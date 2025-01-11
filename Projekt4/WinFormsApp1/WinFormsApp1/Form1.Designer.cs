namespace GrafApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button addNodeButton;
        private System.Windows.Forms.Button addEdgeButton;
        private System.Windows.Forms.Button resetButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.addNodeButton = new System.Windows.Forms.Button();
            this.addEdgeButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();

            // AddNodeButton
            this.addNodeButton.Location = new System.Drawing.Point(10, 10);
            this.addNodeButton.Size = new System.Drawing.Size(100, 30);
            this.addNodeButton.Text = "Dodaj Węzeł";
            this.addNodeButton.Click += new System.EventHandler(this.AddNodeButton_Click);

            // AddEdgeButton
            this.addEdgeButton.Location = new System.Drawing.Point(10, 50);
            this.addEdgeButton.Size = new System.Drawing.Size(100, 30);
            this.addEdgeButton.Text = "Dodaj Krawędź";
            this.addEdgeButton.Click += new System.EventHandler(this.AddEdgeButton_Click);

            // ResetButton
            this.resetButton.Location = new System.Drawing.Point(10, 90);
            this.resetButton.Size = new System.Drawing.Size(100, 30);
            this.resetButton.Text = "Resetuj Graf";
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.addNodeButton);
            this.Controls.Add(this.addEdgeButton);
            this.Controls.Add(this.resetButton);
            this.Text = "Graf";
            this.Load += new System.EventHandler(this.Form1_Load);
        }
    }
}
