using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000811 RID: 2065
	[Token(Token = "0x2000811")]
	public class RoguelikeRecruitAssistCharRequest
	{
		// Token: 0x0600649C RID: 25756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600649C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeRecruitAssistCharRequest()
		{
		}

		// Token: 0x0400311C RID: 12572
		[Token(Token = "0x400311C")]
		[FieldOffset(Offset = "0x10")]
		public string ticketIndex;

		// Token: 0x0400311D RID: 12573
		[Token(Token = "0x400311D")]
		[FieldOffset(Offset = "0x18")]
		public string profession;

		// Token: 0x0400311E RID: 12574
		[Token(Token = "0x400311E")]
		[FieldOffset(Offset = "0x20")]
		public string assistUid;

		// Token: 0x0400311F RID: 12575
		[Token(Token = "0x400311F")]
		[FieldOffset(Offset = "0x28")]
		public string assistCharId;
	}
}
