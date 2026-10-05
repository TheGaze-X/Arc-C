using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x02002901 RID: 10497
	[Token(Token = "0x2002901")]
	public class EAttackRangeMul : BasicEnemyRune
	{
		// Token: 0x17002682 RID: 9858
		// (get) Token: 0x060116C2 RID: 71362 RVA: 0x0006B268 File Offset: 0x00069468
		[Token(Token = "0x17002682")]
		public override int priorityQueue
		{
			[Token(Token = "0x60116C2")]
			[Address(RVA = "0x93AE30", Offset = "0x939A30", VA = "0x18093AE30", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060116C3 RID: 71363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116C3")]
		[Address(RVA = "0x93AC70", Offset = "0x939870", VA = "0x18093AC70", Slot = "17")]
		protected override void DoPreprocessEnemy(LevelData.EnemyData data, Enemy enemy)
		{
		}

		// Token: 0x060116C4 RID: 71364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116C4")]
		[Address(RVA = "0x93AD90", Offset = "0x939990", VA = "0x18093AD90")]
		public EAttackRangeMul()
		{
		}

		// Token: 0x060116C5 RID: 71365 RVA: 0x0006B280 File Offset: 0x00069480
		[Token(Token = "0x60116C5")]
		[Address(RVA = "0x937E80", Offset = "0x936A80", VA = "0x180937E80")]
		private int <>xLuaBaseProxy_get_priorityQueue()
		{
			return 0;
		}

		// Token: 0x04013771 RID: 79729
		[Token(Token = "0x4013771")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_priorityQueue;

		// Token: 0x04013772 RID: 79730
		[Token(Token = "0x4013772")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoPreprocessEnemy;

		// Token: 0x04013773 RID: 79731
		[Token(Token = "0x4013773")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
