using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Login
{
	// Token: 0x020049DE RID: 18910
	[Token(Token = "0x20049DE")]
	public class LoginServiceLicenseView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C788 RID: 116616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C788")]
		[Address(RVA = "0x15E2C60", Offset = "0x15E1860", VA = "0x1815E2C60")]
		public void Show(Action onAgreed)
		{
		}

		// Token: 0x0601C789 RID: 116617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C789")]
		[Address(RVA = "0x15E2BC0", Offset = "0x15E17C0", VA = "0x1815E2BC0")]
		public void Hide()
		{
		}

		// Token: 0x0601C78A RID: 116618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C78A")]
		[Address(RVA = "0x15E2A00", Offset = "0x15E1600", VA = "0x1815E2A00")]
		public void EventOnLicenseToggleClicked()
		{
		}

		// Token: 0x0601C78B RID: 116619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C78B")]
		[Address(RVA = "0x15E2A70", Offset = "0x15E1670", VA = "0x1815E2A70")]
		public void EventOnNextBtnClicked()
		{
		}

		// Token: 0x0601C78C RID: 116620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C78C")]
		[Address(RVA = "0x15E2DF0", Offset = "0x15E19F0", VA = "0x1815E2DF0")]
		private void _SetToggle(bool isActive)
		{
		}

		// Token: 0x0601C78D RID: 116621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C78D")]
		[Address(RVA = "0x15E2D70", Offset = "0x15E1970", VA = "0x1815E2D70")]
		private void _OnAgreed()
		{
		}

		// Token: 0x0601C78E RID: 116622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C78E")]
		[Address(RVA = "0x15E2E90", Offset = "0x15E1A90", VA = "0x1815E2E90")]
		public LoginServiceLicenseView()
		{
		}

		// Token: 0x040254DD RID: 152797
		[Token(Token = "0x40254DD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _content;

		// Token: 0x040254DE RID: 152798
		[Token(Token = "0x40254DE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _licenseToggle;

		// Token: 0x040254DF RID: 152799
		[Token(Token = "0x40254DF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _btnToggle;

		// Token: 0x040254E0 RID: 152800
		[Token(Token = "0x40254E0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIUniWebView _webView;

		// Token: 0x040254E1 RID: 152801
		[Token(Token = "0x40254E1")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isAgreed;

		// Token: 0x040254E2 RID: 152802
		[Token(Token = "0x40254E2")]
		[FieldOffset(Offset = "0x40")]
		private Action m_onAgreed;

		// Token: 0x040254E3 RID: 152803
		[Token(Token = "0x40254E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x040254E4 RID: 152804
		[Token(Token = "0x40254E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x040254E5 RID: 152805
		[Token(Token = "0x40254E5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnLicenseToggleClicked;

		// Token: 0x040254E6 RID: 152806
		[Token(Token = "0x40254E6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnNextBtnClicked;

		// Token: 0x040254E7 RID: 152807
		[Token(Token = "0x40254E7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetToggle;

		// Token: 0x040254E8 RID: 152808
		[Token(Token = "0x40254E8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnAgreed;

		// Token: 0x040254E9 RID: 152809
		[Token(Token = "0x40254E9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
