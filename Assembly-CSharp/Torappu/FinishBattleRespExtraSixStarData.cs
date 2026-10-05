using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000711 RID: 1809
	[Token(Token = "0x2000711")]
	public class FinishBattleRespExtraSixStarData
	{
		// Token: 0x0600637E RID: 25470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600637E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FinishBattleRespExtraSixStarData()
		{
		}

		// Token: 0x04002F50 RID: 12112
		[Token(Token = "0x4002F50")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04002F51 RID: 12113
		[Token(Token = "0x4002F51")]
		[FieldOffset(Offset = "0x18")]
		public int before;

		// Token: 0x04002F52 RID: 12114
		[Token(Token = "0x4002F52")]
		[FieldOffset(Offset = "0x1C")]
		public int after;
	}
}
