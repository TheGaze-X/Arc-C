using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Login
{
	// Token: 0x020049CD RID: 18893
	[Token(Token = "0x20049CD")]
	public class LoginLicenseState : State
	{
		// Token: 0x0601C73B RID: 116539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C73B")]
		[Address(RVA = "0x15DF8F0", Offset = "0x15DE4F0", VA = "0x1815DF8F0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601C73C RID: 116540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C73C")]
		[Address(RVA = "0x15DF950", Offset = "0x15DE550", VA = "0x1815DF950", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601C73D RID: 116541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C73D")]
		[Address(RVA = "0x15DFC00", Offset = "0x15DE800", VA = "0x1815DFC00")]
		private void _OnAgreeClicked()
		{
		}

		// Token: 0x0601C73E RID: 116542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C73E")]
		[Address(RVA = "0x15DFC90", Offset = "0x15DE890", VA = "0x1815DFC90")]
		public LoginLicenseState()
		{
		}

		// Token: 0x0601C73F RID: 116543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C73F")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04025482 RID: 152706
		[Token(Token = "0x4025482")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private LoginServiceLicenseView _licenseView;

		// Token: 0x04025483 RID: 152707
		[Token(Token = "0x4025483")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04025484 RID: 152708
		[Token(Token = "0x4025484")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04025485 RID: 152709
		[Token(Token = "0x4025485")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnAgreeClicked;

		// Token: 0x04025486 RID: 152710
		[Token(Token = "0x4025486")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
