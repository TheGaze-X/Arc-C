using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Sources;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x02000249 RID: 585
	[Token(Token = "0x2000249")]
	[System.Runtime.CompilerServices.AsyncMethodBuilder(typeof(System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder))]
	[StructLayout(3)]
	public readonly struct ValueTask : System.IEquatable<ValueTask>
	{
		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060013B2 RID: 5042 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001DD")]
		internal static Task CompletedTask
		{
			[Token(Token = "0x60013B2")]
			[Address(RVA = "0x4AF2BD0", Offset = "0x4AF17D0", VA = "0x184AF2BD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B3")]
		[Address(RVA = "0x4AF2B80", Offset = "0x4AF1780", VA = "0x184AF2B80")]
		[MethodImpl(256)]
		public ValueTask(Task task)
		{
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013B4")]
		[Address(RVA = "0x4AF2B30", Offset = "0x4AF1730", VA = "0x184AF2B30")]
		[MethodImpl(256)]
		public ValueTask(System.Threading.Tasks.Sources.IValueTaskSource source, short token)
		{
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x0000F048 File Offset: 0x0000D248
		[Token(Token = "0x60013B5")]
		[Address(RVA = "0x3FD8800", Offset = "0x3FD7400", VA = "0x183FD8800", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x0000F060 File Offset: 0x0000D260
		[Token(Token = "0x60013B6")]
		[Address(RVA = "0x4AF25B0", Offset = "0x4AF11B0", VA = "0x184AF25B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x0000F078 File Offset: 0x0000D278
		[Token(Token = "0x60013B7")]
		[Address(RVA = "0x4AF2660", Offset = "0x4AF1260", VA = "0x184AF2660", Slot = "4")]
		public bool Equals(ValueTask other)
		{
			return default(bool);
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60013B8")]
		[Address(RVA = "0x4AF24C0", Offset = "0x4AF10C0", VA = "0x184AF24C0")]
		public Task AsTask()
		{
			return null;
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60013B9")]
		[Address(RVA = "0x4AF26A0", Offset = "0x4AF12A0", VA = "0x184AF26A0")]
		private Task GetTaskForValueTaskSource(System.Threading.Tasks.Sources.IValueTaskSource t)
		{
			return null;
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060013BA RID: 5050 RVA: 0x0000F090 File Offset: 0x0000D290
		[Token(Token = "0x170001DE")]
		public bool IsCompleted
		{
			[Token(Token = "0x60013BA")]
			[Address(RVA = "0x4AF2C60", Offset = "0x4AF1860", VA = "0x184AF2C60")]
			[MethodImpl(256)]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013BB")]
		[Address(RVA = "0x4AF29A0", Offset = "0x4AF15A0", VA = "0x184AF29A0")]
		[StackTraceHidden]
		[MethodImpl(256)]
		internal void ThrowIfCompletedUnsuccessfully()
		{
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x0000F0A8 File Offset: 0x0000D2A8
		[Token(Token = "0x60013BC")]
		[Address(RVA = "0x4AF2680", Offset = "0x4AF1280", VA = "0x184AF2680")]
		public System.Runtime.CompilerServices.ValueTaskAwaiter GetAwaiter()
		{
			return default(System.Runtime.CompilerServices.ValueTaskAwaiter);
		}

		// Token: 0x04000B0F RID: 2831
		[Token(Token = "0x4000B0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Task s_canceledTask;

		// Token: 0x04000B10 RID: 2832
		[Token(Token = "0x4000B10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal readonly object _obj;

		// Token: 0x04000B11 RID: 2833
		[Token(Token = "0x4000B11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal readonly short _token;

		// Token: 0x04000B12 RID: 2834
		[Token(Token = "0x4000B12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		internal readonly bool _continueOnCapturedContext;

		// Token: 0x0200024A RID: 586
		[Token(Token = "0x200024A")]
		private sealed class ValueTaskSourceAsTask : Task<VoidTaskResult>
		{
			// Token: 0x060013BE RID: 5054 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60013BE")]
			[Address(RVA = "0x4AF2340", Offset = "0x4AF0F40", VA = "0x184AF2340")]
			public ValueTaskSourceAsTask(System.Threading.Tasks.Sources.IValueTaskSource source, short token)
			{
			}

			// Token: 0x04000B13 RID: 2835
			[Token(Token = "0x4000B13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly System.Action<object> s_completionAction;

			// Token: 0x04000B14 RID: 2836
			[Token(Token = "0x4000B14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private System.Threading.Tasks.Sources.IValueTaskSource _source;

			// Token: 0x04000B15 RID: 2837
			[Token(Token = "0x4000B15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private readonly short _token;
		}
	}
}
