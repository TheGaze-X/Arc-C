using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020063A0 RID: 25504
	[Token(Token = "0x20063A0")]
	public class AutoChessStageInfoGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06024C67 RID: 150631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C67")]
		[Address(RVA = "0x1FA9870", Offset = "0x1FA8470", VA = "0x181FA9870")]
		public void Render(AutoChessStageInfoGroupViewModel model)
		{
		}

		// Token: 0x06024C68 RID: 150632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C68")]
		[Address(RVA = "0x1FA99E0", Offset = "0x1FA85E0", VA = "0x181FA99E0")]
		public void TutorialOnly_FocusItem(string itemType)
		{
		}

		// Token: 0x06024C69 RID: 150633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C69")]
		[Address(RVA = "0x1FA9DF0", Offset = "0x1FA89F0", VA = "0x181FA9DF0")]
		private void _EventOnFocusComplete()
		{
		}

		// Token: 0x06024C6A RID: 150634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C6A")]
		[Address(RVA = "0x1FA9E80", Offset = "0x1FA8A80", VA = "0x181FA9E80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024C6B RID: 150635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C6B")]
		[Address(RVA = "0x1FA9F50", Offset = "0x1FA8B50", VA = "0x181FA9F50")]
		public AutoChessStageInfoGroupView()
		{
		}

		// Token: 0x04033641 RID: 210497
		[Token(Token = "0x4033641")]
		private const int FOCUS_POS_OFFSET = 20;

		// Token: 0x04033642 RID: 210498
		[Token(Token = "0x4033642")]
		private const float FOCUS_DURATION = 0.5f;

		// Token: 0x04033643 RID: 210499
		[Token(Token = "0x4033643")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIWrappedScrollRect _scrollRect;

		// Token: 0x04033644 RID: 210500
		[Token(Token = "0x4033644")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIRecycleVerticalLayoutGroup _recycleLayoutList;

		// Token: 0x04033645 RID: 210501
		[Token(Token = "0x4033645")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UISimpleRecycleLayoutItemView[] _prefabList;

		// Token: 0x04033646 RID: 210502
		[Token(Token = "0x4033646")]
		[FieldOffset(Offset = "0x30")]
		private UISimpleRecycleLayoutAdapter m_adapter;

		// Token: 0x04033647 RID: 210503
		[Token(Token = "0x4033647")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x04033648 RID: 210504
		[Token(Token = "0x4033648")]
		[FieldOffset(Offset = "0x40")]
		private IList<UISimpleRecycleLayoutItemViewModel> m_cachedData;

		// Token: 0x04033649 RID: 210505
		[Token(Token = "0x4033649")]
		[FieldOffset(Offset = "0x48")]
		private Tween m_focusTween;

		// Token: 0x0403364A RID: 210506
		[Token(Token = "0x403364A")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403364B RID: 210507
		[Token(Token = "0x403364B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403364C RID: 210508
		[Token(Token = "0x403364C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TutorialOnly_FocusItem;

		// Token: 0x0403364D RID: 210509
		[Token(Token = "0x403364D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EventOnFocusComplete;

		// Token: 0x0403364E RID: 210510
		[Token(Token = "0x403364E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403364F RID: 210511
		[Token(Token = "0x403364F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
