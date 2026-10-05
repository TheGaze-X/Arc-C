using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Crisis
{
	// Token: 0x02005A19 RID: 23065
	[Token(Token = "0x2005A19")]
	public class CrisisShopSingleRightView : MonoBehaviour
	{
		// Token: 0x06021999 RID: 137625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021999")]
		[Address(RVA = "0x1C0A280", Offset = "0x1C08E80", VA = "0x181C0A280")]
		public void Render(ShopDetailInfo viewModel)
		{
		}

		// Token: 0x0602199A RID: 137626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602199A")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public CrisisShopSingleRightView()
		{
		}

		// Token: 0x0402DEE6 RID: 188134
		[Token(Token = "0x402DEE6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _itemDetailText;

		// Token: 0x0402DEE7 RID: 188135
		[Token(Token = "0x402DEE7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _itemDetailCount;

		// Token: 0x0402DEE8 RID: 188136
		[Token(Token = "0x402DEE8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _alreadyHaveCount;

		// Token: 0x0402DEE9 RID: 188137
		[Token(Token = "0x402DEE9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _singlePrice;

		// Token: 0x0402DEEA RID: 188138
		[Token(Token = "0x402DEEA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _canBuyPart;

		// Token: 0x0402DEEB RID: 188139
		[Token(Token = "0x402DEEB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _cannotBuyPart;

		// Token: 0x0402DEEC RID: 188140
		[Token(Token = "0x402DEEC")]
		[FieldOffset(Offset = "0x48")]
		private ShopDetailInfo m_cacheViewModel;
	}
}
