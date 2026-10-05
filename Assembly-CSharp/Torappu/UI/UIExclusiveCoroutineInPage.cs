using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003608 RID: 13832
	[Token(Token = "0x2003608")]
	public class UIExclusiveCoroutineInPage : IHotfixable
	{
		// Token: 0x06016086 RID: 90246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016086")]
		[Address(RVA = "0xE83240", Offset = "0xE81E40", VA = "0x180E83240")]
		public void ExclusiveCoroutine(IEnumerator coroutinue)
		{
		}

		// Token: 0x06016087 RID: 90247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016087")]
		[Address(RVA = "0xE83320", Offset = "0xE81F20", VA = "0x180E83320")]
		public UIExclusiveCoroutineInPage(MonoBehaviour handler)
		{
		}

		// Token: 0x0401A78C RID: 108428
		[Token(Token = "0x401A78C")]
		[FieldOffset(Offset = "0x10")]
		private ExclusiveCoroutineHost m_host;

		// Token: 0x0401A78D RID: 108429
		[Token(Token = "0x401A78D")]
		[FieldOffset(Offset = "0x18")]
		private UIPageListener m_pageListener;

		// Token: 0x0401A78E RID: 108430
		[Token(Token = "0x401A78E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ExclusiveCoroutine;

		// Token: 0x0401A78F RID: 108431
		[Token(Token = "0x401A78F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
