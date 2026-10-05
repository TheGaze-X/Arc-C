using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005ACF RID: 23247
	[Token(Token = "0x2005ACF")]
	public class ShopGPSimplePanelAdapter : UIRecycleLayoutAdapter
	{
		// Token: 0x17004F1D RID: 20253
		// (get) Token: 0x06021CA4 RID: 138404 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06021CA5 RID: 138405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004F1D")]
		public ExposureTracker exposureTracker
		{
			[Token(Token = "0x6021CA4")]
			[Address(RVA = "0x1C51540", Offset = "0x1C50140", VA = "0x181C51540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6021CA5")]
			[Address(RVA = "0x1C515A0", Offset = "0x1C501A0", VA = "0x181C515A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06021CA6 RID: 138406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CA6")]
		[Address(RVA = "0x1C514C0", Offset = "0x1C500C0", VA = "0x181C514C0")]
		public ShopGPSimplePanelAdapter(ShopGPSimplePanelAdapter.IShopGPSimplePanelHolder holder)
		{
		}

		// Token: 0x06021CA7 RID: 138407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CA7")]
		[Address(RVA = "0x1C510D0", Offset = "0x1C4FCD0", VA = "0x181C510D0")]
		public void RebuildAll()
		{
		}

		// Token: 0x06021CA8 RID: 138408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021CA8")]
		[Address(RVA = "0x1C50D90", Offset = "0x1C4F990", VA = "0x181C50D90", Slot = "4")]
		public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
		{
			return null;
		}

		// Token: 0x06021CA9 RID: 138409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CA9")]
		[Address(RVA = "0x1C511F0", Offset = "0x1C4FDF0", VA = "0x181C511F0")]
		private void _GenerateVirtualViews(IList<ShopGPCommonItemViewModel> viewModels, IList<UIRecycleLayoutAdapter.IVirtualView> ret, ShopGPMonthlySubItem monthlyPrefab, ShopGPCommonItemView commonPrefab)
		{
		}

		// Token: 0x0402E40C RID: 189452
		[Token(Token = "0x402E40C")]
		[FieldOffset(Offset = "0x18")]
		private ShopGPSimplePanelAdapter.IShopGPSimplePanelHolder m_holder;

		// Token: 0x0402E40E RID: 189454
		[Token(Token = "0x402E40E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_exposureTracker;

		// Token: 0x0402E40F RID: 189455
		[Token(Token = "0x402E40F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_exposureTracker;

		// Token: 0x0402E410 RID: 189456
		[Token(Token = "0x402E410")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402E411 RID: 189457
		[Token(Token = "0x402E411")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RebuildAll;

		// Token: 0x0402E412 RID: 189458
		[Token(Token = "0x402E412")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

		// Token: 0x0402E413 RID: 189459
		[Token(Token = "0x402E413")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenerateVirtualViews;

		// Token: 0x02005AD0 RID: 23248
		[Token(Token = "0x2005AD0")]
		public interface IShopGPSimplePanelHolder
		{
			// Token: 0x06021CAA RID: 138410
			[Token(Token = "0x6021CAA")]
			ShopGPCommonItemView GetCommonItemViewPrefab();

			// Token: 0x06021CAB RID: 138411
			[Token(Token = "0x6021CAB")]
			ShopGPMonthlySubItem GetMonthlySubItemViewPrefab();

			// Token: 0x06021CAC RID: 138412
			[Token(Token = "0x6021CAC")]
			IList<ShopGPCommonItemViewModel> GetItemList();

			// Token: 0x06021CAD RID: 138413
			[Token(Token = "0x6021CAD")]
			IList<ShopGPCommonItemViewModel> GetSoldOutList();
		}
	}
}
