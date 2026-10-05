using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007259 RID: 29273
	[Token(Token = "0x2007259")]
	public class Act5D1ShopDetailProgressItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x060297C6 RID: 169926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297C6")]
		[Address(RVA = "0x24EA1F0", Offset = "0x24E8DF0", VA = "0x1824EA1F0")]
		private void InitCommonPart(int index, Act5D1ProgressGoodItem item)
		{
		}

		// Token: 0x060297C7 RID: 169927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297C7")]
		[Address(RVA = "0x24EA140", Offset = "0x24E8D40", VA = "0x1824EA140")]
		public void InitActiveData(int index, ShopDetailPriceType priceType, Act5D1ProgressGoodItem item)
		{
		}

		// Token: 0x060297C8 RID: 169928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297C8")]
		[Address(RVA = "0x24EA490", Offset = "0x24E9090", VA = "0x1824EA490")]
		public void InitUnActiveData(int index, ShopDetailPriceType priceType, Act5D1ProgressGoodItem item, bool isSoldOut)
		{
		}

		// Token: 0x060297C9 RID: 169929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297C9")]
		[Address(RVA = "0x24EA700", Offset = "0x24E9300", VA = "0x1824EA700")]
		public Act5D1ShopDetailProgressItem()
		{
		}

		// Token: 0x0403B46D RID: 242797
		[Token(Token = "0x403B46D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _itemSprite;

		// Token: 0x0403B46E RID: 242798
		[Token(Token = "0x403B46E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _priceSprite;

		// Token: 0x0403B46F RID: 242799
		[Token(Token = "0x403B46F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _priceText;

		// Token: 0x0403B470 RID: 242800
		[Token(Token = "0x403B470")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _index;

		// Token: 0x0403B471 RID: 242801
		[Token(Token = "0x403B471")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _count;

		// Token: 0x0403B472 RID: 242802
		[Token(Token = "0x403B472")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _backImage;

		// Token: 0x0403B473 RID: 242803
		[Token(Token = "0x403B473")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _isSoldOut;

		// Token: 0x0403B474 RID: 242804
		[Token(Token = "0x403B474")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _pricePart;

		// Token: 0x0403B475 RID: 242805
		[Token(Token = "0x403B475")]
		[FieldOffset(Offset = "0x0")]
		private static readonly float[] BACKIMAGEBLACKTYPE;

		// Token: 0x0403B476 RID: 242806
		[Token(Token = "0x403B476")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitCommonPart;

		// Token: 0x0403B477 RID: 242807
		[Token(Token = "0x403B477")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitActiveData;

		// Token: 0x0403B478 RID: 242808
		[Token(Token = "0x403B478")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitUnActiveData;

		// Token: 0x0403B479 RID: 242809
		[Token(Token = "0x403B479")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
