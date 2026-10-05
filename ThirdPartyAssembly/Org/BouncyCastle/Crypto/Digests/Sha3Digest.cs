using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x02000383 RID: 899
	[Token(Token = "0x2000383")]
	public class Sha3Digest : KeccakDigest
	{
		// Token: 0x06001EB8 RID: 7864 RVA: 0x0000EBE0 File Offset: 0x0000CDE0
		[Token(Token = "0x6001EB8")]
		[Address(RVA = "0x5323CD0", Offset = "0x53228D0", VA = "0x185323CD0")]
		private static int CheckBitLength(int bitLength)
		{
			return 0;
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EB9")]
		[Address(RVA = "0x5324040", Offset = "0x5322C40", VA = "0x185324040")]
		public Sha3Digest()
		{
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBA")]
		[Address(RVA = "0x5324090", Offset = "0x5322C90", VA = "0x185324090")]
		public Sha3Digest(int bitLength)
		{
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBB")]
		[Address(RVA = "0x5324190", Offset = "0x5322D90", VA = "0x185324190")]
		public Sha3Digest(Sha3Digest source)
		{
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06001EBC RID: 7868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040F")]
		public override string AlgorithmName
		{
			[Token(Token = "0x6001EBC")]
			[Address(RVA = "0x53241F0", Offset = "0x5322DF0", VA = "0x1853241F0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x0000EBF8 File Offset: 0x0000CDF8
		[Token(Token = "0x6001EBD")]
		[Address(RVA = "0x5323E30", Offset = "0x5322A30", VA = "0x185323E30", Slot = "17")]
		public override int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x0000EC10 File Offset: 0x0000CE10
		[Token(Token = "0x6001EBE")]
		[Address(RVA = "0x5323F00", Offset = "0x5322B00", VA = "0x185323F00", Slot = "18")]
		protected override int DoFinal(byte[] output, int outOff, byte partialByte, int partialBits)
		{
			return 0;
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EBF")]
		[Address(RVA = "0x5323DA0", Offset = "0x53229A0", VA = "0x185323DA0", Slot = "23")]
		public override IMemoable Copy()
		{
			return null;
		}
	}
}
