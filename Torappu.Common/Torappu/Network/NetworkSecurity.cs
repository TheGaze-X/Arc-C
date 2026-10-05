using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Network
{
	// Token: 0x02000235 RID: 565
	[Token(Token = "0x2000235")]
	public static class NetworkSecurity
	{
		// Token: 0x06000D0C RID: 3340 RVA: 0x00008654 File Offset: 0x00006854
		[Token(Token = "0x6000D0C")]
		[Address(RVA = "0x5584B60", Offset = "0x5583760", VA = "0x185584B60")]
		public static bool Init(out int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x0000866C File Offset: 0x0000686C
		[Token(Token = "0x6000D0D")]
		[Address(RVA = "0x5584B70", Offset = "0x5583770", VA = "0x185584B70")]
		public static bool SecureUrl(string rawUrl, out string newUrl, out int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000D0E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public static void SecureHeader(ref Dictionary<string, string> header)
		{
		}
	}
}
