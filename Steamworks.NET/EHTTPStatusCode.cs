using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000163 RID: 355
	[Token(Token = "0x2000163")]
	public enum EHTTPStatusCode
	{
		// Token: 0x040008F5 RID: 2293
		[Token(Token = "0x40008F5")]
		k_EHTTPStatusCodeInvalid,
		// Token: 0x040008F6 RID: 2294
		[Token(Token = "0x40008F6")]
		k_EHTTPStatusCode100Continue = 100,
		// Token: 0x040008F7 RID: 2295
		[Token(Token = "0x40008F7")]
		k_EHTTPStatusCode101SwitchingProtocols,
		// Token: 0x040008F8 RID: 2296
		[Token(Token = "0x40008F8")]
		k_EHTTPStatusCode200OK = 200,
		// Token: 0x040008F9 RID: 2297
		[Token(Token = "0x40008F9")]
		k_EHTTPStatusCode201Created,
		// Token: 0x040008FA RID: 2298
		[Token(Token = "0x40008FA")]
		k_EHTTPStatusCode202Accepted,
		// Token: 0x040008FB RID: 2299
		[Token(Token = "0x40008FB")]
		k_EHTTPStatusCode203NonAuthoritative,
		// Token: 0x040008FC RID: 2300
		[Token(Token = "0x40008FC")]
		k_EHTTPStatusCode204NoContent,
		// Token: 0x040008FD RID: 2301
		[Token(Token = "0x40008FD")]
		k_EHTTPStatusCode205ResetContent,
		// Token: 0x040008FE RID: 2302
		[Token(Token = "0x40008FE")]
		k_EHTTPStatusCode206PartialContent,
		// Token: 0x040008FF RID: 2303
		[Token(Token = "0x40008FF")]
		k_EHTTPStatusCode300MultipleChoices = 300,
		// Token: 0x04000900 RID: 2304
		[Token(Token = "0x4000900")]
		k_EHTTPStatusCode301MovedPermanently,
		// Token: 0x04000901 RID: 2305
		[Token(Token = "0x4000901")]
		k_EHTTPStatusCode302Found,
		// Token: 0x04000902 RID: 2306
		[Token(Token = "0x4000902")]
		k_EHTTPStatusCode303SeeOther,
		// Token: 0x04000903 RID: 2307
		[Token(Token = "0x4000903")]
		k_EHTTPStatusCode304NotModified,
		// Token: 0x04000904 RID: 2308
		[Token(Token = "0x4000904")]
		k_EHTTPStatusCode305UseProxy,
		// Token: 0x04000905 RID: 2309
		[Token(Token = "0x4000905")]
		k_EHTTPStatusCode307TemporaryRedirect = 307,
		// Token: 0x04000906 RID: 2310
		[Token(Token = "0x4000906")]
		k_EHTTPStatusCode308PermanentRedirect,
		// Token: 0x04000907 RID: 2311
		[Token(Token = "0x4000907")]
		k_EHTTPStatusCode400BadRequest = 400,
		// Token: 0x04000908 RID: 2312
		[Token(Token = "0x4000908")]
		k_EHTTPStatusCode401Unauthorized,
		// Token: 0x04000909 RID: 2313
		[Token(Token = "0x4000909")]
		k_EHTTPStatusCode402PaymentRequired,
		// Token: 0x0400090A RID: 2314
		[Token(Token = "0x400090A")]
		k_EHTTPStatusCode403Forbidden,
		// Token: 0x0400090B RID: 2315
		[Token(Token = "0x400090B")]
		k_EHTTPStatusCode404NotFound,
		// Token: 0x0400090C RID: 2316
		[Token(Token = "0x400090C")]
		k_EHTTPStatusCode405MethodNotAllowed,
		// Token: 0x0400090D RID: 2317
		[Token(Token = "0x400090D")]
		k_EHTTPStatusCode406NotAcceptable,
		// Token: 0x0400090E RID: 2318
		[Token(Token = "0x400090E")]
		k_EHTTPStatusCode407ProxyAuthRequired,
		// Token: 0x0400090F RID: 2319
		[Token(Token = "0x400090F")]
		k_EHTTPStatusCode408RequestTimeout,
		// Token: 0x04000910 RID: 2320
		[Token(Token = "0x4000910")]
		k_EHTTPStatusCode409Conflict,
		// Token: 0x04000911 RID: 2321
		[Token(Token = "0x4000911")]
		k_EHTTPStatusCode410Gone,
		// Token: 0x04000912 RID: 2322
		[Token(Token = "0x4000912")]
		k_EHTTPStatusCode411LengthRequired,
		// Token: 0x04000913 RID: 2323
		[Token(Token = "0x4000913")]
		k_EHTTPStatusCode412PreconditionFailed,
		// Token: 0x04000914 RID: 2324
		[Token(Token = "0x4000914")]
		k_EHTTPStatusCode413RequestEntityTooLarge,
		// Token: 0x04000915 RID: 2325
		[Token(Token = "0x4000915")]
		k_EHTTPStatusCode414RequestURITooLong,
		// Token: 0x04000916 RID: 2326
		[Token(Token = "0x4000916")]
		k_EHTTPStatusCode415UnsupportedMediaType,
		// Token: 0x04000917 RID: 2327
		[Token(Token = "0x4000917")]
		k_EHTTPStatusCode416RequestedRangeNotSatisfiable,
		// Token: 0x04000918 RID: 2328
		[Token(Token = "0x4000918")]
		k_EHTTPStatusCode417ExpectationFailed,
		// Token: 0x04000919 RID: 2329
		[Token(Token = "0x4000919")]
		k_EHTTPStatusCode4xxUnknown,
		// Token: 0x0400091A RID: 2330
		[Token(Token = "0x400091A")]
		k_EHTTPStatusCode429TooManyRequests = 429,
		// Token: 0x0400091B RID: 2331
		[Token(Token = "0x400091B")]
		k_EHTTPStatusCode444ConnectionClosed = 444,
		// Token: 0x0400091C RID: 2332
		[Token(Token = "0x400091C")]
		k_EHTTPStatusCode500InternalServerError = 500,
		// Token: 0x0400091D RID: 2333
		[Token(Token = "0x400091D")]
		k_EHTTPStatusCode501NotImplemented,
		// Token: 0x0400091E RID: 2334
		[Token(Token = "0x400091E")]
		k_EHTTPStatusCode502BadGateway,
		// Token: 0x0400091F RID: 2335
		[Token(Token = "0x400091F")]
		k_EHTTPStatusCode503ServiceUnavailable,
		// Token: 0x04000920 RID: 2336
		[Token(Token = "0x4000920")]
		k_EHTTPStatusCode504GatewayTimeout,
		// Token: 0x04000921 RID: 2337
		[Token(Token = "0x4000921")]
		k_EHTTPStatusCode505HTTPVersionNotSupported,
		// Token: 0x04000922 RID: 2338
		[Token(Token = "0x4000922")]
		k_EHTTPStatusCode5xxUnknown = 599
	}
}
