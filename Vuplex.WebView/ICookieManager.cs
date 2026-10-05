using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	public interface ICookieManager
	{
		// Token: 0x060000D9 RID: 217
		[Token(Token = "0x60000D9")]
		Task<bool> DeleteCookies(string url, [Optional] string cookieName);

		// Token: 0x060000DA RID: 218
		[Token(Token = "0x60000DA")]
		Task<Cookie[]> GetCookies(string url, [Optional] string cookieName);

		// Token: 0x060000DB RID: 219
		[Token(Token = "0x60000DB")]
		Task<bool> SetCookie(Cookie cookie);
	}
}
