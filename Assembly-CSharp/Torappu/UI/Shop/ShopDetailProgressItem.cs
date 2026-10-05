using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AB8 RID: 23224
	[Token(Token = "0x2005AB8")]
	public class ShopDetailProgressItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021C48 RID: 138312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C48")]
		[Address(RVA = "0x1C3EFE0", Offset = "0x1C3DBE0", VA = "0x181C3EFE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021C49 RID: 138313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C49")]
		[Address(RVA = "0x1C3EA30", Offset = "0x1C3D630", VA = "0x181C3EA30")]
		private void InitCommonPart(int index, QCProgressGoodItem item)
		{
		}

		// Token: 0x06021C4A RID: 138314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C4A")]
		[Address(RVA = "0x1C3E760", Offset = "0x1C3D360", VA = "0x181C3E760")]
		public void InitActiveData(int index, ShopDetailPriceType priceType, QCProgressGoodItem item, SpriteHub priceTypeHub, int allCount)
		{
		}

		// Token: 0x06021C4B RID: 138315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C4B")]
		[Address(RVA = "0x1C3EC60", Offset = "0x1C3D860", VA = "0x181C3EC60")]
		public void InitUnActiveData(int index, ShopDetailPriceType priceType, QCProgressGoodItem item, bool isSoldOut, SpriteHub priceTypeHub, int allCount)
		{
		}

		// Token: 0x06021C4C RID: 138316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C4C")]
		[Address(RVA = "0x1C3F1D0", Offset = "0x1C3DDD0", VA = "0x181C3F1D0")]
		public ShopDetailProgressItem()
		{
		}

		// Token: 0x0402E34F RID: 189263
		[Token(Token = "0x402E34F")]
		private const int SPLIT_COUNT = 5;

		// Token: 0x0402E350 RID: 189264
		[Token(Token = "0x402E350")]
		private const float ACTIVE_5_WIDTH = 139f;

		// Token: 0x0402E351 RID: 189265
		[Token(Token = "0x402E351")]
		private const float ACTIVE_MORE_THAN_5_WIDTH = 127f;

		// Token: 0x0402E352 RID: 189266
		[Token(Token = "0x402E352")]
		private const float UNACTIVE_5_WIDTH = 85f;

		// Token: 0x0402E353 RID: 189267
		[Token(Token = "0x402E353")]
		private const float UNACTIVE_MORE_THAN_5_WIDTH = 73f;

		// Token: 0x0402E354 RID: 189268
		[Token(Token = "0x402E354")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0402E355 RID: 189269
		[Token(Token = "0x402E355")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _priceSprite;

		// Token: 0x0402E356 RID: 189270
		[Token(Token = "0x402E356")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _priceText;

		// Token: 0x0402E357 RID: 189271
		[Token(Token = "0x402E357")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _index;

		// Token: 0x0402E358 RID: 189272
		[Token(Token = "0x402E358")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _count;

		// Token: 0x0402E359 RID: 189273
		[Token(Token = "0x402E359")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _backImage;

		// Token: 0x0402E35A RID: 189274
		[Token(Token = "0x402E35A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _isSoldOut;

		// Token: 0x0402E35B RID: 189275
		[Token(Token = "0x402E35B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _pricePart;

		// Token: 0x0402E35C RID: 189276
		[Token(Token = "0x402E35C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _uiScaler;

		// Token: 0x0402E35D RID: 189277
		[Token(Token = "0x402E35D")]
		[FieldOffset(Offset = "0x5C")]
		private bool m_isInited;

		// Token: 0x0402E35E RID: 189278
		[Token(Token = "0x402E35E")]
		[FieldOffset(Offset = "0x60")]
		private UIItemCard m_itemCard;

		// Token: 0x0402E35F RID: 189279
		[Token(Token = "0x402E35F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly float[] BACKIMAGEBLACKTYPE;

		// Token: 0x0402E360 RID: 189280
		[Token(Token = "0x402E360")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402E361 RID: 189281
		[Token(Token = "0x402E361")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitCommonPart;

		// Token: 0x0402E362 RID: 189282
		[Token(Token = "0x402E362")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitActiveData;

		// Token: 0x0402E363 RID: 189283
		[Token(Token = "0x402E363")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitUnActiveData;

		// Token: 0x0402E364 RID: 189284
		[Token(Token = "0x402E364")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
