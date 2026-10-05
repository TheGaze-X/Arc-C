using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D56 RID: 15702
	[Token(Token = "0x2003D56")]
	public class TemplateShopCommonRightComplexView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601874E RID: 100174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601874E")]
		[Address(RVA = "0x10F0570", Offset = "0x10EF170", VA = "0x1810F0570")]
		public void RefreshReplicateInfo([Optional] TemplateCommonShopGoodViewModel viewModel)
		{
		}

		// Token: 0x0601874F RID: 100175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601874F")]
		[Address(RVA = "0x10F0600", Offset = "0x10EF200", VA = "0x1810F0600")]
		public void Render(TemplateCommonShopGoodViewModel shopInfo, bool isReplicate = false, int availCount = -1, [Optional] ItemBundle item)
		{
		}

		// Token: 0x06018750 RID: 100176 RVA: 0x0009A6E0 File Offset: 0x000988E0
		[Token(Token = "0x6018750")]
		[Address(RVA = "0x10F0460", Offset = "0x10EF060", VA = "0x1810F0460")]
		public int RefreshNum(int currCount)
		{
			return 0;
		}

		// Token: 0x06018751 RID: 100177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018751")]
		[Address(RVA = "0x10F1010", Offset = "0x10EFC10", VA = "0x1810F1010")]
		private void _RefreshClick()
		{
		}

		// Token: 0x06018752 RID: 100178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018752")]
		[Address(RVA = "0x10EFF90", Offset = "0x10EEB90", VA = "0x1810EFF90")]
		public void AddOne()
		{
		}

		// Token: 0x06018753 RID: 100179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018753")]
		[Address(RVA = "0x10F0360", Offset = "0x10EEF60", VA = "0x1810F0360")]
		public void MinusOne()
		{
		}

		// Token: 0x06018754 RID: 100180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018754")]
		[Address(RVA = "0x10F0010", Offset = "0x10EEC10", VA = "0x1810F0010")]
		public void AddToMax()
		{
		}

		// Token: 0x06018755 RID: 100181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018755")]
		[Address(RVA = "0x10F03E0", Offset = "0x10EEFE0", VA = "0x1810F03E0")]
		public void MinusToOne()
		{
		}

		// Token: 0x06018756 RID: 100182 RVA: 0x0009A6F8 File Offset: 0x000988F8
		[Token(Token = "0x6018756")]
		[Address(RVA = "0x10F0180", Offset = "0x10EED80", VA = "0x1810F0180")]
		public static int GetMaxPrice(int price, int maxCount)
		{
			return 0;
		}

		// Token: 0x06018757 RID: 100183 RVA: 0x0009A710 File Offset: 0x00098910
		[Token(Token = "0x6018757")]
		[Address(RVA = "0x10F0110", Offset = "0x10EED10", VA = "0x1810F0110")]
		public int GetBuyCount()
		{
			return 0;
		}

		// Token: 0x06018758 RID: 100184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018758")]
		[Address(RVA = "0x10F1160", Offset = "0x10EFD60", VA = "0x1810F1160")]
		public TemplateShopCommonRightComplexView()
		{
		}

		// Token: 0x0401DF05 RID: 122629
		[Token(Token = "0x401DF05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _shopBuyCount;

		// Token: 0x0401DF06 RID: 122630
		[Token(Token = "0x401DF06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _shopItemName;

		// Token: 0x0401DF07 RID: 122631
		[Token(Token = "0x401DF07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _shopPerCount;

		// Token: 0x0401DF08 RID: 122632
		[Token(Token = "0x401DF08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _shopAvailCount;

		// Token: 0x0401DF09 RID: 122633
		[Token(Token = "0x401DF09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _totalPrice;

		// Token: 0x0401DF0A RID: 122634
		[Token(Token = "0x401DF0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _alreadyHaveCount;

		// Token: 0x0401DF0B RID: 122635
		[Token(Token = "0x401DF0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _singlePrice;

		// Token: 0x0401DF0C RID: 122636
		[Token(Token = "0x401DF0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _constText;

		// Token: 0x0401DF0D RID: 122637
		[Token(Token = "0x401DF0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _colorIcon;

		// Token: 0x0401DF0E RID: 122638
		[Token(Token = "0x401DF0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _blackIcon;

		// Token: 0x0401DF0F RID: 122639
		[Token(Token = "0x401DF0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _buyColor;

		// Token: 0x0401DF10 RID: 122640
		[Token(Token = "0x401DF10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _replicateDetail;

		// Token: 0x0401DF11 RID: 122641
		[Token(Token = "0x401DF11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UnityEvent _onBuyChangedEvent;

		// Token: 0x0401DF12 RID: 122642
		[Token(Token = "0x401DF12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int m_shopBuyCount;

		// Token: 0x0401DF13 RID: 122643
		[Token(Token = "0x401DF13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TemplateCommonShopGoodViewModel m_cacheViewModel;

		// Token: 0x0401DF14 RID: 122644
		[Token(Token = "0x401DF14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RefreshReplicateInfo;

		// Token: 0x0401DF15 RID: 122645
		[Token(Token = "0x401DF15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401DF16 RID: 122646
		[Token(Token = "0x401DF16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshNum;

		// Token: 0x0401DF17 RID: 122647
		[Token(Token = "0x401DF17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RefreshClick;

		// Token: 0x0401DF18 RID: 122648
		[Token(Token = "0x401DF18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_AddOne;

		// Token: 0x0401DF19 RID: 122649
		[Token(Token = "0x401DF19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_MinusOne;

		// Token: 0x0401DF1A RID: 122650
		[Token(Token = "0x401DF1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_AddToMax;

		// Token: 0x0401DF1B RID: 122651
		[Token(Token = "0x401DF1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_MinusToOne;

		// Token: 0x0401DF1C RID: 122652
		[Token(Token = "0x401DF1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetMaxPrice;

		// Token: 0x0401DF1D RID: 122653
		[Token(Token = "0x401DF1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetBuyCount;

		// Token: 0x0401DF1E RID: 122654
		[Token(Token = "0x401DF1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
