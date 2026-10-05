using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008BA RID: 2234
	[Token(Token = "0x20008BA")]
	public class StartBattleExtraInfoSixStarData
	{
		// Token: 0x06006567 RID: 25959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006567")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StartBattleExtraInfoSixStarData()
		{
		}

		// Token: 0x040032A5 RID: 12965
		[Token(Token = "0x40032A5")]
		[FieldOffset(Offset = "0x10")]
		public List<string> tags;
	}
}
