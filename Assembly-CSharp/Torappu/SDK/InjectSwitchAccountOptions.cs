using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.SDK
{
	// Token: 0x020014F5 RID: 5365
	[Token(Token = "0x20014F5")]
	public struct InjectSwitchAccountOptions
	{
		// Token: 0x040079ED RID: 31213
		[Token(Token = "0x40079ED")]
		[FieldOffset(Offset = "0x0")]
		public Transform panelSwitchAccount;

		// Token: 0x040079EE RID: 31214
		[Token(Token = "0x40079EE")]
		[FieldOffset(Offset = "0x8")]
		public Action onSwitchAccount;

		// Token: 0x040079EF RID: 31215
		[Token(Token = "0x40079EF")]
		[FieldOffset(Offset = "0x10")]
		public Action onLogin;
	}
}
