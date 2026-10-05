using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020004B0 RID: 1200
	[Token(Token = "0x20004B0")]
	public readonly struct ConfiguredTaskAwaitable<TResult>
	{
		// Token: 0x0600230E RID: 8974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600230E")]
		internal ConfiguredTaskAwaitable(System.Threading.Tasks.Task<TResult> task, bool continueOnCapturedContext)
		{
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x00014070 File Offset: 0x00012270
		[Token(Token = "0x600230F")]
		public ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter GetAwaiter()
		{
			return default(ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter);
		}

		// Token: 0x040013F1 RID: 5105
		[Token(Token = "0x40013F1")]
		[FieldOffset(Offset = "0x0")]
		private readonly ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter m_configuredTaskAwaiter;

		// Token: 0x020004B1 RID: 1201
		[Token(Token = "0x20004B1")]
		public readonly struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion
		{
			// Token: 0x06002310 RID: 8976 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002310")]
			internal ConfiguredTaskAwaiter(System.Threading.Tasks.Task<TResult> task, bool continueOnCapturedContext)
			{
			}

			// Token: 0x17000486 RID: 1158
			// (get) Token: 0x06002311 RID: 8977 RVA: 0x00014088 File Offset: 0x00012288
			[Token(Token = "0x17000486")]
			public bool IsCompleted
			{
				[Token(Token = "0x6002311")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06002312 RID: 8978 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002312")]
			public void UnsafeOnCompleted(System.Action continuation)
			{
			}

			// Token: 0x06002313 RID: 8979 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002313")]
			[StackTraceHidden]
			public TResult GetResult()
			{
				return null;
			}

			// Token: 0x040013F2 RID: 5106
			[Token(Token = "0x40013F2")]
			[FieldOffset(Offset = "0x0")]
			private readonly System.Threading.Tasks.Task<TResult> m_task;

			// Token: 0x040013F3 RID: 5107
			[Token(Token = "0x40013F3")]
			[FieldOffset(Offset = "0x0")]
			private readonly bool m_continueOnCapturedContext;
		}
	}
}
