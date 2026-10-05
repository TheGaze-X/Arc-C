using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200234B RID: 9035
	[Token(Token = "0x200234B")]
	public class Rogue4DLC2AmiyManager : GlobalEnvSystem.EnvManager, IBuffSource, IHotfixable, IAudioSource
	{
		// Token: 0x0600E497 RID: 58519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E497")]
		[Address(RVA = "0x5A8FA0", Offset = "0x5A7BA0", VA = "0x1805A8FA0", Slot = "7")]
		public override void Init(GlobalEnvSystem owner)
		{
		}

		// Token: 0x0600E498 RID: 58520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E498")]
		[Address(RVA = "0x5A9060", Offset = "0x5A7C60", VA = "0x1805A9060", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E499 RID: 58521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E499")]
		[Address(RVA = "0x5A8F20", Offset = "0x5A7B20", VA = "0x1805A8F20", Slot = "10")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x0600E49A RID: 58522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E49A")]
		[Address(RVA = "0x5A9600", Offset = "0x5A8200", VA = "0x1805A9600")]
		public void TriggerSealTile(Enemy enemy, int startCol, int endCol, float interval)
		{
		}

		// Token: 0x0600E49B RID: 58523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E49B")]
		[Address(RVA = "0x5A9470", Offset = "0x5A8070", VA = "0x1805A9470")]
		public void StopSealTile()
		{
		}

		// Token: 0x0600E49C RID: 58524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E49C")]
		[Address(RVA = "0x5A9D10", Offset = "0x5A8910", VA = "0x1805A9D10")]
		private void _StartTimer(float interval)
		{
		}

		// Token: 0x0600E49D RID: 58525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E49D")]
		[Address(RVA = "0x5AA010", Offset = "0x5A8C10", VA = "0x1805AA010")]
		private void _StopTimer()
		{
		}

		// Token: 0x0600E49E RID: 58526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E49E")]
		[Address(RVA = "0x5A9C50", Offset = "0x5A8850", VA = "0x1805A9C50")]
		private void _StartFinishOldEffectTimer(float interval)
		{
		}

		// Token: 0x0600E49F RID: 58527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E49F")]
		[Address(RVA = "0x5A9780", Offset = "0x5A8380", VA = "0x1805A9780")]
		private void _SealTile(int col)
		{
		}

		// Token: 0x0600E4A0 RID: 58528 RVA: 0x00052B00 File Offset: 0x00050D00
		[Token(Token = "0x600E4A0")]
		[Address(RVA = "0x5AA090", Offset = "0x5A8C90", VA = "0x1805AA090")]
		private bool _TileEffectApplicable(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600E4A1 RID: 58529 RVA: 0x00052B18 File Offset: 0x00050D18
		[Token(Token = "0x600E4A1")]
		[Address(RVA = "0x5AA2B0", Offset = "0x5A8EB0", VA = "0x1805AA2B0")]
		private bool _VerifyTileKey(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600E4A2 RID: 58530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4A2")]
		[Address(RVA = "0x5A9E00", Offset = "0x5A8A00", VA = "0x1805A9E00")]
		private void _StopOutOfDateEffect()
		{
		}

		// Token: 0x0600E4A3 RID: 58531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4A3")]
		[Address(RVA = "0x5A8E80", Offset = "0x5A7A80", VA = "0x1805A8E80", Slot = "16")]
		public void GatherAudio(List<string> results)
		{
		}

		// Token: 0x0600E4A4 RID: 58532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4A4")]
		[Address(RVA = "0x5AA450", Offset = "0x5A9050", VA = "0x1805AA450")]
		public Rogue4DLC2AmiyManager()
		{
		}

		// Token: 0x0600E4A5 RID: 58533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4A5")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E4A6 RID: 58534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4A6")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600E4A7 RID: 58535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4A7")]
		[Address(RVA = "0x550BC0", Offset = "0x54F7C0", VA = "0x180550BC0")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x0400FBDA RID: 64474
		[Token(Token = "0x400FBDA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _tileEffect;

		// Token: 0x0400FBDB RID: 64475
		[Token(Token = "0x400FBDB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _tileHoldEffect;

		// Token: 0x0400FBDC RID: 64476
		[Token(Token = "0x400FBDC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TileSelector.Options _tileVerifyOptions;

		// Token: 0x0400FBDD RID: 64477
		[Token(Token = "0x400FBDD")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private BuffData _buff;

		// Token: 0x0400FBDE RID: 64478
		[Token(Token = "0x400FBDE")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private BuildableType _buildableType;

		// Token: 0x0400FBDF RID: 64479
		[Token(Token = "0x400FBDF")]
		[FieldOffset(Offset = "0x8C")]
		private int m_nextSealCol;

		// Token: 0x0400FBE0 RID: 64480
		[Token(Token = "0x400FBE0")]
		[FieldOffset(Offset = "0x90")]
		private int m_endCol;

		// Token: 0x0400FBE1 RID: 64481
		[Token(Token = "0x400FBE1")]
		[FieldOffset(Offset = "0x94")]
		private int m_curCol;

		// Token: 0x0400FBE2 RID: 64482
		[Token(Token = "0x400FBE2")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isAffecting;

		// Token: 0x0400FBE3 RID: 64483
		[Token(Token = "0x400FBE3")]
		[FieldOffset(Offset = "0x9C")]
		private float m_interval;

		// Token: 0x0400FBE4 RID: 64484
		[Token(Token = "0x400FBE4")]
		[FieldOffset(Offset = "0xA0")]
		private float m_interruptInterval;

		// Token: 0x0400FBE5 RID: 64485
		[Token(Token = "0x400FBE5")]
		[FieldOffset(Offset = "0xA4")]
		private bool m_needEarlyStop;

		// Token: 0x0400FBE6 RID: 64486
		[Token(Token = "0x400FBE6")]
		[FieldOffset(Offset = "0xA8")]
		private Enemy m_boss;

		// Token: 0x0400FBE7 RID: 64487
		[Token(Token = "0x400FBE7")]
		[FieldOffset(Offset = "0xB0")]
		private PeriodicTimer m_sealTileTimer;

		// Token: 0x0400FBE8 RID: 64488
		[Token(Token = "0x400FBE8")]
		[FieldOffset(Offset = "0xB8")]
		private PeriodicTimer m_stopEffectTimer;

		// Token: 0x0400FBE9 RID: 64489
		[Token(Token = "0x400FBE9")]
		[FieldOffset(Offset = "0xC0")]
		private PeriodicTimer m_interruptTimer;

		// Token: 0x0400FBEA RID: 64490
		[Token(Token = "0x400FBEA")]
		private const string m_tileKeyForbidden = "tile_forbidden";

		// Token: 0x0400FBEB RID: 64491
		[Token(Token = "0x400FBEB")]
		private const string m_tileKeyTelout = "tile_telout";

		// Token: 0x0400FBEC RID: 64492
		[Token(Token = "0x400FBEC")]
		private const string m_tileKeyTelin = "tile_telin";

		// Token: 0x0400FBED RID: 64493
		[Token(Token = "0x400FBED")]
		private const string m_tileKeyStart = "tile_start";

		// Token: 0x0400FBEE RID: 64494
		[Token(Token = "0x400FBEE")]
		private const string m_tileKeyEnd = "tile_end";

		// Token: 0x0400FBEF RID: 64495
		[Token(Token = "0x400FBEF")]
		private const string m_tileKeyHole = "tile_hole";

		// Token: 0x0400FBF0 RID: 64496
		[Token(Token = "0x400FBF0")]
		private const string SEAL_TILE_AUDIO_SIGNAL = "skzamy_seal_tile";

		// Token: 0x0400FBF1 RID: 64497
		[Token(Token = "0x400FBF1")]
		[FieldOffset(Offset = "0xC8")]
		private List<Effect> m_effectCollection1;

		// Token: 0x0400FBF2 RID: 64498
		[Token(Token = "0x400FBF2")]
		[FieldOffset(Offset = "0xD0")]
		private List<Effect> m_effectCollection2;

		// Token: 0x0400FBF3 RID: 64499
		[Token(Token = "0x400FBF3")]
		[FieldOffset(Offset = "0xD8")]
		private int m_spellCnt;

		// Token: 0x0400FBF4 RID: 64500
		[Token(Token = "0x400FBF4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400FBF5 RID: 64501
		[Token(Token = "0x400FBF5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400FBF6 RID: 64502
		[Token(Token = "0x400FBF6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x0400FBF7 RID: 64503
		[Token(Token = "0x400FBF7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TriggerSealTile;

		// Token: 0x0400FBF8 RID: 64504
		[Token(Token = "0x400FBF8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_StopSealTile;

		// Token: 0x0400FBF9 RID: 64505
		[Token(Token = "0x400FBF9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__StartTimer;

		// Token: 0x0400FBFA RID: 64506
		[Token(Token = "0x400FBFA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__StopTimer;

		// Token: 0x0400FBFB RID: 64507
		[Token(Token = "0x400FBFB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__StartFinishOldEffectTimer;

		// Token: 0x0400FBFC RID: 64508
		[Token(Token = "0x400FBFC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SealTile;

		// Token: 0x0400FBFD RID: 64509
		[Token(Token = "0x400FBFD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TileEffectApplicable;

		// Token: 0x0400FBFE RID: 64510
		[Token(Token = "0x400FBFE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__VerifyTileKey;

		// Token: 0x0400FBFF RID: 64511
		[Token(Token = "0x400FBFF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__StopOutOfDateEffect;

		// Token: 0x0400FC00 RID: 64512
		[Token(Token = "0x400FC00")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GatherAudio;

		// Token: 0x0400FC01 RID: 64513
		[Token(Token = "0x400FC01")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
