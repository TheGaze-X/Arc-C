using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F6A RID: 20330
	[Token(Token = "0x2004F6A")]
	public class EnemyDuelStartMatchRequest
	{
		// Token: 0x0601E3FB RID: 123899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3FB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EnemyDuelStartMatchRequest()
		{
		}

		// Token: 0x040285B7 RID: 165303
		[Token(Token = "0x40285B7")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x040285B8 RID: 165304
		[Token(Token = "0x40285B8")]
		[FieldOffset(Offset = "0x18")]
		public string modeId;
	}
}
