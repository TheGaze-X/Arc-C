using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B61 RID: 23393
	[Token(Token = "0x2005B61")]
	public class SkinShopPerBlindboxItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004F74 RID: 20340
		// (get) Token: 0x06021F47 RID: 139079 RVA: 0x000BBED8 File Offset: 0x000BA0D8
		[Token(Token = "0x17004F74")]
		public bool isAvailable
		{
			[Token(Token = "0x6021F47")]
			[Address(RVA = "0x1C7D1B0", Offset = "0x1C7BDB0", VA = "0x181C7D1B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06021F48 RID: 139080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F48")]
		[Address(RVA = "0x1C7C540", Offset = "0x1C7B140", VA = "0x181C7C540")]
		public void OnClick()
		{
		}

		// Token: 0x06021F49 RID: 139081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F49")]
		[Address(RVA = "0x1C7C700", Offset = "0x1C7B300", VA = "0x181C7C700")]
		public void Render(ISkinShopItemViewModel viewModel)
		{
		}

		// Token: 0x06021F4A RID: 139082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F4A")]
		[Address(RVA = "0x1C7D050", Offset = "0x1C7BC50", VA = "0x181C7D050")]
		private void _SendMessageToState()
		{
		}

		// Token: 0x06021F4B RID: 139083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F4B")]
		[Address(RVA = "0x1C7D150", Offset = "0x1C7BD50", VA = "0x181C7D150")]
		public SkinShopPerBlindboxItemView()
		{
		}

		// Token: 0x0402E840 RID: 190528
		[Token(Token = "0x402E840")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _blindboxImage;

		// Token: 0x0402E841 RID: 190529
		[Token(Token = "0x402E841")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _timeLimitObj;

		// Token: 0x0402E842 RID: 190530
		[Token(Token = "0x402E842")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _timeLimitText;

		// Token: 0x0402E843 RID: 190531
		[Token(Token = "0x402E843")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _selectionVoucherPart;

		// Token: 0x0402E844 RID: 190532
		[Token(Token = "0x402E844")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _selectionVoucherIcon;

		// Token: 0x0402E845 RID: 190533
		[Token(Token = "0x402E845")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _blindboxGoodNameText;

		// Token: 0x0402E846 RID: 190534
		[Token(Token = "0x402E846")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _blindboxSubtitleText;

		// Token: 0x0402E847 RID: 190535
		[Token(Token = "0x402E847")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _diamondSHDPart;

		// Token: 0x0402E848 RID: 190536
		[Token(Token = "0x402E848")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _currentPriceDiamondSHD;

		// Token: 0x0402E849 RID: 190537
		[Token(Token = "0x402E849")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _remainCountText;

		// Token: 0x0402E84A RID: 190538
		[Token(Token = "0x402E84A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _soldOutPart;

		// Token: 0x0402E84B RID: 190539
		[Token(Token = "0x402E84B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _soldOutCanvas;

		// Token: 0x0402E84C RID: 190540
		[Token(Token = "0x402E84C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIButton _openDetailButton;

		// Token: 0x0402E84D RID: 190541
		[Token(Token = "0x402E84D")]
		[FieldOffset(Offset = "0x80")]
		private SkinShopBlindBoxViewModel m_cacheViewModel;

		// Token: 0x0402E84E RID: 190542
		[Token(Token = "0x402E84E")]
		[FieldOffset(Offset = "0x88")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402E84F RID: 190543
		[Token(Token = "0x402E84F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isAvailable;

		// Token: 0x0402E850 RID: 190544
		[Token(Token = "0x402E850")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402E851 RID: 190545
		[Token(Token = "0x402E851")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402E852 RID: 190546
		[Token(Token = "0x402E852")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SendMessageToState;

		// Token: 0x0402E853 RID: 190547
		[Token(Token = "0x402E853")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
