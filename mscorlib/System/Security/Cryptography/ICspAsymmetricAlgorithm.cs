using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002D8 RID: 728
	[Token(Token = "0x20002D8")]
	public interface ICspAsymmetricAlgorithm
	{
		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06001825 RID: 6181
		[Token(Token = "0x17000276")]
		CspKeyContainerInfo CspKeyContainerInfo { [Token(Token = "0x6001825")] get; }

		// Token: 0x06001826 RID: 6182
		[Token(Token = "0x6001826")]
		byte[] ExportCspBlob(bool includePrivateParameters);

		// Token: 0x06001827 RID: 6183
		[Token(Token = "0x6001827")]
		void ImportCspBlob(byte[] rawData);
	}
}
