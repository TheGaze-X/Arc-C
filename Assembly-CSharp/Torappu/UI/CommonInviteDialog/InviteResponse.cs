using System;
using Il2CppDummyDll;

namespace Torappu.UI.CommonInviteDialog
{
	// Token: 0x02005BAC RID: 23468
	[Token(Token = "0x2005BAC")]
	public class InviteResponse : PlayerDeltaResponse
	{
		// Token: 0x060220D0 RID: 139472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60220D0")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public InviteResponse()
		{
		}

		// Token: 0x0402EB06 RID: 191238
		[Token(Token = "0x402EB06")]
		[FieldOffset(Offset = "0x28")]
		public int result;
	}
}
