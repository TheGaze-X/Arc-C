using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FC8 RID: 4040
	[Token(Token = "0x2000FC8")]
	public class CrisisV2NodeData
	{
		// Token: 0x06006D16 RID: 27926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D16")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2NodeData()
		{
		}

		// Token: 0x040055D1 RID: 21969
		[Token(Token = "0x40055D1")]
		[FieldOffset(Offset = "0x10")]
		public string runeId;

		// Token: 0x040055D2 RID: 21970
		[Token(Token = "0x40055D2")]
		[FieldOffset(Offset = "0x18")]
		public string slotPackId;

		// Token: 0x040055D3 RID: 21971
		[Token(Token = "0x40055D3")]
		[FieldOffset(Offset = "0x20")]
		public CrisisV2NodeSlotType nodeType;

		// Token: 0x040055D4 RID: 21972
		[Token(Token = "0x40055D4")]
		[FieldOffset(Offset = "0x28")]
		public string mutualExclusionGroup;

		// Token: 0x040055D5 RID: 21973
		[Token(Token = "0x40055D5")]
		[FieldOffset(Offset = "0x30")]
		public List<string> adjacentNodeList;
	}
}
