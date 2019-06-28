using System;
using System.Drawing;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ADF.CATIDs;
using ESRI.ArcGIS.Controls;
using System.Windows.Forms;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Carto;

namespace MapControlApplication7
{
    /// <summary>
    /// Command that works in ArcMap/Map/PageLayout
    /// </summary>
    [Guid("871ad8bc-bc09-4508-89ad-a2ceab3d7010")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("MapControlApplication7.chooseAddress")]
    public sealed class chooseAddress : BaseCommand
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
        IMapControl3 me=null;
        public chooseAddress(IMapControl3 mapcontrol)
        {
            //
            // TODO: Define values for the public properties
            //
            base.m_category = ""; //localizable text
            base.m_caption = "";  //localizable text 
            base.m_message = "This should work in ArcMap/MapControl/PageLayoutControl";  //localizable text
            base.m_toolTip = "";  //localizable text
            base.m_name = "";   //unique id, non-localizable (e.g. "MyCategory_MyCommand")
            me = mapcontrol;


            try
            {
                //
                // TODO: change bitmap name if necessary
                //
                string bitmapResourceName = GetType().Name + ".bmp";
                base.m_bitmap = new Bitmap(GetType(), bitmapResourceName);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex.Message, "Invalid Bitmap");
            }
        }

        #region Overridden Class Methods

        /// <summary>
        /// Occurs when this command is created
        /// </summary>
        /// <param name="hook">Instance of the application</param>
        public override void OnCreate(object hook)
        {
            if (hook == null)
                return;

            try
            {
                m_hookHelper = new HookHelperClass();
                m_hookHelper.Hook = hook;
                if (m_hookHelper.ActiveView == null)
                    m_hookHelper = null;
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
        /// Occurs when this command is clicked
        /// </summary>
        public override void OnClick()
        {
            // TODO: Add chooseAddress.OnClick implementation

            List<IFeature> pList = new List<IFeature>();//用于存储选中的要素
            IEnumFeature pEnumFeature = me.Map.FeatureSelection as IEnumFeature;
            IFeature pFeature = pEnumFeature.Next();
            //while (pFeature != null)
            //{
            //    pList.Add(pFeature);
            //    pFeature = pEnumFeature.Next();
            //}

            ITopologicalOperator to = pFeature.Shape as ITopologicalOperator;
            IPolygon poly = to.Buffer(1) as IPolygon;
           
            ISpatialFilter ipSpatialFilter = new SpatialFilterClass();
            ipSpatialFilter.Geometry = poly;
            ipSpatialFilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelIntersects;
            IFeatureSelection ipFeatSelect = m_hookHelper.FocusMap.get_Layer(0) as IFeatureSelection;
            ipFeatSelect.Clear();
            ipFeatSelect.SelectFeatures(ipSpatialFilter, esriSelectionResultEnum.esriSelectionResultNew, false);
           

            ICursor cur = null;
            ipFeatSelect.SelectionSet.Search(null, true, out cur);
            IFeature feature = cur.NextRow() as IFeature;
            feature = cur.NextRow() as IFeature;
            if(feature!=null){
                MessageBox.Show("选址成功 可以添加");
                return;
            }
            MessageBox.Show("选址失败 该处不可以添加");

            
        }

        #endregion
    }
}
