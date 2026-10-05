using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042E2 RID: 17122
	[Token(Token = "0x20042E2")]
	public class SandboxV2DungeonEnemyRushGroupViewModel : IHotfixable
	{
		// Token: 0x0601A547 RID: 107847 RVA: 0x000A14A8 File Offset: 0x0009F6A8
		[Token(Token = "0x601A547")]
		[Address(RVA = "0x132BCA0", Offset = "0x132A8A0", VA = "0x18132BCA0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0601A548 RID: 107848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A548")]
		[Address(RVA = "0x132BBA0", Offset = "0x132A7A0", VA = "0x18132BBA0")]
		public void Clear()
		{
		}

		// Token: 0x0601A549 RID: 107849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A549")]
		[Address(RVA = "0x132BA50", Offset = "0x132A650", VA = "0x18132BA50")]
		public void AddEnemyRush(SandboxV2DungeonEnemyRushViewModel enemyRush)
		{
		}

		// Token: 0x0601A54A RID: 107850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A54A")]
		[Address(RVA = "0x132BD20", Offset = "0x132A920", VA = "0x18132BD20")]
		public SandboxV2DungeonEnemyRushGroupViewModel()
		{
		}

		// Token: 0x0402162E RID: 136750
		[Token(Token = "0x402162E")]
		[FieldOffset(Offset = "0x10")]
		public List<SandboxV2DungeonEnemyRushViewModel> enemyRushList;

		// Token: 0x0402162F RID: 136751
		[Token(Token = "0x402162F")]
		[FieldOffset(Offset = "0x18")]
		public int enemyRushStackCount;

		// Token: 0x04021630 RID: 136752
		[Token(Token = "0x4021630")]
		[FieldOffset(Offset = "0x1C")]
		public float enemyRushRatio;

		// Token: 0x04021631 RID: 136753
		[Token(Token = "0x4021631")]
		[FieldOffset(Offset = "0x20")]
		public SandboxV2DungeonProgressViewModel enemyRushProgressModel;

		// Token: 0x04021632 RID: 136754
		[Token(Token = "0x4021632")]
		[FieldOffset(Offset = "0x30")]
		public ListDict<string, SandboxV2DropDetail> enemyRushGroupDrop;

		// Token: 0x04021633 RID: 136755
		[Token(Token = "0x4021633")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x04021634 RID: 136756
		[Token(Token = "0x4021634")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x04021635 RID: 136757
		[Token(Token = "0x4021635")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AddEnemyRush;

		// Token: 0x04021636 RID: 136758
		[Token(Token = "0x4021636")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
