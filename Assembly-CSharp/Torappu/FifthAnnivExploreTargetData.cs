using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200104D RID: 4173
	[Token(Token = "0x200104D")]
	public class FifthAnnivExploreTargetData
	{
		// Token: 0x06006DB5 RID: 28085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DB5")]
		[Address(RVA = "0x21048A0", Offset = "0x21034A0", VA = "0x1821048A0")]
		public FifthAnnivExploreTargetData()
		{
		}

		// Token: 0x040058A8 RID: 22696
		[Token(Token = "0x40058A8")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040058A9 RID: 22697
		[Token(Token = "0x40058A9")]
		[FieldOffset(Offset = "0x18")]
		public string linkStageId;

		// Token: 0x040058AA RID: 22698
		[Token(Token = "0x40058AA")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, int> targetValues;

		// Token: 0x040058AB RID: 22699
		[Token(Token = "0x40058AB")]
		[FieldOffset(Offset = "0x28")]
		public string requireEventId;

		// Token: 0x040058AC RID: 22700
		[Token(Token = "0x40058AC")]
		[FieldOffset(Offset = "0x30")]
		public string lockedLevelId;

		// Token: 0x040058AD RID: 22701
		[Token(Token = "0x40058AD")]
		[FieldOffset(Offset = "0x38")]
		public bool isEnd;

		// Token: 0x040058AE RID: 22702
		[Token(Token = "0x40058AE")]
		[FieldOffset(Offset = "0x40")]
		public string name;

		// Token: 0x040058AF RID: 22703
		[Token(Token = "0x40058AF")]
		[FieldOffset(Offset = "0x48")]
		public string endName;

		// Token: 0x040058B0 RID: 22704
		[Token(Token = "0x40058B0")]
		[FieldOffset(Offset = "0x50")]
		public string desc;

		// Token: 0x040058B1 RID: 22705
		[Token(Token = "0x40058B1")]
		[FieldOffset(Offset = "0x58")]
		public string successDesc;

		// Token: 0x040058B2 RID: 22706
		[Token(Token = "0x40058B2")]
		[FieldOffset(Offset = "0x60")]
		public string successIconId;
	}
}
