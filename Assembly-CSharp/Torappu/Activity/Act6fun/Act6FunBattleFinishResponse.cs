using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act6fun
{
	// Token: 0x020071B0 RID: 29104
	[Token(Token = "0x20071B0")]
	[LuaCallCSharp(GenFlag.No)]
	public class Act6FunBattleFinishResponse : DefaultFinishBattleResponse
	{
		// Token: 0x060294D0 RID: 169168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294D0")]
		[Address(RVA = "0x10D1D40", Offset = "0x10D0940", VA = "0x1810D1D40")]
		public Act6FunBattleFinishResponse()
		{
		}

		// Token: 0x0403AF9E RID: 241566
		[Token(Token = "0x403AF9E")]
		[FieldOffset(Offset = "0xA0")]
		public int completeState;

		// Token: 0x0403AF9F RID: 241567
		[Token(Token = "0x403AF9F")]
		[FieldOffset(Offset = "0xA8")]
		public long passSec;

		// Token: 0x0403AFA0 RID: 241568
		[Token(Token = "0x403AFA0")]
		[FieldOffset(Offset = "0xB0")]
		public bool newRecord;

		// Token: 0x0403AFA1 RID: 241569
		[Token(Token = "0x403AFA1")]
		[FieldOffset(Offset = "0xB4")]
		public int coin;
	}
}
