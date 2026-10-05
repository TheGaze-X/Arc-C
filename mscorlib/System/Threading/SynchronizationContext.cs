using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x0200021E RID: 542
	[Token(Token = "0x200021E")]
	public class SynchronizationContext
	{
		// Token: 0x06001297 RID: 4759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001297")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SynchronizationContext()
		{
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x0000EA90 File Offset: 0x0000CC90
		[Token(Token = "0x6001298")]
		[Address(RVA = "0xF5B8E0", Offset = "0xF5A4E0", VA = "0x180F5B8E0")]
		public bool IsWaitNotificationRequired()
		{
			return default(bool);
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001299")]
		[Address(RVA = "0x4D5B930", Offset = "0x4D5A530", VA = "0x184D5B930", Slot = "4")]
		public virtual void Send(SendOrPostCallback d, object state)
		{
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600129A")]
		[Address(RVA = "0x4D5B8A0", Offset = "0x4D5A4A0", VA = "0x184D5B8A0", Slot = "5")]
		public virtual void Post(SendOrPostCallback d, object state)
		{
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600129B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public virtual void OperationStarted()
		{
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600129C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		public virtual void OperationCompleted()
		{
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x0000EAA8 File Offset: 0x0000CCA8
		[Token(Token = "0x600129D")]
		[Address(RVA = "0x4D5BA60", Offset = "0x4D5A660", VA = "0x184D5BA60", Slot = "8")]
		[System.Runtime.ConstrainedExecution.PrePrepareMethod]
		[System.CLSCompliant(false)]
		public virtual int Wait(System.IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout)
		{
			return 0;
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x0000EAC0 File Offset: 0x0000CCC0
		[Token(Token = "0x600129E")]
		[Address(RVA = "0x4D5B9C0", Offset = "0x4D5A5C0", VA = "0x184D5B9C0")]
		[System.Runtime.ConstrainedExecution.PrePrepareMethod]
		[System.CLSCompliant(false)]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		protected static int WaitHelper(System.IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout)
		{
			return 0;
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600129F")]
		[Address(RVA = "0x4D5B960", Offset = "0x4D5A560", VA = "0x184D5B960")]
		public static void SetSynchronizationContext(SynchronizationContext syncContext)
		{
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060012A0 RID: 4768 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001C2")]
		public static SynchronizationContext Current
		{
			[Token(Token = "0x60012A0")]
			[Address(RVA = "0x4D5BB50", Offset = "0x4D5A750", VA = "0x184D5BB50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060012A1 RID: 4769 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001C3")]
		internal static SynchronizationContext CurrentNoFlow
		{
			[Token(Token = "0x60012A1")]
			[Address(RVA = "0x4D5BB90", Offset = "0x4D5A790", VA = "0x184D5BB90")]
			[FriendAccessAllowed]
			get
			{
				return null;
			}
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60012A2")]
		[Address(RVA = "0x4D5B6E0", Offset = "0x4D5A2E0", VA = "0x184D5B6E0")]
		private static SynchronizationContext GetThreadLocalContext()
		{
			return null;
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60012A3")]
		[Address(RVA = "0x4D5B690", Offset = "0x4D5A290", VA = "0x184D5B690", Slot = "9")]
		public virtual SynchronizationContext CreateCopy()
		{
			return null;
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060012A4 RID: 4772 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001C4")]
		internal static SynchronizationContext CurrentExplicit
		{
			[Token(Token = "0x60012A4")]
			[Address(RVA = "0x4D5BB50", Offset = "0x4D5A750", VA = "0x184D5BB50")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000A7C RID: 2684
		[Token(Token = "0x4000A7C")]
		[FieldOffset(Offset = "0x10")]
		private SynchronizationContextProperties _props;

		// Token: 0x04000A7D RID: 2685
		[Token(Token = "0x4000A7D")]
		[FieldOffset(Offset = "0x0")]
		private static System.Type s_cachedPreparedType1;

		// Token: 0x04000A7E RID: 2686
		[Token(Token = "0x4000A7E")]
		[FieldOffset(Offset = "0x8")]
		private static System.Type s_cachedPreparedType2;

		// Token: 0x04000A7F RID: 2687
		[Token(Token = "0x4000A7F")]
		[FieldOffset(Offset = "0x10")]
		private static System.Type s_cachedPreparedType3;

		// Token: 0x04000A80 RID: 2688
		[Token(Token = "0x4000A80")]
		[FieldOffset(Offset = "0x18")]
		private static System.Type s_cachedPreparedType4;

		// Token: 0x04000A81 RID: 2689
		[Token(Token = "0x4000A81")]
		[FieldOffset(Offset = "0x20")]
		private static System.Type s_cachedPreparedType5;
	}
}
