using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act3fun
{
	// Token: 0x020073BA RID: 29626
	[Token(Token = "0x20073BA")]
	[LuaCallCSharp(GenFlag.No)]
	public class Act3FunBattleStartResponse : DefaultStartBattleResponse
	{
		// Token: 0x06029DBE RID: 171454 RVA: 0x000D6CF8 File Offset: 0x000D4EF8
		[Token(Token = "0x6029DBE")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool GetIsApProtect()
		{
			return default(bool);
		}

		// Token: 0x06029DBF RID: 171455 RVA: 0x000D6D10 File Offset: 0x000D4F10
		[Token(Token = "0x6029DBF")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
		public override bool GetNotifyPowerScoreNotEnoughIfFailed()
		{
			return default(bool);
		}

		// Token: 0x06029DC0 RID: 171456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DC0")]
		[Address(RVA = "0x10D7700", Offset = "0x10D6300", VA = "0x1810D7700")]
		public Act3FunBattleStartResponse()
		{
		}
	}
}
