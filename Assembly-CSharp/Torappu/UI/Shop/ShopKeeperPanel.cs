using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B4E RID: 23374
	[Token(Token = "0x2005B4E")]
	public class ShopKeeperPanel : MonoBehaviour
	{
		// Token: 0x06021EE9 RID: 138985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021EE9")]
		[Address(RVA = "0x1C70F10", Offset = "0x1C6FB10", VA = "0x181C70F10")]
		public void InitWithTag(ShopRecommendViewModel initTag)
		{
		}

		// Token: 0x06021EEA RID: 138986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021EEA")]
		[Address(RVA = "0x1C710A0", Offset = "0x1C6FCA0", VA = "0x181C710A0")]
		public void OnRecommendTagClicked(ShopRecommendViewModel newTag)
		{
		}

		// Token: 0x06021EEB RID: 138987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021EEB")]
		[Address(RVA = "0x1C71130", Offset = "0x1C6FD30", VA = "0x181C71130")]
		public void OnThisPanelClicked()
		{
		}

		// Token: 0x06021EEC RID: 138988 RVA: 0x000BBCC8 File Offset: 0x000B9EC8
		[Token(Token = "0x6021EEC")]
		[Address(RVA = "0x1C71280", Offset = "0x1C6FE80", VA = "0x181C71280")]
		private bool _LoadIfNot()
		{
			return default(bool);
		}

		// Token: 0x06021EED RID: 138989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021EED")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public ShopKeeperPanel()
		{
		}

		// Token: 0x0402E7C3 RID: 190403
		[Token(Token = "0x402E7C3")]
		private const float INIT_KEEPER_DELAY = 0.1f;

		// Token: 0x0402E7C4 RID: 190404
		[Token(Token = "0x402E7C4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ShopRecommendStateBean _stateBean;

		// Token: 0x0402E7C5 RID: 190405
		[Token(Token = "0x402E7C5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ShopKeeperDialog _dialog;

		// Token: 0x0402E7C6 RID: 190406
		[Token(Token = "0x402E7C6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0402E7C7 RID: 190407
		[Token(Token = "0x402E7C7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _shopKeeperId;

		// Token: 0x0402E7C8 RID: 190408
		[Token(Token = "0x402E7C8")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isLoaded;

		// Token: 0x0402E7C9 RID: 190409
		[Token(Token = "0x402E7C9")]
		[FieldOffset(Offset = "0x40")]
		private string m_tagIdOfCurrentWord;

		// Token: 0x0402E7CA RID: 190410
		[Token(Token = "0x402E7CA")]
		[FieldOffset(Offset = "0x48")]
		private ShopKeeperGraphic m_graphicHolder;
	}
}
