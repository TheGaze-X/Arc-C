using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x02000135 RID: 309
	[Token(Token = "0x2000135")]
	public struct PayConfirmOrderAppstoreRequest
	{
		// Token: 0x04000627 RID: 1575
		[Token(Token = "0x4000627")]
		[FieldOffset(Offset = "0x0")]
		public string token;

		// Token: 0x04000628 RID: 1576
		[Token(Token = "0x4000628")]
		[FieldOffset(Offset = "0x8")]
		public string version;

		// Token: 0x04000629 RID: 1577
		[Token(Token = "0x4000629")]
		[FieldOffset(Offset = "0x10")]
		public string orderId;

		// Token: 0x0400062A RID: 1578
		[Token(Token = "0x400062A")]
		[FieldOffset(Offset = "0x18")]
		public string receiptData;
	}
}
