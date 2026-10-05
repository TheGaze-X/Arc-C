using System;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x0200053D RID: 1341
	[Token(Token = "0x200053D")]
	[System.Flags]
	internal enum PInfo
	{
		// Token: 0x04001633 RID: 5683
		[Token(Token = "0x4001633")]
		Attributes = 1,
		// Token: 0x04001634 RID: 5684
		[Token(Token = "0x4001634")]
		GetMethod = 2,
		// Token: 0x04001635 RID: 5685
		[Token(Token = "0x4001635")]
		SetMethod = 4,
		// Token: 0x04001636 RID: 5686
		[Token(Token = "0x4001636")]
		ReflectedType = 8,
		// Token: 0x04001637 RID: 5687
		[Token(Token = "0x4001637")]
		DeclaringType = 16,
		// Token: 0x04001638 RID: 5688
		[Token(Token = "0x4001638")]
		Name = 32
	}
}
