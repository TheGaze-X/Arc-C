using System;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000077 RID: 119
	[Token(Token = "0x2000077")]
	internal sealed class BitHelper
	{
		// Token: 0x060003DD RID: 989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x4F3DBC0", Offset = "0x4F3C7C0", VA = "0x184F3DBC0")]
		internal unsafe BitHelper(int* bitArrayPtr, int length)
		{
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x4F3DC00", Offset = "0x4F3C800", VA = "0x184F3DC00")]
		internal BitHelper(int[] bitArray, int length)
		{
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x4F3DB30", Offset = "0x4F3C730", VA = "0x184F3DB30")]
		internal void MarkBit(int bitPosition)
		{
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00002F88 File Offset: 0x00001188
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x4F3DAB0", Offset = "0x4F3C6B0", VA = "0x184F3DAB0")]
		internal bool IsMarked(int bitPosition)
		{
			return default(bool);
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00002FA0 File Offset: 0x000011A0
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x4F3DBA0", Offset = "0x4F3C7A0", VA = "0x184F3DBA0")]
		internal static int ToIntArrayLength(int n)
		{
			return 0;
		}

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x10")]
		private readonly int _length;

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x18")]
		private unsafe readonly int* _arrayPtr;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x20")]
		private readonly int[] _array;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x28")]
		private readonly bool _useStackAlloc;
	}
}
