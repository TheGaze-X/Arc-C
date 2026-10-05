using System;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x02000268 RID: 616
	[Token(Token = "0x2000268")]
	internal sealed class UnwrapPromise<TResult> : Task<TResult>, ITaskCompletionAction
	{
		// Token: 0x060014B4 RID: 5300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B4")]
		public UnwrapPromise(Task outerTask, bool lookForOce)
		{
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B5")]
		public void Invoke(Task completingTask)
		{
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B6")]
		private void InvokeCore(Task completingTask)
		{
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B7")]
		private void InvokeCoreAsync(Task completingTask)
		{
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014B8")]
		private void ProcessCompletedOuterTask(Task task)
		{
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x0000F678 File Offset: 0x0000D878
		[Token(Token = "0x60014B9")]
		private bool TrySetFromTask(Task task, bool lookForOce)
		{
			return default(bool);
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014BA")]
		private void ProcessInnerTask(Task task)
		{
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060014BB RID: 5307 RVA: 0x0000F690 File Offset: 0x0000D890
		[Token(Token = "0x17000207")]
		public bool InvokeMayRunArbitraryCode
		{
			[Token(Token = "0x60014BB")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000B98 RID: 2968
		[Token(Token = "0x4000B98")]
		[FieldOffset(Offset = "0x0")]
		private byte _state;

		// Token: 0x04000B99 RID: 2969
		[Token(Token = "0x4000B99")]
		[FieldOffset(Offset = "0x0")]
		private readonly bool _lookForOce;
	}
}
