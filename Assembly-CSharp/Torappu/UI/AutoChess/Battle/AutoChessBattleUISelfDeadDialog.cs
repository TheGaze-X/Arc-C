using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064A9 RID: 25769
	[Token(Token = "0x20064A9")]
	public class AutoChessBattleUISelfDeadDialog : UICompDialog<AutoChessBattleUISelfDeadDialog.Input>
	{
		// Token: 0x060250C9 RID: 151753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250C9")]
		[Address(RVA = "0x1FEDC30", Offset = "0x1FEC830", VA = "0x181FEDC30", Slot = "18")]
		protected override void OnRender(AutoChessBattleUISelfDeadDialog.Input input)
		{
		}

		// Token: 0x060250CA RID: 151754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60250CA")]
		[Address(RVA = "0x1FEDAB0", Offset = "0x1FEC6B0", VA = "0x181FEDAB0", Slot = "14")]
		public override UISwitchTween GenerateShowTween()
		{
			return null;
		}

		// Token: 0x060250CB RID: 151755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250CB")]
		[Address(RVA = "0x1FED9C0", Offset = "0x1FEC5C0", VA = "0x181FED9C0")]
		public void EventOnBtnWatchOther()
		{
		}

		// Token: 0x060250CC RID: 151756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250CC")]
		[Address(RVA = "0x1FED8D0", Offset = "0x1FEC4D0", VA = "0x181FED8D0")]
		public void EventOnBtnExit()
		{
		}

		// Token: 0x060250CD RID: 151757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250CD")]
		[Address(RVA = "0x1FEDCE0", Offset = "0x1FEC8E0", VA = "0x181FEDCE0")]
		public AutoChessBattleUISelfDeadDialog()
		{
		}

		// Token: 0x060250CE RID: 151758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60250CE")]
		[Address(RVA = "0xE0F010", Offset = "0xE0DC10", VA = "0x180E0F010")]
		private UISwitchTween <>xLuaBaseProxy_GenerateShowTween()
		{
			return null;
		}

		// Token: 0x04033DE1 RID: 212449
		[Token(Token = "0x4033DE1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04033DE2 RID: 212450
		[Token(Token = "0x4033DE2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x04033DE3 RID: 212451
		[Token(Token = "0x4033DE3")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _animQuit;

		// Token: 0x04033DE4 RID: 212452
		[Token(Token = "0x4033DE4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04033DE5 RID: 212453
		[Token(Token = "0x4033DE5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateShowTween;

		// Token: 0x04033DE6 RID: 212454
		[Token(Token = "0x4033DE6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnBtnWatchOther;

		// Token: 0x04033DE7 RID: 212455
		[Token(Token = "0x4033DE7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBtnExit;

		// Token: 0x04033DE8 RID: 212456
		[Token(Token = "0x4033DE8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020064AA RID: 25770
		[Token(Token = "0x20064AA")]
		public class DialogTween : UISwitchTween, IHotfixable
		{
			// Token: 0x060250CF RID: 151759 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60250CF")]
			[Address(RVA = "0x1FF0D10", Offset = "0x1FEF910", VA = "0x181FF0D10")]
			public DialogTween(CanvasGroup canvasGroup, UIAnimationLocation enterAnim, UIAnimationLocation quitAnim)
			{
			}

			// Token: 0x060250D0 RID: 151760 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60250D0")]
			[Address(RVA = "0x1FF09B0", Offset = "0x1FEF5B0", VA = "0x181FF09B0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x060250D1 RID: 151761 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60250D1")]
			[Address(RVA = "0x1FF0AF0", Offset = "0x1FEF6F0", VA = "0x181FF0AF0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x060250D2 RID: 151762 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60250D2")]
			[Address(RVA = "0x1FF0C30", Offset = "0x1FEF830", VA = "0x181FF0C30", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x060250D3 RID: 151763 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60250D3")]
			[Address(RVA = "0x1FF0910", Offset = "0x1FEF510", VA = "0x181FF0910", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x060250D4 RID: 151764 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60250D4")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x060250D5 RID: 151765 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60250D5")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x04033DE9 RID: 212457
			[Token(Token = "0x4033DE9")]
			[FieldOffset(Offset = "0x48")]
			private CanvasGroup m_canvasGroup;

			// Token: 0x04033DEA RID: 212458
			[Token(Token = "0x4033DEA")]
			[FieldOffset(Offset = "0x50")]
			private UIAnimationLocation m_enterAnim;

			// Token: 0x04033DEB RID: 212459
			[Token(Token = "0x4033DEB")]
			[FieldOffset(Offset = "0x60")]
			private UIAnimationLocation m_quitAnim;

			// Token: 0x04033DEC RID: 212460
			[Token(Token = "0x4033DEC")]
			[FieldOffset(Offset = "0x70")]
			private float m_duration;

			// Token: 0x04033DED RID: 212461
			[Token(Token = "0x4033DED")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033DEE RID: 212462
			[Token(Token = "0x4033DEE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04033DEF RID: 212463
			[Token(Token = "0x4033DEF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04033DF0 RID: 212464
			[Token(Token = "0x4033DF0")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;

			// Token: 0x04033DF1 RID: 212465
			[Token(Token = "0x4033DF1")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;
		}

		// Token: 0x020064AB RID: 25771
		[Token(Token = "0x20064AB")]
		public class Input
		{
			// Token: 0x060250D6 RID: 151766 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60250D6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}
		}

		// Token: 0x020064AC RID: 25772
		[Token(Token = "0x20064AC")]
		public class Output
		{
			// Token: 0x060250D7 RID: 151767 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60250D7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Output()
			{
			}

			// Token: 0x04033DF2 RID: 212466
			[Token(Token = "0x4033DF2")]
			[FieldOffset(Offset = "0x10")]
			public bool keepObserve;
		}
	}
}
