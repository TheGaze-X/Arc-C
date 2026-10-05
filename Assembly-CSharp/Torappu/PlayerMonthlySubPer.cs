using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008F5 RID: 2293
	[Token(Token = "0x20008F5")]
	[Serializable]
	public class PlayerMonthlySubPer
	{
		// Token: 0x060065BB RID: 26043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065BB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerMonthlySubPer()
		{
		}

		// Token: 0x04003359 RID: 13145
		[Token(Token = "0x4003359")]
		[FieldOffset(Offset = "0x10")]
		public long monthlySubscriptionEndTime;

		// Token: 0x0400335A RID: 13146
		[Token(Token = "0x400335A")]
		[FieldOffset(Offset = "0x18")]
		public long monthlySubscriptionStartTime;
	}
}
