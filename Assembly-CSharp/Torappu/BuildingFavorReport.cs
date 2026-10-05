using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000665 RID: 1637
	[Token(Token = "0x2000665")]
	public class BuildingFavorReport
	{
		// Token: 0x06006293 RID: 25235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006293")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingFavorReport()
		{
		}

		// Token: 0x04002E20 RID: 11808
		[Token(Token = "0x4002E20")]
		[FieldOffset(Offset = "0x10")]
		public int charInstId;

		// Token: 0x04002E21 RID: 11809
		[Token(Token = "0x4002E21")]
		[FieldOffset(Offset = "0x18")]
		public List<int> favorChange;
	}
}
