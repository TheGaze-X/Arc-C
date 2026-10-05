using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002E4 RID: 740
	[Token(Token = "0x20002E4")]
	public class MqvPrivateParameters : ICipherParameters
	{
		// Token: 0x0600190A RID: 6410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600190A")]
		[Address(RVA = "0x528F150", Offset = "0x528DD50", VA = "0x18528F150")]
		public MqvPrivateParameters(ECPrivateKeyParameters staticPrivateKey, ECPrivateKeyParameters ephemeralPrivateKey)
		{
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600190B")]
		[Address(RVA = "0x528F170", Offset = "0x528DD70", VA = "0x18528F170")]
		public MqvPrivateParameters(ECPrivateKeyParameters staticPrivateKey, ECPrivateKeyParameters ephemeralPrivateKey, ECPublicKeyParameters ephemeralPublicKey)
		{
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x0600190C RID: 6412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037A")]
		public virtual ECPrivateKeyParameters StaticPrivateKey
		{
			[Token(Token = "0x600190C")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x0600190D RID: 6413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037B")]
		public virtual ECPrivateKeyParameters EphemeralPrivateKey
		{
			[Token(Token = "0x600190D")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x0600190E RID: 6414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037C")]
		public virtual ECPublicKeyParameters EphemeralPublicKey
		{
			[Token(Token = "0x600190E")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000D37 RID: 3383
		[Token(Token = "0x4000D37")]
		[FieldOffset(Offset = "0x10")]
		private readonly ECPrivateKeyParameters staticPrivateKey;

		// Token: 0x04000D38 RID: 3384
		[Token(Token = "0x4000D38")]
		[FieldOffset(Offset = "0x18")]
		private readonly ECPrivateKeyParameters ephemeralPrivateKey;

		// Token: 0x04000D39 RID: 3385
		[Token(Token = "0x4000D39")]
		[FieldOffset(Offset = "0x20")]
		private readonly ECPublicKeyParameters ephemeralPublicKey;
	}
}
