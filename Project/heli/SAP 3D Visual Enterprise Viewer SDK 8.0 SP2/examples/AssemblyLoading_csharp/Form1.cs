using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Exploration3D;
using System.Runtime.InteropServices; //DispidAttribute
using System.Reflection;//IReflect
using System.Collections;//Hashtable
using System.Globalization;//CultureInfo
using System.IO;


namespace AssemblyLoading
{


    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            Exploration3D.IDeepView dv = (Exploration3D.IDeepView)axDeepView1.GetOcx();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Please browse for an rh file to load");
                return;
            }

            Exploration3D.Resource resource = axDeepView1.Creator.Resource.Create(textBox1.Text);

            Exploration3D.Node n = null;

            try
            {
                n = axDeepView1.Scene.AddModel(resource);
            }
            catch (Exception)
            {

            }

            if (n != null)
            {
                float x = float.Parse(textBoxX.Text);
                float y = float.Parse(textBoxY.Text);
                float z = float.Parse(textBoxZ.Text);
                Exploration3D.Matrix4x4 moveVector = axDeepView1.Creator.Matrix4x4.Create3(1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, x, y, z, 1);
                n.Transform = moveVector;
                MessageBox.Show("added Model at (" + x + "," + y + "," + z + ")");
            }
            else
            {
                MessageBox.Show("addModel failed to load: '" + textBox1.Text + "'");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axDeepView1.LoadFile("data:blank");
        }

        private void LoadRHDotRH()
        {
            // This common code, is in its own function to make sure the hardcoded sample file is only referenced once
            Exploration3D.IDeepView dv = (Exploration3D.IDeepView)axDeepView1.GetOcx();
            dv.LoadFile("rh.rh");
        }

    }
}