using System;
using Il2CppDummyDll;

namespace Mono.Security
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	internal sealed class BitConverterLE
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x4A77420", Offset = "0x4A76020", VA = "0x184A77420")]
		private unsafe static byte[] GetUIntBytes(byte* bytes)
		{
			return null;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x4A77510", Offset = "0x4A76110", VA = "0x184A77510")]
		private unsafe static byte[] GetULongBytes(byte* bytes)
		{
			return null;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x4A77310", Offset = "0x4A75F10", VA = "0x184A77310")]
		internal static byte[] GetBytes(int value)
		{
			return null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x4A772F0", Offset = "0x4A75EF0", VA = "0x184A772F0")]
		internal static byte[] GetBytes(long value)
		{
			return null;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x4A778B0", Offset = "0x4A764B0", VA = "0x184A778B0")]
		private unsafe static void UShortFromBytes(byte* dst, byte[] src, int startIndex)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x4A77790", Offset = "0x4A76390", VA = "0x184A77790")]
		private unsafe static void UIntFromBytes(byte* dst, byte[] src, int startIndex)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x4A77690", Offset = "0x4A76290", VA = "0x184A77690")]
		internal static int ToInt32(byte[] value, int startIndex)
		{
			return 0;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x4A776C0", Offset = "0x4A762C0", VA = "0x184A776C0")]
		internal static ushort ToUInt16(byte[] value, int startIndex)
		{
			return 0;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x4A77690", Offset = "0x4A76290", VA = "0x184A77690")]
		internal static uint ToUInt32(byte[] value, int startIndex)
		{
			return 0U;
		}
	}
}
