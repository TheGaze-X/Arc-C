using System;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngineInternal
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	internal static class WebRequestUtils
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x5B9F4C0", Offset = "0x5B9E0C0", VA = "0x185B9F4C0")]
		[RequiredByNativeCode]
		internal static string RedirectTo(string baseUri, string redirectUri)
		{
			return null;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x5B9EE00", Offset = "0x5B9DA00", VA = "0x185B9EE00")]
		internal static string MakeInitialUrl(string targetUrl, string localUrl)
		{
			return null;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x5B9F110", Offset = "0x5B9DD10", VA = "0x185B9F110")]
		internal static string MakeUriString(Uri targetUri, string targetUrl, bool prependProtocol)
		{
			return null;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x5B9F5E0", Offset = "0x5B9E1E0", VA = "0x185B9F5E0")]
		private static string URLDecode(string encoded)
		{
			return null;
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		private static Regex domainRegex;
	}
}
