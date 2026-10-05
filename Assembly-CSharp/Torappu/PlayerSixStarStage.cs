using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020009F8 RID: 2552
	[Token(Token = "0x20009F8")]
	public class PlayerSixStarStage
	{
		// Token: 0x060066BE RID: 26302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066BE")]
		[Address(RVA = "0x1EFE6B0", Offset = "0x1EFD2B0", VA = "0x181EFE6B0")]
		public PlayerSixStarStage()
		{
		}

		// Token: 0x0400373C RID: 14140
		[Token(Token = "0x400373C")]
		[FieldOffset(Offset = "0x10")]
		public PlayerSixStarTagFinishState tagFinish;

		// Token: 0x0400373D RID: 14141
		[Token(Token = "0x400373D")]
		[FieldOffset(Offset = "0x18")]
		public List<string> tagSelected;
	}
}
