using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000149 RID: 329
	[Token(Token = "0x2000149")]
	public enum ECheckFileSignature
	{
		// Token: 0x04000792 RID: 1938
		[Token(Token = "0x4000792")]
		k_ECheckFileSignatureInvalidSignature,
		// Token: 0x04000793 RID: 1939
		[Token(Token = "0x4000793")]
		k_ECheckFileSignatureValidSignature,
		// Token: 0x04000794 RID: 1940
		[Token(Token = "0x4000794")]
		k_ECheckFileSignatureFileNotFound,
		// Token: 0x04000795 RID: 1941
		[Token(Token = "0x4000795")]
		k_ECheckFileSignatureNoSignaturesFoundForThisApp,
		// Token: 0x04000796 RID: 1942
		[Token(Token = "0x4000796")]
		k_ECheckFileSignatureNoSignaturesFoundForThisFile
	}
}
