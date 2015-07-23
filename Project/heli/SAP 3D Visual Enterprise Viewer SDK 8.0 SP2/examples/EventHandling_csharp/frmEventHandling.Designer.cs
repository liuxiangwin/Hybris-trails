namespace EventHandling
{
    partial class frmEventHandling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEventHandling));
            this.axDeepView = new AxExploration3D.AxDeepView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mouseEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseHitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseOverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseMoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseDoubleClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEvents = new System.Windows.Forms.TextBox();
            this.miscellaneousEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.axDeepView)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axDeepView
            // 
            this.axDeepView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axDeepView.Enabled = true;
            this.axDeepView.Location = new System.Drawing.Point(0, 24);
            this.axDeepView.Name = "axDeepView";
            this.axDeepView.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axDeepView.OcxState")));
            this.axDeepView.Size = new System.Drawing.Size(434, 163);
            this.axDeepView.TabIndex = 0;
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
            this.splitContainer1.Panel1.Controls.Add(this.axDeepView);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtEvents);
            this.splitContainer1.Size = new System.Drawing.Size(434, 374);
            this.splitContainer1.SplitterDistance = 187;
            this.splitContainer1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mouseEventsToolStripMenuItem,
            this.miscellaneousEventsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mouseEventsToolStripMenuItem
            // 
            this.mouseEventsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mouseUpToolStripMenuItem,
            this.mouseDownToolStripMenuItem,
            this.mouseHitToolStripMenuItem,
            this.mouseOverToolStripMenuItem,
            this.mouseOutToolStripMenuItem,
            this.mouseMoveToolStripMenuItem,
            this.mouseDoubleClickToolStripMenuItem});
            this.mouseEventsToolStripMenuItem.Name = "mouseEventsToolStripMenuItem";
            this.mouseEventsToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.mouseEventsToolStripMenuItem.Text = "Mouse Events";
            // 
            // mouseUpToolStripMenuItem
            // 
            this.mouseUpToolStripMenuItem.CheckOnClick = true;
            this.mouseUpToolStripMenuItem.Name = "mouseUpToolStripMenuItem";
            this.mouseUpToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.mouseUpToolStripMenuItem.Text = "MouseUp";
            this.mouseUpToolStripMenuItem.CheckedChanged += new System.EventHandler(this.mouseUpToolStripMenuItem_CheckedChanged);
            // 
            // mouseDownToolStripMenuItem
            // 
            this.mouseDownToolStripMenuItem.CheckOnClick = true;
            this.mouseDownToolStripMenuItem.Name = "mouseDownToolStripMenuItem";
            this.mouseDownToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.mouseDownToolStripMenuItem.Text = "MouseDown";
            this.mouseDownToolStripMenuItem.CheckedChanged += new System.EventHandler(this.mouseDownToolStripMenuItem_CheckedChanged);
            // 
            // mouseHitToolStripMenuItem
            // 
            this.mouseHitToolStripMenuItem.CheckOnClick = true;
            this.mouseHitToolStripMenuItem.Name = "mouseHitToolStripMenuItem";
            this.mouseHitToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.mouseHitToolStripMenuItem.Text = "MouseHit";
            this.mouseHitToolStripMenuItem.Click += new System.EventHandler(this.mouseHitToolStripMenuItem_Click);
            // 
            // mouseOverToolStripMenuItem
            // 
            this.mouseOverToolStripMenuItem.CheckOnClick = true;
            this.mouseOverToolStripMenuItem.Name = "mouseOverToolStripMenuItem";
            this.mouseOverToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.mouseOverToolStripMenuItem.Text = "MouseOver";
            this.mouseOverToolStripMenuItem.Click += new System.EventHandler(this.mouseOverToolStripMenuItem_Click);
            // 
            // mouseOutToolStripMenuItem
            // 
            this.mouseOutToolStripMenuItem.CheckOnClick = true;
            this.mouseOutToolStripMenuItem.Name = "mouseOutToolStripMenuItem";
            this.mouseOutToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.mouseOutToolStripMenuItem.Text = "MouseOut";
            this.mouseOutToolStripMenuItem.Click += new System.EventHandler(this.mouseOutToolStripMenuItem_Click);
            // 
            // mouseMoveToolStripMenuItem
            // 
            this.mouseMoveToolStripMenuItem.CheckOnClick = true;
            this.mouseMoveToolStripMenuItem.Name = "mouseMoveToolStripMenuItem";
            this.mouseMoveToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.mouseMoveToolStripMenuItem.Text = "MouseMove";
            this.mouseMoveToolStripMenuItem.Click += new System.EventHandler(this.mouseMoveToolStripMenuItem_Click);
            // 
            // mouseDoubleClickToolStripMenuItem
            // 
            this.mouseDoubleClickToolStripMenuItem.CheckOnClick = true;
            this.mouseDoubleClickToolStripMenuItem.Name = "mouseDoubleClickToolStripMenuItem";
            this.mouseDoubleClickToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.mouseDoubleClickToolStripMenuItem.Text = "MouseDoubleClick";
            this.mouseDoubleClickToolStripMenuItem.Click += new System.EventHandler(this.mouseDoubleClickToolStripMenuItem_Click);
            // 
            // txtEvents
            // 
            this.txtEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEvents.Location = new System.Drawing.Point(0, 0);
            this.txtEvents.Multiline = true;
            this.txtEvents.Name = "txtEvents";
            this.txtEvents.Size = new System.Drawing.Size(434, 183);
            this.txtEvents.TabIndex = 0;
            // 
            // miscellaneousEventsToolStripMenuItem
            // 
            this.miscellaneousEventsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeToolStripMenuItem,
            this.modelToolStripMenuItem,
            this.stepToolStripMenuItem,
            this.conversationToolStripMenuItem,
            this.keyToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.menuToolStripMenuItem});
            this.miscellaneousEventsToolStripMenuItem.Name = "miscellaneousEventsToolStripMenuItem";
            this.miscellaneousEventsToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.miscellaneousEventsToolStripMenuItem.Text = "Miscellaneous Events";
            // 
            // timeToolStripMenuItem
            // 
            this.timeToolStripMenuItem.CheckOnClick = true;
            this.timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            this.timeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.timeToolStripMenuItem.Text = "Time";
            this.timeToolStripMenuItem.Click += new System.EventHandler(this.timeToolStripMenuItem_Click);
            // 
            // modelToolStripMenuItem
            // 
            this.modelToolStripMenuItem.CheckOnClick = true;
            this.modelToolStripMenuItem.Name = "modelToolStripMenuItem";
            this.modelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modelToolStripMenuItem.Text = "Model";
            this.modelToolStripMenuItem.Click += new System.EventHandler(this.modelToolStripMenuItem_Click);
            // 
            // stepToolStripMenuItem
            // 
            this.stepToolStripMenuItem.CheckOnClick = true;
            this.stepToolStripMenuItem.Name = "stepToolStripMenuItem";
            this.stepToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stepToolStripMenuItem.Text = "Step";
            this.stepToolStripMenuItem.Click += new System.EventHandler(this.stepToolStripMenuItem_Click);
            // 
            // conversationToolStripMenuItem
            // 
            this.conversationToolStripMenuItem.CheckOnClick = true;
            this.conversationToolStripMenuItem.Name = "conversationToolStripMenuItem";
            this.conversationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.conversationToolStripMenuItem.Text = "Conversation";
            this.conversationToolStripMenuItem.Click += new System.EventHandler(this.conversationToolStripMenuItem_Click);
            // 
            // keyToolStripMenuItem
            // 
            this.keyToolStripMenuItem.CheckOnClick = true;
            this.keyToolStripMenuItem.Name = "keyToolStripMenuItem";
            this.keyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.keyToolStripMenuItem.Text = "Key";
            this.keyToolStripMenuItem.Click += new System.EventHandler(this.keyToolStripMenuItem_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.CheckOnClick = true;
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.toolToolStripMenuItem.Text = "Tool";
            this.toolToolStripMenuItem.Click += new System.EventHandler(this.toolToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.CheckOnClick = true;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // frmEventHandling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 374);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEventHandling";
            this.Text = "Event Handling";
            this.Load += new System.EventHandler(this.frmEventHandling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axDeepView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AxExploration3D.AxDeepView axDeepView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtEvents;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mouseEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouseUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouseDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouseHitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouseOverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouseOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouseMoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouseDoubleClickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miscellaneousEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
    }
}

