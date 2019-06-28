using System;
using System.Drawing;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ADF.CATIDs;
using ESRI.ArcGIS.Controls;
using System.Windows.Forms;


using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geoprocessor;
using ESRI.ArcGIS.DataSourcesRaster;
using ESRI.ArcGIS.Geometry;


using ESRI.ArcGIS.Display;



namespace MapControlApplication7
{
    /// <summary>
    /// Summary description for identifyRaster.
    /// </summary>
    [Guid("32a41961-367c-4e9c-90b0-5453f510831d")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("MapControlApplication7.identifyRaster")]
    public sealed class identifyRaster : BaseTool
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
        private ILayer selectLayer;
        public identifyRaster(ILayer select )
        {
            //
            // TODO: Define values for the public properties
            //

            selectLayer = select;
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
        /// 
        public void GetPixValue(IRasterLayer pRasterlayer, IPoint pt,
                                                     out object value)
        {
            value = new object();
            IRaster pRaster = pRasterlayer.Raster;
            IRasterProps rasterProps = (IRasterProps)pRaster;
            IEnvelope extent = rasterProps.Extent;
            IRelationalOperator pRO = pt as IRelationalOperator;
            if (!pRO.Within(extent))
                return;
            IRaster2 pRaster2 = pRaster as IRaster2;
            int row = pRaster2.ToPixelRow(pt.Y);
            int col = pRaster2.ToPixelColumn(pt.X);
            value = pRaster2.GetPixelValue(0, col, row);
        }



        public override void OnClick()
        {
            IRubberBand ipRubberRec = new RubberPointClass();
            IPoint po = ipRubberRec.TrackNew(m_hookHelper.ActiveView.ScreenDisplay, null) as IPoint;
            object lidan = null;
            GetPixValue(selectLayer as IRasterLayer, po,out lidan);
           
            MessageBox.Show("ÏñËØÖµ:"+lidan.ToString());

        }

        public override void OnMouseDown(int Button, int Shift, int X, int Y)
        {
            // TODO:  Add identifyRaster.OnMouseDown implementation
        }

        public override void OnMouseMove(int Button, int Shift, int X, int Y)
        {
            // TODO:  Add identifyRaster.OnMouseMove implementation
        }

        public override void OnMouseUp(int Button, int Shift, int X, int Y)
        {
            // TODO:  Add identifyRaster.OnMouseUp implementation
        }
        #endregion
    }
}
