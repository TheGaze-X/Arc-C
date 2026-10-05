using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000118 RID: 280
	[Token(Token = "0x2000118")]
	internal static class Number
	{
		// Token: 0x06000920 RID: 2336 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000920")]
		[Address(RVA = "0x4CDEA50", Offset = "0x4CDD650", VA = "0x184CDEA50")]
		public static string FormatDecimal(decimal value, System.ReadOnlySpan<char> format, System.Globalization.NumberFormatInfo info)
		{
			return null;
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00008FD0 File Offset: 0x000071D0
		[Token(Token = "0x6000921")]
		[Address(RVA = "0x4CE5F30", Offset = "0x4CE4B30", VA = "0x184CE5F30")]
		public static bool TryFormatDecimal(decimal value, System.ReadOnlySpan<char> format, System.Globalization.NumberFormatInfo info, System.Span<char> destination, out int charsWritten)
		{
			return default(bool);
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000922")]
		[Address(RVA = "0x4CDE310", Offset = "0x4CDCF10", VA = "0x184CDE310")]
		private static void DecimalToNumber(decimal value, ref Number.NumberBuffer number)
		{
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000923")]
		[Address(RVA = "0x4CDEC40", Offset = "0x4CDD840", VA = "0x184CDEC40")]
		public static string FormatDouble(double value, string format, System.Globalization.NumberFormatInfo info)
		{
			return null;
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00008FE8 File Offset: 0x000071E8
		[Token(Token = "0x6000924")]
		[Address(RVA = "0x4CE6130", Offset = "0x4CE4D30", VA = "0x184CE6130")]
		public static bool TryFormatDouble(double value, System.ReadOnlySpan<char> format, System.Globalization.NumberFormatInfo info, System.Span<char> destination, out int charsWritten)
		{
			return default(bool);
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000925")]
		[Address(RVA = "0x4CDEDB0", Offset = "0x4CDD9B0", VA = "0x184CDEDB0")]
		private static string FormatDouble(ref ValueStringBuilder sb, double value, System.ReadOnlySpan<char> format, System.Globalization.NumberFormatInfo info)
		{
			return null;
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000926")]
		[Address(RVA = "0x4CE0520", Offset = "0x4CDF120", VA = "0x184CE0520")]
		public static string FormatSingle(float value, string format, System.Globalization.NumberFormatInfo info)
		{
			return null;
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00009000 File Offset: 0x00007200
		[Token(Token = "0x6000927")]
		[Address(RVA = "0x4CE6A30", Offset = "0x4CE5630", VA = "0x184CE6A30")]
		public static bool TryFormatSingle(float value, System.ReadOnlySpan<char> format, System.Globalization.NumberFormatInfo info, System.Span<char> destination, out int charsWritten)
		{
			return default(bool);
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000928")]
		[Address(RVA = "0x4CE0690", Offset = "0x4CDF290", VA = "0x184CE0690")]
		private static string FormatSingle(ref ValueStringBuilder sb, float value, System.ReadOnlySpan<char> format, System.Globalization.NumberFormatInfo info)
		{
			return null;
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00009018 File Offset: 0x00007218
		[Token(Token = "0x6000929")]
		[Address(RVA = "0x4CE5E50", Offset = "0x4CE4A50", VA = "0x184CE5E50")]
		private static bool TryCopyTo(string source, System.Span<char> destination, out int charsWritten)
		{
			return default(bool);
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600092A")]
		[Address(RVA = "0x4CDF980", Offset = "0x4CDE580", VA = "0x184CDF980")]
		public static string FormatInt32(int value, System.ReadOnlySpan<char> format, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00009030 File Offset: 0x00007230
		[Token(Token = "0x600092B")]
		[Address(RVA = "0x4CE6320", Offset = "0x4CE4F20", VA = "0x184CE6320")]
		public static bool TryFormatInt32(int value, System.ReadOnlySpan<char> format, System.IFormatProvider provider, System.Span<char> destination, out int charsWritten)
		{
			return default(bool);
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600092C")]
		[Address(RVA = "0x4CE0980", Offset = "0x4CDF580", VA = "0x184CE0980")]
		public static string FormatUInt32(uint value, System.ReadOnlySpan<char> format, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00009048 File Offset: 0x00007248
		[Token(Token = "0x600092D")]
		[Address(RVA = "0x4CE6C20", Offset = "0x4CE5820", VA = "0x184CE6C20")]
		public static bool TryFormatUInt32(uint value, System.ReadOnlySpan<char> format, System.IFormatProvider provider, System.Span<char> destination, out int charsWritten)
		{
			return default(bool);
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600092E")]
		[Address(RVA = "0x4CDFC90", Offset = "0x4CDE890", VA = "0x184CDFC90")]
		public static string FormatInt64(long value, System.ReadOnlySpan<char> format, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00009060 File Offset: 0x00007260
		[Token(Token = "0x600092F")]
		[Address(RVA = "0x4CE66A0", Offset = "0x4CE52A0", VA = "0x184CE66A0")]
		public static bool TryFormatInt64(long value, System.ReadOnlySpan<char> format, System.IFormatProvider provider, System.Span<char> destination, out int charsWritten)
		{
			return default(bool);
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000930")]
		[Address(RVA = "0x4CE0C30", Offset = "0x4CDF830", VA = "0x184CE0C30")]
		public static string FormatUInt64(ulong value, System.ReadOnlySpan<char> format, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00009078 File Offset: 0x00007278
		[Token(Token = "0x6000931")]
		[Address(RVA = "0x4CE6F20", Offset = "0x4CE5B20", VA = "0x184CE6F20")]
		public static bool TryFormatUInt64(ulong value, System.ReadOnlySpan<char> format, System.IFormatProvider provider, System.Span<char> destination, out int charsWritten)
		{
			return default(bool);
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000932")]
		[Address(RVA = "0x4CE1070", Offset = "0x4CDFC70", VA = "0x184CE1070")]
		[MethodImpl(256)]
		private static void Int32ToNumber(int value, ref Number.NumberBuffer number)
		{
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000933")]
		[Address(RVA = "0x4CE16F0", Offset = "0x4CE02F0", VA = "0x184CE16F0")]
		private static string NegativeInt32ToDecStr(int value, int digits, string sNegative)
		{
			return null;
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00009090 File Offset: 0x00007290
		[Token(Token = "0x6000934")]
		[Address(RVA = "0x4CE75D0", Offset = "0x4CE61D0", VA = "0x184CE75D0")]
		private static bool TryNegativeInt32ToDecStr(int value, int digits, string sNegative, System.Span<char> destination, out int charsWritten)
		{
			return default(bool);
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000935")]
		[Address(RVA = "0x4CE0F40", Offset = "0x4CDFB40", VA = "0x184CE0F40")]
		private static string Int32ToHexStr(int value, char hexBase, int digits)
		{
			return null;
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x000090A8 File Offset: 0x000072A8
		[Token(Token = "0x6000936")]
		[Address(RVA = "0x4CE7220", Offset = "0x4CE5E20", VA = "0x184CE7220")]
		private static bool TryInt32ToHexStr(int value, char hexBase, int digits, System.Span<char> destination, out int charsWritten)
		{
			return default(bool);
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000937")]
		[Address(RVA = "0x4CE0F00", Offset = "0x4CDFB00", VA = "0x184CE0F00")]
		private unsafe static char* Int32ToHexChars(char* buffer, uint value, int hexBase, int digits)
		{
			return null;
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000938")]
		[Address(RVA = "0x4CEAB30", Offset = "0x4CE9730", VA = "0x184CEAB30")]
		[MethodImpl(256)]
		private static void UInt32ToNumber(uint value, ref Number.NumberBuffer number)
		{
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000939")]
		[Address(RVA = "0x4CEA950", Offset = "0x4CE9550", VA = "0x184CEA950")]
		internal unsafe static char* UInt32ToDecChars(char* bufferEnd, uint value, int digits)
		{
			return null;
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600093A")]
		[Address(RVA = "0x4CEA9B0", Offset = "0x4CE95B0", VA = "0x184CEA9B0")]
		private static string UInt32ToDecStr(uint value, int digits)
		{
			return null;
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x000090C0 File Offset: 0x000072C0
		[Token(Token = "0x600093B")]
		[Address(RVA = "0x4CEA5A0", Offset = "0x4CE91A0", VA = "0x184CEA5A0")]
		private static bool TryUInt32ToDecStr(uint value, int digits, System.Span<char> destination, out int charsWritten)
		{
			return default(bool);
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600093C")]
		[Address(RVA = "0x4CE13D0", Offset = "0x4CDFFD0", VA = "0x184CE13D0")]
		private static void Int64ToNumber(long input, ref Number.NumberBuffer number)
		{
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600093D")]
		[Address(RVA = "0x4CE1890", Offset = "0x4CE0490", VA = "0x184CE1890")]
		private static string NegativeInt64ToDecStr(long input, int digits, string sNegative)
		{
			return null;
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x000090D8 File Offset: 0x000072D8
		[Token(Token = "0x600093E")]
		[Address(RVA = "0x4CE77B0", Offset = "0x4CE63B0", VA = "0x184CE77B0")]
		private static bool TryNegativeInt64ToDecStr(long input, int digits, string sNegative, System.Span<char> destination, out int charsWritten)
		{
			return default(bool);
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600093F")]
		[Address(RVA = "0x4CE11B0", Offset = "0x4CDFDB0", VA = "0x184CE11B0")]
		private static string Int64ToHexStr(long value, char hexBase, int digits)
		{
			return null;
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x000090F0 File Offset: 0x000072F0
		[Token(Token = "0x6000940")]
		[Address(RVA = "0x4CE7390", Offset = "0x4CE5F90", VA = "0x184CE7390")]
		private static bool TryInt64ToHexStr(long value, char hexBase, int digits, System.Span<char> destination, out int charsWritten)
		{
			return default(bool);
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000941")]
		[Address(RVA = "0x4CEADE0", Offset = "0x4CE99E0", VA = "0x184CEADE0")]
		private static void UInt64ToNumber(ulong value, ref Number.NumberBuffer number)
		{
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000942")]
		[Address(RVA = "0x4CEAC20", Offset = "0x4CE9820", VA = "0x184CEAC20")]
		private static string UInt64ToDecStr(ulong value, int digits)
		{
			return null;
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00009108 File Offset: 0x00007308
		[Token(Token = "0x6000943")]
		[Address(RVA = "0x4CEA760", Offset = "0x4CE9360", VA = "0x184CEA760")]
		private static bool TryUInt64ToDecStr(ulong value, int digits, System.Span<char> destination, out int charsWritten)
		{
			return default(bool);
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00009120 File Offset: 0x00007320
		[Token(Token = "0x6000944")]
		[Address(RVA = "0x4CE41D0", Offset = "0x4CE2DD0", VA = "0x184CE41D0")]
		internal static char ParseFormatSpecifier(System.ReadOnlySpan<char> format, out int digits)
		{
			return '\0';
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000945")]
		[Address(RVA = "0x4CE3260", Offset = "0x4CE1E60", VA = "0x184CE3260")]
		internal static void NumberToString(ref ValueStringBuilder sb, ref Number.NumberBuffer number, char format, int nMaxDigits, System.Globalization.NumberFormatInfo info, bool isDecimal)
		{
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000946")]
		[Address(RVA = "0x4CE2580", Offset = "0x4CE1180", VA = "0x184CE2580")]
		internal static void NumberToStringFormat(ref ValueStringBuilder sb, ref Number.NumberBuffer number, System.ReadOnlySpan<char> format, System.Globalization.NumberFormatInfo info)
		{
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000947")]
		[Address(RVA = "0x4CDE840", Offset = "0x4CDD440", VA = "0x184CDE840")]
		private static void FormatCurrency(ref ValueStringBuilder sb, ref Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info)
		{
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000948")]
		[Address(RVA = "0x4CDF200", Offset = "0x4CDDE00", VA = "0x184CDF200")]
		private static void FormatFixed(ref ValueStringBuilder sb, ref Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup)
		{
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000949")]
		[Address(RVA = "0x4CDFFA0", Offset = "0x4CDEBA0", VA = "0x184CDFFA0")]
		private static void FormatNumber(ref ValueStringBuilder sb, ref Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info)
		{
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094A")]
		[Address(RVA = "0x4CE0390", Offset = "0x4CDEF90", VA = "0x184CE0390")]
		private static void FormatScientific(ref ValueStringBuilder sb, ref Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info, char expChar)
		{
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094B")]
		[Address(RVA = "0x4CDF080", Offset = "0x4CDDC80", VA = "0x184CDF080")]
		private static void FormatExponent(ref ValueStringBuilder sb, System.Globalization.NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign)
		{
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094C")]
		[Address(RVA = "0x4CDF6E0", Offset = "0x4CDE2E0", VA = "0x184CDF6E0")]
		private static void FormatGeneral(ref ValueStringBuilder sb, ref Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info, char expChar, bool bSuppressScientific)
		{
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094D")]
		[Address(RVA = "0x4CE0170", Offset = "0x4CDED70", VA = "0x184CE0170")]
		private static void FormatPercent(ref ValueStringBuilder sb, ref Number.NumberBuffer number, int nMinDigits, int nMaxDigits, System.Globalization.NumberFormatInfo info)
		{
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094E")]
		[Address(RVA = "0x4CE5AE0", Offset = "0x4CE46E0", VA = "0x184CE5AE0")]
		private static void RoundNumber(ref Number.NumberBuffer number, int pos)
		{
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00009138 File Offset: 0x00007338
		[Token(Token = "0x600094F")]
		[Address(RVA = "0x4CDE720", Offset = "0x4CDD320", VA = "0x184CDE720")]
		private static int FindSection(System.ReadOnlySpan<char> format, int section)
		{
			return 0;
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00009150 File Offset: 0x00007350
		[Token(Token = "0x6000950")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		private static uint Low32(ulong value)
		{
			return 0U;
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00009168 File Offset: 0x00007368
		[Token(Token = "0x6000951")]
		[Address(RVA = "0x4CE0EF0", Offset = "0x4CDFAF0", VA = "0x184CE0EF0")]
		private static uint High32(ulong value)
		{
			return 0U;
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00009180 File Offset: 0x00007380
		[Token(Token = "0x6000952")]
		[Address(RVA = "0x4CE1170", Offset = "0x4CDFD70", VA = "0x184CE1170")]
		private static uint Int64DivMod1E9(ref ulong value)
		{
			return 0U;
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00009198 File Offset: 0x00007398
		[Token(Token = "0x6000953")]
		[Address(RVA = "0x4CE24B0", Offset = "0x4CE10B0", VA = "0x184CE24B0")]
		private static bool NumberToInt32(ref Number.NumberBuffer number, ref int value)
		{
			return default(bool);
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x000091B0 File Offset: 0x000073B0
		[Token(Token = "0x6000954")]
		[Address(RVA = "0x4CE2510", Offset = "0x4CE1110", VA = "0x184CE2510")]
		private static bool NumberToInt64(ref Number.NumberBuffer number, ref long value)
		{
			return default(bool);
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x000091C8 File Offset: 0x000073C8
		[Token(Token = "0x6000955")]
		[Address(RVA = "0x4CE3C00", Offset = "0x4CE2800", VA = "0x184CE3C00")]
		private static bool NumberToUInt32(ref Number.NumberBuffer number, ref uint value)
		{
			return default(bool);
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x000091E0 File Offset: 0x000073E0
		[Token(Token = "0x6000956")]
		[Address(RVA = "0x4CE3C60", Offset = "0x4CE2860", VA = "0x184CE3C60")]
		private static bool NumberToUInt64(ref Number.NumberBuffer number, ref ulong value)
		{
			return default(bool);
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x000091F8 File Offset: 0x000073F8
		[Token(Token = "0x6000957")]
		[Address(RVA = "0x4CE4330", Offset = "0x4CE2F30", VA = "0x184CE4330")]
		internal static int ParseInt32(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo info)
		{
			return 0;
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00009210 File Offset: 0x00007410
		[Token(Token = "0x6000958")]
		[Address(RVA = "0x4CE4570", Offset = "0x4CE3170", VA = "0x184CE4570")]
		internal static long ParseInt64(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo info)
		{
			return 0L;
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00009228 File Offset: 0x00007428
		[Token(Token = "0x6000959")]
		[Address(RVA = "0x4CE5670", Offset = "0x4CE4270", VA = "0x184CE5670")]
		internal static uint ParseUInt32(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo info)
		{
			return 0U;
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00009240 File Offset: 0x00007440
		[Token(Token = "0x600095A")]
		[Address(RVA = "0x4CE58A0", Offset = "0x4CE44A0", VA = "0x184CE58A0")]
		internal static ulong ParseUInt64(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo info)
		{
			return 0UL;
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00009258 File Offset: 0x00007458
		[Token(Token = "0x600095B")]
		[Address(RVA = "0x4CE47B0", Offset = "0x4CE33B0", VA = "0x184CE47B0")]
		private unsafe static bool ParseNumber(ref char* str, char* strEnd, System.Globalization.NumberStyles styles, ref Number.NumberBuffer number, System.Globalization.NumberFormatInfo info, bool parseDecimal)
		{
			return default(bool);
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00009270 File Offset: 0x00007470
		[Token(Token = "0x600095C")]
		[Address(RVA = "0x4CE8220", Offset = "0x4CE6E20", VA = "0x184CE8220")]
		internal static bool TryParseInt32(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo info, out int result)
		{
			return default(bool);
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00009288 File Offset: 0x00007488
		[Token(Token = "0x600095D")]
		[Address(RVA = "0x4CE7C00", Offset = "0x4CE6800", VA = "0x184CE7C00")]
		private static bool TryParseInt32IntegerStyle(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo info, out int result, ref bool failureIsOverflow)
		{
			return default(bool);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x000092A0 File Offset: 0x000074A0
		[Token(Token = "0x600095E")]
		[Address(RVA = "0x4CE8400", Offset = "0x4CE7000", VA = "0x184CE8400")]
		private static bool TryParseInt64IntegerStyle(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo info, out long result, ref bool failureIsOverflow)
		{
			return default(bool);
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x000092B8 File Offset: 0x000074B8
		[Token(Token = "0x600095F")]
		[Address(RVA = "0x4CE8A50", Offset = "0x4CE7650", VA = "0x184CE8A50")]
		internal static bool TryParseInt64(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo info, out long result)
		{
			return default(bool);
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x000092D0 File Offset: 0x000074D0
		[Token(Token = "0x6000960")]
		[Address(RVA = "0x4CE96F0", Offset = "0x4CE82F0", VA = "0x184CE96F0")]
		internal static bool TryParseUInt32(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo info, out uint result)
		{
			return default(bool);
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x000092E8 File Offset: 0x000074E8
		[Token(Token = "0x6000961")]
		[Address(RVA = "0x4CE90E0", Offset = "0x4CE7CE0", VA = "0x184CE90E0")]
		private static bool TryParseUInt32IntegerStyle(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo info, out uint result, ref bool failureIsOverflow)
		{
			return default(bool);
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00009300 File Offset: 0x00007500
		[Token(Token = "0x6000962")]
		[Address(RVA = "0x4CE8DA0", Offset = "0x4CE79A0", VA = "0x184CE8DA0")]
		private static bool TryParseUInt32HexNumberStyle(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo info, out uint result, ref bool failureIsOverflow)
		{
			return default(bool);
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00009318 File Offset: 0x00007518
		[Token(Token = "0x6000963")]
		[Address(RVA = "0x4CEA240", Offset = "0x4CE8E40", VA = "0x184CEA240")]
		internal static bool TryParseUInt64(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo info, out ulong result)
		{
			return default(bool);
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00009330 File Offset: 0x00007530
		[Token(Token = "0x6000964")]
		[Address(RVA = "0x4CE9C20", Offset = "0x4CE8820", VA = "0x184CE9C20")]
		private static bool TryParseUInt64IntegerStyle(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo info, out ulong result, ref bool failureIsOverflow)
		{
			return default(bool);
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00009348 File Offset: 0x00007548
		[Token(Token = "0x6000965")]
		[Address(RVA = "0x4CE98E0", Offset = "0x4CE84E0", VA = "0x184CE98E0")]
		private static bool TryParseUInt64HexNumberStyle(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo info, out ulong result, ref bool failureIsOverflow)
		{
			return default(bool);
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00009360 File Offset: 0x00007560
		[Token(Token = "0x6000966")]
		[Address(RVA = "0x4CE3CD0", Offset = "0x4CE28D0", VA = "0x184CE3CD0")]
		internal static decimal ParseDecimal(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo info)
		{
			return 0m;
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00009378 File Offset: 0x00007578
		[Token(Token = "0x6000967")]
		[Address(RVA = "0x4CE1AA0", Offset = "0x4CE06A0", VA = "0x184CE1AA0")]
		private static bool NumberBufferToDecimal(ref Number.NumberBuffer number, ref decimal value)
		{
			return default(bool);
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00009390 File Offset: 0x00007590
		[Token(Token = "0x6000968")]
		[Address(RVA = "0x4CE3DF0", Offset = "0x4CE29F0", VA = "0x184CE3DF0")]
		internal static double ParseDouble(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo info)
		{
			return 0.0;
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x000093A8 File Offset: 0x000075A8
		[Token(Token = "0x6000969")]
		[Address(RVA = "0x4CE5250", Offset = "0x4CE3E50", VA = "0x184CE5250")]
		internal static float ParseSingle(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo info)
		{
			return 0f;
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x000093C0 File Offset: 0x000075C0
		[Token(Token = "0x600096A")]
		[Address(RVA = "0x4CE79E0", Offset = "0x4CE65E0", VA = "0x184CE79E0")]
		internal static bool TryParseDecimal(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo info, out decimal result)
		{
			return default(bool);
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x000093D8 File Offset: 0x000075D8
		[Token(Token = "0x600096B")]
		[Address(RVA = "0x4CE7AF0", Offset = "0x4CE66F0", VA = "0x184CE7AF0")]
		internal static bool TryParseDouble(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo info, out double result)
		{
			return default(bool);
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x000093F0 File Offset: 0x000075F0
		[Token(Token = "0x600096C")]
		[Address(RVA = "0x4CE8C40", Offset = "0x4CE7840", VA = "0x184CE8C40")]
		internal static bool TryParseSingle(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles styles, System.Globalization.NumberFormatInfo info, out float result)
		{
			return default(bool);
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600096D")]
		[Address(RVA = "0x4CE5BB0", Offset = "0x4CE47B0", VA = "0x184CE5BB0")]
		private static void StringToNumber(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles styles, ref Number.NumberBuffer number, System.Globalization.NumberFormatInfo info, bool parseDecimal)
		{
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00009408 File Offset: 0x00007608
		[Token(Token = "0x600096E")]
		[Address(RVA = "0x4CEA430", Offset = "0x4CE9030", VA = "0x184CEA430")]
		internal static bool TryStringToNumber(System.ReadOnlySpan<char> value, System.Globalization.NumberStyles styles, ref Number.NumberBuffer number, System.Globalization.NumberFormatInfo info, bool parseDecimal)
		{
			return default(bool);
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00009420 File Offset: 0x00007620
		[Token(Token = "0x600096F")]
		[Address(RVA = "0x4CE5DE0", Offset = "0x4CE49E0", VA = "0x184CE5DE0")]
		private static bool TrailingZeros(System.ReadOnlySpan<char> value, int index)
		{
			return default(bool);
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000970")]
		[Address(RVA = "0x4CE15C0", Offset = "0x4CE01C0", VA = "0x184CE15C0")]
		private unsafe static char* MatchChars(char* p, char* pEnd, string value)
		{
			return null;
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00009438 File Offset: 0x00007638
		[Token(Token = "0x6000971")]
		[Address(RVA = "0x4CE15A0", Offset = "0x4CE01A0", VA = "0x184CE15A0")]
		private static bool IsWhite(int ch)
		{
			return default(bool);
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00009450 File Offset: 0x00007650
		[Token(Token = "0x6000972")]
		[Address(RVA = "0x4CE1590", Offset = "0x4CE0190", VA = "0x184CE1590")]
		private static bool IsDigit(int ch)
		{
			return default(bool);
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000973")]
		[Address(RVA = "0x4CE5D30", Offset = "0x4CE4930", VA = "0x184CE5D30")]
		private static void ThrowOverflowOrFormatException(bool overflow, string overflowResourceKey)
		{
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00009468 File Offset: 0x00007668
		[Token(Token = "0x6000974")]
		[Address(RVA = "0x4CE1D60", Offset = "0x4CE0960", VA = "0x184CE1D60")]
		private static bool NumberBufferToDouble(ref Number.NumberBuffer number, ref double value)
		{
			return default(bool);
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00009480 File Offset: 0x00007680
		[Token(Token = "0x6000975")]
		[Address(RVA = "0x4CDE510", Offset = "0x4CDD110", VA = "0x184CDE510")]
		private unsafe static uint DigitsToInt(char* p, int count)
		{
			return 0U;
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00009498 File Offset: 0x00007698
		[Token(Token = "0x6000976")]
		[Address(RVA = "0x4CE1650", Offset = "0x4CE0250", VA = "0x184CE1650")]
		private static ulong Mul32x32To64(uint a, uint b)
		{
			return 0UL;
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x000094B0 File Offset: 0x000076B0
		[Token(Token = "0x6000977")]
		[Address(RVA = "0x4CE1660", Offset = "0x4CE0260", VA = "0x184CE1660")]
		private static ulong Mul64Lossy(ulong a, ulong b, ref int pexp)
		{
			return 0UL;
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x000094C8 File Offset: 0x000076C8
		[Token(Token = "0x6000978")]
		[Address(RVA = "0x4CEC2B0", Offset = "0x4CEAEB0", VA = "0x184CEC2B0")]
		private static int abs(int value)
		{
			return 0;
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x000094E0 File Offset: 0x000076E0
		[Token(Token = "0x6000979")]
		[Address(RVA = "0x4CE1E50", Offset = "0x4CE0A50", VA = "0x184CE1E50")]
		private static double NumberToDouble(ref Number.NumberBuffer number)
		{
			return 0.0;
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600097A")]
		[Address(RVA = "0x4CDE550", Offset = "0x4CDD150", VA = "0x184CDE550")]
		private static void DoubleToNumber(double value, int precision, ref Number.NumberBuffer number)
		{
		}

		// Token: 0x04000460 RID: 1120
		[Token(Token = "0x4000460")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] s_posCurrencyFormats;

		// Token: 0x04000461 RID: 1121
		[Token(Token = "0x4000461")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string[] s_negCurrencyFormats;

		// Token: 0x04000462 RID: 1122
		[Token(Token = "0x4000462")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string[] s_posPercentFormats;

		// Token: 0x04000463 RID: 1123
		[Token(Token = "0x4000463")]
		[FieldOffset(Offset = "0x18")]
		private static readonly string[] s_negPercentFormats;

		// Token: 0x04000464 RID: 1124
		[Token(Token = "0x4000464")]
		[FieldOffset(Offset = "0x20")]
		private static readonly string[] s_negNumberFormats;

		// Token: 0x04000465 RID: 1125
		[Token(Token = "0x4000465")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int[] s_charToHexLookup;

		// Token: 0x04000466 RID: 1126
		[Token(Token = "0x4000466")]
		[FieldOffset(Offset = "0x30")]
		private static readonly ulong[] s_rgval64Power10;

		// Token: 0x04000467 RID: 1127
		[Token(Token = "0x4000467")]
		[FieldOffset(Offset = "0x38")]
		private static readonly sbyte[] s_rgexp64Power10;

		// Token: 0x04000468 RID: 1128
		[Token(Token = "0x4000468")]
		[FieldOffset(Offset = "0x40")]
		private static readonly ulong[] s_rgval64Power10By16;

		// Token: 0x04000469 RID: 1129
		[Token(Token = "0x4000469")]
		[FieldOffset(Offset = "0x48")]
		private static readonly short[] s_rgexp64Power10By16;

		// Token: 0x02000119 RID: 281
		[Token(Token = "0x2000119")]
		[System.Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
		internal ref struct NumberBuffer
		{
			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x0600097C RID: 2428 RVA: 0x000094F8 File Offset: 0x000076F8
			// (set) Token: 0x0600097D RID: 2429 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000A1")]
			public bool sign
			{
				[Token(Token = "0x600097C")]
				[Address(RVA = "0x4CDE2F0", Offset = "0x4CDCEF0", VA = "0x184CDE2F0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600097D")]
				[Address(RVA = "0x4CDE300", Offset = "0x4CDCF00", VA = "0x184CDE300")]
				set
				{
				}
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x0600097E RID: 2430 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170000A2")]
			public unsafe char* digits
			{
				[Token(Token = "0x600097E")]
				[Address(RVA = "0x4CDE2E0", Offset = "0x4CDCEE0", VA = "0x184CDE2E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0400046A RID: 1130
			[Token(Token = "0x400046A")]
			[FieldOffset(Offset = "0x0")]
			public int precision;

			// Token: 0x0400046B RID: 1131
			[Token(Token = "0x400046B")]
			[FieldOffset(Offset = "0x4")]
			public int scale;

			// Token: 0x0400046C RID: 1132
			[Token(Token = "0x400046C")]
			[FieldOffset(Offset = "0x8")]
			private int _sign;

			// Token: 0x0400046D RID: 1133
			[Token(Token = "0x400046D")]
			[FieldOffset(Offset = "0xC")]
			private Number.NumberBuffer.DigitsAndNullTerminator _digits;

			// Token: 0x0400046E RID: 1134
			[Token(Token = "0x400046E")]
			[FieldOffset(Offset = "0x72")]
			private unsafe char* _allDigits;

			// Token: 0x0200011A RID: 282
			[Token(Token = "0x200011A")]
			private struct DigitsAndNullTerminator
			{
			}
		}
	}
}
