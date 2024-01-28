namespace MachineProblem12
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            txtFn = new TextBox();
            txtLn = new TextBox();
            btnInsert = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 47);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 90);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 135);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            // 
            // txtId
            // 
            txtId.Location = new Point(201, 44);
            txtId.Name = "txtId";
            txtId.Size = new Size(128, 23);
            txtId.TabIndex = 3;
            // 
            // txtFn
            // 
            txtFn.Location = new Point(201, 90);
            txtFn.Name = "txtFn";
            txtFn.Size = new Size(128, 23);
            txtFn.TabIndex = 4;
            // 
            // txtLn
            // 
            txtLn.Location = new Point(201, 135);
            txtLn.Name = "txtLn";
            txtLn.Size = new Size(128, 23);
            txtLn.TabIndex = 5;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(26, 202);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(89, 38);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(121, 202);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(89, 38);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(216, 202);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 38);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(311, 202);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(89, 38);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 257);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(374, 227);
            dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 496);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnInsert);
            Controls.Add(txtLn);
            Controls.Add(txtFn);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtFn;
        private TextBox txtLn;
        private Button btnInsert;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView dataGridView1;
    }
}