using System;
using Il2CppDummyDll;

namespace System.Threading.Tasks.Sources
{
	// Token: 0x02000281 RID: 641
	[Token(Token = "0x2000281")]
	[System.Flags]
	public enum ValueTaskSourceOnCompletedFlags
	{
		// Token: 0x04000BD4 RID: 3028
		[Token(Token = "0x4000BD4")]
		None = 0,
		// Token: 0x04000BD5 RID: 3029
		[Token(Token = "0x4000BD5")]
		UseSchedulingContext = 1,
		// Token: 0x04000BD6 RID: 3030
		[Token(Token = "0x4000BD6")]
		FlowExecutionContext = 2
	}
}
