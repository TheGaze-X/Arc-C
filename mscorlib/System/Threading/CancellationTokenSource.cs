using System;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x02000203 RID: 515
	[Token(Token = "0x2000203")]
	public class CancellationTokenSource : System.IDisposable
	{
		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060011F2 RID: 4594 RVA: 0x0000E6E8 File Offset: 0x0000C8E8
		[Token(Token = "0x170001A7")]
		public bool IsCancellationRequested
		{
			[Token(Token = "0x60011F2")]
			[Address(RVA = "0x4D4A690", Offset = "0x4D49290", VA = "0x184D4A690")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060011F3 RID: 4595 RVA: 0x0000E700 File Offset: 0x0000C900
		[Token(Token = "0x170001A8")]
		internal bool IsCancellationCompleted
		{
			[Token(Token = "0x60011F3")]
			[Address(RVA = "0x4D4A670", Offset = "0x4D49270", VA = "0x184D4A670")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060011F4 RID: 4596 RVA: 0x0000E718 File Offset: 0x0000C918
		[Token(Token = "0x170001A9")]
		internal bool IsDisposed
		{
			[Token(Token = "0x60011F4")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060011F5 RID: 4597 RVA: 0x0000E730 File Offset: 0x0000C930
		// (set) Token: 0x060011F6 RID: 4598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AA")]
		internal int ThreadIDExecutingCallbacks
		{
			[Token(Token = "0x60011F5")]
			[Address(RVA = "0x4D4A6B0", Offset = "0x4D492B0", VA = "0x184D4A6B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60011F6")]
			[Address(RVA = "0x4D4A730", Offset = "0x4D49330", VA = "0x184D4A730")]
			set
			{
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060011F7 RID: 4599 RVA: 0x0000E748 File Offset: 0x0000C948
		[Token(Token = "0x170001AB")]
		public CancellationToken Token
		{
			[Token(Token = "0x60011F7")]
			[Address(RVA = "0x4D4A6D0", Offset = "0x4D492D0", VA = "0x184D4A6D0")]
			get
			{
				return default(CancellationToken);
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060011F8 RID: 4600 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001AC")]
		internal CancellationCallbackInfo ExecutingCallback
		{
			[Token(Token = "0x60011F8")]
			[Address(RVA = "0x4C2EF70", Offset = "0x4C2DB70", VA = "0x184C2EF70")]
			get
			{
				return null;
			}
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F9")]
		[Address(RVA = "0x4D4A630", Offset = "0x4D49230", VA = "0x184D4A630")]
		public CancellationTokenSource()
		{
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011FA")]
		[Address(RVA = "0x4D49180", Offset = "0x4D47D80", VA = "0x184D49180")]
		public void Cancel()
		{
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011FB")]
		[Address(RVA = "0x4D49120", Offset = "0x4D47D20", VA = "0x184D49120")]
		public void Cancel(bool throwOnFirstException)
		{
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011FC")]
		[Address(RVA = "0x4D48F40", Offset = "0x4D47B40", VA = "0x184D48F40")]
		public void CancelAfter(int millisecondsDelay)
		{
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011FD")]
		[Address(RVA = "0x4D4A260", Offset = "0x4D48E60", VA = "0x184D4A260")]
		private static void TimerCallbackLogic(object obj)
		{
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011FE")]
		[Address(RVA = "0x4D49790", Offset = "0x4D48390", VA = "0x184D49790", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011FF")]
		[Address(RVA = "0x4D49800", Offset = "0x4D48400", VA = "0x184D49800", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001200")]
		[Address(RVA = "0x4D4A1B0", Offset = "0x4D48DB0", VA = "0x184D4A1B0")]
		internal void ThrowIfDisposed()
		{
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001201")]
		[Address(RVA = "0x4D4A200", Offset = "0x4D48E00", VA = "0x184D4A200")]
		private static void ThrowObjectDisposedException()
		{
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x0000E760 File Offset: 0x0000C960
		[Token(Token = "0x6001202")]
		[Address(RVA = "0x4D49D40", Offset = "0x4D48940", VA = "0x184D49D40")]
		internal CancellationTokenRegistration InternalRegister(System.Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext executionContext)
		{
			return default(CancellationTokenRegistration);
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001203")]
		[Address(RVA = "0x4D4A100", Offset = "0x4D48D00", VA = "0x184D4A100")]
		private void NotifyCancellation(bool throwOnFirstException)
		{
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001204")]
		[Address(RVA = "0x4D498B0", Offset = "0x4D484B0", VA = "0x184D498B0")]
		private void ExecuteCallbackHandlers(bool throwOnFirstException)
		{
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001205")]
		[Address(RVA = "0x4D491E0", Offset = "0x4D47DE0", VA = "0x184D491E0")]
		private void CancellationCallbackCoreWork_OnSyncContext(object obj)
		{
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001206")]
		[Address(RVA = "0x4D49260", Offset = "0x4D47E60", VA = "0x184D49260")]
		private void CancellationCallbackCoreWork(CancellationCallbackCoreWorkArguments args)
		{
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001207")]
		[Address(RVA = "0x4D49320", Offset = "0x4D47F20", VA = "0x184D49320")]
		public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2)
		{
			return null;
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001208")]
		[Address(RVA = "0x4D496B0", Offset = "0x4D482B0", VA = "0x184D496B0")]
		internal static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token)
		{
			return null;
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001209")]
		[Address(RVA = "0x4D4A380", Offset = "0x4D48F80", VA = "0x184D4A380")]
		internal void WaitForCallbackToComplete(CancellationCallbackInfo callbackInfo)
		{
		}

		// Token: 0x04000A23 RID: 2595
		[Token(Token = "0x4000A23")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly CancellationTokenSource s_canceledSource;

		// Token: 0x04000A24 RID: 2596
		[Token(Token = "0x4000A24")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly CancellationTokenSource s_neverCanceledSource;

		// Token: 0x04000A25 RID: 2597
		[Token(Token = "0x4000A25")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int s_nLists;

		// Token: 0x04000A26 RID: 2598
		[Token(Token = "0x4000A26")]
		[FieldOffset(Offset = "0x10")]
		private ManualResetEvent _kernelEvent;

		// Token: 0x04000A27 RID: 2599
		[Token(Token = "0x4000A27")]
		[FieldOffset(Offset = "0x18")]
		private SparselyPopulatedArray<CancellationCallbackInfo>[] _registeredCallbacksLists;

		// Token: 0x04000A28 RID: 2600
		[Token(Token = "0x4000A28")]
		private const int CannotBeCanceled = 0;

		// Token: 0x04000A29 RID: 2601
		[Token(Token = "0x4000A29")]
		private const int NotCanceledState = 1;

		// Token: 0x04000A2A RID: 2602
		[Token(Token = "0x4000A2A")]
		private const int NotifyingState = 2;

		// Token: 0x04000A2B RID: 2603
		[Token(Token = "0x4000A2B")]
		private const int NotifyingCompleteState = 3;

		// Token: 0x04000A2C RID: 2604
		[Token(Token = "0x4000A2C")]
		[FieldOffset(Offset = "0x20")]
		private int _state;

		// Token: 0x04000A2D RID: 2605
		[Token(Token = "0x4000A2D")]
		[FieldOffset(Offset = "0x24")]
		private int _threadIDExecutingCallbacks;

		// Token: 0x04000A2E RID: 2606
		[Token(Token = "0x4000A2E")]
		[FieldOffset(Offset = "0x28")]
		private bool _disposed;

		// Token: 0x04000A2F RID: 2607
		[Token(Token = "0x4000A2F")]
		[FieldOffset(Offset = "0x30")]
		private CancellationCallbackInfo _executingCallback;

		// Token: 0x04000A30 RID: 2608
		[Token(Token = "0x4000A30")]
		[FieldOffset(Offset = "0x38")]
		private Timer _timer;

		// Token: 0x04000A31 RID: 2609
		[Token(Token = "0x4000A31")]
		[FieldOffset(Offset = "0x18")]
		private static readonly TimerCallback s_timerCallback;

		// Token: 0x02000204 RID: 516
		[Token(Token = "0x2000204")]
		private sealed class Linked1CancellationTokenSource : CancellationTokenSource
		{
			// Token: 0x0600120B RID: 4619 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600120B")]
			[Address(RVA = "0x4D54F70", Offset = "0x4D53B70", VA = "0x184D54F70")]
			internal Linked1CancellationTokenSource(CancellationToken token1)
			{
			}

			// Token: 0x0600120C RID: 4620 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600120C")]
			[Address(RVA = "0x4D54F30", Offset = "0x4D53B30", VA = "0x184D54F30", Slot = "5")]
			protected override void Dispose(bool disposing)
			{
			}

			// Token: 0x04000A32 RID: 2610
			[Token(Token = "0x4000A32")]
			[FieldOffset(Offset = "0x40")]
			private readonly CancellationTokenRegistration _reg1;
		}

		// Token: 0x02000205 RID: 517
		[Token(Token = "0x2000205")]
		private sealed class Linked2CancellationTokenSource : CancellationTokenSource
		{
			// Token: 0x0600120D RID: 4621 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600120D")]
			[Address(RVA = "0x4D55100", Offset = "0x4D53D00", VA = "0x184D55100")]
			internal Linked2CancellationTokenSource(CancellationToken token1, CancellationToken token2)
			{
			}

			// Token: 0x0600120E RID: 4622 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600120E")]
			[Address(RVA = "0x4D550B0", Offset = "0x4D53CB0", VA = "0x184D550B0", Slot = "5")]
			protected override void Dispose(bool disposing)
			{
			}

			// Token: 0x04000A33 RID: 2611
			[Token(Token = "0x4000A33")]
			[FieldOffset(Offset = "0x40")]
			private readonly CancellationTokenRegistration _reg1;

			// Token: 0x04000A34 RID: 2612
			[Token(Token = "0x4000A34")]
			[FieldOffset(Offset = "0x58")]
			private readonly CancellationTokenRegistration _reg2;
		}

		// Token: 0x02000206 RID: 518
		[Token(Token = "0x2000206")]
		private sealed class LinkedNCancellationTokenSource : CancellationTokenSource
		{
			// Token: 0x04000A35 RID: 2613
			[Token(Token = "0x4000A35")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly System.Action<object> s_linkedTokenCancelDelegate;
		}
	}
}
