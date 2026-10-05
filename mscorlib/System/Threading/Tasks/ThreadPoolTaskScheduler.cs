using System;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x0200027A RID: 634
	[Token(Token = "0x200027A")]
	internal sealed class ThreadPoolTaskScheduler : TaskScheduler
	{
		// Token: 0x06001511 RID: 5393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001511")]
		[Address(RVA = "0x4AEDEF0", Offset = "0x4AECAF0", VA = "0x184AEDEF0")]
		internal ThreadPoolTaskScheduler()
		{
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001512")]
		[Address(RVA = "0x4AEDA50", Offset = "0x4AEC650", VA = "0x184AEDA50", Slot = "4")]
		protected internal override void QueueTask(Task task)
		{
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x0000F768 File Offset: 0x0000D968
		[Token(Token = "0x6001513")]
		[Address(RVA = "0x4AEDD00", Offset = "0x4AEC900", VA = "0x184AEDD00", Slot = "5")]
		protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
		{
			return default(bool);
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x0000F780 File Offset: 0x0000D980
		[Token(Token = "0x6001514")]
		[Address(RVA = "0x4AEDCF0", Offset = "0x4AEC8F0", VA = "0x184AEDCF0", Slot = "6")]
		protected internal override bool TryDequeue(Task task)
		{
			return default(bool);
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001515")]
		[Address(RVA = "0x4AEDA30", Offset = "0x4AEC630", VA = "0x184AEDA30", Slot = "7")]
		internal override void NotifyWorkItemProgress()
		{
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06001516 RID: 5398 RVA: 0x0000F798 File Offset: 0x0000D998
		[Token(Token = "0x17000210")]
		internal override bool RequiresAtomicStartTransition
		{
			[Token(Token = "0x6001516")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000BBE RID: 3006
		[Token(Token = "0x4000BBE")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ParameterizedThreadStart s_longRunningThreadWork;
	}
}
