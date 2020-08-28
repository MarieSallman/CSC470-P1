using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_Code
{
    public partial class FormHelloWorld : Form
    {
        public FormHelloWorld()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
