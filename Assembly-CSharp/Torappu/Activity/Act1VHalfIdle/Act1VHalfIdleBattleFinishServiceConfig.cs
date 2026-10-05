using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076C0 RID: 30400
	[Token(Token = "0x20076C0")]
	public class Act1VHalfIdleBattleFinishServiceConfig : FinishBattleServiceConfig<Act1VHalfIdleBattleFinishRequest, Act1VHalfIdleBattleFinishResponse>
	{
		// Token: 0x0602AC0A RID: 175114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC0A")]
		[Address(RVA = "0x2681EE0", Offset = "0x2680AE0", VA = "0x182681EE0")]
		public Act1VHalfIdleBattleFinishServiceConfig(string actId)
		{
		}

		// Token: 0x0602AC0B RID: 175115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC0B")]
		[Address(RVA = "0x26819D0", Offset = "0x26805D0", VA = "0x1826819D0", Slot = "9")]
		public override void OnParseRequest(Act1VHalfIdleBattleFinishRequest request)
		{
		}

		// Token: 0x0403D99C RID: 252316
		[Token(Token = "0x403D99C")]
		[FieldOffset(Offset = "0x18")]
		private string m_actId;
	}
}
