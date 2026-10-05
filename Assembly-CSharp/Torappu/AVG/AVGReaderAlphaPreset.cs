using System;
using Il2CppDummyDll;

namespace Torappu.AVG
{
	// Token: 0x02001F3C RID: 7996
	[Token(Token = "0x2001F3C")]
	[Serializable]
	public class AVGReaderAlphaPreset
	{
		// Token: 0x0600C6CD RID: 50893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6CD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AVGReaderAlphaPreset()
		{
		}

		// Token: 0x0400CC50 RID: 52304
		[Token(Token = "0x400CC50")]
		[FieldOffset(Offset = "0x10")]
		public int idx;

		// Token: 0x0400CC51 RID: 52305
		[Token(Token = "0x400CC51")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x0400CC52 RID: 52306
		[Token(Token = "0x400CC52")]
		[FieldOffset(Offset = "0x20")]
		public int alpha;
	}
}
