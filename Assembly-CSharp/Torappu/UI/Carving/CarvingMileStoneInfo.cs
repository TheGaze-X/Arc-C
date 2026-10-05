using System;
using Il2CppDummyDll;

namespace Torappu.UI.Carving
{
	// Token: 0x020060C2 RID: 24770
	[Token(Token = "0x20060C2")]
	public struct CarvingMileStoneInfo
	{
		// Token: 0x04031A74 RID: 203380
		[Token(Token = "0x4031A74")]
		[FieldOffset(Offset = "0x0")]
		public int currLevel;

		// Token: 0x04031A75 RID: 203381
		[Token(Token = "0x4031A75")]
		[FieldOffset(Offset = "0x4")]
		public int currLevelNeedPoint;

		// Token: 0x04031A76 RID: 203382
		[Token(Token = "0x4031A76")]
		[FieldOffset(Offset = "0x8")]
		public int nextLevelNeedPoint;

		// Token: 0x04031A77 RID: 203383
		[Token(Token = "0x4031A77")]
		[FieldOffset(Offset = "0xC")]
		public int currPointInCurrLevel;

		// Token: 0x04031A78 RID: 203384
		[Token(Token = "0x4031A78")]
		[FieldOffset(Offset = "0x10")]
		public int totalPointInCurrLevel;

		// Token: 0x04031A79 RID: 203385
		[Token(Token = "0x4031A79")]
		[FieldOffset(Offset = "0x14")]
		public bool isMax;
	}
}
