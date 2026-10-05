using System;
using System.IO;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace YoStar.SDK.Util
{
	// Token: 0x020000B2 RID: 178
	[Token(Token = "0x20000B2")]
	public class RSAUtils
	{
		// Token: 0x060004C1 RID: 1217 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RSAUtils()
		{
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x5C148D0", Offset = "0x5C134D0", VA = "0x185C148D0")]
		public static string RsaEncryption(string publicKey, string cardInfo)
		{
			return null;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x000027EC File Offset: 0x000009EC
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x5C13D30", Offset = "0x5C12930", VA = "0x185C13D30")]
		private static RSAParameters DecodeX509PublicKey(byte[] x509key)
		{
			return default(RSAParameters);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00002804 File Offset: 0x00000A04
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x5C14800", Offset = "0x5C13400", VA = "0x185C14800")]
		private static bool ReadNextElement(BinaryReader binr, byte expectedFirstByte)
		{
			return default(bool);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0000281C File Offset: 0x00000A1C
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x5C144A0", Offset = "0x5C130A0", VA = "0x185C144A0")]
		private static int GetIntegerSize(BinaryReader binr)
		{
			return 0;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x5C146D0", Offset = "0x5C132D0", VA = "0x185C146D0")]
		private static byte[] ReadModulus(BinaryReader binr, ref int modsize)
		{
			return null;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00002834 File Offset: 0x00000A34
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x50D3710", Offset = "0x50D2310", VA = "0x1850D3710")]
		private static bool CompareBytearrays(byte[] a, byte[] b)
		{
			return default(bool);
		}
	}
}
