using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CE2 RID: 15586
	[Token(Token = "0x2003CE2")]
	public class TuningProductState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x060184C1 RID: 99521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60184C1")]
		[Address(RVA = "0x10CD5C0", Offset = "0x10CC1C0", VA = "0x1810CD5C0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060184C2 RID: 99522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184C2")]
		[Address(RVA = "0x10CD620", Offset = "0x10CC220", VA = "0x1810CD620", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060184C3 RID: 99523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184C3")]
		[Address(RVA = "0x10CE090", Offset = "0x10CCC90", VA = "0x1810CE090", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060184C4 RID: 99524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184C4")]
		[Address(RVA = "0x10CD920", Offset = "0x10CC520", VA = "0x1810CD920", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x060184C5 RID: 99525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60184C5")]
		[Address(RVA = "0x10CE330", Offset = "0x10CCF30", VA = "0x1810CE330", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x060184C6 RID: 99526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60184C6")]
		[Address(RVA = "0x10CE1D0", Offset = "0x10CCDD0", VA = "0x1810CE1D0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x060184C7 RID: 99527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184C7")]
		[Address(RVA = "0x10CDA00", Offset = "0x10CC600", VA = "0x1810CDA00", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060184C8 RID: 99528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184C8")]
		[Address(RVA = "0x10CE680", Offset = "0x10CD280", VA = "0x1810CE680")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060184C9 RID: 99529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184C9")]
		[Address(RVA = "0x10CF670", Offset = "0x10CE270", VA = "0x1810CF670")]
		private void _TryConsumeGuidebook()
		{
		}

		// Token: 0x060184CA RID: 99530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184CA")]
		[Address(RVA = "0x10CEB90", Offset = "0x10CD790", VA = "0x1810CEB90")]
		private void _PlayCurMusic(bool isMainMusicFromStart)
		{
		}

		// Token: 0x060184CB RID: 99531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184CB")]
		[Address(RVA = "0x10CF120", Offset = "0x10CDD20", VA = "0x1810CF120")]
		private void _SelectFrag(string selectFragId)
		{
		}

		// Token: 0x060184CC RID: 99532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184CC")]
		[Address(RVA = "0x10CF2B0", Offset = "0x10CDEB0", VA = "0x1810CF2B0")]
		private void _SelectOrche(string selectOrcheId)
		{
		}

		// Token: 0x060184CD RID: 99533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184CD")]
		[Address(RVA = "0x10CE560", Offset = "0x10CD160", VA = "0x1810CE560")]
		private void _ClearAllFrag()
		{
		}

		// Token: 0x060184CE RID: 99534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184CE")]
		[Address(RVA = "0x10CE820", Offset = "0x10CD420", VA = "0x1810CE820")]
		private void _NextStep()
		{
		}

		// Token: 0x060184CF RID: 99535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184CF")]
		[Address(RVA = "0x10CE480", Offset = "0x10CD080", VA = "0x1810CE480")]
		private void _BackSelectFrag()
		{
		}

		// Token: 0x060184D0 RID: 99536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184D0")]
		[Address(RVA = "0x10CF5C0", Offset = "0x10CE1C0", VA = "0x1810CF5C0")]
		private void _TransToPlayState()
		{
		}

		// Token: 0x060184D1 RID: 99537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184D1")]
		[Address(RVA = "0x10CF500", Offset = "0x10CE100", VA = "0x1810CF500")]
		private void _TransToBagState()
		{
		}

		// Token: 0x060184D2 RID: 99538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184D2")]
		[Address(RVA = "0x10CF3F0", Offset = "0x10CDFF0", VA = "0x1810CF3F0")]
		private void _TransSelectOrche(TuningProductViewModel model)
		{
		}

		// Token: 0x060184D3 RID: 99539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184D3")]
		[Address(RVA = "0x10CED70", Offset = "0x10CD970", VA = "0x1810CED70")]
		private void _ProductMusic()
		{
		}

		// Token: 0x060184D4 RID: 99540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184D4")]
		[Address(RVA = "0x10CE9D0", Offset = "0x10CD5D0", VA = "0x1810CE9D0")]
		private void _OnBackBtnPressed()
		{
		}

		// Token: 0x060184D5 RID: 99541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184D5")]
		[Address(RVA = "0x10CEA70", Offset = "0x10CD670", VA = "0x1810CEA70")]
		private void _OnTransToConfirmState(IStateBean stateBean)
		{
		}

		// Token: 0x060184D6 RID: 99542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184D6")]
		[Address(RVA = "0x10CF6F0", Offset = "0x10CE2F0", VA = "0x1810CF6F0")]
		public TuningProductState()
		{
		}

		// Token: 0x060184D8 RID: 99544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184D8")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060184D9 RID: 99545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184D9")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x060184DA RID: 99546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184DA")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x060184DB RID: 99547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60184DB")]
		[Address(RVA = "0x1089D20", Offset = "0x1088920", VA = "0x181089D20")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x060184DC RID: 99548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60184DC")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0401DACB RID: 121547
		[Token(Token = "0x401DACB")]
		private const string GUIDE_BOOK_SUB_SIGNAL = "product";

		// Token: 0x0401DACC RID: 121548
		[Token(Token = "0x401DACC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TuningProductMenuView _menuView;

		// Token: 0x0401DACD RID: 121549
		[Token(Token = "0x401DACD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TuningProductView _productView;

		// Token: 0x0401DACE RID: 121550
		[Token(Token = "0x401DACE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _entryAnimLocation;

		// Token: 0x0401DACF RID: 121551
		[Token(Token = "0x401DACF")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0401DAD0 RID: 121552
		[Token(Token = "0x401DAD0")]
		[NonSerialized]
		public const int SELECT_FRAG = 0;

		// Token: 0x0401DAD1 RID: 121553
		[Token(Token = "0x401DAD1")]
		[NonSerialized]
		public const int CLEAR_ALL_FRAG = 1;

		// Token: 0x0401DAD2 RID: 121554
		[Token(Token = "0x401DAD2")]
		[NonSerialized]
		public const int NEXT_STEP = 2;

		// Token: 0x0401DAD3 RID: 121555
		[Token(Token = "0x401DAD3")]
		[NonSerialized]
		public const int BACK_SELECT_FRAG = 3;

		// Token: 0x0401DAD4 RID: 121556
		[Token(Token = "0x401DAD4")]
		[NonSerialized]
		public const int TRANS_TO_PLAY_STATE = 4;

		// Token: 0x0401DAD5 RID: 121557
		[Token(Token = "0x401DAD5")]
		[NonSerialized]
		public const int TRANS_TO_BAG_STATE = 5;

		// Token: 0x0401DAD6 RID: 121558
		[Token(Token = "0x401DAD6")]
		[FieldOffset(Offset = "0x98")]
		private TuningProductStateBean m_stateBean;

		// Token: 0x0401DAD7 RID: 121559
		[Token(Token = "0x401DAD7")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_entryTween;

		// Token: 0x0401DAD8 RID: 121560
		[Token(Token = "0x401DAD8")]
		[FieldOffset(Offset = "0xA8")]
		private string m_actId;

		// Token: 0x0401DAD9 RID: 121561
		[Token(Token = "0x401DAD9")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_isInited;

		// Token: 0x0401DADA RID: 121562
		[Token(Token = "0x401DADA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401DADB RID: 121563
		[Token(Token = "0x401DADB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401DADC RID: 121564
		[Token(Token = "0x401DADC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0401DADD RID: 121565
		[Token(Token = "0x401DADD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0401DADE RID: 121566
		[Token(Token = "0x401DADE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0401DADF RID: 121567
		[Token(Token = "0x401DADF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0401DAE0 RID: 121568
		[Token(Token = "0x401DAE0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0401DAE1 RID: 121569
		[Token(Token = "0x401DAE1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401DAE2 RID: 121570
		[Token(Token = "0x401DAE2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TryConsumeGuidebook;

		// Token: 0x0401DAE3 RID: 121571
		[Token(Token = "0x401DAE3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__PlayCurMusic;

		// Token: 0x0401DAE4 RID: 121572
		[Token(Token = "0x401DAE4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SelectFrag;

		// Token: 0x0401DAE5 RID: 121573
		[Token(Token = "0x401DAE5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SelectOrche;

		// Token: 0x0401DAE6 RID: 121574
		[Token(Token = "0x401DAE6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ClearAllFrag;

		// Token: 0x0401DAE7 RID: 121575
		[Token(Token = "0x401DAE7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__NextStep;

		// Token: 0x0401DAE8 RID: 121576
		[Token(Token = "0x401DAE8")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__BackSelectFrag;

		// Token: 0x0401DAE9 RID: 121577
		[Token(Token = "0x401DAE9")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__TransToPlayState;

		// Token: 0x0401DAEA RID: 121578
		[Token(Token = "0x401DAEA")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__TransToBagState;

		// Token: 0x0401DAEB RID: 121579
		[Token(Token = "0x401DAEB")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__TransSelectOrche;

		// Token: 0x0401DAEC RID: 121580
		[Token(Token = "0x401DAEC")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ProductMusic;

		// Token: 0x0401DAED RID: 121581
		[Token(Token = "0x401DAED")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnBackBtnPressed;

		// Token: 0x0401DAEE RID: 121582
		[Token(Token = "0x401DAEE")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnTransToConfirmState;

		// Token: 0x0401DAEF RID: 121583
		[Token(Token = "0x401DAEF")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
