using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;




using ESRI.ArcGIS.Geometry;

using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geoprocessor;
using ESRI.ArcGIS.DataSourcesGDB;

namespace MapControlApplication7
{
    public partial class Form1 : Form
    {
        string AllFilePath;
        string FilePath;
        string filename;
        string name;
        string need;
        private IHookHelper m_hookHelper = null;


        public Form1(object hook)
        {
            InitializeComponent();

            m_hookHelper = new HookHelperClass();
            m_hookHelper.Hook = hook;

            ILayer temp_lay;
            for (int i = 0; i < m_hookHelper.FocusMap.LayerCount; i++)
            {
                temp_lay = (IFeatureLayer)m_hookHelper.FocusMap.get_Layer(i);

                layers.Items.Add(temp_lay.Name);
            }
        }

        

        private void chooseFile_Click(object sender, EventArgs e)
        {
         
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "shp files (*.shp)|*.shp|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                AllFilePath = saveFileDialog1.FileName.ToString();
                FilePath = AllFilePath.Substring(0,
                                     AllFilePath.LastIndexOf("\\"));
                //获取文件名，不带路径
                filename = AllFilePath.Substring(
                                  AllFilePath.LastIndexOf("\\") + 1);
                name= filename.Substring(0,
                                       filename.LastIndexOf("."));
                pathchoose.Text = FilePath;
                need = FilePath = AllFilePath.Substring(0,
                                     AllFilePath.LastIndexOf("\\")+1);
            }



        }

        private void sure_Click(object sender, EventArgs e)
        {
            double rad = Convert.ToDouble(radius.Text);
            string temp_path = FilePath;
            string layer_name = layers.Text;
            ILayer choose =null ;
            IFeatureLayer lidan = null;

            ILayer temp_lay;
             for (int i = 0; i < m_hookHelper.FocusMap.LayerCount; i++)
            {
                temp_lay = (IFeatureLayer)m_hookHelper.FocusMap.get_Layer(i);
                if (temp_lay.Name == layer_name)
                {
                    choose = temp_lay;
                }

            }


            IWorkspaceFactory ipWSFactory = new
                       AccessWorkspaceFactoryClass();
            IWorkspaceName ipWsName = ipWSFactory.Create(FilePath,
                                               name, null, 0);
            IWorkspace ipWorkspace = ipWSFactory.OpenFromFile(
                                              need+name+".mdb", 0);

            ISpatialReference ipSr =
                          m_hookHelper.FocusMap.SpatialReference;


            IFeatureClass temp = CreateFeatureClass(ipWorkspace as IFeatureWorkspace, ipSr);


            lidan = choose as IFeatureLayer;
            IFeatureClass lidan1 = lidan.FeatureClass;
            IQueryFilter queryFilterlast = new QueryFilterClass();

            IFeatureCursor pFCursor;
            IFeature feature;
            queryFilterlast.WhereClause = null;
            pFCursor = lidan1.Search(queryFilterlast, false);


            feature = pFCursor.NextFeature();
            
            while (feature != null)
            {
                ITopologicalOperator to = feature.Shape as ITopologicalOperator;
                IPolygon poly = to.Buffer(rad) as IPolygon;


                IFeature polyFeature = temp.CreateFeature();
                polyFeature.Shape = poly;
                feature = pFCursor.NextFeature() as IFeature;
                polyFeature.Store();
            }

            change(temp, temp_path);

        }


            private void change(IFeatureClass pFeatureClass, string destiShpPath)
            {
                Geoprocessor gp = new Geoprocessor();
                gp.OverwriteOutput = true;
                ESRI.ArcGIS.ConversionTools.FeatureClassToShapefile covertToshp = new ESRI.ArcGIS.ConversionTools.FeatureClassToShapefile();
                covertToshp.Input_Features = pFeatureClass;
                covertToshp.Output_Folder = destiShpPath;
                try
                {
                    gp.Execute(covertToshp, null);
                }
                catch (Exception ex)
                {
                    string str = "";
                    for (int i = 0; i < gp.MessageCount; i++)
                    {
                        str += gp.GetMessage(i);
                        str += "\n";
                    }
                    MessageBox.Show(str);
                }
                MessageBox.Show("转换成功！");
            }



        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void layers_BindingContextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private IFeatureClass CreateFeatureClass(IFeatureWorkspace ipWorkspace, ISpatialReference ipSr)
        {
            //添加函数CreateFeatureClass()
            IFieldsEdit ipFields = new FieldsClass();
            ipFields.FieldCount_2 = 3;
            IFieldEdit ipField = new FieldClass();
            ipField.Name_2 = "ObjectID";
            ipField.AliasName_2 = "FID";
            ipField.Type_2 = esriFieldType.esriFieldTypeOID;
            ipFields.set_Field(0, ipField);
            //Add others miscellaneous text field
            IFieldEdit ipField2 = new FieldClass();
            ipField2.Name_2 = "SmallInteger";
            ipField2.AliasName_2 = "short";
            ipField2.Type_2 = esriFieldType.esriFieldTypeSmallInteger;
            ipFields.set_Field(1, ipField2);
            //Make the shape field
            //it will need a geometry definition, with a spatial reference
            IGeometryDefEdit ipGeoDef = new GeometryDefClass();
            ipGeoDef.SpatialReference_2 = ipSr;
            ipGeoDef.GeometryType_2 =
                              esriGeometryType.esriGeometryPolygon;
            IFieldEdit ipField3 = new FieldClass();
            ipField3.Name_2 = "Shape";
            ipField3.AliasName_2 = "shape";
            ipField3.Type_2 = esriFieldType.esriFieldTypeGeometry;
            ipField3.GeometryDef_2 = ipGeoDef;
            ipFields.set_Field(2, ipField3);
            ipSr.SetDomain(-60000000, 60000000, -60000000, 60000000);
            IFeatureDataset ipFeatDs =
                   ipWorkspace.CreateFeatureDataset("sadf", ipSr);

            IFeatureClass ipFeatCls = ipFeatDs.CreateFeatureClass
("shiasszxx", ipFields, null, null, esriFeatureType.
esriFTSimple, "Shape", "");
            return ipFeatCls;
        }



    }
}
