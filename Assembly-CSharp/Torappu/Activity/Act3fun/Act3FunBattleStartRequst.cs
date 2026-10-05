using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act3fun
{
	// Token: 0x020073B9 RID: 29625
	[Token(Token = "0x20073B9")]
	[LuaCallCSharp(GenFlag.No)]
	public class Act3FunBattleStartRequst
	{
		// Token: 0x06029DBD RID: 171453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DBD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act3FunBattleStartRequst()
		{
		}

		// Token: 0x0403BFD7 RID: 245719
		[Token(Token = "0x403BFD7")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;
	}
}
