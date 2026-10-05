using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001037 RID: 4151
	[Token(Token = "0x2001037")]
	public class EnemyHandbookLevelInfoData
	{
		// Token: 0x06006DA5 RID: 28069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DA5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EnemyHandbookLevelInfoData()
		{
		}

		// Token: 0x04005829 RID: 22569
		[Token(Token = "0x4005829")]
		[FieldOffset(Offset = "0x10")]
		public string classLevel;

		// Token: 0x0400582A RID: 22570
		[Token(Token = "0x400582A")]
		[FieldOffset(Offset = "0x18")]
		public EnemyHandbookLevelInfoData.RangePair attack;

		// Token: 0x0400582B RID: 22571
		[Token(Token = "0x400582B")]
		[FieldOffset(Offset = "0x20")]
		public EnemyHandbookLevelInfoData.RangePair def;

		// Token: 0x0400582C RID: 22572
		[Token(Token = "0x400582C")]
		[FieldOffset(Offset = "0x28")]
		public EnemyHandbookLevelInfoData.RangePair magicRes;

		// Token: 0x0400582D RID: 22573
		[Token(Token = "0x400582D")]
		[FieldOffset(Offset = "0x30")]
		public EnemyHandbookLevelInfoData.RangePair maxHP;

		// Token: 0x0400582E RID: 22574
		[Token(Token = "0x400582E")]
		[FieldOffset(Offset = "0x38")]
		public EnemyHandbookLevelInfoData.RangePair moveSpeed;

		// Token: 0x0400582F RID: 22575
		[Token(Token = "0x400582F")]
		[FieldOffset(Offset = "0x40")]
		public EnemyHandbookLevelInfoData.RangePair attackSpeed;

		// Token: 0x04005830 RID: 22576
		[Token(Token = "0x4005830")]
		[FieldOffset(Offset = "0x48")]
		public EnemyHandbookLevelInfoData.RangePair enemyDamageRes;

		// Token: 0x04005831 RID: 22577
		[Token(Token = "0x4005831")]
		[FieldOffset(Offset = "0x50")]
		public EnemyHandbookLevelInfoData.RangePair enemyRes;

		// Token: 0x02001038 RID: 4152
		[Token(Token = "0x2001038")]
		public class RangePair
		{
			// Token: 0x06006DA6 RID: 28070 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006DA6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RangePair()
			{
			}

			// Token: 0x04005832 RID: 22578
			[Token(Token = "0x4005832")]
			[FieldOffset(Offset = "0x10")]
			public float min;

			// Token: 0x04005833 RID: 22579
			[Token(Token = "0x4005833")]
			[FieldOffset(Offset = "0x14")]
			public float max;
		}
	}
}
