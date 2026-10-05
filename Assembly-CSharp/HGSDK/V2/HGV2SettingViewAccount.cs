using System;
using Il2CppDummyDll;
using Torappu;
using Torappu.SDK;
using UnityEngine;
using XLua;

namespace HGSDK.V2
{
	// Token: 0x0200017D RID: 381
	[Token(Token = "0x200017D")]
	public class HGV2SettingViewAccount : MonoBehaviour, IHotfixable
	{
		// Token: 0x060005F3 RID: 1523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x1AD2DE0", Offset = "0x1AD19E0", VA = "0x181AD2DE0")]
		public void Render(HGSDKV2 hgSDK)
		{
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x1AD2A50", Offset = "0x1AD1650", VA = "0x181AD2A50")]
		public void EventLogout()
		{
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x1AD2CC0", Offset = "0x1AD18C0", VA = "0x181AD2CC0")]
		public void EventShowAgreement()
		{
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x1AD2C40", Offset = "0x1AD1840", VA = "0x181AD2C40")]
		public void EventOnUnbindGrant()
		{
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x1AD3100", Offset = "0x1AD1D00", VA = "0x181AD3100")]
		private void _OnNativeUnbindGrantRet(SDKExtraInfoHandler.UnbindGrantMessage msg)
		{
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x1AD2D40", Offset = "0x1AD1940", VA = "0x181AD2D40")]
		private void OnDestroy()
		{
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x1AD2EC0", Offset = "0x1AD1AC0", VA = "0x181AD2EC0")]
		private void _InvokeNativeUnbindGrant()
		{
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x1AD2E60", Offset = "0x1AD1A60", VA = "0x181AD2E60")]
		private void _DoLogout()
		{
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x1AD31C0", Offset = "0x1AD1DC0", VA = "0x181AD31C0")]
		public HGV2SettingViewAccount()
		{
		}

		// Token: 0x040007B7 RID: 1975
		[Token(Token = "0x40007B7")]
		[FieldOffset(Offset = "0x18")]
		private HGSDKV2 m_sdk;

		// Token: 0x040007B8 RID: 1976
		[Token(Token = "0x40007B8")]
		[FieldOffset(Offset = "0x20")]
		private bool m_listenToNativeUnbindGrant;

		// Token: 0x040007B9 RID: 1977
		[Token(Token = "0x40007B9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040007BA RID: 1978
		[Token(Token = "0x40007BA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventLogout;

		// Token: 0x040007BB RID: 1979
		[Token(Token = "0x40007BB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventShowAgreement;

		// Token: 0x040007BC RID: 1980
		[Token(Token = "0x40007BC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnUnbindGrant;

		// Token: 0x040007BD RID: 1981
		[Token(Token = "0x40007BD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnNativeUnbindGrantRet;

		// Token: 0x040007BE RID: 1982
		[Token(Token = "0x40007BE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040007BF RID: 1983
		[Token(Token = "0x40007BF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InvokeNativeUnbindGrant;

		// Token: 0x040007C0 RID: 1984
		[Token(Token = "0x40007C0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__DoLogout;

		// Token: 0x040007C1 RID: 1985
		[Token(Token = "0x40007C1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
