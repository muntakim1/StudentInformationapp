using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class Form1 : Form
    {
        private Entity.User objUser = new Entity.User();
        private DataTable objTable;
        private bool status = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            objTable = new DataTable();
            objTable.Columns.Add("Username");
            objTable.Columns.Add("Password");
            DataRow _Muntakim = objTable.NewRow();
            _Muntakim["Username"] = "Pranto";
            _Muntakim["Password"] = "12345";
            objTable.Rows.Add(_Muntakim);

            DataRow _ALif = objTable.NewRow();
            _ALif["Username"] = "Alif";
            _ALif["Password"] = "12345";
            objTable.Rows.Add(_ALif);

            objUser.Username = UsernameInput.Text;
            objUser.Password = PasswordInput.Text;

            foreach(DataRow dr in objTable.Rows){
                if (objUser.Username == dr["Username"].ToString() && objUser.Password == dr["Password"].ToString())
                {
                    status = true;
                    break;
                }
                else
                {
                    status = false;
                }
            }
            if (status == true)
            {
                this.Hide();
                studentInform stdinfo = new studentInform();
                stdinfo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
            

        }
    }
}
