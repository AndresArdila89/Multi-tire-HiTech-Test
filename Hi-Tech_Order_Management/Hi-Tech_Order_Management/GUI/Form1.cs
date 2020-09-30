using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi_Tech_Order_Management.BLL;

namespace Hi_Tech_Order_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //if (UserDB.VerifyPassword(2222,"HenryBrown")) {
            //    MessageBox.Show("valid");
            //}
            //else
            //{
            //    MessageBox.Show("invalid");
            //}

            MessageBox.Show(User.ReadUserInfo(1111).JobTitle);

            
        }
    }
}
