using System;
using Il2CppDummyDll;
using Torappu.Battle.Roguelike;

namespace Torappu
{
	// Token: 0x02000814 RID: 2068
	[Token(Token = "0x2000814")]
	public class RoguelikeFinishBattleRequest : CommonFinishBattleRequest, IFinishBattleWithLog
	{
		// Token: 0x0600649F RID: 25759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600649F")]
		[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0", Slot = "4")]
		public void SetBattleLog(string log)
		{
		}

		// Token: 0x060064A0 RID: 25760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064A0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeFinishBattleRequest()
		{
		}

		// Token: 0x04003123 RID: 12579
		[Token(Token = "0x4003123")]
		[FieldOffset(Offset = "0x20")]
		public string battleLog;

		// Token: 0x04003124 RID: 12580
		[Token(Token = "0x4003124")]
		[FieldOffset(Offset = "0x28")]
		public RoguelikeOutput rlv2Data;
	}
}
