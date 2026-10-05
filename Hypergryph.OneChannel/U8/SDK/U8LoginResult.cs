using System;
using Il2CppDummyDll;

namespace U8.SDK
{
	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	public struct U8LoginResult
	{
		// Token: 0x060001F7 RID: 503 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x4A21D50", Offset = "0x4A20950", VA = "0x184A21D50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly U8LoginResult EMPTY;

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x0")]
		public int result;

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x8")]
		public string uid;

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x10")]
		public string channelUid;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x18")]
		public string token;

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x20")]
		public string extension;

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x28")]
		public bool isGuest;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x29")]
		public bool isNew;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x30")]
		public string error;
	}
}
