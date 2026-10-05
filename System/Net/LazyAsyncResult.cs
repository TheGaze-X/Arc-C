using System;
using System.Threading;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002D4 RID: 724
	[Token(Token = "0x20002D4")]
	internal class LazyAsyncResult : IAsyncResult
	{
		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06001411 RID: 5137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700042D")]
		private static LazyAsyncResult.ThreadContext CurrentThreadContext
		{
			[Token(Token = "0x6001411")]
			[Address(RVA = "0x505B2C0", Offset = "0x5059EC0", VA = "0x18505B2C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001412")]
		[Address(RVA = "0x505B130", Offset = "0x5059D30", VA = "0x18505B130")]
		internal LazyAsyncResult(object myObject, object myState, AsyncCallback myCallBack)
		{
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06001413 RID: 5139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700042E")]
		internal object AsyncObject
		{
			[Token(Token = "0x6001413")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700042F")]
		public object AsyncState
		{
			[Token(Token = "0x6001414")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001415 RID: 5141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000430")]
		protected AsyncCallback AsyncCallback
		{
			[Token(Token = "0x6001415")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000431")]
		public WaitHandle AsyncWaitHandle
		{
			[Token(Token = "0x6001416")]
			[Address(RVA = "0x505B1F0", Offset = "0x5059DF0", VA = "0x18505B1F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x000097E0 File Offset: 0x000079E0
		[Token(Token = "0x6001417")]
		[Address(RVA = "0x505AB10", Offset = "0x5059710", VA = "0x18505AB10")]
		private bool LazilyCreateEvent(out ManualResetEvent waitHandle)
		{
			return default(bool);
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x000097F8 File Offset: 0x000079F8
		[Token(Token = "0x17000432")]
		public bool CompletedSynchronously
		{
			[Token(Token = "0x6001418")]
			[Address(RVA = "0x505B290", Offset = "0x5059E90", VA = "0x18505B290", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001419 RID: 5145 RVA: 0x00009810 File Offset: 0x00007A10
		[Token(Token = "0x17000433")]
		public bool IsCompleted
		{
			[Token(Token = "0x6001419")]
			[Address(RVA = "0x505B370", Offset = "0x5059F70", VA = "0x18505B370", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x00009828 File Offset: 0x00007A28
		[Token(Token = "0x17000434")]
		internal bool InternalPeekCompleted
		{
			[Token(Token = "0x600141A")]
			[Address(RVA = "0x505B360", Offset = "0x5059F60", VA = "0x18505B360")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x00009840 File Offset: 0x00007A40
		// (set) Token: 0x0600141C RID: 5148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000435")]
		internal bool EndCalled
		{
			[Token(Token = "0x600141B")]
			[Address(RVA = "0x2033950", Offset = "0x2032550", VA = "0x182033950")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600141C")]
			[Address(RVA = "0x2033A00", Offset = "0x2032600", VA = "0x182033A00")]
			set
			{
			}
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600141D")]
		[Address(RVA = "0x505ACB0", Offset = "0x50598B0", VA = "0x18505ACB0")]
		protected void ProtectedInvokeCallback(object result, IntPtr userToken)
		{
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600141E")]
		[Address(RVA = "0x505AAB0", Offset = "0x50596B0", VA = "0x18505AAB0")]
		internal void InvokeCallback(object result)
		{
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600141F")]
		[Address(RVA = "0x505AA60", Offset = "0x5059660", VA = "0x18505AA60")]
		internal void InvokeCallback()
		{
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001420")]
		[Address(RVA = "0x505A870", Offset = "0x5059470", VA = "0x18505A870", Slot = "8")]
		protected virtual void Complete(IntPtr userToken)
		{
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001421")]
		[Address(RVA = "0x505B080", Offset = "0x5059C80", VA = "0x18505B080")]
		private void WorkerThreadComplete(object state)
		{
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001422")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
		protected virtual void Cleanup()
		{
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001423")]
		[Address(RVA = "0x505AA50", Offset = "0x5059650", VA = "0x18505AA50")]
		internal object InternalWaitForCompletion()
		{
			return null;
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001424")]
		[Address(RVA = "0x505AE60", Offset = "0x5059A60", VA = "0x18505AE60")]
		private object WaitForCompletion(bool snap)
		{
			return null;
		}

		// Token: 0x04000ADC RID: 2780
		[Token(Token = "0x4000ADC")]
		[ThreadStatic]
		private static LazyAsyncResult.ThreadContext t_ThreadContext;

		// Token: 0x04000ADD RID: 2781
		[Token(Token = "0x4000ADD")]
		[FieldOffset(Offset = "0x10")]
		private object m_AsyncObject;

		// Token: 0x04000ADE RID: 2782
		[Token(Token = "0x4000ADE")]
		[FieldOffset(Offset = "0x18")]
		private object m_AsyncState;

		// Token: 0x04000ADF RID: 2783
		[Token(Token = "0x4000ADF")]
		[FieldOffset(Offset = "0x20")]
		private AsyncCallback m_AsyncCallback;

		// Token: 0x04000AE0 RID: 2784
		[Token(Token = "0x4000AE0")]
		[FieldOffset(Offset = "0x28")]
		private object m_Result;

		// Token: 0x04000AE1 RID: 2785
		[Token(Token = "0x4000AE1")]
		[FieldOffset(Offset = "0x30")]
		private int m_IntCompleted;

		// Token: 0x04000AE2 RID: 2786
		[Token(Token = "0x4000AE2")]
		[FieldOffset(Offset = "0x34")]
		private bool m_EndCalled;

		// Token: 0x04000AE3 RID: 2787
		[Token(Token = "0x4000AE3")]
		[FieldOffset(Offset = "0x35")]
		private bool m_UserEvent;

		// Token: 0x04000AE4 RID: 2788
		[Token(Token = "0x4000AE4")]
		[FieldOffset(Offset = "0x38")]
		private object m_Event;

		// Token: 0x020002D5 RID: 725
		[Token(Token = "0x20002D5")]
		private class ThreadContext
		{
			// Token: 0x06001425 RID: 5157 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001425")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ThreadContext()
			{
			}

			// Token: 0x04000AE5 RID: 2789
			[Token(Token = "0x4000AE5")]
			[FieldOffset(Offset = "0x10")]
			internal int m_NestedIOCount;
		}
	}
}
