using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011D1 RID: 4561
	[Token(Token = "0x20011D1")]
	[Serializable]
	public class RoguelikeTopicTable
	{
		// Token: 0x06006FB3 RID: 28595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FB3")]
		[Address(RVA = "0x2114660", Offset = "0x2113260", VA = "0x182114660")]
		public RoguelikeTopicTable()
		{
		}

		// Token: 0x040061AC RID: 25004
		[Token(Token = "0x40061AC")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, RoguelikeTopicBasicData> topics;

		// Token: 0x040061AD RID: 25005
		[Token(Token = "0x40061AD")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeTopicConst constant;

		// Token: 0x040061AE RID: 25006
		[Token(Token = "0x40061AE")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, RoguelikeTopicDetail> details;

		// Token: 0x040061AF RID: 25007
		[Token(Token = "0x40061AF")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, RoguelikeModule> modules;

		// Token: 0x040061B0 RID: 25008
		[Token(Token = "0x40061B0")]
		[FieldOffset(Offset = "0x30")]
		public RoguelikeTopicCustomizeData customizeData;
	}
}
