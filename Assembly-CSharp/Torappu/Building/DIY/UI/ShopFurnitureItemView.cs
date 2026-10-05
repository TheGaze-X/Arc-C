using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Building.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019B8 RID: 6584
	[Token(Token = "0x20019B8")]
	public class ShopFurnitureItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x14000054 RID: 84
		// (add) Token: 0x0600A56E RID: 42350 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600A56F RID: 42351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000054")]
		public event Action<DIYShopItemViewData, ShopFurnitureItemView> buttonPressed
		{
			[Token(Token = "0x600A56E")]
			[Address(RVA = "0x3200040", Offset = "0x31FEC40", VA = "0x183200040")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600A56F")]
			[Address(RVA = "0x3200140", Offset = "0x31FED40", VA = "0x183200140")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600A570 RID: 42352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A570")]
		[Address(RVA = "0x31FFEA0", Offset = "0x31FEAA0", VA = "0x1831FFEA0")]
		private void _SetupIcon(Image img, Sprite sp)
		{
		}

		// Token: 0x0600A571 RID: 42353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A571")]
		[Address(RVA = "0x31FFD70", Offset = "0x31FE970", VA = "0x1831FFD70")]
		public void Setup(DIYShopItemViewData data)
		{
		}

		// Token: 0x0600A572 RID: 42354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A572")]
		[Address(RVA = "0x31FF5D0", Offset = "0x31FE1D0", VA = "0x1831FF5D0")]
		public void Refresh()
		{
		}

		// Token: 0x0600A573 RID: 42355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A573")]
		[Address(RVA = "0x31FFDF0", Offset = "0x31FE9F0", VA = "0x1831FFDF0")]
		private void _OnButtonPressed(DIYItemViewData data, FurnitureItemView view)
		{
		}

		// Token: 0x0600A574 RID: 42356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A574")]
		[Address(RVA = "0x31FF4C0", Offset = "0x31FE0C0", VA = "0x1831FF4C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600A575 RID: 42357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A575")]
		[Address(RVA = "0x31FFFE0", Offset = "0x31FEBE0", VA = "0x1831FFFE0")]
		public ShopFurnitureItemView()
		{
		}

		// Token: 0x04009D27 RID: 40231
		[Token(Token = "0x4009D27")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FurnitureItemView _innerFurnitureItemView;

		// Token: 0x04009D28 RID: 40232
		[Token(Token = "0x4009D28")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _countLabel;

		// Token: 0x04009D29 RID: 40233
		[Token(Token = "0x4009D29")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _comfortLabel;

		// Token: 0x04009D2A RID: 40234
		[Token(Token = "0x4009D2A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _cashCostPanel;

		// Token: 0x04009D2B RID: 40235
		[Token(Token = "0x4009D2B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _cashCostLabel;

		// Token: 0x04009D2C RID: 40236
		[Token(Token = "0x4009D2C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _furnitureCoinCostPanel;

		// Token: 0x04009D2D RID: 40237
		[Token(Token = "0x4009D2D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _furnitureCoinCostLabel;

		// Token: 0x04009D2E RID: 40238
		[Token(Token = "0x4009D2E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _discountPanel;

		// Token: 0x04009D2F RID: 40239
		[Token(Token = "0x4009D2F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _discountLabel;

		// Token: 0x04009D30 RID: 40240
		[Token(Token = "0x4009D30")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _rarityPanel;

		// Token: 0x04009D31 RID: 40241
		[Token(Token = "0x4009D31")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private MeetingClueRestTimeLabel _restTimeLabel;

		// Token: 0x04009D32 RID: 40242
		[Token(Token = "0x4009D32")]
		[FieldOffset(Offset = "0x70")]
		private DIYShopItemViewData m_shopItemData;

		// Token: 0x04009D34 RID: 40244
		[Token(Token = "0x4009D34")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_buttonPressed;

		// Token: 0x04009D35 RID: 40245
		[Token(Token = "0x4009D35")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_remove_buttonPressed;

		// Token: 0x04009D36 RID: 40246
		[Token(Token = "0x4009D36")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetupIcon;

		// Token: 0x04009D37 RID: 40247
		[Token(Token = "0x4009D37")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x04009D38 RID: 40248
		[Token(Token = "0x4009D38")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Refresh;

		// Token: 0x04009D39 RID: 40249
		[Token(Token = "0x4009D39")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnButtonPressed;

		// Token: 0x04009D3A RID: 40250
		[Token(Token = "0x4009D3A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04009D3B RID: 40251
		[Token(Token = "0x4009D3B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
