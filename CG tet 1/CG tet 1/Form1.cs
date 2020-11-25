using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsGL.OpenGL;

namespace CG_tet_1
{
    public partial class Form1 : Form
    {
        Cgtest gl;
        public Form1()
        {
            InitializeComponent();
            gl = new Cgtest();
            gl.Parent = this;
            gl.Dock = DockStyle.Fill;
            gl.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
