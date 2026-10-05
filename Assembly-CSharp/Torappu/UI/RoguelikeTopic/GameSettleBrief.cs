using System;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200454A RID: 17738
	[Token(Token = "0x200454A")]
	public class GameSettleBrief
	{
		// Token: 0x0601B0A2 RID: 110754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0A2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GameSettleBrief()
		{
		}

		// Token: 0x04022BBD RID: 142269
		[Token(Token = "0x4022BBD")]
		[FieldOffset(Offset = "0x10")]
		public int success;

		// Token: 0x04022BBE RID: 142270
		[Token(Token = "0x4022BBE")]
		[FieldOffset(Offset = "0x18")]
		public string ending;

		// Token: 0x04022BBF RID: 142271
		[Token(Token = "0x4022BBF")]
		[FieldOffset(Offset = "0x20")]
		public string theme;

		// Token: 0x04022BC0 RID: 142272
		[Token(Token = "0x4022BC0")]
		[FieldOffset(Offset = "0x28")]
		public RoguelikeTopicMode mode;

		// Token: 0x04022BC1 RID: 142273
		[Token(Token = "0x4022BC1")]
		[FieldOffset(Offset = "0x30")]
		public string band;

		// Token: 0x04022BC2 RID: 142274
		[Token(Token = "0x4022BC2")]
		[FieldOffset(Offset = "0x38")]
		public int level;
	}
}
