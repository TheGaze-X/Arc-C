using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006691 RID: 26257
	[Token(Token = "0x2006691")]
	public class HandBookDesignerView : DataBinder<HandBookDesignerViewProperty>
	{
		// Token: 0x06025B76 RID: 154486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B76")]
		[Address(RVA = "0x20A4540", Offset = "0x20A3140", VA = "0x1820A4540")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025B77 RID: 154487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B77")]
		[Address(RVA = "0x20A4230", Offset = "0x20A2E30", VA = "0x1820A4230", Slot = "7")]
		public override void OnValueChanged(HandBookDesignerViewProperty property)
		{
		}

		// Token: 0x06025B78 RID: 154488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B78")]
		[Address(RVA = "0x20A44D0", Offset = "0x20A30D0", VA = "0x1820A44D0")]
		public void Show()
		{
		}

		// Token: 0x06025B79 RID: 154489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B79")]
		[Address(RVA = "0x20A41C0", Offset = "0x20A2DC0", VA = "0x1820A41C0")]
		public void Hide()
		{
		}

		// Token: 0x06025B7A RID: 154490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B7A")]
		[Address(RVA = "0x20A46F0", Offset = "0x20A32F0", VA = "0x1820A46F0")]
		public HandBookDesignerView()
		{
		}

		// Token: 0x04034FC2 RID: 217026
		[Token(Token = "0x4034FC2")]
		private const float FADE_DURATION = 0.23f;

		// Token: 0x04034FC3 RID: 217027
		[Token(Token = "0x4034FC3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _designerName;

		// Token: 0x04034FC4 RID: 217028
		[Token(Token = "0x4034FC4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _drawerName;

		// Token: 0x04034FC5 RID: 217029
		[Token(Token = "0x4034FC5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _panelCanvasGroup;

		// Token: 0x04034FC6 RID: 217030
		[Token(Token = "0x4034FC6")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x04034FC7 RID: 217031
		[Token(Token = "0x4034FC7")]
		[FieldOffset(Offset = "0x40")]
		private FadeSwitchTween m_tween;

		// Token: 0x04034FC8 RID: 217032
		[Token(Token = "0x4034FC8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04034FC9 RID: 217033
		[Token(Token = "0x4034FC9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04034FCA RID: 217034
		[Token(Token = "0x4034FCA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04034FCB RID: 217035
		[Token(Token = "0x4034FCB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x04034FCC RID: 217036
		[Token(Token = "0x4034FCC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
