using System;
using Il2CppDummyDll;

namespace Torappu.Battle.Douququ
{
	// Token: 0x02002A45 RID: 10821
	[Token(Token = "0x2002A45")]
	[Serializable]
	public class EnemyGenerationData
	{
		// Token: 0x06011F93 RID: 73619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011F93")]
		[Address(RVA = "0xA043A0", Offset = "0xA02FA0", VA = "0x180A043A0")]
		public EnemyGenerationData Duplicate()
		{
			return null;
		}

		// Token: 0x06011F94 RID: 73620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F94")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EnemyGenerationData()
		{
		}

		// Token: 0x0401449D RID: 83101
		[Token(Token = "0x401449D")]
		[FieldOffset(Offset = "0x10")]
		public string enemyId;

		// Token: 0x0401449E RID: 83102
		[Token(Token = "0x401449E")]
		[FieldOffset(Offset = "0x18")]
		public float value;

		// Token: 0x0401449F RID: 83103
		[Token(Token = "0x401449F")]
		[FieldOffset(Offset = "0x1C")]
		public float increment;

		// Token: 0x040144A0 RID: 83104
		[Token(Token = "0x40144A0")]
		[FieldOffset(Offset = "0x20")]
		public int priority;

		// Token: 0x040144A1 RID: 83105
		[Token(Token = "0x40144A1")]
		[FieldOffset(Offset = "0x24")]
		public int count;
	}
}
