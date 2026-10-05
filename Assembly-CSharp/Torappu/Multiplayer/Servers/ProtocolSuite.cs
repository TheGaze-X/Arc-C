using System;
using Il2CppDummyDll;
using Torappu.SocketNetwork.ServerBase;
using XLua;

namespace Torappu.Multiplayer.Servers
{
	// Token: 0x02001590 RID: 5520
	[Token(Token = "0x2001590")]
	public class ProtocolSuite : ServerProtocolSuite
	{
		// Token: 0x06007DBD RID: 32189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DBD")]
		[Address(RVA = "0x284AB60", Offset = "0x2849760", VA = "0x18284AB60", Slot = "7")]
		protected override void OnRegisterProtocol()
		{
		}

		// Token: 0x06007DBE RID: 32190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DBE")]
		[Address(RVA = "0x284AC10", Offset = "0x2849810", VA = "0x18284AC10")]
		public ProtocolSuite()
		{
		}

		// Token: 0x04007EDF RID: 32479
		[Token(Token = "0x4007EDF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRegisterProtocol;

		// Token: 0x04007EE0 RID: 32480
		[Token(Token = "0x4007EE0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
