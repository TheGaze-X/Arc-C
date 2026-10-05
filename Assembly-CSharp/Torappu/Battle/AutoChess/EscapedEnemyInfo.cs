using System;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x0200272C RID: 10028
	[Token(Token = "0x200272C")]
	public class EscapedEnemyInfo
	{
		// Token: 0x06010486 RID: 66694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010486")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EscapedEnemyInfo()
		{
		}

		// Token: 0x04012346 RID: 74566
		[Token(Token = "0x4012346")]
		[FieldOffset(Offset = "0x10")]
		public int uidIndex;

		// Token: 0x04012347 RID: 74567
		[Token(Token = "0x4012347")]
		[FieldOffset(Offset = "0x18")]
		public string enemyId;

		// Token: 0x04012348 RID: 74568
		[Token(Token = "0x4012348")]
		[FieldOffset(Offset = "0x20")]
		public int enemyInstId;

		// Token: 0x04012349 RID: 74569
		[Token(Token = "0x4012349")]
		[FieldOffset(Offset = "0x24")]
		public bool isToken;

		// Token: 0x0401234A RID: 74570
		[Token(Token = "0x401234A")]
		[FieldOffset(Offset = "0x28")]
		public int killedByPlayer;
	}
}
