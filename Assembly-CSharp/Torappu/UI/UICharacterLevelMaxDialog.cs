using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020034BB RID: 13499
	[Token(Token = "0x20034BB")]
	public class UICharacterLevelMaxDialog : UICompDialog<UICharacterLevelMaxDialog.Input>
	{
		// Token: 0x06015835 RID: 88117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015835")]
		[Address(RVA = "0xE0ED00", Offset = "0xE0D900", VA = "0x180E0ED00", Slot = "18")]
		protected override void OnRender(UICharacterLevelMaxDialog.Input input)
		{
		}

		// Token: 0x06015836 RID: 88118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015836")]
		[Address(RVA = "0xE0EAC0", Offset = "0xE0D6C0", VA = "0x180E0EAC0")]
		public void EventOnConfirmClick()
		{
		}

		// Token: 0x06015837 RID: 88119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015837")]
		[Address(RVA = "0xE0EB90", Offset = "0xE0D790", VA = "0x180E0EB90", Slot = "14")]
		public override UISwitchTween GenerateShowTween()
		{
			return null;
		}

		// Token: 0x06015838 RID: 88120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015838")]
		[Address(RVA = "0xE0F020", Offset = "0xE0DC20", VA = "0x180E0F020")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06015839 RID: 88121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015839")]
		[Address(RVA = "0xE0EE70", Offset = "0xE0DA70", VA = "0x180E0EE70")]
		private void TriggerWaitOnShowAnimStart()
		{
		}

		// Token: 0x0601583A RID: 88122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601583A")]
		[Address(RVA = "0xE0F0F0", Offset = "0xE0DCF0", VA = "0x180E0F0F0")]
		private IEnumerator _WaitOnShowAnimStartCoroutine()
		{
			return null;
		}

		// Token: 0x0601583B RID: 88123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601583B")]
		[Address(RVA = "0xE0F1A0", Offset = "0xE0DDA0", VA = "0x180E0F1A0")]
		public UICharacterLevelMaxDialog()
		{
		}

		// Token: 0x0601583C RID: 88124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601583C")]
		[Address(RVA = "0xE0F010", Offset = "0xE0DC10", VA = "0x180E0F010")]
		private UISwitchTween <>xLuaBaseProxy_GenerateShowTween()
		{
			return null;
		}

		// Token: 0x04019C7A RID: 105594
		[Token(Token = "0x4019C7A")]
		private const float DURATION_ANIM_CAN_SKIP = 1f;

		// Token: 0x04019C7B RID: 105595
		[Token(Token = "0x4019C7B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UICharacterLevelMaxView _maxView;

		// Token: 0x04019C7C RID: 105596
		[Token(Token = "0x4019C7C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UICharacterLevelMaxBindWrapper _bindWrapper;

		// Token: 0x04019C7D RID: 105597
		[Token(Token = "0x4019C7D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _showAnim;

		// Token: 0x04019C7E RID: 105598
		[Token(Token = "0x4019C7E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UICommonPageEffectHolder _effectHolder;

		// Token: 0x04019C7F RID: 105599
		[Token(Token = "0x4019C7F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CanvasGroup _rootGroup;

		// Token: 0x04019C80 RID: 105600
		[Token(Token = "0x4019C80")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_hasInited;

		// Token: 0x04019C81 RID: 105601
		[Token(Token = "0x4019C81")]
		[FieldOffset(Offset = "0xA8")]
		private UICharacterLevelMaxDialog.DialogSwitchTween m_cachedTween;

		// Token: 0x04019C82 RID: 105602
		[Token(Token = "0x4019C82")]
		[FieldOffset(Offset = "0xB0")]
		private UIPage m_page;

		// Token: 0x04019C83 RID: 105603
		[Token(Token = "0x4019C83")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_animPlaying;

		// Token: 0x04019C84 RID: 105604
		[Token(Token = "0x4019C84")]
		[FieldOffset(Offset = "0xC0")]
		private Coroutine m_waitCoroutine;

		// Token: 0x04019C85 RID: 105605
		[Token(Token = "0x4019C85")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04019C86 RID: 105606
		[Token(Token = "0x4019C86")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnConfirmClick;

		// Token: 0x04019C87 RID: 105607
		[Token(Token = "0x4019C87")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenerateShowTween;

		// Token: 0x04019C88 RID: 105608
		[Token(Token = "0x4019C88")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04019C89 RID: 105609
		[Token(Token = "0x4019C89")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TriggerWaitOnShowAnimStart;

		// Token: 0x04019C8A RID: 105610
		[Token(Token = "0x4019C8A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__WaitOnShowAnimStartCoroutine;

		// Token: 0x04019C8B RID: 105611
		[Token(Token = "0x4019C8B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020034BC RID: 13500
		[Token(Token = "0x20034BC")]
		public class Input
		{
			// Token: 0x0601583D RID: 88125 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601583D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x04019C8C RID: 105612
			[Token(Token = "0x4019C8C")]
			[FieldOffset(Offset = "0x10")]
			public UIPage page;

			// Token: 0x04019C8D RID: 105613
			[Token(Token = "0x4019C8D")]
			[FieldOffset(Offset = "0x18")]
			public int instId;

			// Token: 0x04019C8E RID: 105614
			[Token(Token = "0x4019C8E")]
			[FieldOffset(Offset = "0x1C")]
			public int fromLevel;
		}

		// Token: 0x020034BD RID: 13501
		[Token(Token = "0x20034BD")]
		private class DialogSwitchTween : UISwitchTween
		{
			// Token: 0x0601583E RID: 88126 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601583E")]
			[Address(RVA = "0xDFAF20", Offset = "0xDF9B20", VA = "0x180DFAF20")]
			public DialogSwitchTween(UICharacterLevelMaxDialog closure)
			{
			}

			// Token: 0x0601583F RID: 88127 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601583F")]
			[Address(RVA = "0xDFAAC0", Offset = "0xDF96C0", VA = "0x180DFAAC0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x06015840 RID: 88128 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6015840")]
			[Address(RVA = "0xDFABA0", Offset = "0xDF97A0", VA = "0x180DFABA0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x06015841 RID: 88129 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015841")]
			[Address(RVA = "0xDFAE50", Offset = "0xDF9A50", VA = "0x180DFAE50", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x06015842 RID: 88130 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015842")]
			[Address(RVA = "0xDFA9D0", Offset = "0xDF95D0", VA = "0x180DFA9D0", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x06015843 RID: 88131 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015843")]
			[Address(RVA = "0xDFA950", Offset = "0xDF9550", VA = "0x180DFA950", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x06015844 RID: 88132 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015844")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x06015845 RID: 88133 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015845")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x06015846 RID: 88134 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015846")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x04019C8F RID: 105615
			[Token(Token = "0x4019C8F")]
			private const float HIDE_DURATION = 0.12f;

			// Token: 0x04019C90 RID: 105616
			[Token(Token = "0x4019C90")]
			[FieldOffset(Offset = "0x48")]
			private readonly UICharacterLevelMaxDialog m_closure;

			// Token: 0x04019C91 RID: 105617
			[Token(Token = "0x4019C91")]
			[FieldOffset(Offset = "0x50")]
			private readonly string m_animName;

			// Token: 0x04019C92 RID: 105618
			[Token(Token = "0x4019C92")]
			[FieldOffset(Offset = "0x58")]
			private readonly AnimationWrapper m_wrapper;

			// Token: 0x04019C93 RID: 105619
			[Token(Token = "0x4019C93")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04019C94 RID: 105620
			[Token(Token = "0x4019C94")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04019C95 RID: 105621
			[Token(Token = "0x4019C95")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04019C96 RID: 105622
			[Token(Token = "0x4019C96")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;

			// Token: 0x04019C97 RID: 105623
			[Token(Token = "0x4019C97")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x04019C98 RID: 105624
			[Token(Token = "0x4019C98")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;
		}
	}
}
