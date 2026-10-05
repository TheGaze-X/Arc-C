using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002643 RID: 9795
	[Token(Token = "0x2002643")]
	[Serializable]
	public abstract class ExtraBuildConditionNode : IHotfixable
	{
		// Token: 0x0601004E RID: 65614
		[Token(Token = "0x601004E")]
		public abstract bool CheckBuildable(Tile tile, SharedConsts.Direction direction, bool spawnManually, bool overflowOccupiedCnt, BattleCharacterData sourceData, PlayerSide operationSide);

		// Token: 0x0601004F RID: 65615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601004F")]
		[Address(RVA = "0x77BF10", Offset = "0x77AB10", VA = "0x18077BF10")]
		protected ExtraBuildConditionNode()
		{
		}

		// Token: 0x04011CFC RID: 72956
		[Token(Token = "0x4011CFC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
