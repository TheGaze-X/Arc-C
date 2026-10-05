using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x02000280 RID: 640
	[Token(Token = "0x2000280")]
	[FriendAccessAllowed]
	internal static class AsyncCausalityTracer
	{
		// Token: 0x17000211 RID: 529
		// (get) Token: 0x0600151B RID: 5403 RVA: 0x0000F7B0 File Offset: 0x0000D9B0
		[Token(Token = "0x17000211")]
		[FriendAccessAllowed]
		internal static bool LoggingOn
		{
			[Token(Token = "0x600151B")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
			[FriendAccessAllowed]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600151C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[FriendAccessAllowed]
		[MethodImpl(8)]
		internal static void TraceOperationCreation(CausalityTraceLevel traceLevel, int taskId, string operationName, ulong relatedContext)
		{
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600151D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[FriendAccessAllowed]
		[MethodImpl(8)]
		internal static void TraceOperationCompletion(CausalityTraceLevel traceLevel, int taskId, AsyncCausalityStatus status)
		{
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600151E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[MethodImpl(8)]
		internal static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, int taskId, CausalitySynchronousWork work)
		{
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600151F")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[MethodImpl(8)]
		internal static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work)
		{
		}
	}
}
