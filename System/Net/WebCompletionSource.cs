using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x0200033B RID: 827
	[Token(Token = "0x200033B")]
	internal class WebCompletionSource<T>
	{
		// Token: 0x06001730 RID: 5936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001730")]
		public WebCompletionSource(bool runAsync = true)
		{
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001731 RID: 5937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700050F")]
		internal WebCompletionSource<T>.Result CurrentResult
		{
			[Token(Token = "0x6001731")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001732 RID: 5938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000510")]
		internal Task Task
		{
			[Token(Token = "0x6001732")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x0000A950 File Offset: 0x00008B50
		[Token(Token = "0x6001733")]
		public bool TrySetCompleted(T argument)
		{
			return default(bool);
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x0000A968 File Offset: 0x00008B68
		[Token(Token = "0x6001734")]
		public bool TrySetCompleted()
		{
			return default(bool);
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x0000A980 File Offset: 0x00008B80
		[Token(Token = "0x6001735")]
		public bool TrySetCanceled()
		{
			return default(bool);
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x0000A998 File Offset: 0x00008B98
		[Token(Token = "0x6001736")]
		public bool TrySetCanceled(OperationCanceledException error)
		{
			return default(bool);
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x0000A9B0 File Offset: 0x00008BB0
		[Token(Token = "0x6001737")]
		public bool TrySetException(Exception error)
		{
			return default(bool);
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001738")]
		public void ThrowOnError()
		{
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001739")]
		public Task<T> WaitForCompletion()
		{
			return null;
		}

		// Token: 0x04000D3C RID: 3388
		[Token(Token = "0x4000D3C")]
		[FieldOffset(Offset = "0x0")]
		private TaskCompletionSource<WebCompletionSource<T>.Result> completion;

		// Token: 0x04000D3D RID: 3389
		[Token(Token = "0x4000D3D")]
		[FieldOffset(Offset = "0x0")]
		private WebCompletionSource<T>.Result currentResult;

		// Token: 0x0200033C RID: 828
		[Token(Token = "0x200033C")]
		internal enum Status
		{
			// Token: 0x04000D3F RID: 3391
			[Token(Token = "0x4000D3F")]
			Running,
			// Token: 0x04000D40 RID: 3392
			[Token(Token = "0x4000D40")]
			Completed,
			// Token: 0x04000D41 RID: 3393
			[Token(Token = "0x4000D41")]
			Canceled,
			// Token: 0x04000D42 RID: 3394
			[Token(Token = "0x4000D42")]
			Faulted
		}

		// Token: 0x0200033D RID: 829
		[Token(Token = "0x200033D")]
		internal class Result
		{
			// Token: 0x17000511 RID: 1297
			// (get) Token: 0x0600173A RID: 5946 RVA: 0x0000A9C8 File Offset: 0x00008BC8
			[Token(Token = "0x17000511")]
			public WebCompletionSource<T>.Status Status
			{
				[Token(Token = "0x600173A")]
				[CompilerGenerated]
				get
				{
					return WebCompletionSource.Status.Running;
				}
			}

			// Token: 0x17000512 RID: 1298
			// (get) Token: 0x0600173B RID: 5947 RVA: 0x0000A9E0 File Offset: 0x00008BE0
			[Token(Token = "0x17000512")]
			public bool Success
			{
				[Token(Token = "0x600173B")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000513 RID: 1299
			// (get) Token: 0x0600173C RID: 5948 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000513")]
			public ExceptionDispatchInfo Error
			{
				[Token(Token = "0x600173C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000514 RID: 1300
			// (get) Token: 0x0600173D RID: 5949 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000514")]
			public T Argument
			{
				[Token(Token = "0x600173D")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x0600173E RID: 5950 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600173E")]
			public Result(T argument)
			{
			}

			// Token: 0x0600173F RID: 5951 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600173F")]
			public Result(WebCompletionSource<T>.Status state, ExceptionDispatchInfo error)
			{
			}
		}
	}
}
