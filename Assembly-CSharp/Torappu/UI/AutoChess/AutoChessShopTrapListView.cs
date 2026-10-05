using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006386 RID: 25478
	[Token(Token = "0x2006386")]
	public class AutoChessShopTrapListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170056C4 RID: 22212
		// (get) Token: 0x06024C00 RID: 150528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170056C4")]
		public AutoChessShopLevelTrapGroupItemView groupTrapChessItemPrefab
		{
			[Token(Token = "0x6024C00")]
			[Address(RVA = "0x1FA4B60", Offset = "0x1FA3760", VA = "0x181FA4B60")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024C01 RID: 150529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C01")]
		[Address(RVA = "0x1FA3EF0", Offset = "0x1FA2AF0", VA = "0x181FA3EF0")]
		public void Init(AutoChessShopPage page)
		{
		}

		// Token: 0x06024C02 RID: 150530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C02")]
		[Address(RVA = "0x1FA3F70", Offset = "0x1FA2B70", VA = "0x181FA3F70")]
		public void Render(AutoChessShopLevelTrapGroupListViewModel listViewModel, AutoChessShopTrapListView.FocusParams focusParams)
		{
		}

		// Token: 0x06024C03 RID: 150531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C03")]
		[Address(RVA = "0x1FA42C0", Offset = "0x1FA2EC0", VA = "0x181FA42C0")]
		public void ResetViewSeqCache()
		{
		}

		// Token: 0x06024C04 RID: 150532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C04")]
		[Address(RVA = "0x1FA4750", Offset = "0x1FA3350", VA = "0x181FA4750")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024C05 RID: 150533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C05")]
		[Address(RVA = "0x1FA4980", Offset = "0x1FA3580", VA = "0x181FA4980")]
		private void _TryStartScrollCo(AutoChessShopTrapListView.FocusParams focusParams)
		{
		}

		// Token: 0x06024C06 RID: 150534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024C06")]
		[Address(RVA = "0x1FA48C0", Offset = "0x1FA34C0", VA = "0x181FA48C0")]
		private IEnumerator _TryScrollToPos(AutoChessShopTrapListView.FocusParams focusParams)
		{
			return null;
		}

		// Token: 0x06024C07 RID: 150535 RVA: 0x000C5628 File Offset: 0x000C3828
		[Token(Token = "0x6024C07")]
		[Address(RVA = "0x1FA46D0", Offset = "0x1FA32D0", VA = "0x181FA46D0")]
		private float _GetPositionFromViewAndColumnIndex(int viewIndex)
		{
			return 0f;
		}

		// Token: 0x06024C08 RID: 150536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C08")]
		[Address(RVA = "0x1FA4320", Offset = "0x1FA2F20", VA = "0x181FA4320")]
		private void _FocusToPos(float pos, bool fastMode = false)
		{
		}

		// Token: 0x06024C09 RID: 150537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C09")]
		[Address(RVA = "0x1FA4B00", Offset = "0x1FA3700", VA = "0x181FA4B00")]
		public AutoChessShopTrapListView()
		{
		}

		// Token: 0x0403357A RID: 210298
		[Token(Token = "0x403357A")]
		private const float MAX_FOCUS_SCROLL_DISTANCE = 1280f;

		// Token: 0x0403357B RID: 210299
		[Token(Token = "0x403357B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AutoChessShopLevelTrapGroupItemView _groupItemViewPrefab;

		// Token: 0x0403357C RID: 210300
		[Token(Token = "0x403357C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIRecycleHorizonLayoutGroup _recycleLayoutList;

		// Token: 0x0403357D RID: 210301
		[Token(Token = "0x403357D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _viewport;

		// Token: 0x0403357E RID: 210302
		[Token(Token = "0x403357E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ScrollRect _scrollView;

		// Token: 0x0403357F RID: 210303
		[Token(Token = "0x403357F")]
		[FieldOffset(Offset = "0x38")]
		private AutoChessShopTrapListRecycleAdapter m_adapter;

		// Token: 0x04033580 RID: 210304
		[Token(Token = "0x4033580")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x04033581 RID: 210305
		[Token(Token = "0x4033581")]
		[FieldOffset(Offset = "0x48")]
		private Coroutine m_scrollToGroupCoroutine;

		// Token: 0x04033582 RID: 210306
		[Token(Token = "0x4033582")]
		[FieldOffset(Offset = "0x50")]
		private AutoChessShopPage m_page;

		// Token: 0x04033583 RID: 210307
		[Token(Token = "0x4033583")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_focusTween;

		// Token: 0x04033584 RID: 210308
		[Token(Token = "0x4033584")]
		[FieldOffset(Offset = "0x60")]
		private int m_cachedEnterSequenceNum;

		// Token: 0x04033585 RID: 210309
		[Token(Token = "0x4033585")]
		private const float FOCUS_TWEEN_DURATION = 0.6f;

		// Token: 0x04033586 RID: 210310
		[Token(Token = "0x4033586")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_groupTrapChessItemPrefab;

		// Token: 0x04033587 RID: 210311
		[Token(Token = "0x4033587")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04033588 RID: 210312
		[Token(Token = "0x4033588")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04033589 RID: 210313
		[Token(Token = "0x4033589")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ResetViewSeqCache;

		// Token: 0x0403358A RID: 210314
		[Token(Token = "0x403358A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403358B RID: 210315
		[Token(Token = "0x403358B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryStartScrollCo;

		// Token: 0x0403358C RID: 210316
		[Token(Token = "0x403358C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryScrollToPos;

		// Token: 0x0403358D RID: 210317
		[Token(Token = "0x403358D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetPositionFromViewAndColumnIndex;

		// Token: 0x0403358E RID: 210318
		[Token(Token = "0x403358E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__FocusToPos;

		// Token: 0x0403358F RID: 210319
		[Token(Token = "0x403358F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006387 RID: 25479
		[Token(Token = "0x2006387")]
		public struct FocusParams
		{
			// Token: 0x04033590 RID: 210320
			[Token(Token = "0x4033590")]
			[FieldOffset(Offset = "0x0")]
			public bool needFocus;

			// Token: 0x04033591 RID: 210321
			[Token(Token = "0x4033591")]
			[FieldOffset(Offset = "0x1")]
			public bool fastModeFocusToLeft;

			// Token: 0x04033592 RID: 210322
			[Token(Token = "0x4033592")]
			[FieldOffset(Offset = "0x4")]
			public int viewIndex;
		}
	}
}
