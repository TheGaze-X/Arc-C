using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act3fun
{
	// Token: 0x020073BD RID: 29629
	[Token(Token = "0x20073BD")]
	[LuaCallCSharp(GenFlag.No)]
	public class Act3FunBattleFinishResponse : DefaultFinishBattleResponse
	{
		// Token: 0x06029DC5 RID: 171461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DC5")]
		[Address(RVA = "0x10D1D40", Offset = "0x10D0940", VA = "0x1810D1D40")]
		public Act3FunBattleFinishResponse()
		{
		}

		// Token: 0x0403BFDC RID: 245724
		[Token(Token = "0x403BFDC")]
		[FieldOffset(Offset = "0xA0")]
		public int score;

		// Token: 0x0403BFDD RID: 245725
		[Token(Token = "0x403BFDD")]
		[FieldOffset(Offset = "0xA4")]
		public bool inRank;

		// Token: 0x0403BFDE RID: 245726
		[Token(Token = "0x403BFDE")]
		[FieldOffset(Offset = "0xA8")]
		public int[] scoreItem;

		// Token: 0x0403BFDF RID: 245727
		[Token(Token = "0x403BFDF")]
		[FieldOffset(Offset = "0xB0")]
		public int[] rank;
	}
}
