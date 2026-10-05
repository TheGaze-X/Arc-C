using System;
using System.IO;
using Il2CppDummyDll;

namespace BestHTTP
{
	// Token: 0x0200049F RID: 1183
	[Token(Token = "0x200049F")]
	internal static class HTTPProtocolFactory
	{
		// Token: 0x06002683 RID: 9859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002683")]
		[Address(RVA = "0x538B150", Offset = "0x5389D50", VA = "0x18538B150")]
		public static HTTPResponse Get(SupportedProtocols protocol, HTTPRequest request, Stream stream, bool isStreamed, bool isFromCache)
		{
			return null;
		}

		// Token: 0x06002684 RID: 9860 RVA: 0x00010AA0 File Offset: 0x0000ECA0
		[Token(Token = "0x6002684")]
		[Address(RVA = "0x538B010", Offset = "0x5389C10", VA = "0x18538B010")]
		public static SupportedProtocols GetProtocolFromUri(Uri uri)
		{
			return SupportedProtocols.Unknown;
		}

		// Token: 0x06002685 RID: 9861 RVA: 0x00010AB8 File Offset: 0x0000ECB8
		[Token(Token = "0x6002685")]
		[Address(RVA = "0x538B280", Offset = "0x5389E80", VA = "0x18538B280")]
		public static bool IsSecureProtocol(Uri uri)
		{
			return default(bool);
		}
	}
}
