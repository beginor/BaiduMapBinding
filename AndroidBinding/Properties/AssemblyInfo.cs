using System.Reflection;
using System.Runtime.CompilerServices;
using Android.App;

// Information about this assembly is defined by the following attributes.
// Change them to the values specific to your project.
[assembly: AssemblyTitle("BaiduMap")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("")]
[assembly: AssemblyCopyright("www.baidu.com")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The form "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.
[assembly: AssemblyVersion("2.3.1")]
// The following attributes are used to specify the signing key for the assembly,
// if desired. See the Mono documentation for more information about signing.
//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]

[assembly: UsesPermissionAttribute(Android.Manifest.Permission.AccessNetworkState)]
[assembly: UsesPermissionAttribute(Android.Manifest.Permission.Internet)]
[assembly: UsesPermissionAttribute(Android.Manifest.Permission.AccessWifiState)]
[assembly: UsesPermissionAttribute(Android.Manifest.Permission.ChangeWifiState)]
[assembly: UsesPermissionAttribute(Android.Manifest.Permission.WriteExternalStorage)]
[assembly: UsesPermissionAttribute(Android.Manifest.Permission.WriteSettings)]
[assembly: UsesPermissionAttribute(Android.Manifest.Permission.ReadPhoneState)]
[assembly: UsesPermissionAttribute(Android.Manifest.Permission.CallPhone)]
[assembly: UsesPermissionAttribute(Android.Manifest.Permission.AccessFineLocation)]
[assembly: UsesPermissionAttribute(Android.Manifest.Permission.AccessCoarseLocation)]
[assembly: UsesPermissionAttribute(Android.Manifest.Permission.AccessMockLocation)]
[assembly: UsesPermissionAttribute("android.permission.ACCESS_GPS")]
[assembly: Permission(Name = "android.permission.BAIDU_LOCATION_SERVICE")]
[assembly: UsesPermissionAttribute("android.permission.BAIDU_LOCATION_SERVICE")]