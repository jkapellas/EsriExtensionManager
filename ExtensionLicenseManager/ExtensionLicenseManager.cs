using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ESRI.ArcGIS.esriSystem;

namespace ExtensionLicenseManager
{
    public class ExtensionLicenseManager : ESRI.ArcGIS.Desktop.AddIns.Extension
    {


        protected override void OnStartup()
        {
            ArcMap.Events.NewDocument += Events_Document;
            ArcMap.Events.OpenDocument += Events_Document;
        }


        void Events_Document()
        {
            var extMgr = ArcMap.Application as IExtensionManager;
            var extensions = new[] { "Spatial Analyst", "3D Analyst", "Geostatistical Analyst", "Esri Publisher Extension" };

            foreach (var name in extensions)
            {
                var ext = extMgr.FindExtension(name);
                var extcfg = ext as IExtensionConfig;
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Extension is {1}", name, extcfg.State == esriExtensionState.esriESEnabled == true ? "ENABLED" : "DISABLED"));

                extcfg.State = esriExtensionState.esriESDisabled;
            }
        
        }

    }

}
