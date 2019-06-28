using MapControlApplication7.db;
using MapControlApplication7.farmInfo;


using ESRI.ArcGIS.Carto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MapControlApplication7.search
{
    public partial class searchForm : Form
    {
        public searchForm()
        {
            InitializeComponent();
        }

        public IMap map = null;
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "" && textBox3.Text.Trim() == "" && comboBox4.Text.Trim() == "" && textBox5.Text.Trim() == "" && textBox6.Text.Trim() == "" && comboBox1.Text.Trim() == "" && comboBox2.Text.Trim() == "" && comboBox3.Text.Trim() == "" && textBox10.Text.Trim() == "" && textBox1.Text.Trim() == "")
            {
                MessageBox.Show("全为空，无法查询!");
                return;
            }

            string sql = "select * from build where id = " + textBox1.Text;
            if (textBox2.Text.Trim() != "")
            {
                sql = sql + " and gid =" + textBox2.Text.Trim() + "";
            }
            if (textBox3.Text.Trim() != "")
            {
                sql = sql + " and name ='" + textBox3.Text.Trim() + "'";
            }
            if (comboBox4.Text.Trim() != "")
            {
                sql = sql + " and owner_type ='" + comboBox4.Text.Trim() + "'";
            }
            if (textBox5.Text.Trim() != "")
            {
                sql = sql + " and owner_name ='" + textBox5.Text.Trim() + "'";
            }
            if (textBox6.Text.Trim() != "")
            {
                sql = sql + " and owner_address_name ='" + textBox6.Text.Trim() + "'";
            }
            if (comboBox1.Text.Trim() != "")
            {
                sql = sql + " and using_type ='" + comboBox1.Text.Trim() + "'";
            }
            if (comboBox2.Text.Trim() != "")
            {
                sql = sql + " and isbuilding ='" + comboBox2.Text.Trim() + "'";
            }
            if (comboBox3.Text.Trim() != "")
            {
                sql = sql + " and build_height =" + comboBox3.Text.Trim() + "";
            }
            if (textBox10.Text.Trim() != "")
            {
                sql = sql + " and build_person_id =" + textBox10.Text.Trim() + "";
            }


            DataSet dataset = null;
            dataset = Dao.query(sql);
            FarmInfo fi = new FarmInfo(dataset);
            fi.currentMap = map;
            fi.ShowDialog();
            // this.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

 
    }
}
