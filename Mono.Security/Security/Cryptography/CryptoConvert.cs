using System;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000049")]
	public sealed class CryptoConvert
	{
		// Token: 0x06000191 RID: 401 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x4A984E0", Offset = "0x4A970E0", VA = "0x184A984E0")]
		private static int ToInt32LE(byte[] bytes, int offset)
		{
			return 0;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x4A984E0", Offset = "0x4A970E0", VA = "0x184A984E0")]
		private static uint ToUInt32LE(byte[] bytes, int offset)
		{
			return 0U;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x4A98560", Offset = "0x4A97160", VA = "0x184A98560")]
		private static byte[] Trim(byte[] array)
		{
			return null;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x4A97790", Offset = "0x4A96390", VA = "0x184A97790")]
		public static RSA FromCapiPrivateKeyBlob(byte[] blob)
		{
			return null;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x4A977A0", Offset = "0x4A963A0", VA = "0x184A977A0")]
		public static RSA FromCapiPrivateKeyBlob(byte[] blob, int offset)
		{
			return null;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x4A97CA0", Offset = "0x4A968A0", VA = "0x184A97CA0")]
		private static RSAParameters GetParametersFromCapiPrivateKeyBlob(byte[] blob, int offset)
		{
			return default(RSAParameters);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x4A983B0", Offset = "0x4A96FB0", VA = "0x184A983B0")]
		public static string ToHex(byte[] input)
		{
			return null;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x4A97990", Offset = "0x4A96590", VA = "0x184A97990")]
		private static byte FromHexChar(char c)
		{
			return 0;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x4A97A30", Offset = "0x4A96630", VA = "0x184A97A30")]
		public static byte[] FromHex(string hex)
		{
			return null;
		}
	}
}
