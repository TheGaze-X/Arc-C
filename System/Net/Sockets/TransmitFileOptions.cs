using System;
using Il2CppDummyDll;

namespace System.Net.Sockets
{
	// Token: 0x020003C5 RID: 965
	[Token(Token = "0x20003C5")]
	[Flags]
	public enum TransmitFileOptions
	{
		// Token: 0x040010C4 RID: 4292
		[Token(Token = "0x40010C4")]
		UseDefaultWorkerThread = 0,
		// Token: 0x040010C5 RID: 4293
		[Token(Token = "0x40010C5")]
		Disconnect = 1,
		// Token: 0x040010C6 RID: 4294
		[Token(Token = "0x40010C6")]
		ReuseSocket = 2,
		// Token: 0x040010C7 RID: 4295
		[Token(Token = "0x40010C7")]
		WriteBehind = 4,
		// Token: 0x040010C8 RID: 4296
		[Token(Token = "0x40010C8")]
		UseSystemThread = 16,
		// Token: 0x040010C9 RID: 4297
		[Token(Token = "0x40010C9")]
		UseKernelApc = 32
	}
}
