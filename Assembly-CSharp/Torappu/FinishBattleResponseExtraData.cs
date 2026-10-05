using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000710 RID: 1808
	[Token(Token = "0x2000710")]
	public class FinishBattleResponseExtraData
	{
		// Token: 0x0600637D RID: 25469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600637D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FinishBattleResponseExtraData()
		{
		}

		// Token: 0x04002F4F RID: 12111
		[Token(Token = "0x4002F4F")]
		[FieldOffset(Offset = "0x10")]
		public FinishBattleRespExtraSixStarData sixStar;
	}
}
