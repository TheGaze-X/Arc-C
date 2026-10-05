using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F64 RID: 20324
	[Token(Token = "0x2004F64")]
	public class EnemyDuelCreateTeamRequest
	{
		// Token: 0x0601E3F7 RID: 123895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3F7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EnemyDuelCreateTeamRequest()
		{
		}

		// Token: 0x040285A2 RID: 165282
		[Token(Token = "0x40285A2")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x040285A3 RID: 165283
		[Token(Token = "0x40285A3")]
		[FieldOffset(Offset = "0x18")]
		public string modeId;
	}
}
