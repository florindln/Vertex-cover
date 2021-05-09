namespace dataStructuresApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDensityProbability = new System.Windows.Forms.TextBox();
            this.tbNrVertices = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateImage = new System.Windows.Forms.Button();
            this.btnConnectGraph = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateGraph = new System.Windows.Forms.Button();
            this.myPictureBox = new System.Windows.Forms.PictureBox();
            this.maxVertexCover = new System.Windows.Forms.TextBox();
            this.BruteForce = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAproxSearch = new System.Windows.Forms.Button();
            this.btnSmartSearch = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPendantMinus = new System.Windows.Forms.Button();
            this.btnPendantPlus = new System.Windows.Forms.Button();
            this.btnTopMinus = new System.Windows.Forms.Button();
            this.btnTopPlus = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKernelize = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEdgesForTop = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDensityProbability);
            this.groupBox1.Controls.Add(this.tbNrVertices);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCreateImage);
            this.groupBox1.Controls.Add(this.btnConnectGraph);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCreateGraph);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 252);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GRAPH";
            // 
            // tbDensityProbability
            // 
            this.tbDensityProbability.Location = new System.Drawing.Point(62, 138);
            this.tbDensityProbability.Name = "tbDensityProbability";
            this.tbDensityProbability.Size = new System.Drawing.Size(100, 22);
            this.tbDensityProbability.TabIndex = 1;
            // 
            // tbNrVertices
            // 
            this.tbNrVertices.Location = new System.Drawing.Point(62, 80);
            this.tbNrVertices.Name = "tbNrVertices";
            this.tbNrVertices.Size = new System.Drawing.Size(100, 22);
            this.tbNrVertices.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of vertices";
            // 
            // btnCreateImage
            // 
            this.btnCreateImage.Location = new System.Drawing.Point(186, 13);
            this.btnCreateImage.Name = "btnCreateImage";
            this.btnCreateImage.Size = new System.Drawing.Size(121, 44);
            this.btnCreateImage.TabIndex = 9;
            this.btnCreateImage.Text = "Create Image";
            this.btnCreateImage.UseVisualStyleBackColor = true;
            this.btnCreateImage.Click += new System.EventHandler(this.BtnCreateImage_Click);
            // 
            // btnConnectGraph
            // 
            this.btnConnectGraph.Location = new System.Drawing.Point(169, 177);
            this.btnConnectGraph.Name = "btnConnectGraph";
            this.btnConnectGraph.Size = new System.Drawing.Size(120, 44);
            this.btnConnectGraph.TabIndex = 5;
            this.btnConnectGraph.Text = "Connect graph";
            this.btnConnectGraph.UseVisualStyleBackColor = true;
            this.btnConnectGraph.Click += new System.EventHandler(this.BtnConnectGraph_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Probability to connect 2 vertices (0-100)";
            // 
            // btnCreateGraph
            // 
            this.btnCreateGraph.Location = new System.Drawing.Point(27, 177);
            this.btnCreateGraph.Name = "btnCreateGraph";
            this.btnCreateGraph.Size = new System.Drawing.Size(121, 44);
            this.btnCreateGraph.TabIndex = 4;
            this.btnCreateGraph.Text = "Create Graph";
            this.btnCreateGraph.UseVisualStyleBackColor = true;
            this.btnCreateGraph.Click += new System.EventHandler(this.BtnCreateGraph_Click);
            // 
            // myPictureBox
            // 
            this.myPictureBox.Location = new System.Drawing.Point(412, 12);
            this.myPictureBox.Name = "myPictureBox";
            this.myPictureBox.Size = new System.Drawing.Size(735, 692);
            this.myPictureBox.TabIndex = 11;
            this.myPictureBox.TabStop = false;
            // 
            // maxVertexCover
            // 
            this.maxVertexCover.Location = new System.Drawing.Point(16, 66);
            this.maxVertexCover.Name = "maxVertexCover";
            this.maxVertexCover.Size = new System.Drawing.Size(103, 22);
            this.maxVertexCover.TabIndex = 12;
            // 
            // BruteForce
            // 
            this.BruteForce.Location = new System.Drawing.Point(134, 49);
            this.BruteForce.Name = "BruteForce";
            this.BruteForce.Size = new System.Drawing.Size(155, 24);
            this.BruteForce.TabIndex = 13;
            this.BruteForce.Text = "Brute Force Search";
            this.BruteForce.UseVisualStyleBackColor = true;
            this.BruteForce.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAproxSearch);
            this.groupBox2.Controls.Add(this.btnSmartSearch);
            this.groupBox2.Controls.Add(this.result);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.maxVertexCover);
            this.groupBox2.Controls.Add(this.BruteForce);
            this.groupBox2.Location = new System.Drawing.Point(12, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 176);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BRUTE FORCE SEARCH";
            // 
            // btnAproxSearch
            // 
            this.btnAproxSearch.Location = new System.Drawing.Point(16, 146);
            this.btnAproxSearch.Name = "btnAproxSearch";
            this.btnAproxSearch.Size = new System.Drawing.Size(273, 24);
            this.btnAproxSearch.TabIndex = 18;
            this.btnAproxSearch.Text = "Approximate search";
            this.btnAproxSearch.UseVisualStyleBackColor = true;
            this.btnAproxSearch.Click += new System.EventHandler(this.BtnAproxSearch_Click);
            // 
            // btnSmartSearch
            // 
            this.btnSmartSearch.Location = new System.Drawing.Point(134, 79);
            this.btnSmartSearch.Name = "btnSmartSearch";
            this.btnSmartSearch.Size = new System.Drawing.Size(155, 24);
            this.btnSmartSearch.TabIndex = 17;
            this.btnSmartSearch.Text = "Smart search";
            this.btnSmartSearch.UseVisualStyleBackColor = true;
            this.btnSmartSearch.Click += new System.EventHandler(this.BtnSmartSearch_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(116, 117);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(32, 17);
            this.result.TabIndex = 16;
            this.result.Text = ". . . \r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "RESULT:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Enter the size k of the vertex cover:\r\n";
            // 
            // btnPendantMinus
            // 
            this.btnPendantMinus.Location = new System.Drawing.Point(14, 69);
            this.btnPendantMinus.Name = "btnPendantMinus";
            this.btnPendantMinus.Size = new System.Drawing.Size(79, 36);
            this.btnPendantMinus.TabIndex = 15;
            this.btnPendantMinus.Text = "p--";
            this.btnPendantMinus.UseVisualStyleBackColor = true;
            this.btnPendantMinus.Click += new System.EventHandler(this.BtnPendantMinus_Click);
            // 
            // btnPendantPlus
            // 
            this.btnPendantPlus.Location = new System.Drawing.Point(109, 69);
            this.btnPendantPlus.Name = "btnPendantPlus";
            this.btnPendantPlus.Size = new System.Drawing.Size(75, 36);
            this.btnPendantPlus.TabIndex = 16;
            this.btnPendantPlus.Text = "p++";
            this.btnPendantPlus.UseVisualStyleBackColor = true;
            this.btnPendantPlus.Click += new System.EventHandler(this.BtnPendantPlus_Click);
            // 
            // btnTopMinus
            // 
            this.btnTopMinus.Location = new System.Drawing.Point(199, 69);
            this.btnTopMinus.Name = "btnTopMinus";
            this.btnTopMinus.Size = new System.Drawing.Size(75, 36);
            this.btnTopMinus.TabIndex = 17;
            this.btnTopMinus.Text = "t--";
            this.btnTopMinus.UseVisualStyleBackColor = true;
            this.btnTopMinus.Click += new System.EventHandler(this.BtnTopMinus_Click);
            // 
            // btnTopPlus
            // 
            this.btnTopPlus.Location = new System.Drawing.Point(280, 69);
            this.btnTopPlus.Name = "btnTopPlus";
            this.btnTopPlus.Size = new System.Drawing.Size(81, 36);
            this.btnTopPlus.TabIndex = 18;
            this.btnTopPlus.Text = "t++";
            this.btnTopPlus.UseVisualStyleBackColor = true;
            this.btnTopPlus.Click += new System.EventHandler(this.BtnTopPlus_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKernelize);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbEdgesForTop);
            this.groupBox3.Controls.Add(this.btnTopMinus);
            this.groupBox3.Controls.Add(this.btnPendantMinus);
            this.groupBox3.Controls.Add(this.btnPendantPlus);
            this.groupBox3.Controls.Add(this.btnTopPlus);
            this.groupBox3.Location = new System.Drawing.Point(12, 467);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 129);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pendants and tops";
            // 
            // btnKernelize
            // 
            this.btnKernelize.Location = new System.Drawing.Point(261, 21);
            this.btnKernelize.Name = "btnKernelize";
            this.btnKernelize.Size = new System.Drawing.Size(100, 42);
            this.btnKernelize.TabIndex = 20;
            this.btnKernelize.Text = "Visualize colors";
            this.btnKernelize.UseVisualStyleBackColor = true;
            this.btnKernelize.Click += new System.EventHandler(this.BtnKernelize_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Edges for top";
            // 
            // tbEdgesForTop
            // 
            this.tbEdgesForTop.Location = new System.Drawing.Point(144, 35);
            this.tbEdgesForTop.Name = "tbEdgesForTop";
            this.tbEdgesForTop.Size = new System.Drawing.Size(100, 22);
            this.tbEdgesForTop.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 717);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.myPictureBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbDensityProbability;
        private System.Windows.Forms.TextBox tbNrVertices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnectGraph;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateGraph;
        private System.Windows.Forms.Button btnCreateImage;
        private System.Windows.Forms.PictureBox myPictureBox;
        private System.Windows.Forms.TextBox maxVertexCover;
        private System.Windows.Forms.Button BruteForce;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button btnPendantMinus;
        private System.Windows.Forms.Button btnPendantPlus;
        private System.Windows.Forms.Button btnTopMinus;
        private System.Windows.Forms.Button btnTopPlus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEdgesForTop;
        private System.Windows.Forms.Button btnKernelize;
        private System.Windows.Forms.Button btnSmartSearch;
        private System.Windows.Forms.Button btnAproxSearch;
    }
}

