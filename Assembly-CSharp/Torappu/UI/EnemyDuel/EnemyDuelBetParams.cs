using System;
using Il2CppDummyDll;
using Torappu.Battle.EnemyDuel;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FD3 RID: 20435
	[Token(Token = "0x2004FD3")]
	public class EnemyDuelBetParams
	{
		// Token: 0x0601E58C RID: 124300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E58C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EnemyDuelBetParams()
		{
		}

		// Token: 0x04028902 RID: 166146
		[Token(Token = "0x4028902")]
		[FieldOffset(Offset = "0x10")]
		public string playerId;

		// Token: 0x04028903 RID: 166147
		[Token(Token = "0x4028903")]
		[FieldOffset(Offset = "0x18")]
		public EnemyDuelChoiceSide side;

		// Token: 0x04028904 RID: 166148
		[Token(Token = "0x4028904")]
		[FieldOffset(Offset = "0x1C")]
		public bool isAllIn;
	}
}
