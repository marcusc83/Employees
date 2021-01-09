
namespace Employees
{
    partial class QueryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblDatabseTitle = new System.Windows.Forms.Label();
            this.grbSelectionCriteria = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chbEmpId = new System.Windows.Forms.CheckBox();
            this.chbFirstName = new System.Windows.Forms.CheckBox();
            this.chblastName = new System.Windows.Forms.CheckBox();
            this.chbStreetAddress = new System.Windows.Forms.CheckBox();
            this.chbCity = new System.Windows.Forms.CheckBox();
            this.chbState = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chbPhoneNumber = new System.Windows.Forms.CheckBox();
            this.chbEmailAddress = new System.Windows.Forms.CheckBox();
            this.chbSalary = new System.Windows.Forms.CheckBox();
            this.chbDepartment = new System.Windows.Forms.CheckBox();
            this.btnRunQuery = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDefaultDatabase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbSelectionCriteria.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Query From";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(346, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 393);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblDatabseTitle
            // 
            this.lblDatabseTitle.AutoSize = true;
            this.lblDatabseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDatabseTitle.Location = new System.Drawing.Point(617, 79);
            this.lblDatabseTitle.Name = "lblDatabseTitle";
            this.lblDatabseTitle.Size = new System.Drawing.Size(136, 20);
            this.lblDatabseTitle.TabIndex = 2;
            this.lblDatabseTitle.Text = "Current Database";
            // 
            // grbSelectionCriteria
            // 
            this.grbSelectionCriteria.Controls.Add(this.chbDepartment);
            this.grbSelectionCriteria.Controls.Add(this.chbSalary);
            this.grbSelectionCriteria.Controls.Add(this.chbEmailAddress);
            this.grbSelectionCriteria.Controls.Add(this.chbPhoneNumber);
            this.grbSelectionCriteria.Controls.Add(this.checkBox1);
            this.grbSelectionCriteria.Controls.Add(this.chbState);
            this.grbSelectionCriteria.Controls.Add(this.chbCity);
            this.grbSelectionCriteria.Controls.Add(this.chbStreetAddress);
            this.grbSelectionCriteria.Controls.Add(this.chblastName);
            this.grbSelectionCriteria.Controls.Add(this.chbFirstName);
            this.grbSelectionCriteria.Controls.Add(this.chbEmpId);
            this.grbSelectionCriteria.Location = new System.Drawing.Point(6, 175);
            this.grbSelectionCriteria.Name = "grbSelectionCriteria";
            this.grbSelectionCriteria.Size = new System.Drawing.Size(334, 179);
            this.grbSelectionCriteria.TabIndex = 3;
            this.grbSelectionCriteria.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose What You Want\r\nto See in the Database";
            // 
            // chbEmpId
            // 
            this.chbEmpId.AutoSize = true;
            this.chbEmpId.Location = new System.Drawing.Point(20, 20);
            this.chbEmpId.Name = "chbEmpId";
            this.chbEmpId.Size = new System.Drawing.Size(55, 17);
            this.chbEmpId.TabIndex = 0;
            this.chbEmpId.Text = "empId";
            this.chbEmpId.UseVisualStyleBackColor = true;
            // 
            // chbFirstName
            // 
            this.chbFirstName.AutoSize = true;
            this.chbFirstName.Location = new System.Drawing.Point(126, 19);
            this.chbFirstName.Name = "chbFirstName";
            this.chbFirstName.Size = new System.Drawing.Size(70, 17);
            this.chbFirstName.TabIndex = 1;
            this.chbFirstName.Text = "firstName";
            this.chbFirstName.UseVisualStyleBackColor = true;
            // 
            // chblastName
            // 
            this.chblastName.AutoSize = true;
            this.chblastName.Location = new System.Drawing.Point(230, 19);
            this.chblastName.Name = "chblastName";
            this.chblastName.Size = new System.Drawing.Size(70, 17);
            this.chblastName.TabIndex = 2;
            this.chblastName.Text = "lastName";
            this.chblastName.UseVisualStyleBackColor = true;
            // 
            // chbStreetAddress
            // 
            this.chbStreetAddress.AutoSize = true;
            this.chbStreetAddress.Location = new System.Drawing.Point(20, 60);
            this.chbStreetAddress.Name = "chbStreetAddress";
            this.chbStreetAddress.Size = new System.Drawing.Size(90, 17);
            this.chbStreetAddress.TabIndex = 3;
            this.chbStreetAddress.Text = "streetAddress";
            this.chbStreetAddress.UseVisualStyleBackColor = true;
            // 
            // chbCity
            // 
            this.chbCity.AutoSize = true;
            this.chbCity.Location = new System.Drawing.Point(126, 60);
            this.chbCity.Name = "chbCity";
            this.chbCity.Size = new System.Drawing.Size(42, 17);
            this.chbCity.TabIndex = 4;
            this.chbCity.Text = "city";
            this.chbCity.UseVisualStyleBackColor = true;
            // 
            // chbState
            // 
            this.chbState.AutoSize = true;
            this.chbState.Location = new System.Drawing.Point(230, 60);
            this.chbState.Name = "chbState";
            this.chbState.Size = new System.Drawing.Size(49, 17);
            this.chbState.TabIndex = 5;
            this.chbState.Text = "state";
            this.chbState.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(20, 100);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "zipCode";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chbPhoneNumber
            // 
            this.chbPhoneNumber.AutoSize = true;
            this.chbPhoneNumber.Location = new System.Drawing.Point(126, 100);
            this.chbPhoneNumber.Name = "chbPhoneNumber";
            this.chbPhoneNumber.Size = new System.Drawing.Size(93, 17);
            this.chbPhoneNumber.TabIndex = 7;
            this.chbPhoneNumber.Text = "phoneNumber";
            this.chbPhoneNumber.UseVisualStyleBackColor = true;
            // 
            // chbEmailAddress
            // 
            this.chbEmailAddress.AutoSize = true;
            this.chbEmailAddress.Location = new System.Drawing.Point(230, 100);
            this.chbEmailAddress.Name = "chbEmailAddress";
            this.chbEmailAddress.Size = new System.Drawing.Size(88, 17);
            this.chbEmailAddress.TabIndex = 8;
            this.chbEmailAddress.Text = "emailAddress";
            this.chbEmailAddress.UseVisualStyleBackColor = true;
            // 
            // chbSalary
            // 
            this.chbSalary.AutoSize = true;
            this.chbSalary.Location = new System.Drawing.Point(20, 140);
            this.chbSalary.Name = "chbSalary";
            this.chbSalary.Size = new System.Drawing.Size(53, 17);
            this.chbSalary.TabIndex = 9;
            this.chbSalary.Text = "salary";
            this.chbSalary.UseVisualStyleBackColor = true;
            // 
            // chbDepartment
            // 
            this.chbDepartment.AutoSize = true;
            this.chbDepartment.Location = new System.Drawing.Point(126, 140);
            this.chbDepartment.Name = "chbDepartment";
            this.chbDepartment.Size = new System.Drawing.Size(79, 17);
            this.chbDepartment.TabIndex = 10;
            this.chbDepartment.Text = "department";
            this.chbDepartment.UseVisualStyleBackColor = true;
            // 
            // btnRunQuery
            // 
            this.btnRunQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunQuery.Location = new System.Drawing.Point(69, 375);
            this.btnRunQuery.Name = "btnRunQuery";
            this.btnRunQuery.Size = new System.Drawing.Size(169, 38);
            this.btnRunQuery.TabIndex = 5;
            this.btnRunQuery.Text = "Run Query";
            this.btnRunQuery.UseVisualStyleBackColor = true;
            this.btnRunQuery.Click += new System.EventHandler(this.btnRunQuery_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(69, 452);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(169, 38);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDefaultDatabase
            // 
            this.btnDefaultDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefaultDatabase.Location = new System.Drawing.Point(866, 19);
            this.btnDefaultDatabase.Name = "btnDefaultDatabase";
            this.btnDefaultDatabase.Size = new System.Drawing.Size(169, 38);
            this.btnDefaultDatabase.TabIndex = 7;
            this.btnDefaultDatabase.Text = "Default Databse";
            this.btnDefaultDatabase.UseVisualStyleBackColor = true;
            this.btnDefaultDatabase.Click += new System.EventHandler(this.btnDefaultDatabase_Click);
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 522);
            this.Controls.Add(this.btnDefaultDatabase);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRunQuery);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grbSelectionCriteria);
            this.Controls.Add(this.lblDatabseTitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "QueryForm";
            this.Text = "Query Form";
            this.Load += new System.EventHandler(this.QueryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbSelectionCriteria.ResumeLayout(false);
            this.grbSelectionCriteria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDatabseTitle;
        private System.Windows.Forms.GroupBox grbSelectionCriteria;
        private System.Windows.Forms.CheckBox chbFirstName;
        private System.Windows.Forms.CheckBox chbEmpId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chbState;
        private System.Windows.Forms.CheckBox chbCity;
        private System.Windows.Forms.CheckBox chbStreetAddress;
        private System.Windows.Forms.CheckBox chblastName;
        private System.Windows.Forms.CheckBox chbDepartment;
        private System.Windows.Forms.CheckBox chbSalary;
        private System.Windows.Forms.CheckBox chbEmailAddress;
        private System.Windows.Forms.CheckBox chbPhoneNumber;
        private System.Windows.Forms.Button btnRunQuery;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDefaultDatabase;
    }
}