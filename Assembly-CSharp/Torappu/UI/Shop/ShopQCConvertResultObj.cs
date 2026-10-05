using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B21 RID: 23329
	[Token(Token = "0x2005B21")]
	public class ShopQCConvertResultObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021E11 RID: 138769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E11")]
		[Address(RVA = "0x1C63F90", Offset = "0x1C62B90", VA = "0x181C63F90")]
		public void InitData(UIItemViewModel viewModel)
		{
		}

		// Token: 0x06021E12 RID: 138770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E12")]
		[Address(RVA = "0x1C643B0", Offset = "0x1C62FB0", VA = "0x181C643B0")]
		public ShopQCConvertResultObj()
		{
		}

		// Token: 0x0402E6A8 RID: 190120
		[Token(Token = "0x402E6A8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x0402E6A9 RID: 190121
		[Token(Token = "0x402E6A9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _countText;

		// Token: 0x0402E6AA RID: 190122
		[Token(Token = "0x402E6AA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _finalCountText;

		// Token: 0x0402E6AB RID: 190123
		[Token(Token = "0x402E6AB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIItemCard _itemCard;

		// Token: 0x0402E6AC RID: 190124
		[Token(Token = "0x402E6AC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0402E6AD RID: 190125
		[Token(Token = "0x402E6AD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0402E6AE RID: 190126
		[Token(Token = "0x402E6AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0402E6AF RID: 190127
		[Token(Token = "0x402E6AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
