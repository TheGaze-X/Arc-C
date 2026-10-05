using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x0200033B RID: 827
	[Token(Token = "0x200033B")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter
	{
		// Token: 0x06001B7C RID: 7036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7C")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public RSAPKCS1SignatureDeformatter()
		{
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7D")]
		[Address(RVA = "0x4B63F40", Offset = "0x4B62B40", VA = "0x184B63F40")]
		public RSAPKCS1SignatureDeformatter(AsymmetricAlgorithm key)
		{
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7E")]
		[Address(RVA = "0x4B63B30", Offset = "0x4B62730", VA = "0x184B63B30", Slot = "5")]
		public override void SetHashAlgorithm(string strName)
		{
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7F")]
		[Address(RVA = "0x4B63BB0", Offset = "0x4B627B0", VA = "0x184B63BB0", Slot = "4")]
		public override void SetKey(AsymmetricAlgorithm key)
		{
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x00012768 File Offset: 0x00010968
		[Token(Token = "0x6001B80")]
		[Address(RVA = "0x4B63D30", Offset = "0x4B62930", VA = "0x184B63D30", Slot = "7")]
		public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
		{
			return default(bool);
		}

		// Token: 0x04000ECE RID: 3790
		[Token(Token = "0x4000ECE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private RSA rsa;

		// Token: 0x04000ECF RID: 3791
		[Token(Token = "0x4000ECF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string hashName;
	}
}
