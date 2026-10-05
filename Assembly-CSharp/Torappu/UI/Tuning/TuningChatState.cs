using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C7A RID: 15482
	[Token(Token = "0x2003C7A")]
	public class TuningChatState : PopupFadeState, IValueMsgReceiver, IHotfixable
	{
		// Token: 0x060182DC RID: 99036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60182DC")]
		[Address(RVA = "0x10ABCC0", Offset = "0x10AA8C0", VA = "0x1810ABCC0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060182DD RID: 99037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182DD")]
		[Address(RVA = "0x10ABF00", Offset = "0x10AAB00", VA = "0x1810ABF00", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060182DE RID: 99038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182DE")]
		[Address(RVA = "0x10ACA00", Offset = "0x10AB600", VA = "0x1810ACA00", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060182DF RID: 99039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182DF")]
		[Address(RVA = "0x10ADC30", Offset = "0x10AC830", VA = "0x1810ADC30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060182E0 RID: 99040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182E0")]
		[Address(RVA = "0x10AF7E0", Offset = "0x10AE3E0", VA = "0x1810AF7E0")]
		private void _PlayEnterAnim()
		{
		}

		// Token: 0x060182E1 RID: 99041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182E1")]
		[Address(RVA = "0x10B06C0", Offset = "0x10AF2C0", VA = "0x1810B06C0")]
		private void _UpdateData(string investId)
		{
		}

		// Token: 0x060182E2 RID: 99042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182E2")]
		[Address(RVA = "0x10ADDF0", Offset = "0x10AC9F0", VA = "0x1810ADDF0")]
		private void _OnBackPress()
		{
		}

		// Token: 0x060182E3 RID: 99043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182E3")]
		[Address(RVA = "0x10AE1F0", Offset = "0x10ACDF0", VA = "0x1810AE1F0")]
		private void _OnDismiss()
		{
		}

		// Token: 0x060182E4 RID: 99044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182E4")]
		[Address(RVA = "0x10ABD20", Offset = "0x10AA920", VA = "0x1810ABD20")]
		public void OnBackPress()
		{
		}

		// Token: 0x060182E5 RID: 99045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182E5")]
		[Address(RVA = "0x10AFEB0", Offset = "0x10AEAB0", VA = "0x1810AFEB0")]
		private void _StartPlayImpl(string storyId, string npcName, int index)
		{
		}

		// Token: 0x060182E6 RID: 99046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182E6")]
		[Address(RVA = "0x10AFA90", Offset = "0x10AE690", VA = "0x1810AFA90")]
		private void _ResetPlayImpl()
		{
		}

		// Token: 0x060182E7 RID: 99047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182E7")]
		[Address(RVA = "0x10AF320", Offset = "0x10ADF20", VA = "0x1810AF320")]
		private void _OnStartPlay()
		{
		}

		// Token: 0x060182E8 RID: 99048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182E8")]
		[Address(RVA = "0x10AEF60", Offset = "0x10ADB60", VA = "0x1810AEF60")]
		private void _OnSelectInvest(string investId)
		{
		}

		// Token: 0x060182E9 RID: 99049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182E9")]
		[Address(RVA = "0x10ADFA0", Offset = "0x10ACBA0", VA = "0x1810ADFA0")]
		private void _OnChatSkip()
		{
		}

		// Token: 0x060182EA RID: 99050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182EA")]
		[Address(RVA = "0x10AE310", Offset = "0x10ACF10", VA = "0x1810AE310")]
		private void _OnHandleNarration(int index)
		{
		}

		// Token: 0x060182EB RID: 99051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182EB")]
		[Address(RVA = "0x10AE740", Offset = "0x10AD340", VA = "0x1810AE740")]
		private void _OnNarrationPlay(int index, string content, string narType)
		{
		}

		// Token: 0x060182EC RID: 99052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182EC")]
		[Address(RVA = "0x10AE670", Offset = "0x10AD270", VA = "0x1810AE670")]
		private void _OnNarrationHandled()
		{
		}

		// Token: 0x060182ED RID: 99053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182ED")]
		[Address(RVA = "0x10AEA90", Offset = "0x10AD690", VA = "0x1810AEA90")]
		private void _OnOpenBackPack()
		{
		}

		// Token: 0x060182EE RID: 99054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182EE")]
		[Address(RVA = "0x10AF510", Offset = "0x10AE110", VA = "0x1810AF510")]
		private void _OnSubmit(int index)
		{
		}

		// Token: 0x060182EF RID: 99055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182EF")]
		[Address(RVA = "0x10AE2A0", Offset = "0x10ACEA0", VA = "0x1810AE2A0")]
		private void _OnFinish()
		{
		}

		// Token: 0x060182F0 RID: 99056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182F0")]
		[Address(RVA = "0x10AEE80", Offset = "0x10ADA80", VA = "0x1810AEE80")]
		private void _OnSelectBagType(string typeId)
		{
		}

		// Token: 0x060182F1 RID: 99057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182F1")]
		[Address(RVA = "0x10AECC0", Offset = "0x10AD8C0", VA = "0x1810AECC0")]
		private void _OnSelectBagProduct(string productId)
		{
		}

		// Token: 0x060182F2 RID: 99058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182F2")]
		[Address(RVA = "0x10AEB30", Offset = "0x10AD730", VA = "0x1810AEB30")]
		private void _OnOpenTuning()
		{
		}

		// Token: 0x060182F3 RID: 99059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182F3")]
		[Address(RVA = "0x10B0490", Offset = "0x10AF090", VA = "0x1810B0490")]
		private void _UpdateBackPack(bool useCacheAnswer, bool isFastMode = false)
		{
		}

		// Token: 0x060182F4 RID: 99060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182F4")]
		[Address(RVA = "0x10AFBF0", Offset = "0x10AE7F0", VA = "0x1810AFBF0")]
		private void _ShowBag(bool isShow)
		{
		}

		// Token: 0x060182F5 RID: 99061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182F5")]
		[Address(RVA = "0x10B0260", Offset = "0x10AEE60", VA = "0x1810B0260")]
		private void _TriggerAudioStart(string musicMainId, string musicSubId)
		{
		}

		// Token: 0x060182F6 RID: 99062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182F6")]
		[Address(RVA = "0x10B03C0", Offset = "0x10AEFC0", VA = "0x1810B03C0")]
		private void _TriggerAudioStop()
		{
		}

		// Token: 0x060182F7 RID: 99063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182F7")]
		private void _HandleService<RespType>(string investId, string productId, Action<RespType> onPreceed) where RespType : TuningChatCommitResponse
		{
		}

		// Token: 0x060182F8 RID: 99064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182F8")]
		[Address(RVA = "0x10ACDC0", Offset = "0x10AB9C0", VA = "0x1810ACDC0")]
		private void _HandleDailyResponse(int index, TuningChatItemViewModel selectedViewModel, TuningChatDailyResponse response)
		{
		}

		// Token: 0x060182F9 RID: 99065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182F9")]
		[Address(RVA = "0x10AD2D0", Offset = "0x10ABED0", VA = "0x1810AD2D0")]
		private void _HandleMajorHiddenResponse(int index, TuningChatItemViewModel selectedViewModel, TuningChatMajorHiddenResponse response)
		{
		}

		// Token: 0x060182FA RID: 99066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60182FA")]
		[Address(RVA = "0x10AF9B0", Offset = "0x10AE5B0", VA = "0x1810AF9B0")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList, Action onConfirm)
		{
			return null;
		}

		// Token: 0x060182FB RID: 99067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182FB")]
		[Address(RVA = "0x10AD7E0", Offset = "0x10AC3E0", VA = "0x1810AD7E0")]
		private void _HandleSuccess(int index, TuningChatItemViewModel selectedViewModel, TuningChatCommitResponse response)
		{
		}

		// Token: 0x060182FC RID: 99068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182FC")]
		[Address(RVA = "0x10ACB90", Offset = "0x10AB790", VA = "0x1810ACB90")]
		private void _DoArchiveTrackTrigger(TuningChatItemViewModel selectedViewModel)
		{
		}

		// Token: 0x060182FD RID: 99069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182FD")]
		[Address(RVA = "0x10AF090", Offset = "0x10ADC90", VA = "0x1810AF090")]
		private void _OnShowDialogConfirm(int index, TuningChatItemViewModel selectedViewModel, TuningChatCommitResponse response)
		{
		}

		// Token: 0x060182FE RID: 99070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182FE")]
		[Address(RVA = "0x10AE390", Offset = "0x10ACF90", VA = "0x1810AE390")]
		private void _OnItemsGained(int index, TuningChatItemViewModel selectedViewModel)
		{
		}

		// Token: 0x060182FF RID: 99071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182FF")]
		[Address(RVA = "0x10ACE80", Offset = "0x10ABA80", VA = "0x1810ACE80")]
		private void _HandleDaily(TuningChatItemViewModel selectedViewModel, TuningChatDailyResponse response)
		{
		}

		// Token: 0x06018300 RID: 99072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018300")]
		[Address(RVA = "0x10AD390", Offset = "0x10ABF90", VA = "0x1810AD390")]
		private void _HandleMajorHidden(TuningChatItemViewModel selectedViewModel, TuningChatMajorHiddenResponse response)
		{
		}

		// Token: 0x06018301 RID: 99073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018301")]
		[Address(RVA = "0x10AFD70", Offset = "0x10AE970", VA = "0x1810AFD70")]
		private void _ShowDialog(TuningChatResultDialog.Options options)
		{
		}

		// Token: 0x06018302 RID: 99074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018302")]
		[Address(RVA = "0x10AE010", Offset = "0x10ACC10", VA = "0x1810AE010")]
		private void _OnDailyFailDialog(string productTypeId, string orcheId, bool openRare)
		{
		}

		// Token: 0x06018303 RID: 99075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018303")]
		[Address(RVA = "0x10AE4C0", Offset = "0x10AD0C0", VA = "0x1810AE4C0")]
		private void _OnMajorHiddenFailDialog(string productId, bool openRare)
		{
		}

		// Token: 0x06018304 RID: 99076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018304")]
		[Address(RVA = "0x10AC1F0", Offset = "0x10AADF0", VA = "0x1810AC1F0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06018305 RID: 99077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018305")]
		[Address(RVA = "0x10B0800", Offset = "0x10AF400", VA = "0x1810B0800")]
		public TuningChatState()
		{
		}

		// Token: 0x06018306 RID: 99078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018306")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06018307 RID: 99079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018307")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0401D6F0 RID: 120560
		[Token(Token = "0x401D6F0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TuningChatController _chatController;

		// Token: 0x0401D6F1 RID: 120561
		[Token(Token = "0x401D6F1")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TuningChatView _chatView;

		// Token: 0x0401D6F2 RID: 120562
		[Token(Token = "0x401D6F2")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TuningChatNarrationView _narrationView;

		// Token: 0x0401D6F3 RID: 120563
		[Token(Token = "0x401D6F3")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x0401D6F4 RID: 120564
		[Token(Token = "0x401D6F4")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0401D6F5 RID: 120565
		[Token(Token = "0x401D6F5")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isInited;

		// Token: 0x0401D6F6 RID: 120566
		[Token(Token = "0x401D6F6")]
		[FieldOffset(Offset = "0xA1")]
		private bool m_isReceiving;

		// Token: 0x0401D6F7 RID: 120567
		[Token(Token = "0x401D6F7")]
		[FieldOffset(Offset = "0xA8")]
		private string m_actId;

		// Token: 0x0401D6F8 RID: 120568
		[Token(Token = "0x401D6F8")]
		[FieldOffset(Offset = "0xB0")]
		private TuningChatProperty m_property;

		// Token: 0x0401D6F9 RID: 120569
		[Token(Token = "0x401D6F9")]
		[FieldOffset(Offset = "0xB8")]
		private TuningProductBagProperty m_bagProperty;

		// Token: 0x0401D6FA RID: 120570
		[Token(Token = "0x401D6FA")]
		[FieldOffset(Offset = "0xC0")]
		private TuningChatStateBean m_stateBean;

		// Token: 0x0401D6FB RID: 120571
		[Token(Token = "0x401D6FB")]
		[FieldOffset(Offset = "0xC8")]
		private Tween m_enterTween;

		// Token: 0x0401D6FC RID: 120572
		[Token(Token = "0x401D6FC")]
		[FieldOffset(Offset = "0xD0")]
		private TuningProductBagViewModel.AnswerParam m_cachedAnswerParam;

		// Token: 0x0401D6FD RID: 120573
		[Token(Token = "0x401D6FD")]
		[NonSerialized]
		public const int MSG_CHAT_SKIP = 1;

		// Token: 0x0401D6FE RID: 120574
		[Token(Token = "0x401D6FE")]
		[NonSerialized]
		public const int MSG_OPEN_BACKPACK = 2;

		// Token: 0x0401D6FF RID: 120575
		[Token(Token = "0x401D6FF")]
		[NonSerialized]
		public const int MSG_SUBMIT = 3;

		// Token: 0x0401D700 RID: 120576
		[Token(Token = "0x401D700")]
		[NonSerialized]
		public const int MSG_FINISH = 4;

		// Token: 0x0401D701 RID: 120577
		[Token(Token = "0x401D701")]
		[NonSerialized]
		public const int MSG_NEXT = 5;

		// Token: 0x0401D702 RID: 120578
		[Token(Token = "0x401D702")]
		[NonSerialized]
		public const int MSG_SELECT_INVEST = 6;

		// Token: 0x0401D703 RID: 120579
		[Token(Token = "0x401D703")]
		[NonSerialized]
		public const int MSG_OPEN_TUNING = 7;

		// Token: 0x0401D704 RID: 120580
		[Token(Token = "0x401D704")]
		[NonSerialized]
		public const int MSG_SELECT_BAG_TYPE = 8;

		// Token: 0x0401D705 RID: 120581
		[Token(Token = "0x401D705")]
		[NonSerialized]
		public const int MSG_SELECT_BAG_PRODUCT = 9;

		// Token: 0x0401D706 RID: 120582
		[Token(Token = "0x401D706")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401D707 RID: 120583
		[Token(Token = "0x401D707")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401D708 RID: 120584
		[Token(Token = "0x401D708")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0401D709 RID: 120585
		[Token(Token = "0x401D709")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D70A RID: 120586
		[Token(Token = "0x401D70A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x0401D70B RID: 120587
		[Token(Token = "0x401D70B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateData;

		// Token: 0x0401D70C RID: 120588
		[Token(Token = "0x401D70C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnBackPress;

		// Token: 0x0401D70D RID: 120589
		[Token(Token = "0x401D70D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnDismiss;

		// Token: 0x0401D70E RID: 120590
		[Token(Token = "0x401D70E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnBackPress;

		// Token: 0x0401D70F RID: 120591
		[Token(Token = "0x401D70F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__StartPlayImpl;

		// Token: 0x0401D710 RID: 120592
		[Token(Token = "0x401D710")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ResetPlayImpl;

		// Token: 0x0401D711 RID: 120593
		[Token(Token = "0x401D711")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnStartPlay;

		// Token: 0x0401D712 RID: 120594
		[Token(Token = "0x401D712")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnSelectInvest;

		// Token: 0x0401D713 RID: 120595
		[Token(Token = "0x401D713")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnChatSkip;

		// Token: 0x0401D714 RID: 120596
		[Token(Token = "0x401D714")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnHandleNarration;

		// Token: 0x0401D715 RID: 120597
		[Token(Token = "0x401D715")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnNarrationPlay;

		// Token: 0x0401D716 RID: 120598
		[Token(Token = "0x401D716")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnNarrationHandled;

		// Token: 0x0401D717 RID: 120599
		[Token(Token = "0x401D717")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnOpenBackPack;

		// Token: 0x0401D718 RID: 120600
		[Token(Token = "0x401D718")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnSubmit;

		// Token: 0x0401D719 RID: 120601
		[Token(Token = "0x401D719")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnFinish;

		// Token: 0x0401D71A RID: 120602
		[Token(Token = "0x401D71A")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnSelectBagType;

		// Token: 0x0401D71B RID: 120603
		[Token(Token = "0x401D71B")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnSelectBagProduct;

		// Token: 0x0401D71C RID: 120604
		[Token(Token = "0x401D71C")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnOpenTuning;

		// Token: 0x0401D71D RID: 120605
		[Token(Token = "0x401D71D")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__UpdateBackPack;

		// Token: 0x0401D71E RID: 120606
		[Token(Token = "0x401D71E")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__ShowBag;

		// Token: 0x0401D71F RID: 120607
		[Token(Token = "0x401D71F")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__TriggerAudioStart;

		// Token: 0x0401D720 RID: 120608
		[Token(Token = "0x401D720")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__TriggerAudioStop;

		// Token: 0x0401D721 RID: 120609
		[Token(Token = "0x401D721")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__HandleService;

		// Token: 0x0401D722 RID: 120610
		[Token(Token = "0x401D722")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__HandleDailyResponse;

		// Token: 0x0401D723 RID: 120611
		[Token(Token = "0x401D723")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__HandleMajorHiddenResponse;

		// Token: 0x0401D724 RID: 120612
		[Token(Token = "0x401D724")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0401D725 RID: 120613
		[Token(Token = "0x401D725")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__HandleSuccess;

		// Token: 0x0401D726 RID: 120614
		[Token(Token = "0x401D726")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__DoArchiveTrackTrigger;

		// Token: 0x0401D727 RID: 120615
		[Token(Token = "0x401D727")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__OnShowDialogConfirm;

		// Token: 0x0401D728 RID: 120616
		[Token(Token = "0x401D728")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__OnItemsGained;

		// Token: 0x0401D729 RID: 120617
		[Token(Token = "0x401D729")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__HandleDaily;

		// Token: 0x0401D72A RID: 120618
		[Token(Token = "0x401D72A")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__HandleMajorHidden;

		// Token: 0x0401D72B RID: 120619
		[Token(Token = "0x401D72B")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__ShowDialog;

		// Token: 0x0401D72C RID: 120620
		[Token(Token = "0x401D72C")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__OnDailyFailDialog;

		// Token: 0x0401D72D RID: 120621
		[Token(Token = "0x401D72D")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__OnMajorHiddenFailDialog;

		// Token: 0x0401D72E RID: 120622
		[Token(Token = "0x401D72E")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0401D72F RID: 120623
		[Token(Token = "0x401D72F")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
