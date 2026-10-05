using System;
using System.Diagnostics.Tracing;
using Il2CppDummyDll;

namespace System.Collections.Concurrent
{
	// Token: 0x020005EB RID: 1515
	[Token(Token = "0x20005EB")]
	[System.Diagnostics.Tracing.EventSource(Name = "System.Collections.Concurrent.ConcurrentCollectionsEventSource", Guid = "35167F8E-49B2-4b96-AB86-435B59336B5E")]
	internal sealed class CDSCollectionETWBCLProvider : System.Diagnostics.Tracing.EventSource
	{
		// Token: 0x06002D6B RID: 11627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D6B")]
		[Address(RVA = "0x4C5AE20", Offset = "0x4C59A20", VA = "0x184C5AE20")]
		private CDSCollectionETWBCLProvider()
		{
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D6C")]
		[Address(RVA = "0x3CF2790", Offset = "0x3CF1390", VA = "0x183CF2790")]
		[System.Diagnostics.Tracing.Event(3, Level = System.Diagnostics.Tracing.EventLevel.Warning)]
		public void ConcurrentDictionary_AcquiringAllLocks(int numOfBuckets)
		{
		}

		// Token: 0x04001A03 RID: 6659
		[Token(Token = "0x4001A03")]
		[FieldOffset(Offset = "0x0")]
		public static CDSCollectionETWBCLProvider Log;
	}
}
