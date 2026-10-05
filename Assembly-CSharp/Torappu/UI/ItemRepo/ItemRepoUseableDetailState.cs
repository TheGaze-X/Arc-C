using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.VoucherSkin;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E6F RID: 24175
	[Token(Token = "0x2005E6F")]
	public class ItemRepoUseableDetailState : ItemRepoItemDetailState
	{
		// Token: 0x0602309B RID: 143515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602309B")]
		[Address(RVA = "0x1DA3220", Offset = "0x1DA1E20", VA = "0x181DA3220", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602309C RID: 143516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602309C")]
		[Address(RVA = "0x1DA4430", Offset = "0x1DA3030", VA = "0x181DA4430")]
		private void _RenderTips(UIItemViewModel model)
		{
		}

		// Token: 0x0602309D RID: 143517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602309D")]
		[Address(RVA = "0x1DA4160", Offset = "0x1DA2D60", VA = "0x181DA4160")]
		private void _RenderApSupplyTips(UIItemViewModel model)
		{
		}

		// Token: 0x0602309E RID: 143518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602309E")]
		[Address(RVA = "0x1DA3300", Offset = "0x1DA1F00", VA = "0x181DA3300", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602309F RID: 143519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602309F")]
		[Address(RVA = "0x1DA2F50", Offset = "0x1DA1B50", VA = "0x181DA2F50")]
		public void OnClick()
		{
		}

		// Token: 0x060230A0 RID: 143520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60230A0")]
		[Address(RVA = "0x1DA3B20", Offset = "0x1DA2720", VA = "0x181DA3B20")]
		private void _FetchVoucherSkinGoodList(Action<List<VoucherSkinItemViewModel>, string> onFinish)
		{
		}

		// Token: 0x060230A1 RID: 143521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60230A1")]
		[Address(RVA = "0x1DA3D70", Offset = "0x1DA2970", VA = "0x181DA3D70")]
		private void _FetchVoucherSkinV2ItemList(Action<List<VoucherSkinItemViewModel>, string> onFinish)
		{
		}

		// Token: 0x060230A2 RID: 143522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60230A2")]
		[Address(RVA = "0x1DA4020", Offset = "0x1DA2C20", VA = "0x181DA4020")]
		private void _OpenVoucherSkinPage(List<VoucherSkinItemViewModel> skinItems, string ruleDesc)
		{
		}

		// Token: 0x060230A3 RID: 143523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60230A3")]
		[Address(RVA = "0x1DA2E80", Offset = "0x1DA1A80", VA = "0x181DA2E80")]
		public void EventOnVoucherPickItemClick(string itemId)
		{
		}

		// Token: 0x060230A4 RID: 143524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60230A4")]
		[Address(RVA = "0x1DA44B0", Offset = "0x1DA30B0", VA = "0x181DA44B0")]
		public ItemRepoUseableDetailState()
		{
		}

		// Token: 0x060230A9 RID: 143529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60230A9")]
		[Address(RVA = "0x1D8A5E0", Offset = "0x1D891E0", VA = "0x181D8A5E0")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060230AA RID: 143530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60230AA")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04030405 RID: 197637
		[Token(Token = "0x4030405")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private RectTransform _tipsContainer;

		// Token: 0x04030406 RID: 197638
		[Token(Token = "0x4030406")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UIStringEvent _voucherPickEvent;

		// Token: 0x04030407 RID: 197639
		[Token(Token = "0x4030407")]
		[FieldOffset(Offset = "0xD0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04030408 RID: 197640
		[Token(Token = "0x4030408")]
		[FieldOffset(Offset = "0xE0")]
		private GameObject m_apSupplyTips;

		// Token: 0x04030409 RID: 197641
		[Token(Token = "0x4030409")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_isUsePageFlag;

		// Token: 0x0403040A RID: 197642
		[Token(Token = "0x403040A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403040B RID: 197643
		[Token(Token = "0x403040B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderTips;

		// Token: 0x0403040C RID: 197644
		[Token(Token = "0x403040C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderApSupplyTips;

		// Token: 0x0403040D RID: 197645
		[Token(Token = "0x403040D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403040E RID: 197646
		[Token(Token = "0x403040E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403040F RID: 197647
		[Token(Token = "0x403040F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__FetchVoucherSkinGoodList;

		// Token: 0x04030410 RID: 197648
		[Token(Token = "0x4030410")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__FetchVoucherSkinV2ItemList;

		// Token: 0x04030411 RID: 197649
		[Token(Token = "0x4030411")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OpenVoucherSkinPage;

		// Token: 0x04030412 RID: 197650
		[Token(Token = "0x4030412")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnVoucherPickItemClick;

		// Token: 0x04030413 RID: 197651
		[Token(Token = "0x4030413")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
