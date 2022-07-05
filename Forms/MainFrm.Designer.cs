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
            this.SuspendLayout();
            // 
            // authBtn
            // 
            this.authBtn.Location = new System.Drawing.Point(190, 220);
            this.authBtn.Name = "authBtn";
            this.authBtn.Size = new System.Drawing.Size(135, 23);
            this.authBtn.TabIndex = 0;
            this.authBtn.Text = "button1";
            this.authBtn.UseVisualStyleBackColor = true;
            this.authBtn.Click += new System.EventHandler(this.authBtn_Click);
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(130, 99);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(250, 20);
            this.loginTB.TabIndex = 1;
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(130, 161);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(250, 20);
            this.passTB.TabIndex = 2;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 332);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.authBtn);
            this.Name = "MainFrm";
            this.Text = "TrainTravel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button authBtn;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passTB;
    }
}

