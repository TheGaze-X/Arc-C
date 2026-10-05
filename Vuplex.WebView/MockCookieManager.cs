using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	internal class MockCookieManager : ICookieManager
	{
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000027")]
		public static MockCookieManager Instance
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x5BB5F00", Offset = "0x5BB4B00", VA = "0x185BB5F00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x5BB5D00", Offset = "0x5BB4900", VA = "0x185BB5D00", Slot = "4")]
		public Task<bool> DeleteCookies(string url, [Optional] string cookieName)
		{
			return null;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x5BB5D20", Offset = "0x5BB4920", VA = "0x185BB5D20", Slot = "5")]
		public Task<Cookie[]> GetCookies(string url, [Optional] string cookieName)
		{
			return null;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x5BB5D40", Offset = "0x5BB4940", VA = "0x185BB5D40", Slot = "6")]
		public Task<bool> SetCookie(Cookie cookie)
		{
			return null;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MockCookieManager()
		{
		}

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static MockCookieManager _instance;
	}
}
