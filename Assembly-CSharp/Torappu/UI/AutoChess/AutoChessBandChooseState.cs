using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006294 RID: 25236
	[Token(Token = "0x2006294")]
	public class AutoChessBandChooseState : AutoChessPrepareBaseState, IValueMsgReceiver, IAutoChessPrepareStateHandler, IHotfixable, ICompDialogCallBack
	{
		// Token: 0x06024628 RID: 149032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024628")]
		[Address(RVA = "0x1F25110", Offset = "0x1F23D10", VA = "0x181F25110", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06024629 RID: 149033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024629")]
		[Address(RVA = "0x1F25E60", Offset = "0x1F24A60", VA = "0x181F25E60", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0602462A RID: 149034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602462A")]
		[Address(RVA = "0x1F25B40", Offset = "0x1F24740", VA = "0x181F25B40", Slot = "31")]
		protected override void OnStateEnter()
		{
		}

		// Token: 0x0602462B RID: 149035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602462B")]
		[Address(RVA = "0x1F255D0", Offset = "0x1F241D0", VA = "0x181F255D0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0602462C RID: 149036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602462C")]
		[Address(RVA = "0x1F25220", Offset = "0x1F23E20", VA = "0x181F25220", Slot = "33")]
		public void OnDataChanged(AutoChessPrepareModel prepareModel)
		{
		}

		// Token: 0x0602462D RID: 149037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602462D")]
		[Address(RVA = "0x1F25520", Offset = "0x1F24120", VA = "0x181F25520")]
		private void OnDestroy()
		{
		}

		// Token: 0x0602462E RID: 149038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602462E")]
		[Address(RVA = "0x1F25670", Offset = "0x1F24270", VA = "0x181F25670", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602462F RID: 149039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602462F")]
		[Address(RVA = "0x1F25FC0", Offset = "0x1F24BC0", VA = "0x181F25FC0")]
		private void _EventOnBandBtnClicked(string bandId)
		{
		}

		// Token: 0x06024630 RID: 149040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024630")]
		[Address(RVA = "0x1F26240", Offset = "0x1F24E40", VA = "0x181F26240")]
		private void _EventOnDetailBtnClicked()
		{
		}

		// Token: 0x06024631 RID: 149041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024631")]
		[Address(RVA = "0x1F268D0", Offset = "0x1F254D0", VA = "0x181F268D0")]
		private void _EventOnSkipBtnClicked()
		{
		}

		// Token: 0x06024632 RID: 149042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024632")]
		[Address(RVA = "0x1F26460", Offset = "0x1F25060", VA = "0x181F26460")]
		private void _EventOnSelectBtnClicked()
		{
		}

		// Token: 0x06024633 RID: 149043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024633")]
		[Address(RVA = "0x1F26640", Offset = "0x1F25240", VA = "0x181F26640")]
		private void _EventOnSelectedDetailBtnClicked(int index)
		{
		}

		// Token: 0x06024634 RID: 149044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024634")]
		[Address(RVA = "0x1F269A0", Offset = "0x1F255A0", VA = "0x181F269A0")]
		private void _EventOnTutorialFocusItem()
		{
		}

		// Token: 0x06024635 RID: 149045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024635")]
		[Address(RVA = "0x1F272D0", Offset = "0x1F25ED0", VA = "0x181F272D0")]
		private IEnumerator _WaitBandFocusAndSendSignal()
		{
			return null;
		}

		// Token: 0x06024636 RID: 149046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024636")]
		[Address(RVA = "0x1F25170", Offset = "0x1F23D70", VA = "0x181F25170", Slot = "34")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06024637 RID: 149047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024637")]
		[Address(RVA = "0x1F27240", Offset = "0x1F25E40", VA = "0x181F27240")]
		private void _TrySendAVGSignal()
		{
		}

		// Token: 0x06024638 RID: 149048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024638")]
		[Address(RVA = "0x1F26B20", Offset = "0x1F25720", VA = "0x181F26B20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024639 RID: 149049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024639")]
		[Address(RVA = "0x1F27010", Offset = "0x1F25C10", VA = "0x181F27010")]
		private void _OnSkipBtnPreClicked()
		{
		}

		// Token: 0x0602463A RID: 149050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602463A")]
		[Address(RVA = "0x1F26EF0", Offset = "0x1F25AF0", VA = "0x181F26EF0")]
		private void _OnSkipBtnClicked()
		{
		}

		// Token: 0x0602463B RID: 149051 RVA: 0x000C4110 File Offset: 0x000C2310
		[Token(Token = "0x602463B")]
		[Address(RVA = "0x1F270B0", Offset = "0x1F25CB0", VA = "0x181F270B0")]
		private bool _OpenSelfTurnDialog()
		{
			return default(bool);
		}

		// Token: 0x0602463C RID: 149052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602463C")]
		[Address(RVA = "0x1F27380", Offset = "0x1F25F80", VA = "0x181F27380")]
		public AutoChessBandChooseState()
		{
		}

		// Token: 0x0602463E RID: 149054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602463E")]
		[Address(RVA = "0x1089D20", Offset = "0x1088920", VA = "0x181089D20")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0602463F RID: 149055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602463F")]
		[Address(RVA = "0x1F25FB0", Offset = "0x1F24BB0", VA = "0x181F25FB0")]
		private void <>xLuaBaseProxy_OnStateEnter()
		{
		}

		// Token: 0x06024640 RID: 149056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024640")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x040329DF RID: 207327
		[Token(Token = "0x40329DF")]
		[NonSerialized]
		public const int ON_BAND_BTN_CLICKED = 0;

		// Token: 0x040329E0 RID: 207328
		[Token(Token = "0x40329E0")]
		[NonSerialized]
		public const int ON_DETAIL_BTN_CLICKED = 1;

		// Token: 0x040329E1 RID: 207329
		[Token(Token = "0x40329E1")]
		[NonSerialized]
		public const int ON_SKIP_BTN_CLICKED = 2;

		// Token: 0x040329E2 RID: 207330
		[Token(Token = "0x40329E2")]
		[NonSerialized]
		public const int ON_SELECT_BTN_CLICKED = 3;

		// Token: 0x040329E3 RID: 207331
		[Token(Token = "0x40329E3")]
		[NonSerialized]
		public const int ON_SELECTED_DETAIL_BTN_CLICKED = 4;

		// Token: 0x040329E4 RID: 207332
		[Token(Token = "0x40329E4")]
		[NonSerialized]
		public const int ON_FOCUS_ITEM = 5;

		// Token: 0x040329E5 RID: 207333
		[Token(Token = "0x40329E5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AutoChessBandChooseBandListView _bandListView;

		// Token: 0x040329E6 RID: 207334
		[Token(Token = "0x40329E6")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AutoChessBandChooseBandDetailView[] _detailView;

		// Token: 0x040329E7 RID: 207335
		[Token(Token = "0x40329E7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AutoChessBandChoosePlayerListView _playerView;

		// Token: 0x040329E8 RID: 207336
		[Token(Token = "0x40329E8")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AutoChessBandChooseTopBarView _topBarView;

		// Token: 0x040329E9 RID: 207337
		[Token(Token = "0x40329E9")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private TwoPhaseButtonWidget _skipBtn;

		// Token: 0x040329EA RID: 207338
		[Token(Token = "0x40329EA")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIAnimationLocation _entryAnim;

		// Token: 0x040329EB RID: 207339
		[Token(Token = "0x40329EB")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UIAnimationLocation _selectSwitchAnim;

		// Token: 0x040329EC RID: 207340
		[Token(Token = "0x40329EC")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UIAnimationLocation _selectedAnim;

		// Token: 0x040329ED RID: 207341
		[Token(Token = "0x40329ED")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private AutoChessBandChooseAVGAdapter _tutorialAdapter;

		// Token: 0x040329EE RID: 207342
		[Token(Token = "0x40329EE")]
		[FieldOffset(Offset = "0xE0")]
		private AutoChessBandChooseStateBean m_stateBean;

		// Token: 0x040329EF RID: 207343
		[Token(Token = "0x40329EF")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_hasInited;

		// Token: 0x040329F0 RID: 207344
		[Token(Token = "0x40329F0")]
		[FieldOffset(Offset = "0xF0")]
		private UISwitchTween m_switchTween;

		// Token: 0x040329F1 RID: 207345
		[Token(Token = "0x40329F1")]
		[FieldOffset(Offset = "0xF8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040329F2 RID: 207346
		[Token(Token = "0x40329F2")]
		[FieldOffset(Offset = "0x108")]
		private int m_selfDialogInstId;

		// Token: 0x040329F3 RID: 207347
		[Token(Token = "0x40329F3")]
		[FieldOffset(Offset = "0x110")]
		private AutoChessStageInfoGroupViewModel.Input m_cachedInput;

		// Token: 0x040329F4 RID: 207348
		[Token(Token = "0x40329F4")]
		[FieldOffset(Offset = "0x118")]
		private AutoChessBandChoosePlayerStatus m_cachedStatus;

		// Token: 0x040329F5 RID: 207349
		[Token(Token = "0x40329F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040329F6 RID: 207350
		[Token(Token = "0x40329F6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x040329F7 RID: 207351
		[Token(Token = "0x40329F7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStateEnter;

		// Token: 0x040329F8 RID: 207352
		[Token(Token = "0x40329F8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x040329F9 RID: 207353
		[Token(Token = "0x40329F9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDataChanged;

		// Token: 0x040329FA RID: 207354
		[Token(Token = "0x40329FA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040329FB RID: 207355
		[Token(Token = "0x40329FB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040329FC RID: 207356
		[Token(Token = "0x40329FC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EventOnBandBtnClicked;

		// Token: 0x040329FD RID: 207357
		[Token(Token = "0x40329FD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EventOnDetailBtnClicked;

		// Token: 0x040329FE RID: 207358
		[Token(Token = "0x40329FE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EventOnSkipBtnClicked;

		// Token: 0x040329FF RID: 207359
		[Token(Token = "0x40329FF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__EventOnSelectBtnClicked;

		// Token: 0x04032A00 RID: 207360
		[Token(Token = "0x4032A00")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EventOnSelectedDetailBtnClicked;

		// Token: 0x04032A01 RID: 207361
		[Token(Token = "0x4032A01")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__EventOnTutorialFocusItem;

		// Token: 0x04032A02 RID: 207362
		[Token(Token = "0x4032A02")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__WaitBandFocusAndSendSignal;

		// Token: 0x04032A03 RID: 207363
		[Token(Token = "0x4032A03")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04032A04 RID: 207364
		[Token(Token = "0x4032A04")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__TrySendAVGSignal;

		// Token: 0x04032A05 RID: 207365
		[Token(Token = "0x4032A05")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032A06 RID: 207366
		[Token(Token = "0x4032A06")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnSkipBtnPreClicked;

		// Token: 0x04032A07 RID: 207367
		[Token(Token = "0x4032A07")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnSkipBtnClicked;

		// Token: 0x04032A08 RID: 207368
		[Token(Token = "0x4032A08")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OpenSelfTurnDialog;

		// Token: 0x04032A09 RID: 207369
		[Token(Token = "0x4032A09")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
