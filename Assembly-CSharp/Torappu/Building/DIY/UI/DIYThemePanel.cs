using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x0200196B RID: 6507
	[Token(Token = "0x200196B")]
	public class DIYThemePanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x0600A373 RID: 41843 RVA: 0x0003F810 File Offset: 0x0003DA10
		[Token(Token = "0x170012F4")]
		public bool shown
		{
			[Token(Token = "0x600A373")]
			[Address(RVA = "0x31E8BF0", Offset = "0x31E77F0", VA = "0x1831E8BF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600A374 RID: 41844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A374")]
		[Address(RVA = "0x31E7B70", Offset = "0x31E6770", VA = "0x1831E7B70")]
		private void _OnViewItemSelected(DIYShopFilterViewData data)
		{
		}

		// Token: 0x0600A375 RID: 41845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A375")]
		[Address(RVA = "0x31E79F0", Offset = "0x31E65F0", VA = "0x1831E79F0")]
		private void _OnViewInfoSelected(DIYShopFilterViewData data)
		{
		}

		// Token: 0x0600A376 RID: 41846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A376")]
		[Address(RVA = "0x31E7890", Offset = "0x31E6490", VA = "0x1831E7890")]
		private void _OnViewDescSelected(DIYShopFilterViewData data)
		{
		}

		// Token: 0x0600A377 RID: 41847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A377")]
		[Address(RVA = "0x31E7DC0", Offset = "0x31E69C0", VA = "0x1831E7DC0")]
		private void _SetFilterSelection(DIYShopFilterViewData data)
		{
		}

		// Token: 0x0600A378 RID: 41848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A378")]
		[Address(RVA = "0x31E7800", Offset = "0x31E6400", VA = "0x1831E7800")]
		private void _OnFurnitureItemSelected(IDIYItem data)
		{
		}

		// Token: 0x0600A379 RID: 41849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A379")]
		[Address(RVA = "0x31E7780", Offset = "0x31E6380", VA = "0x1831E7780")]
		private void _OnFurnitureInfoButtonPressed(DIYItemViewData viewData)
		{
		}

		// Token: 0x0600A37A RID: 41850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A37A")]
		[Address(RVA = "0x31E8020", Offset = "0x31E6C20", VA = "0x1831E8020")]
		private void _ShowOKDialog(string content, [Optional] Action okAction)
		{
		}

		// Token: 0x0600A37B RID: 41851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A37B")]
		[Address(RVA = "0x31E75B0", Offset = "0x31E61B0", VA = "0x1831E75B0")]
		private void _OnBuyItemCommand(IDIYShopItem shopItem, int cashCount, int furnitureCoinCount)
		{
		}

		// Token: 0x0600A37C RID: 41852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A37C")]
		[Address(RVA = "0x31E8170", Offset = "0x31E6D70", VA = "0x1831E8170")]
		public void _UpdateGroupListWithTheme(string themeId)
		{
		}

		// Token: 0x0600A37D RID: 41853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A37D")]
		[Address(RVA = "0x31E8420", Offset = "0x31E7020", VA = "0x1831E8420")]
		private void _UpdateTabsByTheme()
		{
		}

		// Token: 0x0600A37E RID: 41854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A37E")]
		[Address(RVA = "0x31E6C50", Offset = "0x31E5850", VA = "0x1831E6C50")]
		public void Setup(IFurnitureProvider furnitureProvider, IDIYRoomModifierProvider modifierProvider)
		{
		}

		// Token: 0x0600A37F RID: 41855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A37F")]
		[Address(RVA = "0x31E74B0", Offset = "0x31E60B0", VA = "0x1831E74B0")]
		public void UpdateView()
		{
		}

		// Token: 0x0600A380 RID: 41856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A380")]
		[Address(RVA = "0x31E7CA0", Offset = "0x31E68A0", VA = "0x1831E7CA0")]
		private void _PanelTweenCallback(float val)
		{
		}

		// Token: 0x0600A381 RID: 41857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A381")]
		[Address(RVA = "0x31E7060", Offset = "0x31E5C60", VA = "0x1831E7060")]
		public void Show([Optional] Action hideCallback, [Optional] Action<IDIYItem> selectCallback, [Optional] Action<string> oneClickSetupCallback, [Optional] Action<DIYItemViewData> furnitureInfoButtonCallback)
		{
		}

		// Token: 0x0600A382 RID: 41858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A382")]
		[Address(RVA = "0x31E6580", Offset = "0x31E5180", VA = "0x1831E6580")]
		public void Hide(bool needTween)
		{
		}

		// Token: 0x0600A383 RID: 41859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A383")]
		[Address(RVA = "0x31E6BF0", Offset = "0x31E57F0", VA = "0x1831E6BF0")]
		public void OnThemeButtonPressed()
		{
		}

		// Token: 0x0600A384 RID: 41860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A384")]
		[Address(RVA = "0x31E6920", Offset = "0x31E5520", VA = "0x1831E6920")]
		public void OnBackgroundPressed()
		{
		}

		// Token: 0x0600A385 RID: 41861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A385")]
		[Address(RVA = "0x31E6B50", Offset = "0x31E5750", VA = "0x1831E6B50")]
		public void OnOneClickSetupButtonPressed()
		{
		}

		// Token: 0x0600A386 RID: 41862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A386")]
		[Address(RVA = "0x31E69A0", Offset = "0x31E55A0", VA = "0x1831E69A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600A387 RID: 41863 RVA: 0x0003F828 File Offset: 0x0003DA28
		[Token(Token = "0x600A387")]
		[Address(RVA = "0x31E7510", Offset = "0x31E6110", VA = "0x1831E7510")]
		private static int _GetFurnitureTotalCount(string furnitureId, IFurnitureStorage storage)
		{
			return 0;
		}

		// Token: 0x0600A388 RID: 41864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A388")]
		[Address(RVA = "0x31E8B90", Offset = "0x31E7790", VA = "0x1831E8B90")]
		public DIYThemePanel()
		{
		}

		// Token: 0x040099E5 RID: 39397
		[Token(Token = "0x40099E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DIYFilterItemViewAdapter _filterAdapter;

		// Token: 0x040099E6 RID: 39398
		[Token(Token = "0x40099E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DIYThemeGroupPanel _themeGroupPanel;

		// Token: 0x040099E7 RID: 39399
		[Token(Token = "0x40099E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FurnitureGenreConfig _furnitureGenreConfig;

		// Token: 0x040099E8 RID: 39400
		[Token(Token = "0x40099E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _mainPanel;

		// Token: 0x040099E9 RID: 39401
		[Token(Token = "0x40099E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_shown;

		// Token: 0x040099EA RID: 39402
		[Token(Token = "0x40099EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool m_tweening;

		// Token: 0x040099EB RID: 39403
		[Token(Token = "0x40099EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<DIYItemViewData> m_currentItemViewData;

		// Token: 0x040099EC RID: 39404
		[Token(Token = "0x40099EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Action m_hideCallback;

		// Token: 0x040099ED RID: 39405
		[Token(Token = "0x40099ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Action<IDIYItem> m_itemSelectCallback;

		// Token: 0x040099EE RID: 39406
		[Token(Token = "0x40099EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Action<string> m_oneClickSetupCallback;

		// Token: 0x040099EF RID: 39407
		[Token(Token = "0x40099EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Action<DIYItemViewData> m_furnitureInfoCallback;

		// Token: 0x040099F0 RID: 39408
		[Token(Token = "0x40099F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private IFurnitureStorage m_storage;

		// Token: 0x040099F1 RID: 39409
		[Token(Token = "0x40099F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private IFurnitureProvider m_furnitureProvider;

		// Token: 0x040099F2 RID: 39410
		[Token(Token = "0x40099F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IDIYRoomModifierProvider m_modifierProvider;

		// Token: 0x040099F3 RID: 39411
		[Token(Token = "0x40099F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private IFurnitureDataProvider m_furnitureDatabase;

		// Token: 0x040099F4 RID: 39412
		[Token(Token = "0x40099F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private IDIYRoomModifierDataProvider m_modifierDatabase;

		// Token: 0x040099F5 RID: 39413
		[Token(Token = "0x40099F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private DIYShopFilterViewData m_lastFilterData;

		// Token: 0x040099F6 RID: 39414
		[Token(Token = "0x40099F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private string m_currentThemeId;

		// Token: 0x040099F7 RID: 39415
		[Token(Token = "0x40099F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_shown;

		// Token: 0x040099F8 RID: 39416
		[Token(Token = "0x40099F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnViewItemSelected;

		// Token: 0x040099F9 RID: 39417
		[Token(Token = "0x40099F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnViewInfoSelected;

		// Token: 0x040099FA RID: 39418
		[Token(Token = "0x40099FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnViewDescSelected;

		// Token: 0x040099FB RID: 39419
		[Token(Token = "0x40099FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetFilterSelection;

		// Token: 0x040099FC RID: 39420
		[Token(Token = "0x40099FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnFurnitureItemSelected;

		// Token: 0x040099FD RID: 39421
		[Token(Token = "0x40099FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnFurnitureInfoButtonPressed;

		// Token: 0x040099FE RID: 39422
		[Token(Token = "0x40099FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ShowOKDialog;

		// Token: 0x040099FF RID: 39423
		[Token(Token = "0x40099FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnBuyItemCommand;

		// Token: 0x04009A00 RID: 39424
		[Token(Token = "0x4009A00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateGroupListWithTheme;

		// Token: 0x04009A01 RID: 39425
		[Token(Token = "0x4009A01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateTabsByTheme;

		// Token: 0x04009A02 RID: 39426
		[Token(Token = "0x4009A02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x04009A03 RID: 39427
		[Token(Token = "0x4009A03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04009A04 RID: 39428
		[Token(Token = "0x4009A04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__PanelTweenCallback;

		// Token: 0x04009A05 RID: 39429
		[Token(Token = "0x4009A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04009A06 RID: 39430
		[Token(Token = "0x4009A06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x04009A07 RID: 39431
		[Token(Token = "0x4009A07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnThemeButtonPressed;

		// Token: 0x04009A08 RID: 39432
		[Token(Token = "0x4009A08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnBackgroundPressed;

		// Token: 0x04009A09 RID: 39433
		[Token(Token = "0x4009A09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnOneClickSetupButtonPressed;

		// Token: 0x04009A0A RID: 39434
		[Token(Token = "0x4009A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04009A0B RID: 39435
		[Token(Token = "0x4009A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__GetFurnitureTotalCount;

		// Token: 0x04009A0C RID: 39436
		[Token(Token = "0x4009A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
