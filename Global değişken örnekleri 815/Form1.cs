using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Global_değişken_örnekleri_815
{
    
    public partial class Form1 : Form
    {
        double bakiye = 200;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBakiye.Text="Bakiye :" + bakiye.ToString();
            lblBakiye.ForeColor = Color.Green;
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            bakiye += 50;
            lblBakiye.Text = "Bakiye :" + bakiye.ToString();
            lblBakiye.ForeColor = Color.Green;
            
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
           if (bakiye >= 8)
            {
                bakiye -= 8;
                lblBakiye.Text = "Bakiye :" + bakiye.ToString();
            }

           else
            {
                lblBakiye.Text = "Yetersiz bakiye";
                lblBakiye.ForeColor= Color.Red;
            }
           

        }
    }
}
