using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string[] users = { "2180", "0202", "4567" };
        public static string usersTxt = "";
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (pass.Text == users[0] || pass.Text == users[1] || pass.Text == users[2])
                {
                    usersTxt = pass.Text;
                    this.Hide();
                    Form2 obj = new Form2();
                    obj.Show();


                }
                else
                {
                    pass.Text = "Ïncorrect Pin";
                }
            
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        public  void label1_Click(object sender, EventArgs e)
        {
           string lab = label1.Text;
        }

    }
}
