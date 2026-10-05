using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A64 RID: 23140
	[Token(Token = "0x2005A64")]
	public class SkinShopBlindboxRuleInfoDialog : UICompDialog<SkinShopBlindboxRuleInfoDialog.Options>
	{
		// Token: 0x06021AC5 RID: 137925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021AC5")]
		[Address(RVA = "0x1C27CA0", Offset = "0x1C268A0", VA = "0x181C27CA0", Slot = "18")]
		protected override void OnRender(SkinShopBlindboxRuleInfoDialog.Options input)
		{
		}

		// Token: 0x06021AC6 RID: 137926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021AC6")]
		[Address(RVA = "0x1C27C40", Offset = "0x1C26840", VA = "0x181C27C40", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06021AC7 RID: 137927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021AC7")]
		[Address(RVA = "0x1C27B80", Offset = "0x1C26780", VA = "0x181C27B80")]
		public void EventOnBackBtnClicked()
		{
		}

		// Token: 0x06021AC8 RID: 137928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021AC8")]
		[Address(RVA = "0x1C27DC0", Offset = "0x1C269C0", VA = "0x181C27DC0")]
		public SkinShopBlindboxRuleInfoDialog()
		{
		}

		// Token: 0x06021AC9 RID: 137929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021AC9")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0402E08D RID: 188557
		[Token(Token = "0x402E08D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _voucherTitle;

		// Token: 0x0402E08E RID: 188558
		[Token(Token = "0x402E08E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _voucherDetail;

		// Token: 0x0402E08F RID: 188559
		[Token(Token = "0x402E08F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIRenderTextureImage _blurBg;

		// Token: 0x0402E090 RID: 188560
		[Token(Token = "0x402E090")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402E091 RID: 188561
		[Token(Token = "0x402E091")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0402E092 RID: 188562
		[Token(Token = "0x402E092")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnBackBtnClicked;

		// Token: 0x0402E093 RID: 188563
		[Token(Token = "0x402E093")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005A65 RID: 23141
		[Token(Token = "0x2005A65")]
		public class Options
		{
			// Token: 0x06021ACA RID: 137930 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021ACA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x0402E094 RID: 188564
			[Token(Token = "0x402E094")]
			[FieldOffset(Offset = "0x10")]
			public string gachaVoucherName;

			// Token: 0x0402E095 RID: 188565
			[Token(Token = "0x402E095")]
			[FieldOffset(Offset = "0x18")]
			public string gachaVoucherRuleDetail;
		}
	}
}
