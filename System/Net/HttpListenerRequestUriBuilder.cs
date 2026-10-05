using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002AB RID: 683
	[Token(Token = "0x20002AB")]
	internal sealed class HttpListenerRequestUriBuilder
	{
		// Token: 0x06001338 RID: 4920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001338")]
		[Address(RVA = "0x51ADB60", Offset = "0x51AC760", VA = "0x1851ADB60")]
		private HttpListenerRequestUriBuilder(string rawUri, string cookedUriScheme, string cookedUriHost, string cookedUriPath, string cookedUriQuery)
		{
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001339")]
		[Address(RVA = "0x51AD5E0", Offset = "0x51AC1E0", VA = "0x1851AD5E0")]
		public static Uri GetRequestUri(string rawUri, string cookedUriScheme, string cookedUriHost, string cookedUriPath, string cookedUriQuery)
		{
			return null;
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600133A")]
		[Address(RVA = "0x51ACC10", Offset = "0x51AB810", VA = "0x1851ACC10")]
		private Uri Build()
		{
			return null;
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600133B")]
		[Address(RVA = "0x51AC030", Offset = "0x51AAC30", VA = "0x1851AC030")]
		private void BuildRequestUriUsingCookedPath()
		{
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600133C")]
		[Address(RVA = "0x51AC3D0", Offset = "0x51AAFD0", VA = "0x1851AC3D0")]
		private void BuildRequestUriUsingRawPath()
		{
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600133D")]
		[Address(RVA = "0x51AD110", Offset = "0x51ABD10", VA = "0x1851AD110")]
		private static Encoding GetEncoding(HttpListenerRequestUriBuilder.EncodingType type)
		{
			return null;
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x000094F8 File Offset: 0x000076F8
		[Token(Token = "0x600133E")]
		[Address(RVA = "0x51AC900", Offset = "0x51AB500", VA = "0x1851AC900")]
		private HttpListenerRequestUriBuilder.ParsingResult BuildRequestUriUsingRawPath(Encoding encoding)
		{
			return HttpListenerRequestUriBuilder.ParsingResult.Success;
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x00009510 File Offset: 0x00007710
		[Token(Token = "0x600133F")]
		[Address(RVA = "0x51AD830", Offset = "0x51AC430", VA = "0x1851AD830")]
		private HttpListenerRequestUriBuilder.ParsingResult ParseRawPath(Encoding encoding)
		{
			return HttpListenerRequestUriBuilder.ParsingResult.Success;
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x00009528 File Offset: 0x00007728
		[Token(Token = "0x6001340")]
		[Address(RVA = "0x51ABD10", Offset = "0x51AA910", VA = "0x1851ABD10")]
		private bool AppendUnicodeCodePointValuePercentEncoded(string codePoint)
		{
			return default(bool);
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x00009540 File Offset: 0x00007740
		[Token(Token = "0x6001341")]
		[Address(RVA = "0x51AB8F0", Offset = "0x51AA4F0", VA = "0x1851AB8F0")]
		private bool AddPercentEncodedOctetToRawOctetsList(Encoding encoding, string escapedCharacter)
		{
			return default(bool);
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x00009558 File Offset: 0x00007758
		[Token(Token = "0x6001342")]
		[Address(RVA = "0x51ACD10", Offset = "0x51AB910", VA = "0x1851ACD10")]
		private bool EmptyDecodeAndAppendRawOctetsList(Encoding encoding)
		{
			return default(bool);
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001343")]
		[Address(RVA = "0x51ABAC0", Offset = "0x51AA6C0", VA = "0x1851ABAC0")]
		private static void AppendOctetsPercentEncoded(StringBuilder target, IEnumerable<byte> octets)
		{
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001344")]
		[Address(RVA = "0x51AD1A0", Offset = "0x51ABDA0", VA = "0x1851AD1A0")]
		private static string GetOctetsAsString(IEnumerable<byte> octets)
		{
			return null;
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001345")]
		[Address(RVA = "0x51AD460", Offset = "0x51AC060", VA = "0x1851AD460")]
		private static string GetPath(string uriString)
		{
			return null;
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001346")]
		[Address(RVA = "0x51ABA60", Offset = "0x51AA660", VA = "0x1851ABA60")]
		private static string AddSlashToAsteriskOnlyPath(string path)
		{
			return null;
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001347")]
		[Address(RVA = "0x51AD820", Offset = "0x51AC420", VA = "0x1851AD820")]
		private void LogWarning(string methodName, string message, params object[] args)
		{
		}

		// Token: 0x04000A13 RID: 2579
		[Token(Token = "0x4000A13")]
		[FieldOffset(Offset = "0x0")]
		private static readonly bool useCookedRequestUrl;

		// Token: 0x04000A14 RID: 2580
		[Token(Token = "0x4000A14")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Encoding utf8Encoding;

		// Token: 0x04000A15 RID: 2581
		[Token(Token = "0x4000A15")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Encoding ansiEncoding;

		// Token: 0x04000A16 RID: 2582
		[Token(Token = "0x4000A16")]
		[FieldOffset(Offset = "0x10")]
		private readonly string rawUri;

		// Token: 0x04000A17 RID: 2583
		[Token(Token = "0x4000A17")]
		[FieldOffset(Offset = "0x18")]
		private readonly string cookedUriScheme;

		// Token: 0x04000A18 RID: 2584
		[Token(Token = "0x4000A18")]
		[FieldOffset(Offset = "0x20")]
		private readonly string cookedUriHost;

		// Token: 0x04000A19 RID: 2585
		[Token(Token = "0x4000A19")]
		[FieldOffset(Offset = "0x28")]
		private readonly string cookedUriPath;

		// Token: 0x04000A1A RID: 2586
		[Token(Token = "0x4000A1A")]
		[FieldOffset(Offset = "0x30")]
		private readonly string cookedUriQuery;

		// Token: 0x04000A1B RID: 2587
		[Token(Token = "0x4000A1B")]
		[FieldOffset(Offset = "0x38")]
		private StringBuilder requestUriString;

		// Token: 0x04000A1C RID: 2588
		[Token(Token = "0x4000A1C")]
		[FieldOffset(Offset = "0x40")]
		private List<byte> rawOctets;

		// Token: 0x04000A1D RID: 2589
		[Token(Token = "0x4000A1D")]
		[FieldOffset(Offset = "0x48")]
		private string rawPath;

		// Token: 0x04000A1E RID: 2590
		[Token(Token = "0x4000A1E")]
		[FieldOffset(Offset = "0x50")]
		private Uri requestUri;

		// Token: 0x020002AC RID: 684
		[Token(Token = "0x20002AC")]
		private enum ParsingResult
		{
			// Token: 0x04000A20 RID: 2592
			[Token(Token = "0x4000A20")]
			Success,
			// Token: 0x04000A21 RID: 2593
			[Token(Token = "0x4000A21")]
			InvalidString,
			// Token: 0x04000A22 RID: 2594
			[Token(Token = "0x4000A22")]
			EncodingError
		}

		// Token: 0x020002AD RID: 685
		[Token(Token = "0x20002AD")]
		private enum EncodingType
		{
			// Token: 0x04000A24 RID: 2596
			[Token(Token = "0x4000A24")]
			Primary,
			// Token: 0x04000A25 RID: 2597
			[Token(Token = "0x4000A25")]
			Secondary
		}
	}
}
