using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001257 RID: 4695
	[Token(Token = "0x2001257")]
	public class RL03DevRawTextBuffGroup
	{
		// Token: 0x060071CE RID: 29134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071CE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RL03DevRawTextBuffGroup()
		{
		}

		// Token: 0x04006794 RID: 26516
		[Token(Token = "0x4006794")]
		[FieldOffset(Offset = "0x10")]
		public List<string> nodeIdList;

		// Token: 0x04006795 RID: 26517
		[Token(Token = "0x4006795")]
		[FieldOffset(Offset = "0x18")]
		public bool useLevelMark;

		// Token: 0x04006796 RID: 26518
		[Token(Token = "0x4006796")]
		[FieldOffset(Offset = "0x20")]
		public string groupIconId;

		// Token: 0x04006797 RID: 26519
		[Token(Token = "0x4006797")]
		[FieldOffset(Offset = "0x28")]
		public int sortId;
	}
}
