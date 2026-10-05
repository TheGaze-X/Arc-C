using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F6B RID: 20331
	[Token(Token = "0x2004F6B")]
	public class EnemyDuelStartMatchResponse : PlayerDeltaResponse
	{
		// Token: 0x0601E3FC RID: 123900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3FC")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public EnemyDuelStartMatchResponse()
		{
		}

		// Token: 0x040285B9 RID: 165305
		[Token(Token = "0x40285B9")]
		[FieldOffset(Offset = "0x28")]
		public EnemyDuelStartMatchResponse.Result result;

		// Token: 0x02004F6C RID: 20332
		[Token(Token = "0x2004F6C")]
		public enum Result
		{
			// Token: 0x040285BB RID: 165307
			[Token(Token = "0x40285BB")]
			SUCCESS,
			// Token: 0x040285BC RID: 165308
			[Token(Token = "0x40285BC")]
			TOO_FAST,
			// Token: 0x040285BD RID: 165309
			[Token(Token = "0x40285BD")]
			BAN,
			// Token: 0x040285BE RID: 165310
			[Token(Token = "0x40285BE")]
			TOO_BUSY
		}
	}
}
