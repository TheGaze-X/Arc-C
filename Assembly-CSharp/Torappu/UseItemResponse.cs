using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200078D RID: 1933
	[Token(Token = "0x200078D")]
	public class UseItemResponse : PlayerDeltaResponse
	{
		// Token: 0x0600640D RID: 25613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600640D")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public UseItemResponse()
		{
		}

		// Token: 0x04003055 RID: 12373
		[Token(Token = "0x4003055")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemGet> items;
	}
}
