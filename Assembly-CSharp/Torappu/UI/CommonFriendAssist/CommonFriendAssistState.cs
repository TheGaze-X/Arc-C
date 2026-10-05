using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CommonFriendAssist
{
	// Token: 0x02005BC4 RID: 23492
	[Token(Token = "0x2005BC4")]
	public class CommonFriendAssistState : PopupFadeState, CommonFriendAssistView.ICtrl, CommonFriendAssistItem.ICtrl, CommonFriendAssistProfessionTabView.ICtrl
	{
		// Token: 0x0602210A RID: 139530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602210A")]
		[Address(RVA = "0x1C8C490", Offset = "0x1C8B090", VA = "0x181C8C490", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602210B RID: 139531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602210B")]
		[Address(RVA = "0x1C8C4F0", Offset = "0x1C8B0F0", VA = "0x181C8C4F0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602210C RID: 139532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602210C")]
		[Address(RVA = "0x1C8C700", Offset = "0x1C8B300", VA = "0x181C8C700", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x0602210D RID: 139533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602210D")]
		[Address(RVA = "0x1C8C900", Offset = "0x1C8B500", VA = "0x181C8C900", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602210E RID: 139534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602210E")]
		[Address(RVA = "0x1C8D000", Offset = "0x1C8BC00", VA = "0x181C8D000")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602210F RID: 139535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602210F")]
		[Address(RVA = "0x1C8D260", Offset = "0x1C8BE60", VA = "0x181C8D260")]
		private void _OnUpdateCoolDown()
		{
		}

		// Token: 0x06022110 RID: 139536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022110")]
		[Address(RVA = "0x1C8C410", Offset = "0x1C8B010", VA = "0x181C8C410")]
		public void EventOnReturn()
		{
		}

		// Token: 0x06022111 RID: 139537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022111")]
		[Address(RVA = "0x1C8D5D0", Offset = "0x1C8C1D0", VA = "0x181C8D5D0")]
		private void _ReqRefresh(bool refreshFlag)
		{
		}

		// Token: 0x06022112 RID: 139538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022112")]
		[Address(RVA = "0x1C8CE90", Offset = "0x1C8BA90", VA = "0x181C8CE90")]
		private void _DoneRefresh(CommonFriendAssistData data)
		{
		}

		// Token: 0x06022113 RID: 139539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022113")]
		[Address(RVA = "0x1C8C9A0", Offset = "0x1C8B5A0", VA = "0x181C8C9A0", Slot = "31")]
		public void Refresh()
		{
		}

		// Token: 0x06022114 RID: 139540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022114")]
		[Address(RVA = "0x1C8C0D0", Offset = "0x1C8ACD0", VA = "0x181C8C0D0", Slot = "33")]
		public void ApplyAssist(CommonFriendAssistViewModel.FriendItemModel model)
		{
		}

		// Token: 0x06022115 RID: 139541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022115")]
		[Address(RVA = "0x1C8CDF0", Offset = "0x1C8B9F0", VA = "0x181C8CDF0")]
		private void _ApplyAssistSuccess()
		{
		}

		// Token: 0x06022116 RID: 139542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022116")]
		[Address(RVA = "0x1C8CBC0", Offset = "0x1C8B7C0", VA = "0x181C8CBC0", Slot = "34")]
		public void ShowFriendAvatar(string uid)
		{
		}

		// Token: 0x06022117 RID: 139543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022117")]
		[Address(RVA = "0x1C8D4A0", Offset = "0x1C8C0A0", VA = "0x181C8D4A0")]
		private void _OpenFriendNameCard(GetOtherPlayerNameCardResponse response)
		{
		}

		// Token: 0x06022118 RID: 139544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022118")]
		[Address(RVA = "0x1C8C320", Offset = "0x1C8AF20", VA = "0x181C8C320", Slot = "35")]
		public void ChangeProfGrp(ProfessionCategory prof)
		{
		}

		// Token: 0x06022119 RID: 139545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022119")]
		[Address(RVA = "0x1C8CA50", Offset = "0x1C8B650", VA = "0x181C8CA50", Slot = "32")]
		public void SetStarFriendTab(bool prevState)
		{
		}

		// Token: 0x0602211A RID: 139546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602211A")]
		[Address(RVA = "0x1C8D800", Offset = "0x1C8C400", VA = "0x181C8D800")]
		public CommonFriendAssistState()
		{
		}

		// Token: 0x0602211B RID: 139547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602211B")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602211C RID: 139548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602211C")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x0602211D RID: 139549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602211D")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0402EBAB RID: 191403
		[Token(Token = "0x402EBAB")]
		private const float CD_TIMER_TICK_DELAY = 0.1f;

		// Token: 0x0402EBAC RID: 191404
		[Token(Token = "0x402EBAC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CommonFriendAssistView _view;

		// Token: 0x0402EBAD RID: 191405
		[Token(Token = "0x402EBAD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Button _btnReturn;

		// Token: 0x0402EBAE RID: 191406
		[Token(Token = "0x402EBAE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TwoStateToggle _reqRefreshBtnStatus;

		// Token: 0x0402EBAF RID: 191407
		[Token(Token = "0x402EBAF")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textCoolDown;

		// Token: 0x0402EBB0 RID: 191408
		[Token(Token = "0x402EBB0")]
		[FieldOffset(Offset = "0x90")]
		private TickFunctionTimer m_cachedTimer;

		// Token: 0x0402EBB1 RID: 191409
		[Token(Token = "0x402EBB1")]
		[FieldOffset(Offset = "0x98")]
		private CommonFriendAssistStateBean m_bean;

		// Token: 0x0402EBB2 RID: 191410
		[Token(Token = "0x402EBB2")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_inited;

		// Token: 0x0402EBB3 RID: 191411
		[Token(Token = "0x402EBB3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402EBB4 RID: 191412
		[Token(Token = "0x402EBB4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402EBB5 RID: 191413
		[Token(Token = "0x402EBB5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x0402EBB6 RID: 191414
		[Token(Token = "0x402EBB6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402EBB7 RID: 191415
		[Token(Token = "0x402EBB7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402EBB8 RID: 191416
		[Token(Token = "0x402EBB8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnUpdateCoolDown;

		// Token: 0x0402EBB9 RID: 191417
		[Token(Token = "0x402EBB9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnReturn;

		// Token: 0x0402EBBA RID: 191418
		[Token(Token = "0x402EBBA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ReqRefresh;

		// Token: 0x0402EBBB RID: 191419
		[Token(Token = "0x402EBBB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__DoneRefresh;

		// Token: 0x0402EBBC RID: 191420
		[Token(Token = "0x402EBBC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Refresh;

		// Token: 0x0402EBBD RID: 191421
		[Token(Token = "0x402EBBD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ApplyAssist;

		// Token: 0x0402EBBE RID: 191422
		[Token(Token = "0x402EBBE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ApplyAssistSuccess;

		// Token: 0x0402EBBF RID: 191423
		[Token(Token = "0x402EBBF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ShowFriendAvatar;

		// Token: 0x0402EBC0 RID: 191424
		[Token(Token = "0x402EBC0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OpenFriendNameCard;

		// Token: 0x0402EBC1 RID: 191425
		[Token(Token = "0x402EBC1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ChangeProfGrp;

		// Token: 0x0402EBC2 RID: 191426
		[Token(Token = "0x402EBC2")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_SetStarFriendTab;

		// Token: 0x0402EBC3 RID: 191427
		[Token(Token = "0x402EBC3")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005BC5 RID: 23493
		[Token(Token = "0x2005BC5")]
		public enum Event
		{
			// Token: 0x0402EBC5 RID: 191429
			[Token(Token = "0x402EBC5")]
			CHANGE_PROF_GRP,
			// Token: 0x0402EBC6 RID: 191430
			[Token(Token = "0x402EBC6")]
			SHOW_FRIEND_AVATAR,
			// Token: 0x0402EBC7 RID: 191431
			[Token(Token = "0x402EBC7")]
			CHOOSE_ASSIST
		}
	}
}
