using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x02000137 RID: 311
	[Token(Token = "0x2000137")]
	public class AppstoreOrder
	{
		// Token: 0x060004F4 RID: 1268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AppstoreOrder()
		{
		}

		// Token: 0x0400062C RID: 1580
		[Token(Token = "0x400062C")]
		[FieldOffset(Offset = "0x10")]
		public string txId;

		// Token: 0x0400062D RID: 1581
		[Token(Token = "0x400062D")]
		[FieldOffset(Offset = "0x18")]
		public string orderId;
	}
}
