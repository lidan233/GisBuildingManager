using System;
using System.Drawing;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ADF.CATIDs;
using ESRI.ArcGIS.Controls;
using System.Windows.Forms;
using System.IO;

using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;

namespace MapControlApplication7
{
    /// <summary>
    /// Summary description for readFileTool.
    /// </summary>
    [Guid("2076e22f-0164-48fd-b378-c385612d3ca7")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("MapControlApplication7.readFileTool")]
    public sealed class readFileTool : BaseTool
    {
        #region COM Registration Function(s)
        [ComRegisterFunction()]
        [ComVisible(false)]
        static void RegisterFunction(Type registerType)
        {
            // Required for ArcGIS Component Category Registrar support
            ArcGISCategoryRegistration(registerType);

            //
            // TODO: Add any COM registration code here
            //
        }

        [ComUnregisterFunction()]
        [ComVisible(false)]
        static void UnregisterFunction(Type registerType)
        {
            // Required for ArcGIS Component Category Registrar support
            ArcGISCategoryUnregistration(registerType);

            //
            // TODO: Add any COM unregistration code here
            //
        }

        #region ArcGIS Component Category Registrar generated code
        /// <summary>
        /// Required method for ArcGIS Component Category registration -
        /// Do not modify the contents of this method with the code editor.
        /// </summary>
        private static void ArcGISCategoryRegistration(Type registerType)
        {
            string regKey = string.Format("HKEY_CLASSES_ROOT\\CLSID\\{{{0}}}", registerType.GUID);
            MxCommands.Register(regKey);
            ControlsCommands.Register(regKey);
        }
        /// <summary>
        /// Required method for ArcGIS Component Category unregistration -
        /// Do not modify the contents of this method with the code editor.
        /// </summary>
        private static void ArcGISCategoryUnregistration(Type registerType)
        {
            string regKey = string.Format("HKEY_CLASSES_ROOT\\CLSID\\{{{0}}}", registerType.GUID);
            MxCommands.Unregister(regKey);
            ControlsCommands.Unregister(regKey);
        }

        #endregion
        #endregion

        private IHookHelper m_hookHelper = null;

        public readFileTool()
        {
            //
            // TODO: Define values for the public properties
            //
            base.m_category = ""; //localizable text 
            base.m_caption = "";  //localizable text 
            base.m_message = "This should work in ArcMap/MapControl/PageLayoutControl";  //localizable text
            base.m_toolTip = "";  //localizable text
            base.m_name = "";   //unique id, non-localizable (e.g. "MyCategory_MyTool")
            try
            {
                //
                // TODO: change resource name if necessary
                //
                string bitmapResourceName = GetType().Name + ".bmp";
                base.m_bitmap = new Bitmap(GetType(), bitmapResourceName);
                base.m_cursor = new System.Windows.Forms.Cursor(GetType(), GetType().Name + ".cur");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex.Message, "Invalid Bitmap");
            }
        }

        #region Overridden Class Methods

        /// <summary>
        /// Occurs when this tool is created
        /// </summary>
        /// <param name="hook">Instance of the application</param>
        public override void OnCreate(object hook)
        {
            try
            {
                m_hookHelper = new HookHelperClass();
                m_hookHelper.Hook = hook;
                if (m_hookHelper.ActiveView == null)
                {
                    m_hookHelper = null;
                }
            }
            catch
            {
                m_hookHelper = null;
            }

            if (m_hookHelper == null)
                base.m_enabled = false;
            else
                base.m_enabled = true;

            // TODO:  Add other initialization code
        }

        /// <summary>
        /// Occurs when this tool is clicked
        /// </summary>
        public override void OnClick()
        {
            OpenFileDialog filedlg = new OpenFileDialog();
            filedlg.Filter = "空间数据文件（*.txt）|*.txt";
            filedlg.RestoreDirectory = true;
            if (filedlg.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = filedlg.FileName.ToString();
                string FilePath = localFilePath.Substring(0,
                                    localFilePath.LastIndexOf("\\"));
                //获取文件名，不带路径
                string fileNameExt = localFilePath.Substring(
                                 localFilePath.LastIndexOf("\\") + 1);
                string fileName = fileNameExt.Substring(0,
                                       fileNameExt.LastIndexOf("."));

                addToPoint(localFilePath);

                
            }
        }
        public void addToPoint(string file)
        {
           
            IPoint pPoint = null;
            IPointCollection pPCol = new PolygonClass();
            string[] lines = File.ReadAllLines(file);
            object ptmp = Type.Missing;


           
            
            ISpatialReferenceFactory pfactory = new SpatialReferenceEnvironmentClass();
            ISpatialReference flatref = m_hookHelper.FocusMap.SpatialReference;
            ISpatialReference earthref = pfactory.CreateGeographicCoordinateSystem((int)esriSRGeoCSType.esriSRGeoCS_Beijing1954);
           

            



            for (int i = 1; i < lines.Length; i++)
            {
   
                string[] temp = lines[i].Trim().Split(' ');
                for (int j = 0; j < temp.Length; j++)
                {
                    pPoint = new PointClass();
                    pPoint.X = int.Parse(temp[1].Trim());
                    pPoint.Y = int.Parse(temp[2].Trim());
                   

                    IGeometry geo = pPoint as IGeometry ;
                    geo.SpatialReference = flatref;
                    geo.Project(earthref);
                    addpoint(geo) ;
                    pPCol.AddPoint(pPoint, ref  ptmp, ref  ptmp);

                    if (j == (temp.Length - 1))
                    {
                        string[] temp1 = lines[1].Trim().Split(' ');
                        pPoint = new PointClass();
       
                        pPoint.PutCoords(int.Parse(temp1[1].Trim()), int.Parse(temp1[2].Trim()));
                        pPCol.AddPoint(pPoint, ref  ptmp, ref  ptmp);
                    }

                }
            }
            addpolygon(pPCol as IGeometry);

        }


        public void addpoint(IGeometry ipGeo)
        {
            IFeatureLayer layer = null;
            for (int i = 0; i < m_hookHelper.FocusMap.LayerCount; i++)
            {
                layer = (IFeatureLayer)m_hookHelper.FocusMap.get_Layer(i);
                if (layer.Name == "point")
                {
                    break;
                }
                layer = null;
            }
            if (layer != null)
            {
                IFeature feature = layer.FeatureClass.CreateFeature();
                feature.Shape = ipGeo;
                feature.Store();
                m_hookHelper.ActiveView.Refresh();
            }
        }




        public void addpolygon(IGeometry ipGeo)
        {
            IFeatureLayer layer = null;
            for (int i = 0; i < m_hookHelper.FocusMap.LayerCount; i++)
            {
                layer = (IFeatureLayer)m_hookHelper.FocusMap.get_Layer(i);
                if (layer.Name == "polygon")
                {
                    break;
                }
                layer = null;
            }
            if (layer != null)
            {
                IFeature feature = layer.FeatureClass.CreateFeature();
                feature.Shape = ipGeo;
                feature.Store();
                m_hookHelper.ActiveView.Refresh();
            }
        }


        public override void OnMouseDown(int Button, int Shift, int X, int Y)
        {
            // TODO:  Add readFileTool.OnMouseDown implementation
        }

        public override void OnMouseMove(int Button, int Shift, int X, int Y)
        {
            // TODO:  Add readFileTool.OnMouseMove implementation
        }

        public override void OnMouseUp(int Button, int Shift, int X, int Y)
        {
            // TODO:  Add readFileTool.OnMouseUp implementation
        }
        #endregion
    }
}
