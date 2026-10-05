using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act4fun
{
	// Token: 0x02007206 RID: 29190
	[Token(Token = "0x2007206")]
	[LuaCallCSharp(GenFlag.No)]
	public class Act4FunBattleStartResponse : DefaultStartBattleResponse
	{
		// Token: 0x0602963E RID: 169534 RVA: 0x000D58B8 File Offset: 0x000D3AB8
		[Token(Token = "0x602963E")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool GetIsApProtect()
		{
			return default(bool);
		}

		// Token: 0x0602963F RID: 169535 RVA: 0x000D58D0 File Offset: 0x000D3AD0
		[Token(Token = "0x602963F")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
		public override bool GetNotifyPowerScoreNotEnoughIfFailed()
		{
			return default(bool);
		}

		// Token: 0x06029640 RID: 169536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029640")]
		[Address(RVA = "0x10D7700", Offset = "0x10D6300", VA = "0x1810D7700")]
		public Act4FunBattleStartResponse()
		{
		}
	}
}
