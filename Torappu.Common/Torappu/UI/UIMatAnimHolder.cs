using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02000158 RID: 344
	[Token(Token = "0x2000158")]
	public static class UIMatAnimHolder
	{
		// Token: 0x06000806 RID: 2054 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000806")]
		[Address(RVA = "0x553FFC0", Offset = "0x553EBC0", VA = "0x18553FFC0")]
		public static void Register(UIAbstractMatAnimWrapper wrapper)
		{
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000807")]
		[Address(RVA = "0x5540080", Offset = "0x553EC80", VA = "0x185540080")]
		public static void UnRegister(UIAbstractMatAnimWrapper wrapper)
		{
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000808")]
		[Address(RVA = "0x55402D0", Offset = "0x553EED0", VA = "0x1855402D0")]
		private static void _UpdateSystemActivateStatus()
		{
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000809")]
		[Address(RVA = "0x5540140", Offset = "0x553ED40", VA = "0x185540140")]
		private static void _Refresh()
		{
		}

		// Token: 0x04000761 RID: 1889
		[Token(Token = "0x4000761")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HashSet<UIAbstractMatAnimWrapper> s_activeMatAnim;

		// Token: 0x04000762 RID: 1890
		[Token(Token = "0x4000762")]
		[FieldOffset(Offset = "0x8")]
		private static bool s_isActive;

		// Token: 0x04000763 RID: 1891
		[Token(Token = "0x4000763")]
		[FieldOffset(Offset = "0x10")]
		private static IWillRenderCanvasTask m_willRenderTask;
	}
}
