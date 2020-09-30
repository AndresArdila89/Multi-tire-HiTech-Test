using Hi_Tech_Order_Management.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hi_Tech_Order_Management.GUI
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }


        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            User user = new User();
            int inputId = Convert.ToInt32(textBoxUserId.Text.Trim());
            string inputPwd = textBoxPws.Text.Trim();

            if (User.VerifyUser(inputId))
            {
                if (User.VerifyPassword(inputId, inputPwd))
                {
                    user = User.ReadUserInfo(inputId);
                    MessageBox.Show(user.JobTitle);
                }
                else
                {
                    labelErrors.Text = "Wrong Password";
                    textBoxPws.Clear();
                    textBoxPws.Focus();
                }
            }else
            {
                labelErrors.Text = "User Id does not exists";
                textBoxUserId.Clear();
                textBoxUserId.Focus();
                textBoxPws.Clear();
                textBoxPws.Focus();
            }
        }
    }
}
