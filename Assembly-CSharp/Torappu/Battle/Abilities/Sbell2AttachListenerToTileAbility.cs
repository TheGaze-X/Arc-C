using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AEC RID: 10988
	[Token(Token = "0x2002AEC")]
	public class Sbell2AttachListenerToTileAbility : AttachListenerToTileAbility
	{
		// Token: 0x17002840 RID: 10304
		// (get) Token: 0x06012591 RID: 75153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002840")]
		public List<Tile> tilesInRange
		{
			[Token(Token = "0x6012591")]
			[Address(RVA = "0xA5FD10", Offset = "0xA5E910", VA = "0x180A5FD10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06012592 RID: 75154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012592")]
		[Address(RVA = "0xA5D2D0", Offset = "0xA5BED0", VA = "0x180A5D2D0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012593 RID: 75155 RVA: 0x00070608 File Offset: 0x0006E808
		[Token(Token = "0x6012593")]
		[Address(RVA = "0xA5CE60", Offset = "0xA5BA60", VA = "0x180A5CE60", Slot = "32")]
		public override bool CastToTarget(Entity target, [Optional] Ability.FinishCallbackDelegate finishCb, bool firstAttack = true)
		{
			return default(bool);
		}

		// Token: 0x06012594 RID: 75156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012594")]
		[Address(RVA = "0xA5D720", Offset = "0xA5C320", VA = "0x180A5D720", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x06012595 RID: 75157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012595")]
		[Address(RVA = "0xA5D610", Offset = "0xA5C210", VA = "0x180A5D610", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x06012596 RID: 75158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012596")]
		[Address(RVA = "0xA5D550", Offset = "0xA5C150", VA = "0x180A5D550")]
		public void MoveManagedS1TileListSnowForward()
		{
		}

		// Token: 0x06012597 RID: 75159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012597")]
		[Address(RVA = "0xA5D430", Offset = "0xA5C030", VA = "0x180A5D430")]
		public void ExpandManagedS2TileListSnowOutward()
		{
		}

		// Token: 0x06012598 RID: 75160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012598")]
		[Address(RVA = "0xA5CFF0", Offset = "0xA5BBF0", VA = "0x180A5CFF0")]
		public void CheckToCreateTokenInEndTile()
		{
		}

		// Token: 0x06012599 RID: 75161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012599")]
		[Address(RVA = "0xA5D230", Offset = "0xA5BE30", VA = "0x180A5D230")]
		public void ClearS1SnowTileList()
		{
		}

		// Token: 0x0601259A RID: 75162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601259A")]
		[Address(RVA = "0xA5D680", Offset = "0xA5C280", VA = "0x180A5D680")]
		public void ResetTilesInRangeList()
		{
		}

		// Token: 0x0601259B RID: 75163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601259B")]
		[Address(RVA = "0xA5DA10", Offset = "0xA5C610", VA = "0x180A5DA10")]
		private void _ClearRelatedData()
		{
		}

		// Token: 0x0601259C RID: 75164 RVA: 0x00070620 File Offset: 0x0006E820
		[Token(Token = "0x601259C")]
		[Address(RVA = "0xA5D7E0", Offset = "0xA5C3E0", VA = "0x180A5D7E0")]
		private bool _CheckTileFitCoverSnow(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0601259D RID: 75165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601259D")]
		[Address(RVA = "0xA5E550", Offset = "0xA5D150", VA = "0x180A5E550")]
		private void _S1PrepareSnowTileList()
		{
		}

		// Token: 0x0601259E RID: 75166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601259E")]
		[Address(RVA = "0xA5E000", Offset = "0xA5CC00", VA = "0x180A5E000")]
		private void _S1GetCachedSnowTileList()
		{
		}

		// Token: 0x0601259F RID: 75167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601259F")]
		[Address(RVA = "0xA5DB90", Offset = "0xA5C790", VA = "0x180A5DB90")]
		private void _S1ApplyCachedSnowTileDict()
		{
		}

		// Token: 0x060125A0 RID: 75168 RVA: 0x00070638 File Offset: 0x0006E838
		[Token(Token = "0x60125A0")]
		[Address(RVA = "0xA5F5E0", Offset = "0xA5E1E0", VA = "0x180A5F5E0")]
		private int _S2GetRestCountOutsideAttackRange()
		{
			return 0;
		}

		// Token: 0x060125A1 RID: 75169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125A1")]
		[Address(RVA = "0xA5F7A0", Offset = "0xA5E3A0", VA = "0x180A5F7A0")]
		private void _S2PrepareSnowTileList()
		{
		}

		// Token: 0x060125A2 RID: 75170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125A2")]
		[Address(RVA = "0xA5ED90", Offset = "0xA5D990", VA = "0x180A5ED90")]
		private void _S2GetCachedSnowTileList(int restCount)
		{
		}

		// Token: 0x060125A3 RID: 75171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125A3")]
		[Address(RVA = "0xA5E720", Offset = "0xA5D320", VA = "0x180A5E720")]
		private void _S2ApplyCachedSnowTileDict()
		{
		}

		// Token: 0x060125A4 RID: 75172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125A4")]
		[Address(RVA = "0xA5EBE0", Offset = "0xA5D7E0", VA = "0x180A5EBE0")]
		private void _S2CreateTokenInEndTile(Tile tile)
		{
		}

		// Token: 0x060125A5 RID: 75173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125A5")]
		[Address(RVA = "0xA5F990", Offset = "0xA5E590", VA = "0x180A5F990")]
		public Sbell2AttachListenerToTileAbility()
		{
		}

		// Token: 0x060125A6 RID: 75174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125A6")]
		[Address(RVA = "0xA5D7A0", Offset = "0xA5C3A0", VA = "0x180A5D7A0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060125A7 RID: 75175 RVA: 0x00070650 File Offset: 0x0006E850
		[Token(Token = "0x60125A7")]
		[Address(RVA = "0xA5D790", Offset = "0xA5C390", VA = "0x180A5D790")]
		private bool <>xLuaBaseProxy_CastToTarget(Entity P0, Ability.FinishCallbackDelegate P1, bool P2)
		{
			return default(bool);
		}

		// Token: 0x060125A8 RID: 75176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125A8")]
		[Address(RVA = "0xA4FAF0", Offset = "0xA4E6F0", VA = "0x180A4FAF0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x060125A9 RID: 75177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125A9")]
		[Address(RVA = "0xA5D7D0", Offset = "0xA5C3D0", VA = "0x180A5D7D0")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x04014BDA RID: 84954
		[Token(Token = "0x4014BDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		[SerializeField]
		[Group("AttachListener")]
		private TileSelector.Options _tileOptions;

		// Token: 0x04014BDB RID: 84955
		[Token(Token = "0x4014BDB")]
		private const string MAX_CAST_TILE_COUNT_STR = "max_cast_tile_count";

		// Token: 0x04014BDC RID: 84956
		[Token(Token = "0x4014BDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private List<Tile> m_s1SnowTileList;

		// Token: 0x04014BDD RID: 84957
		[Token(Token = "0x4014BDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private List<GridPosition> m_s2SnowTileList;

		// Token: 0x04014BDE RID: 84958
		[Token(Token = "0x4014BDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private Dictionary<Tile, int> m_cachedSnowTileDict;

		// Token: 0x04014BDF RID: 84959
		[Token(Token = "0x4014BDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private int m_maxExistSnowTileCount;

		// Token: 0x04014BE0 RID: 84960
		[Token(Token = "0x4014BE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private string m_s2TokenId;

		// Token: 0x04014BE1 RID: 84961
		[Token(Token = "0x4014BE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private List<Tile> m_tilesInRange;

		// Token: 0x04014BE2 RID: 84962
		[Token(Token = "0x4014BE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private List<Tile> m_appendTileList;

		// Token: 0x04014BE3 RID: 84963
		[Token(Token = "0x4014BE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private List<Sbell2AttachListenerToTileAbility.S2SnowTileStruct> m_s2CachedSnowTileList;

		// Token: 0x04014BE4 RID: 84964
		[Token(Token = "0x4014BE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_tilesInRange;

		// Token: 0x04014BE5 RID: 84965
		[Token(Token = "0x4014BE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014BE6 RID: 84966
		[Token(Token = "0x4014BE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CastToTarget;

		// Token: 0x04014BE7 RID: 84967
		[Token(Token = "0x4014BE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04014BE8 RID: 84968
		[Token(Token = "0x4014BE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x04014BE9 RID: 84969
		[Token(Token = "0x4014BE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_MoveManagedS1TileListSnowForward;

		// Token: 0x04014BEA RID: 84970
		[Token(Token = "0x4014BEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ExpandManagedS2TileListSnowOutward;

		// Token: 0x04014BEB RID: 84971
		[Token(Token = "0x4014BEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckToCreateTokenInEndTile;

		// Token: 0x04014BEC RID: 84972
		[Token(Token = "0x4014BEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ClearS1SnowTileList;

		// Token: 0x04014BED RID: 84973
		[Token(Token = "0x4014BED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ResetTilesInRangeList;

		// Token: 0x04014BEE RID: 84974
		[Token(Token = "0x4014BEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ClearRelatedData;

		// Token: 0x04014BEF RID: 84975
		[Token(Token = "0x4014BEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CheckTileFitCoverSnow;

		// Token: 0x04014BF0 RID: 84976
		[Token(Token = "0x4014BF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__S1PrepareSnowTileList;

		// Token: 0x04014BF1 RID: 84977
		[Token(Token = "0x4014BF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__S1GetCachedSnowTileList;

		// Token: 0x04014BF2 RID: 84978
		[Token(Token = "0x4014BF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__S1ApplyCachedSnowTileDict;

		// Token: 0x04014BF3 RID: 84979
		[Token(Token = "0x4014BF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__S2GetRestCountOutsideAttackRange;

		// Token: 0x04014BF4 RID: 84980
		[Token(Token = "0x4014BF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__S2PrepareSnowTileList;

		// Token: 0x04014BF5 RID: 84981
		[Token(Token = "0x4014BF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__S2GetCachedSnowTileList;

		// Token: 0x04014BF6 RID: 84982
		[Token(Token = "0x4014BF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__S2ApplyCachedSnowTileDict;

		// Token: 0x04014BF7 RID: 84983
		[Token(Token = "0x4014BF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__S2CreateTokenInEndTile;

		// Token: 0x04014BF8 RID: 84984
		[Token(Token = "0x4014BF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002AED RID: 10989
		[Token(Token = "0x2002AED")]
		public struct S2SnowTileStruct
		{
			// Token: 0x060125AA RID: 75178 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60125AA")]
			[Address(RVA = "0xA74DC0", Offset = "0xA739C0", VA = "0x180A74DC0")]
			public S2SnowTileStruct(Tile inputTile, GridPosition sourcePos, int inputNums)
			{
			}

			// Token: 0x04014BF9 RID: 84985
			[Token(Token = "0x4014BF9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Tile tile;

			// Token: 0x04014BFA RID: 84986
			[Token(Token = "0x4014BFA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int distance;

			// Token: 0x04014BFB RID: 84987
			[Token(Token = "0x4014BFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int nums;
		}
	}
}
