namespace TranslateRotateScale
{
    partial class frmTranslateRotateScaleDemo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTranslateRotateScaleDemo));
			this.axDeepView1 = new AxExploration3D.AxDeepView();
			this.button1 = new System.Windows.Forms.Button();
			this.MoveWorld = new System.Windows.Forms.Button();
			this.RotateWorld = new System.Windows.Forms.Button();
			this.ScaleWorld = new System.Windows.Forms.Button();
			this.MoveLocal = new System.Windows.Forms.Button();
			this.RotateLocal = new System.Windows.Forms.Button();
			this.ScaleLocal = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.axDeepView1)).BeginInit();
			this.SuspendLayout();
			// 
			// axDeepView1
			// 
			this.axDeepView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.axDeepView1.Enabled = true;
			this.axDeepView1.Location = new System.Drawing.Point(1, 134);
			this.axDeepView1.Name = "axDeepView1";
			this.axDeepView1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axDeepView1.OcxState")));
			this.axDeepView1.Size = new System.Drawing.Size(573, 357);
			this.axDeepView1.TabIndex = 0;
			this.axDeepView1.Enter += new System.EventHandler(this.axDeepView1_Enter);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(17, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(116, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "LoadFile()";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// MoveWorld
			// 
			this.MoveWorld.Location = new System.Drawing.Point(55, 52);
			this.MoveWorld.Name = "MoveWorld";
			this.MoveWorld.Size = new System.Drawing.Size(75, 23);
			this.MoveWorld.TabIndex = 2;
			this.MoveWorld.Text = "MoveWorld";
			this.MoveWorld.UseVisualStyleBackColor = true;
			this.MoveWorld.Click += new System.EventHandler(this.MoveWorld_Click);
			// 
			// RotateWorld
			// 
			this.RotateWorld.Location = new System.Drawing.Point(155, 51);
			this.RotateWorld.Name = "RotateWorld";
			this.RotateWorld.Size = new System.Drawing.Size(75, 23);
			this.RotateWorld.TabIndex = 3;
			this.RotateWorld.Text = "RotateWorld";
			this.RotateWorld.UseVisualStyleBackColor = true;
			this.RotateWorld.Click += new System.EventHandler(this.RotateWorld_Click);
			// 
			// ScaleWorld
			// 
			this.ScaleWorld.Location = new System.Drawing.Point(262, 50);
			this.ScaleWorld.Name = "ScaleWorld";
			this.ScaleWorld.Size = new System.Drawing.Size(75, 23);
			this.ScaleWorld.TabIndex = 4;
			this.ScaleWorld.Text = "ScaleWorld";
			this.ScaleWorld.UseVisualStyleBackColor = true;
			this.ScaleWorld.Click += new System.EventHandler(this.ScaleWorld_Click);
			// 
			// MoveLocal
			// 
			this.MoveLocal.Location = new System.Drawing.Point(55, 96);
			this.MoveLocal.Name = "MoveLocal";
			this.MoveLocal.Size = new System.Drawing.Size(75, 23);
			this.MoveLocal.TabIndex = 5;
			this.MoveLocal.Text = "MoveLocal";
			this.MoveLocal.UseVisualStyleBackColor = true;
			this.MoveLocal.Click += new System.EventHandler(this.MoveLocal_Click);
			// 
			// RotateLocal
			// 
			this.RotateLocal.Location = new System.Drawing.Point(155, 96);
			this.RotateLocal.Name = "RotateLocal";
			this.RotateLocal.Size = new System.Drawing.Size(75, 23);
			this.RotateLocal.TabIndex = 6;
			this.RotateLocal.Text = "RotateLocal";
			this.RotateLocal.UseVisualStyleBackColor = true;
			this.RotateLocal.Click += new System.EventHandler(this.RotateLocal_Click);
			// 
			// ScaleLocal
			// 
			this.ScaleLocal.Location = new System.Drawing.Point(262, 96);
			this.ScaleLocal.Name = "ScaleLocal";
			this.ScaleLocal.Size = new System.Drawing.Size(75, 23);
			this.ScaleLocal.TabIndex = 7;
			this.ScaleLocal.Text = "ScaleLocal";
			this.ScaleLocal.UseVisualStyleBackColor = true;
			this.ScaleLocal.Click += new System.EventHandler(this.ScaleLocal_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(155, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(334, 20);
			this.textBox1.TabIndex = 8;
			// 
			// frmTranslateRotateScaleDemo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(575, 490);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.ScaleLocal);
			this.Controls.Add(this.RotateLocal);
			this.Controls.Add(this.MoveLocal);
			this.Controls.Add(this.ScaleWorld);
			this.Controls.Add(this.RotateWorld);
			this.Controls.Add(this.MoveWorld);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.axDeepView1);
			this.Name = "frmTranslateRotateScaleDemo";
			this.Text = "Translate/Rotate/Scale Demo";
			((System.ComponentModel.ISupportInitialize)(this.axDeepView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private AxExploration3D.AxDeepView axDeepView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button MoveWorld;
        private System.Windows.Forms.Button RotateWorld;
        private System.Windows.Forms.Button ScaleWorld;
        private System.Windows.Forms.Button MoveLocal;
        private System.Windows.Forms.Button RotateLocal;
        private System.Windows.Forms.Button ScaleLocal;
        private System.Windows.Forms.TextBox textBox1;
    }
}

