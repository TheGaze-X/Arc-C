using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D52 RID: 15698
	[Token(Token = "0x2003D52")]
	public class TemplateShopCharDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018731 RID: 100145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018731")]
		[Address(RVA = "0x10ECBD0", Offset = "0x10EB7D0", VA = "0x1810ECBD0")]
		private void _InitedIfNot()
		{
		}

		// Token: 0x06018732 RID: 100146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018732")]
		[Address(RVA = "0x10EC360", Offset = "0x10EAF60", VA = "0x1810EC360")]
		public void Render(TemplateCommonShopGoodViewModel viewModel)
		{
		}

		// Token: 0x06018733 RID: 100147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018733")]
		[Address(RVA = "0x10EC240", Offset = "0x10EAE40", VA = "0x1810EC240")]
		public void OnClick()
		{
		}

		// Token: 0x06018734 RID: 100148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018734")]
		[Address(RVA = "0x10ECD50", Offset = "0x10EB950", VA = "0x1810ECD50")]
		public TemplateShopCharDetailView()
		{
		}

		// Token: 0x0401DE9C RID: 122524
		[Token(Token = "0x401DE9C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("CHAR_INFO")]
		private UIAtlasImage _charPortraitImg;

		// Token: 0x0401DE9D RID: 122525
		[Token(Token = "0x401DE9D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("CHAR_INFO")]
		private Image _charProfession;

		// Token: 0x0401DE9E RID: 122526
		[Token(Token = "0x401DE9E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("CHAR_INFO")]
		private Image _charStar;

		// Token: 0x0401DE9F RID: 122527
		[Token(Token = "0x401DE9F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("CHAR_INFO")]
		private Text _charName;

		// Token: 0x0401DEA0 RID: 122528
		[Token(Token = "0x401DEA0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("CHAR_INFO")]
		private Text _charDetail;

		// Token: 0x0401DEA1 RID: 122529
		[Token(Token = "0x401DEA1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("CHAR_INFO")]
		private Text _charUsage;

		// Token: 0x0401DEA2 RID: 122530
		[Token(Token = "0x401DEA2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _charItemInfo;

		// Token: 0x0401DEA3 RID: 122531
		[Token(Token = "0x401DEA3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _priceText;

		// Token: 0x0401DEA4 RID: 122532
		[Token(Token = "0x401DEA4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _priceText2;

		// Token: 0x0401DEA5 RID: 122533
		[Token(Token = "0x401DEA5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _priceIcon;

		// Token: 0x0401DEA6 RID: 122534
		[Token(Token = "0x401DEA6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _priceIcon2;

		// Token: 0x0401DEA7 RID: 122535
		[Token(Token = "0x401DEA7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIItemCard _itemCard;

		// Token: 0x0401DEA8 RID: 122536
		[Token(Token = "0x401DEA8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0401DEA9 RID: 122537
		[Token(Token = "0x401DEA9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0401DEAA RID: 122538
		[Token(Token = "0x401DEAA")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _buttonImage;

		// Token: 0x0401DEAB RID: 122539
		[Token(Token = "0x401DEAB")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _constText;

		// Token: 0x0401DEAC RID: 122540
		[Token(Token = "0x401DEAC")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x0401DEAD RID: 122541
		[Token(Token = "0x401DEAD")]
		[FieldOffset(Offset = "0xA0")]
		private UIItemCard m_itemCard;

		// Token: 0x0401DEAE RID: 122542
		[Token(Token = "0x401DEAE")]
		[FieldOffset(Offset = "0xA8")]
		private string m_cacheId;

		// Token: 0x0401DEAF RID: 122543
		[Token(Token = "0x401DEAF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitedIfNot;

		// Token: 0x0401DEB0 RID: 122544
		[Token(Token = "0x401DEB0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401DEB1 RID: 122545
		[Token(Token = "0x401DEB1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401DEB2 RID: 122546
		[Token(Token = "0x401DEB2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
