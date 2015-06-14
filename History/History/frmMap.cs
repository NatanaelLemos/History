using History.Controls;
using History.DAO;
using History.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace History
{
    public partial class frmMap : SILIB.View.frmMain
    {
        #region Variáveis
        private List<Pais> _LstPais;
        private List<Periodo> _LstPeriodo;

        private PaisDAO _PaisDAO;
        private PeriodoDAO _PeriodoDAO;

        private PeriodoPais _PeriodoPaisLeft;
        private PeriodoPais _PeriodoPaisRight;

        private Int32 _MapNumber;
        private Int32 _LastMapLeft;
        private Int32 _LastMapTop;

        private Boolean _IsZooming;
        private Boolean _IsMovingMap;
        private ctrImageViewer _ImageViewer;

        //Three-State: Nulo não possui período/país selecionado | true o ultimo período/país selecionado foi o da esqueda | false idem / o da direita
        private Boolean? _LastSideLeft;
        #endregion

        #region PInvoke
        [DllImport("user32.dll")]
        static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("gdi32.dll")]
        static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);
        #endregion

        #region Construtor
        public frmMap()
        {
            //Inicia tudo como nulo
            InitializeComponent();
            _LstPais = new List<Pais>();
            _LstPeriodo = new List<Periodo>();

            _PaisDAO = new PaisDAO();
            _PeriodoDAO = new PeriodoDAO();

            _PeriodoPaisLeft = new PeriodoPais();
            _PeriodoPaisLeft.pais = null;
            _PeriodoPaisLeft.periodo = null;

            _PeriodoPaisRight = new PeriodoPais();
            _PeriodoPaisRight.pais = null;
            _PeriodoPaisRight.periodo = null;

            _LastSideLeft = null;

            //Nos eventos de entrada e saida do mouse na grid da esquerda
            dgvImg1.CellMouseEnter += dgvImg_CellMouseEnter;
            dgvImg1.CellMouseLeave += dgvImg_CellMouseLeave;

            //Nos eventos de entrada e saida do mouse na grid da direita
            dgvImg2.CellMouseEnter += dgvImg_CellMouseEnter;
            dgvImg2.CellMouseLeave += dgvImg_CellMouseLeave;
        }

        private void frmMap_Load(object sender, EventArgs e)
        {
            //Seta a cor dos richtextboxes como a cor do tema
            rtxtDesc1.BackColor = rtxtDesc2.BackColor = this.BackColor;
            _MapNumber = 7;

            LoadCmbPais();
            LoadCmbPeriodo();

            grbImagens1.Visible = false;
            grbImagens2.Visible = false;

            tblDescricao.Visible = false;

            dgvImg1.AutoGenerateColumns = false;
            dgvImg2.AutoGenerateColumns = false;
        }
        #endregion

        #region Métodos
        private void LoadCmbPais()
        {
            //Limpa a combobox de país
            cmbPais.DataSource = null;
            cmbPais.Items.Clear();

            //Carrega a lista de todos os países
            _PaisDAO.FillListPais(_LstPais);
            //E insere uma linha em branco no começo
            _LstPais.Insert(0, new Pais() { codPais = -1, txNomePais = "" });

            cmbPais.DisplayMember = "txNomePais";
            cmbPais.ValueMember = "codPais";
            cmbPais.DataSource = _LstPais;
        }

        private void LoadCmbPeriodo()
        {
            //Limpa a combobox de período
            cmbPeriodo.DataSource = null;
            cmbPeriodo.Items.Clear();

            //Carrega todos os períodos
            _PeriodoDAO.FillListPeriodo(_LstPeriodo);
            //e insere uma linha em branco no começo
            _LstPeriodo.Insert(0, new Periodo() { codPeriodo = -1 });

            cmbPeriodo.DisplayMember = "periodo";
            cmbPeriodo.ValueMember = "codPeriodo";
            cmbPeriodo.DataSource = _LstPeriodo;
        }

        private void LoadContent()
        {
            //Se não tem nem país, nem período selecionado, então sai daqui
            if (cmbPais.SelectedIndex <= 0 || cmbPeriodo.SelectedIndex <= 0) return;

            //Se não tem ultimo lado, ou o ultimo lado for o direito, e tem país e tem período
            if ((_LastSideLeft == null || _LastSideLeft == false) && _PeriodoPaisLeft.pais != null && _PeriodoPaisLeft.periodo != null)
            {
                //Coloca o nome do país no lado esquerdo
                lblPais1.Text = _PeriodoPaisLeft.pais.txNomePais + " " + _PeriodoPaisLeft.periodo.periodo;
                //Exibe a grid de imagens do lado esquerdo
                grbImagens1.Visible = true;
                tblDescricao.Visible = true;

                rtxtDesc1.Text = _PeriodoPaisLeft.Descricao;

                //O ultimo lado agora  é o esquerdo
                _LastSideLeft = true;

                //Carrega as imagens
                dgvImg1.DataSource = null;
                dgvImg1.DataSource = _PeriodoPaisLeft.lstImagens;

                //Carrega todos os países/períodos novamente
                cmbPais.SelectedIndex = 0;
                cmbPeriodo.SelectedIndex = 0;
                LoadCmbPais();
                LoadCmbPeriodo();
            }
            else if (_LastSideLeft == true && _PeriodoPaisRight.pais != null && _PeriodoPaisRight.periodo != null)
            {
                lblPais2.Text = _PeriodoPaisRight.pais.txNomePais + " " + _PeriodoPaisRight.periodo.periodo;
                grbImagens2.Visible = true;
                tblDescricao.Visible = true;
                rtxtDesc2.Text = _PeriodoPaisRight.Descricao;

                _LastSideLeft = false;

                dgvImg2.DataSource = null;
                dgvImg2.DataSource = _PeriodoPaisRight.lstImagens;

                cmbPais.SelectedIndex = 0;
                cmbPeriodo.SelectedIndex = 0;
                LoadCmbPais();
                LoadCmbPeriodo();
            }
        }

        private void ZoomInvoker()
        {
            //Enquanto estiver com o botão de zoom precionado
            while (_IsZooming)
            {
                //Dá zoom
                this.Invoke(new Action(() => Zoom()));
            }
        }

        private void Zoom()
        {
            ptbMap.Top -= 5;
            ptbMap.Left -= 5;
            ptbMap.Height += 10;
            ptbMap.Width += 10;
            System.Threading.Thread.Sleep(30);
            Application.DoEvents();
        }

        private void UnZoomInvoker()
        {
            while (_IsZooming && ptbMap.Height > pnlMapContent.Height && ptbMap.Width > pnlMapContent.Width)
            {
                this.Invoke(new Action(() => UnZoom()));
            }
        }

        private void UnZoom()
        {
            ptbMap.Top += 5;
            ptbMap.Left += 5;
            ptbMap.Height -= 10;
            ptbMap.Width -= 10;
            System.Threading.Thread.Sleep(30);
            Application.DoEvents();
        }
        #endregion

        #region Handlers
        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se possui um país selecionado
            if (cmbPais.SelectedItem != null && cmbPais.SelectedIndex > 0)
            {
                //Atribui o país selecionado para o Model do lado correto:
                //Se não tem ultimo lado, ou o ultimo lado for o direito, então atribui para o lado esquerdo
                if (_LastSideLeft == null || _LastSideLeft == false)
                {
                    _PeriodoPaisLeft.pais = (Pais)cmbPais.SelectedItem;
                }
                //Em caso contrário, atribui o país para o lado direito
                else
                {
                    _PeriodoPaisRight.pais = (Pais)cmbPais.SelectedItem;
                }
                //Carrega os conteúdos
                LoadContent();
            }

            //Se não possui um período selecionado, então carrega todos os períodos do país selecionado
            if ((cmbPeriodo.SelectedItem == null || cmbPeriodo.SelectedIndex <= 0) && cmbPais.SelectedIndex > 0)
            {
                cmbPeriodo.DataSource = null;
                cmbPeriodo.Items.Clear();

                Pais pais = (Pais)cmbPais.SelectedItem;

                _PeriodoDAO.FillListPeriodo(_LstPeriodo, pais.codPais);
                _LstPeriodo.Insert(0, new Periodo() { codPeriodo = -1 });

                cmbPeriodo.DisplayMember = "periodo";
                cmbPeriodo.ValueMember = "codPeriodo";
                cmbPeriodo.DataSource = _LstPeriodo;
            }
        }

        private void cmbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se possui um período selecionado
            if (cmbPeriodo.SelectedItem != null && cmbPeriodo.SelectedIndex > 0)
            {
                //Carrega o período para o lado correto
                if (_LastSideLeft == null || _LastSideLeft == false)
                {
                    _PeriodoPaisLeft.periodo = (Periodo)cmbPeriodo.SelectedItem;
                }
                else
                {
                    _PeriodoPaisRight.periodo = (Periodo)cmbPeriodo.SelectedItem;
                }
                //Carrega o conteúdo
                LoadContent();
            }

            //Se não possui um país, então carrega todos os países do período selecionado
            if ((cmbPais.SelectedItem == null || cmbPais.SelectedIndex <= 0) && cmbPeriodo.SelectedIndex > 0)
            {
                cmbPais.DataSource = null;
                cmbPais.Items.Clear();

                Periodo periodo = (Periodo)cmbPeriodo.SelectedItem;

                _PaisDAO.FillListPais(_LstPais, periodo.codPeriodo);
                _LstPais.Insert(0, new Pais() { codPais = -1 });

                cmbPais.DisplayMember = "txNomePais";
                cmbPais.ValueMember = "codPais";
                cmbPais.DataSource = _LstPais;
            }

            //Troca o mapa de acordo com o período informado
            if (cmbPeriodo.SelectedIndex > 0)
            {
                Periodo periodo = (Periodo)cmbPeriodo.SelectedItem;

                if (periodo.dtInicialPeriodo < 1485)
                {
                    _MapNumber = 0;
                    ptbMap.BackgroundImage = Properties.Resources.map1452;
                }
                else if (periodo.dtInicialPeriodo < 1581)
                {
                    _MapNumber = 1;
                    ptbMap.BackgroundImage = Properties.Resources.map1485;
                }
                else if (periodo.dtInicialPeriodo < 1603)
                {
                    _MapNumber = 2;
                    ptbMap.BackgroundImage = Properties.Resources.map1581;
                }
                else if (periodo.dtInicialPeriodo < 1640)
                {
                    _MapNumber = 3;
                    ptbMap.BackgroundImage = Properties.Resources.map1603;
                }
                else if (periodo.dtInicialPeriodo < 1700)
                {
                    _MapNumber = 4;
                    ptbMap.BackgroundImage = Properties.Resources.map1640;
                }
                else if (periodo.dtInicialPeriodo < 1740)
                {
                    _MapNumber = 5;
                    ptbMap.BackgroundImage = Properties.Resources.map1700;
                }
                else if (periodo.dtInicialPeriodo < 1789)
                {
                    _MapNumber = 6;
                    ptbMap.BackgroundImage = Properties.Resources.map1740;
                }
                else
                {
                    _MapNumber = 7;
                    ptbMap.BackgroundImage = Properties.Resources.map1789;
                }
            }
        }

        /// <summary>
        /// Evento de entrada do mouse em uma gridview
        /// </summary>
        void dgvImg_CellMouseEnter(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            //Se não tem datasource ou não tem linhas, então sai daqui
            if (((DataGridView)sender).DataSource == null) return;
            if (((DataGridView)sender).Rows[e.RowIndex] == null) return;

            //Cria um novo popup de visualização de imagem
            _ImageViewer = new ctrImageViewer();
            //Se for da grid do lado esquerdo, então pega o index da imagem selecionada no lado esquerdo
            Imagem img = ((DataGridView)sender).Name == "dgvImg1" ? _PeriodoPaisLeft.lstImagens[e.RowIndex] : _PeriodoPaisRight.lstImagens[e.RowIndex];

            _ImageViewer.Title = img.txNomeImagem;
            _ImageViewer.Description = img.txDescricaoImagem;
            _ImageViewer.Image = img.image;

            //Atribui a posição de exibição
            _ImageViewer.Left = ((DataGridView)sender).Name == "dgvImg1" ? (this.Left + grbImagens1.Width) : ((this.Left + grbImagens2.Left) - _ImageViewer.Width);
            _ImageViewer.Top = System.Windows.Forms.Control.MousePosition.Y;

            _ImageViewer.Show();
        }

        void dgvImg_CellMouseLeave(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            //Quando o mouse sai da grid, então elimina o componente de immagem
            if (_ImageViewer != null && !_ImageViewer.IsDisposed) _ImageViewer.Dispose();
        }

        private void btnZoomUp_MouseDown(object sender, MouseEventArgs e)
        {
            //Ao apertar o mouse em cima do botão de zoom (click + segura o botão esquerdo)
            _IsZooming = true;

            //Inicia uma thread que faz o redimensionamento da imagem
            Thread LZoomThread = new Thread(ZoomInvoker);
            LZoomThread.Start();
        }

        private void btnZoomUp_MouseUp(object sender, MouseEventArgs e)
        {
            //Ao parar de precionar o botão de zoom, para a thread de zoom
            _IsZooming = false;
        }

        private void btnZoomDown_MouseDown(object sender, MouseEventArgs e)
        {
            _IsZooming = true;

            Thread LZoomThread = new Thread(UnZoomInvoker);
            LZoomThread.Start();
        }

        private void btnZoomDown_MouseUp(object sender, MouseEventArgs e)
        {
            _IsZooming = false;

            if (ptbMap.Height <= pnlMapContent.Height || ptbMap.Width <= pnlMapContent.Width)
            {
                ptbMap.Height = pnlMapContent.Height;
                ptbMap.Width = pnlMapContent.Width;

                ptbMap.Top = ptbMap.Left = 0;
            }
        }

        private void ptbMap_MouseDown(object sender, MouseEventArgs e)
        {
            _LastMapLeft = ptbMap.Left;
            _LastMapTop = ptbMap.Top;

            if (ptbMap.Height > pnlMapContent.Height && ptbMap.Width > pnlMapContent.Width)
            {
                _IsMovingMap = true;
                ptbMap.Cursor = Cursors.Hand;
            }
        }

        private void ptbMap_MouseMove(object sender, MouseEventArgs e)
        {
            if (_IsMovingMap)
            {
                Int32 xPos = (Cursor.Position.X - pnlMapContent.Left - (ptbMap.Width / 2)) - this.Left;
                Int32 yPos = (Cursor.Position.Y - pnlMapContent.Top - (ptbMap.Height / 2)) - this.Top;

                ptbMap.Location = new System.Drawing.Point(xPos, yPos);
            }
        }

        private void ptbMap_MouseUp(object sender, MouseEventArgs e)
        {
            _IsMovingMap = false;
            ptbMap.Cursor = Cursors.Default;

            if (ptbMap.Left != _LastMapLeft) return;
            if (ptbMap.Top != _LastMapTop) return;

            SelectPaisUnderMouse();
        }

        private void SelectPaisUnderMouse()
        {
            if (cmbPeriodo.Text != "") return;

            String colorName = GetPixelColor(Cursor.Position.X, Cursor.Position.Y).Name;

            switch (_MapNumber)
            {
                case 0:
                    switch (colorName)
                    {
                        case "fffd5764":
                            cmbPais.Text = "Inglaterra";
                            break;
                        case "ffacfdd0":
                            cmbPais.Text = "França";
                            break;
                        case "ffebf291":
                            cmbPais.Text = "Espanha";
                            break;
                        case "fff28e8c":
                            cmbPais.Text = "Portugal";
                            break;
                        case "fff291e0":
                            cmbPais.Text = "Itália";
                            break;
                    }
                    break;
                case 1:
                    switch (colorName)
                    {
                        case "fffd5764":
                            cmbPais.Text = "Inglaterra";
                            break;
                        case "ffacfdd0":
                            cmbPais.Text = "França";
                            break;
                        case "fffce965":
                            cmbPais.Text = "Espanha";
                            break;
                        case "fff28e8c":
                            cmbPais.Text = "Portugal";
                            break;
                        case "fff291e0":
                            cmbPais.Text = "Itália";
                            break;
                    }
                    break;
                case 2:
                    switch (colorName)
                    {
                        case "fffd5764":
                            cmbPais.Text = "Inglaterra";
                            break;
                        case "ffacfdd0":
                            cmbPais.Text = "França";
                            break;
                        case "fffce965":
                            cmbPais.Text = "Espanha";
                            break;
                        case "fff28e8c":
                            cmbPais.Text = "Portugal";
                            break;
                        case "fff291e0":
                            cmbPais.Text = "Itália";
                            break;
                    }
                    break;
                case 3:
                    switch (colorName)
                    {
                        case "fffd5764":
                            cmbPais.Text = "Inglaterra";
                            break;
                        case "ffacfdd0":
                            cmbPais.Text = "França";
                            break;
                        case "fffce965":
                            cmbPais.Text = "Espanha";
                            break;
                        case "fff28e8c":
                            cmbPais.Text = "Portugal";
                            break;
                        case "fff291e0":
                            cmbPais.Text = "Itália";
                            break;
                    }
                    break;
                case 4:
                    switch (colorName)
                    {
                        case "fffd5764":
                            cmbPais.Text = "Inglaterra";
                            break;
                        case "ffacfdd0":
                            cmbPais.Text = "França";
                            break;
                        case "fffce965":
                            cmbPais.Text = "Espanha";
                            break;
                        case "fff28e8c":
                            cmbPais.Text = "Portugal";
                            break;
                        case "fff291e0":
                            cmbPais.Text = "Itália";
                            break;
                    }
                    break;
                case 5:
                    switch (colorName)
                    {
                        case "ffea4264":
                            cmbPais.Text = "Inglaterra";
                            break;
                        case "ffacfdd0":
                            cmbPais.Text = "França";
                            break;
                        case "fffce965":
                            cmbPais.Text = "Espanha";
                            break;
                        case "fff28e8c":
                            cmbPais.Text = "Portugal";
                            break;
                        case "fff291e0":
                            cmbPais.Text = "Itália";
                            break;
                    }
                    break;
                case 6:
                    switch (colorName)
                    {
                        case "ffea4264":
                            cmbPais.Text = "Inglaterra";
                            break;
                        case "ffacfdd0":
                            cmbPais.Text = "França";
                            break;
                        case "fffce965":
                            cmbPais.Text = "Espanha";
                            break;
                        case "fff28e8c":
                            cmbPais.Text = "Portugal";
                            break;
                        case "ffa3deab":
                            cmbPais.Text = "Itália";
                            break;
                    }
                    break;
                case 7:
                    switch (colorName)
                    {
                        case "ffea4264":
                            cmbPais.Text = "Inglaterra";
                            break;
                        case "ffacfdd0":
                            cmbPais.Text = "França";
                            break;
                        case "fffce965":
                            cmbPais.Text = "Espanha";
                            break;
                        case "fff28e8c":
                            cmbPais.Text = "Portugal";
                            break;
                        case "ffa3deab":
                            cmbPais.Text = "Itália";
                            break;
                    }
                    break;
            }
        }

        private Color GetPixelColor(int x, int y)
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hdc, x, y);
            ReleaseDC(IntPtr.Zero, hdc);
            Color color = Color.FromArgb((int)(pixel & 0x000000FF),
                         (int)(pixel & 0x0000FF00) >> 8,
                         (int)(pixel & 0x00FF0000) >> 16);
            return color;
        }
        #endregion
    }
}
