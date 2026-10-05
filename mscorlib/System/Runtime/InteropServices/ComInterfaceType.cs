using System;
using Il2CppDummyDll;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000460 RID: 1120
	[Token(Token = "0x2000460")]
	[ComVisible(true)]
	[System.Serializable]
	public enum ComInterfaceType
	{
		// Token: 0x0400132C RID: 4908
		[Token(Token = "0x400132C")]
		InterfaceIsDual,
		// Token: 0x0400132D RID: 4909
		[Token(Token = "0x400132D")]
		InterfaceIsIUnknown,
		// Token: 0x0400132E RID: 4910
		[Token(Token = "0x400132E")]
		InterfaceIsIDispatch,
		// Token: 0x0400132F RID: 4911
		[Token(Token = "0x400132F")]
		[ComVisible(false)]
		InterfaceIsIInspectable
	}
}
