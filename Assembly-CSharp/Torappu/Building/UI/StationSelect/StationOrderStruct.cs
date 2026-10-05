using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C72 RID: 7282
	[Token(Token = "0x2001C72")]
	public struct StationOrderStruct
	{
		// Token: 0x0600B4E7 RID: 46311 RVA: 0x00044B08 File Offset: 0x00042D08
		[Token(Token = "0x600B4E7")]
		[Address(RVA = "0x32FC510", Offset = "0x32FB110", VA = "0x1832FC510")]
		public bool FilterStationStatus(StationCharViewModel charItem)
		{
			return default(bool);
		}

		// Token: 0x0400B0E7 RID: 45287
		[Token(Token = "0x400B0E7")]
		[FieldOffset(Offset = "0x0")]
		public CharSortType sortType;

		// Token: 0x0400B0E8 RID: 45288
		[Token(Token = "0x400B0E8")]
		[FieldOffset(Offset = "0x4")]
		public bool isInverse;

		// Token: 0x0400B0E9 RID: 45289
		[Token(Token = "0x400B0E9")]
		[FieldOffset(Offset = "0x8")]
		public BuildingData.CharStationFilterType stationFilterType;
	}
}
