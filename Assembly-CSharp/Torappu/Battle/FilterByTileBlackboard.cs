using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002644 RID: 9796
	[Token(Token = "0x2002644")]
	[ExtraBuildConditionInfo(Category = "Common")]
	public class FilterByTileBlackboard : ExtraBuildConditionNode
	{
		// Token: 0x06010050 RID: 65616 RVA: 0x00061890 File Offset: 0x0005FA90
		[Token(Token = "0x6010050")]
		[Address(RVA = "0x77BF70", Offset = "0x77AB70", VA = "0x18077BF70", Slot = "4")]
		public override bool CheckBuildable(Tile tile, SharedConsts.Direction direction, bool spawnManually, bool overflowOccupiedCnt, BattleCharacterData sourceData, PlayerSide operationSide)
		{
			return default(bool);
		}

		// Token: 0x06010051 RID: 65617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010051")]
		[Address(RVA = "0x77C0B0", Offset = "0x77ACB0", VA = "0x18077C0B0")]
		public FilterByTileBlackboard()
		{
		}

		// Token: 0x04011CFD RID: 72957
		[Token(Token = "0x4011CFD")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _blackboardKey;

		// Token: 0x04011CFE RID: 72958
		[Token(Token = "0x4011CFE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _value;

		// Token: 0x04011CFF RID: 72959
		[Token(Token = "0x4011CFF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckBuildable;

		// Token: 0x04011D00 RID: 72960
		[Token(Token = "0x4011D00")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
