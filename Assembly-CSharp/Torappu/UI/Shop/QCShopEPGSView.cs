using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AFF RID: 23295
	[Token(Token = "0x2005AFF")]
	public class QCShopEPGSView : MonoBehaviour
	{
		// Token: 0x06021D9B RID: 138651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D9B")]
		[Address(RVA = "0x1C499C0", Offset = "0x1C485C0", VA = "0x181C499C0")]
		public void OnEnter(ShopPage page)
		{
		}

		// Token: 0x06021D9C RID: 138652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D9C")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public QCShopEPGSView()
		{
		}

		// Token: 0x0402E5DA RID: 189914
		[Token(Token = "0x402E5DA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private QCShopEPGSRecycleAdapter _adapter;
	}
}
