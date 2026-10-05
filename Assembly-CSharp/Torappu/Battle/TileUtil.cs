using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200265D RID: 9821
	[Token(Token = "0x200265D")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class TileUtil
	{
		// Token: 0x060100F8 RID: 65784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60100F8")]
		[Address(RVA = "0x7D3050", Offset = "0x7D1C50", VA = "0x1807D3050")]
		public static List<List<GridPosition>> GetConnectedRegions(bool[,] gridList)
		{
			return null;
		}

		// Token: 0x060100F9 RID: 65785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60100F9")]
		[Address(RVA = "0x7D2D80", Offset = "0x7D1980", VA = "0x1807D2D80")]
		private static void DFS(int c, int r, bool[,] gridList, bool[,] visited, List<GridPosition> region)
		{
		}

		// Token: 0x04011DBF RID: 73151
		[Token(Token = "0x4011DBF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetConnectedRegions;

		// Token: 0x04011DC0 RID: 73152
		[Token(Token = "0x4011DC0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DFS;
	}
}
