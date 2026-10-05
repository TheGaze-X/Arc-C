using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace HGSDK.V2
{
	// Token: 0x02000178 RID: 376
	[Token(Token = "0x2000178")]
	public class HGSDKV2GameLicenseDialog : UICustomDialog<int>
	{
		// Token: 0x060005DB RID: 1499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x1AD0AB0", Offset = "0x1ACF6B0", VA = "0x181AD0AB0", Slot = "7")]
		protected override void OnRender(int _)
		{
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x1AD0C80", Offset = "0x1ACF880", VA = "0x181AD0C80")]
		private void _CloseSelf()
		{
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x1AD09B0", Offset = "0x1ACF5B0", VA = "0x181AD09B0")]
		public void EventOnCloseClicked()
		{
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x1AD0CF0", Offset = "0x1ACF8F0", VA = "0x181AD0CF0")]
		public HGSDKV2GameLicenseDialog()
		{
		}

		// Token: 0x04000792 RID: 1938
		[Token(Token = "0x4000792")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIUniWebView _webview;

		// Token: 0x04000793 RID: 1939
		[Token(Token = "0x4000793")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04000794 RID: 1940
		[Token(Token = "0x4000794")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CloseSelf;

		// Token: 0x04000795 RID: 1941
		[Token(Token = "0x4000795")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnCloseClicked;

		// Token: 0x04000796 RID: 1942
		[Token(Token = "0x4000796")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
