using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011F0 RID: 4592
	[Token(Token = "0x20011F0")]
	public class RoguelikeTopicDev
	{
		// Token: 0x06006FE2 RID: 28642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FE2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTopicDev()
		{
		}

		// Token: 0x040062AE RID: 25262
		[Token(Token = "0x40062AE")]
		[FieldOffset(Offset = "0x10")]
		public string buffId;

		// Token: 0x040062AF RID: 25263
		[Token(Token = "0x40062AF")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x040062B0 RID: 25264
		[Token(Token = "0x40062B0")]
		[FieldOffset(Offset = "0x1C")]
		public RoguelikeTopicDevNodeType nodeType;

		// Token: 0x040062B1 RID: 25265
		[Token(Token = "0x40062B1")]
		[FieldOffset(Offset = "0x20")]
		public List<string> nextNodeId;

		// Token: 0x040062B2 RID: 25266
		[Token(Token = "0x40062B2")]
		[FieldOffset(Offset = "0x28")]
		public List<string> frontNodeId;

		// Token: 0x040062B3 RID: 25267
		[Token(Token = "0x40062B3")]
		[FieldOffset(Offset = "0x30")]
		public int tokenCost;

		// Token: 0x040062B4 RID: 25268
		[Token(Token = "0x40062B4")]
		[FieldOffset(Offset = "0x38")]
		public string buffName;

		// Token: 0x040062B5 RID: 25269
		[Token(Token = "0x40062B5")]
		[FieldOffset(Offset = "0x40")]
		public string buffIconId;

		// Token: 0x040062B6 RID: 25270
		[Token(Token = "0x40062B6")]
		[FieldOffset(Offset = "0x48")]
		public string buffTypeName;

		// Token: 0x040062B7 RID: 25271
		[Token(Token = "0x40062B7")]
		[FieldOffset(Offset = "0x50")]
		public List<RoguelikeTopicDisplayItem> buffDisplayInfo;
	}
}
