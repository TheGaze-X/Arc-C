using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x0200031D RID: 797
	[Token(Token = "0x200031D")]
	public class DHBasicKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
	{
		// Token: 0x06001AD6 RID: 6870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD6")]
		[Address(RVA = "0x52A33B0", Offset = "0x52A1FB0", VA = "0x1852A33B0", Slot = "6")]
		public virtual void Init(KeyGenerationParameters parameters)
		{
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD7")]
		[Address(RVA = "0x52A3240", Offset = "0x52A1E40", VA = "0x1852A3240", Slot = "7")]
		public virtual AsymmetricCipherKeyPair GenerateKeyPair()
		{
			return null;
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DHBasicKeyPairGenerator()
		{
		}

		// Token: 0x04000E3E RID: 3646
		[Token(Token = "0x4000E3E")]
		[FieldOffset(Offset = "0x10")]
		private DHKeyGenerationParameters param;
	}
}
