using System;
using System.Diagnostics.Tracing;
using Il2CppDummyDll;

namespace System.Buffers
{
	// Token: 0x02000636 RID: 1590
	[Token(Token = "0x2000636")]
	[System.Diagnostics.Tracing.EventSource(Guid = "0866B2B8-5CEF-5DB9-2612-0C0FFD814A44", Name = "System.Buffers.ArrayPoolEventSource")]
	internal sealed class ArrayPoolEventSource : System.Diagnostics.Tracing.EventSource
	{
		// Token: 0x06002FD5 RID: 12245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD5")]
		[Address(RVA = "0x4C5A810", Offset = "0x4C59410", VA = "0x184C5A810")]
		private ArrayPoolEventSource()
		{
		}

		// Token: 0x06002FD6 RID: 12246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD6")]
		[Address(RVA = "0x4C5A490", Offset = "0x4C59090", VA = "0x184C5A490")]
		[System.Diagnostics.Tracing.Event(1, Level = System.Diagnostics.Tracing.EventLevel.Verbose)]
		internal void BufferRented(int bufferId, int bufferSize, int poolId, int bucketId)
		{
		}

		// Token: 0x06002FD7 RID: 12247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD7")]
		[Address(RVA = "0x4C5A3B0", Offset = "0x4C58FB0", VA = "0x184C5A3B0")]
		[System.Diagnostics.Tracing.Event(2, Level = System.Diagnostics.Tracing.EventLevel.Informational)]
		internal void BufferAllocated(int bufferId, int bufferSize, int poolId, int bucketId, ArrayPoolEventSource.BufferAllocatedReason reason)
		{
		}

		// Token: 0x06002FD8 RID: 12248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD8")]
		[Address(RVA = "0x4C5A560", Offset = "0x4C59160", VA = "0x184C5A560")]
		[System.Diagnostics.Tracing.Event(3, Level = System.Diagnostics.Tracing.EventLevel.Verbose)]
		internal void BufferReturned(int bufferId, int bufferSize, int poolId)
		{
		}

		// Token: 0x06002FD9 RID: 12249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD9")]
		[Address(RVA = "0x4C5A6C0", Offset = "0x4C592C0", VA = "0x184C5A6C0")]
		[System.Diagnostics.Tracing.Event(4, Level = System.Diagnostics.Tracing.EventLevel.Informational)]
		internal void BufferTrimmed(int bufferId, int bufferSize, int poolId)
		{
		}

		// Token: 0x06002FDA RID: 12250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FDA")]
		[Address(RVA = "0x4C5A590", Offset = "0x4C59190", VA = "0x184C5A590")]
		[System.Diagnostics.Tracing.Event(5, Level = System.Diagnostics.Tracing.EventLevel.Informational)]
		internal void BufferTrimPoll(int milliseconds, int pressure)
		{
		}

		// Token: 0x04001A87 RID: 6791
		[Token(Token = "0x4001A87")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly ArrayPoolEventSource Log;

		// Token: 0x02000637 RID: 1591
		[Token(Token = "0x2000637")]
		internal enum BufferAllocatedReason
		{
			// Token: 0x04001A89 RID: 6793
			[Token(Token = "0x4001A89")]
			Pooled,
			// Token: 0x04001A8A RID: 6794
			[Token(Token = "0x4001A8A")]
			OverMaximumSize,
			// Token: 0x04001A8B RID: 6795
			[Token(Token = "0x4001A8B")]
			PoolExhausted
		}
	}
}
