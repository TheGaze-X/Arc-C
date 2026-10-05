using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007255 RID: 29269
	[Token(Token = "0x2007255")]
	public class Act5D1ShopDetailComplexView : Act5D1ShopDetailView, IHotfixable
	{
		// Token: 0x060297B1 RID: 169905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297B1")]
		[Address(RVA = "0x24E8820", Offset = "0x24E7420", VA = "0x1824E8820", Slot = "4")]
		public override void ApplyData(Act5D1ShopCommonViewModel data)
		{
		}

		// Token: 0x060297B2 RID: 169906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297B2")]
		[Address(RVA = "0x24E8E80", Offset = "0x24E7A80", VA = "0x1824E8E80", Slot = "5")]
		public override void OnClick()
		{
		}

		// Token: 0x060297B3 RID: 169907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297B3")]
		[Address(RVA = "0x24E8740", Offset = "0x24E7340", VA = "0x1824E8740")]
		public void AddOne()
		{
		}

		// Token: 0x060297B4 RID: 169908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297B4")]
		[Address(RVA = "0x24E8D40", Offset = "0x24E7940", VA = "0x1824E8D40")]
		public void MinusOne()
		{
		}

		// Token: 0x060297B5 RID: 169909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297B5")]
		[Address(RVA = "0x24E87B0", Offset = "0x24E73B0", VA = "0x1824E87B0")]
		public void AddToMax()
		{
		}

		// Token: 0x060297B6 RID: 169910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297B6")]
		[Address(RVA = "0x24E8DB0", Offset = "0x24E79B0", VA = "0x1824E8DB0")]
		public void MinusToOne()
		{
		}

		// Token: 0x060297B7 RID: 169911 RVA: 0x000D5C48 File Offset: 0x000D3E48
		[Token(Token = "0x60297B7")]
		[Address(RVA = "0x24E8C10", Offset = "0x24E7810", VA = "0x1824E8C10")]
		public int GetMaxPrice()
		{
			return 0;
		}

		// Token: 0x060297B8 RID: 169912 RVA: 0x000D5C60 File Offset: 0x000D3E60
		[Token(Token = "0x60297B8")]
		[Address(RVA = "0x24E8F10", Offset = "0x24E7B10", VA = "0x1824E8F10")]
		public int RefreshNum(int currCount)
		{
			return 0;
		}

		// Token: 0x060297B9 RID: 169913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297B9")]
		[Address(RVA = "0x24E9020", Offset = "0x24E7C20", VA = "0x1824E9020")]
		private void _RefreshClick()
		{
		}

		// Token: 0x060297BA RID: 169914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297BA")]
		[Address(RVA = "0x24E9140", Offset = "0x24E7D40", VA = "0x1824E9140")]
		public Act5D1ShopDetailComplexView()
		{
		}

		// Token: 0x060297BB RID: 169915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297BB")]
		[Address(RVA = "0x24E8F90", Offset = "0x24E7B90", VA = "0x1824E8F90")]
		private void <>xLuaBaseProxy_ApplyData(Act5D1ShopCommonViewModel P0)
		{
		}

		// Token: 0x060297BC RID: 169916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297BC")]
		[Address(RVA = "0x24E8FA0", Offset = "0x24E7BA0", VA = "0x1824E8FA0")]
		private void <>xLuaBaseProxy_OnClick()
		{
		}

		// Token: 0x0403B444 RID: 242756
		[Token(Token = "0x403B444")]
		[FieldOffset(Offset = "0x40")]
		private int m_shopBuyCount;

		// Token: 0x0403B445 RID: 242757
		[Token(Token = "0x403B445")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Act5D1ShopDetailItemPileView _pileView;

		// Token: 0x0403B446 RID: 242758
		[Token(Token = "0x403B446")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _shopBuyCount;

		// Token: 0x0403B447 RID: 242759
		[Token(Token = "0x403B447")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _remainCount;

		// Token: 0x0403B448 RID: 242760
		[Token(Token = "0x403B448")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _shopItemName;

		// Token: 0x0403B449 RID: 242761
		[Token(Token = "0x403B449")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _shopPerCount;

		// Token: 0x0403B44A RID: 242762
		[Token(Token = "0x403B44A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _shopAvailCount;

		// Token: 0x0403B44B RID: 242763
		[Token(Token = "0x403B44B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _totalPrice;

		// Token: 0x0403B44C RID: 242764
		[Token(Token = "0x403B44C")]
		[FieldOffset(Offset = "0x80")]
		private Act5D1ShopCommonViewModel m_data;

		// Token: 0x0403B44D RID: 242765
		[Token(Token = "0x403B44D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0403B44E RID: 242766
		[Token(Token = "0x403B44E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403B44F RID: 242767
		[Token(Token = "0x403B44F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AddOne;

		// Token: 0x0403B450 RID: 242768
		[Token(Token = "0x403B450")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_MinusOne;

		// Token: 0x0403B451 RID: 242769
		[Token(Token = "0x403B451")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_AddToMax;

		// Token: 0x0403B452 RID: 242770
		[Token(Token = "0x403B452")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_MinusToOne;

		// Token: 0x0403B453 RID: 242771
		[Token(Token = "0x403B453")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetMaxPrice;

		// Token: 0x0403B454 RID: 242772
		[Token(Token = "0x403B454")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RefreshNum;

		// Token: 0x0403B455 RID: 242773
		[Token(Token = "0x403B455")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RefreshClick;

		// Token: 0x0403B456 RID: 242774
		[Token(Token = "0x403B456")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
