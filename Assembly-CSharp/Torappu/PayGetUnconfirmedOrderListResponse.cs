using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200088E RID: 2190
	[Token(Token = "0x200088E")]
	public class PayGetUnconfirmedOrderListResponse
	{
		// Token: 0x0600652E RID: 25902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600652E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PayGetUnconfirmedOrderListResponse()
		{
		}

		// Token: 0x04003227 RID: 12839
		[Token(Token = "0x4003227")]
		[FieldOffset(Offset = "0x10")]
		public List<string> orderIdList;
	}
}
