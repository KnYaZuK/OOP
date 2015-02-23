using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Work_4
{
	enum wearsubtype
	{
		pants,
		skirt
	}

	class UnderWear : Cloth
	{
		public wearsubtype WearSubType { get; set; }
		public bool hasPockets { get; set; }
		public bool hasBelt { get; set; }
		
		
		public UnderWear () : base ()
		{
			WearSubType = wearsubtype.pants;
			hasPockets = false;
			hasBelt = false;
		}

		public UnderWear ( bool _hasPockets, bool _hasBelt ) : this ()
		{
			hasPockets = _hasPockets;
			hasBelt = _hasBelt;
		}

		public UnderWear(wearsubtype _WearSubType, bool _hasPockets, bool _hasBelt, material _Material, size _Size, color _Color)
			: base(weartype.underwear, _Material, _Size , _Color )
		{
			WearSubType = _WearSubType;
			hasPockets = _hasPockets;
			hasBelt = _hasBelt;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append("\n\nКарманы: ");
			sb.Append(hasPockets.ToString());
			sb.Append("\n\nРемень: ");
			sb.Append(hasBelt.ToString());

			return base.ToString() + sb.ToString();
		}
	}
}
