using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002FA RID: 762
	[Token(Token = "0x20002FA")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public sealed class DESCryptoServiceProvider : DES
	{
		// Token: 0x06001916 RID: 6422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001916")]
		[Address(RVA = "0x4B26B60", Offset = "0x4B25760", VA = "0x184B26B60")]
		public DESCryptoServiceProvider()
		{
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001917")]
		[Address(RVA = "0x4B267B0", Offset = "0x4B253B0", VA = "0x184B267B0", Slot = "23")]
		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
		{
			return null;
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001918")]
		[Address(RVA = "0x4B265F0", Offset = "0x4B251F0", VA = "0x184B265F0", Slot = "25")]
		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
		{
			return null;
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001919")]
		[Address(RVA = "0x4B26A30", Offset = "0x4B25630", VA = "0x184B26A30", Slot = "26")]
		public override void GenerateKey()
		{
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600191A")]
		[Address(RVA = "0x4B26970", Offset = "0x4B25570", VA = "0x184B26970", Slot = "27")]
		public override void GenerateIV()
		{
		}
	}
}
