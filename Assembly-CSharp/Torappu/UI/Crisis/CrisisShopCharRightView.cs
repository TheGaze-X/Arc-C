using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Crisis
{
	// Token: 0x02005A17 RID: 23063
	[Token(Token = "0x2005A17")]
	public class CrisisShopCharRightView : MonoBehaviour
	{
		// Token: 0x0602198C RID: 137612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602198C")]
		[Address(RVA = "0x1C049F0", Offset = "0x1C035F0", VA = "0x181C049F0")]
		public void Render(ShopDetailInfo detailInfo)
		{
		}

		// Token: 0x0602198D RID: 137613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602198D")]
		[Address(RVA = "0x1C048F0", Offset = "0x1C034F0", VA = "0x181C048F0")]
		public void OpenCharacterShow()
		{
		}

		// Token: 0x0602198E RID: 137614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602198E")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public CrisisShopCharRightView()
		{
		}

		// Token: 0x0402DED9 RID: 188121
		[Token(Token = "0x402DED9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _itemDetailText;

		// Token: 0x0402DEDA RID: 188122
		[Token(Token = "0x402DEDA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _singlePrice;

		// Token: 0x0402DEDB RID: 188123
		[Token(Token = "0x402DEDB")]
		[FieldOffset(Offset = "0x28")]
		private ShopDetailInfo m_cacheViewModel;
	}
}
