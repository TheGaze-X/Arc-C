using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.EnemyDuel
{
	// Token: 0x020026C3 RID: 9923
	[Token(Token = "0x20026C3")]
	public class EnemyDuelRoundBornUnit
	{
		// Token: 0x060102CD RID: 66253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102CD")]
		[Address(RVA = "0x7E8510", Offset = "0x7E7110", VA = "0x1807E8510")]
		public void AddUnit(Unit unit, bool isRight)
		{
		}

		// Token: 0x060102CE RID: 66254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102CE")]
		[Address(RVA = "0x7E8640", Offset = "0x7E7240", VA = "0x1807E8640")]
		public void Reset(int curRound)
		{
		}

		// Token: 0x060102CF RID: 66255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102CF")]
		[Address(RVA = "0x7E86B0", Offset = "0x7E72B0", VA = "0x1807E86B0")]
		public EnemyDuelRoundBornUnit()
		{
		}

		// Token: 0x04012097 RID: 73879
		[Token(Token = "0x4012097")]
		[FieldOffset(Offset = "0x10")]
		public int round;

		// Token: 0x04012098 RID: 73880
		[Token(Token = "0x4012098")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, int> leftUnitIds;

		// Token: 0x04012099 RID: 73881
		[Token(Token = "0x4012099")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, int> rightUnitIds;
	}
}
