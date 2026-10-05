using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act3fun
{
	// Token: 0x020073BE RID: 29630
	[Token(Token = "0x20073BE")]
	[LuaCallCSharp(GenFlag.No)]
	public class Act3BattleFinishServerConfig : FinishBattleServiceConfig<Act3FunBattleFinishRequest, Act3FunBattleFinishResponse>
	{
		// Token: 0x06029DC6 RID: 171462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DC6")]
		[Address(RVA = "0x2569070", Offset = "0x2567C70", VA = "0x182569070", Slot = "9")]
		public override void OnParseRequest(Act3FunBattleFinishRequest request)
		{
		}

		// Token: 0x06029DC7 RID: 171463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DC7")]
		[Address(RVA = "0x25690C0", Offset = "0x2567CC0", VA = "0x1825690C0")]
		public Act3BattleFinishServerConfig(string serviceCode)
		{
		}
	}
}
