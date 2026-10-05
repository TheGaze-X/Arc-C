using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x02002906 RID: 10502
	[Token(Token = "0x2002906")]
	public class ELifeReduceAdd : BasicEnemyRune
	{
		// Token: 0x17002685 RID: 9861
		// (get) Token: 0x060116D2 RID: 71378 RVA: 0x0006B2F8 File Offset: 0x000694F8
		[Token(Token = "0x17002685")]
		public override int priorityQueue
		{
			[Token(Token = "0x60116D2")]
			[Address(RVA = "0x93B650", Offset = "0x93A250", VA = "0x18093B650", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060116D3 RID: 71379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116D3")]
		[Address(RVA = "0x93B4E0", Offset = "0x93A0E0", VA = "0x18093B4E0", Slot = "17")]
		protected override void DoPreprocessEnemy(LevelData.EnemyData data, Enemy enemy)
		{
		}

		// Token: 0x060116D4 RID: 71380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116D4")]
		[Address(RVA = "0x93B5B0", Offset = "0x93A1B0", VA = "0x18093B5B0")]
		public ELifeReduceAdd()
		{
		}

		// Token: 0x060116D5 RID: 71381 RVA: 0x0006B310 File Offset: 0x00069510
		[Token(Token = "0x60116D5")]
		[Address(RVA = "0x937E80", Offset = "0x936A80", VA = "0x180937E80")]
		private int <>xLuaBaseProxy_get_priorityQueue()
		{
			return 0;
		}

		// Token: 0x0401377E RID: 79742
		[Token(Token = "0x401377E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_priorityQueue;

		// Token: 0x0401377F RID: 79743
		[Token(Token = "0x401377F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoPreprocessEnemy;

		// Token: 0x04013780 RID: 79744
		[Token(Token = "0x4013780")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
