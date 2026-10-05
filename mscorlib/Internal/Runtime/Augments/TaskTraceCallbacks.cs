using System;
using Il2CppDummyDll;

namespace Internal.Runtime.Augments
{
	// Token: 0x0200008E RID: 142
	[Token(Token = "0x200008E")]
	internal abstract class TaskTraceCallbacks
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000287 RID: 647
		[Token(Token = "0x1700003E")]
		public abstract bool Enabled { [Token(Token = "0x6000287")] get; }

		// Token: 0x06000288 RID: 648
		[Token(Token = "0x6000288")]
		public abstract void TaskWaitBegin_Asynchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

		// Token: 0x06000289 RID: 649
		[Token(Token = "0x6000289")]
		public abstract void TaskWaitBegin_Synchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

		// Token: 0x0600028A RID: 650
		[Token(Token = "0x600028A")]
		public abstract void TaskWaitEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

		// Token: 0x0600028B RID: 651
		[Token(Token = "0x600028B")]
		public abstract void TaskScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, int CreatingTaskID, int TaskCreationOptions);
	}
}
