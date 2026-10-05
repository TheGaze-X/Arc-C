using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act36side
{
	// Token: 0x0200745B RID: 29787
	[Token(Token = "0x200745B")]
	public class Act36sideFoodHandbookTokenListItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A060 RID: 172128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A060")]
		[Address(RVA = "0x259D6E0", Offset = "0x259C2E0", VA = "0x18259D6E0")]
		public void Render(Act36sideFoodHandbookTokenItemModel model, string selectedId, string actId)
		{
		}

		// Token: 0x0602A061 RID: 172129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A061")]
		[Address(RVA = "0x259D5F0", Offset = "0x259C1F0", VA = "0x18259D5F0")]
		public void OnTokenSelected()
		{
		}

		// Token: 0x0602A062 RID: 172130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A062")]
		[Address(RVA = "0x259D850", Offset = "0x259C450", VA = "0x18259D850")]
		public Act36sideFoodHandbookTokenListItem()
		{
		}

		// Token: 0x0403C46F RID: 246895
		[Token(Token = "0x403C46F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _tokenImage;

		// Token: 0x0403C470 RID: 246896
		[Token(Token = "0x403C470")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _selectedPanel;

		// Token: 0x0403C471 RID: 246897
		[Token(Token = "0x403C471")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _newPanel;

		// Token: 0x0403C472 RID: 246898
		[Token(Token = "0x403C472")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _unlockToggle;

		// Token: 0x0403C473 RID: 246899
		[Token(Token = "0x403C473")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _hotspot;

		// Token: 0x0403C474 RID: 246900
		[Token(Token = "0x403C474")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403C475 RID: 246901
		[Token(Token = "0x403C475")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedId;

		// Token: 0x0403C476 RID: 246902
		[Token(Token = "0x403C476")]
		[FieldOffset(Offset = "0x58")]
		private bool m_cachedIsSelected;

		// Token: 0x0403C477 RID: 246903
		[Token(Token = "0x403C477")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C478 RID: 246904
		[Token(Token = "0x403C478")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTokenSelected;

		// Token: 0x0403C479 RID: 246905
		[Token(Token = "0x403C479")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
