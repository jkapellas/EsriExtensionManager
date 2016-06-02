# EsriExtensionManager

The Extension Manager is an ArcGIS Desktop (v.10.2+) add-in designed to assist with the management of concurrent use ArcGIS Extension
(e.g., Spatial Analyst, Geostatistical Analyst, etc.) licenses. When an ArcMap .mxd document is saved, all selected Extension licenses
are also saved in the document. The next time the user opens the document, the licenses for those Extensions are checked out again,
even if the user does not require the use of those licenses in the current session. This blocks the ability of other users from
checking out those licenses.

The Extension Manager resolves this issue by clearing out the selected Extension licenses each time an ArcMap document is opened. 
By doing this, the user is required to explicitly select the Extension license when they need to use the its functionality. Once
selected, the user will retain that license until the document is closed. Upon reopening, the user will need to re-select the
Extension license if they wish to use the Extension's functionality.

The ExtensionManager project is a Visual Studio 2010 C# project. To configure the Add-in for a particular set of license, open
the ExtensionLicenseManager.sln file in Visual Studio 2010 (or later). In the ExtensionLicenseManager.cs file, set the 
extensions varible to an array of Extension Name strings or GUIDs. The list of Extension Name strings and GUIDs can be found at
http://resources.arcgis.com/en/help/arcobjects-net/conceptualhelp/#/Extensions/0001000000w9000000/

Rebuild and install the Add-in as per ESRI instructions.

The Extension License Manager has been tested in ArcMap 10.2.1, 10.2.2 and 10.3.1, and with the Spatial Analyst, 3D Analyst, 
Geostatistical Analyst and Publisher extensions.

I would like to thank Freddie Gibson of ESRI Support Services for his invaluable assistance in the initial development of this add-in.

Comments, suggestions, bugfixes and enhancements are quite welcome. I hope you find this Add-in useful.


