using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002546 RID: 9542
	[Token(Token = "0x2002546")]
	public class MostUnitSurroundTileSelector : TileSelector
	{
		// Token: 0x17002040 RID: 8256
		// (get) Token: 0x0600F63E RID: 63038 RVA: 0x0005BA58 File Offset: 0x00059C58
		[Token(Token = "0x17002040")]
		protected override TileSelector.FilterType filterType
		{
			[Token(Token = "0x600F63E")]
			[Address(RVA = "0x6D7C80", Offset = "0x6D6880", VA = "0x1806D7C80", Slot = "40")]
			get
			{
				return TileSelector.FilterType.ALL;
			}
		}

		// Token: 0x17002041 RID: 8257
		// (get) Token: 0x0600F63F RID: 63039 RVA: 0x0005BA70 File Offset: 0x00059C70
		[Token(Token = "0x17002041")]
		public override bool ignoreTargetFree
		{
			[Token(Token = "0x600F63F")]
			[Address(RVA = "0x6D7CE0", Offset = "0x6D68E0", VA = "0x1806D7CE0", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F640 RID: 63040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F640")]
		[Address(RVA = "0x6D6D80", Offset = "0x6D5980", VA = "0x1806D6D80", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F641 RID: 63041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F641")]
		[Address(RVA = "0x6D7850", Offset = "0x6D6450", VA = "0x1806D7850")]
		private void _Init()
		{
		}

		// Token: 0x0600F642 RID: 63042 RVA: 0x0005BA88 File Offset: 0x00059C88
		[Token(Token = "0x600F642")]
		[Address(RVA = "0x6D7A50", Offset = "0x6D6650", VA = "0x1806D7A50")]
		protected bool _VerifyUnit(Unit unit)
		{
			return default(bool);
		}

		// Token: 0x0600F643 RID: 63043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F643")]
		[Address(RVA = "0x6D6F40", Offset = "0x6D5B40", VA = "0x1806D6F40")]
		private void _CalculateTileWeight()
		{
		}

		// Token: 0x0600F644 RID: 63044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F644")]
		[Address(RVA = "0x6D7350", Offset = "0x6D5F50", VA = "0x1806D7350", Slot = "41")]
		protected override void _DoFilter(List<Tile> candidates, TileSelector.FilterType tileFilterType)
		{
		}

		// Token: 0x0600F645 RID: 63045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F645")]
		[Address(RVA = "0x6D7400", Offset = "0x6D6000", VA = "0x1806D7400")]
		private void _FilterWithWeight(List<Tile> candidates)
		{
		}

		// Token: 0x0600F646 RID: 63046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F646")]
		[Address(RVA = "0x6D7BA0", Offset = "0x6D67A0", VA = "0x1806D7BA0")]
		public MostUnitSurroundTileSelector()
		{
		}

		// Token: 0x0600F647 RID: 63047 RVA: 0x0005BAA0 File Offset: 0x00059CA0
		[Token(Token = "0x600F647")]
		[Address(RVA = "0x6D4AB0", Offset = "0x6D36B0", VA = "0x1806D4AB0")]
		private TileSelector.FilterType <>xLuaBaseProxy_get_filterType()
		{
			return TileSelector.FilterType.ALL;
		}

		// Token: 0x0600F648 RID: 63048 RVA: 0x0005BAB8 File Offset: 0x00059CB8
		[Token(Token = "0x600F648")]
		[Address(RVA = "0x6D4B10", Offset = "0x6D3710", VA = "0x1806D4B10")]
		private bool <>xLuaBaseProxy_get_ignoreTargetFree()
		{
			return default(bool);
		}

		// Token: 0x0600F649 RID: 63049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F649")]
		[Address(RVA = "0x6D3780", Offset = "0x6D2380", VA = "0x1806D3780")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0600F64A RID: 63050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F64A")]
		[Address(RVA = "0x6D37A0", Offset = "0x6D23A0", VA = "0x1806D37A0")]
		private void <>xLuaBaseProxy__DoFilter(List<Tile> P0, TileSelector.FilterType P1)
		{
		}

		// Token: 0x04011122 RID: 69922
		[Token(Token = "0x4011122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[SerializeField]
		[Group("Advanced")]
		private string _rootTileWeightBB;

		// Token: 0x04011123 RID: 69923
		[Token(Token = "0x4011123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[SerializeField]
		[Group("Advanced")]
		private string _surroundTileWeightBB;

		// Token: 0x04011124 RID: 69924
		[Token(Token = "0x4011124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[SerializeField]
		[Group("Advanced")]
		private bool _ignoreTargetFree;

		// Token: 0x04011125 RID: 69925
		[Token(Token = "0x4011125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		[SerializeField]
		[Group("Advanced")]
		private int _surroundRange;

		// Token: 0x04011126 RID: 69926
		[Token(Token = "0x4011126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[SerializeField]
		[Group("Advanced")]
		private TargetValidator _unitValidator;

		// Token: 0x04011127 RID: 69927
		[Token(Token = "0x4011127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private int[,] m_tileWeightMap;

		// Token: 0x04011128 RID: 69928
		[Token(Token = "0x4011128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private int m_cachedMapHeight;

		// Token: 0x04011129 RID: 69929
		[Token(Token = "0x4011129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private int m_cachedMapWidth;

		// Token: 0x0401112A RID: 69930
		[Token(Token = "0x401112A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private int m_rootTileWeight;

		// Token: 0x0401112B RID: 69931
		[Token(Token = "0x401112B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private int m_surroundTileWeight;

		// Token: 0x0401112C RID: 69932
		[Token(Token = "0x401112C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private List<TileWithWeight> m_candidates;

		// Token: 0x0401112D RID: 69933
		[Token(Token = "0x401112D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_filterType;

		// Token: 0x0401112E RID: 69934
		[Token(Token = "0x401112E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_ignoreTargetFree;

		// Token: 0x0401112F RID: 69935
		[Token(Token = "0x401112F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04011130 RID: 69936
		[Token(Token = "0x4011130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x04011131 RID: 69937
		[Token(Token = "0x4011131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__VerifyUnit;

		// Token: 0x04011132 RID: 69938
		[Token(Token = "0x4011132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CalculateTileWeight;

		// Token: 0x04011133 RID: 69939
		[Token(Token = "0x4011133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__DoFilter;

		// Token: 0x04011134 RID: 69940
		[Token(Token = "0x4011134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__FilterWithWeight;

		// Token: 0x04011135 RID: 69941
		[Token(Token = "0x4011135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
