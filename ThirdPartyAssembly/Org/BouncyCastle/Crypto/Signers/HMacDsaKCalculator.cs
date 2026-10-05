using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020002B6 RID: 694
	[Token(Token = "0x20002B6")]
	public class HMacDsaKCalculator : IDsaKCalculator
	{
		// Token: 0x060017D3 RID: 6099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D3")]
		[Address(RVA = "0x5266DC0", Offset = "0x52659C0", VA = "0x185266DC0")]
		public HMacDsaKCalculator(IDigest digest)
		{
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x060017D4 RID: 6100 RVA: 0x0000BAC0 File Offset: 0x00009CC0
		[Token(Token = "0x1700033A")]
		public virtual bool IsDeterministic
		{
			[Token(Token = "0x60017D4")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D5")]
		[Address(RVA = "0x52662E0", Offset = "0x5264EE0", VA = "0x1852662E0", Slot = "9")]
		public virtual void Init(BigInteger n, SecureRandom random)
		{
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D6")]
		[Address(RVA = "0x5266340", Offset = "0x5264F40", VA = "0x185266340", Slot = "6")]
		public void Init(BigInteger n, BigInteger d, byte[] message)
		{
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017D7")]
		[Address(RVA = "0x52669A0", Offset = "0x52655A0", VA = "0x1852669A0", Slot = "10")]
		public virtual BigInteger NextK()
		{
			return null;
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017D8")]
		[Address(RVA = "0x5266220", Offset = "0x5264E20", VA = "0x185266220")]
		private BigInteger BitsToInt(byte[] t)
		{
			return null;
		}

		// Token: 0x04000C9E RID: 3230
		[Token(Token = "0x4000C9E")]
		[FieldOffset(Offset = "0x10")]
		private readonly HMac hMac;

		// Token: 0x04000C9F RID: 3231
		[Token(Token = "0x4000C9F")]
		[FieldOffset(Offset = "0x18")]
		private readonly byte[] K;

		// Token: 0x04000CA0 RID: 3232
		[Token(Token = "0x4000CA0")]
		[FieldOffset(Offset = "0x20")]
		private readonly byte[] V;

		// Token: 0x04000CA1 RID: 3233
		[Token(Token = "0x4000CA1")]
		[FieldOffset(Offset = "0x28")]
		private BigInteger n;
	}
}
