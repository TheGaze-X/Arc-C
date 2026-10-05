using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act4fun
{
	// Token: 0x02007204 RID: 29188
	[Token(Token = "0x2007204")]
	[LuaCallCSharp(GenFlag.No)]
	public class Act4FunService : IHotfixable
	{
		// Token: 0x0602963C RID: 169532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602963C")]
		[Address(RVA = "0x24C06F0", Offset = "0x24BF2F0", VA = "0x1824C06F0")]
		public Act4FunService()
		{
		}

		// Token: 0x0403B1F1 RID: 242161
		[Token(Token = "0x403B1F1")]
		public const string FUN_BATTLE_START = "/aprilFool/act4fun/battleStart";

		// Token: 0x0403B1F2 RID: 242162
		[Token(Token = "0x403B1F2")]
		public const string FUN_BATTLE_FINISH = "/aprilFool/act4fun/battleFinish";

		// Token: 0x0403B1F3 RID: 242163
		[Token(Token = "0x403B1F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
