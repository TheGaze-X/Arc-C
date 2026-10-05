using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200776F RID: 30575
	[Token(Token = "0x200776F")]
	public class Act1VHalfidlePlotSquadCountItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602AF15 RID: 175893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF15")]
		[Address(RVA = "0x26BEF30", Offset = "0x26BDB30", VA = "0x1826BEF30")]
		public void Render(Act1VHalfIdlePlotSquadViewModel viewModel)
		{
		}

		// Token: 0x0602AF16 RID: 175894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF16")]
		[Address(RVA = "0x26BF100", Offset = "0x26BDD00", VA = "0x1826BF100")]
		public Act1VHalfidlePlotSquadCountItemView()
		{
		}

		// Token: 0x0403DF54 RID: 253780
		[Token(Token = "0x403DF54")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act1VHalfIdlePlotType _type;

		// Token: 0x0403DF55 RID: 253781
		[Token(Token = "0x403DF55")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0403DF56 RID: 253782
		[Token(Token = "0x403DF56")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _count;

		// Token: 0x0403DF57 RID: 253783
		[Token(Token = "0x403DF57")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403DF58 RID: 253784
		[Token(Token = "0x403DF58")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403DF59 RID: 253785
		[Token(Token = "0x403DF59")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
