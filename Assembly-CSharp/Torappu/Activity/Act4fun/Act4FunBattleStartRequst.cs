using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act4fun
{
	// Token: 0x02007205 RID: 29189
	[Token(Token = "0x2007205")]
	[LuaCallCSharp(GenFlag.No)]
	public class Act4FunBattleStartRequst
	{
		// Token: 0x0602963D RID: 169533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602963D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act4FunBattleStartRequst()
		{
		}

		// Token: 0x0403B1F4 RID: 242164
		[Token(Token = "0x403B1F4")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;
	}
}
