using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x020000F8 RID: 248
	[Token(Token = "0x20000F8")]
	public enum ResultCode
	{
		// Token: 0x040004C3 RID: 1219
		[Token(Token = "0x40004C3")]
		OK,
		// Token: 0x040004C4 RID: 1220
		[Token(Token = "0x40004C4")]
		HTTP_ERROR = 500,
		// Token: 0x040004C5 RID: 1221
		[Token(Token = "0x40004C5")]
		REQUEST_TIMEOUT = 1000,
		// Token: 0x040004C6 RID: 1222
		[Token(Token = "0x40004C6")]
		RESPONSE_PARSE_ERROR,
		// Token: 0x040004C7 RID: 1223
		[Token(Token = "0x40004C7")]
		PAY_PRODUCT_INVALID = 2000,
		// Token: 0x040004C8 RID: 1224
		[Token(Token = "0x40004C8")]
		PAY_SDK_CANT_INIT_IAP,
		// Token: 0x040004C9 RID: 1225
		[Token(Token = "0x40004C9")]
		PAY_INVALID_PRODUCT_IN_STORE,
		// Token: 0x040004CA RID: 1226
		[Token(Token = "0x40004CA")]
		PAY_STORE_FAILURE,
		// Token: 0x040004CB RID: 1227
		[Token(Token = "0x40004CB")]
		PAY_CANCELED,
		// Token: 0x040004CC RID: 1228
		[Token(Token = "0x40004CC")]
		PAY_SERVER_INTERNAL_ERROR,
		// Token: 0x040004CD RID: 1229
		[Token(Token = "0x40004CD")]
		PAY_RECEIPT_UPLOAD_FAILED = 2005,
		// Token: 0x040004CE RID: 1230
		[Token(Token = "0x40004CE")]
		PAY_IAP_CONFIG_EXCEPTION,
		// Token: 0x040004CF RID: 1231
		[Token(Token = "0x40004CF")]
		PAY_HAS_PENDING_ORDERS,
		// Token: 0x040004D0 RID: 1232
		[Token(Token = "0x40004D0")]
		UNKNOWN = 65535
	}
}
