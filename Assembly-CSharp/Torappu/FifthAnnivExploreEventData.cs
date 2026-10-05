using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200104F RID: 4175
	[Token(Token = "0x200104F")]
	public class FifthAnnivExploreEventData
	{
		// Token: 0x06006DB7 RID: 28087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DB7")]
		[Address(RVA = "0x2104780", Offset = "0x2103380", VA = "0x182104780")]
		public FifthAnnivExploreEventData()
		{
		}

		// Token: 0x040058B9 RID: 22713
		[Token(Token = "0x40058B9")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040058BA RID: 22714
		[Token(Token = "0x40058BA")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x040058BB RID: 22715
		[Token(Token = "0x40058BB")]
		[FieldOffset(Offset = "0x20")]
		public string typeName;

		// Token: 0x040058BC RID: 22716
		[Token(Token = "0x40058BC")]
		[FieldOffset(Offset = "0x28")]
		public string iconId;

		// Token: 0x040058BD RID: 22717
		[Token(Token = "0x40058BD")]
		[FieldOffset(Offset = "0x30")]
		public string desc;

		// Token: 0x040058BE RID: 22718
		[Token(Token = "0x40058BE")]
		[FieldOffset(Offset = "0x38")]
		public List<string> choiceIds;
	}
}
