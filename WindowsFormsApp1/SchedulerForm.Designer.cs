namespace WindowsFormsApp1
{
    partial class SCH001
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SCH001));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pista10 = new System.Windows.Forms.PictureBox();
            this.Pista15 = new System.Windows.Forms.PictureBox();
            this.PistaDecolagem = new System.Windows.Forms.PictureBox();
            this.PistaPouso = new System.Windows.Forms.PictureBox();
            this.Pista20 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pista10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pista15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PistaDecolagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PistaPouso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pista20)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Pista10);
            this.panel1.Controls.Add(this.Pista15);
            this.panel1.Controls.Add(this.PistaDecolagem);
            this.panel1.Controls.Add(this.PistaPouso);
            this.panel1.Controls.Add(this.Pista20);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 283);
            this.panel1.TabIndex = 0;
            // 
            // Pista10
            // 
            this.Pista10.Image = ((System.Drawing.Image)(resources.GetObject("Pista10.Image")));
            this.Pista10.Location = new System.Drawing.Point(3, 116);
            this.Pista10.Name = "Pista10";
            this.Pista10.Size = new System.Drawing.Size(768, 50);
            this.Pista10.TabIndex = 6;
            this.Pista10.TabStop = false;
            // 
            // Pista15
            // 
            this.Pista15.Image = ((System.Drawing.Image)(resources.GetObject("Pista15.Image")));
            this.Pista15.Location = new System.Drawing.Point(3, 60);
            this.Pista15.Name = "Pista15";
            this.Pista15.Size = new System.Drawing.Size(768, 50);
            this.Pista15.TabIndex = 5;
            this.Pista15.TabStop = false;
            // 
            // PistaDecolagem
            // 
            this.PistaDecolagem.Image = ((System.Drawing.Image)(resources.GetObject("PistaDecolagem.Image")));
            this.PistaDecolagem.Location = new System.Drawing.Point(4, 228);
            this.PistaDecolagem.Name = "PistaDecolagem";
            this.PistaDecolagem.Size = new System.Drawing.Size(768, 50);
            this.PistaDecolagem.TabIndex = 4;
            this.PistaDecolagem.TabStop = false;
            // 
            // PistaPouso
            // 
            this.PistaPouso.Image = ((System.Drawing.Image)(resources.GetObject("PistaPouso.Image")));
            this.PistaPouso.Location = new System.Drawing.Point(4, 172);
            this.PistaPouso.Name = "PistaPouso";
            this.PistaPouso.Size = new System.Drawing.Size(768, 50);
            this.PistaPouso.TabIndex = 3;
            this.PistaPouso.TabStop = false;
            // 
            // Pista20
            // 
            this.Pista20.Image = ((System.Drawing.Image)(resources.GetObject("Pista20.Image")));
            this.Pista20.Location = new System.Drawing.Point(4, 4);
            this.Pista20.Name = "Pista20";
            this.Pista20.Size = new System.Drawing.Size(768, 50);
            this.Pista20.TabIndex = 0;
            this.Pista20.TabStop = false;
            // 
            // SCH001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 307);
            this.Controls.Add(this.panel1);
            this.Name = "SCH001";
            this.Text = "Scheduler SISOP";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pista10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pista15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PistaDecolagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PistaPouso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pista20)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PistaDecolagem;
        private System.Windows.Forms.PictureBox Pista20;
        private System.Windows.Forms.PictureBox Pista10;
        private System.Windows.Forms.PictureBox Pista15;
        private System.Windows.Forms.PictureBox PistaPouso;
    }
}

