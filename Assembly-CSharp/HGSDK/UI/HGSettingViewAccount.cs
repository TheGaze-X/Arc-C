using System;
using Il2CppDummyDll;
using Torappu;
using Torappu.SDK;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x020001C7 RID: 455
	[Token(Token = "0x20001C7")]
	public class HGSettingViewAccount : MonoBehaviour, IHotfixable
	{
		// Token: 0x060007CA RID: 1994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x1AD2240", Offset = "0x1AD0E40", VA = "0x181AD2240")]
		public void Render(HGSDK hgSDK)
		{
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x1AD1CE0", Offset = "0x1AD08E0", VA = "0x181AD1CE0")]
		public void EventChangePhone()
		{
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x1AD1D60", Offset = "0x1AD0960", VA = "0x181AD1D60")]
		public void EventChangePwd()
		{
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x1AD2120", Offset = "0x1AD0D20", VA = "0x181AD2120")]
		public void EventShowAgreement()
		{
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x1AD1DE0", Offset = "0x1AD09E0", VA = "0x181AD1DE0")]
		public void EventLogout()
		{
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x1AD2050", Offset = "0x1AD0C50", VA = "0x181AD2050")]
		public void EventOnUnbindGrant()
		{
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x1AD27A0", Offset = "0x1AD13A0", VA = "0x181AD27A0")]
		private void _OnNativeUnbindGrantRet(SDKExtraInfoHandler.UnbindGrantMessage msg)
		{
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x1AD21A0", Offset = "0x1AD0DA0", VA = "0x181AD21A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x1AD2850", Offset = "0x1AD1450", VA = "0x181AD2850")]
		private void _UpdateAccountPanel()
		{
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x1AD2540", Offset = "0x1AD1140", VA = "0x181AD2540")]
		private void _InvokeNativeUnbindGrant()
		{
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00003CF0 File Offset: 0x00001EF0
		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x1AD2480", Offset = "0x1AD1080", VA = "0x181AD2480")]
		private static bool _CheckIfShowAccount()
		{
			return default(bool);
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x1AD29F0", Offset = "0x1AD15F0", VA = "0x181AD29F0")]
		public HGSettingViewAccount()
		{
		}

		// Token: 0x04000A11 RID: 2577
		[Token(Token = "0x4000A11")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _accountPanel;

		// Token: 0x04000A12 RID: 2578
		[Token(Token = "0x4000A12")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] _subAccountPanels;

		// Token: 0x04000A13 RID: 2579
		[Token(Token = "0x4000A13")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _unbindPanel;

		// Token: 0x04000A14 RID: 2580
		[Token(Token = "0x4000A14")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _agreementText;

		// Token: 0x04000A15 RID: 2581
		[Token(Token = "0x4000A15")]
		[FieldOffset(Offset = "0x38")]
		private HGSDK m_sdk;

		// Token: 0x04000A16 RID: 2582
		[Token(Token = "0x4000A16")]
		[FieldOffset(Offset = "0x40")]
		private bool m_listenToNativeUnbindGrant;

		// Token: 0x04000A17 RID: 2583
		[Token(Token = "0x4000A17")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04000A18 RID: 2584
		[Token(Token = "0x4000A18")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventChangePhone;

		// Token: 0x04000A19 RID: 2585
		[Token(Token = "0x4000A19")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventChangePwd;

		// Token: 0x04000A1A RID: 2586
		[Token(Token = "0x4000A1A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventShowAgreement;

		// Token: 0x04000A1B RID: 2587
		[Token(Token = "0x4000A1B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventLogout;

		// Token: 0x04000A1C RID: 2588
		[Token(Token = "0x4000A1C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnUnbindGrant;

		// Token: 0x04000A1D RID: 2589
		[Token(Token = "0x4000A1D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnNativeUnbindGrantRet;

		// Token: 0x04000A1E RID: 2590
		[Token(Token = "0x4000A1E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04000A1F RID: 2591
		[Token(Token = "0x4000A1F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateAccountPanel;

		// Token: 0x04000A20 RID: 2592
		[Token(Token = "0x4000A20")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InvokeNativeUnbindGrant;

		// Token: 0x04000A21 RID: 2593
		[Token(Token = "0x4000A21")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CheckIfShowAccount;

		// Token: 0x04000A22 RID: 2594
		[Token(Token = "0x4000A22")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
