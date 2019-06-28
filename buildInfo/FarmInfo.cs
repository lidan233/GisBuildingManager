


using MapControlApplication7.farmInfo;
using MapControlApplication7.db;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



using System.Drawing;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ADF.CATIDs;
using ESRI.ArcGIS.Controls;



using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using MapControlApplication7.farmInfo;
using MapControlApplication7.person;

namespace MapControlApplication7.farmInfo
{
    public partial class FarmInfo : Form
    {
        private IFeatureLayer currentFeatureLayer;
        public IMap currentMap = null;
        int row = 0;
        IHookHelper m_hookhelper = null;
        IFeatureLayer me = null;


        public FarmInfo(IFeatureLayer a, IHookHelper m_hookHelper)
        {
             me = a;
             m_hookhelper = m_hookHelper;
            InitializeComponent();
            initialData();
        }


        public FarmInfo(DataSet data)
        {
            InitializeComponent();
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = data.Tables[0];


        }


        private void initialColumns()
        {

            dataGridView1.Columns[1].HeaderCell.Value = "图斑编号";
            dataGridView1.Columns[2].HeaderCell.Value = "建筑名称";
            dataGridView1.Columns[3].HeaderCell.Value = "权属性质";
            dataGridView1.Columns[4].HeaderCell.Value = "权属单位名称";
            dataGridView1.Columns[5].HeaderCell.Value = "坐落单位名称";
            dataGridView1.Columns[6].HeaderCell.Value = "建筑用途类型";
            dataGridView1.Columns[7].HeaderCell.Value = "建筑修建中";
            dataGridView1.Columns[8].HeaderCell.Value = "建筑层数";
            dataGridView1.Columns[9].HeaderCell.Value = "责任人编号";
            dataGridView1.Columns[10].HeaderCell.Value = "保护开始时间";
            dataGridView1.Columns[11].HeaderCell.Value = "保护结束时间";
        }



        private void initialData()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            DataSet dataset = null;
            dataset = Dao.query("select*from build");
            dataGridView1.DataSource = dataset.Tables[0];
        }


        private void button1_Click(object sender, EventArgs e)
        {

            clearContent();
            button4.Text = "确认添加";
            button4.Enabled = true;
            button9.Enabled = true;
            DataSet dataset = null;
            dataset = Dao.query("select max(id) from build");//查询基本农田表的信息
            //string rs = dataset.Tables[0].Rows[0][0] as int;
            int a = Convert.ToInt32(dataset.Tables[0].Rows[0][0]);
            int c = a + 1;
            textBox1.Text = c.ToString();
        }


        private void clearContent()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox9.Text = "";
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button4.Text = "确认修改";
            button4.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (currentFeatureLayer == null)
            {
                MessageBox.Show("当前无加载地图！");
                return;
            }
            string tbh = dataGridView1.Rows[row].Cells[2].Value.ToString();//获取图斑号
            IQueryFilter queryFilter = new QueryFilterClass();
            queryFilter.WhereClause = "gid = '" + tbh + "'";
            IFeatureCursor featurecursor;
            featurecursor = currentFeatureLayer.FeatureClass.Search(queryFilter, false);
            IFeature feature = featurecursor.NextFeature();
            //定义新的IEnvelope接口对象获取该要素的空间范围
            if (feature == null)
            {
                MessageBox.Show("无法定位，没有此图斑!");
                return;
            }

            ESRI.ArcGIS.Geometry.IEnvelope outEnvelope = new ESRI.ArcGIS.Geometry.EnvelopeClass();
            //通过IGeometry接口的QueryEnvelope方法获取要素的空间范围
            feature.Shape.QueryEnvelope(outEnvelope);
            //将主窗体地图的当前可视范围定义为要素的空间范围，并刷新地图
            IActiveView activeView = currentMap as IActiveView;

            activeView.Extent = outEnvelope;
            activeView.Refresh();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (currentFeatureLayer == null)
            {
                MessageBox.Show("当前无加载地图！");
                return;
            }
            string tbh = textBox2.Text.Trim();//获取图斑号
            IQueryFilter queryFilter = new QueryFilterClass();
            queryFilter.WhereClause = "gid = '" + tbh + "'";
            IFeatureCursor featurecursor;
            featurecursor = currentFeatureLayer.FeatureClass.Search(queryFilter, false);
            IFeature feature = featurecursor.NextFeature();
            //定义新的IEnvelope接口对象获取该要素的空间范围
            if (feature == null)
            {
                MessageBox.Show("没有此图斑!");
                return;
            }
            else
            {
                MessageBox.Show("图斑存在");
            }

            ESRI.ArcGIS.Geometry.IEnvelope outEnvelope = new ESRI.ArcGIS.Geometry.EnvelopeClass();
            //通过IGeometry接口的QueryEnvelope方法获取要素的空间范围
            feature.Shape.QueryEnvelope(outEnvelope);
            //将主窗体地图的当前可视范围定义为要素的空间范围，并刷新地图
            IActiveView activeView = currentMap as IActiveView;

            activeView.Extent = outEnvelope;
            activeView.Refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            getForm a = new getForm();
            a.pt = this;
            a.ShowDialog();
        }


        private bool checkHasNull()
        {
            if (textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "" && comboBox4.Text.Trim() != "" && textBox5.Text.Trim() != "" && textBox6.Text.Trim() != "" && comboBox1.Text.Trim() != "" && comboBox2.Text.Trim() != "" && comboBox3.Text.Trim() != "" && textBox9.Text.Trim() != "" )
            {
                return true;
            }
            return false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "确认添加")
            {
                string sql = "insert into build(id,gid,name,owner_type,owner_name,owner_address_name,using_type,isbuilding,build_person_id,build_height,begin_time,end_time)values(" +
                        textBox1.Text.Trim() + "," + textBox2.Text.Trim() + ",'" + textBox3.Text.Trim() + "','" + comboBox4.Text.Trim() + "','" + textBox5.Text.Trim() + "','" + textBox6.Text.Trim() + "','"
                        + comboBox1.Text.Trim() + "','" + comboBox2.Text.Trim() + "'," + comboBox3.Text.Trim() + "," + textBox9.Text.Trim() + ",'"
                        + dateTimePicker1.Text.Trim() + "','" + dateTimePicker2.Text.Trim() + "')";

                if (checkHasNull())
                {
                    Dao.dml(sql);
                    MessageBox.Show("添加成功！");
                    button4.Enabled = false;
                    //更新表格内容
                    DataSet dataset = null;
                    dataset = Dao.query("select*from build");
                    dataGridView1.DataSource = dataset.Tables[0];



                    IRubberBand ipRubber = new RubberPolygonClass();
                    IGeometry ipGeo = ipRubber.TrackNew(m_hookhelper.
                        ActiveView.ScreenDisplay, null);
                    IFeature feature = me.FeatureClass.CreateFeature();
                    feature.set_Value(1, textBox2.Text.Trim());
                    
                    feature.Shape = ipGeo;
                    feature.Store();
                    m_hookhelper.ActiveView.Refresh();

                }
                else
                {
                    MessageBox.Show("信息填写不完整！");


                }
            }
            if (button4.Text == "确认修改")
            {
                string sql = "update build set gid =" + textBox2.Text.Trim() + ",name='" + textBox3.Text.Trim() + "',owner_type='" + comboBox4.Text.Trim() + "',owner_name='"
                    + textBox5.Text.Trim() + "',owner_address_name='" + textBox6.Text.Trim() + "',using_type='" + comboBox1.Text.Trim() + "',isbuilding='" + comboBox2.Text.Trim() +
                    "',build_person_id=" + comboBox3.Text.Trim() + ",begin_time='" + dateTimePicker1.Value + "',end_time='" + dateTimePicker2.Value + "',build_height=" + textBox9.Text.Trim() +
                    " where id =" + textBox1.Text.Trim() + "";
                if (checkHasNull())
                {
                    Dao.dml(sql);
                    MessageBox.Show("修改成功！");
                    button4.Enabled = false;
                    //更新表格内容
                    DataSet dataset = null;
                    dataset = Dao.query("select*from build");
                    dataGridView1.DataSource = dataset.Tables[0];
                }
                else
                {
                    MessageBox.Show("信息填写不完整！");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void setTBH(int tbh)
        {
            int line = -1;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)//行数带标题注意
            {

                if (dataGridView1.Rows[i].Cells[2].Value.ToString() == tbh.ToString())
                {
                    line = i;
                    break;
                }
                if (line >= 0)
                    break;

            }
            if (line == -1)
            {
                MessageBox.Show(this.Owner, "非建筑！");
                return;
            }
            dataGridView1_CellClick(dataGridView1, new DataGridViewCellEventArgs(2, line));
            dataGridView1.ClearSelection();
            dataGridView1.Rows[line].Selected = true;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button7.Enabled = true;
            row = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
            comboBox4.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[row].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[row].Cells[5].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[row].Cells[6].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[row].Cells[7].Value.ToString();
            comboBox3.Text = dataGridView1.Rows[row].Cells[8].Value.ToString();

            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[row].Cells[10].Value.ToString());
            dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.Rows[row].Cells[11].Value.ToString());
            textBox9.Text = dataGridView1.Rows[row].Cells[9].Value.ToString();
          

        }

        private void FarmInfo_Load(object sender, EventArgs e)
        {
            initialColumns();
            currentFeatureLayer = me;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "delete from build where id=" + textBox1.Text.Trim() + "";
            Dao.dml(sql);
            clearContent();
            textBox1.Text = "";


            //设定筛选条件获得满足要求的所有Feature
            IQueryFilter queryFilter = new QueryFilterClass();
            queryFilter.WhereClause = "";
            IFeatureCursor cursor = me.FeatureClass.Search(queryFilter, false);
            IFeature feature = cursor.NextFeature();
            //获取想要获取的字段值的fieldName的id号
            string name = "";
            int index = 0;
            while (feature != null)
            {
                if (Convert.ToString(feature.get_Value(1)) == textBox2.Text.Trim())
                {
                    cursor.DeleteFeature();
                }
                feature = cursor.NextFeature();
            }



            MessageBox.Show("删除成功！");
            //更新表格内容
            DataSet dataset = null;
            dataset = Dao.query("select*from build");
            dataGridView1.DataSource = dataset.Tables[0];
        }
    }
}
