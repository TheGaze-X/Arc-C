using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053DC RID: 21468
	[Token(Token = "0x20053DC")]
	public class RoguelikeRewardEntrySpLevelView : RoguelikeRewardEntryLevelAndExpView
	{
		// Token: 0x0601F96E RID: 129390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F96E")]
		[Address(RVA = "0x193A9A0", Offset = "0x19395A0", VA = "0x18193A9A0", Slot = "4")]
		public override void Init(RoguelikeRewardEarnViewModel earnViewModel)
		{
		}

		// Token: 0x0601F96F RID: 129391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F96F")]
		[Address(RVA = "0x193AC50", Offset = "0x1939850", VA = "0x18193AC50", Slot = "7")]
		protected override void _RenderExp(int maxLevel, int level, int exp, string topicId, RoguelikeRewardEarnViewModel earnViewModel)
		{
		}

		// Token: 0x0601F970 RID: 129392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F970")]
		[Address(RVA = "0x193AD90", Offset = "0x1939990", VA = "0x18193AD90")]
		public RoguelikeRewardEntrySpLevelView()
		{
		}

		// Token: 0x0601F971 RID: 129393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F971")]
		[Address(RVA = "0x193AA80", Offset = "0x1939680", VA = "0x18193AA80")]
		private void <>xLuaBaseProxy_Init(RoguelikeRewardEarnViewModel P0)
		{
		}

		// Token: 0x0601F972 RID: 129394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F972")]
		[Address(RVA = "0x193AA90", Offset = "0x1939690", VA = "0x18193AA90")]
		private void <>xLuaBaseProxy__RenderExp(int P0, int P1, int P2, string P3, RoguelikeRewardEarnViewModel P4)
		{
		}

		// Token: 0x0402A889 RID: 174217
		[Token(Token = "0x402A889")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402A88A RID: 174218
		[Token(Token = "0x402A88A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderExp;

		// Token: 0x0402A88B RID: 174219
		[Token(Token = "0x402A88B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
