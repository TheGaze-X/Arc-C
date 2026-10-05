using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x02000138 RID: 312
	[Token(Token = "0x2000138")]
	public class PayConfirmOrderAppstoreNewRequest
	{
		// Token: 0x060004F5 RID: 1269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x1034650", Offset = "0x1033250", VA = "0x181034650")]
		public PayConfirmOrderAppstoreNewRequest()
		{
		}

		// Token: 0x0400062E RID: 1582
		[Token(Token = "0x400062E")]
		[FieldOffset(Offset = "0x10")]
		public string token;

		// Token: 0x0400062F RID: 1583
		[Token(Token = "0x400062F")]
		[FieldOffset(Offset = "0x18")]
		public string version;

		// Token: 0x04000630 RID: 1584
		[Token(Token = "0x4000630")]
		[FieldOffset(Offset = "0x20")]
		public string curOrderId;

		// Token: 0x04000631 RID: 1585
		[Token(Token = "0x4000631")]
		[FieldOffset(Offset = "0x28")]
		public List<AppstoreOrder> infoList;

		// Token: 0x04000632 RID: 1586
		[Token(Token = "0x4000632")]
		[FieldOffset(Offset = "0x30")]
		public string receiptData;
	}
}
