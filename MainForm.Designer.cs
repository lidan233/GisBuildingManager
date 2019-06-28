namespace MapControlApplication7
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            //Ensures that any ESRI libraries that have been used are unloaded in the correct order. 
            //Failure to do this may result in random crashes on exit due to the operating system unloading 
            //the libraries in the incorrect order. 
            ESRI.ArcGIS.ADF.COMSupport.AOUninitialize.Shutdown();

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuExitApp = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPolygonFeatureClsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findSpatialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPointFeatureClsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBuildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToshpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGridToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteGridToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.setToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buildingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBarXY = new System.Windows.Forms.ToolStripStatusLabel();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createRasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rasterRenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.identifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attributeTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.axMapControl2 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMap = new System.Windows.Forms.TabPage();
            this.tabPageLayout = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.axPageLayoutControl1 = new ESRI.ArcGIS.Controls.AxPageLayoutControl();
            this.chooseAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageMap.SuspendLayout();
            this.tabPageLayout.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axPageLayoutControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.testToolStripMenuItem,
            this.selectToolStripMenuItem,
            this.addToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.rasterToolStripMenuItem,
            this.layoutToolStripMenuItem,
            this.userToolStripMenuItem,
            this.personToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1145, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewDoc,
            this.menuOpenDoc,
            this.menuSaveDoc,
            this.menuSaveAs,
            this.menuSeparator,
            this.menuExitApp});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(46, 24);
            this.menuFile.Text = "File";
            // 
            // menuNewDoc
            // 
            this.menuNewDoc.Image = ((System.Drawing.Image)(resources.GetObject("menuNewDoc.Image")));
            this.menuNewDoc.ImageTransparentColor = System.Drawing.Color.White;
            this.menuNewDoc.Name = "menuNewDoc";
            this.menuNewDoc.Size = new System.Drawing.Size(210, 24);
            this.menuNewDoc.Text = "New Document";
            this.menuNewDoc.Click += new System.EventHandler(this.menuNewDoc_Click);
            // 
            // menuOpenDoc
            // 
            this.menuOpenDoc.Image = ((System.Drawing.Image)(resources.GetObject("menuOpenDoc.Image")));
            this.menuOpenDoc.ImageTransparentColor = System.Drawing.Color.White;
            this.menuOpenDoc.Name = "menuOpenDoc";
            this.menuOpenDoc.Size = new System.Drawing.Size(210, 24);
            this.menuOpenDoc.Text = "Open Document...";
            this.menuOpenDoc.Click += new System.EventHandler(this.menuOpenDoc_Click);
            // 
            // menuSaveDoc
            // 
            this.menuSaveDoc.Image = ((System.Drawing.Image)(resources.GetObject("menuSaveDoc.Image")));
            this.menuSaveDoc.ImageTransparentColor = System.Drawing.Color.White;
            this.menuSaveDoc.Name = "menuSaveDoc";
            this.menuSaveDoc.Size = new System.Drawing.Size(210, 24);
            this.menuSaveDoc.Text = "SaveDocument";
            this.menuSaveDoc.Click += new System.EventHandler(this.menuSaveDoc_Click);
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Name = "menuSaveAs";
            this.menuSaveAs.Size = new System.Drawing.Size(210, 24);
            this.menuSaveAs.Text = "Save As...";
            this.menuSaveAs.Click += new System.EventHandler(this.menuSaveAs_Click);
            // 
            // menuSeparator
            // 
            this.menuSeparator.Name = "menuSeparator";
            this.menuSeparator.Size = new System.Drawing.Size(207, 6);
            // 
            // menuExitApp
            // 
            this.menuExitApp.Name = "menuExitApp";
            this.menuExitApp.Size = new System.Drawing.Size(210, 24);
            this.menuExitApp.Text = "Exit";
            this.menuExitApp.Click += new System.EventHandler(this.menuExitApp_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPolygonFeatureClsToolStripMenuItem,
            this.newPolygonToolStripMenuItem,
            this.findSpatialToolStripMenuItem,
            this.newPointFeatureClsToolStripMenuItem,
            this.newPointToolStripMenuItem,
            this.addBuildToolStripMenuItem,
            this.chooseAddressToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.testToolStripMenuItem.Text = "build";
            // 
            // newPolygonFeatureClsToolStripMenuItem
            // 
            this.newPolygonFeatureClsToolStripMenuItem.Name = "newPolygonFeatureClsToolStripMenuItem";
            this.newPolygonFeatureClsToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.newPolygonFeatureClsToolStripMenuItem.Text = "import buildings";
            this.newPolygonFeatureClsToolStripMenuItem.Click += new System.EventHandler(this.newPolygonFeatureClsToolStripMenuItem_Click);
            // 
            // newPolygonToolStripMenuItem
            // 
            this.newPolygonToolStripMenuItem.Name = "newPolygonToolStripMenuItem";
            this.newPolygonToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.newPolygonToolStripMenuItem.Text = "add shape";
            this.newPolygonToolStripMenuItem.Click += new System.EventHandler(this.newPolygonToolStripMenuItem_Click);
            // 
            // findSpatialToolStripMenuItem
            // 
            this.findSpatialToolStripMenuItem.Name = "findSpatialToolStripMenuItem";
            this.findSpatialToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.findSpatialToolStripMenuItem.Text = "Find Spatial";
            this.findSpatialToolStripMenuItem.Click += new System.EventHandler(this.findSpatialToolStripMenuItem_Click);
            // 
            // newPointFeatureClsToolStripMenuItem
            // 
            this.newPointFeatureClsToolStripMenuItem.Name = "newPointFeatureClsToolStripMenuItem";
            this.newPointFeatureClsToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.newPointFeatureClsToolStripMenuItem.Text = "addpoi";
            this.newPointFeatureClsToolStripMenuItem.Click += new System.EventHandler(this.newPointFeatureClsToolStripMenuItem_Click);
            // 
            // newPointToolStripMenuItem
            // 
            this.newPointToolStripMenuItem.Name = "newPointToolStripMenuItem";
            this.newPointToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.newPointToolStripMenuItem.Text = "add poi shape";
            this.newPointToolStripMenuItem.Click += new System.EventHandler(this.newPointToolStripMenuItem_Click);
            // 
            // addBuildToolStripMenuItem
            // 
            this.addBuildToolStripMenuItem.Name = "addBuildToolStripMenuItem";
            this.addBuildToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.addBuildToolStripMenuItem.Text = "Add Build";
            this.addBuildToolStripMenuItem.Click += new System.EventHandler(this.addZongdiToolStripMenuItem_Click);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem1,
            this.selectAddToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.selectToolStripMenuItem.Text = "select";
            // 
            // selectToolStripMenuItem1
            // 
            this.selectToolStripMenuItem1.Name = "selectToolStripMenuItem1";
            this.selectToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.selectToolStripMenuItem1.Text = "select";
            this.selectToolStripMenuItem1.Click += new System.EventHandler(this.selectToolStripMenuItem1_Click);
            // 
            // selectAddToolStripMenuItem
            // 
            this.selectAddToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polygonToolStripMenuItem,
            this.pointToolStripMenuItem,
            this.lineStringToolStripMenuItem});
            this.selectAddToolStripMenuItem.Name = "selectAddToolStripMenuItem";
            this.selectAddToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.selectAddToolStripMenuItem.Text = "selectAdd";
            this.selectAddToolStripMenuItem.Click += new System.EventHandler(this.selectAddToolStripMenuItem_Click);
            // 
            // polygonToolStripMenuItem
            // 
            this.polygonToolStripMenuItem.Name = "polygonToolStripMenuItem";
            this.polygonToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.polygonToolStripMenuItem.Text = "Polygon";
            this.polygonToolStripMenuItem.Click += new System.EventHandler(this.polygonToolStripMenuItem_Click);
            // 
            // pointToolStripMenuItem
            // 
            this.pointToolStripMenuItem.Name = "pointToolStripMenuItem";
            this.pointToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.pointToolStripMenuItem.Text = "Rectangle";
            this.pointToolStripMenuItem.Click += new System.EventHandler(this.pointToolStripMenuItem_Click);
            // 
            // lineStringToolStripMenuItem
            // 
            this.lineStringToolStripMenuItem.Name = "lineStringToolStripMenuItem";
            this.lineStringToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.lineStringToolStripMenuItem.Text = "Circle";
            this.lineStringToolStripMenuItem.Click += new System.EventHandler(this.lineStringToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.searchToolStripMenuItem.Text = "search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFromFileToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.addToolStripMenuItem.Text = "add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // addFromFileToolStripMenuItem
            // 
            this.addFromFileToolStripMenuItem.Name = "addFromFileToolStripMenuItem";
            this.addFromFileToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.addFromFileToolStripMenuItem.Text = "addFromFile";
            this.addFromFileToolStripMenuItem.Click += new System.EventHandler(this.addFromFileToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToshpToolStripMenuItem,
            this.exportToImageToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.exportToolStripMenuItem.Text = "export";
            // 
            // exportToshpToolStripMenuItem
            // 
            this.exportToshpToolStripMenuItem.Name = "exportToshpToolStripMenuItem";
            this.exportToshpToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.exportToshpToolStripMenuItem.Text = "exportToshp";
            this.exportToshpToolStripMenuItem.Click += new System.EventHandler(this.exportToshpToolStripMenuItem_Click);
            // 
            // exportToImageToolStripMenuItem
            // 
            this.exportToImageToolStripMenuItem.Name = "exportToImageToolStripMenuItem";
            this.exportToImageToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.exportToImageToolStripMenuItem.Text = "exportToImage";
            this.exportToImageToolStripMenuItem.Click += new System.EventHandler(this.exportToImageToolStripMenuItem_Click);
            // 
            // rasterToolStripMenuItem
            // 
            this.rasterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem});
            this.rasterToolStripMenuItem.Name = "rasterToolStripMenuItem";
            this.rasterToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.rasterToolStripMenuItem.Text = "Raster";
            this.rasterToolStripMenuItem.Click += new System.EventHandler(this.rasterToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.createToolStripMenuItem.Text = "exacte";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // layoutToolStripMenuItem
            // 
            this.layoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGridToolStripMenuItem,
            this.setToolStripMenuItem});
            this.layoutToolStripMenuItem.Name = "layoutToolStripMenuItem";
            this.layoutToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.layoutToolStripMenuItem.Text = "Shader";
            this.layoutToolStripMenuItem.Click += new System.EventHandler(this.layoutToolStripMenuItem_Click);
            // 
            // addGridToolStripMenuItem
            // 
            this.addGridToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGridToolStripMenuItem1,
            this.deleteGridToolStripMenuItem1});
            this.addGridToolStripMenuItem.Name = "addGridToolStripMenuItem";
            this.addGridToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.addGridToolStripMenuItem.Text = "Grid";
            // 
            // addGridToolStripMenuItem1
            // 
            this.addGridToolStripMenuItem1.Name = "addGridToolStripMenuItem1";
            this.addGridToolStripMenuItem1.Size = new System.Drawing.Size(157, 24);
            this.addGridToolStripMenuItem1.Text = "AddGrid";
            this.addGridToolStripMenuItem1.Click += new System.EventHandler(this.addGridToolStripMenuItem_Click);
            // 
            // deleteGridToolStripMenuItem1
            // 
            this.deleteGridToolStripMenuItem1.Name = "deleteGridToolStripMenuItem1";
            this.deleteGridToolStripMenuItem1.Size = new System.Drawing.Size(157, 24);
            this.deleteGridToolStripMenuItem1.Text = "DeleteGrid";
            this.deleteGridToolStripMenuItem1.Click += new System.EventHandler(this.deleteGridToolStripMenuItem_Click);
            // 
            // setToolStripMenuItem
            // 
            this.setToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shaderToolStripMenuItem,
            this.borderToolStripMenuItem,
            this.backgroundToolStripMenuItem});
            this.setToolStripMenuItem.Name = "setToolStripMenuItem";
            this.setToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.setToolStripMenuItem.Text = "Set";
            // 
            // shaderToolStripMenuItem
            // 
            this.shaderToolStripMenuItem.Name = "shaderToolStripMenuItem";
            this.shaderToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.shaderToolStripMenuItem.Text = "shader";
            this.shaderToolStripMenuItem.Click += new System.EventHandler(this.shaderToolStripMenuItem_Click);
            // 
            // borderToolStripMenuItem
            // 
            this.borderToolStripMenuItem.Name = "borderToolStripMenuItem";
            this.borderToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.borderToolStripMenuItem.Text = "border";
            this.borderToolStripMenuItem.Click += new System.EventHandler(this.borderToolStripMenuItem_Click);
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.backgroundToolStripMenuItem.Text = "background";
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem,
            this.modifyToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.addUserToolStripMenuItem.Text = "AddUser";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.deleteUserToolStripMenuItem.Text = "DeleteUser";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.modifyToolStripMenuItem.Text = "Modify";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // personToolStripMenuItem
            // 
            this.personToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personToolStripMenuItem1,
            this.buildingToolStripMenuItem});
            this.personToolStripMenuItem.Name = "personToolStripMenuItem";
            this.personToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.personToolStripMenuItem.Text = "Info";
            // 
            // personToolStripMenuItem1
            // 
            this.personToolStripMenuItem1.Name = "personToolStripMenuItem1";
            this.personToolStripMenuItem1.Size = new System.Drawing.Size(137, 24);
            this.personToolStripMenuItem1.Text = "Person";
            this.personToolStripMenuItem1.Click += new System.EventHandler(this.personToolStripMenuItem1_Click);
            // 
            // buildingToolStripMenuItem
            // 
            this.buildingToolStripMenuItem.Name = "buildingToolStripMenuItem";
            this.buildingToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.buildingToolStripMenuItem.Text = "Building";
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.axToolbarControl1.Location = new System.Drawing.Point(0, 28);
            this.axToolbarControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(1145, 28);
            this.axToolbarControl1.TabIndex = 3;
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axTOCControl1.Location = new System.Drawing.Point(0, 0);
            this.axTOCControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(254, 340);
            this.axTOCControl1.TabIndex = 4;
            this.axTOCControl1.OnMouseDown += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseDownEventHandler(this.axTOCControl1_OnMouseDown);
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(466, 278);
            this.axLicenseControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 5;
            this.axLicenseControl1.Enter += new System.EventHandler(this.axLicenseControl1_Enter);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 56);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 620);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarXY});
            this.statusStrip1.Location = new System.Drawing.Point(4, 651);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1141, 25);
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusBar1";
            // 
            // statusBarXY
            // 
            this.statusBarXY.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.statusBarXY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusBarXY.Name = "statusBarXY";
            this.statusBarXY.Size = new System.Drawing.Size(71, 20);
            this.statusBarXY.Text = "Test 123";
            // 
            // axMapControl1
            // 
            this.axMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl1.Location = new System.Drawing.Point(3, 3);
            this.axMapControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(873, 560);
            this.axMapControl1.TabIndex = 6;
            this.axMapControl1.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl1_OnMouseDown);
            this.axMapControl1.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl1_OnMouseMove);
            this.axMapControl1.OnExtentUpdated += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnExtentUpdatedEventHandler(this.axMapControl1_OnExtentUpdated);
            this.axMapControl1.OnFullExtentUpdated += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnFullExtentUpdatedEventHandler(this.axMapControl1_OnFullExtentUpdated);
            this.axMapControl1.OnMapReplaced += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMapReplacedEventHandler(this.axMapControl1_OnMapReplaced);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createRasterToolStripMenuItem,
            this.rasterRenderToolStripMenuItem,
            this.identifyToolStripMenuItem,
            this.staticsToolStripMenuItem,
            this.attributeTableToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(183, 124);
            // 
            // createRasterToolStripMenuItem
            // 
            this.createRasterToolStripMenuItem.Name = "createRasterToolStripMenuItem";
            this.createRasterToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.createRasterToolStripMenuItem.Text = "createRaster";
            this.createRasterToolStripMenuItem.Click += new System.EventHandler(this.createRasterToolStripMenuItem_Click);
            // 
            // rasterRenderToolStripMenuItem
            // 
            this.rasterRenderToolStripMenuItem.Name = "rasterRenderToolStripMenuItem";
            this.rasterRenderToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.rasterRenderToolStripMenuItem.Text = "RasterRender";
            this.rasterRenderToolStripMenuItem.Click += new System.EventHandler(this.rasterRenderToolStripMenuItem_Click);
            // 
            // identifyToolStripMenuItem
            // 
            this.identifyToolStripMenuItem.Name = "identifyToolStripMenuItem";
            this.identifyToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.identifyToolStripMenuItem.Text = "identify";
            this.identifyToolStripMenuItem.Click += new System.EventHandler(this.identifyToolStripMenuItem_Click);
            // 
            // staticsToolStripMenuItem
            // 
            this.staticsToolStripMenuItem.Name = "staticsToolStripMenuItem";
            this.staticsToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.staticsToolStripMenuItem.Text = "statics";
            this.staticsToolStripMenuItem.Click += new System.EventHandler(this.staticsToolStripMenuItem_Click);
            // 
            // attributeTableToolStripMenuItem
            // 
            this.attributeTableToolStripMenuItem.Name = "attributeTableToolStripMenuItem";
            this.attributeTableToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.attributeTableToolStripMenuItem.Text = "attributeTable";
            this.attributeTableToolStripMenuItem.Click += new System.EventHandler(this.attributeTableToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripButton9});
            this.toolStrip1.Location = new System.Drawing.Point(678, 31);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(219, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "toolStripButton7";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "toolStripButton8";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "toolStripButton9";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.splitContainer1.Location = new System.Drawing.Point(4, 56);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.axTOCControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.axMapControl2);
            this.splitContainer1.Size = new System.Drawing.Size(254, 595);
            this.splitContainer1.SplitterDistance = 340;
            this.splitContainer1.TabIndex = 2;
            // 
            // axMapControl2
            // 
            this.axMapControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl2.Location = new System.Drawing.Point(0, 0);
            this.axMapControl2.Name = "axMapControl2";
            this.axMapControl2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl2.OcxState")));
            this.axMapControl2.Size = new System.Drawing.Size(254, 251);
            this.axMapControl2.TabIndex = 0;
            this.axMapControl2.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl2_OnMouseDown);
            this.axMapControl2.OnMapReplaced += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMapReplacedEventHandler(this.axMapControl2_OnMapReplaced);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMap);
            this.tabControl1.Controls.Add(this.tabPageLayout);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(258, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(887, 595);
            this.tabControl1.TabIndex = 10;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageMap
            // 
            this.tabPageMap.Controls.Add(this.axMapControl1);
            this.tabPageMap.Location = new System.Drawing.Point(4, 25);
            this.tabPageMap.Name = "tabPageMap";
            this.tabPageMap.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMap.Size = new System.Drawing.Size(879, 566);
            this.tabPageMap.TabIndex = 0;
            this.tabPageMap.Text = "tabPageMap";
            this.tabPageMap.UseVisualStyleBackColor = true;
            // 
            // tabPageLayout
            // 
            this.tabPageLayout.Controls.Add(this.toolStrip2);
            this.tabPageLayout.Controls.Add(this.axPageLayoutControl1);
            this.tabPageLayout.Location = new System.Drawing.Point(4, 25);
            this.tabPageLayout.Name = "tabPageLayout";
            this.tabPageLayout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLayout.Size = new System.Drawing.Size(879, 566);
            this.tabPageLayout.TabIndex = 1;
            this.tabPageLayout.Text = "tabPageLayout";
            this.tabPageLayout.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(873, 28);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox1.TextChanged += new System.EventHandler(this.toolStripComboBox1_TextChanged);
            // 
            // axPageLayoutControl1
            // 
            this.axPageLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axPageLayoutControl1.Location = new System.Drawing.Point(3, 3);
            this.axPageLayoutControl1.Name = "axPageLayoutControl1";
            this.axPageLayoutControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPageLayoutControl1.OcxState")));
            this.axPageLayoutControl1.Size = new System.Drawing.Size(873, 560);
            this.axPageLayoutControl1.TabIndex = 0;
            // 
            // chooseAddressToolStripMenuItem
            // 
            this.chooseAddressToolStripMenuItem.Name = "chooseAddressToolStripMenuItem";
            this.chooseAddressToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.chooseAddressToolStripMenuItem.Text = "choose address";
            this.chooseAddressToolStripMenuItem.Click += new System.EventHandler(this.chooseAddressToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 676);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.axToolbarControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "城市建筑管理及选址系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageMap.ResumeLayout(false);
            this.tabPageLayout.ResumeLayout(false);
            this.tabPageLayout.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axPageLayoutControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuNewDoc;
        private System.Windows.Forms.ToolStripMenuItem menuOpenDoc;
        private System.Windows.Forms.ToolStripMenuItem menuSaveDoc;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuExitApp;
        private System.Windows.Forms.ToolStripSeparator menuSeparator;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBarXY;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPolygonFeatureClsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPolygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findSpatialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPointFeatureClsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selectAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToshpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createRasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rasterRenderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem identifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staticsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMap;
        private System.Windows.Forms.TabPage tabPageLayout;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private ESRI.ArcGIS.Controls.AxPageLayoutControl axPageLayoutControl1;
        private System.Windows.Forms.ToolStripMenuItem layoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGridToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteGridToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem attributeTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buildingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBuildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseAddressToolStripMenuItem;
    }
}

