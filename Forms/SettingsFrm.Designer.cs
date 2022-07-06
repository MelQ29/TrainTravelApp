namespace TrainTravelApp.Forms
{
    partial class SettingsFrm
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
            this.rusBtn = new System.Windows.Forms.Button();
            this.engBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rusBtn
            // 
            this.rusBtn.Location = new System.Drawing.Point(80, 183);
            this.rusBtn.Name = "rusBtn";
            this.rusBtn.Size = new System.Drawing.Size(75, 23);
            this.rusBtn.TabIndex = 0;
            this.rusBtn.Text = "РУС";
            this.rusBtn.UseVisualStyleBackColor = true;
            // 
            // engBtn
            // 
            this.engBtn.Location = new System.Drawing.Point(80, 240);
            this.engBtn.Name = "engBtn";
            this.engBtn.Size = new System.Drawing.Size(75, 23);
            this.engBtn.TabIndex = 1;
            this.engBtn.Text = "АНГЛ";
            this.engBtn.UseVisualStyleBackColor = true;
            this.engBtn.Click += new System.EventHandler(this.engBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(66, 385);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(116, 23);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // SettingsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 450);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.engBtn);
            this.Controls.Add(this.rusBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingsFrm";
            this.Text = "Настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsFrm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rusBtn;
        private System.Windows.Forms.Button engBtn;
        private System.Windows.Forms.Button saveBtn;
    }
}