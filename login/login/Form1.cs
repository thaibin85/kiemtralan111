using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "admin" && txtpassword.Text == "admin")
            {
                MessageBox.Show("Đăng nhập thành công");
                Form2 form = new Form2();
                form.ShowDialog();
            }
            else MessageBox.Show("Đăng nhâp thất bại");
        }
    }
}
