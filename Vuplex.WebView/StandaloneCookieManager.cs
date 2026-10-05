using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	public class StandaloneCookieManager : ICookieManager
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700003A")]
		public static StandaloneCookieManager Instance
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x5BBAF70", Offset = "0x5BB9B70", VA = "0x185BBAF70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x5BBADE0", Offset = "0x5BB99E0", VA = "0x185BBADE0", Slot = "4")]
		public Task<bool> DeleteCookies(string url, [Optional] string cookieName)
		{
			return null;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x5BBAEC0", Offset = "0x5BB9AC0", VA = "0x185BBAEC0", Slot = "5")]
		public Task<Cookie[]> GetCookies(string url, [Optional] string cookieName)
		{
			return null;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x5BBAF20", Offset = "0x5BB9B20", VA = "0x185BBAF20", Slot = "6")]
		public Task<bool> SetCookie(Cookie cookie)
		{
			return null;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StandaloneCookieManager()
		{
		}

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static StandaloneCookieManager _instance;
	}
}
