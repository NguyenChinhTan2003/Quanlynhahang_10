using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Quanlynhahang_10
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ShowForm1()
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            Thread thread = new Thread(new ThreadStart(ShowForm1)); //Tao luong moi
            thread.Start();//khoi chay luong
            this.Close();

            
        }
    }
}
