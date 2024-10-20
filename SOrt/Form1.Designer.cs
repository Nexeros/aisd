namespace SOrt
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
            txtInput = new RichTextBox();
            btnSort = new Button();
            btnCompare = new Button();
            txtSortedNumbers = new RichTextBox();
            dgvResults = new DataGridView();
            Algorithm = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            lblTime = new Label();
            cmbAlgorithms = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 12);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(351, 159);
            txtInput.TabIndex = 0;
            txtInput.Text = "";
            txtInput.TextChanged += txtInput_TextChanged;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(12, 177);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(75, 23);
            btnSort.TabIndex = 1;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // btnCompare
            // 
            btnCompare.Location = new Point(539, 177);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(75, 23);
            btnCompare.TabIndex = 2;
            btnCompare.Text = "Compare";
            btnCompare.UseVisualStyleBackColor = true;
            btnCompare.Click += btnCompare_Click;
            // 
            // txtSortedNumbers
            // 
            txtSortedNumbers.Location = new Point(12, 206);
            txtSortedNumbers.Name = "txtSortedNumbers";
            txtSortedNumbers.Size = new Size(351, 158);
            txtSortedNumbers.TabIndex = 3;
            txtSortedNumbers.Text = "";
            txtSortedNumbers.TextChanged += txtSortedNumbers_TextChanged;
            // 
            // dgvResults
            // 
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Columns.AddRange(new DataGridViewColumn[] { Algorithm, Time });
            dgvResults.Location = new Point(539, 12);
            dgvResults.Name = "dgvResults";
            dgvResults.RowTemplate.Height = 25;
            dgvResults.Size = new Size(249, 159);
            dgvResults.TabIndex = 4;
            dgvResults.CellContentClick += dgvResults_CellContentClick;
            // 
            // Algorithm
            // 
            Algorithm.HeaderText = "Algorithm";
            Algorithm.Name = "Algorithm";
            // 
            // Time
            // 
            Time.HeaderText = "Time";
            Time.Name = "Time";
            // 
            // lblTime
            // 
            lblTime.Location = new Point(369, 15);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(164, 36);
            lblTime.TabIndex = 5;
            lblTime.Text = "Czas:";
            lblTime.Click += lblTime_Click;
            // 
            // cmbAlgorithms
            // 
            cmbAlgorithms.FormattingEnabled = true;
            cmbAlgorithms.Location = new Point(93, 177);
            cmbAlgorithms.Name = "cmbAlgorithms";
            cmbAlgorithms.Size = new Size(121, 23);
            cmbAlgorithms.TabIndex = 6;
            cmbAlgorithms.SelectedIndexChanged += cmbAlgorithms_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbAlgorithms);
            Controls.Add(lblTime);
            Controls.Add(dgvResults);
            Controls.Add(txtSortedNumbers);
            Controls.Add(btnCompare);
            Controls.Add(btnSort);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txtInput;
        private Button btnSort;
        private Button btnCompare;
        private RichTextBox txtSortedNumbers;
        private DataGridView dgvResults;
        private Label lblTime;
        private ComboBox cmbAlgorithms;
        private DataGridViewTextBoxColumn Algorithm;
        private DataGridViewTextBoxColumn Time;
    }
}