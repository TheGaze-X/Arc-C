using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x020065AD RID: 26029
	[Token(Token = "0x20065AD")]
	public class ArtMagazineDiyFilterGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700587C RID: 22652
		// (get) Token: 0x0602569D RID: 153245 RVA: 0x000C7D58 File Offset: 0x000C5F58
		[Token(Token = "0x1700587C")]
		public FilterGroupType filterGroupType
		{
			[Token(Token = "0x602569D")]
			[Address(RVA = "0x2061FD0", Offset = "0x2060BD0", VA = "0x182061FD0")]
			get
			{
				return FilterGroupType.CHAR_RARITY;
			}
		}

		// Token: 0x0602569E RID: 153246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602569E")]
		[Address(RVA = "0x2061DE0", Offset = "0x20609E0", VA = "0x182061DE0")]
		public void Render(ArtMagazineDiyItemFilterModel filterModel)
		{
		}

		// Token: 0x0602569F RID: 153247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602569F")]
		[Address(RVA = "0x2061C40", Offset = "0x2060840", VA = "0x182061C40")]
		public void OnClick()
		{
		}

		// Token: 0x060256A0 RID: 153248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60256A0")]
		[Address(RVA = "0x2061F70", Offset = "0x2060B70", VA = "0x182061F70")]
		public ArtMagazineDiyFilterGroupView()
		{
		}

		// Token: 0x0403480F RID: 215055
		[Token(Token = "0x403480F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FilterGroupType _filterGroupType;

		// Token: 0x04034810 RID: 215056
		[Token(Token = "0x4034810")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _title;

		// Token: 0x04034811 RID: 215057
		[Token(Token = "0x4034811")]
		[FieldOffset(Offset = "0x28")]
		private string m_cacheDialogResPath;

		// Token: 0x04034812 RID: 215058
		[Token(Token = "0x4034812")]
		[FieldOffset(Offset = "0x30")]
		private ItemType m_cacheRelateItemType;

		// Token: 0x04034813 RID: 215059
		[Token(Token = "0x4034813")]
		[FieldOffset(Offset = "0x38")]
		private object m_cacheActiveFilterParam;

		// Token: 0x04034814 RID: 215060
		[Token(Token = "0x4034814")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04034815 RID: 215061
		[Token(Token = "0x4034815")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_filterGroupType;

		// Token: 0x04034816 RID: 215062
		[Token(Token = "0x4034816")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04034817 RID: 215063
		[Token(Token = "0x4034817")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04034818 RID: 215064
		[Token(Token = "0x4034818")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
