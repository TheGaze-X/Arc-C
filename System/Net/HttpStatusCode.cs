using System;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000285 RID: 645
	[Token(Token = "0x2000285")]
	public enum HttpStatusCode
	{
		// Token: 0x040008D9 RID: 2265
		[Token(Token = "0x40008D9")]
		Continue = 100,
		// Token: 0x040008DA RID: 2266
		[Token(Token = "0x40008DA")]
		SwitchingProtocols,
		// Token: 0x040008DB RID: 2267
		[Token(Token = "0x40008DB")]
		Processing,
		// Token: 0x040008DC RID: 2268
		[Token(Token = "0x40008DC")]
		EarlyHints,
		// Token: 0x040008DD RID: 2269
		[Token(Token = "0x40008DD")]
		OK = 200,
		// Token: 0x040008DE RID: 2270
		[Token(Token = "0x40008DE")]
		Created,
		// Token: 0x040008DF RID: 2271
		[Token(Token = "0x40008DF")]
		Accepted,
		// Token: 0x040008E0 RID: 2272
		[Token(Token = "0x40008E0")]
		NonAuthoritativeInformation,
		// Token: 0x040008E1 RID: 2273
		[Token(Token = "0x40008E1")]
		NoContent,
		// Token: 0x040008E2 RID: 2274
		[Token(Token = "0x40008E2")]
		ResetContent,
		// Token: 0x040008E3 RID: 2275
		[Token(Token = "0x40008E3")]
		PartialContent,
		// Token: 0x040008E4 RID: 2276
		[Token(Token = "0x40008E4")]
		MultiStatus,
		// Token: 0x040008E5 RID: 2277
		[Token(Token = "0x40008E5")]
		AlreadyReported,
		// Token: 0x040008E6 RID: 2278
		[Token(Token = "0x40008E6")]
		IMUsed = 226,
		// Token: 0x040008E7 RID: 2279
		[Token(Token = "0x40008E7")]
		MultipleChoices = 300,
		// Token: 0x040008E8 RID: 2280
		[Token(Token = "0x40008E8")]
		Ambiguous = 300,
		// Token: 0x040008E9 RID: 2281
		[Token(Token = "0x40008E9")]
		MovedPermanently,
		// Token: 0x040008EA RID: 2282
		[Token(Token = "0x40008EA")]
		Moved = 301,
		// Token: 0x040008EB RID: 2283
		[Token(Token = "0x40008EB")]
		Found,
		// Token: 0x040008EC RID: 2284
		[Token(Token = "0x40008EC")]
		Redirect = 302,
		// Token: 0x040008ED RID: 2285
		[Token(Token = "0x40008ED")]
		SeeOther,
		// Token: 0x040008EE RID: 2286
		[Token(Token = "0x40008EE")]
		RedirectMethod = 303,
		// Token: 0x040008EF RID: 2287
		[Token(Token = "0x40008EF")]
		NotModified,
		// Token: 0x040008F0 RID: 2288
		[Token(Token = "0x40008F0")]
		UseProxy,
		// Token: 0x040008F1 RID: 2289
		[Token(Token = "0x40008F1")]
		Unused,
		// Token: 0x040008F2 RID: 2290
		[Token(Token = "0x40008F2")]
		TemporaryRedirect,
		// Token: 0x040008F3 RID: 2291
		[Token(Token = "0x40008F3")]
		RedirectKeepVerb = 307,
		// Token: 0x040008F4 RID: 2292
		[Token(Token = "0x40008F4")]
		PermanentRedirect,
		// Token: 0x040008F5 RID: 2293
		[Token(Token = "0x40008F5")]
		BadRequest = 400,
		// Token: 0x040008F6 RID: 2294
		[Token(Token = "0x40008F6")]
		Unauthorized,
		// Token: 0x040008F7 RID: 2295
		[Token(Token = "0x40008F7")]
		PaymentRequired,
		// Token: 0x040008F8 RID: 2296
		[Token(Token = "0x40008F8")]
		Forbidden,
		// Token: 0x040008F9 RID: 2297
		[Token(Token = "0x40008F9")]
		NotFound,
		// Token: 0x040008FA RID: 2298
		[Token(Token = "0x40008FA")]
		MethodNotAllowed,
		// Token: 0x040008FB RID: 2299
		[Token(Token = "0x40008FB")]
		NotAcceptable,
		// Token: 0x040008FC RID: 2300
		[Token(Token = "0x40008FC")]
		ProxyAuthenticationRequired,
		// Token: 0x040008FD RID: 2301
		[Token(Token = "0x40008FD")]
		RequestTimeout,
		// Token: 0x040008FE RID: 2302
		[Token(Token = "0x40008FE")]
		Conflict,
		// Token: 0x040008FF RID: 2303
		[Token(Token = "0x40008FF")]
		Gone,
		// Token: 0x04000900 RID: 2304
		[Token(Token = "0x4000900")]
		LengthRequired,
		// Token: 0x04000901 RID: 2305
		[Token(Token = "0x4000901")]
		PreconditionFailed,
		// Token: 0x04000902 RID: 2306
		[Token(Token = "0x4000902")]
		RequestEntityTooLarge,
		// Token: 0x04000903 RID: 2307
		[Token(Token = "0x4000903")]
		RequestUriTooLong,
		// Token: 0x04000904 RID: 2308
		[Token(Token = "0x4000904")]
		UnsupportedMediaType,
		// Token: 0x04000905 RID: 2309
		[Token(Token = "0x4000905")]
		RequestedRangeNotSatisfiable,
		// Token: 0x04000906 RID: 2310
		[Token(Token = "0x4000906")]
		ExpectationFailed,
		// Token: 0x04000907 RID: 2311
		[Token(Token = "0x4000907")]
		MisdirectedRequest = 421,
		// Token: 0x04000908 RID: 2312
		[Token(Token = "0x4000908")]
		UnprocessableEntity,
		// Token: 0x04000909 RID: 2313
		[Token(Token = "0x4000909")]
		Locked,
		// Token: 0x0400090A RID: 2314
		[Token(Token = "0x400090A")]
		FailedDependency,
		// Token: 0x0400090B RID: 2315
		[Token(Token = "0x400090B")]
		UpgradeRequired = 426,
		// Token: 0x0400090C RID: 2316
		[Token(Token = "0x400090C")]
		PreconditionRequired = 428,
		// Token: 0x0400090D RID: 2317
		[Token(Token = "0x400090D")]
		TooManyRequests,
		// Token: 0x0400090E RID: 2318
		[Token(Token = "0x400090E")]
		RequestHeaderFieldsTooLarge = 431,
		// Token: 0x0400090F RID: 2319
		[Token(Token = "0x400090F")]
		UnavailableForLegalReasons = 451,
		// Token: 0x04000910 RID: 2320
		[Token(Token = "0x4000910")]
		InternalServerError = 500,
		// Token: 0x04000911 RID: 2321
		[Token(Token = "0x4000911")]
		NotImplemented,
		// Token: 0x04000912 RID: 2322
		[Token(Token = "0x4000912")]
		BadGateway,
		// Token: 0x04000913 RID: 2323
		[Token(Token = "0x4000913")]
		ServiceUnavailable,
		// Token: 0x04000914 RID: 2324
		[Token(Token = "0x4000914")]
		GatewayTimeout,
		// Token: 0x04000915 RID: 2325
		[Token(Token = "0x4000915")]
		HttpVersionNotSupported,
		// Token: 0x04000916 RID: 2326
		[Token(Token = "0x4000916")]
		VariantAlsoNegotiates,
		// Token: 0x04000917 RID: 2327
		[Token(Token = "0x4000917")]
		InsufficientStorage,
		// Token: 0x04000918 RID: 2328
		[Token(Token = "0x4000918")]
		LoopDetected,
		// Token: 0x04000919 RID: 2329
		[Token(Token = "0x4000919")]
		NotExtended = 510,
		// Token: 0x0400091A RID: 2330
		[Token(Token = "0x400091A")]
		NetworkAuthenticationRequired
	}
}
