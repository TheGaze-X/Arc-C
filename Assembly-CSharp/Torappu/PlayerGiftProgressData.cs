using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A2B RID: 2603
	[Token(Token = "0x2000A2B")]
	public class PlayerGiftProgressData
	{
		// Token: 0x060066EA RID: 26346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066EA")]
		[Address(RVA = "0x1EFA9A0", Offset = "0x1EF95A0", VA = "0x181EFA9A0")]
		public PlayerGiftProgressData()
		{
		}

		// Token: 0x040037D3 RID: 14291
		[Token(Token = "0x40037D3")]
		[FieldOffset(Offset = "0x10")]
		public PlayerGiftProgressPerData oneTime;

		// Token: 0x040037D4 RID: 14292
		[Token(Token = "0x40037D4")]
		[FieldOffset(Offset = "0x18")]
		public PlayerGiftProgressPerData level;

		// Token: 0x040037D5 RID: 14293
		[Token(Token = "0x40037D5")]
		[FieldOffset(Offset = "0x20")]
		public PlayerGiftProgressPerData weekly;

		// Token: 0x040037D6 RID: 14294
		[Token(Token = "0x40037D6")]
		[FieldOffset(Offset = "0x28")]
		public PlayerGiftProgressPerData monthly;

		// Token: 0x040037D7 RID: 14295
		[Token(Token = "0x40037D7")]
		[FieldOffset(Offset = "0x30")]
		public PlayerGiftProgressPerData choose;

		// Token: 0x040037D8 RID: 14296
		[Token(Token = "0x40037D8")]
		[FieldOffset(Offset = "0x38")]
		public PlayerGiftProgressPerData conditionChoose;
	}
}
