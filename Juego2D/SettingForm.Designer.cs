namespace Juego2D
{
    partial class SettingForm
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
            this.buttonBackSetting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBackSetting
            // 
            this.buttonBackSetting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBackSetting.Location = new System.Drawing.Point(63, 194);
            this.buttonBackSetting.Name = "buttonBackSetting";
            this.buttonBackSetting.Size = new System.Drawing.Size(161, 32);
            this.buttonBackSetting.TabIndex = 0;
            this.buttonBackSetting.Text = "Atrás";
            this.buttonBackSetting.UseVisualStyleBackColor = true;
            this.buttonBackSetting.Click += new System.EventHandler(this.buttonBackSetting_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonBackSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBackSetting;
    }
}