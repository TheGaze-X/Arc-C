using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x0200561B RID: 22043
	[Token(Token = "0x200561B")]
	public class RL05SpecialShopController : RoguelikeShopControllerBase
	{
		// Token: 0x06020576 RID: 132470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020576")]
		[Address(RVA = "0x1A7FF20", Offset = "0x1A7EB20", VA = "0x181A7FF20", Slot = "4")]
		public override void OnEnter(RoguelikeShopControllerBase.Builder builder)
		{
		}

		// Token: 0x06020577 RID: 132471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020577")]
		[Address(RVA = "0x1A802B0", Offset = "0x1A7EEB0", VA = "0x181A802B0", Slot = "5")]
		public override void OnResume(bool isResumedFromStack)
		{
		}

		// Token: 0x06020578 RID: 132472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020578")]
		[Address(RVA = "0x1A80FC0", Offset = "0x1A7FBC0", VA = "0x181A80FC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020579 RID: 132473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020579")]
		[Address(RVA = "0x1A80850", Offset = "0x1A7F450", VA = "0x181A80850")]
		private void _InitCommonChildView()
		{
		}

		// Token: 0x0602057A RID: 132474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602057A")]
		[Address(RVA = "0x1A81440", Offset = "0x1A80040", VA = "0x181A81440")]
		private void _InitStatusController()
		{
		}

		// Token: 0x0602057B RID: 132475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602057B")]
		[Address(RVA = "0x1A80650", Offset = "0x1A7F250", VA = "0x181A80650")]
		private void _BindPropForViews()
		{
		}

		// Token: 0x0602057C RID: 132476 RVA: 0x000B5788 File Offset: 0x000B3988
		[Token(Token = "0x602057C")]
		[Address(RVA = "0x1A81620", Offset = "0x1A80220", VA = "0x181A81620")]
		private bool _IsCurrentStatusEqual(RoguelikeGameShopStatusEnum shopStatus)
		{
			return default(bool);
		}

		// Token: 0x0602057D RID: 132477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602057D")]
		[Address(RVA = "0x1A828E0", Offset = "0x1A814E0", VA = "0x181A828E0")]
		private void _UpdateViewStatus(RoguelikeGameShopStatusEnum shopStatus)
		{
		}

		// Token: 0x0602057E RID: 132478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602057E")]
		[Address(RVA = "0x1A827C0", Offset = "0x1A813C0", VA = "0x181A827C0")]
		private void _UpdateNpcDialog(RoguelikeGameShopDialogType dialogType, RoguelikeGameItemType itemType = RoguelikeGameItemType.NONE)
		{
		}

		// Token: 0x0602057F RID: 132479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602057F")]
		[Address(RVA = "0x1A81DA0", Offset = "0x1A809A0", VA = "0x181A81DA0")]
		private void _OnGoodsClicked(RoguelikeGoodsViewModel viewModel)
		{
		}

		// Token: 0x06020580 RID: 132480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020580")]
		[Address(RVA = "0x1A82260", Offset = "0x1A80E60", VA = "0x181A82260")]
		private void _OnLockSlotClicked(RoguelikeGoodsViewModel viewModel)
		{
		}

		// Token: 0x06020581 RID: 132481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020581")]
		[Address(RVA = "0x1A81B20", Offset = "0x1A80720", VA = "0x181A81B20")]
		private void _OnConfirmShopRefresh()
		{
		}

		// Token: 0x06020582 RID: 132482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020582")]
		[Address(RVA = "0x1A803E0", Offset = "0x1A7EFE0", VA = "0x181A803E0")]
		private void _OnShopRefreshed()
		{
		}

		// Token: 0x06020583 RID: 132483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020583")]
		[Address(RVA = "0x1A81F40", Offset = "0x1A80B40", VA = "0x181A81F40")]
		private void _OnLeaveShop()
		{
		}

		// Token: 0x06020584 RID: 132484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020584")]
		[Address(RVA = "0x1A82320", Offset = "0x1A80F20", VA = "0x181A82320")]
		private void _OnRefreshBtnClick()
		{
		}

		// Token: 0x06020585 RID: 132485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020585")]
		[Address(RVA = "0x1A81A30", Offset = "0x1A80630", VA = "0x181A81A30")]
		private void _OnConfirmClicked()
		{
		}

		// Token: 0x06020586 RID: 132486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020586")]
		[Address(RVA = "0x1A816F0", Offset = "0x1A802F0", VA = "0x181A816F0")]
		private void _OnBuyGoods(RoguelikeGoodsViewModel goods)
		{
		}

		// Token: 0x06020587 RID: 132487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020587")]
		[Address(RVA = "0x1A81330", Offset = "0x1A7FF30", VA = "0x181A81330")]
		private void _InitNormalView()
		{
		}

		// Token: 0x06020588 RID: 132488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020588")]
		[Address(RVA = "0x1A81260", Offset = "0x1A7FE60", VA = "0x181A81260")]
		private void _InitLineupView()
		{
		}

		// Token: 0x06020589 RID: 132489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020589")]
		[Address(RVA = "0x1A81550", Offset = "0x1A80150", VA = "0x181A81550")]
		private void _InitStatusView()
		{
		}

		// Token: 0x0602058A RID: 132490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602058A")]
		[Address(RVA = "0x1A80760", Offset = "0x1A7F360", VA = "0x181A80760")]
		private void _EventOnBackward()
		{
		}

		// Token: 0x0602058B RID: 132491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602058B")]
		[Address(RVA = "0x1A82B50", Offset = "0x1A81750", VA = "0x181A82B50")]
		public RL05SpecialShopController()
		{
		}

		// Token: 0x0602058F RID: 132495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602058F")]
		[Address(RVA = "0x1A04DA0", Offset = "0x1A039A0", VA = "0x181A04DA0")]
		private void <>xLuaBaseProxy_OnEnter(RoguelikeShopControllerBase.Builder P0)
		{
		}

		// Token: 0x06020590 RID: 132496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020590")]
		[Address(RVA = "0x1A04DE0", Offset = "0x1A039E0", VA = "0x181A04DE0")]
		private void <>xLuaBaseProxy_OnResume(bool P0)
		{
		}

		// Token: 0x0402BC53 RID: 179283
		[Token(Token = "0x402BC53")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HashSet<RoguelikeGameItemType> USING_ICON_COST_ITEM_TYPES;

		// Token: 0x0402BC54 RID: 179284
		[Token(Token = "0x402BC54")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RoguelikeShopStatusView _statusView;

		// Token: 0x0402BC55 RID: 179285
		[Token(Token = "0x402BC55")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RL05SpecialShopNormalView _normalView;

		// Token: 0x0402BC56 RID: 179286
		[Token(Token = "0x402BC56")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RoguelikeShopLineupView _lineupView;

		// Token: 0x0402BC57 RID: 179287
		[Token(Token = "0x402BC57")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RL05SpecialShopDetailView _detailView;

		// Token: 0x0402BC58 RID: 179288
		[Token(Token = "0x402BC58")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RoguelikeNpcDialogView _npcDialogView;

		// Token: 0x0402BC59 RID: 179289
		[Token(Token = "0x402BC59")]
		[FieldOffset(Offset = "0x78")]
		private bool m_inited;

		// Token: 0x0402BC5A RID: 179290
		[Token(Token = "0x402BC5A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402BC5B RID: 179291
		[Token(Token = "0x402BC5B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402BC5C RID: 179292
		[Token(Token = "0x402BC5C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402BC5D RID: 179293
		[Token(Token = "0x402BC5D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitCommonChildView;

		// Token: 0x0402BC5E RID: 179294
		[Token(Token = "0x402BC5E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitStatusController;

		// Token: 0x0402BC5F RID: 179295
		[Token(Token = "0x402BC5F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__BindPropForViews;

		// Token: 0x0402BC60 RID: 179296
		[Token(Token = "0x402BC60")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__IsCurrentStatusEqual;

		// Token: 0x0402BC61 RID: 179297
		[Token(Token = "0x402BC61")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateViewStatus;

		// Token: 0x0402BC62 RID: 179298
		[Token(Token = "0x402BC62")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateNpcDialog;

		// Token: 0x0402BC63 RID: 179299
		[Token(Token = "0x402BC63")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnGoodsClicked;

		// Token: 0x0402BC64 RID: 179300
		[Token(Token = "0x402BC64")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnLockSlotClicked;

		// Token: 0x0402BC65 RID: 179301
		[Token(Token = "0x402BC65")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnConfirmShopRefresh;

		// Token: 0x0402BC66 RID: 179302
		[Token(Token = "0x402BC66")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnShopRefreshed;

		// Token: 0x0402BC67 RID: 179303
		[Token(Token = "0x402BC67")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnLeaveShop;

		// Token: 0x0402BC68 RID: 179304
		[Token(Token = "0x402BC68")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnRefreshBtnClick;

		// Token: 0x0402BC69 RID: 179305
		[Token(Token = "0x402BC69")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnConfirmClicked;

		// Token: 0x0402BC6A RID: 179306
		[Token(Token = "0x402BC6A")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnBuyGoods;

		// Token: 0x0402BC6B RID: 179307
		[Token(Token = "0x402BC6B")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__InitNormalView;

		// Token: 0x0402BC6C RID: 179308
		[Token(Token = "0x402BC6C")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__InitLineupView;

		// Token: 0x0402BC6D RID: 179309
		[Token(Token = "0x402BC6D")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__InitStatusView;

		// Token: 0x0402BC6E RID: 179310
		[Token(Token = "0x402BC6E")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__EventOnBackward;

		// Token: 0x0402BC6F RID: 179311
		[Token(Token = "0x402BC6F")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
