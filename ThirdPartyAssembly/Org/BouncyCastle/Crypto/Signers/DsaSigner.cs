using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020002AF RID: 687
	[Token(Token = "0x20002AF")]
	public class DsaSigner : IDsa
	{
		// Token: 0x060017A0 RID: 6048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017A0")]
		[Address(RVA = "0x52610B0", Offset = "0x525FCB0", VA = "0x1852610B0")]
		public DsaSigner()
		{
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017A1")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public DsaSigner(IDsaKCalculator kCalculator)
		{
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060017A2 RID: 6050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000333")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x60017A2")]
			[Address(RVA = "0x5261120", Offset = "0x525FD20", VA = "0x185261120", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017A3")]
		[Address(RVA = "0x52609C0", Offset = "0x525F5C0", VA = "0x1852609C0", Slot = "9")]
		public virtual void Init(bool forSigning, ICipherParameters parameters)
		{
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017A4")]
		[Address(RVA = "0x52605A0", Offset = "0x525F1A0", VA = "0x1852605A0", Slot = "10")]
		public virtual BigInteger[] GenerateSignature(byte[] message)
		{
			return null;
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x0000BA18 File Offset: 0x00009C18
		[Token(Token = "0x60017A5")]
		[Address(RVA = "0x5260E80", Offset = "0x525FA80", VA = "0x185260E80", Slot = "11")]
		public virtual bool VerifySignature(byte[] message, BigInteger r, BigInteger s)
		{
			return default(bool);
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017A6")]
		[Address(RVA = "0x52604D0", Offset = "0x525F0D0", VA = "0x1852604D0", Slot = "12")]
		protected virtual BigInteger CalculateE(BigInteger n, byte[] message)
		{
			return null;
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017A7")]
		[Address(RVA = "0x5260940", Offset = "0x525F540", VA = "0x185260940", Slot = "13")]
		protected virtual SecureRandom InitSecureRandom(bool needed, SecureRandom provided)
		{
			return null;
		}

		// Token: 0x04000C8A RID: 3210
		[Token(Token = "0x4000C8A")]
		[FieldOffset(Offset = "0x10")]
		protected readonly IDsaKCalculator kCalculator;

		// Token: 0x04000C8B RID: 3211
		[Token(Token = "0x4000C8B")]
		[FieldOffset(Offset = "0x18")]
		protected DsaKeyParameters key;

		// Token: 0x04000C8C RID: 3212
		[Token(Token = "0x4000C8C")]
		[FieldOffset(Offset = "0x20")]
		protected SecureRandom random;
	}
}
