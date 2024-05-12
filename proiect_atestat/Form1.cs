using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace proiect_atestat
{
    public partial class Form1 : Form
    {

        int v_juc=40, v_curenta=30,penalizari=0,indicator_img;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void penalizare1()
        {
            if (jucator.Bounds.IntersectsWith(masina_albastra.Bounds) || jucator.Bounds.IntersectsWith(masina_verde.Bounds))
            {

              
                timer1.Enabled = false;
                restart_buton.Enabled = true;
                

               
                

                restart_buton.Show();
                
               
            }
        
        
        }
        private void indicatoare(int v2)
        {
            Random rnd = new Random();
            int x, y;


         
            if (indicator.Top >= 656)
            {
                indicator.Top = 0;
                

                Random rnd2 = new Random();
                indicator_img = rnd2.Next(1, 2);
                string[] lista_ind;
                lista_ind=Directory.GetFiles(Directory.GetCurrentDirectory()+ @"\resurse joc\indicatoarele");

              
                        indicator.Load(lista_ind[indicator_img]);
                
                      


            }
            else
            {
               
                indicator.Top += v2;
            }
            
         /*   if (var1_a.Checked) {var2_a.Enabled = false;
                var3_a.Enabled = false;
                var1_a.Enabled = false;
                penalizari += 1;

                var1_a.Hide();
                var2_a.Hide();
                var3_a.Hide();
                intrebare.Hide();



            }
            if(var2_a.Checked)
            {
                var2_a.Enabled = false;
                var3_a.Enabled = false;
                var1_a.Enabled = false;
                penalizari += 1;

                var1_a.Hide();
                var2_a.Hide();
                var3_a.Hide();
                intrebare.Hide();


            }
            if (var3_a.Checked)
            {
                var2_a.Enabled = false;
                var3_a.Enabled = false;
                var1_a.Enabled = false;
                

                var1_a.Hide();
                var2_a.Hide();
                var3_a.Hide();
                intrebare.Hide();


            }

            */



        }
        private void ax_drum(int v)
        {
            
            if (ax1.Top >= 656) ax1.Top = 0;
            else ax1.Top += v;

            if (ax2.Top >= 656) ax2.Top = 0;
            else ax2.Top += v; 

            

            if (ax4.Top >= 656) ax4.Top = 0;
            else ax4.Top += v;



            int x, y;
            if (masina_albastra.Top >= 656)
            {

                x = rnd.Next(0, 100);
                masina_albastra.Location = new Point(x, 0);


            }
            
            else {
                masina_albastra.Top += v; }




            if (masina_albastra2.Top >= 656)
            {

                x = rnd.Next(101, 250);
                masina_albastra2.Location = new Point(x, 0);


            }

            else
            {
                masina_albastra2.Top += v;
            }



            if (masina_verde.Top >= 656)
            {

                x = rnd.Next(250, 656);
                masina_verde.Location = new Point(x, 0);


            }

            else
            {
                masina_verde.Top += v;
            }



        }
        private void Form1_Load(object sender, EventArgs e)
        {

            viteza.Text = "viteza: " + v_curenta + "km/h".ToString();
            Scor.Text = "Penalizari: " + penalizari;
            restart_buton.Enabled = false;
            restart_buton.Hide(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ax_drum(v_juc);
            indicatoare(9);
            penalizare1();
        }


        private void restart()
        {
            int x,x2;

            x = rnd.Next(0, 656);
            x2 = rnd.Next(200, 656);
            restart_buton.Enabled = false;
            restart_buton.Hide();
            masina_verde.Location = new Point(x2, 656);
            masina_albastra.Location = new Point(x, 0);
            masina_albastra2.Location = new Point(x, 0);

            v_juc = 40;
            v_curenta = 30;

            timer1.Enabled=true;
            penalizari = 0;
            viteza.Text = "viteza: " + v_curenta + "km/h".ToString();
            Scor.Text = "Penalizari: " + penalizari;
           
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Down) 
             if(e.KeyCode == Keys.Left)
                    {
                if (jucator.Left > 0) jucator.Left -= 35;
                    }
            if (e.KeyCode == Keys.Right)
            {
                if (jucator.Right <=663) jucator.Left += 35;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (v_juc < 100)
                {
                    v_juc+=10;
                    viteza.Text = "viteza: " + v_curenta + "km/h".ToString();
                    v_curenta+=5;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (v_juc > 0)
                {
                    v_juc -= 10;
                    viteza.Text = "viteza: " + v_curenta + "km/h".ToString();
                    v_curenta -= 5;
                }
            }




        }
    }
}
