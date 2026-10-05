using System;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004549 RID: 17737
	[Token(Token = "0x2004549")]
	public class GameSettleGameInfo
	{
		// Token: 0x0601B0A1 RID: 110753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0A1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GameSettleGameInfo()
		{
		}

		// Token: 0x04022BB8 RID: 142264
		[Token(Token = "0x4022BB8")]
		[FieldOffset(Offset = "0x10")]
		public GameSettleBrief brief;

		// Token: 0x04022BB9 RID: 142265
		[Token(Token = "0x4022BB9")]
		[FieldOffset(Offset = "0x18")]
		public GameSettleRecord record;

		// Token: 0x04022BBA RID: 142266
		[Token(Token = "0x4022BBA")]
		[FieldOffset(Offset = "0x20")]
		public GameSettleScore score;

		// Token: 0x04022BBB RID: 142267
		[Token(Token = "0x4022BBB")]
		[FieldOffset(Offset = "0x28")]
		public GameSettleMonthTeam monthTeam;

		// Token: 0x04022BBC RID: 142268
		[Token(Token = "0x4022BBC")]
		[FieldOffset(Offset = "0x30")]
		public GameSettleChallenge challenge;
	}
}
