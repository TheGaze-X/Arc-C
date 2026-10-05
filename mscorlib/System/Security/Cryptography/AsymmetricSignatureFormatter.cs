using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002ED RID: 749
	[Token(Token = "0x20002ED")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public abstract class AsymmetricSignatureFormatter
	{
		// Token: 0x060018C7 RID: 6343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018C7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected AsymmetricSignatureFormatter()
		{
		}

		// Token: 0x060018C8 RID: 6344
		[Token(Token = "0x60018C8")]
		public abstract void SetKey(AsymmetricAlgorithm key);

		// Token: 0x060018C9 RID: 6345
		[Token(Token = "0x60018C9")]
		public abstract void SetHashAlgorithm(string strName);

		// Token: 0x060018CA RID: 6346 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60018CA")]
		[Address(RVA = "0x4B23E30", Offset = "0x4B22A30", VA = "0x184B23E30", Slot = "6")]
		public virtual byte[] CreateSignature(HashAlgorithm hash)
		{
			return null;
		}

		// Token: 0x060018CB RID: 6347
		[Token(Token = "0x60018CB")]
		public abstract byte[] CreateSignature(byte[] rgbHash);
	}
}
