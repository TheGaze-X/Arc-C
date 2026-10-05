using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000B8 RID: 184
	[Token(Token = "0x20000B8")]
	internal static class IriHelper
	{
		// Token: 0x06000391 RID: 913 RVA: 0x00003180 File Offset: 0x00001380
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x50CD8B0", Offset = "0x50CC4B0", VA = "0x1850CD8B0")]
		internal static bool CheckIriUnicodeRange(char unicode, bool isQuery)
		{
			return default(bool);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00003198 File Offset: 0x00001398
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x50CD330", Offset = "0x50CBF30", VA = "0x1850CD330")]
		internal static bool CheckIriUnicodeRange(char highSurr, char lowSurr, ref bool surrogatePair, bool isQuery)
		{
			return default(bool);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x000031B0 File Offset: 0x000013B0
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x50CD920", Offset = "0x50CC520", VA = "0x1850CD920")]
		internal static bool CheckIsReserved(char ch, UriComponents component)
		{
			return default(bool);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x50CDA30", Offset = "0x50CC630", VA = "0x1850CDA30")]
		internal unsafe static string EscapeUnescapeIri(char* pInput, int start, int end, UriComponents component)
		{
			return null;
		}
	}
}
