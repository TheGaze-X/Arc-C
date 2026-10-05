using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005959 RID: 22873
	[Token(Token = "0x2005959")]
	public class CrisisV2MapTreasureNodeModel : CrisisV2MapNodeModel
	{
		// Token: 0x17004E2D RID: 20013
		// (get) Token: 0x06021552 RID: 136530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E2D")]
		public ItemBundle reward
		{
			[Token(Token = "0x6021552")]
			[Address(RVA = "0x1BB7BB0", Offset = "0x1BB67B0", VA = "0x181BB7BB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E2E RID: 20014
		// (get) Token: 0x06021553 RID: 136531 RVA: 0x000B9640 File Offset: 0x000B7840
		[Token(Token = "0x17004E2E")]
		public override bool isSpecialNode
		{
			[Token(Token = "0x6021553")]
			[Address(RVA = "0x1BB78F0", Offset = "0x1BB64F0", VA = "0x181BB78F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004E2F RID: 20015
		// (get) Token: 0x06021554 RID: 136532 RVA: 0x000B9658 File Offset: 0x000B7858
		[Token(Token = "0x17004E2F")]
		public override PlayerCrisisV2Season.NodeState currentState
		{
			[Token(Token = "0x6021554")]
			[Address(RVA = "0x1BB77B0", Offset = "0x1BB63B0", VA = "0x181BB77B0", Slot = "7")]
			get
			{
				return PlayerCrisisV2Season.NodeState.INACTIVE;
			}
		}

		// Token: 0x17004E30 RID: 20016
		// (get) Token: 0x06021555 RID: 136533 RVA: 0x000B9670 File Offset: 0x000B7870
		[Token(Token = "0x17004E30")]
		public override bool needShowPreview
		{
			[Token(Token = "0x6021555")]
			[Address(RVA = "0x1BB7950", Offset = "0x1BB6550", VA = "0x181BB7950", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004E31 RID: 20017
		// (get) Token: 0x06021556 RID: 136534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E31")]
		public override string previewTitle
		{
			[Token(Token = "0x6021556")]
			[Address(RVA = "0x1BB7A40", Offset = "0x1BB6640", VA = "0x181BB7A40", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E32 RID: 20018
		// (get) Token: 0x06021557 RID: 136535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E32")]
		public override string previewDesc
		{
			[Token(Token = "0x6021557")]
			[Address(RVA = "0x1BB79B0", Offset = "0x1BB65B0", VA = "0x181BB79B0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E33 RID: 20019
		// (get) Token: 0x06021558 RID: 136536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E33")]
		public override List<CrisisV2TimeLimitItemModel> rewards
		{
			[Token(Token = "0x6021558")]
			[Address(RVA = "0x1BB7C20", Offset = "0x1BB6820", VA = "0x181BB7C20", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E34 RID: 20020
		// (get) Token: 0x06021559 RID: 136537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E34")]
		public override List<string> relatedNodeOrBagIds
		{
			[Token(Token = "0x6021559")]
			[Address(RVA = "0x1BB7AD0", Offset = "0x1BB66D0", VA = "0x181BB7AD0", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004E35 RID: 20021
		// (get) Token: 0x0602155A RID: 136538 RVA: 0x000B9688 File Offset: 0x000B7888
		[Token(Token = "0x17004E35")]
		public override CrisisV2MapModel.ViewType highlightView
		{
			[Token(Token = "0x602155A")]
			[Address(RVA = "0x1BB7890", Offset = "0x1BB6490", VA = "0x181BB7890", Slot = "16")]
			get
			{
				return CrisisV2MapModel.ViewType.NONE;
			}
		}

		// Token: 0x17004E36 RID: 20022
		// (get) Token: 0x0602155B RID: 136539 RVA: 0x000B96A0 File Offset: 0x000B78A0
		[Token(Token = "0x17004E36")]
		public override int requiredSelectCount
		{
			[Token(Token = "0x602155B")]
			[Address(RVA = "0x1BB7B40", Offset = "0x1BB6740", VA = "0x181BB7B40", Slot = "17")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004E37 RID: 20023
		// (get) Token: 0x0602155C RID: 136540 RVA: 0x000B96B8 File Offset: 0x000B78B8
		[Token(Token = "0x17004E37")]
		public int currentVal
		{
			[Token(Token = "0x602155C")]
			[Address(RVA = "0x1BB7820", Offset = "0x1BB6420", VA = "0x181BB7820")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004E38 RID: 20024
		// (get) Token: 0x0602155D RID: 136541 RVA: 0x000B96D0 File Offset: 0x000B78D0
		[Token(Token = "0x17004E38")]
		public int totalVal
		{
			[Token(Token = "0x602155D")]
			[Address(RVA = "0x1BB7D90", Offset = "0x1BB6990", VA = "0x181BB7D90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602155E RID: 136542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602155E")]
		[Address(RVA = "0x1BB7510", Offset = "0x1BB6110", VA = "0x181BB7510", Slot = "19")]
		protected override void OnLoadData()
		{
		}

		// Token: 0x0602155F RID: 136543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602155F")]
		[Address(RVA = "0x1BB75D0", Offset = "0x1BB61D0", VA = "0x181BB75D0", Slot = "18")]
		public override void UpdatePlayerData(PlayerCrisisV2Season.BasicMapInfo playerMapInfo)
		{
		}

		// Token: 0x06021560 RID: 136544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021560")]
		[Address(RVA = "0x1BB7710", Offset = "0x1BB6310", VA = "0x181BB7710")]
		public CrisisV2MapTreasureNodeModel()
		{
		}

		// Token: 0x06021561 RID: 136545 RVA: 0x000B96E8 File Offset: 0x000B78E8
		[Token(Token = "0x6021561")]
		[Address(RVA = "0x1BA5160", Offset = "0x1BA3D60", VA = "0x181BA5160")]
		private bool <>xLuaBaseProxy_get_isSpecialNode()
		{
			return default(bool);
		}

		// Token: 0x06021562 RID: 136546 RVA: 0x000B9700 File Offset: 0x000B7900
		[Token(Token = "0x6021562")]
		[Address(RVA = "0x1BA5040", Offset = "0x1BA3C40", VA = "0x181BA5040")]
		private PlayerCrisisV2Season.NodeState <>xLuaBaseProxy_get_currentState()
		{
			return PlayerCrisisV2Season.NodeState.INACTIVE;
		}

		// Token: 0x06021563 RID: 136547 RVA: 0x000B9718 File Offset: 0x000B7918
		[Token(Token = "0x6021563")]
		[Address(RVA = "0x1BA51C0", Offset = "0x1BA3DC0", VA = "0x181BA51C0")]
		private bool <>xLuaBaseProxy_get_needShowPreview()
		{
			return default(bool);
		}

		// Token: 0x06021564 RID: 136548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021564")]
		[Address(RVA = "0x1BA5290", Offset = "0x1BA3E90", VA = "0x181BA5290")]
		private string <>xLuaBaseProxy_get_previewTitle()
		{
			return null;
		}

		// Token: 0x06021565 RID: 136549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021565")]
		[Address(RVA = "0x1BA5220", Offset = "0x1BA3E20", VA = "0x181BA5220")]
		private string <>xLuaBaseProxy_get_previewDesc()
		{
			return null;
		}

		// Token: 0x06021566 RID: 136550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021566")]
		[Address(RVA = "0x1BA53C0", Offset = "0x1BA3FC0", VA = "0x181BA53C0")]
		private List<CrisisV2TimeLimitItemModel> <>xLuaBaseProxy_get_rewards()
		{
			return null;
		}

		// Token: 0x06021567 RID: 136551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021567")]
		[Address(RVA = "0x1BA5300", Offset = "0x1BA3F00", VA = "0x181BA5300")]
		private List<string> <>xLuaBaseProxy_get_relatedNodeOrBagIds()
		{
			return null;
		}

		// Token: 0x06021568 RID: 136552 RVA: 0x000B9730 File Offset: 0x000B7930
		[Token(Token = "0x6021568")]
		[Address(RVA = "0x1BA50A0", Offset = "0x1BA3CA0", VA = "0x181BA50A0")]
		private CrisisV2MapModel.ViewType <>xLuaBaseProxy_get_highlightView()
		{
			return CrisisV2MapModel.ViewType.NONE;
		}

		// Token: 0x06021569 RID: 136553 RVA: 0x000B9748 File Offset: 0x000B7948
		[Token(Token = "0x6021569")]
		[Address(RVA = "0x1BA5360", Offset = "0x1BA3F60", VA = "0x181BA5360")]
		private int <>xLuaBaseProxy_get_requiredSelectCount()
		{
			return 0;
		}

		// Token: 0x0602156A RID: 136554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602156A")]
		[Address(RVA = "0x1BA4EC0", Offset = "0x1BA3AC0", VA = "0x181BA4EC0")]
		private void <>xLuaBaseProxy_OnLoadData()
		{
		}

		// Token: 0x0602156B RID: 136555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602156B")]
		[Address(RVA = "0x1BA4F20", Offset = "0x1BA3B20", VA = "0x181BA4F20")]
		private void <>xLuaBaseProxy_UpdatePlayerData(PlayerCrisisV2Season.BasicMapInfo P0)
		{
		}

		// Token: 0x0402D75C RID: 186204
		[Token(Token = "0x402D75C")]
		[FieldOffset(Offset = "0x30")]
		private CrisisV2RewardNodeData m_treasureServerData;

		// Token: 0x0402D75D RID: 186205
		[Token(Token = "0x402D75D")]
		[FieldOffset(Offset = "0x38")]
		private PlayerCrisisV2Season.RewardInfo m_rewardInfo;

		// Token: 0x0402D75E RID: 186206
		[Token(Token = "0x402D75E")]
		[FieldOffset(Offset = "0x40")]
		private List<CrisisV2TimeLimitItemModel> m_previewRewards;

		// Token: 0x0402D75F RID: 186207
		[Token(Token = "0x402D75F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_reward;

		// Token: 0x0402D760 RID: 186208
		[Token(Token = "0x402D760")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isSpecialNode;

		// Token: 0x0402D761 RID: 186209
		[Token(Token = "0x402D761")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_currentState;

		// Token: 0x0402D762 RID: 186210
		[Token(Token = "0x402D762")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_needShowPreview;

		// Token: 0x0402D763 RID: 186211
		[Token(Token = "0x402D763")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_previewTitle;

		// Token: 0x0402D764 RID: 186212
		[Token(Token = "0x402D764")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_previewDesc;

		// Token: 0x0402D765 RID: 186213
		[Token(Token = "0x402D765")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_rewards;

		// Token: 0x0402D766 RID: 186214
		[Token(Token = "0x402D766")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_relatedNodeOrBagIds;

		// Token: 0x0402D767 RID: 186215
		[Token(Token = "0x402D767")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_highlightView;

		// Token: 0x0402D768 RID: 186216
		[Token(Token = "0x402D768")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_requiredSelectCount;

		// Token: 0x0402D769 RID: 186217
		[Token(Token = "0x402D769")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_currentVal;

		// Token: 0x0402D76A RID: 186218
		[Token(Token = "0x402D76A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_totalVal;

		// Token: 0x0402D76B RID: 186219
		[Token(Token = "0x402D76B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnLoadData;

		// Token: 0x0402D76C RID: 186220
		[Token(Token = "0x402D76C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_UpdatePlayerData;

		// Token: 0x0402D76D RID: 186221
		[Token(Token = "0x402D76D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
