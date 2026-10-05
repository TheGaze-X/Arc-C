using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL01
{
	// Token: 0x02004649 RID: 17993
	[Token(Token = "0x2004649")]
	public class Rl01OuterBuffSkillBranchNode : Rl01OuterBuffSkillTreeNode
	{
		// Token: 0x0601B521 RID: 111905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B521")]
		[Address(RVA = "0x14A51C0", Offset = "0x14A3DC0", VA = "0x1814A51C0", Slot = "5")]
		protected override void _DoInitIfNot(RoguelikeTopicOuterBuffSkillTreeNodeModel nodeModel)
		{
		}

		// Token: 0x0601B522 RID: 111906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B522")]
		[Address(RVA = "0x14A5300", Offset = "0x14A3F00", VA = "0x1814A5300", Slot = "6")]
		protected override void _DoRenderFrontNodeUpgradedStatus(bool[] frontIsUpgraded, int changedFrontNodeIndex, RoguelikeTopicDevNodeType changedFrontNodeType, bool isInit)
		{
		}

		// Token: 0x0601B523 RID: 111907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B523")]
		[Address(RVA = "0x14A56B0", Offset = "0x14A42B0", VA = "0x1814A56B0", Slot = "7")]
		protected override void _DoRenderIsUpgraded(bool isUpgraded, bool isInit)
		{
		}

		// Token: 0x0601B524 RID: 111908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B524")]
		[Address(RVA = "0x14A5830", Offset = "0x14A4430", VA = "0x1814A5830", Slot = "8")]
		protected override void _DoRenderSelection(bool isSelected, bool isInit)
		{
		}

		// Token: 0x0601B525 RID: 111909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B525")]
		[Address(RVA = "0x14A5040", Offset = "0x14A3C40", VA = "0x1814A5040")]
		public void EventOnButtonClicked()
		{
		}

		// Token: 0x0601B526 RID: 111910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B526")]
		[Address(RVA = "0x14A5950", Offset = "0x14A4550", VA = "0x1814A5950")]
		public Rl01OuterBuffSkillBranchNode()
		{
		}

		// Token: 0x040234B6 RID: 144566
		[Token(Token = "0x40234B6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _pnlLocked;

		// Token: 0x040234B7 RID: 144567
		[Token(Token = "0x40234B7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _pnlUnlocked;

		// Token: 0x040234B8 RID: 144568
		[Token(Token = "0x40234B8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _imgBuffIcon;

		// Token: 0x040234B9 RID: 144569
		[Token(Token = "0x40234B9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _borderSelected;

		// Token: 0x040234BA RID: 144570
		[Token(Token = "0x40234BA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button _btnNode;

		// Token: 0x040234BB RID: 144571
		[Token(Token = "0x40234BB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _animUnlock;

		// Token: 0x040234BC RID: 144572
		[Token(Token = "0x40234BC")]
		[FieldOffset(Offset = "0x80")]
		private Rl01OuterBuffSkillTreeNode.SelectedBorderSwitchTween m_selectedBorderSwitchTween;

		// Token: 0x040234BD RID: 144573
		[Token(Token = "0x40234BD")]
		[FieldOffset(Offset = "0x88")]
		private Rl01OuterBuffSkillBranchNode.UpgradedBorderSwitchTween m_upgradedBorderSwitchTween;

		// Token: 0x040234BE RID: 144574
		[Token(Token = "0x40234BE")]
		[FieldOffset(Offset = "0x90")]
		private Rl01OuterBuffSkillBranchNode.UnlockedSwitchTween m_unlockedSwitchTween;

		// Token: 0x040234BF RID: 144575
		[Token(Token = "0x40234BF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__DoInitIfNot;

		// Token: 0x040234C0 RID: 144576
		[Token(Token = "0x40234C0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__DoRenderFrontNodeUpgradedStatus;

		// Token: 0x040234C1 RID: 144577
		[Token(Token = "0x40234C1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__DoRenderIsUpgraded;

		// Token: 0x040234C2 RID: 144578
		[Token(Token = "0x40234C2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DoRenderSelection;

		// Token: 0x040234C3 RID: 144579
		[Token(Token = "0x40234C3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnButtonClicked;

		// Token: 0x040234C4 RID: 144580
		[Token(Token = "0x40234C4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200464A RID: 17994
		[Token(Token = "0x200464A")]
		private class UpgradedBorderSwitchTween : UISwitchTween
		{
			// Token: 0x0601B527 RID: 111911 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B527")]
			[Address(RVA = "0x14AA980", Offset = "0x14A9580", VA = "0x1814AA980")]
			public UpgradedBorderSwitchTween(Rl01OuterBuffSkillBranchNode closure)
			{
			}

			// Token: 0x0601B528 RID: 111912 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B528")]
			[Address(RVA = "0x14AA200", Offset = "0x14A8E00", VA = "0x1814AA200", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601B529 RID: 111913 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B529")]
			[Address(RVA = "0x14AA4C0", Offset = "0x14A90C0", VA = "0x1814AA4C0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601B52A RID: 111914 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B52A")]
			[Address(RVA = "0x14AA780", Offset = "0x14A9380", VA = "0x1814AA780", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601B52B RID: 111915 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B52B")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x040234C5 RID: 144581
			[Token(Token = "0x40234C5")]
			[FieldOffset(Offset = "0x48")]
			private Rl01OuterBuffSkillBranchNode m_closure;

			// Token: 0x040234C6 RID: 144582
			[Token(Token = "0x40234C6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040234C7 RID: 144583
			[Token(Token = "0x40234C7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x040234C8 RID: 144584
			[Token(Token = "0x40234C8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x040234C9 RID: 144585
			[Token(Token = "0x40234C9")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}

		// Token: 0x0200464B RID: 17995
		[Token(Token = "0x200464B")]
		private class UnlockedSwitchTween : UISwitchTween
		{
			// Token: 0x0601B52C RID: 111916 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B52C")]
			[Address(RVA = "0x14AA180", Offset = "0x14A8D80", VA = "0x1814AA180")]
			public UnlockedSwitchTween(Rl01OuterBuffSkillBranchNode closure)
			{
			}

			// Token: 0x0601B52D RID: 111917 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B52D")]
			[Address(RVA = "0x14A9370", Offset = "0x14A7F70", VA = "0x1814A9370", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601B52E RID: 111918 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B52E")]
			[Address(RVA = "0x14A9A40", Offset = "0x14A8640", VA = "0x1814A9A40", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601B52F RID: 111919 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B52F")]
			[Address(RVA = "0x14A9110", Offset = "0x14A7D10", VA = "0x1814A9110", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x0601B530 RID: 111920 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B530")]
			[Address(RVA = "0x14A8F40", Offset = "0x14A7B40", VA = "0x1814A8F40", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0601B531 RID: 111921 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B531")]
			[Address(RVA = "0x14A8FD0", Offset = "0x14A7BD0", VA = "0x1814A8FD0", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x0601B532 RID: 111922 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B532")]
			[Address(RVA = "0x14A92E0", Offset = "0x14A7EE0", VA = "0x1814A92E0", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0601B533 RID: 111923 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B533")]
			[Address(RVA = "0x14A9D40", Offset = "0x14A8940", VA = "0x1814A9D40", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601B534 RID: 111924 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B534")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x0601B535 RID: 111925 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B535")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0601B536 RID: 111926 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B536")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x0601B537 RID: 111927 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B537")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0601B538 RID: 111928 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B538")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x040234CA RID: 144586
			[Token(Token = "0x40234CA")]
			[FieldOffset(Offset = "0x48")]
			private Rl01OuterBuffSkillBranchNode m_closure;

			// Token: 0x040234CB RID: 144587
			[Token(Token = "0x40234CB")]
			[FieldOffset(Offset = "0x50")]
			public float showDelay;

			// Token: 0x040234CC RID: 144588
			[Token(Token = "0x40234CC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040234CD RID: 144589
			[Token(Token = "0x40234CD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x040234CE RID: 144590
			[Token(Token = "0x40234CE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x040234CF RID: 144591
			[Token(Token = "0x40234CF")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x040234D0 RID: 144592
			[Token(Token = "0x40234D0")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x040234D1 RID: 144593
			[Token(Token = "0x40234D1")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;

			// Token: 0x040234D2 RID: 144594
			[Token(Token = "0x40234D2")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x040234D3 RID: 144595
			[Token(Token = "0x40234D3")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
