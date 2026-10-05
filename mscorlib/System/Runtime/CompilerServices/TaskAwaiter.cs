using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020004AB RID: 1195
	[Token(Token = "0x20004AB")]
	public readonly struct TaskAwaiter : ICriticalNotifyCompletion
	{
		// Token: 0x060022F8 RID: 8952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022F8")]
		[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
		internal TaskAwaiter(System.Threading.Tasks.Task task)
		{
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x060022F9 RID: 8953 RVA: 0x00014010 File Offset: 0x00012210
		[Token(Token = "0x17000483")]
		public bool IsCompleted
		{
			[Token(Token = "0x60022F9")]
			[Address(RVA = "0x441CFC0", Offset = "0x441BBC0", VA = "0x18441CFC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022FA")]
		[Address(RVA = "0x4BE9D60", Offset = "0x4BE8960", VA = "0x184BE9D60", Slot = "4")]
		public void UnsafeOnCompleted(System.Action continuation)
		{
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022FB")]
		[Address(RVA = "0x4BD1070", Offset = "0x4BCFC70", VA = "0x184BD1070")]
		[StackTraceHidden]
		public void GetResult()
		{
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022FC")]
		[Address(RVA = "0x4BE9E20", Offset = "0x4BE8A20", VA = "0x184BE9E20")]
		[StackTraceHidden]
		internal static void ValidateEnd(System.Threading.Tasks.Task task)
		{
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022FD")]
		[Address(RVA = "0x4BE9780", Offset = "0x4BE8380", VA = "0x184BE9780")]
		[StackTraceHidden]
		private static void HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task task)
		{
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022FE")]
		[Address(RVA = "0x4BE9C00", Offset = "0x4BE8800", VA = "0x184BE9C00")]
		[StackTraceHidden]
		private static void ThrowForNonSuccess(System.Threading.Tasks.Task task)
		{
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022FF")]
		[Address(RVA = "0x4BE9920", Offset = "0x4BE8520", VA = "0x184BE9920")]
		internal static void OnCompletedInternal(System.Threading.Tasks.Task task, System.Action continuation, bool continueOnCapturedContext, bool flowExecutionContext)
		{
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002300")]
		[Address(RVA = "0x4BE9A00", Offset = "0x4BE8600", VA = "0x184BE9A00")]
		private static System.Action OutputWaitEtwEvents(System.Threading.Tasks.Task task, System.Action continuation)
		{
			return null;
		}

		// Token: 0x040013EA RID: 5098
		[Token(Token = "0x40013EA")]
		[FieldOffset(Offset = "0x0")]
		internal readonly System.Threading.Tasks.Task m_task;
	}
}
