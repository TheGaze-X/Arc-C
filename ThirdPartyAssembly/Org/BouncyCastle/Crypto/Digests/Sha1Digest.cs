using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x0200037F RID: 895
	[Token(Token = "0x200037F")]
	public class Sha1Digest : GeneralDigest
	{
		// Token: 0x06001E7C RID: 7804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E7C")]
		[Address(RVA = "0x5321970", Offset = "0x5320570", VA = "0x185321970")]
		public Sha1Digest()
		{
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E7D")]
		[Address(RVA = "0x53219F0", Offset = "0x53205F0", VA = "0x1853219F0")]
		public Sha1Digest(Sha1Digest t)
		{
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E7E")]
		[Address(RVA = "0x5305000", Offset = "0x5303C00", VA = "0x185305000")]
		private void CopyIn(Sha1Digest t)
		{
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06001E7F RID: 7807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040B")]
		public override string AlgorithmName
		{
			[Token(Token = "0x6001E7F")]
			[Address(RVA = "0x5321AD0", Offset = "0x53206D0", VA = "0x185321AD0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x0000E9E8 File Offset: 0x0000CBE8
		[Token(Token = "0x6001E80")]
		[Address(RVA = "0x3D286E0", Offset = "0x3D272E0", VA = "0x183D286E0", Slot = "18")]
		public override int GetDigestSize()
		{
			return 0;
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E81")]
		[Address(RVA = "0x5321760", Offset = "0x5320360", VA = "0x185321760", Slot = "14")]
		internal override void ProcessWord(byte[] input, int inOff)
		{
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E82")]
		[Address(RVA = "0x53216E0", Offset = "0x53202E0", VA = "0x1853216E0", Slot = "15")]
		internal override void ProcessLength(long bitLength)
		{
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x0000EA00 File Offset: 0x0000CC00
		[Token(Token = "0x6001E83")]
		[Address(RVA = "0x5320E80", Offset = "0x531FA80", VA = "0x185320E80", Slot = "19")]
		public override int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E84")]
		[Address(RVA = "0x5321910", Offset = "0x5320510", VA = "0x185321910", Slot = "13")]
		public override void Reset()
		{
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x0000EA18 File Offset: 0x0000CC18
		[Token(Token = "0x6001E85")]
		[Address(RVA = "0x4B3E7C0", Offset = "0x4B3D3C0", VA = "0x184B3E7C0")]
		private static uint F(uint u, uint v, uint w)
		{
			return 0U;
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x0000EA30 File Offset: 0x0000CC30
		[Token(Token = "0x6001E86")]
		[Address(RVA = "0x4B3E7B0", Offset = "0x4B3D3B0", VA = "0x184B3E7B0")]
		private static uint H(uint u, uint v, uint w)
		{
			return 0U;
		}

		// Token: 0x06001E87 RID: 7815 RVA: 0x0000EA48 File Offset: 0x0000CC48
		[Token(Token = "0x6001E87")]
		[Address(RVA = "0x5320F40", Offset = "0x531FB40", VA = "0x185320F40")]
		private static uint G(uint u, uint v, uint w)
		{
			return 0U;
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E88")]
		[Address(RVA = "0x5320F50", Offset = "0x531FB50", VA = "0x185320F50", Slot = "16")]
		internal override void ProcessBlock()
		{
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E89")]
		[Address(RVA = "0x5320D70", Offset = "0x531F970", VA = "0x185320D70", Slot = "20")]
		public override IMemoable Copy()
		{
			return null;
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E8A")]
		[Address(RVA = "0x53217F0", Offset = "0x53203F0", VA = "0x1853217F0", Slot = "21")]
		public override void Reset(IMemoable other)
		{
		}

		// Token: 0x04001084 RID: 4228
		[Token(Token = "0x4001084")]
		private const int DigestLength = 20;

		// Token: 0x04001085 RID: 4229
		[Token(Token = "0x4001085")]
		[FieldOffset(Offset = "0x28")]
		private uint H1;

		// Token: 0x04001086 RID: 4230
		[Token(Token = "0x4001086")]
		[FieldOffset(Offset = "0x2C")]
		private uint H2;

		// Token: 0x04001087 RID: 4231
		[Token(Token = "0x4001087")]
		[FieldOffset(Offset = "0x30")]
		private uint H3;

		// Token: 0x04001088 RID: 4232
		[Token(Token = "0x4001088")]
		[FieldOffset(Offset = "0x34")]
		private uint H4;

		// Token: 0x04001089 RID: 4233
		[Token(Token = "0x4001089")]
		[FieldOffset(Offset = "0x38")]
		private uint H5;

		// Token: 0x0400108A RID: 4234
		[Token(Token = "0x400108A")]
		[FieldOffset(Offset = "0x40")]
		private uint[] X;

		// Token: 0x0400108B RID: 4235
		[Token(Token = "0x400108B")]
		[FieldOffset(Offset = "0x48")]
		private int xOff;

		// Token: 0x0400108C RID: 4236
		[Token(Token = "0x400108C")]
		private const uint Y1 = 1518500249U;

		// Token: 0x0400108D RID: 4237
		[Token(Token = "0x400108D")]
		private const uint Y2 = 1859775393U;

		// Token: 0x0400108E RID: 4238
		[Token(Token = "0x400108E")]
		private const uint Y3 = 2400959708U;

		// Token: 0x0400108F RID: 4239
		[Token(Token = "0x400108F")]
		private const uint Y4 = 3395469782U;
	}
}
