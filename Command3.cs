using System;
using System.Drawing;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ADF.CATIDs;
using ESRI.ArcGIS.Controls;

using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geoprocessor;
using ESRI.ArcGIS.DataSourcesRaster;
using  ESRI.ArcGIS.Display ;

namespace MapControlApplication7
{
    /// <summary>
    /// Command that works in ArcMap/Map/PageLayout
    /// </summary>
    [Guid("428c1a54-780f-47c4-8dec-8041e9cd86f8")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("MapControlApplication7.Command3")]
    public sealed class Command3 : BaseCommand
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
        private ILayer selectlayer;
        public Command3(ILayer select )
        {
            //
            // TODO: Define values for the public properties
            //

            selectlayer = select;
            base.m_category = ""; //localizable text
            base.m_caption = "";  //localizable text 
            base.m_message = "This should work in ArcMap/MapControl/PageLayoutControl";  //localizable text
            base.m_toolTip = "";  //localizable text
            base.m_name = "";   //unique id, non-localizable (e.g. "MyCategory_MyCommand")

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
        /// 
        public void RasterStretchColorMapRender(IRasterLayer pRasterlayer)
        {
            try
            {
                IRaster pRaster = pRasterlayer.Raster;
                int intTransPValue = 30;
                IColor pFromColor = new RgbColorClass();
                //Red + (0x100 * Green) + (0x10000 * Blue);
                pFromColor.RGB = 255 + 0x100 * 255;
                IColor pToColor = new RgbColorClass();
                pToColor.RGB = 0x10000 * 255;
                IRasterStretchColorRampRenderer pStretchRender =(IRasterStretchColorRampRenderer)pRasterlayer.Renderer;
                IRasterRenderer pRasterRender =default(IRasterRenderer);
                pRasterRender = (IRasterRenderer)pStretchRender;
                pRasterRender.Raster = pRaster;
                pRasterRender.Update();
                IAlgorithmicColorRamp pColorRamp =
                                         new AlgorithmicColorRamp();
                pColorRamp.Size = 255;
                pColorRamp.FromColor = pFromColor;
                pColorRamp.ToColor = pToColor;
                bool outvalue = true;
                pColorRamp.CreateRamp(out outvalue);
                pStretchRender.BandIndex = 0;
                pStretchRender.ColorRamp = pColorRamp;
                if (intTransPValue > 0)
                {
                    IRasterDisplayProps pRRenProp =
                                 (IRasterDisplayProps)pStretchRender;
                    pRRenProp.TransparencyValue = intTransPValue;
                }
                pRasterRender.Update();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }



        public override void OnClick()
        {
            IRasterLayer a = selectlayer as IRasterLayer;
            RasterStretchColorMapRender(a);
        }

        #endregion
    }
}
