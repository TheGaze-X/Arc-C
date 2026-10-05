using System;
using System.Collections;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Login
{
	// Token: 0x020049CB RID: 18891
	[Token(Token = "0x20049CB")]
	public class LoginInitState : State
	{
		// Token: 0x0601C72E RID: 116526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C72E")]
		[Address(RVA = "0x15DF410", Offset = "0x15DE010", VA = "0x1815DF410", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601C72F RID: 116527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C72F")]
		[Address(RVA = "0x15DF470", Offset = "0x15DE070", VA = "0x1815DF470", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601C730 RID: 116528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C730")]
		[Address(RVA = "0x15DF690", Offset = "0x15DE290", VA = "0x1815DF690")]
		private void _JustAfterResumed()
		{
		}

		// Token: 0x0601C731 RID: 116529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C731")]
		[Address(RVA = "0x15DF600", Offset = "0x15DE200", VA = "0x1815DF600")]
		private IEnumerator _DoSDKLoginCoroutine()
		{
			return null;
		}

		// Token: 0x0601C732 RID: 116530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C732")]
		[Address(RVA = "0x15DF890", Offset = "0x15DE490", VA = "0x1815DF890")]
		public LoginInitState()
		{
		}

		// Token: 0x0601C734 RID: 116532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C734")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0402547B RID: 152699
		[Token(Token = "0x402547B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402547C RID: 152700
		[Token(Token = "0x402547C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402547D RID: 152701
		[Token(Token = "0x402547D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__JustAfterResumed;

		// Token: 0x0402547E RID: 152702
		[Token(Token = "0x402547E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DoSDKLoginCoroutine;

		// Token: 0x0402547F RID: 152703
		[Token(Token = "0x402547F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
