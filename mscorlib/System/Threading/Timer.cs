using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x0200023B RID: 571
	[Token(Token = "0x200023B")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public sealed class Timer : System.MarshalByRefObject, System.IDisposable
	{
		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06001375 RID: 4981 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001D6")]
		private static Timer.Scheduler scheduler
		{
			[Token(Token = "0x6001375")]
			[Address(RVA = "0x4AF18E0", Offset = "0x4AF04E0", VA = "0x184AF18E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001376")]
		[Address(RVA = "0x4AF16C0", Offset = "0x4AF02C0", VA = "0x184AF16C0")]
		public Timer(TimerCallback callback, object state, int dueTime, int period)
		{
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001377")]
		[Address(RVA = "0x4AF17A0", Offset = "0x4AF03A0", VA = "0x184AF17A0")]
		public Timer(TimerCallback callback, object state, System.TimeSpan dueTime, System.TimeSpan period)
		{
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001378")]
		[Address(RVA = "0x4AF1600", Offset = "0x4AF0200", VA = "0x184AF1600")]
		private void Init(TimerCallback callback, object state, long dueTime, long period)
		{
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x0000EEF8 File Offset: 0x0000D0F8
		[Token(Token = "0x6001379")]
		[Address(RVA = "0x4AF1500", Offset = "0x4AF0100", VA = "0x184AF1500")]
		public bool Change(int dueTime, int period)
		{
			return default(bool);
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x0000EF10 File Offset: 0x0000D110
		[Token(Token = "0x600137A")]
		[Address(RVA = "0x4AF1520", Offset = "0x4AF0120", VA = "0x184AF1520")]
		public bool Change(System.TimeSpan dueTime, System.TimeSpan period)
		{
			return default(bool);
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600137B")]
		[Address(RVA = "0x4AF15B0", Offset = "0x4AF01B0", VA = "0x184AF15B0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x0000EF28 File Offset: 0x0000D128
		[Token(Token = "0x600137C")]
		[Address(RVA = "0x4AF1260", Offset = "0x4AEFE60", VA = "0x184AF1260")]
		private bool Change(long dueTime, long period, bool first)
		{
			return default(bool);
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600137D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		internal void KeepRootedWhileScheduled()
		{
		}

		// Token: 0x0600137E RID: 4990
		[Token(Token = "0x600137E")]
		[Address(RVA = "0x4AF15F0", Offset = "0x4AF01F0", VA = "0x184AF15F0")]
		[MethodImpl(4096)]
		private static extern long GetTimeMonotonic();

		// Token: 0x04000AF7 RID: 2807
		[Token(Token = "0x4000AF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TimerCallback callback;

		// Token: 0x04000AF8 RID: 2808
		[Token(Token = "0x4000AF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private object state;

		// Token: 0x04000AF9 RID: 2809
		[Token(Token = "0x4000AF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private long due_time_ms;

		// Token: 0x04000AFA RID: 2810
		[Token(Token = "0x4000AFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private long period_ms;

		// Token: 0x04000AFB RID: 2811
		[Token(Token = "0x4000AFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private long next_run;

		// Token: 0x04000AFC RID: 2812
		[Token(Token = "0x4000AFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool disposed;

		// Token: 0x04000AFD RID: 2813
		[Token(Token = "0x4000AFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool is_dead;

		// Token: 0x04000AFE RID: 2814
		[Token(Token = "0x4000AFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		private bool is_added;

		// Token: 0x04000AFF RID: 2815
		[Token(Token = "0x4000AFF")]
		private const long MaxValue = 4294967294L;

		// Token: 0x0200023C RID: 572
		[Token(Token = "0x200023C")]
		private struct TimerComparer : System.Collections.IComparer, System.Collections.Generic.IComparer<Timer>
		{
			// Token: 0x0600137F RID: 4991 RVA: 0x0000EF40 File Offset: 0x0000D140
			[Token(Token = "0x600137F")]
			[Address(RVA = "0x4AF1170", Offset = "0x4AEFD70", VA = "0x184AF1170", Slot = "4")]
			private int Compare(object x, object y)
			{
				return 0;
			}

			// Token: 0x06001380 RID: 4992 RVA: 0x0000EF58 File Offset: 0x0000D158
			[Token(Token = "0x6001380")]
			[Address(RVA = "0x4AF1100", Offset = "0x4AEFD00", VA = "0x184AF1100", Slot = "5")]
			public int Compare(Timer tx, Timer ty)
			{
				return 0;
			}
		}

		// Token: 0x0200023D RID: 573
		[Token(Token = "0x200023D")]
		private sealed class Scheduler
		{
			// Token: 0x06001381 RID: 4993 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001381")]
			[Address(RVA = "0x4AE0840", Offset = "0x4ADF440", VA = "0x184AE0840")]
			private void InitScheduler()
			{
			}

			// Token: 0x06001382 RID: 4994 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001382")]
			[Address(RVA = "0x36A4B00", Offset = "0x36A3700", VA = "0x1836A4B00")]
			private void WakeupScheduler()
			{
			}

			// Token: 0x06001383 RID: 4995 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001383")]
			[Address(RVA = "0x4AE0DE0", Offset = "0x4ADF9E0", VA = "0x184AE0DE0")]
			private void SchedulerThread()
			{
			}

			// Token: 0x170001D7 RID: 471
			// (get) Token: 0x06001384 RID: 4996 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170001D7")]
			public static Timer.Scheduler Instance
			{
				[Token(Token = "0x6001384")]
				[Address(RVA = "0x4AE12B0", Offset = "0x4ADFEB0", VA = "0x184AE12B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06001385 RID: 4997 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001385")]
			[Address(RVA = "0x4AE10A0", Offset = "0x4ADFCA0", VA = "0x184AE10A0")]
			private Scheduler()
			{
			}

			// Token: 0x06001386 RID: 4998 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001386")]
			[Address(RVA = "0x4AE0A00", Offset = "0x4ADF600", VA = "0x184AE0A00")]
			public void Remove(Timer timer)
			{
			}

			// Token: 0x06001387 RID: 4999 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001387")]
			[Address(RVA = "0x4AE0530", Offset = "0x4ADF130", VA = "0x184AE0530")]
			public void Change(Timer timer, long new_next_run)
			{
			}

			// Token: 0x06001388 RID: 5000 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001388")]
			[Address(RVA = "0x4AE0440", Offset = "0x4ADF040", VA = "0x184AE0440")]
			private void Add(Timer timer)
			{
			}

			// Token: 0x06001389 RID: 5001 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001389")]
			[Address(RVA = "0x4AE09D0", Offset = "0x4ADF5D0", VA = "0x184AE09D0")]
			private void InternalRemove(Timer timer)
			{
			}

			// Token: 0x0600138A RID: 5002 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600138A")]
			[Address(RVA = "0x4AE0FB0", Offset = "0x4ADFBB0", VA = "0x184AE0FB0")]
			private static void TimerCB(object o)
			{
			}

			// Token: 0x0600138B RID: 5003 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600138B")]
			[Address(RVA = "0x4AE0780", Offset = "0x4ADF380", VA = "0x184AE0780")]
			private void FireTimer(Timer timer)
			{
			}

			// Token: 0x0600138C RID: 5004 RVA: 0x0000EF70 File Offset: 0x0000D170
			[Token(Token = "0x600138C")]
			[Address(RVA = "0x4AE0AA0", Offset = "0x4ADF6A0", VA = "0x184AE0AA0")]
			private int RunSchedulerLoop()
			{
				return 0;
			}

			// Token: 0x04000B00 RID: 2816
			[Token(Token = "0x4000B00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly Timer.Scheduler instance;

			// Token: 0x04000B01 RID: 2817
			[Token(Token = "0x4000B01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private bool needReSort;

			// Token: 0x04000B02 RID: 2818
			[Token(Token = "0x4000B02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private System.Collections.Generic.List<Timer> list;

			// Token: 0x04000B03 RID: 2819
			[Token(Token = "0x4000B03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private long current_next_run;

			// Token: 0x04000B04 RID: 2820
			[Token(Token = "0x4000B04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ManualResetEvent changed;
		}
	}
}
