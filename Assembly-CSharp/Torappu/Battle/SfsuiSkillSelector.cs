using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200253B RID: 9531
	[Token(Token = "0x200253B")]
	public class SfsuiSkillSelector : AdvancedSelector
	{
		// Token: 0x1700202D RID: 8237
		// (get) Token: 0x0600F5DD RID: 62941 RVA: 0x0005B680 File Offset: 0x00059880
		[Token(Token = "0x1700202D")]
		private bool IsNoSpecificBuffFilter
		{
			[Token(Token = "0x600F5DD")]
			[Address(RVA = "0x6DD790", Offset = "0x6DC390", VA = "0x1806DD790")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700202E RID: 8238
		// (get) Token: 0x0600F5DE RID: 62942 RVA: 0x0005B698 File Offset: 0x00059898
		[Token(Token = "0x1700202E")]
		private bool IsDistRelatedFilter
		{
			[Token(Token = "0x600F5DE")]
			[Address(RVA = "0x6DD6E0", Offset = "0x6DC2E0", VA = "0x1806DD6E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700202F RID: 8239
		// (get) Token: 0x0600F5DF RID: 62943 RVA: 0x0005B6B0 File Offset: 0x000598B0
		[Token(Token = "0x1700202F")]
		private bool IsAllRightTilesToFirstTargetFilter
		{
			[Token(Token = "0x600F5DF")]
			[Address(RVA = "0x6DD680", Offset = "0x6DC280", VA = "0x1806DD680")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F5E0 RID: 62944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5E0")]
		[Address(RVA = "0x6DC730", Offset = "0x6DB330", VA = "0x1806DC730", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F5E1 RID: 62945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F5E1")]
		[Address(RVA = "0x6DC050", Offset = "0x6DAC50", VA = "0x1806DC050", Slot = "20")]
		public override List<Tile> FindTiles(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F5E2 RID: 62946 RVA: 0x0005B6C8 File Offset: 0x000598C8
		[Token(Token = "0x600F5E2")]
		[Address(RVA = "0x6DD160", Offset = "0x6DBD60", VA = "0x1806DD160")]
		private bool _Filter_RowDistToPosDec(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F5E3 RID: 62947 RVA: 0x0005B6E0 File Offset: 0x000598E0
		[Token(Token = "0x600F5E3")]
		[Address(RVA = "0x6DC930", Offset = "0x6DB530", VA = "0x1806DC930")]
		private bool _Filter_DistToPosDec(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F5E4 RID: 62948 RVA: 0x0005B6F8 File Offset: 0x000598F8
		[Token(Token = "0x600F5E4")]
		[Address(RVA = "0x6DCD30", Offset = "0x6DB930", VA = "0x1806DCD30")]
		private bool _Filter_NoSpecificBuffFirst(Entity candidate, Entity source, out FP weight, out FP priorWeight)
		{
			return default(bool);
		}

		// Token: 0x0600F5E5 RID: 62949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5E5")]
		[Address(RVA = "0x6DD550", Offset = "0x6DC150", VA = "0x1806DD550")]
		public SfsuiSkillSelector()
		{
		}

		// Token: 0x0600F5E6 RID: 62950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5E6")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x0600F5E7 RID: 62951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F5E7")]
		[Address(RVA = "0x69B0B0", Offset = "0x699CB0", VA = "0x18069B0B0")]
		private List<Tile> <>xLuaBaseProxy_FindTiles(Vector2 P0)
		{
			return null;
		}

		// Token: 0x040110A6 RID: 69798
		[Token(Token = "0x40110A6")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private SfsuiSkillSelector.SfsuiSkillFilterType _filter;

		// Token: 0x040110A7 RID: 69799
		[Token(Token = "0x40110A7")]
		[FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private BuildableType _specificBuildableTypeFirst;

		// Token: 0x040110A8 RID: 69800
		[Token(Token = "0x40110A8")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Inspect("IsDistRelatedFilter")]
		private Vector2 _posOffset;

		// Token: 0x040110A9 RID: 69801
		[Token(Token = "0x40110A9")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Inspect("IsNoSpecificBuffFilter")]
		private string _buffKey;

		// Token: 0x040110AA RID: 69802
		[Token(Token = "0x40110AA")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Inspect("IsAllRightTilesToFirstTargetFilter")]
		private int _rowCount;

		// Token: 0x040110AB RID: 69803
		[Token(Token = "0x40110AB")]
		[FieldOffset(Offset = "0x110")]
		private List<Tile> m_castTiles;

		// Token: 0x040110AC RID: 69804
		[Token(Token = "0x40110AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_IsNoSpecificBuffFilter;

		// Token: 0x040110AD RID: 69805
		[Token(Token = "0x40110AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_IsDistRelatedFilter;

		// Token: 0x040110AE RID: 69806
		[Token(Token = "0x40110AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_IsAllRightTilesToFirstTargetFilter;

		// Token: 0x040110AF RID: 69807
		[Token(Token = "0x40110AF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x040110B0 RID: 69808
		[Token(Token = "0x40110B0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_FindTiles;

		// Token: 0x040110B1 RID: 69809
		[Token(Token = "0x40110B1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__Filter_RowDistToPosDec;

		// Token: 0x040110B2 RID: 69810
		[Token(Token = "0x40110B2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__Filter_DistToPosDec;

		// Token: 0x040110B3 RID: 69811
		[Token(Token = "0x40110B3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__Filter_NoSpecificBuffFirst;

		// Token: 0x040110B4 RID: 69812
		[Token(Token = "0x40110B4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200253C RID: 9532
		[Token(Token = "0x200253C")]
		public enum SfsuiSkillFilterType
		{
			// Token: 0x040110B6 RID: 69814
			[Token(Token = "0x40110B6")]
			ROW_DIST_TO_POS_DEC,
			// Token: 0x040110B7 RID: 69815
			[Token(Token = "0x40110B7")]
			DIST_TO_POS_DEC,
			// Token: 0x040110B8 RID: 69816
			[Token(Token = "0x40110B8")]
			NO_SPECIFIC_BUFF_FIRST,
			// Token: 0x040110B9 RID: 69817
			[Token(Token = "0x40110B9")]
			RIGHT_LOWLAND_COL,
			// Token: 0x040110BA RID: 69818
			[Token(Token = "0x40110BA")]
			ALL_RIGHT_TILES_TO_FIRST_TARGET
		}
	}
}
