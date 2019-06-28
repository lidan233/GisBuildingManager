using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MapControlApplication7.db;
using MapControlApplication7;

namespace MapControlApplication7
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string passwd = textBox2.Text.Trim();
            string sql = "select *  from users where username ='" + username + "' and passwd = '" + passwd + "';";
            DataSet rs = Dao.query(sql);
            if (rs == null)
            {
                MessageBox.Show("账户或密码错误！");
                return;
            }
            else
            {
                this.Visible = false;
                MainForm main = new MainForm();
                main.par = this;
                main.ShowDialog();
            }
        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }
    }
}
