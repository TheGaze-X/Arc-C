using System;
using Il2CppDummyDll;

namespace Torappu.Multiplayer.Servers
{
	// Token: 0x020015C6 RID: 5574
	[Token(Token = "0x20015C6")]
	public struct BattleEntry
	{
		// Token: 0x04007FFC RID: 32764
		[Token(Token = "0x4007FFC")]
		[FieldOffset(Offset = "0x0")]
		public string sceneID;

		// Token: 0x04007FFD RID: 32765
		[Token(Token = "0x4007FFD")]
		[FieldOffset(Offset = "0x8")]
		public string svrAddress;

		// Token: 0x04007FFE RID: 32766
		[Token(Token = "0x4007FFE")]
		[FieldOffset(Offset = "0x10")]
		public string token;
	}
}
