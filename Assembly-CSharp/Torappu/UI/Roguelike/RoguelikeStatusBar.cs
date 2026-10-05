using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052F5 RID: 21237
	[Token(Token = "0x20052F5")]
	public class RoguelikeStatusBar : RoguelikeMenuBar
	{
		// Token: 0x0601F533 RID: 128307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F533")]
		[Address(RVA = "0x191E530", Offset = "0x191D130", VA = "0x18191E530", Slot = "4")]
		protected override UISwitchTween GenerateUISwitchTween()
		{
			return null;
		}

		// Token: 0x0601F534 RID: 128308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F534")]
		[Address(RVA = "0x191E600", Offset = "0x191D200", VA = "0x18191E600", Slot = "5")]
		protected override void RefreshMenuBar(RoguelikeMenu.StateTransitionParam transitionParam, RoguelikeMenuAdapter topAdapter, bool fastMode)
		{
		}

		// Token: 0x0601F535 RID: 128309 RVA: 0x000B1858 File Offset: 0x000AFA58
		[Token(Token = "0x601F535")]
		[Address(RVA = "0x191E470", Offset = "0x191D070", VA = "0x18191E470", Slot = "6")]
		protected override bool AchieveShowStatus(RoguelikeMenu.StateTransitionParam transitionParam, RoguelikeMenuAdapter topAdapter)
		{
			return default(bool);
		}

		// Token: 0x0601F536 RID: 128310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F536")]
		[Address(RVA = "0x191E690", Offset = "0x191D290", VA = "0x18191E690")]
		public RoguelikeStatusBar()
		{
		}

		// Token: 0x0402A160 RID: 172384
		[Token(Token = "0x402A160")]
		private const float TWEEN_DURATION = 0.5f;

		// Token: 0x0402A161 RID: 172385
		[Token(Token = "0x402A161")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GenerateUISwitchTween;

		// Token: 0x0402A162 RID: 172386
		[Token(Token = "0x402A162")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshMenuBar;

		// Token: 0x0402A163 RID: 172387
		[Token(Token = "0x402A163")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AchieveShowStatus;

		// Token: 0x0402A164 RID: 172388
		[Token(Token = "0x402A164")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
