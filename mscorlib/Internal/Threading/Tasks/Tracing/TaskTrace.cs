using System;
using Il2CppDummyDll;
using Internal.Runtime.Augments;

namespace Internal.Threading.Tasks.Tracing
{
	// Token: 0x0200008C RID: 140
	[Token(Token = "0x200008C")]
	internal static class TaskTrace
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000282 RID: 642 RVA: 0x000032D0 File Offset: 0x000014D0
		[Token(Token = "0x1700003D")]
		public static bool Enabled
		{
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x4BFB230", Offset = "0x4BF9E30", VA = "0x184BFB230")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x4BFB050", Offset = "0x4BF9C50", VA = "0x184BFB050")]
		public static void TaskWaitBegin_Asynchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID)
		{
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x4BFB0F0", Offset = "0x4BF9CF0", VA = "0x184BFB0F0")]
		public static void TaskWaitBegin_Synchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID)
		{
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x4BFB190", Offset = "0x4BF9D90", VA = "0x184BFB190")]
		public static void TaskWaitEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID)
		{
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x4BFAF90", Offset = "0x4BF9B90", VA = "0x184BFAF90")]
		public static void TaskScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, int CreatingTaskID, int TaskCreationOptions)
		{
		}

		// Token: 0x04000265 RID: 613
		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x0")]
		private static TaskTraceCallbacks s_callbacks;
	}
}
