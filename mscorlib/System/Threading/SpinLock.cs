using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x02000213 RID: 531
	[Token(Token = "0x2000213")]
	[System.Diagnostics.DebuggerTypeProxy(typeof(SpinLock.SystemThreading_SpinLockDebugView))]
	[System.Diagnostics.DebuggerDisplay("IsHeld = {IsHeld}")]
	[System.Runtime.InteropServices.ComVisible(false)]
	public struct SpinLock
	{
		// Token: 0x06001241 RID: 4673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001241")]
		[Address(RVA = "0x4D5B180", Offset = "0x4D59D80", VA = "0x184D5B180")]
		public SpinLock(bool enableThreadOwnerTracking)
		{
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001242")]
		[Address(RVA = "0x4D5ADE0", Offset = "0x4D599E0", VA = "0x184D5ADE0")]
		public void Enter(ref bool lockTaken)
		{
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001243")]
		[Address(RVA = "0x4D5B070", Offset = "0x4D59C70", VA = "0x184D5B070")]
		public void TryEnter(int millisecondsTimeout, ref bool lockTaken)
		{
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001244")]
		[Address(RVA = "0x4D5A860", Offset = "0x4D59460", VA = "0x184D5A860")]
		private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken)
		{
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001245")]
		[Address(RVA = "0x4D5AD10", Offset = "0x4D59910", VA = "0x184D5AD10")]
		private void DecrementWaiters()
		{
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001246")]
		[Address(RVA = "0x4D5A630", Offset = "0x4D59230", VA = "0x184D5A630")]
		private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken)
		{
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001247")]
		[Address(RVA = "0x4D5AFE0", Offset = "0x4D59BE0", VA = "0x184D5AFE0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public void Exit(bool useMemoryBarrier)
		{
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001248")]
		[Address(RVA = "0x4D5AE90", Offset = "0x4D59A90", VA = "0x184D5AE90")]
		private void ExitSlowPath(bool useMemoryBarrier)
		{
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06001249 RID: 4681 RVA: 0x0000E868 File Offset: 0x0000CA68
		[Token(Token = "0x170001B4")]
		public bool IsHeldByCurrentThread
		{
			[Token(Token = "0x6001249")]
			[Address(RVA = "0x4D5B1C0", Offset = "0x4D59DC0", VA = "0x184D5B1C0")]
			[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600124A RID: 4682 RVA: 0x0000E880 File Offset: 0x0000CA80
		[Token(Token = "0x170001B5")]
		public bool IsThreadOwnerTrackingEnabled
		{
			[Token(Token = "0x600124A")]
			[Address(RVA = "0x4D5B2A0", Offset = "0x4D59EA0", VA = "0x184D5B2A0")]
			[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000A60 RID: 2656
		[Token(Token = "0x4000A60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int m_owner;

		// Token: 0x04000A61 RID: 2657
		[Token(Token = "0x4000A61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int MAXIMUM_WAITERS;

		// Token: 0x02000214 RID: 532
		[Token(Token = "0x2000214")]
		internal class SystemThreading_SpinLockDebugView
		{
		}
	}
}
