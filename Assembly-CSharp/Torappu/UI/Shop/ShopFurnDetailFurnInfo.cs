using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A92 RID: 23186
	[Token(Token = "0x2005A92")]
	public class ShopFurnDetailFurnInfo : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021B77 RID: 138103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B77")]
		[Address(RVA = "0x1C23FC0", Offset = "0x1C22BC0", VA = "0x181C23FC0")]
		public void Render(FurnGroupViewModel.FurnCurrentInfoViewModel furnInfo, SpriteHub priceHub, int currentGroup)
		{
		}

		// Token: 0x06021B78 RID: 138104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B78")]
		[Address(RVA = "0x1C23E60", Offset = "0x1C22A60", VA = "0x181C23E60")]
		public void ApplyPriceState(ShopDetailFurnGroupView.SelectClass selectClass, Sprite icon, Color textColor)
		{
		}

		// Token: 0x06021B79 RID: 138105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B79")]
		[Address(RVA = "0x1C24460", Offset = "0x1C23060", VA = "0x181C24460")]
		public ShopFurnDetailFurnInfo()
		{
		}

		// Token: 0x0402E1E1 RID: 188897
		[Token(Token = "0x402E1E1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _furnName;

		// Token: 0x0402E1E2 RID: 188898
		[Token(Token = "0x402E1E2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _countText;

		// Token: 0x0402E1E3 RID: 188899
		[Token(Token = "0x402E1E3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _priceIcon;

		// Token: 0x0402E1E4 RID: 188900
		[Token(Token = "0x402E1E4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _pricePart;

		// Token: 0x0402E1E5 RID: 188901
		[Token(Token = "0x402E1E5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _needToPricePart;

		// Token: 0x0402E1E6 RID: 188902
		[Token(Token = "0x402E1E6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _notNeedToBuyPart;

		// Token: 0x0402E1E7 RID: 188903
		[Token(Token = "0x402E1E7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _ablePart;

		// Token: 0x0402E1E8 RID: 188904
		[Token(Token = "0x402E1E8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _notAblePart;

		// Token: 0x0402E1E9 RID: 188905
		[Token(Token = "0x402E1E9")]
		[FieldOffset(Offset = "0x58")]
		private FurnGroupViewModel.FurnCurrentInfoViewModel m_furnInfo;

		// Token: 0x0402E1EA RID: 188906
		[Token(Token = "0x402E1EA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402E1EB RID: 188907
		[Token(Token = "0x402E1EB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyPriceState;

		// Token: 0x0402E1EC RID: 188908
		[Token(Token = "0x402E1EC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
