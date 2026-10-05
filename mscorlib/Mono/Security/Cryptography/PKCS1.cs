using System;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	internal sealed class PKCS1
	{
		// Token: 0x0600019E RID: 414 RVA: 0x00002CD0 File Offset: 0x00000ED0
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x4A9EFC0", Offset = "0x4A9DBC0", VA = "0x184A9EFC0")]
		private static bool Compare(byte[] array1, byte[] array2)
		{
			return default(bool);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x4ACF8F0", Offset = "0x4ACE4F0", VA = "0x184ACF8F0")]
		private static byte[] xor(byte[] array1, byte[] array2)
		{
			return null;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x4ACE750", Offset = "0x4ACD350", VA = "0x184ACE750")]
		private static byte[] GetEmptyHash(System.Security.Cryptography.HashAlgorithm hash)
		{
			return null;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x4ACEA40", Offset = "0x4ACD640", VA = "0x184ACEA40")]
		public static byte[] I2OSP(int x, int size)
		{
			return null;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x4ACE9C0", Offset = "0x4ACD5C0", VA = "0x184ACE9C0")]
		public static byte[] I2OSP(byte[] x, int size)
		{
			return null;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x4ACEE30", Offset = "0x4ACDA30", VA = "0x184ACEE30")]
		public static byte[] OS2IP(byte[] x)
		{
			return null;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x4A9FF20", Offset = "0x4A9EB20", VA = "0x184A9FF20")]
		public static byte[] RSAEP(System.Security.Cryptography.RSA rsa, byte[] m)
		{
			return null;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x4ACEEF0", Offset = "0x4ACDAF0", VA = "0x184ACEEF0")]
		public static byte[] RSADP(System.Security.Cryptography.RSA rsa, byte[] c)
		{
			return null;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x4ACEEF0", Offset = "0x4ACDAF0", VA = "0x184ACEEF0")]
		public static byte[] RSASP1(System.Security.Cryptography.RSA rsa, byte[] m)
		{
			return null;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x4A9FF20", Offset = "0x4A9EB20", VA = "0x184A9FF20")]
		public static byte[] RSAVP1(System.Security.Cryptography.RSA rsa, byte[] s)
		{
			return null;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x4ACE240", Offset = "0x4ACCE40", VA = "0x184ACE240")]
		public static byte[] Encrypt_OAEP(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.HashAlgorithm hash, System.Security.Cryptography.RandomNumberGenerator rng, byte[] M)
		{
			return null;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x4ACD950", Offset = "0x4ACC550", VA = "0x184ACD950")]
		public static byte[] Decrypt_OAEP(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.HashAlgorithm hash, byte[] C)
		{
			return null;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x4ACF050", Offset = "0x4ACDC50", VA = "0x184ACF050")]
		public static byte[] Sign_v15(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.HashAlgorithm hash, byte[] hashValue)
		{
			return null;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x4ACEF40", Offset = "0x4ACDB40", VA = "0x184ACEF40")]
		internal static byte[] Sign_v15(System.Security.Cryptography.RSA rsa, string hashName, byte[] hashValue)
		{
			return null;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002CE8 File Offset: 0x00000EE8
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x4ACF6B0", Offset = "0x4ACE2B0", VA = "0x184ACF6B0")]
		public static bool Verify_v15(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.HashAlgorithm hash, byte[] hashValue, byte[] signature)
		{
			return default(bool);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002D00 File Offset: 0x00000F00
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x4ACF590", Offset = "0x4ACE190", VA = "0x184ACF590")]
		internal static bool Verify_v15(System.Security.Cryptography.RSA rsa, string hashName, byte[] hashValue, byte[] signature)
		{
			return default(bool);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002D18 File Offset: 0x00000F18
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x4ACF230", Offset = "0x4ACDE30", VA = "0x184ACF230")]
		public static bool Verify_v15(System.Security.Cryptography.RSA rsa, System.Security.Cryptography.HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding)
		{
			return default(bool);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x4ACDE90", Offset = "0x4ACCA90", VA = "0x184ACDE90")]
		public static byte[] Encode_v15(System.Security.Cryptography.HashAlgorithm hash, byte[] hashValue, int emLength)
		{
			return null;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x4ACEB20", Offset = "0x4ACD720", VA = "0x184ACEB20")]
		public static byte[] MGF1(System.Security.Cryptography.HashAlgorithm hash, byte[] mgfSeed, int maskLen)
		{
			return null;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x4ACD3A0", Offset = "0x4ACBFA0", VA = "0x184ACD3A0")]
		internal static System.Security.Cryptography.HashAlgorithm CreateFromName(string name)
		{
			return null;
		}

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x0")]
		private static byte[] emptySHA1;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x8")]
		private static byte[] emptySHA256;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x10")]
		private static byte[] emptySHA384;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x18")]
		private static byte[] emptySHA512;
	}
}
