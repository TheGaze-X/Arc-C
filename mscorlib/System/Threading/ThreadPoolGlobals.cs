using System;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x0200022B RID: 555
	[Token(Token = "0x200022B")]
	internal static class ThreadPoolGlobals
	{
		// Token: 0x04000AA0 RID: 2720
		[Token(Token = "0x4000AA0")]
		[FieldOffset(Offset = "0x0")]
		public static int processorCount;

		// Token: 0x04000AA1 RID: 2721
		[Token(Token = "0x4000AA1")]
		[FieldOffset(Offset = "0x4")]
		public static bool vmTpInitialized;

		// Token: 0x04000AA2 RID: 2722
		[Token(Token = "0x4000AA2")]
		[FieldOffset(Offset = "0x5")]
		public static bool enableWorkerTracking;

		// Token: 0x04000AA3 RID: 2723
		[Token(Token = "0x4000AA3")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ThreadPoolWorkQueue workQueue;
	}
}
