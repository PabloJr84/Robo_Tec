namespace Robo_Tec
{
    partial class Robo_Form
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
            this.Btn_acessar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_acessar
            // 
            this.Btn_acessar.Location = new System.Drawing.Point(12, 50);
            this.Btn_acessar.Name = "Btn_acessar";
            this.Btn_acessar.Size = new System.Drawing.Size(75, 23);
            this.Btn_acessar.TabIndex = 0;
            this.Btn_acessar.Text = "Acessar";
            this.Btn_acessar.UseVisualStyleBackColor = true;
            this.Btn_acessar.Click += new System.EventHandler(this.Btn_acessar_Click);
            // 
            // Robo_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_acessar);
            this.Name = "Robo_Form";
            this.Text = "Robô Tec";
            this.Load += new System.EventHandler(this.Robo_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_acessar;
    }
}

