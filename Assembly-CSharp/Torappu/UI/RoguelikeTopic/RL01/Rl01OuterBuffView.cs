using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL01
{
	// Token: 0x0200465D RID: 18013
	[Token(Token = "0x200465D")]
	public class Rl01OuterBuffView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004127 RID: 16679
		// (get) Token: 0x0601B5B9 RID: 112057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004127")]
		public DataBinder<RoguelikeTopicOuterBuffListProperty> buffListView
		{
			[Token(Token = "0x601B5B9")]
			[Address(RVA = "0x14AE3D0", Offset = "0x14ACFD0", VA = "0x1814AE3D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004128 RID: 16680
		// (get) Token: 0x0601B5BA RID: 112058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004128")]
		public DataBinder<RoguelikeTopicOuterBuffSkillTreeProperty> skillTreeView
		{
			[Token(Token = "0x601B5BA")]
			[Address(RVA = "0x14AE430", Offset = "0x14AD030", VA = "0x1814AE430")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004129 RID: 16681
		// (get) Token: 0x0601B5BB RID: 112059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004129")]
		public DataBinder<RoguelikeTopicOuterBuffSkillTreeProperty> buffItemDetailView
		{
			[Token(Token = "0x601B5BB")]
			[Address(RVA = "0x14AE370", Offset = "0x14ACF70", VA = "0x1814AE370")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601B5BC RID: 112060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5BC")]
		[Address(RVA = "0x14ADD90", Offset = "0x14AC990", VA = "0x1814ADD90")]
		public void Init(Rl01TopicOuterBuffController topicController)
		{
		}

		// Token: 0x0601B5BD RID: 112061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5BD")]
		[Address(RVA = "0x14AE080", Offset = "0x14ACC80", VA = "0x1814AE080")]
		public void SwitchDetailView(bool isShow, bool isInit)
		{
		}

		// Token: 0x0601B5BE RID: 112062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5BE")]
		[Address(RVA = "0x14ADEB0", Offset = "0x14ACAB0", VA = "0x1814ADEB0")]
		public void ResetView()
		{
		}

		// Token: 0x0601B5BF RID: 112063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5BF")]
		[Address(RVA = "0x14ADFF0", Offset = "0x14ACBF0", VA = "0x1814ADFF0")]
		public void ShowView()
		{
		}

		// Token: 0x0601B5C0 RID: 112064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5C0")]
		[Address(RVA = "0x14AE310", Offset = "0x14ACF10", VA = "0x1814AE310")]
		public Rl01OuterBuffView()
		{
		}

		// Token: 0x04023597 RID: 144791
		[Token(Token = "0x4023597")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Rl01OuterBuffListView _buffListView;

		// Token: 0x04023598 RID: 144792
		[Token(Token = "0x4023598")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Rl01OuterBuffSkillTreeView _skillTreeView;

		// Token: 0x04023599 RID: 144793
		[Token(Token = "0x4023599")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Rl01OuterBuffItemDetailView _buffItemDetailView;

		// Token: 0x0402359A RID: 144794
		[Token(Token = "0x402359A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _showAnim;

		// Token: 0x0402359B RID: 144795
		[Token(Token = "0x402359B")]
		[FieldOffset(Offset = "0x40")]
		private Rl01OuterBuffView.DetailViewSwitchTween m_switchTween;

		// Token: 0x0402359C RID: 144796
		[Token(Token = "0x402359C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_buffListView;

		// Token: 0x0402359D RID: 144797
		[Token(Token = "0x402359D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_skillTreeView;

		// Token: 0x0402359E RID: 144798
		[Token(Token = "0x402359E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_buffItemDetailView;

		// Token: 0x0402359F RID: 144799
		[Token(Token = "0x402359F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040235A0 RID: 144800
		[Token(Token = "0x40235A0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SwitchDetailView;

		// Token: 0x040235A1 RID: 144801
		[Token(Token = "0x40235A1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ResetView;

		// Token: 0x040235A2 RID: 144802
		[Token(Token = "0x40235A2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ShowView;

		// Token: 0x040235A3 RID: 144803
		[Token(Token = "0x40235A3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200465E RID: 18014
		[Token(Token = "0x200465E")]
		protected class DetailViewSwitchTween : UISwitchTween
		{
			// Token: 0x0601B5C1 RID: 112065 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B5C1")]
			[Address(RVA = "0x14AB310", Offset = "0x14A9F10", VA = "0x1814AB310")]
			public DetailViewSwitchTween(RectTransform bottomView, RectTransform centerView)
			{
			}

			// Token: 0x0601B5C2 RID: 112066 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B5C2")]
			[Address(RVA = "0x14AAF20", Offset = "0x14A9B20", VA = "0x1814AAF20", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601B5C3 RID: 112067 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B5C3")]
			[Address(RVA = "0x14AB090", Offset = "0x14A9C90", VA = "0x1814AB090", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601B5C4 RID: 112068 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B5C4")]
			[Address(RVA = "0x14AAE20", Offset = "0x14A9A20", VA = "0x1814AAE20", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0601B5C5 RID: 112069 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B5C5")]
			[Address(RVA = "0x14AAEA0", Offset = "0x14A9AA0", VA = "0x1814AAEA0", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0601B5C6 RID: 112070 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B5C6")]
			[Address(RVA = "0x14AB200", Offset = "0x14A9E00", VA = "0x1814AB200", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601B5C7 RID: 112071 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B5C7")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0601B5C8 RID: 112072 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B5C8")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0601B5C9 RID: 112073 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B5C9")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x040235A4 RID: 144804
			[Token(Token = "0x40235A4")]
			private const float SELECTION_ANIM_DURATION = 0.4f;

			// Token: 0x040235A5 RID: 144805
			[Token(Token = "0x40235A5")]
			private const int BOTTOM_VIEW_TARGET_Y = -120;

			// Token: 0x040235A6 RID: 144806
			[Token(Token = "0x40235A6")]
			private const int MIDDLE_VIEW_HIDE_Y = -20;

			// Token: 0x040235A7 RID: 144807
			[Token(Token = "0x40235A7")]
			private const int MIDDLE_VIEW_SHOW_Y = 35;

			// Token: 0x040235A8 RID: 144808
			[Token(Token = "0x40235A8")]
			[FieldOffset(Offset = "0x48")]
			private RectTransform m_bottomView;

			// Token: 0x040235A9 RID: 144809
			[Token(Token = "0x40235A9")]
			[FieldOffset(Offset = "0x50")]
			private RectTransform m_centerView;

			// Token: 0x040235AA RID: 144810
			[Token(Token = "0x40235AA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040235AB RID: 144811
			[Token(Token = "0x40235AB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x040235AC RID: 144812
			[Token(Token = "0x40235AC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x040235AD RID: 144813
			[Token(Token = "0x40235AD")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x040235AE RID: 144814
			[Token(Token = "0x40235AE")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x040235AF RID: 144815
			[Token(Token = "0x40235AF")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
