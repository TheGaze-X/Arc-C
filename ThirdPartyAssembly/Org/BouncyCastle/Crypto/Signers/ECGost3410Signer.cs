using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020002B1 RID: 689
	[Token(Token = "0x20002B1")]
	public class ECGost3410Signer : IDsa
	{
		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060017B3 RID: 6067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000335")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x60017B3")]
			[Address(RVA = "0x5263210", Offset = "0x5261E10", VA = "0x185263210", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017B4")]
		[Address(RVA = "0x5262910", Offset = "0x5261510", VA = "0x185262910", Slot = "9")]
		public virtual void Init(bool forSigning, ICipherParameters parameters)
		{
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B5")]
		[Address(RVA = "0x52623F0", Offset = "0x5260FF0", VA = "0x1852623F0", Slot = "10")]
		public virtual BigInteger[] GenerateSignature(byte[] message)
		{
			return null;
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x0000BA48 File Offset: 0x00009C48
		[Token(Token = "0x60017B6")]
		[Address(RVA = "0x5262DB0", Offset = "0x52619B0", VA = "0x185262DB0", Slot = "11")]
		public virtual bool VerifySignature(byte[] message, BigInteger r, BigInteger s)
		{
			return default(bool);
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B7")]
		[Address(RVA = "0x52623A0", Offset = "0x5260FA0", VA = "0x1852623A0", Slot = "12")]
		protected virtual ECMultiplier CreateBasePointMultiplier()
		{
			return null;
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017B8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ECGost3410Signer()
		{
		}

		// Token: 0x04000C91 RID: 3217
		[Token(Token = "0x4000C91")]
		[FieldOffset(Offset = "0x10")]
		private ECKeyParameters key;

		// Token: 0x04000C92 RID: 3218
		[Token(Token = "0x4000C92")]
		[FieldOffset(Offset = "0x18")]
		private SecureRandom random;
	}
}
