using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CC8 RID: 19656
	[Token(Token = "0x2004CC8")]
	public class GroceryOrderGoodItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D715 RID: 120597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D715")]
		[Address(RVA = "0x16FE1A0", Offset = "0x16FCDA0", VA = "0x1816FE1A0")]
		public void Render(GroceryOrderGoodItemViewModel goodItemViewModel, string curChangingGoodId)
		{
		}

		// Token: 0x0601D716 RID: 120598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D716")]
		[Address(RVA = "0x16FE070", Offset = "0x16FCC70", VA = "0x1816FE070")]
		public void RegisterTutorialGO()
		{
		}

		// Token: 0x0601D717 RID: 120599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D717")]
		[Address(RVA = "0x16FE610", Offset = "0x16FD210", VA = "0x1816FE610")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D718 RID: 120600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D718")]
		[Address(RVA = "0x16FE770", Offset = "0x16FD370", VA = "0x1816FE770")]
		public GroceryOrderGoodItemView()
		{
		}

		// Token: 0x04026CE4 RID: 158948
		[Token(Token = "0x4026CE4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Good")]
		private Text _txtGoodName;

		// Token: 0x04026CE5 RID: 158949
		[Token(Token = "0x4026CE5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Good")]
		private Text _txtGoodOfferCount;

		// Token: 0x04026CE6 RID: 158950
		[Token(Token = "0x4026CE6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Good")]
		private Image _imgGoodIcon;

		// Token: 0x04026CE7 RID: 158951
		[Token(Token = "0x4026CE7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Other Shops")]
		private SimpleLayoutContent _otherShopContent;

		// Token: 0x04026CE8 RID: 158952
		[Token(Token = "0x4026CE8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("My Shop")]
		private GroceryOrderMyShopItemView _myShopItemView;

		// Token: 0x04026CE9 RID: 158953
		[Token(Token = "0x4026CE9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _panelGoods;

		// Token: 0x04026CEA RID: 158954
		[Token(Token = "0x4026CEA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _panelPrice;

		// Token: 0x04026CEB RID: 158955
		[Token(Token = "0x4026CEB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _panelInquire;

		// Token: 0x04026CEC RID: 158956
		[Token(Token = "0x4026CEC")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x04026CED RID: 158957
		[Token(Token = "0x4026CED")]
		[FieldOffset(Offset = "0x60")]
		private string m_cachedGoodId;

		// Token: 0x04026CEE RID: 158958
		[Token(Token = "0x4026CEE")]
		[FieldOffset(Offset = "0x68")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04026CEF RID: 158959
		[Token(Token = "0x4026CEF")]
		[FieldOffset(Offset = "0x78")]
		private GroceryOrderGoodItemView.GrocerOrderOtherShopItemViewAdapter m_adapterOtherShop;

		// Token: 0x04026CF0 RID: 158960
		[Token(Token = "0x4026CF0")]
		[FieldOffset(Offset = "0x80")]
		private string m_curChangingGoodId;

		// Token: 0x04026CF1 RID: 158961
		[Token(Token = "0x4026CF1")]
		[FieldOffset(Offset = "0x88")]
		private GroceryOrderGoodItemViewModel m_cachedViewModel;

		// Token: 0x04026CF2 RID: 158962
		[Token(Token = "0x4026CF2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04026CF3 RID: 158963
		[Token(Token = "0x4026CF3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x04026CF4 RID: 158964
		[Token(Token = "0x4026CF4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026CF5 RID: 158965
		[Token(Token = "0x4026CF5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004CC9 RID: 19657
		[Token(Token = "0x2004CC9")]
		private class GrocerOrderOtherShopItemViewAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601D719 RID: 120601 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D719")]
			[Address(RVA = "0x16F4C10", Offset = "0x16F3810", VA = "0x1816F4C10")]
			public GrocerOrderOtherShopItemViewAdapter(GroceryOrderGoodItemView closure)
			{
			}

			// Token: 0x17004507 RID: 17671
			// (get) Token: 0x0601D71A RID: 120602 RVA: 0x000AB750 File Offset: 0x000A9950
			[Token(Token = "0x17004507")]
			public override int count
			{
				[Token(Token = "0x601D71A")]
				[Address(RVA = "0x16F4C90", Offset = "0x16F3890", VA = "0x1816F4C90", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D71B RID: 120603 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D71B")]
			[Address(RVA = "0x16F4A40", Offset = "0x16F3640", VA = "0x1816F4A40", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04026CF6 RID: 158966
			[Token(Token = "0x4026CF6")]
			[FieldOffset(Offset = "0x20")]
			private GroceryOrderGoodItemView m_closure;

			// Token: 0x04026CF7 RID: 158967
			[Token(Token = "0x4026CF7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04026CF8 RID: 158968
			[Token(Token = "0x4026CF8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04026CF9 RID: 158969
			[Token(Token = "0x4026CF9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
