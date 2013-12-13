using System;
using System.Collections.Generic;
using System.Text;
using Object = Java.Lang.Object;

namespace Com.Baidu.Mapapi.Map
{
	public partial class ItemizedOverlay
	{
		public int Compare(Object left, Object right)
		{
			return left.GetHashCode() - right.GetHashCode();
		}
	}
}