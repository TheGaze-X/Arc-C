using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AB4 RID: 23220
	[Token(Token = "0x2005AB4")]
	public class ShopDetailProgressGPRewardItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021C3E RID: 138302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C3E")]
		[Address(RVA = "0x1C3DF60", Offset = "0x1C3CB60", VA = "0x181C3DF60")]
		public void Render(ItemBundle item)
		{
		}

		// Token: 0x06021C3F RID: 138303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C3F")]
		[Address(RVA = "0x1C3E0F0", Offset = "0x1C3CCF0", VA = "0x181C3E0F0")]
		public ShopDetailProgressGPRewardItemView()
		{
		}

		// Token: 0x0402E339 RID: 189241
		[Token(Token = "0x402E339")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textItemName;

		// Token: 0x0402E33A RID: 189242
		[Token(Token = "0x402E33A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x0402E33B RID: 189243
		[Token(Token = "0x402E33B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402E33C RID: 189244
		[Token(Token = "0x402E33C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
