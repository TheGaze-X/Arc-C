using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x0200012E RID: 302
	[Token(Token = "0x200012E")]
	public class WaitForStartCoroutine : CustomYieldInstruction
	{
		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x000067C4 File Offset: 0x000049C4
		[Token(Token = "0x1700009A")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000730")]
			[Address(RVA = "0x160BEE0", Offset = "0x160AAE0", VA = "0x18160BEE0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x06000732 RID: 1842 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x1700009B")]
		public IEnumerator wrappedRoutine
		{
			[Token(Token = "0x6000731")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000732")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000733")]
		[Address(RVA = "0x552C180", Offset = "0x552AD80", VA = "0x18552C180")]
		public WaitForStartCoroutine(IEnumerator routine, Func<IEnumerator, Coroutine> startCoroFunc)
		{
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000734")]
		[Address(RVA = "0x552C0F0", Offset = "0x552ACF0", VA = "0x18552C0F0")]
		private IEnumerator _WrappedRoutine(IEnumerator routine)
		{
			return null;
		}

		// Token: 0x04000636 RID: 1590
		[Token(Token = "0x4000636")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isFinished;
	}
}
