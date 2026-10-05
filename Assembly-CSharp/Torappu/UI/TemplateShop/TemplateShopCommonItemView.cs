using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D53 RID: 15699
	[Token(Token = "0x2003D53")]
	public class TemplateShopCommonItemView : MonoBehaviour, IHotfixable, IAsyncDataView<TemplateCommonShopGoodViewModel>
	{
		// Token: 0x06018735 RID: 100149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018735")]
		[Address(RVA = "0x10ED070", Offset = "0x10EBC70", VA = "0x1810ED070")]
		private UIItemCard _EnsureItemCard()
		{
			return null;
		}

		// Token: 0x06018736 RID: 100150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018736")]
		[Address(RVA = "0x10ED210", Offset = "0x10EBE10", VA = "0x1810ED210")]
		private UIItemCard _EnsureReplicateItemCard()
		{
			return null;
		}

		// Token: 0x06018737 RID: 100151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018737")]
		[Address(RVA = "0x10ECDC0", Offset = "0x10EB9C0", VA = "0x1810ECDC0", Slot = "4")]
		public void AsyncSetData(TemplateCommonShopGoodViewModel viewModel)
		{
		}

		// Token: 0x06018738 RID: 100152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018738")]
		[Address(RVA = "0x10ECEA0", Offset = "0x10EBAA0", VA = "0x1810ECEA0")]
		public void RenderItem(TemplateCommonShopGoodViewModel viewModel)
		{
		}

		// Token: 0x06018739 RID: 100153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018739")]
		[Address(RVA = "0x10EDC30", Offset = "0x10EC830", VA = "0x1810EDC30")]
		private void _RenderCommonPart(TemplateCommonShopGoodViewModel viewModel)
		{
		}

		// Token: 0x0601873A RID: 100154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601873A")]
		[Address(RVA = "0x10ED3B0", Offset = "0x10EBFB0", VA = "0x1810ED3B0")]
		private void _RenderChar(TemplateCommonShopGoodViewModel viewModel)
		{
		}

		// Token: 0x0601873B RID: 100155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601873B")]
		[Address(RVA = "0x10EE590", Offset = "0x10ED190", VA = "0x1810EE590")]
		private void _RenderSkin(TemplateCommonShopGoodViewModel viewModel)
		{
		}

		// Token: 0x0601873C RID: 100156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601873C")]
		[Address(RVA = "0x10ED850", Offset = "0x10EC450", VA = "0x1810ED850")]
		private void _RenderCommonItemType(TemplateCommonShopGoodViewModel viewModel)
		{
		}

		// Token: 0x0601873D RID: 100157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601873D")]
		[Address(RVA = "0x10EE340", Offset = "0x10ECF40", VA = "0x1810EE340")]
		private void _RenderNormalGoodType(TemplateCommonShopGoodViewModel viewModel)
		{
		}

		// Token: 0x0601873E RID: 100158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601873E")]
		[Address(RVA = "0x10EE3C0", Offset = "0x10ECFC0", VA = "0x1810EE3C0")]
		private void _RenderProgressGoodType(TemplateCommonShopGoodViewModel viewModel)
		{
		}

		// Token: 0x0601873F RID: 100159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601873F")]
		[Address(RVA = "0x10ECE40", Offset = "0x10EBA40", VA = "0x1810ECE40")]
		public void OnClick()
		{
		}

		// Token: 0x06018740 RID: 100160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018740")]
		[Address(RVA = "0x10EE8F0", Offset = "0x10ED4F0", VA = "0x1810EE8F0")]
		public TemplateShopCommonItemView()
		{
		}

		// Token: 0x0401DEB3 RID: 122547
		[Token(Token = "0x401DEB3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Common")]
		private Text _priceText;

		// Token: 0x0401DEB4 RID: 122548
		[Token(Token = "0x401DEB4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Common")]
		private UIItemCard _itemCard;

		// Token: 0x0401DEB5 RID: 122549
		[Token(Token = "0x401DEB5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Common")]
		private Transform _itemContainer;

		// Token: 0x0401DEB6 RID: 122550
		[Token(Token = "0x401DEB6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Common")]
		private float _itemScale;

		// Token: 0x0401DEB7 RID: 122551
		[Token(Token = "0x401DEB7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Common")]
		private GameObject _remainCountPart;

		// Token: 0x0401DEB8 RID: 122552
		[Token(Token = "0x401DEB8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Common")]
		private Text _remainCount;

		// Token: 0x0401DEB9 RID: 122553
		[Token(Token = "0x401DEB9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Common")]
		private Text _priceCount;

		// Token: 0x0401DEBA RID: 122554
		[Token(Token = "0x401DEBA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Common")]
		private Image _priceIcon;

		// Token: 0x0401DEBB RID: 122555
		[Token(Token = "0x401DEBB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Common")]
		private CanvasGroup _soldOutGroup;

		// Token: 0x0401DEBC RID: 122556
		[Token(Token = "0x401DEBC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Common")]
		private GameObject _soldOutImg;

		// Token: 0x0401DEBD RID: 122557
		[Token(Token = "0x401DEBD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Common")]
		private GameObject _alreadyGetObj;

		// Token: 0x0401DEBE RID: 122558
		[Token(Token = "0x401DEBE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Progress")]
		private GameObject _progressPart;

		// Token: 0x0401DEBF RID: 122559
		[Token(Token = "0x401DEBF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Progress")]
		private Text _progressText;

		// Token: 0x0401DEC0 RID: 122560
		[Token(Token = "0x401DEC0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Char")]
		private GameObject _charPart;

		// Token: 0x0401DEC1 RID: 122561
		[Token(Token = "0x401DEC1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Char")]
		private UIAtlasImage _charPortraitImg;

		// Token: 0x0401DEC2 RID: 122562
		[Token(Token = "0x401DEC2")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Char")]
		private Image _charRarityImg;

		// Token: 0x0401DEC3 RID: 122563
		[Token(Token = "0x401DEC3")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Char")]
		private Image _charProfessionImg;

		// Token: 0x0401DEC4 RID: 122564
		[Token(Token = "0x401DEC4")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Char")]
		private Text _charName;

		// Token: 0x0401DEC5 RID: 122565
		[Token(Token = "0x401DEC5")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Skin")]
		private GameObject _skinPart;

		// Token: 0x0401DEC6 RID: 122566
		[Token(Token = "0x401DEC6")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Skin")]
		private UIAtlasImage _skinPortraitImg;

		// Token: 0x0401DEC7 RID: 122567
		[Token(Token = "0x401DEC7")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Skin")]
		private Image _skinBrandImage;

		// Token: 0x0401DEC8 RID: 122568
		[Token(Token = "0x401DEC8")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Skin")]
		private Text _skinCharName;

		// Token: 0x0401DEC9 RID: 122569
		[Token(Token = "0x401DEC9")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Skin")]
		private Text _skinName;

		// Token: 0x0401DECA RID: 122570
		[Token(Token = "0x401DECA")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Normal")]
		private GameObject _normalPart;

		// Token: 0x0401DECB RID: 122571
		[Token(Token = "0x401DECB")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Normal")]
		private Text _normalName;

		// Token: 0x0401DECC RID: 122572
		[Token(Token = "0x401DECC")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Replicate")]
		private GameObject _replicatePart;

		// Token: 0x0401DECD RID: 122573
		[Token(Token = "0x401DECD")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Replicate")]
		private AnimationWrapper _replicateObj;

		// Token: 0x0401DECE RID: 122574
		[Token(Token = "0x401DECE")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Common")]
		private Transform _replicateItemContainer;

		// Token: 0x0401DECF RID: 122575
		[Token(Token = "0x401DECF")]
		private const string REPLICATE_SHINING = "replicate_shining";

		// Token: 0x0401DED0 RID: 122576
		[Token(Token = "0x401DED0")]
		[FieldOffset(Offset = "0xF8")]
		private UIItemCard m_itemCard;

		// Token: 0x0401DED1 RID: 122577
		[Token(Token = "0x401DED1")]
		[FieldOffset(Offset = "0x100")]
		private UIItemCard m_replicateItemCard;

		// Token: 0x0401DED2 RID: 122578
		[Token(Token = "0x401DED2")]
		[FieldOffset(Offset = "0x108")]
		private TemplateCommonShopGoodViewModel m_cacheViewModel;

		// Token: 0x0401DED3 RID: 122579
		[Token(Token = "0x401DED3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__EnsureItemCard;

		// Token: 0x0401DED4 RID: 122580
		[Token(Token = "0x401DED4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureReplicateItemCard;

		// Token: 0x0401DED5 RID: 122581
		[Token(Token = "0x401DED5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AsyncSetData;

		// Token: 0x0401DED6 RID: 122582
		[Token(Token = "0x401DED6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderItem;

		// Token: 0x0401DED7 RID: 122583
		[Token(Token = "0x401DED7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderCommonPart;

		// Token: 0x0401DED8 RID: 122584
		[Token(Token = "0x401DED8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderChar;

		// Token: 0x0401DED9 RID: 122585
		[Token(Token = "0x401DED9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderSkin;

		// Token: 0x0401DEDA RID: 122586
		[Token(Token = "0x401DEDA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderCommonItemType;

		// Token: 0x0401DEDB RID: 122587
		[Token(Token = "0x401DEDB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderNormalGoodType;

		// Token: 0x0401DEDC RID: 122588
		[Token(Token = "0x401DEDC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderProgressGoodType;

		// Token: 0x0401DEDD RID: 122589
		[Token(Token = "0x401DEDD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401DEDE RID: 122590
		[Token(Token = "0x401DEDE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
