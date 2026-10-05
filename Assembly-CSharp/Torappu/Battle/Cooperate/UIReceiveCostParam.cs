using System;
using Il2CppDummyDll;

namespace Torappu.Battle.Cooperate
{
	// Token: 0x020026DB RID: 9947
	[Token(Token = "0x20026DB")]
	public struct UIReceiveCostParam
	{
		// Token: 0x04012162 RID: 74082
		[Token(Token = "0x4012162")]
		[FieldOffset(Offset = "0x0")]
		public PlayerSide side;

		// Token: 0x04012163 RID: 74083
		[Token(Token = "0x4012163")]
		[FieldOffset(Offset = "0x4")]
		public int cost;

		// Token: 0x04012164 RID: 74084
		[Token(Token = "0x4012164")]
		[FieldOffset(Offset = "0x8")]
		public int type;
	}
}
