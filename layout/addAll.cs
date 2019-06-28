using System;
using System.Drawing;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ADF.CATIDs;
using ESRI.ArcGIS.Controls;


using ESRI.ArcGIS.Framework;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.CartoUI;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.esriSystem;


namespace MapControlApplication7.layout
{
    /// <summary>
    /// Command that works in ArcMap/Map/PageLayout
    /// </summary>
    [Guid("de959c2c-8041-4a08-9503-250fd9e9cf1a")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("MapControlApplication7.layout.addAll")]
    public sealed class addAll : BaseCommand
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
        string m_type = "";
        private IHookHelper m_hookHelper = null;
        public addAll(string m)
        {
            //
            // TODO: Define values for the public properties
            //
            base.m_category = ""; //localizable text
            base.m_caption = "";  //localizable text 
            base.m_message = "This should work in ArcMap/MapControl/PageLayoutControl";  //localizable text
            base.m_toolTip = "";  //localizable text
            base.m_name = "";   //unique id, non-localizable (e.g. "MyCategory_MyCommand")
            m_type = m;
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
            // TODO: Add addAll.OnClick implementation
            string sName = "";
            if (m_type == "esriCarto.")
            {
                return;
             }
            UID uid = new UIDClass();
            uid.Value = m_type;
            switch (m_type)
            {
                case "esriCarto.Legend":
                    sName = "Í¼Àý";
                    break;
                case "esriCarto.MarkerNorthArrow":
                    sName = "Ö¸±±Õë";
                    break;
                case "esriCarto.ScaleLine":
                    sName = "±ÈÀý³ß";
                    break;
                case "esriCarto.ScaleText":
                    sName = "±ÈÀý³ß";
                    break;
                default:
                    return;
            }
            IRubberBand ipRubber = new RubberEnvelopeClass();
            IEnvelope env = ipRubber.TrackNew(m_hookHelper.ActiveView.ScreenDisplay,
                null) as IEnvelope;
            CreateMapSurround(uid, env, sName, null);
        }
        private IMapSurround CreateMapSurround(UID ipUID, IEnvelope ipEnv, string sName, IMapSurround ipStyle)
        {
            IMapSurround ms = null;
            IMapFrame mf = m_hookHelper.ActiveView.GraphicsContainer.FindFrame(
                m_hookHelper.ActiveView.FocusMap) as IMapFrame;
            IMapSurroundFrame msf = mf.CreateSurroundFrame(ipUID, ipStyle);
            IElement ele = msf as IElement;
            ele.Geometry = ipEnv;
            ms = msf.MapSurround;
            ms.Name = sName;
            m_hookHelper.ActiveView.GraphicsContainer.AddElement(ele, 0);
            m_hookHelper.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics,
                null, null);
            return ms;
        }
        #endregion
    }
}
