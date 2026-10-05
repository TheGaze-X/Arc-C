using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051D8 RID: 20952
	[Token(Token = "0x20051D8")]
	public class RoguelikeRelicViewModel : IHotfixable, IRoguelikeSacrifice, IRoguelikeRelicViewModel
	{
		// Token: 0x1700483D RID: 18493
		// (get) Token: 0x0601EF11 RID: 126737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700483D")]
		public string instId
		{
			[Token(Token = "0x601EF11")]
			[Address(RVA = "0x18C1430", Offset = "0x18C0030", VA = "0x1818C1430", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700483E RID: 18494
		// (get) Token: 0x0601EF12 RID: 126738 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601EF13 RID: 126739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700483E")]
		public string itemId
		{
			[Token(Token = "0x601EF12")]
			[Address(RVA = "0x18C1490", Offset = "0x18C0090", VA = "0x1818C1490", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601EF13")]
			[Address(RVA = "0x18C16D0", Offset = "0x18C02D0", VA = "0x1818C16D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700483F RID: 18495
		// (get) Token: 0x0601EF14 RID: 126740 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601EF15 RID: 126741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700483F")]
		public string name
		{
			[Token(Token = "0x601EF14")]
			[Address(RVA = "0x18C1550", Offset = "0x18C0150", VA = "0x1818C1550", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601EF15")]
			[Address(RVA = "0x18C17C0", Offset = "0x18C03C0", VA = "0x1818C17C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004840 RID: 18496
		// (get) Token: 0x0601EF16 RID: 126742 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601EF17 RID: 126743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004840")]
		public string usage
		{
			[Token(Token = "0x601EF16")]
			[Address(RVA = "0x18C1670", Offset = "0x18C0270", VA = "0x1818C1670", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601EF17")]
			[Address(RVA = "0x18C1930", Offset = "0x18C0530", VA = "0x1818C1930")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004841 RID: 18497
		// (get) Token: 0x0601EF18 RID: 126744 RVA: 0x000B0358 File Offset: 0x000AE558
		// (set) Token: 0x0601EF19 RID: 126745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004841")]
		public long ts
		{
			[Token(Token = "0x601EF18")]
			[Address(RVA = "0x18C1610", Offset = "0x18C0210", VA = "0x1818C1610", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x601EF19")]
			[Address(RVA = "0x18C18C0", Offset = "0x18C04C0", VA = "0x1818C18C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004842 RID: 18498
		// (get) Token: 0x0601EF1A RID: 126746 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601EF1B RID: 126747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004842")]
		public string topicId
		{
			[Token(Token = "0x601EF1A")]
			[Address(RVA = "0x18C15B0", Offset = "0x18C01B0", VA = "0x1818C15B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601EF1B")]
			[Address(RVA = "0x18C1840", Offset = "0x18C0440", VA = "0x1818C1840")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004843 RID: 18499
		// (get) Token: 0x0601EF1C RID: 126748 RVA: 0x000B0370 File Offset: 0x000AE570
		// (set) Token: 0x0601EF1D RID: 126749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004843")]
		public RoguelikeGameItemType itemType
		{
			[Token(Token = "0x601EF1C")]
			[Address(RVA = "0x18C14F0", Offset = "0x18C00F0", VA = "0x1818C14F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return RoguelikeGameItemType.NONE;
			}
			[Token(Token = "0x601EF1D")]
			[Address(RVA = "0x18C1750", Offset = "0x18C0350", VA = "0x1818C1750")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601EF1E RID: 126750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EF1E")]
		[Address(RVA = "0x18C0F70", Offset = "0x18BFB70", VA = "0x1818C0F70")]
		public static RoguelikeRelicViewModel Create(string topicId, PlayerRoguelikeV2.CurrentData.Relic relic, RoguelikeGameItemType itemType)
		{
			return null;
		}

		// Token: 0x0601EF1F RID: 126751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EF1F")]
		[Address(RVA = "0x18C0A80", Offset = "0x18BF680", VA = "0x1818C0A80")]
		public static RoguelikeRelicViewModel Create(string topicId, string id, RoguelikeGameItemType itemType)
		{
			return null;
		}

		// Token: 0x0601EF20 RID: 126752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EF20")]
		[Address(RVA = "0x18C1150", Offset = "0x18BFD50", VA = "0x1818C1150", Slot = "11")]
		public string GetItemId()
		{
			return null;
		}

		// Token: 0x0601EF21 RID: 126753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EF21")]
		[Address(RVA = "0x18C10C0", Offset = "0x18BFCC0", VA = "0x1818C10C0", Slot = "12")]
		public string GetId()
		{
			return null;
		}

		// Token: 0x0601EF22 RID: 126754 RVA: 0x000B0388 File Offset: 0x000AE588
		[Token(Token = "0x601EF22")]
		[Address(RVA = "0x18C11E0", Offset = "0x18BFDE0", VA = "0x1818C11E0", Slot = "13")]
		public RoguelikeMenuRelicItemType GetRelicItemType()
		{
			return RoguelikeMenuRelicItemType.RELIC;
		}

		// Token: 0x0601EF23 RID: 126755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF23")]
		[Address(RVA = "0x18C1240", Offset = "0x18BFE40", VA = "0x1818C1240")]
		private static void _ProcessRoguelikeBand(RoguelikeRelicViewModel ret)
		{
		}

		// Token: 0x0601EF24 RID: 126756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF24")]
		[Address(RVA = "0x18C13D0", Offset = "0x18BFFD0", VA = "0x1818C13D0")]
		public RoguelikeRelicViewModel()
		{
		}

		// Token: 0x0402985C RID: 170076
		[Token(Token = "0x402985C")]
		[FieldOffset(Offset = "0x10")]
		public string indexId;

		// Token: 0x0402985D RID: 170077
		[Token(Token = "0x402985D")]
		[FieldOffset(Offset = "0x18")]
		public int viewIndex;

		// Token: 0x0402985E RID: 170078
		[Token(Token = "0x402985E")]
		[FieldOffset(Offset = "0x1C")]
		public bool isUsed;

		// Token: 0x0402985F RID: 170079
		[Token(Token = "0x402985F")]
		[FieldOffset(Offset = "0x1D")]
		public bool canSacrifice;

		// Token: 0x04029860 RID: 170080
		[Token(Token = "0x4029860")]
		[FieldOffset(Offset = "0x20")]
		public int layer;

		// Token: 0x04029861 RID: 170081
		[Token(Token = "0x4029861")]
		[FieldOffset(Offset = "0x24")]
		public bool isUpgradable;

		// Token: 0x04029862 RID: 170082
		[Token(Token = "0x4029862")]
		[FieldOffset(Offset = "0x28")]
		public int upgradeRank;

		// Token: 0x04029863 RID: 170083
		[Token(Token = "0x4029863")]
		[FieldOffset(Offset = "0x30")]
		public string originalItemId;

		// Token: 0x0402986A RID: 170090
		[Token(Token = "0x402986A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_instId;

		// Token: 0x0402986B RID: 170091
		[Token(Token = "0x402986B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_itemId;

		// Token: 0x0402986C RID: 170092
		[Token(Token = "0x402986C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_itemId;

		// Token: 0x0402986D RID: 170093
		[Token(Token = "0x402986D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x0402986E RID: 170094
		[Token(Token = "0x402986E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_name;

		// Token: 0x0402986F RID: 170095
		[Token(Token = "0x402986F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_usage;

		// Token: 0x04029870 RID: 170096
		[Token(Token = "0x4029870")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_usage;

		// Token: 0x04029871 RID: 170097
		[Token(Token = "0x4029871")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_ts;

		// Token: 0x04029872 RID: 170098
		[Token(Token = "0x4029872")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_ts;

		// Token: 0x04029873 RID: 170099
		[Token(Token = "0x4029873")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x04029874 RID: 170100
		[Token(Token = "0x4029874")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x04029875 RID: 170101
		[Token(Token = "0x4029875")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_itemType;

		// Token: 0x04029876 RID: 170102
		[Token(Token = "0x4029876")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_set_itemType;

		// Token: 0x04029877 RID: 170103
		[Token(Token = "0x4029877")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x04029878 RID: 170104
		[Token(Token = "0x4029878")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix1_Create;

		// Token: 0x04029879 RID: 170105
		[Token(Token = "0x4029879")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetItemId;

		// Token: 0x0402987A RID: 170106
		[Token(Token = "0x402987A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetId;

		// Token: 0x0402987B RID: 170107
		[Token(Token = "0x402987B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetRelicItemType;

		// Token: 0x0402987C RID: 170108
		[Token(Token = "0x402987C")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ProcessRoguelikeBand;

		// Token: 0x0402987D RID: 170109
		[Token(Token = "0x402987D")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
