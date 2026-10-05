using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Checksums
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public sealed class Crc32 : IChecksum
	{
		// Token: 0x06000071 RID: 113 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x4A39B00", Offset = "0x4A38700", VA = "0x184A39B00")]
		internal static uint ComputeCrc32(uint oldCrc, byte value)
		{
			return 0U;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000022DC File Offset: 0x000004DC
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000010")]
		public long Value
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "4")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			set
			{
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1AF4C90", Offset = "0x1AF3890", VA = "0x181AF4C90", Slot = "5")]
		public void Reset()
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x4A39E20", Offset = "0x4A38A20", VA = "0x184A39E20", Slot = "6")]
		public void Update(int value)
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x4A39DA0", Offset = "0x4A389A0", VA = "0x184A39DA0", Slot = "7")]
		public void Update(byte[] buffer)
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x4A39B90", Offset = "0x4A38790", VA = "0x184A39B90", Slot = "8")]
		public void Update(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Crc32()
		{
		}

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		private const uint CrcSeed = 4294967295U;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x0")]
		private static readonly uint[] CrcTable;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x10")]
		private uint crc;
	}
}
