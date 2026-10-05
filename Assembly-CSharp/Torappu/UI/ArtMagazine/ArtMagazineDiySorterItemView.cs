using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x020065A7 RID: 26023
	[Token(Token = "0x20065A7")]
	public class ArtMagazineDiySorterItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025687 RID: 153223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025687")]
		[Address(RVA = "0x2064040", Offset = "0x2062C40", VA = "0x182064040")]
		public void Render(SorterType activeSorterType)
		{
		}

		// Token: 0x06025688 RID: 153224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025688")]
		[Address(RVA = "0x2063FA0", Offset = "0x2062BA0", VA = "0x182063FA0")]
		public void OnClick()
		{
		}

		// Token: 0x06025689 RID: 153225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025689")]
		[Address(RVA = "0x2064100", Offset = "0x2062D00", VA = "0x182064100")]
		private void _SendSorterMsg(SorterType sorterToSet)
		{
		}

		// Token: 0x0602568A RID: 153226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602568A")]
		[Address(RVA = "0x2064230", Offset = "0x2062E30", VA = "0x182064230")]
		public ArtMagazineDiySorterItemView()
		{
		}

		// Token: 0x040347DE RID: 215006
		[Token(Token = "0x40347DE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ItemType _relateItemType;

		// Token: 0x040347DF RID: 215007
		[Token(Token = "0x40347DF")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private SorterType _sorterTypeFirst;

		// Token: 0x040347E0 RID: 215008
		[Token(Token = "0x40347E0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SorterType _sorterTypeSecond;

		// Token: 0x040347E1 RID: 215009
		[Token(Token = "0x40347E1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ThreeStateToggle _toggle;

		// Token: 0x040347E2 RID: 215010
		[Token(Token = "0x40347E2")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040347E3 RID: 215011
		[Token(Token = "0x40347E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040347E4 RID: 215012
		[Token(Token = "0x40347E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x040347E5 RID: 215013
		[Token(Token = "0x40347E5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SendSorterMsg;

		// Token: 0x040347E6 RID: 215014
		[Token(Token = "0x40347E6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
