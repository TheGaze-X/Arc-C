using System;
using Il2CppDummyDll;

namespace Torappu.SocketNetwork.SvrCom
{
	// Token: 0x020014A7 RID: 5287
	[Token(Token = "0x20014A7")]
	public struct CommonJoinEntry
	{
		// Token: 0x04007827 RID: 30759
		[Token(Token = "0x4007827")]
		[FieldOffset(Offset = "0x0")]
		public string id;

		// Token: 0x04007828 RID: 30760
		[Token(Token = "0x4007828")]
		[FieldOffset(Offset = "0x8")]
		public string svrAddress;

		// Token: 0x04007829 RID: 30761
		[Token(Token = "0x4007829")]
		[FieldOffset(Offset = "0x10")]
		public string svrToken;

		// Token: 0x0400782A RID: 30762
		[Token(Token = "0x400782A")]
		[FieldOffset(Offset = "0x18")]
		public Action<bool> onJoinDone;
	}
}
