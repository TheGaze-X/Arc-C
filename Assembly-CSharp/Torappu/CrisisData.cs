using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001269 RID: 4713
	[Token(Token = "0x2001269")]
	[Serializable]
	public class CrisisData
	{
		// Token: 0x060071EC RID: 29164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071EC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisData()
		{
		}

		// Token: 0x040067E8 RID: 26600
		[Token(Token = "0x40067E8")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, CrisisData.RuneMapInfo> mapInfo;

		// Token: 0x040067E9 RID: 26601
		[Token(Token = "0x40067E9")]
		[FieldOffset(Offset = "0x18")]
		public List<CrisisData.SeasonInfo> seasonInfo;

		// Token: 0x040067EA RID: 26602
		[Token(Token = "0x40067EA")]
		[FieldOffset(Offset = "0x20")]
		public List<CrisisData.TrainingInfo> trainingInfo;

		// Token: 0x040067EB RID: 26603
		[Token(Token = "0x40067EB")]
		[FieldOffset(Offset = "0x28")]
		public List<CrisisData.LongTermShopInfo> shopInfoList;

		// Token: 0x040067EC RID: 26604
		[Token(Token = "0x40067EC")]
		[FieldOffset(Offset = "0x30")]
		public List<CrisisData.ProgressGoodItem> progressGoodInfo;

		// Token: 0x0200126A RID: 4714
		[Token(Token = "0x200126A")]
		public enum StageType
		{
			// Token: 0x040067EE RID: 26606
			[Token(Token = "0x40067EE")]
			TEMPORARY,
			// Token: 0x040067EF RID: 26607
			[Token(Token = "0x40067EF")]
			PERMANENT
		}

		// Token: 0x0200126B RID: 4715
		[Token(Token = "0x200126B")]
		public class RuneReleaseData
		{
			// Token: 0x060071ED RID: 29165 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071ED")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RuneReleaseData()
			{
			}

			// Token: 0x040067F0 RID: 26608
			[Token(Token = "0x40067F0")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x040067F1 RID: 26609
			[Token(Token = "0x40067F1")]
			[FieldOffset(Offset = "0x18")]
			public List<string> runeId;

			// Token: 0x040067F2 RID: 26610
			[Token(Token = "0x40067F2")]
			[FieldOffset(Offset = "0x20")]
			public long releaseTime;
		}

		// Token: 0x0200126C RID: 4716
		[Token(Token = "0x200126C")]
		public class CrisisStagePointLevelChallengeInfo
		{
			// Token: 0x060071EE RID: 29166 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071EE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CrisisStagePointLevelChallengeInfo()
			{
			}

			// Token: 0x040067F3 RID: 26611
			[Token(Token = "0x40067F3")]
			[FieldOffset(Offset = "0x10")]
			public int pointCount;

			// Token: 0x040067F4 RID: 26612
			[Token(Token = "0x40067F4")]
			[FieldOffset(Offset = "0x14")]
			public int shopCoin;

			// Token: 0x040067F5 RID: 26613
			[Token(Token = "0x40067F5")]
			[FieldOffset(Offset = "0x18")]
			public int runeCoin;

			// Token: 0x040067F6 RID: 26614
			[Token(Token = "0x40067F6")]
			[FieldOffset(Offset = "0x20")]
			public ItemBundle itemReward;

			// Token: 0x040067F7 RID: 26615
			[Token(Token = "0x40067F7")]
			[FieldOffset(Offset = "0x28")]
			public string descrption;
		}

		// Token: 0x0200126D RID: 4717
		[Token(Token = "0x200126D")]
		public class CrisisTeRunePackChallengeInfo
		{
			// Token: 0x060071EF RID: 29167 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071EF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CrisisTeRunePackChallengeInfo()
			{
			}

			// Token: 0x040067F8 RID: 26616
			[Token(Token = "0x40067F8")]
			[FieldOffset(Offset = "0x10")]
			public string challengeId;

			// Token: 0x040067F9 RID: 26617
			[Token(Token = "0x40067F9")]
			[FieldOffset(Offset = "0x18")]
			public int slotIndex;

			// Token: 0x040067FA RID: 26618
			[Token(Token = "0x40067FA")]
			[FieldOffset(Offset = "0x1C")]
			public int shopCoin;

			// Token: 0x040067FB RID: 26619
			[Token(Token = "0x40067FB")]
			[FieldOffset(Offset = "0x20")]
			public int runeCoin;

			// Token: 0x040067FC RID: 26620
			[Token(Token = "0x40067FC")]
			[FieldOffset(Offset = "0x28")]
			public ItemBundle itemReward;

			// Token: 0x040067FD RID: 26621
			[Token(Token = "0x40067FD")]
			[FieldOffset(Offset = "0x30")]
			public string descrption;

			// Token: 0x040067FE RID: 26622
			[Token(Token = "0x40067FE")]
			[FieldOffset(Offset = "0x38")]
			public bool ableToUseBenefit;
		}

		// Token: 0x0200126E RID: 4718
		[Token(Token = "0x200126E")]
		public class CrisisPeRunePackChallengeInfo
		{
			// Token: 0x060071F0 RID: 29168 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071F0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CrisisPeRunePackChallengeInfo()
			{
			}

			// Token: 0x040067FF RID: 26623
			[Token(Token = "0x40067FF")]
			[FieldOffset(Offset = "0x10")]
			public string challengeId;

			// Token: 0x04006800 RID: 26624
			[Token(Token = "0x4006800")]
			[FieldOffset(Offset = "0x18")]
			public int slotIndex;

			// Token: 0x04006801 RID: 26625
			[Token(Token = "0x4006801")]
			[FieldOffset(Offset = "0x1C")]
			public int shopCoin;

			// Token: 0x04006802 RID: 26626
			[Token(Token = "0x4006802")]
			[FieldOffset(Offset = "0x20")]
			public int runeCoin;

			// Token: 0x04006803 RID: 26627
			[Token(Token = "0x4006803")]
			[FieldOffset(Offset = "0x28")]
			public ItemBundle itemReward;

			// Token: 0x04006804 RID: 26628
			[Token(Token = "0x4006804")]
			[FieldOffset(Offset = "0x30")]
			public string descrption;

			// Token: 0x04006805 RID: 26629
			[Token(Token = "0x4006805")]
			[FieldOffset(Offset = "0x38")]
			public long unlockTime;
		}

		// Token: 0x0200126F RID: 4719
		[Token(Token = "0x200126F")]
		public class RuneInfo
		{
			// Token: 0x060071F1 RID: 29169 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071F1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RuneInfo()
			{
			}

			// Token: 0x04006806 RID: 26630
			[Token(Token = "0x4006806")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x04006807 RID: 26631
			[Token(Token = "0x4006807")]
			[FieldOffset(Offset = "0x18")]
			public string runeId;

			// Token: 0x04006808 RID: 26632
			[Token(Token = "0x4006808")]
			[FieldOffset(Offset = "0x20")]
			public string iconId;

			// Token: 0x04006809 RID: 26633
			[Token(Token = "0x4006809")]
			[FieldOffset(Offset = "0x28")]
			public string bgPicId;

			// Token: 0x0400680A RID: 26634
			[Token(Token = "0x400680A")]
			[FieldOffset(Offset = "0x30")]
			public int slotId;

			// Token: 0x0400680B RID: 26635
			[Token(Token = "0x400680B")]
			[FieldOffset(Offset = "0x38")]
			public string groupId;

			// Token: 0x0400680C RID: 26636
			[Token(Token = "0x400680C")]
			[FieldOffset(Offset = "0x40")]
			public int unlockCount;

			// Token: 0x0400680D RID: 26637
			[Token(Token = "0x400680D")]
			[FieldOffset(Offset = "0x48")]
			public string runeName;

			// Token: 0x0400680E RID: 26638
			[Token(Token = "0x400680E")]
			[FieldOffset(Offset = "0x50")]
			public string desc;
		}

		// Token: 0x02001270 RID: 4720
		[Token(Token = "0x2001270")]
		public class SeasonShopInfo
		{
			// Token: 0x060071F2 RID: 29170 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071F2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SeasonShopInfo()
			{
			}

			// Token: 0x0400680F RID: 26639
			[Token(Token = "0x400680F")]
			[FieldOffset(Offset = "0x10")]
			public string goodId;

			// Token: 0x04006810 RID: 26640
			[Token(Token = "0x4006810")]
			[FieldOffset(Offset = "0x18")]
			public string displayName;

			// Token: 0x04006811 RID: 26641
			[Token(Token = "0x4006811")]
			[FieldOffset(Offset = "0x20")]
			public int slotId;

			// Token: 0x04006812 RID: 26642
			[Token(Token = "0x4006812")]
			[FieldOffset(Offset = "0x28")]
			public ItemBundle item;

			// Token: 0x04006813 RID: 26643
			[Token(Token = "0x4006813")]
			[FieldOffset(Offset = "0x30")]
			public string progressGoodId;

			// Token: 0x04006814 RID: 26644
			[Token(Token = "0x4006814")]
			[FieldOffset(Offset = "0x38")]
			public int price;

			// Token: 0x04006815 RID: 26645
			[Token(Token = "0x4006815")]
			[FieldOffset(Offset = "0x3C")]
			public int availCount;
		}

		// Token: 0x02001271 RID: 4721
		[Token(Token = "0x2001271")]
		public class PermStageGroup
		{
			// Token: 0x060071F3 RID: 29171 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071F3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PermStageGroup()
			{
			}

			// Token: 0x04006816 RID: 26646
			[Token(Token = "0x4006816")]
			[FieldOffset(Offset = "0x10")]
			public string runeGroupId;

			// Token: 0x04006817 RID: 26647
			[Token(Token = "0x4006817")]
			[FieldOffset(Offset = "0x18")]
			public string stageId;

			// Token: 0x04006818 RID: 26648
			[Token(Token = "0x4006818")]
			[FieldOffset(Offset = "0x20")]
			public List<CrisisData.RuneReleaseData> releaseInfo;

			// Token: 0x04006819 RID: 26649
			[Token(Token = "0x4006819")]
			[FieldOffset(Offset = "0x28")]
			public string[] runeList;

			// Token: 0x0400681A RID: 26650
			[Token(Token = "0x400681A")]
			[FieldOffset(Offset = "0x30")]
			public Dictionary<int, CrisisData.CrisisStagePointLevelChallengeInfo> stagePointLevelInfo;

			// Token: 0x0400681B RID: 26651
			[Token(Token = "0x400681B")]
			[FieldOffset(Offset = "0x38")]
			public List<CrisisData.CrisisPeRunePackChallengeInfo> stageChallengeInfo;
		}

		// Token: 0x02001272 RID: 4722
		[Token(Token = "0x2001272")]
		public class TempStageGroup
		{
			// Token: 0x060071F4 RID: 29172 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071F4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TempStageGroup()
			{
			}

			// Token: 0x0400681C RID: 26652
			[Token(Token = "0x400681C")]
			[FieldOffset(Offset = "0x10")]
			public string runeGroupId;

			// Token: 0x0400681D RID: 26653
			[Token(Token = "0x400681D")]
			[FieldOffset(Offset = "0x18")]
			public string stageName;

			// Token: 0x0400681E RID: 26654
			[Token(Token = "0x400681E")]
			[FieldOffset(Offset = "0x20")]
			public long startTs;

			// Token: 0x0400681F RID: 26655
			[Token(Token = "0x400681F")]
			[FieldOffset(Offset = "0x28")]
			public long endTs;

			// Token: 0x04006820 RID: 26656
			[Token(Token = "0x4006820")]
			[FieldOffset(Offset = "0x30")]
			public string[] runeList;

			// Token: 0x04006821 RID: 26657
			[Token(Token = "0x4006821")]
			[FieldOffset(Offset = "0x38")]
			public Dictionary<int, CrisisData.CrisisStagePointLevelChallengeInfo> stagePointLevelInfo;

			// Token: 0x04006822 RID: 26658
			[Token(Token = "0x4006822")]
			[FieldOffset(Offset = "0x40")]
			public List<CrisisData.CrisisTeRunePackChallengeInfo> stageChallengeInfo;
		}

		// Token: 0x02001273 RID: 4723
		[Token(Token = "0x2001273")]
		public class CrisisStageData
		{
			// Token: 0x060071F5 RID: 29173 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071F5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CrisisStageData()
			{
			}

			// Token: 0x04006823 RID: 26659
			[Token(Token = "0x4006823")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x04006824 RID: 26660
			[Token(Token = "0x4006824")]
			[FieldOffset(Offset = "0x18")]
			public string mapId;

			// Token: 0x04006825 RID: 26661
			[Token(Token = "0x4006825")]
			[FieldOffset(Offset = "0x20")]
			public string code;

			// Token: 0x04006826 RID: 26662
			[Token(Token = "0x4006826")]
			[FieldOffset(Offset = "0x28")]
			public string name;

			// Token: 0x04006827 RID: 26663
			[Token(Token = "0x4006827")]
			[FieldOffset(Offset = "0x30")]
			public string loadingPicId;

			// Token: 0x04006828 RID: 26664
			[Token(Token = "0x4006828")]
			[FieldOffset(Offset = "0x38")]
			public string description;

			// Token: 0x04006829 RID: 26665
			[Token(Token = "0x4006829")]
			[FieldOffset(Offset = "0x40")]
			public string picId;
		}

		// Token: 0x02001274 RID: 4724
		[Token(Token = "0x2001274")]
		public class ProgressGoodItem
		{
			// Token: 0x060071F6 RID: 29174 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071F6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ProgressGoodItem()
			{
			}

			// Token: 0x0400682A RID: 26666
			[Token(Token = "0x400682A")]
			[FieldOffset(Offset = "0x10")]
			public int order;

			// Token: 0x0400682B RID: 26667
			[Token(Token = "0x400682B")]
			[FieldOffset(Offset = "0x14")]
			public int price;

			// Token: 0x0400682C RID: 26668
			[Token(Token = "0x400682C")]
			[FieldOffset(Offset = "0x18")]
			public string displayName;

			// Token: 0x0400682D RID: 26669
			[Token(Token = "0x400682D")]
			[FieldOffset(Offset = "0x20")]
			public ItemBundle item;
		}

		// Token: 0x02001275 RID: 4725
		[Token(Token = "0x2001275")]
		public class LongTermShopInfo
		{
			// Token: 0x060071F7 RID: 29175 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071F7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LongTermShopInfo()
			{
			}

			// Token: 0x0400682E RID: 26670
			[Token(Token = "0x400682E")]
			[FieldOffset(Offset = "0x10")]
			public string goodId;

			// Token: 0x0400682F RID: 26671
			[Token(Token = "0x400682F")]
			[FieldOffset(Offset = "0x18")]
			public string displayName;

			// Token: 0x04006830 RID: 26672
			[Token(Token = "0x4006830")]
			[FieldOffset(Offset = "0x20")]
			public string seasonId;

			// Token: 0x04006831 RID: 26673
			[Token(Token = "0x4006831")]
			[FieldOffset(Offset = "0x28")]
			public int slotId1;

			// Token: 0x04006832 RID: 26674
			[Token(Token = "0x4006832")]
			[FieldOffset(Offset = "0x2C")]
			public int slotId2;

			// Token: 0x04006833 RID: 26675
			[Token(Token = "0x4006833")]
			[FieldOffset(Offset = "0x30")]
			public ItemBundle item;

			// Token: 0x04006834 RID: 26676
			[Token(Token = "0x4006834")]
			[FieldOffset(Offset = "0x38")]
			public string progressGoodId;

			// Token: 0x04006835 RID: 26677
			[Token(Token = "0x4006835")]
			[FieldOffset(Offset = "0x40")]
			public int price;

			// Token: 0x04006836 RID: 26678
			[Token(Token = "0x4006836")]
			[FieldOffset(Offset = "0x44")]
			public int availCount;
		}

		// Token: 0x02001276 RID: 4726
		[Token(Token = "0x2001276")]
		public class SeasonInfo
		{
			// Token: 0x060071F8 RID: 29176 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071F8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SeasonInfo()
			{
			}

			// Token: 0x04006837 RID: 26679
			[Token(Token = "0x4006837")]
			[FieldOffset(Offset = "0x10")]
			public string seasonId;

			// Token: 0x04006838 RID: 26680
			[Token(Token = "0x4006838")]
			[FieldOffset(Offset = "0x18")]
			public long startTs;

			// Token: 0x04006839 RID: 26681
			[Token(Token = "0x4006839")]
			[FieldOffset(Offset = "0x20")]
			public long endTs;

			// Token: 0x0400683A RID: 26682
			[Token(Token = "0x400683A")]
			[FieldOffset(Offset = "0x28")]
			public List<CrisisData.CrisisStageData> crisisStageData;

			// Token: 0x0400683B RID: 26683
			[Token(Token = "0x400683B")]
			[FieldOffset(Offset = "0x30")]
			public List<CrisisData.PermStageGroup> permStageGroup;

			// Token: 0x0400683C RID: 26684
			[Token(Token = "0x400683C")]
			[FieldOffset(Offset = "0x38")]
			public List<CrisisData.TempStageGroup> tempStageGroup;

			// Token: 0x0400683D RID: 26685
			[Token(Token = "0x400683D")]
			[FieldOffset(Offset = "0x40")]
			public Dictionary<string, List<CrisisData.RuneInfo>> runeInfoList;

			// Token: 0x0400683E RID: 26686
			[Token(Token = "0x400683E")]
			[FieldOffset(Offset = "0x48")]
			public List<CrisisData.SeasonShopInfo> shopInfoList;

			// Token: 0x0400683F RID: 26687
			[Token(Token = "0x400683F")]
			[FieldOffset(Offset = "0x50")]
			public List<CrisisData.ProgressGoodItem> progressGoodInfo;
		}

		// Token: 0x02001277 RID: 4727
		[Token(Token = "0x2001277")]
		public class RuneMapInfo
		{
			// Token: 0x060071F9 RID: 29177 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071F9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RuneMapInfo()
			{
			}
		}

		// Token: 0x02001278 RID: 4728
		[Token(Token = "0x2001278")]
		public class TrainingInfo
		{
			// Token: 0x060071FA RID: 29178 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071FA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TrainingInfo()
			{
			}
		}
	}
}
