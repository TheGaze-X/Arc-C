using System;
using Il2CppDummyDll;

namespace Torappu.AVG
{
	// Token: 0x02001F3B RID: 7995
	[Token(Token = "0x2001F3B")]
	[Serializable]
	public class AVGReaderLineSpacePreset
	{
		// Token: 0x0600C6CC RID: 50892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6CC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AVGReaderLineSpacePreset()
		{
		}

		// Token: 0x0400CC4D RID: 52301
		[Token(Token = "0x400CC4D")]
		[FieldOffset(Offset = "0x10")]
		public int idx;

		// Token: 0x0400CC4E RID: 52302
		[Token(Token = "0x400CC4E")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x0400CC4F RID: 52303
		[Token(Token = "0x400CC4F")]
		[FieldOffset(Offset = "0x20")]
		public int lineSpace;
	}
}
