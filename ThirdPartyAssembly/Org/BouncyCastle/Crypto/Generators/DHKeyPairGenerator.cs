using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x0200031F RID: 799
	[Token(Token = "0x200031F")]
	public class DHKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
	{
		// Token: 0x06001ADD RID: 6877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ADD")]
		[Address(RVA = "0x52A38E0", Offset = "0x52A24E0", VA = "0x1852A38E0", Slot = "6")]
		public virtual void Init(KeyGenerationParameters parameters)
		{
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ADE")]
		[Address(RVA = "0x52A3770", Offset = "0x52A2370", VA = "0x1852A3770", Slot = "7")]
		public virtual AsymmetricCipherKeyPair GenerateKeyPair()
		{
			return null;
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ADF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DHKeyPairGenerator()
		{
		}

		// Token: 0x04000E40 RID: 3648
		[Token(Token = "0x4000E40")]
		[FieldOffset(Offset = "0x10")]
		private DHKeyGenerationParameters param;
	}
}
