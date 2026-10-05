using System;
using Il2CppDummyDll;

namespace XDSDK
{
	// Token: 0x020000D3 RID: 211
	[Token(Token = "0x20000D3")]
	public struct PayConfirmOrderAppstoreRequest
	{
		// Token: 0x0400044E RID: 1102
		[Token(Token = "0x400044E")]
		[FieldOffset(Offset = "0x0")]
		public string token;

		// Token: 0x0400044F RID: 1103
		[Token(Token = "0x400044F")]
		[FieldOffset(Offset = "0x8")]
		public string version;

		// Token: 0x04000450 RID: 1104
		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0x10")]
		public string orderId;

		// Token: 0x04000451 RID: 1105
		[Token(Token = "0x4000451")]
		[FieldOffset(Offset = "0x18")]
		public string receiptData;
	}
}
