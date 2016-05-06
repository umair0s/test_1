using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.IO;
using System.Xml;
using System.Net.WebSockets;
using System.Net.Http;

namespace test__1
{
    public partial class Form1 : Form
    {
        // declare variables here
        double bu_price = 0.80 ;
        double mlk_price = 1.15;
        double br_price = 1.00;

        double F_butter = 0.0;
        double F_milk = 0.0;
        //double F_bread = 0.0;
        double bread_cost;


        int q_butter = 0;
        int q_milk = 0;
        int q_bread = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void AppendTextBox1(string value)    // position box invoked
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox1), new object[] { value });
                return;
            }


            richTextBox1.Text = value;
        }

        public void AppendTextBox2(string value)    // position box invoked
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox2), new object[] { value });
                return;
            }


            richTextBox2.Text = value;
        }
        public void AppendTextBox3(string value)    // position box invoked
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox3), new object[] { value });
                return;
            }


            richTextBox3.Text = value;
        }

        public void AppendTextBox4(string value)    // position box invoked
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox4), new object[] { value });
                return;
            }


            richTextBox4.Text = value;
        }

        public void AppendTextBox5(string value)    // position box invoked
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox5), new object[] { value });
                return;
            }


            richTextBox5.Text += value;
        }

        public void AppendTextBox6(string value)    // position box invoked
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox6), new object[] { value });
                return;
            }


            richTextBox6.Text += value;
        }

        private void button1_Click(object sender, EventArgs e) // butter
        {
            q_butter++;
            AppendTextBox1("Butter total Now: " + q_butter);
        }
        private void button2_Click(object sender, EventArgs e) // milk 
        {
            q_milk++;
            AppendTextBox2("Milk total Now: " + q_milk);
        }

        private void button3_Click(object sender, EventArgs e)  //  bread
        {
            q_bread++;
            AppendTextBox3("Bread total Now: " + q_bread);
        }

        private void button4_Click(object sender, EventArgs e) // add to bascket
        {
            double pak0f4 = q_milk / 4;
            double spare = q_milk % 4;

            double butterpack = q_butter / 2;
            double butterspare = q_butter % 2; 

            AppendTextBox4("Butter : "+ q_butter + " ----  Milk : " + q_milk + " ----  Bread : " + q_bread+ "\r \n" );
           

            //logic

            if (q_milk != 0 | q_milk == 0 )
            {
                //MessageBox.Show("Milk Present/n/r");
                double q_milk_free = q_milk - (3 * pak0f4) - spare;
                double x = q_milk - q_milk_free;
                double milk_cost = x * mlk_price;
                F_milk = milk_cost;
                AppendTextBox5("Milk Cost:    "+ milk_cost+"\r");
            }

           if (q_butter != 0 | q_butter == 0)
            {
               
                double butter_cost = q_butter * bu_price;
                F_butter = butter_cost;
                AppendTextBox5("Butter Cost:    " + butter_cost+"\r");
            }

            if (q_bread == 0)
            {
                bread_cost = q_bread * br_price;
                AppendTextBox5("Bread Cost:    " + bread_cost + "\r");
            }

            if (q_bread == 1)
            {
                bread_cost = q_bread * br_price;
                AppendTextBox5("Bread Cost:    " + bread_cost + "\r");
            }
            if (q_bread >1)
            {
                double u = q_bread - butterpack;
                double disc_price = butterpack * 0.5;
                double orig_price = u * br_price;
                bread_cost = disc_price + orig_price;
                AppendTextBox5("Bread Cost:    " + bread_cost + "\r");
                double  Final_Cost = bread_cost + F_butter + F_milk;
                AppendTextBox6(Final_Cost.ToString());
            }

            //if (q_bread <1 && butterpack ==0)
            //{
            //    double q_bread_discount = q_bread - butterpack;
            //    double neu_q_bread = q_bread - q_bread_discount;
            //    double bread_cost = (neu_q_bread * br_price) + (butterpack*0.5);
            //    AppendTextBox5("Bread Cost:    " + bread_cost + "\r");
            //    Double Final_Cost = bread_cost + F_butter + F_milk;
            //    AppendTextBox6(Final_Cost.ToString());
                

            //}
            //if (q_bread >=1 && butterpack ==0)
            //{
            //    bread_cost = q_bread * br_price;
            //    AppendTextBox5("Bread Cost:    " + bread_cost + "\r");
            //    Double Final_Cost = bread_cost + F_butter + F_milk;
            //    AppendTextBox6(Final_Cost.ToString());
            //}


        }

        private void button5_Click(object sender, EventArgs e) // clear
        {
            q_bread = 0;
            q_butter = 0;
            q_milk = 0;
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
            richTextBox4.Clear();
            richTextBox5.Clear();
            richTextBox6.Clear();
            F_butter = 0.0;
            F_milk = 0.0;
            bread_cost = 0.0;
        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
