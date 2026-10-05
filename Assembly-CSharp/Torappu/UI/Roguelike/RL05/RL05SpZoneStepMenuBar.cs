using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055F5 RID: 22005
	[Token(Token = "0x20055F5")]
	public class RL05SpZoneStepMenuBar : RoguelikeMenuBar
	{
		// Token: 0x060204CE RID: 132302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60204CE")]
		[Address(RVA = "0x1A71250", Offset = "0x1A6FE50", VA = "0x181A71250", Slot = "4")]
		protected override UISwitchTween GenerateUISwitchTween()
		{
			return null;
		}

		// Token: 0x060204CF RID: 132303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204CF")]
		[Address(RVA = "0x1A71330", Offset = "0x1A6FF30", VA = "0x181A71330", Slot = "5")]
		protected override void RefreshMenuBar(RoguelikeMenu.StateTransitionParam transitionParam, RoguelikeMenuAdapter topAdapter, bool fastMode)
		{
		}

		// Token: 0x060204D0 RID: 132304 RVA: 0x000B5428 File Offset: 0x000B3628
		[Token(Token = "0x60204D0")]
		[Address(RVA = "0x1A71120", Offset = "0x1A6FD20", VA = "0x181A71120", Slot = "6")]
		protected override bool AchieveShowStatus(RoguelikeMenu.StateTransitionParam transitionParam, RoguelikeMenuAdapter topAdapter)
		{
			return default(bool);
		}

		// Token: 0x060204D1 RID: 132305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204D1")]
		[Address(RVA = "0x1A71540", Offset = "0x1A70140", VA = "0x181A71540")]
		public RL05SpZoneStepMenuBar()
		{
		}

		// Token: 0x0402BB76 RID: 179062
		[Token(Token = "0x402BB76")]
		private const float TWEEN_DURATION = 0.5f;

		// Token: 0x0402BB77 RID: 179063
		[Token(Token = "0x402BB77")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type[] ENABLE_STATES;

		// Token: 0x0402BB78 RID: 179064
		[Token(Token = "0x402BB78")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateUISwitchTween;

		// Token: 0x0402BB79 RID: 179065
		[Token(Token = "0x402BB79")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshMenuBar;

		// Token: 0x0402BB7A RID: 179066
		[Token(Token = "0x402BB7A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_AchieveShowStatus;

		// Token: 0x0402BB7B RID: 179067
		[Token(Token = "0x402BB7B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
