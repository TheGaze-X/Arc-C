using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001168 RID: 4456
	[Token(Token = "0x2001168")]
	public class RoguelikeDungeonLayer
	{
		// Token: 0x06006F53 RID: 28499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F53")]
		[Address(RVA = "0x2111140", Offset = "0x210FD40", VA = "0x182111140")]
		public RoguelikeDungeonLayer()
		{
		}

		// Token: 0x04005F7A RID: 24442
		[Token(Token = "0x4005F7A")]
		[FieldOffset(Offset = "0x10")]
		public List<RoguelikeDungeonNode> nodes;
	}
}
