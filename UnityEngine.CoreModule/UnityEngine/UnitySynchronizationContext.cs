using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000122 RID: 290
	[Token(Token = "0x2000122")]
	internal sealed class UnitySynchronizationContext : SynchronizationContext
	{
		// Token: 0x06000A50 RID: 2640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x5978D10", Offset = "0x5977910", VA = "0x185978D10")]
		private UnitySynchronizationContext(int mainThreadID)
		{
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x5978C50", Offset = "0x5977850", VA = "0x185978C50")]
		private UnitySynchronizationContext(List<UnitySynchronizationContext.WorkRequest> queue, int mainThreadID)
		{
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x59789A0", Offset = "0x59775A0", VA = "0x1859789A0", Slot = "4")]
		public override void Send(SendOrPostCallback callback, object state)
		{
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x5978810", Offset = "0x5977410", VA = "0x185978810", Slot = "6")]
		public override void OperationStarted()
		{
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x5978800", Offset = "0x5977400", VA = "0x185978800", Slot = "7")]
		public override void OperationCompleted()
		{
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x5978820", Offset = "0x5977420", VA = "0x185978820", Slot = "5")]
		public override void Post(SendOrPostCallback callback, object state)
		{
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x59781F0", Offset = "0x5976DF0", VA = "0x1859781F0", Slot = "9")]
		public override SynchronizationContext CreateCopy()
		{
			return null;
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x59782F0", Offset = "0x5976EF0", VA = "0x1859782F0")]
		private void Exec()
		{
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00005E38 File Offset: 0x00004038
		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x5978660", Offset = "0x5977260", VA = "0x185978660")]
		private bool HasPendingTasks()
		{
			return default(bool);
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x59786C0", Offset = "0x59772C0", VA = "0x1859786C0")]
		[RequiredByNativeCode]
		private static void InitializeSynchronizationContext()
		{
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x5978600", Offset = "0x5977200", VA = "0x185978600")]
		[RequiredByNativeCode]
		private static void ExecuteTasks()
		{
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00005E50 File Offset: 0x00004050
		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x59784A0", Offset = "0x59770A0", VA = "0x1859784A0")]
		[RequiredByNativeCode]
		private static bool ExecutePendingTasks(long millisecondsTimeout)
		{
			return default(bool);
		}

		// Token: 0x040004CE RID: 1230
		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue;

		// Token: 0x040004CF RID: 1231
		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork;

		// Token: 0x040004D0 RID: 1232
		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly int m_MainThreadID;

		// Token: 0x040004D1 RID: 1233
		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int m_TrackedCount;

		// Token: 0x02000123 RID: 291
		[Token(Token = "0x2000123")]
		private struct WorkRequest
		{
			// Token: 0x06000A5C RID: 2652 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A5C")]
			[Address(RVA = "0x17F8010", Offset = "0x17F6C10", VA = "0x1817F8010")]
			public WorkRequest(SendOrPostCallback callback, object state, [Optional] ManualResetEvent waitHandle)
			{
			}

			// Token: 0x06000A5D RID: 2653 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A5D")]
			[Address(RVA = "0x59795E0", Offset = "0x59781E0", VA = "0x1859795E0")]
			public void Invoke()
			{
			}

			// Token: 0x040004D2 RID: 1234
			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly SendOrPostCallback m_DelagateCallback;

			// Token: 0x040004D3 RID: 1235
			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly object m_DelagateState;

			// Token: 0x040004D4 RID: 1236
			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly ManualResetEvent m_WaitHandle;
		}
	}
}
