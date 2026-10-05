using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000312 RID: 786
	[Token(Token = "0x2000312")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public sealed class RijndaelManaged : Rijndael
	{
		// Token: 0x060019C8 RID: 6600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019C8")]
		[Address(RVA = "0x4B37460", Offset = "0x4B36060", VA = "0x184B37460")]
		public RijndaelManaged()
		{
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60019C9")]
		[Address(RVA = "0x4B37120", Offset = "0x4B35D20", VA = "0x184B37120", Slot = "23")]
		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
		{
			return null;
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60019CA")]
		[Address(RVA = "0x4B36FF0", Offset = "0x4B35BF0", VA = "0x184B36FF0", Slot = "25")]
		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
		{
			return null;
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019CB")]
		[Address(RVA = "0x4B372C0", Offset = "0x4B35EC0", VA = "0x184B372C0", Slot = "26")]
		public override void GenerateKey()
		{
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019CC")]
		[Address(RVA = "0x4B37250", Offset = "0x4B35E50", VA = "0x184B37250", Slot = "27")]
		public override void GenerateIV()
		{
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60019CD")]
		[Address(RVA = "0x4B37330", Offset = "0x4B35F30", VA = "0x184B37330")]
		private ICryptoTransform NewEncryptor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int feedbackSize, RijndaelManagedTransformMode encryptMode)
		{
			return null;
		}
	}
}
