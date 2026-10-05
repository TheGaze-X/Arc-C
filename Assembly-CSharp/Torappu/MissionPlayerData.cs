using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A8D RID: 2701
	[Token(Token = "0x2000A8D")]
	public class MissionPlayerData
	{
		// Token: 0x06006752 RID: 26450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006752")]
		[Address(RVA = "0x1EEC0B0", Offset = "0x1EEACB0", VA = "0x181EEC0B0")]
		public MissionPlayerData()
		{
		}

		// Token: 0x0400392E RID: 14638
		[Token(Token = "0x400392E")]
		[FieldOffset(Offset = "0x10")]
		public MissionPlayerDataGroup missions;

		// Token: 0x0400392F RID: 14639
		[Token(Token = "0x400392F")]
		[FieldOffset(Offset = "0x18")]
		public MissionDailyRewards missionRewards;

		// Token: 0x04003930 RID: 14640
		[Token(Token = "0x4003930")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, MissionPlayerData.MissionGroupState> missionGroups;

		// Token: 0x04003931 RID: 14641
		[Token(Token = "0x4003931")]
		[FieldOffset(Offset = "0x28")]
		public string pinnedSpecialOperator;

		// Token: 0x02000A8E RID: 2702
		[Token(Token = "0x2000A8E")]
		public enum MissionGroupState
		{
			// Token: 0x04003933 RID: 14643
			[Token(Token = "0x4003933")]
			Uncomplete,
			// Token: 0x04003934 RID: 14644
			[Token(Token = "0x4003934")]
			Complete
		}
	}
}
