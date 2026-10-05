using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x02000385 RID: 901
	[Token(Token = "0x2000385")]
	public class Sha512tDigest : LongDigest
	{
		// Token: 0x06001EC8 RID: 7880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC8")]
		[Address(RVA = "0x5325510", Offset = "0x5324110", VA = "0x185325510")]
		public Sha512tDigest(int bitLength)
		{
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC9")]
		[Address(RVA = "0x5325470", Offset = "0x5324070", VA = "0x185325470")]
		public Sha512tDigest(Sha512tDigest t)
		{
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06001ECA RID: 7882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000411")]
		public override string AlgorithmName
		{
			[Token(Token = "0x6001ECA")]
			[Address(RVA = "0x5325710", Offset = "0x5324310", VA = "0x185325710", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x0000EC58 File Offset: 0x0000CE58
		[Token(Token = "0x6001ECB")]
		[Address(RVA = "0x12905A0", Offset = "0x128F1A0", VA = "0x1812905A0", Slot = "15")]
		public override int GetDigestSize()
		{
			return 0;
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x0000EC70 File Offset: 0x0000CE70
		[Token(Token = "0x6001ECC")]
		[Address(RVA = "0x53246B0", Offset = "0x53232B0", VA = "0x1853246B0", Slot = "16")]
		public override int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ECD")]
		[Address(RVA = "0x5325020", Offset = "0x5323C20", VA = "0x185325020", Slot = "13")]
		public override void Reset()
		{
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ECE")]
		[Address(RVA = "0x5325770", Offset = "0x5324370", VA = "0x185325770")]
		private void tIvGenerate(int bitLength)
		{
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ECF")]
		[Address(RVA = "0x5325300", Offset = "0x5323F00", VA = "0x185325300")]
		private static void UInt64_To_BE(ulong n, byte[] bs, int off, int max)
		{
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED0")]
		[Address(RVA = "0x5325230", Offset = "0x5323E30", VA = "0x185325230")]
		private static void UInt32_To_BE(uint n, byte[] bs, int off, int max)
		{
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED1")]
		[Address(RVA = "0x53245E0", Offset = "0x53231E0", VA = "0x1853245E0", Slot = "17")]
		public override IMemoable Copy()
		{
			return null;
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED2")]
		[Address(RVA = "0x5325090", Offset = "0x5323C90", VA = "0x185325090", Slot = "18")]
		public override void Reset(IMemoable other)
		{
		}

		// Token: 0x040010AA RID: 4266
		[Token(Token = "0x40010AA")]
		private const ulong A5 = 11936128518282651045UL;

		// Token: 0x040010AB RID: 4267
		[Token(Token = "0x40010AB")]
		[FieldOffset(Offset = "0x88")]
		private readonly int digestLength;

		// Token: 0x040010AC RID: 4268
		[Token(Token = "0x40010AC")]
		[FieldOffset(Offset = "0x90")]
		private ulong H1t;

		// Token: 0x040010AD RID: 4269
		[Token(Token = "0x40010AD")]
		[FieldOffset(Offset = "0x98")]
		private ulong H2t;

		// Token: 0x040010AE RID: 4270
		[Token(Token = "0x40010AE")]
		[FieldOffset(Offset = "0xA0")]
		private ulong H3t;

		// Token: 0x040010AF RID: 4271
		[Token(Token = "0x40010AF")]
		[FieldOffset(Offset = "0xA8")]
		private ulong H4t;

		// Token: 0x040010B0 RID: 4272
		[Token(Token = "0x40010B0")]
		[FieldOffset(Offset = "0xB0")]
		private ulong H5t;

		// Token: 0x040010B1 RID: 4273
		[Token(Token = "0x40010B1")]
		[FieldOffset(Offset = "0xB8")]
		private ulong H6t;

		// Token: 0x040010B2 RID: 4274
		[Token(Token = "0x40010B2")]
		[FieldOffset(Offset = "0xC0")]
		private ulong H7t;

		// Token: 0x040010B3 RID: 4275
		[Token(Token = "0x40010B3")]
		[FieldOffset(Offset = "0xC8")]
		private ulong H8t;
	}
}
