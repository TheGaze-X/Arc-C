using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005ACB RID: 23243
	[Token(Token = "0x2005ACB")]
	public class ShopGPMonthCardPanel : ShopGPDisplayPanelBase<ShopGPMonthCardPanelModel>
	{
		// Token: 0x17004F1B RID: 20251
		// (get) Token: 0x06021C8E RID: 138382 RVA: 0x000BB470 File Offset: 0x000B9670
		[Token(Token = "0x17004F1B")]
		protected override ShopGPPanelType type
		{
			[Token(Token = "0x6021C8E")]
			[Address(RVA = "0x1C421E0", Offset = "0x1C40DE0", VA = "0x181C421E0", Slot = "4")]
			get
			{
				return ShopGPPanelType.DEFAULT_COMMON;
			}
		}

		// Token: 0x06021C8F RID: 138383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C8F")]
		[Address(RVA = "0x1C41EB0", Offset = "0x1C40AB0", VA = "0x181C41EB0", Slot = "7")]
		protected override void OnRender(ShopGPMonthCardPanelModel panelModel)
		{
		}

		// Token: 0x06021C90 RID: 138384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C90")]
		[Address(RVA = "0x1C41FD0", Offset = "0x1C40BD0", VA = "0x181C41FD0", Slot = "8")]
		protected override void SetShow(bool isShow, bool fastMode = false)
		{
		}

		// Token: 0x06021C91 RID: 138385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C91")]
		[Address(RVA = "0x1C420A0", Offset = "0x1C40CA0", VA = "0x181C420A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021C92 RID: 138386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C92")]
		[Address(RVA = "0x1C41B30", Offset = "0x1C40730", VA = "0x181C41B30")]
		public void OnClick()
		{
		}

		// Token: 0x06021C93 RID: 138387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C93")]
		[Address(RVA = "0x1C42170", Offset = "0x1C40D70", VA = "0x181C42170")]
		public ShopGPMonthCardPanel()
		{
		}

		// Token: 0x0402E3DD RID: 189405
		[Token(Token = "0x402E3DD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _remainTime;

		// Token: 0x0402E3DE RID: 189406
		[Token(Token = "0x402E3DE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _price;

		// Token: 0x0402E3DF RID: 189407
		[Token(Token = "0x402E3DF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _rootCg;

		// Token: 0x0402E3E0 RID: 189408
		[Token(Token = "0x402E3E0")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0402E3E1 RID: 189409
		[Token(Token = "0x402E3E1")]
		[FieldOffset(Offset = "0x40")]
		private FadeSwitchTween m_switchTween;

		// Token: 0x0402E3E2 RID: 189410
		[Token(Token = "0x402E3E2")]
		[FieldOffset(Offset = "0x48")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402E3E3 RID: 189411
		[Token(Token = "0x402E3E3")]
		[FieldOffset(Offset = "0x58")]
		private ShopGPMonthlySubItemViewModel m_cacheViewModel;

		// Token: 0x0402E3E4 RID: 189412
		[Token(Token = "0x402E3E4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x0402E3E5 RID: 189413
		[Token(Token = "0x402E3E5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402E3E6 RID: 189414
		[Token(Token = "0x402E3E6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetShow;

		// Token: 0x0402E3E7 RID: 189415
		[Token(Token = "0x402E3E7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402E3E8 RID: 189416
		[Token(Token = "0x402E3E8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402E3E9 RID: 189417
		[Token(Token = "0x402E3E9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
