using System;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x020001F7 RID: 503
	[Token(Token = "0x20001F7")]
	[System.Flags]
	public enum ThreadState
	{
		// Token: 0x040009FB RID: 2555
		[Token(Token = "0x40009FB")]
		Running = 0,
		// Token: 0x040009FC RID: 2556
		[Token(Token = "0x40009FC")]
		StopRequested = 1,
		// Token: 0x040009FD RID: 2557
		[Token(Token = "0x40009FD")]
		SuspendRequested = 2,
		// Token: 0x040009FE RID: 2558
		[Token(Token = "0x40009FE")]
		Background = 4,
		// Token: 0x040009FF RID: 2559
		[Token(Token = "0x40009FF")]
		Unstarted = 8,
		// Token: 0x04000A00 RID: 2560
		[Token(Token = "0x4000A00")]
		Stopped = 16,
		// Token: 0x04000A01 RID: 2561
		[Token(Token = "0x4000A01")]
		WaitSleepJoin = 32,
		// Token: 0x04000A02 RID: 2562
		[Token(Token = "0x4000A02")]
		Suspended = 64,
		// Token: 0x04000A03 RID: 2563
		[Token(Token = "0x4000A03")]
		AbortRequested = 128,
		// Token: 0x04000A04 RID: 2564
		[Token(Token = "0x4000A04")]
		Aborted = 256
	}
}
