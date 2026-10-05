using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E0D RID: 3597
	[Token(Token = "0x2000E0D")]
	public class DefaultZoneData
	{
		// Token: 0x06006AE0 RID: 27360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AE0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DefaultZoneData()
		{
		}

		// Token: 0x04004AF3 RID: 19187
		[Token(Token = "0x4004AF3")]
		[FieldOffset(Offset = "0x10")]
		public string zoneId;

		// Token: 0x04004AF4 RID: 19188
		[Token(Token = "0x4004AF4")]
		[FieldOffset(Offset = "0x18")]
		public string zoneIndex;

		// Token: 0x04004AF5 RID: 19189
		[Token(Token = "0x4004AF5")]
		[FieldOffset(Offset = "0x20")]
		public string zoneName;

		// Token: 0x04004AF6 RID: 19190
		[Token(Token = "0x4004AF6")]
		[FieldOffset(Offset = "0x28")]
		public string zoneDesc;

		// Token: 0x04004AF7 RID: 19191
		[Token(Token = "0x4004AF7")]
		[FieldOffset(Offset = "0x30")]
		public List<string> itemDropList;
	}
}
