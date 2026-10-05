using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007938 RID: 31032
	[Token(Token = "0x2007938")]
	public class Act1ArcadeBadgeBookView : DataBinder<Act1ArcadeBadgeBookProperty>
	{
		// Token: 0x0602B89D RID: 178333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B89D")]
		[Address(RVA = "0x27719E0", Offset = "0x27705E0", VA = "0x1827719E0")]
		public void OnOpenShareEvent()
		{
		}

		// Token: 0x0602B89E RID: 178334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B89E")]
		[Address(RVA = "0x2771A80", Offset = "0x2770680", VA = "0x182771A80")]
		public void OnSwitchLayoutEvent()
		{
		}

		// Token: 0x0602B89F RID: 178335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B89F")]
		[Address(RVA = "0x2772010", Offset = "0x2770C10", VA = "0x182772010")]
		public void PlayFocusItem(int index)
		{
		}

		// Token: 0x0602B8A0 RID: 178336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8A0")]
		[Address(RVA = "0x2771B20", Offset = "0x2770720", VA = "0x182771B20", Slot = "7")]
		public override void OnValueChanged(Act1ArcadeBadgeBookProperty property)
		{
		}

		// Token: 0x0602B8A1 RID: 178337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B8A1")]
		[Address(RVA = "0x27711D0", Offset = "0x276FDD0", VA = "0x1827711D0")]
		public Act1ArcadeBadgeBookShareModelCollector GenerateShareModelCollector()
		{
			return null;
		}

		// Token: 0x0602B8A2 RID: 178338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8A2")]
		[Address(RVA = "0x27728B0", Offset = "0x27714B0", VA = "0x1827728B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B8A3 RID: 178339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8A3")]
		[Address(RVA = "0x2772EF0", Offset = "0x2771AF0", VA = "0x182772EF0")]
		private void _SwitchContentGroup()
		{
		}

		// Token: 0x0602B8A4 RID: 178340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8A4")]
		[Address(RVA = "0x2772B10", Offset = "0x2771710", VA = "0x182772B10")]
		private void _RefreshGroupViews()
		{
		}

		// Token: 0x0602B8A5 RID: 178341 RVA: 0x000DC608 File Offset: 0x000DA808
		[Token(Token = "0x602B8A5")]
		[Address(RVA = "0x27724F0", Offset = "0x27710F0", VA = "0x1827724F0")]
		private Bounds _CalculateRelativeBounds(Transform root, RectTransform child)
		{
			return default(Bounds);
		}

		// Token: 0x0602B8A6 RID: 178342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8A6")]
		[Address(RVA = "0x2773080", Offset = "0x2771C80", VA = "0x182773080")]
		public Act1ArcadeBadgeBookView()
		{
		}

		// Token: 0x0403EF6B RID: 257899
		[Token(Token = "0x403EF6B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _ultimateGroupNameText;

		// Token: 0x0403EF6C RID: 257900
		[Token(Token = "0x403EF6C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act1ArcadeBadgeBookItemHeadView _ultimateBadgeHeadView;

		// Token: 0x0403EF6D RID: 257901
		[Token(Token = "0x403EF6D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Act1ArcadeBadgeBookUltimateTailView _ultimateBadgeTailView;

		// Token: 0x0403EF6E RID: 257902
		[Token(Token = "0x403EF6E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<Act1ArcadeBadgeBookView.BadgeGroup> _badgeGroups;

		// Token: 0x0403EF6F RID: 257903
		[Token(Token = "0x403EF6F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ScrollRect _badgesContentScroll;

		// Token: 0x0403EF70 RID: 257904
		[Token(Token = "0x403EF70")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _badgeContentRect;

		// Token: 0x0403EF71 RID: 257905
		[Token(Token = "0x403EF71")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private HorizontalLayoutGroup _badgeContentLayout;

		// Token: 0x0403EF72 RID: 257906
		[Token(Token = "0x403EF72")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ContentSizeFitter _badgeContentFitter;

		// Token: 0x0403EF73 RID: 257907
		[Token(Token = "0x403EF73")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _badgesContentGroup;

		// Token: 0x0403EF74 RID: 257908
		[Token(Token = "0x403EF74")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _contentFadeTime;

		// Token: 0x0403EF75 RID: 257909
		[Token(Token = "0x403EF75")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _switchButtonAnimation;

		// Token: 0x0403EF76 RID: 257910
		[Token(Token = "0x403EF76")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _ultimateBadgeSwitchAnimation;

		// Token: 0x0403EF77 RID: 257911
		[Token(Token = "0x403EF77")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _focusFullLengthDuration;

		// Token: 0x0403EF78 RID: 257912
		[Token(Token = "0x403EF78")]
		[FieldOffset(Offset = "0x98")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403EF79 RID: 257913
		[Token(Token = "0x403EF79")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_hasInited;

		// Token: 0x0403EF7A RID: 257914
		[Token(Token = "0x403EF7A")]
		[FieldOffset(Offset = "0xB0")]
		private AnimationSwitchTween m_switchButtonTween;

		// Token: 0x0403EF7B RID: 257915
		[Token(Token = "0x403EF7B")]
		[FieldOffset(Offset = "0xB8")]
		private AnimationSwitchTween m_ultimateBadgeTween;

		// Token: 0x0403EF7C RID: 257916
		[Token(Token = "0x403EF7C")]
		[FieldOffset(Offset = "0xC0")]
		private Act1ArcadeBadgeBookViewModel m_cachedModel;

		// Token: 0x0403EF7D RID: 257917
		[Token(Token = "0x403EF7D")]
		[FieldOffset(Offset = "0xC8")]
		private BadgeBookLayoutMode m_displayedLayoutMode;

		// Token: 0x0403EF7E RID: 257918
		[Token(Token = "0x403EF7E")]
		[FieldOffset(Offset = "0xD0")]
		private Sequence m_switchSequence;

		// Token: 0x0403EF7F RID: 257919
		[Token(Token = "0x403EF7F")]
		[FieldOffset(Offset = "0xD8")]
		private Vector3[] m_cornerCache;

		// Token: 0x0403EF80 RID: 257920
		[Token(Token = "0x403EF80")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnOpenShareEvent;

		// Token: 0x0403EF81 RID: 257921
		[Token(Token = "0x403EF81")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSwitchLayoutEvent;

		// Token: 0x0403EF82 RID: 257922
		[Token(Token = "0x403EF82")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PlayFocusItem;

		// Token: 0x0403EF83 RID: 257923
		[Token(Token = "0x403EF83")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403EF84 RID: 257924
		[Token(Token = "0x403EF84")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GenerateShareModelCollector;

		// Token: 0x0403EF85 RID: 257925
		[Token(Token = "0x403EF85")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403EF86 RID: 257926
		[Token(Token = "0x403EF86")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SwitchContentGroup;

		// Token: 0x0403EF87 RID: 257927
		[Token(Token = "0x403EF87")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RefreshGroupViews;

		// Token: 0x0403EF88 RID: 257928
		[Token(Token = "0x403EF88")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CalculateRelativeBounds;

		// Token: 0x0403EF89 RID: 257929
		[Token(Token = "0x403EF89")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007939 RID: 31033
		[Token(Token = "0x2007939")]
		[Serializable]
		public struct BadgeGroup
		{
			// Token: 0x0403EF8A RID: 257930
			[Token(Token = "0x403EF8A")]
			[FieldOffset(Offset = "0x0")]
			public ActArcadeData.BadgeType type;

			// Token: 0x0403EF8B RID: 257931
			[Token(Token = "0x403EF8B")]
			[FieldOffset(Offset = "0x8")]
			public Act1ArcadeBadgeBookGroupView view;
		}
	}
}
