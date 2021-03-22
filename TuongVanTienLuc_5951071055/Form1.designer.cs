
namespace NguyenManhHoai_5951071029
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.StudentRecordData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNName = new System.Windows.Forms.TextBox();
            this.TxtRoll = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtHName = new System.Windows.Forms.TextBox();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentRecordData)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(132, 159);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(88, 43);
            this.UpdateButton.TabIndex = 1;
            this.UpdateButton.Text = "Cập nhật";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(226, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Xác lập";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(320, 159);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(88, 43);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(532, 159);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 43);
            this.button5.TabIndex = 4;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // StudentRecordData
            // 
            this.StudentRecordData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentRecordData.Location = new System.Drawing.Point(13, 238);
            this.StudentRecordData.Name = "StudentRecordData";
            this.StudentRecordData.Size = new System.Drawing.Size(607, 177);
            this.StudentRecordData.TabIndex = 5;
            this.StudentRecordData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentRecordData_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Họ sinh viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số báo danh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên sinh viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số điện thoại:";
            // 
            // TxtNName
            // 
            this.TxtNName.Location = new System.Drawing.Point(132, 16);
            this.TxtNName.Name = "TxtNName";
            this.TxtNName.Size = new System.Drawing.Size(107, 20);
            this.TxtNName.TabIndex = 11;
            // 
            // TxtRoll
            // 
            this.TxtRoll.Location = new System.Drawing.Point(132, 53);
            this.TxtRoll.Name = "TxtRoll";
            this.TxtRoll.Size = new System.Drawing.Size(107, 20);
            this.TxtRoll.TabIndex = 12;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(132, 90);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(107, 20);
            this.TxtAddress.TabIndex = 13;
            // 
            // TxtHName
            // 
            this.TxtHName.Location = new System.Drawing.Point(429, 16);
            this.TxtHName.Name = "TxtHName";
            this.TxtHName.Size = new System.Drawing.Size(107, 20);
            this.TxtHName.TabIndex = 14;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(429, 56);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(107, 20);
            this.TxtPhone.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(653, 427);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.TxtHName);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtRoll);
            this.Controls.Add(this.TxtNName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentRecordData);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Infomation";
            ((System.ComponentModel.ISupportInitialize)(this.StudentRecordData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView StudentRecordData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNName;
        private System.Windows.Forms.TextBox TxtRoll;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtHName;
        private System.Windows.Forms.TextBox TxtPhone;
    }
}

