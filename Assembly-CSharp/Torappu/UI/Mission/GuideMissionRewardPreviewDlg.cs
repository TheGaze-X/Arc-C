using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x02004864 RID: 18532
	[Token(Token = "0x2004864")]
	public class GuideMissionRewardPreviewDlg : UICompDialog<GuideMissionRewardPreviewDlg.Input>
	{
		// Token: 0x0601BFDA RID: 114650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BFDA")]
		[Address(RVA = "0x154BFE0", Offset = "0x154ABE0", VA = "0x18154BFE0", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601BFDB RID: 114651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BFDB")]
		[Address(RVA = "0x154C040", Offset = "0x154AC40", VA = "0x18154C040", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601BFDC RID: 114652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BFDC")]
		[Address(RVA = "0x154C180", Offset = "0x154AD80", VA = "0x18154C180", Slot = "18")]
		protected override void OnRender(GuideMissionRewardPreviewDlg.Input input)
		{
		}

		// Token: 0x0601BFDD RID: 114653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BFDD")]
		[Address(RVA = "0x154C250", Offset = "0x154AE50", VA = "0x18154C250")]
		private void _EventOnClose()
		{
		}

		// Token: 0x0601BFDE RID: 114654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BFDE")]
		[Address(RVA = "0x154BEF0", Offset = "0x154AAF0", VA = "0x18154BEF0")]
		public void EventOnCloseClick()
		{
		}

		// Token: 0x0601BFDF RID: 114655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BFDF")]
		[Address(RVA = "0x154C310", Offset = "0x154AF10", VA = "0x18154C310")]
		public GuideMissionRewardPreviewDlg()
		{
		}

		// Token: 0x0601BFE0 RID: 114656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BFE0")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601BFE1 RID: 114657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BFE1")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0402482E RID: 149550
		[Token(Token = "0x402482E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x0402482F RID: 149551
		[Token(Token = "0x402482F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIRenderTextureImage _blurBkg;

		// Token: 0x04024830 RID: 149552
		[Token(Token = "0x4024830")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GuideMissionRewardPreview _view;

		// Token: 0x04024831 RID: 149553
		[Token(Token = "0x4024831")]
		[FieldOffset(Offset = "0x88")]
		private GuideMissionRewardPreviewProp m_prop;

		// Token: 0x04024832 RID: 149554
		[Token(Token = "0x4024832")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x04024833 RID: 149555
		[Token(Token = "0x4024833")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04024834 RID: 149556
		[Token(Token = "0x4024834")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04024835 RID: 149557
		[Token(Token = "0x4024835")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventOnClose;

		// Token: 0x04024836 RID: 149558
		[Token(Token = "0x4024836")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnCloseClick;

		// Token: 0x04024837 RID: 149559
		[Token(Token = "0x4024837")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004865 RID: 18533
		[Token(Token = "0x2004865")]
		public class Input
		{
			// Token: 0x0601BFE2 RID: 114658 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BFE2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}
		}
	}
}
