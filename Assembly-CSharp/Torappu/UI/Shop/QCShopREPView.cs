using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B1C RID: 23324
	[Token(Token = "0x2005B1C")]
	public class QCShopREPView : MonoBehaviour
	{
		// Token: 0x06021E01 RID: 138753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E01")]
		[Address(RVA = "0x1C5F320", Offset = "0x1C5DF20", VA = "0x181C5F320")]
		public void OnEnter(ShopPage page)
		{
		}

		// Token: 0x06021E02 RID: 138754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E02")]
		[Address(RVA = "0x1C5F4D0", Offset = "0x1C5E0D0", VA = "0x181C5F4D0")]
		private void _ApplyData(GetREPGoodListResponse response)
		{
		}

		// Token: 0x06021E03 RID: 138755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E03")]
		[Address(RVA = "0x1C5F550", Offset = "0x1C5E150", VA = "0x181C5F550")]
		private void _RenderShopList()
		{
		}

		// Token: 0x06021E04 RID: 138756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E04")]
		[Address(RVA = "0x1C5F6E0", Offset = "0x1C5E2E0", VA = "0x181C5F6E0")]
		public QCShopREPView()
		{
		}

		// Token: 0x0402E698 RID: 190104
		[Token(Token = "0x402E698")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private QCShopREPRecycleAdapter _adapter;

		// Token: 0x0402E699 RID: 190105
		[Token(Token = "0x402E699")]
		[FieldOffset(Offset = "0x20")]
		private QCShopREPViewModel m_viewModel;

		// Token: 0x0402E69A RID: 190106
		[Token(Token = "0x402E69A")]
		[FieldOffset(Offset = "0x28")]
		private SpriteHub m_priceTypeHub;
	}
}
