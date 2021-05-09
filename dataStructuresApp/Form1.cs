using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace dataStructuresApp
{
    public partial class Form1 : Form
    {

        Graph g = new Graph();
        Random randomNr = new Random(); //only required once
        Algorithm algorithm = new Algorithm();
        Stopwatch sw = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCreateGraph_Click(object sender, EventArgs e)
        {
            int numberDensity = 0;
            try
            {
                int vertices = Convert.ToInt32(tbNrVertices.Text);

                numberDensity = Convert.ToInt32(tbDensityProbability.Text);
                if (numberDensity < 0 || numberDensity > 100)
                {
                    numberDensity = 0;
                    throw new Exception();
                }
                g.initializeGraph(vertices);

            }
            catch
            {
                MessageBox.Show("Please enter a valid integer");
            }

            g.addEdgesOnProbability(numberDensity);
            g.connectedComponents();
            g.writeGraphToFile();
        }

        private void BtnConnectGraph_Click(object sender, EventArgs e)
        {
            g.connectGraph();
            g.connectedComponents();
            g.writeGraphToFile();
        }


        private void BtnCreateImage_Click(object sender, EventArgs e)
        {
            /*     
                Process dot = new Process();
                dot.StartInfo.FileName = "dot.exe";
                dot.StartInfo.Arguments = "-Tpng graph.dot -o graph.png";
                dot.Start();
                dot.WaitForExit(); 
                myPictureBox.ImageLocation = "graph.png"; */
            Process dot = new Process();
            dot.StartInfo.FileName = "dot.exe";
            dot.StartInfo.Arguments = "-Tpng graph.dot -o graph.png";
            dot.Start();
            dot.WaitForExit();
            myPictureBox.ImageLocation = "graph.png";
        }

        private int[] preprocess()
        {
            g.kernelization(Convert.ToInt32(maxVertexCover.Text));
            int[] cover = new int[g.GetVertices()] ;

            foreach (int top in g.getTops())
            {
                cover[top] = 2;
            }

            foreach (int  pendant in g.getPendants())
            {
                cover[g.getAdjListArray()[pendant][0]]=2;
            }

            return cover;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            sw.Start();

            g.setOk(true);
            bool algResult = algorithm.Validate(g, new bool[g.GetVertices()], g.GetVertices(), 0, Convert.ToInt32(maxVertexCover.Text));
            if (algResult)
            {
                result.Text = "TRUE";               
            }
            else
            {
                result.Text = "FALSE";
            }

            sw.Stop();
            Console.WriteLine();
            Console.WriteLine("Elapsed={0}", sw.Elapsed);
            sw.Reset();

        }

        private void BtnPendantMinus_Click(object sender, EventArgs e)
        {
            //selects an arbitrary *pendant* vertex and makes it a *non* pendant by *adding* arbitrary edges
            g.makeNonPendant();
            // g.writeGraphToFile();
            g.updateColorGraphToFile();
           
        }

        private void BtnPendantPlus_Click(object sender, EventArgs e)
        {
            //selects an arbitrary *non-pendant* vertex and makes it a pendant by *removing* arbitrary edges
            g.makePendant();
            // g.writeGraphToFile();
            g.updateColorGraphToFile();
            
        }

        private void BtnTopMinus_Click(object sender, EventArgs e)
        {
            //selects an arbitrary *tops* vertex and makes it a *non* tops by *removing* arbitrary edges.
            g.makeNonTop(Convert.ToInt32(tbEdgesForTop.Text));
            //g.writeGraphToFile();
            g.updateColorGraphToFile();
            
        }

        private void BtnTopPlus_Click(object sender, EventArgs e)
        {
            //selects an arbitrary *non-tops* vertex and makes it a tops by *adding* arbitrary edges.
            g.makeTop(Convert.ToInt32(tbEdgesForTop.Text));
            //g.writeGraphToFile();
            g.updateColorGraphToFile();
            
        }

        private void BtnKernelize_Click(object sender, EventArgs e)
        {            
            try
            {
                g.kernelization(Convert.ToInt32(tbEdgesForTop.Text));
                g.updateColorGraphToFile();
                BtnCreateImage_Click(this, e);
            }
            catch { MessageBox.Show("Write k in textbox"); }
        }

        private void BtnSmartSearch_Click(object sender, EventArgs e)
        {
           

            int[] coverInitial = preprocess();
            g.setOk(true);

            sw.Start();
            bool algResult = algorithm.ValidateSmart(g, coverInitial, g.GetVertices(), 0, Convert.ToInt32(maxVertexCover.Text));
            if (algResult)
            {
                result.Text = "TRUE";
            }
            else
            {
                result.Text = "FALSE";
            }

            sw.Stop();
            Console.WriteLine();
            Console.WriteLine("Elapsed={0}", sw.Elapsed);
            sw.Reset();
        }

        
        private void BtnAproxSearch_Click(object sender, EventArgs e)
        {
           

            sw.Start();
           


            //prints size of vertex cover and vertices that are in the cover
            algorithm.ValidateAprox(g, g.GetVertices());
            

            sw.Stop();
            Console.WriteLine();
            Console.WriteLine("Elapsed={0}", sw.Elapsed);
            sw.Reset();
        }
    }
}
