using System;
using Il2CppDummyDll;

namespace BestHTTP
{
	// Token: 0x020004A6 RID: 1190
	// (Invoke) Token: 0x060026AE RID: 9902
	[Token(Token = "0x20004A6")]
	public delegate bool OnBeforeRedirectionDelegate(HTTPRequest originalRequest, HTTPResponse response, Uri redirectUri);
}
