namespace db_project
{
    partial class ChangePassword
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
            this.currentPassword_L = new System.Windows.Forms.Label();
            this.currentPass_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newPass_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.confrmPass_text = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentPassword_L
            // 
            this.currentPassword_L.AutoSize = true;
            this.currentPassword_L.Location = new System.Drawing.Point(98, 64);
            this.currentPassword_L.Name = "currentPassword_L";
            this.currentPassword_L.Size = new System.Drawing.Size(93, 13);
            this.currentPassword_L.TabIndex = 0;
            this.currentPassword_L.Text = "&Current Password:";
            // 
            // currentPass_text
            // 
            this.currentPass_text.Location = new System.Drawing.Point(198, 61);
            this.currentPass_text.Name = "currentPass_text";
            this.currentPass_text.Size = new System.Drawing.Size(100, 20);
            this.currentPass_text.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "&New Password:";
            // 
            // newPass_text
            // 
            this.newPass_text.Location = new System.Drawing.Point(198, 113);
            this.newPass_text.Name = "newPass_text";
            this.newPass_text.Size = new System.Drawing.Size(100, 20);
            this.newPass_text.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "&Confrm Password:";
            // 
            // confrmPass_text
            // 
            this.confrmPass_text.Location = new System.Drawing.Point(198, 166);
            this.confrmPass_text.Name = "confrmPass_text";
            this.confrmPass_text.Size = new System.Drawing.Size(100, 20);
            this.confrmPass_text.TabIndex = 3;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(94, 249);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 4;
            this.save_button.Text = "&Save";
            this.save_button.UseVisualStyleBackColor = true;
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(247, 249);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 5;
            this.cancel_button.Text = "&Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 348);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.confrmPass_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newPass_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentPass_text);
            this.Controls.Add(this.currentPassword_L);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentPassword_L;
        private System.Windows.Forms.TextBox currentPass_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newPass_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confrmPass_text;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button cancel_button;
    }
}