using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A9B RID: 23195
	[Token(Token = "0x2005A9B")]
	public class ShopDetailChooseGpView : ShopDetailCommonView, IHotfixable
	{
		// Token: 0x06021BAE RID: 138158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BAE")]
		[Address(RVA = "0x1C209C0", Offset = "0x1C1F5C0", VA = "0x181C209C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021BAF RID: 138159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BAF")]
		[Address(RVA = "0x1C1FEB0", Offset = "0x1C1EAB0", VA = "0x181C1FEB0", Slot = "4")]
		public override void ApplyData(DetailCommonViewModel viewModel, SpriteHub priceTypeHub)
		{
		}

		// Token: 0x06021BB0 RID: 138160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BB0")]
		[Address(RVA = "0x1C205B0", Offset = "0x1C1F1B0", VA = "0x181C205B0")]
		public void OnGetDetail(int indexId)
		{
		}

		// Token: 0x06021BB1 RID: 138161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BB1")]
		[Address(RVA = "0x1C20680", Offset = "0x1C1F280", VA = "0x181C20680")]
		public void RefreshIndexInfo(int indexId)
		{
		}

		// Token: 0x06021BB2 RID: 138162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BB2")]
		[Address(RVA = "0x1C20390", Offset = "0x1C1EF90", VA = "0x181C20390", Slot = "5")]
		public override void OnClick()
		{
		}

		// Token: 0x06021BB3 RID: 138163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BB3")]
		[Address(RVA = "0x1C20AF0", Offset = "0x1C1F6F0", VA = "0x181C20AF0")]
		public ShopDetailChooseGpView()
		{
		}

		// Token: 0x06021BB4 RID: 138164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BB4")]
		[Address(RVA = "0x1C1EA10", Offset = "0x1C1D610", VA = "0x181C1EA10")]
		private void <>xLuaBaseProxy_ApplyData(DetailCommonViewModel P0, SpriteHub P1)
		{
		}

		// Token: 0x06021BB5 RID: 138165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BB5")]
		[Address(RVA = "0x1C1EA20", Offset = "0x1C1D620", VA = "0x181C1EA20")]
		private void <>xLuaBaseProxy_OnClick()
		{
		}

		// Token: 0x0402E23F RID: 188991
		[Token(Token = "0x402E23F")]
		private const int UNSELECT_INDEX = -1;

		// Token: 0x0402E240 RID: 188992
		[Token(Token = "0x402E240")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private SimpleLayoutContent _gpItemList;

		// Token: 0x0402E241 RID: 188993
		[Token(Token = "0x402E241")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private ShopDetailChooseGpView.UIOptionEvent _findDetailAction;

		// Token: 0x0402E242 RID: 188994
		[Token(Token = "0x402E242")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Image _spriteImage;

		// Token: 0x0402E243 RID: 188995
		[Token(Token = "0x402E243")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x0402E244 RID: 188996
		[Token(Token = "0x402E244")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Text _itemText;

		// Token: 0x0402E245 RID: 188997
		[Token(Token = "0x402E245")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Text _itemCount;

		// Token: 0x0402E246 RID: 188998
		[Token(Token = "0x402E246")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Remain")]
		private GameObject _panelRemain;

		// Token: 0x0402E247 RID: 188999
		[Token(Token = "0x402E247")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Remain")]
		private Text _remainCount;

		// Token: 0x0402E248 RID: 189000
		[Token(Token = "0x402E248")]
		[FieldOffset(Offset = "0xE8")]
		private ShopDetailChooseGpView.Adapter m_adapter;

		// Token: 0x0402E249 RID: 189001
		[Token(Token = "0x402E249")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_isInited;

		// Token: 0x0402E24A RID: 189002
		[Token(Token = "0x402E24A")]
		[FieldOffset(Offset = "0xF8")]
		private DetailChooseGPViewModel m_cacheChooseViewModel;

		// Token: 0x0402E24B RID: 189003
		[Token(Token = "0x402E24B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402E24C RID: 189004
		[Token(Token = "0x402E24C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E24D RID: 189005
		[Token(Token = "0x402E24D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnGetDetail;

		// Token: 0x0402E24E RID: 189006
		[Token(Token = "0x402E24E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RefreshIndexInfo;

		// Token: 0x0402E24F RID: 189007
		[Token(Token = "0x402E24F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402E250 RID: 189008
		[Token(Token = "0x402E250")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005A9C RID: 23196
		[Token(Token = "0x2005A9C")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17004F10 RID: 20240
			// (get) Token: 0x06021BB6 RID: 138166 RVA: 0x000BB2A8 File Offset: 0x000B94A8
			[Token(Token = "0x17004F10")]
			public override int count
			{
				[Token(Token = "0x6021BB6")]
				[Address(RVA = "0x1C169C0", Offset = "0x1C155C0", VA = "0x181C169C0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06021BB7 RID: 138167 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021BB7")]
			[Address(RVA = "0x1C16600", Offset = "0x1C15200", VA = "0x181C16600", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06021BB8 RID: 138168 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021BB8")]
			[Address(RVA = "0x1C16950", Offset = "0x1C15550", VA = "0x181C16950")]
			public Adapter()
			{
			}

			// Token: 0x0402E251 RID: 189009
			[Token(Token = "0x402E251")]
			[FieldOffset(Offset = "0x20")]
			public List<ChooseGiftPackageShopOption> options;

			// Token: 0x0402E252 RID: 189010
			[Token(Token = "0x402E252")]
			[FieldOffset(Offset = "0x28")]
			public int selectIndex;

			// Token: 0x0402E253 RID: 189011
			[Token(Token = "0x402E253")]
			[FieldOffset(Offset = "0x30")]
			public Action<int> selectIndexAction;

			// Token: 0x0402E254 RID: 189012
			[Token(Token = "0x402E254")]
			[FieldOffset(Offset = "0x38")]
			public Action<int> detailAction;

			// Token: 0x0402E255 RID: 189013
			[Token(Token = "0x402E255")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402E256 RID: 189014
			[Token(Token = "0x402E256")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402E257 RID: 189015
			[Token(Token = "0x402E257")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005A9D RID: 23197
		[Token(Token = "0x2005A9D")]
		[Serializable]
		public class UIOptionEvent : UnityEvent<ChooseGiftPackageShopOption>
		{
			// Token: 0x06021BB9 RID: 138169 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021BB9")]
			[Address(RVA = "0x1C2E2D0", Offset = "0x1C2CED0", VA = "0x181C2E2D0")]
			public void Callback(ChooseGiftPackageShopOption param)
			{
			}

			// Token: 0x06021BBA RID: 138170 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021BBA")]
			[Address(RVA = "0x1C2E320", Offset = "0x1C2CF20", VA = "0x181C2E320")]
			public UIOptionEvent()
			{
			}
		}
	}
}
