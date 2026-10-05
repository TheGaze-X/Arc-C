using System;
using Il2CppDummyDll;

namespace Mono.Security
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	internal sealed class BitConverterLE
	{
		// Token: 0x0600012A RID: 298 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x4AA9E10", Offset = "0x4AA8A10", VA = "0x184AA9E10")]
		private unsafe static byte[] GetUIntBytes(byte* bytes)
		{
			return null;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x4AA9F00", Offset = "0x4AA8B00", VA = "0x184AA9F00")]
		private unsafe static byte[] GetULongBytes(byte* bytes)
		{
			return null;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x4AA9DB0", Offset = "0x4AA89B0", VA = "0x184AA9DB0")]
		internal static byte[] GetBytes(int value)
		{
			return null;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x4AA9DD0", Offset = "0x4AA89D0", VA = "0x184AA9DD0")]
		internal static byte[] GetBytes(float value)
		{
			return null;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x4AA9DF0", Offset = "0x4AA89F0", VA = "0x184AA9DF0")]
		internal static byte[] GetBytes(double value)
		{
			return null;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x4AAA270", Offset = "0x4AA8E70", VA = "0x184AAA270")]
		private unsafe static void UIntFromBytes(byte* dst, byte[] src, int startIndex)
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x4AAA390", Offset = "0x4AA8F90", VA = "0x184AAA390")]
		private unsafe static void ULongFromBytes(byte* dst, byte[] src, int startIndex)
		{
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x4AAA160", Offset = "0x4AA8D60", VA = "0x184AAA160")]
		internal static float ToSingle(byte[] value, int startIndex)
		{
			return 0f;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x4AAA080", Offset = "0x4AA8C80", VA = "0x184AAA080")]
		internal static double ToDouble(byte[] value, int startIndex)
		{
			return 0.0;
		}
	}
}
