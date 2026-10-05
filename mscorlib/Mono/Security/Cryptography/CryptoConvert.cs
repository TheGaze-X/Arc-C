using System;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	internal sealed class CryptoConvert
	{
		// Token: 0x06000152 RID: 338 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x4A984E0", Offset = "0x4A970E0", VA = "0x184A984E0")]
		private static int ToInt32LE(byte[] bytes, int offset)
		{
			return 0;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x4A984E0", Offset = "0x4A970E0", VA = "0x184A984E0")]
		private static uint ToUInt32LE(byte[] bytes, int offset)
		{
			return 0U;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x4AC3440", Offset = "0x4AC2040", VA = "0x184AC3440")]
		private static byte[] GetBytesLE(int val)
		{
			return null;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x4AC4D90", Offset = "0x4AC3990", VA = "0x184AC4D90")]
		private static byte[] Trim(byte[] array)
		{
			return null;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x4AC2C60", Offset = "0x4AC1860", VA = "0x184AC2C60")]
		public static System.Security.Cryptography.RSA FromCapiPrivateKeyBlob(byte[] blob, int offset)
		{
			return null;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x4AC34D0", Offset = "0x4AC20D0", VA = "0x184AC34D0")]
		private static System.Security.Cryptography.RSAParameters GetParametersFromCapiPrivateKeyBlob(byte[] blob, int offset)
		{
			return default(System.Security.Cryptography.RSAParameters);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x4AC2680", Offset = "0x4AC1280", VA = "0x184AC2680")]
		public static System.Security.Cryptography.DSA FromCapiPrivateKeyBlobDSA(byte[] blob, int offset)
		{
			return null;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x4AC43E0", Offset = "0x4AC2FE0", VA = "0x184AC43E0")]
		public static byte[] ToCapiPrivateKeyBlob(System.Security.Cryptography.RSA rsa)
		{
			return null;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x4AC40C0", Offset = "0x4AC2CC0", VA = "0x184AC40C0")]
		public static byte[] ToCapiPrivateKeyBlob(System.Security.Cryptography.DSA dsa)
		{
			return null;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x4AC32F0", Offset = "0x4AC1EF0", VA = "0x184AC32F0")]
		public static System.Security.Cryptography.RSA FromCapiPublicKeyBlob(byte[] blob, int offset)
		{
			return null;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x4AC3BE0", Offset = "0x4AC27E0", VA = "0x184AC3BE0")]
		private static System.Security.Cryptography.RSAParameters GetParametersFromCapiPublicKeyBlob(byte[] blob, int offset)
		{
			return default(System.Security.Cryptography.RSAParameters);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x4AC2D20", Offset = "0x4AC1920", VA = "0x184AC2D20")]
		public static System.Security.Cryptography.DSA FromCapiPublicKeyBlobDSA(byte[] blob, int offset)
		{
			return null;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x4AC4B30", Offset = "0x4AC3730", VA = "0x184AC4B30")]
		public static byte[] ToCapiPublicKeyBlob(System.Security.Cryptography.RSA rsa)
		{
			return null;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x4AC4820", Offset = "0x4AC3420", VA = "0x184AC4820")]
		public static byte[] ToCapiPublicKeyBlob(System.Security.Cryptography.DSA dsa)
		{
			return null;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x4AC2450", Offset = "0x4AC1050", VA = "0x184AC2450")]
		public static System.Security.Cryptography.RSA FromCapiKeyBlob(byte[] blob)
		{
			return null;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x4AC2460", Offset = "0x4AC1060", VA = "0x184AC2460")]
		public static System.Security.Cryptography.RSA FromCapiKeyBlob(byte[] blob, int offset)
		{
			return null;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x4AC21C0", Offset = "0x4AC0DC0", VA = "0x184AC21C0")]
		public static System.Security.Cryptography.DSA FromCapiKeyBlobDSA(byte[] blob)
		{
			return null;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x4AC2300", Offset = "0x4AC0F00", VA = "0x184AC2300")]
		public static System.Security.Cryptography.DSA FromCapiKeyBlobDSA(byte[] blob, int offset)
		{
			return null;
		}
	}
}
