using System;
using Il2CppDummyDll;

namespace Torappu.AVG
{
	// Token: 0x02001F3A RID: 7994
	[Token(Token = "0x2001F3A")]
	[Serializable]
	public class AVGFontPreset
	{
		// Token: 0x0600C6CB RID: 50891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6CB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AVGFontPreset()
		{
		}

		// Token: 0x0400CC4A RID: 52298
		[Token(Token = "0x400CC4A")]
		[FieldOffset(Offset = "0x10")]
		public int idx;

		// Token: 0x0400CC4B RID: 52299
		[Token(Token = "0x400CC4B")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x0400CC4C RID: 52300
		[Token(Token = "0x400CC4C")]
		[FieldOffset(Offset = "0x20")]
		public int fontsize;
	}
}
