using System.Drawing;

namespace StudentInfo_withDatabase
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.MaskedTextBox();
            this.dgwStudents = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupboxMain = new System.Windows.Forms.GroupBox();
            this.tbxMark = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxUpdate = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxMarkUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxPhoneUpdate = new System.Windows.Forms.MaskedTextBox();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.tbxAgeUpdate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).BeginInit();
            this.groupboxMain.SuspendLayout();
            this.groupBoxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(51, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(66, 111);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(47, 22);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age:";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(46, 154);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(67, 22);
            this.lblTelephone.TabIndex = 2;
            this.lblTelephone.Text = "Phone:";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(404, 39);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(108, 25);
            this.lblTable.TabIndex = 10;
            this.lblTable.Text = "SQL Table";
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(127, 66);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(197, 28);
            this.tbxName.TabIndex = 5;
            // 
            // tbxAge
            // 
            this.tbxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAge.Location = new System.Drawing.Point(127, 108);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(60, 28);
            this.tbxAge.TabIndex = 6;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhone.Location = new System.Drawing.Point(127, 151);
            this.tbxPhone.Mask = "(999) 000-0000";
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(151, 28);
            this.tbxPhone.TabIndex = 7;
            // 
            // dgwStudents
            // 
            this.dgwStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwStudents.ColumnHeadersHeight = 29;
            this.dgwStudents.Location = new System.Drawing.Point(368, 65);
            this.dgwStudents.Name = "dgwStudents";
            this.dgwStudents.RowHeadersWidth = 51;
            this.dgwStudents.RowTemplate.Height = 24;
            this.dgwStudents.Size = new System.Drawing.Size(762, 329);
            this.dgwStudents.TabIndex = 11;
            this.dgwStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwStudents_CellClick);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(127, 273);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 41);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupboxMain
            // 
            this.groupboxMain.Controls.Add(this.tbxMark);
            this.groupboxMain.Controls.Add(this.label1);
            this.groupboxMain.Controls.Add(this.lblName);
            this.groupboxMain.Controls.Add(this.dgwStudents);
            this.groupboxMain.Controls.Add(this.btnSave);
            this.groupboxMain.Controls.Add(this.lblTable);
            this.groupboxMain.Controls.Add(this.lblAge);
            this.groupboxMain.Controls.Add(this.lblTelephone);
            this.groupboxMain.Controls.Add(this.tbxPhone);
            this.groupboxMain.Controls.Add(this.tbxName);
            this.groupboxMain.Controls.Add(this.tbxAge);
            this.groupboxMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxMain.Location = new System.Drawing.Point(12, 25);
            this.groupboxMain.Name = "groupboxMain";
            this.groupboxMain.Size = new System.Drawing.Size(1156, 421);
            this.groupboxMain.TabIndex = 9;
            this.groupboxMain.TabStop = false;
            this.groupboxMain.Text = "Send Info to SQL Server / Retrieve";
            // 
            // tbxMark
            // 
            this.tbxMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMark.Location = new System.Drawing.Point(127, 203);
            this.tbxMark.Name = "tbxMark";
            this.tbxMark.Size = new System.Drawing.Size(71, 28);
            this.tbxMark.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mark:";
            // 
            // groupBoxUpdate
            // 
            this.groupBoxUpdate.Controls.Add(this.btnDelete);
            this.groupBoxUpdate.Controls.Add(this.btnUpdate);
            this.groupBoxUpdate.Controls.Add(this.tbxMarkUpdate);
            this.groupBoxUpdate.Controls.Add(this.label6);
            this.groupBoxUpdate.Controls.Add(this.textBox1);
            this.groupBoxUpdate.Controls.Add(this.label2);
            this.groupBoxUpdate.Controls.Add(this.label3);
            this.groupBoxUpdate.Controls.Add(this.label4);
            this.groupBoxUpdate.Controls.Add(this.label5);
            this.groupBoxUpdate.Controls.Add(this.tbxPhoneUpdate);
            this.groupBoxUpdate.Controls.Add(this.tbxNameUpdate);
            this.groupBoxUpdate.Controls.Add(this.tbxAgeUpdate);
            this.groupBoxUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUpdate.Location = new System.Drawing.Point(52, 461);
            this.groupBoxUpdate.Name = "groupBoxUpdate";
            this.groupBoxUpdate.Size = new System.Drawing.Size(1064, 147);
            this.groupBoxUpdate.TabIndex = 10;
            this.groupBoxUpdate.TabStop = false;
            this.groupBoxUpdate.Text = "Update - Remove Form";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Info;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Location = new System.Drawing.Point(835, 91);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(205, 41);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete Record";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(933, 33);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 41);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxMarkUpdate
            // 
            this.tbxMarkUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMarkUpdate.Location = new System.Drawing.Point(796, 40);
            this.tbxMarkUpdate.Name = "tbxMarkUpdate";
            this.tbxMarkUpdate.Size = new System.Drawing.Size(71, 28);
            this.tbxMarkUpdate.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(736, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Mark:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(382, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 28);
            this.textBox1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mark:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(349, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Age:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(488, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Phone:";
            // 
            // tbxPhoneUpdate
            // 
            this.tbxPhoneUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhoneUpdate.Location = new System.Drawing.Point(561, 40);
            this.tbxPhoneUpdate.Mask = "(999) 000-0000";
            this.tbxPhoneUpdate.Name = "tbxPhoneUpdate";
            this.tbxPhoneUpdate.Size = new System.Drawing.Size(151, 28);
            this.tbxPhoneUpdate.TabIndex = 16;
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNameUpdate.Location = new System.Drawing.Point(127, 38);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(197, 28);
            this.tbxNameUpdate.TabIndex = 14;
            // 
            // tbxAgeUpdate
            // 
            this.tbxAgeUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAgeUpdate.Location = new System.Drawing.Point(409, 40);
            this.tbxAgeUpdate.Name = "tbxAgeUpdate";
            this.tbxAgeUpdate.Size = new System.Drawing.Size(60, 28);
            this.tbxAgeUpdate.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 633);
            this.Controls.Add(this.groupBoxUpdate);
            this.Controls.Add(this.groupboxMain);
            this.Name = "Form1";
            this.Text = "Name/Age/Phone Records";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).EndInit();
            this.groupboxMain.ResumeLayout(false);
            this.groupboxMain.PerformLayout();
            this.groupBoxUpdate.ResumeLayout(false);
            this.groupBoxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.MaskedTextBox tbxPhone;
        private System.Windows.Forms.DataGridView dgwStudents;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupboxMain;
        private System.Windows.Forms.TextBox tbxMark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxMarkUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox tbxPhoneUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.TextBox tbxAgeUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

