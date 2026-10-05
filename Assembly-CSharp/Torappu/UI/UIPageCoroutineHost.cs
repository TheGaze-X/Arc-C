using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003966 RID: 14694
	[Token(Token = "0x2003966")]
	public class UIPageCoroutineHost : LoopRequestSender.ICoroutineHost, IHotfixable
	{
		// Token: 0x06017373 RID: 95091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017373")]
		[Address(RVA = "0xF97140", Offset = "0xF95D40", VA = "0x180F97140")]
		public UIPageCoroutineHost(UIPage page)
		{
		}

		// Token: 0x06017374 RID: 95092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017374")]
		[Address(RVA = "0xF97070", Offset = "0xF95C70", VA = "0x180F97070", Slot = "4")]
		public Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		// Token: 0x0401C05B RID: 114779
		[Token(Token = "0x401C05B")]
		[FieldOffset(Offset = "0x10")]
		private UIPage m_page;

		// Token: 0x0401C05C RID: 114780
		[Token(Token = "0x401C05C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401C05D RID: 114781
		[Token(Token = "0x401C05D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_StartCoroutine;
	}
}
