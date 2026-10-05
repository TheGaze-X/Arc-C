using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x02000198 RID: 408
	[Token(Token = "0x2000198")]
	public abstract class WNafUtilities
	{
		// Token: 0x06000BC1 RID: 3009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0x54D1610", Offset = "0x54D0210", VA = "0x1854D1610")]
		public static int[] GenerateCompactNaf(BigInteger k)
		{
			return null;
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0x54D18D0", Offset = "0x54D04D0", VA = "0x1854D18D0")]
		public static int[] GenerateCompactWindowNaf(int width, BigInteger k)
		{
			return null;
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC3")]
		[Address(RVA = "0x54D1BF0", Offset = "0x54D07F0", VA = "0x1854D1BF0")]
		public static byte[] GenerateJsf(BigInteger g, BigInteger h)
		{
			return null;
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC4")]
		[Address(RVA = "0x54D1F10", Offset = "0x54D0B10", VA = "0x1854D1F10")]
		public static byte[] GenerateNaf(BigInteger k)
		{
			return null;
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0x54D20A0", Offset = "0x54D0CA0", VA = "0x1854D20A0")]
		public static byte[] GenerateWindowNaf(int width, BigInteger k)
		{
			return null;
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x00007BC0 File Offset: 0x00005DC0
		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0x54D24B0", Offset = "0x54D10B0", VA = "0x1854D24B0")]
		public static int GetNafWeight(BigInteger k)
		{
			return 0;
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0x54D2640", Offset = "0x54D1240", VA = "0x1854D2640")]
		public static WNafPreCompInfo GetWNafPreCompInfo(ECPoint p)
		{
			return null;
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0x54D2520", Offset = "0x54D1120", VA = "0x1854D2520")]
		public static WNafPreCompInfo GetWNafPreCompInfo(PreCompInfo preCompInfo)
		{
			return null;
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x00007BD8 File Offset: 0x00005DD8
		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0x54D2770", Offset = "0x54D1370", VA = "0x1854D2770")]
		public static int GetWindowSize(int bits)
		{
			return 0;
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x00007BF0 File Offset: 0x00005DF0
		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0x54D2720", Offset = "0x54D1320", VA = "0x1854D2720")]
		public static int GetWindowSize(int bits, int[] windowSizeCutoffs)
		{
			return 0;
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0x54D2800", Offset = "0x54D1400", VA = "0x1854D2800")]
		public static ECPoint MapPointWithPrecomp(ECPoint p, int width, bool includeNegated, ECPointMap pointMap)
		{
			return null;
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BCC")]
		[Address(RVA = "0x54D2D00", Offset = "0x54D1900", VA = "0x1854D2D00")]
		public static WNafPreCompInfo Precompute(ECPoint p, int width, bool includeNegated)
		{
			return null;
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BCD")]
		[Address(RVA = "0x54D36A0", Offset = "0x54D22A0", VA = "0x1854D36A0")]
		private static byte[] Trim(byte[] a, int length)
		{
			return null;
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BCE")]
		[Address(RVA = "0x54D3720", Offset = "0x54D2320", VA = "0x1854D3720")]
		private static int[] Trim(int[] a, int length)
		{
			return null;
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0x54D3620", Offset = "0x54D2220", VA = "0x1854D3620")]
		private static ECPoint[] ResizeTable(ECPoint[] a, int length)
		{
			return null;
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected WNafUtilities()
		{
		}

		// Token: 0x0400086B RID: 2155
		[Token(Token = "0x400086B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string PRECOMP_NAME;

		// Token: 0x0400086C RID: 2156
		[Token(Token = "0x400086C")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[] DEFAULT_WINDOW_SIZE_CUTOFFS;

		// Token: 0x0400086D RID: 2157
		[Token(Token = "0x400086D")]
		[FieldOffset(Offset = "0x10")]
		private static readonly byte[] EMPTY_BYTES;

		// Token: 0x0400086E RID: 2158
		[Token(Token = "0x400086E")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int[] EMPTY_INTS;

		// Token: 0x0400086F RID: 2159
		[Token(Token = "0x400086F")]
		[FieldOffset(Offset = "0x20")]
		private static readonly ECPoint[] EMPTY_POINTS;
	}
}
