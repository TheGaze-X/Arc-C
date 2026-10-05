using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act36side
{
	// Token: 0x0200745C RID: 29788
	[Token(Token = "0x200745C")]
	public class Act36sideFoodHandbookTokenPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A063 RID: 172131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A063")]
		[Address(RVA = "0x259D8B0", Offset = "0x259C4B0", VA = "0x18259D8B0")]
		public void Render(Act36sideFoodHandbookViewModel model)
		{
		}

		// Token: 0x0602A064 RID: 172132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A064")]
		[Address(RVA = "0x259DCC0", Offset = "0x259C8C0", VA = "0x18259DCC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A065 RID: 172133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A065")]
		[Address(RVA = "0x259DDF0", Offset = "0x259C9F0", VA = "0x18259DDF0")]
		public Act36sideFoodHandbookTokenPanel()
		{
		}

		// Token: 0x0403C47A RID: 246906
		[Token(Token = "0x403C47A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _selectedTokenName;

		// Token: 0x0403C47B RID: 246907
		[Token(Token = "0x403C47B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _selectedTokenBigIcon;

		// Token: 0x0403C47C RID: 246908
		[Token(Token = "0x403C47C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _selectedTokenDesc;

		// Token: 0x0403C47D RID: 246909
		[Token(Token = "0x403C47D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _selectedTokenAbility;

		// Token: 0x0403C47E RID: 246910
		[Token(Token = "0x403C47E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _selectedTokenObtain;

		// Token: 0x0403C47F RID: 246911
		[Token(Token = "0x403C47F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TwoStateToggle _unlockToggle;

		// Token: 0x0403C480 RID: 246912
		[Token(Token = "0x403C480")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _gridContent;

		// Token: 0x0403C481 RID: 246913
		[Token(Token = "0x403C481")]
		[FieldOffset(Offset = "0x50")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403C482 RID: 246914
		[Token(Token = "0x403C482")]
		[FieldOffset(Offset = "0x60")]
		private List<Act36sideFoodHandbookTokenItemModel> m_cachedItemModels;

		// Token: 0x0403C483 RID: 246915
		[Token(Token = "0x403C483")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedActId;

		// Token: 0x0403C484 RID: 246916
		[Token(Token = "0x403C484")]
		[FieldOffset(Offset = "0x70")]
		private string m_cachedSelectedItemId;

		// Token: 0x0403C485 RID: 246917
		[Token(Token = "0x403C485")]
		[FieldOffset(Offset = "0x78")]
		private Act36sideFoodHandbookTokenPanel.ItemAdater m_adapter;

		// Token: 0x0403C486 RID: 246918
		[Token(Token = "0x403C486")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x0403C487 RID: 246919
		[Token(Token = "0x403C487")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C488 RID: 246920
		[Token(Token = "0x403C488")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403C489 RID: 246921
		[Token(Token = "0x403C489")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200745D RID: 29789
		[Token(Token = "0x200745D")]
		private class ItemAdater : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0602A066 RID: 172134 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A066")]
			[Address(RVA = "0x25AC1D0", Offset = "0x25AADD0", VA = "0x1825AC1D0")]
			public ItemAdater(Act36sideFoodHandbookTokenPanel closure)
			{
			}

			// Token: 0x17006322 RID: 25378
			// (get) Token: 0x0602A067 RID: 172135 RVA: 0x000D7430 File Offset: 0x000D5630
			[Token(Token = "0x17006322")]
			public override int count
			{
				[Token(Token = "0x602A067")]
				[Address(RVA = "0x25AC250", Offset = "0x25AAE50", VA = "0x1825AC250", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602A068 RID: 172136 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A068")]
			[Address(RVA = "0x25ABEE0", Offset = "0x25AAAE0", VA = "0x1825ABEE0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403C48A RID: 246922
			[Token(Token = "0x403C48A")]
			[FieldOffset(Offset = "0x20")]
			private Act36sideFoodHandbookTokenPanel m_closure;

			// Token: 0x0403C48B RID: 246923
			[Token(Token = "0x403C48B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403C48C RID: 246924
			[Token(Token = "0x403C48C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403C48D RID: 246925
			[Token(Token = "0x403C48D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
