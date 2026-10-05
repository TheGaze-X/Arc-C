using System;
using Il2CppDummyDll;

namespace U8.SDK
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	public struct ExternalPluginLoginParams
	{
		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		public Action nativeLogin;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x8")]
		public Action<string> nativeLoginCustom;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x10")]
		public Action<string> nativeOnLoginSuc;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x18")]
		public Action<string> nativeOnLoginFail;

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x20")]
		public Action<U8MockLogin> markMockLogin;
	}
}
