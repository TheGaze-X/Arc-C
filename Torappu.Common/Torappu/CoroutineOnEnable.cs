using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x02000123 RID: 291
	[Token(Token = "0x2000123")]
	public class CoroutineOnEnable : IHotfixable
	{
		// Token: 0x06000707 RID: 1799 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x5513080", Offset = "0x5511C80", VA = "0x185513080")]
		public CoroutineOnEnable(MonoBehaviour target, CoroutineOnEnable.Options options)
		{
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x5512DD0", Offset = "0x55119D0", VA = "0x185512DD0")]
		public void InvokeOnEnable()
		{
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000709")]
		[Address(RVA = "0x5512D70", Offset = "0x5511970", VA = "0x185512D70")]
		public void InvokeOnDisable()
		{
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600070A")]
		[Address(RVA = "0x5512F10", Offset = "0x5511B10", VA = "0x185512F10")]
		private void _TryStartCoroutine()
		{
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x5512E40", Offset = "0x5511A40", VA = "0x185512E40")]
		private IEnumerator _TaskWrapper(IEnumerator task)
		{
			return null;
		}

		// Token: 0x0400060D RID: 1549
		[Token(Token = "0x400060D")]
		[FieldOffset(Offset = "0x10")]
		private CoroutineOnEnable.Options m_options;

		// Token: 0x0400060E RID: 1550
		[Token(Token = "0x400060E")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isEnabled;

		// Token: 0x0400060F RID: 1551
		[Token(Token = "0x400060F")]
		[FieldOffset(Offset = "0x21")]
		private bool m_coroutineLock;

		// Token: 0x04000610 RID: 1552
		[Token(Token = "0x4000610")]
		[FieldOffset(Offset = "0x28")]
		private Func<IEnumerator, Coroutine> m_startCoroutine;

		// Token: 0x04000611 RID: 1553
		[Token(Token = "0x4000611")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate129 _c__Hotfix0_ctor;

		// Token: 0x04000612 RID: 1554
		[Token(Token = "0x4000612")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate1 __Hotfix0_InvokeOnEnable;

		// Token: 0x04000613 RID: 1555
		[Token(Token = "0x4000613")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate1 __Hotfix0_InvokeOnDisable;

		// Token: 0x04000614 RID: 1556
		[Token(Token = "0x4000614")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate1 __Hotfix0__TryStartCoroutine;

		// Token: 0x04000615 RID: 1557
		[Token(Token = "0x4000615")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate130 __Hotfix0__TaskWrapper;

		// Token: 0x02000124 RID: 292
		[Token(Token = "0x2000124")]
		public struct Options
		{
			// Token: 0x04000616 RID: 1558
			[Token(Token = "0x4000616")]
			[FieldOffset(Offset = "0x0")]
			public static readonly CoroutineOnEnable.Options EMPTY;

			// Token: 0x04000617 RID: 1559
			[Token(Token = "0x4000617")]
			[FieldOffset(Offset = "0x0")]
			public IEnumerator task;

			// Token: 0x04000618 RID: 1560
			[Token(Token = "0x4000618")]
			[FieldOffset(Offset = "0x8")]
			public bool retryIfInterrupted;
		}
	}
}
