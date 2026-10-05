using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003D0D RID: 15629
	[Token(Token = "0x2003D0D")]
	public class TuningChatCommitResponse : PlayerDeltaResponse
	{
		// Token: 0x060185F3 RID: 99827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185F3")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public TuningChatCommitResponse()
		{
		}

		// Token: 0x0401DCDB RID: 122075
		[Token(Token = "0x401DCDB")]
		[FieldOffset(Offset = "0x28")]
		public bool isCorrect;

		// Token: 0x0401DCDC RID: 122076
		[Token(Token = "0x401DCDC")]
		[FieldOffset(Offset = "0x30")]
		public List<RewardItemModel> items;

		// Token: 0x0401DCDD RID: 122077
		[Token(Token = "0x401DCDD")]
		[FieldOffset(Offset = "0x38")]
		public string lastMajorNPC;
	}
}
