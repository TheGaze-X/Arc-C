using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B0D RID: 23309
	[Token(Token = "0x2005B0D")]
	public class QCShopLMTGSItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021DC9 RID: 138697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DC9")]
		[Address(RVA = "0x1C5A8F0", Offset = "0x1C594F0", VA = "0x181C5A8F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021DCA RID: 138698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DCA")]
		[Address(RVA = "0x1C5A180", Offset = "0x1C58D80", VA = "0x181C5A180")]
		public void RenderItem(LMTGSViewModel viewModel)
		{
		}

		// Token: 0x06021DCB RID: 138699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DCB")]
		[Address(RVA = "0x1C5A890", Offset = "0x1C59490", VA = "0x181C5A890")]
		public void TryOpenDetail()
		{
		}

		// Token: 0x06021DCC RID: 138700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DCC")]
		[Address(RVA = "0x1C5A100", Offset = "0x1C58D00", VA = "0x181C5A100")]
		public void OnClick()
		{
		}

		// Token: 0x06021DCD RID: 138701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DCD")]
		[Address(RVA = "0x1C5AAB0", Offset = "0x1C596B0", VA = "0x181C5AAB0")]
		public QCShopLMTGSItem()
		{
		}

		// Token: 0x0402E625 RID: 189989
		[Token(Token = "0x402E625")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _button;

		// Token: 0x0402E626 RID: 189990
		[Token(Token = "0x402E626")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _cardName;

		// Token: 0x0402E627 RID: 189991
		[Token(Token = "0x402E627")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _endTimePart;

		// Token: 0x0402E628 RID: 189992
		[Token(Token = "0x402E628")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _endTimeText;

		// Token: 0x0402E629 RID: 189993
		[Token(Token = "0x402E629")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0402E62A RID: 189994
		[Token(Token = "0x402E62A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _remainCount;

		// Token: 0x0402E62B RID: 189995
		[Token(Token = "0x402E62B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _remainCountPart;

		// Token: 0x0402E62C RID: 189996
		[Token(Token = "0x402E62C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _price;

		// Token: 0x0402E62D RID: 189997
		[Token(Token = "0x402E62D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _priceIcon;

		// Token: 0x0402E62E RID: 189998
		[Token(Token = "0x402E62E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0402E62F RID: 189999
		[Token(Token = "0x402E62F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _soldOutCanvasGroup;

		// Token: 0x0402E630 RID: 190000
		[Token(Token = "0x402E630")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _soldOutObj;

		// Token: 0x0402E631 RID: 190001
		[Token(Token = "0x402E631")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAtlasImage _portraitImg;

		// Token: 0x0402E632 RID: 190002
		[Token(Token = "0x402E632")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0402E633 RID: 190003
		[Token(Token = "0x402E633")]
		[FieldOffset(Offset = "0x88")]
		private UIItemCard m_itemCard;

		// Token: 0x0402E634 RID: 190004
		[Token(Token = "0x402E634")]
		[FieldOffset(Offset = "0x90")]
		private LMTGSViewModel m_cacheViewModel;

		// Token: 0x0402E635 RID: 190005
		[Token(Token = "0x402E635")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402E636 RID: 190006
		[Token(Token = "0x402E636")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderItem;

		// Token: 0x0402E637 RID: 190007
		[Token(Token = "0x402E637")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryOpenDetail;

		// Token: 0x0402E638 RID: 190008
		[Token(Token = "0x402E638")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402E639 RID: 190009
		[Token(Token = "0x402E639")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
