using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000D4F RID: 3407
	[Token(Token = "0x2000D4F")]
	public class Act44SideData
	{
		// Token: 0x06006A23 RID: 27171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A23")]
		[Address(RVA = "0x1FF6660", Offset = "0x1FF5260", VA = "0x181FF6660")]
		public Act44SideData()
		{
		}

		// Token: 0x04004617 RID: 17943
		[Token(Token = "0x4004617")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, Act44SideData.Act44SideZoneAdditionData> zoneAdditionDataMap;

		// Token: 0x04004618 RID: 17944
		[Token(Token = "0x4004618")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, Act44SideData.Act44SideCustomerData> customerDataMap;

		// Token: 0x04004619 RID: 17945
		[Token(Token = "0x4004619")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, Act44SideData.Act44SideTagData> tagDataMap;

		// Token: 0x0400461A RID: 17946
		[Token(Token = "0x400461A")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, Act44SideData.Act44SideChoiceData> choiceDataMap;

		// Token: 0x0400461B RID: 17947
		[Token(Token = "0x400461B")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, string> customerDialogMap;

		// Token: 0x0400461C RID: 17948
		[Token(Token = "0x400461C")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, string> keeperDialogMap;

		// Token: 0x0400461D RID: 17949
		[Token(Token = "0x400461D")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, Act44SideData.Act44SideNewsData> newsDataMap;

		// Token: 0x0400461E RID: 17950
		[Token(Token = "0x400461E")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, Act44SideData.Act44SideInsightData> insightDescMap;

		// Token: 0x0400461F RID: 17951
		[Token(Token = "0x400461F")]
		[FieldOffset(Offset = "0x50")]
		public List<Act44SideData.Act44SideMileStoneData> mileStoneList;

		// Token: 0x04004620 RID: 17952
		[Token(Token = "0x4004620")]
		[FieldOffset(Offset = "0x58")]
		public Act44SideData.Act44SideConstData constData;

		// Token: 0x02000D50 RID: 3408
		[Token(Token = "0x2000D50")]
		public class Act44SideZoneAdditionData
		{
			// Token: 0x06006A24 RID: 27172 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A24")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act44SideZoneAdditionData()
			{
			}

			// Token: 0x04004621 RID: 17953
			[Token(Token = "0x4004621")]
			[FieldOffset(Offset = "0x10")]
			public string zoneId;

			// Token: 0x04004622 RID: 17954
			[Token(Token = "0x4004622")]
			[FieldOffset(Offset = "0x18")]
			public string unlockText;
		}

		// Token: 0x02000D51 RID: 3409
		[Token(Token = "0x2000D51")]
		public class Act44SideCustomerData
		{
			// Token: 0x06006A25 RID: 27173 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A25")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act44SideCustomerData()
			{
			}

			// Token: 0x04004623 RID: 17955
			[Token(Token = "0x4004623")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04004624 RID: 17956
			[Token(Token = "0x4004624")]
			[FieldOffset(Offset = "0x18")]
			public string name;

			// Token: 0x04004625 RID: 17957
			[Token(Token = "0x4004625")]
			[FieldOffset(Offset = "0x20")]
			public string imgId;

			// Token: 0x04004626 RID: 17958
			[Token(Token = "0x4004626")]
			[FieldOffset(Offset = "0x28")]
			public string iconId;

			// Token: 0x04004627 RID: 17959
			[Token(Token = "0x4004627")]
			[FieldOffset(Offset = "0x30")]
			public bool isSp;

			// Token: 0x04004628 RID: 17960
			[Token(Token = "0x4004628")]
			[FieldOffset(Offset = "0x38")]
			public string description;
		}

		// Token: 0x02000D52 RID: 3410
		[Token(Token = "0x2000D52")]
		public class Act44SideTagData
		{
			// Token: 0x06006A26 RID: 27174 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A26")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act44SideTagData()
			{
			}

			// Token: 0x04004629 RID: 17961
			[Token(Token = "0x4004629")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x0400462A RID: 17962
			[Token(Token = "0x400462A")]
			[FieldOffset(Offset = "0x18")]
			public string name;

			// Token: 0x0400462B RID: 17963
			[Token(Token = "0x400462B")]
			[FieldOffset(Offset = "0x20")]
			public bool isSp;

			// Token: 0x0400462C RID: 17964
			[Token(Token = "0x400462C")]
			[FieldOffset(Offset = "0x28")]
			public string description;
		}

		// Token: 0x02000D53 RID: 3411
		[Token(Token = "0x2000D53")]
		public class Act44SideChoiceData
		{
			// Token: 0x06006A27 RID: 27175 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A27")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act44SideChoiceData()
			{
			}

			// Token: 0x0400462D RID: 17965
			[Token(Token = "0x400462D")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x0400462E RID: 17966
			[Token(Token = "0x400462E")]
			[FieldOffset(Offset = "0x18")]
			public string imgId;

			// Token: 0x0400462F RID: 17967
			[Token(Token = "0x400462F")]
			[FieldOffset(Offset = "0x20")]
			public int attentionArrow;

			// Token: 0x04004630 RID: 17968
			[Token(Token = "0x4004630")]
			[FieldOffset(Offset = "0x24")]
			public int trustArrow;

			// Token: 0x04004631 RID: 17969
			[Token(Token = "0x4004631")]
			[FieldOffset(Offset = "0x28")]
			public int attentionValue;

			// Token: 0x04004632 RID: 17970
			[Token(Token = "0x4004632")]
			[FieldOffset(Offset = "0x2C")]
			public int trustValue;

			// Token: 0x04004633 RID: 17971
			[Token(Token = "0x4004633")]
			[FieldOffset(Offset = "0x30")]
			public int patienceValue;
		}

		// Token: 0x02000D54 RID: 3412
		[Token(Token = "0x2000D54")]
		public class Act44SideNewsData
		{
			// Token: 0x06006A28 RID: 27176 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A28")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act44SideNewsData()
			{
			}

			// Token: 0x04004634 RID: 17972
			[Token(Token = "0x4004634")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04004635 RID: 17973
			[Token(Token = "0x4004635")]
			[FieldOffset(Offset = "0x18")]
			public string title;

			// Token: 0x04004636 RID: 17974
			[Token(Token = "0x4004636")]
			[FieldOffset(Offset = "0x20")]
			public string desc1;

			// Token: 0x04004637 RID: 17975
			[Token(Token = "0x4004637")]
			[FieldOffset(Offset = "0x28")]
			public string desc2;

			// Token: 0x04004638 RID: 17976
			[Token(Token = "0x4004638")]
			[FieldOffset(Offset = "0x30")]
			public string imgId;
		}

		// Token: 0x02000D55 RID: 3413
		[Token(Token = "0x2000D55")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum InsightType
		{
			// Token: 0x0400463A RID: 17978
			[Token(Token = "0x400463A")]
			PATIENCE,
			// Token: 0x0400463B RID: 17979
			[Token(Token = "0x400463B")]
			ATTENTION,
			// Token: 0x0400463C RID: 17980
			[Token(Token = "0x400463C")]
			TRUST
		}

		// Token: 0x02000D56 RID: 3414
		[Token(Token = "0x2000D56")]
		public class Act44SideInsightData
		{
			// Token: 0x06006A29 RID: 27177 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A29")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act44SideInsightData()
			{
			}

			// Token: 0x0400463D RID: 17981
			[Token(Token = "0x400463D")]
			[FieldOffset(Offset = "0x10")]
			public Act44SideData.InsightType type;

			// Token: 0x0400463E RID: 17982
			[Token(Token = "0x400463E")]
			[FieldOffset(Offset = "0x18")]
			public string lowerDesc;

			// Token: 0x0400463F RID: 17983
			[Token(Token = "0x400463F")]
			[FieldOffset(Offset = "0x20")]
			public string recommendDesc;

			// Token: 0x04004640 RID: 17984
			[Token(Token = "0x4004640")]
			[FieldOffset(Offset = "0x28")]
			public string maxDesc;
		}

		// Token: 0x02000D57 RID: 3415
		[Token(Token = "0x2000D57")]
		public class Act44SideMileStoneData
		{
			// Token: 0x06006A2A RID: 27178 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A2A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act44SideMileStoneData()
			{
			}

			// Token: 0x04004641 RID: 17985
			[Token(Token = "0x4004641")]
			[FieldOffset(Offset = "0x10")]
			public string mileStoneId;

			// Token: 0x04004642 RID: 17986
			[Token(Token = "0x4004642")]
			[FieldOffset(Offset = "0x18")]
			public int mileStoneLvl;

			// Token: 0x04004643 RID: 17987
			[Token(Token = "0x4004643")]
			[FieldOffset(Offset = "0x1C")]
			public int needPointCnt;

			// Token: 0x04004644 RID: 17988
			[Token(Token = "0x4004644")]
			[FieldOffset(Offset = "0x20")]
			public ItemBundle rewardItem;
		}

		// Token: 0x02000D58 RID: 3416
		[Token(Token = "0x2000D58")]
		public class Act44SideMilestoneSpecialRewardInfo
		{
			// Token: 0x06006A2B RID: 27179 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A2B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act44SideMilestoneSpecialRewardInfo()
			{
			}

			// Token: 0x04004645 RID: 17989
			[Token(Token = "0x4004645")]
			[FieldOffset(Offset = "0x10")]
			public string itemName;

			// Token: 0x04004646 RID: 17990
			[Token(Token = "0x4004646")]
			[FieldOffset(Offset = "0x18")]
			public int point;
		}

		// Token: 0x02000D59 RID: 3417
		[Token(Token = "0x2000D59")]
		public class Act44SideConstData
		{
			// Token: 0x06006A2C RID: 27180 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A2C")]
			[Address(RVA = "0x1FF65D0", Offset = "0x1FF51D0", VA = "0x181FF65D0")]
			public Act44SideConstData()
			{
			}

			// Token: 0x04004647 RID: 17991
			[Token(Token = "0x4004647")]
			[FieldOffset(Offset = "0x10")]
			public string informantUnlockStageId;

			// Token: 0x04004648 RID: 17992
			[Token(Token = "0x4004648")]
			[FieldOffset(Offset = "0x18")]
			public string informantItemId;

			// Token: 0x04004649 RID: 17993
			[Token(Token = "0x4004649")]
			[FieldOffset(Offset = "0x20")]
			public ItemType informantItemType;

			// Token: 0x0400464A RID: 17994
			[Token(Token = "0x400464A")]
			[FieldOffset(Offset = "0x24")]
			public int informantItemCount;

			// Token: 0x0400464B RID: 17995
			[Token(Token = "0x400464B")]
			[FieldOffset(Offset = "0x28")]
			public string milestoneItemId;

			// Token: 0x0400464C RID: 17996
			[Token(Token = "0x400464C")]
			[FieldOffset(Offset = "0x30")]
			public int attentionMax;

			// Token: 0x0400464D RID: 17997
			[Token(Token = "0x400464D")]
			[FieldOffset(Offset = "0x34")]
			public int trustMax;

			// Token: 0x0400464E RID: 17998
			[Token(Token = "0x400464E")]
			[FieldOffset(Offset = "0x38")]
			public int attentionMin;

			// Token: 0x0400464F RID: 17999
			[Token(Token = "0x400464F")]
			[FieldOffset(Offset = "0x3C")]
			public int trustMin;

			// Token: 0x04004650 RID: 18000
			[Token(Token = "0x4004650")]
			[FieldOffset(Offset = "0x40")]
			public int patienceRCRoundNum;

			// Token: 0x04004651 RID: 18001
			[Token(Token = "0x4004651")]
			[FieldOffset(Offset = "0x44")]
			public int beginnerPatienceRCRoundNum;

			// Token: 0x04004652 RID: 18002
			[Token(Token = "0x4004652")]
			[FieldOffset(Offset = "0x48")]
			public List<string> specialCustomerListId;

			// Token: 0x04004653 RID: 18003
			[Token(Token = "0x4004653")]
			[FieldOffset(Offset = "0x50")]
			public List<Act44SideData.Act44SideMilestoneSpecialRewardInfo> milestoneRewardList;

			// Token: 0x04004654 RID: 18004
			[Token(Token = "0x4004654")]
			[FieldOffset(Offset = "0x58")]
			public int forCountBigSuccess;

			// Token: 0x04004655 RID: 18005
			[Token(Token = "0x4004655")]
			[FieldOffset(Offset = "0x60")]
			public string outerOpenUnlock;

			// Token: 0x04004656 RID: 18006
			[Token(Token = "0x4004656")]
			[FieldOffset(Offset = "0x68")]
			public string customerTagFormat;
		}
	}
}
