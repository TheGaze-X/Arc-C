using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BC7 RID: 27591
	[Token(Token = "0x2006BC7")]
	public class ArchiveNewsListItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005D0D RID: 23821
		// (get) Token: 0x0602767F RID: 161407 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027680 RID: 161408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D0D")]
		public ArchiveNewsController controller
		{
			[Token(Token = "0x602767F")]
			[Address(RVA = "0x2297FD0", Offset = "0x2296BD0", VA = "0x182297FD0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027680")]
			[Address(RVA = "0x2298030", Offset = "0x2296C30", VA = "0x182298030")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06027681 RID: 161409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027681")]
		[Address(RVA = "0x2297AE0", Offset = "0x22966E0", VA = "0x182297AE0")]
		public void Render(string selectedItem, NewsItemModel itemModel, bool isInit)
		{
		}

		// Token: 0x06027682 RID: 161410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027682")]
		[Address(RVA = "0x2297990", Offset = "0x2296590", VA = "0x182297990")]
		public void EventOnItemClicked()
		{
		}

		// Token: 0x06027683 RID: 161411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027683")]
		[Address(RVA = "0x2297F70", Offset = "0x2296B70", VA = "0x182297F70")]
		public ArchiveNewsListItemView()
		{
		}

		// Token: 0x04037D46 RID: 228678
		[Token(Token = "0x4037D46")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Item Nodes")]
		private Image _nodeCurrent;

		// Token: 0x04037D47 RID: 228679
		[Token(Token = "0x4037D47")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Item Nodes")]
		private Image _nodeCurrentArray;

		// Token: 0x04037D48 RID: 228680
		[Token(Token = "0x4037D48")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Item Nodes")]
		private GameObject _nodeNew;

		// Token: 0x04037D49 RID: 228681
		[Token(Token = "0x4037D49")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Item Nodes")]
		private GameObject _nodeLocked;

		// Token: 0x04037D4A RID: 228682
		[Token(Token = "0x4037D4A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Item Nodes")]
		private CanvasGroup _canvasLocked;

		// Token: 0x04037D4B RID: 228683
		[Token(Token = "0x4037D4B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Animation Param")]
		private Vector2 _nodeCurrentArrayStartPos;

		// Token: 0x04037D4C RID: 228684
		[Token(Token = "0x4037D4C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Animation Param")]
		private Vector2 _nodeCurrentArrayEndPos;

		// Token: 0x04037D4D RID: 228685
		[Token(Token = "0x4037D4D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Animation Param")]
		private Vector3 _nodeCurrentStartScale;

		// Token: 0x04037D4E RID: 228686
		[Token(Token = "0x4037D4E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Canvas Groups")]
		private CanvasGroup _currNodeCanvasGroup;

		// Token: 0x04037D4F RID: 228687
		[Token(Token = "0x4037D4F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Canvas Groups")]
		private CanvasGroup _textTitleCanvasGroup;

		// Token: 0x04037D50 RID: 228688
		[Token(Token = "0x4037D50")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04037D51 RID: 228689
		[Token(Token = "0x4037D51")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textNewspaper;

		// Token: 0x04037D52 RID: 228690
		[Token(Token = "0x4037D52")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _imgNewspaper;

		// Token: 0x04037D53 RID: 228691
		[Token(Token = "0x4037D53")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Button _picSelectBtn;

		// Token: 0x04037D54 RID: 228692
		[Token(Token = "0x4037D54")]
		[FieldOffset(Offset = "0x90")]
		private NewsItemModel m_cachedModel;

		// Token: 0x04037D55 RID: 228693
		[Token(Token = "0x4037D55")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isFocus;

		// Token: 0x04037D56 RID: 228694
		[Token(Token = "0x4037D56")]
		[FieldOffset(Offset = "0xA0")]
		private Sequence m_sequence;

		// Token: 0x04037D57 RID: 228695
		[Token(Token = "0x4037D57")]
		[FieldOffset(Offset = "0xA8")]
		private ArchiveNewsListItemView.ArchiveNewsListItemSwitchTween m_switchTween;

		// Token: 0x04037D59 RID: 228697
		[Token(Token = "0x4037D59")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04037D5A RID: 228698
		[Token(Token = "0x4037D5A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04037D5B RID: 228699
		[Token(Token = "0x4037D5B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037D5C RID: 228700
		[Token(Token = "0x4037D5C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnItemClicked;

		// Token: 0x04037D5D RID: 228701
		[Token(Token = "0x4037D5D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006BC8 RID: 27592
		[Token(Token = "0x2006BC8")]
		private class ArchiveNewsListItemSwitchTween : UISwitchTween
		{
			// Token: 0x06027684 RID: 161412 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027684")]
			[Address(RVA = "0x2297910", Offset = "0x2296510", VA = "0x182297910")]
			public ArchiveNewsListItemSwitchTween(ArchiveNewsListItemView closure)
			{
			}

			// Token: 0x06027685 RID: 161413 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027685")]
			[Address(RVA = "0x2297540", Offset = "0x2296140", VA = "0x182297540")]
			private Sequence _GenerateSequence(bool isFocus)
			{
				return null;
			}

			// Token: 0x06027686 RID: 161414 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027686")]
			[Address(RVA = "0x2297130", Offset = "0x2295D30", VA = "0x182297130", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x06027687 RID: 161415 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027687")]
			[Address(RVA = "0x22971D0", Offset = "0x2295DD0", VA = "0x1822971D0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x06027688 RID: 161416 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027688")]
			[Address(RVA = "0x2296FF0", Offset = "0x2295BF0", VA = "0x182296FF0", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x06027689 RID: 161417 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027689")]
			[Address(RVA = "0x2297090", Offset = "0x2295C90", VA = "0x182297090", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x0602768A RID: 161418 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602768A")]
			[Address(RVA = "0x2297270", Offset = "0x2295E70", VA = "0x182297270", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0602768B RID: 161419 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602768B")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0602768C RID: 161420 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602768C")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x0602768D RID: 161421 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602768D")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x04037D5E RID: 228702
			[Token(Token = "0x4037D5E")]
			[FieldOffset(Offset = "0x48")]
			private ArchiveNewsListItemView m_closure;

			// Token: 0x04037D5F RID: 228703
			[Token(Token = "0x4037D5F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037D60 RID: 228704
			[Token(Token = "0x4037D60")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__GenerateSequence;

			// Token: 0x04037D61 RID: 228705
			[Token(Token = "0x4037D61")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04037D62 RID: 228706
			[Token(Token = "0x4037D62")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04037D63 RID: 228707
			[Token(Token = "0x4037D63")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x04037D64 RID: 228708
			[Token(Token = "0x4037D64")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;

			// Token: 0x04037D65 RID: 228709
			[Token(Token = "0x4037D65")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
