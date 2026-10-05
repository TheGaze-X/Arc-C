using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.Douququ
{
	// Token: 0x02002A46 RID: 10822
	[Token(Token = "0x2002A46")]
	[Serializable]
	public class TeamData
	{
		// Token: 0x06011F95 RID: 73621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F95")]
		[Address(RVA = "0xA1D3F0", Offset = "0xA1BFF0", VA = "0x180A1D3F0")]
		public TeamData()
		{
		}

		// Token: 0x040144A2 RID: 83106
		[Token(Token = "0x40144A2")]
		[FieldOffset(Offset = "0x10")]
		public List<EnemyGenerationData> teamRight;

		// Token: 0x040144A3 RID: 83107
		[Token(Token = "0x40144A3")]
		[FieldOffset(Offset = "0x18")]
		public List<EnemyGenerationData> teamLeft;
	}
}
