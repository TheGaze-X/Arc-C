using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004412 RID: 17426
	[Token(Token = "0x2004412")]
	public class SandboxV2RacingBattleFinishResponse : CommonFinishBattleResponse
	{
		// Token: 0x0601A9DA RID: 109018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A9DA")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "10")]
		public override List<ServiceAlertStruct> GetAlert()
		{
			return null;
		}

		// Token: 0x0601A9DB RID: 109019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A9DB")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "7")]
		public override List<CommonFinishBattleResponse.RewardModel> GetFirstRewards()
		{
			return null;
		}

		// Token: 0x0601A9DC RID: 109020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9DC")]
		[Address(RVA = "0x10D1D30", Offset = "0x10D0930", VA = "0x1810D1D30", Slot = "6")]
		public override void GetGoldAndExpScale(out float goldScale, out float expScale)
		{
		}

		// Token: 0x0601A9DD RID: 109021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A9DD")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "9")]
		public override string[] GetUnlockStages()
		{
			return null;
		}

		// Token: 0x0601A9DE RID: 109022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9DE")]
		[Address(RVA = "0x10D1D40", Offset = "0x10D0940", VA = "0x1810D1D40")]
		public SandboxV2RacingBattleFinishResponse()
		{
		}

		// Token: 0x04021ED8 RID: 138968
		[Token(Token = "0x4021ED8")]
		[FieldOffset(Offset = "0x68")]
		public bool giveUp;

		// Token: 0x04021ED9 RID: 138969
		[Token(Token = "0x4021ED9")]
		[FieldOffset(Offset = "0x70")]
		public string myRacer;

		// Token: 0x04021EDA RID: 138970
		[Token(Token = "0x4021EDA")]
		[FieldOffset(Offset = "0x78")]
		public string myMedalId;

		// Token: 0x04021EDB RID: 138971
		[Token(Token = "0x4021EDB")]
		[FieldOffset(Offset = "0x80")]
		public List<SandboxV2RacingBattleFinishResponse.RacerInfo> rankList;

		// Token: 0x04021EDC RID: 138972
		[Token(Token = "0x4021EDC")]
		[FieldOffset(Offset = "0x88")]
		public bool isNewBest;

		// Token: 0x04021EDD RID: 138973
		[Token(Token = "0x4021EDD")]
		[FieldOffset(Offset = "0x8C")]
		public int bestTime;

		// Token: 0x04021EDE RID: 138974
		[Token(Token = "0x4021EDE")]
		[FieldOffset(Offset = "0x90")]
		public new List<SandboxV2CommonRewardItem> rewards;

		// Token: 0x02004413 RID: 17427
		[Token(Token = "0x2004413")]
		public class RacerInfo
		{
			// Token: 0x0601A9DF RID: 109023 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A9DF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RacerInfo()
			{
			}

			// Token: 0x04021EDF RID: 138975
			[Token(Token = "0x4021EDF")]
			[FieldOffset(Offset = "0x10")]
			public string inst;

			// Token: 0x04021EE0 RID: 138976
			[Token(Token = "0x4021EE0")]
			[FieldOffset(Offset = "0x18")]
			public string id;

			// Token: 0x04021EE1 RID: 138977
			[Token(Token = "0x4021EE1")]
			[FieldOffset(Offset = "0x20")]
			public SandboxV2RacingBattleFinishResponse.RacerName name;

			// Token: 0x04021EE2 RID: 138978
			[Token(Token = "0x4021EE2")]
			[FieldOffset(Offset = "0x28")]
			public int time;
		}

		// Token: 0x02004414 RID: 17428
		[Token(Token = "0x2004414")]
		public class RacerName
		{
			// Token: 0x0601A9E0 RID: 109024 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A9E0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RacerName()
			{
			}

			// Token: 0x04021EE3 RID: 138979
			[Token(Token = "0x4021EE3")]
			[FieldOffset(Offset = "0x10")]
			public string prefix;

			// Token: 0x04021EE4 RID: 138980
			[Token(Token = "0x4021EE4")]
			[FieldOffset(Offset = "0x18")]
			public string suffix;
		}
	}
}
