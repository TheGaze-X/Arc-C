using System;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	public sealed class PKCS1
	{
		// Token: 0x060001B6 RID: 438 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x4A9EFC0", Offset = "0x4A9DBC0", VA = "0x184A9EFC0")]
		private static bool Compare(byte[] array1, byte[] array2)
		{
			return default(bool);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x4A9FDE0", Offset = "0x4A9E9E0", VA = "0x184A9FDE0")]
		public static byte[] I2OSP(byte[] x, int size)
		{
			return null;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x4A9FE60", Offset = "0x4A9EA60", VA = "0x184A9FE60")]
		public static byte[] OS2IP(byte[] x)
		{
			return null;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x4A9FF20", Offset = "0x4A9EB20", VA = "0x184A9FF20")]
		public static byte[] RSAVP1(RSA rsa, byte[] s)
		{
			return null;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x4A9FF70", Offset = "0x4A9EB70", VA = "0x184A9FF70")]
		public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding)
		{
			return default(bool);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x4A9F650", Offset = "0x4A9E250", VA = "0x184A9F650")]
		public static byte[] Encode_v15(HashAlgorithm hash, byte[] hashValue, int emLength)
		{
			return null;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x4A9FA00", Offset = "0x4A9E600", VA = "0x184A9FA00")]
		internal static string HashNameFromOid(string oid, bool throwOnError = true)
		{
			return null;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x4A9F5F0", Offset = "0x4A9E1F0", VA = "0x184A9F5F0")]
		internal static HashAlgorithm CreateFromOid(string oid)
		{
			return null;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x4A9F040", Offset = "0x4A9DC40", VA = "0x184A9F040")]
		internal static HashAlgorithm CreateFromName(string name)
		{
			return null;
		}

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x0")]
		private static byte[] emptySHA1;

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x8")]
		private static byte[] emptySHA256;

		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x10")]
		private static byte[] emptySHA384;

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x18")]
		private static byte[] emptySHA512;
	}
}
