namespace Assignment_4._2
{
    partial class StudentRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRecords));
            this.labelLM = new System.Windows.Forms.Label();
            this.stuGrid = new System.Windows.Forms.DataGridView();
            this.grpStu = new System.Windows.Forms.GroupBox();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stuGrid)).BeginInit();
            this.grpStu.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLM
            // 
            this.labelLM.AutoSize = true;
            this.labelLM.BackColor = System.Drawing.Color.Transparent;
            this.labelLM.Font = new System.Drawing.Font("Vladimir Script", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLM.Location = new System.Drawing.Point(359, 54);
            this.labelLM.Name = "labelLM";
            this.labelLM.Size = new System.Drawing.Size(366, 40);
            this.labelLM.TabIndex = 0;
            this.labelLM.Text = "Infinite Learning Management";
            // 
            // stuGrid
            // 
            this.stuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stuGrid.Location = new System.Drawing.Point(636, 203);
            this.stuGrid.Name = "stuGrid";
            this.stuGrid.RowHeadersWidth = 51;
            this.stuGrid.RowTemplate.Height = 24;
            this.stuGrid.Size = new System.Drawing.Size(410, 424);
            this.stuGrid.TabIndex = 1;
            // 
            // grpStu
            // 
            this.grpStu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grpStu.Controls.Add(this.txtGPA);
            this.grpStu.Controls.Add(this.txtName);
            this.grpStu.Controls.Add(this.txtId);
            this.grpStu.Controls.Add(this.label3);
            this.grpStu.Controls.Add(this.label2);
            this.grpStu.Controls.Add(this.label1);
            this.grpStu.Font = new System.Drawing.Font("Vladimir Script", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStu.Location = new System.Drawing.Point(43, 228);
            this.grpStu.Name = "grpStu";
            this.grpStu.Size = new System.Drawing.Size(364, 399);
            this.grpStu.TabIndex = 2;
            this.grpStu.TabStop = false;
            this.grpStu.Text = "Enter student info";
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(153, 221);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(157, 23);
            this.txtGPA.TabIndex = 5;
            this.txtGPA.Validating += new System.ComponentModel.CancelEventHandler(this.txtGPA_Validating);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(153, 153);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 23);
            this.txtName.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(153, 88);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(157, 23);
            this.txtId.TabIndex = 3;
            this.txtId.Validating += new System.ComponentModel.CancelEventHandler(this.txtId_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vladimir Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student GPA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vladimir Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vladimir Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(455, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 47);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Student";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(455, 556);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 46);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Student";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(455, 393);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(137, 57);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Save Best Student";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // StudentRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(860, 636);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grpStu);
            this.Controls.Add(this.stuGrid);
            this.Controls.Add(this.labelLM);
            this.Name = "StudentRecords";
            this.Text = "StudentRecords";
            this.Load += new System.EventHandler(this.StudentRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stuGrid)).EndInit();
            this.grpStu.ResumeLayout(false);
            this.grpStu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLM;
        private System.Windows.Forms.DataGridView stuGrid;
        private System.Windows.Forms.GroupBox grpStu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoad;
    }
}