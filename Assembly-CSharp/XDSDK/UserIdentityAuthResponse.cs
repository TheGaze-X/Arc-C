using System;
using Il2CppDummyDll;

namespace XDSDK
{
	// Token: 0x020000E3 RID: 227
	[Token(Token = "0x20000E3")]
	public class UserIdentityAuthResponse
	{
		// Token: 0x060003AD RID: 941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UserIdentityAuthResponse()
		{
		}

		// Token: 0x04000485 RID: 1157
		[Token(Token = "0x4000485")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		// Token: 0x04000486 RID: 1158
		[Token(Token = "0x4000486")]
		[FieldOffset(Offset = "0x14")]
		public bool isMinor;

		// Token: 0x04000487 RID: 1159
		[Token(Token = "0x4000487")]
		[FieldOffset(Offset = "0x18")]
		public string error;
	}
}
