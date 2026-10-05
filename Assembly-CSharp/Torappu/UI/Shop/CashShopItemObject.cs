using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A73 RID: 23155
	[Token(Token = "0x2005A73")]
	public class CashShopItemObject : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021B06 RID: 137990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B06")]
		[Address(RVA = "0x1C17140", Offset = "0x1C15D40", VA = "0x181C17140")]
		public void Render(CashItemViewModel viewModel)
		{
		}

		// Token: 0x06021B07 RID: 137991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B07")]
		[Address(RVA = "0x1C16FB0", Offset = "0x1C15BB0", VA = "0x181C16FB0")]
		public void EventOnClicked()
		{
		}

		// Token: 0x06021B08 RID: 137992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B08")]
		[Address(RVA = "0x1C17520", Offset = "0x1C16120", VA = "0x181C17520")]
		public CashShopItemObject()
		{
		}

		// Token: 0x0402E10E RID: 188686
		[Token(Token = "0x402E10E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _backSprite;

		// Token: 0x0402E10F RID: 188687
		[Token(Token = "0x402E10F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _countSprite;

		// Token: 0x0402E110 RID: 188688
		[Token(Token = "0x402E110")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _countText;

		// Token: 0x0402E111 RID: 188689
		[Token(Token = "0x402E111")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _availSpritePart;

		// Token: 0x0402E112 RID: 188690
		[Token(Token = "0x402E112")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _noSpritePart;

		// Token: 0x0402E113 RID: 188691
		[Token(Token = "0x402E113")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _constTextNoGift;

		// Token: 0x0402E114 RID: 188692
		[Token(Token = "0x402E114")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _priceIcon;

		// Token: 0x0402E115 RID: 188693
		[Token(Token = "0x402E115")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _priceText;

		// Token: 0x0402E116 RID: 188694
		[Token(Token = "0x402E116")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _isDoublePart;

		// Token: 0x0402E117 RID: 188695
		[Token(Token = "0x402E117")]
		[FieldOffset(Offset = "0x60")]
		private CashItemViewModel m_cachedViewModel;

		// Token: 0x0402E118 RID: 188696
		[Token(Token = "0x402E118")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402E119 RID: 188697
		[Token(Token = "0x402E119")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0402E11A RID: 188698
		[Token(Token = "0x402E11A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
