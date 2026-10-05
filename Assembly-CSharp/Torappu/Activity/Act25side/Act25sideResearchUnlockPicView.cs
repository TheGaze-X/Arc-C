using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x0200751B RID: 29979
	[Token(Token = "0x200751B")]
	public class Act25sideResearchUnlockPicView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A3F9 RID: 173049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3F9")]
		[Address(RVA = "0x25E92B0", Offset = "0x25E7EB0", VA = "0x1825E92B0")]
		public void Render(string picId, int num)
		{
		}

		// Token: 0x0602A3FA RID: 173050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3FA")]
		[Address(RVA = "0x25E9450", Offset = "0x25E8050", VA = "0x1825E9450")]
		public Act25sideResearchUnlockPicView()
		{
		}

		// Token: 0x0403CBB3 RID: 248755
		[Token(Token = "0x403CBB3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0403CBB4 RID: 248756
		[Token(Token = "0x403CBB4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _count;

		// Token: 0x0403CBB5 RID: 248757
		[Token(Token = "0x403CBB5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelNum;

		// Token: 0x0403CBB6 RID: 248758
		[Token(Token = "0x403CBB6")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403CBB7 RID: 248759
		[Token(Token = "0x403CBB7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403CBB8 RID: 248760
		[Token(Token = "0x403CBB8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
