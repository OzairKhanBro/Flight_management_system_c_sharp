namespace db_project
{
    partial class Plane_details
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
            this.cancel_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstName_lable = new System.Windows.Forms.Label();
            this.max_pass_text = new System.Windows.Forms.TextBox();
            this.compeny_name = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.plane_id_text = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.condition_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(410, 390);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 7;
            this.cancel_button.Text = "&Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(242, 390);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 6;
            this.save_button.Text = "&Save";
            this.save_button.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "&Max Passengers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "&Company:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "&Model:";
            // 
            // FirstName_lable
            // 
            this.FirstName_lable.AutoSize = true;
            this.FirstName_lable.Location = new System.Drawing.Point(80, 61);
            this.FirstName_lable.Name = "FirstName_lable";
            this.FirstName_lable.Size = new System.Drawing.Size(48, 13);
            this.FirstName_lable.TabIndex = 66;
            this.FirstName_lable.Text = "&Plane id:";
            // 
            // max_pass_text
            // 
            this.max_pass_text.Location = new System.Drawing.Point(196, 153);
            this.max_pass_text.Name = "max_pass_text";
            this.max_pass_text.Size = new System.Drawing.Size(100, 20);
            this.max_pass_text.TabIndex = 3;
            // 
            // compeny_name
            // 
            this.compeny_name.Location = new System.Drawing.Point(196, 104);
            this.compeny_name.Name = "compeny_name";
            this.compeny_name.Size = new System.Drawing.Size(100, 20);
            this.compeny_name.TabIndex = 2;
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(196, 195);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(100, 20);
            this.model.TabIndex = 4;
            // 
            // plane_id_text
            // 
            this.plane_id_text.Location = new System.Drawing.Point(196, 58);
            this.plane_id_text.Name = "plane_id_text";
            this.plane_id_text.Size = new System.Drawing.Size(100, 20);
            this.plane_id_text.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "&Condition:";
            // 
            // condition_comboBox
            // 
            this.condition_comboBox.AllowDrop = true;
            this.condition_comboBox.FormattingEnabled = true;
            this.condition_comboBox.Items.AddRange(new object[] {
            "Good",
            "Medium",
            "bad"});
            this.condition_comboBox.Location = new System.Drawing.Point(196, 252);
            this.condition_comboBox.MaxDropDownItems = 3;
            this.condition_comboBox.Name = "condition_comboBox";
            this.condition_comboBox.Size = new System.Drawing.Size(100, 21);
            this.condition_comboBox.TabIndex = 5;
            // 
            // Plane_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 468);
            this.Controls.Add(this.condition_comboBox);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstName_lable);
            this.Controls.Add(this.max_pass_text);
            this.Controls.Add(this.compeny_name);
            this.Controls.Add(this.model);
            this.Controls.Add(this.plane_id_text);
            this.Controls.Add(this.label9);
            this.Name = "Plane_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plane_details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FirstName_lable;
        private System.Windows.Forms.TextBox max_pass_text;
        private System.Windows.Forms.TextBox compeny_name;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.TextBox plane_id_text;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox condition_comboBox;
    }
}