using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL01
{
	// Token: 0x0200465B RID: 18011
	[Token(Token = "0x200465B")]
	public class Rl01OuterBuffTokenView : DataBinder<RoguelikeTopicOuterBuffSkillTreeProperty>
	{
		// Token: 0x17004126 RID: 16678
		// (get) Token: 0x0601B5A6 RID: 112038 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B5A7 RID: 112039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004126")]
		private Rl01TopicOuterBuffController bindTopicController
		{
			[Token(Token = "0x601B5A6")]
			[Address(RVA = "0x14ADCB0", Offset = "0x14AC8B0", VA = "0x1814ADCB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B5A7")]
			[Address(RVA = "0x14ADD10", Offset = "0x14AC910", VA = "0x1814ADD10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B5A8 RID: 112040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5A8")]
		[Address(RVA = "0x14AD810", Offset = "0x14AC410", VA = "0x1814AD810", Slot = "8")]
		public virtual void Init(Rl01TopicOuterBuffController topicController)
		{
		}

		// Token: 0x0601B5A9 RID: 112041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5A9")]
		[Address(RVA = "0x14AD960", Offset = "0x14AC560", VA = "0x1814AD960", Slot = "7")]
		public override void OnValueChanged(RoguelikeTopicOuterBuffSkillTreeProperty property)
		{
		}

		// Token: 0x0601B5AA RID: 112042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5AA")]
		[Address(RVA = "0x14ADB00", Offset = "0x14AC700", VA = "0x1814ADB00")]
		private void _Render(RoguelikeTopicOuterBuffSkillTreeModel model)
		{
		}

		// Token: 0x0601B5AB RID: 112043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5AB")]
		[Address(RVA = "0x14ADC40", Offset = "0x14AC840", VA = "0x1814ADC40")]
		public Rl01OuterBuffTokenView()
		{
		}

		// Token: 0x0402357C RID: 144764
		[Token(Token = "0x402357C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textTokenNum;

		// Token: 0x0402357D RID: 144765
		[Token(Token = "0x402357D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTokenName;

		// Token: 0x0402357E RID: 144766
		[Token(Token = "0x402357E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _iconToken;

		// Token: 0x0402357F RID: 144767
		[Token(Token = "0x402357F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage _imgAllCompleted;

		// Token: 0x04023580 RID: 144768
		[Token(Token = "0x4023580")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _bkgLeft;

		// Token: 0x04023581 RID: 144769
		[Token(Token = "0x4023581")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _bkg;

		// Token: 0x04023582 RID: 144770
		[Token(Token = "0x4023582")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _pnlNotCompleted;

		// Token: 0x04023583 RID: 144771
		[Token(Token = "0x4023583")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _pnlCompleted;

		// Token: 0x04023584 RID: 144772
		[Token(Token = "0x4023584")]
		[FieldOffset(Offset = "0x60")]
		private string m_cachedTopicId;

		// Token: 0x04023585 RID: 144773
		[Token(Token = "0x4023585")]
		[FieldOffset(Offset = "0x68")]
		private Rl01OuterBuffTokenView.SwitchTween m_switchTween;

		// Token: 0x04023587 RID: 144775
		[Token(Token = "0x4023587")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bindTopicController;

		// Token: 0x04023588 RID: 144776
		[Token(Token = "0x4023588")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_bindTopicController;

		// Token: 0x04023589 RID: 144777
		[Token(Token = "0x4023589")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402358A RID: 144778
		[Token(Token = "0x402358A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402358B RID: 144779
		[Token(Token = "0x402358B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0402358C RID: 144780
		[Token(Token = "0x402358C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200465C RID: 18012
		[Token(Token = "0x200465C")]
		private class SwitchTween : UISwitchTween
		{
			// Token: 0x0601B5AC RID: 112044 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B5AC")]
			[Address(RVA = "0x14C0C40", Offset = "0x14BF840", VA = "0x1814C0C40")]
			public SwitchTween(Rl01OuterBuffTokenView closure)
			{
			}

			// Token: 0x0601B5AD RID: 112045 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B5AD")]
			[Address(RVA = "0x14C0830", Offset = "0x14BF430", VA = "0x1814C0830", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601B5AE RID: 112046 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B5AE")]
			[Address(RVA = "0x14C09A0", Offset = "0x14BF5A0", VA = "0x1814C09A0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601B5AF RID: 112047 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B5AF")]
			[Address(RVA = "0x14C0710", Offset = "0x14BF310", VA = "0x1814C0710", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x0601B5B0 RID: 112048 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B5B0")]
			[Address(RVA = "0x14C05F0", Offset = "0x14BF1F0", VA = "0x1814C05F0", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0601B5B1 RID: 112049 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B5B1")]
			[Address(RVA = "0x14C0680", Offset = "0x14BF280", VA = "0x1814C0680", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x0601B5B2 RID: 112050 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B5B2")]
			[Address(RVA = "0x14C07A0", Offset = "0x14BF3A0", VA = "0x1814C07A0", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0601B5B3 RID: 112051 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B5B3")]
			[Address(RVA = "0x14C0B10", Offset = "0x14BF710", VA = "0x1814C0B10", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601B5B4 RID: 112052 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B5B4")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x0601B5B5 RID: 112053 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B5B5")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0601B5B6 RID: 112054 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B5B6")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x0601B5B7 RID: 112055 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B5B7")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0601B5B8 RID: 112056 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B5B8")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0402358D RID: 144781
			[Token(Token = "0x402358D")]
			private const float ANIM_DURATION = 0.16f;

			// Token: 0x0402358E RID: 144782
			[Token(Token = "0x402358E")]
			[FieldOffset(Offset = "0x48")]
			private Rl01OuterBuffTokenView m_closure;

			// Token: 0x0402358F RID: 144783
			[Token(Token = "0x402358F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04023590 RID: 144784
			[Token(Token = "0x4023590")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04023591 RID: 144785
			[Token(Token = "0x4023591")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04023592 RID: 144786
			[Token(Token = "0x4023592")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x04023593 RID: 144787
			[Token(Token = "0x4023593")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x04023594 RID: 144788
			[Token(Token = "0x4023594")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;

			// Token: 0x04023595 RID: 144789
			[Token(Token = "0x4023595")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x04023596 RID: 144790
			[Token(Token = "0x4023596")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
