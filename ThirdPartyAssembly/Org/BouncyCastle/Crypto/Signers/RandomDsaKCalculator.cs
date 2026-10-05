using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020002BB RID: 699
	[Token(Token = "0x20002BB")]
	public class RandomDsaKCalculator : IDsaKCalculator
	{
		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06001805 RID: 6149 RVA: 0x0000BB80 File Offset: 0x00009D80
		[Token(Token = "0x1700033E")]
		public virtual bool IsDeterministic
		{
			[Token(Token = "0x6001805")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001806")]
		[Address(RVA = "0x35CBFD0", Offset = "0x35CABD0", VA = "0x1835CBFD0", Slot = "9")]
		public virtual void Init(BigInteger n, SecureRandom random)
		{
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001807")]
		[Address(RVA = "0x5294630", Offset = "0x5293230", VA = "0x185294630", Slot = "10")]
		public virtual void Init(BigInteger n, BigInteger d, byte[] message)
		{
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001808")]
		[Address(RVA = "0x5294690", Offset = "0x5293290", VA = "0x185294690", Slot = "11")]
		public virtual BigInteger NextK()
		{
			return null;
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001809")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RandomDsaKCalculator()
		{
		}

		// Token: 0x04000CD0 RID: 3280
		[Token(Token = "0x4000CD0")]
		[FieldOffset(Offset = "0x10")]
		private BigInteger q;

		// Token: 0x04000CD1 RID: 3281
		[Token(Token = "0x4000CD1")]
		[FieldOffset(Offset = "0x18")]
		private SecureRandom random;
	}
}
