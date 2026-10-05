using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x02000325 RID: 805
	[Token(Token = "0x2000325")]
	public class RsaKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
	{
		// Token: 0x06001AFB RID: 6907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AFB")]
		[Address(RVA = "0x52AB960", Offset = "0x52AA560", VA = "0x1852AB960", Slot = "6")]
		public virtual void Init(KeyGenerationParameters parameters)
		{
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AFC")]
		[Address(RVA = "0x52AB4E0", Offset = "0x52AA0E0", VA = "0x1852AB4E0", Slot = "7")]
		public virtual AsymmetricCipherKeyPair GenerateKeyPair()
		{
			return null;
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AFD")]
		[Address(RVA = "0x52AB260", Offset = "0x52A9E60", VA = "0x1852AB260", Slot = "8")]
		protected virtual BigInteger ChooseRandomPrime(int bitlength, BigInteger e)
		{
			return null;
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AFE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RsaKeyPairGenerator()
		{
		}

		// Token: 0x04000E4E RID: 3662
		[Token(Token = "0x4000E4E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] SPECIAL_E_VALUES;

		// Token: 0x04000E4F RID: 3663
		[Token(Token = "0x4000E4F")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int SPECIAL_E_HIGHEST;

		// Token: 0x04000E50 RID: 3664
		[Token(Token = "0x4000E50")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int SPECIAL_E_BITS;

		// Token: 0x04000E51 RID: 3665
		[Token(Token = "0x4000E51")]
		[FieldOffset(Offset = "0x10")]
		protected static readonly BigInteger One;

		// Token: 0x04000E52 RID: 3666
		[Token(Token = "0x4000E52")]
		[FieldOffset(Offset = "0x18")]
		protected static readonly BigInteger DefaultPublicExponent;

		// Token: 0x04000E53 RID: 3667
		[Token(Token = "0x4000E53")]
		protected const int DefaultTests = 100;

		// Token: 0x04000E54 RID: 3668
		[Token(Token = "0x4000E54")]
		[FieldOffset(Offset = "0x10")]
		protected RsaKeyGenerationParameters parameters;
	}
}
