namespace TrainTravelApp
{
    partial class MainFrm
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
            this.authBtn = new System.Windows.Forms.Button();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passTB = new System.Windows.Forms.TextBox();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authBtn
            // 
            this.authBtn.Location = new System.Drawing.Point(253, 271);
            this.authBtn.Margin = new System.Windows.Forms.Padding(4);
            this.authBtn.Name = "authBtn";
            this.authBtn.Size = new System.Drawing.Size(180, 28);
            this.authBtn.TabIndex = 0;
            this.authBtn.Text = "button1";
            this.authBtn.UseVisualStyleBackColor = true;
            this.authBtn.Click += new System.EventHandler(this.authBtn_Click);
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(173, 122);
            this.loginTB.Margin = new System.Windows.Forms.Padding(4);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(332, 22);
            this.loginTB.TabIndex = 1;
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(173, 198);
            this.passTB.Margin = new System.Windows.Forms.Padding(4);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(332, 22);
            this.passTB.TabIndex = 2;
            // 
            // settingsBtn
            // 
            this.settingsBtn.Location = new System.Drawing.Point(0, 0);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(75, 23);
            this.settingsBtn.TabIndex = 3;
            this.settingsBtn.Text = "Настройки";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 409);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.authBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainFrm";
            this.Text = "TrainTravel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button authBtn;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.Button settingsBtn;
    }
}

