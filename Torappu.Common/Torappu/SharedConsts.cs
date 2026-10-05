using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	public static class SharedConsts
	{
		// Token: 0x06000148 RID: 328 RVA: 0x00002A14 File Offset: 0x00000C14
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x54ECD60", Offset = "0x54EB960", VA = "0x1854ECD60")]
		public static bool CheckDirectionValid(SharedConsts.Direction direction)
		{
			return default(bool);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002A2C File Offset: 0x00000C2C
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x54ECD90", Offset = "0x54EB990", VA = "0x1854ECD90")]
		public static SharedConsts.LeftOrRight Opposite(SharedConsts.LeftOrRight side)
		{
			return SharedConsts.LeftOrRight.LEFT;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002A44 File Offset: 0x00000C44
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x54ECDA0", Offset = "0x54EB9A0", VA = "0x1854ECDA0")]
		public static SharedConsts.Direction Opposite(SharedConsts.Direction dir)
		{
			return SharedConsts.Direction.UP;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002A5C File Offset: 0x00000C5C
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x54ECD70", Offset = "0x54EB970", VA = "0x1854ECD70")]
		public static SharedConsts.Direction OppositeLR(SharedConsts.Direction dir)
		{
			return SharedConsts.Direction.UP;
		}

		// Token: 0x0400029B RID: 667
		[Token(Token = "0x400029B")]
		public const int ATTRIBUTES_NUM = 36;

		// Token: 0x0400029C RID: 668
		[Token(Token = "0x400029C")]
		public const int ABNORMAL_FLAGS_NUM = 44;

		// Token: 0x0400029D RID: 669
		[Token(Token = "0x400029D")]
		public const int ABNORMAL_COMBO_NUM = 2;

		// Token: 0x0400029E RID: 670
		[Token(Token = "0x400029E")]
		public const int MOTION_MODE_NUM = 2;

		// Token: 0x0400029F RID: 671
		[Token(Token = "0x400029F")]
		public const int DYNAMIC_CONDITION_NUM = 2;

		// Token: 0x040002A0 RID: 672
		[Token(Token = "0x40002A0")]
		public const int MAX_MAIN_SKILL_LEVEL = 7;

		// Token: 0x040002A1 RID: 673
		[Token(Token = "0x40002A1")]
		public const int MAX_SPECIALIZE_SKILL_LEVEL = 3;

		// Token: 0x040002A2 RID: 674
		[Token(Token = "0x40002A2")]
		public const int INITIAL_MAIN_SKILL_LEVEL = 1;

		// Token: 0x040002A3 RID: 675
		[Token(Token = "0x40002A3")]
		public const bool ASSIST_CHAR_CLAMP_FLAG = false;

		// Token: 0x040002A4 RID: 676
		[Token(Token = "0x40002A4")]
		public const int MAX_POTENTIAL_RANK = 5;

		// Token: 0x040002A5 RID: 677
		[Token(Token = "0x40002A5")]
		public const int GAME_DAY_DIVISION_HOUR = 4;

		// Token: 0x040002A6 RID: 678
		[Token(Token = "0x40002A6")]
		public const string EMPTY_BUFF_TEMPLATE_KEY = "empty";

		// Token: 0x040002A7 RID: 679
		[Token(Token = "0x40002A7")]
		public const string PALSY_BUFF_KEY = "palsy[stack]";

		// Token: 0x040002A8 RID: 680
		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string[] SPAWN_ON_TILE_BLACKLIST;

		// Token: 0x040002A9 RID: 681
		[Token(Token = "0x40002A9")]
		public const string EMPTY_TILE_KEY = "tile_empty";

		// Token: 0x040002AA RID: 682
		[Token(Token = "0x40002AA")]
		public const string TILE_START = "tile_start";

		// Token: 0x040002AB RID: 683
		[Token(Token = "0x40002AB")]
		public const string TILE_START_FLY = "tile_flystart";

		// Token: 0x040002AC RID: 684
		[Token(Token = "0x40002AC")]
		public const string TILE_END = "tile_end";

		// Token: 0x040002AD RID: 685
		[Token(Token = "0x40002AD")]
		public const string TILE_TELIN = "tile_telin";

		// Token: 0x040002AE RID: 686
		[Token(Token = "0x40002AE")]
		public const string TILE_TELOUT = "tile_telout";

		// Token: 0x040002AF RID: 687
		[Token(Token = "0x40002AF")]
		public const string TILE_HOLE = "tile_hole";

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		public const string TILE_FORBIDDEN = "tile_forbidden";

		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x40002B1")]
		public const string TILE_WALL = "tile_wall";

		// Token: 0x040002B2 RID: 690
		[Token(Token = "0x40002B2")]
		public const string TILE_ROAD = "tile_road";

		// Token: 0x040002B3 RID: 691
		[Token(Token = "0x40002B3")]
		public const string TILE_ALLY_GOAL_KEY = "tile_allygoal";

		// Token: 0x040002B4 RID: 692
		[Token(Token = "0x40002B4")]
		public const string TILE_ENEMY_GOAL_KEY = "tile_enemygoal";

		// Token: 0x040002B5 RID: 693
		[Token(Token = "0x40002B5")]
		public const float MIN_ONE_MINUS_STATUS_RESISTANCE = 0.001f;

		// Token: 0x040002B6 RID: 694
		[Token(Token = "0x40002B6")]
		public const float MAX_ONE_MINUS_STATUS_RESISTANCE = 1000f;

		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x40002B7")]
		public const int MAX_UNIEQUIP_LEVEL = 3;

		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x40002B8")]
		public const int INITIAL_UNIEQUIP_LEVEL = 1;

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		public const string DEFAULT_SKIN = "DefaultSkin";

		// Token: 0x040002BA RID: 698
		[Token(Token = "0x40002BA")]
		public const string VIDEO_FILE_EXT = ".mp4";

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x40002BB")]
		public const int INITIAL_MASTER_LEVEL = 1;

		// Token: 0x040002BC RID: 700
		[Token(Token = "0x40002BC")]
		public const int DIRECTIONS_NUM = 4;

		// Token: 0x040002BD RID: 701
		[Token(Token = "0x40002BD")]
		public const int EIGHT_DIRECTIONS_NUM = 8;

		// Token: 0x040002BE RID: 702
		[Token(Token = "0x40002BE")]
		public const int ALL_DIRECTION_PASSABLE_MASK = 15;

		// Token: 0x040002BF RID: 703
		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x8")]
		public static readonly SharedConsts.Direction[] REVERSE_FOUR_WAYS;

		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Vector2 LEFT;

		// Token: 0x040002C1 RID: 705
		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x18")]
		public static readonly Vector2 RIGHT;

		// Token: 0x040002C2 RID: 706
		[Token(Token = "0x40002C2")]
		[FieldOffset(Offset = "0x20")]
		public static readonly Vector2 UP;

		// Token: 0x040002C3 RID: 707
		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0x28")]
		public static readonly Vector2 DOWN;

		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x30")]
		public static readonly Vector2 UP_LEFT;

		// Token: 0x040002C5 RID: 709
		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0x38")]
		public static readonly Vector2 UP_RIGHT;

		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x40")]
		public static readonly Vector2 DOWN_LEFT;

		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x48")]
		public static readonly Vector2 DOWN_RIGHT;

		// Token: 0x040002C8 RID: 712
		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x50")]
		public static readonly Vector2[] FOUR_WAYS;

		// Token: 0x040002C9 RID: 713
		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x58")]
		public static readonly Vector2[] FOUR_DIAGONAL_WAYS;

		// Token: 0x040002CA RID: 714
		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x60")]
		public static readonly Vector2[] EIGHT_WAYS;

		// Token: 0x040002CB RID: 715
		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x68")]
		public static readonly int[] FOUR_ANGLE;

		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x70")]
		public static readonly Dictionary<string, SharedConsts.Direction> DIRECTION_DIC;

		// Token: 0x040002CD RID: 717
		[Token(Token = "0x40002CD")]
		public const int DEFAULT_CHARACTER_LIMIT = 99;

		// Token: 0x040002CE RID: 718
		[Token(Token = "0x40002CE")]
		public const int DEFAULT_MAX_LIFE_POINT = 15;

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		public const int DEFAULT_ENEMY_TAUNT_LEVEL_MUL = 1;

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		public const int DEFAULT_MAX_COST = 99;

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		public const int DEFAULT_INITIAL_COST = 3;

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		public const float DEFAULT_COST_INCREASE_TIME = 1f;

		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		public const float DEFAULT_MOVE_MULTIPLIER = 0.5f;

		// Token: 0x040002D4 RID: 724
		[Token(Token = "0x40002D4")]
		public const int DEFAULT_SP_RECOVERY_DELTA = 1;

		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		public const float DEFAULT_ATTACK_SPEED = 100f;

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x78")]
		public static readonly Color DEFAULT_UNIT_COLOR;

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0x88")]
		public static readonly Color BUILDABLE_COLOR;

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x98")]
		public static readonly Color TRAP_TINT_COLOR;

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0xA8")]
		public static readonly Color EMISSION_COLOR;

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		public const SharedConsts.Direction DEFAULT_MAP_EFFECT_DIRECTION = SharedConsts.Direction.UP;

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		public const float BUFF_ESTIMATE_PRIORITY_OFFSET = 1000f;

		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40002DC")]
		public const string RELIC_STABLE_UNLOCK_GAIN_RES = "StableGainResource";

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		public const string RELIC_STABLE_UNLOCK_RECRUIT = "StableRecruitChar";

		// Token: 0x040002DE RID: 734
		[Token(Token = "0x40002DE")]
		public const string RELIC_STABLE_UNLOCK_UPGRADE = "StableUpgradeChar";

		// Token: 0x040002DF RID: 735
		[Token(Token = "0x40002DF")]
		public const string RELIC_STABLE_UNLOCK_INTO_NODE_NO_BATTLE = "StableIntoNodeNoBattle";

		// Token: 0x040002E0 RID: 736
		[Token(Token = "0x40002E0")]
		public const string RELIC_STABLE_UNLOCK_COMPLETE_BATTLE = "StableCompleteBattle";

		// Token: 0x040002E1 RID: 737
		[Token(Token = "0x40002E1")]
		public const string RELIC_STABLE_UNLOCK_COST_GOLD = "StableShopCostGold";

		// Token: 0x040002E2 RID: 738
		[Token(Token = "0x40002E2")]
		public const string RELIC_STABLE_UNLOCK_COST_HP = "StableCostHP";

		// Token: 0x040002E3 RID: 739
		[Token(Token = "0x40002E3")]
		public const string RELIC_STABLE_UNLOCK_SCENE_COUNT = "StableSceneCount";

		// Token: 0x040002E4 RID: 740
		[Token(Token = "0x40002E4")]
		public const string RELIC_STABLE_UNLOCK_ENEMY_KILL = "StableEnemyKillCount";

		// Token: 0x040002E5 RID: 741
		[Token(Token = "0x40002E5")]
		public const string RELIC_STABLE_UNLOCK_STABLE_CHOICE = "StableChoiceCount";

		// Token: 0x0200006D RID: 109
		[Token(Token = "0x200006D")]
		public enum LeftOrRight
		{
			// Token: 0x040002E7 RID: 743
			[Token(Token = "0x40002E7")]
			LEFT,
			// Token: 0x040002E8 RID: 744
			[Token(Token = "0x40002E8")]
			RIGHT
		}

		// Token: 0x0200006E RID: 110
		[Token(Token = "0x200006E")]
		public enum Direction
		{
			// Token: 0x040002EA RID: 746
			[Token(Token = "0x40002EA")]
			UP,
			// Token: 0x040002EB RID: 747
			[Token(Token = "0x40002EB")]
			RIGHT,
			// Token: 0x040002EC RID: 748
			[Token(Token = "0x40002EC")]
			DOWN,
			// Token: 0x040002ED RID: 749
			[Token(Token = "0x40002ED")]
			LEFT,
			// Token: 0x040002EE RID: 750
			[Token(Token = "0x40002EE")]
			E_NUM,
			// Token: 0x040002EF RID: 751
			[Token(Token = "0x40002EF")]
			INVALID = 4
		}

		// Token: 0x0200006F RID: 111
		[Token(Token = "0x200006F")]
		public enum EightWaysDirection
		{
			// Token: 0x040002F1 RID: 753
			[Token(Token = "0x40002F1")]
			UP,
			// Token: 0x040002F2 RID: 754
			[Token(Token = "0x40002F2")]
			UP_RIGHT,
			// Token: 0x040002F3 RID: 755
			[Token(Token = "0x40002F3")]
			RIGHT,
			// Token: 0x040002F4 RID: 756
			[Token(Token = "0x40002F4")]
			DOWN_RIGHT,
			// Token: 0x040002F5 RID: 757
			[Token(Token = "0x40002F5")]
			DOWN,
			// Token: 0x040002F6 RID: 758
			[Token(Token = "0x40002F6")]
			DOWN_LEFT,
			// Token: 0x040002F7 RID: 759
			[Token(Token = "0x40002F7")]
			LEFT,
			// Token: 0x040002F8 RID: 760
			[Token(Token = "0x40002F8")]
			UP_LEFT,
			// Token: 0x040002F9 RID: 761
			[Token(Token = "0x40002F9")]
			E_NUM,
			// Token: 0x040002FA RID: 762
			[Token(Token = "0x40002FA")]
			INVALID = 8
		}
	}
}
