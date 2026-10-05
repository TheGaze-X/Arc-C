using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace XDSDK
{
	// Token: 0x020000DD RID: 221
	[Token(Token = "0x20000DD")]
	public class UserGuestCaptchaResponse
	{
		// Token: 0x060003A7 RID: 935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UserGuestCaptchaResponse()
		{
		}

		// Token: 0x04000468 RID: 1128
		[Token(Token = "0x4000468")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		// Token: 0x04000469 RID: 1129
		[Token(Token = "0x4000469")]
		[FieldOffset(Offset = "0x18")]
		public JObject data;
	}
}
