using System;
using Il2CppDummyDll;
using Torappu.SocketNetwork.ServerBase;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x0200643F RID: 25663
	[Token(Token = "0x200643F")]
	public class AutoChessProtocolSuit : ServerProtocolSuite
	{
		// Token: 0x06024EE0 RID: 151264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EE0")]
		[Address(RVA = "0x1FD6570", Offset = "0x1FD5170", VA = "0x181FD6570", Slot = "7")]
		protected override void OnRegisterProtocol()
		{
		}

		// Token: 0x06024EE1 RID: 151265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EE1")]
		[Address(RVA = "0x1FD6600", Offset = "0x1FD5200", VA = "0x181FD6600")]
		public AutoChessProtocolSuit()
		{
		}

		// Token: 0x04033A95 RID: 211605
		[Token(Token = "0x4033A95")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRegisterProtocol;

		// Token: 0x04033A96 RID: 211606
		[Token(Token = "0x4033A96")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
