using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.GameMode
{
	// Token: 0x02002803 RID: 10243
	[Token(Token = "0x2002803")]
	[ExtraBuildConditionInfo(Category = "AutoChess")]
	public class AutoChessEquipBuildBaseCondition : ExtraBuildConditionNode
	{
		// Token: 0x06011096 RID: 69782 RVA: 0x00068DF0 File Offset: 0x00066FF0
		[Token(Token = "0x6011096")]
		[Address(RVA = "0x8E8560", Offset = "0x8E7160", VA = "0x1808E8560", Slot = "4")]
		public override bool CheckBuildable(Tile tile, SharedConsts.Direction direction, bool spawnManually, bool overflowOccupiedCnt, BattleCharacterData sourceData, PlayerSide operationSide)
		{
			return default(bool);
		}

		// Token: 0x06011097 RID: 69783 RVA: 0x00068E08 File Offset: 0x00067008
		[Token(Token = "0x6011097")]
		[Address(RVA = "0x8E8B20", Offset = "0x8E7720", VA = "0x1808E8B20")]
		private bool _CheckTargetNotDIY(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x06011098 RID: 69784 RVA: 0x00068E20 File Offset: 0x00067020
		[Token(Token = "0x6011098")]
		[Address(RVA = "0x8E8C80", Offset = "0x8E7880", VA = "0x1808E8C80")]
		private bool _CheckTargetNotGold(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x06011099 RID: 69785 RVA: 0x00068E38 File Offset: 0x00067038
		[Token(Token = "0x6011099")]
		[Address(RVA = "0x8E87D0", Offset = "0x8E73D0", VA = "0x1808E87D0")]
		private bool _CheckTargetChessLevel(Tile tile, int chessLevelToCompare)
		{
			return default(bool);
		}

		// Token: 0x0601109A RID: 69786 RVA: 0x00068E50 File Offset: 0x00067050
		[Token(Token = "0x601109A")]
		[Address(RVA = "0x8E8950", Offset = "0x8E7550", VA = "0x1808E8950")]
		private bool _CheckTargetGroupId(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0601109B RID: 69787 RVA: 0x00068E68 File Offset: 0x00067068
		[Token(Token = "0x601109B")]
		[Address(RVA = "0x8E8DE0", Offset = "0x8E79E0", VA = "0x1808E8DE0")]
		private bool _CheckTargetProfession(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0601109C RID: 69788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601109C")]
		[Address(RVA = "0x8E8F00", Offset = "0x8E7B00", VA = "0x1808E8F00")]
		public AutoChessEquipBuildBaseCondition()
		{
		}

		// Token: 0x04013114 RID: 78100
		[Token(Token = "0x4013114")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private AutoChessEquipBuildBaseCondition.ExtraBuildCondition[] _extraConditions;

		// Token: 0x04013115 RID: 78101
		[Token(Token = "0x4013115")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _chessLevelToCompare;

		// Token: 0x04013116 RID: 78102
		[Token(Token = "0x4013116")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private CompareType _condType;

		// Token: 0x04013117 RID: 78103
		[Token(Token = "0x4013117")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _filterGroupId;

		// Token: 0x04013118 RID: 78104
		[Token(Token = "0x4013118")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Enum(true, EnumDisplay.Checkbox)]
		private ProfessionCategory _professionCategoryMask;

		// Token: 0x04013119 RID: 78105
		[Token(Token = "0x4013119")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckBuildable;

		// Token: 0x0401311A RID: 78106
		[Token(Token = "0x401311A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CheckTargetNotDIY;

		// Token: 0x0401311B RID: 78107
		[Token(Token = "0x401311B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckTargetNotGold;

		// Token: 0x0401311C RID: 78108
		[Token(Token = "0x401311C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckTargetChessLevel;

		// Token: 0x0401311D RID: 78109
		[Token(Token = "0x401311D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckTargetGroupId;

		// Token: 0x0401311E RID: 78110
		[Token(Token = "0x401311E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckTargetProfession;

		// Token: 0x0401311F RID: 78111
		[Token(Token = "0x401311F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002804 RID: 10244
		[Token(Token = "0x2002804")]
		private enum ExtraBuildCondition
		{
			// Token: 0x04013121 RID: 78113
			[Token(Token = "0x4013121")]
			DEFAULT,
			// Token: 0x04013122 RID: 78114
			[Token(Token = "0x4013122")]
			CHECK_TARGET_VALID_SHOP_LEVEL,
			// Token: 0x04013123 RID: 78115
			[Token(Token = "0x4013123")]
			CHECK_TARGET_NOT_GOLD,
			// Token: 0x04013124 RID: 78116
			[Token(Token = "0x4013124")]
			CHECK_TARGET_CHESS_LEVEL,
			// Token: 0x04013125 RID: 78117
			[Token(Token = "0x4013125")]
			CHECK_TARGET_GROUP_ID,
			// Token: 0x04013126 RID: 78118
			[Token(Token = "0x4013126")]
			CHECK_TARGET_PROFESSION,
			// Token: 0x04013127 RID: 78119
			[Token(Token = "0x4013127")]
			CHECK_TARGET_NOT_DIY
		}
	}
}
