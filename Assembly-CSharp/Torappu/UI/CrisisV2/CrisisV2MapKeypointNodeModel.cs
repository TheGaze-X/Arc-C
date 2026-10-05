using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200595A RID: 22874
	[Token(Token = "0x200595A")]
	public class CrisisV2MapKeypointNodeModel : CrisisV2MapNodeModel
	{
		// Token: 0x17004E39 RID: 20025
		// (get) Token: 0x0602156C RID: 136556 RVA: 0x000B9760 File Offset: 0x000B7960
		[Token(Token = "0x17004E39")]
		public override bool isSpecialNode
		{
			[Token(Token = "0x602156C")]
			[Address(RVA = "0x1BA5810", Offset = "0x1BA4410", VA = "0x181BA5810", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004E3A RID: 20026
		// (get) Token: 0x0602156D RID: 136557 RVA: 0x000B9778 File Offset: 0x000B7978
		[Token(Token = "0x17004E3A")]
		public override bool canCoverRoad
		{
			[Token(Token = "0x602156D")]
			[Address(RVA = "0x1BA5630", Offset = "0x1BA4230", VA = "0x181BA5630", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004E3B RID: 20027
		// (get) Token: 0x0602156E RID: 136558 RVA: 0x000B9790 File Offset: 0x000B7990
		[Token(Token = "0x17004E3B")]
		public override bool isAutoSelect
		{
			[Token(Token = "0x602156E")]
			[Address(RVA = "0x1BA57B0", Offset = "0x1BA43B0", VA = "0x181BA57B0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004E3C RID: 20028
		// (get) Token: 0x0602156F RID: 136559 RVA: 0x000B97A8 File Offset: 0x000B79A8
		[Token(Token = "0x17004E3C")]
		public override bool canStartFrom
		{
			[Token(Token = "0x602156F")]
			[Address(RVA = "0x1BA5690", Offset = "0x1BA4290", VA = "0x181BA5690", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004E3D RID: 20029
		// (get) Token: 0x06021570 RID: 136560 RVA: 0x000B97C0 File Offset: 0x000B79C0
		[Token(Token = "0x17004E3D")]
		public override CrisisV2RoadPointStyle roadPointStyle
		{
			[Token(Token = "0x6021570")]
			[Address(RVA = "0x1BA5CE0", Offset = "0x1BA48E0", VA = "0x181BA5CE0", Slot = "10")]
			get
			{
				return CrisisV2RoadPointStyle.NONE;
			}
		}

		// Token: 0x17004E3E RID: 20030
		// (get) Token: 0x06021571 RID: 136561 RVA: 0x000B97D8 File Offset: 0x000B79D8
		[Token(Token = "0x17004E3E")]
		public override PlayerCrisisV2Season.NodeState currentState
		{
			[Token(Token = "0x6021571")]
			[Address(RVA = "0x1BA56F0", Offset = "0x1BA42F0", VA = "0x181BA56F0", Slot = "7")]
			get
			{
				return PlayerCrisisV2Season.NodeState.INACTIVE;
			}
		}

		// Token: 0x17004E3F RID: 20031
		// (get) Token: 0x06021572 RID: 136562 RVA: 0x000B97F0 File Offset: 0x000B79F0
		[Token(Token = "0x17004E3F")]
		public override bool needShowPreview
		{
			[Token(Token = "0x6021572")]
			[Address(RVA = "0x1BA5870", Offset = "0x1BA4470", VA = "0x181BA5870", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004E40 RID: 20032
		// (get) Token: 0x06021573 RID: 136563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E40")]
		public override string previewTitle
		{
			[Token(Token = "0x6021573")]
			[Address(RVA = "0x1BA5960", Offset = "0x1BA4560", VA = "0x181BA5960", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E41 RID: 20033
		// (get) Token: 0x06021574 RID: 136564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E41")]
		public override string previewDesc
		{
			[Token(Token = "0x6021574")]
			[Address(RVA = "0x1BA58D0", Offset = "0x1BA44D0", VA = "0x181BA58D0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E42 RID: 20034
		// (get) Token: 0x06021575 RID: 136565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E42")]
		public override List<CrisisV2TimeLimitItemModel> rewards
		{
			[Token(Token = "0x6021575")]
			[Address(RVA = "0x1BA5AD0", Offset = "0x1BA46D0", VA = "0x181BA5AD0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E43 RID: 20035
		// (get) Token: 0x06021576 RID: 136566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E43")]
		public override List<string> relatedNodeOrBagIds
		{
			[Token(Token = "0x6021576")]
			[Address(RVA = "0x1BA59F0", Offset = "0x1BA45F0", VA = "0x181BA59F0", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E44 RID: 20036
		// (get) Token: 0x06021577 RID: 136567 RVA: 0x000B9808 File Offset: 0x000B7A08
		[Token(Token = "0x17004E44")]
		public override CrisisV2MapModel.ViewType highlightView
		{
			[Token(Token = "0x6021577")]
			[Address(RVA = "0x1BA5750", Offset = "0x1BA4350", VA = "0x181BA5750", Slot = "16")]
			get
			{
				return CrisisV2MapModel.ViewType.NONE;
			}
		}

		// Token: 0x17004E45 RID: 20037
		// (get) Token: 0x06021578 RID: 136568 RVA: 0x000B9820 File Offset: 0x000B7A20
		[Token(Token = "0x17004E45")]
		public override int requiredSelectCount
		{
			[Token(Token = "0x6021578")]
			[Address(RVA = "0x1BA5A60", Offset = "0x1BA4660", VA = "0x181BA5A60", Slot = "17")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06021579 RID: 136569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021579")]
		[Address(RVA = "0x1BA5480", Offset = "0x1BA4080", VA = "0x181BA5480", Slot = "18")]
		public override void UpdatePlayerData(PlayerCrisisV2Season.BasicMapInfo playerMapInfo)
		{
		}

		// Token: 0x0602157A RID: 136570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602157A")]
		[Address(RVA = "0x1BA4E00", Offset = "0x1BA3A00", VA = "0x181BA4E00", Slot = "19")]
		protected override void OnLoadData()
		{
		}

		// Token: 0x0602157B RID: 136571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602157B")]
		[Address(RVA = "0x1BA5590", Offset = "0x1BA4190", VA = "0x181BA5590")]
		public CrisisV2MapKeypointNodeModel()
		{
		}

		// Token: 0x0602157C RID: 136572 RVA: 0x000B9838 File Offset: 0x000B7A38
		[Token(Token = "0x602157C")]
		[Address(RVA = "0x1BA5160", Offset = "0x1BA3D60", VA = "0x181BA5160")]
		private bool <>xLuaBaseProxy_get_isSpecialNode()
		{
			return default(bool);
		}

		// Token: 0x0602157D RID: 136573 RVA: 0x000B9850 File Offset: 0x000B7A50
		[Token(Token = "0x602157D")]
		[Address(RVA = "0x1BA4F80", Offset = "0x1BA3B80", VA = "0x181BA4F80")]
		private bool <>xLuaBaseProxy_get_canCoverRoad()
		{
			return default(bool);
		}

		// Token: 0x0602157E RID: 136574 RVA: 0x000B9868 File Offset: 0x000B7A68
		[Token(Token = "0x602157E")]
		[Address(RVA = "0x1BA5100", Offset = "0x1BA3D00", VA = "0x181BA5100")]
		private bool <>xLuaBaseProxy_get_isAutoSelect()
		{
			return default(bool);
		}

		// Token: 0x0602157F RID: 136575 RVA: 0x000B9880 File Offset: 0x000B7A80
		[Token(Token = "0x602157F")]
		[Address(RVA = "0x1BA4FE0", Offset = "0x1BA3BE0", VA = "0x181BA4FE0")]
		private bool <>xLuaBaseProxy_get_canStartFrom()
		{
			return default(bool);
		}

		// Token: 0x06021580 RID: 136576 RVA: 0x000B9898 File Offset: 0x000B7A98
		[Token(Token = "0x6021580")]
		[Address(RVA = "0x1BA5420", Offset = "0x1BA4020", VA = "0x181BA5420")]
		private CrisisV2RoadPointStyle <>xLuaBaseProxy_get_roadPointStyle()
		{
			return CrisisV2RoadPointStyle.NONE;
		}

		// Token: 0x06021581 RID: 136577 RVA: 0x000B98B0 File Offset: 0x000B7AB0
		[Token(Token = "0x6021581")]
		[Address(RVA = "0x1BA5040", Offset = "0x1BA3C40", VA = "0x181BA5040")]
		private PlayerCrisisV2Season.NodeState <>xLuaBaseProxy_get_currentState()
		{
			return PlayerCrisisV2Season.NodeState.INACTIVE;
		}

		// Token: 0x06021582 RID: 136578 RVA: 0x000B98C8 File Offset: 0x000B7AC8
		[Token(Token = "0x6021582")]
		[Address(RVA = "0x1BA51C0", Offset = "0x1BA3DC0", VA = "0x181BA51C0")]
		private bool <>xLuaBaseProxy_get_needShowPreview()
		{
			return default(bool);
		}

		// Token: 0x06021583 RID: 136579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021583")]
		[Address(RVA = "0x1BA5290", Offset = "0x1BA3E90", VA = "0x181BA5290")]
		private string <>xLuaBaseProxy_get_previewTitle()
		{
			return null;
		}

		// Token: 0x06021584 RID: 136580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021584")]
		[Address(RVA = "0x1BA5220", Offset = "0x1BA3E20", VA = "0x181BA5220")]
		private string <>xLuaBaseProxy_get_previewDesc()
		{
			return null;
		}

		// Token: 0x06021585 RID: 136581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021585")]
		[Address(RVA = "0x1BA53C0", Offset = "0x1BA3FC0", VA = "0x181BA53C0")]
		private List<CrisisV2TimeLimitItemModel> <>xLuaBaseProxy_get_rewards()
		{
			return null;
		}

		// Token: 0x06021586 RID: 136582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021586")]
		[Address(RVA = "0x1BA5300", Offset = "0x1BA3F00", VA = "0x181BA5300")]
		private List<string> <>xLuaBaseProxy_get_relatedNodeOrBagIds()
		{
			return null;
		}

		// Token: 0x06021587 RID: 136583 RVA: 0x000B98E0 File Offset: 0x000B7AE0
		[Token(Token = "0x6021587")]
		[Address(RVA = "0x1BA50A0", Offset = "0x1BA3CA0", VA = "0x181BA50A0")]
		private CrisisV2MapModel.ViewType <>xLuaBaseProxy_get_highlightView()
		{
			return CrisisV2MapModel.ViewType.NONE;
		}

		// Token: 0x06021588 RID: 136584 RVA: 0x000B98F8 File Offset: 0x000B7AF8
		[Token(Token = "0x6021588")]
		[Address(RVA = "0x1BA5360", Offset = "0x1BA3F60", VA = "0x181BA5360")]
		private int <>xLuaBaseProxy_get_requiredSelectCount()
		{
			return 0;
		}

		// Token: 0x06021589 RID: 136585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021589")]
		[Address(RVA = "0x1BA4F20", Offset = "0x1BA3B20", VA = "0x181BA4F20")]
		private void <>xLuaBaseProxy_UpdatePlayerData(PlayerCrisisV2Season.BasicMapInfo P0)
		{
		}

		// Token: 0x0602158A RID: 136586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602158A")]
		[Address(RVA = "0x1BA4EC0", Offset = "0x1BA3AC0", VA = "0x181BA4EC0")]
		private void <>xLuaBaseProxy_OnLoadData()
		{
		}

		// Token: 0x0402D76E RID: 186222
		[Token(Token = "0x402D76E")]
		[FieldOffset(Offset = "0x30")]
		private CrisisV2ChallengeNodeData m_keypointServerData;

		// Token: 0x0402D76F RID: 186223
		[Token(Token = "0x402D76F")]
		[FieldOffset(Offset = "0x38")]
		private PlayerCrisisV2Season.NodeState m_nodeState;

		// Token: 0x0402D770 RID: 186224
		[Token(Token = "0x402D770")]
		[FieldOffset(Offset = "0x40")]
		private List<CrisisV2TimeLimitItemModel> m_previewRewards;

		// Token: 0x0402D771 RID: 186225
		[Token(Token = "0x402D771")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isSpecialNode;

		// Token: 0x0402D772 RID: 186226
		[Token(Token = "0x402D772")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_canCoverRoad;

		// Token: 0x0402D773 RID: 186227
		[Token(Token = "0x402D773")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isAutoSelect;

		// Token: 0x0402D774 RID: 186228
		[Token(Token = "0x402D774")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_canStartFrom;

		// Token: 0x0402D775 RID: 186229
		[Token(Token = "0x402D775")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_roadPointStyle;

		// Token: 0x0402D776 RID: 186230
		[Token(Token = "0x402D776")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_currentState;

		// Token: 0x0402D777 RID: 186231
		[Token(Token = "0x402D777")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_needShowPreview;

		// Token: 0x0402D778 RID: 186232
		[Token(Token = "0x402D778")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_previewTitle;

		// Token: 0x0402D779 RID: 186233
		[Token(Token = "0x402D779")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_previewDesc;

		// Token: 0x0402D77A RID: 186234
		[Token(Token = "0x402D77A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_rewards;

		// Token: 0x0402D77B RID: 186235
		[Token(Token = "0x402D77B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_relatedNodeOrBagIds;

		// Token: 0x0402D77C RID: 186236
		[Token(Token = "0x402D77C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_highlightView;

		// Token: 0x0402D77D RID: 186237
		[Token(Token = "0x402D77D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_requiredSelectCount;

		// Token: 0x0402D77E RID: 186238
		[Token(Token = "0x402D77E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_UpdatePlayerData;

		// Token: 0x0402D77F RID: 186239
		[Token(Token = "0x402D77F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnLoadData;

		// Token: 0x0402D780 RID: 186240
		[Token(Token = "0x402D780")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
