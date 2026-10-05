using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001024 RID: 4132
	[Token(Token = "0x2001024")]
	public class MagazineLeafData
	{
		// Token: 0x06006D76 RID: 28022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D76")]
		[Address(RVA = "0x2106E40", Offset = "0x2105A40", VA = "0x182106E40")]
		public MagazineLeafData()
		{
		}

		// Token: 0x040057B9 RID: 22457
		[Token(Token = "0x40057B9")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, MagazineLeafItemData> leafMap;

		// Token: 0x040057BA RID: 22458
		[Token(Token = "0x40057BA")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, MagazineLeafDecorTypeData> leafDecorTypeMap;

		// Token: 0x040057BB RID: 22459
		[Token(Token = "0x40057BB")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, MagazineLeafTypeData> leafTypeMap;

		// Token: 0x040057BC RID: 22460
		[Token(Token = "0x40057BC")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, ArtMagazineLeafData> leafTemplateMap;

		// Token: 0x040057BD RID: 22461
		[Token(Token = "0x40057BD")]
		[FieldOffset(Offset = "0x30")]
		public MagazineLeafConst constData;

		// Token: 0x040057BE RID: 22462
		[Token(Token = "0x40057BE")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, Dictionary<string, int>> blackListInDiy;
	}
}
