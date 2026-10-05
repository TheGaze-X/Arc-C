using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D66 RID: 15718
	[Token(Token = "0x2003D66")]
	public class TemplateShopSkinDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060187A1 RID: 100257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187A1")]
		[Address(RVA = "0x10FB160", Offset = "0x10F9D60", VA = "0x1810FB160")]
		private void _InitedIfNot()
		{
		}

		// Token: 0x060187A2 RID: 100258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187A2")]
		[Address(RVA = "0x10FA660", Offset = "0x10F9260", VA = "0x1810FA660")]
		public void RenderSkinWithSkinId(string skinId)
		{
		}

		// Token: 0x060187A3 RID: 100259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187A3")]
		[Address(RVA = "0x10FA600", Offset = "0x10F9200", VA = "0x1810FA600")]
		public void OnOpenSkinDetail()
		{
		}

		// Token: 0x060187A4 RID: 100260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187A4")]
		[Address(RVA = "0x10FAAA0", Offset = "0x10F96A0", VA = "0x1810FAAA0")]
		public void Render(TemplateCommonShopGoodViewModel viewModel)
		{
		}

		// Token: 0x060187A5 RID: 100261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187A5")]
		[Address(RVA = "0x10FB2E0", Offset = "0x10F9EE0", VA = "0x1810FB2E0")]
		public TemplateShopSkinDetailView()
		{
		}

		// Token: 0x0401DFB9 RID: 122809
		[Token(Token = "0x401DFB9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("SKIN_INFO")]
		private Transform _imageContainer;

		// Token: 0x0401DFBA RID: 122810
		[Token(Token = "0x401DFBA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("SKIN_INFO")]
		private Text _skinName;

		// Token: 0x0401DFBB RID: 122811
		[Token(Token = "0x401DFBB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("SKIN_INFO")]
		private Text _charName;

		// Token: 0x0401DFBC RID: 122812
		[Token(Token = "0x401DFBC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("SKIN_INFO")]
		private Text _skinDetail;

		// Token: 0x0401DFBD RID: 122813
		[Token(Token = "0x401DFBD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("SKIN_INFO")]
		private Text _skinUsage;

		// Token: 0x0401DFBE RID: 122814
		[Token(Token = "0x401DFBE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("SKIN_INFO")]
		private Image _skinBar;

		// Token: 0x0401DFBF RID: 122815
		[Token(Token = "0x401DFBF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _skinItemInfo;

		// Token: 0x0401DFC0 RID: 122816
		[Token(Token = "0x401DFC0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _priceText;

		// Token: 0x0401DFC1 RID: 122817
		[Token(Token = "0x401DFC1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _priceText2;

		// Token: 0x0401DFC2 RID: 122818
		[Token(Token = "0x401DFC2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _priceIcon;

		// Token: 0x0401DFC3 RID: 122819
		[Token(Token = "0x401DFC3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _priceIcon2;

		// Token: 0x0401DFC4 RID: 122820
		[Token(Token = "0x401DFC4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIItemCard _itemCard;

		// Token: 0x0401DFC5 RID: 122821
		[Token(Token = "0x401DFC5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0401DFC6 RID: 122822
		[Token(Token = "0x401DFC6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0401DFC7 RID: 122823
		[Token(Token = "0x401DFC7")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _buttonImage;

		// Token: 0x0401DFC8 RID: 122824
		[Token(Token = "0x401DFC8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _brandImage;

		// Token: 0x0401DFC9 RID: 122825
		[Token(Token = "0x401DFC9")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _constText;

		// Token: 0x0401DFCA RID: 122826
		[Token(Token = "0x401DFCA")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isInited;

		// Token: 0x0401DFCB RID: 122827
		[Token(Token = "0x401DFCB")]
		[FieldOffset(Offset = "0xA8")]
		private UIItemCard m_itemCard;

		// Token: 0x0401DFCC RID: 122828
		[Token(Token = "0x401DFCC")]
		[FieldOffset(Offset = "0xB0")]
		private string m_cacheId;

		// Token: 0x0401DFCD RID: 122829
		[Token(Token = "0x401DFCD")]
		[FieldOffset(Offset = "0xB8")]
		private UICharacterIllust m_illust;

		// Token: 0x0401DFCE RID: 122830
		[Token(Token = "0x401DFCE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitedIfNot;

		// Token: 0x0401DFCF RID: 122831
		[Token(Token = "0x401DFCF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderSkinWithSkinId;

		// Token: 0x0401DFD0 RID: 122832
		[Token(Token = "0x401DFD0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnOpenSkinDetail;

		// Token: 0x0401DFD1 RID: 122833
		[Token(Token = "0x401DFD1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401DFD2 RID: 122834
		[Token(Token = "0x401DFD2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
