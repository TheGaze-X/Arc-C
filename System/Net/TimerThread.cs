using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002D8 RID: 728
	[Token(Token = "0x20002D8")]
	internal static class TimerThread
	{
		// Token: 0x0600142B RID: 5163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600142B")]
		[Address(RVA = "0x505DC70", Offset = "0x505C870", VA = "0x18505DC70")]
		internal static TimerThread.Queue CreateQueue(int durationMilliseconds)
		{
			return null;
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600142C")]
		[Address(RVA = "0x505DEC0", Offset = "0x505CAC0", VA = "0x18505DEC0")]
		internal static TimerThread.Queue GetOrCreateQueue(int durationMilliseconds)
		{
			return null;
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600142D")]
		[Address(RVA = "0x505E870", Offset = "0x505D470", VA = "0x18505E870")]
		private static void Prod()
		{
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600142E")]
		[Address(RVA = "0x505EA10", Offset = "0x505D610", VA = "0x18505EA10")]
		private static void ThreadProc()
		{
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600142F")]
		[Address(RVA = "0x505E990", Offset = "0x505D590", VA = "0x18505E990")]
		private static void StopTimerThread()
		{
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x00009858 File Offset: 0x00007A58
		[Token(Token = "0x6001430")]
		[Address(RVA = "0x505E790", Offset = "0x505D390", VA = "0x18505E790")]
		private static bool IsTickBetween(int start, int end, int comparand)
		{
			return default(bool);
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001431")]
		[Address(RVA = "0x505E7B0", Offset = "0x505D3B0", VA = "0x18505E7B0")]
		private static void OnDomainUnload(object sender, EventArgs e)
		{
		}

		// Token: 0x04000AE8 RID: 2792
		[Token(Token = "0x4000AE8")]
		[FieldOffset(Offset = "0x0")]
		private static LinkedList<WeakReference> s_Queues;

		// Token: 0x04000AE9 RID: 2793
		[Token(Token = "0x4000AE9")]
		[FieldOffset(Offset = "0x8")]
		private static LinkedList<WeakReference> s_NewQueues;

		// Token: 0x04000AEA RID: 2794
		[Token(Token = "0x4000AEA")]
		[FieldOffset(Offset = "0x10")]
		private static int s_ThreadState;

		// Token: 0x04000AEB RID: 2795
		[Token(Token = "0x4000AEB")]
		[FieldOffset(Offset = "0x18")]
		private static AutoResetEvent s_ThreadReadyEvent;

		// Token: 0x04000AEC RID: 2796
		[Token(Token = "0x4000AEC")]
		[FieldOffset(Offset = "0x20")]
		private static ManualResetEvent s_ThreadShutdownEvent;

		// Token: 0x04000AED RID: 2797
		[Token(Token = "0x4000AED")]
		[FieldOffset(Offset = "0x28")]
		private static WaitHandle[] s_ThreadEvents;

		// Token: 0x04000AEE RID: 2798
		[Token(Token = "0x4000AEE")]
		[FieldOffset(Offset = "0x30")]
		private static int s_CacheScanIteration;

		// Token: 0x04000AEF RID: 2799
		[Token(Token = "0x4000AEF")]
		[FieldOffset(Offset = "0x38")]
		private static Hashtable s_QueuesCache;

		// Token: 0x020002D9 RID: 729
		[Token(Token = "0x20002D9")]
		internal abstract class Queue
		{
			// Token: 0x06001432 RID: 5170 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001432")]
			[Address(RVA = "0x50EDE0", Offset = "0x50D9E0", VA = "0x18050EDE0")]
			internal Queue(int durationMilliseconds)
			{
			}

			// Token: 0x17000436 RID: 1078
			// (get) Token: 0x06001433 RID: 5171 RVA: 0x00009870 File Offset: 0x00007A70
			[Token(Token = "0x17000436")]
			internal int Duration
			{
				[Token(Token = "0x6001433")]
				[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06001434 RID: 5172
			[Token(Token = "0x6001434")]
			internal abstract TimerThread.Timer CreateTimer(TimerThread.Callback callback, object context);

			// Token: 0x04000AF0 RID: 2800
			[Token(Token = "0x4000AF0")]
			[FieldOffset(Offset = "0x10")]
			private readonly int m_DurationMilliseconds;
		}

		// Token: 0x020002DA RID: 730
		[Token(Token = "0x20002DA")]
		internal abstract class Timer : IDisposable
		{
			// Token: 0x06001435 RID: 5173 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001435")]
			[Address(RVA = "0x505F530", Offset = "0x505E130", VA = "0x18505F530")]
			internal Timer(int durationMilliseconds)
			{
			}

			// Token: 0x17000437 RID: 1079
			// (get) Token: 0x06001436 RID: 5174 RVA: 0x00009888 File Offset: 0x00007A88
			[Token(Token = "0x17000437")]
			internal int StartTime
			{
				[Token(Token = "0x6001436")]
				[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000438 RID: 1080
			// (get) Token: 0x06001437 RID: 5175 RVA: 0x000098A0 File Offset: 0x00007AA0
			[Token(Token = "0x17000438")]
			internal int Expiration
			{
				[Token(Token = "0x6001437")]
				[Address(RVA = "0x505F560", Offset = "0x505E160", VA = "0x18505F560")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06001438 RID: 5176
			[Token(Token = "0x6001438")]
			internal abstract bool Cancel();

			// Token: 0x17000439 RID: 1081
			// (get) Token: 0x06001439 RID: 5177
			[Token(Token = "0x17000439")]
			internal abstract bool HasExpired { [Token(Token = "0x6001439")] get; }

			// Token: 0x0600143A RID: 5178 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600143A")]
			[Address(RVA = "0x505F4F0", Offset = "0x505E0F0", VA = "0x18505F4F0", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x04000AF1 RID: 2801
			[Token(Token = "0x4000AF1")]
			[FieldOffset(Offset = "0x10")]
			private readonly int m_StartTimeMilliseconds;

			// Token: 0x04000AF2 RID: 2802
			[Token(Token = "0x4000AF2")]
			[FieldOffset(Offset = "0x14")]
			private readonly int m_DurationMilliseconds;
		}

		// Token: 0x020002DB RID: 731
		// (Invoke) Token: 0x0600143C RID: 5180
		[Token(Token = "0x20002DB")]
		internal delegate void Callback(TimerThread.Timer timer, int timeNoticed, object context);

		// Token: 0x020002DC RID: 732
		[Token(Token = "0x20002DC")]
		private class TimerQueue : TimerThread.Queue
		{
			// Token: 0x0600143D RID: 5181 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600143D")]
			[Address(RVA = "0x505DBB0", Offset = "0x505C7B0", VA = "0x18505DBB0")]
			internal TimerQueue(int durationMilliseconds)
			{
			}

			// Token: 0x0600143E RID: 5182 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600143E")]
			[Address(RVA = "0x505D650", Offset = "0x505C250", VA = "0x18505D650", Slot = "4")]
			internal override TimerThread.Timer CreateTimer(TimerThread.Callback callback, object context)
			{
				return null;
			}

			// Token: 0x0600143F RID: 5183 RVA: 0x000098B8 File Offset: 0x00007AB8
			[Token(Token = "0x600143F")]
			[Address(RVA = "0x505D9D0", Offset = "0x505C5D0", VA = "0x18505D9D0")]
			internal bool Fire(out int nextExpiration)
			{
				return default(bool);
			}

			// Token: 0x04000AF3 RID: 2803
			[Token(Token = "0x4000AF3")]
			[FieldOffset(Offset = "0x18")]
			private IntPtr m_ThisHandle;

			// Token: 0x04000AF4 RID: 2804
			[Token(Token = "0x4000AF4")]
			[FieldOffset(Offset = "0x20")]
			private readonly TimerThread.TimerNode m_Timers;
		}

		// Token: 0x020002DD RID: 733
		[Token(Token = "0x20002DD")]
		private class InfiniteTimerQueue : TimerThread.Queue
		{
			// Token: 0x06001440 RID: 5184 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001440")]
			[Address(RVA = "0x4A42200", Offset = "0x4A40E00", VA = "0x184A42200")]
			internal InfiniteTimerQueue()
			{
			}

			// Token: 0x06001441 RID: 5185 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001441")]
			[Address(RVA = "0x505A170", Offset = "0x5058D70", VA = "0x18505A170", Slot = "4")]
			internal override TimerThread.Timer CreateTimer(TimerThread.Callback callback, object context)
			{
				return null;
			}
		}

		// Token: 0x020002DE RID: 734
		[Token(Token = "0x20002DE")]
		private class TimerNode : TimerThread.Timer
		{
			// Token: 0x06001442 RID: 5186 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001442")]
			[Address(RVA = "0x505D5B0", Offset = "0x505C1B0", VA = "0x18505D5B0")]
			internal TimerNode(TimerThread.Callback callback, object context, int durationMilliseconds, object queueLock)
			{
			}

			// Token: 0x06001443 RID: 5187 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001443")]
			[Address(RVA = "0x505D580", Offset = "0x505C180", VA = "0x18505D580")]
			internal TimerNode()
			{
			}

			// Token: 0x1700043A RID: 1082
			// (get) Token: 0x06001444 RID: 5188 RVA: 0x000098D0 File Offset: 0x00007AD0
			[Token(Token = "0x1700043A")]
			internal override bool HasExpired
			{
				[Token(Token = "0x6001444")]
				[Address(RVA = "0x505D640", Offset = "0x505C240", VA = "0x18505D640", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700043B RID: 1083
			// (get) Token: 0x06001445 RID: 5189 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06001446 RID: 5190 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700043B")]
			internal TimerThread.TimerNode Next
			{
				[Token(Token = "0x6001445")]
				[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
				get
				{
					return null;
				}
				[Token(Token = "0x6001446")]
				[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
				set
				{
				}
			}

			// Token: 0x1700043C RID: 1084
			// (get) Token: 0x06001447 RID: 5191 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06001448 RID: 5192 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700043C")]
			internal TimerThread.TimerNode Prev
			{
				[Token(Token = "0x6001447")]
				[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
				get
				{
					return null;
				}
				[Token(Token = "0x6001448")]
				[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
				set
				{
				}
			}

			// Token: 0x06001449 RID: 5193 RVA: 0x000098E8 File Offset: 0x00007AE8
			[Token(Token = "0x6001449")]
			[Address(RVA = "0x505D1D0", Offset = "0x505BDD0", VA = "0x18505D1D0", Slot = "5")]
			internal override bool Cancel()
			{
				return default(bool);
			}

			// Token: 0x0600144A RID: 5194 RVA: 0x00009900 File Offset: 0x00007B00
			[Token(Token = "0x600144A")]
			[Address(RVA = "0x505D320", Offset = "0x505BF20", VA = "0x18505D320")]
			internal bool Fire()
			{
				return default(bool);
			}

			// Token: 0x04000AF5 RID: 2805
			[Token(Token = "0x4000AF5")]
			[FieldOffset(Offset = "0x18")]
			private TimerThread.TimerNode.TimerState m_TimerState;

			// Token: 0x04000AF6 RID: 2806
			[Token(Token = "0x4000AF6")]
			[FieldOffset(Offset = "0x20")]
			private TimerThread.Callback m_Callback;

			// Token: 0x04000AF7 RID: 2807
			[Token(Token = "0x4000AF7")]
			[FieldOffset(Offset = "0x28")]
			private object m_Context;

			// Token: 0x04000AF8 RID: 2808
			[Token(Token = "0x4000AF8")]
			[FieldOffset(Offset = "0x30")]
			private object m_QueueLock;

			// Token: 0x04000AF9 RID: 2809
			[Token(Token = "0x4000AF9")]
			[FieldOffset(Offset = "0x38")]
			private TimerThread.TimerNode next;

			// Token: 0x04000AFA RID: 2810
			[Token(Token = "0x4000AFA")]
			[FieldOffset(Offset = "0x40")]
			private TimerThread.TimerNode prev;

			// Token: 0x020002DF RID: 735
			[Token(Token = "0x20002DF")]
			private enum TimerState
			{
				// Token: 0x04000AFC RID: 2812
				[Token(Token = "0x4000AFC")]
				Ready,
				// Token: 0x04000AFD RID: 2813
				[Token(Token = "0x4000AFD")]
				Fired,
				// Token: 0x04000AFE RID: 2814
				[Token(Token = "0x4000AFE")]
				Cancelled,
				// Token: 0x04000AFF RID: 2815
				[Token(Token = "0x4000AFF")]
				Sentinel
			}
		}

		// Token: 0x020002E0 RID: 736
		[Token(Token = "0x20002E0")]
		private class InfiniteTimer : TimerThread.Timer
		{
			// Token: 0x0600144B RID: 5195 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600144B")]
			[Address(RVA = "0x505A1F0", Offset = "0x5058DF0", VA = "0x18505A1F0")]
			internal InfiniteTimer()
			{
			}

			// Token: 0x1700043D RID: 1085
			// (get) Token: 0x0600144C RID: 5196 RVA: 0x00009918 File Offset: 0x00007B18
			[Token(Token = "0x1700043D")]
			internal override bool HasExpired
			{
				[Token(Token = "0x600144C")]
				[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600144D RID: 5197 RVA: 0x00009930 File Offset: 0x00007B30
			[Token(Token = "0x600144D")]
			[Address(RVA = "0x505A1D0", Offset = "0x5058DD0", VA = "0x18505A1D0", Slot = "5")]
			internal override bool Cancel()
			{
				return default(bool);
			}

			// Token: 0x04000B00 RID: 2816
			[Token(Token = "0x4000B00")]
			[FieldOffset(Offset = "0x18")]
			private int cancelled;
		}
	}
}
