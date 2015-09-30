namespace Juego2D
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonExitGame = new System.Windows.Forms.Button();
            this.botonJugar = new System.Windows.Forms.Button();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExitGame
            // 
            this.buttonExitGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExitGame.Location = new System.Drawing.Point(68, 189);
            this.buttonExitGame.Name = "buttonExitGame";
            this.buttonExitGame.Size = new System.Drawing.Size(161, 32);
            this.buttonExitGame.TabIndex = 0;
            this.buttonExitGame.Text = "Salir del juego";
            this.buttonExitGame.UseVisualStyleBackColor = true;
            this.buttonExitGame.Click += new System.EventHandler(this.buttonExitGame_Click);
            // 
            // botonJugar
            // 
            this.botonJugar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonJugar.Location = new System.Drawing.Point(68, 113);
            this.botonJugar.Name = "botonJugar";
            this.botonJugar.Size = new System.Drawing.Size(161, 32);
            this.botonJugar.TabIndex = 1;
            this.botonJugar.Text = "Jugar";
            this.botonJugar.UseVisualStyleBackColor = true;
            this.botonJugar.Click += new System.EventHandler(this.botonJugar_Click);
            // 
            // buttonSetting
            // 
            this.buttonSetting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSetting.Location = new System.Drawing.Point(68, 151);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(161, 32);
            this.buttonSetting.TabIndex = 2;
            this.buttonSetting.Text = "Opciones";
            this.buttonSetting.UseVisualStyleBackColor = true;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonSetting);
            this.Controls.Add(this.botonJugar);
            this.Controls.Add(this.buttonExitGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExitGame;
        private System.Windows.Forms.Button botonJugar;
        private System.Windows.Forms.Button buttonSetting;
    }
}

