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
    public partial class Form2 : Form
    {
        public static string user;
        string name = Form1.usersTxt;
        public static int num;
        public Form2()
        {

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            
            if (name == "2180")
            {
                num = 5000;
                user = "Gbemisola";
                username.Text = "Welcome " + user;
                
            }
            else if (name == "0202")
            {
                num = 10000;
                user = "Jacob";
                username.Text = "Welcome "+ user;
            }
            else if (name == "4567")
            {
                num = 15000;
                user = "Opeyemi";
                username.Text = "Welcome " + user;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num = wtdamt.SelectedItem.ToString();
           int res = them.Withdraw(int.Parse(num));
           if (res == -1)
           {
               this.Hide();
               Form3 frm = new Form3();
               frm.Show();
               frm.label1.Text = "Transanction Not Successfull";
               this.Hide();
               Form3 from = new Form3();
               from.Show();
           }
           

        }

        private void balance_Click(object sender, EventArgs e)
        {
            int res = them.Balance();
            MessageBox.Show(res.ToString());

        }

        private void deposit_Click(object sender, EventArgs e)
        {
            string num = depamt.SelectedItem.ToString();
            int res = them.Deposit(int.Parse(num));
            this.Hide();
            Form3 frm = new Form3();
            frm.Show();
    
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            withdraw.Enabled = true;
        }

        private void depamt_SelectedIndexChanged(object sender, EventArgs e)
        {
            deposit.Enabled = true;
        }
        Account them = new Account(user, num);

        private void transfer_Click(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        public string label1 { get; set; }
    }
}
