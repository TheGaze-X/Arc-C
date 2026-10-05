using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002EA RID: 746
	[Token(Token = "0x20002EA")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public abstract class AsymmetricKeyExchangeDeformatter
	{
		// Token: 0x060018B8 RID: 6328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected AsymmetricKeyExchangeDeformatter()
		{
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060018B9 RID: 6329
		// (set) Token: 0x060018BA RID: 6330
		[Token(Token = "0x17000298")]
		public abstract string Parameters { [Token(Token = "0x60018B9")] get; [Token(Token = "0x60018BA")] set; }

		// Token: 0x060018BB RID: 6331
		[Token(Token = "0x60018BB")]
		public abstract void SetKey(AsymmetricAlgorithm key);

		// Token: 0x060018BC RID: 6332
		[Token(Token = "0x60018BC")]
		public abstract byte[] DecryptKeyExchange(byte[] rgb);
	}
}
