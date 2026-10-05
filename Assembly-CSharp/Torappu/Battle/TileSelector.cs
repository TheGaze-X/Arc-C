using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200254D RID: 9549
	[Token(Token = "0x200254D")]
	public class TileSelector : RangeSelector
	{
		// Token: 0x17002045 RID: 8261
		// (get) Token: 0x0600F668 RID: 63080 RVA: 0x0005BB30 File Offset: 0x00059D30
		[Token(Token = "0x17002045")]
		public bool limitTargetNum
		{
			[Token(Token = "0x600F668")]
			[Address(RVA = "0x6ED350", Offset = "0x6EBF50", VA = "0x1806ED350")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002046 RID: 8262
		// (get) Token: 0x0600F669 RID: 63081 RVA: 0x0005BB48 File Offset: 0x00059D48
		[Token(Token = "0x17002046")]
		protected bool isCertainTileKeyListPreferred
		{
			[Token(Token = "0x600F669")]
			[Address(RVA = "0x6ED160", Offset = "0x6EBD60", VA = "0x1806ED160")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002047 RID: 8263
		// (get) Token: 0x0600F66A RID: 63082 RVA: 0x0005BB60 File Offset: 0x00059D60
		[Token(Token = "0x17002047")]
		protected bool isFixedDistInFrontLineFallbackFarthest
		{
			[Token(Token = "0x600F66A")]
			[Address(RVA = "0x6ED2F0", Offset = "0x6EBEF0", VA = "0x1806ED2F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002048 RID: 8264
		// (get) Token: 0x0600F66B RID: 63083 RVA: 0x0005BB78 File Offset: 0x00059D78
		[Token(Token = "0x17002048")]
		protected bool isAct37SideEquip
		{
			[Token(Token = "0x600F66B")]
			[Address(RVA = "0x6ED100", Offset = "0x6EBD00", VA = "0x1806ED100")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002049 RID: 8265
		// (get) Token: 0x0600F66C RID: 63084 RVA: 0x0005BB90 File Offset: 0x00059D90
		[Token(Token = "0x17002049")]
		protected bool isEnemyWithBuff
		{
			[Token(Token = "0x600F66C")]
			[Address(RVA = "0x6ED1D0", Offset = "0x6EBDD0", VA = "0x1806ED1D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700204A RID: 8266
		// (get) Token: 0x0600F66D RID: 63085 RVA: 0x0005BBA8 File Offset: 0x00059DA8
		[Token(Token = "0x1700204A")]
		protected bool isFilterDistRandom
		{
			[Token(Token = "0x600F66D")]
			[Address(RVA = "0x6ED290", Offset = "0x6EBE90", VA = "0x1806ED290")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700204B RID: 8267
		// (get) Token: 0x0600F66E RID: 63086 RVA: 0x0005BBC0 File Offset: 0x00059DC0
		[Token(Token = "0x1700204B")]
		protected bool isEnemyWithCertainKey
		{
			[Token(Token = "0x600F66E")]
			[Address(RVA = "0x6ED230", Offset = "0x6EBE30", VA = "0x1806ED230")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700204C RID: 8268
		// (get) Token: 0x0600F66F RID: 63087 RVA: 0x0005BBD8 File Offset: 0x00059DD8
		[Token(Token = "0x1700204C")]
		protected virtual TileSelector.FilterType filterType
		{
			[Token(Token = "0x600F66F")]
			[Address(RVA = "0x6D4AB0", Offset = "0x6D36B0", VA = "0x1806D4AB0", Slot = "40")]
			get
			{
				return TileSelector.FilterType.ALL;
			}
		}

		// Token: 0x1700204D RID: 8269
		// (get) Token: 0x0600F670 RID: 63088 RVA: 0x0005BBF0 File Offset: 0x00059DF0
		// (set) Token: 0x0600F671 RID: 63089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700204D")]
		protected int maxTileNum
		{
			[Token(Token = "0x600F670")]
			[Address(RVA = "0x6ED3B0", Offset = "0x6EBFB0", VA = "0x1806ED3B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600F671")]
			[Address(RVA = "0x6ED4D0", Offset = "0x6EC0D0", VA = "0x1806ED4D0")]
			set
			{
			}
		}

		// Token: 0x1700204E RID: 8270
		// (get) Token: 0x0600F672 RID: 63090 RVA: 0x0005BC08 File Offset: 0x00059E08
		[Token(Token = "0x1700204E")]
		public override EntityCategory targetCategory
		{
			[Token(Token = "0x600F672")]
			[Address(RVA = "0x6D4B70", Offset = "0x6D3770", VA = "0x1806D4B70", Slot = "27")]
			get
			{
				return EntityCategory.NONE;
			}
		}

		// Token: 0x1700204F RID: 8271
		// (get) Token: 0x0600F673 RID: 63091 RVA: 0x0005BC20 File Offset: 0x00059E20
		[Token(Token = "0x1700204F")]
		public override MotionMask targetMotion
		{
			[Token(Token = "0x600F673")]
			[Address(RVA = "0x6ED410", Offset = "0x6EC010", VA = "0x1806ED410", Slot = "26")]
			get
			{
				return MotionMask.NONE;
			}
		}

		// Token: 0x17002050 RID: 8272
		// (get) Token: 0x0600F674 RID: 63092 RVA: 0x0005BC38 File Offset: 0x00059E38
		[Token(Token = "0x17002050")]
		public override SideType targetSide
		{
			[Token(Token = "0x600F674")]
			[Address(RVA = "0x6ED470", Offset = "0x6EC070", VA = "0x1806ED470", Slot = "25")]
			get
			{
				return SideType.NONE;
			}
		}

		// Token: 0x17002051 RID: 8273
		// (get) Token: 0x0600F675 RID: 63093 RVA: 0x0005BC50 File Offset: 0x00059E50
		[Token(Token = "0x17002051")]
		public override bool ignoreTargetFree
		{
			[Token(Token = "0x600F675")]
			[Address(RVA = "0x6D4B10", Offset = "0x6D3710", VA = "0x1806D4B10", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F676 RID: 63094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F676")]
		[Address(RVA = "0x6E1450", Offset = "0x6E0050", VA = "0x1806E1450", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F677 RID: 63095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F677")]
		[Address(RVA = "0x6E1570", Offset = "0x6E0170", VA = "0x1806E1570", Slot = "22")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0600F678 RID: 63096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F678")]
		[Address(RVA = "0x6E1350", Offset = "0x6DFF50", VA = "0x1806E1350", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F679 RID: 63097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F679")]
		[Address(RVA = "0x6E0F90", Offset = "0x6DFB90", VA = "0x1806E0F90", Slot = "38")]
		protected override void OnPostFilter(List<Tile> candidates)
		{
		}

		// Token: 0x0600F67A RID: 63098 RVA: 0x0005BC68 File Offset: 0x00059E68
		[Token(Token = "0x600F67A")]
		[Address(RVA = "0x6E2580", Offset = "0x6E1180", VA = "0x1806E2580", Slot = "17")]
		public override bool ValidateTile(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600F67B RID: 63099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F67B")]
		[Address(RVA = "0x6E3C30", Offset = "0x6E2830", VA = "0x1806E3C30", Slot = "41")]
		protected virtual void _DoFilter(List<Tile> candidates, TileSelector.FilterType tileFilterType)
		{
		}

		// Token: 0x0600F67C RID: 63100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F67C")]
		[Address(RVA = "0x6EB8F0", Offset = "0x6EA4F0", VA = "0x1806EB8F0")]
		private void _FilterDistRandom(List<Tile> candidates)
		{
		}

		// Token: 0x0600F67D RID: 63101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F67D")]
		[Address(RVA = "0x6EB5B0", Offset = "0x6EA1B0", VA = "0x1806EB5B0")]
		private void _ExcludeOwnerRootTile(ref List<Tile> candidates)
		{
		}

		// Token: 0x0600F67E RID: 63102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F67E")]
		[Address(RVA = "0x6EBC20", Offset = "0x6EA820", VA = "0x1806EBC20")]
		private Tile _GetNearestTile(Entity candidate, List<Tile> tiles)
		{
			return null;
		}

		// Token: 0x0600F67F RID: 63103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F67F")]
		[Address(RVA = "0x6E37A0", Offset = "0x6E23A0", VA = "0x1806E37A0")]
		private void _CollectSurroundTile(Tile keyPoint, List<Tile> tiles, List<Tile> result, float maxDistance)
		{
		}

		// Token: 0x0600F680 RID: 63104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F680")]
		[Address(RVA = "0x6E3A20", Offset = "0x6E2620", VA = "0x1806E3A20")]
		private void _CollectSurroundingTilesWithin3x3(Tile center, List<Tile> results)
		{
		}

		// Token: 0x0600F681 RID: 63105 RVA: 0x0005BC80 File Offset: 0x00059E80
		[Token(Token = "0x600F681")]
		[Address(RVA = "0x6E2AA0", Offset = "0x6E16A0", VA = "0x1806E2AA0")]
		private bool _CheckHatredEnemyOnTile(Tile tile, out FP weight)
		{
			return default(bool);
		}

		// Token: 0x0600F682 RID: 63106 RVA: 0x0005BC98 File Offset: 0x00059E98
		[Token(Token = "0x600F682")]
		[Address(RVA = "0x6E2E50", Offset = "0x6E1A50", VA = "0x1806E2E50")]
		private bool _CheckHatredEntityOnTile(Tile tile, out FP weight)
		{
			return default(bool);
		}

		// Token: 0x0600F683 RID: 63107 RVA: 0x0005BCB0 File Offset: 0x00059EB0
		[Token(Token = "0x600F683")]
		[Address(RVA = "0x6EB770", Offset = "0x6EA370", VA = "0x1806EB770")]
		private bool _FilterCharOnTileHatredDes(Tile tile, out FP weight)
		{
			return default(bool);
		}

		// Token: 0x0600F684 RID: 63108 RVA: 0x0005BCC8 File Offset: 0x00059EC8
		[Token(Token = "0x600F684")]
		[Address(RVA = "0x6E3470", Offset = "0x6E2070", VA = "0x1806E3470")]
		private bool _CheckMostCrowedThenHatredCharacterOnTile(Tile tile, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F685 RID: 63109 RVA: 0x0005BCE0 File Offset: 0x00059EE0
		[Token(Token = "0x600F685")]
		[Address(RVA = "0x6E3140", Offset = "0x6E1D40", VA = "0x1806E3140")]
		private bool _CheckLeastCrowedThenHatredCharacterOnTile(Tile tile, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F686 RID: 63110 RVA: 0x0005BCF8 File Offset: 0x00059EF8
		[Token(Token = "0x600F686")]
		[Address(RVA = "0x6E2820", Offset = "0x6E1420", VA = "0x1806E2820")]
		private bool _CheckCharacter(Character character)
		{
			return default(bool);
		}

		// Token: 0x0600F687 RID: 63111 RVA: 0x0005BD10 File Offset: 0x00059F10
		[Token(Token = "0x600F687")]
		[Address(RVA = "0x6E2500", Offset = "0x6E1100", VA = "0x1806E2500", Slot = "16")]
		protected override bool ValidateTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F688 RID: 63112 RVA: 0x0005BD28 File Offset: 0x00059F28
		[Token(Token = "0x600F688")]
		[Address(RVA = "0x6E0D70", Offset = "0x6DF970", VA = "0x1806E0D70")]
		protected bool CheckEnemies(DoubleBufferedList<ObjectPtr<Enemy>> enemies)
		{
			return default(bool);
		}

		// Token: 0x0600F689 RID: 63113 RVA: 0x0005BD40 File Offset: 0x00059F40
		[Token(Token = "0x600F689")]
		[Address(RVA = "0x6E2960", Offset = "0x6E1560", VA = "0x1806E2960")]
		private bool _CheckEntities(ReusableList<Entity> entities)
		{
			return default(bool);
		}

		// Token: 0x0600F68A RID: 63114 RVA: 0x0005BD58 File Offset: 0x00059F58
		[Token(Token = "0x600F68A")]
		[Address(RVA = "0x6E0AD0", Offset = "0x6DF6D0", VA = "0x1806E0AD0")]
		protected bool CheckEnemiesWithCertainKey(DoubleBufferedList<ObjectPtr<Enemy>> enemies)
		{
			return default(bool);
		}

		// Token: 0x0600F68B RID: 63115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F68B")]
		[Address(RVA = "0x6EC9C0", Offset = "0x6EB5C0", VA = "0x1806EC9C0")]
		private void _SortTiles(List<Tile> candidates)
		{
		}

		// Token: 0x0600F68C RID: 63116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F68C")]
		[Address(RVA = "0x6ECDE0", Offset = "0x6EB9E0", VA = "0x1806ECDE0")]
		private static void _StableRandomShuffle(List<Tile> list)
		{
		}

		// Token: 0x0600F68D RID: 63117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F68D")]
		[Address(RVA = "0x6EC780", Offset = "0x6EB380", VA = "0x1806EC780")]
		private void _SortTiles_ManhattanOwnerDirCenterPerfered(List<Tile> candidates)
		{
		}

		// Token: 0x0600F68E RID: 63118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F68E")]
		[Address(RVA = "0x6EC5C0", Offset = "0x6EB1C0", VA = "0x1806EC5C0")]
		private void _SortTiles_DistToOwnerAsc(List<Tile> candidates)
		{
		}

		// Token: 0x0600F68F RID: 63119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F68F")]
		[Address(RVA = "0x6EC4E0", Offset = "0x6EB0E0", VA = "0x1806EC4E0")]
		private void _SortTiles_DistToOwnerAscFixed(List<Tile> candidates)
		{
		}

		// Token: 0x0600F690 RID: 63120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F690")]
		[Address(RVA = "0x6EC370", Offset = "0x6EAF70", VA = "0x1806EC370")]
		private void _SortTiles_DistToMapCenterDes(List<Tile> candidates)
		{
		}

		// Token: 0x0600F691 RID: 63121 RVA: 0x0005BD70 File Offset: 0x00059F70
		[Token(Token = "0x600F691")]
		[Address(RVA = "0x6EBE70", Offset = "0x6EAA70", VA = "0x1806EBE70")]
		private int _GetTileClockWiseWeight(Tile tile)
		{
			return 0;
		}

		// Token: 0x0600F692 RID: 63122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F692")]
		[Address(RVA = "0x6EC140", Offset = "0x6EAD40", VA = "0x1806EC140")]
		private void _SortTiles_ClockwisePartRandom(List<Tile> candidates)
		{
		}

		// Token: 0x0600F693 RID: 63123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F693")]
		[Address(RVA = "0x6EC6A0", Offset = "0x6EB2A0", VA = "0x1806EC6A0")]
		private void _SortTiles_DistToOwnerDesStable(List<Tile> candidates)
		{
		}

		// Token: 0x0600F694 RID: 63124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F694")]
		[Address(RVA = "0x6EC290", Offset = "0x6EAE90", VA = "0x1806EC290")]
		private void _SortTiles_DistDesFrontFirst(List<Tile> candidate)
		{
		}

		// Token: 0x0600F695 RID: 63125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F695")]
		[Address(RVA = "0x6ECF70", Offset = "0x6EBB70", VA = "0x1806ECF70")]
		public TileSelector()
		{
		}

		// Token: 0x0600F69C RID: 63132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F69C")]
		[Address(RVA = "0x6A2DA0", Offset = "0x6A19A0", VA = "0x1806A2DA0")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0600F69D RID: 63133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F69D")]
		[Address(RVA = "0x6A2DB0", Offset = "0x6A19B0", VA = "0x1806A2DB0")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0600F69E RID: 63134 RVA: 0x0005BE18 File Offset: 0x0005A018
		[Token(Token = "0x600F69E")]
		[Address(RVA = "0x6E0530", Offset = "0x6DF130", VA = "0x1806E0530")]
		private bool <>xLuaBaseProxy_ValidateTile(Tile P0)
		{
			return default(bool);
		}

		// Token: 0x0600F69F RID: 63135 RVA: 0x0005BE30 File Offset: 0x0005A030
		[Token(Token = "0x600F69F")]
		[Address(RVA = "0x6A2DC0", Offset = "0x6A19C0", VA = "0x1806A2DC0")]
		private bool <>xLuaBaseProxy_ValidateTarget(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x04011161 RID: 69985
		[Token(Token = "0x4011161")]
		private const float MAX_SURROUND_DISTANCE = 1.5f;

		// Token: 0x04011162 RID: 69986
		[Token(Token = "0x4011162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		protected TileSelector.Options _options;

		// Token: 0x04011163 RID: 69987
		[Token(Token = "0x4011163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private TileSelector.FilterType _filterType;

		// Token: 0x04011164 RID: 69988
		[Token(Token = "0x4011164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[SerializeField]
		private bool _limitTargetNum;

		// Token: 0x04011165 RID: 69989
		[Token(Token = "0x4011165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Inspect("limitTargetNum")]
		private int _maxNum;

		// Token: 0x04011166 RID: 69990
		[Token(Token = "0x4011166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Inspect("isCertainTileKeyListPreferred")]
		private string[] _tileOrTokenIdListPreferred;

		// Token: 0x04011167 RID: 69991
		[Token(Token = "0x4011167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private TileSelector.TileSortType _tileSortType;

		// Token: 0x04011168 RID: 69992
		[Token(Token = "0x4011168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[SerializeField]
		[Group("Target")]
		private SideType _targetSide;

		// Token: 0x04011169 RID: 69993
		[Token(Token = "0x4011169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("Target")]
		private MotionMask _targetMotion;

		// Token: 0x0401116A RID: 69994
		[Token(Token = "0x401116A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[SerializeField]
		[Group("Target")]
		private EntityCategory _targetCategory;

		// Token: 0x0401116B RID: 69995
		[Token(Token = "0x401116B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("Target")]
		[Inspect("isCertainTileKeyListPreferred")]
		private bool _excludeAllCharacter;

		// Token: 0x0401116C RID: 69996
		[Token(Token = "0x401116C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x111")]
		[SerializeField]
		[Group("Target")]
		[Inspect("isCertainTileKeyListPreferred")]
		private bool _randomBeforeShrink;

		// Token: 0x0401116D RID: 69997
		[Token(Token = "0x401116D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[SerializeField]
		[Group("Target")]
		[Inspect("isFixedDistInFrontLineFallbackFarthest")]
		private int _fixedDistance;

		// Token: 0x0401116E RID: 69998
		[Token(Token = "0x401116E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Group("Target")]
		[Inspect("isAct37SideEquip")]
		private string _blackboardKey;

		// Token: 0x0401116F RID: 69999
		[Token(Token = "0x401116F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Group("Target")]
		[Inspect("isAct37SideEquip")]
		private string _chrBuffKey;

		// Token: 0x04011170 RID: 70000
		[Token(Token = "0x4011170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		[Group("Target")]
		[Inspect("isEnemyWithBuff")]
		private string _enemyBuffKey;

		// Token: 0x04011171 RID: 70001
		[Token(Token = "0x4011171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Group("Target")]
		[Inspect("isFilterDistRandom")]
		private int _distValue;

		// Token: 0x04011172 RID: 70002
		[Token(Token = "0x4011172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		[SerializeField]
		[Group("Target")]
		[Inspect("isFilterDistRandom")]
		private CompareType _distCompareType;

		// Token: 0x04011173 RID: 70003
		[Token(Token = "0x4011173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Group("Target")]
		[Inspect("isEnemyWithCertainKey")]
		private string[] _enemyKeys;

		// Token: 0x04011174 RID: 70004
		[Token(Token = "0x4011174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Group("Target")]
		private string[] _blackboardKeys;

		// Token: 0x04011175 RID: 70005
		[Token(Token = "0x4011175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		private bool _excludeCamouflagCharacter;

		// Token: 0x04011176 RID: 70006
		[Token(Token = "0x4011176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x149")]
		[SerializeField]
		private bool _alwaysSort;

		// Token: 0x04011177 RID: 70007
		[Token(Token = "0x4011177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14A")]
		[SerializeField]
		private bool _alwaysRandomInTheEnd;

		// Token: 0x04011178 RID: 70008
		[Token(Token = "0x4011178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14B")]
		[SerializeField]
		private bool _ignoreBlackList;

		// Token: 0x04011179 RID: 70009
		[Token(Token = "0x4011179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[SerializeField]
		private TileSelector.FilterType[] _extraFilterTypeList;

		// Token: 0x0401117A RID: 70010
		[Token(Token = "0x401117A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[SerializeField]
		private bool _ignoreHitRange;

		// Token: 0x0401117B RID: 70011
		[Token(Token = "0x401117B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x159")]
		[SerializeField]
		private bool _excludeOwnerRootTile;

		// Token: 0x0401117C RID: 70012
		[Token(Token = "0x401117C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		protected int m_maxTileNum;

		// Token: 0x0401117D RID: 70013
		[Token(Token = "0x401117D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private SideType m_sideType;

		// Token: 0x0401117E RID: 70014
		[Token(Token = "0x401117E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private readonly List<Tile> m_reusableTileList;

		// Token: 0x0401117F RID: 70015
		[Token(Token = "0x401117F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_limitTargetNum;

		// Token: 0x04011180 RID: 70016
		[Token(Token = "0x4011180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isCertainTileKeyListPreferred;

		// Token: 0x04011181 RID: 70017
		[Token(Token = "0x4011181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isFixedDistInFrontLineFallbackFarthest;

		// Token: 0x04011182 RID: 70018
		[Token(Token = "0x4011182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isAct37SideEquip;

		// Token: 0x04011183 RID: 70019
		[Token(Token = "0x4011183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isEnemyWithBuff;

		// Token: 0x04011184 RID: 70020
		[Token(Token = "0x4011184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isFilterDistRandom;

		// Token: 0x04011185 RID: 70021
		[Token(Token = "0x4011185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isEnemyWithCertainKey;

		// Token: 0x04011186 RID: 70022
		[Token(Token = "0x4011186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_filterType;

		// Token: 0x04011187 RID: 70023
		[Token(Token = "0x4011187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_maxTileNum;

		// Token: 0x04011188 RID: 70024
		[Token(Token = "0x4011188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_maxTileNum;

		// Token: 0x04011189 RID: 70025
		[Token(Token = "0x4011189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_targetCategory;

		// Token: 0x0401118A RID: 70026
		[Token(Token = "0x401118A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_targetMotion;

		// Token: 0x0401118B RID: 70027
		[Token(Token = "0x401118B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_targetSide;

		// Token: 0x0401118C RID: 70028
		[Token(Token = "0x401118C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_ignoreTargetFree;

		// Token: 0x0401118D RID: 70029
		[Token(Token = "0x401118D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0401118E RID: 70030
		[Token(Token = "0x401118E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401118F RID: 70031
		[Token(Token = "0x401118F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04011190 RID: 70032
		[Token(Token = "0x4011190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix1_OnPostFilter;

		// Token: 0x04011191 RID: 70033
		[Token(Token = "0x4011191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_ValidateTile;

		// Token: 0x04011192 RID: 70034
		[Token(Token = "0x4011192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__DoFilter;

		// Token: 0x04011193 RID: 70035
		[Token(Token = "0x4011193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__FilterDistRandom;

		// Token: 0x04011194 RID: 70036
		[Token(Token = "0x4011194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__ExcludeOwnerRootTile;

		// Token: 0x04011195 RID: 70037
		[Token(Token = "0x4011195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__GetNearestTile;

		// Token: 0x04011196 RID: 70038
		[Token(Token = "0x4011196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__CollectSurroundTile;

		// Token: 0x04011197 RID: 70039
		[Token(Token = "0x4011197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__CollectSurroundingTilesWithin3x3;

		// Token: 0x04011198 RID: 70040
		[Token(Token = "0x4011198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__CheckHatredEnemyOnTile;

		// Token: 0x04011199 RID: 70041
		[Token(Token = "0x4011199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__CheckHatredEntityOnTile;

		// Token: 0x0401119A RID: 70042
		[Token(Token = "0x401119A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__FilterCharOnTileHatredDes;

		// Token: 0x0401119B RID: 70043
		[Token(Token = "0x401119B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__CheckMostCrowedThenHatredCharacterOnTile;

		// Token: 0x0401119C RID: 70044
		[Token(Token = "0x401119C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__CheckLeastCrowedThenHatredCharacterOnTile;

		// Token: 0x0401119D RID: 70045
		[Token(Token = "0x401119D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__CheckCharacter;

		// Token: 0x0401119E RID: 70046
		[Token(Token = "0x401119E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_ValidateTarget;

		// Token: 0x0401119F RID: 70047
		[Token(Token = "0x401119F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_CheckEnemies;

		// Token: 0x040111A0 RID: 70048
		[Token(Token = "0x40111A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__CheckEntities;

		// Token: 0x040111A1 RID: 70049
		[Token(Token = "0x40111A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_CheckEnemiesWithCertainKey;

		// Token: 0x040111A2 RID: 70050
		[Token(Token = "0x40111A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__SortTiles;

		// Token: 0x040111A3 RID: 70051
		[Token(Token = "0x40111A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__StableRandomShuffle;

		// Token: 0x040111A4 RID: 70052
		[Token(Token = "0x40111A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__SortTiles_ManhattanOwnerDirCenterPerfered;

		// Token: 0x040111A5 RID: 70053
		[Token(Token = "0x40111A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__SortTiles_DistToOwnerAsc;

		// Token: 0x040111A6 RID: 70054
		[Token(Token = "0x40111A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__SortTiles_DistToOwnerAscFixed;

		// Token: 0x040111A7 RID: 70055
		[Token(Token = "0x40111A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__SortTiles_DistToMapCenterDes;

		// Token: 0x040111A8 RID: 70056
		[Token(Token = "0x40111A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__GetTileClockWiseWeight;

		// Token: 0x040111A9 RID: 70057
		[Token(Token = "0x40111A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__SortTiles_ClockwisePartRandom;

		// Token: 0x040111AA RID: 70058
		[Token(Token = "0x40111AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__SortTiles_DistToOwnerDesStable;

		// Token: 0x040111AB RID: 70059
		[Token(Token = "0x40111AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__SortTiles_DistDesFrontFirst;

		// Token: 0x040111AC RID: 70060
		[Token(Token = "0x40111AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200254E RID: 9550
		[Token(Token = "0x200254E")]
		public enum FilterType
		{
			// Token: 0x040111AE RID: 70062
			[Token(Token = "0x40111AE")]
			ALL,
			// Token: 0x040111AF RID: 70063
			[Token(Token = "0x40111AF")]
			ONLY_CHARACTER,
			// Token: 0x040111B0 RID: 70064
			[Token(Token = "0x40111B0")]
			EXCEPT_CHARACTER,
			// Token: 0x040111B1 RID: 70065
			[Token(Token = "0x40111B1")]
			BETTER_CHARACTER,
			// Token: 0x040111B2 RID: 70066
			[Token(Token = "0x40111B2")]
			ONLY_ENEMY,
			// Token: 0x040111B3 RID: 70067
			[Token(Token = "0x40111B3")]
			EXCEPT_ENEMY,
			// Token: 0x040111B4 RID: 70068
			[Token(Token = "0x40111B4")]
			BETTER_ENEMY,
			// Token: 0x040111B5 RID: 70069
			[Token(Token = "0x40111B5")]
			BETTER_ENEMY_WITH_COLLIDER,
			// Token: 0x040111B6 RID: 70070
			[Token(Token = "0x40111B6")]
			ONLY_CERTAIN_TILE_KEY,
			// Token: 0x040111B7 RID: 70071
			[Token(Token = "0x40111B7")]
			SURROUND_OWNER_RALLY_POINT,
			// Token: 0x040111B8 RID: 70072
			[Token(Token = "0x40111B8")]
			HATRED_ENTITY_WITH_COLLIDER_FALLBACK_OWNER,
			// Token: 0x040111B9 RID: 70073
			[Token(Token = "0x40111B9")]
			NEARL2_SKILL_3,
			// Token: 0x040111BA RID: 70074
			[Token(Token = "0x40111BA")]
			DIST_DES_IN_FRONT_LINE,
			// Token: 0x040111BB RID: 70075
			[Token(Token = "0x40111BB")]
			TILE_PROJECTILE_TRAP_VALID_AND_NO_CHARACTER,
			// Token: 0x040111BC RID: 70076
			[Token(Token = "0x40111BC")]
			ENEMY_MINIMA_S2,
			// Token: 0x040111BD RID: 70077
			[Token(Token = "0x40111BD")]
			ENEMY_MINIMA_S3,
			// Token: 0x040111BE RID: 70078
			[Token(Token = "0x40111BE")]
			NO_CHARACTER_AND_ENEMY,
			// Token: 0x040111BF RID: 70079
			[Token(Token = "0x40111BF")]
			DUSK_EQUIP_003,
			// Token: 0x040111C0 RID: 70080
			[Token(Token = "0x40111C0")]
			FIXED_DIST_IN_FRONT_LINE_FALLBACK_FARTHEST,
			// Token: 0x040111C1 RID: 70081
			[Token(Token = "0x40111C1")]
			NEAREST_TO_TRACETARGET,
			// Token: 0x040111C2 RID: 70082
			[Token(Token = "0x40111C2")]
			BETTER_ENEMY_REACHABLE,
			// Token: 0x040111C3 RID: 70083
			[Token(Token = "0x40111C3")]
			EXCEPT_BUILD_RANDOM,
			// Token: 0x040111C4 RID: 70084
			[Token(Token = "0x40111C4")]
			MLYSS_WTRMAN_SUMMON,
			// Token: 0x040111C5 RID: 70085
			[Token(Token = "0x40111C5")]
			RANDOM,
			// Token: 0x040111C6 RID: 70086
			[Token(Token = "0x40111C6")]
			HATRED_CHARACTER,
			// Token: 0x040111C7 RID: 70087
			[Token(Token = "0x40111C7")]
			SANDBOX_ANIMAL_REACHABLE,
			// Token: 0x040111C8 RID: 70088
			[Token(Token = "0x40111C8")]
			HATRED_CHARACTER_BLOCKED_FIRST,
			// Token: 0x040111C9 RID: 70089
			[Token(Token = "0x40111C9")]
			NO_CHARACTER_AND_NEAREST,
			// Token: 0x040111CA RID: 70090
			[Token(Token = "0x40111CA")]
			ULPIA_SKILL_3,
			// Token: 0x040111CB RID: 70091
			[Token(Token = "0x40111CB")]
			DIST_DES_FRONT_FIRST,
			// Token: 0x040111CC RID: 70092
			[Token(Token = "0x40111CC")]
			SANDBOX_ANIMAL_REACHABLE_SPECIAL,
			// Token: 0x040111CD RID: 70093
			[Token(Token = "0x40111CD")]
			SANDBOX_EXCEPT_HIDE_AREA,
			// Token: 0x040111CE RID: 70094
			[Token(Token = "0x40111CE")]
			ACT37SIDE_EQUIP,
			// Token: 0x040111CF RID: 70095
			[Token(Token = "0x40111CF")]
			ENEMY_WITH_BUFF,
			// Token: 0x040111D0 RID: 70096
			[Token(Token = "0x40111D0")]
			EXCLUDE_OWNER_ROOTTILE,
			// Token: 0x040111D1 RID: 70097
			[Token(Token = "0x40111D1")]
			FILTER_DIST_RANDOM,
			// Token: 0x040111D2 RID: 70098
			[Token(Token = "0x40111D2")]
			ANGEL2_S3,
			// Token: 0x040111D3 RID: 70099
			[Token(Token = "0x40111D3")]
			ANGEL2_S3_Linear,
			// Token: 0x040111D4 RID: 70100
			[Token(Token = "0x40111D4")]
			EXCEPT_ENEMY_WITH_CERTAIN_KEY,
			// Token: 0x040111D5 RID: 70101
			[Token(Token = "0x40111D5")]
			SURROUND_CHARACTER_FOUR_TILES,
			// Token: 0x040111D6 RID: 70102
			[Token(Token = "0x40111D6")]
			SURROUND_FOUR_TILES_EXCEPT_CHARACTER,
			// Token: 0x040111D7 RID: 70103
			[Token(Token = "0x40111D7")]
			TILE_PROJECTILE_TRAP_VALID_AND_CERTAIN_KEY,
			// Token: 0x040111D8 RID: 70104
			[Token(Token = "0x40111D8")]
			TILE_KEY_IN_TILE_KEY_PERFERED_LIST
		}

		// Token: 0x0200254F RID: 9551
		[Token(Token = "0x200254F")]
		[Serializable]
		public struct Options
		{
			// Token: 0x0600F6A0 RID: 63136 RVA: 0x0005BE48 File Offset: 0x0005A048
			[Token(Token = "0x600F6A0")]
			[Address(RVA = "0x711A70", Offset = "0x710670", VA = "0x180711A70")]
			public bool Verify(Tile tile)
			{
				return default(bool);
			}

			// Token: 0x0600F6A1 RID: 63137 RVA: 0x0005BE60 File Offset: 0x0005A060
			[Token(Token = "0x600F6A1")]
			[Address(RVA = "0x712020", Offset = "0x710C20", VA = "0x180712020")]
			private bool _CheckTileMode(Tile tile)
			{
				return default(bool);
			}

			// Token: 0x040111D9 RID: 70105
			[Token(Token = "0x40111D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[NonSerialized]
			public static readonly TileSelector.Options DEFAULT;

			// Token: 0x040111DA RID: 70106
			[Token(Token = "0x40111DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public BuildableType buildableType;

			// Token: 0x040111DB RID: 70107
			[Token(Token = "0x40111DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public bool allowNoneBuildableType;

			// Token: 0x040111DC RID: 70108
			[Token(Token = "0x40111DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public MotionMask passableMask;

			// Token: 0x040111DD RID: 70109
			[Token(Token = "0x40111DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool allowNonePassableMask;

			// Token: 0x040111DE RID: 70110
			[Token(Token = "0x40111DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool checkBuildableOrPassable;

			// Token: 0x040111DF RID: 70111
			[Token(Token = "0x40111DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool checkExtraBuildableCheckers;

			// Token: 0x040111E0 RID: 70112
			[Token(Token = "0x40111E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Enum(true, EnumDisplay.Checkbox)]
			public AdvancedBuildableMask advancedBuildableMask;

			// Token: 0x040111E1 RID: 70113
			[Token(Token = "0x40111E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool advancedBuildableMaskExcept;

			// Token: 0x040111E2 RID: 70114
			[Token(Token = "0x40111E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			public bool allowAllAdvancedBuildableMask;

			// Token: 0x040111E3 RID: 70115
			[Token(Token = "0x40111E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TileData.HeightType heightType;

			// Token: 0x040111E4 RID: 70116
			[Token(Token = "0x40111E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool checkHeightType;

			// Token: 0x040111E5 RID: 70117
			[Token(Token = "0x40111E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
			public bool checkTileMode;

			// Token: 0x040111E6 RID: 70118
			[Token(Token = "0x40111E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int modeIndex;

			// Token: 0x040111E7 RID: 70119
			[Token(Token = "0x40111E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool checkTileMoveCost;

			// Token: 0x040111E8 RID: 70120
			[Token(Token = "0x40111E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CompareType moveCostCompareType;

			// Token: 0x040111E9 RID: 70121
			[Token(Token = "0x40111E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int moveCostThreshold;

			// Token: 0x040111EA RID: 70122
			[Token(Token = "0x40111EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string allowedTileBlackboardKey;

			// Token: 0x040111EB RID: 70123
			[Token(Token = "0x40111EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string excludeTileBlackboardKey;

			// Token: 0x040111EC RID: 70124
			[Token(Token = "0x40111EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool checkTileTypes;

			// Token: 0x040111ED RID: 70125
			[Token(Token = "0x40111ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
			public bool exceptTileTypes;

			// Token: 0x040111EE RID: 70126
			[Token(Token = "0x40111EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[Enum(true, EnumDisplay.Checkbox)]
			public TileTypesMask tileTypesMask;
		}

		// Token: 0x02002550 RID: 9552
		[Token(Token = "0x2002550")]
		public enum TileSortType
		{
			// Token: 0x040111F0 RID: 70128
			[Token(Token = "0x40111F0")]
			DONT_SORT,
			// Token: 0x040111F1 RID: 70129
			[Token(Token = "0x40111F1")]
			DIST_TO_OWNER_ASC,
			// Token: 0x040111F2 RID: 70130
			[Token(Token = "0x40111F2")]
			DIST_TO_OWNER_ASC_FIXED,
			// Token: 0x040111F3 RID: 70131
			[Token(Token = "0x40111F3")]
			CLOCKWISE_PART_RANDOM,
			// Token: 0x040111F4 RID: 70132
			[Token(Token = "0x40111F4")]
			DIST_TO_MAP_CENTER_DES,
			// Token: 0x040111F5 RID: 70133
			[Token(Token = "0x40111F5")]
			MANHATTAN_OWNER_DIR_CENTER_PERFERED
		}
	}
}
