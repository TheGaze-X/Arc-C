using System;
using System.Threading;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020004BC RID: 1212
	[Token(Token = "0x20004BC")]
	public readonly struct YieldAwaitable
	{
		// Token: 0x06002344 RID: 9028 RVA: 0x000140E8 File Offset: 0x000122E8
		[Token(Token = "0x6002344")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		public YieldAwaitable.YieldAwaiter GetAwaiter()
		{
			return default(YieldAwaitable.YieldAwaiter);
		}

		// Token: 0x020004BD RID: 1213
		[Token(Token = "0x20004BD")]
		public readonly struct YieldAwaiter : ICriticalNotifyCompletion
		{
			// Token: 0x1700048A RID: 1162
			// (get) Token: 0x06002345 RID: 9029 RVA: 0x00014100 File Offset: 0x00012300
			[Token(Token = "0x1700048A")]
			public bool IsCompleted
			{
				[Token(Token = "0x6002345")]
				[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06002346 RID: 9030 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002346")]
			[Address(RVA = "0x4BEBDA0", Offset = "0x4BEA9A0", VA = "0x184BEBDA0", Slot = "4")]
			public void UnsafeOnCompleted(System.Action continuation)
			{
			}

			// Token: 0x06002347 RID: 9031 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002347")]
			[Address(RVA = "0x4BEBA50", Offset = "0x4BEA650", VA = "0x184BEBA50")]
			private static void QueueContinuation(System.Action continuation, bool flowContext)
			{
			}

			// Token: 0x06002348 RID: 9032 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002348")]
			[Address(RVA = "0x4BEBD30", Offset = "0x4BEA930", VA = "0x184BEBD30")]
			private static void RunAction(object state)
			{
			}

			// Token: 0x06002349 RID: 9033 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002349")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
			public void GetResult()
			{
			}

			// Token: 0x0400140C RID: 5132
			[Token(Token = "0x400140C")]
			[FieldOffset(Offset = "0x0")]
			private static readonly System.Threading.WaitCallback s_waitCallbackRunAction;

			// Token: 0x0400140D RID: 5133
			[Token(Token = "0x400140D")]
			[FieldOffset(Offset = "0x8")]
			private static readonly System.Threading.SendOrPostCallback s_sendOrPostCallbackRunAction;
		}
	}
}
