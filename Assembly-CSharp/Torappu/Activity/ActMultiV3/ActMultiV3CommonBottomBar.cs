using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EF7 RID: 28407
	[Token(Token = "0x2006EF7")]
	public class ActMultiV3CommonBottomBar : MonoBehaviour, IHotfixable
	{
		// Token: 0x060285C8 RID: 165320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285C8")]
		[Address(RVA = "0x23A95E0", Offset = "0x23A81E0", VA = "0x1823A95E0")]
		public void Render(string actId, ILoadAsset assetLoader)
		{
		}

		// Token: 0x060285C9 RID: 165321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285C9")]
		[Address(RVA = "0x23A96D0", Offset = "0x23A82D0", VA = "0x1823A96D0")]
		public ActMultiV3CommonBottomBar()
		{
		}

		// Token: 0x04039613 RID: 235027
		[Token(Token = "0x4039613")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgSeasonLogo;

		// Token: 0x04039614 RID: 235028
		[Token(Token = "0x4039614")]
		[FieldOffset(Offset = "0x20")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04039615 RID: 235029
		[Token(Token = "0x4039615")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039616 RID: 235030
		[Token(Token = "0x4039616")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
