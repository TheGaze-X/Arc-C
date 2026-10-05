using System;
using Il2CppDummyDll;

namespace U8.SDK
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	public struct ExternalPluginLogoutParams
	{
		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x0")]
		public Action nativeLogout;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x8")]
		public Action nativeOnLogoutSuc;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x10")]
		public Action nativeOnLogoutFail;
	}
}
