using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F67 RID: 20327
	[Token(Token = "0x2004F67")]
	public class EnemyDuelJoinTeamRequest
	{
		// Token: 0x0601E3F9 RID: 123897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3F9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EnemyDuelJoinTeamRequest()
		{
		}

		// Token: 0x040285AB RID: 165291
		[Token(Token = "0x40285AB")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x040285AC RID: 165292
		[Token(Token = "0x40285AC")]
		[FieldOffset(Offset = "0x18")]
		public string teamId;
	}
}
