using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007C9 RID: 1993
	[Token(Token = "0x20007C9")]
	public class AutoConfirmMissionsResponse : PlayerDeltaResponse
	{
		// Token: 0x0600644A RID: 25674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600644A")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public AutoConfirmMissionsResponse()
		{
		}

		// Token: 0x040030D6 RID: 12502
		[Token(Token = "0x40030D6")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemBundle> items;
	}
}
