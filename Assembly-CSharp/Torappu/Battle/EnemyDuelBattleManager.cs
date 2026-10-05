using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using Torappu.Battle.GameMode;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200231D RID: 8989
	[Token(Token = "0x200231D")]
	public class EnemyDuelBattleManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x17001C7B RID: 7291
		// (get) Token: 0x0600E2FD RID: 58109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C7B")]
		private GameModeFactory.EnemyDuelGameMode gameMode
		{
			[Token(Token = "0x600E2FD")]
			[Address(RVA = "0x56F8A0", Offset = "0x56E4A0", VA = "0x18056F8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C7C RID: 7292
		// (get) Token: 0x0600E2FE RID: 58110 RVA: 0x00052488 File Offset: 0x00050688
		[Token(Token = "0x17001C7C")]
		[Inspect]
		[ReadOnly]
		private int teamOnSceneLeftCount
		{
			[Token(Token = "0x600E2FE")]
			[Address(RVA = "0x56FAD0", Offset = "0x56E6D0", VA = "0x18056FAD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001C7D RID: 7293
		// (get) Token: 0x0600E2FF RID: 58111 RVA: 0x000524A0 File Offset: 0x000506A0
		[Token(Token = "0x17001C7D")]
		[Inspect]
		[ReadOnly]
		private int teamOnSceneRightCount
		{
			[Token(Token = "0x600E2FF")]
			[Address(RVA = "0x56FB40", Offset = "0x56E740", VA = "0x18056FB40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001C7E RID: 7294
		// (get) Token: 0x0600E300 RID: 58112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C7E")]
		private CameraEffect safeZoneCameraEffect
		{
			[Token(Token = "0x600E300")]
			[Address(RVA = "0x56F9C0", Offset = "0x56E5C0", VA = "0x18056F9C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C7F RID: 7295
		// (get) Token: 0x0600E301 RID: 58113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C7F")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E301")]
			[Address(RVA = "0x56F460", Offset = "0x56E060", VA = "0x18056F460", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E302 RID: 58114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E302")]
		[Address(RVA = "0x56BD00", Offset = "0x56A900", VA = "0x18056BD00", Slot = "7")]
		public override void Init(GlobalEnvSystem envSystem)
		{
		}

		// Token: 0x0600E303 RID: 58115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E303")]
		[Address(RVA = "0x56BF60", Offset = "0x56AB60", VA = "0x18056BF60", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E304 RID: 58116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E304")]
		[Address(RVA = "0x56BC60", Offset = "0x56A860", VA = "0x18056BC60", Slot = "9")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600E305 RID: 58117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E305")]
		[Address(RVA = "0x56BBC0", Offset = "0x56A7C0", VA = "0x18056BBC0", Slot = "10")]
		public override void GatherBuffs(List<BuffData> buffs)
		{
		}

		// Token: 0x0600E306 RID: 58118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E306")]
		[Address(RVA = "0x56DF60", Offset = "0x56CB60", VA = "0x18056DF60")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600E307 RID: 58119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E307")]
		[Address(RVA = "0x56E160", Offset = "0x56CD60", VA = "0x18056E160")]
		private void _OnUnitFinish(object arg)
		{
		}

		// Token: 0x0600E308 RID: 58120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E308")]
		[Address(RVA = "0x56E580", Offset = "0x56D180", VA = "0x18056E580")]
		private void _OnWaveWillStart(object arg)
		{
		}

		// Token: 0x0600E309 RID: 58121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E309")]
		[Address(RVA = "0x56E490", Offset = "0x56D090", VA = "0x18056E490")]
		public void _OnWaveWillFinish(object arg)
		{
		}

		// Token: 0x0600E30A RID: 58122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E30A")]
		[Address(RVA = "0x56D660", Offset = "0x56C260", VA = "0x18056D660")]
		private void _OnGameOver(object arg)
		{
		}

		// Token: 0x0600E30B RID: 58123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E30B")]
		[Address(RVA = "0x56C810", Offset = "0x56B410", VA = "0x18056C810")]
		private void _InitSafeZone()
		{
		}

		// Token: 0x0600E30C RID: 58124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E30C")]
		[Address(RVA = "0x56DA60", Offset = "0x56C660", VA = "0x18056DA60")]
		private void _OnRoundStartSafeZone()
		{
		}

		// Token: 0x0600E30D RID: 58125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E30D")]
		[Address(RVA = "0x56E200", Offset = "0x56CE00", VA = "0x18056E200")]
		private void _OnWaveWillFinishSafeZone()
		{
		}

		// Token: 0x0600E30E RID: 58126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E30E")]
		[Address(RVA = "0x56E750", Offset = "0x56D350", VA = "0x18056E750")]
		private void _SafeZoneTick(FP deltaTime)
		{
		}

		// Token: 0x0600E30F RID: 58127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E30F")]
		[Address(RVA = "0x56D4D0", Offset = "0x56C0D0", VA = "0x18056D4D0")]
		private void _OnGameOverSafeZone()
		{
		}

		// Token: 0x0600E310 RID: 58128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E310")]
		[Address(RVA = "0x56C4A0", Offset = "0x56B0A0", VA = "0x18056C4A0")]
		private List<DynamicBuffTileFixed> _GetDangerZoneTilesByLevel(int level)
		{
			return null;
		}

		// Token: 0x0600E311 RID: 58129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E311")]
		[Address(RVA = "0x56BD90", Offset = "0x56A990", VA = "0x18056BD90")]
		public void OnEventReportCombat(IUseTeamSide teamSideEnemy)
		{
		}

		// Token: 0x0600E312 RID: 58130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E312")]
		[Address(RVA = "0x56BB20", Offset = "0x56A720", VA = "0x18056BB20")]
		public void DoSurpriseAttackerSpawnForSingleSide(bool isLeft)
		{
		}

		// Token: 0x0600E313 RID: 58131 RVA: 0x000524B8 File Offset: 0x000506B8
		[Token(Token = "0x600E313")]
		[Address(RVA = "0x56CF40", Offset = "0x56BB40", VA = "0x18056CF40")]
		private static bool _MoveBranch(bool isLeft)
		{
			return default(bool);
		}

		// Token: 0x0600E314 RID: 58132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E314")]
		[Address(RVA = "0x56D000", Offset = "0x56BC00", VA = "0x18056D000")]
		private void _OnEnemyBorn(IUseTeamSide teamSideEnemy)
		{
		}

		// Token: 0x0600E315 RID: 58133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E315")]
		[Address(RVA = "0x56D190", Offset = "0x56BD90", VA = "0x18056D190")]
		private void _OnEnemyFinish(IUseTeamSide teamSideEnemy)
		{
		}

		// Token: 0x0600E316 RID: 58134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E316")]
		[Address(RVA = "0x56DCC0", Offset = "0x56C8C0", VA = "0x18056DCC0")]
		private void _OnRoundStartSurpriseAttacker()
		{
		}

		// Token: 0x0600E317 RID: 58135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E317")]
		[Address(RVA = "0x56E410", Offset = "0x56D010", VA = "0x18056E410")]
		private void _OnWaveWillFinishSurpriseAttacker()
		{
		}

		// Token: 0x0600E318 RID: 58136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E318")]
		[Address(RVA = "0x56EB90", Offset = "0x56D790", VA = "0x18056EB90")]
		private void _SurpriseAttackerTick(FP deltaTime)
		{
		}

		// Token: 0x0600E319 RID: 58137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E319")]
		[Address(RVA = "0x56DE20", Offset = "0x56CA20", VA = "0x18056DE20")]
		private void _OnTeamReportCombatRatioReached(bool isLeft)
		{
		}

		// Token: 0x0600E31A RID: 58138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E31A")]
		[Address(RVA = "0x56DEC0", Offset = "0x56CAC0", VA = "0x18056DEC0")]
		private void _OnTeamValueZero(bool isLeft)
		{
		}

		// Token: 0x0600E31B RID: 58139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E31B")]
		[Address(RVA = "0x56CD10", Offset = "0x56B910", VA = "0x18056CD10")]
		private void _InitSurpriseAttacker()
		{
		}

		// Token: 0x0600E31C RID: 58140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E31C")]
		[Address(RVA = "0x56EFA0", Offset = "0x56DBA0", VA = "0x18056EFA0")]
		private void _UpdateTeamValue(bool isLeft)
		{
		}

		// Token: 0x0600E31D RID: 58141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E31D")]
		[Address(RVA = "0x56C000", Offset = "0x56AC00", VA = "0x18056C000")]
		private void _CalculateTotalTeamValue(bool isLeft)
		{
		}

		// Token: 0x0600E31E RID: 58142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E31E")]
		[Address(RVA = "0x56C360", Offset = "0x56AF60", VA = "0x18056C360")]
		private void _DoSurpriseAttackerSpawn()
		{
		}

		// Token: 0x0600E31F RID: 58143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E31F")]
		[Address(RVA = "0x56C1B0", Offset = "0x56ADB0", VA = "0x18056C1B0")]
		private void _DiceSurpriseAttacker()
		{
		}

		// Token: 0x0600E320 RID: 58144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E320")]
		[Address(RVA = "0x56D850", Offset = "0x56C450", VA = "0x18056D850")]
		private void _OnRoundStartBuff()
		{
		}

		// Token: 0x0600E321 RID: 58145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E321")]
		[Address(RVA = "0x56F0B0", Offset = "0x56DCB0", VA = "0x18056F0B0")]
		public EnemyDuelBattleManager()
		{
		}

		// Token: 0x0600E322 RID: 58146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E322")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0600E323 RID: 58147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E323")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E324 RID: 58148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E324")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600E325 RID: 58149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E325")]
		[Address(RVA = "0x550BD0", Offset = "0x54F7D0", VA = "0x180550BD0")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x0600E326 RID: 58150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E326")]
		[Address(RVA = "0x550BC0", Offset = "0x54F7C0", VA = "0x180550BC0")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x0400F900 RID: 63744
		[Token(Token = "0x400F900")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("缩圈")]
		private bool _enableSafeZone;

		// Token: 0x0400F901 RID: 63745
		[Token(Token = "0x400F901")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("缩圈")]
		[Tooltip("Buff地块Key")]
		private List<string> _buffTileKeyList;

		// Token: 0x0400F902 RID: 63746
		[Token(Token = "0x400F902")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("缩圈")]
		[Tooltip("特效")]
		private List<string> _effectList;

		// Token: 0x0400F903 RID: 63747
		[Token(Token = "0x400F903")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("缩圈")]
		[Tooltip("特效位置")]
		private Vector3 _position;

		// Token: 0x0400F904 RID: 63748
		[Token(Token = "0x400F904")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("缩圈")]
		[Tooltip("屏幕特效")]
		private string _cameraEffect;

		// Token: 0x0400F905 RID: 63749
		[Token(Token = "0x400F905")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("缩圈")]
		[Tooltip("第一次缩圈时间")]
		private float _firstSafeZoneInterval;

		// Token: 0x0400F906 RID: 63750
		[Token(Token = "0x400F906")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[Group("缩圈")]
		[Tooltip("缩圈时间")]
		private float _interval;

		// Token: 0x0400F907 RID: 63751
		[Token(Token = "0x400F907")]
		[FieldOffset(Offset = "0x60")]
		[Group("奇袭")]
		[Tooltip("出生延迟Key")]
		[SerializeField]
		private string _surpriseAttackerSpawnDelayKey;

		// Token: 0x0400F908 RID: 63752
		[Token(Token = "0x400F908")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("奇袭")]
		[Tooltip("出生延迟")]
		private float _surpriseAttackerSpawnDelay;

		// Token: 0x0400F909 RID: 63753
		[Token(Token = "0x400F909")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("奇袭")]
		[Tooltip("基础概率Key")]
		private string _surpriseAttackerBaseProbKey;

		// Token: 0x0400F90A RID: 63754
		[Token(Token = "0x400F90A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("奇袭")]
		[Tooltip("基础概率")]
		private float _surpriseAttackerBaseProb;

		// Token: 0x0400F90B RID: 63755
		[Token(Token = "0x400F90B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("奇袭")]
		[Tooltip("接敌增加概率Key")]
		private string _surpriseAttackerProbAddWhenHurtKey;

		// Token: 0x0400F90C RID: 63756
		[Token(Token = "0x400F90C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("奇袭")]
		[Tooltip("接敌增加概率")]
		private float _surpriseAttackerProbAddWhenHurt;

		// Token: 0x0400F90D RID: 63757
		[Token(Token = "0x400F90D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("奇袭")]
		[Tooltip("战损比例增加概率Key")]
		private string _surpriseAttackerProbAddBattleLossRatioKey;

		// Token: 0x0400F90E RID: 63758
		[Token(Token = "0x400F90E")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("奇袭")]
		[Tooltip("战损比例增加概率")]
		private float _surpriseAttackerProbAddBattleLossRatio;

		// Token: 0x0400F90F RID: 63759
		[Token(Token = "0x400F90F")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("奇袭")]
		[Tooltip("战力比例增加概率Key")]
		private string _surpriseAttackerProbAddBattleValueRatioKey;

		// Token: 0x0400F910 RID: 63760
		[Token(Token = "0x400F910")]
		[FieldOffset(Offset = "0xA8")]
		[Group("奇袭")]
		[Tooltip("战力比例增加概率")]
		[SerializeField]
		private float _surpriseAttackerProbAddBattleValueRatio;

		// Token: 0x0400F911 RID: 63761
		[Token(Token = "0x400F911")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("奇袭")]
		[Tooltip("接敌比例Key")]
		private string _teamCountRatioKey;

		// Token: 0x0400F912 RID: 63762
		[Token(Token = "0x400F912")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("奇袭")]
		[Tooltip("接敌比例")]
		private float _teamCountRatio;

		// Token: 0x0400F913 RID: 63763
		[Token(Token = "0x400F913")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("奇袭")]
		[Tooltip("战损比例Key")]
		private string _battleLossRatioKey;

		// Token: 0x0400F914 RID: 63764
		[Token(Token = "0x400F914")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("奇袭")]
		[Tooltip("战损比例")]
		private float _battleLossRatio;

		// Token: 0x0400F915 RID: 63765
		[Token(Token = "0x400F915")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("奇袭")]
		[Tooltip("战力比例Key")]
		private string _battleValueRatioKey;

		// Token: 0x0400F916 RID: 63766
		[Token(Token = "0x400F916")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("奇袭")]
		[Tooltip("战力比例")]
		private float _battleValueRatio;

		// Token: 0x0400F917 RID: 63767
		[Token(Token = "0x400F917")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("奇袭")]
		[Tooltip("检测间隔Key")]
		private string _surpriseAttackerIntervalKey;

		// Token: 0x0400F918 RID: 63768
		[Token(Token = "0x400F918")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("奇袭")]
		[Tooltip("检测间隔")]
		private float _surpriseAttackerInterval;

		// Token: 0x0400F919 RID: 63769
		[Token(Token = "0x400F919")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private BuffData[] _roundStartbuffs;

		// Token: 0x0400F91A RID: 63770
		[Token(Token = "0x400F91A")]
		[FieldOffset(Offset = "0xF8")]
		[Inspect]
		[ReadOnly]
		private int m_zoneLevel;

		// Token: 0x0400F91B RID: 63771
		[Token(Token = "0x400F91B")]
		[FieldOffset(Offset = "0xFC")]
		private bool m_enableSafeZone;

		// Token: 0x0400F91C RID: 63772
		[Token(Token = "0x400F91C")]
		[FieldOffset(Offset = "0x100")]
		private int m_mapWidth;

		// Token: 0x0400F91D RID: 63773
		[Token(Token = "0x400F91D")]
		[FieldOffset(Offset = "0x104")]
		private int m_mapHeight;

		// Token: 0x0400F91E RID: 63774
		[Token(Token = "0x400F91E")]
		[FieldOffset(Offset = "0x108")]
		private float m_safeZoneInterval;

		// Token: 0x0400F91F RID: 63775
		[Token(Token = "0x400F91F")]
		[FieldOffset(Offset = "0x10C")]
		private float m_firstSafeZoneInterval;

		// Token: 0x0400F920 RID: 63776
		[Token(Token = "0x400F920")]
		[FieldOffset(Offset = "0x110")]
		[Inspect]
		[ReadOnly]
		private bool m_isRoundOn;

		// Token: 0x0400F921 RID: 63777
		[Token(Token = "0x400F921")]
		[FieldOffset(Offset = "0x118")]
		private Effect m_safeZoneEffect;

		// Token: 0x0400F922 RID: 63778
		[Token(Token = "0x400F922")]
		[FieldOffset(Offset = "0x120")]
		private CameraEffect m_safeZoneCameraEffect;

		// Token: 0x0400F923 RID: 63779
		[Token(Token = "0x400F923")]
		[FieldOffset(Offset = "0x128")]
		private readonly PeriodicTimer m_intervalTickerSafeZone;

		// Token: 0x0400F924 RID: 63780
		[Token(Token = "0x400F924")]
		[FieldOffset(Offset = "0x130")]
		private readonly List<DynamicBuffTileFixed> m_tiles;

		// Token: 0x0400F925 RID: 63781
		[Token(Token = "0x400F925")]
		[FieldOffset(Offset = "0x138")]
		private readonly List<List<DynamicBuffTileFixed>> m_dangerZoneList;

		// Token: 0x0400F926 RID: 63782
		[Token(Token = "0x400F926")]
		[FieldOffset(Offset = "0x140")]
		[Inspect]
		[ReadOnly]
		private EnemyDuelBattleManager.TeamProbParms m_teamProbParmsLeft;

		// Token: 0x0400F927 RID: 63783
		[Token(Token = "0x400F927")]
		[FieldOffset(Offset = "0x158")]
		[Inspect]
		[ReadOnly]
		private EnemyDuelBattleManager.TeamProbParms m_teamProbParmsRight;

		// Token: 0x0400F928 RID: 63784
		[Token(Token = "0x400F928")]
		[FieldOffset(Offset = "0x170")]
		private float m_surpriseAttackerSpawnDelay;

		// Token: 0x0400F929 RID: 63785
		[Token(Token = "0x400F929")]
		[FieldOffset(Offset = "0x174")]
		private float m_surpriseAttackerBaseProb;

		// Token: 0x0400F92A RID: 63786
		[Token(Token = "0x400F92A")]
		[FieldOffset(Offset = "0x178")]
		private float m_surpriseAttackerProbAddWhenHurt;

		// Token: 0x0400F92B RID: 63787
		[Token(Token = "0x400F92B")]
		[FieldOffset(Offset = "0x17C")]
		private float m_surpriseAttackerProbAddBattleLossRatio;

		// Token: 0x0400F92C RID: 63788
		[Token(Token = "0x400F92C")]
		[FieldOffset(Offset = "0x180")]
		private float m_surpriseAttackerProbAddBattleValueRatio;

		// Token: 0x0400F92D RID: 63789
		[Token(Token = "0x400F92D")]
		[FieldOffset(Offset = "0x184")]
		private float m_surpriseAttackerInterval;

		// Token: 0x0400F92E RID: 63790
		[Token(Token = "0x400F92E")]
		[FieldOffset(Offset = "0x188")]
		private float m_battleLossRatio;

		// Token: 0x0400F92F RID: 63791
		[Token(Token = "0x400F92F")]
		[FieldOffset(Offset = "0x18C")]
		private float m_battleValueRatio;

		// Token: 0x0400F930 RID: 63792
		[Token(Token = "0x400F930")]
		[FieldOffset(Offset = "0x190")]
		private readonly PeriodicTimer m_intervalTickerSurpriseAttackerProb;

		// Token: 0x0400F931 RID: 63793
		[Token(Token = "0x400F931")]
		[FieldOffset(Offset = "0x198")]
		private readonly PeriodicTimer m_intervalTickerSurpriseAttackerSpawn;

		// Token: 0x0400F932 RID: 63794
		[Token(Token = "0x400F932")]
		[FieldOffset(Offset = "0x1A0")]
		private GameModeFactory.EnemyDuelGameMode m_gameMode;

		// Token: 0x0400F933 RID: 63795
		[Token(Token = "0x400F933")]
		public const string ENV_SYSTEM_KEY = "env_025_act1enemyduel";

		// Token: 0x0400F934 RID: 63796
		[Token(Token = "0x400F934")]
		private const int SAFE_ZONE_ROW_CONST = 2;

		// Token: 0x0400F935 RID: 63797
		[Token(Token = "0x400F935")]
		private const int SAFE_ZONE_COL_CONST = 3;

		// Token: 0x0400F936 RID: 63798
		[Token(Token = "0x400F936")]
		private const int MAX_ZONE_LEVEL = 5;

		// Token: 0x0400F937 RID: 63799
		[Token(Token = "0x400F937")]
		private const float SURPRISE_ATTACKER_PROB_FULL = 1f;

		// Token: 0x0400F938 RID: 63800
		[Token(Token = "0x400F938")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_gameMode;

		// Token: 0x0400F939 RID: 63801
		[Token(Token = "0x400F939")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_teamOnSceneLeftCount;

		// Token: 0x0400F93A RID: 63802
		[Token(Token = "0x400F93A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_teamOnSceneRightCount;

		// Token: 0x0400F93B RID: 63803
		[Token(Token = "0x400F93B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_safeZoneCameraEffect;

		// Token: 0x0400F93C RID: 63804
		[Token(Token = "0x400F93C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400F93D RID: 63805
		[Token(Token = "0x400F93D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F93E RID: 63806
		[Token(Token = "0x400F93E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F93F RID: 63807
		[Token(Token = "0x400F93F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400F940 RID: 63808
		[Token(Token = "0x400F940")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x0400F941 RID: 63809
		[Token(Token = "0x400F941")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0400F942 RID: 63810
		[Token(Token = "0x400F942")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnUnitFinish;

		// Token: 0x0400F943 RID: 63811
		[Token(Token = "0x400F943")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnWaveWillStart;

		// Token: 0x0400F944 RID: 63812
		[Token(Token = "0x400F944")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnWaveWillFinish;

		// Token: 0x0400F945 RID: 63813
		[Token(Token = "0x400F945")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnGameOver;

		// Token: 0x0400F946 RID: 63814
		[Token(Token = "0x400F946")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__InitSafeZone;

		// Token: 0x0400F947 RID: 63815
		[Token(Token = "0x400F947")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnRoundStartSafeZone;

		// Token: 0x0400F948 RID: 63816
		[Token(Token = "0x400F948")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnWaveWillFinishSafeZone;

		// Token: 0x0400F949 RID: 63817
		[Token(Token = "0x400F949")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__SafeZoneTick;

		// Token: 0x0400F94A RID: 63818
		[Token(Token = "0x400F94A")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnGameOverSafeZone;

		// Token: 0x0400F94B RID: 63819
		[Token(Token = "0x400F94B")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__GetDangerZoneTilesByLevel;

		// Token: 0x0400F94C RID: 63820
		[Token(Token = "0x400F94C")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnEventReportCombat;

		// Token: 0x0400F94D RID: 63821
		[Token(Token = "0x400F94D")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_DoSurpriseAttackerSpawnForSingleSide;

		// Token: 0x0400F94E RID: 63822
		[Token(Token = "0x400F94E")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__MoveBranch;

		// Token: 0x0400F94F RID: 63823
		[Token(Token = "0x400F94F")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnEnemyBorn;

		// Token: 0x0400F950 RID: 63824
		[Token(Token = "0x400F950")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnEnemyFinish;

		// Token: 0x0400F951 RID: 63825
		[Token(Token = "0x400F951")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__OnRoundStartSurpriseAttacker;

		// Token: 0x0400F952 RID: 63826
		[Token(Token = "0x400F952")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__OnWaveWillFinishSurpriseAttacker;

		// Token: 0x0400F953 RID: 63827
		[Token(Token = "0x400F953")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__SurpriseAttackerTick;

		// Token: 0x0400F954 RID: 63828
		[Token(Token = "0x400F954")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__OnTeamReportCombatRatioReached;

		// Token: 0x0400F955 RID: 63829
		[Token(Token = "0x400F955")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__OnTeamValueZero;

		// Token: 0x0400F956 RID: 63830
		[Token(Token = "0x400F956")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__InitSurpriseAttacker;

		// Token: 0x0400F957 RID: 63831
		[Token(Token = "0x400F957")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__UpdateTeamValue;

		// Token: 0x0400F958 RID: 63832
		[Token(Token = "0x400F958")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__CalculateTotalTeamValue;

		// Token: 0x0400F959 RID: 63833
		[Token(Token = "0x400F959")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__DoSurpriseAttackerSpawn;

		// Token: 0x0400F95A RID: 63834
		[Token(Token = "0x400F95A")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__DiceSurpriseAttacker;

		// Token: 0x0400F95B RID: 63835
		[Token(Token = "0x400F95B")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__OnRoundStartBuff;

		// Token: 0x0400F95C RID: 63836
		[Token(Token = "0x400F95C")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200231E RID: 8990
		[Token(Token = "0x200231E")]
		[Serializable]
		private struct TeamProbParms
		{
			// Token: 0x0600E327 RID: 58151 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E327")]
			[Address(RVA = "0x57E8E0", Offset = "0x57D4E0", VA = "0x18057E8E0")]
			public void Reset()
			{
			}

			// Token: 0x0400F95D RID: 63837
			[Token(Token = "0x400F95D")]
			[FieldOffset(Offset = "0x0")]
			public float curProb;

			// Token: 0x0400F95E RID: 63838
			[Token(Token = "0x400F95E")]
			[FieldOffset(Offset = "0x4")]
			public float curTeamValue;

			// Token: 0x0400F95F RID: 63839
			[Token(Token = "0x400F95F")]
			[FieldOffset(Offset = "0x8")]
			public float totalTeamValue;

			// Token: 0x0400F960 RID: 63840
			[Token(Token = "0x400F960")]
			[FieldOffset(Offset = "0xC")]
			public bool lossRatioAdded;

			// Token: 0x0400F961 RID: 63841
			[Token(Token = "0x400F961")]
			[FieldOffset(Offset = "0xD")]
			public bool valueRatioAdded;

			// Token: 0x0400F962 RID: 63842
			[Token(Token = "0x400F962")]
			[FieldOffset(Offset = "0x10")]
			public int combatedCount;

			// Token: 0x0400F963 RID: 63843
			[Token(Token = "0x400F963")]
			[FieldOffset(Offset = "0x14")]
			public bool teamCountAdded;

			// Token: 0x0400F964 RID: 63844
			[Token(Token = "0x400F964")]
			[FieldOffset(Offset = "0x15")]
			public bool branchMoved;
		}
	}
}
