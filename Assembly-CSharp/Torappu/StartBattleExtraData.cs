using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008B9 RID: 2233
	[Token(Token = "0x20008B9")]
	public class StartBattleExtraData
	{
		// Token: 0x06006566 RID: 25958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006566")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StartBattleExtraData()
		{
		}

		// Token: 0x040032A4 RID: 12964
		[Token(Token = "0x40032A4")]
		[FieldOffset(Offset = "0x10")]
		public StartBattleExtraInfoSixStarData sixStar;
	}
}
