using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F9D RID: 3997
	[Token(Token = "0x2000F9D")]
	public class ClimbTowerSeasonInfoData
	{
		// Token: 0x06006CDD RID: 27869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CDD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ClimbTowerSeasonInfoData()
		{
		}

		// Token: 0x040054F1 RID: 21745
		[Token(Token = "0x40054F1")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040054F2 RID: 21746
		[Token(Token = "0x40054F2")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x040054F3 RID: 21747
		[Token(Token = "0x40054F3")]
		[FieldOffset(Offset = "0x20")]
		public int seasonNum;

		// Token: 0x040054F4 RID: 21748
		[Token(Token = "0x40054F4")]
		[FieldOffset(Offset = "0x28")]
		public long startTs;

		// Token: 0x040054F5 RID: 21749
		[Token(Token = "0x40054F5")]
		[FieldOffset(Offset = "0x30")]
		public long endTs;

		// Token: 0x040054F6 RID: 21750
		[Token(Token = "0x40054F6")]
		[FieldOffset(Offset = "0x38")]
		public List<string> towers;

		// Token: 0x040054F7 RID: 21751
		[Token(Token = "0x40054F7")]
		[FieldOffset(Offset = "0x40")]
		public List<string> seasonCards;

		// Token: 0x040054F8 RID: 21752
		[Token(Token = "0x40054F8")]
		[FieldOffset(Offset = "0x48")]
		public List<string> replicatedTowers;
	}
}
