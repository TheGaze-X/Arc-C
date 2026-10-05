using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act7fun
{
	// Token: 0x02007194 RID: 29076
	[Token(Token = "0x2007194")]
	[LuaCallCSharp(GenFlag.No)]
	public class Act7FunBattleStartRequst
	{
		// Token: 0x06029436 RID: 169014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029436")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act7FunBattleStartRequst()
		{
		}

		// Token: 0x0403AEED RID: 241389
		[Token(Token = "0x403AEED")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;
	}
}
