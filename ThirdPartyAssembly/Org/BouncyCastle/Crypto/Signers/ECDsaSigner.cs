using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020002B0 RID: 688
	[Token(Token = "0x20002B0")]
	public class ECDsaSigner : IDsa
	{
		// Token: 0x060017A8 RID: 6056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017A8")]
		[Address(RVA = "0x5262300", Offset = "0x5260F00", VA = "0x185262300")]
		public ECDsaSigner()
		{
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017A9")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public ECDsaSigner(IDsaKCalculator kCalculator)
		{
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060017AA RID: 6058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000334")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x60017AA")]
			[Address(RVA = "0x5262370", Offset = "0x5260F70", VA = "0x185262370", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017AB")]
		[Address(RVA = "0x52619A0", Offset = "0x52605A0", VA = "0x1852619A0", Slot = "9")]
		public virtual void Init(bool forSigning, ICipherParameters parameters)
		{
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017AC")]
		[Address(RVA = "0x5261260", Offset = "0x525FE60", VA = "0x185261260", Slot = "10")]
		public virtual BigInteger[] GenerateSignature(byte[] message)
		{
			return null;
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x0000BA30 File Offset: 0x00009C30
		[Token(Token = "0x60017AD")]
		[Address(RVA = "0x5261E60", Offset = "0x5260A60", VA = "0x185261E60", Slot = "11")]
		public virtual bool VerifySignature(byte[] message, BigInteger r, BigInteger s)
		{
			return default(bool);
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017AE")]
		[Address(RVA = "0x5261150", Offset = "0x525FD50", VA = "0x185261150", Slot = "12")]
		protected virtual BigInteger CalculateE(BigInteger n, byte[] message)
		{
			return null;
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017AF")]
		[Address(RVA = "0x5261210", Offset = "0x525FE10", VA = "0x185261210", Slot = "13")]
		protected virtual ECMultiplier CreateBasePointMultiplier()
		{
			return null;
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B0")]
		[Address(RVA = "0x5261830", Offset = "0x5260430", VA = "0x185261830", Slot = "14")]
		protected virtual ECFieldElement GetDenominator(int coordinateSystem, ECPoint p)
		{
			return null;
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B1")]
		[Address(RVA = "0x5261920", Offset = "0x5260520", VA = "0x185261920", Slot = "15")]
		protected virtual SecureRandom InitSecureRandom(bool needed, SecureRandom provided)
		{
			return null;
		}

		// Token: 0x04000C8D RID: 3213
		[Token(Token = "0x4000C8D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly BigInteger Eight;

		// Token: 0x04000C8E RID: 3214
		[Token(Token = "0x4000C8E")]
		[FieldOffset(Offset = "0x10")]
		protected readonly IDsaKCalculator kCalculator;

		// Token: 0x04000C8F RID: 3215
		[Token(Token = "0x4000C8F")]
		[FieldOffset(Offset = "0x18")]
		protected ECKeyParameters key;

		// Token: 0x04000C90 RID: 3216
		[Token(Token = "0x4000C90")]
		[FieldOffset(Offset = "0x20")]
		protected SecureRandom random;
	}
}
