using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002645 RID: 9797
	[Token(Token = "0x2002645")]
	[ExtraBuildConditionInfo(Category = "Common/Overlap Character")]
	public class OverlapCharacterCondition : ExtraBuildConditionNode
	{
		// Token: 0x06010052 RID: 65618 RVA: 0x000618A8 File Offset: 0x0005FAA8
		[Token(Token = "0x6010052")]
		[Address(RVA = "0x782A40", Offset = "0x781640", VA = "0x180782A40", Slot = "4")]
		public override bool CheckBuildable(Tile tile, SharedConsts.Direction direction, bool spawnManually, bool overflowOccupiedCnt, BattleCharacterData sourceData, PlayerSide operationSide)
		{
			return default(bool);
		}

		// Token: 0x06010053 RID: 65619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010053")]
		[Address(RVA = "0x782CE0", Offset = "0x7818E0", VA = "0x180782CE0")]
		public OverlapCharacterCondition()
		{
		}

		// Token: 0x04011D01 RID: 72961
		[Token(Token = "0x4011D01")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool _checkOverlapHost;

		// Token: 0x04011D02 RID: 72962
		[Token(Token = "0x4011D02")]
		[FieldOffset(Offset = "0x11")]
		[SerializeField]
		private bool _checkExcludeBuffKey;

		// Token: 0x04011D03 RID: 72963
		[Token(Token = "0x4011D03")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<string> _excludeBuffKeys;

		// Token: 0x04011D04 RID: 72964
		[Token(Token = "0x4011D04")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckBuildable;

		// Token: 0x04011D05 RID: 72965
		[Token(Token = "0x4011D05")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
