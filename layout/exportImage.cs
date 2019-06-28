using System;
using System.Drawing;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ADF.CATIDs;
using ESRI.ArcGIS.Controls;


using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Framework;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.CartoUI;
using    ESRI.ArcGIS.Output ;
using    ESRI.ArcGIS.Geometry ;
using    ESRI.ArcGIS.Display;
using System.Windows.Forms;
namespace MapControlApplication7.layout
{
    /// <summary>
    /// Command that works in ArcMap/Map/PageLayout
    /// </summary>
    [Guid("4722edac-e6dc-4fe9-8d41-3c4c6bb33d4d")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("MapControlApplication7.layout.exportImage")]
    public sealed class exportImage : BaseCommand
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
        private IPageLayoutControl3 pagelayout = null;
        public exportImage(IPageLayoutControl3 use)
        {
            //
            // TODO: Define values for the public properties
            //
            base.m_category = ""; //localizable text
            base.m_caption = "";  //localizable text 
            base.m_message = "This should work in ArcMap/MapControl/PageLayoutControl";  //localizable text
            base.m_toolTip = "";  //localizable text
            base.m_name = "";   //unique id, non-localizable (e.g. "MyCategory_MyCommand")
            pagelayout = use; 


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
            // TODO: Add exportImage.OnClick implementation

            SaveFileDialog dbfiledlg = new SaveFileDialog();
            dbfiledlg.Filter = "栅格文件（*）| * ";
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
                ExportActiveViewParameterized(300, 1, "PDF", FilePath, false);
            }




            
        }

        #endregion











        private void ExportActiveViewParameterized(long iOutputResolution, long lResampleRatio, string ExportType, string sOutputDir, Boolean bClipToGraphicsExtent)
        {
            /* EXPORT PARAMETER: (iOutputResolution) the resolution requested.
             * EXPORT PARAMETER: (lResampleRatio) Output Image Quality of the export.  The value here will only be used if the export
             * object is a format that allows setting of Output Image Quality, i.e. a vector exporter.
             * The value assigned to ResampleRatio should be in the range 1 to 5.
             * 1 corresponds to "Best", 5 corresponds to "Fast"
             * EXPORT PARAMETER: (ExportType) a string which contains the export type to create.
             * EXPORT PARAMETER: (sOutputDir) a string which contains the directory to output to.
             * EXPORT PARAMETER: (bClipToGraphicsExtent) Assign True or False to determine if export image will be clipped to the graphic 
             * extent of layout elements.  This value is ignored for data view exports
             */

            /* Exports the Active View of the document to selected output format. */

            IActiveView docActiveView = pagelayout.ActiveView;
            IExport docExport;
            long iPrevOutputImageQuality;
            IOutputRasterSettings docOutputRasterSettings;
            IEnvelope PixelBoundsEnv;
            tagRECT exportRECT;
            tagRECT DisplayBounds;
            IDisplayTransformation docDisplayTransformation;
            IPageLayout docPageLayout;
            IEnvelope docMapExtEnv;
            long hdc;
            //long tmpDC;
            string sNameRoot;
            long iScreenResolution;
            bool bReenable = false;


            IEnvelope docGraphicsExtentEnv;
            IUnitConverter pUnitConvertor;



            // The Export*Class() type initializes a new export class of the desired type.

            if (ExportType == "PDF")
            {
                docExport = new ExportPDFClass();
            }
            else if (ExportType == "EPS")
            {
                docExport = new ExportPSClass();
            }
            else if (ExportType == "AI")
            {
                docExport = new ExportAIClass();
            }
            else if (ExportType == "BMP")
            {

                docExport = new ExportBMPClass();
            }
            else if (ExportType == "TIFF")
            {
                docExport = new ExportTIFFClass();
            }
            else if (ExportType == "SVG")
            {
                docExport = new ExportSVGClass();
            }
            else if (ExportType == "PNG")
            {
                docExport = new ExportPNGClass();
            }
            else if (ExportType == "GIF")
            {
                docExport = new ExportGIFClass();
            }
            else if (ExportType == "EMF")
            {
                docExport = new ExportEMFClass();
            }
            else if (ExportType == "JPEG")
            {
                docExport = new ExportJPEGClass();
            }
            else
            {
                MessageBox.Show("Unsupported export type " + ExportType + ", defaulting to EMF.");
                ExportType = "EMF";
                docExport = new ExportEMFClass();
            }


            //  save the previous output image quality, so that when the export is complete it will be set back.
            docOutputRasterSettings = docActiveView.ScreenDisplay.DisplayTransformation as IOutputRasterSettings;
            iPrevOutputImageQuality = docOutputRasterSettings.ResampleRatio;


            if (docExport is IExportImage)
            {
                // always set the output quality of the DISPLAY to 1 for image export formats
                SetOutputQuality(docActiveView, 1);
            }
            else
            {
                // for vector formats, assign the desired ResampleRatio to control drawing of raster layers at export time   
                SetOutputQuality(docActiveView, lResampleRatio);
            }

            //set the name root for the export
            sNameRoot = "ExportActiveViewSampleOutput";

            //set the export filename (which is the nameroot + the appropriate file extension)
            docExport.ExportFileName = sOutputDir + sNameRoot + "." + docExport.Filter.Split('.')[1].Split('|')[0].Split(')')[0];


            /* Get the device context of the screen */
            //tmpDC = docExport.StartExporting(); ;
            /* Get the screen resolution. */
            iScreenResolution = 300; //88 is the win32 const for Logical pixels/inch in X)
            /* release the DC. */
            // docExport.FinishExporting();
            docExport.Resolution = iOutputResolution;


            if (docActiveView is IPageLayout)
            {
                //get the bounds of the "exportframe" of the active view.
                DisplayBounds = docActiveView.ExportFrame;
                //set up pGraphicsExtent, used if clipping to graphics extent.
                docGraphicsExtentEnv = GetGraphicsExtent(docActiveView);
            }
            else
            {
                //Get the bounds of the deviceframe for the screen.
                docDisplayTransformation = docActiveView.ScreenDisplay.DisplayTransformation;
                DisplayBounds = docDisplayTransformation.get_DeviceFrame();
            }

            PixelBoundsEnv = new Envelope() as IEnvelope;

            if (bClipToGraphicsExtent && (docActiveView is IPageLayout))
            {
                docGraphicsExtentEnv = GetGraphicsExtent(docActiveView);
                docPageLayout = docActiveView as PageLayout;
                pUnitConvertor = new UnitConverter();

                //assign the x and y values representing the clipped area to the PixelBounds envelope
                PixelBoundsEnv.XMin = 0;
                PixelBoundsEnv.YMin = 0;
                PixelBoundsEnv.XMax = pUnitConvertor.ConvertUnits(docGraphicsExtentEnv.XMax, docPageLayout.Page.Units, esriUnits.esriInches) * docExport.Resolution - pUnitConvertor.ConvertUnits(docGraphicsExtentEnv.XMin, docPageLayout.Page.Units, esriUnits.esriInches) * docExport.Resolution;
                PixelBoundsEnv.YMax = pUnitConvertor.ConvertUnits(docGraphicsExtentEnv.YMax, docPageLayout.Page.Units, esriUnits.esriInches) * docExport.Resolution - pUnitConvertor.ConvertUnits(docGraphicsExtentEnv.YMin, docPageLayout.Page.Units, esriUnits.esriInches) * docExport.Resolution;

                //'assign the x and y values representing the clipped export extent to the exportRECT
                exportRECT.bottom = (int)(PixelBoundsEnv.YMax) + 1;
                exportRECT.left = (int)(PixelBoundsEnv.XMin);
                exportRECT.top = (int)(PixelBoundsEnv.YMin);
                exportRECT.right = (int)(PixelBoundsEnv.XMax) + 1;

                //since we're clipping to graphics extent, set the visible bounds.
                docMapExtEnv = docGraphicsExtentEnv;
            }
            else
            {
                double tempratio = iOutputResolution / iScreenResolution;
                double tempbottom = DisplayBounds.bottom * tempratio;
                double tempright = DisplayBounds.right * tempratio;
                //'The values in the exportRECT tagRECT correspond to the width
                //and height to export, measured in pixels with an origin in the top left corner.
                exportRECT.bottom = (int)Math.Truncate(tempbottom);
                exportRECT.left = 0;
                exportRECT.top = 0;
                exportRECT.right = (int)Math.Truncate(tempright);


                //populate the PixelBounds envelope with the values from exportRECT.
                // We need to do this because the exporter object requires an envelope object
                // instead of a tagRECT structure.
                PixelBoundsEnv.PutCoords(exportRECT.left, exportRECT.top, exportRECT.right, exportRECT.bottom);

                //since it's a page layout or an unclipped page layout we don't need docMapExtEnv.
                docMapExtEnv = null;
            }

            // Assign the envelope object to the exporter object's PixelBounds property.  The exporter object
            // will use these dimensions when allocating memory for the export file.
            docExport.PixelBounds = PixelBoundsEnv;

            // call the StartExporting method to tell docExport you're ready to start outputting.
            SetOutputQuality(docActiveView, iPrevOutputImageQuality);
            hdc = docExport.StartExporting();

            // Redraw the active view, rendering it to the exporter object device context instead of the app display.
            // We pass the following values:
            //  * hDC is the device context of the exporter object.
            //  * exportRECT is the tagRECT structure that describes the dimensions of the view that will be rendered.
            // The values in exportRECT should match those held in the exporter object's PixelBounds property.
            //  * docMapExtEnv is an envelope defining the section of the original image to draw into the export object.
            docActiveView.Output((int)hdc, (int)docExport.Resolution, ref exportRECT, docMapExtEnv, null);

            //finishexporting, then cleanup.
            docExport.FinishExporting();
            docExport.Cleanup();

            MessageBox.Show("Finished exporting " + sOutputDir + sNameRoot + "." + docExport.Filter.Split('.')[1].Split('|')[0].Split(')')[0] + ".", "Export Active View Sample");

            //set the output quality back to the previous value

            if (bReenable)
            {

            }


            docMapExtEnv = null;
            PixelBoundsEnv = null;
        }


        private void SetOutputQuality(IActiveView docActiveView, long iResampleRatio)
        {
            /* This function sets OutputImageQuality for the active view.  If the active view is a pagelayout, then
             * it must also set the output image quality for EACH of the Maps in the pagelayout.
             */
            IGraphicsContainer oiqGraphicsContainer;
            IElement oiqElement;
            IOutputRasterSettings docOutputRasterSettings;
            IMapFrame docMapFrame;
            IActiveView TmpActiveView;

            if (docActiveView is IMap)
            {
                docOutputRasterSettings = docActiveView.ScreenDisplay.DisplayTransformation as IOutputRasterSettings;
                docOutputRasterSettings.ResampleRatio = (int)iResampleRatio;
            }
            else if (docActiveView is IPageLayout)
            {
                //assign ResampleRatio for PageLayout
                docOutputRasterSettings = docActiveView.ScreenDisplay.DisplayTransformation as IOutputRasterSettings;
                docOutputRasterSettings.ResampleRatio = (int)iResampleRatio;
                //and assign ResampleRatio to the Maps in the PageLayout
                oiqGraphicsContainer = docActiveView as IGraphicsContainer;
                oiqGraphicsContainer.Reset();

                oiqElement = oiqGraphicsContainer.Next();
                while (oiqElement != null)
                {
                    if (oiqElement is IMapFrame)
                    {
                        docMapFrame = oiqElement as IMapFrame;
                        TmpActiveView = docMapFrame.Map as IActiveView;
                        docOutputRasterSettings = TmpActiveView.ScreenDisplay.DisplayTransformation as IOutputRasterSettings;
                        docOutputRasterSettings.ResampleRatio = (int)iResampleRatio;
                    }
                    oiqElement = oiqGraphicsContainer.Next();
                }

                docMapFrame = null;
                oiqGraphicsContainer = null;
                TmpActiveView = null;
            }
            docOutputRasterSettings = null;

        }

        private IEnvelope GetGraphicsExtent(IActiveView docActiveView)
        {
            /* Gets the combined extent of all the objects in the map. */
            IEnvelope GraphicsBounds;
            IEnvelope GraphicsEnvelope;
            IGraphicsContainer oiqGraphicsContainer;
            IPageLayout docPageLayout;
            IDisplay GraphicsDisplay;
            IElement oiqElement;

            GraphicsBounds = new EnvelopeClass();
            GraphicsEnvelope = new EnvelopeClass();
            docPageLayout = docActiveView as IPageLayout;
            GraphicsDisplay = docActiveView.ScreenDisplay;
            oiqGraphicsContainer = docActiveView as IGraphicsContainer;
            oiqGraphicsContainer.Reset();

            oiqElement = oiqGraphicsContainer.Next();
            while (oiqElement != null)
            {
                oiqElement.QueryBounds(GraphicsDisplay, GraphicsEnvelope);
                GraphicsBounds.Union(GraphicsEnvelope);
                oiqElement = oiqGraphicsContainer.Next();
            }

            return GraphicsBounds;

        }

    }
}
