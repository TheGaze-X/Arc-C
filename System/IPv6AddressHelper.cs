using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000B1 RID: 177
	[Token(Token = "0x20000B1")]
	internal static class IPv6AddressHelper
	{
		// Token: 0x06000369 RID: 873 RVA: 0x00003060 File Offset: 0x00001260
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x50CBB10", Offset = "0x50CA710", VA = "0x1850CBB10")]
		internal static ValueTuple<int, int> FindCompressionRange(ReadOnlySpan<ushort> numbers)
		{
			return default(ValueTuple<int, int>);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00003078 File Offset: 0x00001278
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x50CCFB0", Offset = "0x50CBBB0", VA = "0x1850CCFB0")]
		internal static bool ShouldHaveIpv4Embedded(ReadOnlySpan<ushort> numbers)
		{
			return default(bool);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00003090 File Offset: 0x00001290
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x50CBF60", Offset = "0x50CAB60", VA = "0x1850CBF60")]
		internal unsafe static bool IsValidStrict(char* name, int start, ref int end)
		{
			return default(bool);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x50CCBC0", Offset = "0x50CB7C0", VA = "0x1850CCBC0")]
		internal unsafe static void Parse(ReadOnlySpan<char> address, ushort* numbers, int start, ref string scopeId)
		{
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x50CC2F0", Offset = "0x50CAEF0", VA = "0x1850CC2F0")]
		internal static string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId)
		{
			return null;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x000030A8 File Offset: 0x000012A8
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x50CBE90", Offset = "0x50CAA90", VA = "0x1850CBE90")]
		private static bool IsLoopback(ReadOnlySpan<ushort> numbers)
		{
			return default(bool);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x000030C0 File Offset: 0x000012C0
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x50CBBD0", Offset = "0x50CA7D0", VA = "0x1850CBBD0")]
		private unsafe static bool InternalIsValid(char* name, int start, ref int end, bool validateStrictAddress)
		{
			return default(bool);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x000030D8 File Offset: 0x000012D8
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x50CC2D0", Offset = "0x50CAED0", VA = "0x1850CC2D0")]
		internal unsafe static bool IsValid(char* name, int start, ref int end)
		{
			return default(bool);
		}
	}
}
