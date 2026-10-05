using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002EB RID: 747
	[Token(Token = "0x20002EB")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public abstract class AsymmetricKeyExchangeFormatter
	{
		// Token: 0x060018BD RID: 6333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018BD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected AsymmetricKeyExchangeFormatter()
		{
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060018BE RID: 6334
		[Token(Token = "0x17000299")]
		public abstract string Parameters { [Token(Token = "0x60018BE")] get; }

		// Token: 0x060018BF RID: 6335
		[Token(Token = "0x60018BF")]
		public abstract void SetKey(AsymmetricAlgorithm key);

		// Token: 0x060018C0 RID: 6336
		[Token(Token = "0x60018C0")]
		public abstract byte[] CreateKeyExchange(byte[] data);

		// Token: 0x060018C1 RID: 6337
		[Token(Token = "0x60018C1")]
		public abstract byte[] CreateKeyExchange(byte[] data, System.Type symAlgType);
	}
}
