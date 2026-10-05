using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002556 RID: 9558
	[Token(Token = "0x2002556")]
	public class WangTileSelector : TileSelector
	{
		// Token: 0x17002052 RID: 8274
		// (get) Token: 0x0600F6AF RID: 63151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002052")]
		private WangStoneTriggerManager stoneManager
		{
			[Token(Token = "0x600F6AF")]
			[Address(RVA = "0x719CD0", Offset = "0x7188D0", VA = "0x180719CD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F6B0 RID: 63152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6B0")]
		[Address(RVA = "0x718F40", Offset = "0x717B40", VA = "0x180718F40", Slot = "22")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0600F6B1 RID: 63153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F6B1")]
		[Address(RVA = "0x718BD0", Offset = "0x7177D0", VA = "0x180718BD0", Slot = "20")]
		public override List<Tile> FindTiles(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F6B2 RID: 63154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6B2")]
		[Address(RVA = "0x7195D0", Offset = "0x7181D0", VA = "0x1807195D0", Slot = "41")]
		protected override void _DoFilter(List<Tile> candidates, TileSelector.FilterType tileFilterType)
		{
		}

		// Token: 0x0600F6B3 RID: 63155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6B3")]
		[Address(RVA = "0x7197F0", Offset = "0x7183F0", VA = "0x1807197F0")]
		private void _FilterWangNormal(List<Tile> candidates)
		{
		}

		// Token: 0x0600F6B4 RID: 63156 RVA: 0x0005BF08 File Offset: 0x0005A108
		[Token(Token = "0x600F6B4")]
		[Address(RVA = "0x7193C0", Offset = "0x717FC0", VA = "0x1807193C0")]
		private bool _CheckMapTileValid(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600F6B5 RID: 63157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6B5")]
		[Address(RVA = "0x719AA0", Offset = "0x7186A0", VA = "0x180719AA0")]
		private void _SortCandidates(List<Tile> candidates)
		{
		}

		// Token: 0x0600F6B6 RID: 63158 RVA: 0x0005BF20 File Offset: 0x0005A120
		[Token(Token = "0x600F6B6")]
		[Address(RVA = "0x7199D0", Offset = "0x7185D0", VA = "0x1807199D0")]
		private int _GetDirectionPriority(GridPosition pos, GridPosition oriPos)
		{
			return 0;
		}

		// Token: 0x0600F6B7 RID: 63159 RVA: 0x0005BF38 File Offset: 0x0005A138
		[Token(Token = "0x600F6B7")]
		[Address(RVA = "0x719170", Offset = "0x717D70", VA = "0x180719170")]
		private bool _CheckContainsEnemies(DoubleBufferedList<ObjectPtr<Enemy>> enemies)
		{
			return default(bool);
		}

		// Token: 0x0600F6B8 RID: 63160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6B8")]
		[Address(RVA = "0x719C20", Offset = "0x718820", VA = "0x180719C20")]
		public WangTileSelector()
		{
		}

		// Token: 0x0600F6BA RID: 63162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6BA")]
		[Address(RVA = "0x6D3790", Offset = "0x6D2390", VA = "0x1806D3790")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0600F6BB RID: 63163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F6BB")]
		[Address(RVA = "0x69B0B0", Offset = "0x699CB0", VA = "0x18069B0B0")]
		private List<Tile> <>xLuaBaseProxy_FindTiles(Vector2 P0)
		{
			return null;
		}

		// Token: 0x0600F6BC RID: 63164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6BC")]
		[Address(RVA = "0x6D37A0", Offset = "0x6D23A0", VA = "0x1806D37A0")]
		private void <>xLuaBaseProxy__DoFilter(List<Tile> P0, TileSelector.FilterType P1)
		{
		}

		// Token: 0x040111FE RID: 70142
		[Token(Token = "0x40111FE")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private WangTileSelector.SubFilterType _subFilterType;

		// Token: 0x040111FF RID: 70143
		[Token(Token = "0x40111FF")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private string _builtStoneCntBuffKey;

		// Token: 0x04011200 RID: 70144
		[Token(Token = "0x4011200")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private string _maxBuiltCntBBKey;

		// Token: 0x04011201 RID: 70145
		[Token(Token = "0x4011201")]
		[FieldOffset(Offset = "0x188")]
		private WangStoneTriggerManager m_stoneManager;

		// Token: 0x04011202 RID: 70146
		[Token(Token = "0x4011202")]
		[FieldOffset(Offset = "0x190")]
		private GridPosition m_targetPos;

		// Token: 0x04011203 RID: 70147
		[Token(Token = "0x4011203")]
		[FieldOffset(Offset = "0x198")]
		private int m_maxStoneBuiltCnt;

		// Token: 0x04011204 RID: 70148
		[Token(Token = "0x4011204")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stoneManager;

		// Token: 0x04011205 RID: 70149
		[Token(Token = "0x4011205")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04011206 RID: 70150
		[Token(Token = "0x4011206")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_FindTiles;

		// Token: 0x04011207 RID: 70151
		[Token(Token = "0x4011207")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DoFilter;

		// Token: 0x04011208 RID: 70152
		[Token(Token = "0x4011208")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__FilterWangNormal;

		// Token: 0x04011209 RID: 70153
		[Token(Token = "0x4011209")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckMapTileValid;

		// Token: 0x0401120A RID: 70154
		[Token(Token = "0x401120A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SortCandidates;

		// Token: 0x0401120B RID: 70155
		[Token(Token = "0x401120B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetDirectionPriority;

		// Token: 0x0401120C RID: 70156
		[Token(Token = "0x401120C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckContainsEnemies;

		// Token: 0x0401120D RID: 70157
		[Token(Token = "0x401120D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002557 RID: 9559
		[Token(Token = "0x2002557")]
		public enum SubFilterType
		{
			// Token: 0x0401120F RID: 70159
			[Token(Token = "0x401120F")]
			TALENT,
			// Token: 0x04011210 RID: 70160
			[Token(Token = "0x4011210")]
			SKILL_3,
			// Token: 0x04011211 RID: 70161
			[Token(Token = "0x4011211")]
			SKILL_3_INSTANT
		}
	}
}
