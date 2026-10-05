using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Login
{
	// Token: 0x020049D2 RID: 18898
	[Token(Token = "0x20049D2")]
	public class LoginNamingState : State
	{
		// Token: 0x0601C756 RID: 116566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C756")]
		[Address(RVA = "0x15E03D0", Offset = "0x15DEFD0", VA = "0x1815E03D0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601C757 RID: 116567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C757")]
		[Address(RVA = "0x15E0590", Offset = "0x15DF190", VA = "0x1815E0590", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601C758 RID: 116568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C758")]
		[Address(RVA = "0x15E0620", Offset = "0x15DF220", VA = "0x1815E0620")]
		private void _DoInGameLicenseLogics()
		{
		}

		// Token: 0x0601C759 RID: 116569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C759")]
		[Address(RVA = "0x15E0430", Offset = "0x15DF030", VA = "0x1815E0430")]
		public void OnConfirmClicked()
		{
		}

		// Token: 0x0601C75A RID: 116570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C75A")]
		[Address(RVA = "0x15E01E0", Offset = "0x15DEDE0", VA = "0x1815E01E0")]
		private void Awake()
		{
		}

		// Token: 0x0601C75B RID: 116571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C75B")]
		[Address(RVA = "0x15E09A0", Offset = "0x15DF5A0", VA = "0x1815E09A0")]
		public LoginNamingState()
		{
		}

		// Token: 0x0601C75D RID: 116573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C75D")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402549F RID: 152735
		[Token(Token = "0x402549F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InputField _playerNameInput;

		// Token: 0x040254A0 RID: 152736
		[Token(Token = "0x40254A0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private LoginServiceLicenseView _licenseView;

		// Token: 0x040254A1 RID: 152737
		[Token(Token = "0x40254A1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _confirmButtonText;

		// Token: 0x040254A2 RID: 152738
		[Token(Token = "0x40254A2")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isAgreementPassed;

		// Token: 0x040254A3 RID: 152739
		[Token(Token = "0x40254A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040254A4 RID: 152740
		[Token(Token = "0x40254A4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040254A5 RID: 152741
		[Token(Token = "0x40254A5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__DoInGameLicenseLogics;

		// Token: 0x040254A6 RID: 152742
		[Token(Token = "0x40254A6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnConfirmClicked;

		// Token: 0x040254A7 RID: 152743
		[Token(Token = "0x40254A7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x040254A8 RID: 152744
		[Token(Token = "0x40254A8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
