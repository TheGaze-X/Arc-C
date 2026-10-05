using System;
using Il2CppDummyDll;
using Torappu.SocketNetwork.ServerBase;
using XLua;

namespace Torappu.UI.EnemyDuel.Service.Mode.Multi
{
	// Token: 0x020050BB RID: 20667
	[Token(Token = "0x20050BB")]
	public class EnemyDuelProtocolSuit : ServerProtocolSuite
	{
		// Token: 0x0601E964 RID: 125284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E964")]
		[Address(RVA = "0x183F690", Offset = "0x183E290", VA = "0x18183F690", Slot = "7")]
		protected override void OnRegisterProtocol()
		{
		}

		// Token: 0x0601E965 RID: 125285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E965")]
		[Address(RVA = "0x183F700", Offset = "0x183E300", VA = "0x18183F700")]
		public EnemyDuelProtocolSuit()
		{
		}

		// Token: 0x04028FA4 RID: 167844
		[Token(Token = "0x4028FA4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRegisterProtocol;

		// Token: 0x04028FA5 RID: 167845
		[Token(Token = "0x4028FA5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
