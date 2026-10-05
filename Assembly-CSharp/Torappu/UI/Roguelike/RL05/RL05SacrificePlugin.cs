using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055FF RID: 22015
	[Token(Token = "0x20055FF")]
	public class RL05SacrificePlugin : RoguelikeSacrificePlugin
	{
		// Token: 0x060204FC RID: 132348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60204FC")]
		[Address(RVA = "0x1A70180", Offset = "0x1A6ED80", VA = "0x181A70180", Slot = "4")]
		public override RoguelikeSacrificeModelParamBuilder GetModelParamBuilder()
		{
			return null;
		}

		// Token: 0x060204FD RID: 132349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60204FD")]
		[Address(RVA = "0x1A700F0", Offset = "0x1A6ECF0", VA = "0x181A700F0", Slot = "5")]
		public override RoguelikeSacrificeConfirmBehaviour GetConfirmBehaviour()
		{
			return null;
		}

		// Token: 0x060204FE RID: 132350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204FE")]
		[Address(RVA = "0x1A70230", Offset = "0x1A6EE30", VA = "0x181A70230")]
		public RL05SacrificePlugin()
		{
		}

		// Token: 0x060204FF RID: 132351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60204FF")]
		[Address(RVA = "0x1A70220", Offset = "0x1A6EE20", VA = "0x181A70220")]
		private RoguelikeSacrificeModelParamBuilder <>xLuaBaseProxy_GetModelParamBuilder()
		{
			return null;
		}

		// Token: 0x06020500 RID: 132352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020500")]
		[Address(RVA = "0x1A70210", Offset = "0x1A6EE10", VA = "0x181A70210")]
		private RoguelikeSacrificeConfirmBehaviour <>xLuaBaseProxy_GetConfirmBehaviour()
		{
			return null;
		}

		// Token: 0x0402BBC8 RID: 179144
		[Token(Token = "0x402BBC8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetModelParamBuilder;

		// Token: 0x0402BBC9 RID: 179145
		[Token(Token = "0x402BBC9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetConfirmBehaviour;

		// Token: 0x0402BBCA RID: 179146
		[Token(Token = "0x402BBCA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
