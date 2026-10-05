using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F68 RID: 20328
	[Token(Token = "0x2004F68")]
	public class EnemyDuelJoinTeamResponse : PlayerDeltaResponse
	{
		// Token: 0x0601E3FA RID: 123898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3FA")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public EnemyDuelJoinTeamResponse()
		{
		}

		// Token: 0x040285AD RID: 165293
		[Token(Token = "0x40285AD")]
		[FieldOffset(Offset = "0x28")]
		public int result;

		// Token: 0x040285AE RID: 165294
		[Token(Token = "0x40285AE")]
		[FieldOffset(Offset = "0x30")]
		public EnemyDuelJoinTeamInfo team;

		// Token: 0x02004F69 RID: 20329
		[Token(Token = "0x2004F69")]
		public enum JoinResultType
		{
			// Token: 0x040285B0 RID: 165296
			[Token(Token = "0x40285B0")]
			OK,
			// Token: 0x040285B1 RID: 165297
			[Token(Token = "0x40285B1")]
			TOO_FAST,
			// Token: 0x040285B2 RID: 165298
			[Token(Token = "0x40285B2")]
			BAN,
			// Token: 0x040285B3 RID: 165299
			[Token(Token = "0x40285B3")]
			ROOM_NOT_EXIST,
			// Token: 0x040285B4 RID: 165300
			[Token(Token = "0x40285B4")]
			ROOM_IS_FULL,
			// Token: 0x040285B5 RID: 165301
			[Token(Token = "0x40285B5")]
			STAGE_MISMATCH,
			// Token: 0x040285B6 RID: 165302
			[Token(Token = "0x40285B6")]
			ROOM_IS_IN_GAME
		}
	}
}
