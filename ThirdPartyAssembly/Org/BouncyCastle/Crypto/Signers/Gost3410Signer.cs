using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020002B5 RID: 693
	[Token(Token = "0x20002B5")]
	public class Gost3410Signer : IDsa
	{
		// Token: 0x17000339 RID: 825
		// (get) Token: 0x060017CE RID: 6094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000339")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x60017CE")]
			[Address(RVA = "0x52661F0", Offset = "0x5264DF0", VA = "0x1852661F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017CF")]
		[Address(RVA = "0x5265960", Offset = "0x5264560", VA = "0x185265960", Slot = "9")]
		public virtual void Init(bool forSigning, ICipherParameters parameters)
		{
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017D0")]
		[Address(RVA = "0x52655C0", Offset = "0x52641C0", VA = "0x1852655C0", Slot = "10")]
		public virtual BigInteger[] GenerateSignature(byte[] message)
		{
			return null;
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x0000BAA8 File Offset: 0x00009CA8
		[Token(Token = "0x60017D1")]
		[Address(RVA = "0x5265E00", Offset = "0x5264A00", VA = "0x185265E00", Slot = "11")]
		public virtual bool VerifySignature(byte[] message, BigInteger r, BigInteger s)
		{
			return default(bool);
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Gost3410Signer()
		{
		}

		// Token: 0x04000C9C RID: 3228
		[Token(Token = "0x4000C9C")]
		[FieldOffset(Offset = "0x10")]
		private Gost3410KeyParameters key;

		// Token: 0x04000C9D RID: 3229
		[Token(Token = "0x4000C9D")]
		[FieldOffset(Offset = "0x18")]
		private SecureRandom random;
	}
}
