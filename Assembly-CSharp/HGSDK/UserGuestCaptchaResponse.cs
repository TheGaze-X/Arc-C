using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace HGSDK
{
	// Token: 0x0200013F RID: 319
	[Token(Token = "0x200013F")]
	public class UserGuestCaptchaResponse
	{
		// Token: 0x060004FC RID: 1276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UserGuestCaptchaResponse()
		{
		}

		// Token: 0x04000647 RID: 1607
		[Token(Token = "0x4000647")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		// Token: 0x04000648 RID: 1608
		[Token(Token = "0x4000648")]
		[FieldOffset(Offset = "0x18")]
		public JObject data;
	}
}
