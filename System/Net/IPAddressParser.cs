using System;
using System.Text;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000289 RID: 649
	[Token(Token = "0x2000289")]
	internal class IPAddressParser
	{
		// Token: 0x0600123F RID: 4671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600123F")]
		[Address(RVA = "0x51AF4F0", Offset = "0x51AE0F0", VA = "0x1851AF4F0")]
		internal static IPAddress Parse(ReadOnlySpan<char> ipSpan, bool tryParse)
		{
			return null;
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001240")]
		[Address(RVA = "0x51AEDB0", Offset = "0x51AD9B0", VA = "0x1851AEDB0")]
		internal static string IPv4AddressToString(uint address)
		{
			return null;
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001241")]
		[Address(RVA = "0x51AEE10", Offset = "0x51ADA10", VA = "0x1851AEE10")]
		internal static void IPv4AddressToString(uint address, StringBuilder destination)
		{
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x00008DD8 File Offset: 0x00006FD8
		[Token(Token = "0x6001242")]
		[Address(RVA = "0x51AEB20", Offset = "0x51AD720", VA = "0x1851AEB20")]
		private unsafe static int IPv4AddressToStringHelper(uint address, char* addressString)
		{
			return 0;
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001243")]
		[Address(RVA = "0x51AF290", Offset = "0x51ADE90", VA = "0x1851AF290")]
		internal static string IPv6AddressToString(ushort[] address, uint scopeId)
		{
			return null;
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001244")]
		[Address(RVA = "0x51AEE80", Offset = "0x51ADA80", VA = "0x1851AEE80")]
		internal static StringBuilder IPv6AddressToStringHelper(ushort[] address, uint scopeId)
		{
			return null;
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001245")]
		[Address(RVA = "0x51AEA70", Offset = "0x51AD670", VA = "0x1851AEA70")]
		private unsafe static void FormatIPv4AddressNumber(int number, char* addressString, ref int offset)
		{
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00008DF0 File Offset: 0x00006FF0
		[Token(Token = "0x6001246")]
		[Address(RVA = "0x51AF2B0", Offset = "0x51ADEB0", VA = "0x1851AF2B0")]
		public static bool Ipv4StringToAddress(ReadOnlySpan<char> ipSpan, out long address)
		{
			return default(bool);
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x00008E08 File Offset: 0x00007008
		[Token(Token = "0x6001247")]
		[Address(RVA = "0x51AF3A0", Offset = "0x51ADFA0", VA = "0x1851AF3A0")]
		public unsafe static bool Ipv6StringToAddress(ReadOnlySpan<char> ipSpan, ushort* numbers, int numbersLength, out uint scope)
		{
			return default(bool);
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001248")]
		[Address(RVA = "0x51AE880", Offset = "0x51AD480", VA = "0x1851AE880")]
		private static void AppendSections(ushort[] address, int fromInclusive, int toExclusive, StringBuilder buffer)
		{
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001249")]
		[Address(RVA = "0x51AE7D0", Offset = "0x51AD3D0", VA = "0x1851AE7D0")]
		private static void AppendHex(ushort value, StringBuilder buffer)
		{
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x00008E20 File Offset: 0x00007020
		[Token(Token = "0x600124A")]
		[Address(RVA = "0x51AEA30", Offset = "0x51AD630", VA = "0x1851AEA30")]
		private static uint ExtractIPv4Address(ushort[] address)
		{
			return 0U;
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x00008E38 File Offset: 0x00007038
		[Token(Token = "0x600124B")]
		[Address(RVA = "0x51AF910", Offset = "0x51AE510", VA = "0x1851AF910")]
		private static ushort Reverse(ushort number)
		{
			return 0;
		}
	}
}
