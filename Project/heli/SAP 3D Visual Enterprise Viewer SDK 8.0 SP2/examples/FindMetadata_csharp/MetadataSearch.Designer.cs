namespace FindMetadata
{
    partial class MetadataSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetadataSearch));
            this.txtMetadata = new System.Windows.Forms.TextBox();
            this.btnSelectNodes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSelection = new System.Windows.Forms.TextBox();
            this.axDeepView = new AxExploration3D.AxDeepView();
            ((System.ComponentModel.ISupportInitialize)(this.axDeepView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMetadata
            // 
            this.txtMetadata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMetadata.Location = new System.Drawing.Point(15, 25);
            this.txtMetadata.Name = "txtMetadata";
            this.txtMetadata.Size = new System.Drawing.Size(350, 20);
            this.txtMetadata.TabIndex = 1;
            // 
            // btnSelectNodes
            // 
            this.btnSelectNodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectNodes.Location = new System.Drawing.Point(371, 22);
            this.btnSelectNodes.Name = "btnSelectNodes";
            this.btnSelectNodes.Size = new System.Drawing.Size(92, 23);
            this.btnSelectNodes.TabIndex = 2;
            this.btnSelectNodes.Text = "Find";
            this.btnSelectNodes.UseVisualStyleBackColor = true;
            this.btnSelectNodes.Click += new System.EventHandler(this.btnSelectNodes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type the color to select nodes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "The colors of selected nodes:";
            // 
            // txtSelection
            // 
            this.txtSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelection.Location = new System.Drawing.Point(15, 75);
            this.txtSelection.Name = "txtSelection";
            this.txtSelection.ReadOnly = true;
            this.txtSelection.Size = new System.Drawing.Size(448, 20);
            this.txtSelection.TabIndex = 1;
            this.txtSelection.Text = "None";
            // 
            // axDeepView
            // 
            this.axDeepView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.axDeepView.Enabled = true;
            this.axDeepView.Location = new System.Drawing.Point(0, 101);
            this.axDeepView.Name = "axDeepView";
            this.axDeepView.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axDeepView.OcxState")));
            this.axDeepView.Size = new System.Drawing.Size(475, 273);
            this.axDeepView.TabIndex = 0;
            // 
            // MetadataSearch
            // 
            this.AcceptButton = this.btnSelectNodes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 374);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectNodes);
            this.Controls.Add(this.axDeepView);
            this.Controls.Add(this.txtSelection);
            this.Controls.Add(this.txtMetadata);
            this.Name = "MetadataSearch";
            this.Text = "Select Nodes By Metadata";
            ((System.ComponentModel.ISupportInitialize)(this.axDeepView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxExploration3D.AxDeepView axDeepView;
        private System.Windows.Forms.TextBox txtMetadata;
        private System.Windows.Forms.Button btnSelectNodes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSelection;
    }
}

