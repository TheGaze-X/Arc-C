using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x02000415 RID: 1045
	[Token(Token = "0x2000415")]
	[System.Flags]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public enum StreamingContextStates
	{
		// Token: 0x04001104 RID: 4356
		[Token(Token = "0x4001104")]
		CrossProcess = 1,
		// Token: 0x04001105 RID: 4357
		[Token(Token = "0x4001105")]
		CrossMachine = 2,
		// Token: 0x04001106 RID: 4358
		[Token(Token = "0x4001106")]
		File = 4,
		// Token: 0x04001107 RID: 4359
		[Token(Token = "0x4001107")]
		Persistence = 8,
		// Token: 0x04001108 RID: 4360
		[Token(Token = "0x4001108")]
		Remoting = 16,
		// Token: 0x04001109 RID: 4361
		[Token(Token = "0x4001109")]
		Other = 32,
		// Token: 0x0400110A RID: 4362
		[Token(Token = "0x400110A")]
		Clone = 64,
		// Token: 0x0400110B RID: 4363
		[Token(Token = "0x400110B")]
		CrossAppDomain = 128,
		// Token: 0x0400110C RID: 4364
		[Token(Token = "0x400110C")]
		All = 255
	}
}
