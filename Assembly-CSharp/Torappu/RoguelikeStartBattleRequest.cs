using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000813 RID: 2067
	[Token(Token = "0x2000813")]
	public class RoguelikeStartBattleRequest
	{
		// Token: 0x0600649E RID: 25758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600649E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeStartBattleRequest()
		{
		}

		// Token: 0x04003120 RID: 12576
		[Token(Token = "0x4003120")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeNodePosition to;

		// Token: 0x04003121 RID: 12577
		[Token(Token = "0x4003121")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x04003122 RID: 12578
		[Token(Token = "0x4003122")]
		[FieldOffset(Offset = "0x20")]
		public CommonStartBattleRequest.SquadModel squad;
	}
}
