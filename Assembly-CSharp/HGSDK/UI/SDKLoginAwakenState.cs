using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x0200018F RID: 399
	[Token(Token = "0x200018F")]
	public class SDKLoginAwakenState : SDKLoginPage.UIState
	{
		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x000034E0 File Offset: 0x000016E0
		[Token(Token = "0x170000DD")]
		public override SDKLoginPage.LoginState myState
		{
			[Token(Token = "0x6000657")]
			[Address(RVA = "0x1AD8B60", Offset = "0x1AD7760", VA = "0x181AD8B60", Slot = "13")]
			get
			{
				return SDKLoginPage.LoginState.DEFAULT_STATE;
			}
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000658")]
		[Address(RVA = "0x1AD84B0", Offset = "0x1AD70B0", VA = "0x181AD84B0", Slot = "17")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x1AD8100", Offset = "0x1AD6D00", VA = "0x181AD8100")]
		public void EventOnAwakenClicked()
		{
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x1AD8450", Offset = "0x1AD7050", VA = "0x181AD8450")]
		public void EventOnGuestUpgradeClicked()
		{
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x1AD8950", Offset = "0x1AD7550", VA = "0x181AD8950")]
		private string _TryHidePhoneNumber(string accountName)
		{
			return null;
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x000034F8 File Offset: 0x000016F8
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x1AD8850", Offset = "0x1AD7450", VA = "0x181AD8850")]
		private bool _BlockGuestLogin()
		{
			return default(bool);
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x1AD8AE0", Offset = "0x1AD76E0", VA = "0x181AD8AE0")]
		public SDKLoginAwakenState()
		{
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x1AD6EC0", Offset = "0x1AD5AC0", VA = "0x181AD6EC0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x0400083F RID: 2111
		[Token(Token = "0x400083F")]
		private const int HIDDED_PHONE_NUMBER_STAR_NUM = 4;

		// Token: 0x04000840 RID: 2112
		[Token(Token = "0x4000840")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _userTitle;

		// Token: 0x04000841 RID: 2113
		[Token(Token = "0x4000841")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _userAccount;

		// Token: 0x04000842 RID: 2114
		[Token(Token = "0x4000842")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _userPanel;

		// Token: 0x04000843 RID: 2115
		[Token(Token = "0x4000843")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _guestPanel;

		// Token: 0x04000844 RID: 2116
		[Token(Token = "0x4000844")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isGuest;

		// Token: 0x04000845 RID: 2117
		[Token(Token = "0x4000845")]
		[FieldOffset(Offset = "0x80")]
		private string m_token;

		// Token: 0x04000846 RID: 2118
		[Token(Token = "0x4000846")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_myState;

		// Token: 0x04000847 RID: 2119
		[Token(Token = "0x4000847")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04000848 RID: 2120
		[Token(Token = "0x4000848")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnAwakenClicked;

		// Token: 0x04000849 RID: 2121
		[Token(Token = "0x4000849")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnGuestUpgradeClicked;

		// Token: 0x0400084A RID: 2122
		[Token(Token = "0x400084A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryHidePhoneNumber;

		// Token: 0x0400084B RID: 2123
		[Token(Token = "0x400084B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__BlockGuestLogin;

		// Token: 0x0400084C RID: 2124
		[Token(Token = "0x400084C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
