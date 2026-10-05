using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DEF RID: 19951
	[Token(Token = "0x2004DEF")]
	public class NameCardSkinListAdapter : LoopScrollAdapter<NameCardSkinListItemViewHolder, NameCardSkinListItemViewModel>, IHotfixable
	{
		// Token: 0x0601DD1E RID: 122142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD1E")]
		[Address(RVA = "0x1756620", Offset = "0x1755220", VA = "0x181756620")]
		public void SetParam(bool isSkinTmplList, string selectSkinId, int selectSkinTmpl, bool subSkinFastMode = false)
		{
		}

		// Token: 0x0601DD1F RID: 122143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DD1F")]
		[Address(RVA = "0x1756490", Offset = "0x1755090", VA = "0x181756490", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0601DD20 RID: 122144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD20")]
		[Address(RVA = "0x17566E0", Offset = "0x17552E0", VA = "0x1817566E0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, NameCardSkinListItemViewHolder holder, NameCardSkinListItemViewModel data)
		{
		}

		// Token: 0x0601DD21 RID: 122145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD21")]
		[Address(RVA = "0x1756860", Offset = "0x1755460", VA = "0x181756860")]
		public NameCardSkinListAdapter()
		{
		}

		// Token: 0x040277F6 RID: 161782
		[Token(Token = "0x40277F6")]
		[FieldOffset(Offset = "0x58")]
		private NameCardSkinListItemView m_itemViewPrefab;

		// Token: 0x040277F7 RID: 161783
		[Token(Token = "0x40277F7")]
		[FieldOffset(Offset = "0x60")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040277F8 RID: 161784
		[Token(Token = "0x40277F8")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isSkinTmplList;

		// Token: 0x040277F9 RID: 161785
		[Token(Token = "0x40277F9")]
		[FieldOffset(Offset = "0x78")]
		private string m_selectSkinId;

		// Token: 0x040277FA RID: 161786
		[Token(Token = "0x40277FA")]
		[FieldOffset(Offset = "0x80")]
		private int m_selectSkinTmpl;

		// Token: 0x040277FB RID: 161787
		[Token(Token = "0x40277FB")]
		[FieldOffset(Offset = "0x84")]
		private bool m_subSkinFastMode;

		// Token: 0x040277FC RID: 161788
		[Token(Token = "0x40277FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetParam;

		// Token: 0x040277FD RID: 161789
		[Token(Token = "0x40277FD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x040277FE RID: 161790
		[Token(Token = "0x40277FE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x040277FF RID: 161791
		[Token(Token = "0x40277FF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
