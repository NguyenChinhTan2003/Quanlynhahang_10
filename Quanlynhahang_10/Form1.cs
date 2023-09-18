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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowForm2()
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowForm2)); //Tao luong moi
            thread.Start();//khoi chay luong
            this.Close();
            
        }
    }
}
