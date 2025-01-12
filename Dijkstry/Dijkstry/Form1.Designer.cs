namespace Dijkstry
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtStartNode = new System.Windows.Forms.TextBox();
            this.txtGraph = new System.Windows.Forms.TextBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btnRunDijkstra = new System.Windows.Forms.Button();
            this.btnAddEdge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(24, 12);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(83, 20);
            this.txtFrom.TabIndex = 0;
            this.txtFrom.TextChanged += new System.EventHandler(this.txtFrom_TextChanged);
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(24, 38);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(83, 20);
            this.txtTo.TabIndex = 1;
            this.txtTo.TextChanged += new System.EventHandler(this.txtTo_TextChanged);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(24, 64);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(83, 20);
            this.txtWeight.TabIndex = 2;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // txtStartNode
            // 
            this.txtStartNode.Location = new System.Drawing.Point(24, 90);
            this.txtStartNode.Name = "txtStartNode";
            this.txtStartNode.Size = new System.Drawing.Size(83, 20);
            this.txtStartNode.TabIndex = 3;
            this.txtStartNode.TextChanged += new System.EventHandler(this.txtStartNode_TextChanged);
            // 
            // txtGraph
            // 
            this.txtGraph.Location = new System.Drawing.Point(24, 117);
            this.txtGraph.Name = "txtGraph";
            this.txtGraph.Size = new System.Drawing.Size(750, 20);
            this.txtGraph.TabIndex = 4;
            this.txtGraph.TextChanged += new System.EventHandler(this.txtGraph_TextChanged);
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(24, 143);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(750, 20);
            this.txtResults.TabIndex = 5;
            this.txtResults.TextChanged += new System.EventHandler(this.txtResults_TextChanged);
            // 
            // btnRunDijkstra
            // 
            this.btnRunDijkstra.Location = new System.Drawing.Point(177, 87);
            this.btnRunDijkstra.Name = "btnRunDijkstra";
            this.btnRunDijkstra.Size = new System.Drawing.Size(75, 23);
            this.btnRunDijkstra.TabIndex = 6;
            this.btnRunDijkstra.Text = "Run Dijkstry";
            this.btnRunDijkstra.UseVisualStyleBackColor = true;
            this.btnRunDijkstra.Click += new System.EventHandler(this.btnRunDijkstra_Click);
            // 
            // btnAddEdge
            // 
            this.btnAddEdge.Location = new System.Drawing.Point(177, 61);
            this.btnAddEdge.Name = "btnAddEdge";
            this.btnAddEdge.Size = new System.Drawing.Size(75, 23);
            this.btnAddEdge.TabIndex = 7;
            this.btnAddEdge.Text = "Add Edge";
            this.btnAddEdge.UseVisualStyleBackColor = true;
            this.btnAddEdge.Click += new System.EventHandler(this.btnAddEdge_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Start Node";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Weight";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 174);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddEdge);
            this.Controls.Add(this.btnRunDijkstra);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.txtGraph);
            this.Controls.Add(this.txtStartNode);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtStartNode;
        private System.Windows.Forms.TextBox txtGraph;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnRunDijkstra;
        private System.Windows.Forms.Button btnAddEdge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

