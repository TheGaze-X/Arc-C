using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A33 RID: 2611
	[Token(Token = "0x2000A33")]
	public class PlayerPushFlags
	{
		// Token: 0x060066F1 RID: 26353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066F1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerPushFlags()
		{
		}

		// Token: 0x040037F5 RID: 14325
		[Token(Token = "0x40037F5")]
		[FieldOffset(Offset = "0x10")]
		public bool hasGifts;

		// Token: 0x040037F6 RID: 14326
		[Token(Token = "0x40037F6")]
		[FieldOffset(Offset = "0x11")]
		public bool hasFriendRequest;

		// Token: 0x040037F7 RID: 14327
		[Token(Token = "0x40037F7")]
		[FieldOffset(Offset = "0x12")]
		public bool hasClues;

		// Token: 0x040037F8 RID: 14328
		[Token(Token = "0x40037F8")]
		[FieldOffset(Offset = "0x13")]
		public bool hasFreeLevelGP;

		// Token: 0x040037F9 RID: 14329
		[Token(Token = "0x40037F9")]
		[FieldOffset(Offset = "0x18")]
		public long status;
	}
}
