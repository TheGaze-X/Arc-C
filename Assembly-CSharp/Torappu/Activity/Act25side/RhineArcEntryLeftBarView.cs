using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074E1 RID: 29921
	[Token(Token = "0x20074E1")]
	public class RhineArcEntryLeftBarView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A2E1 RID: 172769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2E1")]
		[Address(RVA = "0x25D4F80", Offset = "0x25D3B80", VA = "0x1825D4F80")]
		public void Render(RhineArcViewModel.Group groupViewModel)
		{
		}

		// Token: 0x0602A2E2 RID: 172770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2E2")]
		[Address(RVA = "0x25D5270", Offset = "0x25D3E70", VA = "0x1825D5270")]
		public RhineArcEntryLeftBarView()
		{
		}

		// Token: 0x0403C996 RID: 248214
		[Token(Token = "0x403C996")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _areaName;

		// Token: 0x0403C997 RID: 248215
		[Token(Token = "0x403C997")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _percentText;

		// Token: 0x0403C998 RID: 248216
		[Token(Token = "0x403C998")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _percentBar;

		// Token: 0x0403C999 RID: 248217
		[Token(Token = "0x403C999")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _areaEngImg;

		// Token: 0x0403C99A RID: 248218
		[Token(Token = "0x403C99A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _lockObj;

		// Token: 0x0403C99B RID: 248219
		[Token(Token = "0x403C99B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _unlockObj;

		// Token: 0x0403C99C RID: 248220
		[Token(Token = "0x403C99C")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403C99D RID: 248221
		[Token(Token = "0x403C99D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C99E RID: 248222
		[Token(Token = "0x403C99E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
