using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act3fun
{
	// Token: 0x020073B8 RID: 29624
	[Token(Token = "0x20073B8")]
	[LuaCallCSharp(GenFlag.No)]
	public class Act3FunService : IHotfixable
	{
		// Token: 0x06029DBC RID: 171452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DBC")]
		[Address(RVA = "0x256E4D0", Offset = "0x256D0D0", VA = "0x18256E4D0")]
		public Act3FunService()
		{
		}

		// Token: 0x0403BFD4 RID: 245716
		[Token(Token = "0x403BFD4")]
		public const string FUN_BATTLE_START = "/aprilFool/act3fun/battleStart";

		// Token: 0x0403BFD5 RID: 245717
		[Token(Token = "0x403BFD5")]
		public const string FUN_BATTLE_FINISH = "/aprilFool/act3fun/battleFinish";

		// Token: 0x0403BFD6 RID: 245718
		[Token(Token = "0x403BFD6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
