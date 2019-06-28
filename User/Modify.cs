using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MapControlApplication7.db;

namespace MapControlApplication7.User
{
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (username.Text == null || username.Text.Equals(""))
            {
                MessageBox.Show("用户名不能为空!");
                return;
            }
            if (psw1.Text == null || psw1.Text.Equals(""))
            {
                MessageBox.Show("密码不能为空!");
                return;
            }
            if (psw1.Text != psw2.Text)
            {
                MessageBox.Show("两次密码不一致!");
                return;
            }
            String sqlstr;
            sqlstr = "UPDATE  users SET passwd='" + psw1.Text.Trim() + "' WHERE username='" + username.Text.Trim() + "'";
            int rs = Dao.dml(sqlstr);
            if (rs > 0)
            {
                MessageBox.Show("数据修改成功");
                this.Close();
            }
            else
                MessageBox.Show("用户不存在");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
