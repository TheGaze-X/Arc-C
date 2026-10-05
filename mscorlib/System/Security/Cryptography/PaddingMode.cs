using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002F2 RID: 754
	[Token(Token = "0x20002F2")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public enum PaddingMode
	{
		// Token: 0x04000DAA RID: 3498
		[Token(Token = "0x4000DAA")]
		None = 1,
		// Token: 0x04000DAB RID: 3499
		[Token(Token = "0x4000DAB")]
		PKCS7,
		// Token: 0x04000DAC RID: 3500
		[Token(Token = "0x4000DAC")]
		Zeros,
		// Token: 0x04000DAD RID: 3501
		[Token(Token = "0x4000DAD")]
		ANSIX923,
		// Token: 0x04000DAE RID: 3502
		[Token(Token = "0x4000DAE")]
		ISO10126
	}
}
