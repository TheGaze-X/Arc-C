using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002EC RID: 748
	[Token(Token = "0x20002EC")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public abstract class AsymmetricSignatureDeformatter
	{
		// Token: 0x060018C2 RID: 6338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected AsymmetricSignatureDeformatter()
		{
		}

		// Token: 0x060018C3 RID: 6339
		[Token(Token = "0x60018C3")]
		public abstract void SetKey(AsymmetricAlgorithm key);

		// Token: 0x060018C4 RID: 6340
		[Token(Token = "0x60018C4")]
		public abstract void SetHashAlgorithm(string strName);

		// Token: 0x060018C5 RID: 6341 RVA: 0x00011898 File Offset: 0x0000FA98
		[Token(Token = "0x60018C5")]
		[Address(RVA = "0x4B23CF0", Offset = "0x4B228F0", VA = "0x184B23CF0", Slot = "6")]
		public virtual bool VerifySignature(HashAlgorithm hash, byte[] rgbSignature)
		{
			return default(bool);
		}

		// Token: 0x060018C6 RID: 6342
		[Token(Token = "0x60018C6")]
		public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);
	}
}
