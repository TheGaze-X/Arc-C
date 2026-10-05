using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000B6F RID: 2927
	[Token(Token = "0x2000B6F")]
	public class TowerSeason
	{
		// Token: 0x0600680D RID: 26637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600680D")]
		[Address(RVA = "0x1F02DA0", Offset = "0x1F019A0", VA = "0x181F02DA0")]
		public TowerSeason()
		{
		}

		// Token: 0x04003CDF RID: 15583
		[Token(Token = "0x4003CDF")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04003CE0 RID: 15584
		[Token(Token = "0x4003CE0")]
		[FieldOffset(Offset = "0x18")]
		public long finishTs;

		// Token: 0x04003CE1 RID: 15585
		[Token(Token = "0x4003CE1")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, TowerSeason.TowerSeasonMission> missions;

		// Token: 0x04003CE2 RID: 15586
		[Token(Token = "0x4003CE2")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, string[]> passWithGodCard;

		// Token: 0x04003CE3 RID: 15587
		[Token(Token = "0x4003CE3")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty(PropertyName = "slots")]
		public Dictionary<string, TowerSeason.TowerSeasonCardSquad[]> towerSlotsMap;

		// Token: 0x04003CE4 RID: 15588
		[Token(Token = "0x4003CE4")]
		[FieldOffset(Offset = "0x38")]
		public TowerSeason.TowerSeasonPeriod period;

		// Token: 0x02000B70 RID: 2928
		[Token(Token = "0x2000B70")]
		public class TowerSeasonMission
		{
			// Token: 0x0600680E RID: 26638 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600680E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TowerSeasonMission()
			{
			}

			// Token: 0x04003CE5 RID: 15589
			[Token(Token = "0x4003CE5")]
			[FieldOffset(Offset = "0x10")]
			public int target;

			// Token: 0x04003CE6 RID: 15590
			[Token(Token = "0x4003CE6")]
			[FieldOffset(Offset = "0x14")]
			public int value;

			// Token: 0x04003CE7 RID: 15591
			[Token(Token = "0x4003CE7")]
			[FieldOffset(Offset = "0x18")]
			public bool hasRecv;
		}

		// Token: 0x02000B71 RID: 2929
		[Token(Token = "0x2000B71")]
		public class TowerSeasonCardSquad
		{
			// Token: 0x0600680F RID: 26639 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600680F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TowerSeasonCardSquad()
			{
			}

			// Token: 0x04003CE8 RID: 15592
			[Token(Token = "0x4003CE8")]
			[FieldOffset(Offset = "0x10")]
			public string godCardId;

			// Token: 0x04003CE9 RID: 15593
			[Token(Token = "0x4003CE9")]
			[FieldOffset(Offset = "0x18")]
			public PlayerSquadItem[] squad;
		}

		// Token: 0x02000B72 RID: 2930
		[Token(Token = "0x2000B72")]
		public class TowerSeasonPeriod
		{
			// Token: 0x06006810 RID: 26640 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006810")]
			[Address(RVA = "0x1F02D10", Offset = "0x1F01910", VA = "0x181F02D10")]
			public TowerSeasonPeriod()
			{
			}

			// Token: 0x04003CEA RID: 15594
			[Token(Token = "0x4003CEA")]
			[FieldOffset(Offset = "0x10")]
			public long termTs;

			// Token: 0x04003CEB RID: 15595
			[Token(Token = "0x4003CEB")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, int> items;

			// Token: 0x04003CEC RID: 15596
			[Token(Token = "0x4003CEC")]
			[FieldOffset(Offset = "0x20")]
			[JsonProperty(PropertyName = "cur")]
			public int periodCurr;

			// Token: 0x04003CED RID: 15597
			[Token(Token = "0x4003CED")]
			[FieldOffset(Offset = "0x24")]
			[JsonProperty(PropertyName = "len")]
			public int periodCount;
		}
	}
}
