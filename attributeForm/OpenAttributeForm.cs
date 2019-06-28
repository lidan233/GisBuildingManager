using System;
using System.Drawing;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ADF.CATIDs;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;

namespace MapControlApplication7.attributeForm
{
    class OpenAttributeForm
    {

        private IMapControl3 m_mapControl;
        private IDisplayTable pDisplayTable;

        private ILayer m_pLayer;
        public OpenAttributeForm(ILayer pLayer, object hook)
        {
            m_pLayer = pLayer;
            m_mapControl = (IMapControl3)hook;

        }


        public void OnClick()
        {
            AttributeForm attributeTable = new AttributeForm(m_mapControl);
            attributeTable.CreateAttributeTable(m_pLayer);
            attributeTable.ShowDialog();

        }

    }
}
