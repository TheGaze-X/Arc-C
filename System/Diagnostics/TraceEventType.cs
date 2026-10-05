using System;
using System.ComponentModel;
using Il2CppDummyDll;

namespace System.Diagnostics
{
	// Token: 0x02000104 RID: 260
	[Token(Token = "0x2000104")]
	public enum TraceEventType
	{
		// Token: 0x04000460 RID: 1120
		[Token(Token = "0x4000460")]
		Critical = 1,
		// Token: 0x04000461 RID: 1121
		[Token(Token = "0x4000461")]
		Error,
		// Token: 0x04000462 RID: 1122
		[Token(Token = "0x4000462")]
		Warning = 4,
		// Token: 0x04000463 RID: 1123
		[Token(Token = "0x4000463")]
		Information = 8,
		// Token: 0x04000464 RID: 1124
		[Token(Token = "0x4000464")]
		Verbose = 16,
		// Token: 0x04000465 RID: 1125
		[Token(Token = "0x4000465")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Start = 256,
		// Token: 0x04000466 RID: 1126
		[Token(Token = "0x4000466")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Stop = 512,
		// Token: 0x04000467 RID: 1127
		[Token(Token = "0x4000467")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Suspend = 1024,
		// Token: 0x04000468 RID: 1128
		[Token(Token = "0x4000468")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Resume = 2048,
		// Token: 0x04000469 RID: 1129
		[Token(Token = "0x4000469")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		Transfer = 4096
	}
}
