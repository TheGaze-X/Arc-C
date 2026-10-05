using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A98 RID: 23192
	[Token(Token = "0x2005A98")]
	public class ShopDetailCharView : ShopDetailCommonView
	{
		// Token: 0x06021B9F RID: 138143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B9F")]
		[Address(RVA = "0x1C1F0A0", Offset = "0x1C1DCA0", VA = "0x181C1F0A0", Slot = "4")]
		public override void ApplyData(DetailCommonViewModel viewModel, SpriteHub priceTypeHub)
		{
		}

		// Token: 0x06021BA0 RID: 138144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BA0")]
		[Address(RVA = "0x1C1F3A0", Offset = "0x1C1DFA0", VA = "0x181C1F3A0")]
		public void OpenCharacterShow()
		{
		}

		// Token: 0x06021BA1 RID: 138145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BA1")]
		[Address(RVA = "0x1C1F4C0", Offset = "0x1C1E0C0", VA = "0x181C1F4C0")]
		public ShopDetailCharView()
		{
		}

		// Token: 0x06021BA2 RID: 138146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BA2")]
		[Address(RVA = "0x1C1EA10", Offset = "0x1C1D610", VA = "0x181C1EA10")]
		private void <>xLuaBaseProxy_ApplyData(DetailCommonViewModel P0, SpriteHub P1)
		{
		}

		// Token: 0x0402E225 RID: 188965
		[Token(Token = "0x402E225")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("char")]
		private UIItemCard _itemCard;

		// Token: 0x0402E226 RID: 188966
		[Token(Token = "0x402E226")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("char")]
		private Transform _itemContainer;

		// Token: 0x0402E227 RID: 188967
		[Token(Token = "0x402E227")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("char")]
		private float _itemScale;

		// Token: 0x0402E228 RID: 188968
		[Token(Token = "0x402E228")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("char")]
		private Text _charName;

		// Token: 0x0402E229 RID: 188969
		[Token(Token = "0x402E229")]
		[FieldOffset(Offset = "0xC8")]
		private string m_charId;

		// Token: 0x0402E22A RID: 188970
		[Token(Token = "0x402E22A")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_isInited;

		// Token: 0x0402E22B RID: 188971
		[Token(Token = "0x402E22B")]
		[FieldOffset(Offset = "0xD8")]
		private UIItemCard m_itemViewCard;

		// Token: 0x0402E22C RID: 188972
		[Token(Token = "0x402E22C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E22D RID: 188973
		[Token(Token = "0x402E22D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OpenCharacterShow;

		// Token: 0x0402E22E RID: 188974
		[Token(Token = "0x402E22E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
