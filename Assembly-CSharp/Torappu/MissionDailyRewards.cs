using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A8A RID: 2698
	[Token(Token = "0x2000A8A")]
	public class MissionDailyRewards
	{
		// Token: 0x06006744 RID: 26436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006744")]
		[Address(RVA = "0x1EEB9D0", Offset = "0x1EEA5D0", VA = "0x181EEB9D0")]
		public MissionDailyRewards()
		{
		}

		// Token: 0x04003921 RID: 14625
		[Token(Token = "0x4003921")]
		[FieldOffset(Offset = "0x10")]
		public int dailyPoint;

		// Token: 0x04003922 RID: 14626
		[Token(Token = "0x4003922")]
		[FieldOffset(Offset = "0x14")]
		public int weeklyPoint;

		// Token: 0x04003923 RID: 14627
		[Token(Token = "0x4003923")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, Dictionary<string, int>> rewards;
	}
}
