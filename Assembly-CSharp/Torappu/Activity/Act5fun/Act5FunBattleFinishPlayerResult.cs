using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act5fun
{
	// Token: 0x020071D4 RID: 29140
	[Token(Token = "0x20071D4")]
	[LuaCallCSharp(GenFlag.No)]
	public class Act5FunBattleFinishPlayerResult
	{
		// Token: 0x0602957D RID: 169341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602957D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act5FunBattleFinishPlayerResult()
		{
		}

		// Token: 0x0403B0B8 RID: 241848
		[Token(Token = "0x403B0B8")]
		[FieldOffset(Offset = "0x10")]
		public int totalWin;

		// Token: 0x0403B0B9 RID: 241849
		[Token(Token = "0x403B0B9")]
		[FieldOffset(Offset = "0x14")]
		public int streak;

		// Token: 0x0403B0BA RID: 241850
		[Token(Token = "0x403B0BA")]
		[FieldOffset(Offset = "0x18")]
		public int totalRound;
	}
}
