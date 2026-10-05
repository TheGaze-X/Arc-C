using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000A02 RID: 2562
	[Token(Token = "0x2000A02")]
	public class PlayerCampaign
	{
		// Token: 0x060066C6 RID: 26310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066C6")]
		[Address(RVA = "0x1EF28C0", Offset = "0x1EF14C0", VA = "0x181EF28C0")]
		public PlayerCampaign()
		{
		}

		// Token: 0x04003756 RID: 14166
		[Token(Token = "0x4003756")]
		[FieldOffset(Offset = "0x10")]
		public int campaignCurrentFee;

		// Token: 0x04003757 RID: 14167
		[Token(Token = "0x4003757")]
		[FieldOffset(Offset = "0x14")]
		public int campaignTotalFee;

		// Token: 0x04003758 RID: 14168
		[Token(Token = "0x4003758")]
		[FieldOffset(Offset = "0x18")]
		public string activeGroupId;

		// Token: 0x04003759 RID: 14169
		[Token(Token = "0x4003759")]
		[FieldOffset(Offset = "0x20")]
		public PlayerCampaign.StageOpenInfo open;

		// Token: 0x0400375A RID: 14170
		[Token(Token = "0x400375A")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, PlayerCampaign.MissionState> missions;

		// Token: 0x0400375B RID: 14171
		[Token(Token = "0x400375B")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, PlayerCampaign.Stage> instances;

		// Token: 0x0400375C RID: 14172
		[Token(Token = "0x400375C")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, int> sweepMaxKills;

		// Token: 0x02000A03 RID: 2563
		[Token(Token = "0x2000A03")]
		public class StageOpenInfo
		{
			// Token: 0x060066C7 RID: 26311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60066C7")]
			[Address(RVA = "0x1F021F0", Offset = "0x1F00DF0", VA = "0x181F021F0")]
			public StageOpenInfo()
			{
			}

			// Token: 0x0400375D RID: 14173
			[Token(Token = "0x400375D")]
			[FieldOffset(Offset = "0x10")]
			public List<string> permanent;

			// Token: 0x0400375E RID: 14174
			[Token(Token = "0x400375E")]
			[FieldOffset(Offset = "0x18")]
			public List<string> training;

			// Token: 0x0400375F RID: 14175
			[Token(Token = "0x400375F")]
			[FieldOffset(Offset = "0x20")]
			public string rotate;

			// Token: 0x04003760 RID: 14176
			[Token(Token = "0x4003760")]
			[FieldOffset(Offset = "0x28")]
			[JsonProperty(PropertyName = "rGroup")]
			public string rotateGroup;

			// Token: 0x04003761 RID: 14177
			[Token(Token = "0x4003761")]
			[FieldOffset(Offset = "0x30")]
			[JsonProperty(PropertyName = "tGroup")]
			public string trainingGroup;

			// Token: 0x04003762 RID: 14178
			[Token(Token = "0x4003762")]
			[FieldOffset(Offset = "0x38")]
			[JsonProperty(PropertyName = "tAllOpen")]
			public string trainingAllOpenGroup;
		}

		// Token: 0x02000A04 RID: 2564
		[Token(Token = "0x2000A04")]
		public class Stage
		{
			// Token: 0x060066C8 RID: 26312 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60066C8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Stage()
			{
			}

			// Token: 0x04003763 RID: 14179
			[Token(Token = "0x4003763")]
			[FieldOffset(Offset = "0x10")]
			public int maxKills;

			// Token: 0x04003764 RID: 14180
			[Token(Token = "0x4003764")]
			[FieldOffset(Offset = "0x18")]
			public int[] rewardStatus;
		}

		// Token: 0x02000A05 RID: 2565
		[Token(Token = "0x2000A05")]
		public enum MissionState
		{
			// Token: 0x04003766 RID: 14182
			[Token(Token = "0x4003766")]
			UNCOMPLETE,
			// Token: 0x04003767 RID: 14183
			[Token(Token = "0x4003767")]
			COMPLETE,
			// Token: 0x04003768 RID: 14184
			[Token(Token = "0x4003768")]
			FINISHED
		}
	}
}
