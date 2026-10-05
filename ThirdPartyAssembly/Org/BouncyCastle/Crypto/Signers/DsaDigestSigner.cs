using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020002AE RID: 686
	[Token(Token = "0x20002AE")]
	public class DsaDigestSigner : ISigner
	{
		// Token: 0x06001796 RID: 6038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001796")]
		[Address(RVA = "0x4B6E740", Offset = "0x4B6D340", VA = "0x184B6E740")]
		public DsaDigestSigner(IDsa signer, IDigest digest)
		{
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06001797 RID: 6039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000332")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001797")]
			[Address(RVA = "0x5260430", Offset = "0x525F030", VA = "0x185260430", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001798")]
		[Address(RVA = "0x525FE80", Offset = "0x525EA80", VA = "0x18525FE80", Slot = "12")]
		public virtual void Init(bool forSigning, ICipherParameters parameters)
		{
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001799")]
		[Address(RVA = "0x5260240", Offset = "0x525EE40", VA = "0x185260240", Slot = "13")]
		public virtual void Update(byte input)
		{
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600179A")]
		[Address(RVA = "0x525F600", Offset = "0x525E200", VA = "0x18525F600", Slot = "14")]
		public virtual void BlockUpdate(byte[] input, int inOff, int length)
		{
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600179B")]
		[Address(RVA = "0x525FBC0", Offset = "0x525E7C0", VA = "0x18525FBC0", Slot = "15")]
		public virtual byte[] GenerateSignature()
		{
			return null;
		}

		// Token: 0x0600179C RID: 6044 RVA: 0x0000BA00 File Offset: 0x00009C00
		[Token(Token = "0x600179C")]
		[Address(RVA = "0x52602A0", Offset = "0x525EEA0", VA = "0x1852602A0", Slot = "16")]
		public virtual bool VerifySignature(byte[] signature)
		{
			return default(bool);
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600179D")]
		[Address(RVA = "0x52601F0", Offset = "0x525EDF0", VA = "0x1852601F0", Slot = "17")]
		public virtual void Reset()
		{
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600179E")]
		[Address(RVA = "0x525FA40", Offset = "0x525E640", VA = "0x18525FA40")]
		private byte[] DerEncode(BigInteger r, BigInteger s)
		{
			return null;
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600179F")]
		[Address(RVA = "0x525F680", Offset = "0x525E280", VA = "0x18525F680")]
		private BigInteger[] DerDecode(byte[] encoding)
		{
			return null;
		}

		// Token: 0x04000C87 RID: 3207
		[Token(Token = "0x4000C87")]
		[FieldOffset(Offset = "0x10")]
		private readonly IDigest digest;

		// Token: 0x04000C88 RID: 3208
		[Token(Token = "0x4000C88")]
		[FieldOffset(Offset = "0x18")]
		private readonly IDsa dsaSigner;

		// Token: 0x04000C89 RID: 3209
		[Token(Token = "0x4000C89")]
		[FieldOffset(Offset = "0x20")]
		private bool forSigning;
	}
}
