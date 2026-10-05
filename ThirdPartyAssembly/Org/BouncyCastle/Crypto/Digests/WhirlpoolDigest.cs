using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x02000388 RID: 904
	[Token(Token = "0x2000388")]
	public sealed class WhirlpoolDigest : IDigest, IMemoable
	{
		// Token: 0x06001EF4 RID: 7924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF4")]
		[Address(RVA = "0x5328FB0", Offset = "0x5327BB0", VA = "0x185328FB0")]
		public WhirlpoolDigest()
		{
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x0000ED60 File Offset: 0x0000CF60
		[Token(Token = "0x6001EF5")]
		[Address(RVA = "0x5329810", Offset = "0x5328410", VA = "0x185329810")]
		private static long packIntoLong(int b7, int b6, int b5, int b4, int b3, int b2, int b1, int b0)
		{
			return 0L;
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x0000ED78 File Offset: 0x0000CF78
		[Token(Token = "0x6001EF6")]
		[Address(RVA = "0x53297F0", Offset = "0x53283F0", VA = "0x1853297F0")]
		private static int maskWithReductionPolynomial(int input)
		{
			return 0;
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF7")]
		[Address(RVA = "0x5328E40", Offset = "0x5327A40", VA = "0x185328E40")]
		public WhirlpoolDigest(WhirlpoolDigest originalDigest)
		{
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001EF8 RID: 7928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000414")]
		public string AlgorithmName
		{
			[Token(Token = "0x6001EF8")]
			[Address(RVA = "0x53296A0", Offset = "0x53282A0", VA = "0x1853296A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x0000ED90 File Offset: 0x0000CF90
		[Token(Token = "0x6001EF9")]
		[Address(RVA = "0x3D28710", Offset = "0x3D27310", VA = "0x183D28710", Slot = "5")]
		public int GetDigestSize()
		{
			return 0;
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x0000EDA8 File Offset: 0x0000CFA8
		[Token(Token = "0x6001EFA")]
		[Address(RVA = "0x53280D0", Offset = "0x5326CD0", VA = "0x1853280D0", Slot = "9")]
		public int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EFB")]
		[Address(RVA = "0x53283B0", Offset = "0x5326FB0", VA = "0x1853283B0", Slot = "10")]
		public void Reset()
		{
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EFC")]
		[Address(RVA = "0x532A200", Offset = "0x5328E00", VA = "0x18532A200")]
		private void processFilledBuffer()
		{
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x0000EDC0 File Offset: 0x0000CFC0
		[Token(Token = "0x6001EFD")]
		[Address(RVA = "0x5329360", Offset = "0x5327F60", VA = "0x185329360")]
		private static long bytesToLongFromBuffer(byte[] buffer, int startPos)
		{
			return 0L;
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EFE")]
		[Address(RVA = "0x5329470", Offset = "0x5328070", VA = "0x185329470")]
		private static void convertLongToByteArray(long inputLong, byte[] outputArray, int offSet)
		{
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EFF")]
		[Address(RVA = "0x5329870", Offset = "0x5328470", VA = "0x185329870")]
		private void processBlock()
		{
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F00")]
		[Address(RVA = "0x5328640", Offset = "0x5327240", VA = "0x185328640", Slot = "7")]
		public void Update(byte input)
		{
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F01")]
		[Address(RVA = "0x53296D0", Offset = "0x53282D0", VA = "0x1853296D0")]
		private void increment()
		{
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F02")]
		[Address(RVA = "0x5327D80", Offset = "0x5326980", VA = "0x185327D80", Slot = "8")]
		public void BlockUpdate(byte[] input, int inOff, int length)
		{
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F03")]
		[Address(RVA = "0x5329560", Offset = "0x5328160", VA = "0x185329560")]
		private void finish()
		{
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F04")]
		[Address(RVA = "0x53294D0", Offset = "0x53280D0", VA = "0x1853294D0")]
		private byte[] copyBitLength()
		{
			return null;
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x0000EDD8 File Offset: 0x0000CFD8
		[Token(Token = "0x6001F05")]
		[Address(RVA = "0x3D28710", Offset = "0x3D27310", VA = "0x183D28710", Slot = "6")]
		public int GetByteLength()
		{
			return 0;
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F06")]
		[Address(RVA = "0x5327F20", Offset = "0x5326B20", VA = "0x185327F20", Slot = "11")]
		public IMemoable Copy()
		{
			return null;
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F07")]
		[Address(RVA = "0x5328480", Offset = "0x5327080", VA = "0x185328480", Slot = "12")]
		public void Reset(IMemoable other)
		{
		}

		// Token: 0x040010C2 RID: 4290
		[Token(Token = "0x40010C2")]
		private const int BYTE_LENGTH = 64;

		// Token: 0x040010C3 RID: 4291
		[Token(Token = "0x40010C3")]
		private const int DIGEST_LENGTH_BYTES = 64;

		// Token: 0x040010C4 RID: 4292
		[Token(Token = "0x40010C4")]
		private const int ROUNDS = 10;

		// Token: 0x040010C5 RID: 4293
		[Token(Token = "0x40010C5")]
		private const int REDUCTION_POLYNOMIAL = 285;

		// Token: 0x040010C6 RID: 4294
		[Token(Token = "0x40010C6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] SBOX;

		// Token: 0x040010C7 RID: 4295
		[Token(Token = "0x40010C7")]
		[FieldOffset(Offset = "0x8")]
		private static readonly long[] C0;

		// Token: 0x040010C8 RID: 4296
		[Token(Token = "0x40010C8")]
		[FieldOffset(Offset = "0x10")]
		private static readonly long[] C1;

		// Token: 0x040010C9 RID: 4297
		[Token(Token = "0x40010C9")]
		[FieldOffset(Offset = "0x18")]
		private static readonly long[] C2;

		// Token: 0x040010CA RID: 4298
		[Token(Token = "0x40010CA")]
		[FieldOffset(Offset = "0x20")]
		private static readonly long[] C3;

		// Token: 0x040010CB RID: 4299
		[Token(Token = "0x40010CB")]
		[FieldOffset(Offset = "0x28")]
		private static readonly long[] C4;

		// Token: 0x040010CC RID: 4300
		[Token(Token = "0x40010CC")]
		[FieldOffset(Offset = "0x30")]
		private static readonly long[] C5;

		// Token: 0x040010CD RID: 4301
		[Token(Token = "0x40010CD")]
		[FieldOffset(Offset = "0x38")]
		private static readonly long[] C6;

		// Token: 0x040010CE RID: 4302
		[Token(Token = "0x40010CE")]
		[FieldOffset(Offset = "0x40")]
		private static readonly long[] C7;

		// Token: 0x040010CF RID: 4303
		[Token(Token = "0x40010CF")]
		[FieldOffset(Offset = "0x10")]
		private readonly long[] _rc;

		// Token: 0x040010D0 RID: 4304
		[Token(Token = "0x40010D0")]
		[FieldOffset(Offset = "0x48")]
		private static readonly short[] EIGHT;

		// Token: 0x040010D1 RID: 4305
		[Token(Token = "0x40010D1")]
		private const int BITCOUNT_ARRAY_SIZE = 32;

		// Token: 0x040010D2 RID: 4306
		[Token(Token = "0x40010D2")]
		[FieldOffset(Offset = "0x18")]
		private byte[] _buffer;

		// Token: 0x040010D3 RID: 4307
		[Token(Token = "0x40010D3")]
		[FieldOffset(Offset = "0x20")]
		private int _bufferPos;

		// Token: 0x040010D4 RID: 4308
		[Token(Token = "0x40010D4")]
		[FieldOffset(Offset = "0x28")]
		private short[] _bitCount;

		// Token: 0x040010D5 RID: 4309
		[Token(Token = "0x40010D5")]
		[FieldOffset(Offset = "0x30")]
		private long[] _hash;

		// Token: 0x040010D6 RID: 4310
		[Token(Token = "0x40010D6")]
		[FieldOffset(Offset = "0x38")]
		private long[] _K;

		// Token: 0x040010D7 RID: 4311
		[Token(Token = "0x40010D7")]
		[FieldOffset(Offset = "0x40")]
		private long[] _L;

		// Token: 0x040010D8 RID: 4312
		[Token(Token = "0x40010D8")]
		[FieldOffset(Offset = "0x48")]
		private long[] _block;

		// Token: 0x040010D9 RID: 4313
		[Token(Token = "0x40010D9")]
		[FieldOffset(Offset = "0x50")]
		private long[] _state;
	}
}
