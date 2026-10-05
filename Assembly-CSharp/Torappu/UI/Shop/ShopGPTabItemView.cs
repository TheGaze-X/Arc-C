using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AEE RID: 23278
	[Token(Token = "0x2005AEE")]
	public class ShopGPTabItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021D4C RID: 138572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D4C")]
		[Address(RVA = "0x1C552D0", Offset = "0x1C53ED0", VA = "0x181C552D0")]
		public void Render(ShopGPTabItemModel itemModel, string selectedTabId)
		{
		}

		// Token: 0x06021D4D RID: 138573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D4D")]
		[Address(RVA = "0x1C551D0", Offset = "0x1C53DD0", VA = "0x181C551D0")]
		public void OnClick()
		{
		}

		// Token: 0x06021D4E RID: 138574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D4E")]
		[Address(RVA = "0x1C555F0", Offset = "0x1C541F0", VA = "0x181C555F0")]
		public ShopGPTabItemView()
		{
		}

		// Token: 0x0402E525 RID: 189733
		[Token(Token = "0x402E525")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _textOffColor;

		// Token: 0x0402E526 RID: 189734
		[Token(Token = "0x402E526")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _textOnColor;

		// Token: 0x0402E527 RID: 189735
		[Token(Token = "0x402E527")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TwoStateToggle _selectedToggle;

		// Token: 0x0402E528 RID: 189736
		[Token(Token = "0x402E528")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _tabNameText;

		// Token: 0x0402E529 RID: 189737
		[Token(Token = "0x402E529")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _tabIcon;

		// Token: 0x0402E52A RID: 189738
		[Token(Token = "0x402E52A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _markerIcon;

		// Token: 0x0402E52B RID: 189739
		[Token(Token = "0x402E52B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelTicket;

		// Token: 0x0402E52C RID: 189740
		[Token(Token = "0x402E52C")]
		[FieldOffset(Offset = "0x60")]
		private string m_cachedTabId;

		// Token: 0x0402E52D RID: 189741
		[Token(Token = "0x402E52D")]
		[FieldOffset(Offset = "0x68")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402E52E RID: 189742
		[Token(Token = "0x402E52E")]
		[FieldOffset(Offset = "0x78")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402E52F RID: 189743
		[Token(Token = "0x402E52F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402E530 RID: 189744
		[Token(Token = "0x402E530")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402E531 RID: 189745
		[Token(Token = "0x402E531")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
