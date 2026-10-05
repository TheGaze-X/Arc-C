using System;
using Il2CppDummyDll;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000473 RID: 1139
	[Token(Token = "0x2000473")]
	[ComVisible(true)]
	[System.Serializable]
	public enum CallingConvention
	{
		// Token: 0x040013A5 RID: 5029
		[Token(Token = "0x40013A5")]
		Winapi = 1,
		// Token: 0x040013A6 RID: 5030
		[Token(Token = "0x40013A6")]
		Cdecl,
		// Token: 0x040013A7 RID: 5031
		[Token(Token = "0x40013A7")]
		StdCall,
		// Token: 0x040013A8 RID: 5032
		[Token(Token = "0x40013A8")]
		ThisCall,
		// Token: 0x040013A9 RID: 5033
		[Token(Token = "0x40013A9")]
		FastCall
	}
}
