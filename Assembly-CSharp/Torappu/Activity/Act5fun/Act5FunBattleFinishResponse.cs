using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act5fun
{
	// Token: 0x020071D5 RID: 29141
	[Token(Token = "0x20071D5")]
	[LuaCallCSharp(GenFlag.No)]
	public class Act5FunBattleFinishResponse : DefaultFinishBattleResponse
	{
		// Token: 0x0602957E RID: 169342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602957E")]
		[Address(RVA = "0x10D1D40", Offset = "0x10D0940", VA = "0x1810D1D40")]
		public Act5FunBattleFinishResponse()
		{
		}

		// Token: 0x0403B0BB RID: 241851
		[Token(Token = "0x403B0BB")]
		[FieldOffset(Offset = "0xA0")]
		public new int result;

		// Token: 0x0403B0BC RID: 241852
		[Token(Token = "0x403B0BC")]
		[FieldOffset(Offset = "0xA4")]
		public int score;

		// Token: 0x0403B0BD RID: 241853
		[Token(Token = "0x403B0BD")]
		[FieldOffset(Offset = "0xA8")]
		public bool isHighScore;

		// Token: 0x0403B0BE RID: 241854
		[Token(Token = "0x403B0BE")]
		[FieldOffset(Offset = "0xB0")]
		public Dictionary<string, int> npcResult;

		// Token: 0x0403B0BF RID: 241855
		[Token(Token = "0x403B0BF")]
		[FieldOffset(Offset = "0xB8")]
		public Act5FunBattleFinishPlayerResult playerResult;

		// Token: 0x0403B0C0 RID: 241856
		[Token(Token = "0x403B0C0")]
		[FieldOffset(Offset = "0xC0")]
		public List<CommonFinishBattleResponse.RewardModel> reward;
	}
}
