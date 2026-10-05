using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D55 RID: 15701
	[Token(Token = "0x2003D55")]
	public class TemplateShopCommonLeftViewHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018744 RID: 100164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018744")]
		[Address(RVA = "0x10EFB10", Offset = "0x10EE710", VA = "0x1810EFB10")]
		private void _InitedIfNot()
		{
		}

		// Token: 0x06018745 RID: 100165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018745")]
		[Address(RVA = "0x10EF0E0", Offset = "0x10EDCE0", VA = "0x1810EF0E0")]
		public void RenderFirstTime()
		{
		}

		// Token: 0x06018746 RID: 100166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018746")]
		[Address(RVA = "0x10EF9D0", Offset = "0x10EE5D0", VA = "0x1810EF9D0")]
		public void Render(TemplateCommonShopGoodViewModel shopViewModel, bool isReplicate = false, [Optional] ItemBundle item)
		{
		}

		// Token: 0x06018747 RID: 100167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018747")]
		[Address(RVA = "0x10EF910", Offset = "0x10EE510", VA = "0x1810EF910")]
		public void RenderReplicate(bool isReplicate, ItemBundle item)
		{
		}

		// Token: 0x06018748 RID: 100168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018748")]
		[Address(RVA = "0x10EFD20", Offset = "0x10EE920", VA = "0x1810EFD20")]
		private void _RenderReplicate(bool isReplicate, ItemBundle item)
		{
		}

		// Token: 0x06018749 RID: 100169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018749")]
		[Address(RVA = "0x10EF200", Offset = "0x10EDE00", VA = "0x1810EF200")]
		public void RenderNormalObj(TemplateCommonShopGoodViewModel shopViewModel)
		{
		}

		// Token: 0x0601874A RID: 100170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601874A")]
		[Address(RVA = "0x10EF5F0", Offset = "0x10EE1F0", VA = "0x1810EF5F0")]
		public void RenderProgressObj(TemplateCommonShopGoodViewModel shopViewModel)
		{
		}

		// Token: 0x0601874B RID: 100171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601874B")]
		[Address(RVA = "0x10EEFD0", Offset = "0x10EDBD0", VA = "0x1810EEFD0")]
		public void RenderCommonObj(TemplateCommonShopGoodViewModel shopViewModel)
		{
		}

		// Token: 0x0601874C RID: 100172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601874C")]
		[Address(RVA = "0x10EF140", Offset = "0x10EDD40", VA = "0x1810EF140")]
		public void RenderFurn(TemplateCommonShopGoodViewModel shopViewModel)
		{
		}

		// Token: 0x0601874D RID: 100173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601874D")]
		[Address(RVA = "0x10EFF20", Offset = "0x10EEB20", VA = "0x1810EFF20")]
		public TemplateShopCommonLeftViewHolder()
		{
		}

		// Token: 0x0401DEE9 RID: 122601
		[Token(Token = "0x401DEE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _name;

		// Token: 0x0401DEEA RID: 122602
		[Token(Token = "0x401DEEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _description;

		// Token: 0x0401DEEB RID: 122603
		[Token(Token = "0x401DEEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _usage;

		// Token: 0x0401DEEC RID: 122604
		[Token(Token = "0x401DEEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _normalView;

		// Token: 0x0401DEED RID: 122605
		[Token(Token = "0x401DEED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TemplateShopLeftProgressView _progressView;

		// Token: 0x0401DEEE RID: 122606
		[Token(Token = "0x401DEEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TemplateShopCommonLeftFurnView _furnView;

		// Token: 0x0401DEEF RID: 122607
		[Token(Token = "0x401DEEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ShopDetailItemPileView _pileView;

		// Token: 0x0401DEF0 RID: 122608
		[Token(Token = "0x401DEF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _pileViewContainer;

		// Token: 0x0401DEF1 RID: 122609
		[Token(Token = "0x401DEF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _replicateItemContainer;

		// Token: 0x0401DEF2 RID: 122610
		[Token(Token = "0x401DEF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _replicateIcon;

		// Token: 0x0401DEF3 RID: 122611
		[Token(Token = "0x401DEF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0401DEF4 RID: 122612
		[Token(Token = "0x401DEF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _scaleInfo;

		// Token: 0x0401DEF5 RID: 122613
		[Token(Token = "0x401DEF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ShopDetailItemPileView m_pileView;

		// Token: 0x0401DEF6 RID: 122614
		[Token(Token = "0x401DEF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private UIItemCard m_replicateItemCard;

		// Token: 0x0401DEF7 RID: 122615
		[Token(Token = "0x401DEF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x0401DEF8 RID: 122616
		[Token(Token = "0x401DEF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool m_isFirstTime;

		// Token: 0x0401DEF9 RID: 122617
		[Token(Token = "0x401DEF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		private bool m_cacheReplicated;

		// Token: 0x0401DEFA RID: 122618
		[Token(Token = "0x401DEFA")]
		private const string ANIMATION_SHINING = "shop_detail_shining";

		// Token: 0x0401DEFB RID: 122619
		[Token(Token = "0x401DEFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitedIfNot;

		// Token: 0x0401DEFC RID: 122620
		[Token(Token = "0x401DEFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderFirstTime;

		// Token: 0x0401DEFD RID: 122621
		[Token(Token = "0x401DEFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401DEFE RID: 122622
		[Token(Token = "0x401DEFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderReplicate;

		// Token: 0x0401DEFF RID: 122623
		[Token(Token = "0x401DEFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderReplicate;

		// Token: 0x0401DF00 RID: 122624
		[Token(Token = "0x401DF00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RenderNormalObj;

		// Token: 0x0401DF01 RID: 122625
		[Token(Token = "0x401DF01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RenderProgressObj;

		// Token: 0x0401DF02 RID: 122626
		[Token(Token = "0x401DF02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RenderCommonObj;

		// Token: 0x0401DF03 RID: 122627
		[Token(Token = "0x401DF03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RenderFurn;

		// Token: 0x0401DF04 RID: 122628
		[Token(Token = "0x401DF04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
