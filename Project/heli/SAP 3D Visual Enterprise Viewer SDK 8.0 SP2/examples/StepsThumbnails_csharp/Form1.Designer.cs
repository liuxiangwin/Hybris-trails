namespace WindowsApplication2
{
    partial class frmStepThumbnailDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStepThumbnailDemo));
            this.axDeepViewControl1 = new AxExploration3D.AxDeepView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Modelview = new System.Windows.Forms.NumericUpDown();
            this.Step = new System.Windows.Forms.NumericUpDown();
            this.Portfolio = new System.Windows.Forms.NumericUpDown();
            this.Procedure = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GetStepThumbnail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axDeepViewControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Modelview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Step)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Portfolio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Procedure)).BeginInit();
            this.SuspendLayout();
            // 
            // axDeepViewControl1
            // 
            this.axDeepViewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axDeepViewControl1.Enabled = true;
            this.axDeepViewControl1.Location = new System.Drawing.Point(0, 0);
            this.axDeepViewControl1.Name = "axDeepViewControl1";
            this.axDeepViewControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axDeepViewControl1.OcxState")));
            this.axDeepViewControl1.Size = new System.Drawing.Size(609, 255);
            this.axDeepViewControl1.TabIndex = 0;
            this.axDeepViewControl1.Enter += new System.EventHandler(this.axDeepViewControl1_Enter);
            this.axDeepViewControl1.SceneLoadedEvent += new AxExploration3D.IDeepViewEvents_SceneLoadedEventHandler(this.axDeepViewControl1_SceneLoadedEvent);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(609, 251);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.axDeepViewControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Modelview);
            this.splitContainer1.Panel2.Controls.Add(this.Step);
            this.splitContainer1.Panel2.Controls.Add(this.Portfolio);
            this.splitContainer1.Panel2.Controls.Add(this.Procedure);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.GetStepThumbnail);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(609, 510);
            this.splitContainer1.SplitterDistance = 255;
            this.splitContainer1.TabIndex = 2;
            // 
            // Modelview
            // 
            this.Modelview.Location = new System.Drawing.Point(259, 79);
            this.Modelview.Name = "Modelview";
            this.Modelview.Size = new System.Drawing.Size(33, 20);
            this.Modelview.TabIndex = 6;
            // 
            // Step
            // 
            this.Step.Location = new System.Drawing.Point(259, 18);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(33, 20);
            this.Step.TabIndex = 6;
            // 
            // Portfolio
            // 
            this.Portfolio.Location = new System.Drawing.Point(111, 81);
            this.Portfolio.Name = "Portfolio";
            this.Portfolio.Size = new System.Drawing.Size(34, 20);
            this.Portfolio.TabIndex = 6;
            // 
            // Procedure
            // 
            this.Procedure.Location = new System.Drawing.Point(111, 20);
            this.Procedure.Name = "Procedure";
            this.Procedure.Size = new System.Drawing.Size(34, 20);
            this.Procedure.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ModelView";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Step";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Portfolio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Procedure";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(341, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "GetScreenshot";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get Modelview Thumbnail";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GetStepThumbnail
            // 
            this.GetStepThumbnail.Location = new System.Drawing.Point(341, 20);
            this.GetStepThumbnail.Name = "GetStepThumbnail";
            this.GetStepThumbnail.Size = new System.Drawing.Size(234, 23);
            this.GetStepThumbnail.TabIndex = 2;
            this.GetStepThumbnail.Text = "Get Step Thumbnail";
            this.GetStepThumbnail.UseVisualStyleBackColor = true;
            this.GetStepThumbnail.Click += new System.EventHandler(this.GetStepThumbnail_Click);
            // 
            // frmStepThumbnailDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 510);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmStepThumbnailDemo";
            this.Text = "Step Thumbnail Demo";
            ((System.ComponentModel.ISupportInitialize)(this.axDeepViewControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Modelview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Step)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Portfolio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Procedure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxExploration3D.AxDeepView axDeepViewControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GetStepThumbnail;
        private System.Windows.Forms.NumericUpDown Modelview;
        private System.Windows.Forms.NumericUpDown Step;
        private System.Windows.Forms.NumericUpDown Portfolio;
        private System.Windows.Forms.NumericUpDown Procedure;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

