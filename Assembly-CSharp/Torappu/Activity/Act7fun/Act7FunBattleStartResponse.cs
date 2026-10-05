using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act7fun
{
	// Token: 0x02007195 RID: 29077
	[Token(Token = "0x2007195")]
	[LuaCallCSharp(GenFlag.No)]
	public class Act7FunBattleStartResponse : DefaultStartBattleResponse
	{
		// Token: 0x06029437 RID: 169015 RVA: 0x000D4E98 File Offset: 0x000D3098
		[Token(Token = "0x6029437")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool GetIsApProtect()
		{
			return default(bool);
		}

		// Token: 0x06029438 RID: 169016 RVA: 0x000D4EB0 File Offset: 0x000D30B0
		[Token(Token = "0x6029438")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
		public override bool GetNotifyPowerScoreNotEnoughIfFailed()
		{
			return default(bool);
		}

		// Token: 0x06029439 RID: 169017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029439")]
		[Address(RVA = "0x10D7700", Offset = "0x10D6300", VA = "0x1810D7700")]
		public Act7FunBattleStartResponse()
		{
		}
	}
}
