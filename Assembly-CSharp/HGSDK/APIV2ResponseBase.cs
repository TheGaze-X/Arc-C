using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace HGSDK
{
	// Token: 0x02000159 RID: 345
	[Token(Token = "0x2000159")]
	public abstract class APIV2ResponseBase
	{
		// Token: 0x0600051A RID: 1306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1028430", Offset = "0x1027030", VA = "0x181028430")]
		public string SerializeCaptchaStr()
		{
			return null;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected APIV2ResponseBase()
		{
		}

		// Token: 0x040006A0 RID: 1696
		[Token(Token = "0x40006A0")]
		public const int BUSINESS_SUC = 0;

		// Token: 0x040006A1 RID: 1697
		[Token(Token = "0x40006A1")]
		public const int NEED_CAPTCHA_STATUS = 1;

		// Token: 0x040006A2 RID: 1698
		[Token(Token = "0x40006A2")]
		public const int CAPTCHA_AUTH_FAIELD = 4;

		// Token: 0x040006A3 RID: 1699
		[Token(Token = "0x40006A3")]
		public const int INVALID_PHONE_CODE = 5;

		// Token: 0x040006A4 RID: 1700
		[Token(Token = "0x40006A4")]
		[FieldOffset(Offset = "0x10")]
		public JObject captcha;
	}
}
