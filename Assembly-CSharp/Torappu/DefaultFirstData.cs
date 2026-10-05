using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E0E RID: 3598
	[Token(Token = "0x2000E0E")]
	public class DefaultFirstData
	{
		// Token: 0x06006AE1 RID: 27361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AE1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DefaultFirstData()
		{
		}

		// Token: 0x04004AF8 RID: 19192
		[Token(Token = "0x4004AF8")]
		[FieldOffset(Offset = "0x10")]
		public List<DefaultZoneData> zoneList;

		// Token: 0x04004AF9 RID: 19193
		[Token(Token = "0x4004AF9")]
		[FieldOffset(Offset = "0x18")]
		public List<DefaultShopData> shopList;
	}
}
