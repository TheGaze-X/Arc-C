using System;
using Il2CppDummyDll;

namespace Torappu.Battle.Douququ
{
	// Token: 0x02002A44 RID: 10820
	[Token(Token = "0x2002A44")]
	[Serializable]
	public class RoundData
	{
		// Token: 0x06011F92 RID: 73618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F92")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoundData()
		{
		}

		// Token: 0x04014499 RID: 83097
		[Token(Token = "0x4014499")]
		[FieldOffset(Offset = "0x10")]
		public int minType;

		// Token: 0x0401449A RID: 83098
		[Token(Token = "0x401449A")]
		[FieldOffset(Offset = "0x14")]
		public int maxType;

		// Token: 0x0401449B RID: 83099
		[Token(Token = "0x401449B")]
		[FieldOffset(Offset = "0x18")]
		public float enemyPoint;

		// Token: 0x0401449C RID: 83100
		[Token(Token = "0x401449C")]
		[FieldOffset(Offset = "0x1C")]
		public float enemyScoreRandom;
	}
}
