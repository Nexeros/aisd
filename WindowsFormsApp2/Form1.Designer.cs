namespace WindowsFormsApp2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox listBoxDisplay;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnAddFirst;
        private System.Windows.Forms.Button btnAddLast;
        private System.Windows.Forms.Button btnAddAt;
        private System.Windows.Forms.Button btnRemoveFirst;
        private System.Windows.Forms.Button btnRemoveLast;

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btnAddFirst = new System.Windows.Forms.Button();
            this.btnAddLast = new System.Windows.Forms.Button();
            this.btnAddAt = new System.Windows.Forms.Button();
            this.btnRemoveFirst = new System.Windows.Forms.Button();
            this.btnRemoveLast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 18);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 0;
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.Location = new System.Drawing.Point(12, 44);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(100, 108);
            this.listBoxDisplay.TabIndex = 1;
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(12, 156);
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(312, 20);
            this.txtResults.TabIndex = 2;
            // 
            // btnAddFirst
            // 
            this.btnAddFirst.Location = new System.Drawing.Point(118, 12);
            this.btnAddFirst.Name = "btnAddFirst";
            this.btnAddFirst.Size = new System.Drawing.Size(100, 30);
            this.btnAddFirst.TabIndex = 3;
            this.btnAddFirst.Text = "Add First";
            this.btnAddFirst.Click += new System.EventHandler(this.btnAddFirst_Click);
            // 
            // btnAddLast
            // 
            this.btnAddLast.Location = new System.Drawing.Point(224, 12);
            this.btnAddLast.Name = "btnAddLast";
            this.btnAddLast.Size = new System.Drawing.Size(100, 30);
            this.btnAddLast.TabIndex = 4;
            this.btnAddLast.Text = "Add Last";
            this.btnAddLast.Click += new System.EventHandler(this.btnAddLast_Click);
            // 
            // btnAddAt
            // 
            this.btnAddAt.Location = new System.Drawing.Point(118, 48);
            this.btnAddAt.Name = "btnAddAt";
            this.btnAddAt.Size = new System.Drawing.Size(206, 30);
            this.btnAddAt.TabIndex = 5;
            this.btnAddAt.Text = "Add At Selected";
            this.btnAddAt.Click += new System.EventHandler(this.btnAddAt_Click);
            // 
            // btnRemoveFirst
            // 
            this.btnRemoveFirst.Location = new System.Drawing.Point(118, 84);
            this.btnRemoveFirst.Name = "btnRemoveFirst";
            this.btnRemoveFirst.Size = new System.Drawing.Size(206, 30);
            this.btnRemoveFirst.TabIndex = 6;
            this.btnRemoveFirst.Text = "Remove First";
            this.btnRemoveFirst.Click += new System.EventHandler(this.btnRemoveFirst_Click);
            // 
            // btnRemoveLast
            // 
            this.btnRemoveLast.Location = new System.Drawing.Point(118, 120);
            this.btnRemoveLast.Name = "btnRemoveLast";
            this.btnRemoveLast.Size = new System.Drawing.Size(206, 30);
            this.btnRemoveLast.TabIndex = 7;
            this.btnRemoveLast.Text = "Remove Last";
            this.btnRemoveLast.Click += new System.EventHandler(this.btnRemoveLast_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(327, 180);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.listBoxDisplay);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btnAddFirst);
            this.Controls.Add(this.btnAddLast);
            this.Controls.Add(this.btnAddAt);
            this.Controls.Add(this.btnRemoveFirst);
            this.Controls.Add(this.btnRemoveLast);
            this.Name = "Form1";
            this.Text = "LinkedList UI Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

