using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003658 RID: 13912
	[Token(Token = "0x2003658")]
	[Hotfix(HotfixFlag.Stateless)]
	internal static class StateEngineFuncs
	{
		// Token: 0x0601623F RID: 90687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601623F")]
		[Address(RVA = "0xE93FE0", Offset = "0xE92BE0", VA = "0x180E93FE0")]
		public static void BindDynamicTransActionsFromStates(State fromState, State toState, Transition transOut, Transition transIn, StateTransOptions transOptions, StateEngineFuncs.DirectionalAction directionalAction)
		{
		}

		// Token: 0x06016240 RID: 90688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016240")]
		[Address(RVA = "0xE94300", Offset = "0xE92F00", VA = "0x180E94300")]
		private static void _BindDynamicDataTransActionsLegacy(State fromState, State toState, Transition transOut, Transition transIn, StateTransOptions transOptions, bool isForwardTransition)
		{
		}

		// Token: 0x0401A9D5 RID: 109013
		[Token(Token = "0x401A9D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_BindDynamicTransActionsFromStates;

		// Token: 0x0401A9D6 RID: 109014
		[Token(Token = "0x401A9D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__BindDynamicDataTransActionsLegacy;

		// Token: 0x02003659 RID: 13913
		[Token(Token = "0x2003659")]
		public enum DirectionalAction
		{
			// Token: 0x0401A9D8 RID: 109016
			[Token(Token = "0x401A9D8")]
			FORWARD,
			// Token: 0x0401A9D9 RID: 109017
			[Token(Token = "0x401A9D9")]
			BACKWARD_NORMAL_MODE,
			// Token: 0x0401A9DA RID: 109018
			[Token(Token = "0x401A9DA")]
			BACKWARD_WITH_ENTER_MODE
		}
	}
}
