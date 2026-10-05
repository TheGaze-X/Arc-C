using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Sources;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x0200024C RID: 588
	[Token(Token = "0x200024C")]
	[System.Runtime.CompilerServices.AsyncMethodBuilder(typeof(System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder<>))]
	[StructLayout(3)]
	public readonly struct ValueTask<TResult> : System.IEquatable<ValueTask<TResult>>
	{
		// Token: 0x060013C3 RID: 5059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C3")]
		[MethodImpl(256)]
		public ValueTask(TResult result)
		{
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C4")]
		[MethodImpl(256)]
		public ValueTask(Task<TResult> task)
		{
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C5")]
		[MethodImpl(256)]
		public ValueTask(System.Threading.Tasks.Sources.IValueTaskSource<TResult> source, short token)
		{
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C6")]
		[MethodImpl(256)]
		private ValueTask(object obj, TResult result, short token, bool continueOnCapturedContext)
		{
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x0000F0C0 File Offset: 0x0000D2C0
		[Token(Token = "0x60013C7")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x0000F0D8 File Offset: 0x0000D2D8
		[Token(Token = "0x60013C8")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x0000F0F0 File Offset: 0x0000D2F0
		[Token(Token = "0x60013C9")]
		public bool Equals(ValueTask<TResult> other)
		{
			return default(bool);
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60013CA")]
		public Task<TResult> AsTask()
		{
			return null;
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60013CB")]
		private Task<TResult> GetTaskForValueTaskSource(System.Threading.Tasks.Sources.IValueTaskSource<TResult> t)
		{
			return null;
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060013CC RID: 5068 RVA: 0x0000F108 File Offset: 0x0000D308
		[Token(Token = "0x170001DF")]
		public bool IsCompleted
		{
			[Token(Token = "0x60013CC")]
			[MethodImpl(256)]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060013CD RID: 5069 RVA: 0x0000F120 File Offset: 0x0000D320
		[Token(Token = "0x170001E0")]
		public bool IsCompletedSuccessfully
		{
			[Token(Token = "0x60013CD")]
			[MethodImpl(256)]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060013CE RID: 5070 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001E1")]
		public TResult Result
		{
			[Token(Token = "0x60013CE")]
			[MethodImpl(256)]
			get
			{
				return null;
			}
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x0000F138 File Offset: 0x0000D338
		[Token(Token = "0x60013CF")]
		[MethodImpl(256)]
		public System.Runtime.CompilerServices.ValueTaskAwaiter<TResult> GetAwaiter()
		{
			return default(System.Runtime.CompilerServices.ValueTaskAwaiter<TResult>);
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x0000F150 File Offset: 0x0000D350
		[Token(Token = "0x60013D0")]
		[MethodImpl(256)]
		public System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext)
		{
			return default(System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable<TResult>);
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60013D1")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000B17 RID: 2839
		[Token(Token = "0x4000B17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Task<TResult> s_canceledTask;

		// Token: 0x04000B18 RID: 2840
		[Token(Token = "0x4000B18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal readonly object _obj;

		// Token: 0x04000B19 RID: 2841
		[Token(Token = "0x4000B19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal readonly TResult _result;

		// Token: 0x04000B1A RID: 2842
		[Token(Token = "0x4000B1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal readonly short _token;

		// Token: 0x04000B1B RID: 2843
		[Token(Token = "0x4000B1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal readonly bool _continueOnCapturedContext;

		// Token: 0x0200024D RID: 589
		[Token(Token = "0x200024D")]
		private sealed class ValueTaskSourceAsTask : Task<TResult>
		{
			// Token: 0x060013D2 RID: 5074 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60013D2")]
			public ValueTaskSourceAsTask(System.Threading.Tasks.Sources.IValueTaskSource<TResult> source, short token)
			{
			}

			// Token: 0x04000B1C RID: 2844
			[Token(Token = "0x4000B1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly System.Action<object> s_completionAction;

			// Token: 0x04000B1D RID: 2845
			[Token(Token = "0x4000B1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private System.Threading.Tasks.Sources.IValueTaskSource<TResult> _source;

			// Token: 0x04000B1E RID: 2846
			[Token(Token = "0x4000B1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly short _token;
		}
	}
}
