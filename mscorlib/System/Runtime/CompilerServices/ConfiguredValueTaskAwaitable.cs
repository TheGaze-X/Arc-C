using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200048F RID: 1167
	[Token(Token = "0x200048F")]
	[StructLayout(3)]
	public readonly struct ConfiguredValueTaskAwaitable<TResult>
	{
		// Token: 0x060022C0 RID: 8896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022C0")]
		[MethodImpl(256)]
		internal ConfiguredValueTaskAwaitable(System.Threading.Tasks.ValueTask<TResult> value)
		{
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x00013F50 File Offset: 0x00012150
		[Token(Token = "0x60022C1")]
		[MethodImpl(256)]
		public ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter GetAwaiter()
		{
			return default(ConfiguredValueTaskAwaitable<TResult>.ConfiguredValueTaskAwaiter);
		}

		// Token: 0x040013D9 RID: 5081
		[Token(Token = "0x40013D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly System.Threading.Tasks.ValueTask<TResult> _value;

		// Token: 0x02000490 RID: 1168
		[Token(Token = "0x2000490")]
		[StructLayout(3)]
		public readonly struct ConfiguredValueTaskAwaiter : ICriticalNotifyCompletion
		{
			// Token: 0x060022C2 RID: 8898 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60022C2")]
			[MethodImpl(256)]
			internal ConfiguredValueTaskAwaiter(System.Threading.Tasks.ValueTask<TResult> value)
			{
			}

			// Token: 0x17000474 RID: 1140
			// (get) Token: 0x060022C3 RID: 8899 RVA: 0x00013F68 File Offset: 0x00012168
			[Token(Token = "0x17000474")]
			public bool IsCompleted
			{
				[Token(Token = "0x60022C3")]
				[MethodImpl(256)]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060022C4 RID: 8900 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x60022C4")]
			[StackTraceHidden]
			[MethodImpl(256)]
			public TResult GetResult()
			{
				return null;
			}

			// Token: 0x060022C5 RID: 8901 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60022C5")]
			public void UnsafeOnCompleted(System.Action continuation)
			{
			}

			// Token: 0x040013DA RID: 5082
			[Token(Token = "0x40013DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly System.Threading.Tasks.ValueTask<TResult> _value;
		}
	}
}
