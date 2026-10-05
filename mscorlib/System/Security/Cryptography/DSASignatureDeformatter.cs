using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002FD RID: 765
	[Token(Token = "0x20002FD")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class DSASignatureDeformatter : AsymmetricSignatureDeformatter
	{
		// Token: 0x06001935 RID: 6453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001935")]
		[Address(RVA = "0x4B27F10", Offset = "0x4B26B10", VA = "0x184B27F10")]
		public DSASignatureDeformatter()
		{
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001936")]
		[Address(RVA = "0x4B27D30", Offset = "0x4B26930", VA = "0x184B27D30")]
		public DSASignatureDeformatter(AsymmetricAlgorithm key)
		{
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001937")]
		[Address(RVA = "0x4B27A70", Offset = "0x4B26670", VA = "0x184B27A70", Slot = "4")]
		public override void SetKey(AsymmetricAlgorithm key)
		{
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001938")]
		[Address(RVA = "0x4B279A0", Offset = "0x4B265A0", VA = "0x184B279A0", Slot = "5")]
		public override void SetHashAlgorithm(string strName)
		{
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x00011B68 File Offset: 0x0000FD68
		[Token(Token = "0x6001939")]
		[Address(RVA = "0x4B27BF0", Offset = "0x4B267F0", VA = "0x184B27BF0", Slot = "7")]
		public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
		{
			return default(bool);
		}

		// Token: 0x04000DD1 RID: 3537
		[Token(Token = "0x4000DD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DSA _dsaKey;

		// Token: 0x04000DD2 RID: 3538
		[Token(Token = "0x4000DD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _oid;
	}
}
