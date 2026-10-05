using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x0200033C RID: 828
	[Token(Token = "0x200033C")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class RSAPKCS1SignatureFormatter : AsymmetricSignatureFormatter
	{
		// Token: 0x06001B81 RID: 7041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B81")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public RSAPKCS1SignatureFormatter()
		{
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B82")]
		[Address(RVA = "0x4B63F40", Offset = "0x4B62B40", VA = "0x184B63F40")]
		public RSAPKCS1SignatureFormatter(AsymmetricAlgorithm key)
		{
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001B83")]
		[Address(RVA = "0x4B63F90", Offset = "0x4B62B90", VA = "0x184B63F90", Slot = "7")]
		public override byte[] CreateSignature(byte[] rgbHash)
		{
			return null;
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B84")]
		[Address(RVA = "0x4B64130", Offset = "0x4B62D30", VA = "0x184B64130", Slot = "5")]
		public override void SetHashAlgorithm(string strName)
		{
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B85")]
		[Address(RVA = "0x4B641B0", Offset = "0x4B62DB0", VA = "0x184B641B0", Slot = "4")]
		public override void SetKey(AsymmetricAlgorithm key)
		{
		}

		// Token: 0x04000ED0 RID: 3792
		[Token(Token = "0x4000ED0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private RSA rsa;

		// Token: 0x04000ED1 RID: 3793
		[Token(Token = "0x4000ED1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string hash;
	}
}
