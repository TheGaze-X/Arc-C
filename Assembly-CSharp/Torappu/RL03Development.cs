using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001256 RID: 4694
	[Token(Token = "0x2001256")]
	public class RL03Development
	{
		// Token: 0x060071CD RID: 29133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071CD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RL03Development()
		{
		}

		// Token: 0x04006786 RID: 26502
		[Token(Token = "0x4006786")]
		[FieldOffset(Offset = "0x10")]
		public string buffId;

		// Token: 0x04006787 RID: 26503
		[Token(Token = "0x4006787")]
		[FieldOffset(Offset = "0x18")]
		public RL03DevelopmentNodeType nodeType;

		// Token: 0x04006788 RID: 26504
		[Token(Token = "0x4006788")]
		[FieldOffset(Offset = "0x20")]
		public List<string> frontNodeId;

		// Token: 0x04006789 RID: 26505
		[Token(Token = "0x4006789")]
		[FieldOffset(Offset = "0x28")]
		public List<string> nextNodeId;

		// Token: 0x0400678A RID: 26506
		[Token(Token = "0x400678A")]
		[FieldOffset(Offset = "0x30")]
		public int positionRow;

		// Token: 0x0400678B RID: 26507
		[Token(Token = "0x400678B")]
		[FieldOffset(Offset = "0x34")]
		public int positionOrder;

		// Token: 0x0400678C RID: 26508
		[Token(Token = "0x400678C")]
		[FieldOffset(Offset = "0x38")]
		public int tokenCost;

		// Token: 0x0400678D RID: 26509
		[Token(Token = "0x400678D")]
		[FieldOffset(Offset = "0x40")]
		public string buffName;

		// Token: 0x0400678E RID: 26510
		[Token(Token = "0x400678E")]
		[FieldOffset(Offset = "0x48")]
		public string buffIconId;

		// Token: 0x0400678F RID: 26511
		[Token(Token = "0x400678F")]
		[FieldOffset(Offset = "0x50")]
		public RL03DevelopmentEffectType effectType;

		// Token: 0x04006790 RID: 26512
		[Token(Token = "0x4006790")]
		[FieldOffset(Offset = "0x58")]
		public List<string> rawDesc;

		// Token: 0x04006791 RID: 26513
		[Token(Token = "0x4006791")]
		[FieldOffset(Offset = "0x60")]
		public List<RoguelikeTopicDisplayItem> buffDisplayInfo;

		// Token: 0x04006792 RID: 26514
		[Token(Token = "0x4006792")]
		[FieldOffset(Offset = "0x68")]
		public string groupId;

		// Token: 0x04006793 RID: 26515
		[Token(Token = "0x4006793")]
		[FieldOffset(Offset = "0x70")]
		public string enrollId;
	}
}
