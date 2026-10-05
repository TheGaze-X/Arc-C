using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020004AD RID: 1197
	[Token(Token = "0x20004AD")]
	public readonly struct TaskAwaiter<TResult> : ICriticalNotifyCompletion
	{
		// Token: 0x06002303 RID: 8963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002303")]
		internal TaskAwaiter(System.Threading.Tasks.Task<TResult> task)
		{
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06002304 RID: 8964 RVA: 0x00014028 File Offset: 0x00012228
		[Token(Token = "0x17000484")]
		public bool IsCompleted
		{
			[Token(Token = "0x6002304")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002305")]
		public void UnsafeOnCompleted(System.Action continuation)
		{
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002306")]
		[StackTraceHidden]
		public TResult GetResult()
		{
			return null;
		}

		// Token: 0x040013ED RID: 5101
		[Token(Token = "0x40013ED")]
		[FieldOffset(Offset = "0x0")]
		private readonly System.Threading.Tasks.Task<TResult> m_task;
	}
}
