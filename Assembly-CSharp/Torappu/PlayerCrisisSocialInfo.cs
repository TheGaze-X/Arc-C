using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A92 RID: 2706
	[Token(Token = "0x2000A92")]
	public class PlayerCrisisSocialInfo
	{
		// Token: 0x06006756 RID: 26454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006756")]
		[Address(RVA = "0x1EF4370", Offset = "0x1EF2F70", VA = "0x181EF4370")]
		public PlayerCrisisSocialInfo()
		{
		}

		// Token: 0x0400393C RID: 14652
		[Token(Token = "0x400393C")]
		[FieldOffset(Offset = "0x10")]
		public int assistCnt;

		// Token: 0x0400393D RID: 14653
		[Token(Token = "0x400393D")]
		[FieldOffset(Offset = "0x14")]
		public int maxPnt;

		// Token: 0x0400393E RID: 14654
		[Token(Token = "0x400393E")]
		[FieldOffset(Offset = "0x18")]
		public List<PlayerCrisisSocialInfo.AssistChar> chars;

		// Token: 0x02000A93 RID: 2707
		[Token(Token = "0x2000A93")]
		public class AssistChar
		{
			// Token: 0x06006757 RID: 26455 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006757")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AssistChar()
			{
			}

			// Token: 0x0400393F RID: 14655
			[Token(Token = "0x400393F")]
			[FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x04003940 RID: 14656
			[Token(Token = "0x4003940")]
			[FieldOffset(Offset = "0x18")]
			public int cnt;
		}
	}
}
