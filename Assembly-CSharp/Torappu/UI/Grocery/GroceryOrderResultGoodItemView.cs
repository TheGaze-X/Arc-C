using System;
using System.Collections;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CE1 RID: 19681
	[Token(Token = "0x2004CE1")]
	public class GroceryOrderResultGoodItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D7FB RID: 120827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D7FB")]
		[Address(RVA = "0x170FE50", Offset = "0x170EA50", VA = "0x18170FE50")]
		public void Render(GroceryOrderResultGoodItemViewModel goodItemViewModel)
		{
		}

		// Token: 0x0601D7FC RID: 120828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D7FC")]
		[Address(RVA = "0x170FDA0", Offset = "0x170E9A0", VA = "0x18170FDA0")]
		public IEnumerator PlayShopItemSliderTween()
		{
			return null;
		}

		// Token: 0x0601D7FD RID: 120829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D7FD")]
		[Address(RVA = "0x1710150", Offset = "0x170ED50", VA = "0x181710150")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D7FE RID: 120830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D7FE")]
		[Address(RVA = "0x17102B0", Offset = "0x170EEB0", VA = "0x1817102B0")]
		public GroceryOrderResultGoodItemView()
		{
		}

		// Token: 0x04026E8B RID: 159371
		[Token(Token = "0x4026E8B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Good")]
		private Text _txtGoodName;

		// Token: 0x04026E8C RID: 159372
		[Token(Token = "0x4026E8C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Good")]
		private Image _imgGoodIcon;

		// Token: 0x04026E8D RID: 159373
		[Token(Token = "0x4026E8D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Shops")]
		private SimpleLayoutContent _shopContent;

		// Token: 0x04026E8E RID: 159374
		[Token(Token = "0x4026E8E")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x04026E8F RID: 159375
		[Token(Token = "0x4026E8F")]
		[FieldOffset(Offset = "0x38")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04026E90 RID: 159376
		[Token(Token = "0x4026E90")]
		[FieldOffset(Offset = "0x48")]
		private GroceryOrderResultGoodItemViewModel m_cachedViewModel;

		// Token: 0x04026E91 RID: 159377
		[Token(Token = "0x4026E91")]
		[FieldOffset(Offset = "0x50")]
		private GroceryOrderResultGoodItemView.GrocerOrderResultShopItemViewAdapter m_adapterShop;

		// Token: 0x04026E92 RID: 159378
		[Token(Token = "0x4026E92")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04026E93 RID: 159379
		[Token(Token = "0x4026E93")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayShopItemSliderTween;

		// Token: 0x04026E94 RID: 159380
		[Token(Token = "0x4026E94")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026E95 RID: 159381
		[Token(Token = "0x4026E95")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004CE2 RID: 19682
		[Token(Token = "0x2004CE2")]
		private class GrocerOrderResultShopItemViewAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601D7FF RID: 120831 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D7FF")]
			[Address(RVA = "0x170E2D0", Offset = "0x170CED0", VA = "0x18170E2D0")]
			public GrocerOrderResultShopItemViewAdapter(GroceryOrderResultGoodItemView closure)
			{
			}

			// Token: 0x17004542 RID: 17730
			// (get) Token: 0x0601D800 RID: 120832 RVA: 0x000ABB88 File Offset: 0x000A9D88
			[Token(Token = "0x17004542")]
			public override int count
			{
				[Token(Token = "0x601D800")]
				[Address(RVA = "0x170E350", Offset = "0x170CF50", VA = "0x18170E350", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D801 RID: 120833 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D801")]
			[Address(RVA = "0x170E040", Offset = "0x170CC40", VA = "0x18170E040", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601D802 RID: 120834 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D802")]
			[Address(RVA = "0x170DF90", Offset = "0x170CB90", VA = "0x18170DF90")]
			public IEnumerator PlayEnterAnim()
			{
				return null;
			}

			// Token: 0x0601D803 RID: 120835 RVA: 0x000ABBA0 File Offset: 0x000A9DA0
			[Token(Token = "0x601D803")]
			[Address(RVA = "0x170E230", Offset = "0x170CE30", VA = "0x18170E230")]
			private float _GetDelay(int index)
			{
				return 0f;
			}

			// Token: 0x04026E96 RID: 159382
			[Token(Token = "0x4026E96")]
			[FieldOffset(Offset = "0x20")]
			private GroceryOrderResultGoodItemView m_closure;

			// Token: 0x04026E97 RID: 159383
			[Token(Token = "0x4026E97")]
			private const float DELAY_START = 0.6f;

			// Token: 0x04026E98 RID: 159384
			[Token(Token = "0x4026E98")]
			private const float DELAY_FIRST_SHOP = 0f;

			// Token: 0x04026E99 RID: 159385
			[Token(Token = "0x4026E99")]
			private const float DELAY_SECOND_SHOP = 0.2f;

			// Token: 0x04026E9A RID: 159386
			[Token(Token = "0x4026E9A")]
			private const float DELAY_THIRD_SHOP = 0.4f;

			// Token: 0x04026E9B RID: 159387
			[Token(Token = "0x4026E9B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04026E9C RID: 159388
			[Token(Token = "0x4026E9C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04026E9D RID: 159389
			[Token(Token = "0x4026E9D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04026E9E RID: 159390
			[Token(Token = "0x4026E9E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_PlayEnterAnim;

			// Token: 0x04026E9F RID: 159391
			[Token(Token = "0x4026E9F")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__GetDelay;
		}
	}
}
