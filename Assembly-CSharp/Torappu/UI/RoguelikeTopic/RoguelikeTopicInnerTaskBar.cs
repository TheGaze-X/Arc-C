using System;
using Il2CppDummyDll;
using Torappu.UI.Roguelike;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004473 RID: 17523
	[Token(Token = "0x2004473")]
	public class RoguelikeTopicInnerTaskBar : RoguelikeMenuBar
	{
		// Token: 0x0601AC87 RID: 109703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AC87")]
		[Address(RVA = "0x13FE6C0", Offset = "0x13FD2C0", VA = "0x1813FE6C0", Slot = "4")]
		protected override UISwitchTween GenerateUISwitchTween()
		{
			return null;
		}

		// Token: 0x0601AC88 RID: 109704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC88")]
		[Address(RVA = "0x13FE7A0", Offset = "0x13FD3A0", VA = "0x1813FE7A0", Slot = "5")]
		protected override void RefreshMenuBar(RoguelikeMenu.StateTransitionParam transitionParam, RoguelikeMenuAdapter topAdapter, bool fastMode)
		{
		}

		// Token: 0x0601AC89 RID: 109705 RVA: 0x000A3530 File Offset: 0x000A1730
		[Token(Token = "0x601AC89")]
		[Address(RVA = "0x13FE590", Offset = "0x13FD190", VA = "0x1813FE590", Slot = "6")]
		protected override bool AchieveShowStatus(RoguelikeMenu.StateTransitionParam transitionParam, RoguelikeMenuAdapter topAdapter)
		{
			return default(bool);
		}

		// Token: 0x0601AC8A RID: 109706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC8A")]
		[Address(RVA = "0x13FEA80", Offset = "0x13FD680", VA = "0x1813FEA80")]
		public RoguelikeTopicInnerTaskBar()
		{
		}

		// Token: 0x040223F4 RID: 140276
		[Token(Token = "0x40223F4")]
		private const float TWEEN_DURATION = 0.5f;

		// Token: 0x040223F5 RID: 140277
		[Token(Token = "0x40223F5")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type[] ENABLE_STATES;

		// Token: 0x040223F6 RID: 140278
		[Token(Token = "0x40223F6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateUISwitchTween;

		// Token: 0x040223F7 RID: 140279
		[Token(Token = "0x40223F7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshMenuBar;

		// Token: 0x040223F8 RID: 140280
		[Token(Token = "0x40223F8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_AchieveShowStatus;

		// Token: 0x040223F9 RID: 140281
		[Token(Token = "0x40223F9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
