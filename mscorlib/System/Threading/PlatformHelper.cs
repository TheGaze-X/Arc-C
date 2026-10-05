using System;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x02000200 RID: 512
	[Token(Token = "0x2000200")]
	internal static class PlatformHelper
	{
		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x0000E640 File Offset: 0x0000C840
		[Token(Token = "0x170001A6")]
		internal static int ProcessorCount
		{
			[Token(Token = "0x60011E8")]
			[Address(RVA = "0x4D58520", Offset = "0x4D57120", VA = "0x184D58520")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000A1E RID: 2590
		[Token(Token = "0x4000A1E")]
		[FieldOffset(Offset = "0x0")]
		private static int s_processorCount;

		// Token: 0x04000A1F RID: 2591
		[Token(Token = "0x4000A1F")]
		[FieldOffset(Offset = "0x4")]
		private static int s_lastProcessorCountRefreshTicks;

		// Token: 0x04000A20 RID: 2592
		[Token(Token = "0x4000A20")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly bool IsSingleProcessor;
	}
}
