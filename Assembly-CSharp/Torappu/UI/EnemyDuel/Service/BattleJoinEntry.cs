using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x02005067 RID: 20583
	[Token(Token = "0x2005067")]
	public struct BattleJoinEntry
	{
		// Token: 0x04028DDE RID: 167390
		[Token(Token = "0x4028DDE")]
		[FieldOffset(Offset = "0x0")]
		public string sceneID;

		// Token: 0x04028DDF RID: 167391
		[Token(Token = "0x4028DDF")]
		[FieldOffset(Offset = "0x8")]
		public string svrAddress;

		// Token: 0x04028DE0 RID: 167392
		[Token(Token = "0x4028DE0")]
		[FieldOffset(Offset = "0x10")]
		public string token;
	}
}
