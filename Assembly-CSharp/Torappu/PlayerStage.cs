using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A00 RID: 2560
	[Token(Token = "0x2000A00")]
	public class PlayerStage
	{
		// Token: 0x060066C4 RID: 26308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066C4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerStage()
		{
		}

		// Token: 0x0400374F RID: 14159
		[Token(Token = "0x400374F")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04003750 RID: 14160
		[Token(Token = "0x4003750")]
		[FieldOffset(Offset = "0x18")]
		public int completeTimes;

		// Token: 0x04003751 RID: 14161
		[Token(Token = "0x4003751")]
		[FieldOffset(Offset = "0x1C")]
		public PlayerStageState state;

		// Token: 0x04003752 RID: 14162
		[Token(Token = "0x4003752")]
		[FieldOffset(Offset = "0x20")]
		public bool hasBattleReplay;

		// Token: 0x04003753 RID: 14163
		[Token(Token = "0x4003753")]
		[FieldOffset(Offset = "0x24")]
		public int noCostCnt;
	}
}
