using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x0200018A RID: 394
	[Token(Token = "0x200018A")]
	internal class SDKLoginAccountHistoryState : SDKLoginPage.UIState
	{
		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x00003498 File Offset: 0x00001698
		[Token(Token = "0x170000DA")]
		public override SDKLoginPage.LoginState myState
		{
			[Token(Token = "0x600063F")]
			[Address(RVA = "0x1AD7580", Offset = "0x1AD6180", VA = "0x181AD7580", Slot = "13")]
			get
			{
				return SDKLoginPage.LoginState.DEFAULT_STATE;
			}
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x1AD6E40", Offset = "0x1AD5A40", VA = "0x181AD6E40", Slot = "17")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x1AD6F80", Offset = "0x1AD5B80", VA = "0x181AD6F80")]
		private void _RefreshAccountList()
		{
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000642")]
		[Address(RVA = "0x1AD6ED0", Offset = "0x1AD5AD0", VA = "0x181AD6ED0")]
		private void _HandleChangeAccount(int idx)
		{
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x1AD6D80", Offset = "0x1AD5980", VA = "0x181AD6D80")]
		public void EventOnDelCurCount()
		{
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x1AD7500", Offset = "0x1AD6100", VA = "0x181AD7500")]
		public SDKLoginAccountHistoryState()
		{
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x1AD6EC0", Offset = "0x1AD5AC0", VA = "0x181AD6EC0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x04000826 RID: 2086
		[Token(Token = "0x4000826")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Dropdown _list;

		// Token: 0x04000827 RID: 2087
		[Token(Token = "0x4000827")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_myState;

		// Token: 0x04000828 RID: 2088
		[Token(Token = "0x4000828")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04000829 RID: 2089
		[Token(Token = "0x4000829")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RefreshAccountList;

		// Token: 0x0400082A RID: 2090
		[Token(Token = "0x400082A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__HandleChangeAccount;

		// Token: 0x0400082B RID: 2091
		[Token(Token = "0x400082B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnDelCurCount;

		// Token: 0x0400082C RID: 2092
		[Token(Token = "0x400082C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
