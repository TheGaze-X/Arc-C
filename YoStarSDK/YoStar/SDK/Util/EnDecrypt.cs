using System;
using Il2CppDummyDll;

namespace YoStar.SDK.Util
{
	// Token: 0x02000099 RID: 153
	[Token(Token = "0x2000099")]
	public class EnDecrypt
	{
		// Token: 0x0600043C RID: 1084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x5C0AAC0", Offset = "0x5C096C0", VA = "0x185C0AAC0")]
		public static string EncryptMD5(string str)
		{
			return null;
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x5C0A6F0", Offset = "0x5C092F0", VA = "0x185C0A6F0")]
		public static string EncryptAES(string plainText)
		{
			return null;
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x5C0A260", Offset = "0x5C08E60", VA = "0x185C0A260")]
		public static string DecryptAES(string encryptedHexString)
		{
			return null;
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EnDecrypt()
		{
		}

		// Token: 0x04000265 RID: 613
		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] KEY;

		// Token: 0x04000266 RID: 614
		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x8")]
		private static readonly byte[] IV;
	}
}
