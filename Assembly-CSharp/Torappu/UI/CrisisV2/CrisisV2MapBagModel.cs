using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005970 RID: 22896
	[Token(Token = "0x2005970")]
	public class CrisisV2MapBagModel : IHotfixable
	{
		// Token: 0x17004E86 RID: 20102
		// (get) Token: 0x0602163D RID: 136765 RVA: 0x000BA060 File Offset: 0x000B8260
		[Token(Token = "0x17004E86")]
		public PlayerCrisisV2Season.BagState bagState
		{
			[Token(Token = "0x602163D")]
			[Address(RVA = "0x1BC4190", Offset = "0x1BC2D90", VA = "0x181BC4190")]
			get
			{
				return PlayerCrisisV2Season.BagState.INCOMPLETE;
			}
		}

		// Token: 0x17004E87 RID: 20103
		// (get) Token: 0x0602163E RID: 136766 RVA: 0x000BA078 File Offset: 0x000B8278
		[Token(Token = "0x17004E87")]
		public bool hasReward
		{
			[Token(Token = "0x602163E")]
			[Address(RVA = "0x1BC42D0", Offset = "0x1BC2ED0", VA = "0x181BC42D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004E88 RID: 20104
		// (get) Token: 0x0602163F RID: 136767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E88")]
		public string bagId
		{
			[Token(Token = "0x602163F")]
			[Address(RVA = "0x1BC4130", Offset = "0x1BC2D30", VA = "0x181BC4130")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E89 RID: 20105
		// (get) Token: 0x06021640 RID: 136768 RVA: 0x000BA090 File Offset: 0x000B8290
		[Token(Token = "0x17004E89")]
		public int sortId
		{
			[Token(Token = "0x6021640")]
			[Address(RVA = "0x1BC4690", Offset = "0x1BC3290", VA = "0x181BC4690")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004E8A RID: 20106
		// (get) Token: 0x06021641 RID: 136769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E8A")]
		public string shortName
		{
			[Token(Token = "0x6021641")]
			[Address(RVA = "0x1BC4620", Offset = "0x1BC3220", VA = "0x181BC4620")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E8B RID: 20107
		// (get) Token: 0x06021642 RID: 136770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E8B")]
		public string fullName
		{
			[Token(Token = "0x6021642")]
			[Address(RVA = "0x1BC4260", Offset = "0x1BC2E60", VA = "0x181BC4260")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E8C RID: 20108
		// (get) Token: 0x06021643 RID: 136771 RVA: 0x000BA0A8 File Offset: 0x000B82A8
		[Token(Token = "0x17004E8C")]
		public int rewardScore
		{
			[Token(Token = "0x6021643")]
			[Address(RVA = "0x1BC45B0", Offset = "0x1BC31B0", VA = "0x181BC45B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004E8D RID: 20109
		// (get) Token: 0x06021644 RID: 136772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E8D")]
		public List<string> nodeList
		{
			[Token(Token = "0x6021644")]
			[Address(RVA = "0x1BC4430", Offset = "0x1BC3030", VA = "0x181BC4430")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E8E RID: 20110
		// (get) Token: 0x06021645 RID: 136773 RVA: 0x000BA0C0 File Offset: 0x000B82C0
		[Token(Token = "0x17004E8E")]
		public int dimension
		{
			[Token(Token = "0x6021645")]
			[Address(RVA = "0x1BC41F0", Offset = "0x1BC2DF0", VA = "0x181BC41F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004E8F RID: 20111
		// (get) Token: 0x06021646 RID: 136774 RVA: 0x000BA0D8 File Offset: 0x000B82D8
		[Token(Token = "0x17004E8F")]
		public bool isDaily
		{
			[Token(Token = "0x6021646")]
			[Address(RVA = "0x1BC43C0", Offset = "0x1BC2FC0", VA = "0x181BC43C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004E90 RID: 20112
		// (get) Token: 0x06021647 RID: 136775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E90")]
		public string previewTitle
		{
			[Token(Token = "0x6021647")]
			[Address(RVA = "0x1BC4520", Offset = "0x1BC3120", VA = "0x181BC4520")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E91 RID: 20113
		// (get) Token: 0x06021648 RID: 136776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E91")]
		public string previewDesc
		{
			[Token(Token = "0x6021648")]
			[Address(RVA = "0x1BC4490", Offset = "0x1BC3090", VA = "0x181BC4490")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E92 RID: 20114
		// (get) Token: 0x06021649 RID: 136777 RVA: 0x000BA0F0 File Offset: 0x000B82F0
		[Token(Token = "0x17004E92")]
		public bool isComplete
		{
			[Token(Token = "0x6021649")]
			[Address(RVA = "0x1BC4360", Offset = "0x1BC2F60", VA = "0x181BC4360")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602164A RID: 136778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602164A")]
		[Address(RVA = "0x1BC3BA0", Offset = "0x1BC27A0", VA = "0x181BC3BA0")]
		public List<CrisisV2TimeLimitItemModel> GenRewardList()
		{
			return null;
		}

		// Token: 0x0602164B RID: 136779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602164B")]
		[Address(RVA = "0x1BC3D40", Offset = "0x1BC2940", VA = "0x181BC3D40")]
		public void Load(string bagId, CrisisV2BagData bagData, CrisisV2MapDetailData mapDetailData)
		{
		}

		// Token: 0x0602164C RID: 136780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602164C")]
		[Address(RVA = "0x1BC3F40", Offset = "0x1BC2B40", VA = "0x181BC3F40")]
		public void UpdatePlayerData(PlayerCrisisV2Season.BasicMapInfo playerMapInfo)
		{
		}

		// Token: 0x0602164D RID: 136781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602164D")]
		[Address(RVA = "0x1BC4070", Offset = "0x1BC2C70", VA = "0x181BC4070")]
		public CrisisV2MapBagModel()
		{
		}

		// Token: 0x0402D89A RID: 186522
		[Token(Token = "0x402D89A")]
		[FieldOffset(Offset = "0x10")]
		private string m_bagId;

		// Token: 0x0402D89B RID: 186523
		[Token(Token = "0x402D89B")]
		[FieldOffset(Offset = "0x18")]
		private CrisisV2BagData m_bagData;

		// Token: 0x0402D89C RID: 186524
		[Token(Token = "0x402D89C")]
		[FieldOffset(Offset = "0x20")]
		private List<string> m_nodeList;

		// Token: 0x0402D89D RID: 186525
		[Token(Token = "0x402D89D")]
		[FieldOffset(Offset = "0x28")]
		private PlayerCrisisV2Season.BagState m_bagState;

		// Token: 0x0402D89E RID: 186526
		[Token(Token = "0x402D89E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bagState;

		// Token: 0x0402D89F RID: 186527
		[Token(Token = "0x402D89F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_hasReward;

		// Token: 0x0402D8A0 RID: 186528
		[Token(Token = "0x402D8A0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_bagId;

		// Token: 0x0402D8A1 RID: 186529
		[Token(Token = "0x402D8A1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x0402D8A2 RID: 186530
		[Token(Token = "0x402D8A2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_shortName;

		// Token: 0x0402D8A3 RID: 186531
		[Token(Token = "0x402D8A3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_fullName;

		// Token: 0x0402D8A4 RID: 186532
		[Token(Token = "0x402D8A4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_rewardScore;

		// Token: 0x0402D8A5 RID: 186533
		[Token(Token = "0x402D8A5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_nodeList;

		// Token: 0x0402D8A6 RID: 186534
		[Token(Token = "0x402D8A6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_dimension;

		// Token: 0x0402D8A7 RID: 186535
		[Token(Token = "0x402D8A7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_isDaily;

		// Token: 0x0402D8A8 RID: 186536
		[Token(Token = "0x402D8A8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_previewTitle;

		// Token: 0x0402D8A9 RID: 186537
		[Token(Token = "0x402D8A9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_previewDesc;

		// Token: 0x0402D8AA RID: 186538
		[Token(Token = "0x402D8AA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_isComplete;

		// Token: 0x0402D8AB RID: 186539
		[Token(Token = "0x402D8AB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GenRewardList;

		// Token: 0x0402D8AC RID: 186540
		[Token(Token = "0x402D8AC")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x0402D8AD RID: 186541
		[Token(Token = "0x402D8AD")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_UpdatePlayerData;

		// Token: 0x0402D8AE RID: 186542
		[Token(Token = "0x402D8AE")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
