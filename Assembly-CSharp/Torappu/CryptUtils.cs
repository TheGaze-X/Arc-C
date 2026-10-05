using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013CF RID: 5071
	[Token(Token = "0x20013CF")]
	public class CryptUtils
	{
		// Token: 0x060073BF RID: 29631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073BF")]
		[Address(RVA = "0x2204150", Offset = "0x2202D50", VA = "0x182204150")]
		public static string CalculateMD5FromString(string source)
		{
			return null;
		}

		// Token: 0x060073C0 RID: 29632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073C0")]
		[Address(RVA = "0x22042F0", Offset = "0x2202EF0", VA = "0x1822042F0")]
		public static string CalculateShortMD5FromString(string source, int cutLength)
		{
			return null;
		}

		// Token: 0x060073C1 RID: 29633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073C1")]
		[Address(RVA = "0x2203E40", Offset = "0x2202A40", VA = "0x182203E40")]
		public static string CalculateMD5FromFile(string file)
		{
			return null;
		}

		// Token: 0x060073C2 RID: 29634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073C2")]
		[Address(RVA = "0x2203D70", Offset = "0x2202970", VA = "0x182203D70")]
		public static string CalculateMD5FromFileOrEmpty(string file)
		{
			return null;
		}

		// Token: 0x060073C3 RID: 29635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073C3")]
		[Address(RVA = "0x2204690", Offset = "0x2203290", VA = "0x182204690")]
		public static string[] GenerateKeysRSA()
		{
			return null;
		}

		// Token: 0x060073C4 RID: 29636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073C4")]
		[Address(RVA = "0x2204AF0", Offset = "0x22036F0", VA = "0x182204AF0")]
		public static string SignWithMD5RSA(string content, string key)
		{
			return null;
		}

		// Token: 0x060073C5 RID: 29637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073C5")]
		[Address(RVA = "0x22048A0", Offset = "0x22034A0", VA = "0x1822048A0")]
		public static byte[] SignWithMD5RSA(byte[] contentBytes, string key)
		{
			return null;
		}

		// Token: 0x060073C6 RID: 29638 RVA: 0x00033798 File Offset: 0x00031998
		[Token(Token = "0x60073C6")]
		[Address(RVA = "0x2204E80", Offset = "0x2203A80", VA = "0x182204E80")]
		public static bool VerifySignMD5RSA(string content, string sign, string publicKey)
		{
			return default(bool);
		}

		// Token: 0x060073C7 RID: 29639 RVA: 0x000337B0 File Offset: 0x000319B0
		[Token(Token = "0x60073C7")]
		[Address(RVA = "0x2204C10", Offset = "0x2203810", VA = "0x182204C10")]
		public static bool VerifySignMD5RSA(byte[] contentBytes, byte[] sign, string publicKey)
		{
			return default(bool);
		}

		// Token: 0x060073C8 RID: 29640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073C8")]
		[Address(RVA = "0x22044C0", Offset = "0x22030C0", VA = "0x1822044C0")]
		public static string EncryptRSA(byte[] plainText, string key)
		{
			return null;
		}

		// Token: 0x060073C9 RID: 29641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073C9")]
		[Address(RVA = "0x2204320", Offset = "0x2202F20", VA = "0x182204320")]
		public static byte[] DecryptRSA(string cipher, string key)
		{
			return null;
		}

		// Token: 0x060073CA RID: 29642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073CA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CryptUtils()
		{
		}
	}
}
