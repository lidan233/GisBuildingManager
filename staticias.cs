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

using ESRI.ArcGIS.SpatialAnalystTools;

namespace MapControlApplication7
{
    /// <summary>
    /// Command that works in ArcMap/Map/PageLayout
    /// </summary>
    [Guid("c92ab6a6-1950-45eb-bd38-a23809c9f10d")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("MapControlApplication7.staticias")]
    public sealed class staticias : BaseCommand
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

        public staticias(ILayer select )
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

        public string RasterStistics(IRasterLayer rLayer)
        {
            IRaster2 r2 = rLayer.Raster as IRaster2;
            IRasterDataset rasterDataset = r2.RasterDataset;
            IRasterBandCollection rasterBands = 
                                (IRasterBandCollection)rasterDataset;
            IEnumRasterBand enumRasterBand = rasterBands.Bands;
            string sRasterStisticsResult = "Raster Statistics Result:\n";
            IRasterBand rasterBand = enumRasterBand.Next();
            while (rasterBand != null)
            { 
                bool tmpBool;
                rasterBand.HasStatistics(out tmpBool);
                if (!tmpBool)
                rasterBand.ComputeStatsAndHist();
                sRasterStisticsResult += GetRasterStistics(rasterBand);
                rasterBand = enumRasterBand.Next();
            }
            return sRasterStisticsResult;
        }
        private string GetRasterStistics(IRasterBand rasterBand)
        {
            IRasterStatistics rasterStatistics = rasterBand.Statistics;
            string statisticsResult;
            statisticsResult = ""+rasterBand .Bandname +"Mean is:" 
                + rasterStatistics.Mean.ToString() + "\n SD is"
                + rasterStatistics.StandardDeviation.ToString();
            return statisticsResult;
        }




        public override void OnClick()
        {
            // TODO: Add staticias.OnClick implementation
            IRasterLayer a = selectlayer as IRasterLayer;
            string result = RasterStistics(a);
            MessageBox.Show(result);
            
        }

        #endregion
    }
}
