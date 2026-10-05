using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020002B4 RID: 692
	[Token(Token = "0x20002B4")]
	public class Gost3410DigestSigner : ISigner
	{
		// Token: 0x060017C6 RID: 6086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C6")]
		[Address(RVA = "0x4B61C30", Offset = "0x4B60830", VA = "0x184B61C30")]
		public Gost3410DigestSigner(IDsa signer, IDigest digest)
		{
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060017C7 RID: 6087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000338")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x60017C7")]
			[Address(RVA = "0x5265520", Offset = "0x5264120", VA = "0x185265520", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C8")]
		[Address(RVA = "0x5264EB0", Offset = "0x5263AB0", VA = "0x185264EB0", Slot = "12")]
		public virtual void Init(bool forSigning, ICipherParameters parameters)
		{
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C9")]
		[Address(RVA = "0x5265270", Offset = "0x5263E70", VA = "0x185265270", Slot = "13")]
		public virtual void Update(byte input)
		{
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017CA")]
		[Address(RVA = "0x5264BB0", Offset = "0x52637B0", VA = "0x185264BB0", Slot = "14")]
		public virtual void BlockUpdate(byte[] input, int inOff, int length)
		{
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017CB")]
		[Address(RVA = "0x5264C30", Offset = "0x5263830", VA = "0x185264C30", Slot = "15")]
		public virtual byte[] GenerateSignature()
		{
			return null;
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x0000BA90 File Offset: 0x00009C90
		[Token(Token = "0x60017CC")]
		[Address(RVA = "0x52652D0", Offset = "0x5263ED0", VA = "0x1852652D0", Slot = "16")]
		public virtual bool VerifySignature(byte[] signature)
		{
			return default(bool);
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017CD")]
		[Address(RVA = "0x5265220", Offset = "0x5263E20", VA = "0x185265220", Slot = "17")]
		public virtual void Reset()
		{
		}

		// Token: 0x04000C99 RID: 3225
		[Token(Token = "0x4000C99")]
		[FieldOffset(Offset = "0x10")]
		private readonly IDigest digest;

		// Token: 0x04000C9A RID: 3226
		[Token(Token = "0x4000C9A")]
		[FieldOffset(Offset = "0x18")]
		private readonly IDsa dsaSigner;

		// Token: 0x04000C9B RID: 3227
		[Token(Token = "0x4000C9B")]
		[FieldOffset(Offset = "0x20")]
		private bool forSigning;
	}
}
