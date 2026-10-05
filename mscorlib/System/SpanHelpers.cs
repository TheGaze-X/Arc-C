using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x0200012E RID: 302
	[Token(Token = "0x200012E")]
	internal static class SpanHelpers
	{
		// Token: 0x06000A35 RID: 2613 RVA: 0x00009E70 File Offset: 0x00008070
		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x4CFBC60", Offset = "0x4CFA860", VA = "0x184CFBC60")]
		public static int IndexOfAny(ref byte searchSpace, int searchSpaceLength, ref byte value, int valueLength)
		{
			return 0;
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00009E88 File Offset: 0x00008088
		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x4CFC0B0", Offset = "0x4CFACB0", VA = "0x184CFC0B0")]
		public static int IndexOf(ref byte searchSpace, byte value, int length)
		{
			return 0;
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00009EA0 File Offset: 0x000080A0
		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x4CFCDA0", Offset = "0x4CFB9A0", VA = "0x184CFCDA0")]
		public static bool SequenceEqual(ref byte first, ref byte second, ulong length)
		{
			return default(bool);
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00009EB8 File Offset: 0x000080B8
		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x4CFC9B0", Offset = "0x4CFB5B0", VA = "0x184CFC9B0")]
		public static int SequenceCompareTo(ref char first, int firstLength, ref char second, int secondLength)
		{
			return 0;
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00009ED0 File Offset: 0x000080D0
		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x4CFBCE0", Offset = "0x4CFA8E0", VA = "0x184CFBCE0")]
		public static int IndexOf(ref char searchSpace, char value, int length)
		{
			return 0;
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00009EE8 File Offset: 0x000080E8
		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x4CFC330", Offset = "0x4CFAF30", VA = "0x184CFC330")]
		public static int LastIndexOf(ref char searchSpace, char value, int length)
		{
			return 0;
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00009F00 File Offset: 0x00008100
		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x4CFC720", Offset = "0x4CFB320", VA = "0x184CFC720")]
		[MethodImpl(256)]
		private static int LocateFirstFoundChar(System.Numerics.Vector<ushort> match)
		{
			return 0;
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00009F18 File Offset: 0x00008118
		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x4CFC700", Offset = "0x4CFB300", VA = "0x184CFC700")]
		[MethodImpl(256)]
		private static int LocateFirstFoundChar(ulong match)
		{
			return 0;
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00009F30 File Offset: 0x00008130
		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x4CFC860", Offset = "0x4CFB460", VA = "0x184CFC860")]
		[MethodImpl(256)]
		private static int LocateLastFoundChar(System.Numerics.Vector<ushort> match)
		{
			return 0;
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00009F48 File Offset: 0x00008148
		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x4CFC990", Offset = "0x4CFB590", VA = "0x184CFC990")]
		[MethodImpl(256)]
		private static int LocateLastFoundChar(ulong match)
		{
			return 0;
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00009F60 File Offset: 0x00008160
		[Token(Token = "0x6000A3F")]
		public static int IndexOf<T>(ref T searchSpace, T value, int length) where T : System.IEquatable<T>
		{
			return 0;
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00009F78 File Offset: 0x00008178
		[Token(Token = "0x6000A40")]
		public static int IndexOfAny<T>(ref T searchSpace, int searchSpaceLength, ref T value, int valueLength) where T : System.IEquatable<T>
		{
			return 0;
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x00009F90 File Offset: 0x00008190
		[Token(Token = "0x6000A41")]
		public static bool SequenceEqual<T>(ref T first, ref T second, int length) where T : System.IEquatable<T>
		{
			return default(bool);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x00009FA8 File Offset: 0x000081A8
		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x4CFB720", Offset = "0x4CFA320", VA = "0x184CFB720")]
		public static bool EndsWithCultureHelper(System.ReadOnlySpan<char> span, System.ReadOnlySpan<char> value, System.Globalization.CompareInfo compareInfo)
		{
			return default(bool);
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00009FC0 File Offset: 0x000081C0
		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x4CFB960", Offset = "0x4CFA560", VA = "0x184CFB960")]
		public static bool EndsWithCultureIgnoreCaseHelper(System.ReadOnlySpan<char> span, System.ReadOnlySpan<char> value, System.Globalization.CompareInfo compareInfo)
		{
			return default(bool);
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00009FD8 File Offset: 0x000081D8
		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x4CFBB60", Offset = "0x4CFA760", VA = "0x184CFBB60")]
		public static bool EndsWithOrdinalIgnoreCaseHelper(System.ReadOnlySpan<char> span, System.ReadOnlySpan<char> value)
		{
			return default(bool);
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x4CFB4C0", Offset = "0x4CFA0C0", VA = "0x184CFB4C0")]
		public static void ClearWithoutReferences(ref byte b, ulong byteLength)
		{
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x4CFB390", Offset = "0x4CF9F90", VA = "0x184CFB390")]
		public static void ClearWithReferences(ref System.IntPtr ip, ulong pointerSizeLength)
		{
		}
	}
}
