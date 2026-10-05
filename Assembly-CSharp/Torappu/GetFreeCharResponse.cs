using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200075D RID: 1885
	[Token(Token = "0x200075D")]
	public class GetFreeCharResponse : PlayerDeltaResponse
	{
		// Token: 0x060063C7 RID: 25543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C7")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public GetFreeCharResponse()
		{
		}

		// Token: 0x04002FE6 RID: 12262
		[Token(Token = "0x4002FE6")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
