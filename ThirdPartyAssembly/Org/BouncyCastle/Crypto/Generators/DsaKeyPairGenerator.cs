using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x02000321 RID: 801
	[Token(Token = "0x2000321")]
	public class DsaKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
	{
		// Token: 0x06001AE5 RID: 6885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE5")]
		[Address(RVA = "0x52A4770", Offset = "0x52A3370", VA = "0x1852A4770", Slot = "4")]
		public void Init(KeyGenerationParameters parameters)
		{
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE6")]
		[Address(RVA = "0x52A4480", Offset = "0x52A3080", VA = "0x1852A4480", Slot = "5")]
		public AsymmetricCipherKeyPair GenerateKeyPair()
		{
			return null;
		}

		// Token: 0x06001AE7 RID: 6887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE7")]
		[Address(RVA = "0x52A4680", Offset = "0x52A3280", VA = "0x1852A4680")]
		private static BigInteger GeneratePrivateKey(BigInteger q, SecureRandom random)
		{
			return null;
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE8")]
		[Address(RVA = "0x52A4450", Offset = "0x52A3050", VA = "0x1852A4450")]
		private static BigInteger CalculatePublicKey(BigInteger p, BigInteger g, BigInteger x)
		{
			return null;
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DsaKeyPairGenerator()
		{
		}

		// Token: 0x04000E45 RID: 3653
		[Token(Token = "0x4000E45")]
		[FieldOffset(Offset = "0x0")]
		private static readonly BigInteger One;

		// Token: 0x04000E46 RID: 3654
		[Token(Token = "0x4000E46")]
		[FieldOffset(Offset = "0x10")]
		private DsaKeyGenerationParameters param;
	}
}
