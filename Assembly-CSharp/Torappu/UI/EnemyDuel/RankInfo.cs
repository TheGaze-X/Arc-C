using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F78 RID: 20344
	[Token(Token = "0x2004F78")]
	public class RankInfo
	{
		// Token: 0x0601E413 RID: 123923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E413")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RankInfo()
		{
		}

		// Token: 0x040285DE RID: 165342
		[Token(Token = "0x40285DE")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040285DF RID: 165343
		[Token(Token = "0x40285DF")]
		[FieldOffset(Offset = "0x18")]
		public int rank;

		// Token: 0x040285E0 RID: 165344
		[Token(Token = "0x40285E0")]
		[FieldOffset(Offset = "0x1C")]
		public int score;

		// Token: 0x040285E1 RID: 165345
		[Token(Token = "0x40285E1")]
		[FieldOffset(Offset = "0x20")]
		public int isPlayer;

		// Token: 0x040285E2 RID: 165346
		[Token(Token = "0x40285E2")]
		[FieldOffset(Offset = "0x28")]
		public PlayerInfo playerBrief;
	}
}
