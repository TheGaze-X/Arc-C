using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AEC RID: 23276
	[Token(Token = "0x2005AEC")]
	public class ShopGPLeftTabListView : DataBinder<ShopGPProperty>, IHotfixable
	{
		// Token: 0x06021D46 RID: 138566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D46")]
		[Address(RVA = "0x1C4F1D0", Offset = "0x1C4DDD0", VA = "0x181C4F1D0", Slot = "7")]
		public override void OnValueChanged(ShopGPProperty property)
		{
		}

		// Token: 0x06021D47 RID: 138567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D47")]
		[Address(RVA = "0x1C4F480", Offset = "0x1C4E080", VA = "0x181C4F480")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021D48 RID: 138568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D48")]
		[Address(RVA = "0x1C4F5A0", Offset = "0x1C4E1A0", VA = "0x181C4F5A0")]
		public ShopGPLeftTabListView()
		{
		}

		// Token: 0x0402E518 RID: 189720
		[Token(Token = "0x402E518")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ShopGPAllTagItem _allTabItem;

		// Token: 0x0402E519 RID: 189721
		[Token(Token = "0x402E519")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0402E51A RID: 189722
		[Token(Token = "0x402E51A")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x0402E51B RID: 189723
		[Token(Token = "0x402E51B")]
		[FieldOffset(Offset = "0x38")]
		private ShopGPLeftTabListView.Adapter m_adapter;

		// Token: 0x0402E51C RID: 189724
		[Token(Token = "0x402E51C")]
		[FieldOffset(Offset = "0x40")]
		private List<ShopGPTabItemModel> m_cachedModels;

		// Token: 0x0402E51D RID: 189725
		[Token(Token = "0x402E51D")]
		[FieldOffset(Offset = "0x48")]
		private string m_cachedSelectedId;

		// Token: 0x0402E51E RID: 189726
		[Token(Token = "0x402E51E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402E51F RID: 189727
		[Token(Token = "0x402E51F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402E520 RID: 189728
		[Token(Token = "0x402E520")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005AED RID: 23277
		[Token(Token = "0x2005AED")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06021D49 RID: 138569 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021D49")]
			[Address(RVA = "0x1C42D00", Offset = "0x1C41900", VA = "0x181C42D00")]
			public Adapter(ShopGPLeftTabListView closure)
			{
			}

			// Token: 0x17004F2D RID: 20269
			// (get) Token: 0x06021D4A RID: 138570 RVA: 0x000BB5F0 File Offset: 0x000B97F0
			[Token(Token = "0x17004F2D")]
			public override int count
			{
				[Token(Token = "0x6021D4A")]
				[Address(RVA = "0x1C42E30", Offset = "0x1C41A30", VA = "0x181C42E30", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06021D4B RID: 138571 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021D4B")]
			[Address(RVA = "0x1C429A0", Offset = "0x1C415A0", VA = "0x181C429A0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402E521 RID: 189729
			[Token(Token = "0x402E521")]
			[FieldOffset(Offset = "0x20")]
			private ShopGPLeftTabListView m_closure;

			// Token: 0x0402E522 RID: 189730
			[Token(Token = "0x402E522")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402E523 RID: 189731
			[Token(Token = "0x402E523")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402E524 RID: 189732
			[Token(Token = "0x402E524")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
