using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x0200031E RID: 798
	[Token(Token = "0x200031E")]
	internal class DHKeyGeneratorHelper
	{
		// Token: 0x06001AD9 RID: 6873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private DHKeyGeneratorHelper()
		{
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ADA")]
		[Address(RVA = "0x52A34E0", Offset = "0x52A20E0", VA = "0x1852A34E0")]
		internal BigInteger CalculatePrivate(DHParameters dhParams, SecureRandom random)
		{
			return null;
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ADB")]
		[Address(RVA = "0x52A36C0", Offset = "0x52A22C0", VA = "0x1852A36C0")]
		internal BigInteger CalculatePublic(DHParameters dhParams, BigInteger x)
		{
			return null;
		}

		// Token: 0x04000E3F RID: 3647
		[Token(Token = "0x4000E3F")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly DHKeyGeneratorHelper Instance;
	}
}
