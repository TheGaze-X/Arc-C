using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Agreement
{
	// Token: 0x02000389 RID: 905
	[Token(Token = "0x2000389")]
	public class DHBasicAgreement : IBasicAgreement
	{
		// Token: 0x06001F08 RID: 7944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F08")]
		[Address(RVA = "0x5319C70", Offset = "0x5318870", VA = "0x185319C70", Slot = "7")]
		public virtual void Init(ICipherParameters parameters)
		{
		}

		// Token: 0x06001F09 RID: 7945 RVA: 0x0000EDF0 File Offset: 0x0000CFF0
		[Token(Token = "0x6001F09")]
		[Address(RVA = "0x5319C30", Offset = "0x5318830", VA = "0x185319C30", Slot = "8")]
		public virtual int GetFieldSize()
		{
			return 0;
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F0A")]
		[Address(RVA = "0x5319A40", Offset = "0x5318640", VA = "0x185319A40", Slot = "9")]
		public virtual BigInteger CalculateAgreement(ICipherParameters pubKey)
		{
			return null;
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F0B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DHBasicAgreement()
		{
		}

		// Token: 0x040010DA RID: 4314
		[Token(Token = "0x40010DA")]
		[FieldOffset(Offset = "0x10")]
		private DHPrivateKeyParameters key;

		// Token: 0x040010DB RID: 4315
		[Token(Token = "0x40010DB")]
		[FieldOffset(Offset = "0x18")]
		private DHParameters dhParams;
	}
}
