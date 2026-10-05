using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F62 RID: 20322
	[Token(Token = "0x2004F62")]
	public class EnemyDuelTeamInfo
	{
		// Token: 0x0601E3F5 RID: 123893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3F5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EnemyDuelTeamInfo()
		{
		}

		// Token: 0x0402859E RID: 165278
		[Token(Token = "0x402859E")]
		[FieldOffset(Offset = "0x10")]
		public string teamId;

		// Token: 0x0402859F RID: 165279
		[Token(Token = "0x402859F")]
		[FieldOffset(Offset = "0x18")]
		public string serverAddress;

		// Token: 0x040285A0 RID: 165280
		[Token(Token = "0x40285A0")]
		[FieldOffset(Offset = "0x20")]
		public string serverToken;
	}
}
