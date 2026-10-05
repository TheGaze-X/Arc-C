using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x02000387 RID: 903
	[Token(Token = "0x2000387")]
	public class TigerDigest : IDigest, IMemoable
	{
		// Token: 0x06001EDE RID: 7902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EDE")]
		[Address(RVA = "0x5327B10", Offset = "0x5326710", VA = "0x185327B10")]
		public TigerDigest()
		{
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EDF")]
		[Address(RVA = "0x5327BA0", Offset = "0x53267A0", VA = "0x185327BA0")]
		public TigerDigest(TigerDigest t)
		{
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001EE0 RID: 7904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000413")]
		public string AlgorithmName
		{
			[Token(Token = "0x6001EE0")]
			[Address(RVA = "0x5327D50", Offset = "0x5326950", VA = "0x185327D50", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x0000ED18 File Offset: 0x0000CF18
		[Token(Token = "0x6001EE1")]
		[Address(RVA = "0x3D28730", Offset = "0x3D27330", VA = "0x183D28730", Slot = "5")]
		public int GetDigestSize()
		{
			return 0;
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x0000ED30 File Offset: 0x0000CF30
		[Token(Token = "0x6001EE2")]
		[Address(RVA = "0x3D28710", Offset = "0x3D27310", VA = "0x183D28710", Slot = "6")]
		public int GetByteLength()
		{
			return 0;
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE3")]
		[Address(RVA = "0x5326F80", Offset = "0x5325B80", VA = "0x185326F80")]
		private void ProcessWord(byte[] b, int off)
		{
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE4")]
		[Address(RVA = "0x5327900", Offset = "0x5326500", VA = "0x185327900", Slot = "7")]
		public void Update(byte input)
		{
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE5")]
		[Address(RVA = "0x5326110", Offset = "0x5324D10", VA = "0x185326110", Slot = "8")]
		public void BlockUpdate(byte[] input, int inOff, int length)
		{
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE6")]
		[Address(RVA = "0x53272F0", Offset = "0x5325EF0", VA = "0x1853272F0")]
		private void RoundABC(long x, long mul)
		{
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE7")]
		[Address(RVA = "0x53274B0", Offset = "0x53260B0", VA = "0x1853274B0")]
		private void RoundBCA(long x, long mul)
		{
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE8")]
		[Address(RVA = "0x5327670", Offset = "0x5326270", VA = "0x185327670")]
		private void RoundCAB(long x, long mul)
		{
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE9")]
		[Address(RVA = "0x5326830", Offset = "0x5325430", VA = "0x185326830")]
		private void KeySchedule()
		{
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EEA")]
		[Address(RVA = "0x5326AC0", Offset = "0x53256C0", VA = "0x185326AC0")]
		private void ProcessBlock()
		{
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EEB")]
		[Address(RVA = "0x5327830", Offset = "0x5326430", VA = "0x185327830")]
		private void UnpackWord(long r, byte[] output, int outOff)
		{
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EEC")]
		[Address(RVA = "0x5326F50", Offset = "0x5325B50", VA = "0x185326F50")]
		private void ProcessLength(long bitLength)
		{
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EED")]
		[Address(RVA = "0x5326740", Offset = "0x5325340", VA = "0x185326740")]
		private void Finish()
		{
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x0000ED48 File Offset: 0x0000CF48
		[Token(Token = "0x6001EEE")]
		[Address(RVA = "0x5326470", Offset = "0x5325070", VA = "0x185326470", Slot = "9")]
		public int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EEF")]
		[Address(RVA = "0x5327220", Offset = "0x5325E20", VA = "0x185327220", Slot = "10")]
		public void Reset()
		{
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EF0")]
		[Address(RVA = "0x5326280", Offset = "0x5324E80", VA = "0x185326280", Slot = "11")]
		public IMemoable Copy()
		{
			return null;
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF1")]
		[Address(RVA = "0x53270E0", Offset = "0x5325CE0", VA = "0x1853270E0", Slot = "12")]
		public void Reset(IMemoable other)
		{
		}

		// Token: 0x040010B4 RID: 4276
		[Token(Token = "0x40010B4")]
		private const int MyByteLength = 64;

		// Token: 0x040010B5 RID: 4277
		[Token(Token = "0x40010B5")]
		[FieldOffset(Offset = "0x0")]
		private static readonly long[] t1;

		// Token: 0x040010B6 RID: 4278
		[Token(Token = "0x40010B6")]
		[FieldOffset(Offset = "0x8")]
		private static readonly long[] t2;

		// Token: 0x040010B7 RID: 4279
		[Token(Token = "0x40010B7")]
		[FieldOffset(Offset = "0x10")]
		private static readonly long[] t3;

		// Token: 0x040010B8 RID: 4280
		[Token(Token = "0x40010B8")]
		[FieldOffset(Offset = "0x18")]
		private static readonly long[] t4;

		// Token: 0x040010B9 RID: 4281
		[Token(Token = "0x40010B9")]
		private const int DigestLength = 24;

		// Token: 0x040010BA RID: 4282
		[Token(Token = "0x40010BA")]
		[FieldOffset(Offset = "0x10")]
		private long a;

		// Token: 0x040010BB RID: 4283
		[Token(Token = "0x40010BB")]
		[FieldOffset(Offset = "0x18")]
		private long b;

		// Token: 0x040010BC RID: 4284
		[Token(Token = "0x40010BC")]
		[FieldOffset(Offset = "0x20")]
		private long c;

		// Token: 0x040010BD RID: 4285
		[Token(Token = "0x40010BD")]
		[FieldOffset(Offset = "0x28")]
		private long byteCount;

		// Token: 0x040010BE RID: 4286
		[Token(Token = "0x40010BE")]
		[FieldOffset(Offset = "0x30")]
		private byte[] Buffer;

		// Token: 0x040010BF RID: 4287
		[Token(Token = "0x40010BF")]
		[FieldOffset(Offset = "0x38")]
		private int bOff;

		// Token: 0x040010C0 RID: 4288
		[Token(Token = "0x40010C0")]
		[FieldOffset(Offset = "0x40")]
		private long[] x;

		// Token: 0x040010C1 RID: 4289
		[Token(Token = "0x40010C1")]
		[FieldOffset(Offset = "0x48")]
		private int xOff;
	}
}
