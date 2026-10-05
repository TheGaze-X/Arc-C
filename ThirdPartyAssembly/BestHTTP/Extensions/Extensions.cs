using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace BestHTTP.Extensions
{
	// Token: 0x020004DA RID: 1242
	[Token(Token = "0x20004DA")]
	public static class Extensions
	{
		// Token: 0x06002917 RID: 10519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002917")]
		[Address(RVA = "0x53A28D0", Offset = "0x53A14D0", VA = "0x1853A28D0")]
		public static string AsciiToString(this byte[] bytes)
		{
			return null;
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002918")]
		[Address(RVA = "0x53A2D60", Offset = "0x53A1960", VA = "0x1853A2D60")]
		public static byte[] GetASCIIBytes(this string str)
		{
			return null;
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002919")]
		[Address(RVA = "0x53A3AC0", Offset = "0x53A26C0", VA = "0x1853A3AC0")]
		public static void SendAsASCII(this BinaryWriter stream, string str)
		{
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600291A")]
		[Address(RVA = "0x53A3EF0", Offset = "0x53A2AF0", VA = "0x1853A3EF0")]
		public static void WriteLine(this FileStream fs)
		{
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600291B")]
		[Address(RVA = "0x53A4040", Offset = "0x53A2C40", VA = "0x1853A4040")]
		public static void WriteLine(this FileStream fs, string line)
		{
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600291C")]
		[Address(RVA = "0x53A4140", Offset = "0x53A2D40", VA = "0x1853A4140")]
		public static void WriteLine(this FileStream fs, string format, params object[] values)
		{
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600291D")]
		[Address(RVA = "0x53A2E10", Offset = "0x53A1A10", VA = "0x1853A2E10")]
		public static string GetRequestPathAndQueryURL(this Uri uri)
		{
			return null;
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600291E")]
		[Address(RVA = "0x53A2BF0", Offset = "0x53A17F0", VA = "0x1853A2BF0")]
		public static string[] FindOption(this string str, string option)
		{
			return null;
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600291F")]
		[Address(RVA = "0x53A3E80", Offset = "0x53A2A80", VA = "0x1853A3E80")]
		public static void WriteArray(this Stream stream, byte[] array)
		{
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x00011640 File Offset: 0x0000F840
		[Token(Token = "0x6002920")]
		[Address(RVA = "0x53A3C60", Offset = "0x53A2860", VA = "0x1853A3C60")]
		public static int ToInt32(this string str, int defaultValue = 0)
		{
			return 0;
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x00011658 File Offset: 0x0000F858
		[Token(Token = "0x6002921")]
		[Address(RVA = "0x53A3C90", Offset = "0x53A2890", VA = "0x1853A3C90")]
		public static long ToInt64(this string str, long defaultValue = 0L)
		{
			return 0L;
		}

		// Token: 0x06002922 RID: 10530 RVA: 0x00011670 File Offset: 0x0000F870
		[Token(Token = "0x6002922")]
		[Address(RVA = "0x53A3BE0", Offset = "0x53A27E0", VA = "0x1853A3BE0")]
		public static DateTime ToDateTime(this string str, [Optional] DateTime defaultValue)
		{
			return default(DateTime);
		}

		// Token: 0x06002923 RID: 10531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002923")]
		[Address(RVA = "0x53A3CC0", Offset = "0x53A28C0", VA = "0x1853A3CC0")]
		public static string ToStrOrEmpty(this string str)
		{
			return null;
		}

		// Token: 0x06002924 RID: 10532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002924")]
		[Address(RVA = "0x53A2AD0", Offset = "0x53A16D0", VA = "0x1853A2AD0")]
		public static string CalculateMD5Hash(this string input)
		{
			return null;
		}

		// Token: 0x06002925 RID: 10533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002925")]
		[Address(RVA = "0x53A29B0", Offset = "0x53A15B0", VA = "0x1853A29B0")]
		public static string CalculateMD5Hash(this byte[] input)
		{
			return null;
		}

		// Token: 0x06002926 RID: 10534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002926")]
		[Address(RVA = "0x53A39D0", Offset = "0x53A25D0", VA = "0x1853A39D0")]
		internal static string Read(this string str, ref int pos, char block, bool needResult = true)
		{
			return null;
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002927")]
		[Address(RVA = "0x53A3880", Offset = "0x53A2480", VA = "0x1853A3880")]
		internal static string Read(this string str, ref int pos, Func<char, bool> block, bool needResult = true)
		{
			return null;
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002928")]
		[Address(RVA = "0x53A35F0", Offset = "0x53A21F0", VA = "0x1853A35F0")]
		internal static string ReadPossibleQuotedText(this string str, ref int pos)
		{
			return null;
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002929")]
		[Address(RVA = "0x53A3B40", Offset = "0x53A2740", VA = "0x1853A3B40")]
		internal static void SkipWhiteSpace(this string str, ref int pos)
		{
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600292A")]
		[Address(RVA = "0x53A3D10", Offset = "0x53A2910", VA = "0x1853A3D10")]
		internal static string TrimAndLower(this string str)
		{
			return null;
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x00011688 File Offset: 0x0000F888
		[Token(Token = "0x600292B")]
		[Address(RVA = "0x53A34B0", Offset = "0x53A20B0", VA = "0x1853A34B0")]
		internal static char? Peek(this string str, int pos)
		{
			return null;
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600292C")]
		[Address(RVA = "0x53A2E80", Offset = "0x53A1A80", VA = "0x1853A2E80")]
		internal static List<HeaderValue> ParseOptionalHeader(this string str)
		{
			return null;
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600292D")]
		[Address(RVA = "0x53A3180", Offset = "0x53A1D80", VA = "0x1853A3180")]
		internal static List<HeaderValue> ParseQualityParams(this string str)
		{
			return null;
		}

		// Token: 0x0600292E RID: 10542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600292E")]
		[Address(RVA = "0x53A3540", Offset = "0x53A2140", VA = "0x1853A3540")]
		public static void ReadBuffer(this Stream stream, byte[] buffer)
		{
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600292F")]
		[Address(RVA = "0x53A3E80", Offset = "0x53A2A80", VA = "0x1853A3E80")]
		public static void WriteAll(this MemoryStream ms, byte[] buffer)
		{
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002930")]
		[Address(RVA = "0x53A4310", Offset = "0x53A2F10", VA = "0x1853A4310")]
		public static void WriteString(this MemoryStream ms, string str)
		{
		}

		// Token: 0x06002931 RID: 10545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002931")]
		[Address(RVA = "0x53A3F90", Offset = "0x53A2B90", VA = "0x1853A3F90")]
		public static void WriteLine(this MemoryStream ms)
		{
		}

		// Token: 0x06002932 RID: 10546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002932")]
		[Address(RVA = "0x53A4250", Offset = "0x53A2E50", VA = "0x1853A4250")]
		public static void WriteLine(this MemoryStream ms, string str)
		{
		}
	}
}
