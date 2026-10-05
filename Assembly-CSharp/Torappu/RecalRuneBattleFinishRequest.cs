using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007D5 RID: 2005
	[Token(Token = "0x20007D5")]
	public class RecalRuneBattleFinishRequest : CommonFinishBattleRequest, IFinishBattleWithLog
	{
		// Token: 0x0600645C RID: 25692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600645C")]
		[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0", Slot = "4")]
		public void SetBattleLog(string log)
		{
		}

		// Token: 0x0600645D RID: 25693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600645D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RecalRuneBattleFinishRequest()
		{
		}

		// Token: 0x040030EC RID: 12524
		[Token(Token = "0x40030EC")]
		[FieldOffset(Offset = "0x20")]
		public string battleLog;
	}
}
