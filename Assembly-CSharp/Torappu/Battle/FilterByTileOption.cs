using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002646 RID: 9798
	[Token(Token = "0x2002646")]
	[ExtraBuildConditionInfo(Category = "Common")]
	public class FilterByTileOption : ExtraBuildConditionNode
	{
		// Token: 0x06010054 RID: 65620 RVA: 0x000618C0 File Offset: 0x0005FAC0
		[Token(Token = "0x6010054")]
		[Address(RVA = "0x77C170", Offset = "0x77AD70", VA = "0x18077C170", Slot = "4")]
		public override bool CheckBuildable(Tile tile, SharedConsts.Direction direction, bool spawnManually, bool overflowOccupiedCnt, BattleCharacterData sourceData, PlayerSide operationSide)
		{
			return default(bool);
		}

		// Token: 0x06010055 RID: 65621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010055")]
		[Address(RVA = "0x77C2C0", Offset = "0x77AEC0", VA = "0x18077C2C0")]
		public FilterByTileOption()
		{
		}

		// Token: 0x04011D06 RID: 72966
		[Token(Token = "0x4011D06")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool _checkPassableMask;

		// Token: 0x04011D07 RID: 72967
		[Token(Token = "0x4011D07")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private MotionMask _passableMask;

		// Token: 0x04011D08 RID: 72968
		[Token(Token = "0x4011D08")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _checkBuildableType;

		// Token: 0x04011D09 RID: 72969
		[Token(Token = "0x4011D09")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private BuildableType _buildableType;

		// Token: 0x04011D0A RID: 72970
		[Token(Token = "0x4011D0A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _checkBuildableMask;

		// Token: 0x04011D0B RID: 72971
		[Token(Token = "0x4011D0B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private AdvancedBuildableMask _advancedBuildableMask;

		// Token: 0x04011D0C RID: 72972
		[Token(Token = "0x4011D0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckBuildable;

		// Token: 0x04011D0D RID: 72973
		[Token(Token = "0x4011D0D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
