using System;
using System.Collections;
using System.IO;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200028D RID: 653
	[Token(Token = "0x200028D")]
	public class TlsDheKeyExchange : TlsDHKeyExchange
	{
		// Token: 0x060015B7 RID: 5559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015B7")]
		[Address(RVA = "0x5259C00", Offset = "0x5258800", VA = "0x185259C00")]
		public TlsDheKeyExchange(int keyExchange, IList supportedSignatureAlgorithms, DHParameters dhParameters)
		{
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015B8")]
		[Address(RVA = "0x5259650", Offset = "0x5258250", VA = "0x185259650", Slot = "23")]
		public override void ProcessServerCredentials(TlsCredentials serverCredentials)
		{
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B9")]
		[Address(RVA = "0x52591E0", Offset = "0x5257DE0", VA = "0x1852591E0", Slot = "25")]
		public override byte[] GenerateServerKeyExchange()
		{
			return null;
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015BA")]
		[Address(RVA = "0x52597A0", Offset = "0x52583A0", VA = "0x1852597A0", Slot = "27")]
		public override void ProcessServerKeyExchange(Stream input)
		{
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015BB")]
		[Address(RVA = "0x5259560", Offset = "0x5258160", VA = "0x185259560", Slot = "37")]
		protected virtual ISigner InitVerifyer(TlsSigner tlsSigner, SignatureAndHashAlgorithm algorithm, SecurityParameters securityParameters)
		{
			return null;
		}

		// Token: 0x04000C1B RID: 3099
		[Token(Token = "0x4000C1B")]
		[FieldOffset(Offset = "0x58")]
		protected TlsSignerCredentials mServerCredentials;
	}
}
