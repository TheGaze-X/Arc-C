using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020002B3 RID: 691
	[Token(Token = "0x20002B3")]
	public class GenericSigner : ISigner
	{
		// Token: 0x060017BE RID: 6078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017BE")]
		[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
		public GenericSigner(IAsymmetricBlockCipher engine, IDigest digest)
		{
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060017BF RID: 6079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000337")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x60017BF")]
			[Address(RVA = "0x5264940", Offset = "0x5263540", VA = "0x185264940", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C0")]
		[Address(RVA = "0x5264340", Offset = "0x5262F40", VA = "0x185264340", Slot = "12")]
		public virtual void Init(bool forSigning, ICipherParameters parameters)
		{
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C1")]
		[Address(RVA = "0x5264700", Offset = "0x5263300", VA = "0x185264700", Slot = "13")]
		public virtual void Update(byte input)
		{
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C2")]
		[Address(RVA = "0x5264180", Offset = "0x5262D80", VA = "0x185264180", Slot = "14")]
		public virtual void BlockUpdate(byte[] input, int inOff, int length)
		{
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017C3")]
		[Address(RVA = "0x5264200", Offset = "0x5262E00", VA = "0x185264200", Slot = "15")]
		public virtual byte[] GenerateSignature()
		{
			return null;
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x0000BA78 File Offset: 0x00009C78
		[Token(Token = "0x60017C4")]
		[Address(RVA = "0x5264760", Offset = "0x5263360", VA = "0x185264760", Slot = "16")]
		public virtual bool VerifySignature(byte[] signature)
		{
			return default(bool);
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C5")]
		[Address(RVA = "0x52646B0", Offset = "0x52632B0", VA = "0x1852646B0", Slot = "17")]
		public virtual void Reset()
		{
		}

		// Token: 0x04000C96 RID: 3222
		[Token(Token = "0x4000C96")]
		[FieldOffset(Offset = "0x10")]
		private readonly IAsymmetricBlockCipher engine;

		// Token: 0x04000C97 RID: 3223
		[Token(Token = "0x4000C97")]
		[FieldOffset(Offset = "0x18")]
		private readonly IDigest digest;

		// Token: 0x04000C98 RID: 3224
		[Token(Token = "0x4000C98")]
		[FieldOffset(Offset = "0x20")]
		private bool forSigning;
	}
}
