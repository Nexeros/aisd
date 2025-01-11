namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Deklaracja kontrolek
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDisplayTree;
        private System.Windows.Forms.Button buttonReset; // Dodano przycisk reset

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDisplayTree = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button(); // Inicjalizacja przycisku reset
            this.SuspendLayout();

            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(260, 400);
            this.treeView1.TabIndex = 0;

            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(290, 20);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxInput.TabIndex = 1;

            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(290, 50);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 30);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Dodaj liczbę";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);

            // 
            // buttonDisplayTree
            // 
            this.buttonDisplayTree.Location = new System.Drawing.Point(290, 90);
            this.buttonDisplayTree.Name = "buttonDisplayTree";
            this.buttonDisplayTree.Size = new System.Drawing.Size(100, 30);
            this.buttonDisplayTree.TabIndex = 3;
            this.buttonDisplayTree.Text = "Wyświetl drzewo";
            this.buttonDisplayTree.UseVisualStyleBackColor = true;
            this.buttonDisplayTree.Click += new System.EventHandler(this.buttonDisplayTree_Click);

            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(290, 130);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(100, 30);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Restart";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 421);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDisplayTree);
            this.Controls.Add(this.buttonReset); // Dodanie przycisku reset do formularza
            this.Name = "Form1";
            this.Text = "Głupie drzewko";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
