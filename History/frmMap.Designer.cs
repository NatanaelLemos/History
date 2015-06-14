namespace History
{
    partial class frmMap : SILIB.View.frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMap));
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.tblDescricao = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rtxtDesc2 = new System.Windows.Forms.RichTextBox();
            this.lblPais2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtxtDesc1 = new System.Windows.Forms.RichTextBox();
            this.lblPais1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlZoom = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnZoomDown = new System.Windows.Forms.Button();
            this.btnZoomUp = new System.Windows.Forms.Button();
            this.pnlMapContent = new System.Windows.Forms.Panel();
            this.ptbMap = new System.Windows.Forms.PictureBox();
            this.grbImagens1 = new System.Windows.Forms.GroupBox();
            this.dgvImg1 = new System.Windows.Forms.DataGridView();
            this.colimage = new System.Windows.Forms.DataGridViewImageColumn();
            this.grbImagens2 = new System.Windows.Forms.GroupBox();
            this.dgvImg2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnConfiguracoes = new System.Windows.Forms.MenuStrip();
            this.mnuConfiguracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.tblDescricao.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlZoom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlMapContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMap)).BeginInit();
            this.grbImagens1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImg1)).BeginInit();
            this.grbImagens2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImg2)).BeginInit();
            this.btnConfiguracoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlResizeRight
            // 
            this.pnlResizeRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.pnlResizeRight.ForeColor = System.Drawing.Color.White;
            this.pnlResizeRight.Size = new System.Drawing.Size(6, 565);
            // 
            // cmbPais
            // 
            this.cmbPais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(81, 3);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(171, 24);
            this.cmbPais.TabIndex = 6;
            this.cmbPais.SelectedIndexChanged += new System.EventHandler(this.cmbPais_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "País:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(268, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Período:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(346, 3);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(173, 24);
            this.cmbPeriodo.TabIndex = 8;
            this.cmbPeriodo.SelectedIndexChanged += new System.EventHandler(this.cmbPeriodo_SelectedIndexChanged);
            // 
            // tblDescricao
            // 
            this.tblDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.tblDescricao.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblDescricao.ColumnCount = 2;
            this.tblDescricao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDescricao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDescricao.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblDescricao.Controls.Add(this.panel3, 1, 0);
            this.tblDescricao.Controls.Add(this.panel2, 0, 0);
            this.tblDescricao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblDescricao.ForeColor = System.Drawing.Color.White;
            this.tblDescricao.Location = new System.Drawing.Point(6, 383);
            this.tblDescricao.Margin = new System.Windows.Forms.Padding(0);
            this.tblDescricao.Name = "tblDescricao";
            this.tblDescricao.Padding = new System.Windows.Forms.Padding(1);
            this.tblDescricao.RowCount = 1;
            this.tblDescricao.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDescricao.Size = new System.Drawing.Size(953, 214);
            this.tblDescricao.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.panel3.Controls.Add(this.rtxtDesc2);
            this.panel3.Controls.Add(this.lblPais2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(480, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(468, 204);
            this.panel3.TabIndex = 3;
            // 
            // rtxtDesc2
            // 
            this.rtxtDesc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.rtxtDesc2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtDesc2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtDesc2.Font = new System.Drawing.Font("Arial", 12F);
            this.rtxtDesc2.ForeColor = System.Drawing.Color.White;
            this.rtxtDesc2.Location = new System.Drawing.Point(0, 23);
            this.rtxtDesc2.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.rtxtDesc2.Name = "rtxtDesc2";
            this.rtxtDesc2.ReadOnly = true;
            this.rtxtDesc2.Size = new System.Drawing.Size(468, 181);
            this.rtxtDesc2.TabIndex = 0;
            this.rtxtDesc2.Text = "";
            // 
            // lblPais2
            // 
            this.lblPais2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.lblPais2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPais2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais2.ForeColor = System.Drawing.Color.White;
            this.lblPais2.Location = new System.Drawing.Point(0, 0);
            this.lblPais2.Name = "lblPais2";
            this.lblPais2.Size = new System.Drawing.Size(468, 23);
            this.lblPais2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.panel2.Controls.Add(this.rtxtDesc1);
            this.panel2.Controls.Add(this.lblPais1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 204);
            this.panel2.TabIndex = 2;
            // 
            // rtxtDesc1
            // 
            this.rtxtDesc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.rtxtDesc1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtDesc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtDesc1.Font = new System.Drawing.Font("Arial", 12F);
            this.rtxtDesc1.ForeColor = System.Drawing.Color.White;
            this.rtxtDesc1.Location = new System.Drawing.Point(0, 23);
            this.rtxtDesc1.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.rtxtDesc1.Name = "rtxtDesc1";
            this.rtxtDesc1.ReadOnly = true;
            this.rtxtDesc1.Size = new System.Drawing.Size(468, 181);
            this.rtxtDesc1.TabIndex = 0;
            this.rtxtDesc1.Text = "";
            // 
            // lblPais1
            // 
            this.lblPais1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.lblPais1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPais1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais1.ForeColor = System.Drawing.Color.White;
            this.lblPais1.Location = new System.Drawing.Point(0, 0);
            this.lblPais1.Name = "lblPais1";
            this.lblPais1.Size = new System.Drawing.Size(468, 23);
            this.lblPais1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnlZoom, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pnlMapContent, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(156, 32);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.84615F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.15385F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(653, 351);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbPais, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbPeriodo, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(65, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(522, 26);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pnlZoom
            // 
            this.pnlZoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.pnlZoom.Controls.Add(this.panel1);
            this.pnlZoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlZoom.ForeColor = System.Drawing.Color.White;
            this.pnlZoom.Location = new System.Drawing.Point(3, 29);
            this.pnlZoom.Name = "pnlZoom";
            this.pnlZoom.Size = new System.Drawing.Size(59, 57);
            this.pnlZoom.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.btnZoomDown);
            this.panel1.Controls.Add(this.btnZoomUp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(23, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(36, 57);
            this.panel1.TabIndex = 3;
            // 
            // btnZoomDown
            // 
            this.btnZoomDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnZoomDown.FlatAppearance.BorderSize = 0;
            this.btnZoomDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomDown.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomDown.Location = new System.Drawing.Point(0, 34);
            this.btnZoomDown.Name = "btnZoomDown";
            this.btnZoomDown.Size = new System.Drawing.Size(36, 23);
            this.btnZoomDown.TabIndex = 1;
            this.btnZoomDown.Text = "-";
            this.btnZoomDown.UseVisualStyleBackColor = true;
            this.btnZoomDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZoomDown_MouseDown);
            this.btnZoomDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnZoomDown_MouseUp);
            // 
            // btnZoomUp
            // 
            this.btnZoomUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnZoomUp.FlatAppearance.BorderSize = 0;
            this.btnZoomUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomUp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomUp.Location = new System.Drawing.Point(0, 0);
            this.btnZoomUp.Name = "btnZoomUp";
            this.btnZoomUp.Size = new System.Drawing.Size(36, 23);
            this.btnZoomUp.TabIndex = 0;
            this.btnZoomUp.Text = "+";
            this.btnZoomUp.UseVisualStyleBackColor = true;
            this.btnZoomUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZoomUp_MouseDown);
            this.btnZoomUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnZoomUp_MouseUp);
            // 
            // pnlMapContent
            // 
            this.pnlMapContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.pnlMapContent.Controls.Add(this.ptbMap);
            this.pnlMapContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMapContent.ForeColor = System.Drawing.Color.White;
            this.pnlMapContent.Location = new System.Drawing.Point(68, 29);
            this.pnlMapContent.Name = "pnlMapContent";
            this.pnlMapContent.Size = new System.Drawing.Size(516, 285);
            this.pnlMapContent.TabIndex = 3;
            // 
            // ptbMap
            // 
            this.ptbMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMap.BackColor = System.Drawing.Color.White;
            this.ptbMap.BackgroundImage = global::History.Properties.Resources.map1789;
            this.ptbMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbMap.Location = new System.Drawing.Point(3, 4);
            this.ptbMap.Name = "ptbMap";
            this.ptbMap.Size = new System.Drawing.Size(513, 278);
            this.ptbMap.TabIndex = 0;
            this.ptbMap.TabStop = false;
            this.ptbMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ptbMap_MouseDown);
            this.ptbMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptbMap_MouseMove);
            this.ptbMap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptbMap_MouseUp);
            // 
            // grbImagens1
            // 
            this.grbImagens1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.grbImagens1.Controls.Add(this.dgvImg1);
            this.grbImagens1.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbImagens1.Font = new System.Drawing.Font("Arial", 10F);
            this.grbImagens1.ForeColor = System.Drawing.Color.White;
            this.grbImagens1.Location = new System.Drawing.Point(6, 32);
            this.grbImagens1.Name = "grbImagens1";
            this.grbImagens1.Size = new System.Drawing.Size(150, 351);
            this.grbImagens1.TabIndex = 15;
            this.grbImagens1.TabStop = false;
            this.grbImagens1.Text = "Imagens";
            // 
            // dgvImg1
            // 
            this.dgvImg1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.dgvImg1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvImg1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvImg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImg1.ColumnHeadersVisible = false;
            this.dgvImg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colimage});
            this.dgvImg1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImg1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvImg1.Location = new System.Drawing.Point(3, 19);
            this.dgvImg1.Name = "dgvImg1";
            this.dgvImg1.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvImg1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvImg1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvImg1.RowTemplate.Height = 144;
            this.dgvImg1.Size = new System.Drawing.Size(144, 329);
            this.dgvImg1.TabIndex = 0;
            // 
            // colimage
            // 
            this.colimage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colimage.DataPropertyName = "image";
            this.colimage.HeaderText = "";
            this.colimage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colimage.Name = "colimage";
            // 
            // grbImagens2
            // 
            this.grbImagens2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.grbImagens2.Controls.Add(this.dgvImg2);
            this.grbImagens2.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbImagens2.Font = new System.Drawing.Font("Arial", 10F);
            this.grbImagens2.ForeColor = System.Drawing.Color.White;
            this.grbImagens2.Location = new System.Drawing.Point(809, 32);
            this.grbImagens2.Name = "grbImagens2";
            this.grbImagens2.Size = new System.Drawing.Size(150, 351);
            this.grbImagens2.TabIndex = 16;
            this.grbImagens2.TabStop = false;
            this.grbImagens2.Text = "Imagens";
            // 
            // dgvImg2
            // 
            this.dgvImg2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.dgvImg2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvImg2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvImg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImg2.ColumnHeadersVisible = false;
            this.dgvImg2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1});
            this.dgvImg2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImg2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvImg2.Location = new System.Drawing.Point(3, 19);
            this.dgvImg2.Name = "dgvImg2";
            this.dgvImg2.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvImg2.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvImg2.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvImg2.RowTemplate.Height = 144;
            this.dgvImg2.Size = new System.Drawing.Size(144, 329);
            this.dgvImg2.TabIndex = 1;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.DataPropertyName = "image";
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfiguracoes.AutoSize = false;
            this.btnConfiguracoes.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConfiguracoes.Dock = System.Windows.Forms.DockStyle.None;
            this.btnConfiguracoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConfiguracoes});
            this.btnConfiguracoes.Location = new System.Drawing.Point(820, -4);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(42, 35);
            this.btnConfiguracoes.TabIndex = 2;
            // 
            // mnuConfiguracoes
            // 
            this.mnuConfiguracoes.AutoSize = false;
            this.mnuConfiguracoes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuConfiguracoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSobre});
            this.mnuConfiguracoes.Image = global::History.Properties.Resources.Settings_01;
            this.mnuConfiguracoes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuConfiguracoes.Name = "mnuConfiguracoes";
            this.mnuConfiguracoes.Size = new System.Drawing.Size(33, 31);
            // 
            // mnuSobre
            // 
            this.mnuSobre.Name = "mnuSobre";
            this.mnuSobre.Size = new System.Drawing.Size(104, 22);
            this.mnuSobre.Text = "Sobre";
            this.mnuSobre.Click += new System.EventHandler(this.mnuSobre_Click);
            // 
            // frmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(965, 603);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.grbImagens2);
            this.Controls.Add(this.grbImagens1);
            this.Controls.Add(this.tblDescricao);
            this.Controls.Add(this.btnConfiguracoes);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = SIFormBorderStyle.Sizable;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.Name = "frmMap";
            this.ShowTitle = true;
            this.Text = "History";
            this.ThemeColor = SILIB.View.ThemeColors.Blue;
            this.Load += new System.EventHandler(this.frmMap_Load);
            this.Controls.SetChildIndex(this.btnConfiguracoes, 0);
            this.Controls.SetChildIndex(this.pnlResizeRight, 0);
            this.Controls.SetChildIndex(this.tblDescricao, 0);
            this.Controls.SetChildIndex(this.grbImagens1, 0);
            this.Controls.SetChildIndex(this.grbImagens2, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            this.tblDescricao.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlZoom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlMapContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbMap)).EndInit();
            this.grbImagens1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImg1)).EndInit();
            this.grbImagens2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImg2)).EndInit();
            this.btnConfiguracoes.ResumeLayout(false);
            this.btnConfiguracoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.TableLayoutPanel tblDescricao;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox ptbMap;
        private System.Windows.Forms.GroupBox grbImagens1;
        private System.Windows.Forms.GroupBox grbImagens2;
        private System.Windows.Forms.RichTextBox rtxtDesc1;
        private System.Windows.Forms.DataGridView dgvImg1;
        private System.Windows.Forms.DataGridViewImageColumn colimage;
        private System.Windows.Forms.DataGridView dgvImg2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlZoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnZoomDown;
        private System.Windows.Forms.Button btnZoomUp;
        private System.Windows.Forms.Panel pnlMapContent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox rtxtDesc2;
        private System.Windows.Forms.Label lblPais2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPais1;
        private System.Windows.Forms.MenuStrip btnConfiguracoes;
        private System.Windows.Forms.ToolStripMenuItem mnuConfiguracoes;
        private System.Windows.Forms.ToolStripMenuItem mnuSobre;


    }
}
