using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000B0 RID: 176
	[Token(Token = "0x20000B0")]
	internal static class IPv4AddressHelper
	{
		// Token: 0x06000362 RID: 866 RVA: 0x00002FD0 File Offset: 0x000011D0
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x50CB710", Offset = "0x50CA310", VA = "0x1850CB710")]
		internal static int ParseHostNumber(ReadOnlySpan<char> str, int start, int end)
		{
			return 0;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00002FE8 File Offset: 0x000011E8
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x50CB210", Offset = "0x50C9E10", VA = "0x1850CB210")]
		internal unsafe static bool IsValid(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme)
		{
			return default(bool);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00003000 File Offset: 0x00001200
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x50CB680", Offset = "0x50CA280", VA = "0x1850CB680")]
		private unsafe static bool ParseCanonical(ReadOnlySpan<char> name, byte* numbers, int start, int end)
		{
			return default(bool);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00003018 File Offset: 0x00001218
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x50CB0C0", Offset = "0x50C9CC0", VA = "0x1850CB0C0")]
		internal unsafe static bool IsValidCanonical(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile)
		{
			return default(bool);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00003030 File Offset: 0x00001230
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x50CB7E0", Offset = "0x50CA3E0", VA = "0x1850CB7E0")]
		internal unsafe static long ParseNonCanonical(char* name, int start, ref int end, bool notImplicitFile)
		{
			return 0L;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x50CB3A0", Offset = "0x50C9FA0", VA = "0x1850CB3A0")]
		internal static string ParseCanonicalName(string str, int start, int end, ref bool isLoopback)
		{
			return null;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00003048 File Offset: 0x00001248
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x50CBA80", Offset = "0x50CA680", VA = "0x1850CBA80")]
		private unsafe static bool Parse(string name, byte* numbers, int start, int end)
		{
			return default(bool);
		}
	}
}
