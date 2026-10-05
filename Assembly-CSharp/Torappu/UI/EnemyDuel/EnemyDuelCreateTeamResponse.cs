using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F65 RID: 20325
	[Token(Token = "0x2004F65")]
	public class EnemyDuelCreateTeamResponse : PlayerDeltaResponse
	{
		// Token: 0x0601E3F8 RID: 123896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3F8")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public EnemyDuelCreateTeamResponse()
		{
		}

		// Token: 0x040285A4 RID: 165284
		[Token(Token = "0x40285A4")]
		[FieldOffset(Offset = "0x28")]
		public int result;

		// Token: 0x040285A5 RID: 165285
		[Token(Token = "0x40285A5")]
		[FieldOffset(Offset = "0x30")]
		public EnemyDuelTeamInfo team;

		// Token: 0x02004F66 RID: 20326
		[Token(Token = "0x2004F66")]
		public enum ResultType
		{
			// Token: 0x040285A7 RID: 165287
			[Token(Token = "0x40285A7")]
			SUCCESS,
			// Token: 0x040285A8 RID: 165288
			[Token(Token = "0x40285A8")]
			TOO_FAST,
			// Token: 0x040285A9 RID: 165289
			[Token(Token = "0x40285A9")]
			BAN,
			// Token: 0x040285AA RID: 165290
			[Token(Token = "0x40285AA")]
			TOO_BUSY
		}
	}
}
