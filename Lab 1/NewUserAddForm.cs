using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class NewUserAddForm : Form
    {
        FormUsers formUsers;

        public NewUserAddForm(FormUsers formUsers)
        {
            InitializeComponent();

            this.formUsers = formUsers;
        }

        private void NewUserAddForm_Load(object sender, EventArgs e)
        {

        }

        private void AddNewUser_Click(object sender, EventArgs e)
        {
            formUsers.AddNewUser(new FormUsers.User(passwordTextBox.Text, loginTextBox.Text, dateTextBox.Value,
                phoneTextBox.Text, emailTextBox.Text, nameTextBox.Text, surnameTextBox.Text));

            Close();
        }
        

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
