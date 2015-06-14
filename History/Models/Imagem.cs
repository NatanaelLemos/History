using System;
using System.Drawing;
using System.Windows.Forms;

namespace History.Models
{
    public class Imagem
    {
        public Int32 codImagem { get; set; }
        public String txNomeImagem { get; set; }
        public String txDescricaoImagem { get; set; }
        public Int32 codPerPais { get; set; }
        public String txEnderecoImg { get; set; }

        public Image image
        {
            get
            {
                String caminhoAbsoluto = Application.StartupPath  + "\\Resources\\" + txEnderecoImg;
                return Image.FromFile(caminhoAbsoluto);
            }
        }
    }
}
