using System;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x02000246 RID: 582
	[Token(Token = "0x2000246")]
	internal static class TaskToApm
	{
		// Token: 0x060013A7 RID: 5031 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60013A7")]
		[Address(RVA = "0x4AE4570", Offset = "0x4AE3170", VA = "0x184AE4570")]
		public static System.IAsyncResult Begin(Task task, System.AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A8")]
		[Address(RVA = "0x4AE47A0", Offset = "0x4AE33A0", VA = "0x184AE47A0")]
		public static void End(System.IAsyncResult asyncResult)
		{
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60013A9")]
		public static TResult End<TResult>(System.IAsyncResult asyncResult)
		{
			return null;
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AA")]
		[Address(RVA = "0x4AE48D0", Offset = "0x4AE34D0", VA = "0x184AE48D0")]
		private static void InvokeCallbackWhenTaskCompletes(Task antecedent, System.AsyncCallback callback, System.IAsyncResult asyncResult)
		{
		}

		// Token: 0x02000247 RID: 583
		[Token(Token = "0x2000247")]
		private sealed class TaskWrapperAsyncResult : System.IAsyncResult
		{
			// Token: 0x060013AB RID: 5035 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60013AB")]
			[Address(RVA = "0x4AE4B20", Offset = "0x4AE3720", VA = "0x184AE4B20")]
			internal TaskWrapperAsyncResult(Task task, object state, bool completedSynchronously)
			{
			}

			// Token: 0x170001D9 RID: 473
			// (get) Token: 0x060013AC RID: 5036 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170001D9")]
			private object AsyncState
			{
				[Token(Token = "0x60013AC")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x170001DA RID: 474
			// (get) Token: 0x060013AD RID: 5037 RVA: 0x0000F018 File Offset: 0x0000D218
			[Token(Token = "0x170001DA")]
			private bool CompletedSynchronously
			{
				[Token(Token = "0x60013AD")]
				[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170001DB RID: 475
			// (get) Token: 0x060013AE RID: 5038 RVA: 0x0000F030 File Offset: 0x0000D230
			[Token(Token = "0x170001DB")]
			private bool IsCompleted
			{
				[Token(Token = "0x60013AE")]
				[Address(RVA = "0x4AE4AC0", Offset = "0x4AE36C0", VA = "0x184AE4AC0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170001DC RID: 476
			// (get) Token: 0x060013AF RID: 5039 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170001DC")]
			private WaitHandle AsyncWaitHandle
			{
				[Token(Token = "0x60013AF")]
				[Address(RVA = "0x4AE49E0", Offset = "0x4AE35E0", VA = "0x184AE49E0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x04000B0A RID: 2826
			[Token(Token = "0x4000B0A")]
			[FieldOffset(Offset = "0x10")]
			internal readonly Task Task;

			// Token: 0x04000B0B RID: 2827
			[Token(Token = "0x4000B0B")]
			[FieldOffset(Offset = "0x18")]
			private readonly object _state;

			// Token: 0x04000B0C RID: 2828
			[Token(Token = "0x4000B0C")]
			[FieldOffset(Offset = "0x20")]
			private readonly bool _completedSynchronously;
		}
	}
}
