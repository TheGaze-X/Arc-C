using System;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020022C7 RID: 8903
	[Token(Token = "0x20022C7")]
	public class Act38SideBattleManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x17001C17 RID: 7191
		// (get) Token: 0x0600DFF8 RID: 57336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C17")]
		private Enemy boss
		{
			[Token(Token = "0x600DFF8")]
			[Address(RVA = "0x3669C40", Offset = "0x3668840", VA = "0x183669C40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C18 RID: 7192
		// (get) Token: 0x0600DFF9 RID: 57337 RVA: 0x00051570 File Offset: 0x0004F770
		[Token(Token = "0x17001C18")]
		public FireworkData.FireworkType fireworkType
		{
			[Token(Token = "0x600DFF9")]
			[Address(RVA = "0x366A1B0", Offset = "0x3668DB0", VA = "0x18366A1B0")]
			get
			{
				return FireworkData.FireworkType.RED;
			}
		}

		// Token: 0x17001C19 RID: 7193
		// (get) Token: 0x0600DFFA RID: 57338 RVA: 0x00051588 File Offset: 0x0004F788
		[Token(Token = "0x17001C19")]
		public int fireworkLevel
		{
			[Token(Token = "0x600DFFA")]
			[Address(RVA = "0x366A0F0", Offset = "0x3668CF0", VA = "0x18366A0F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001C1A RID: 7194
		// (get) Token: 0x0600DFFB RID: 57339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C1A")]
		public string defaultRangeId
		{
			[Token(Token = "0x600DFFB")]
			[Address(RVA = "0x3669D60", Offset = "0x3668960", VA = "0x183669D60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C1B RID: 7195
		// (get) Token: 0x0600DFFC RID: 57340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C1B")]
		public RangeData fireworkRangeData
		{
			[Token(Token = "0x600DFFC")]
			[Address(RVA = "0x366A150", Offset = "0x3668D50", VA = "0x18366A150")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C1C RID: 7196
		// (get) Token: 0x0600DFFD RID: 57341 RVA: 0x000515A0 File Offset: 0x0004F7A0
		[Token(Token = "0x17001C1C")]
		public int allyKillCnt
		{
			[Token(Token = "0x600DFFD")]
			[Address(RVA = "0x3669B80", Offset = "0x3668780", VA = "0x183669B80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001C1D RID: 7197
		// (get) Token: 0x0600DFFE RID: 57342 RVA: 0x000515B8 File Offset: 0x0004F7B8
		[Token(Token = "0x17001C1D")]
		public int bossKillCnt
		{
			[Token(Token = "0x600DFFE")]
			[Address(RVA = "0x3669BE0", Offset = "0x36687E0", VA = "0x183669BE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001C1E RID: 7198
		// (get) Token: 0x0600DFFF RID: 57343 RVA: 0x000515D0 File Offset: 0x0004F7D0
		[Token(Token = "0x17001C1E")]
		public bool isDuringCarnivalBet
		{
			[Token(Token = "0x600DFFF")]
			[Address(RVA = "0x366A400", Offset = "0x3669000", VA = "0x18366A400")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001C1F RID: 7199
		// (get) Token: 0x0600E000 RID: 57344 RVA: 0x000515E8 File Offset: 0x0004F7E8
		[Token(Token = "0x17001C1F")]
		public bool isDuringCarnival
		{
			[Token(Token = "0x600E000")]
			[Address(RVA = "0x366A4A0", Offset = "0x36690A0", VA = "0x18366A4A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001C20 RID: 7200
		// (get) Token: 0x0600E001 RID: 57345 RVA: 0x00051600 File Offset: 0x0004F800
		[Token(Token = "0x17001C20")]
		public bool isBossFinished
		{
			[Token(Token = "0x600E001")]
			[Address(RVA = "0x366A210", Offset = "0x3668E10", VA = "0x18366A210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001C21 RID: 7201
		// (get) Token: 0x0600E002 RID: 57346 RVA: 0x00051618 File Offset: 0x0004F818
		[Token(Token = "0x17001C21")]
		public bool isBossWin
		{
			[Token(Token = "0x600E002")]
			[Address(RVA = "0x366A340", Offset = "0x3668F40", VA = "0x18366A340")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001C22 RID: 7202
		// (get) Token: 0x0600E003 RID: 57347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C22")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E003")]
			[Address(RVA = "0x3669E20", Offset = "0x3668A20", VA = "0x183669E20", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C23 RID: 7203
		// (get) Token: 0x0600E004 RID: 57348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C23")]
		public Route carnivalRoute
		{
			[Token(Token = "0x600E004")]
			[Address(RVA = "0x3669D00", Offset = "0x3668900", VA = "0x183669D00")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E005 RID: 57349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E005")]
		[Address(RVA = "0x3665720", Offset = "0x3664320", VA = "0x183665720", Slot = "7")]
		public override void Init(GlobalEnvSystem envSystem)
		{
		}

		// Token: 0x0600E006 RID: 57350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E006")]
		[Address(RVA = "0x3665C90", Offset = "0x3664890", VA = "0x183665C90", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E007 RID: 57351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E007")]
		[Address(RVA = "0x3666270", Offset = "0x3664E70", VA = "0x183666270", Slot = "15")]
		public override void OnTrigger(object param)
		{
		}

		// Token: 0x0600E008 RID: 57352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E008")]
		[Address(RVA = "0x3665BE0", Offset = "0x36647E0", VA = "0x183665BE0")]
		public void LogKilled(bool isKilledByBoss)
		{
		}

		// Token: 0x0600E009 RID: 57353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E009")]
		[Address(RVA = "0x3665670", Offset = "0x3664270", VA = "0x183665670")]
		public void CheckFunLevelLost()
		{
		}

		// Token: 0x0600E00A RID: 57354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E00A")]
		[Address(RVA = "0x3668920", Offset = "0x3667520", VA = "0x183668920")]
		private void _OnGameStart(object arg)
		{
		}

		// Token: 0x0600E00B RID: 57355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E00B")]
		[Address(RVA = "0x3669110", Offset = "0x3667D10", VA = "0x183669110")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600E00C RID: 57356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E00C")]
		[Address(RVA = "0x3668470", Offset = "0x3667070", VA = "0x183668470")]
		private void _OnEnemyBorn(Enemy enemy)
		{
		}

		// Token: 0x0600E00D RID: 57357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E00D")]
		[Address(RVA = "0x3667C30", Offset = "0x3666830", VA = "0x183667C30")]
		private void _OnCarnivalStart()
		{
		}

		// Token: 0x0600E00E RID: 57358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E00E")]
		[Address(RVA = "0x3667A00", Offset = "0x3666600", VA = "0x183667A00")]
		private void _OnCarnivalFinish()
		{
		}

		// Token: 0x0600E00F RID: 57359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E00F")]
		[Address(RVA = "0x3667830", Offset = "0x3666430", VA = "0x183667830")]
		private void _OnBossWin()
		{
		}

		// Token: 0x0600E010 RID: 57360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E010")]
		[Address(RVA = "0x3667490", Offset = "0x3666090", VA = "0x183667490")]
		private void _OnAllyWin()
		{
		}

		// Token: 0x0600E011 RID: 57361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E011")]
		[Address(RVA = "0x3668560", Offset = "0x3667160", VA = "0x183668560")]
		private void _OnGameOver(object arg)
		{
		}

		// Token: 0x0600E012 RID: 57362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E012")]
		[Address(RVA = "0x3666CD0", Offset = "0x36658D0", VA = "0x183666CD0")]
		private void _InitFirework()
		{
		}

		// Token: 0x0600E013 RID: 57363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E013")]
		[Address(RVA = "0x3669300", Offset = "0x3667F00", VA = "0x183669300")]
		private void _ResetCount()
		{
		}

		// Token: 0x0600E014 RID: 57364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E014")]
		[Address(RVA = "0x3666B00", Offset = "0x3665700", VA = "0x183666B00")]
		private void _InitFireworkSpine()
		{
		}

		// Token: 0x0600E015 RID: 57365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E015")]
		[Address(RVA = "0x3669370", Offset = "0x3667F70", VA = "0x183669370")]
		private void _ResetFirework()
		{
		}

		// Token: 0x0600E016 RID: 57366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E016")]
		[Address(RVA = "0x36663F0", Offset = "0x3664FF0", VA = "0x1836663F0")]
		private static List<GridPosition> _ConvertToGridPositions(int[,] array)
		{
			return null;
		}

		// Token: 0x0600E017 RID: 57367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E017")]
		[Address(RVA = "0x36665B0", Offset = "0x36651B0", VA = "0x1836665B0")]
		private int[,] _ConvertToIntArray()
		{
			return null;
		}

		// Token: 0x0600E018 RID: 57368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E018")]
		[Address(RVA = "0x3666740", Offset = "0x3665340", VA = "0x183666740")]
		private RangeData _ConvertToRangeData()
		{
			return null;
		}

		// Token: 0x0600E019 RID: 57369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E019")]
		[Address(RVA = "0x3667380", Offset = "0x3665F80", VA = "0x183667380")]
		private void _LogCarnivalStart()
		{
		}

		// Token: 0x0600E01A RID: 57370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E01A")]
		[Address(RVA = "0x36698D0", Offset = "0x36684D0", VA = "0x1836698D0")]
		public Act38SideBattleManager()
		{
		}

		// Token: 0x0600E01B RID: 57371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E01B")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0600E01C RID: 57372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E01C")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E01D RID: 57373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E01D")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600E01E RID: 57374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E01E")]
		[Address(RVA = "0x550C10", Offset = "0x54F810", VA = "0x180550C10")]
		private void <>xLuaBaseProxy_OnTrigger(object P0)
		{
		}

		// Token: 0x0400F3AB RID: 62379
		[Token(Token = "0x400F3AB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _timeToRespawnFirework;

		// Token: 0x0400F3AC RID: 62380
		[Token(Token = "0x400F3AC")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private FireworkData.FireworkType _defaultFireworkType;

		// Token: 0x0400F3AD RID: 62381
		[Token(Token = "0x400F3AD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _defaultFireworkLevel;

		// Token: 0x0400F3AE RID: 62382
		[Token(Token = "0x400F3AE")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int _defaultFireworkRangeIndex;

		// Token: 0x0400F3AF RID: 62383
		[Token(Token = "0x400F3AF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<string> _defaultRangeIdList;

		// Token: 0x0400F3B0 RID: 62384
		[Token(Token = "0x400F3B0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<string> _defaultFireworkRangeData;

		// Token: 0x0400F3B1 RID: 62385
		[Token(Token = "0x400F3B1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _minClearDistance;

		// Token: 0x0400F3B2 RID: 62386
		[Token(Token = "0x400F3B2")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _minFireOffset;

		// Token: 0x0400F3B3 RID: 62387
		[Token(Token = "0x400F3B3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _fireEnemyId;

		// Token: 0x0400F3B4 RID: 62388
		[Token(Token = "0x400F3B4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string _fireworkTrapId;

		// Token: 0x0400F3B5 RID: 62389
		[Token(Token = "0x400F3B5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _bossId;

		// Token: 0x0400F3B6 RID: 62390
		[Token(Token = "0x400F3B6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Bet")]
		[Tooltip("友方胜利烟花Buff")]
		private List<BuffData> _winFireworkBuffs;

		// Token: 0x0400F3B7 RID: 62391
		[Token(Token = "0x400F3B7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Bet")]
		[Tooltip("友方胜利BossBuff")]
		private List<BuffData> _winBossBuffs;

		// Token: 0x0400F3B8 RID: 62392
		[Token(Token = "0x400F3B8")]
		[FieldOffset(Offset = "0x78")]
		[Tooltip("Boss烟花Buff")]
		[SerializeField]
		[Group("Bet")]
		private List<BuffData> _lostFireworkBuffs;

		// Token: 0x0400F3B9 RID: 62393
		[Token(Token = "0x400F3B9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Camera Effect")]
		private string _fireworkCamEff;

		// Token: 0x0400F3BA RID: 62394
		[Token(Token = "0x400F3BA")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Effect")]
		private string _tileEffectKey;

		// Token: 0x0400F3BB RID: 62395
		[Token(Token = "0x400F3BB")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Effect")]
		private string _color;

		// Token: 0x0400F3BC RID: 62396
		[Token(Token = "0x400F3BC")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Effect")]
		private float _colorTweenDuration;

		// Token: 0x0400F3BD RID: 62397
		[Token(Token = "0x400F3BD")]
		[FieldOffset(Offset = "0xA0")]
		private Tile m_fireworkTile;

		// Token: 0x0400F3BE RID: 62398
		[Token(Token = "0x400F3BE")]
		[FieldOffset(Offset = "0xA8")]
		private Trap m_fireworkTrap;

		// Token: 0x0400F3BF RID: 62399
		[Token(Token = "0x400F3BF")]
		[FieldOffset(Offset = "0xB0")]
		private FireworkData.FireworkType m_fireworkType;

		// Token: 0x0400F3C0 RID: 62400
		[Token(Token = "0x400F3C0")]
		[FieldOffset(Offset = "0xB8")]
		private string m_fireworkId;

		// Token: 0x0400F3C1 RID: 62401
		[Token(Token = "0x400F3C1")]
		[FieldOffset(Offset = "0xC0")]
		private int m_fireworkLevel;

		// Token: 0x0400F3C2 RID: 62402
		[Token(Token = "0x400F3C2")]
		[FieldOffset(Offset = "0xC4")]
		private int m_fireworkRangeIndex;

		// Token: 0x0400F3C3 RID: 62403
		[Token(Token = "0x400F3C3")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_isAvgLevel;

		// Token: 0x0400F3C4 RID: 62404
		[Token(Token = "0x400F3C4")]
		[FieldOffset(Offset = "0xC9")]
		private bool m_isFunLevel;

		// Token: 0x0400F3C5 RID: 62405
		[Token(Token = "0x400F3C5")]
		[FieldOffset(Offset = "0xCA")]
		private bool m_isTrLevel;

		// Token: 0x0400F3C6 RID: 62406
		[Token(Token = "0x400F3C6")]
		[FieldOffset(Offset = "0xCB")]
		private bool m_hasStartAvgEmitted;

		// Token: 0x0400F3C7 RID: 62407
		[Token(Token = "0x400F3C7")]
		[FieldOffset(Offset = "0xCC")]
		private bool m_hasWinAvgEmitted;

		// Token: 0x0400F3C8 RID: 62408
		[Token(Token = "0x400F3C8")]
		[FieldOffset(Offset = "0xCD")]
		private bool m_hasLostAvgEmitted;

		// Token: 0x0400F3C9 RID: 62409
		[Token(Token = "0x400F3C9")]
		[FieldOffset(Offset = "0xCE")]
		private bool m_isTrapInitiated;

		// Token: 0x0400F3CA RID: 62410
		[Token(Token = "0x400F3CA")]
		[FieldOffset(Offset = "0xD0")]
		private CameraEffect m_fireworkCamEff;

		// Token: 0x0400F3CB RID: 62411
		[Token(Token = "0x400F3CB")]
		[FieldOffset(Offset = "0xD8")]
		private Enemy m_boss;

		// Token: 0x0400F3CC RID: 62412
		[Token(Token = "0x400F3CC")]
		[FieldOffset(Offset = "0xE0")]
		private Enemy m_fire;

		// Token: 0x0400F3CD RID: 62413
		[Token(Token = "0x400F3CD")]
		[FieldOffset(Offset = "0xE8")]
		private readonly ListDict<int, Tile> m_tiles;

		// Token: 0x0400F3CE RID: 62414
		[Token(Token = "0x400F3CE")]
		[FieldOffset(Offset = "0xF0")]
		private Effect m_lineEffect;

		// Token: 0x0400F3CF RID: 62415
		[Token(Token = "0x400F3CF")]
		[FieldOffset(Offset = "0xF8")]
		private LineRenderer[] m_lineRenderers;

		// Token: 0x0400F3D0 RID: 62416
		[Token(Token = "0x400F3D0")]
		[FieldOffset(Offset = "0x100")]
		private LineRenderer m_lineRenderer;

		// Token: 0x0400F3D1 RID: 62417
		[Token(Token = "0x400F3D1")]
		[FieldOffset(Offset = "0x108")]
		private Material m_material;

		// Token: 0x0400F3D2 RID: 62418
		[Token(Token = "0x400F3D2")]
		[FieldOffset(Offset = "0x110")]
		private readonly List<Vector3> m_originLinePositions;

		// Token: 0x0400F3D3 RID: 62419
		[Token(Token = "0x400F3D3")]
		[FieldOffset(Offset = "0x118")]
		private List<Vector3> m_linePositions;

		// Token: 0x0400F3D4 RID: 62420
		[Token(Token = "0x400F3D4")]
		[FieldOffset(Offset = "0x120")]
		private int m_tintColor;

		// Token: 0x0400F3D5 RID: 62421
		[Token(Token = "0x400F3D5")]
		[FieldOffset(Offset = "0x128")]
		private Tween m_tween;

		// Token: 0x0400F3D6 RID: 62422
		[Token(Token = "0x400F3D6")]
		[FieldOffset(Offset = "0x130")]
		private BattleCharacterData m_fireworkTrapData;

		// Token: 0x0400F3D7 RID: 62423
		[Token(Token = "0x400F3D7")]
		[FieldOffset(Offset = "0x138")]
		private Route m_carnivalRoute;

		// Token: 0x0400F3D8 RID: 62424
		[Token(Token = "0x400F3D8")]
		[FieldOffset(Offset = "0x140")]
		private CoroutineId m_coroutineId;

		// Token: 0x0400F3D9 RID: 62425
		[Token(Token = "0x400F3D9")]
		[FieldOffset(Offset = "0x150")]
		[Inspect]
		[ReadOnly]
		private RangeData m_fireworkRangeData;

		// Token: 0x0400F3DA RID: 62426
		[Token(Token = "0x400F3DA")]
		[FieldOffset(Offset = "0x158")]
		[Inspect]
		[ReadOnly]
		private int[,] m_fireworkRangeDataArray;

		// Token: 0x0400F3DB RID: 62427
		[Token(Token = "0x400F3DB")]
		[FieldOffset(Offset = "0x160")]
		[Inspect]
		[ReadOnly]
		private bool m_isBossLevel;

		// Token: 0x0400F3DC RID: 62428
		[Token(Token = "0x400F3DC")]
		[FieldOffset(Offset = "0x164")]
		[Inspect]
		[ReadOnly]
		private int m_allyKillCnt;

		// Token: 0x0400F3DD RID: 62429
		[Token(Token = "0x400F3DD")]
		[FieldOffset(Offset = "0x168")]
		[Inspect]
		[ReadOnly]
		private int m_bossKillCnt;

		// Token: 0x0400F3DE RID: 62430
		[Token(Token = "0x400F3DE")]
		[FieldOffset(Offset = "0x16C")]
		[Inspect]
		[ReadOnly]
		private bool m_isBossWin;

		// Token: 0x0400F3DF RID: 62431
		[Token(Token = "0x400F3DF")]
		[FieldOffset(Offset = "0x16D")]
		[Inspect]
		[ReadOnly]
		private bool m_nextFireworkBuff;

		// Token: 0x0400F3E0 RID: 62432
		[Token(Token = "0x400F3E0")]
		[FieldOffset(Offset = "0x16E")]
		[Inspect]
		[ReadOnly]
		private bool m_nextFireworkDeBuff;

		// Token: 0x0400F3E1 RID: 62433
		[Token(Token = "0x400F3E1")]
		[FieldOffset(Offset = "0x16F")]
		[Inspect]
		[ReadOnly]
		private bool m_isDuringCarnival;

		// Token: 0x0400F3E2 RID: 62434
		[Token(Token = "0x400F3E2")]
		[FieldOffset(Offset = "0x170")]
		[Inspect]
		[ReadOnly]
		private bool m_bossBorn;

		// Token: 0x0400F3E3 RID: 62435
		[Token(Token = "0x400F3E3")]
		private const string EVENT_ON_CARNIVAL_START = "event_on_carnival_start";

		// Token: 0x0400F3E4 RID: 62436
		[Token(Token = "0x400F3E4")]
		private const string EVENT_ON_CARNIVAL_FINISH = "event_on_carnival_finish";

		// Token: 0x0400F3E5 RID: 62437
		[Token(Token = "0x400F3E5")]
		private const string LINE_INDEX = "line_inedex";

		// Token: 0x0400F3E6 RID: 62438
		[Token(Token = "0x400F3E6")]
		private const string LOG_CARNIVAL = "SIMPLE,{0},carnival";

		// Token: 0x0400F3E7 RID: 62439
		[Token(Token = "0x400F3E7")]
		private const string MATERIAL_KEY = "share";

		// Token: 0x0400F3E8 RID: 62440
		[Token(Token = "0x400F3E8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_boss;

		// Token: 0x0400F3E9 RID: 62441
		[Token(Token = "0x400F3E9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_fireworkType;

		// Token: 0x0400F3EA RID: 62442
		[Token(Token = "0x400F3EA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_fireworkLevel;

		// Token: 0x0400F3EB RID: 62443
		[Token(Token = "0x400F3EB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_defaultRangeId;

		// Token: 0x0400F3EC RID: 62444
		[Token(Token = "0x400F3EC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_fireworkRangeData;

		// Token: 0x0400F3ED RID: 62445
		[Token(Token = "0x400F3ED")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_allyKillCnt;

		// Token: 0x0400F3EE RID: 62446
		[Token(Token = "0x400F3EE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_bossKillCnt;

		// Token: 0x0400F3EF RID: 62447
		[Token(Token = "0x400F3EF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_isDuringCarnivalBet;

		// Token: 0x0400F3F0 RID: 62448
		[Token(Token = "0x400F3F0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isDuringCarnival;

		// Token: 0x0400F3F1 RID: 62449
		[Token(Token = "0x400F3F1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_isBossFinished;

		// Token: 0x0400F3F2 RID: 62450
		[Token(Token = "0x400F3F2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_isBossWin;

		// Token: 0x0400F3F3 RID: 62451
		[Token(Token = "0x400F3F3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400F3F4 RID: 62452
		[Token(Token = "0x400F3F4")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_carnivalRoute;

		// Token: 0x0400F3F5 RID: 62453
		[Token(Token = "0x400F3F5")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F3F6 RID: 62454
		[Token(Token = "0x400F3F6")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F3F7 RID: 62455
		[Token(Token = "0x400F3F7")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnTrigger;

		// Token: 0x0400F3F8 RID: 62456
		[Token(Token = "0x400F3F8")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_LogKilled;

		// Token: 0x0400F3F9 RID: 62457
		[Token(Token = "0x400F3F9")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_CheckFunLevelLost;

		// Token: 0x0400F3FA RID: 62458
		[Token(Token = "0x400F3FA")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnGameStart;

		// Token: 0x0400F3FB RID: 62459
		[Token(Token = "0x400F3FB")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0400F3FC RID: 62460
		[Token(Token = "0x400F3FC")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnEnemyBorn;

		// Token: 0x0400F3FD RID: 62461
		[Token(Token = "0x400F3FD")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnCarnivalStart;

		// Token: 0x0400F3FE RID: 62462
		[Token(Token = "0x400F3FE")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnCarnivalFinish;

		// Token: 0x0400F3FF RID: 62463
		[Token(Token = "0x400F3FF")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnBossWin;

		// Token: 0x0400F400 RID: 62464
		[Token(Token = "0x400F400")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnAllyWin;

		// Token: 0x0400F401 RID: 62465
		[Token(Token = "0x400F401")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__OnGameOver;

		// Token: 0x0400F402 RID: 62466
		[Token(Token = "0x400F402")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__InitFirework;

		// Token: 0x0400F403 RID: 62467
		[Token(Token = "0x400F403")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__ResetCount;

		// Token: 0x0400F404 RID: 62468
		[Token(Token = "0x400F404")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__InitFireworkSpine;

		// Token: 0x0400F405 RID: 62469
		[Token(Token = "0x400F405")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__ResetFirework;

		// Token: 0x0400F406 RID: 62470
		[Token(Token = "0x400F406")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__ConvertToGridPositions;

		// Token: 0x0400F407 RID: 62471
		[Token(Token = "0x400F407")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__ConvertToIntArray;

		// Token: 0x0400F408 RID: 62472
		[Token(Token = "0x400F408")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__ConvertToRangeData;

		// Token: 0x0400F409 RID: 62473
		[Token(Token = "0x400F409")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__LogCarnivalStart;

		// Token: 0x0400F40A RID: 62474
		[Token(Token = "0x400F40A")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
