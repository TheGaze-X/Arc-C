using System;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x02000244 RID: 580
	[Token(Token = "0x2000244")]
	public class TaskCompletionSource<TResult>
	{
		// Token: 0x06001398 RID: 5016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001398")]
		public TaskCompletionSource()
		{
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001399")]
		public TaskCompletionSource(TaskCreationOptions creationOptions)
		{
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600139A")]
		public TaskCompletionSource(object state)
		{
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600139B")]
		public TaskCompletionSource(object state, TaskCreationOptions creationOptions)
		{
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001D8")]
		public Task<TResult> Task
		{
			[Token(Token = "0x600139C")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600139D")]
		private void SpinUntilCompleted()
		{
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x0000EFB8 File Offset: 0x0000D1B8
		[Token(Token = "0x600139E")]
		public bool TrySetException(System.Exception exception)
		{
			return default(bool);
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600139F")]
		public void SetException(System.Exception exception)
		{
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x0000EFD0 File Offset: 0x0000D1D0
		[Token(Token = "0x60013A0")]
		public bool TrySetResult(TResult result)
		{
			return default(bool);
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A1")]
		public void SetResult(TResult result)
		{
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x0000EFE8 File Offset: 0x0000D1E8
		[Token(Token = "0x60013A2")]
		public bool TrySetCanceled()
		{
			return default(bool);
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x0000F000 File Offset: 0x0000D200
		[Token(Token = "0x60013A3")]
		public bool TrySetCanceled(CancellationToken cancellationToken)
		{
			return default(bool);
		}

		// Token: 0x04000B09 RID: 2825
		[Token(Token = "0x4000B09")]
		[FieldOffset(Offset = "0x0")]
		private readonly Task<TResult> _task;
	}
}
