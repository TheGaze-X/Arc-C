using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x0200194D RID: 6477
	[Token(Token = "0x200194D")]
	public class DIYShopPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x0600A2D4 RID: 41684 RVA: 0x0003F4C8 File Offset: 0x0003D6C8
		[Token(Token = "0x170012E4")]
		public bool shown
		{
			[Token(Token = "0x600A2D4")]
			[Address(RVA = "0x31CA680", Offset = "0x31C9280", VA = "0x1831CA680")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600A2D5 RID: 41685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2D5")]
		[Address(RVA = "0x31C7FB0", Offset = "0x31C6BB0", VA = "0x1831C7FB0")]
		private void _OnViewItemSelected(DIYShopFilterViewData data)
		{
		}

		// Token: 0x0600A2D6 RID: 41686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2D6")]
		[Address(RVA = "0x31C7E30", Offset = "0x31C6A30", VA = "0x1831C7E30")]
		private void _OnViewInfoSelected(DIYShopFilterViewData data)
		{
		}

		// Token: 0x0600A2D7 RID: 41687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2D7")]
		[Address(RVA = "0x31C7CD0", Offset = "0x31C68D0", VA = "0x1831C7CD0")]
		private void _OnViewDescSelected(DIYShopFilterViewData data)
		{
		}

		// Token: 0x0600A2D8 RID: 41688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2D8")]
		[Address(RVA = "0x31C8890", Offset = "0x31C7490", VA = "0x1831C8890")]
		private void _SetFilterSelection(DIYShopFilterViewData data)
		{
		}

		// Token: 0x0600A2D9 RID: 41689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2D9")]
		[Address(RVA = "0x31C8AF0", Offset = "0x31C76F0", VA = "0x1831C8AF0")]
		private void _SetThemeFilterSelection(DIYShopFilterViewData data)
		{
		}

		// Token: 0x0600A2DA RID: 41690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2DA")]
		[Address(RVA = "0x31C7310", Offset = "0x31C5F10", VA = "0x1831C7310")]
		private void _OnShopItemSelected(DIYShopItemViewData data)
		{
		}

		// Token: 0x0600A2DB RID: 41691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2DB")]
		[Address(RVA = "0x31C8D50", Offset = "0x31C7950", VA = "0x1831C8D50")]
		private void _ShowOKDialog(string content, [Optional] Action okAction)
		{
		}

		// Token: 0x0600A2DC RID: 41692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2DC")]
		[Address(RVA = "0x31C7010", Offset = "0x31C5C10", VA = "0x1831C7010")]
		private void _OnBuyItemCommand(IDIYShopItem shopItem, int cashCount, int furnitureCoinCount)
		{
		}

		// Token: 0x0600A2DD RID: 41693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2DD")]
		[Address(RVA = "0x31C8EA0", Offset = "0x31C7AA0", VA = "0x1831C8EA0")]
		private void _UpdateFurnitureGroupView(string themeId, [Optional] Predicate<IDIYShopItem> filter, [Optional] Comparison<IDIYShopItem> sorter)
		{
		}

		// Token: 0x0600A2DE RID: 41694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2DE")]
		[Address(RVA = "0x31C9130", Offset = "0x31C7D30", VA = "0x1831C9130")]
		private void _UpdateFurnitureList([Optional] Predicate<IDIYShopItem> pred)
		{
		}

		// Token: 0x0600A2DF RID: 41695 RVA: 0x0003F4E0 File Offset: 0x0003D6E0
		[Token(Token = "0x600A2DF")]
		[Address(RVA = "0x31C6C50", Offset = "0x31C5850", VA = "0x1831C6C50")]
		private int _GetShopItemCountOfTheme(string themeId)
		{
			return 0;
		}

		// Token: 0x0600A2E0 RID: 41696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2E0")]
		[Address(RVA = "0x31CA070", Offset = "0x31C8C70", VA = "0x1831CA070")]
		private void _UpdateTabsByTheme([Optional] Predicate<IDIYShopItem> filter, [Optional] Comparison<IDIYShopItem> sorter)
		{
		}

		// Token: 0x0600A2E1 RID: 41697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2E1")]
		[Address(RVA = "0x31C9980", Offset = "0x31C8580", VA = "0x1831C9980")]
		private void _UpdateTabsByGenre(int index)
		{
		}

		// Token: 0x0600A2E2 RID: 41698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2E2")]
		[Address(RVA = "0x31C5510", Offset = "0x31C4110", VA = "0x1831C5510")]
		public void Setup(IDIYShop shop)
		{
		}

		// Token: 0x0600A2E3 RID: 41699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2E3")]
		[Address(RVA = "0x31C69F0", Offset = "0x31C55F0", VA = "0x1831C69F0")]
		public void UpdateView()
		{
		}

		// Token: 0x0600A2E4 RID: 41700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2E4")]
		[Address(RVA = "0x31C97C0", Offset = "0x31C83C0", VA = "0x1831C97C0")]
		private void _UpdateResources()
		{
		}

		// Token: 0x0600A2E5 RID: 41701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2E5")]
		[Address(RVA = "0x31C8280", Offset = "0x31C6E80", VA = "0x1831C8280")]
		private void _PanelTweenCallback(float val)
		{
		}

		// Token: 0x0600A2E6 RID: 41702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2E6")]
		[Address(RVA = "0x31C5D70", Offset = "0x31C4970", VA = "0x1831C5D70")]
		public void Show([Optional] Action hideCallback)
		{
		}

		// Token: 0x0600A2E7 RID: 41703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2E7")]
		[Address(RVA = "0x31C4B60", Offset = "0x31C3760", VA = "0x1831C4B60")]
		public void Hide(bool needTween)
		{
		}

		// Token: 0x0600A2E8 RID: 41704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2E8")]
		[Address(RVA = "0x31C4A80", Offset = "0x31C3680", VA = "0x1831C4A80")]
		public void HandleBackCommon()
		{
		}

		// Token: 0x0600A2E9 RID: 41705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A2E9")]
		[Address(RVA = "0x31C6B60", Offset = "0x31C5760", VA = "0x1831C6B60")]
		private Predicate<IDIYShopItem> _GetShopFilterFunction(IEnumerable<DIYSortPanel.FilterSetting> settings)
		{
			return null;
		}

		// Token: 0x0600A2EA RID: 41706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2EA")]
		[Address(RVA = "0x31C8500", Offset = "0x31C7100", VA = "0x1831C8500")]
		private void _RefreshFurnitureCount()
		{
		}

		// Token: 0x0600A2EB RID: 41707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2EB")]
		[Address(RVA = "0x31C5270", Offset = "0x31C3E70", VA = "0x1831C5270")]
		public void OnFilterButtonPressed()
		{
		}

		// Token: 0x0600A2EC RID: 41708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2EC")]
		[Address(RVA = "0x31C53E0", Offset = "0x31C3FE0", VA = "0x1831C53E0")]
		public void OnThemeButtonPressed()
		{
		}

		// Token: 0x0600A2ED RID: 41709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2ED")]
		[Address(RVA = "0x31C5380", Offset = "0x31C3F80", VA = "0x1831C5380")]
		public void OnGroundButtonPresed()
		{
		}

		// Token: 0x0600A2EE RID: 41710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2EE")]
		[Address(RVA = "0x31C54B0", Offset = "0x31C40B0", VA = "0x1831C54B0")]
		public void OnWallButtonPresed()
		{
		}

		// Token: 0x0600A2EF RID: 41711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2EF")]
		[Address(RVA = "0x31C4F90", Offset = "0x31C3B90", VA = "0x1831C4F90")]
		public void OnCeilingButtonPresed()
		{
		}

		// Token: 0x0600A2F0 RID: 41712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2F0")]
		[Address(RVA = "0x31C4F10", Offset = "0x31C3B10", VA = "0x1831C4F10")]
		public void OnBackgroundPressed()
		{
		}

		// Token: 0x0600A2F1 RID: 41713 RVA: 0x0003F4F8 File Offset: 0x0003D6F8
		[Token(Token = "0x600A2F1")]
		[Address(RVA = "0x31C6AC0", Offset = "0x31C56C0", VA = "0x1831C6AC0")]
		private static int _GetFurnitureTotalCount(string furnitureId, IFurnitureStorage storage)
		{
			return 0;
		}

		// Token: 0x0600A2F2 RID: 41714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2F2")]
		[Address(RVA = "0x31C4FF0", Offset = "0x31C3BF0", VA = "0x1831C4FF0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600A2F3 RID: 41715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2F3")]
		[Address(RVA = "0x31CA5D0", Offset = "0x31C91D0", VA = "0x1831CA5D0")]
		public DIYShopPanel()
		{
		}

		// Token: 0x04009947 RID: 39239
		[Token(Token = "0x4009947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DIYFilterItemViewAdapter _filterAdapter;

		// Token: 0x04009948 RID: 39240
		[Token(Token = "0x4009948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DIYFilterItemViewAdapter _themeFilterAdapter;

		// Token: 0x04009949 RID: 39241
		[Token(Token = "0x4009949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DIYShopItemViewAdapter _furnitureAdapter;

		// Token: 0x0400994A RID: 39242
		[Token(Token = "0x400994A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private DIYFurnitureFilterGroup _filterGroup;

		// Token: 0x0400994B RID: 39243
		[Token(Token = "0x400994B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FurnitureGenreConfig _furnitureGenreConfig;

		// Token: 0x0400994C RID: 39244
		[Token(Token = "0x400994C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIDIYFurnitureTypeIconHub _typeIcons;

		// Token: 0x0400994D RID: 39245
		[Token(Token = "0x400994D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private DIYShopBuyPanel _buyPanel;

		// Token: 0x0400994E RID: 39246
		[Token(Token = "0x400994E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _cashLabel;

		// Token: 0x0400994F RID: 39247
		[Token(Token = "0x400994F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _furnitureCoinLabel;

		// Token: 0x04009950 RID: 39248
		[Token(Token = "0x4009950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _mainPanel;

		// Token: 0x04009951 RID: 39249
		[Token(Token = "0x4009951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private DIYSortPanel _diySortPanel;

		// Token: 0x04009952 RID: 39250
		[Token(Token = "0x4009952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private DIYShopGroupPanel _shopGroupPanel;

		// Token: 0x04009953 RID: 39251
		[Token(Token = "0x4009953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _backgroundImage;

		// Token: 0x04009954 RID: 39252
		[Token(Token = "0x4009954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private IDIYShop m_diyShop;

		// Token: 0x04009955 RID: 39253
		[Token(Token = "0x4009955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool m_shown;

		// Token: 0x04009956 RID: 39254
		[Token(Token = "0x4009956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private DIYShopFilterViewData m_lastFilterData;

		// Token: 0x04009957 RID: 39255
		[Token(Token = "0x4009957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Predicate<IDIYShopItem> m_currentFurnitureListPredicator;

		// Token: 0x04009958 RID: 39256
		[Token(Token = "0x4009958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool m_tweening;

		// Token: 0x04009959 RID: 39257
		[Token(Token = "0x4009959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private List<DIYShopItemViewData> m_currentItemViewData;

		// Token: 0x0400995A RID: 39258
		[Token(Token = "0x400995A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private FurnitureSorter m_sorter;

		// Token: 0x0400995B RID: 39259
		[Token(Token = "0x400995B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Predicate<IDIYShopItem> m_filterFunction;

		// Token: 0x0400995C RID: 39260
		[Token(Token = "0x400995C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Func<IDIYShopItem, IDIYShopItem, int> m_sortFunction;

		// Token: 0x0400995D RID: 39261
		[Token(Token = "0x400995D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Action m_hideCallback;

		// Token: 0x0400995E RID: 39262
		[Token(Token = "0x400995E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_shown;

		// Token: 0x0400995F RID: 39263
		[Token(Token = "0x400995F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnViewItemSelected;

		// Token: 0x04009960 RID: 39264
		[Token(Token = "0x4009960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnViewInfoSelected;

		// Token: 0x04009961 RID: 39265
		[Token(Token = "0x4009961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnViewDescSelected;

		// Token: 0x04009962 RID: 39266
		[Token(Token = "0x4009962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetFilterSelection;

		// Token: 0x04009963 RID: 39267
		[Token(Token = "0x4009963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetThemeFilterSelection;

		// Token: 0x04009964 RID: 39268
		[Token(Token = "0x4009964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnShopItemSelected;

		// Token: 0x04009965 RID: 39269
		[Token(Token = "0x4009965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ShowOKDialog;

		// Token: 0x04009966 RID: 39270
		[Token(Token = "0x4009966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnBuyItemCommand;

		// Token: 0x04009967 RID: 39271
		[Token(Token = "0x4009967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateFurnitureGroupView;

		// Token: 0x04009968 RID: 39272
		[Token(Token = "0x4009968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateFurnitureList;

		// Token: 0x04009969 RID: 39273
		[Token(Token = "0x4009969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GetShopItemCountOfTheme;

		// Token: 0x0400996A RID: 39274
		[Token(Token = "0x400996A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateTabsByTheme;

		// Token: 0x0400996B RID: 39275
		[Token(Token = "0x400996B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UpdateTabsByGenre;

		// Token: 0x0400996C RID: 39276
		[Token(Token = "0x400996C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x0400996D RID: 39277
		[Token(Token = "0x400996D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0400996E RID: 39278
		[Token(Token = "0x400996E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__UpdateResources;

		// Token: 0x0400996F RID: 39279
		[Token(Token = "0x400996F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__PanelTweenCallback;

		// Token: 0x04009970 RID: 39280
		[Token(Token = "0x4009970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04009971 RID: 39281
		[Token(Token = "0x4009971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x04009972 RID: 39282
		[Token(Token = "0x4009972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_HandleBackCommon;

		// Token: 0x04009973 RID: 39283
		[Token(Token = "0x4009973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__GetShopFilterFunction;

		// Token: 0x04009974 RID: 39284
		[Token(Token = "0x4009974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__RefreshFurnitureCount;

		// Token: 0x04009975 RID: 39285
		[Token(Token = "0x4009975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnFilterButtonPressed;

		// Token: 0x04009976 RID: 39286
		[Token(Token = "0x4009976")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnThemeButtonPressed;

		// Token: 0x04009977 RID: 39287
		[Token(Token = "0x4009977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnGroundButtonPresed;

		// Token: 0x04009978 RID: 39288
		[Token(Token = "0x4009978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnWallButtonPresed;

		// Token: 0x04009979 RID: 39289
		[Token(Token = "0x4009979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_OnCeilingButtonPresed;

		// Token: 0x0400997A RID: 39290
		[Token(Token = "0x400997A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_OnBackgroundPressed;

		// Token: 0x0400997B RID: 39291
		[Token(Token = "0x400997B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__GetFurnitureTotalCount;

		// Token: 0x0400997C RID: 39292
		[Token(Token = "0x400997C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400997D RID: 39293
		[Token(Token = "0x400997D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200194E RID: 6478
		[Token(Token = "0x200194E")]
		public class DIYShopInnerItemViewData : DIYItemViewData
		{
			// Token: 0x0600A2FD RID: 41725 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A2FD")]
			[Address(RVA = "0x31E2B50", Offset = "0x31E1750", VA = "0x1831E2B50", Slot = "22")]
			public override string GetDisplayName()
			{
				return null;
			}

			// Token: 0x0600A2FE RID: 41726 RVA: 0x0003F588 File Offset: 0x0003D788
			[Token(Token = "0x600A2FE")]
			[Address(RVA = "0x31E2BD0", Offset = "0x31E17D0", VA = "0x1831E2BD0", Slot = "23")]
			public override int GetRarity()
			{
				return 0;
			}

			// Token: 0x0600A2FF RID: 41727 RVA: 0x0003F5A0 File Offset: 0x0003D7A0
			[Token(Token = "0x600A2FF")]
			[Address(RVA = "0x31E2C50", Offset = "0x31E1850", VA = "0x1831E2C50", Slot = "10")]
			public override bool ShowCount()
			{
				return default(bool);
			}

			// Token: 0x0600A300 RID: 41728 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A300")]
			[Address(RVA = "0x31E2AD0", Offset = "0x31E16D0", VA = "0x1831E2AD0", Slot = "4")]
			public override Sprite GetBigSprite()
			{
				return null;
			}

			// Token: 0x0600A301 RID: 41729 RVA: 0x0003F5B8 File Offset: 0x0003D7B8
			[Token(Token = "0x600A301")]
			[Address(RVA = "0x31E2A70", Offset = "0x31E1670", VA = "0x1831E2A70", Slot = "21")]
			public override bool ButtonValid()
			{
				return default(bool);
			}

			// Token: 0x0600A302 RID: 41730 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A302")]
			[Address(RVA = "0x31E2CB0", Offset = "0x31E18B0", VA = "0x1831E2CB0")]
			public DIYShopInnerItemViewData()
			{
			}

			// Token: 0x0600A303 RID: 41731 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A303")]
			[Address(RVA = "0x31DF880", Offset = "0x31DE480", VA = "0x1831DF880")]
			private string <>xLuaBaseProxy_GetDisplayName()
			{
				return null;
			}

			// Token: 0x0600A304 RID: 41732 RVA: 0x0003F5D0 File Offset: 0x0003D7D0
			[Token(Token = "0x600A304")]
			[Address(RVA = "0x31E0A40", Offset = "0x31DF640", VA = "0x1831E0A40")]
			private int <>xLuaBaseProxy_GetRarity()
			{
				return 0;
			}

			// Token: 0x0600A305 RID: 41733 RVA: 0x0003F5E8 File Offset: 0x0003D7E8
			[Token(Token = "0x600A305")]
			[Address(RVA = "0x31E1060", Offset = "0x31DFC60", VA = "0x1831E1060")]
			private bool <>xLuaBaseProxy_ShowCount()
			{
				return default(bool);
			}

			// Token: 0x0600A306 RID: 41734 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A306")]
			[Address(RVA = "0x31DF7C0", Offset = "0x31DE3C0", VA = "0x1831DF7C0")]
			private Sprite <>xLuaBaseProxy_GetBigSprite()
			{
				return null;
			}

			// Token: 0x0600A307 RID: 41735 RVA: 0x0003F600 File Offset: 0x0003D800
			[Token(Token = "0x600A307")]
			[Address(RVA = "0x31DF760", Offset = "0x31DE360", VA = "0x1831DF760")]
			private bool <>xLuaBaseProxy_ButtonValid()
			{
				return default(bool);
			}

			// Token: 0x0400997E RID: 39294
			[Token(Token = "0x400997E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public new IDIYItem diyItem;

			// Token: 0x0400997F RID: 39295
			[Token(Token = "0x400997F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetDisplayName;

			// Token: 0x04009980 RID: 39296
			[Token(Token = "0x4009980")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetRarity;

			// Token: 0x04009981 RID: 39297
			[Token(Token = "0x4009981")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ShowCount;

			// Token: 0x04009982 RID: 39298
			[Token(Token = "0x4009982")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetBigSprite;

			// Token: 0x04009983 RID: 39299
			[Token(Token = "0x4009983")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_ButtonValid;

			// Token: 0x04009984 RID: 39300
			[Token(Token = "0x4009984")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
