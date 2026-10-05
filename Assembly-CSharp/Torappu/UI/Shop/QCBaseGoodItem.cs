using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AF4 RID: 23284
	[Token(Token = "0x2005AF4")]
	public abstract class QCBaseGoodItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004F2F RID: 20271
		// (get) Token: 0x06021D60 RID: 138592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F2F")]
		protected Button clickButton
		{
			[Token(Token = "0x6021D60")]
			[Address(RVA = "0x1C45050", Offset = "0x1C43C50", VA = "0x181C45050")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004F30 RID: 20272
		// (get) Token: 0x06021D61 RID: 138593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F30")]
		protected GameObject soldOutObj
		{
			[Token(Token = "0x6021D61")]
			[Address(RVA = "0x1C45170", Offset = "0x1C43D70", VA = "0x181C45170")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004F31 RID: 20273
		// (get) Token: 0x06021D62 RID: 138594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F31")]
		protected GameObject remainCountPart
		{
			[Token(Token = "0x6021D62")]
			[Address(RVA = "0x1C450B0", Offset = "0x1C43CB0", VA = "0x181C450B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004F32 RID: 20274
		// (get) Token: 0x06021D63 RID: 138595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F32")]
		protected CanvasGroup soldOutCanvasGroup
		{
			[Token(Token = "0x6021D63")]
			[Address(RVA = "0x1C45110", Offset = "0x1C43D10", VA = "0x181C45110")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004F33 RID: 20275
		// (get) Token: 0x06021D64 RID: 138596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F33")]
		protected Text cardName
		{
			[Token(Token = "0x6021D64")]
			[Address(RVA = "0x1C44FF0", Offset = "0x1C43BF0", VA = "0x181C44FF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06021D65 RID: 138597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D65")]
		[Address(RVA = "0x1C44CF0", Offset = "0x1C438F0", VA = "0x181C44CF0", Slot = "4")]
		protected virtual void SetSoldOutObj(bool isSoldOut)
		{
		}

		// Token: 0x06021D66 RID: 138598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021D66")]
		[Address(RVA = "0x1C44DF0", Offset = "0x1C439F0", VA = "0x181C44DF0")]
		private UIItemCard _EnsureItemCard()
		{
			return null;
		}

		// Token: 0x06021D67 RID: 138599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D67")]
		[Address(RVA = "0x1C447A0", Offset = "0x1C433A0", VA = "0x181C447A0", Slot = "5")]
		protected virtual void RenderPrice(int originPrice, int price, float discount, ShopDetailPriceType priceType, SpriteHub hub)
		{
		}

		// Token: 0x06021D68 RID: 138600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D68")]
		[Address(RVA = "0x1C444F0", Offset = "0x1C430F0", VA = "0x181C444F0", Slot = "6")]
		protected virtual void RenderItem(ItemBundle item, string displayName)
		{
		}

		// Token: 0x06021D69 RID: 138601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D69")]
		[Address(RVA = "0x1C44A70", Offset = "0x1C43670", VA = "0x181C44A70", Slot = "7")]
		protected virtual void RenderSoldOutState(int availCount, int buyCount, float alpha = 0.4f)
		{
		}

		// Token: 0x06021D6A RID: 138602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D6A")]
		[Address(RVA = "0x1C44330", Offset = "0x1C42F30", VA = "0x181C44330", Slot = "8")]
		protected virtual void RenderEndTimePart(long goodEndTime, bool hideEndTime = false)
		{
		}

		// Token: 0x06021D6B RID: 138603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D6B")]
		[Address(RVA = "0x1C44F80", Offset = "0x1C43B80", VA = "0x181C44F80")]
		protected QCBaseGoodItem()
		{
		}

		// Token: 0x0402E550 RID: 189776
		[Token(Token = "0x402E550")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _button;

		// Token: 0x0402E551 RID: 189777
		[Token(Token = "0x402E551")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _cardName;

		// Token: 0x0402E552 RID: 189778
		[Token(Token = "0x402E552")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _offsetPart;

		// Token: 0x0402E553 RID: 189779
		[Token(Token = "0x402E553")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _offsetPercent;

		// Token: 0x0402E554 RID: 189780
		[Token(Token = "0x402E554")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _endTimePart;

		// Token: 0x0402E555 RID: 189781
		[Token(Token = "0x402E555")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _endTimeText;

		// Token: 0x0402E556 RID: 189782
		[Token(Token = "0x402E556")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIItemCard _itemCard;

		// Token: 0x0402E557 RID: 189783
		[Token(Token = "0x402E557")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0402E558 RID: 189784
		[Token(Token = "0x402E558")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _remainCount;

		// Token: 0x0402E559 RID: 189785
		[Token(Token = "0x402E559")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _remainCountPart;

		// Token: 0x0402E55A RID: 189786
		[Token(Token = "0x402E55A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _originPrice;

		// Token: 0x0402E55B RID: 189787
		[Token(Token = "0x402E55B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _price;

		// Token: 0x0402E55C RID: 189788
		[Token(Token = "0x402E55C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _offsetPricePart;

		// Token: 0x0402E55D RID: 189789
		[Token(Token = "0x402E55D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _priceIcon;

		// Token: 0x0402E55E RID: 189790
		[Token(Token = "0x402E55E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0402E55F RID: 189791
		[Token(Token = "0x402E55F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private CanvasGroup _soldOutCanvasGroup;

		// Token: 0x0402E560 RID: 189792
		[Token(Token = "0x402E560")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _soldOutObj;

		// Token: 0x0402E561 RID: 189793
		[Token(Token = "0x402E561")]
		[FieldOffset(Offset = "0xA0")]
		private UIItemCard m_itemCard;

		// Token: 0x0402E562 RID: 189794
		[Token(Token = "0x402E562")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_clickButton;

		// Token: 0x0402E563 RID: 189795
		[Token(Token = "0x402E563")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_soldOutObj;

		// Token: 0x0402E564 RID: 189796
		[Token(Token = "0x402E564")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_remainCountPart;

		// Token: 0x0402E565 RID: 189797
		[Token(Token = "0x402E565")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_soldOutCanvasGroup;

		// Token: 0x0402E566 RID: 189798
		[Token(Token = "0x402E566")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_cardName;

		// Token: 0x0402E567 RID: 189799
		[Token(Token = "0x402E567")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetSoldOutObj;

		// Token: 0x0402E568 RID: 189800
		[Token(Token = "0x402E568")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EnsureItemCard;

		// Token: 0x0402E569 RID: 189801
		[Token(Token = "0x402E569")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RenderPrice;

		// Token: 0x0402E56A RID: 189802
		[Token(Token = "0x402E56A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RenderItem;

		// Token: 0x0402E56B RID: 189803
		[Token(Token = "0x402E56B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RenderSoldOutState;

		// Token: 0x0402E56C RID: 189804
		[Token(Token = "0x402E56C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RenderEndTimePart;

		// Token: 0x0402E56D RID: 189805
		[Token(Token = "0x402E56D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
