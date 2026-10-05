using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EAE RID: 20142
	[Token(Token = "0x2004EAE")]
	public class FifthAnnivExploreLogView : FifthAnnivExploreDetailViewBase
	{
		// Token: 0x0601E0D6 RID: 123094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0D6")]
		[Address(RVA = "0x17BE710", Offset = "0x17BD310", VA = "0x1817BE710")]
		private void _InitIfNot()
		{
		}

		// Token: 0x17004687 RID: 18055
		// (get) Token: 0x0601E0D7 RID: 123095 RVA: 0x000AD4C0 File Offset: 0x000AB6C0
		[Token(Token = "0x17004687")]
		protected override FifthAnnivExploreDecisionModel.DecisionStatus status
		{
			[Token(Token = "0x601E0D7")]
			[Address(RVA = "0x17BF620", Offset = "0x17BE220", VA = "0x1817BF620", Slot = "8")]
			get
			{
				return FifthAnnivExploreDecisionModel.DecisionStatus.NONE;
			}
		}

		// Token: 0x0601E0D8 RID: 123096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0D8")]
		[Address(RVA = "0x17BE4E0", Offset = "0x17BD0E0", VA = "0x1817BE4E0", Slot = "9")]
		protected override void OnDataUpdate()
		{
		}

		// Token: 0x0601E0D9 RID: 123097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0D9")]
		[Address(RVA = "0x17BEE70", Offset = "0x17BDA70", VA = "0x1817BEE70")]
		private void _Render()
		{
		}

		// Token: 0x0601E0DA RID: 123098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0DA")]
		[Address(RVA = "0x17BE7C0", Offset = "0x17BD3C0", VA = "0x1817BE7C0")]
		private void _OnPostLayout()
		{
		}

		// Token: 0x0601E0DB RID: 123099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0DB")]
		[Address(RVA = "0x17BE440", Offset = "0x17BD040", VA = "0x1817BE440")]
		public void OnContinueClicked()
		{
		}

		// Token: 0x0601E0DC RID: 123100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0DC")]
		[Address(RVA = "0x17BF570", Offset = "0x17BE170", VA = "0x1817BF570")]
		public FifthAnnivExploreLogView()
		{
		}

		// Token: 0x04027F7B RID: 163707
		[Token(Token = "0x4027F7B")]
		private const int MAX_LOOP_COUNT = 2;

		// Token: 0x04027F7C RID: 163708
		[Token(Token = "0x4027F7C")]
		private const string CHOICE_VALUE_ADD_FORMAT = "+{0}";

		// Token: 0x04027F7D RID: 163709
		[Token(Token = "0x4027F7D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textEventTitle;

		// Token: 0x04027F7E RID: 163710
		[Token(Token = "0x4027F7E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textEventTypeDesc;

		// Token: 0x04027F7F RID: 163711
		[Token(Token = "0x4027F7F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textEventDesc;

		// Token: 0x04027F80 RID: 163712
		[Token(Token = "0x4027F80")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textChoiceTitle;

		// Token: 0x04027F81 RID: 163713
		[Token(Token = "0x4027F81")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textChoiceDesc;

		// Token: 0x04027F82 RID: 163714
		[Token(Token = "0x4027F82")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textResultTitle;

		// Token: 0x04027F83 RID: 163715
		[Token(Token = "0x4027F83")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textResultDesc;

		// Token: 0x04027F84 RID: 163716
		[Token(Token = "0x4027F84")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x04027F85 RID: 163717
		[Token(Token = "0x4027F85")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private string _spriteNameSuccess;

		// Token: 0x04027F86 RID: 163718
		[Token(Token = "0x4027F86")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private string _spriteNameFail;

		// Token: 0x04027F87 RID: 163719
		[Token(Token = "0x4027F87")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAtlasImage _imgResultSprite;

		// Token: 0x04027F88 RID: 163720
		[Token(Token = "0x4027F88")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x04027F89 RID: 163721
		[Token(Token = "0x4027F89")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RectTransform _viewport;

		// Token: 0x04027F8A RID: 163722
		[Token(Token = "0x4027F8A")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x04027F8B RID: 163723
		[Token(Token = "0x4027F8B")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RectTransform _firstDialogContent;

		// Token: 0x04027F8C RID: 163724
		[Token(Token = "0x4027F8C")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private float _loadingDialogHeight;

		// Token: 0x04027F8D RID: 163725
		[Token(Token = "0x4027F8D")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private VerticalLayoutGroup _verticalLayout;

		// Token: 0x04027F8E RID: 163726
		[Token(Token = "0x4027F8E")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x04027F8F RID: 163727
		[Token(Token = "0x4027F8F")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UIAnimationLocation _animLoop;

		// Token: 0x04027F90 RID: 163728
		[Token(Token = "0x4027F90")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private UIAnimationLocation _animExpand;

		// Token: 0x04027F91 RID: 163729
		[Token(Token = "0x4027F91")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private float _firstFocusOffset;

		// Token: 0x04027F92 RID: 163730
		[Token(Token = "0x4027F92")]
		[FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private float _expandFocusOffset;

		// Token: 0x04027F93 RID: 163731
		[Token(Token = "0x4027F93")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private float _focusTweenDur;

		// Token: 0x04027F94 RID: 163732
		[Token(Token = "0x4027F94")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private GameObject _pnlDotSuccess;

		// Token: 0x04027F95 RID: 163733
		[Token(Token = "0x4027F95")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private GameObject _pnlDotFailed;

		// Token: 0x04027F96 RID: 163734
		[Token(Token = "0x4027F96")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private GameObject _pnlBkgSuccess;

		// Token: 0x04027F97 RID: 163735
		[Token(Token = "0x4027F97")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private GameObject _pnlBkgFailed;

		// Token: 0x04027F98 RID: 163736
		[Token(Token = "0x4027F98")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private Text[] _textValues;

		// Token: 0x04027F99 RID: 163737
		[Token(Token = "0x4027F99")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private UIAtlasImage[] _spriteValues;

		// Token: 0x04027F9A RID: 163738
		[Token(Token = "0x4027F9A")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private UIColorGraphic[] _graphicValues;

		// Token: 0x04027F9B RID: 163739
		[Token(Token = "0x4027F9B")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private UIAtlasObject _commonAtlas;

		// Token: 0x04027F9C RID: 163740
		[Token(Token = "0x4027F9C")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private Color _colorValueDecrease;

		// Token: 0x04027F9D RID: 163741
		[Token(Token = "0x4027F9D")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private UIAtlasObject _eventIconAtlas;

		// Token: 0x04027F9E RID: 163742
		[Token(Token = "0x4027F9E")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private UIAtlasImage _imgEventIcon;

		// Token: 0x04027F9F RID: 163743
		[Token(Token = "0x4027F9F")]
		[FieldOffset(Offset = "0x160")]
		private bool m_inited;

		// Token: 0x04027FA0 RID: 163744
		[Token(Token = "0x4027FA0")]
		[FieldOffset(Offset = "0x168")]
		private UILayoutDimensionListener m_dimensionListener;

		// Token: 0x04027FA1 RID: 163745
		[Token(Token = "0x4027FA1")]
		[FieldOffset(Offset = "0x170")]
		private Tween m_effectTween;

		// Token: 0x04027FA2 RID: 163746
		[Token(Token = "0x4027FA2")]
		[FieldOffset(Offset = "0x178")]
		private int m_cachedSeqNum;

		// Token: 0x04027FA3 RID: 163747
		[Token(Token = "0x4027FA3")]
		[FieldOffset(Offset = "0x180")]
		private FifthAnnivExploreLogModel m_cachedLogModel;

		// Token: 0x04027FA4 RID: 163748
		[Token(Token = "0x4027FA4")]
		[FieldOffset(Offset = "0x188")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04027FA5 RID: 163749
		[Token(Token = "0x4027FA5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027FA6 RID: 163750
		[Token(Token = "0x4027FA6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_status;

		// Token: 0x04027FA7 RID: 163751
		[Token(Token = "0x4027FA7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDataUpdate;

		// Token: 0x04027FA8 RID: 163752
		[Token(Token = "0x4027FA8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x04027FA9 RID: 163753
		[Token(Token = "0x4027FA9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnPostLayout;

		// Token: 0x04027FAA RID: 163754
		[Token(Token = "0x4027FAA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnContinueClicked;

		// Token: 0x04027FAB RID: 163755
		[Token(Token = "0x4027FAB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004EAF RID: 20143
		[Token(Token = "0x2004EAF")]
		private class OnPostLayoutAction : UILayoutDimensionListener.IAction
		{
			// Token: 0x0601E0DF RID: 123103 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E0DF")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public OnPostLayoutAction(FifthAnnivExploreLogView closure)
			{
			}

			// Token: 0x0601E0E0 RID: 123104 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E0E0")]
			[Address(RVA = "0x17C76C0", Offset = "0x17C62C0", VA = "0x1817C76C0", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x04027FAC RID: 163756
			[Token(Token = "0x4027FAC")]
			[FieldOffset(Offset = "0x10")]
			private FifthAnnivExploreLogView m_closure;
		}
	}
}
