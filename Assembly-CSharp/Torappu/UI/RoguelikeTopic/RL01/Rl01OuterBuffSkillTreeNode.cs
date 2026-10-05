using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL01
{
	// Token: 0x02004657 RID: 18007
	[Token(Token = "0x2004657")]
	public abstract class Rl01OuterBuffSkillTreeNode : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700411D RID: 16669
		// (get) Token: 0x0601B57B RID: 111995 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B57C RID: 111996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700411D")]
		public string buffId
		{
			[Token(Token = "0x601B57B")]
			[Address(RVA = "0x14A7E10", Offset = "0x14A6A10", VA = "0x1814A7E10")]
			get
			{
				return null;
			}
			[Token(Token = "0x601B57C")]
			[Address(RVA = "0x14A7FB0", Offset = "0x14A6BB0", VA = "0x1814A7FB0")]
			set
			{
			}
		}

		// Token: 0x1700411E RID: 16670
		// (get) Token: 0x0601B57D RID: 111997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700411E")]
		public List<Rl01OuterBuffSkillTreeNode.Rl01OuterBuffSkillTreeLine> connectLines
		{
			[Token(Token = "0x601B57D")]
			[Address(RVA = "0x14A7E70", Offset = "0x14A6A70", VA = "0x1814A7E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700411F RID: 16671
		// (get) Token: 0x0601B57E RID: 111998 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B57F RID: 111999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700411F")]
		protected Rl01TopicOuterBuffController bindTopicController
		{
			[Token(Token = "0x601B57E")]
			[Address(RVA = "0x14A7DB0", Offset = "0x14A69B0", VA = "0x1814A7DB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B57F")]
			[Address(RVA = "0x14A7F30", Offset = "0x14A6B30", VA = "0x1814A7F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004120 RID: 16672
		// (get) Token: 0x0601B580 RID: 112000 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B581 RID: 112001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004120")]
		protected Rl01OuterBuffSkillTreeView outerSkillTreeView
		{
			[Token(Token = "0x601B580")]
			[Address(RVA = "0x14A7ED0", Offset = "0x14A6AD0", VA = "0x1814A7ED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B581")]
			[Address(RVA = "0x14A8030", Offset = "0x14A6C30", VA = "0x1814A8030")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B582 RID: 112002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B582")]
		[Address(RVA = "0x14A7120", Offset = "0x14A5D20", VA = "0x1814A7120", Slot = "4")]
		public virtual void Init(Rl01TopicOuterBuffController controller, Rl01OuterBuffSkillTreeView outerView)
		{
		}

		// Token: 0x0601B583 RID: 112003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B583")]
		[Address(RVA = "0x14A75F0", Offset = "0x14A61F0", VA = "0x1814A75F0")]
		private void _InitIfNot(RoguelikeTopicOuterBuffSkillTreeNodeModel nodeModel)
		{
		}

		// Token: 0x0601B584 RID: 112004 RVA: 0x000A4EB0 File Offset: 0x000A30B0
		[Token(Token = "0x601B584")]
		[Address(RVA = "0x14A6FB0", Offset = "0x14A5BB0", VA = "0x1814A6FB0")]
		protected bool CanUpgrade()
		{
			return default(bool);
		}

		// Token: 0x0601B585 RID: 112005 RVA: 0x000A4EC8 File Offset: 0x000A30C8
		[Token(Token = "0x601B585")]
		[Address(RVA = "0x14A7080", Offset = "0x14A5C80", VA = "0x1814A7080")]
		protected float GetOuterBuffSkillTreeNodeAnimDelay(RoguelikeTopicDevNodeType nodeType)
		{
			return 0f;
		}

		// Token: 0x0601B586 RID: 112006 RVA: 0x000A4EE0 File Offset: 0x000A30E0
		[Token(Token = "0x601B586")]
		[Address(RVA = "0x14A7B30", Offset = "0x14A6730", VA = "0x1814A7B30")]
		private bool _UpdateFrontNodeUpgradedStatus(RoguelikeTopicOuterBuffSkillTreeNodeModel nodeModel, RoguelikeTopicOuterBuffSkillTreeModel model, out int changedFrontNodeIndex, out RoguelikeTopicDevNodeType changedFrontNodeType)
		{
			return default(bool);
		}

		// Token: 0x0601B587 RID: 112007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B587")]
		[Address(RVA = "0x14A7700", Offset = "0x14A6300", VA = "0x1814A7700")]
		private void _RenderFrontNodeUpgradedStatus(RoguelikeTopicOuterBuffSkillTreeNodeModel nodeModel, RoguelikeTopicOuterBuffSkillTreeModel model, bool isInit)
		{
		}

		// Token: 0x0601B588 RID: 112008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B588")]
		[Address(RVA = "0x14A7950", Offset = "0x14A6550", VA = "0x1814A7950")]
		private void _RenderIsUpgraded(RoguelikeTopicOuterBuffSkillTreeNodeModel nodeModel, bool isInit)
		{
		}

		// Token: 0x0601B589 RID: 112009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B589")]
		[Address(RVA = "0x14A7A10", Offset = "0x14A6610", VA = "0x1814A7A10")]
		private void _RenderSelection(RoguelikeTopicOuterBuffSkillTreeModel model, bool isInit)
		{
		}

		// Token: 0x0601B58A RID: 112010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B58A")]
		[Address(RVA = "0x14A7260", Offset = "0x14A5E60", VA = "0x1814A7260")]
		public void Render(RoguelikeTopicOuterBuffSkillTreeModel model)
		{
		}

		// Token: 0x0601B58B RID: 112011
		[Token(Token = "0x601B58B")]
		protected abstract void _DoInitIfNot(RoguelikeTopicOuterBuffSkillTreeNodeModel nodeModel);

		// Token: 0x0601B58C RID: 112012
		[Token(Token = "0x601B58C")]
		protected abstract void _DoRenderFrontNodeUpgradedStatus(bool[] frontIsUpgraded, int changedFrontNodeIndex, RoguelikeTopicDevNodeType changedFrontNodeType, bool isInit);

		// Token: 0x0601B58D RID: 112013
		[Token(Token = "0x601B58D")]
		protected abstract void _DoRenderIsUpgraded(bool isUpgraded, bool isInit);

		// Token: 0x0601B58E RID: 112014
		[Token(Token = "0x601B58E")]
		protected abstract void _DoRenderSelection(bool isSelected, bool isInit);

		// Token: 0x0601B58F RID: 112015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B58F")]
		[Address(RVA = "0x14A7CF0", Offset = "0x14A68F0", VA = "0x1814A7CF0")]
		protected Rl01OuterBuffSkillTreeNode()
		{
		}

		// Token: 0x0402353A RID: 144698
		[Token(Token = "0x402353A")]
		protected const float BRANCH_UNLOCK_ANIM_DURATION = 0.16f;

		// Token: 0x0402353B RID: 144699
		[Token(Token = "0x402353B")]
		protected const float MAIN_UNLOCK_ANIM_DURATION = 0.4f;

		// Token: 0x0402353C RID: 144700
		[Token(Token = "0x402353C")]
		protected const float BRANCH_UPGRADE_ANIM_DURATION = 0.4f;

		// Token: 0x0402353D RID: 144701
		[Token(Token = "0x402353D")]
		protected const float MAIN_UPGRADE_ANIM_DURATION = 0.56f;

		// Token: 0x0402353E RID: 144702
		[Token(Token = "0x402353E")]
		protected const float BRANCH_UPGRADE_ANIM_DELAY = 0.08f;

		// Token: 0x0402353F RID: 144703
		[Token(Token = "0x402353F")]
		protected const float MAIN_UPGRADE_ANIM_DELAY = 0.28f;

		// Token: 0x04023540 RID: 144704
		[Token(Token = "0x4023540")]
		protected const float PROGRESS_BAR_FILL_DURATION = 0.16f;

		// Token: 0x04023541 RID: 144705
		[Token(Token = "0x4023541")]
		protected const float PROGRESS_UNLOCK_ANIM_DURATION = 1.5f;

		// Token: 0x04023542 RID: 144706
		[Token(Token = "0x4023542")]
		protected const float PROGRESS_UNLOCK_ANIM_DELAY = 1.2f;

		// Token: 0x04023543 RID: 144707
		[Token(Token = "0x4023543")]
		protected const float SELECT_ANIM_DURATION = 0.15f;

		// Token: 0x04023544 RID: 144708
		[Token(Token = "0x4023544")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _buffId;

		// Token: 0x04023545 RID: 144709
		[Token(Token = "0x4023545")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Rl01OuterBuffSkillTreeNode.Rl01OuterBuffSkillTreeLine> _connectLines;

		// Token: 0x04023548 RID: 144712
		[Token(Token = "0x4023548")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x04023549 RID: 144713
		[Token(Token = "0x4023549")]
		[FieldOffset(Offset = "0x39")]
		private bool m_cachedIsUpgraded;

		// Token: 0x0402354A RID: 144714
		[Token(Token = "0x402354A")]
		[FieldOffset(Offset = "0x40")]
		private bool[] m_cachedFrontIsUpgraded;

		// Token: 0x0402354B RID: 144715
		[Token(Token = "0x402354B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_buffId;

		// Token: 0x0402354C RID: 144716
		[Token(Token = "0x402354C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_buffId;

		// Token: 0x0402354D RID: 144717
		[Token(Token = "0x402354D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_connectLines;

		// Token: 0x0402354E RID: 144718
		[Token(Token = "0x402354E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_bindTopicController;

		// Token: 0x0402354F RID: 144719
		[Token(Token = "0x402354F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_bindTopicController;

		// Token: 0x04023550 RID: 144720
		[Token(Token = "0x4023550")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_outerSkillTreeView;

		// Token: 0x04023551 RID: 144721
		[Token(Token = "0x4023551")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_outerSkillTreeView;

		// Token: 0x04023552 RID: 144722
		[Token(Token = "0x4023552")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04023553 RID: 144723
		[Token(Token = "0x4023553")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023554 RID: 144724
		[Token(Token = "0x4023554")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CanUpgrade;

		// Token: 0x04023555 RID: 144725
		[Token(Token = "0x4023555")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetOuterBuffSkillTreeNodeAnimDelay;

		// Token: 0x04023556 RID: 144726
		[Token(Token = "0x4023556")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateFrontNodeUpgradedStatus;

		// Token: 0x04023557 RID: 144727
		[Token(Token = "0x4023557")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__RenderFrontNodeUpgradedStatus;

		// Token: 0x04023558 RID: 144728
		[Token(Token = "0x4023558")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__RenderIsUpgraded;

		// Token: 0x04023559 RID: 144729
		[Token(Token = "0x4023559")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__RenderSelection;

		// Token: 0x0402355A RID: 144730
		[Token(Token = "0x402355A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402355B RID: 144731
		[Token(Token = "0x402355B")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004658 RID: 18008
		[Token(Token = "0x2004658")]
		protected class SelectedBorderSwitchTween : UISwitchTween
		{
			// Token: 0x0601B590 RID: 112016 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B590")]
			[Address(RVA = "0x14C0570", Offset = "0x14BF170", VA = "0x1814C0570")]
			public SelectedBorderSwitchTween(CanvasGroup borderSelected)
			{
			}

			// Token: 0x0601B591 RID: 112017 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B591")]
			[Address(RVA = "0x14C0310", Offset = "0x14BEF10", VA = "0x1814C0310", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601B592 RID: 112018 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B592")]
			[Address(RVA = "0x14C03E0", Offset = "0x14BEFE0", VA = "0x1814C03E0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601B593 RID: 112019 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B593")]
			[Address(RVA = "0x14C0210", Offset = "0x14BEE10", VA = "0x1814C0210", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0601B594 RID: 112020 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B594")]
			[Address(RVA = "0x14C0290", Offset = "0x14BEE90", VA = "0x1814C0290", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0601B595 RID: 112021 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B595")]
			[Address(RVA = "0x14C04C0", Offset = "0x14BF0C0", VA = "0x1814C04C0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601B596 RID: 112022 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B596")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0601B597 RID: 112023 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B597")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0601B598 RID: 112024 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B598")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0402355C RID: 144732
			[Token(Token = "0x402355C")]
			[FieldOffset(Offset = "0x48")]
			private CanvasGroup m_borderSelected;

			// Token: 0x0402355D RID: 144733
			[Token(Token = "0x402355D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402355E RID: 144734
			[Token(Token = "0x402355E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0402355F RID: 144735
			[Token(Token = "0x402355F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04023560 RID: 144736
			[Token(Token = "0x4023560")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x04023561 RID: 144737
			[Token(Token = "0x4023561")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x04023562 RID: 144738
			[Token(Token = "0x4023562")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}

		// Token: 0x02004659 RID: 18009
		[Token(Token = "0x2004659")]
		[Serializable]
		public class Rl01OuterBuffSkillTreeLine : IHotfixable
		{
			// Token: 0x0601B599 RID: 112025 RVA: 0x000A4EF8 File Offset: 0x000A30F8
			[Token(Token = "0x601B599")]
			[Address(RVA = "0x14ACAA0", Offset = "0x14AB6A0", VA = "0x1814ACAA0")]
			public float SetShow(bool show, float delay, bool isInit)
			{
				return 0f;
			}

			// Token: 0x0601B59A RID: 112026 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B59A")]
			[Address(RVA = "0x14ACC50", Offset = "0x14AB850", VA = "0x1814ACC50")]
			public Rl01OuterBuffSkillTreeLine()
			{
			}

			// Token: 0x04023563 RID: 144739
			[Token(Token = "0x4023563")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public List<Rl01OuterBuffSkillTreeLineSegment> lineSegments;

			// Token: 0x04023564 RID: 144740
			[Token(Token = "0x4023564")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetShow;

			// Token: 0x04023565 RID: 144741
			[Token(Token = "0x4023565")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
