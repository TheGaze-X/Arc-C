using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020002B2 RID: 690
	[Token(Token = "0x20002B2")]
	public class ECNRSigner : IDsa
	{
		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060017B9 RID: 6073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000336")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x60017B9")]
			[Address(RVA = "0x5264150", Offset = "0x5262D50", VA = "0x185264150", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017BA")]
		[Address(RVA = "0x5263930", Offset = "0x5262530", VA = "0x185263930", Slot = "9")]
		public virtual void Init(bool forSigning, ICipherParameters parameters)
		{
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017BB")]
		[Address(RVA = "0x5263240", Offset = "0x5261E40", VA = "0x185263240", Slot = "10")]
		public virtual BigInteger[] GenerateSignature(byte[] message)
		{
			return null;
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x0000BA60 File Offset: 0x00009C60
		[Token(Token = "0x60017BC")]
		[Address(RVA = "0x5263DE0", Offset = "0x52629E0", VA = "0x185263DE0", Slot = "11")]
		public virtual bool VerifySignature(byte[] message, BigInteger r, BigInteger s)
		{
			return default(bool);
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017BD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ECNRSigner()
		{
		}

		// Token: 0x04000C93 RID: 3219
		[Token(Token = "0x4000C93")]
		[FieldOffset(Offset = "0x10")]
		private bool forSigning;

		// Token: 0x04000C94 RID: 3220
		[Token(Token = "0x4000C94")]
		[FieldOffset(Offset = "0x18")]
		private ECKeyParameters key;

		// Token: 0x04000C95 RID: 3221
		[Token(Token = "0x4000C95")]
		[FieldOffset(Offset = "0x20")]
		private SecureRandom random;
	}
}
