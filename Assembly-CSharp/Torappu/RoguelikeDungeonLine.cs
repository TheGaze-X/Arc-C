using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001163 RID: 4451
	[Token(Token = "0x2001163")]
	public class RoguelikeDungeonLine
	{
		// Token: 0x06006F41 RID: 28481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F41")]
		[Address(RVA = "0x21111D0", Offset = "0x210FDD0", VA = "0x1821111D0")]
		public RoguelikeDungeonNode GetOtherNode(RoguelikeDungeonNode node)
		{
			return null;
		}

		// Token: 0x06006F42 RID: 28482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F42")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeDungeonLine()
		{
		}

		// Token: 0x04005F4E RID: 24398
		[Token(Token = "0x4005F4E")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeDungeonNode children;

		// Token: 0x04005F4F RID: 24399
		[Token(Token = "0x4005F4F")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeDungeonNode parent;

		// Token: 0x04005F50 RID: 24400
		[Token(Token = "0x4005F50")]
		[FieldOffset(Offset = "0x20")]
		public bool isLocked;

		// Token: 0x04005F51 RID: 24401
		[Token(Token = "0x4005F51")]
		[FieldOffset(Offset = "0x21")]
		public bool isHiddened;

		// Token: 0x04005F52 RID: 24402
		[Token(Token = "0x4005F52")]
		[FieldOffset(Offset = "0x24")]
		public RoguelikeDungeonLine.VertType type;

		// Token: 0x02001164 RID: 4452
		[Token(Token = "0x2001164")]
		public enum VertType
		{
			// Token: 0x04005F54 RID: 24404
			[Token(Token = "0x4005F54")]
			NONE,
			// Token: 0x04005F55 RID: 24405
			[Token(Token = "0x4005F55")]
			DOWN_AVAIL,
			// Token: 0x04005F56 RID: 24406
			[Token(Token = "0x4005F56")]
			UP_AVAIL,
			// Token: 0x04005F57 RID: 24407
			[Token(Token = "0x4005F57")]
			DISCARD,
			// Token: 0x04005F58 RID: 24408
			[Token(Token = "0x4005F58")]
			FUTURE_NORMAL,
			// Token: 0x04005F59 RID: 24409
			[Token(Token = "0x4005F59")]
			ALREADY_GO_UP,
			// Token: 0x04005F5A RID: 24410
			[Token(Token = "0x4005F5A")]
			ALREADY_GO_DOWN
		}
	}
}
