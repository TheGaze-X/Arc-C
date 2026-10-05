using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002647 RID: 9799
	[Token(Token = "0x2002647")]
	public class MlyssWtrmanCondition : ExtraBuildConditionNode
	{
		// Token: 0x06010056 RID: 65622 RVA: 0x000618D8 File Offset: 0x0005FAD8
		[Token(Token = "0x6010056")]
		[Address(RVA = "0x7800C0", Offset = "0x77ECC0", VA = "0x1807800C0", Slot = "4")]
		public override bool CheckBuildable(Tile tile, SharedConsts.Direction direction, bool spawnManually, bool overflowOccupiedCnt, BattleCharacterData sourceData, PlayerSide operationSide)
		{
			return default(bool);
		}

		// Token: 0x06010057 RID: 65623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010057")]
		[Address(RVA = "0x780220", Offset = "0x77EE20", VA = "0x180780220")]
		public MlyssWtrmanCondition()
		{
		}

		// Token: 0x04011D0E RID: 72974
		[Token(Token = "0x4011D0E")]
		[FieldOffset(Offset = "0x10")]
		private readonly string MLYSS_SKILL_BUFF_KEY;

		// Token: 0x04011D0F RID: 72975
		[Token(Token = "0x4011D0F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckBuildable;

		// Token: 0x04011D10 RID: 72976
		[Token(Token = "0x4011D10")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
