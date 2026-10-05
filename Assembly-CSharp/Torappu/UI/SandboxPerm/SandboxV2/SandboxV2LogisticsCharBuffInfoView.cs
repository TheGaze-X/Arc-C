using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200433C RID: 17212
	[Token(Token = "0x200433C")]
	public class SandboxV2LogisticsCharBuffInfoView : DataBinder<SandboxV2LogisticsHomeProperty>
	{
		// Token: 0x0601A708 RID: 108296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A708")]
		[Address(RVA = "0x1386670", Offset = "0x1385270", VA = "0x181386670", Slot = "7")]
		public override void OnValueChanged(SandboxV2LogisticsHomeProperty property)
		{
		}

		// Token: 0x0601A709 RID: 108297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A709")]
		[Address(RVA = "0x1386960", Offset = "0x1385560", VA = "0x181386960")]
		private void _InitIfNot(bool isShow)
		{
		}

		// Token: 0x0601A70A RID: 108298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A70A")]
		[Address(RVA = "0x1386A60", Offset = "0x1385660", VA = "0x181386A60")]
		public SandboxV2LogisticsCharBuffInfoView()
		{
		}

		// Token: 0x04021990 RID: 137616
		[Token(Token = "0x4021990")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCharName;

		// Token: 0x04021991 RID: 137617
		[Token(Token = "0x4021991")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelTagValid;

		// Token: 0x04021992 RID: 137618
		[Token(Token = "0x4021992")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelTagInvalid;

		// Token: 0x04021993 RID: 137619
		[Token(Token = "0x4021993")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SandboxV2LogisticsCharBeanView _charBeanView;

		// Token: 0x04021994 RID: 137620
		[Token(Token = "0x4021994")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SandboxV2LogisticsComplexBuffItemView _buffItemView;

		// Token: 0x04021995 RID: 137621
		[Token(Token = "0x4021995")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04021996 RID: 137622
		[Token(Token = "0x4021996")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x04021997 RID: 137623
		[Token(Token = "0x4021997")]
		[FieldOffset(Offset = "0x58")]
		private FadeSwitchTween m_fadeSwitchTween;

		// Token: 0x04021998 RID: 137624
		[Token(Token = "0x4021998")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04021999 RID: 137625
		[Token(Token = "0x4021999")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402199A RID: 137626
		[Token(Token = "0x402199A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
