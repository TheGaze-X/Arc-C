using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000D5F RID: 3423
	[Token(Token = "0x2000D5F")]
	public class Act46SideData
	{
		// Token: 0x06006A32 RID: 27186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A32")]
		[Address(RVA = "0x1FF6BE0", Offset = "0x1FF57E0", VA = "0x181FF6BE0")]
		public Act46SideData()
		{
		}

		// Token: 0x04004675 RID: 18037
		[Token(Token = "0x4004675")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, Act46SideData.Act46SideZoneAdditionData> zoneAdditionDataMap;

		// Token: 0x04004676 RID: 18038
		[Token(Token = "0x4004676")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, Act46SideData.Act46SideMonopolyStageData> monopolyStageDataMap;

		// Token: 0x04004677 RID: 18039
		[Token(Token = "0x4004677")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, Act46SideData.Act46SideMonopolyBuffData> buffDataMap;

		// Token: 0x04004678 RID: 18040
		[Token(Token = "0x4004678")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, Dictionary<string, List<Act46SideData.Act46SideSettleDialogData>>> settleDialogDataMap;

		// Token: 0x04004679 RID: 18041
		[Token(Token = "0x4004679")]
		[FieldOffset(Offset = "0x30")]
		public Act46SideData.Act46SideConstData constData;

		// Token: 0x0400467A RID: 18042
		[Token(Token = "0x400467A")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, Act46SideData.Act46SideMonopolyResourceItemData> resourceItemDataMap;

		// Token: 0x02000D60 RID: 3424
		[Token(Token = "0x2000D60")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum Act46SideSettleType
		{
			// Token: 0x0400467C RID: 18044
			[Token(Token = "0x400467C")]
			FAIL,
			// Token: 0x0400467D RID: 18045
			[Token(Token = "0x400467D")]
			GOOD,
			// Token: 0x0400467E RID: 18046
			[Token(Token = "0x400467E")]
			EXCELLENT
		}

		// Token: 0x02000D61 RID: 3425
		[Token(Token = "0x2000D61")]
		public class Act46SideZoneAdditionData
		{
			// Token: 0x06006A33 RID: 27187 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A33")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act46SideZoneAdditionData()
			{
			}

			// Token: 0x0400467F RID: 18047
			[Token(Token = "0x400467F")]
			[FieldOffset(Offset = "0x10")]
			public string zoneId;

			// Token: 0x04004680 RID: 18048
			[Token(Token = "0x4004680")]
			[FieldOffset(Offset = "0x18")]
			public string unlockText;
		}

		// Token: 0x02000D62 RID: 3426
		[Token(Token = "0x2000D62")]
		public class Act46SideMonopolyStageData
		{
			// Token: 0x06006A34 RID: 27188 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A34")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act46SideMonopolyStageData()
			{
			}

			// Token: 0x04004681 RID: 18049
			[Token(Token = "0x4004681")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x04004682 RID: 18050
			[Token(Token = "0x4004682")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x04004683 RID: 18051
			[Token(Token = "0x4004683")]
			[FieldOffset(Offset = "0x20")]
			public long startTs;

			// Token: 0x04004684 RID: 18052
			[Token(Token = "0x4004684")]
			[FieldOffset(Offset = "0x28")]
			public string stageName;

			// Token: 0x04004685 RID: 18053
			[Token(Token = "0x4004685")]
			[FieldOffset(Offset = "0x30")]
			public string stageDesc;

			// Token: 0x04004686 RID: 18054
			[Token(Token = "0x4004686")]
			[FieldOffset(Offset = "0x38")]
			public int taskRequiredAmount;

			// Token: 0x04004687 RID: 18055
			[Token(Token = "0x4004687")]
			[FieldOffset(Offset = "0x40")]
			public List<ItemBundle> rewardList;

			// Token: 0x04004688 RID: 18056
			[Token(Token = "0x4004688")]
			[FieldOffset(Offset = "0x48")]
			public List<string> buffIdList;

			// Token: 0x04004689 RID: 18057
			[Token(Token = "0x4004689")]
			[FieldOffset(Offset = "0x50")]
			public string bgSpriteId;

			// Token: 0x0400468A RID: 18058
			[Token(Token = "0x400468A")]
			[FieldOffset(Offset = "0x58")]
			public int maxTurn;

			// Token: 0x0400468B RID: 18059
			[Token(Token = "0x400468B")]
			[FieldOffset(Offset = "0x60")]
			public List<int> nodeIconStyleIndexList;

			// Token: 0x0400468C RID: 18060
			[Token(Token = "0x400468C")]
			[FieldOffset(Offset = "0x68")]
			public List<string> validResourceIdList;
		}

		// Token: 0x02000D63 RID: 3427
		[Token(Token = "0x2000D63")]
		public class Act46SideConstData
		{
			// Token: 0x06006A35 RID: 27189 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A35")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act46SideConstData()
			{
			}

			// Token: 0x0400468D RID: 18061
			[Token(Token = "0x400468D")]
			[FieldOffset(Offset = "0x10")]
			public string trainingStageId;

			// Token: 0x0400468E RID: 18062
			[Token(Token = "0x400468E")]
			[FieldOffset(Offset = "0x18")]
			public List<int> excellentRate;

			// Token: 0x0400468F RID: 18063
			[Token(Token = "0x400468F")]
			[FieldOffset(Offset = "0x20")]
			public string entryRequirement;

			// Token: 0x04004690 RID: 18064
			[Token(Token = "0x4004690")]
			[FieldOffset(Offset = "0x28")]
			public string businessUnlockText;

			// Token: 0x04004691 RID: 18065
			[Token(Token = "0x4004691")]
			[FieldOffset(Offset = "0x30")]
			public string mapNodeStartIcon;

			// Token: 0x04004692 RID: 18066
			[Token(Token = "0x4004692")]
			[FieldOffset(Offset = "0x38")]
			public int comboTaskProgressCount;
		}

		// Token: 0x02000D64 RID: 3428
		[Token(Token = "0x2000D64")]
		public class Act46SideMonopolyBuffData
		{
			// Token: 0x06006A36 RID: 27190 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A36")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act46SideMonopolyBuffData()
			{
			}

			// Token: 0x04004693 RID: 18067
			[Token(Token = "0x4004693")]
			[FieldOffset(Offset = "0x10")]
			public string buffId;

			// Token: 0x04004694 RID: 18068
			[Token(Token = "0x4004694")]
			[FieldOffset(Offset = "0x18")]
			public string buffIconId;

			// Token: 0x04004695 RID: 18069
			[Token(Token = "0x4004695")]
			[FieldOffset(Offset = "0x20")]
			public string buffName;

			// Token: 0x04004696 RID: 18070
			[Token(Token = "0x4004696")]
			[FieldOffset(Offset = "0x28")]
			public string buffDesc;
		}

		// Token: 0x02000D65 RID: 3429
		[Token(Token = "0x2000D65")]
		public class Act46SideSettleDialogData
		{
			// Token: 0x06006A37 RID: 27191 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A37")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act46SideSettleDialogData()
			{
			}

			// Token: 0x04004697 RID: 18071
			[Token(Token = "0x4004697")]
			[FieldOffset(Offset = "0x10")]
			public string characterAvatarId;

			// Token: 0x04004698 RID: 18072
			[Token(Token = "0x4004698")]
			[FieldOffset(Offset = "0x18")]
			public string dialogText;
		}

		// Token: 0x02000D66 RID: 3430
		[Token(Token = "0x2000D66")]
		public class Act46SideMonopolyResourceItemData
		{
			// Token: 0x06006A38 RID: 27192 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A38")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act46SideMonopolyResourceItemData()
			{
			}

			// Token: 0x04004699 RID: 18073
			[Token(Token = "0x4004699")]
			[FieldOffset(Offset = "0x10")]
			public string resourceId;

			// Token: 0x0400469A RID: 18074
			[Token(Token = "0x400469A")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;
		}
	}
}
