using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Crisis
{
	// Token: 0x02005A15 RID: 23061
	[Token(Token = "0x2005A15")]
	public class CrisisShopLeftProgressItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021983 RID: 137603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021983")]
		[Address(RVA = "0x1C08B00", Offset = "0x1C07700", VA = "0x181C08B00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021984 RID: 137604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021984")]
		[Address(RVA = "0x1C08560", Offset = "0x1C07160", VA = "0x181C08560")]
		private void InitCommonPart(int index, CrisisProgressShopItemViewModel item)
		{
		}

		// Token: 0x06021985 RID: 137605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021985")]
		[Address(RVA = "0x1C08400", Offset = "0x1C07000", VA = "0x181C08400")]
		public void InitActiveData(int index, int totalCount, CrisisProgressShopItemViewModel viewModel, CrisisShopVer shopVer)
		{
		}

		// Token: 0x06021986 RID: 137606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021986")]
		[Address(RVA = "0x1C088C0", Offset = "0x1C074C0", VA = "0x181C088C0")]
		public void InitUnActiveData(int index, int totalCount, CrisisProgressShopItemViewModel viewModel, bool isSoldOut)
		{
		}

		// Token: 0x06021987 RID: 137607 RVA: 0x000BAD80 File Offset: 0x000B8F80
		[Token(Token = "0x6021987")]
		[Address(RVA = "0x1C08330", Offset = "0x1C06F30", VA = "0x181C08330")]
		public float GetWidth(int totalCount, bool isActive)
		{
			return 0f;
		}

		// Token: 0x06021988 RID: 137608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021988")]
		[Address(RVA = "0x1C08D40", Offset = "0x1C07940", VA = "0x181C08D40")]
		public CrisisShopLeftProgressItem()
		{
		}

		// Token: 0x0402DEBD RID: 188093
		[Token(Token = "0x402DEBD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _itemSprite;

		// Token: 0x0402DEBE RID: 188094
		[Token(Token = "0x402DEBE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _priceSprite;

		// Token: 0x0402DEBF RID: 188095
		[Token(Token = "0x402DEBF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _priceIcon1;

		// Token: 0x0402DEC0 RID: 188096
		[Token(Token = "0x402DEC0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _priceIconV2;

		// Token: 0x0402DEC1 RID: 188097
		[Token(Token = "0x402DEC1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _priceText;

		// Token: 0x0402DEC2 RID: 188098
		[Token(Token = "0x402DEC2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _index;

		// Token: 0x0402DEC3 RID: 188099
		[Token(Token = "0x402DEC3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _count;

		// Token: 0x0402DEC4 RID: 188100
		[Token(Token = "0x402DEC4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _backImage;

		// Token: 0x0402DEC5 RID: 188101
		[Token(Token = "0x402DEC5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _charPart;

		// Token: 0x0402DEC6 RID: 188102
		[Token(Token = "0x402DEC6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _isSoldOut;

		// Token: 0x0402DEC7 RID: 188103
		[Token(Token = "0x402DEC7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _pricePart;

		// Token: 0x0402DEC8 RID: 188104
		[Token(Token = "0x402DEC8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0402DEC9 RID: 188105
		[Token(Token = "0x402DEC9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _itemScaler;

		// Token: 0x0402DECA RID: 188106
		[Token(Token = "0x402DECA")]
		[FieldOffset(Offset = "0x80")]
		private UIItemCard m_itemCard;

		// Token: 0x0402DECB RID: 188107
		[Token(Token = "0x402DECB")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x0402DECC RID: 188108
		[Token(Token = "0x402DECC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly float[] BACKIMAGEBLACKTYPE;

		// Token: 0x0402DECD RID: 188109
		[Token(Token = "0x402DECD")]
		private const float ACTIVE_SCALE = 1.64f;

		// Token: 0x0402DECE RID: 188110
		[Token(Token = "0x402DECE")]
		private const float TOTAL_WIDTH = 479f;

		// Token: 0x0402DECF RID: 188111
		[Token(Token = "0x402DECF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402DED0 RID: 188112
		[Token(Token = "0x402DED0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitCommonPart;

		// Token: 0x0402DED1 RID: 188113
		[Token(Token = "0x402DED1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitActiveData;

		// Token: 0x0402DED2 RID: 188114
		[Token(Token = "0x402DED2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitUnActiveData;

		// Token: 0x0402DED3 RID: 188115
		[Token(Token = "0x402DED3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetWidth;

		// Token: 0x0402DED4 RID: 188116
		[Token(Token = "0x402DED4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
