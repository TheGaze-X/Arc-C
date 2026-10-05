using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x02000273 RID: 627
	[Token(Token = "0x2000273")]
	internal class AwaitTaskContinuation : TaskContinuation, IThreadPoolWorkItem
	{
		// Token: 0x060014D7 RID: 5335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D7")]
		[Address(RVA = "0x4ADAD20", Offset = "0x4AD9920", VA = "0x184ADAD20")]
		internal AwaitTaskContinuation(System.Action action, bool flowExecutionContext)
		{
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60014D8")]
		[Address(RVA = "0x4ADA680", Offset = "0x4AD9280", VA = "0x184ADA680")]
		protected Task CreateTask(System.Action<object> action, object state, TaskScheduler scheduler)
		{
			return null;
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014D9")]
		[Address(RVA = "0x4ADAAE0", Offset = "0x4AD96E0", VA = "0x184ADAAE0", Slot = "4")]
		internal override void Run(Task ignored, bool canInlineContinuationTask)
		{
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060014DA RID: 5338 RVA: 0x0000F6A8 File Offset: 0x0000D8A8
		[Token(Token = "0x17000208")]
		internal static bool IsValidLocationForInlining
		{
			[Token(Token = "0x60014DA")]
			[Address(RVA = "0x4ADADB0", Offset = "0x4AD99B0", VA = "0x184ADADB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014DB")]
		[Address(RVA = "0x4ADABA0", Offset = "0x4AD97A0", VA = "0x184ADABA0", Slot = "5")]
		private void ExecuteWorkItem()
		{
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014DC")]
		[Address(RVA = "0x4ADA830", Offset = "0x4AD9430", VA = "0x184ADA830")]
		private static void InvokeAction(object state)
		{
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60014DD")]
		[Address(RVA = "0x4ADA780", Offset = "0x4AD9380", VA = "0x184ADA780")]
		[MethodImpl(256)]
		protected static ContextCallback GetInvokeActionCallback()
		{
			return null;
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014DE")]
		[Address(RVA = "0x4ADA8A0", Offset = "0x4AD94A0", VA = "0x184ADA8A0")]
		protected void RunCallback(ContextCallback callback, object state, ref Task currentTask)
		{
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014DF")]
		[Address(RVA = "0x4ADA9D0", Offset = "0x4AD95D0", VA = "0x184ADA9D0")]
		internal static void RunOrScheduleAction(System.Action action, bool allowInlining, ref Task currentTask)
		{
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014E0")]
		[Address(RVA = "0x4ADAC90", Offset = "0x4AD9890", VA = "0x184ADAC90")]
		internal static void UnsafeScheduleAction(System.Action action)
		{
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014E1")]
		[Address(RVA = "0x4ADAC40", Offset = "0x4AD9840", VA = "0x184ADAC40")]
		protected static void ThrowAsyncIfNecessary(System.Exception exc)
		{
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014E2")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public void MarkAborted(ThreadAbortException e)
		{
		}

		// Token: 0x04000BA9 RID: 2985
		[Token(Token = "0x4000BA9")]
		[FieldOffset(Offset = "0x10")]
		private readonly ExecutionContext m_capturedContext;

		// Token: 0x04000BAA RID: 2986
		[Token(Token = "0x4000BAA")]
		[FieldOffset(Offset = "0x18")]
		protected readonly System.Action m_action;

		// Token: 0x04000BAB RID: 2987
		[Token(Token = "0x4000BAB")]
		[FieldOffset(Offset = "0x0")]
		private static ContextCallback s_invokeActionCallback;
	}
}
