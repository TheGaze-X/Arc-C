using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B0F RID: 19215
	[Token(Token = "0x2004B0F")]
	public class HomeCheckInState : PopupFloatState, IValueMsgReceiver, ICompDialogCallBack, IHotfixable
	{
		// Token: 0x0601CE3D RID: 118333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CE3D")]
		[Address(RVA = "0x16538A0", Offset = "0x16524A0", VA = "0x1816538A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601CE3E RID: 118334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE3E")]
		[Address(RVA = "0x1653A10", Offset = "0x1652610", VA = "0x181653A10", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601CE3F RID: 118335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE3F")]
		[Address(RVA = "0x1653D00", Offset = "0x1652900", VA = "0x181653D00", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601CE40 RID: 118336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE40")]
		[Address(RVA = "0x1653B10", Offset = "0x1652710", VA = "0x181653B10", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601CE41 RID: 118337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE41")]
		[Address(RVA = "0x1653900", Offset = "0x1652500", VA = "0x181653900", Slot = "33")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0601CE42 RID: 118338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE42")]
		[Address(RVA = "0x1653760", Offset = "0x1652360", VA = "0x181653760")]
		public void EventOnBackPressed()
		{
		}

		// Token: 0x0601CE43 RID: 118339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE43")]
		[Address(RVA = "0x16540C0", Offset = "0x1652CC0", VA = "0x1816540C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601CE44 RID: 118340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE44")]
		[Address(RVA = "0x1654750", Offset = "0x1653350", VA = "0x181654750")]
		private void _SendCheckInRequest()
		{
		}

		// Token: 0x0601CE45 RID: 118341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CE45")]
		[Address(RVA = "0x1654650", Offset = "0x1653250", VA = "0x181654650")]
		private IEnumerator _ReceiveItemsCoroutine(CheckInResponse response, UIPage page)
		{
			return null;
		}

		// Token: 0x0601CE46 RID: 118342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE46")]
		[Address(RVA = "0x1654580", Offset = "0x1653180", VA = "0x181654580")]
		private void _OnSignInItemClicked(int index)
		{
		}

		// Token: 0x0601CE47 RID: 118343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE47")]
		[Address(RVA = "0x16548D0", Offset = "0x16534D0", VA = "0x1816548D0")]
		private void _SetProgressDetailShownStatus(bool isShown)
		{
		}

		// Token: 0x0601CE48 RID: 118344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE48")]
		[Address(RVA = "0x1654340", Offset = "0x1652F40", VA = "0x181654340")]
		private void _OnLongTermBtnClicked()
		{
		}

		// Token: 0x0601CE49 RID: 118345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE49")]
		[Address(RVA = "0x16549B0", Offset = "0x16535B0", VA = "0x1816549B0")]
		public HomeCheckInState()
		{
		}

		// Token: 0x0601CE4B RID: 118347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE4B")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601CE4C RID: 118348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE4C")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04025E61 RID: 155233
		[Token(Token = "0x4025E61")]
		private const float DELAY_CHECKIN_TODAY_EFFECT = 1f;

		// Token: 0x04025E62 RID: 155234
		[Token(Token = "0x4025E62")]
		[NonSerialized]
		public const int MSG_ON_SIGN_IN_ITEM_CLICKED = 0;

		// Token: 0x04025E63 RID: 155235
		[Token(Token = "0x4025E63")]
		[NonSerialized]
		public const int MSG_ON_PROGRESS_DETAIL_CLICKED = 1;

		// Token: 0x04025E64 RID: 155236
		[Token(Token = "0x4025E64")]
		[NonSerialized]
		public const int MSG_ON_PROGRESS_DETAIL_HIDE_CLICKED = 2;

		// Token: 0x04025E65 RID: 155237
		[Token(Token = "0x4025E65")]
		[NonSerialized]
		public const int MSG_ON_LONG_TERM_BTN_CLICKED = 3;

		// Token: 0x04025E66 RID: 155238
		[Token(Token = "0x4025E66")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private HomeCheckInGridView _gridView;

		// Token: 0x04025E67 RID: 155239
		[Token(Token = "0x4025E67")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private HomeCheckInCountDownView _countDownView;

		// Token: 0x04025E68 RID: 155240
		[Token(Token = "0x4025E68")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private HomeCheckInProgressGPInfoView _progressGpInfoView;

		// Token: 0x04025E69 RID: 155241
		[Token(Token = "0x4025E69")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private HomeCheckInCommonRewardView _commonRewardView;

		// Token: 0x04025E6A RID: 155242
		[Token(Token = "0x4025E6A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private HomeCheckInProgressGPDetailView _detailView;

		// Token: 0x04025E6B RID: 155243
		[Token(Token = "0x4025E6B")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private HomeCheckInLongTermCheckInView _longTermView;

		// Token: 0x04025E6C RID: 155244
		[Token(Token = "0x4025E6C")]
		[FieldOffset(Offset = "0xA0")]
		private HomeCheckInStateBean m_stateBean;

		// Token: 0x04025E6D RID: 155245
		[Token(Token = "0x4025E6D")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_hasInited;

		// Token: 0x04025E6E RID: 155246
		[Token(Token = "0x4025E6E")]
		[FieldOffset(Offset = "0xA9")]
		private bool m_isItemGained;

		// Token: 0x04025E6F RID: 155247
		[Token(Token = "0x4025E6F")]
		[FieldOffset(Offset = "0xB0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04025E70 RID: 155248
		[Token(Token = "0x4025E70")]
		[FieldOffset(Offset = "0xC0")]
		private int m_dialogInstId;

		// Token: 0x04025E71 RID: 155249
		[Token(Token = "0x4025E71")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04025E72 RID: 155250
		[Token(Token = "0x4025E72")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04025E73 RID: 155251
		[Token(Token = "0x4025E73")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04025E74 RID: 155252
		[Token(Token = "0x4025E74")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04025E75 RID: 155253
		[Token(Token = "0x4025E75")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04025E76 RID: 155254
		[Token(Token = "0x4025E76")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnBackPressed;

		// Token: 0x04025E77 RID: 155255
		[Token(Token = "0x4025E77")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04025E78 RID: 155256
		[Token(Token = "0x4025E78")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SendCheckInRequest;

		// Token: 0x04025E79 RID: 155257
		[Token(Token = "0x4025E79")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x04025E7A RID: 155258
		[Token(Token = "0x4025E7A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnSignInItemClicked;

		// Token: 0x04025E7B RID: 155259
		[Token(Token = "0x4025E7B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SetProgressDetailShownStatus;

		// Token: 0x04025E7C RID: 155260
		[Token(Token = "0x4025E7C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnLongTermBtnClicked;

		// Token: 0x04025E7D RID: 155261
		[Token(Token = "0x4025E7D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
