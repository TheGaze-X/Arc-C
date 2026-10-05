using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200088C RID: 2188
	[Token(Token = "0x200088C")]
	public class PayCreateOrderResponse
	{
		// Token: 0x0600652C RID: 25900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600652C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PayCreateOrderResponse()
		{
		}

		// Token: 0x04003221 RID: 12833
		[Token(Token = "0x4003221")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		// Token: 0x04003222 RID: 12834
		[Token(Token = "0x4003222")]
		[FieldOffset(Offset = "0x18")]
		public string orderId;

		// Token: 0x04003223 RID: 12835
		[Token(Token = "0x4003223")]
		[FieldOffset(Offset = "0x20")]
		public string extension;

		// Token: 0x04003224 RID: 12836
		[Token(Token = "0x4003224")]
		[FieldOffset(Offset = "0x28")]
		public List<string> orderIdList;

		// Token: 0x04003225 RID: 12837
		[Token(Token = "0x4003225")]
		[FieldOffset(Offset = "0x30")]
		public bool alertMinor;

		// Token: 0x04003226 RID: 12838
		[Token(Token = "0x4003226")]
		[FieldOffset(Offset = "0x38")]
		public string errMsg;
	}
}
