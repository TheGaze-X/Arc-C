using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005957 RID: 22871
	[Token(Token = "0x2005957")]
	public abstract class CrisisV2MapNodeModel : IHotfixable
	{
		// Token: 0x17004E1B RID: 19995
		// (get) Token: 0x0602153B RID: 136507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E1B")]
		public string nodeId
		{
			[Token(Token = "0x602153B")]
			[Address(RVA = "0x1BB0230", Offset = "0x1BAEE30", VA = "0x181BB0230")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E1C RID: 19996
		// (get) Token: 0x0602153C RID: 136508 RVA: 0x000B9538 File Offset: 0x000B7738
		[Token(Token = "0x17004E1C")]
		public CrisisV2NodeSlotType slotType
		{
			[Token(Token = "0x602153C")]
			[Address(RVA = "0x1BB0370", Offset = "0x1BAEF70", VA = "0x181BB0370")]
			get
			{
				return CrisisV2NodeSlotType.NONE;
			}
		}

		// Token: 0x17004E1D RID: 19997
		// (get) Token: 0x0602153D RID: 136509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E1D")]
		public string exclusionGroupId
		{
			[Token(Token = "0x602153D")]
			[Address(RVA = "0x1BB01C0", Offset = "0x1BAEDC0", VA = "0x181BB01C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E1E RID: 19998
		// (get) Token: 0x0602153E RID: 136510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E1E")]
		public List<string> adjacentNodeList
		{
			[Token(Token = "0x602153E")]
			[Address(RVA = "0x1BB00F0", Offset = "0x1BAECF0", VA = "0x181BB00F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E1F RID: 19999
		// (get) Token: 0x0602153F RID: 136511 RVA: 0x000B9550 File Offset: 0x000B7750
		[Token(Token = "0x17004E1F")]
		public virtual bool canCoverRoad
		{
			[Token(Token = "0x602153F")]
			[Address(RVA = "0x1BA4F80", Offset = "0x1BA3B80", VA = "0x181BA4F80", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004E20 RID: 20000
		// (get) Token: 0x06021540 RID: 136512 RVA: 0x000B9568 File Offset: 0x000B7768
		[Token(Token = "0x17004E20")]
		public virtual CrisisV2MapNodeModel.Connectivity connectivity
		{
			[Token(Token = "0x6021540")]
			[Address(RVA = "0x1BB0160", Offset = "0x1BAED60", VA = "0x181BB0160", Slot = "5")]
			get
			{
				return CrisisV2MapNodeModel.Connectivity.CLOSE;
			}
		}

		// Token: 0x17004E21 RID: 20001
		// (get) Token: 0x06021541 RID: 136513 RVA: 0x000B9580 File Offset: 0x000B7780
		[Token(Token = "0x17004E21")]
		public virtual bool isSpecialNode
		{
			[Token(Token = "0x6021541")]
			[Address(RVA = "0x1BA5160", Offset = "0x1BA3D60", VA = "0x181BA5160", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004E22 RID: 20002
		// (get) Token: 0x06021542 RID: 136514 RVA: 0x000B9598 File Offset: 0x000B7798
		[Token(Token = "0x17004E22")]
		public virtual PlayerCrisisV2Season.NodeState currentState
		{
			[Token(Token = "0x6021542")]
			[Address(RVA = "0x1BA5040", Offset = "0x1BA3C40", VA = "0x181BA5040", Slot = "7")]
			get
			{
				return PlayerCrisisV2Season.NodeState.INACTIVE;
			}
		}

		// Token: 0x17004E23 RID: 20003
		// (get) Token: 0x06021543 RID: 136515 RVA: 0x000B95B0 File Offset: 0x000B77B0
		[Token(Token = "0x17004E23")]
		public virtual bool isAutoSelect
		{
			[Token(Token = "0x6021543")]
			[Address(RVA = "0x1BA5100", Offset = "0x1BA3D00", VA = "0x181BA5100", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004E24 RID: 20004
		// (get) Token: 0x06021544 RID: 136516 RVA: 0x000B95C8 File Offset: 0x000B77C8
		[Token(Token = "0x17004E24")]
		public virtual bool canStartFrom
		{
			[Token(Token = "0x6021544")]
			[Address(RVA = "0x1BA4FE0", Offset = "0x1BA3BE0", VA = "0x181BA4FE0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004E25 RID: 20005
		// (get) Token: 0x06021545 RID: 136517 RVA: 0x000B95E0 File Offset: 0x000B77E0
		[Token(Token = "0x17004E25")]
		public virtual CrisisV2RoadPointStyle roadPointStyle
		{
			[Token(Token = "0x6021545")]
			[Address(RVA = "0x1BA5420", Offset = "0x1BA4020", VA = "0x181BA5420", Slot = "10")]
			get
			{
				return CrisisV2RoadPointStyle.NONE;
			}
		}

		// Token: 0x17004E26 RID: 20006
		// (get) Token: 0x06021546 RID: 136518 RVA: 0x000B95F8 File Offset: 0x000B77F8
		[Token(Token = "0x17004E26")]
		public virtual bool needShowPreview
		{
			[Token(Token = "0x6021546")]
			[Address(RVA = "0x1BA51C0", Offset = "0x1BA3DC0", VA = "0x181BA51C0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004E27 RID: 20007
		// (get) Token: 0x06021547 RID: 136519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E27")]
		public virtual string previewTitle
		{
			[Token(Token = "0x6021547")]
			[Address(RVA = "0x1BB0300", Offset = "0x1BAEF00", VA = "0x181BB0300", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E28 RID: 20008
		// (get) Token: 0x06021548 RID: 136520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E28")]
		public virtual string previewDesc
		{
			[Token(Token = "0x6021548")]
			[Address(RVA = "0x1BB0290", Offset = "0x1BAEE90", VA = "0x181BB0290", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E29 RID: 20009
		// (get) Token: 0x06021549 RID: 136521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E29")]
		public virtual List<CrisisV2TimeLimitItemModel> rewards
		{
			[Token(Token = "0x6021549")]
			[Address(RVA = "0x1BA53C0", Offset = "0x1BA3FC0", VA = "0x181BA53C0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E2A RID: 20010
		// (get) Token: 0x0602154A RID: 136522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E2A")]
		public virtual List<string> relatedNodeOrBagIds
		{
			[Token(Token = "0x602154A")]
			[Address(RVA = "0x1BA5300", Offset = "0x1BA3F00", VA = "0x181BA5300", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E2B RID: 20011
		// (get) Token: 0x0602154B RID: 136523 RVA: 0x000B9610 File Offset: 0x000B7810
		[Token(Token = "0x17004E2B")]
		public virtual CrisisV2MapModel.ViewType highlightView
		{
			[Token(Token = "0x602154B")]
			[Address(RVA = "0x1BA50A0", Offset = "0x1BA3CA0", VA = "0x181BA50A0", Slot = "16")]
			get
			{
				return CrisisV2MapModel.ViewType.NONE;
			}
		}

		// Token: 0x17004E2C RID: 20012
		// (get) Token: 0x0602154C RID: 136524 RVA: 0x000B9628 File Offset: 0x000B7828
		[Token(Token = "0x17004E2C")]
		public virtual int requiredSelectCount
		{
			[Token(Token = "0x602154C")]
			[Address(RVA = "0x1BA5360", Offset = "0x1BA3F60", VA = "0x181BA5360", Slot = "17")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602154D RID: 136525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602154D")]
		[Address(RVA = "0x1BAFC30", Offset = "0x1BAE830", VA = "0x181BAFC30")]
		public static CrisisV2MapNodeModel Create(CrisisV2NodeSlotType slotType)
		{
			return null;
		}

		// Token: 0x0602154E RID: 136526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602154E")]
		[Address(RVA = "0x1BAFFA0", Offset = "0x1BAEBA0", VA = "0x181BAFFA0")]
		public void Load(string nodeId, CrisisV2NodeData nodeData, CrisisV2MapDetailData mapDetailData, long rewardEndTime)
		{
		}

		// Token: 0x0602154F RID: 136527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602154F")]
		[Address(RVA = "0x1BA4F20", Offset = "0x1BA3B20", VA = "0x181BA4F20", Slot = "18")]
		public virtual void UpdatePlayerData(PlayerCrisisV2Season.BasicMapInfo playerMapInfo)
		{
		}

		// Token: 0x06021550 RID: 136528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021550")]
		[Address(RVA = "0x1BA4EC0", Offset = "0x1BA3AC0", VA = "0x181BA4EC0", Slot = "19")]
		protected virtual void OnLoadData()
		{
		}

		// Token: 0x06021551 RID: 136529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021551")]
		[Address(RVA = "0x1BB0090", Offset = "0x1BAEC90", VA = "0x181BB0090")]
		protected CrisisV2MapNodeModel()
		{
		}

		// Token: 0x0402D73D RID: 186173
		[Token(Token = "0x402D73D")]
		[FieldOffset(Offset = "0x10")]
		protected string m_nodeId;

		// Token: 0x0402D73E RID: 186174
		[Token(Token = "0x402D73E")]
		[FieldOffset(Offset = "0x18")]
		protected CrisisV2NodeData m_nodeData;

		// Token: 0x0402D73F RID: 186175
		[Token(Token = "0x402D73F")]
		[FieldOffset(Offset = "0x20")]
		protected CrisisV2MapDetailData m_mapDetailData;

		// Token: 0x0402D740 RID: 186176
		[Token(Token = "0x402D740")]
		[FieldOffset(Offset = "0x28")]
		protected long m_rewardEndTime;

		// Token: 0x0402D741 RID: 186177
		[Token(Token = "0x402D741")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_nodeId;

		// Token: 0x0402D742 RID: 186178
		[Token(Token = "0x402D742")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_slotType;

		// Token: 0x0402D743 RID: 186179
		[Token(Token = "0x402D743")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_exclusionGroupId;

		// Token: 0x0402D744 RID: 186180
		[Token(Token = "0x402D744")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_adjacentNodeList;

		// Token: 0x0402D745 RID: 186181
		[Token(Token = "0x402D745")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_canCoverRoad;

		// Token: 0x0402D746 RID: 186182
		[Token(Token = "0x402D746")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_connectivity;

		// Token: 0x0402D747 RID: 186183
		[Token(Token = "0x402D747")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isSpecialNode;

		// Token: 0x0402D748 RID: 186184
		[Token(Token = "0x402D748")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_currentState;

		// Token: 0x0402D749 RID: 186185
		[Token(Token = "0x402D749")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isAutoSelect;

		// Token: 0x0402D74A RID: 186186
		[Token(Token = "0x402D74A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_canStartFrom;

		// Token: 0x0402D74B RID: 186187
		[Token(Token = "0x402D74B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_roadPointStyle;

		// Token: 0x0402D74C RID: 186188
		[Token(Token = "0x402D74C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_needShowPreview;

		// Token: 0x0402D74D RID: 186189
		[Token(Token = "0x402D74D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_previewTitle;

		// Token: 0x0402D74E RID: 186190
		[Token(Token = "0x402D74E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_previewDesc;

		// Token: 0x0402D74F RID: 186191
		[Token(Token = "0x402D74F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_rewards;

		// Token: 0x0402D750 RID: 186192
		[Token(Token = "0x402D750")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_relatedNodeOrBagIds;

		// Token: 0x0402D751 RID: 186193
		[Token(Token = "0x402D751")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_highlightView;

		// Token: 0x0402D752 RID: 186194
		[Token(Token = "0x402D752")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_requiredSelectCount;

		// Token: 0x0402D753 RID: 186195
		[Token(Token = "0x402D753")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x0402D754 RID: 186196
		[Token(Token = "0x402D754")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x0402D755 RID: 186197
		[Token(Token = "0x402D755")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_UpdatePlayerData;

		// Token: 0x0402D756 RID: 186198
		[Token(Token = "0x402D756")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnLoadData;

		// Token: 0x0402D757 RID: 186199
		[Token(Token = "0x402D757")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005958 RID: 22872
		[Token(Token = "0x2005958")]
		public enum Connectivity
		{
			// Token: 0x0402D759 RID: 186201
			[Token(Token = "0x402D759")]
			CLOSE,
			// Token: 0x0402D75A RID: 186202
			[Token(Token = "0x402D75A")]
			BLOCK,
			// Token: 0x0402D75B RID: 186203
			[Token(Token = "0x402D75B")]
			CONNECT
		}
	}
}
