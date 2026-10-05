using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020004AA RID: 1194
	[Token(Token = "0x20004AA")]
	public readonly struct ValueTaskAwaiter<TResult> : ICriticalNotifyCompletion
	{
		// Token: 0x060022F4 RID: 8948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022F4")]
		[MethodImpl(256)]
		internal ValueTaskAwaiter(System.Threading.Tasks.ValueTask<TResult> value)
		{
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x060022F5 RID: 8949 RVA: 0x00013FF8 File Offset: 0x000121F8
		[Token(Token = "0x17000482")]
		public bool IsCompleted
		{
			[Token(Token = "0x60022F5")]
			[MethodImpl(256)]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60022F6")]
		[StackTraceHidden]
		[MethodImpl(256)]
		public TResult GetResult()
		{
			return null;
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022F7")]
		public void UnsafeOnCompleted(System.Action continuation)
		{
		}

		// Token: 0x040013E9 RID: 5097
		[Token(Token = "0x40013E9")]
		[FieldOffset(Offset = "0x0")]
		private readonly System.Threading.Tasks.ValueTask<TResult> _value;
	}
}
