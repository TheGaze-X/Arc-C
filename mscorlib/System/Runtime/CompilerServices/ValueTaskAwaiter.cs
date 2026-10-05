using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020004A8 RID: 1192
	[Token(Token = "0x20004A8")]
	public readonly struct ValueTaskAwaiter : ICriticalNotifyCompletion
	{
		// Token: 0x060022EC RID: 8940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022EC")]
		[Address(RVA = "0x4F7EA0", Offset = "0x4F6AA0", VA = "0x1804F7EA0")]
		[MethodImpl(256)]
		internal ValueTaskAwaiter(System.Threading.Tasks.ValueTask value)
		{
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x060022ED RID: 8941 RVA: 0x00013FE0 File Offset: 0x000121E0
		[Token(Token = "0x17000481")]
		public bool IsCompleted
		{
			[Token(Token = "0x60022ED")]
			[Address(RVA = "0x4BEBA00", Offset = "0x4BEA600", VA = "0x184BEBA00")]
			[MethodImpl(256)]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022EE")]
		[Address(RVA = "0x4BEB5D0", Offset = "0x4BEA1D0", VA = "0x184BEB5D0")]
		[StackTraceHidden]
		[MethodImpl(256)]
		public void GetResult()
		{
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022EF")]
		[Address(RVA = "0x4BEB620", Offset = "0x4BEA220", VA = "0x184BEB620", Slot = "4")]
		public void UnsafeOnCompleted(System.Action continuation)
		{
		}

		// Token: 0x040013E6 RID: 5094
		[Token(Token = "0x40013E6")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly System.Action<object> s_invokeActionDelegate;

		// Token: 0x040013E7 RID: 5095
		[Token(Token = "0x40013E7")]
		[FieldOffset(Offset = "0x0")]
		private readonly System.Threading.Tasks.ValueTask _value;
	}
}
