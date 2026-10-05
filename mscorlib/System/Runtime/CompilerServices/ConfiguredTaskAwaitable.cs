using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020004AE RID: 1198
	[Token(Token = "0x20004AE")]
	public readonly struct ConfiguredTaskAwaitable
	{
		// Token: 0x06002307 RID: 8967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002307")]
		[Address(RVA = "0x4BD1020", Offset = "0x4BCFC20", VA = "0x184BD1020")]
		internal ConfiguredTaskAwaitable(System.Threading.Tasks.Task task, bool continueOnCapturedContext)
		{
		}

		// Token: 0x06002308 RID: 8968 RVA: 0x00014040 File Offset: 0x00012240
		[Token(Token = "0x6002308")]
		[Address(RVA = "0x253ECA0", Offset = "0x253D8A0", VA = "0x18253ECA0")]
		public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter GetAwaiter()
		{
			return default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
		}

		// Token: 0x040013EE RID: 5102
		[Token(Token = "0x40013EE")]
		[FieldOffset(Offset = "0x0")]
		private readonly ConfiguredTaskAwaitable.ConfiguredTaskAwaiter m_configuredTaskAwaiter;

		// Token: 0x020004AF RID: 1199
		[Token(Token = "0x20004AF")]
		public readonly struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion
		{
			// Token: 0x06002309 RID: 8969 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002309")]
			[Address(RVA = "0x4006D10", Offset = "0x4005910", VA = "0x184006D10")]
			internal ConfiguredTaskAwaiter(System.Threading.Tasks.Task task, bool continueOnCapturedContext)
			{
			}

			// Token: 0x17000485 RID: 1157
			// (get) Token: 0x0600230A RID: 8970 RVA: 0x00014058 File Offset: 0x00012258
			[Token(Token = "0x17000485")]
			public bool IsCompleted
			{
				[Token(Token = "0x600230A")]
				[Address(RVA = "0x441CFC0", Offset = "0x441BBC0", VA = "0x18441CFC0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600230B RID: 8971 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600230B")]
			[Address(RVA = "0x4BD10C0", Offset = "0x4BCFCC0", VA = "0x184BD10C0", Slot = "5")]
			public void OnCompleted(System.Action continuation)
			{
			}

			// Token: 0x0600230C RID: 8972 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600230C")]
			[Address(RVA = "0x4BD1190", Offset = "0x4BCFD90", VA = "0x184BD1190", Slot = "4")]
			public void UnsafeOnCompleted(System.Action continuation)
			{
			}

			// Token: 0x0600230D RID: 8973 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600230D")]
			[Address(RVA = "0x4BD1070", Offset = "0x4BCFC70", VA = "0x184BD1070")]
			[StackTraceHidden]
			public void GetResult()
			{
			}

			// Token: 0x040013EF RID: 5103
			[Token(Token = "0x40013EF")]
			[FieldOffset(Offset = "0x0")]
			internal readonly System.Threading.Tasks.Task m_task;

			// Token: 0x040013F0 RID: 5104
			[Token(Token = "0x40013F0")]
			[FieldOffset(Offset = "0x8")]
			internal readonly bool m_continueOnCapturedContext;
		}
	}
}
