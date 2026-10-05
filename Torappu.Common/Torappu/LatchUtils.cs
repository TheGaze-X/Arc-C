using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000FE RID: 254
	[Token(Token = "0x20000FE")]
	public static class LatchUtils
	{
		// Token: 0x06000642 RID: 1602 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000642")]
		[Address(RVA = "0x55212C0", Offset = "0x551FEC0", VA = "0x1855212C0")]
		public static void NullableUnlock(this LatchUtils.InvokeWhenUnlock latch)
		{
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x5521250", Offset = "0x551FE50", VA = "0x185521250")]
		public static void NullableInvoke(this LatchUtils.InvokeWhenUnlock latch, Action callback)
		{
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x5521310", Offset = "0x551FF10", VA = "0x185521310")]
		public static IEnumerator NullableWaitUntilUnlocked(this LatchUtils.InvokeWhenUnlock latch)
		{
			return null;
		}

		// Token: 0x020000FF RID: 255
		[Token(Token = "0x20000FF")]
		public class InvokeWhenUnlock
		{
			// Token: 0x06000645 RID: 1605 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000645")]
			[Address(RVA = "0x55211D0", Offset = "0x551FDD0", VA = "0x1855211D0")]
			public void Unlock()
			{
			}

			// Token: 0x06000646 RID: 1606 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000646")]
			[Address(RVA = "0x5521170", Offset = "0x551FD70", VA = "0x185521170")]
			public void Invoke(Action callback)
			{
			}

			// Token: 0x06000647 RID: 1607 RVA: 0x000060EC File Offset: 0x000042EC
			[Token(Token = "0x6000647")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			public bool IsUnlocked()
			{
				return default(bool);
			}

			// Token: 0x06000648 RID: 1608 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000648")]
			[Address(RVA = "0x5521130", Offset = "0x551FD30", VA = "0x185521130")]
			public void Forget(Action callback)
			{
			}

			// Token: 0x06000649 RID: 1609 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000649")]
			[Address(RVA = "0x5521100", Offset = "0x551FD00", VA = "0x185521100")]
			public void ForgetAndLock()
			{
			}

			// Token: 0x0600064A RID: 1610 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x600064A")]
			[Address(RVA = "0x5521210", Offset = "0x551FE10", VA = "0x185521210")]
			private void _ConsumeIfUnlocked()
			{
			}

			// Token: 0x0600064B RID: 1611 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x600064B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public InvokeWhenUnlock()
			{
			}

			// Token: 0x0400058E RID: 1422
			[Token(Token = "0x400058E")]
			[FieldOffset(Offset = "0x10")]
			private bool m_unlocked;

			// Token: 0x0400058F RID: 1423
			[Token(Token = "0x400058F")]
			[FieldOffset(Offset = "0x18")]
			private Action m_callback;
		}

		// Token: 0x02000100 RID: 256
		[Token(Token = "0x2000100")]
		public class SetWhenBind<TTarget, TValue> where TTarget : class
		{
			// Token: 0x0600064C RID: 1612 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x600064C")]
			public SetWhenBind(Action<TTarget, TValue> setAction)
			{
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x0600064D RID: 1613 RVA: 0x00002066 File Offset: 0x00000266
			// (set) Token: 0x0600064E RID: 1614 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x1700007B")]
			public TTarget target
			{
				[Token(Token = "0x600064D")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600064E")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x0600064F RID: 1615 RVA: 0x00002066 File Offset: 0x00000266
			// (set) Token: 0x06000650 RID: 1616 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x1700007C")]
			public TValue value
			{
				[Token(Token = "0x600064F")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000650")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000651 RID: 1617 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000651")]
			public void Set(TValue val)
			{
			}

			// Token: 0x06000652 RID: 1618 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000652")]
			public void Bind(TTarget tar)
			{
			}

			// Token: 0x04000590 RID: 1424
			[Token(Token = "0x4000590")]
			[FieldOffset(Offset = "0x0")]
			private bool m_hasBeenSet;

			// Token: 0x04000591 RID: 1425
			[Token(Token = "0x4000591")]
			[FieldOffset(Offset = "0x0")]
			private Action<TTarget, TValue> m_setAction;
		}
	}
}
