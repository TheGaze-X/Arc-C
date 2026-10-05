using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act4fun
{
	// Token: 0x02007209 RID: 29193
	[Token(Token = "0x2007209")]
	[LuaCallCSharp(GenFlag.No)]
	public class Act4FunBattleFinishResponse : DefaultFinishBattleResponse
	{
		// Token: 0x06029645 RID: 169541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029645")]
		[Address(RVA = "0x10D1D40", Offset = "0x10D0940", VA = "0x1810D1D40")]
		public Act4FunBattleFinishResponse()
		{
		}

		// Token: 0x0403B1F9 RID: 242169
		[Token(Token = "0x403B1F9")]
		[FieldOffset(Offset = "0xA0")]
		public string liveId;

		// Token: 0x0403B1FA RID: 242170
		[Token(Token = "0x403B1FA")]
		[FieldOffset(Offset = "0xA8")]
		public List<Act4FunBattleMaterial> materials;
	}
}
