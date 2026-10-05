using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act7fun
{
	// Token: 0x02007192 RID: 29074
	[Token(Token = "0x2007192")]
	[LuaCallCSharp(GenFlag.No)]
	public class Act7FunBattleOutMeta : IHotfixable
	{
		// Token: 0x06029434 RID: 169012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029434")]
		[Address(RVA = "0x2491A40", Offset = "0x2490640", VA = "0x182491A40")]
		public Act7FunBattleOutMeta()
		{
		}

		// Token: 0x0403AEE6 RID: 241382
		[Token(Token = "0x403AEE6")]
		[FieldOffset(Offset = "0x10")]
		public int trapCnt;

		// Token: 0x0403AEE7 RID: 241383
		[Token(Token = "0x403AEE7")]
		[FieldOffset(Offset = "0x14")]
		public int cardUsedCnt;

		// Token: 0x0403AEE8 RID: 241384
		[Token(Token = "0x403AEE8")]
		[FieldOffset(Offset = "0x18")]
		public int defeatedCnt;

		// Token: 0x0403AEE9 RID: 241385
		[Token(Token = "0x403AEE9")]
		[FieldOffset(Offset = "0x20")]
		public List<string> easterEggIds;

		// Token: 0x0403AEEA RID: 241386
		[Token(Token = "0x403AEEA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
