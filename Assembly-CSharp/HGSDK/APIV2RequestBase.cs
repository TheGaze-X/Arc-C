using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace HGSDK
{
	// Token: 0x02000158 RID: 344
	[Token(Token = "0x2000158")]
	public abstract class APIV2RequestBase
	{
		// Token: 0x06000518 RID: 1304 RVA: 0x000031F8 File Offset: 0x000013F8
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x1028420", Offset = "0x1027020", VA = "0x181028420")]
		public bool ShouldSerializecaptcha()
		{
			return default(bool);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected APIV2RequestBase()
		{
		}

		// Token: 0x0400069E RID: 1694
		[Token(Token = "0x400069E")]
		[FieldOffset(Offset = "0x10")]
		public JObject captcha;

		// Token: 0x0400069F RID: 1695
		[Token(Token = "0x400069F")]
		[FieldOffset(Offset = "0x18")]
		public string token;
	}
}
