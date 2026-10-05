using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x02002903 RID: 10499
	[Token(Token = "0x2002903")]
	public class ETalentBlackboardMul : BasicEnemyRune
	{
		// Token: 0x17002683 RID: 9859
		// (get) Token: 0x060116C8 RID: 71368 RVA: 0x0006B298 File Offset: 0x00069498
		[Token(Token = "0x17002683")]
		public override int priorityQueue
		{
			[Token(Token = "0x60116C8")]
			[Address(RVA = "0x93C9B0", Offset = "0x93B5B0", VA = "0x18093C9B0", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060116C9 RID: 71369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116C9")]
		[Address(RVA = "0x93C870", Offset = "0x93B470", VA = "0x18093C870", Slot = "17")]
		protected override void DoPreprocessEnemy(LevelData.EnemyData data, Enemy enemy)
		{
		}

		// Token: 0x060116CA RID: 71370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116CA")]
		[Address(RVA = "0x93C910", Offset = "0x93B510", VA = "0x18093C910")]
		public ETalentBlackboardMul()
		{
		}

		// Token: 0x060116CB RID: 71371 RVA: 0x0006B2B0 File Offset: 0x000694B0
		[Token(Token = "0x60116CB")]
		[Address(RVA = "0x937E80", Offset = "0x936A80", VA = "0x180937E80")]
		private int <>xLuaBaseProxy_get_priorityQueue()
		{
			return 0;
		}

		// Token: 0x04013776 RID: 79734
		[Token(Token = "0x4013776")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_priorityQueue;

		// Token: 0x04013777 RID: 79735
		[Token(Token = "0x4013777")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoPreprocessEnemy;

		// Token: 0x04013778 RID: 79736
		[Token(Token = "0x4013778")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
