using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B2B RID: 23339
	[Token(Token = "0x2005B2B")]
	public class ShopRecommendTabButton : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021E37 RID: 138807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E37")]
		[Address(RVA = "0x1C687A0", Offset = "0x1C673A0", VA = "0x181C687A0")]
		public void RenderButton(ShopRecommendViewModel buttonViewModel)
		{
		}

		// Token: 0x06021E38 RID: 138808 RVA: 0x000BB9C8 File Offset: 0x000B9BC8
		[Token(Token = "0x6021E38")]
		[Address(RVA = "0x1C688F0", Offset = "0x1C674F0", VA = "0x181C688F0")]
		public bool SetSelectedState(string tabId)
		{
			return default(bool);
		}

		// Token: 0x06021E39 RID: 138809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E39")]
		[Address(RVA = "0x1C686A0", Offset = "0x1C672A0", VA = "0x181C686A0")]
		public void RefreshTagState(ShopRecommendViewModel currentViewModel)
		{
		}

		// Token: 0x06021E3A RID: 138810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E3A")]
		[Address(RVA = "0x1C68600", Offset = "0x1C67200", VA = "0x181C68600")]
		public void OnClick()
		{
		}

		// Token: 0x06021E3B RID: 138811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E3B")]
		[Address(RVA = "0x1C68AE0", Offset = "0x1C676E0", VA = "0x181C68AE0")]
		public ShopRecommendTabButton()
		{
		}

		// Token: 0x0402E6E6 RID: 190182
		[Token(Token = "0x402E6E6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _buttonText;

		// Token: 0x0402E6E7 RID: 190183
		[Token(Token = "0x402E6E7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _buttonText_2;

		// Token: 0x0402E6E8 RID: 190184
		[Token(Token = "0x402E6E8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _selectPart;

		// Token: 0x0402E6E9 RID: 190185
		[Token(Token = "0x402E6E9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _unselectPart;

		// Token: 0x0402E6EA RID: 190186
		[Token(Token = "0x402E6EA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _onSaleTag;

		// Token: 0x0402E6EB RID: 190187
		[Token(Token = "0x402E6EB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _newTag;

		// Token: 0x0402E6EC RID: 190188
		[Token(Token = "0x402E6EC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _timeLimitTag;

		// Token: 0x0402E6ED RID: 190189
		[Token(Token = "0x402E6ED")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public UIStringEvent onClickEvent;

		// Token: 0x0402E6EE RID: 190190
		[Token(Token = "0x402E6EE")]
		[FieldOffset(Offset = "0x58")]
		private string m_cacheId;

		// Token: 0x0402E6EF RID: 190191
		[Token(Token = "0x402E6EF")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public ShopRecommendViewModel cacheData;

		// Token: 0x0402E6F0 RID: 190192
		[Token(Token = "0x402E6F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderButton;

		// Token: 0x0402E6F1 RID: 190193
		[Token(Token = "0x402E6F1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetSelectedState;

		// Token: 0x0402E6F2 RID: 190194
		[Token(Token = "0x402E6F2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshTagState;

		// Token: 0x0402E6F3 RID: 190195
		[Token(Token = "0x402E6F3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402E6F4 RID: 190196
		[Token(Token = "0x402E6F4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
