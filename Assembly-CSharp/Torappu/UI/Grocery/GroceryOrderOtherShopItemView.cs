using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CCD RID: 19661
	[Token(Token = "0x2004CCD")]
	public class GroceryOrderOtherShopItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D725 RID: 120613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D725")]
		[Address(RVA = "0x1700EC0", Offset = "0x16FFAC0", VA = "0x181700EC0")]
		public void Render(GroceryOrderOtherShopItemViewModel itemViewModel, string curChangingGoodId)
		{
		}

		// Token: 0x0601D726 RID: 120614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D726")]
		[Address(RVA = "0x1701480", Offset = "0x1700080", VA = "0x181701480")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D727 RID: 120615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D727")]
		[Address(RVA = "0x1701630", Offset = "0x1700230", VA = "0x181701630")]
		private void _RefreshOrderCount(GroceryOrderOtherShopItemViewModel itemViewModel, bool fastMode = false)
		{
		}

		// Token: 0x0601D728 RID: 120616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D728")]
		[Address(RVA = "0x1700D20", Offset = "0x16FF920", VA = "0x181700D20")]
		public void OnClick()
		{
		}

		// Token: 0x0601D729 RID: 120617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D729")]
		[Address(RVA = "0x1701930", Offset = "0x1700530", VA = "0x181701930")]
		public GroceryOrderOtherShopItemView()
		{
		}

		// Token: 0x04026D17 RID: 158999
		[Token(Token = "0x4026D17")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Empty")]
		private GameObject _objEmpty;

		// Token: 0x04026D18 RID: 159000
		[Token(Token = "0x4026D18")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Info")]
		private GameObject _objInfo;

		// Token: 0x04026D19 RID: 159001
		[Token(Token = "0x4026D19")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Not Inquire")]
		private CanvasGroup _canvasNotInquire;

		// Token: 0x04026D1A RID: 159002
		[Token(Token = "0x4026D1A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Not Inquire")]
		private Image _imgIconNotInquire;

		// Token: 0x04026D1B RID: 159003
		[Token(Token = "0x4026D1B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Inquired")]
		private GameObject _objInquired;

		// Token: 0x04026D1C RID: 159004
		[Token(Token = "0x4026D1C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Inquired")]
		private Image _imgIconInquired;

		// Token: 0x04026D1D RID: 159005
		[Token(Token = "0x4026D1D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Inquired")]
		private Text _txtStrategy;

		// Token: 0x04026D1E RID: 159006
		[Token(Token = "0x4026D1E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Inquired")]
		private GameObject _objExactCount;

		// Token: 0x04026D1F RID: 159007
		[Token(Token = "0x4026D1F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Inquired")]
		private Text _txtExactCount;

		// Token: 0x04026D20 RID: 159008
		[Token(Token = "0x4026D20")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Inquired")]
		private GameObject _objRangeCount;

		// Token: 0x04026D21 RID: 159009
		[Token(Token = "0x4026D21")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Inquired")]
		private Text _txtRangeDownCount;

		// Token: 0x04026D22 RID: 159010
		[Token(Token = "0x4026D22")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Inquired")]
		private Text _txtRangeUpCount;

		// Token: 0x04026D23 RID: 159011
		[Token(Token = "0x4026D23")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInit;

		// Token: 0x04026D24 RID: 159012
		[Token(Token = "0x4026D24")]
		[FieldOffset(Offset = "0x80")]
		private string m_cachedShopId;

		// Token: 0x04026D25 RID: 159013
		[Token(Token = "0x4026D25")]
		[FieldOffset(Offset = "0x88")]
		private string m_cachedGoodId;

		// Token: 0x04026D26 RID: 159014
		[Token(Token = "0x4026D26")]
		[FieldOffset(Offset = "0x90")]
		private GroceryOrderOtherShopStatus m_cachedStatus;

		// Token: 0x04026D27 RID: 159015
		[Token(Token = "0x4026D27")]
		[FieldOffset(Offset = "0x98")]
		private FadeSwitchTween m_notInquireTween;

		// Token: 0x04026D28 RID: 159016
		[Token(Token = "0x4026D28")]
		[FieldOffset(Offset = "0xA0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04026D29 RID: 159017
		[Token(Token = "0x4026D29")]
		[FieldOffset(Offset = "0xB0")]
		private GroceryOrderCountTextTweener m_exactCountTweener;

		// Token: 0x04026D2A RID: 159018
		[Token(Token = "0x4026D2A")]
		[FieldOffset(Offset = "0xB8")]
		private GroceryOrderCountTextTweener m_rangeDownCountTweener;

		// Token: 0x04026D2B RID: 159019
		[Token(Token = "0x4026D2B")]
		[FieldOffset(Offset = "0xC0")]
		private GroceryOrderCountTextTweener m_rangeUpCountTweener;

		// Token: 0x04026D2C RID: 159020
		[Token(Token = "0x4026D2C")]
		private const float CNT_CHANGE_DUR = 0.5f;

		// Token: 0x04026D2D RID: 159021
		[Token(Token = "0x4026D2D")]
		private const float INQUIRE_COUNT_NOT_ENOUGH_ALPHA = 0.3f;

		// Token: 0x04026D2E RID: 159022
		[Token(Token = "0x4026D2E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04026D2F RID: 159023
		[Token(Token = "0x4026D2F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026D30 RID: 159024
		[Token(Token = "0x4026D30")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RefreshOrderCount;

		// Token: 0x04026D31 RID: 159025
		[Token(Token = "0x4026D31")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04026D32 RID: 159026
		[Token(Token = "0x4026D32")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004CCE RID: 19662
		[Token(Token = "0x2004CCE")]
		public class ShopItemClickParam : IHotfixable
		{
			// Token: 0x0601D72A RID: 120618 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D72A")]
			[Address(RVA = "0x170CC10", Offset = "0x170B810", VA = "0x18170CC10")]
			public ShopItemClickParam()
			{
			}

			// Token: 0x04026D33 RID: 159027
			[Token(Token = "0x4026D33")]
			[FieldOffset(Offset = "0x10")]
			public string goodId;

			// Token: 0x04026D34 RID: 159028
			[Token(Token = "0x4026D34")]
			[FieldOffset(Offset = "0x18")]
			public string shopId;

			// Token: 0x04026D35 RID: 159029
			[Token(Token = "0x4026D35")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
