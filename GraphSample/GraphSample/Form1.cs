using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //create a form 
            //System.Windows.Forms.Form form = new System.Windows.Forms.Form();
            //create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            //create the graph content 
            graph.AddEdge("A", "B");
            graph.AddEdge("B", "C");
            graph.AddEdge("A", "C").Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
            graph.FindNode("A").Attr.FillColor = Microsoft.Msagl.Drawing.Color.Magenta;
            graph.FindNode("B").Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;
            Microsoft.Msagl.Drawing.Node c = graph.FindNode("C");
            c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.PaleGreen;
            c.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
            //bind the graph to the viewer 
            gViewer1.Graph = graph;

            gViewer1.Refresh();

            //associate the viewer with the form 
            //form.SuspendLayout();
            //this.SuspendLayout();
            //gViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.Controls.Add(viewer);
            //this.ResumeLayout();
            //show the form 
            //form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Microsoft.Msagl.Drawing.Graph graph = gViewer1.Graph;

            graph.AddEdge("C", "D");
            graph.FindNode("D").Attr.FillColor = Microsoft.Msagl.Drawing.Color.Orange;
            graph.FindNode("D").Attr.Shape = Microsoft.Msagl.Drawing.Shape.Hexagon;

            //bind the graph to the viewer 
            gViewer1.Graph = graph;

            gViewer1.Refresh();

        }
    }
}
