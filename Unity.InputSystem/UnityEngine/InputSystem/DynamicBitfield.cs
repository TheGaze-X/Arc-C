using System;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	// Token: 0x020000D9 RID: 217
	[Token(Token = "0x20000D9")]
	internal struct DynamicBitfield
	{
		// Token: 0x06000B97 RID: 2967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B97")]
		[Address(RVA = "0x569D730", Offset = "0x569C330", VA = "0x18569D730")]
		public void SetLength(int newLength)
		{
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x569D6A0", Offset = "0x569C2A0", VA = "0x18569D6A0")]
		public void SetBit(int bitIndex)
		{
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00005B08 File Offset: 0x00003D08
		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x569D790", Offset = "0x569C390", VA = "0x18569D790")]
		public bool TestBit(int bitIndex)
		{
			return default(bool);
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x569D610", Offset = "0x569C210", VA = "0x18569D610")]
		public void ClearBit(int bitIndex)
		{
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x00005B20 File Offset: 0x00003D20
		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x569D600", Offset = "0x569C200", VA = "0x18569D600")]
		private static int BitCountToULongCount(int bitCount)
		{
			return 0;
		}

		// Token: 0x04000507 RID: 1287
		[Token(Token = "0x4000507")]
		[FieldOffset(Offset = "0x0")]
		public InlinedArray<ulong> array;

		// Token: 0x04000508 RID: 1288
		[Token(Token = "0x4000508")]
		[FieldOffset(Offset = "0x18")]
		public int length;
	}
}
