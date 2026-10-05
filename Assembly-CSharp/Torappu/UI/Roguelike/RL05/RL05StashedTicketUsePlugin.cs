using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005638 RID: 22072
	[Token(Token = "0x2005638")]
	public class RL05StashedTicketUsePlugin : RoguelikeStashedTicketUsePlugin
	{
		// Token: 0x0602063C RID: 132668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602063C")]
		[Address(RVA = "0x1A885E0", Offset = "0x1A871E0", VA = "0x181A885E0", Slot = "4")]
		public override RoguelikeStashedTicketUseParamBuilder GetModelParamBuilder()
		{
			return null;
		}

		// Token: 0x0602063D RID: 132669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602063D")]
		[Address(RVA = "0x1A886B0", Offset = "0x1A872B0", VA = "0x181A886B0")]
		public RL05StashedTicketUsePlugin()
		{
		}

		// Token: 0x0402BD87 RID: 179591
		[Token(Token = "0x402BD87")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetModelParamBuilder;

		// Token: 0x0402BD88 RID: 179592
		[Token(Token = "0x402BD88")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
