using System;
using Il2CppDummyDll;

namespace System.Numerics
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	internal static class BigIntegerCalculator
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00002112 File Offset: 0x00000312
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x4F69430", Offset = "0x4F68030", VA = "0x184F69430")]
		public static uint[] Add(uint[] left, uint right)
		{
			return null;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002112 File Offset: 0x00000312
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x4F69500", Offset = "0x4F68100", VA = "0x184F69500")]
		public static uint[] Add(uint[] left, uint[] right)
		{
			return null;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x4F69380", Offset = "0x4F67F80", VA = "0x184F69380")]
		private unsafe static void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002112 File Offset: 0x00000312
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x4F69910", Offset = "0x4F68510", VA = "0x184F69910")]
		public static uint[] Subtract(uint[] left, uint right)
		{
			return null;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002112 File Offset: 0x00000312
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x4F696F0", Offset = "0x4F682F0", VA = "0x184F696F0")]
		public static uint[] Subtract(uint[] left, uint[] right)
		{
			return null;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x4F69860", Offset = "0x4F68460", VA = "0x184F69860")]
		private unsafe static void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x4F69670", Offset = "0x4F68270", VA = "0x184F69670")]
		public static int Compare(uint[] left, uint[] right)
		{
			return 0;
		}

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x0")]
		private static int ReducerThreshold;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x4")]
		private static int SquareThreshold;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x8")]
		private static int AllocationThreshold;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0xC")]
		private static int MultiplyThreshold;
	}
}
