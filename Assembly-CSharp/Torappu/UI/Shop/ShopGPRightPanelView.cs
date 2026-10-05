using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005ACE RID: 23246
	[Token(Token = "0x2005ACE")]
	public class ShopGPRightPanelView : DataBinder<ShopGPProperty>, IHotfixable
	{
		// Token: 0x06021C9F RID: 138399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C9F")]
		[Address(RVA = "0x1C50650", Offset = "0x1C4F250", VA = "0x181C50650", Slot = "7")]
		public override void OnValueChanged(ShopGPProperty property)
		{
		}

		// Token: 0x06021CA0 RID: 138400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021CA0")]
		private T _CreatePanel<T>(ShopGPPanelType type) where T : ShopGPDisplayPanelBase
		{
			return null;
		}

		// Token: 0x06021CA1 RID: 138401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CA1")]
		[Address(RVA = "0x1C509A0", Offset = "0x1C4F5A0", VA = "0x181C509A0")]
		private void _CreatePanelIfNecessary(ShopGPViewModel viewModel)
		{
		}

		// Token: 0x06021CA2 RID: 138402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CA2")]
		[Address(RVA = "0x1C50BA0", Offset = "0x1C4F7A0", VA = "0x181C50BA0")]
		private void _GeneratePanelIfNecessary(ShopGPPanelType panelType)
		{
		}

		// Token: 0x06021CA3 RID: 138403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CA3")]
		[Address(RVA = "0x1C50CC0", Offset = "0x1C4F8C0", VA = "0x181C50CC0")]
		public ShopGPRightPanelView()
		{
		}

		// Token: 0x0402E402 RID: 189442
		[Token(Token = "0x402E402")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _panelContainer;

		// Token: 0x0402E403 RID: 189443
		[Token(Token = "0x402E403")]
		[FieldOffset(Offset = "0x28")]
		private int m_cachedFastSeq;

		// Token: 0x0402E404 RID: 189444
		[Token(Token = "0x402E404")]
		[FieldOffset(Offset = "0x30")]
		private string m_cachedSelectedId;

		// Token: 0x0402E405 RID: 189445
		[Token(Token = "0x402E405")]
		[FieldOffset(Offset = "0x38")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402E406 RID: 189446
		[Token(Token = "0x402E406")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<int, ShopGPDisplayPanelBase> m_createdPanelDict;

		// Token: 0x0402E407 RID: 189447
		[Token(Token = "0x402E407")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402E408 RID: 189448
		[Token(Token = "0x402E408")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CreatePanel;

		// Token: 0x0402E409 RID: 189449
		[Token(Token = "0x402E409")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CreatePanelIfNecessary;

		// Token: 0x0402E40A RID: 189450
		[Token(Token = "0x402E40A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GeneratePanelIfNecessary;

		// Token: 0x0402E40B RID: 189451
		[Token(Token = "0x402E40B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
