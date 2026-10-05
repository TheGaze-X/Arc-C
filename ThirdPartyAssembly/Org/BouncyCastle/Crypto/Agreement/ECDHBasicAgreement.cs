using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Agreement
{
	// Token: 0x0200038A RID: 906
	[Token(Token = "0x200038A")]
	public class ECDHBasicAgreement : IBasicAgreement
	{
		// Token: 0x06001F0C RID: 7948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F0C")]
		[Address(RVA = "0x5320AF0", Offset = "0x531F6F0", VA = "0x185320AF0", Slot = "7")]
		public virtual void Init(ICipherParameters parameters)
		{
		}

		// Token: 0x06001F0D RID: 7949 RVA: 0x0000EE08 File Offset: 0x0000D008
		[Token(Token = "0x6001F0D")]
		[Address(RVA = "0x5320A90", Offset = "0x531F690", VA = "0x185320A90", Slot = "8")]
		public virtual int GetFieldSize()
		{
			return 0;
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F0E")]
		[Address(RVA = "0x53207F0", Offset = "0x531F3F0", VA = "0x1853207F0", Slot = "9")]
		public virtual BigInteger CalculateAgreement(ICipherParameters pubKey)
		{
			return null;
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F0F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ECDHBasicAgreement()
		{
		}

		// Token: 0x040010DC RID: 4316
		[Token(Token = "0x40010DC")]
		[FieldOffset(Offset = "0x10")]
		protected internal ECPrivateKeyParameters privKey;
	}
}
