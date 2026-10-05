using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x020001FD RID: 509
	[Token(Token = "0x20001FD")]
	[System.Diagnostics.DebuggerDisplay("Set = {IsSet}")]
	public class ManualResetEventSlim : System.IDisposable
	{
		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060011CB RID: 4555 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001A0")]
		public WaitHandle WaitHandle
		{
			[Token(Token = "0x60011CB")]
			[Address(RVA = "0x4D56FA0", Offset = "0x4D55BA0", VA = "0x184D56FA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060011CC RID: 4556 RVA: 0x0000E568 File Offset: 0x0000C768
		// (set) Token: 0x060011CD RID: 4557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A1")]
		public bool IsSet
		{
			[Token(Token = "0x60011CC")]
			[Address(RVA = "0x4D56EE0", Offset = "0x4D55AE0", VA = "0x184D56EE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60011CD")]
			[Address(RVA = "0x4D57090", Offset = "0x4D55C90", VA = "0x184D57090")]
			private set
			{
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x0000E580 File Offset: 0x0000C780
		// (set) Token: 0x060011CF RID: 4559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A2")]
		public int SpinCount
		{
			[Token(Token = "0x60011CE")]
			[Address(RVA = "0x4D56F40", Offset = "0x4D55B40", VA = "0x184D56F40")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60011CF")]
			[Address(RVA = "0x4D570C0", Offset = "0x4D55CC0", VA = "0x184D570C0")]
			private set
			{
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060011D0 RID: 4560 RVA: 0x0000E598 File Offset: 0x0000C798
		// (set) Token: 0x060011D1 RID: 4561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A3")]
		private int Waiters
		{
			[Token(Token = "0x60011D0")]
			[Address(RVA = "0x4D57040", Offset = "0x4D55C40", VA = "0x184D57040")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60011D1")]
			[Address(RVA = "0x4D57100", Offset = "0x4D55D00", VA = "0x184D57100")]
			set
			{
			}
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011D2")]
		[Address(RVA = "0x4D56CA0", Offset = "0x4D558A0", VA = "0x184D56CA0")]
		public ManualResetEventSlim(bool initialState)
		{
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011D3")]
		[Address(RVA = "0x4D56DA0", Offset = "0x4D559A0", VA = "0x184D56DA0")]
		public ManualResetEventSlim(bool initialState, int spinCount)
		{
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011D4")]
		[Address(RVA = "0x4D55A90", Offset = "0x4D54690", VA = "0x184D55A90")]
		private void Initialize(bool initialState, int spinCount)
		{
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011D5")]
		[Address(RVA = "0x4D559F0", Offset = "0x4D545F0", VA = "0x184D559F0")]
		private void EnsureLockObjectCreated()
		{
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x0000E5B0 File Offset: 0x0000C7B0
		[Token(Token = "0x60011D6")]
		[Address(RVA = "0x4D55B50", Offset = "0x4D54750", VA = "0x184D55B50")]
		private bool LazyInitializeEvent()
		{
			return default(bool);
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011D7")]
		[Address(RVA = "0x4D55E90", Offset = "0x4D54A90", VA = "0x184D55E90")]
		public void Set()
		{
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011D8")]
		[Address(RVA = "0x4D55EA0", Offset = "0x4D54AA0", VA = "0x184D55EA0")]
		private void Set(bool duringCancellation)
		{
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x0000E5C8 File Offset: 0x0000C7C8
		[Token(Token = "0x60011D9")]
		[Address(RVA = "0x4D563C0", Offset = "0x4D54FC0", VA = "0x184D563C0")]
		public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			return default(bool);
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011DA")]
		[Address(RVA = "0x4D55820", Offset = "0x4D54420", VA = "0x184D55820", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011DB")]
		[Address(RVA = "0x4D55890", Offset = "0x4D54490", VA = "0x184D55890", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011DC")]
		[Address(RVA = "0x4D56240", Offset = "0x4D54E40", VA = "0x184D56240")]
		private void ThrowIfDisposed()
		{
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011DD")]
		[Address(RVA = "0x4D555D0", Offset = "0x4D541D0", VA = "0x184D555D0")]
		private static void CancellationTokenCallback(object obj)
		{
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011DE")]
		[Address(RVA = "0x4D562B0", Offset = "0x4D54EB0", VA = "0x184D562B0")]
		private void UpdateStateAtomically(int newBits, int updateBitsMask)
		{
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x0000E5E0 File Offset: 0x0000C7E0
		[Token(Token = "0x60011DF")]
		[Address(RVA = "0x4D55A70", Offset = "0x4D54670", VA = "0x184D55A70")]
		private static int ExtractStatePortionAndShiftRight(int state, int mask, int rightBitShiftCount)
		{
			return 0;
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x0000E5F8 File Offset: 0x0000C7F8
		[Token(Token = "0x60011E0")]
		[Address(RVA = "0x4D55A80", Offset = "0x4D54680", VA = "0x184D55A80")]
		private static int ExtractStatePortion(int state, int mask)
		{
			return 0;
		}

		// Token: 0x04000A09 RID: 2569
		[Token(Token = "0x4000A09")]
		private const int DEFAULT_SPIN_SP = 1;

		// Token: 0x04000A0A RID: 2570
		[Token(Token = "0x4000A0A")]
		[FieldOffset(Offset = "0x10")]
		private object m_lock;

		// Token: 0x04000A0B RID: 2571
		[Token(Token = "0x4000A0B")]
		[FieldOffset(Offset = "0x18")]
		private ManualResetEvent m_eventObj;

		// Token: 0x04000A0C RID: 2572
		[Token(Token = "0x4000A0C")]
		[FieldOffset(Offset = "0x20")]
		private int m_combinedState;

		// Token: 0x04000A0D RID: 2573
		[Token(Token = "0x4000A0D")]
		private const int SignalledState_BitMask = -2147483648;

		// Token: 0x04000A0E RID: 2574
		[Token(Token = "0x4000A0E")]
		private const int SignalledState_ShiftCount = 31;

		// Token: 0x04000A0F RID: 2575
		[Token(Token = "0x4000A0F")]
		private const int Dispose_BitMask = 1073741824;

		// Token: 0x04000A10 RID: 2576
		[Token(Token = "0x4000A10")]
		private const int SpinCountState_BitMask = 1073217536;

		// Token: 0x04000A11 RID: 2577
		[Token(Token = "0x4000A11")]
		private const int SpinCountState_ShiftCount = 19;

		// Token: 0x04000A12 RID: 2578
		[Token(Token = "0x4000A12")]
		private const int SpinCountState_MaxValue = 2047;

		// Token: 0x04000A13 RID: 2579
		[Token(Token = "0x4000A13")]
		private const int NumWaitersState_BitMask = 524287;

		// Token: 0x04000A14 RID: 2580
		[Token(Token = "0x4000A14")]
		private const int NumWaitersState_ShiftCount = 0;

		// Token: 0x04000A15 RID: 2581
		[Token(Token = "0x4000A15")]
		private const int NumWaitersState_MaxValue = 524287;

		// Token: 0x04000A16 RID: 2582
		[Token(Token = "0x4000A16")]
		[FieldOffset(Offset = "0x0")]
		private static System.Action<object> s_cancellationTokenCallback;
	}
}
