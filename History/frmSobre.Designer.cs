namespace History
{
    partial class frmSobre
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
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lklGnuGpl = new System.Windows.Forms.LinkLabel();
            this.lklGitHub = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Arial", 12F);
            this.btnOk.Location = new System.Drawing.Point(287, 315);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(98, 33);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sobre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 89);
            this.label2.TabIndex = 2;
            this.label2.Text = "Projeto de Iniciação Científica\r\nDesenvolvido por Natanael Tavares Lemos\r\nOrienta" +
    "do pelo Prof. Dr. Paulo Edson Alves Filho\r\n02/2013-02/2014";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(397, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sistema de Ensino de História";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "2014 - FATEC Sorocaba";
            // 
            // lklGnuGpl
            // 
            this.lklGnuGpl.Font = new System.Drawing.Font("Arial", 8F);
            this.lklGnuGpl.Location = new System.Drawing.Point(92, 198);
            this.lklGnuGpl.Name = "lklGnuGpl";
            this.lklGnuGpl.Size = new System.Drawing.Size(293, 36);
            this.lklGnuGpl.TabIndex = 5;
            this.lklGnuGpl.TabStop = true;
            this.lklGnuGpl.Text = "Este é um software livre, você pode redistrubuí-lo e/ou modificá-lo sob os termos" +
    " da Licença Pública GNU/GPL";
            this.lklGnuGpl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lklGnuGpl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklGnuGpl_LinkClicked);
            // 
            // lklGitHub
            // 
            this.lklGitHub.Font = new System.Drawing.Font("Arial", 8F);
            this.lklGitHub.Location = new System.Drawing.Point(79, 245);
            this.lklGitHub.Name = "lklGitHub";
            this.lklGitHub.Size = new System.Drawing.Size(306, 36);
            this.lklGitHub.TabIndex = 6;
            this.lklGitHub.TabStop = true;
            this.lklGitHub.Text = "Todo o código-fonte deste software pode ser encontrado em: [https://github.com/Na" +
    "tanaelLemos/History/tree/commit]";
            this.lklGitHub.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lklGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklGitHub_LinkClicked);
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(397, 360);
            this.Controls.Add(this.lklGitHub);
            this.Controls.Add(this.lklGnuGpl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSobre";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSobre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lklGnuGpl;
        private System.Windows.Forms.LinkLabel lklGitHub;
    }
}