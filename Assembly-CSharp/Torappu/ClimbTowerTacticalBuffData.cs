using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000F98 RID: 3992
	[Token(Token = "0x2000F98")]
	public class ClimbTowerTacticalBuffData
	{
		// Token: 0x06006CD8 RID: 27864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CD8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ClimbTowerTacticalBuffData()
		{
		}

		// Token: 0x040054D4 RID: 21716
		[Token(Token = "0x40054D4")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040054D5 RID: 21717
		[Token(Token = "0x40054D5")]
		[FieldOffset(Offset = "0x18")]
		public string desc;

		// Token: 0x040054D6 RID: 21718
		[Token(Token = "0x40054D6")]
		[FieldOffset(Offset = "0x20")]
		[JsonConverter(typeof(StringEnumConverter))]
		public ProfessionCategory profession;

		// Token: 0x040054D7 RID: 21719
		[Token(Token = "0x40054D7")]
		[FieldOffset(Offset = "0x24")]
		public bool isDefaultActive;

		// Token: 0x040054D8 RID: 21720
		[Token(Token = "0x40054D8")]
		[FieldOffset(Offset = "0x28")]
		public int sortId;

		// Token: 0x040054D9 RID: 21721
		[Token(Token = "0x40054D9")]
		[FieldOffset(Offset = "0x2C")]
		public ClimbTowerTaticalBuffType buffType;
	}
}
