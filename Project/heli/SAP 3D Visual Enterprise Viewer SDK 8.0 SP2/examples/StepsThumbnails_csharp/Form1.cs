using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Exploration3D;

namespace WindowsApplication2
{
    public partial class frmStepThumbnailDemo : Form
    {
        public int WIDTH = 80;
        public int HEIGHT = 60;
        public frmStepThumbnailDemo()
        {
            InitializeComponent();
        }

        private void axDeepViewControl1_Enter(object sender, EventArgs e)
        {
            axDeepViewControl1.LoadFile("MVsStepsCalloutsMetadata.rh");
        }

        private void UpdatePictureFromString(String tn, int width, int height)
        {
             //Get the hex values from thumbnail string
            int pxCount = 0;
            //String array to hold the hex values
            String[] strHexValues = new String[width * height];
            //Get every 6 characters out of the string and into the string array
            for (int ii = 0; ii < tn.Length / 6; ii++)
            {
                //Set the value and prefix with a # so that ColorTranslator.FromHtml
                //function below works
                strHexValues[ii] = "#" + tn.Substring(pxCount, 6);
                pxCount += 6;
            }

            //Convert the hex values to colours
            //Create a Color array to store the pixel colours
            System.Drawing.Color[] colPixelColour = new System.Drawing.Color[width * height];
            //For each pixel in the thumbnail
            for (int xx = 0; xx < width * height; xx++)
            {
                //Put the colour in the Color array
                colPixelColour[xx] = System.Drawing.ColorTranslator.FromHtml(strHexValues[xx]);
            }

            //Create a bitmap that is the same size as the thumbnail
            Bitmap bmThumbnail = new Bitmap(width, height);
            //Reset the count
            pxCount = 0;

            //For each pixel row in height
            for (int yy = 0; yy < height; yy++)
            {
                //For each pixel in a row
                for (int zz = 0; zz < width; zz++)
                {
                    //Set the pixel with colour
                    bmThumbnail.SetPixel(zz, yy, colPixelColour[pxCount]);
                    //Increment the count for each pixel
                    pxCount++;
                }
            }
            //Set the forms picture box to equal the thumbnail
            pictureBox1.Image = bmThumbnail;
            //Save the PNG to disc
            bmThumbnail.Save("C:\\Thumbnail.png");
        }

        private void axDeepViewControl1_SceneLoadedEvent(object sender, AxExploration3D.IDeepViewEvents_SceneLoadedEvent e)
        {
            Procedure p = (Procedure)axDeepViewControl1.Scene.Procedures.GetByIndex(0);
            Step s = (Step)p.Steps.GetByIndex(0);
            s.UpdateThumbnail();
            String tn = s.Thumbnail.AsRGBHexString;
        }

        private void GetStepThumbnail_Click(object sender, EventArgs e)
        {
            ProcedureCollection procedures = axDeepViewControl1.Scene.Procedures;
            
            int procedureIndex = (int) this.Procedure.Value;
            
            if(procedureIndex  >= 0 && procedureIndex < procedures.Count )
            {
                Procedure procedure = procedures.GetByIndex( procedureIndex);
                SceneObjectList steps = procedure.Steps;

                int stepIndex = (int)this.Step.Value;
                if(stepIndex >=0 && stepIndex < steps.Count )
                {
                    Step step = (Step)steps.GetByIndex(stepIndex);
                    step.UpdateThumbnail();
                    String tn = step.Thumbnail.AsRGBHexString;
                    UpdatePictureFromString(tn, WIDTH, HEIGHT);
                }
                else
                {
                    MessageBox.Show("Step index: " + stepIndex + " exceeds maximum of " + steps.Count);
                }
            }else
            {
                MessageBox.Show("Procedure index: " + procedureIndex + " exceeds maximum of " + procedures.Count);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PortfolioCollection portfolios = axDeepViewControl1.Scene.Portfolios;

            int portfolioIndex = (int)this.Portfolio.Value;

            if (portfolioIndex >= 0 && portfolioIndex < portfolios.Count)
            {
                Portfolio portfolio = portfolios.GetByIndex(portfolioIndex);
                SceneObjectList modelviews = portfolio.Views;

                int modelviewIndex = (int)this.Modelview.Value;
                if (modelviewIndex >= 0 && modelviewIndex < modelviews.Count)
                {
                    ModelView modelview = (ModelView)modelviews.GetByIndex(modelviewIndex);
                    modelview.UpdateThumbnail();
                    String tn = modelview.Thumbnail.AsRGBHexString;
                    UpdatePictureFromString(tn, WIDTH, HEIGHT);
                }
                else
                {
                    MessageBox.Show("Modelview index: " + modelviewIndex + " exceeds maximum of " + modelviews.Count);
                }
            }
            else
            {
                MessageBox.Show("Portfolio index: " + portfolioIndex + " exceeds maximum of " + portfolios.Count);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            int iImgWidth = axDeepViewControl1.Width;
            int iImgHeight = axDeepViewControl1.Height;
            String ts = axDeepViewControl1.GetScreenshot(iImgWidth, iImgHeight);
            UpdatePictureFromString(ts, iImgWidth, iImgHeight);
        }
    }
}