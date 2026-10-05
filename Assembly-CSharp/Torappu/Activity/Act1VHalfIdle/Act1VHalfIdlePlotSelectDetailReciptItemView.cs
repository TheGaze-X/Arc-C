using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007765 RID: 30565
	[Token(Token = "0x2007765")]
	public class Act1VHalfIdlePlotSelectDetailReciptItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602AECE RID: 175822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AECE")]
		[Address(RVA = "0x26B4C50", Offset = "0x26B3850", VA = "0x1826B4C50")]
		public void Render(string origPlotId, Act1VHalfidlePlotViewModel targetItem)
		{
		}

		// Token: 0x0602AECF RID: 175823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AECF")]
		[Address(RVA = "0x26B4DB0", Offset = "0x26B39B0", VA = "0x1826B4DB0")]
		public Act1VHalfIdlePlotSelectDetailReciptItemView()
		{
		}

		// Token: 0x0403DECE RID: 253646
		[Token(Token = "0x403DECE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _plotIcon;

		// Token: 0x0403DECF RID: 253647
		[Token(Token = "0x403DECF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act1VHalfIdlePlotCombineView _combineView;

		// Token: 0x0403DED0 RID: 253648
		[Token(Token = "0x403DED0")]
		[FieldOffset(Offset = "0x28")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403DED1 RID: 253649
		[Token(Token = "0x403DED1")]
		[FieldOffset(Offset = "0x38")]
		private string m_cachedPlotId;

		// Token: 0x0403DED2 RID: 253650
		[Token(Token = "0x403DED2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403DED3 RID: 253651
		[Token(Token = "0x403DED3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
