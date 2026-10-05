using System;
using System.IO;
using Il2CppDummyDll;

namespace BestHTTP.Decompression.Crc
{
	// Token: 0x02000503 RID: 1283
	[Token(Token = "0x2000503")]
	internal class CRC32
	{
		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06002A2E RID: 10798 RVA: 0x00012030 File Offset: 0x00010230
		[Token(Token = "0x17000616")]
		public long TotalBytesRead
		{
			[Token(Token = "0x6002A2E")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06002A2F RID: 10799 RVA: 0x00012048 File Offset: 0x00010248
		[Token(Token = "0x17000617")]
		public int Crc32Result
		{
			[Token(Token = "0x6002A2F")]
			[Address(RVA = "0x53C6D20", Offset = "0x53C5920", VA = "0x1853C6D20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x00012060 File Offset: 0x00010260
		[Token(Token = "0x6002A30")]
		[Address(RVA = "0x53C6600", Offset = "0x53C5200", VA = "0x1853C6600")]
		public int GetCrc32(Stream input)
		{
			return 0;
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x00012078 File Offset: 0x00010278
		[Token(Token = "0x6002A31")]
		[Address(RVA = "0x53C6360", Offset = "0x53C4F60", VA = "0x1853C6360")]
		public int GetCrc32AndCopy(Stream input, Stream output)
		{
			return 0;
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x00012090 File Offset: 0x00010290
		[Token(Token = "0x6002A32")]
		[Address(RVA = "0x53C61D0", Offset = "0x53C4DD0", VA = "0x1853C61D0")]
		public int ComputeCrc32(int W, byte B)
		{
			return 0;
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x000120A8 File Offset: 0x000102A8
		[Token(Token = "0x6002A33")]
		[Address(RVA = "0x53C61D0", Offset = "0x53C4DD0", VA = "0x1853C61D0")]
		internal int _InternalComputeCrc32(uint W, byte B)
		{
			return 0;
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A34")]
		[Address(RVA = "0x53C66B0", Offset = "0x53C52B0", VA = "0x1853C66B0")]
		public void SlurpBlock(byte[] block, int offset, int count)
		{
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A35")]
		[Address(RVA = "0x53C6850", Offset = "0x53C5450", VA = "0x1853C6850")]
		public void UpdateCRC(byte b)
		{
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A36")]
		[Address(RVA = "0x53C67D0", Offset = "0x53C53D0", VA = "0x1853C67D0")]
		public void UpdateCRC(byte b, int n)
		{
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x000120C0 File Offset: 0x000102C0
		[Token(Token = "0x6002A37")]
		[Address(RVA = "0x53C6650", Offset = "0x53C5250", VA = "0x1853C6650")]
		private static uint ReverseBits(uint data)
		{
			return 0U;
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x000120D8 File Offset: 0x000102D8
		[Token(Token = "0x6002A38")]
		[Address(RVA = "0x53C6620", Offset = "0x53C5220", VA = "0x1853C6620")]
		private static byte ReverseBits(byte data)
		{
			return 0;
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A39")]
		[Address(RVA = "0x53C6210", Offset = "0x53C4E10", VA = "0x1853C6210")]
		private void GenerateLookupTable()
		{
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x000120F0 File Offset: 0x000102F0
		[Token(Token = "0x6002A3A")]
		[Address(RVA = "0x53C6DC0", Offset = "0x53C59C0", VA = "0x1853C6DC0")]
		private uint gf2_matrix_times(uint[] matrix, uint vec)
		{
			return 0U;
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A3B")]
		[Address(RVA = "0x53C6D30", Offset = "0x53C5930", VA = "0x1853C6D30")]
		private void gf2_matrix_square(uint[] square, uint[] mat)
		{
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A3C")]
		[Address(RVA = "0x53C5F00", Offset = "0x53C4B00", VA = "0x1853C5F00")]
		public void Combine(int crc, int length)
		{
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A3D")]
		[Address(RVA = "0x53C6A40", Offset = "0x53C5640", VA = "0x1853C6A40")]
		public CRC32()
		{
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A3E")]
		[Address(RVA = "0x53C68D0", Offset = "0x53C54D0", VA = "0x1853C68D0")]
		public CRC32(bool reverseBits)
		{
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A3F")]
		[Address(RVA = "0x53C6BB0", Offset = "0x53C57B0", VA = "0x1853C6BB0")]
		public CRC32(int polynomial, bool reverseBits)
		{
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A40")]
		[Address(RVA = "0x53C6610", Offset = "0x53C5210", VA = "0x1853C6610")]
		public void Reset()
		{
		}

		// Token: 0x04001814 RID: 6164
		[Token(Token = "0x4001814")]
		[FieldOffset(Offset = "0x10")]
		private uint dwPolynomial;

		// Token: 0x04001815 RID: 6165
		[Token(Token = "0x4001815")]
		[FieldOffset(Offset = "0x18")]
		private long _TotalBytesRead;

		// Token: 0x04001816 RID: 6166
		[Token(Token = "0x4001816")]
		[FieldOffset(Offset = "0x20")]
		private bool reverseBits;

		// Token: 0x04001817 RID: 6167
		[Token(Token = "0x4001817")]
		[FieldOffset(Offset = "0x28")]
		private uint[] crc32Table;

		// Token: 0x04001818 RID: 6168
		[Token(Token = "0x4001818")]
		private const int BUFFER_SIZE = 8192;

		// Token: 0x04001819 RID: 6169
		[Token(Token = "0x4001819")]
		[FieldOffset(Offset = "0x30")]
		private uint _register;
	}
}
