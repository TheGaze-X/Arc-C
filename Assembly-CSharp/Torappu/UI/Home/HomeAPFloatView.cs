using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.ItemRepo;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BD2 RID: 19410
	[Token(Token = "0x2004BD2")]
	public class HomeAPFloatView : MonoBehaviour, ITimeWatcher, IHotfixable
	{
		// Token: 0x0601D2BC RID: 119484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2BC")]
		[Address(RVA = "0x16B9700", Offset = "0x16B8300", VA = "0x1816B9700", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x0601D2BD RID: 119485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2BD")]
		[Address(RVA = "0x16B92F0", Offset = "0x16B7EF0", VA = "0x1816B92F0")]
		public void Show()
		{
		}

		// Token: 0x0601D2BE RID: 119486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2BE")]
		[Address(RVA = "0x16B8500", Offset = "0x16B7100", VA = "0x1816B8500")]
		public void OnSelectTag(bool isApItem)
		{
		}

		// Token: 0x0601D2BF RID: 119487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2BF")]
		[Address(RVA = "0x16B8A90", Offset = "0x16B7690", VA = "0x1816B8A90")]
		public void RefreshIfActive()
		{
		}

		// Token: 0x0601D2C0 RID: 119488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2C0")]
		[Address(RVA = "0x16B8C60", Offset = "0x16B7860", VA = "0x1816B8C60")]
		private void RenderDiamond()
		{
		}

		// Token: 0x0601D2C1 RID: 119489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2C1")]
		[Address(RVA = "0x16B7FA0", Offset = "0x16B6BA0", VA = "0x1816B7FA0")]
		private void CleanDiamond()
		{
		}

		// Token: 0x0601D2C2 RID: 119490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2C2")]
		[Address(RVA = "0x16B8B10", Offset = "0x16B7710", VA = "0x1816B8B10")]
		private void RenderApItem()
		{
		}

		// Token: 0x0601D2C3 RID: 119491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2C3")]
		[Address(RVA = "0x16B7F00", Offset = "0x16B6B00", VA = "0x1816B7F00")]
		private void CleanApItem()
		{
		}

		// Token: 0x0601D2C4 RID: 119492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2C4")]
		[Address(RVA = "0x16B8960", Offset = "0x16B7560", VA = "0x1816B8960")]
		public void OpenShopPage()
		{
		}

		// Token: 0x0601D2C5 RID: 119493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2C5")]
		[Address(RVA = "0x16B8050", Offset = "0x16B6C50", VA = "0x1816B8050")]
		public void Dismiss()
		{
		}

		// Token: 0x0601D2C6 RID: 119494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2C6")]
		[Address(RVA = "0x16B9930", Offset = "0x16B8530", VA = "0x1816B9930", Slot = "4")]
		public void UpdateTime(float deltaTime)
		{
		}

		// Token: 0x0601D2C7 RID: 119495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2C7")]
		[Address(RVA = "0x16B8310", Offset = "0x16B6F10", VA = "0x1816B8310")]
		public void EventOnConfirmBuyClick()
		{
		}

		// Token: 0x0601D2C8 RID: 119496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2C8")]
		[Address(RVA = "0x16B8290", Offset = "0x16B6E90", VA = "0x1816B8290")]
		public void EventOnCancelBuyClick()
		{
		}

		// Token: 0x0601D2C9 RID: 119497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2C9")]
		[Address(RVA = "0x16B8DE0", Offset = "0x16B79E0", VA = "0x1816B8DE0")]
		public void SendUseApItemService(List<UIItemViewModel> itemViewModelList)
		{
		}

		// Token: 0x0601D2CA RID: 119498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D2CA")]
		[Address(RVA = "0x16B89E0", Offset = "0x16B75E0", VA = "0x1816B89E0")]
		public static IEnumerator ReceiveItemsCoroutine(List<ItemGet> items)
		{
			return null;
		}

		// Token: 0x0601D2CB RID: 119499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2CB")]
		[Address(RVA = "0x16B9D00", Offset = "0x16B8900", VA = "0x1816B9D00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D2CC RID: 119500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2CC")]
		[Address(RVA = "0x16B9F30", Offset = "0x16B8B30", VA = "0x1816B9F30")]
		private void _SendBuyApService()
		{
		}

		// Token: 0x0601D2CD RID: 119501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2CD")]
		[Address(RVA = "0x16B9DE0", Offset = "0x16B89E0", VA = "0x1816B9DE0")]
		private void _OnBuyApSuccess(BuyApResponse response)
		{
		}

		// Token: 0x0601D2CE RID: 119502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D2CE")]
		[Address(RVA = "0x16B9C00", Offset = "0x16B8800", VA = "0x1816B9C00")]
		private ActionPointViewModel _GetApModel()
		{
			return null;
		}

		// Token: 0x0601D2CF RID: 119503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D2CF")]
		[Address(RVA = "0x16BA160", Offset = "0x16B8D60", VA = "0x1816BA160")]
		public HomeAPFloatView()
		{
		}

		// Token: 0x0402647D RID: 156797
		[Token(Token = "0x402647D")]
		public const float UPDATE_INTERVAL = 0.23f;

		// Token: 0x0402647E RID: 156798
		[Token(Token = "0x402647E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textApCountDown;

		// Token: 0x0402647F RID: 156799
		[Token(Token = "0x402647F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _countDownDesc;

		// Token: 0x04026480 RID: 156800
		[Token(Token = "0x4026480")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _showAnimation;

		// Token: 0x04026481 RID: 156801
		[Token(Token = "0x4026481")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UnityEvent _eventBuyApFinish;

		// Token: 0x04026482 RID: 156802
		[Token(Token = "0x4026482")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TwoStateToggle _useApItemState;

		// Token: 0x04026483 RID: 156803
		[Token(Token = "0x4026483")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TwoStateToggle _useDiamondState;

		// Token: 0x04026484 RID: 156804
		[Token(Token = "0x4026484")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private HomeAPUseDiamondView _useDiamondView;

		// Token: 0x04026485 RID: 156805
		[Token(Token = "0x4026485")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _noDiamondView;

		// Token: 0x04026486 RID: 156806
		[Token(Token = "0x4026486")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _noTimesView;

		// Token: 0x04026487 RID: 156807
		[Token(Token = "0x4026487")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _noApItemView;

		// Token: 0x04026488 RID: 156808
		[Token(Token = "0x4026488")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private HomeAPUseApItemView _useApItemView;

		// Token: 0x04026489 RID: 156809
		[Token(Token = "0x4026489")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text[] _textsUseDiamond;

		// Token: 0x0402648A RID: 156810
		[Token(Token = "0x402648A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ItemRepoActionPointViewModelWithBuyApCount _apProperty;

		// Token: 0x0402648B RID: 156811
		[Token(Token = "0x402648B")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isShow;

		// Token: 0x0402648C RID: 156812
		[Token(Token = "0x402648C")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_showTweener;

		// Token: 0x0402648D RID: 156813
		[Token(Token = "0x402648D")]
		[FieldOffset(Offset = "0x98")]
		private long m_remainSeconds;

		// Token: 0x0402648E RID: 156814
		[Token(Token = "0x402648E")]
		[FieldOffset(Offset = "0xA0")]
		private float m_timeAccum;

		// Token: 0x0402648F RID: 156815
		[Token(Token = "0x402648F")]
		[FieldOffset(Offset = "0xA8")]
		private ActionPointViewModel m_apModel;

		// Token: 0x04026490 RID: 156816
		[Token(Token = "0x4026490")]
		[FieldOffset(Offset = "0xB0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04026491 RID: 156817
		[Token(Token = "0x4026491")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_isInited;

		// Token: 0x04026492 RID: 156818
		[Token(Token = "0x4026492")]
		[FieldOffset(Offset = "0xC1")]
		private bool m_isApItemFlag;

		// Token: 0x04026493 RID: 156819
		[Token(Token = "0x4026493")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04026494 RID: 156820
		[Token(Token = "0x4026494")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04026495 RID: 156821
		[Token(Token = "0x4026495")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnSelectTag;

		// Token: 0x04026496 RID: 156822
		[Token(Token = "0x4026496")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RefreshIfActive;

		// Token: 0x04026497 RID: 156823
		[Token(Token = "0x4026497")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RenderDiamond;

		// Token: 0x04026498 RID: 156824
		[Token(Token = "0x4026498")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CleanDiamond;

		// Token: 0x04026499 RID: 156825
		[Token(Token = "0x4026499")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RenderApItem;

		// Token: 0x0402649A RID: 156826
		[Token(Token = "0x402649A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CleanApItem;

		// Token: 0x0402649B RID: 156827
		[Token(Token = "0x402649B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OpenShopPage;

		// Token: 0x0402649C RID: 156828
		[Token(Token = "0x402649C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Dismiss;

		// Token: 0x0402649D RID: 156829
		[Token(Token = "0x402649D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x0402649E RID: 156830
		[Token(Token = "0x402649E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnConfirmBuyClick;

		// Token: 0x0402649F RID: 156831
		[Token(Token = "0x402649F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnCancelBuyClick;

		// Token: 0x040264A0 RID: 156832
		[Token(Token = "0x40264A0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SendUseApItemService;

		// Token: 0x040264A1 RID: 156833
		[Token(Token = "0x40264A1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ReceiveItemsCoroutine;

		// Token: 0x040264A2 RID: 156834
		[Token(Token = "0x40264A2")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040264A3 RID: 156835
		[Token(Token = "0x40264A3")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__SendBuyApService;

		// Token: 0x040264A4 RID: 156836
		[Token(Token = "0x40264A4")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnBuyApSuccess;

		// Token: 0x040264A5 RID: 156837
		[Token(Token = "0x40264A5")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GetApModel;

		// Token: 0x040264A6 RID: 156838
		[Token(Token = "0x40264A6")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
