using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000332 RID: 818
	[Token(Token = "0x2000332")]
	internal static class Utils
	{
		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06001AF9 RID: 6905 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170002ED")]
		internal static RNGCryptoServiceProvider StaticRandomNumberGenerator
		{
			[Token(Token = "0x6001AF9")]
			[Address(RVA = "0x4B52890", Offset = "0x4B51490", VA = "0x184B52890")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001AFA")]
		[Address(RVA = "0x4B52020", Offset = "0x4B50C20", VA = "0x184B52020")]
		internal static byte[] GenerateRandom(int keySize)
		{
			return null;
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x00012468 File Offset: 0x00010668
		[Token(Token = "0x6001AFB")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70")]
		internal static bool HasAlgorithm(int dwCalg, int dwKeySize)
		{
			return default(bool);
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001AFC")]
		[Address(RVA = "0x4B51990", Offset = "0x4B50590", VA = "0x184B51990")]
		internal static string DiscardWhiteSpaces(string inputBuffer)
		{
			return null;
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001AFD")]
		[Address(RVA = "0x4B51B50", Offset = "0x4B50750", VA = "0x184B51B50")]
		internal static string DiscardWhiteSpaces(string inputBuffer, int inputOffset, int inputCount)
		{
			return null;
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x00012480 File Offset: 0x00010680
		[Token(Token = "0x6001AFE")]
		[Address(RVA = "0x4B51540", Offset = "0x4B50140", VA = "0x184B51540")]
		internal static int ConvertByteArrayToInt(byte[] input)
		{
			return 0;
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001AFF")]
		[Address(RVA = "0x4B515A0", Offset = "0x4B501A0", VA = "0x184B515A0")]
		internal static byte[] ConvertIntToByteArray(int dwInput)
		{
			return null;
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B00")]
		[Address(RVA = "0x4B516C0", Offset = "0x4B502C0", VA = "0x184B516C0")]
		internal static void ConvertIntToByteArray(uint dwInput, ref byte[] counter)
		{
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001B01")]
		[Address(RVA = "0x4B51F70", Offset = "0x4B50B70", VA = "0x184B51F70")]
		internal static byte[] FixupKeyParity(byte[] key)
		{
			return null;
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B02")]
		[Address(RVA = "0x4B51790", Offset = "0x4B50390", VA = "0x184B51790")]
		internal unsafe static void DWORDFromLittleEndian(uint* x, int digits, byte* block)
		{
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B03")]
		[Address(RVA = "0x4B518C0", Offset = "0x4B504C0", VA = "0x184B518C0")]
		internal static void DWORDToLittleEndian(byte[] block, uint[] x, int digits)
		{
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B04")]
		[Address(RVA = "0x4B51730", Offset = "0x4B50330", VA = "0x184B51730")]
		internal unsafe static void DWORDFromBigEndian(uint* x, int digits, byte* block)
		{
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B05")]
		[Address(RVA = "0x4B517F0", Offset = "0x4B503F0", VA = "0x184B517F0")]
		internal static void DWORDToBigEndian(byte[] block, uint[] x, int digits)
		{
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B06")]
		[Address(RVA = "0x4B52280", Offset = "0x4B50E80", VA = "0x184B52280")]
		internal unsafe static void QuadWordFromBigEndian(ulong* x, int digits, byte* block)
		{
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B07")]
		[Address(RVA = "0x4B52310", Offset = "0x4B50F10", VA = "0x184B52310")]
		internal static void QuadWordToBigEndian(byte[] block, ulong[] x, int digits)
		{
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001B08")]
		[Address(RVA = "0x4B520D0", Offset = "0x4B50CD0", VA = "0x184B520D0")]
		internal static byte[] Int(uint i)
		{
			return null;
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001B09")]
		[Address(RVA = "0x4B52550", Offset = "0x4B51150", VA = "0x184B52550")]
		internal static byte[] RsaOaepEncrypt(RSA rsa, HashAlgorithm hash, PKCS1MaskGenerationMethod mgf, RandomNumberGenerator rng, byte[] data)
		{
			return null;
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001B0A")]
		[Address(RVA = "0x4B52480", Offset = "0x4B51080", VA = "0x184B52480")]
		internal static byte[] RsaOaepDecrypt(RSA rsa, HashAlgorithm hash, PKCS1MaskGenerationMethod mgf, byte[] encryptedData)
		{
			return null;
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001B0B")]
		[Address(RVA = "0x4B525D0", Offset = "0x4B511D0", VA = "0x184B525D0")]
		internal static byte[] RsaPkcs1Padding(RSA rsa, byte[] oid, byte[] hash)
		{
			return null;
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x00012498 File Offset: 0x00010698
		[Token(Token = "0x6001B0C")]
		[Address(RVA = "0x4B51430", Offset = "0x4B50030", VA = "0x184B51430")]
		internal static bool CompareBigIntArrays(byte[] lhs, byte[] rhs)
		{
			return default(bool);
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x000124B0 File Offset: 0x000106B0
		[Token(Token = "0x6001B0D")]
		[Address(RVA = "0x4B52160", Offset = "0x4B50D60", VA = "0x184B52160")]
		internal static HashAlgorithmName OidToHashAlgorithmName(string oid)
		{
			return default(HashAlgorithmName);
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x000124C8 File Offset: 0x000106C8
		[Token(Token = "0x6001B0E")]
		[Address(RVA = "0x4B51DB0", Offset = "0x4B509B0", VA = "0x184B51DB0")]
		internal static bool DoesRsaKeyOverride(RSA rsaKey, string methodName, System.Type[] parameterTypes)
		{
			return default(bool);
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x000124E0 File Offset: 0x000106E0
		[Token(Token = "0x6001B0F")]
		[Address(RVA = "0x4B51CC0", Offset = "0x4B508C0", VA = "0x184B51CC0")]
		private static bool DoesRsaKeyOverrideSlowPath(System.Type t, string methodName, System.Type[] parameterTypes)
		{
			return default(bool);
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x000124F8 File Offset: 0x000106F8
		[Token(Token = "0x6001B10")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		internal static bool _ProduceLegacyHmacValues()
		{
			return default(bool);
		}

		// Token: 0x04000EA2 RID: 3746
		[Token(Token = "0x4000EA2")]
		internal const int DefaultRsaProviderType = 1;

		// Token: 0x04000EA3 RID: 3747
		[Token(Token = "0x4000EA3")]
		[FieldOffset(Offset = "0x0")]
		private static RNGCryptoServiceProvider _rng;
	}
}
