using System;
using System.IO;
using System.Drawing;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ADF.CATIDs;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.DataSourcesGDB;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.esriSystem;

namespace MapControlApplication7
{
    /// <summary>
    /// Command that works in ArcMap/Map/PageLayout
    /// </summary>
    [Guid("70258060-34cc-4cfc-90db-525faa949371")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("MapControlApplication7.Command2")]
    public sealed class Command2 : BaseCommand
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
        public Command2()
        {
            //
            // TODO: Define values for the public properties
            //
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
        public override void OnClick()
        {

            SaveFileDialog dbfiledlg = new SaveFileDialog();
            dbfiledlg.Filter = "空间数据库文件（*.mdb）|*.mdb";
            dbfiledlg.RestoreDirectory = true;
            if (dbfiledlg.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = dbfiledlg.FileName.ToString();
                if (System.IO.File.Exists(localFilePath))
                    System.IO.File.Delete(localFilePath);
                //获得不带文件名的文件路径
                string FilePath = localFilePath.Substring(0,
                                    localFilePath.LastIndexOf("\\"));
                //获取文件名，不带路径
                string fileNameExt = localFilePath.Substring(
                                 localFilePath.LastIndexOf("\\") + 1);
                string fileName = fileNameExt.Substring(0,
                                       fileNameExt.LastIndexOf("."));
                IWorkspaceFactory ipWSFactory = new AccessWorkspaceFactoryClass();
                if (!File.Exists(localFilePath))
                {
                    IWorkspaceName ipWsName = ipWSFactory.Create(FilePath,
                                                   fileName, null, 0);
                }
                
                IWorkspace ipWorkspace = ipWSFactory.OpenFromFile(
                                                   localFilePath, 0);
                //添加函数CreateFeatureClass
                ISpatialReference ipSr =
                              m_hookHelper.FocusMap.SpatialReference;
                IFeatureClass ipFeatCls = CreateFeatureClass(
                              ipWorkspace as IFeatureWorkspace, ipSr);
                IFeatureLayer ipFeatLyr = new FeatureLayerClass();
                ipFeatLyr.Name = "polygon";
                ipFeatLyr.FeatureClass = ipFeatCls;
                m_hookHelper.FocusMap.AddLayer(ipFeatLyr);
            }


             //IWorkspaceFactory wsFactory = new     SdeWorkspaceFactoryClass(); 
             //IPropertySet ps = new PropertySetClass();
             //ps.SetProperty("SERVER", "DESKTOP-E7NJ8FE\\SQLEXPRESS");
             //ps.SetProperty("INSTANCE", "");
             //ps.SetProperty("DATABASE", "SDE");
             //ps.SetProperty("USER", "SDE");
             //ps.SetProperty("PASSWORD", "123");
             ////PublicWorkspace.ipWorkspace = wsFactory.Open(ps, 0);
             ////IEnumDataset eds = PublicWorkspace.ipWorkspace.get_Datasets(esriDatasetType.esriDTFeatureClass);
             //IWorkspace ipWorkspace = wsFactory.Open(ps, 0); 
             ////IEnumDataset eds = ipWorkspace.get_Datasets(esriDatasetType.esriDTFeatureClass);
             //////if (ps.GetProperty("INSTANCE") != "")
             //////{
                 
             ////    IFeatureClass fc = eds.Next() as IFeatureClass;
             ////    IFeatureLayer layer = new FeatureLayerClass();
             ////    layer.Name ="polygon";
                 
             ////    layer.FeatureClass = fc;
             ////    m_hookHelper.FocusMap.AddLayer(layer as ILayer);
             //////}


             //ISpatialReference ipSr =
             //              m_hookHelper.FocusMap.SpatialReference;
             //IFeatureClass ipFeatCls = CreateFeatureClass(
             //              ipWorkspace as IFeatureWorkspace, ipSr);
             //IFeatureLayer ipFeatLyr = new FeatureLayerClass();
             //ipFeatLyr.Name = "polygon";
             //ipFeatLyr.FeatureClass = ipFeatCls;
             //m_hookHelper.FocusMap.AddLayer(ipFeatLyr);

                



            
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
            //IFeatureDataset ipFeatDs =ipWorkspace.OpenFeatureDataset("daat1");
            IFeatureDataset ipFeatDs = ipWorkspace.CreateFeatureDataset("ipsr", ipSr);
            IFeatureClass ipFeatCls = ipFeatDs.CreateFeatureClass
("shiasszxx", ipFields, null, null, esriFeatureType.
esriFTSimple, "Shape", "");
            return ipFeatCls;
        }


        #endregion
    }
}
