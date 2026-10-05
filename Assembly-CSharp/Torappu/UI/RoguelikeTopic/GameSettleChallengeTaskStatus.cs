using System;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200454F RID: 17743
	[Token(Token = "0x200454F")]
	public class GameSettleChallengeTaskStatus
	{
		// Token: 0x0601B0A7 RID: 110759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0A7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GameSettleChallengeTaskStatus()
		{
		}

		// Token: 0x04022BD8 RID: 142296
		[Token(Token = "0x4022BD8")]
		[FieldOffset(Offset = "0x10")]
		public string taskId;

		// Token: 0x04022BD9 RID: 142297
		[Token(Token = "0x4022BD9")]
		[FieldOffset(Offset = "0x18")]
		public int[] progress;
	}
}
