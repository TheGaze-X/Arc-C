using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000128 RID: 296
	[Token(Token = "0x2000128")]
	public class WaitForAsyncTask<Result> : CustomYieldInstruction
	{
		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000092")]
		public Result result
		{
			[Token(Token = "0x6000718")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000093")]
		public Exception exception
		{
			[Token(Token = "0x6000719")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x00006764 File Offset: 0x00004964
		[Token(Token = "0x17000094")]
		public override bool keepWaiting
		{
			[Token(Token = "0x600071A")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x0600071C RID: 1820 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000095")]
		public object context
		{
			[Token(Token = "0x600071B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600071C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600071D")]
		public WaitForAsyncTask(Func<Result> task, [Optional] object pContext)
		{
		}

		// Token: 0x04000620 RID: 1568
		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Result m_result;

		// Token: 0x04000621 RID: 1569
		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_isFinished;

		// Token: 0x04000622 RID: 1570
		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Exception m_exception;
	}
}
