using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x02002905 RID: 10501
	[Token(Token = "0x2002905")]
	public class ETalentBlackboardMax : BasicEnemyRune
	{
		// Token: 0x17002684 RID: 9860
		// (get) Token: 0x060116CE RID: 71374 RVA: 0x0006B2C8 File Offset: 0x000694C8
		[Token(Token = "0x17002684")]
		public override int priorityQueue
		{
			[Token(Token = "0x60116CE")]
			[Address(RVA = "0x93C810", Offset = "0x93B410", VA = "0x18093C810", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060116CF RID: 71375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116CF")]
		[Address(RVA = "0x93C6D0", Offset = "0x93B2D0", VA = "0x18093C6D0", Slot = "17")]
		protected override void DoPreprocessEnemy(LevelData.EnemyData data, Enemy enemy)
		{
		}

		// Token: 0x060116D0 RID: 71376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116D0")]
		[Address(RVA = "0x93C770", Offset = "0x93B370", VA = "0x18093C770")]
		public ETalentBlackboardMax()
		{
		}

		// Token: 0x060116D1 RID: 71377 RVA: 0x0006B2E0 File Offset: 0x000694E0
		[Token(Token = "0x60116D1")]
		[Address(RVA = "0x937E80", Offset = "0x936A80", VA = "0x180937E80")]
		private int <>xLuaBaseProxy_get_priorityQueue()
		{
			return 0;
		}

		// Token: 0x0401377B RID: 79739
		[Token(Token = "0x401377B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_priorityQueue;

		// Token: 0x0401377C RID: 79740
		[Token(Token = "0x401377C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoPreprocessEnemy;

		// Token: 0x0401377D RID: 79741
		[Token(Token = "0x401377D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
