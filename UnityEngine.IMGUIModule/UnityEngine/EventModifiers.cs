using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[Flags]
	public enum EventModifiers
	{
		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		None = 0,
		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		Shift = 1,
		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		Control = 2,
		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		Alt = 4,
		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		Command = 8,
		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		Numeric = 16,
		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		CapsLock = 32,
		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		FunctionKey = 64
	}
}
