using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.Campaign
{
	// Token: 0x02006A46 RID: 27206
	[Token(Token = "0x2006A46")]
	[RequireComponent(typeof(CanvasGroup))]
	public class CampaignFeeControlView : DataBinder<ZoneViewProperty>
	{
		// Token: 0x06026E37 RID: 159287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E37")]
		[Address(RVA = "0x21E86F0", Offset = "0x21E72F0", VA = "0x1821E86F0", Slot = "7")]
		public override void OnValueChanged(ZoneViewProperty property)
		{
		}

		// Token: 0x06026E38 RID: 159288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E38")]
		[Address(RVA = "0x21E8EE0", Offset = "0x21E7AE0", VA = "0x1821E8EE0")]
		private void _SetVisibility(bool isVisible)
		{
		}

		// Token: 0x06026E39 RID: 159289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E39")]
		[Address(RVA = "0x21E8D90", Offset = "0x21E7990", VA = "0x1821E8D90")]
		private void _SetPanelWidth(CampaignZoneViewModel campZoneModel)
		{
		}

		// Token: 0x06026E3A RID: 159290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E3A")]
		[Address(RVA = "0x21E8A20", Offset = "0x21E7620", VA = "0x1821E8A20")]
		private void _SetData(CampaignZoneViewModel campZoneModel)
		{
		}

		// Token: 0x06026E3B RID: 159291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E3B")]
		[Address(RVA = "0x21E9050", Offset = "0x21E7C50", VA = "0x1821E9050")]
		private void _UpdateNextRefreshDateTime()
		{
		}

		// Token: 0x06026E3C RID: 159292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E3C")]
		[Address(RVA = "0x21E89C0", Offset = "0x21E75C0", VA = "0x1821E89C0")]
		private void Update()
		{
		}

		// Token: 0x06026E3D RID: 159293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E3D")]
		[Address(RVA = "0x21E9380", Offset = "0x21E7F80", VA = "0x1821E9380")]
		public CampaignFeeControlView()
		{
		}

		// Token: 0x04036FDA RID: 225242
		[Token(Token = "0x4036FDA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _feeRefreshCountDownText;

		// Token: 0x04036FDB RID: 225243
		[Token(Token = "0x4036FDB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _feeProgressText;

		// Token: 0x04036FDC RID: 225244
		[Token(Token = "0x4036FDC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Slider _feeProgressSlider;

		// Token: 0x04036FDD RID: 225245
		[Token(Token = "0x4036FDD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _notFullHint;

		// Token: 0x04036FDE RID: 225246
		[Token(Token = "0x4036FDE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _unitWidthOfTotalFee;

		// Token: 0x04036FDF RID: 225247
		[Token(Token = "0x4036FDF")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _minPanelWidth;

		// Token: 0x04036FE0 RID: 225248
		[Token(Token = "0x4036FE0")]
		[FieldOffset(Offset = "0x48")]
		private CanvasGroup m_canvasGroup;

		// Token: 0x04036FE1 RID: 225249
		[Token(Token = "0x4036FE1")]
		[FieldOffset(Offset = "0x50")]
		private RectTransform m_rectTransform;

		// Token: 0x04036FE2 RID: 225250
		[Token(Token = "0x4036FE2")]
		[FieldOffset(Offset = "0x58")]
		private FadeSwitchTween m_fadeSwitch;

		// Token: 0x04036FE3 RID: 225251
		[Token(Token = "0x4036FE3")]
		[FieldOffset(Offset = "0x60")]
		private CampaignZoneViewModel m_campZoneModel;

		// Token: 0x04036FE4 RID: 225252
		[Token(Token = "0x4036FE4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04036FE5 RID: 225253
		[Token(Token = "0x4036FE5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetVisibility;

		// Token: 0x04036FE6 RID: 225254
		[Token(Token = "0x4036FE6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetPanelWidth;

		// Token: 0x04036FE7 RID: 225255
		[Token(Token = "0x4036FE7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetData;

		// Token: 0x04036FE8 RID: 225256
		[Token(Token = "0x4036FE8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateNextRefreshDateTime;

		// Token: 0x04036FE9 RID: 225257
		[Token(Token = "0x4036FE9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04036FEA RID: 225258
		[Token(Token = "0x4036FEA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
