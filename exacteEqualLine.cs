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
using ESRI.ArcGIS.DataSourcesRaster;
using  ESRI.ArcGIS.GeoAnalyst ;



namespace MapControlApplication7
{
    public partial class exacteEqualLine : Form
    {
        private IHookHelper m_hookHelper = null;
        string AllFilePath;
        string FilePath;
        string filename;
        string name;
        string need;

        public exacteEqualLine(object hook)
        {
            InitializeComponent();

            m_hookHelper = new HookHelperClass();
            m_hookHelper.Hook = hook;

            ILayer temp_lay;
            for (int i = 0; i < m_hookHelper.FocusMap.LayerCount; i++)
            {
                temp_lay = m_hookHelper.FocusMap.get_Layer(i);
                layers1.Items.Add(temp_lay.Name);
            }

        }

        private void exacteEqualLine_Load(object sender, EventArgs e)
        {

        }

 

        private void layers1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sure_Click(object sender, EventArgs e)
        {
            string layer_name = layers1.Text;
            ILayer choose = null;
            double @base = double.Parse(basenumber.Text);
            double interval = double.Parse(dis.Text) ;


            ILayer temp_lay;
            for (int i = 0; i < m_hookHelper.FocusMap.LayerCount; i++)
            {
                temp_lay = m_hookHelper.FocusMap.get_Layer(i);
                if (temp_lay.Name == layer_name)
                {
                    choose = temp_lay;
                }

            }

            IRasterLayer chooseras = choose as IRasterLayer;
            

            ISurfaceOp2 pSurfaceOp = default(ISurfaceOp2);
            pSurfaceOp = new RasterSurfaceOp() as ISurfaceOp2;
            IGeoDataset pRasterDataset = chooseras as IGeoDataset;            
            IWorkspace pShpWS = default(IWorkspace);
            IWorkspaceFactory pShpWorkspaceFactory = 
                                    new  ESRI.ArcGIS.DataSourcesFile.ShapefileWorkspaceFactory();
            pShpWS = pShpWorkspaceFactory.OpenFromFile(FilePath, 0);
            pSurfaceOp = new RasterSurfaceOp() as ISurfaceOp2;
            IRasterAnalysisEnvironment pRasterAEnv =
                              (IRasterAnalysisEnvironment)pSurfaceOp;
            pRasterAEnv.OutWorkspace = pShpWS;
            IGeoDataset pOutput = default(IGeoDataset);
            IFeatureClass pFeatureClass = default(IFeatureClass);
            IFeatureLayer pFLayer = default(IFeatureLayer);


  
            object tmpbase;
            tmpbase = (object)@base;
            object tmpmy = 1;
            pOutput = pSurfaceOp.Contour(pRasterDataset, interval, 
                                              ref tmpbase, ref tmpmy);
            pFeatureClass = (IFeatureClass)pOutput;
            pFLayer = new FeatureLayer();
            pFLayer.FeatureClass = pFeatureClass;
            IGeoFeatureLayer pGeoFL = default(IGeoFeatureLayer);
            pGeoFL = (IGeoFeatureLayer)pFLayer;
            pGeoFL.DisplayAnnotation = false;
            pGeoFL.DisplayField = "CONTOUR";
            pGeoFL.Name = "CONTOUR";
            m_hookHelper.FocusMap.AddLayer(pGeoFL); 
        }



      

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
                name = filename.Substring(0,
                                       filename.LastIndexOf("."));
                savepath.Text = FilePath;
                need = FilePath = AllFilePath.Substring(0,
                                     AllFilePath.LastIndexOf("\\") + 1);
            }
        }
    }
}
