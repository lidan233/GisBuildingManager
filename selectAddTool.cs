using System;
using System.Drawing;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ADF.CATIDs;
using ESRI.ArcGIS.Controls;
using System.Windows.Forms;


using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;


namespace MapControlApplication7
{
    /// <summary>
    /// Summary description for selectAddTool.
    /// </summary>
    [Guid("ba64a6be-e774-4b98-8e56-08a3a29ddb84")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("MapControlApplication7.selectAddTool")]
    public sealed class selectAddTool : BaseTool
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

        public selectAddTool()
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
            // TODO: Add selectAddTool.OnClick implementation
        }

        public override void OnMouseDown(int Button, int Shift, int X, int Y)
        {
            // TODO:  Add CBR_SelectFeature.OnMouseDown implementation
            IRubberBand ipRubberPolygon = new RubberPolygonClass();
            IPolygon polygon = ipRubberPolygon.TrackNew(m_hookHelper.ActiveView.ScreenDisplay, null) as IPolygon;
            ISpatialFilter ipSpatialFilter = new SpatialFilterClass();
            ipSpatialFilter.Geometry = polygon;
            ipSpatialFilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelIntersects;
            IFeatureSelection ipFeatSelect = m_hookHelper.FocusMap.get_Layer(1) as IFeatureSelection;
            ipFeatSelect.Clear();
            ipFeatSelect.SelectFeatures(ipSpatialFilter,esriSelectionResultEnum.esriSelectionResultNew,false);
            ipFeatSelect.SelectionSet.Refresh();
            m_hookHelper.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeoSelection, null, null);

            ICursor cur = null;
            ipFeatSelect.SelectionSet.Search(null, true, out cur);
            IFeature feature = cur.NextRow() as IFeature;
            IFeatureLayer fl = m_hookHelper.FocusMap.get_Layer(0) as IFeatureLayer;

            while (feature!=null)
            {
                ITopologicalOperator to = feature.Shape as ITopologicalOperator;
                IPolygon poly = to.Buffer(0.01) as IPolygon;

                
                IFeature polyFeature = fl.FeatureClass.CreateFeature();
                polyFeature.Shape = poly;
                feature = cur.NextRow() as IFeature;
                polyFeature.Store();
            }
      
            m_hookHelper.ActiveView.Refresh();

        }


        public override void OnMouseMove(int Button, int Shift, int X, int Y)
        {
            // TODO:  Add selectAddTool.OnMouseMove implementation
        }

        public override void OnMouseUp(int Button, int Shift, int X, int Y)
        {
            // TODO:  Add selectAddTool.OnMouseUp implementation
        }
        #endregion
    }
}
