using System;
using Il2CppDummyDll;

namespace System.Runtime.ConstrainedExecution
{
	// Token: 0x02000485 RID: 1157
	[Token(Token = "0x2000485")]
	public enum Consistency
	{
		// Token: 0x040013CB RID: 5067
		[Token(Token = "0x40013CB")]
		MayCorruptProcess,
		// Token: 0x040013CC RID: 5068
		[Token(Token = "0x40013CC")]
		MayCorruptAppDomain,
		// Token: 0x040013CD RID: 5069
		[Token(Token = "0x40013CD")]
		MayCorruptInstance,
		// Token: 0x040013CE RID: 5070
		[Token(Token = "0x40013CE")]
		WillNotCorruptState
	}
}
