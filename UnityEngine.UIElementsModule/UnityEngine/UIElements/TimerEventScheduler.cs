using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	internal class TimerEventScheduler : IScheduler
	{
		// Token: 0x06000253 RID: 595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x5A406F0", Offset = "0x5A3F2F0", VA = "0x185A406F0", Slot = "5")]
		public void Schedule(ScheduledItem item)
		{
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002D78 File Offset: 0x00000F78
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x5A40670", Offset = "0x5A3F270", VA = "0x185A40670")]
		private bool RemovedScheduledItemAt(int index)
		{
			return default(bool);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x5A408E0", Offset = "0x5A3F4E0", VA = "0x185A408E0", Slot = "4")]
		public void Unschedule(ScheduledItem item)
		{
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002D90 File Offset: 0x00000F90
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x5A40590", Offset = "0x5A3F190", VA = "0x185A40590")]
		private bool PrivateUnSchedule(ScheduledItem sItem)
		{
			return default(bool);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x5A40BA0", Offset = "0x5A3F7A0", VA = "0x185A40BA0", Slot = "6")]
		public void UpdateScheduledEvents()
		{
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x5A411D0", Offset = "0x5A3FDD0", VA = "0x185A411D0")]
		public TimerEventScheduler()
		{
		}

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<ScheduledItem> m_ScheduledItems;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x18")]
		private bool m_TransactionMode;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<ScheduledItem> m_ScheduleTransactions;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x28")]
		private readonly HashSet<ScheduledItem> m_UnscheduleTransactions;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x30")]
		internal bool disableThrottling;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x34")]
		private int m_LastUpdatedIndex;
	}
}
