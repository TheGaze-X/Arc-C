using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x02000247 RID: 583
	[Token(Token = "0x2000247")]
	internal static class NumberHelpers
	{
		// Token: 0x06001533 RID: 5427 RVA: 0x0000B4C0 File Offset: 0x000096C0
		[Token(Token = "0x6001533")]
		[Address(RVA = "0x5611E50", Offset = "0x5610A50", VA = "0x185611E50")]
		[MethodImpl(256)]
		public static int AlignToMultipleOf(this int number, int alignment)
		{
			return 0;
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x0000B4D8 File Offset: 0x000096D8
		[Token(Token = "0x6001534")]
		[Address(RVA = "0x5611E90", Offset = "0x5610A90", VA = "0x185611E90")]
		[MethodImpl(256)]
		public static long AlignToMultipleOf(this long number, long alignment)
		{
			return 0L;
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x0000B4F0 File Offset: 0x000096F0
		[Token(Token = "0x6001535")]
		[Address(RVA = "0x5611E70", Offset = "0x5610A70", VA = "0x185611E70")]
		[MethodImpl(256)]
		public static uint AlignToMultipleOf(this uint number, uint alignment)
		{
			return 0U;
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x0000B508 File Offset: 0x00009708
		[Token(Token = "0x6001536")]
		[Address(RVA = "0x5611EB0", Offset = "0x5610AB0", VA = "0x185611EB0")]
		[MethodImpl(256)]
		public static bool Approximately(double a, double b)
		{
			return default(bool);
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x0000B520 File Offset: 0x00009720
		[Token(Token = "0x6001537")]
		[Address(RVA = "0x5611F50", Offset = "0x5610B50", VA = "0x185611F50")]
		[MethodImpl(256)]
		public static float IntToNormalizedFloat(int value, int minValue, int maxValue)
		{
			return 0f;
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x0000B538 File Offset: 0x00009738
		[Token(Token = "0x6001538")]
		[Address(RVA = "0x5611F90", Offset = "0x5610B90", VA = "0x185611F90")]
		[MethodImpl(256)]
		public static int NormalizedFloatToInt(float value, int intMinValue, int intMaxValue)
		{
			return 0;
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x0000B550 File Offset: 0x00009750
		[Token(Token = "0x6001539")]
		[Address(RVA = "0x5612070", Offset = "0x5610C70", VA = "0x185612070")]
		[MethodImpl(256)]
		public static float UIntToNormalizedFloat(uint value, uint minValue, uint maxValue)
		{
			return 0f;
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x0000B568 File Offset: 0x00009768
		[Token(Token = "0x600153A")]
		[Address(RVA = "0x560EBC0", Offset = "0x560D7C0", VA = "0x18560EBC0")]
		[MethodImpl(256)]
		public static uint NormalizedFloatToUInt(float value, uint uintMinValue, uint uintMaxValue)
		{
			return 0U;
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x0000B580 File Offset: 0x00009780
		[Token(Token = "0x600153B")]
		[Address(RVA = "0x5611FD0", Offset = "0x5610BD0", VA = "0x185611FD0")]
		[MethodImpl(256)]
		public static uint RemapUIntBitsToNormalizeFloatToUIntBits(uint value, uint inBitSize, uint outBitSize)
		{
			return 0U;
		}
	}
}
