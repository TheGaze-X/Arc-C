using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002378 RID: 9080
	[Token(Token = "0x2002378")]
	public class GridCursor : BasicCursor
	{
		// Token: 0x0600E64E RID: 58958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E64E")]
		[Address(RVA = "0x5C1250", Offset = "0x5BFE50", VA = "0x1805C1250")]
		public GridCursor(Route route, Scheduler.SchedulerSnapshot snapshot, Entity entity)
		{
		}

		// Token: 0x0600E64F RID: 58959 RVA: 0x00053BC8 File Offset: 0x00051DC8
		[Token(Token = "0x600E64F")]
		[Address(RVA = "0x5C0F90", Offset = "0x5BFB90", VA = "0x1805C0F90")]
		public bool CheckReached(GridPosition gridPos)
		{
			return default(bool);
		}

		// Token: 0x0600E650 RID: 58960 RVA: 0x00053BE0 File Offset: 0x00051DE0
		[Token(Token = "0x600E650")]
		[Address(RVA = "0x5C1050", Offset = "0x5BFC50", VA = "0x1805C1050")]
		public GridPosition GetNextGrid(GridPosition gridPos)
		{
			return default(GridPosition);
		}

		// Token: 0x0400FDD0 RID: 64976
		[Token(Token = "0x400FDD0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400FDD1 RID: 64977
		[Token(Token = "0x400FDD1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckReached;

		// Token: 0x0400FDD2 RID: 64978
		[Token(Token = "0x400FDD2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetNextGrid;
	}
}
