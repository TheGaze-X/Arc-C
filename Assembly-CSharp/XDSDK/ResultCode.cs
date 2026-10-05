using System;
using Il2CppDummyDll;

namespace XDSDK
{
	// Token: 0x020000B7 RID: 183
	[Token(Token = "0x20000B7")]
	public enum ResultCode
	{
		// Token: 0x040003B4 RID: 948
		[Token(Token = "0x40003B4")]
		OK,
		// Token: 0x040003B5 RID: 949
		[Token(Token = "0x40003B5")]
		HTTP_ERROR = 500,
		// Token: 0x040003B6 RID: 950
		[Token(Token = "0x40003B6")]
		REQUEST_TIMEOUT = 1000,
		// Token: 0x040003B7 RID: 951
		[Token(Token = "0x40003B7")]
		RESPONSE_PARSE_ERROR,
		// Token: 0x040003B8 RID: 952
		[Token(Token = "0x40003B8")]
		PAY_PRODUCT_INVALID = 2000,
		// Token: 0x040003B9 RID: 953
		[Token(Token = "0x40003B9")]
		PAY_SDK_CANT_INIT_IAP,
		// Token: 0x040003BA RID: 954
		[Token(Token = "0x40003BA")]
		PAY_INVALID_PRODUCT_IN_STORE,
		// Token: 0x040003BB RID: 955
		[Token(Token = "0x40003BB")]
		PAY_STORE_FAILURE,
		// Token: 0x040003BC RID: 956
		[Token(Token = "0x40003BC")]
		PAY_CANCELED,
		// Token: 0x040003BD RID: 957
		[Token(Token = "0x40003BD")]
		PAY_SERVER_INTERNAL_ERROR,
		// Token: 0x040003BE RID: 958
		[Token(Token = "0x40003BE")]
		PAY_RECEIPT_UPLOAD_FAILED = 2005,
		// Token: 0x040003BF RID: 959
		[Token(Token = "0x40003BF")]
		PAY_IAP_CONFIG_EXCEPTION,
		// Token: 0x040003C0 RID: 960
		[Token(Token = "0x40003C0")]
		PAY_HAS_PENDING_ORDERS,
		// Token: 0x040003C1 RID: 961
		[Token(Token = "0x40003C1")]
		UNKNOWN = 65535
	}
}
