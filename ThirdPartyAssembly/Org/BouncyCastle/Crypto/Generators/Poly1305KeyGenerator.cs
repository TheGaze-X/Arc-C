using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x02000324 RID: 804
	[Token(Token = "0x2000324")]
	public class Poly1305KeyGenerator : CipherKeyGenerator
	{
		// Token: 0x06001AF5 RID: 6901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF5")]
		[Address(RVA = "0x52AA2E0", Offset = "0x52A8EE0", VA = "0x1852AA2E0", Slot = "4")]
		protected override void engineInit(KeyGenerationParameters param)
		{
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF6")]
		[Address(RVA = "0x52AA210", Offset = "0x52A8E10", VA = "0x1852AA210", Slot = "5")]
		protected override byte[] engineGenerateKey()
		{
			return null;
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF7")]
		[Address(RVA = "0x52AA140", Offset = "0x52A8D40", VA = "0x1852AA140")]
		public static void Clamp(byte[] key)
		{
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF8")]
		[Address(RVA = "0x52A9DD0", Offset = "0x52A89D0", VA = "0x1852A9DD0")]
		public static void CheckKey(byte[] key)
		{
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF9")]
		[Address(RVA = "0x52AA0D0", Offset = "0x52A8CD0", VA = "0x1852AA0D0")]
		private static void CheckMask(byte b, byte mask)
		{
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AFA")]
		[Address(RVA = "0x52AA200", Offset = "0x52A8E00", VA = "0x1852AA200")]
		public Poly1305KeyGenerator()
		{
		}

		// Token: 0x04000E4C RID: 3660
		[Token(Token = "0x4000E4C")]
		private const byte R_MASK_LOW_2 = 252;

		// Token: 0x04000E4D RID: 3661
		[Token(Token = "0x4000E4D")]
		private const byte R_MASK_HIGH_4 = 15;
	}
}
