using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002325 RID: 8997
	[Token(Token = "0x2002325")]
	public class HalfIdleLhkawaManager : GlobalEnvSystem.EnvManager, IHotfixable, IBuffSource
	{
		// Token: 0x17001C83 RID: 7299
		// (get) Token: 0x0600E349 RID: 58185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C83")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E349")]
			[Address(RVA = "0x578370", Offset = "0x576F70", VA = "0x180578370", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E34A RID: 58186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E34A")]
		[Address(RVA = "0x5746A0", Offset = "0x5732A0", VA = "0x1805746A0", Slot = "7")]
		public override void Init(GlobalEnvSystem owner)
		{
		}

		// Token: 0x0600E34B RID: 58187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E34B")]
		[Address(RVA = "0x574AF0", Offset = "0x5736F0", VA = "0x180574AF0", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E34C RID: 58188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E34C")]
		[Address(RVA = "0x5742A0", Offset = "0x572EA0", VA = "0x1805742A0")]
		public void HalfIdlePolluteTrapNoticeBorn(Trap polluteTrap, string rangeId)
		{
		}

		// Token: 0x0600E34D RID: 58189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E34D")]
		[Address(RVA = "0x5745D0", Offset = "0x5731D0", VA = "0x1805745D0")]
		public void HalfIdlePolluteTrapNoticeDeath(Trap polluteTrap)
		{
		}

		// Token: 0x0600E34E RID: 58190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E34E")]
		[Address(RVA = "0x5724B0", Offset = "0x5710B0", VA = "0x1805724B0")]
		public void HalfIdleLhkawaTrapNoticeBorn(Trap kawaTrap, string rangeId)
		{
		}

		// Token: 0x0600E34F RID: 58191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E34F")]
		[Address(RVA = "0x572270", Offset = "0x570E70", VA = "0x180572270")]
		public void HalfIdleKawaIrrigateTiles(Trap kawa, bool firstIrrigate)
		{
		}

		// Token: 0x0600E350 RID: 58192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E350")]
		[Address(RVA = "0x573D30", Offset = "0x572930", VA = "0x180573D30")]
		public void HalfIdleLhtownNoticeBorn(Trap trapCity, string rangeId)
		{
		}

		// Token: 0x0600E351 RID: 58193 RVA: 0x00052530 File Offset: 0x00050730
		[Token(Token = "0x600E351")]
		[Address(RVA = "0x572180", Offset = "0x570D80", VA = "0x180572180")]
		public bool CheckOnIrrigatedTile(GridPosition pos)
		{
			return default(bool);
		}

		// Token: 0x0600E352 RID: 58194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E352")]
		[Address(RVA = "0x5758A0", Offset = "0x5744A0", VA = "0x1805758A0")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600E353 RID: 58195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E353")]
		[Address(RVA = "0x574BB0", Offset = "0x5737B0", VA = "0x180574BB0")]
		private void _DealKawaIrrigate(int row, int col, Trap kawa)
		{
		}

		// Token: 0x0600E354 RID: 58196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E354")]
		[Address(RVA = "0x574CB0", Offset = "0x5738B0", VA = "0x180574CB0")]
		private void _DealSingleIrrigateTile(Trap kawa, int row, int col)
		{
		}

		// Token: 0x0600E355 RID: 58197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E355")]
		[Address(RVA = "0x576400", Offset = "0x575000", VA = "0x180576400")]
		private void _UpdateIrrigate()
		{
		}

		// Token: 0x0600E356 RID: 58198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E356")]
		[Address(RVA = "0x577440", Offset = "0x576040", VA = "0x180577440")]
		private void _UpdatePollute()
		{
		}

		// Token: 0x0600E357 RID: 58199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E357")]
		[Address(RVA = "0x575B10", Offset = "0x574710", VA = "0x180575B10")]
		private void _UpdateClean(uint trapUid)
		{
		}

		// Token: 0x0600E358 RID: 58200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E358")]
		[Address(RVA = "0x575020", Offset = "0x573C20", VA = "0x180575020")]
		private void _HalfIdleUpdateSTilesByRangeId(string rangeId, GridPosition anchorPos)
		{
		}

		// Token: 0x0600E359 RID: 58201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E359")]
		[Address(RVA = "0x576C10", Offset = "0x575810", VA = "0x180576C10")]
		private void _UpdateLhheModelTypeWhenBorn(Trap trap)
		{
		}

		// Token: 0x0600E35A RID: 58202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E35A")]
		[Address(RVA = "0x576E80", Offset = "0x575A80", VA = "0x180576E80")]
		private void _UpdateLhheModelType(Tile tile)
		{
		}

		// Token: 0x0600E35B RID: 58203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E35B")]
		[Address(RVA = "0x578110", Offset = "0x576D10", VA = "0x180578110")]
		public HalfIdleLhkawaManager()
		{
		}

		// Token: 0x0600E35D RID: 58205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E35D")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0600E35E RID: 58206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E35E")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E35F RID: 58207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E35F")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0400F997 RID: 63895
		[Token(Token = "0x400F997")]
		private const int MAX_RIVER_BELONG_CNT = 4;

		// Token: 0x0400F998 RID: 63896
		[Token(Token = "0x400F998")]
		private const string TILE_HOLE_KEY = "tile_hole";

		// Token: 0x0400F999 RID: 63897
		[Token(Token = "0x400F999")]
		private const string POLLUTE_RANGE = "x-5";

		// Token: 0x0400F99A RID: 63898
		[Token(Token = "0x400F99A")]
		private const string CLEAN_TILE_GEN_AUDIO_SIGNAL = "lhhe_gen_clean_tile";

		// Token: 0x0400F99B RID: 63899
		[Token(Token = "0x400F99B")]
		private const string POLLUTE_TILE_GEN_AUDIO_SIGNAL = "lhhe_gen_pollute_tile";

		// Token: 0x0400F99C RID: 63900
		[Token(Token = "0x400F99C")]
		[FieldOffset(Offset = "0x0")]
		private static int s_globalRiverCounter;

		// Token: 0x0400F99D RID: 63901
		[Token(Token = "0x400F99D")]
		[FieldOffset(Offset = "0x8")]
		private static List<Tile> s_sharedTiles;

		// Token: 0x0400F99E RID: 63902
		[Token(Token = "0x400F99E")]
		[FieldOffset(Offset = "0x10")]
		private static HashSet<int> s_sharedRiverIds;

		// Token: 0x0400F99F RID: 63903
		[Token(Token = "0x400F99F")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<int, HalfIdleLhkawaManager.RiverInfo> m_riverInfos;

		// Token: 0x0400F9A0 RID: 63904
		[Token(Token = "0x400F9A0")]
		[FieldOffset(Offset = "0x30")]
		private HalfIdleLhkawaManager.IrrigateTileInfo[][] m_irrigateTileInfos;

		// Token: 0x0400F9A1 RID: 63905
		[Token(Token = "0x400F9A1")]
		[FieldOffset(Offset = "0x38")]
		private int[][] m_tileToRiverIDInfos;

		// Token: 0x0400F9A2 RID: 63906
		[Token(Token = "0x400F9A2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _lhkawaTag;

		// Token: 0x0400F9A3 RID: 63907
		[Token(Token = "0x400F9A3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _lhpltTag;

		// Token: 0x0400F9A4 RID: 63908
		[Token(Token = "0x400F9A4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _lhtownTag;

		// Token: 0x0400F9A5 RID: 63909
		[Token(Token = "0x400F9A5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string _lhportId;

		// Token: 0x0400F9A6 RID: 63910
		[Token(Token = "0x400F9A6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TargetOptions _targetValidator;

		// Token: 0x0400F9A7 RID: 63911
		[Token(Token = "0x400F9A7")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private string _irrigateBuffName;

		// Token: 0x0400F9A8 RID: 63912
		[Token(Token = "0x400F9A8")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private BuffData _irrigateBuff;

		// Token: 0x0400F9A9 RID: 63913
		[Token(Token = "0x400F9A9")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private string _polluteBuffName;

		// Token: 0x0400F9AA RID: 63914
		[Token(Token = "0x400F9AA")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private BuffData _polluteBuff;

		// Token: 0x0400F9AB RID: 63915
		[Token(Token = "0x400F9AB")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private BuffData _portToTownBuff;

		// Token: 0x0400F9AC RID: 63916
		[Token(Token = "0x400F9AC")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private string _irrigateEffectKey;

		// Token: 0x0400F9AD RID: 63917
		[Token(Token = "0x400F9AD")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private string _polluteEffectKey;

		// Token: 0x0400F9AE RID: 63918
		[Token(Token = "0x400F9AE")]
		[FieldOffset(Offset = "0xF8")]
		private int row;

		// Token: 0x0400F9AF RID: 63919
		[Token(Token = "0x400F9AF")]
		[FieldOffset(Offset = "0xFC")]
		private int col;

		// Token: 0x0400F9B0 RID: 63920
		[Token(Token = "0x400F9B0")]
		[FieldOffset(Offset = "0x100")]
		private bool m_updateIrrigate;

		// Token: 0x0400F9B1 RID: 63921
		[Token(Token = "0x400F9B1")]
		[FieldOffset(Offset = "0x101")]
		private bool m_needUpdatePolluteState;

		// Token: 0x0400F9B2 RID: 63922
		[Token(Token = "0x400F9B2")]
		[FieldOffset(Offset = "0x108")]
		private Dictionary<uint, uint> m_lhtownToLhportDict;

		// Token: 0x0400F9B3 RID: 63923
		[Token(Token = "0x400F9B3")]
		[FieldOffset(Offset = "0x110")]
		public HalfIdleLhheAnimatorBehaviour.HalfIdleLhheAnimatorEventParam cachedLhheAnimatorParam;

		// Token: 0x0400F9B4 RID: 63924
		[Token(Token = "0x400F9B4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400F9B5 RID: 63925
		[Token(Token = "0x400F9B5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F9B6 RID: 63926
		[Token(Token = "0x400F9B6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F9B7 RID: 63927
		[Token(Token = "0x400F9B7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HalfIdlePolluteTrapNoticeBorn;

		// Token: 0x0400F9B8 RID: 63928
		[Token(Token = "0x400F9B8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HalfIdlePolluteTrapNoticeDeath;

		// Token: 0x0400F9B9 RID: 63929
		[Token(Token = "0x400F9B9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HalfIdleLhkawaTrapNoticeBorn;

		// Token: 0x0400F9BA RID: 63930
		[Token(Token = "0x400F9BA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_HalfIdleKawaIrrigateTiles;

		// Token: 0x0400F9BB RID: 63931
		[Token(Token = "0x400F9BB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_HalfIdleLhtownNoticeBorn;

		// Token: 0x0400F9BC RID: 63932
		[Token(Token = "0x400F9BC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CheckOnIrrigatedTile;

		// Token: 0x0400F9BD RID: 63933
		[Token(Token = "0x400F9BD")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0400F9BE RID: 63934
		[Token(Token = "0x400F9BE")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__DealKawaIrrigate;

		// Token: 0x0400F9BF RID: 63935
		[Token(Token = "0x400F9BF")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__DealSingleIrrigateTile;

		// Token: 0x0400F9C0 RID: 63936
		[Token(Token = "0x400F9C0")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__UpdateIrrigate;

		// Token: 0x0400F9C1 RID: 63937
		[Token(Token = "0x400F9C1")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__UpdatePollute;

		// Token: 0x0400F9C2 RID: 63938
		[Token(Token = "0x400F9C2")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__UpdateClean;

		// Token: 0x0400F9C3 RID: 63939
		[Token(Token = "0x400F9C3")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__HalfIdleUpdateSTilesByRangeId;

		// Token: 0x0400F9C4 RID: 63940
		[Token(Token = "0x400F9C4")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__UpdateLhheModelTypeWhenBorn;

		// Token: 0x0400F9C5 RID: 63941
		[Token(Token = "0x400F9C5")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__UpdateLhheModelType;

		// Token: 0x0400F9C6 RID: 63942
		[Token(Token = "0x400F9C6")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002326 RID: 8998
		[Token(Token = "0x2002326")]
		private class IrrigateTileInfo
		{
			// Token: 0x0600E360 RID: 58208 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E360")]
			[Address(RVA = "0x578BB0", Offset = "0x5777B0", VA = "0x180578BB0")]
			public IrrigateTileInfo()
			{
			}

			// Token: 0x0400F9C7 RID: 63943
			[Token(Token = "0x400F9C7")]
			[FieldOffset(Offset = "0x10")]
			public bool isIrrigated;

			// Token: 0x0400F9C8 RID: 63944
			[Token(Token = "0x400F9C8")]
			[FieldOffset(Offset = "0x18")]
			public HashSet<int> sourceRiverIds;

			// Token: 0x0400F9C9 RID: 63945
			[Token(Token = "0x400F9C9")]
			[FieldOffset(Offset = "0x20")]
			public HashSet<uint> sourceTrapIds;

			// Token: 0x0400F9CA RID: 63946
			[Token(Token = "0x400F9CA")]
			[FieldOffset(Offset = "0x28")]
			public List<uint> sourceTrapIdsToUpdate;

			// Token: 0x0400F9CB RID: 63947
			[Token(Token = "0x400F9CB")]
			[FieldOffset(Offset = "0x30")]
			public Effect tileEffect;

			// Token: 0x0400F9CC RID: 63948
			[Token(Token = "0x400F9CC")]
			[FieldOffset(Offset = "0x38")]
			public bool isPolluted;

			// Token: 0x0400F9CD RID: 63949
			[Token(Token = "0x400F9CD")]
			[FieldOffset(Offset = "0x39")]
			public bool toBeIrrigate;
		}

		// Token: 0x02002327 RID: 8999
		[Token(Token = "0x2002327")]
		private class RiverInfo
		{
			// Token: 0x0600E361 RID: 58209 RVA: 0x00052548 File Offset: 0x00050748
			[Token(Token = "0x600E361")]
			[Address(RVA = "0x57B6D0", Offset = "0x57A2D0", VA = "0x18057B6D0")]
			public bool CheckTrapBelongsRiver(uint trapUid)
			{
				return default(bool);
			}

			// Token: 0x0600E362 RID: 58210 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E362")]
			[Address(RVA = "0x57B730", Offset = "0x57A330", VA = "0x18057B730")]
			public RiverInfo()
			{
			}

			// Token: 0x0400F9CE RID: 63950
			[Token(Token = "0x400F9CE")]
			[FieldOffset(Offset = "0x10")]
			public int riverId;

			// Token: 0x0400F9CF RID: 63951
			[Token(Token = "0x400F9CF")]
			[FieldOffset(Offset = "0x18")]
			public HashSet<uint> kawaTrapUids;

			// Token: 0x0400F9D0 RID: 63952
			[Token(Token = "0x400F9D0")]
			[FieldOffset(Offset = "0x20")]
			public bool isPolluted;

			// Token: 0x0400F9D1 RID: 63953
			[Token(Token = "0x400F9D1")]
			[FieldOffset(Offset = "0x28")]
			public HashSet<uint> nearbyPolluteUids;

			// Token: 0x0400F9D2 RID: 63954
			[Token(Token = "0x400F9D2")]
			[FieldOffset(Offset = "0x30")]
			public HashSet<uint> port;
		}

		// Token: 0x02002328 RID: 9000
		[Token(Token = "0x2002328")]
		private class PortInfo
		{
			// Token: 0x0600E363 RID: 58211 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E363")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PortInfo()
			{
			}

			// Token: 0x0400F9D3 RID: 63955
			[Token(Token = "0x400F9D3")]
			[FieldOffset(Offset = "0x10")]
			public uint portUid;

			// Token: 0x0400F9D4 RID: 63956
			[Token(Token = "0x400F9D4")]
			[FieldOffset(Offset = "0x14")]
			public int riverId;
		}
	}
}
