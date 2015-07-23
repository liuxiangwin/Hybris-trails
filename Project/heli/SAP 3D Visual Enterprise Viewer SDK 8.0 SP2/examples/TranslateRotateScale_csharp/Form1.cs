using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Exploration3D;

namespace TranslateRotateScale
{
    public partial class frmTranslateRotateScaleDemo : Form
    {
        public frmTranslateRotateScaleDemo()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            axDeepView1.LoadFile(textBox1.Text);
        }

        private void axDeepView1_Enter(object sender, EventArgs e)
        {

        }

        private Exploration3D.Node getSelected()
        {
			NodeCollection selectedNodes = axDeepView1.Scene.SelectedNodes;
			if (selectedNodes.Count == 0)
				return null;

			return selectedNodes[0];
        }

        void BadNodeWarning()
        {
            MessageBox.Show("nothing selected");
        }

        private void MoveWorld_Click(object sender, EventArgs e)
        {
            Exploration3D.Node n = getSelected();
            if (n == null)
            {
                BadNodeWarning();
                return;
            }

            // rotate in world coords
            Exploration3D.Vector3 aBit = axDeepView1.Creator.Vector3.Create(10, 0, 0);
            n.Transform.TranslateInPlace(aBit);
            axDeepView1.Scene.Update();
        }

        private void MoveLocal_Click(object sender, EventArgs e)
        {
            Exploration3D.Node n = getSelected();
            if (n == null)
            {
                BadNodeWarning();
                return;
            }

            // move in local coords
            Exploration3D.Vector3 vector = axDeepView1.Creator.Vector3.Create(10, 0, 0);
            try{
                vector = n.Parent.Transform.TransformDirection(vector);
            }
            catch(Exception)
            {
            }
            n.Transform.TranslateInPlace(vector);
            axDeepView1.Scene.Update();
        }

        private void RotateWorld_Click(object sender, EventArgs e)
        {
            Exploration3D.Node n = getSelected();
            if (n == null)
            {
                BadNodeWarning();
                return;
            }

            // rotate in world coords
            n.Transform.RotateAboutZInPlace(3.14159/7);
            axDeepView1.Scene.Update();
        }

        private void RotateLocal_Click(object sender, EventArgs e)
        {
            Exploration3D.Node n = getSelected();
            if (n == null)
            {
                BadNodeWarning();
                return;
            }

            // rotate in local coords
            Exploration3D.Vector3 vFromOrigin = n.Transform.Translation;
            Exploration3D.Vector3 vToOrigin = axDeepView1.Creator.Vector3.Create(-vFromOrigin.X, -vFromOrigin.Y, -vFromOrigin.Z);
            n.Transform.TranslateInPlace(vToOrigin);
            n.Transform.RotateAboutZInPlace(3.14159 / 7);
            n.Transform.TranslateInPlace(vFromOrigin);
            axDeepView1.Scene.Update();
        }

        private void ScaleWorld_Click(object sender, EventArgs e)
        {
            Exploration3D.Node n = getSelected();
            if (n == null)
            {
                BadNodeWarning();
                return;
            }

            // rotate in world coords
            n.Transform.ScaleInPlace(1.1, 1.1, 1.1);
            axDeepView1.Scene.Update();
        }

        private void ScaleLocal_Click(object sender, EventArgs e)
        {
            Exploration3D.Node n = getSelected();
            if (n == null)
            {
                BadNodeWarning();
                return;
            }

            // scale in local coords
            Exploration3D.Vector3 vFromOrigin = n.Transform.Translation;
            Exploration3D.Vector3 vToOrigin = axDeepView1.Creator.Vector3.Create(-vFromOrigin.X, -vFromOrigin.Y, -vFromOrigin.Z);
            n.Transform.TranslateInPlace(vToOrigin);
            n.Transform.ScaleInPlace(1.1, 1.1, 1.1);
            n.Transform.TranslateInPlace(vFromOrigin);
            axDeepView1.Scene.Update();
        }





    }
}