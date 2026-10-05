using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F6E RID: 20334
	[Token(Token = "0x2004F6E")]
	public class EnemyDuelQueryMatchResponse : PlayerDeltaResponse
	{
		// Token: 0x0601E3FE RID: 123902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3FE")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public EnemyDuelQueryMatchResponse()
		{
		}

		// Token: 0x040285C1 RID: 165313
		[Token(Token = "0x40285C1")]
		[FieldOffset(Offset = "0x28")]
		public EnemyDuelQueryMatchResponse.Result result;

		// Token: 0x040285C2 RID: 165314
		[Token(Token = "0x40285C2")]
		[FieldOffset(Offset = "0x30")]
		public EnemyDuelTeamInfo team;

		// Token: 0x040285C3 RID: 165315
		[Token(Token = "0x40285C3")]
		[FieldOffset(Offset = "0x38")]
		public string info;

		// Token: 0x040285C4 RID: 165316
		[Token(Token = "0x40285C4")]
		[FieldOffset(Offset = "0x40")]
		public int playerCnt;

		// Token: 0x02004F6F RID: 20335
		[Token(Token = "0x2004F6F")]
		public enum Result
		{
			// Token: 0x040285C6 RID: 165318
			[Token(Token = "0x40285C6")]
			SUCCESS,
			// Token: 0x040285C7 RID: 165319
			[Token(Token = "0x40285C7")]
			CANCEL,
			// Token: 0x040285C8 RID: 165320
			[Token(Token = "0x40285C8")]
			NOT_IN_MATCH,
			// Token: 0x040285C9 RID: 165321
			[Token(Token = "0x40285C9")]
			TIME_OUT,
			// Token: 0x040285CA RID: 165322
			[Token(Token = "0x40285CA")]
			FAIL_TO_CANCEL
		}
	}
}
