using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace XDSDK
{
	// Token: 0x020000D6 RID: 214
	[Token(Token = "0x20000D6")]
	public class PayConfirmOrderAppstoreNewRequest
	{
		// Token: 0x060003A0 RID: 928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x10346E0", Offset = "0x10332E0", VA = "0x1810346E0")]
		public PayConfirmOrderAppstoreNewRequest()
		{
		}

		// Token: 0x04000455 RID: 1109
		[Token(Token = "0x4000455")]
		[FieldOffset(Offset = "0x10")]
		public string token;

		// Token: 0x04000456 RID: 1110
		[Token(Token = "0x4000456")]
		[FieldOffset(Offset = "0x18")]
		public string version;

		// Token: 0x04000457 RID: 1111
		[Token(Token = "0x4000457")]
		[FieldOffset(Offset = "0x20")]
		public string curOrderId;

		// Token: 0x04000458 RID: 1112
		[Token(Token = "0x4000458")]
		[FieldOffset(Offset = "0x28")]
		public List<AppstoreOrder> infoList;

		// Token: 0x04000459 RID: 1113
		[Token(Token = "0x4000459")]
		[FieldOffset(Offset = "0x30")]
		public string receiptData;
	}
}
