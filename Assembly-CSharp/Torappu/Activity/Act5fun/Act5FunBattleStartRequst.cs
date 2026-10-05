using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act5fun
{
	// Token: 0x020071D0 RID: 29136
	[Token(Token = "0x20071D0")]
	[LuaCallCSharp(GenFlag.No)]
	public class Act5FunBattleStartRequst
	{
		// Token: 0x06029575 RID: 169333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029575")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act5FunBattleStartRequst()
		{
		}

		// Token: 0x0403B0B3 RID: 241843
		[Token(Token = "0x403B0B3")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;
	}
}
