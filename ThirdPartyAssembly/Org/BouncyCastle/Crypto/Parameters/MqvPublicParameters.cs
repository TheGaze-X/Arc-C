using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002E5 RID: 741
	[Token(Token = "0x20002E5")]
	public class MqvPublicParameters : ICipherParameters
	{
		// Token: 0x0600190F RID: 6415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600190F")]
		[Address(RVA = "0x528F450", Offset = "0x528E050", VA = "0x18528F450")]
		public MqvPublicParameters(ECPublicKeyParameters staticPublicKey, ECPublicKeyParameters ephemeralPublicKey)
		{
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06001910 RID: 6416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037D")]
		public virtual ECPublicKeyParameters StaticPublicKey
		{
			[Token(Token = "0x6001910")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001911 RID: 6417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037E")]
		public virtual ECPublicKeyParameters EphemeralPublicKey
		{
			[Token(Token = "0x6001911")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000D3A RID: 3386
		[Token(Token = "0x4000D3A")]
		[FieldOffset(Offset = "0x10")]
		private readonly ECPublicKeyParameters staticPublicKey;

		// Token: 0x04000D3B RID: 3387
		[Token(Token = "0x4000D3B")]
		[FieldOffset(Offset = "0x18")]
		private readonly ECPublicKeyParameters ephemeralPublicKey;
	}
}
