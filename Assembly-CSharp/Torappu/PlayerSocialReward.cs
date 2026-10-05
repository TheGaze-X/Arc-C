using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A18 RID: 2584
	[Token(Token = "0x2000A18")]
	public class PlayerSocialReward
	{
		// Token: 0x060066D8 RID: 26328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066D8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerSocialReward()
		{
		}

		// Token: 0x040037A4 RID: 14244
		[Token(Token = "0x40037A4")]
		[FieldOffset(Offset = "0x10")]
		public bool canReceive;

		// Token: 0x040037A5 RID: 14245
		[Token(Token = "0x40037A5")]
		[FieldOffset(Offset = "0x14")]
		public int first;

		// Token: 0x040037A6 RID: 14246
		[Token(Token = "0x40037A6")]
		[FieldOffset(Offset = "0x18")]
		public int assistAmount;

		// Token: 0x040037A7 RID: 14247
		[Token(Token = "0x40037A7")]
		[FieldOffset(Offset = "0x1C")]
		public int comfortAmount;
	}
}
