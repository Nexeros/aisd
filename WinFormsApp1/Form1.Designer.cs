namespace WinFormsApp1
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
            txtBoxCount = new TextBox();
            listBoxNumbers = new ListBox();
            listBoxSortedNumbers = new ListBox();
            btnSubmitCount = new Button();
            btnSort = new Button();
            progressBar1 = new ProgressBar();
            txtBoxEditNumber = new TextBox();
            btnSaveNumber = new Button();
            btnExit = new Button();
            labelProgressStatus = new Label();
            SuspendLayout();
            // 
            // txtBoxCount
            // 
            txtBoxCount.Location = new Point(12, 12);
            txtBoxCount.Name = "txtBoxCount";
            txtBoxCount.Size = new Size(384, 23);
            txtBoxCount.TabIndex = 0;
            txtBoxCount.TextChanged += textBox1_TextChanged;
            // 
            // listBoxNumbers
            // 
            listBoxNumbers.FormattingEnabled = true;
            listBoxNumbers.ItemHeight = 15;
            listBoxNumbers.Location = new Point(12, 41);
            listBoxNumbers.Name = "listBoxNumbers";
            listBoxNumbers.Size = new Size(478, 94);
            listBoxNumbers.TabIndex = 1;
            listBoxNumbers.SelectedIndexChanged += listBoxNumbers_SelectedIndexChanged;
            // 
            // listBoxSortedNumbers
            // 
            listBoxSortedNumbers.FormattingEnabled = true;
            listBoxSortedNumbers.ItemHeight = 15;
            listBoxSortedNumbers.Location = new Point(12, 199);
            listBoxSortedNumbers.Name = "listBoxSortedNumbers";
            listBoxSortedNumbers.Size = new Size(478, 94);
            listBoxSortedNumbers.TabIndex = 2;
            listBoxSortedNumbers.SelectedIndexChanged += listBoxSortedNumbers_SelectedIndexChanged;
            // 
            // btnSubmitCount
            // 
            btnSubmitCount.Location = new Point(413, 12);
            btnSubmitCount.Name = "btnSubmitCount";
            btnSubmitCount.Size = new Size(75, 23);
            btnSubmitCount.TabIndex = 3;
            btnSubmitCount.Text = "Submit";
            btnSubmitCount.UseVisualStyleBackColor = true;
            btnSubmitCount.Click += btnSubmitCount_Click_1;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(413, 141);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(75, 23);
            btnSort.TabIndex = 4;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click_1;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(10, 171);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(478, 23);
            progressBar1.TabIndex = 5;
            progressBar1.Click += progressBar1_Click;
            // 
            // txtBoxEditNumber
            // 
            txtBoxEditNumber.Location = new Point(12, 142);
            txtBoxEditNumber.Name = "txtBoxEditNumber";
            txtBoxEditNumber.Size = new Size(100, 23);
            txtBoxEditNumber.TabIndex = 6;
            // 
            // btnSaveNumber
            // 
            btnSaveNumber.Location = new Point(118, 142);
            btnSaveNumber.Name = "btnSaveNumber";
            btnSaveNumber.Size = new Size(75, 23);
            btnSaveNumber.TabIndex = 7;
            btnSaveNumber.Text = "Save";
            btnSaveNumber.UseVisualStyleBackColor = true;
            btnSaveNumber.Click += btnSaveNumber_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(413, 305);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // labelProgressStatus
            // 
            labelProgressStatus.BackColor = Color.Transparent;
            labelProgressStatus.Location = new Point(199, 145);
            labelProgressStatus.Name = "labelProgressStatus";
            labelProgressStatus.Size = new Size(140, 15);
            labelProgressStatus.TabIndex = 9;
            labelProgressStatus.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 340);
            Controls.Add(labelProgressStatus);
            Controls.Add(progressBar1);
            Controls.Add(btnExit);
            Controls.Add(btnSaveNumber);
            Controls.Add(txtBoxEditNumber);
            Controls.Add(btnSort);
            Controls.Add(btnSubmitCount);
            Controls.Add(listBoxSortedNumbers);
            Controls.Add(listBoxNumbers);
            Controls.Add(txtBoxCount);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxCount;
        private ListBox listBoxNumbers;
        private ListBox listBoxSortedNumbers;
        private Button btnSubmitCount;
        private Button btnSort;
        private ProgressBar progressBar1;
        private TextBox txtBoxEditNumber;
        private Button btnSaveNumber;
        private Button btnExit;
        private Label labelProgressStatus;
    }
}