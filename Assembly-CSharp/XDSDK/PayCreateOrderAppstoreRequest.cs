using System;
using Il2CppDummyDll;

namespace XDSDK
{
	// Token: 0x020000D1 RID: 209
	[Token(Token = "0x20000D1")]
	public struct PayCreateOrderAppstoreRequest
	{
		// Token: 0x04000448 RID: 1096
		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0x0")]
		public string token;

		// Token: 0x04000449 RID: 1097
		[Token(Token = "0x4000449")]
		[FieldOffset(Offset = "0x8")]
		public string version;

		// Token: 0x0400044A RID: 1098
		[Token(Token = "0x400044A")]
		[FieldOffset(Offset = "0x10")]
		public string orderId;

		// Token: 0x0400044B RID: 1099
		[Token(Token = "0x400044B")]
		[FieldOffset(Offset = "0x18")]
		public long time;
	}
}
