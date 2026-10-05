using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x0200724E RID: 29262
	[Token(Token = "0x200724E")]
	public class Act5D1RuneShopItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029786 RID: 169862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029786")]
		[Address(RVA = "0x24E50C0", Offset = "0x24E3CC0", VA = "0x1824E50C0")]
		public void ApplyData(Act5D1RuneShopState shop, Act5D1ShopGood good, [Optional] Act5D1ProgressGoodItem[] progress)
		{
		}

		// Token: 0x06029787 RID: 169863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029787")]
		[Address(RVA = "0x24E6030", Offset = "0x24E4C30", VA = "0x1824E6030")]
		private void _SynContent()
		{
		}

		// Token: 0x06029788 RID: 169864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029788")]
		[Address(RVA = "0x24E5250", Offset = "0x24E3E50", VA = "0x1824E5250")]
		public void OpenItemDetail()
		{
		}

		// Token: 0x06029789 RID: 169865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029789")]
		[Address(RVA = "0x24E55A0", Offset = "0x24E41A0", VA = "0x1824E55A0")]
		private Act5D1ShopCommonViewModel _CalculateDetailModel()
		{
			return null;
		}

		// Token: 0x0602978A RID: 169866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602978A")]
		[Address(RVA = "0x24E5890", Offset = "0x24E4490", VA = "0x1824E5890")]
		private Act5D1ProgressGoodItem _GetCurPrgGoodItem()
		{
			return null;
		}

		// Token: 0x0602978B RID: 169867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602978B")]
		[Address(RVA = "0x24E5F30", Offset = "0x24E4B30", VA = "0x1824E5F30")]
		private void _SetSoldOutObj(bool isSoldOut)
		{
		}

		// Token: 0x0602978C RID: 169868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602978C")]
		[Address(RVA = "0x24E59C0", Offset = "0x24E45C0", VA = "0x1824E59C0")]
		private void _HandleBuy()
		{
		}

		// Token: 0x0602978D RID: 169869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602978D")]
		[Address(RVA = "0x24E5A20", Offset = "0x24E4620", VA = "0x1824E5A20")]
		private void _HandleBuy(int buyCount)
		{
		}

		// Token: 0x0602978E RID: 169870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602978E")]
		[Address(RVA = "0x24E5E60", Offset = "0x24E4A60", VA = "0x1824E5E60")]
		private IEnumerator _ReceiveItemsCoroutine(RewardItemModel rewarditem)
		{
			return null;
		}

		// Token: 0x0602978F RID: 169871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602978F")]
		[Address(RVA = "0x24E5190", Offset = "0x24E3D90", VA = "0x1824E5190")]
		public void EnterDetailEvent()
		{
		}

		// Token: 0x06029790 RID: 169872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029790")]
		[Address(RVA = "0x24E51F0", Offset = "0x24E3DF0", VA = "0x1824E51F0")]
		public void OnClick()
		{
		}

		// Token: 0x06029791 RID: 169873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029791")]
		[Address(RVA = "0x24E66A0", Offset = "0x24E52A0", VA = "0x1824E66A0")]
		public Act5D1RuneShopItem()
		{
		}

		// Token: 0x0403B408 RID: 242696
		[Token(Token = "0x403B408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _button;

		// Token: 0x0403B409 RID: 242697
		[Token(Token = "0x403B409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _rarityBG1;

		// Token: 0x0403B40A RID: 242698
		[Token(Token = "0x403B40A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _rarityBG2;

		// Token: 0x0403B40B RID: 242699
		[Token(Token = "0x403B40B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _rarityBG3;

		// Token: 0x0403B40C RID: 242700
		[Token(Token = "0x403B40C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _bg;

		// Token: 0x0403B40D RID: 242701
		[Token(Token = "0x403B40D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _cardName;

		// Token: 0x0403B40E RID: 242702
		[Token(Token = "0x403B40E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _offsetPercent;

		// Token: 0x0403B40F RID: 242703
		[Token(Token = "0x403B40F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0403B410 RID: 242704
		[Token(Token = "0x403B410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _remainCount;

		// Token: 0x0403B411 RID: 242705
		[Token(Token = "0x403B411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _remainCountPart;

		// Token: 0x0403B412 RID: 242706
		[Token(Token = "0x403B412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _price;

		// Token: 0x0403B413 RID: 242707
		[Token(Token = "0x403B413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _offsetPricePart;

		// Token: 0x0403B414 RID: 242708
		[Token(Token = "0x403B414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0403B415 RID: 242709
		[Token(Token = "0x403B415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CanvasGroup _soldOutCanvasGroup;

		// Token: 0x0403B416 RID: 242710
		[Token(Token = "0x403B416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _soldOutObj;

		// Token: 0x0403B417 RID: 242711
		[Token(Token = "0x403B417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Act5D1RuneShopState m_shop;

		// Token: 0x0403B418 RID: 242712
		[Token(Token = "0x403B418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Act5D1ShopGood m_good;

		// Token: 0x0403B419 RID: 242713
		[Token(Token = "0x403B419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Act5D1ProgressGoodItem[] m_progress;

		// Token: 0x0403B41A RID: 242714
		[Token(Token = "0x403B41A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private UIItemCard m_itemCard;

		// Token: 0x0403B41B RID: 242715
		[Token(Token = "0x403B41B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0403B41C RID: 242716
		[Token(Token = "0x403B41C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SynContent;

		// Token: 0x0403B41D RID: 242717
		[Token(Token = "0x403B41D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OpenItemDetail;

		// Token: 0x0403B41E RID: 242718
		[Token(Token = "0x403B41E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CalculateDetailModel;

		// Token: 0x0403B41F RID: 242719
		[Token(Token = "0x403B41F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetCurPrgGoodItem;

		// Token: 0x0403B420 RID: 242720
		[Token(Token = "0x403B420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetSoldOutObj;

		// Token: 0x0403B421 RID: 242721
		[Token(Token = "0x403B421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__HandleBuy;

		// Token: 0x0403B422 RID: 242722
		[Token(Token = "0x403B422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix1__HandleBuy;

		// Token: 0x0403B423 RID: 242723
		[Token(Token = "0x403B423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0403B424 RID: 242724
		[Token(Token = "0x403B424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EnterDetailEvent;

		// Token: 0x0403B425 RID: 242725
		[Token(Token = "0x403B425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403B426 RID: 242726
		[Token(Token = "0x403B426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
