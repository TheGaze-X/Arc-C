using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using XLua;

namespace Torappu
{
	// Token: 0x02000F3C RID: 3900
	[Token(Token = "0x2000F3C")]
	[Serializable]
	public class CampaignData : IHotfixable
	{
		// Token: 0x06006C42 RID: 27714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C42")]
		[Address(RVA = "0x20078C0", Offset = "0x20064C0", VA = "0x1820078C0")]
		public CampaignData.GainLadder GetGainDataOrDefault(int killCnt)
		{
			return null;
		}

		// Token: 0x06006C43 RID: 27715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C43")]
		[Address(RVA = "0x2007A80", Offset = "0x2006680", VA = "0x182007A80")]
		public CampaignData.GainLadder GetGainDataOrDefault(CampaignStageType stageType, int killCnt)
		{
			return null;
		}

		// Token: 0x06006C44 RID: 27716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C44")]
		[Address(RVA = "0x2007BF0", Offset = "0x20067F0", VA = "0x182007BF0")]
		public CampaignData()
		{
		}

		// Token: 0x040052F4 RID: 21236
		[Token(Token = "0x40052F4")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x040052F5 RID: 21237
		[Token(Token = "0x40052F5")]
		[FieldOffset(Offset = "0x18")]
		public int isSmallScale;

		// Token: 0x040052F6 RID: 21238
		[Token(Token = "0x40052F6")]
		[FieldOffset(Offset = "0x20")]
		public List<CampaignData.BreakRewardLadder> breakLadders;

		// Token: 0x040052F7 RID: 21239
		[Token(Token = "0x40052F7")]
		[FieldOffset(Offset = "0x28")]
		public bool isCustomized;

		// Token: 0x040052F8 RID: 21240
		[Token(Token = "0x40052F8")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<CampaignStageType, CampaignData.DropGainInfo> dropGains;

		// Token: 0x040052F9 RID: 21241
		[Token(Token = "0x40052F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetGainDataOrDefault;

		// Token: 0x040052FA RID: 21242
		[Token(Token = "0x40052FA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_GetGainDataOrDefault;

		// Token: 0x040052FB RID: 21243
		[Token(Token = "0x40052FB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02000F3D RID: 3901
		[Token(Token = "0x2000F3D")]
		[Serializable]
		public class CampaignDropInfo
		{
			// Token: 0x06006C45 RID: 27717 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C45")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CampaignDropInfo()
			{
			}

			// Token: 0x040052FC RID: 21244
			[Token(Token = "0x40052FC")]
			[FieldOffset(Offset = "0x10")]
			public ItemBundle[] firstPassRewards;

			// Token: 0x040052FD RID: 21245
			[Token(Token = "0x40052FD")]
			[FieldOffset(Offset = "0x18")]
			public WeightItemBundle[][] passRewards;

			// Token: 0x040052FE RID: 21246
			[Token(Token = "0x40052FE")]
			[FieldOffset(Offset = "0x20")]
			public List<StageData.DisplayDetailRewards> displayDetailRewards;
		}

		// Token: 0x02000F3E RID: 3902
		[Token(Token = "0x2000F3E")]
		[Serializable]
		public class BreakRewardLadder
		{
			// Token: 0x06006C46 RID: 27718 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C46")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BreakRewardLadder()
			{
			}

			// Token: 0x040052FF RID: 21247
			[Token(Token = "0x40052FF")]
			[FieldOffset(Offset = "0x0")]
			[JsonIgnore]
			[NonSerialized]
			public static readonly CampaignData.BreakRewardLadder DEFAULT;

			// Token: 0x04005300 RID: 21248
			[Token(Token = "0x4005300")]
			[FieldOffset(Offset = "0x10")]
			public int killCnt;

			// Token: 0x04005301 RID: 21249
			[Token(Token = "0x4005301")]
			[FieldOffset(Offset = "0x14")]
			public int breakFeeAdd;

			// Token: 0x04005302 RID: 21250
			[Token(Token = "0x4005302")]
			[FieldOffset(Offset = "0x18")]
			public ItemBundle[] rewards;
		}

		// Token: 0x02000F3F RID: 3903
		[Token(Token = "0x2000F3F")]
		[Serializable]
		public class DropLadder
		{
			// Token: 0x06006C48 RID: 27720 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C48")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DropLadder()
			{
			}

			// Token: 0x04005303 RID: 21251
			[Token(Token = "0x4005303")]
			[FieldOffset(Offset = "0x0")]
			[JsonIgnore]
			[NonSerialized]
			public static readonly CampaignData.DropLadder DEFAULT;

			// Token: 0x04005304 RID: 21252
			[Token(Token = "0x4005304")]
			[FieldOffset(Offset = "0x10")]
			public int killCnt;

			// Token: 0x04005305 RID: 21253
			[Token(Token = "0x4005305")]
			[FieldOffset(Offset = "0x18")]
			public CampaignData.CampaignDropInfo dropInfo;
		}

		// Token: 0x02000F40 RID: 3904
		[Token(Token = "0x2000F40")]
		[Serializable]
		public class GainLadder
		{
			// Token: 0x06006C4A RID: 27722 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C4A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public GainLadder()
			{
			}

			// Token: 0x04005306 RID: 21254
			[Token(Token = "0x4005306")]
			[FieldOffset(Offset = "0x0")]
			[JsonIgnore]
			[NonSerialized]
			public static readonly CampaignData.GainLadder DEFAULT;

			// Token: 0x04005307 RID: 21255
			[Token(Token = "0x4005307")]
			[FieldOffset(Offset = "0x10")]
			public int killCnt;

			// Token: 0x04005308 RID: 21256
			[Token(Token = "0x4005308")]
			[FieldOffset(Offset = "0x14")]
			public int apFailReturn;

			// Token: 0x04005309 RID: 21257
			[Token(Token = "0x4005309")]
			[FieldOffset(Offset = "0x18")]
			public int favor;

			// Token: 0x0400530A RID: 21258
			[Token(Token = "0x400530A")]
			[FieldOffset(Offset = "0x1C")]
			public int expGain;

			// Token: 0x0400530B RID: 21259
			[Token(Token = "0x400530B")]
			[FieldOffset(Offset = "0x20")]
			public int goldGain;

			// Token: 0x0400530C RID: 21260
			[Token(Token = "0x400530C")]
			[FieldOffset(Offset = "0x24")]
			public int displayDiamondShdNum;
		}

		// Token: 0x02000F41 RID: 3905
		[Token(Token = "0x2000F41")]
		[Serializable]
		public class DropGainInfo
		{
			// Token: 0x06006C4C RID: 27724 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C4C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DropGainInfo()
			{
			}

			// Token: 0x0400530D RID: 21261
			[Token(Token = "0x400530D")]
			[FieldOffset(Offset = "0x10")]
			public List<CampaignData.DropLadder> dropLadders;

			// Token: 0x0400530E RID: 21262
			[Token(Token = "0x400530E")]
			[FieldOffset(Offset = "0x18")]
			public List<CampaignData.GainLadder> gainLadders;

			// Token: 0x0400530F RID: 21263
			[Token(Token = "0x400530F")]
			[FieldOffset(Offset = "0x20")]
			public List<StageData.DisplayRewards> displayRewards;

			// Token: 0x04005310 RID: 21264
			[Token(Token = "0x4005310")]
			[FieldOffset(Offset = "0x28")]
			public List<StageData.DisplayDetailRewards> displayDetailRewards;
		}
	}
}
