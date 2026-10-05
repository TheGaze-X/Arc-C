using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CCA RID: 19658
	[Token(Token = "0x2004CCA")]
	public class GroceryOrderMyShopItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D71C RID: 120604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D71C")]
		[Address(RVA = "0x16FE820", Offset = "0x16FD420", VA = "0x1816FE820")]
		public void Render(GroceryOrderSelfShopViewModel selfShopViewModel, string curChangingGoodId)
		{
		}

		// Token: 0x0601D71D RID: 120605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D71D")]
		[Address(RVA = "0x16FEA10", Offset = "0x16FD610", VA = "0x1816FEA10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D71E RID: 120606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D71E")]
		[Address(RVA = "0x16FEC40", Offset = "0x16FD840", VA = "0x1816FEC40")]
		private void _RefreshExpectedOrderCount(GroceryOrderSelfShopViewModel itemViewModel, bool fastMode = false)
		{
		}

		// Token: 0x0601D71F RID: 120607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D71F")]
		[Address(RVA = "0x16FEEF0", Offset = "0x16FDAF0", VA = "0x1816FEEF0")]
		public GroceryOrderMyShopItemView()
		{
		}

		// Token: 0x04026CFA RID: 158970
		[Token(Token = "0x4026CFA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Strategy")]
		private SimpleLayoutContent _selfShopStrategyContent;

		// Token: 0x04026CFB RID: 158971
		[Token(Token = "0x4026CFB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Stock")]
		private GameObject _objStock;

		// Token: 0x04026CFC RID: 158972
		[Token(Token = "0x4026CFC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Stock")]
		private Text _txtStockCount;

		// Token: 0x04026CFD RID: 158973
		[Token(Token = "0x4026CFD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Order Count")]
		private GameObject _objUnknownCount;

		// Token: 0x04026CFE RID: 158974
		[Token(Token = "0x4026CFE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Order Count")]
		private GameObject _objExactCount;

		// Token: 0x04026CFF RID: 158975
		[Token(Token = "0x4026CFF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Order Count")]
		private Text _txtExactCount;

		// Token: 0x04026D00 RID: 158976
		[Token(Token = "0x4026D00")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Order Count")]
		private GameObject _objRangeCount;

		// Token: 0x04026D01 RID: 158977
		[Token(Token = "0x4026D01")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Order Count")]
		private Text _txtRangeDownCount;

		// Token: 0x04026D02 RID: 158978
		[Token(Token = "0x4026D02")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Order Count")]
		private Text _txtRangeUpCount;

		// Token: 0x04026D03 RID: 158979
		[Token(Token = "0x4026D03")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x04026D04 RID: 158980
		[Token(Token = "0x4026D04")]
		[FieldOffset(Offset = "0x68")]
		private GroceryOrderMyShopItemView.GroceryOrderMyShopStrategyItemViewAdapter m_adapterMyShopStrategy;

		// Token: 0x04026D05 RID: 158981
		[Token(Token = "0x4026D05")]
		[FieldOffset(Offset = "0x70")]
		private GroceryOrderSelfShopViewModel m_cachedViewModel;

		// Token: 0x04026D06 RID: 158982
		[Token(Token = "0x4026D06")]
		[FieldOffset(Offset = "0x78")]
		private GroceryOrderCountTextTweener m_exactCountTweener;

		// Token: 0x04026D07 RID: 158983
		[Token(Token = "0x4026D07")]
		[FieldOffset(Offset = "0x80")]
		private GroceryOrderCountTextTweener m_rangeDownCountTweener;

		// Token: 0x04026D08 RID: 158984
		[Token(Token = "0x4026D08")]
		[FieldOffset(Offset = "0x88")]
		private GroceryOrderCountTextTweener m_rangeUpCountTweener;

		// Token: 0x04026D09 RID: 158985
		[Token(Token = "0x4026D09")]
		private const float CNT_CHANGE_DUR = 0.5f;

		// Token: 0x04026D0A RID: 158986
		[Token(Token = "0x4026D0A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04026D0B RID: 158987
		[Token(Token = "0x4026D0B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026D0C RID: 158988
		[Token(Token = "0x4026D0C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RefreshExpectedOrderCount;

		// Token: 0x04026D0D RID: 158989
		[Token(Token = "0x4026D0D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004CCB RID: 19659
		[Token(Token = "0x2004CCB")]
		private class GroceryOrderMyShopStrategyItemViewAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601D720 RID: 120608 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D720")]
			[Address(RVA = "0x16FF110", Offset = "0x16FDD10", VA = "0x1816FF110")]
			public GroceryOrderMyShopStrategyItemViewAdapter(GroceryOrderMyShopItemView closure)
			{
			}

			// Token: 0x17004508 RID: 17672
			// (get) Token: 0x0601D721 RID: 120609 RVA: 0x000AB768 File Offset: 0x000A9968
			[Token(Token = "0x17004508")]
			public override int count
			{
				[Token(Token = "0x601D721")]
				[Address(RVA = "0x16FF190", Offset = "0x16FDD90", VA = "0x1816FF190", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D722 RID: 120610 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D722")]
			[Address(RVA = "0x16FEF50", Offset = "0x16FDB50", VA = "0x1816FEF50", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04026D0E RID: 158990
			[Token(Token = "0x4026D0E")]
			[FieldOffset(Offset = "0x20")]
			private GroceryOrderMyShopItemView m_closure;

			// Token: 0x04026D0F RID: 158991
			[Token(Token = "0x4026D0F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04026D10 RID: 158992
			[Token(Token = "0x4026D10")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04026D11 RID: 158993
			[Token(Token = "0x4026D11")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
