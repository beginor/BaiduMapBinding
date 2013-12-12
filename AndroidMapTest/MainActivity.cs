using Android.App;
using Android.OS;
using Com.Baidu.Mapapi;
using Com.Baidu.Mapapi.Map;
using Com.Baidu.Platform.Comapi.Basestruct;

namespace BaiduMapTest {

	[Activity(Label = "BaiduMapTest", MainLauncher = true)]
	public class MainActivity : Activity {

		BMapManager mapManager;
		MapView mapView;

		protected override void OnCreate(Bundle savedInstanceState) {
			this.SetTheme(Android.Resource.Style.ThemeHolo);
			base.OnCreate(savedInstanceState);

			mapManager = new BMapManager(this.Application);
			mapManager.Init("", null);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			mapView = FindViewById<MapView>(Resource.Id.mapview);
			mapView.SetBuiltInZoomControls(true);

			var mapController = mapView.Controller;
			var point = new GeoPoint((int)(39.915 * 1E6), (int)(116.404 * 1E6));
			mapController.SetCenter(point);
			mapController.SetZoom(12);
		}

		protected override void OnDestroy() {
			mapView.Destroy();
			if (mapManager != null) {
				mapManager.Destroy();
				mapManager = null;
			}
			base.OnDestroy();
		}

		protected override void OnPause() {
			mapView.OnPause();
			if (mapManager != null) {
				mapManager.Stop();
			}
			base.OnPause();
		}

		protected override void OnResume() {
			mapView.OnResume();
			if (mapManager != null) {
				mapManager.Start();
			}
			base.OnResume();
		}
	}
}


