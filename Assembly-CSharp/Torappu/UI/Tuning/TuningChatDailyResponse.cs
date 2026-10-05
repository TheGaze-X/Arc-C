using System;
using Il2CppDummyDll;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003D0F RID: 15631
	[Token(Token = "0x2003D0F")]
	public class TuningChatDailyResponse : TuningChatCommitResponse
	{
		// Token: 0x060185F5 RID: 99829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185F5")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public TuningChatDailyResponse()
		{
		}

		// Token: 0x0401DCE1 RID: 122081
		[Token(Token = "0x401DCE1")]
		[FieldOffset(Offset = "0x40")]
		public int tryTimes;

		// Token: 0x0401DCE2 RID: 122082
		[Token(Token = "0x401DCE2")]
		[FieldOffset(Offset = "0x48")]
		public TuningChatDailyAnswer dailyAnswer;

		// Token: 0x0401DCE3 RID: 122083
		[Token(Token = "0x401DCE3")]
		[FieldOffset(Offset = "0x58")]
		public bool openRare;
	}
}
