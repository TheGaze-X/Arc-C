using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002F1 RID: 753
	[Token(Token = "0x20002F1")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public enum CipherMode
	{
		// Token: 0x04000DA4 RID: 3492
		[Token(Token = "0x4000DA4")]
		CBC = 1,
		// Token: 0x04000DA5 RID: 3493
		[Token(Token = "0x4000DA5")]
		ECB,
		// Token: 0x04000DA6 RID: 3494
		[Token(Token = "0x4000DA6")]
		OFB,
		// Token: 0x04000DA7 RID: 3495
		[Token(Token = "0x4000DA7")]
		CFB,
		// Token: 0x04000DA8 RID: 3496
		[Token(Token = "0x4000DA8")]
		CTS
	}
}
