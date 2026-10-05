using System;
using Il2CppDummyDll;
using Torappu;
using Torappu.SDK;
using UnityEngine;
using XLua;

namespace XDSDK
{
	// Token: 0x020000E4 RID: 228
	[Token(Token = "0x20000E4")]
	public class XDLoginSwitchAccountPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x060003AE RID: 942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x1040210", Offset = "0x103EE10", VA = "0x181040210")]
		public void Init(InjectSwitchAccountOptions options)
		{
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x1040110", Offset = "0x103ED10", VA = "0x181040110")]
		public void EventOnLoginClicked()
		{
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x1040190", Offset = "0x103ED90", VA = "0x181040190")]
		public void EventOnSwitchAccountClicked()
		{
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x10402C0", Offset = "0x103EEC0", VA = "0x1810402C0")]
		public XDLoginSwitchAccountPlugin()
		{
		}

		// Token: 0x04000488 RID: 1160
		[Token(Token = "0x4000488")]
		[FieldOffset(Offset = "0x18")]
		private Action m_onLogin;

		// Token: 0x04000489 RID: 1161
		[Token(Token = "0x4000489")]
		[FieldOffset(Offset = "0x20")]
		private Action m_onSwitchAccount;

		// Token: 0x0400048A RID: 1162
		[Token(Token = "0x400048A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400048B RID: 1163
		[Token(Token = "0x400048B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnLoginClicked;

		// Token: 0x0400048C RID: 1164
		[Token(Token = "0x400048C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnSwitchAccountClicked;

		// Token: 0x0400048D RID: 1165
		[Token(Token = "0x400048D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
