using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AE8 RID: 23272
	[Token(Token = "0x2005AE8")]
	public class ShopGPViewModel : IHotfixable
	{
		// Token: 0x17004F2A RID: 20266
		// (get) Token: 0x06021D30 RID: 138544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F2A")]
		public string selectedTabId
		{
			[Token(Token = "0x6021D30")]
			[Address(RVA = "0x1C56FA0", Offset = "0x1C55BA0", VA = "0x181C56FA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004F2B RID: 20267
		// (get) Token: 0x06021D31 RID: 138545 RVA: 0x000BB590 File Offset: 0x000B9790
		[Token(Token = "0x17004F2B")]
		public int enterSeq
		{
			[Token(Token = "0x6021D31")]
			[Address(RVA = "0x1C56EE0", Offset = "0x1C55AE0", VA = "0x181C56EE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004F2C RID: 20268
		// (get) Token: 0x06021D32 RID: 138546 RVA: 0x000BB5A8 File Offset: 0x000B97A8
		[Token(Token = "0x17004F2C")]
		public int fastSeq
		{
			[Token(Token = "0x6021D32")]
			[Address(RVA = "0x1C56F40", Offset = "0x1C55B40", VA = "0x181C56F40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06021D33 RID: 138547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D33")]
		[Address(RVA = "0x1C55C70", Offset = "0x1C54870", VA = "0x181C55C70")]
		public void RefreshData(List<ShopGPCommonItemViewModel> shopItemList, List<ShopGPCommonItemViewModel> soldOutItemList)
		{
		}

		// Token: 0x06021D34 RID: 138548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D34")]
		[Address(RVA = "0x1C56370", Offset = "0x1C54F70", VA = "0x181C56370")]
		public void SelectTab(string selectedTabId)
		{
		}

		// Token: 0x06021D35 RID: 138549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D35")]
		[Address(RVA = "0x1C563F0", Offset = "0x1C54FF0", VA = "0x181C563F0")]
		public void TrySelectFirstNotAllTab()
		{
		}

		// Token: 0x06021D36 RID: 138550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D36")]
		[Address(RVA = "0x1C55BB0", Offset = "0x1C547B0", VA = "0x181C55BB0")]
		public void NotifyEnter()
		{
		}

		// Token: 0x06021D37 RID: 138551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D37")]
		[Address(RVA = "0x1C55C10", Offset = "0x1C54810", VA = "0x181C55C10")]
		public void NotifyFast()
		{
		}

		// Token: 0x06021D38 RID: 138552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D38")]
		[Address(RVA = "0x1C567B0", Offset = "0x1C553B0", VA = "0x181C567B0")]
		private void _CollectValidTabSet(List<ShopGPCommonItemViewModel> itemList, List<ShopGPCommonItemViewModel> soldOutItemList, ref Dictionary<string, ShopGpTabGroupModel> tabGroups)
		{
		}

		// Token: 0x06021D39 RID: 138553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D39")]
		[Address(RVA = "0x1C564D0", Offset = "0x1C550D0", VA = "0x181C564D0")]
		private void _CollectTabGrp(List<ShopGPCommonItemViewModel> itemList, Dictionary<string, ShopGpTabGroupModel> tabGroups, Action<ShopGPCommonItemViewModel, ShopGpTabGroupModel> actionOnGrp)
		{
		}

		// Token: 0x06021D3A RID: 138554 RVA: 0x000BB5C0 File Offset: 0x000B97C0
		[Token(Token = "0x6021D3A")]
		[Address(RVA = "0x1C56C30", Offset = "0x1C55830", VA = "0x181C56C30")]
		private bool _IsTabTimeValid(ShopGPTabDisplayData data, long timeStampNow)
		{
			return default(bool);
		}

		// Token: 0x06021D3B RID: 138555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021D3B")]
		[Address(RVA = "0x1C56A10", Offset = "0x1C55610", VA = "0x181C56A10")]
		private AbstractShopGPPanelModel _GetPanelModelByType(ShopGPTabType tabType)
		{
			return null;
		}

		// Token: 0x06021D3C RID: 138556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D3C")]
		[Address(RVA = "0x1C56D00", Offset = "0x1C55900", VA = "0x181C56D00")]
		public ShopGPViewModel()
		{
		}

		// Token: 0x0402E4FA RID: 189690
		[Token(Token = "0x402E4FA")]
		[FieldOffset(Offset = "0x10")]
		public ShopGPCommonSortPanelModel panelAllModel;

		// Token: 0x0402E4FB RID: 189691
		[Token(Token = "0x402E4FB")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, ShopGPTabItemModel> tabDict;

		// Token: 0x0402E4FC RID: 189692
		[Token(Token = "0x402E4FC")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, AbstractShopGPPanelModel> panelDict;

		// Token: 0x0402E4FD RID: 189693
		[Token(Token = "0x402E4FD")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, ShopGPCommonItemViewModel> viewModelDict;

		// Token: 0x0402E4FE RID: 189694
		[Token(Token = "0x402E4FE")]
		[FieldOffset(Offset = "0x30")]
		private int m_enterSeqNum;

		// Token: 0x0402E4FF RID: 189695
		[Token(Token = "0x402E4FF")]
		[FieldOffset(Offset = "0x34")]
		private int m_fastSeqNum;

		// Token: 0x0402E500 RID: 189696
		[Token(Token = "0x402E500")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, ShopGpTabGroupModel> m_validTab;

		// Token: 0x0402E501 RID: 189697
		[Token(Token = "0x402E501")]
		[FieldOffset(Offset = "0x40")]
		private string m_selectedTabId;

		// Token: 0x0402E502 RID: 189698
		[Token(Token = "0x402E502")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedTabId;

		// Token: 0x0402E503 RID: 189699
		[Token(Token = "0x402E503")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enterSeq;

		// Token: 0x0402E504 RID: 189700
		[Token(Token = "0x402E504")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_fastSeq;

		// Token: 0x0402E505 RID: 189701
		[Token(Token = "0x402E505")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0402E506 RID: 189702
		[Token(Token = "0x402E506")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SelectTab;

		// Token: 0x0402E507 RID: 189703
		[Token(Token = "0x402E507")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TrySelectFirstNotAllTab;

		// Token: 0x0402E508 RID: 189704
		[Token(Token = "0x402E508")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_NotifyEnter;

		// Token: 0x0402E509 RID: 189705
		[Token(Token = "0x402E509")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_NotifyFast;

		// Token: 0x0402E50A RID: 189706
		[Token(Token = "0x402E50A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CollectValidTabSet;

		// Token: 0x0402E50B RID: 189707
		[Token(Token = "0x402E50B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CollectTabGrp;

		// Token: 0x0402E50C RID: 189708
		[Token(Token = "0x402E50C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__IsTabTimeValid;

		// Token: 0x0402E50D RID: 189709
		[Token(Token = "0x402E50D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GetPanelModelByType;

		// Token: 0x0402E50E RID: 189710
		[Token(Token = "0x402E50E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
