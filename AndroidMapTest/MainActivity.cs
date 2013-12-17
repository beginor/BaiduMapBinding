using Android.App;
using Android.OS;
using Com.Baidu.Mapapi;
using Com.Baidu.Mapapi.Map;
using Com.Baidu.Platform.Comapi.Basestruct;
using Android.Graphics.Drawables;
using Android.Graphics;

namespace BaiduMapTest {

	[Activity(Label = "BaiduMapTest", MainLauncher = true)]
	public class MainActivity : Activity {

		BMapManager mapManager;
		MapView mapView;

		protected override void OnCreate(Bundle savedInstanceState) {
			this.SetTheme(Android.Resource.Style.ThemeHolo);
			base.OnCreate(savedInstanceState);

			mapManager = new BMapManager(this.Application);
			mapManager.Init(GetString(Resource.String.baidu_map_api_key), null);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			mapView = FindViewById<MapView>(Resource.Id.mapview);
			mapView.SetBuiltInZoomControls(true);
			mapView.Satellite = true;

			var mapController = mapView.Controller;
			var point = new GeoPoint((int)(39.915 * 1E6), (int)(116.404 * 1E6));
			mapController.SetCenter(point);
			mapController.SetZoom(12);
			addGroundOverlay();
		}

		private void addGroundOverlay() {
			GroundOverlay overlay = new GroundOverlay(mapView);
			GeoPoint leftBottom = new GeoPoint((int)(39.815 * 1E6), (int)(116.304 * 1E6));
			GeoPoint rightUp = new GeoPoint((int)(39.999 * 1E6), (int)(116.504 * 1E6));
			Drawable d = Resources.GetDrawable(Resource.Drawable.Icon);
			Bitmap bitmap = ((BitmapDrawable)d).Bitmap;
			Ground ground = new Ground(bitmap, leftBottom, rightUp);

			mapView.Overlays.Add(overlay);
			overlay.AddGround(ground);
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


