namespace db_project
{
    partial class Reservation
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
            this.FirstName_lable = new System.Windows.Forms.Label();
            this.passenger_id_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cnic_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.flight_id_box = new System.Windows.Forms.ComboBox();
            this.reserve_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstName_lable
            // 
            this.FirstName_lable.AutoSize = true;
            this.FirstName_lable.Location = new System.Drawing.Point(182, 118);
            this.FirstName_lable.Name = "FirstName_lable";
            this.FirstName_lable.Size = new System.Drawing.Size(35, 13);
            this.FirstName_lable.TabIndex = 11;
            this.FirstName_lable.Text = "&Flight:";
            // 
            // passenger_id_text
            // 
            this.passenger_id_text.Location = new System.Drawing.Point(298, 163);
            this.passenger_id_text.Name = "passenger_id_text";
            this.passenger_id_text.Size = new System.Drawing.Size(100, 20);
            this.passenger_id_text.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "&Passenger id:";
            // 
            // cnic_text
            // 
            this.cnic_text.Location = new System.Drawing.Point(298, 218);
            this.cnic_text.Name = "cnic_text";
            this.cnic_text.Size = new System.Drawing.Size(100, 20);
            this.cnic_text.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "&CNIC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "OR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "&Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(298, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // flight_id_box
            // 
            this.flight_id_box.FormattingEnabled = true;
            this.flight_id_box.Location = new System.Drawing.Point(298, 109);
            this.flight_id_box.Name = "flight_id_box";
            this.flight_id_box.Size = new System.Drawing.Size(200, 21);
            this.flight_id_box.TabIndex = 14;
            // 
            // reserve_button
            // 
            this.reserve_button.Location = new System.Drawing.Point(185, 335);
            this.reserve_button.Name = "reserve_button";
            this.reserve_button.Size = new System.Drawing.Size(75, 23);
            this.reserve_button.TabIndex = 15;
            this.reserve_button.Text = "&Reserve";
            this.reserve_button.UseVisualStyleBackColor = true;
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(347, 335);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 15;
            this.cancel_button.Text = "&Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 455);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.reserve_button);
            this.Controls.Add(this.flight_id_box);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FirstName_lable);
            this.Controls.Add(this.cnic_text);
            this.Controls.Add(this.passenger_id_text);
            this.Name = "Reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstName_lable;
        private System.Windows.Forms.TextBox passenger_id_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cnic_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox flight_id_box;
        private System.Windows.Forms.Button reserve_button;
        private System.Windows.Forms.Button cancel_button;
    }
}