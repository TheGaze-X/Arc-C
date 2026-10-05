using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x02000250 RID: 592
	[Token(Token = "0x2000250")]
	internal readonly struct ForceAsyncAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion
	{
		// Token: 0x060013D8 RID: 5080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013D8")]
		[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
		internal ForceAsyncAwaiter(Task task)
		{
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x0000F180 File Offset: 0x0000D380
		[Token(Token = "0x60013D9")]
		[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
		public ForceAsyncAwaiter GetAwaiter()
		{
			return default(ForceAsyncAwaiter);
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060013DA RID: 5082 RVA: 0x0000F198 File Offset: 0x0000D398
		[Token(Token = "0x170001E2")]
		public bool IsCompleted
		{
			[Token(Token = "0x60013DA")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013DB")]
		[Address(RVA = "0x4ADE960", Offset = "0x4ADD560", VA = "0x184ADE960")]
		public void GetResult()
		{
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013DC")]
		[Address(RVA = "0x4ADE9A0", Offset = "0x4ADD5A0", VA = "0x184ADE9A0", Slot = "4")]
		public void UnsafeOnCompleted(System.Action action)
		{
		}

		// Token: 0x04000B20 RID: 2848
		[Token(Token = "0x4000B20")]
		[FieldOffset(Offset = "0x0")]
		private readonly Task _task;
	}
}
