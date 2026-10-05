using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007931 RID: 31025
	[Token(Token = "0x2007931")]
	public class Act1ArcadeBadgeBookState : UIPopupState, IValueMsgReceiver, ICompDialogCallBack
	{
		// Token: 0x0602B874 RID: 178292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B874")]
		[Address(RVA = "0x276DA00", Offset = "0x276C600", VA = "0x18276DA00", Slot = "29")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602B875 RID: 178293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B875")]
		[Address(RVA = "0x276D410", Offset = "0x276C010", VA = "0x18276D410", Slot = "30")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0602B876 RID: 178294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B876")]
		[Address(RVA = "0x276E620", Offset = "0x276D220", VA = "0x18276E620")]
		private void _OnOpenDetailEvent(ValueBundle msg)
		{
		}

		// Token: 0x0602B877 RID: 178295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B877")]
		[Address(RVA = "0x276E920", Offset = "0x276D520", VA = "0x18276E920")]
		private void _OnOpenShareEvent()
		{
		}

		// Token: 0x0602B878 RID: 178296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B878")]
		[Address(RVA = "0x276EC70", Offset = "0x276D870", VA = "0x18276EC70")]
		private void _OnSwitchLayoutEvent()
		{
		}

		// Token: 0x0602B879 RID: 178297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B879")]
		[Address(RVA = "0x276D3B0", Offset = "0x276BFB0", VA = "0x18276D3B0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602B87A RID: 178298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B87A")]
		[Address(RVA = "0x276E290", Offset = "0x276CE90", VA = "0x18276E290")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B87B RID: 178299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B87B")]
		[Address(RVA = "0x276D770", Offset = "0x276C370", VA = "0x18276D770", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602B87C RID: 178300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B87C")]
		[Address(RVA = "0x276E580", Offset = "0x276D180", VA = "0x18276E580")]
		private void _OnClickBack()
		{
		}

		// Token: 0x0602B87D RID: 178301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B87D")]
		[Address(RVA = "0x276DFD0", Offset = "0x276CBD0", VA = "0x18276DFD0")]
		private void _FocusZoneBadgeIfNeed()
		{
		}

		// Token: 0x0602B87E RID: 178302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B87E")]
		[Address(RVA = "0x276DF10", Offset = "0x276CB10", VA = "0x18276DF10")]
		private IEnumerator _FocusZoneBadgeCoroutine(int index)
		{
			return null;
		}

		// Token: 0x0602B87F RID: 178303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B87F")]
		[Address(RVA = "0x276DC90", Offset = "0x276C890", VA = "0x18276DC90", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0602B880 RID: 178304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B880")]
		[Address(RVA = "0x276D500", Offset = "0x276C100", VA = "0x18276D500", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0602B881 RID: 178305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B881")]
		[Address(RVA = "0x276DDD0", Offset = "0x276C9D0", VA = "0x18276DDD0", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0602B882 RID: 178306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B882")]
		[Address(RVA = "0x276D640", Offset = "0x276C240", VA = "0x18276D640", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0602B883 RID: 178307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B883")]
		[Address(RVA = "0x276EE10", Offset = "0x276DA10", VA = "0x18276EE10")]
		public Act1ArcadeBadgeBookState()
		{
		}

		// Token: 0x0602B884 RID: 178308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B884")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403EF21 RID: 257825
		[Token(Token = "0x403EF21")]
		private const float FADE_DURATION = 0.23f;

		// Token: 0x0403EF22 RID: 257826
		[Token(Token = "0x403EF22")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Act1ArcadeBadgeBookView _badgeBookView;

		// Token: 0x0403EF23 RID: 257827
		[Token(Token = "0x403EF23")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _rootGroup;

		// Token: 0x0403EF24 RID: 257828
		[Token(Token = "0x403EF24")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _inAnimationLocation;

		// Token: 0x0403EF25 RID: 257829
		[Token(Token = "0x403EF25")]
		[FieldOffset(Offset = "0x80")]
		private readonly Act1ArcadeBadgeBookStateBean m_stateBean;

		// Token: 0x0403EF26 RID: 257830
		[Token(Token = "0x403EF26")]
		[FieldOffset(Offset = "0x88")]
		private readonly Act1ArcadeBadgeBookProperty m_property;

		// Token: 0x0403EF27 RID: 257831
		[Token(Token = "0x403EF27")]
		[FieldOffset(Offset = "0x90")]
		private Coroutine m_focusCoroutine;

		// Token: 0x0403EF28 RID: 257832
		[Token(Token = "0x403EF28")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x0403EF29 RID: 257833
		[Token(Token = "0x403EF29")]
		[FieldOffset(Offset = "0xA0")]
		private AnimationSwitchTween m_inTween;

		// Token: 0x0403EF2A RID: 257834
		[Token(Token = "0x403EF2A")]
		[FieldOffset(Offset = "0xA8")]
		private int m_detailDialogInst;

		// Token: 0x0403EF2B RID: 257835
		[Token(Token = "0x403EF2B")]
		[NonSerialized]
		public const int OPEN_DETAIL_EVENT = 0;

		// Token: 0x0403EF2C RID: 257836
		[Token(Token = "0x403EF2C")]
		[NonSerialized]
		public const int OPEN_SHARE_EVENT = 1;

		// Token: 0x0403EF2D RID: 257837
		[Token(Token = "0x403EF2D")]
		[NonSerialized]
		public const int SWITCH_LAYOUT_EVENT = 2;

		// Token: 0x0403EF2E RID: 257838
		[Token(Token = "0x403EF2E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403EF2F RID: 257839
		[Token(Token = "0x403EF2F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0403EF30 RID: 257840
		[Token(Token = "0x403EF30")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnOpenDetailEvent;

		// Token: 0x0403EF31 RID: 257841
		[Token(Token = "0x403EF31")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnOpenShareEvent;

		// Token: 0x0403EF32 RID: 257842
		[Token(Token = "0x403EF32")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnSwitchLayoutEvent;

		// Token: 0x0403EF33 RID: 257843
		[Token(Token = "0x403EF33")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403EF34 RID: 257844
		[Token(Token = "0x403EF34")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403EF35 RID: 257845
		[Token(Token = "0x403EF35")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403EF36 RID: 257846
		[Token(Token = "0x403EF36")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnClickBack;

		// Token: 0x0403EF37 RID: 257847
		[Token(Token = "0x403EF37")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__FocusZoneBadgeIfNeed;

		// Token: 0x0403EF38 RID: 257848
		[Token(Token = "0x403EF38")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__FocusZoneBadgeCoroutine;

		// Token: 0x0403EF39 RID: 257849
		[Token(Token = "0x403EF39")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0403EF3A RID: 257850
		[Token(Token = "0x403EF3A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0403EF3B RID: 257851
		[Token(Token = "0x403EF3B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x0403EF3C RID: 257852
		[Token(Token = "0x403EF3C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x0403EF3D RID: 257853
		[Token(Token = "0x403EF3D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
