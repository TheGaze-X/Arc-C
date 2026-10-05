using System;
using Il2CppDummyDll;

namespace UnityEngineInternal.Input
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[Flags]
	internal enum NativeInputUpdateType
	{
		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		Dynamic = 1,
		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		Fixed = 2,
		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		BeforeRender = 4,
		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		Editor = 8,
		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		IgnoreFocus = -2147483648
	}
}
