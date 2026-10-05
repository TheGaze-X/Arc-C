using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x0200010D RID: 269
	[Token(Token = "0x200010D")]
	public static class MemoryExtensions
	{
		// Token: 0x060008EA RID: 2282 RVA: 0x00008D90 File Offset: 0x00006F90
		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x4CDD670", Offset = "0x4CDC270", VA = "0x184CDD670")]
		[MethodImpl(256)]
		internal static bool EqualsOrdinal(this System.ReadOnlySpan<char> span, System.ReadOnlySpan<char> value)
		{
			return default(bool);
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00008DA8 File Offset: 0x00006FA8
		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x4CDD5C0", Offset = "0x4CDC1C0", VA = "0x184CDD5C0")]
		[MethodImpl(256)]
		internal static bool EqualsOrdinalIgnoreCase(this System.ReadOnlySpan<char> span, System.ReadOnlySpan<char> value)
		{
			return default(bool);
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00008DC0 File Offset: 0x00006FC0
		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x4CDD150", Offset = "0x4CDBD50", VA = "0x184CDD150")]
		internal static bool Contains(this System.ReadOnlySpan<char> source, char value)
		{
			return default(bool);
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00008DD8 File Offset: 0x00006FD8
		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x4CDD700", Offset = "0x4CDC300", VA = "0x184CDD700")]
		public static int ToUpperInvariant(this System.ReadOnlySpan<char> source, System.Span<char> destination)
		{
			return 0;
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00008DF0 File Offset: 0x00006FF0
		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x4CDD1D0", Offset = "0x4CDBDD0", VA = "0x184CDD1D0")]
		public static bool EndsWith(this System.ReadOnlySpan<char> span, System.ReadOnlySpan<char> value, System.StringComparison comparisonType)
		{
			return default(bool);
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00008E08 File Offset: 0x00007008
		[Token(Token = "0x60008EF")]
		[MethodImpl(256)]
		public static System.Span<T> AsSpan<T>(this T[] array, int start)
		{
			return default(System.Span<T>);
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00008E20 File Offset: 0x00007020
		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x4CDCF80", Offset = "0x4CDBB80", VA = "0x184CDCF80")]
		[MethodImpl(256)]
		public static System.ReadOnlySpan<char> AsSpan(this string text)
		{
			return default(System.ReadOnlySpan<char>);
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00008E38 File Offset: 0x00007038
		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x4CDD0B0", Offset = "0x4CDBCB0", VA = "0x184CDD0B0")]
		[MethodImpl(256)]
		public static System.ReadOnlySpan<char> AsSpan(this string text, int start)
		{
			return default(System.ReadOnlySpan<char>);
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00008E50 File Offset: 0x00007050
		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x4CDD000", Offset = "0x4CDBC00", VA = "0x184CDD000")]
		[MethodImpl(256)]
		public static System.ReadOnlySpan<char> AsSpan(this string text, int start, int length)
		{
			return default(System.ReadOnlySpan<char>);
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00008E68 File Offset: 0x00007068
		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x4CDDB10", Offset = "0x4CDC710", VA = "0x184CDDB10")]
		public static System.ReadOnlySpan<char> Trim(this System.ReadOnlySpan<char> span)
		{
			return default(System.ReadOnlySpan<char>);
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00008E80 File Offset: 0x00007080
		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x4CDDA00", Offset = "0x4CDC600", VA = "0x184CDDA00")]
		public static System.ReadOnlySpan<char> TrimStart(this System.ReadOnlySpan<char> span)
		{
			return default(System.ReadOnlySpan<char>);
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00008E98 File Offset: 0x00007098
		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x4CDD8F0", Offset = "0x4CDC4F0", VA = "0x184CDD8F0")]
		public static System.ReadOnlySpan<char> TrimEnd(this System.ReadOnlySpan<char> span)
		{
			return default(System.ReadOnlySpan<char>);
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00008EB0 File Offset: 0x000070B0
		[Token(Token = "0x60008F6")]
		[MethodImpl(256)]
		public static int IndexOf<T>(this System.ReadOnlySpan<T> span, T value) where T : System.IEquatable<T>
		{
			return 0;
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00008EC8 File Offset: 0x000070C8
		[Token(Token = "0x60008F7")]
		[MethodImpl(256)]
		public static int IndexOfAny<T>(this System.ReadOnlySpan<T> span, System.ReadOnlySpan<T> values) where T : System.IEquatable<T>
		{
			return 0;
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00008EE0 File Offset: 0x000070E0
		[Token(Token = "0x60008F8")]
		[MethodImpl(256)]
		public static bool SequenceEqual<T>(this System.ReadOnlySpan<T> span, System.ReadOnlySpan<T> other) where T : System.IEquatable<T>
		{
			return default(bool);
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00008EF8 File Offset: 0x000070F8
		[Token(Token = "0x60008F9")]
		[MethodImpl(256)]
		public static bool StartsWith<T>(this System.ReadOnlySpan<T> span, System.ReadOnlySpan<T> value) where T : System.IEquatable<T>
		{
			return default(bool);
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00008F10 File Offset: 0x00007110
		[Token(Token = "0x60008FA")]
		[MethodImpl(256)]
		public static bool EndsWith<T>(this System.ReadOnlySpan<T> span, System.ReadOnlySpan<T> value) where T : System.IEquatable<T>
		{
			return default(bool);
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00008F28 File Offset: 0x00007128
		[Token(Token = "0x60008FB")]
		[MethodImpl(256)]
		public static System.Span<T> AsSpan<T>(this T[] array, int start, int length)
		{
			return default(System.Span<T>);
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008FC")]
		[MethodImpl(256)]
		public static void CopyTo<T>(this T[] source, System.Span<T> destination)
		{
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00008F40 File Offset: 0x00007140
		[Token(Token = "0x60008FD")]
		[MethodImpl(256)]
		private static bool IsTypeComparableAsBytes<T>(out ulong size)
		{
			return default(bool);
		}
	}
}
