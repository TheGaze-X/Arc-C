using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL01
{
	// Token: 0x0200464C RID: 17996
	[Token(Token = "0x200464C")]
	public class Rl01OuterBuffSkillMainNode : Rl01OuterBuffSkillTreeNode
	{
		// Token: 0x17004115 RID: 16661
		// (get) Token: 0x0601B539 RID: 111929 RVA: 0x000A4DF0 File Offset: 0x000A2FF0
		// (set) Token: 0x0601B53A RID: 111930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004115")]
		public int layerIndex
		{
			[Token(Token = "0x601B539")]
			[Address(RVA = "0x14A6560", Offset = "0x14A5160", VA = "0x1814A6560")]
			private get
			{
				return 0;
			}
			[Token(Token = "0x601B53A")]
			[Address(RVA = "0x14A6640", Offset = "0x14A5240", VA = "0x1814A6640")]
			set
			{
			}
		}

		// Token: 0x17004116 RID: 16662
		// (get) Token: 0x0601B53B RID: 111931 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B53C RID: 111932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004116")]
		public Rl01OuterBuffSkillTreeNode.Rl01OuterBuffSkillTreeLine innerLine
		{
			[Token(Token = "0x601B53B")]
			[Address(RVA = "0x14A6500", Offset = "0x14A5100", VA = "0x1814A6500")]
			private get
			{
				return null;
			}
			[Token(Token = "0x601B53C")]
			[Address(RVA = "0x14A65C0", Offset = "0x14A51C0", VA = "0x1814A65C0")]
			set
			{
			}
		}

		// Token: 0x0601B53D RID: 111933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B53D")]
		[Address(RVA = "0x14A59B0", Offset = "0x14A45B0", VA = "0x1814A59B0", Slot = "4")]
		public override void Init(Rl01TopicOuterBuffController controller, Rl01OuterBuffSkillTreeView outerView)
		{
		}

		// Token: 0x0601B53E RID: 111934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B53E")]
		[Address(RVA = "0x14A5B90", Offset = "0x14A4790", VA = "0x1814A5B90", Slot = "5")]
		protected override void _DoInitIfNot(RoguelikeTopicOuterBuffSkillTreeNodeModel nodeModel)
		{
		}

		// Token: 0x0601B53F RID: 111935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B53F")]
		[Address(RVA = "0x14A5D20", Offset = "0x14A4920", VA = "0x1814A5D20", Slot = "6")]
		protected override void _DoRenderFrontNodeUpgradedStatus(bool[] frontIsUpgraded, int changedFrontNodeIndex, RoguelikeTopicDevNodeType changedFrontNodeType, bool isInit)
		{
		}

		// Token: 0x0601B540 RID: 111936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B540")]
		[Address(RVA = "0x14A6150", Offset = "0x14A4D50", VA = "0x1814A6150", Slot = "7")]
		protected override void _DoRenderIsUpgraded(bool isUpgraded, bool isInit)
		{
		}

		// Token: 0x0601B541 RID: 111937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B541")]
		[Address(RVA = "0x14A6320", Offset = "0x14A4F20", VA = "0x1814A6320", Slot = "8")]
		protected override void _DoRenderSelection(bool isSelected, bool isInit)
		{
		}

		// Token: 0x0601B542 RID: 111938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B542")]
		[Address(RVA = "0x14A64A0", Offset = "0x14A50A0", VA = "0x1814A64A0")]
		public Rl01OuterBuffSkillMainNode()
		{
		}

		// Token: 0x0601B543 RID: 111939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B543")]
		[Address(RVA = "0x14A5B80", Offset = "0x14A4780", VA = "0x1814A5B80")]
		private void <>xLuaBaseProxy_Init(Rl01TopicOuterBuffController P0, Rl01OuterBuffSkillTreeView P1)
		{
		}

		// Token: 0x040234D4 RID: 144596
		[Token(Token = "0x40234D4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Rl01OuterBuffSkillMainNode.MainNode _mainNode;

		// Token: 0x040234D5 RID: 144597
		[Token(Token = "0x40234D5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Rl01OuterBuffSkillMainNode.ProgressNode _progressNode;

		// Token: 0x040234D6 RID: 144598
		[Token(Token = "0x40234D6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Rl01OuterBuffSkillMainNode.ProgressBar _progressBar;

		// Token: 0x040234D7 RID: 144599
		[Token(Token = "0x40234D7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private int _layerIndex;

		// Token: 0x040234D8 RID: 144600
		[Token(Token = "0x40234D8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Rl01OuterBuffSkillTreeNode.Rl01OuterBuffSkillTreeLine _innerLine;

		// Token: 0x040234D9 RID: 144601
		[Token(Token = "0x40234D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_layerIndex;

		// Token: 0x040234DA RID: 144602
		[Token(Token = "0x40234DA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_layerIndex;

		// Token: 0x040234DB RID: 144603
		[Token(Token = "0x40234DB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_innerLine;

		// Token: 0x040234DC RID: 144604
		[Token(Token = "0x40234DC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_innerLine;

		// Token: 0x040234DD RID: 144605
		[Token(Token = "0x40234DD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040234DE RID: 144606
		[Token(Token = "0x40234DE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__DoInitIfNot;

		// Token: 0x040234DF RID: 144607
		[Token(Token = "0x40234DF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__DoRenderFrontNodeUpgradedStatus;

		// Token: 0x040234E0 RID: 144608
		[Token(Token = "0x40234E0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__DoRenderIsUpgraded;

		// Token: 0x040234E1 RID: 144609
		[Token(Token = "0x40234E1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__DoRenderSelection;

		// Token: 0x040234E2 RID: 144610
		[Token(Token = "0x40234E2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200464D RID: 17997
		[Token(Token = "0x200464D")]
		[Serializable]
		private class MainNode : IHotfixable
		{
			// Token: 0x17004117 RID: 16663
			// (get) Token: 0x0601B544 RID: 111940 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601B545 RID: 111941 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004117")]
			public Rl01OuterBuffSkillMainNode closure
			{
				[Token(Token = "0x601B544")]
				[Address(RVA = "0x1498860", Offset = "0x1497460", VA = "0x181498860")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x601B545")]
				[Address(RVA = "0x14988C0", Offset = "0x14974C0", VA = "0x1814988C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0601B546 RID: 111942 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B546")]
			[Address(RVA = "0x1497EE0", Offset = "0x1496AE0", VA = "0x181497EE0")]
			public void DoInitIfNot(RoguelikeTopicOuterBuffSkillTreeNodeModel nodeModel)
			{
			}

			// Token: 0x0601B547 RID: 111943 RVA: 0x000A4E08 File Offset: 0x000A3008
			[Token(Token = "0x601B547")]
			[Address(RVA = "0x14981E0", Offset = "0x1496DE0", VA = "0x1814981E0")]
			public float DoRenderFrontNodeUpgradedStatus(bool canUpgrade, float delay, bool isInit)
			{
				return 0f;
			}

			// Token: 0x0601B548 RID: 111944 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B548")]
			[Address(RVA = "0x1498380", Offset = "0x1496F80", VA = "0x181498380")]
			public void DoRenderIsUpgraded(bool isUpgraded, bool isInit)
			{
			}

			// Token: 0x0601B549 RID: 111945 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B549")]
			[Address(RVA = "0x14984F0", Offset = "0x14970F0", VA = "0x1814984F0")]
			public void DoRenderSelection(bool isSelected, bool isInit)
			{
			}

			// Token: 0x0601B54A RID: 111946 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B54A")]
			[Address(RVA = "0x1498610", Offset = "0x1497210", VA = "0x181498610")]
			public void EventOnButtonClicked()
			{
			}

			// Token: 0x0601B54B RID: 111947 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B54B")]
			[Address(RVA = "0x1498800", Offset = "0x1497400", VA = "0x181498800")]
			public MainNode()
			{
			}

			// Token: 0x040234E3 RID: 144611
			[Token(Token = "0x40234E3")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private CanvasGroup _pnlLocked;

			// Token: 0x040234E4 RID: 144612
			[Token(Token = "0x40234E4")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private CanvasGroup _pnlUnlocked;

			// Token: 0x040234E5 RID: 144613
			[Token(Token = "0x40234E5")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Image _imgBuffIcon;

			// Token: 0x040234E6 RID: 144614
			[Token(Token = "0x40234E6")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private CanvasGroup _borderSelected;

			// Token: 0x040234E7 RID: 144615
			[Token(Token = "0x40234E7")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Image _imgStageNum;

			// Token: 0x040234E8 RID: 144616
			[Token(Token = "0x40234E8")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private Image _imgStageNumBottom;

			// Token: 0x040234E9 RID: 144617
			[Token(Token = "0x40234E9")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private Button _btnNode;

			// Token: 0x040234EA RID: 144618
			[Token(Token = "0x40234EA")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			private UIAnimationLocation _animUnlock;

			// Token: 0x040234EC RID: 144620
			[Token(Token = "0x40234EC")]
			[FieldOffset(Offset = "0x60")]
			private Rl01OuterBuffSkillMainNode.MainNode.UpgradedBorderSwitchTween m_upgradedBorderSwitchTween;

			// Token: 0x040234ED RID: 144621
			[Token(Token = "0x40234ED")]
			[FieldOffset(Offset = "0x68")]
			private Rl01OuterBuffSkillTreeNode.SelectedBorderSwitchTween m_selectedBorderSwitchTween;

			// Token: 0x040234EE RID: 144622
			[Token(Token = "0x40234EE")]
			[FieldOffset(Offset = "0x70")]
			private Rl01OuterBuffSkillMainNode.MainNode.UnlockedSwitchTween m_unlockedSwitchTween;

			// Token: 0x040234EF RID: 144623
			[Token(Token = "0x40234EF")]
			[FieldOffset(Offset = "0x78")]
			private bool m_cachedCanUpgrade;

			// Token: 0x040234F0 RID: 144624
			[Token(Token = "0x40234F0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_closure;

			// Token: 0x040234F1 RID: 144625
			[Token(Token = "0x40234F1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_closure;

			// Token: 0x040234F2 RID: 144626
			[Token(Token = "0x40234F2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_DoInitIfNot;

			// Token: 0x040234F3 RID: 144627
			[Token(Token = "0x40234F3")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_DoRenderFrontNodeUpgradedStatus;

			// Token: 0x040234F4 RID: 144628
			[Token(Token = "0x40234F4")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_DoRenderIsUpgraded;

			// Token: 0x040234F5 RID: 144629
			[Token(Token = "0x40234F5")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_DoRenderSelection;

			// Token: 0x040234F6 RID: 144630
			[Token(Token = "0x40234F6")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_EventOnButtonClicked;

			// Token: 0x040234F7 RID: 144631
			[Token(Token = "0x40234F7")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0200464E RID: 17998
			[Token(Token = "0x200464E")]
			private class UpgradedBorderSwitchTween : UISwitchTween
			{
				// Token: 0x0601B54C RID: 111948 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601B54C")]
				[Address(RVA = "0x14AA900", Offset = "0x14A9500", VA = "0x1814AA900")]
				public UpgradedBorderSwitchTween(Rl01OuterBuffSkillMainNode.MainNode closure)
				{
				}

				// Token: 0x0601B54D RID: 111949 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x601B54D")]
				[Address(RVA = "0x14AA360", Offset = "0x14A8F60", VA = "0x1814AA360", Slot = "5")]
				protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
				{
					return null;
				}

				// Token: 0x0601B54E RID: 111950 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x601B54E")]
				[Address(RVA = "0x14AA620", Offset = "0x14A9220", VA = "0x1814AA620", Slot = "4")]
				protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
				{
					return null;
				}

				// Token: 0x0601B54F RID: 111951 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601B54F")]
				[Address(RVA = "0x14AA840", Offset = "0x14A9440", VA = "0x1814AA840", Slot = "10")]
				protected override void ResetToState(bool isShow)
				{
				}

				// Token: 0x0601B550 RID: 111952 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601B550")]
				[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
				private void <>xLuaBaseProxy_ResetToState(bool P0)
				{
				}

				// Token: 0x040234F8 RID: 144632
				[Token(Token = "0x40234F8")]
				[FieldOffset(Offset = "0x48")]
				private Rl01OuterBuffSkillMainNode.MainNode m_closure;

				// Token: 0x040234F9 RID: 144633
				[Token(Token = "0x40234F9")]
				[FieldOffset(Offset = "0x0")]
				private static DelegateBridge _c__Hotfix0_ctor;

				// Token: 0x040234FA RID: 144634
				[Token(Token = "0x40234FA")]
				[FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

				// Token: 0x040234FB RID: 144635
				[Token(Token = "0x40234FB")]
				[FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

				// Token: 0x040234FC RID: 144636
				[Token(Token = "0x40234FC")]
				[FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_ResetToState;
			}

			// Token: 0x0200464F RID: 17999
			[Token(Token = "0x200464F")]
			private class UnlockedSwitchTween : UISwitchTween
			{
				// Token: 0x0601B551 RID: 111953 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601B551")]
				[Address(RVA = "0x14AA080", Offset = "0x14A8C80", VA = "0x1814AA080")]
				public UnlockedSwitchTween(Rl01OuterBuffSkillMainNode.MainNode closure)
				{
				}

				// Token: 0x0601B552 RID: 111954 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x601B552")]
				[Address(RVA = "0x14A9640", Offset = "0x14A8240", VA = "0x1814A9640", Slot = "5")]
				protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
				{
					return null;
				}

				// Token: 0x0601B553 RID: 111955 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x601B553")]
				[Address(RVA = "0x14A9BC0", Offset = "0x14A87C0", VA = "0x1814A9BC0", Slot = "4")]
				protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
				{
					return null;
				}

				// Token: 0x0601B554 RID: 111956 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601B554")]
				[Address(RVA = "0x14A91B0", Offset = "0x14A7DB0", VA = "0x1814A91B0", Slot = "7")]
				protected override void BeforeHideEffect()
				{
				}

				// Token: 0x0601B555 RID: 111957 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601B555")]
				[Address(RVA = "0x14A8EB0", Offset = "0x14A7AB0", VA = "0x1814A8EB0", Slot = "9")]
				protected override void AfterHideEffect()
				{
				}

				// Token: 0x0601B556 RID: 111958 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601B556")]
				[Address(RVA = "0x14A9070", Offset = "0x14A7C70", VA = "0x1814A9070", Slot = "8")]
				protected override void AfterShowEffect()
				{
				}

				// Token: 0x0601B557 RID: 111959 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601B557")]
				[Address(RVA = "0x14A9250", Offset = "0x14A7E50", VA = "0x1814A9250", Slot = "6")]
				protected override void BeforeShowEffect()
				{
				}

				// Token: 0x0601B558 RID: 111960 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601B558")]
				[Address(RVA = "0x14A9E80", Offset = "0x14A8A80", VA = "0x1814A9E80", Slot = "10")]
				protected override void ResetToState(bool isShow)
				{
				}

				// Token: 0x0601B559 RID: 111961 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601B559")]
				[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
				private void <>xLuaBaseProxy_BeforeHideEffect()
				{
				}

				// Token: 0x0601B55A RID: 111962 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601B55A")]
				[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
				private void <>xLuaBaseProxy_AfterHideEffect()
				{
				}

				// Token: 0x0601B55B RID: 111963 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601B55B")]
				[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
				private void <>xLuaBaseProxy_AfterShowEffect()
				{
				}

				// Token: 0x0601B55C RID: 111964 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601B55C")]
				[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
				private void <>xLuaBaseProxy_BeforeShowEffect()
				{
				}

				// Token: 0x0601B55D RID: 111965 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601B55D")]
				[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
				private void <>xLuaBaseProxy_ResetToState(bool P0)
				{
				}

				// Token: 0x040234FD RID: 144637
				[Token(Token = "0x40234FD")]
				[FieldOffset(Offset = "0x48")]
				private Rl01OuterBuffSkillMainNode.MainNode m_closure;

				// Token: 0x040234FE RID: 144638
				[Token(Token = "0x40234FE")]
				[FieldOffset(Offset = "0x50")]
				public float showDelay;

				// Token: 0x040234FF RID: 144639
				[Token(Token = "0x40234FF")]
				[FieldOffset(Offset = "0x0")]
				private static DelegateBridge _c__Hotfix0_ctor;

				// Token: 0x04023500 RID: 144640
				[Token(Token = "0x4023500")]
				[FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

				// Token: 0x04023501 RID: 144641
				[Token(Token = "0x4023501")]
				[FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

				// Token: 0x04023502 RID: 144642
				[Token(Token = "0x4023502")]
				[FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_BeforeHideEffect;

				// Token: 0x04023503 RID: 144643
				[Token(Token = "0x4023503")]
				[FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_AfterHideEffect;

				// Token: 0x04023504 RID: 144644
				[Token(Token = "0x4023504")]
				[FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0_AfterShowEffect;

				// Token: 0x04023505 RID: 144645
				[Token(Token = "0x4023505")]
				[FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0_BeforeShowEffect;

				// Token: 0x04023506 RID: 144646
				[Token(Token = "0x4023506")]
				[FieldOffset(Offset = "0x38")]
				private static DelegateBridge __Hotfix0_ResetToState;
			}
		}

		// Token: 0x02004650 RID: 18000
		[Token(Token = "0x2004650")]
		[Serializable]
		private class ProgressNode : IHotfixable
		{
			// Token: 0x17004118 RID: 16664
			// (get) Token: 0x0601B55E RID: 111966 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601B55F RID: 111967 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004118")]
			public Rl01OuterBuffSkillMainNode closure
			{
				[Token(Token = "0x601B55E")]
				[Address(RVA = "0x1499990", Offset = "0x1498590", VA = "0x181499990")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x601B55F")]
				[Address(RVA = "0x14999F0", Offset = "0x14985F0", VA = "0x1814999F0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0601B560 RID: 111968 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B560")]
			[Address(RVA = "0x1499690", Offset = "0x1498290", VA = "0x181499690")]
			public void DoInitIfNot(RoguelikeTopicOuterBuffSkillTreeNodeModel nodeModel)
			{
			}

			// Token: 0x0601B561 RID: 111969 RVA: 0x000A4E20 File Offset: 0x000A3020
			[Token(Token = "0x601B561")]
			[Address(RVA = "0x1499790", Offset = "0x1498390", VA = "0x181499790")]
			public float DoRenderFrontNodeUpgradedStatus(bool canUpgrade, float delay, bool isInit)
			{
				return 0f;
			}

			// Token: 0x0601B562 RID: 111970 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B562")]
			[Address(RVA = "0x1499930", Offset = "0x1498530", VA = "0x181499930")]
			public ProgressNode()
			{
			}

			// Token: 0x04023507 RID: 144647
			[Token(Token = "0x4023507")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private UIAnimationLocation _animUnlock;

			// Token: 0x04023508 RID: 144648
			[Token(Token = "0x4023508")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Text _unlockedText;

			// Token: 0x0402350A RID: 144650
			[Token(Token = "0x402350A")]
			[FieldOffset(Offset = "0x30")]
			private Rl01OuterBuffSkillMainNode.ProgressNode.UnlockedSwitchTween m_unlockedSwitchTween;

			// Token: 0x0402350B RID: 144651
			[Token(Token = "0x402350B")]
			[FieldOffset(Offset = "0x38")]
			private bool m_cachedCanUpgrade;

			// Token: 0x0402350C RID: 144652
			[Token(Token = "0x402350C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_closure;

			// Token: 0x0402350D RID: 144653
			[Token(Token = "0x402350D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_closure;

			// Token: 0x0402350E RID: 144654
			[Token(Token = "0x402350E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_DoInitIfNot;

			// Token: 0x0402350F RID: 144655
			[Token(Token = "0x402350F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_DoRenderFrontNodeUpgradedStatus;

			// Token: 0x04023510 RID: 144656
			[Token(Token = "0x4023510")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02004651 RID: 18001
			[Token(Token = "0x2004651")]
			private class UnlockedSwitchTween : UISwitchTween
			{
				// Token: 0x0601B563 RID: 111971 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601B563")]
				[Address(RVA = "0x14AA100", Offset = "0x14A8D00", VA = "0x1814AA100")]
				public UnlockedSwitchTween(Rl01OuterBuffSkillMainNode.ProgressNode closure)
				{
				}

				// Token: 0x0601B564 RID: 111972 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x601B564")]
				[Address(RVA = "0x14A94E0", Offset = "0x14A80E0", VA = "0x1814A94E0", Slot = "5")]
				protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
				{
					return null;
				}

				// Token: 0x0601B565 RID: 111973 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x601B565")]
				[Address(RVA = "0x14A97B0", Offset = "0x14A83B0", VA = "0x1814A97B0", Slot = "4")]
				protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
				{
					return null;
				}

				// Token: 0x0601B566 RID: 111974 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601B566")]
				[Address(RVA = "0x14A9FC0", Offset = "0x14A8BC0", VA = "0x1814A9FC0", Slot = "10")]
				protected override void ResetToState(bool isShow)
				{
				}

				// Token: 0x0601B567 RID: 111975 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601B567")]
				[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
				private void <>xLuaBaseProxy_ResetToState(bool P0)
				{
				}

				// Token: 0x04023511 RID: 144657
				[Token(Token = "0x4023511")]
				[FieldOffset(Offset = "0x48")]
				private Rl01OuterBuffSkillMainNode.ProgressNode m_closure;

				// Token: 0x04023512 RID: 144658
				[Token(Token = "0x4023512")]
				[FieldOffset(Offset = "0x50")]
				public float showDelay;

				// Token: 0x04023513 RID: 144659
				[Token(Token = "0x4023513")]
				[FieldOffset(Offset = "0x0")]
				private static DelegateBridge _c__Hotfix0_ctor;

				// Token: 0x04023514 RID: 144660
				[Token(Token = "0x4023514")]
				[FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

				// Token: 0x04023515 RID: 144661
				[Token(Token = "0x4023515")]
				[FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

				// Token: 0x04023516 RID: 144662
				[Token(Token = "0x4023516")]
				[FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_ResetToState;
			}
		}

		// Token: 0x02004653 RID: 18003
		[Token(Token = "0x2004653")]
		[Serializable]
		private class ProgressBar : IHotfixable
		{
			// Token: 0x17004119 RID: 16665
			// (get) Token: 0x0601B56B RID: 111979 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601B56C RID: 111980 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004119")]
			public Rl01OuterBuffSkillMainNode closure
			{
				[Token(Token = "0x601B56B")]
				[Address(RVA = "0x14995B0", Offset = "0x14981B0", VA = "0x1814995B0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x601B56C")]
				[Address(RVA = "0x1499610", Offset = "0x1498210", VA = "0x181499610")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0601B56D RID: 111981 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B56D")]
			[Address(RVA = "0x1499150", Offset = "0x1497D50", VA = "0x181499150")]
			public void DoInitIfNot(RoguelikeTopicOuterBuffSkillTreeNodeModel nodeModel)
			{
			}

			// Token: 0x0601B56E RID: 111982 RVA: 0x000A4E38 File Offset: 0x000A3038
			[Token(Token = "0x601B56E")]
			[Address(RVA = "0x14993B0", Offset = "0x1497FB0", VA = "0x1814993B0")]
			public float DoRenderFrontNodeUpgradedStatus(int progress, float delay, bool isInit)
			{
				return 0f;
			}

			// Token: 0x0601B56F RID: 111983 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B56F")]
			[Address(RVA = "0x1499550", Offset = "0x1498150", VA = "0x181499550")]
			public ProgressBar()
			{
			}

			// Token: 0x04023519 RID: 144665
			[Token(Token = "0x4023519")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Image _progressBarShadow;

			// Token: 0x0402351A RID: 144666
			[Token(Token = "0x402351A")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Image _progressBar;

			// Token: 0x0402351C RID: 144668
			[Token(Token = "0x402351C")]
			[FieldOffset(Offset = "0x28")]
			private int m_totalProgress;

			// Token: 0x0402351D RID: 144669
			[Token(Token = "0x402351D")]
			[FieldOffset(Offset = "0x2C")]
			private int m_cachedProgress;

			// Token: 0x0402351E RID: 144670
			[Token(Token = "0x402351E")]
			[FieldOffset(Offset = "0x30")]
			private Tween m_tween;

			// Token: 0x0402351F RID: 144671
			[Token(Token = "0x402351F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_closure;

			// Token: 0x04023520 RID: 144672
			[Token(Token = "0x4023520")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_closure;

			// Token: 0x04023521 RID: 144673
			[Token(Token = "0x4023521")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_DoInitIfNot;

			// Token: 0x04023522 RID: 144674
			[Token(Token = "0x4023522")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_DoRenderFrontNodeUpgradedStatus;

			// Token: 0x04023523 RID: 144675
			[Token(Token = "0x4023523")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
