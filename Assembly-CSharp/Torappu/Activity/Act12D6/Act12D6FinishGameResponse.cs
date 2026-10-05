using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007AC9 RID: 31433
	[Token(Token = "0x2007AC9")]
	public class Act12D6FinishGameResponse : PlayerDeltaResponse
	{
		// Token: 0x0602C052 RID: 180306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C052")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act12D6FinishGameResponse()
		{
		}

		// Token: 0x0403FC99 RID: 261273
		[Token(Token = "0x403FC99")]
		[FieldOffset(Offset = "0x28")]
		public int buffToken;

		// Token: 0x0403FC9A RID: 261274
		[Token(Token = "0x403FC9A")]
		[FieldOffset(Offset = "0x2C")]
		public int milestoneToken;

		// Token: 0x0403FC9B RID: 261275
		[Token(Token = "0x403FC9B")]
		[FieldOffset(Offset = "0x30")]
		public int unlockRelicBuffToken;

		// Token: 0x0403FC9C RID: 261276
		[Token(Token = "0x403FC9C")]
		[FieldOffset(Offset = "0x34")]
		public int unlockRelicMilestoneToken;
	}
}
