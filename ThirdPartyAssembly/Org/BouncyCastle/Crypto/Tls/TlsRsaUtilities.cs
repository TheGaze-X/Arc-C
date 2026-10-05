using System;
using System.IO;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x020002A3 RID: 675
	[Token(Token = "0x20002A3")]
	public abstract class TlsRsaUtilities
	{
		// Token: 0x060016D6 RID: 5846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016D6")]
		[Address(RVA = "0x5273D60", Offset = "0x5272960", VA = "0x185273D60")]
		public static byte[] GenerateEncryptedPreMasterSecret(TlsContext context, RsaKeyParameters rsaServerPublicKey, Stream output)
		{
			return null;
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016D7")]
		[Address(RVA = "0x52740D0", Offset = "0x5272CD0", VA = "0x1852740D0")]
		public static byte[] SafeDecryptPreMasterSecret(TlsContext context, RsaKeyParameters rsaServerPrivateKey, byte[] encryptedPreMasterSecret)
		{
			return null;
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016D8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected TlsRsaUtilities()
		{
		}
	}
}
