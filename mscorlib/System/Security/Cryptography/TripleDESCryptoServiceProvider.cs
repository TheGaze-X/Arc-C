using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x0200032F RID: 815
	[Token(Token = "0x200032F")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public sealed class TripleDESCryptoServiceProvider : TripleDES
	{
		// Token: 0x06001AF3 RID: 6899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF3")]
		[Address(RVA = "0x4B50780", Offset = "0x4B4F380", VA = "0x184B50780")]
		public TripleDESCryptoServiceProvider()
		{
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001AF4")]
		[Address(RVA = "0x4B50490", Offset = "0x4B4F090", VA = "0x184B50490", Slot = "23")]
		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
		{
			return null;
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001AF5")]
		[Address(RVA = "0x4B50360", Offset = "0x4B4EF60", VA = "0x184B50360", Slot = "25")]
		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
		{
			return null;
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF6")]
		[Address(RVA = "0x4B50680", Offset = "0x4B4F280", VA = "0x184B50680", Slot = "26")]
		public override void GenerateKey()
		{
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF7")]
		[Address(RVA = "0x4B505C0", Offset = "0x4B4F1C0", VA = "0x184B505C0", Slot = "27")]
		public override void GenerateIV()
		{
		}
	}
}
