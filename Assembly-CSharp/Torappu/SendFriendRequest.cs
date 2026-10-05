using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200071F RID: 1823
	[Token(Token = "0x200071F")]
	public class SendFriendRequest
	{
		// Token: 0x0600638A RID: 25482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600638A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SendFriendRequest()
		{
		}

		// Token: 0x04002F75 RID: 12149
		[Token(Token = "0x4002F75")]
		public const int SOURCE_NONE = 0;

		// Token: 0x04002F76 RID: 12150
		[Token(Token = "0x4002F76")]
		public const int FROM_DEFAULT_BATTLE = 1;

		// Token: 0x04002F77 RID: 12151
		[Token(Token = "0x4002F77")]
		public const int ROGUELIKE_FRIEND = 2;

		// Token: 0x04002F78 RID: 12152
		[Token(Token = "0x4002F78")]
		public const int FRIEND_SEARCH = 3;

		// Token: 0x04002F79 RID: 12153
		[Token(Token = "0x4002F79")]
		public const int SQUAD = 4;

		// Token: 0x04002F7A RID: 12154
		[Token(Token = "0x4002F7A")]
		public const int MULTIPLAY_MANUAL = 5;

		// Token: 0x04002F7B RID: 12155
		[Token(Token = "0x4002F7B")]
		public const int ENEMY_DUEL_MANUAL = 6;

		// Token: 0x04002F7C RID: 12156
		[Token(Token = "0x4002F7C")]
		public const int TEAM_QUEST = 7;

		// Token: 0x04002F7D RID: 12157
		[Token(Token = "0x4002F7D")]
		public const int AUTO_CHESS_MANUAL = 8;

		// Token: 0x04002F7E RID: 12158
		[Token(Token = "0x4002F7E")]
		[FieldOffset(Offset = "0x10")]
		public string friendId;

		// Token: 0x04002F7F RID: 12159
		[Token(Token = "0x4002F7F")]
		[FieldOffset(Offset = "0x18")]
		public int afterBattle;

		// Token: 0x04002F80 RID: 12160
		[Token(Token = "0x4002F80")]
		[FieldOffset(Offset = "0x1C")]
		public int originType;

		// Token: 0x04002F81 RID: 12161
		[Token(Token = "0x4002F81")]
		[FieldOffset(Offset = "0x20")]
		public string battleOrigin;
	}
}
