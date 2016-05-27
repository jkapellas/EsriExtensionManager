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
            //var extensions = new[] { "Spatial Analyst", "3D Analyst", "Geostatistical Analyst", "Esri Publisher Extension" };
            var extensions = new[] { "{3C5059FE-9F15-401A-94ED-EED914D73E3E}", "{94305472-592E-11D4-80EE-00C04FA0ADF8}", "{DE0502C4-8D34-11D3-A63A-0008C7BF3347}", "{8AEE0DE1-535C-4788-95C8-1659444D4C02}" };

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
