using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000AA4 RID: 2724
	[Token(Token = "0x2000AA4")]
	public class PlayerRecalRuneReward
	{
		// Token: 0x06006764 RID: 26468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006764")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerRecalRuneReward()
		{
		}

		// Token: 0x04003975 RID: 14709
		[Token(Token = "0x4003975")]
		[FieldOffset(Offset = "0x10")]
		public PlayerRecalRuneReward.State junior;

		// Token: 0x04003976 RID: 14710
		[Token(Token = "0x4003976")]
		[FieldOffset(Offset = "0x14")]
		public PlayerRecalRuneReward.State senior;

		// Token: 0x02000AA5 RID: 2725
		[Token(Token = "0x2000AA5")]
		public enum State
		{
			// Token: 0x04003978 RID: 14712
			[Token(Token = "0x4003978")]
			UNCLAIMED,
			// Token: 0x04003979 RID: 14713
			[Token(Token = "0x4003979")]
			CLAIMED
		}
	}
}
