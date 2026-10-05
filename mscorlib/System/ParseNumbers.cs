using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000121 RID: 289
	[Token(Token = "0x2000121")]
	internal static class ParseNumbers
	{
		// Token: 0x0600099D RID: 2461 RVA: 0x00009540 File Offset: 0x00007740
		[Token(Token = "0x600099D")]
		[Address(RVA = "0x4CEE5C0", Offset = "0x4CED1C0", VA = "0x184CEE5C0")]
		public static long StringToLong(System.ReadOnlySpan<char> s, int radix, int flags)
		{
			return 0L;
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x00009558 File Offset: 0x00007758
		[Token(Token = "0x600099E")]
		[Address(RVA = "0x4CEE080", Offset = "0x4CECC80", VA = "0x184CEE080")]
		public static long StringToLong(System.ReadOnlySpan<char> s, int radix, int flags, ref int currPos)
		{
			return 0L;
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x00009570 File Offset: 0x00007770
		[Token(Token = "0x600099F")]
		[Address(RVA = "0x4CEDA60", Offset = "0x4CEC660", VA = "0x184CEDA60")]
		public static int StringToInt(System.ReadOnlySpan<char> s, int radix, int flags)
		{
			return 0;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00009588 File Offset: 0x00007788
		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x4CEDA90", Offset = "0x4CEC690", VA = "0x184CEDA90")]
		public static int StringToInt(System.ReadOnlySpan<char> s, int radix, int flags, ref int currPos)
		{
			return 0;
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x4CED1F0", Offset = "0x4CEBDF0", VA = "0x184CED1F0")]
		public static string IntToString(int n, int radix, int width, char paddingChar, int flags)
		{
			return null;
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x4CED610", Offset = "0x4CEC210", VA = "0x184CED610")]
		public static string LongToString(long n, int radix, int width, char paddingChar, int flags)
		{
			return null;
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x4CECD60", Offset = "0x4CEB960", VA = "0x184CECD60")]
		private static void EatWhiteSpace(System.ReadOnlySpan<char> s, ref int i)
		{
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x000095A0 File Offset: 0x000077A0
		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x4CED010", Offset = "0x4CEBC10", VA = "0x184CED010")]
		private static long GrabLongs(int radix, System.ReadOnlySpan<char> s, ref int i, bool isUnsigned)
		{
			return 0L;
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x000095B8 File Offset: 0x000077B8
		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x4CECE10", Offset = "0x4CEBA10", VA = "0x184CECE10")]
		private static int GrabInts(int radix, System.ReadOnlySpan<char> s, ref int i, bool isUnsigned)
		{
			return 0;
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x4CEE5F0", Offset = "0x4CED1F0", VA = "0x184CEE5F0")]
		private static void ThrowOverflowInt32Exception()
		{
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x4CEE650", Offset = "0x4CED250", VA = "0x184CEE650")]
		private static void ThrowOverflowInt64Exception()
		{
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x4CEE6B0", Offset = "0x4CED2B0", VA = "0x184CEE6B0")]
		private static void ThrowOverflowUInt32Exception()
		{
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x4CEE710", Offset = "0x4CED310", VA = "0x184CEE710")]
		private static void ThrowOverflowUInt64Exception()
		{
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x000095D0 File Offset: 0x000077D0
		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x4CED5B0", Offset = "0x4CEC1B0", VA = "0x184CED5B0")]
		[MethodImpl(256)]
		private static bool IsDigit(char c, int radix, out int result)
		{
			return default(bool);
		}
	}
}
