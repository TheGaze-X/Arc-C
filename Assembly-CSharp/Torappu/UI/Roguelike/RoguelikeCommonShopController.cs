using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054BC RID: 21692
	[Token(Token = "0x20054BC")]
	public class RoguelikeCommonShopController : RoguelikeShopControllerBase
	{
		// Token: 0x0601FE6D RID: 130669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE6D")]
		[Address(RVA = "0x1A04790", Offset = "0x1A03390", VA = "0x181A04790", Slot = "4")]
		public override void OnEnter(RoguelikeShopControllerBase.Builder builder)
		{
		}

		// Token: 0x0601FE6E RID: 130670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE6E")]
		[Address(RVA = "0x1A04C10", Offset = "0x1A03810", VA = "0x181A04C10", Slot = "5")]
		public override void OnResume(bool isResumedFromStack)
		{
		}

		// Token: 0x0601FE6F RID: 130671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FE6F")]
		[Address(RVA = "0x1A04650", Offset = "0x1A03250", VA = "0x181A04650", Slot = "7")]
		public override IEnumerator HideCoroutine()
		{
			return null;
		}

		// Token: 0x0601FE70 RID: 130672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE70")]
		[Address(RVA = "0x1A04710", Offset = "0x1A03310", VA = "0x181A04710", Slot = "8")]
		protected virtual void LoadDynShopView()
		{
		}

		// Token: 0x0601FE71 RID: 130673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE71")]
		[Address(RVA = "0x1A04560", Offset = "0x1A03160", VA = "0x181A04560", Slot = "9")]
		protected virtual void CollectDynShopView(List<IRoguelikeGameShopVisibility> panelList)
		{
		}

		// Token: 0x0601FE72 RID: 130674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE72")]
		[Address(RVA = "0x1A04420", Offset = "0x1A03020", VA = "0x181A04420", Slot = "10")]
		protected virtual void CollectDynBankView(List<RoguelikeGameShopBaseView> panelList)
		{
		}

		// Token: 0x0601FE73 RID: 130675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE73")]
		[Address(RVA = "0x1A06B10", Offset = "0x1A05710", VA = "0x181A06B10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601FE74 RID: 130676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE74")]
		[Address(RVA = "0x1A05DF0", Offset = "0x1A049F0", VA = "0x181A05DF0")]
		private void _InitCommonChildView()
		{
		}

		// Token: 0x0601FE75 RID: 130677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE75")]
		[Address(RVA = "0x1A06F40", Offset = "0x1A05B40", VA = "0x181A06F40")]
		private void _InitStatusController()
		{
		}

		// Token: 0x0601FE76 RID: 130678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE76")]
		[Address(RVA = "0x1A05AB0", Offset = "0x1A046B0", VA = "0x181A05AB0")]
		private void _InitBankController()
		{
		}

		// Token: 0x0601FE77 RID: 130679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE77")]
		[Address(RVA = "0x1A053C0", Offset = "0x1A03FC0", VA = "0x181A053C0")]
		private void _BindPropForViews()
		{
		}

		// Token: 0x0601FE78 RID: 130680 RVA: 0x000B3BB0 File Offset: 0x000B1DB0
		[Token(Token = "0x601FE78")]
		[Address(RVA = "0x1A071B0", Offset = "0x1A05DB0", VA = "0x181A071B0")]
		private bool _IsCurrentStatusEqual(RoguelikeGameShopStatusEnum shopStatus)
		{
			return default(bool);
		}

		// Token: 0x0601FE79 RID: 130681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE79")]
		[Address(RVA = "0x1A0B0C0", Offset = "0x1A09CC0", VA = "0x181A0B0C0")]
		private void _UpdateViewStatus(RoguelikeGameShopStatusEnum shopStatus)
		{
		}

		// Token: 0x0601FE7A RID: 130682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE7A")]
		[Address(RVA = "0x1A0AFA0", Offset = "0x1A09BA0", VA = "0x181A0AFA0")]
		private void _UpdateNpcDialog(RoguelikeGameShopDialogType dialogType, RoguelikeGameItemType itemType = RoguelikeGameItemType.NONE)
		{
		}

		// Token: 0x0601FE7B RID: 130683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE7B")]
		[Address(RVA = "0x1A08550", Offset = "0x1A07150", VA = "0x181A08550")]
		private void _OnGoodsClicked(RoguelikeGoodsViewModel viewModel)
		{
		}

		// Token: 0x0601FE7C RID: 130684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE7C")]
		[Address(RVA = "0x1A07BA0", Offset = "0x1A067A0", VA = "0x181A07BA0")]
		private void _OnBankSlotClicked()
		{
		}

		// Token: 0x0601FE7D RID: 130685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE7D")]
		[Address(RVA = "0x1A08CF0", Offset = "0x1A078F0", VA = "0x181A08CF0")]
		private void _OnLockSlotClicked(RoguelikeGoodsViewModel viewModel)
		{
		}

		// Token: 0x0601FE7E RID: 130686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE7E")]
		[Address(RVA = "0x1A08160", Offset = "0x1A06D60", VA = "0x181A08160")]
		private void _OnConfirmShopRefresh()
		{
		}

		// Token: 0x0601FE7F RID: 130687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE7F")]
		[Address(RVA = "0x1A04F30", Offset = "0x1A03B30", VA = "0x181A04F30")]
		private void _OnShopRefreshed()
		{
		}

		// Token: 0x0601FE80 RID: 130688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE80")]
		[Address(RVA = "0x1A08470", Offset = "0x1A07070", VA = "0x181A08470")]
		private void _OnDealerClick()
		{
		}

		// Token: 0x0601FE81 RID: 130689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE81")]
		[Address(RVA = "0x1A089E0", Offset = "0x1A075E0", VA = "0x181A089E0")]
		private void _OnLeaveShop()
		{
		}

		// Token: 0x0601FE82 RID: 130690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE82")]
		[Address(RVA = "0x1A094E0", Offset = "0x1A080E0", VA = "0x181A094E0")]
		private void _OnRefreshBtnClick()
		{
		}

		// Token: 0x0601FE83 RID: 130691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE83")]
		[Address(RVA = "0x1A09D20", Offset = "0x1A08920", VA = "0x181A09D20")]
		private void _OnSwitchOperationMode()
		{
		}

		// Token: 0x0601FE84 RID: 130692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE84")]
		[Address(RVA = "0x1A08060", Offset = "0x1A06C60", VA = "0x181A08060")]
		private void _OnConfirmClicked()
		{
		}

		// Token: 0x0601FE85 RID: 130693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE85")]
		[Address(RVA = "0x1A07D20", Offset = "0x1A06920", VA = "0x181A07D20")]
		private void _OnBuyGoods(RoguelikeGoodsViewModel goods)
		{
		}

		// Token: 0x0601FE86 RID: 130694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE86")]
		[Address(RVA = "0x1A09110", Offset = "0x1A07D10", VA = "0x181A09110")]
		private void _OnRecycleGoods(RoguelikeGoodsViewModel goods)
		{
		}

		// Token: 0x0601FE87 RID: 130695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE87")]
		[Address(RVA = "0x1A08E40", Offset = "0x1A07A40", VA = "0x181A08E40")]
		private void _OnOpenInvest()
		{
		}

		// Token: 0x0601FE88 RID: 130696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE88")]
		[Address(RVA = "0x1A08F50", Offset = "0x1A07B50", VA = "0x181A08F50")]
		private void _OnOpenWithdrawal()
		{
		}

		// Token: 0x0601FE89 RID: 130697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE89")]
		[Address(RVA = "0x1A07280", Offset = "0x1A05E80", VA = "0x181A07280")]
		private void _LoadBankWithdrawView()
		{
		}

		// Token: 0x0601FE8A RID: 130698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE8A")]
		[Address(RVA = "0x1A0ACA0", Offset = "0x1A098A0", VA = "0x181A0ACA0")]
		private void _TryLoadBankWithdrawView()
		{
		}

		// Token: 0x0601FE8B RID: 130699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE8B")]
		[Address(RVA = "0x1A0A5C0", Offset = "0x1A091C0", VA = "0x181A0A5C0")]
		private void _OnWithdraw()
		{
		}

		// Token: 0x0601FE8C RID: 130700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE8C")]
		[Address(RVA = "0x1A0A380", Offset = "0x1A08F80", VA = "0x181A0A380")]
		private void _OnWithdrawUseItem(int withdrawCount)
		{
		}

		// Token: 0x0601FE8D RID: 130701 RVA: 0x000B3BC8 File Offset: 0x000B1DC8
		[Token(Token = "0x601FE8D")]
		[Address(RVA = "0x1A0B280", Offset = "0x1A09E80", VA = "0x181A0B280")]
		private bool _WithdrawlPreCheck()
		{
			return default(bool);
		}

		// Token: 0x0601FE8E RID: 130702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE8E")]
		[Address(RVA = "0x1A0A230", Offset = "0x1A08E30", VA = "0x181A0A230")]
		private void _OnWithdrawSuccess()
		{
		}

		// Token: 0x0601FE8F RID: 130703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE8F")]
		[Address(RVA = "0x1A09E70", Offset = "0x1A08A70", VA = "0x181A09E70")]
		private void _OnWithdrawConsume()
		{
		}

		// Token: 0x0601FE90 RID: 130704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE90")]
		[Address(RVA = "0x1A09FF0", Offset = "0x1A08BF0", VA = "0x181A09FF0")]
		private void _OnWithdrawIncrementCurrent()
		{
		}

		// Token: 0x0601FE91 RID: 130705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE91")]
		[Address(RVA = "0x1A09F30", Offset = "0x1A08B30", VA = "0x181A09F30")]
		private void _OnWithdrawDecrementCurrent()
		{
		}

		// Token: 0x0601FE92 RID: 130706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE92")]
		[Address(RVA = "0x1A0A0B0", Offset = "0x1A08CB0", VA = "0x181A0A0B0")]
		private void _OnWithdrawMaxCurrent()
		{
		}

		// Token: 0x0601FE93 RID: 130707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE93")]
		[Address(RVA = "0x1A0A170", Offset = "0x1A08D70", VA = "0x181A0A170")]
		private void _OnWithdrawMinCurrent()
		{
		}

		// Token: 0x0601FE94 RID: 130708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE94")]
		[Address(RVA = "0x1A086F0", Offset = "0x1A072F0", VA = "0x181A086F0")]
		private void _OnInvest()
		{
		}

		// Token: 0x0601FE95 RID: 130709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE95")]
		[Address(RVA = "0x1A07860", Offset = "0x1A06460", VA = "0x181A07860")]
		private void _LoadShopBattleConfirmView()
		{
		}

		// Token: 0x0601FE96 RID: 130710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE96")]
		[Address(RVA = "0x1A0AE20", Offset = "0x1A09A20", VA = "0x181A0AE20")]
		private void _TryLoadBattleConfirmView()
		{
		}

		// Token: 0x0601FE97 RID: 130711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE97")]
		[Address(RVA = "0x1A05D10", Offset = "0x1A04910", VA = "0x181A05D10")]
		private void _InitBattleShopView()
		{
		}

		// Token: 0x0601FE98 RID: 130712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE98")]
		[Address(RVA = "0x1A06E70", Offset = "0x1A05A70", VA = "0x181A06E70")]
		private void _InitNormalView()
		{
		}

		// Token: 0x0601FE99 RID: 130713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE99")]
		[Address(RVA = "0x1A06D60", Offset = "0x1A05960", VA = "0x181A06D60")]
		private void _InitLineupViews()
		{
		}

		// Token: 0x0601FE9A RID: 130714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE9A")]
		[Address(RVA = "0x1A070E0", Offset = "0x1A05CE0", VA = "0x181A070E0")]
		private void _InitStatusView()
		{
		}

		// Token: 0x0601FE9B RID: 130715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE9B")]
		[Address(RVA = "0x1A07C50", Offset = "0x1A06850", VA = "0x181A07C50")]
		private void _OnBattleConfirmClick()
		{
		}

		// Token: 0x0601FE9C RID: 130716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE9C")]
		[Address(RVA = "0x1A0AAD0", Offset = "0x1A096D0", VA = "0x181A0AAD0")]
		private void _ShowBattleConfirmView()
		{
		}

		// Token: 0x0601FE9D RID: 130717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE9D")]
		[Address(RVA = "0x1A0A7F0", Offset = "0x1A093F0", VA = "0x181A0A7F0")]
		private void _SendRobShopRequest(Action onComplete)
		{
		}

		// Token: 0x0601FE9E RID: 130718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE9E")]
		[Address(RVA = "0x1A05640", Offset = "0x1A04240", VA = "0x181A05640")]
		private void _CloseSelf()
		{
		}

		// Token: 0x0601FE9F RID: 130719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FE9F")]
		[Address(RVA = "0x1A05580", Offset = "0x1A04180", VA = "0x181A05580")]
		private IEnumerator _CloseSelfCoroutine()
		{
			return null;
		}

		// Token: 0x0601FEA0 RID: 130720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEA0")]
		[Address(RVA = "0x1A059E0", Offset = "0x1A045E0", VA = "0x181A059E0")]
		private void _EventOnOpenBankReward()
		{
		}

		// Token: 0x0601FEA1 RID: 130721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEA1")]
		[Address(RVA = "0x1A05800", Offset = "0x1A04400", VA = "0x181A05800")]
		private void _EventOnBackward()
		{
		}

		// Token: 0x0601FEA2 RID: 130722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEA2")]
		[Address(RVA = "0x1A0B400", Offset = "0x1A0A000", VA = "0x181A0B400")]
		public RoguelikeCommonShopController()
		{
		}

		// Token: 0x0601FEAA RID: 130730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEAA")]
		[Address(RVA = "0x1A04DA0", Offset = "0x1A039A0", VA = "0x181A04DA0")]
		private void <>xLuaBaseProxy_OnEnter(RoguelikeShopControllerBase.Builder P0)
		{
		}

		// Token: 0x0601FEAB RID: 130731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEAB")]
		[Address(RVA = "0x1A04DE0", Offset = "0x1A039E0", VA = "0x181A04DE0")]
		private void <>xLuaBaseProxy_OnResume(bool P0)
		{
		}

		// Token: 0x0601FEAC RID: 130732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FEAC")]
		[Address(RVA = "0x1A04D90", Offset = "0x1A03990", VA = "0x181A04D90")]
		private IEnumerator <>xLuaBaseProxy_HideCoroutine()
		{
			return null;
		}

		// Token: 0x0402B09A RID: 176282
		[Token(Token = "0x402B09A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HashSet<RoguelikeGameItemType> USING_ICON_COST_ITEM_TYPES;

		// Token: 0x0402B09B RID: 176283
		[Token(Token = "0x402B09B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Child Controller")]
		private RoguelikeShopStatusView _shopViewsStatusBinder;

		// Token: 0x0402B09C RID: 176284
		[Token(Token = "0x402B09C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Shop Common View")]
		private RoguelikeShopNormalView _normalView;

		// Token: 0x0402B09D RID: 176285
		[Token(Token = "0x402B09D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Shop Common View")]
		private RoguelikeShopLineupView _lineupBuyView;

		// Token: 0x0402B09E RID: 176286
		[Token(Token = "0x402B09E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Shop Common View")]
		private RoguelikeShopLineupView _lineupRecycleView;

		// Token: 0x0402B09F RID: 176287
		[Token(Token = "0x402B09F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Shop Common View")]
		private RoguelikeShopDetailView _goodDetailView;

		// Token: 0x0402B0A0 RID: 176288
		[Token(Token = "0x402B0A0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Shop Common View")]
		private RoguelikeNpcDialogView _npcDialogView;

		// Token: 0x0402B0A1 RID: 176289
		[Token(Token = "0x402B0A1")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Child Controller")]
		private RoguelikeCommonShopBankViewBinder _bankViewsBinder;

		// Token: 0x0402B0A2 RID: 176290
		[Token(Token = "0x402B0A2")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Bank Common View")]
		private RoguelikeGameBankEntryView _bankEntryView;

		// Token: 0x0402B0A3 RID: 176291
		[Token(Token = "0x402B0A3")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Bank Common View")]
		private RoguelikeGameBankInvestView _bankInvestView;

		// Token: 0x0402B0A4 RID: 176292
		[Token(Token = "0x402B0A4")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Bank Common View")]
		private RoguelikeGameBankFaultyView _bankFaultyView;

		// Token: 0x0402B0A5 RID: 176293
		[Token(Token = "0x402B0A5")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Bank withdraw View Holder")]
		private RectTransform _transBankWithdrawContainer;

		// Token: 0x0402B0A6 RID: 176294
		[Token(Token = "0x402B0A6")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Battle Shop Holder")]
		private RectTransform _transBattleShopConfirmContainer;

		// Token: 0x0402B0A7 RID: 176295
		[Token(Token = "0x402B0A7")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_inited;

		// Token: 0x0402B0A8 RID: 176296
		[Token(Token = "0x402B0A8")]
		[FieldOffset(Offset = "0xB8")]
		private RoguelikeGameBankWithdrawCommonView m_bankWithdrawView;

		// Token: 0x0402B0A9 RID: 176297
		[Token(Token = "0x402B0A9")]
		[FieldOffset(Offset = "0xC0")]
		private RoguelikeGameShopBattleConfirmView m_battleConfirmView;

		// Token: 0x0402B0AA RID: 176298
		[Token(Token = "0x402B0AA")]
		[FieldOffset(Offset = "0xC8")]
		private int m_clickDealerCount;

		// Token: 0x0402B0AB RID: 176299
		[Token(Token = "0x402B0AB")]
		private const int TO_BATTLE_CLICK_COUNT = 3;

		// Token: 0x0402B0AC RID: 176300
		[Token(Token = "0x402B0AC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402B0AD RID: 176301
		[Token(Token = "0x402B0AD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402B0AE RID: 176302
		[Token(Token = "0x402B0AE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0402B0AF RID: 176303
		[Token(Token = "0x402B0AF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadDynShopView;

		// Token: 0x0402B0B0 RID: 176304
		[Token(Token = "0x402B0B0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CollectDynShopView;

		// Token: 0x0402B0B1 RID: 176305
		[Token(Token = "0x402B0B1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CollectDynBankView;

		// Token: 0x0402B0B2 RID: 176306
		[Token(Token = "0x402B0B2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B0B3 RID: 176307
		[Token(Token = "0x402B0B3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitCommonChildView;

		// Token: 0x0402B0B4 RID: 176308
		[Token(Token = "0x402B0B4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitStatusController;

		// Token: 0x0402B0B5 RID: 176309
		[Token(Token = "0x402B0B5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitBankController;

		// Token: 0x0402B0B6 RID: 176310
		[Token(Token = "0x402B0B6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__BindPropForViews;

		// Token: 0x0402B0B7 RID: 176311
		[Token(Token = "0x402B0B7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__IsCurrentStatusEqual;

		// Token: 0x0402B0B8 RID: 176312
		[Token(Token = "0x402B0B8")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UpdateViewStatus;

		// Token: 0x0402B0B9 RID: 176313
		[Token(Token = "0x402B0B9")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UpdateNpcDialog;

		// Token: 0x0402B0BA RID: 176314
		[Token(Token = "0x402B0BA")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnGoodsClicked;

		// Token: 0x0402B0BB RID: 176315
		[Token(Token = "0x402B0BB")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnBankSlotClicked;

		// Token: 0x0402B0BC RID: 176316
		[Token(Token = "0x402B0BC")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnLockSlotClicked;

		// Token: 0x0402B0BD RID: 176317
		[Token(Token = "0x402B0BD")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnConfirmShopRefresh;

		// Token: 0x0402B0BE RID: 176318
		[Token(Token = "0x402B0BE")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnShopRefreshed;

		// Token: 0x0402B0BF RID: 176319
		[Token(Token = "0x402B0BF")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnDealerClick;

		// Token: 0x0402B0C0 RID: 176320
		[Token(Token = "0x402B0C0")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnLeaveShop;

		// Token: 0x0402B0C1 RID: 176321
		[Token(Token = "0x402B0C1")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnRefreshBtnClick;

		// Token: 0x0402B0C2 RID: 176322
		[Token(Token = "0x402B0C2")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnSwitchOperationMode;

		// Token: 0x0402B0C3 RID: 176323
		[Token(Token = "0x402B0C3")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnConfirmClicked;

		// Token: 0x0402B0C4 RID: 176324
		[Token(Token = "0x402B0C4")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__OnBuyGoods;

		// Token: 0x0402B0C5 RID: 176325
		[Token(Token = "0x402B0C5")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__OnRecycleGoods;

		// Token: 0x0402B0C6 RID: 176326
		[Token(Token = "0x402B0C6")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__OnOpenInvest;

		// Token: 0x0402B0C7 RID: 176327
		[Token(Token = "0x402B0C7")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__OnOpenWithdrawal;

		// Token: 0x0402B0C8 RID: 176328
		[Token(Token = "0x402B0C8")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__LoadBankWithdrawView;

		// Token: 0x0402B0C9 RID: 176329
		[Token(Token = "0x402B0C9")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__TryLoadBankWithdrawView;

		// Token: 0x0402B0CA RID: 176330
		[Token(Token = "0x402B0CA")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__OnWithdraw;

		// Token: 0x0402B0CB RID: 176331
		[Token(Token = "0x402B0CB")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__OnWithdrawUseItem;

		// Token: 0x0402B0CC RID: 176332
		[Token(Token = "0x402B0CC")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__WithdrawlPreCheck;

		// Token: 0x0402B0CD RID: 176333
		[Token(Token = "0x402B0CD")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__OnWithdrawSuccess;

		// Token: 0x0402B0CE RID: 176334
		[Token(Token = "0x402B0CE")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__OnWithdrawConsume;

		// Token: 0x0402B0CF RID: 176335
		[Token(Token = "0x402B0CF")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__OnWithdrawIncrementCurrent;

		// Token: 0x0402B0D0 RID: 176336
		[Token(Token = "0x402B0D0")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__OnWithdrawDecrementCurrent;

		// Token: 0x0402B0D1 RID: 176337
		[Token(Token = "0x402B0D1")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__OnWithdrawMaxCurrent;

		// Token: 0x0402B0D2 RID: 176338
		[Token(Token = "0x402B0D2")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__OnWithdrawMinCurrent;

		// Token: 0x0402B0D3 RID: 176339
		[Token(Token = "0x402B0D3")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__OnInvest;

		// Token: 0x0402B0D4 RID: 176340
		[Token(Token = "0x402B0D4")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__LoadShopBattleConfirmView;

		// Token: 0x0402B0D5 RID: 176341
		[Token(Token = "0x402B0D5")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__TryLoadBattleConfirmView;

		// Token: 0x0402B0D6 RID: 176342
		[Token(Token = "0x402B0D6")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__InitBattleShopView;

		// Token: 0x0402B0D7 RID: 176343
		[Token(Token = "0x402B0D7")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__InitNormalView;

		// Token: 0x0402B0D8 RID: 176344
		[Token(Token = "0x402B0D8")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__InitLineupViews;

		// Token: 0x0402B0D9 RID: 176345
		[Token(Token = "0x402B0D9")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__InitStatusView;

		// Token: 0x0402B0DA RID: 176346
		[Token(Token = "0x402B0DA")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__OnBattleConfirmClick;

		// Token: 0x0402B0DB RID: 176347
		[Token(Token = "0x402B0DB")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__ShowBattleConfirmView;

		// Token: 0x0402B0DC RID: 176348
		[Token(Token = "0x402B0DC")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__SendRobShopRequest;

		// Token: 0x0402B0DD RID: 176349
		[Token(Token = "0x402B0DD")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__CloseSelf;

		// Token: 0x0402B0DE RID: 176350
		[Token(Token = "0x402B0DE")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__CloseSelfCoroutine;

		// Token: 0x0402B0DF RID: 176351
		[Token(Token = "0x402B0DF")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__EventOnOpenBankReward;

		// Token: 0x0402B0E0 RID: 176352
		[Token(Token = "0x402B0E0")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0__EventOnBackward;

		// Token: 0x0402B0E1 RID: 176353
		[Token(Token = "0x402B0E1")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
