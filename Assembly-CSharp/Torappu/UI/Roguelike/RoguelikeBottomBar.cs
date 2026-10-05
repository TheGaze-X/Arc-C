using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052F3 RID: 21235
	[Token(Token = "0x20052F3")]
	public class RoguelikeBottomBar : RoguelikeMenuBar
	{
		// Token: 0x0601F523 RID: 128291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F523")]
		[Address(RVA = "0x18F3AD0", Offset = "0x18F26D0", VA = "0x1818F3AD0", Slot = "4")]
		protected override UISwitchTween GenerateUISwitchTween()
		{
			return null;
		}

		// Token: 0x0601F524 RID: 128292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F524")]
		[Address(RVA = "0x18F3CB0", Offset = "0x18F28B0", VA = "0x1818F3CB0", Slot = "5")]
		protected override void RefreshMenuBar(RoguelikeMenu.StateTransitionParam transitionParam, RoguelikeMenuAdapter topAdapter, bool fastMode)
		{
		}

		// Token: 0x0601F525 RID: 128293 RVA: 0x000B1840 File Offset: 0x000AFA40
		[Token(Token = "0x601F525")]
		[Address(RVA = "0x18F3A00", Offset = "0x18F2600", VA = "0x1818F3A00", Slot = "6")]
		protected override bool AchieveShowStatus(RoguelikeMenu.StateTransitionParam transitionParam, RoguelikeMenuAdapter topAdapter)
		{
			return default(bool);
		}

		// Token: 0x0601F526 RID: 128294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F526")]
		[Address(RVA = "0x18F3BD0", Offset = "0x18F27D0", VA = "0x1818F3BD0", Slot = "7")]
		public override void Init(RoguelikeDungeonController controller, StateEngine stateEngine, RoguelikeMenu menu, RoguelikeMenuViewModel viewModel)
		{
		}

		// Token: 0x0601F527 RID: 128295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F527")]
		[Address(RVA = "0x18F3FB0", Offset = "0x18F2BB0", VA = "0x1818F3FB0")]
		public RoguelikeBottomBar()
		{
		}

		// Token: 0x0601F529 RID: 128297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F529")]
		[Address(RVA = "0x18F3E30", Offset = "0x18F2A30", VA = "0x1818F3E30")]
		private void <>xLuaBaseProxy_Init(RoguelikeDungeonController P0, StateEngine P1, RoguelikeMenu P2, RoguelikeMenuViewModel P3)
		{
		}

		// Token: 0x0402A14E RID: 172366
		[Token(Token = "0x402A14E")]
		private const string FOLD_ANIM_PARAM = "fold_out";

		// Token: 0x0402A14F RID: 172367
		[Token(Token = "0x402A14F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type[] SMALL_MENU_STATES;

		// Token: 0x0402A150 RID: 172368
		[Token(Token = "0x402A150")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _animFold;

		// Token: 0x0402A151 RID: 172369
		[Token(Token = "0x402A151")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _pnlBottomBar;

		// Token: 0x0402A152 RID: 172370
		[Token(Token = "0x402A152")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateUISwitchTween;

		// Token: 0x0402A153 RID: 172371
		[Token(Token = "0x402A153")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshMenuBar;

		// Token: 0x0402A154 RID: 172372
		[Token(Token = "0x402A154")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_AchieveShowStatus;

		// Token: 0x0402A155 RID: 172373
		[Token(Token = "0x402A155")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402A156 RID: 172374
		[Token(Token = "0x402A156")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020052F4 RID: 21236
		[Token(Token = "0x20052F4")]
		protected class ShowSwitchTween : UISwitchTween
		{
			// Token: 0x0601F52A RID: 128298 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F52A")]
			[Address(RVA = "0x190A310", Offset = "0x1908F10", VA = "0x18190A310")]
			public ShowSwitchTween(RoguelikeBottomBar closure)
			{
			}

			// Token: 0x0601F52B RID: 128299 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F52B")]
			[Address(RVA = "0x190A050", Offset = "0x1908C50", VA = "0x18190A050", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601F52C RID: 128300 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F52C")]
			[Address(RVA = "0x190A140", Offset = "0x1908D40", VA = "0x18190A140", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601F52D RID: 128301 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F52D")]
			[Address(RVA = "0x1909F30", Offset = "0x1908B30", VA = "0x181909F30", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0601F52E RID: 128302 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F52E")]
			[Address(RVA = "0x1909FC0", Offset = "0x1908BC0", VA = "0x181909FC0", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0601F52F RID: 128303 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F52F")]
			[Address(RVA = "0x190A230", Offset = "0x1908E30", VA = "0x18190A230", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601F530 RID: 128304 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F530")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0601F531 RID: 128305 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F531")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0601F532 RID: 128306 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F532")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0402A157 RID: 172375
			[Token(Token = "0x402A157")]
			private const float ANIM_DURATION = 0.3f;

			// Token: 0x0402A158 RID: 172376
			[Token(Token = "0x402A158")]
			private const int BOTTOM_VIEW_TARGET_Y = -84;

			// Token: 0x0402A159 RID: 172377
			[Token(Token = "0x402A159")]
			[FieldOffset(Offset = "0x48")]
			private RoguelikeBottomBar m_closure;

			// Token: 0x0402A15A RID: 172378
			[Token(Token = "0x402A15A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402A15B RID: 172379
			[Token(Token = "0x402A15B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0402A15C RID: 172380
			[Token(Token = "0x402A15C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0402A15D RID: 172381
			[Token(Token = "0x402A15D")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x0402A15E RID: 172382
			[Token(Token = "0x402A15E")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0402A15F RID: 172383
			[Token(Token = "0x402A15F")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
