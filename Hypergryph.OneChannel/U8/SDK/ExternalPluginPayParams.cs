using System;
using Il2CppDummyDll;

namespace U8.SDK
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public struct ExternalPluginPayParams
	{
		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x0")]
		public U8PayParams payParams;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x8")]
		public Func<U8PayParams, SDKPromise<U8PayResult>> nativePay;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x10")]
		public Action<U8PayResult> onPaySuc;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x18")]
		public Action<object> onPayFail;
	}
}
