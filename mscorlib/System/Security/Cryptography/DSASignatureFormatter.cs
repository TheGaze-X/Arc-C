using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002FE RID: 766
	[Token(Token = "0x20002FE")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class DSASignatureFormatter : AsymmetricSignatureFormatter
	{
		// Token: 0x0600193A RID: 6458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600193A")]
		[Address(RVA = "0x4B28330", Offset = "0x4B26F30", VA = "0x184B28330")]
		public DSASignatureFormatter()
		{
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600193B")]
		[Address(RVA = "0x4B283B0", Offset = "0x4B26FB0", VA = "0x184B283B0")]
		public DSASignatureFormatter(AsymmetricAlgorithm key)
		{
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600193C")]
		[Address(RVA = "0x4B281B0", Offset = "0x4B26DB0", VA = "0x184B281B0", Slot = "4")]
		public override void SetKey(AsymmetricAlgorithm key)
		{
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600193D")]
		[Address(RVA = "0x4B280E0", Offset = "0x4B26CE0", VA = "0x184B280E0", Slot = "5")]
		public override void SetHashAlgorithm(string strName)
		{
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600193E")]
		[Address(RVA = "0x4B27F90", Offset = "0x4B26B90", VA = "0x184B27F90", Slot = "7")]
		public override byte[] CreateSignature(byte[] rgbHash)
		{
			return null;
		}

		// Token: 0x04000DD3 RID: 3539
		[Token(Token = "0x4000DD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DSA _dsaKey;

		// Token: 0x04000DD4 RID: 3540
		[Token(Token = "0x4000DD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _oid;
	}
}
