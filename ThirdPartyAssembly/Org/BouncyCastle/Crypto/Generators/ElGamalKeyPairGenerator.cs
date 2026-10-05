using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x02000323 RID: 803
	[Token(Token = "0x2000323")]
	public class ElGamalKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
	{
		// Token: 0x06001AF2 RID: 6898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF2")]
		[Address(RVA = "0x52A5690", Offset = "0x52A4290", VA = "0x1852A5690", Slot = "4")]
		public void Init(KeyGenerationParameters parameters)
		{
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF3")]
		[Address(RVA = "0x52A54B0", Offset = "0x52A40B0", VA = "0x1852A54B0", Slot = "5")]
		public AsymmetricCipherKeyPair GenerateKeyPair()
		{
			return null;
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ElGamalKeyPairGenerator()
		{
		}

		// Token: 0x04000E4B RID: 3659
		[Token(Token = "0x4000E4B")]
		[FieldOffset(Offset = "0x10")]
		private ElGamalKeyGenerationParameters param;
	}
}
