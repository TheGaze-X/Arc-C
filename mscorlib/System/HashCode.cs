using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000ED RID: 237
	[Token(Token = "0x20000ED")]
	public struct HashCode
	{
		// Token: 0x060007E3 RID: 2019 RVA: 0x00008088 File Offset: 0x00006288
		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x4CD7AD0", Offset = "0x4CD66D0", VA = "0x184CD7AD0")]
		private static uint GenerateGlobalSeed()
		{
			return 0U;
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x000080A0 File Offset: 0x000062A0
		[Token(Token = "0x60007E4")]
		public static int Combine<T1, T2>(T1 value1, T2 value2)
		{
			return 0;
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x000080B8 File Offset: 0x000062B8
		[Token(Token = "0x60007E5")]
		public static int Combine<T1, T2, T3, T4, T5>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5)
		{
			return 0;
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x000080D0 File Offset: 0x000062D0
		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x4CD7DD0", Offset = "0x4CD69D0", VA = "0x184CD7DD0")]
		[MethodImpl(256)]
		private static uint Rol(uint value, int count)
		{
			return 0U;
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x4CD7B60", Offset = "0x4CD6760", VA = "0x184CD7B60")]
		[MethodImpl(256)]
		private static void Initialize(out uint v1, out uint v2, out uint v3, out uint v4)
		{
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x000080E8 File Offset: 0x000062E8
		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x4CD7DF0", Offset = "0x4CD69F0", VA = "0x184CD7DF0")]
		[MethodImpl(256)]
		private static uint Round(uint hash, uint input)
		{
			return 0U;
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00008100 File Offset: 0x00006300
		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x4CD7D60", Offset = "0x4CD6960", VA = "0x184CD7D60")]
		[MethodImpl(256)]
		private static uint QueueRound(uint hash, uint queuedValue)
		{
			return 0U;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00008118 File Offset: 0x00006318
		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x4CD7CC0", Offset = "0x4CD68C0", VA = "0x184CD7CC0")]
		[MethodImpl(256)]
		private static uint MixState(uint v1, uint v2, uint v3, uint v4)
		{
			return 0U;
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00008130 File Offset: 0x00006330
		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x4CD7C30", Offset = "0x4CD6830", VA = "0x184CD7C30")]
		private static uint MixEmptyState()
		{
			return 0U;
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00008148 File Offset: 0x00006348
		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x4CD7C90", Offset = "0x4CD6890", VA = "0x184CD7C90")]
		[MethodImpl(256)]
		private static uint MixFinal(uint hash)
		{
			return 0U;
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00008160 File Offset: 0x00006360
		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x4CD7B00", Offset = "0x4CD6700", VA = "0x184CD7B00", Slot = "2")]
		[System.Obsolete("HashCode is a mutable struct and should not be compared with other HashCodes. Use ToHashCode to retrieve the computed hash code.", true)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00008178 File Offset: 0x00006378
		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x4CD7A70", Offset = "0x4CD6670", VA = "0x184CD7A70", Slot = "0")]
		[System.Obsolete("HashCode is a mutable struct and should not be compared with other HashCodes.", true)]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0400042B RID: 1067
		[Token(Token = "0x400042B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly uint s_seed;

		// Token: 0x0400042C RID: 1068
		[Token(Token = "0x400042C")]
		[FieldOffset(Offset = "0x0")]
		private uint _v1;

		// Token: 0x0400042D RID: 1069
		[Token(Token = "0x400042D")]
		[FieldOffset(Offset = "0x4")]
		private uint _v2;

		// Token: 0x0400042E RID: 1070
		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x8")]
		private uint _v3;

		// Token: 0x0400042F RID: 1071
		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0xC")]
		private uint _v4;

		// Token: 0x04000430 RID: 1072
		[Token(Token = "0x4000430")]
		[FieldOffset(Offset = "0x10")]
		private uint _queue1;

		// Token: 0x04000431 RID: 1073
		[Token(Token = "0x4000431")]
		[FieldOffset(Offset = "0x14")]
		private uint _queue2;

		// Token: 0x04000432 RID: 1074
		[Token(Token = "0x4000432")]
		[FieldOffset(Offset = "0x18")]
		private uint _queue3;

		// Token: 0x04000433 RID: 1075
		[Token(Token = "0x4000433")]
		[FieldOffset(Offset = "0x1C")]
		private uint _length;
	}
}
