using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x0200584D RID: 22605
	[Token(Token = "0x200584D")]
	public class RL03SacrificePlugin : RoguelikeSacrificePlugin
	{
		// Token: 0x0602105A RID: 135258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602105A")]
		[Address(RVA = "0x1B5DA30", Offset = "0x1B5C630", VA = "0x181B5DA30", Slot = "4")]
		public override RoguelikeSacrificeModelParamBuilder GetModelParamBuilder()
		{
			return null;
		}

		// Token: 0x0602105B RID: 135259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602105B")]
		[Address(RVA = "0x1B5DAC0", Offset = "0x1B5C6C0", VA = "0x181B5DAC0")]
		public RL03SacrificePlugin()
		{
		}

		// Token: 0x0602105C RID: 135260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602105C")]
		[Address(RVA = "0x1A70220", Offset = "0x1A6EE20", VA = "0x181A70220")]
		private RoguelikeSacrificeModelParamBuilder <>xLuaBaseProxy_GetModelParamBuilder()
		{
			return null;
		}

		// Token: 0x0402CEA3 RID: 183971
		[Token(Token = "0x402CEA3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetModelParamBuilder;

		// Token: 0x0402CEA4 RID: 183972
		[Token(Token = "0x402CEA4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
