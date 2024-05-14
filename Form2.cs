using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_atestat
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form2.ActiveForm.Activate();

        }

        private void Restart_Click(object sender, EventArgs e)
        {
           
            Form2.ActiveForm.Hide();
            Form1.ActiveForm.Show();
            Form1.ActiveForm.Activate();
             
            
        }
    }
}
