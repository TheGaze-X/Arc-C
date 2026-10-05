using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E61 RID: 3681
	[Token(Token = "0x2000E61")]
	public class ActVecBreakV2ScheduleBlockData
	{
		// Token: 0x06006B2E RID: 27438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B2E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActVecBreakV2ScheduleBlockData()
		{
		}

		// Token: 0x04004D10 RID: 19728
		[Token(Token = "0x4004D10")]
		[FieldOffset(Offset = "0x10")]
		public long startTs;

		// Token: 0x04004D11 RID: 19729
		[Token(Token = "0x4004D11")]
		[FieldOffset(Offset = "0x18")]
		public long endTs;
	}
}
