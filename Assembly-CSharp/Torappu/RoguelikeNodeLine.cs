using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001160 RID: 4448
	[Token(Token = "0x2001160")]
	public class RoguelikeNodeLine
	{
		// Token: 0x06006F3F RID: 28479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F3F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeNodeLine()
		{
		}

		// Token: 0x04005F44 RID: 24388
		[Token(Token = "0x4005F44")]
		[FieldOffset(Offset = "0x10")]
		public int x;

		// Token: 0x04005F45 RID: 24389
		[Token(Token = "0x4005F45")]
		[FieldOffset(Offset = "0x14")]
		public int y;

		// Token: 0x04005F46 RID: 24390
		[Token(Token = "0x4005F46")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeNodeLine.HiddenType hidden;

		// Token: 0x04005F47 RID: 24391
		[Token(Token = "0x4005F47")]
		[FieldOffset(Offset = "0x1C")]
		public bool key;

		// Token: 0x02001161 RID: 4449
		[Token(Token = "0x2001161")]
		public enum HiddenType
		{
			// Token: 0x04005F49 RID: 24393
			[Token(Token = "0x4005F49")]
			SHOW,
			// Token: 0x04005F4A RID: 24394
			[Token(Token = "0x4005F4A")]
			HIDE,
			// Token: 0x04005F4B RID: 24395
			[Token(Token = "0x4005F4B")]
			APPEAR
		}
	}
}
