using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act5fun
{
	// Token: 0x020071D1 RID: 29137
	[Token(Token = "0x20071D1")]
	[LuaCallCSharp(GenFlag.No)]
	public class Act5FunBattleStartResponse : DefaultStartBattleResponse
	{
		// Token: 0x06029576 RID: 169334 RVA: 0x000D5660 File Offset: 0x000D3860
		[Token(Token = "0x6029576")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public override bool GetIsApProtect()
		{
			return default(bool);
		}

		// Token: 0x06029577 RID: 169335 RVA: 0x000D5678 File Offset: 0x000D3878
		[Token(Token = "0x6029577")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
		public override bool GetNotifyPowerScoreNotEnoughIfFailed()
		{
			return default(bool);
		}

		// Token: 0x06029578 RID: 169336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029578")]
		[Address(RVA = "0x10D7700", Offset = "0x10D6300", VA = "0x1810D7700")]
		public Act5FunBattleStartResponse()
		{
		}
	}
}
