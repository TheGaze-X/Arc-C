using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Activity.Act49side.Battle.UI;
using Torappu.Battle.Action;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020022E1 RID: 8929
	[Token(Token = "0x20022E1")]
	public class Act49SideLevelBossManager : GlobalEnvSystem.EnvManager, IBuffSource, IHotfixable, IEffectSource
	{
		// Token: 0x17001C3E RID: 7230
		// (get) Token: 0x0600E13C RID: 57660 RVA: 0x00051B58 File Offset: 0x0004FD58
		[Token(Token = "0x17001C3E")]
		public bool isHeadRoomFinished
		{
			[Token(Token = "0x600E13C")]
			[Address(RVA = "0x36962A0", Offset = "0x3694EA0", VA = "0x1836962A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001C3F RID: 7231
		// (get) Token: 0x0600E13D RID: 57661 RVA: 0x00051B70 File Offset: 0x0004FD70
		[Token(Token = "0x17001C3F")]
		public bool isTailRoomFinished
		{
			[Token(Token = "0x600E13D")]
			[Address(RVA = "0x3696480", Offset = "0x3695080", VA = "0x183696480")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001C40 RID: 7232
		// (get) Token: 0x0600E13E RID: 57662 RVA: 0x00051B88 File Offset: 0x0004FD88
		[Token(Token = "0x17001C40")]
		public bool isLeftHandRoomFinished
		{
			[Token(Token = "0x600E13E")]
			[Address(RVA = "0x3696340", Offset = "0x3694F40", VA = "0x183696340")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001C41 RID: 7233
		// (get) Token: 0x0600E13F RID: 57663 RVA: 0x00051BA0 File Offset: 0x0004FDA0
		[Token(Token = "0x17001C41")]
		public bool isRightHandRoomFinished
		{
			[Token(Token = "0x600E13F")]
			[Address(RVA = "0x36963E0", Offset = "0x3694FE0", VA = "0x1836963E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001C42 RID: 7234
		// (get) Token: 0x0600E140 RID: 57664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C42")]
		public Act49SidePrintingManager printManager
		{
			[Token(Token = "0x600E140")]
			[Address(RVA = "0x3696520", Offset = "0x3695120", VA = "0x183696520")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C43 RID: 7235
		// (get) Token: 0x0600E141 RID: 57665 RVA: 0x00051BB8 File Offset: 0x0004FDB8
		[Token(Token = "0x17001C43")]
		public bool fullyUnsealed
		{
			[Token(Token = "0x600E141")]
			[Address(RVA = "0x3696210", Offset = "0x3694E10", VA = "0x183696210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600E142 RID: 57666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E142")]
		[Address(RVA = "0x368D7A0", Offset = "0x368C3A0", VA = "0x18368D7A0", Slot = "10")]
		public override void GatherBuffs(List<BuffData> buffs)
		{
		}

		// Token: 0x0600E143 RID: 57667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E143")]
		[Address(RVA = "0x368D870", Offset = "0x368C470", VA = "0x18368D870", Slot = "9")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600E144 RID: 57668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E144")]
		[Address(RVA = "0x368DE80", Offset = "0x368CA80", VA = "0x18368DE80", Slot = "7")]
		public override void Init(GlobalEnvSystem system)
		{
		}

		// Token: 0x0600E145 RID: 57669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E145")]
		[Address(RVA = "0x368F130", Offset = "0x368DD30", VA = "0x18368F130", Slot = "8")]
		public override void OnPostInit()
		{
		}

		// Token: 0x0600E146 RID: 57670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E146")]
		[Address(RVA = "0x368F220", Offset = "0x368DE20", VA = "0x18368F220", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E147 RID: 57671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E147")]
		[Address(RVA = "0x368EF40", Offset = "0x368DB40", VA = "0x18368EF40", Slot = "13")]
		public override void OnEnvDestroy()
		{
		}

		// Token: 0x0600E148 RID: 57672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E148")]
		[Address(RVA = "0x368B900", Offset = "0x368A500", VA = "0x18368B900")]
		public void DoMoveCamera(Vector3 offset, string distinationType)
		{
		}

		// Token: 0x0600E149 RID: 57673 RVA: 0x00051BD0 File Offset: 0x0004FDD0
		[Token(Token = "0x600E149")]
		[Address(RVA = "0x368FC80", Offset = "0x368E880", VA = "0x18368FC80")]
		public bool RegisterEnemy(Enemy enemy)
		{
			return default(bool);
		}

		// Token: 0x0600E14A RID: 57674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E14A")]
		[Address(RVA = "0x368B6C0", Offset = "0x368A2C0", VA = "0x18368B6C0")]
		public void DeregisterEnemy(Enemy enemy)
		{
		}

		// Token: 0x0600E14B RID: 57675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E14B")]
		[Address(RVA = "0x368E6F0", Offset = "0x368D2F0", VA = "0x18368E6F0")]
		public void InterruptSubRoom(Enemy enemy)
		{
		}

		// Token: 0x0600E14C RID: 57676 RVA: 0x00051BE8 File Offset: 0x0004FDE8
		[Token(Token = "0x600E14C")]
		[Address(RVA = "0x368B2A0", Offset = "0x3689EA0", VA = "0x18368B2A0")]
		public bool CheckBossPartSealed(string partName)
		{
			return default(bool);
		}

		// Token: 0x0600E14D RID: 57677 RVA: 0x00051C00 File Offset: 0x0004FE00
		[Token(Token = "0x600E14D")]
		[Address(RVA = "0x368F710", Offset = "0x368E310", VA = "0x18368F710")]
		public Act49SideBattleBossLevelUIPlugin.Act49SideBossLevelUIState QueryBossLevelUIState()
		{
			return default(Act49SideBattleBossLevelUIPlugin.Act49SideBossLevelUIState);
		}

		// Token: 0x0600E14E RID: 57678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E14E")]
		[Address(RVA = "0x36901E0", Offset = "0x368EDE0", VA = "0x1836901E0")]
		public void SummonHolderTraps(Enemy enemy, string partName)
		{
		}

		// Token: 0x0600E14F RID: 57679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E14F")]
		[Address(RVA = "0x368B400", Offset = "0x368A000", VA = "0x18368B400")]
		public void ClearHolderTraps(Enemy enemy, string partName)
		{
		}

		// Token: 0x0600E150 RID: 57680 RVA: 0x00051C18 File Offset: 0x0004FE18
		[Token(Token = "0x600E150")]
		[Address(RVA = "0x368B200", Offset = "0x3689E00", VA = "0x18368B200")]
		public bool CanTriggerSunmaoTrapSkill()
		{
			return default(bool);
		}

		// Token: 0x0600E151 RID: 57681 RVA: 0x00051C30 File Offset: 0x0004FE30
		[Token(Token = "0x600E151")]
		[Address(RVA = "0x368F390", Offset = "0x368DF90", VA = "0x18368F390")]
		public bool OnTrapSunmaoSkillTriggered(Trap trap, string param)
		{
			return default(bool);
		}

		// Token: 0x0600E152 RID: 57682 RVA: 0x00051C48 File Offset: 0x0004FE48
		[Token(Token = "0x600E152")]
		[Address(RVA = "0x368CAC0", Offset = "0x368B6C0", VA = "0x18368CAC0")]
		public GridPosition FindTargetHead(Enemy boss)
		{
			return default(GridPosition);
		}

		// Token: 0x0600E153 RID: 57683 RVA: 0x00051C60 File Offset: 0x0004FE60
		[Token(Token = "0x600E153")]
		[Address(RVA = "0x368CD80", Offset = "0x368B980", VA = "0x18368CD80")]
		public GridPosition FindTargetLeftHand(Enemy boss)
		{
			return default(GridPosition);
		}

		// Token: 0x0600E154 RID: 57684 RVA: 0x00051C78 File Offset: 0x0004FE78
		[Token(Token = "0x600E154")]
		[Address(RVA = "0x368D040", Offset = "0x368BC40", VA = "0x18368D040")]
		public GridPosition FindTargetRightHand(Enemy boss)
		{
			return default(GridPosition);
		}

		// Token: 0x0600E155 RID: 57685 RVA: 0x00051C90 File Offset: 0x0004FE90
		[Token(Token = "0x600E155")]
		[Address(RVA = "0x368D310", Offset = "0x368BF10", VA = "0x18368D310")]
		public GridPosition FindTargetTail(Enemy boss)
		{
			return default(GridPosition);
		}

		// Token: 0x0600E156 RID: 57686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E156")]
		[Address(RVA = "0x3691B30", Offset = "0x3690730", VA = "0x183691B30")]
		public void UpdateRectSkillTileList(List<Tile> tiles, GridPosition anchor, int leftBound, int rightBound, int topBound, int bottomBound)
		{
		}

		// Token: 0x0600E157 RID: 57687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E157")]
		[Address(RVA = "0x3691D30", Offset = "0x3690930", VA = "0x183691D30")]
		public void UpdateTailSkillTileList()
		{
		}

		// Token: 0x0600E158 RID: 57688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E158")]
		[Address(RVA = "0x368A560", Offset = "0x3689160", VA = "0x18368A560")]
		public void ApplyDamageToTargetTiles(Enemy source, List<Tile> tiles, DamageType damageType, float atkScale, SourceApplyWay applyWay = SourceApplyWay.MELEE, Modifier.SourceAttackType attackType = Modifier.SourceAttackType.SPLASH)
		{
		}

		// Token: 0x0600E159 RID: 57689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E159")]
		[Address(RVA = "0x368BDD0", Offset = "0x368A9D0", VA = "0x18368BDD0")]
		public void FindSkillFocusGrid(Enemy enemy, string partName)
		{
		}

		// Token: 0x0600E15A RID: 57690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E15A")]
		[Address(RVA = "0x3690060", Offset = "0x368EC60", VA = "0x183690060")]
		public void SetDefaultSkillFocusGrid(string partName, GridPosition pos)
		{
		}

		// Token: 0x0600E15B RID: 57691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E15B")]
		[Address(RVA = "0x368AAE0", Offset = "0x36896E0", VA = "0x18368AAE0")]
		public void ApplySkillDamage(Enemy source, string partName, DamageType damageType, float atkScale, SourceApplyWay applyWay = SourceApplyWay.MELEE, Modifier.SourceAttackType attackType = Modifier.SourceAttackType.SPLASH)
		{
		}

		// Token: 0x0600E15C RID: 57692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E15C")]
		[Address(RVA = "0x368B040", Offset = "0x3689C40", VA = "0x18368B040")]
		public void BossTailChargeEnemySummonCnt(int cnt)
		{
		}

		// Token: 0x0600E15D RID: 57693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E15D")]
		[Address(RVA = "0x368B160", Offset = "0x3689D60", VA = "0x18368B160")]
		public void BossTailSetSummonEnemyInterval(float interval)
		{
		}

		// Token: 0x0600E15E RID: 57694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E15E")]
		[Address(RVA = "0x368DB10", Offset = "0x368C710", VA = "0x18368DB10")]
		public Tile GetBossHeadSkillTargetTile()
		{
			return null;
		}

		// Token: 0x0600E15F RID: 57695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E15F")]
		[Address(RVA = "0x368DA70", Offset = "0x368C670", VA = "0x18368DA70")]
		public List<ActionNode> GetBossHeadSkillActionWhenReachedTarget()
		{
			return null;
		}

		// Token: 0x0600E160 RID: 57696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E160")]
		[Address(RVA = "0x368FF80", Offset = "0x368EB80", VA = "0x18368FF80")]
		public void ResetHeadSkillDotTimerAndClearHeadSkillRangeEffect()
		{
		}

		// Token: 0x0600E161 RID: 57697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E161")]
		[Address(RVA = "0x368E920", Offset = "0x368D520", VA = "0x18368E920")]
		public void OnBossHeadSkillReached(Enemy source)
		{
		}

		// Token: 0x0600E162 RID: 57698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E162")]
		[Address(RVA = "0x368DBC0", Offset = "0x368C7C0", VA = "0x18368DBC0")]
		public void HeadBossSetParams(Enemy boss, float mainAttackAtkScale, float dotAttackAtkScale, float mainAttackEleAtkScale, float dotAttackEleAtkScale, float dotAttackDuration, float dotAttackTriggerInterval, float doomCountDown)
		{
		}

		// Token: 0x0600E163 RID: 57699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E163")]
		[Address(RVA = "0x368F990", Offset = "0x368E590", VA = "0x18368F990")]
		public void RegistBossPart(Enemy boss, string partName)
		{
		}

		// Token: 0x0600E164 RID: 57700 RVA: 0x00051CA8 File Offset: 0x0004FEA8
		[Token(Token = "0x600E164")]
		[Address(RVA = "0x368A4A0", Offset = "0x36890A0", VA = "0x18368A4A0")]
		public bool ApplyDamageToLevelBoss(Enemy source, ref Modifier modifier)
		{
			return default(bool);
		}

		// Token: 0x0600E165 RID: 57701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E165")]
		[Address(RVA = "0x3691050", Offset = "0x368FC50", VA = "0x183691050")]
		public void UpdateBossSkillWarningEffect(string partName, bool force)
		{
		}

		// Token: 0x0600E166 RID: 57702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E166")]
		[Address(RVA = "0x368D5E0", Offset = "0x368C1E0", VA = "0x18368D5E0")]
		public void FinishBossSkillWarningEffect(string partName)
		{
		}

		// Token: 0x0600E167 RID: 57703 RVA: 0x00051CC0 File Offset: 0x0004FEC0
		[Token(Token = "0x600E167")]
		[Address(RVA = "0x368BB10", Offset = "0x368A710", VA = "0x18368BB10")]
		public bool EnemySheartTriggerSkill(Enemy enemy)
		{
			return default(bool);
		}

		// Token: 0x0600E168 RID: 57704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E168")]
		[Address(RVA = "0x3690AA0", Offset = "0x368F6A0", VA = "0x183690AA0")]
		public void TriggerLevelFinish(float delayToKillAll, float delayToFinishLevel)
		{
		}

		// Token: 0x0600E169 RID: 57705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E169")]
		[Address(RVA = "0x3693C30", Offset = "0x3692830", VA = "0x183693C30")]
		private IEnumerator _KillAllBeforeFinishLevel(float delay)
		{
			return null;
		}

		// Token: 0x0600E16A RID: 57706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E16A")]
		[Address(RVA = "0x36939E0", Offset = "0x36925E0", VA = "0x1836939E0")]
		private IEnumerator _FinishLevel(float delay)
		{
			return null;
		}

		// Token: 0x0600E16B RID: 57707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E16B")]
		[Address(RVA = "0x3694700", Offset = "0x3693300", VA = "0x183694700")]
		private IEnumerator _PlayAudioAtPos(float delay, Vector3 pos, string signal)
		{
			return null;
		}

		// Token: 0x0600E16C RID: 57708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E16C")]
		[Address(RVA = "0x3694400", Offset = "0x3693000", VA = "0x183694400")]
		private IEnumerator _OnHeadSealed()
		{
			return null;
		}

		// Token: 0x0600E16D RID: 57709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E16D")]
		[Address(RVA = "0x3694640", Offset = "0x3693240", VA = "0x183694640")]
		private IEnumerator _OnTailSealed()
		{
			return null;
		}

		// Token: 0x0600E16E RID: 57710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E16E")]
		[Address(RVA = "0x36944C0", Offset = "0x36930C0", VA = "0x1836944C0")]
		private IEnumerator _OnLeftHandSealed()
		{
			return null;
		}

		// Token: 0x0600E16F RID: 57711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E16F")]
		[Address(RVA = "0x3694580", Offset = "0x3693180", VA = "0x183694580")]
		private IEnumerator _OnRightHandSealed()
		{
			return null;
		}

		// Token: 0x0600E170 RID: 57712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E170")]
		[Address(RVA = "0x36926C0", Offset = "0x36912C0", VA = "0x1836926C0")]
		private void _AwakeBoss()
		{
		}

		// Token: 0x0600E171 RID: 57713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E171")]
		[Address(RVA = "0x3694AE0", Offset = "0x36936E0", VA = "0x183694AE0")]
		private void _UpdateSubRoomState()
		{
		}

		// Token: 0x0600E172 RID: 57714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E172")]
		[Address(RVA = "0x3693AA0", Offset = "0x36926A0", VA = "0x183693AA0")]
		private void _HideTrapTjgsdAndTrapCharacterTile()
		{
		}

		// Token: 0x0600E173 RID: 57715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E173")]
		[Address(RVA = "0x3693D10", Offset = "0x3692910", VA = "0x183693D10")]
		private void _OnFinishCameraMove(object param)
		{
		}

		// Token: 0x0600E174 RID: 57716 RVA: 0x00051CD8 File Offset: 0x0004FED8
		[Token(Token = "0x600E174")]
		[Address(RVA = "0x3693150", Offset = "0x3691D50", VA = "0x183693150")]
		private bool _CheckHasAliveEnemyInSubRoom(Dictionary<GridPosition, Tile>.ValueCollection tiles)
		{
			return default(bool);
		}

		// Token: 0x0600E175 RID: 57717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E175")]
		[Address(RVA = "0x3693570", Offset = "0x3692170", VA = "0x183693570")]
		private ReusableList<Entity> _FindAndSortTargets(Enemy boss)
		{
			return null;
		}

		// Token: 0x0600E176 RID: 57718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E176")]
		[Address(RVA = "0x3693080", Offset = "0x3691C80", VA = "0x183693080")]
		private void _BossTailSummonEnemyWhenHitDefaultPos()
		{
		}

		// Token: 0x0600E177 RID: 57719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E177")]
		[Address(RVA = "0x3692130", Offset = "0x3690D30", VA = "0x183692130")]
		private void _ApplyHeadBossSkillDotDmg()
		{
		}

		// Token: 0x0600E178 RID: 57720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E178")]
		[Address(RVA = "0x3694810", Offset = "0x3693410", VA = "0x183694810")]
		private void _SwitchSubRoomTileBuidableType(Dictionary<GridPosition, Tile> tileDict, Dictionary<GridPosition, BuildableType> originDict, bool isReset)
		{
		}

		// Token: 0x0600E179 RID: 57721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E179")]
		[Address(RVA = "0x3693940", Offset = "0x3692540", VA = "0x183693940")]
		private void _FinishBossLockBuff(Effect effect)
		{
		}

		// Token: 0x0600E17A RID: 57722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E17A")]
		[Address(RVA = "0x3695310", Offset = "0x3693F10", VA = "0x183695310")]
		public Act49SideLevelBossManager()
		{
		}

		// Token: 0x0600E17C RID: 57724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E17C")]
		[Address(RVA = "0x550BC0", Offset = "0x54F7C0", VA = "0x180550BC0")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x0600E17D RID: 57725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E17D")]
		[Address(RVA = "0x550BD0", Offset = "0x54F7D0", VA = "0x180550BD0")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x0600E17E RID: 57726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E17E")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E17F RID: 57727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E17F")]
		[Address(RVA = "0x590AE0", Offset = "0x58F6E0", VA = "0x180590AE0")]
		private void <>xLuaBaseProxy_OnPostInit()
		{
		}

		// Token: 0x0600E180 RID: 57728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E180")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600E181 RID: 57729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E181")]
		[Address(RVA = "0x550BF0", Offset = "0x54F7F0", VA = "0x180550BF0")]
		private void <>xLuaBaseProxy_OnEnvDestroy()
		{
		}

		// Token: 0x0400F610 RID: 62992
		[Token(Token = "0x400F610")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string EVENT_SYSTEM_KEY;

		// Token: 0x0400F611 RID: 62993
		[Token(Token = "0x400F611")]
		private const int MAX_COL = 10000;

		// Token: 0x0400F612 RID: 62994
		[Token(Token = "0x400F612")]
		private const int MAX_ROW = 10000;

		// Token: 0x0400F613 RID: 62995
		[Token(Token = "0x400F613")]
		private const int MIN_COL = -1;

		// Token: 0x0400F614 RID: 62996
		[Token(Token = "0x400F614")]
		private const int MIN_ROW = -1;

		// Token: 0x0400F615 RID: 62997
		[Token(Token = "0x400F615")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _headRoomOffsetKey;

		// Token: 0x0400F616 RID: 62998
		[Token(Token = "0x400F616")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _tailRoomOffsetKey;

		// Token: 0x0400F617 RID: 62999
		[Token(Token = "0x400F617")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _rightHandRoomOffsetKey;

		// Token: 0x0400F618 RID: 63000
		[Token(Token = "0x400F618")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _leftHandRoomOffsetKey;

		// Token: 0x0400F619 RID: 63001
		[Token(Token = "0x400F619")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _tileMarkKey;

		// Token: 0x0400F61A RID: 63002
		[Token(Token = "0x400F61A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _headRoomMark;

		// Token: 0x0400F61B RID: 63003
		[Token(Token = "0x400F61B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string _tailRoomMark;

		// Token: 0x0400F61C RID: 63004
		[Token(Token = "0x400F61C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _leftHandRoomMark;

		// Token: 0x0400F61D RID: 63005
		[Token(Token = "0x400F61D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string _rightHandRoomMark;

		// Token: 0x0400F61E RID: 63006
		[Token(Token = "0x400F61E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string _mainFieldMark;

		// Token: 0x0400F61F RID: 63007
		[Token(Token = "0x400F61F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private string _roomWithPrintKey;

		// Token: 0x0400F620 RID: 63008
		[Token(Token = "0x400F620")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private string _holderTrapId;

		// Token: 0x0400F621 RID: 63009
		[Token(Token = "0x400F621")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private BuffData _buffToKillCharacters;

		// Token: 0x0400F622 RID: 63010
		[Token(Token = "0x400F622")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private BuffData _buffToKillEnemies;

		// Token: 0x0400F623 RID: 63011
		[Token(Token = "0x400F623")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private string _finalEnemyMark;

		// Token: 0x0400F624 RID: 63012
		[Token(Token = "0x400F624")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private List<string> _enemyWhiteList;

		// Token: 0x0400F625 RID: 63013
		[Token(Token = "0x400F625")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("branch_id")]
		private string _enemyBranchIdHeadRoom;

		// Token: 0x0400F626 RID: 63014
		[Token(Token = "0x400F626")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("branch_id")]
		private string _enemyBranchIdTailRoom;

		// Token: 0x0400F627 RID: 63015
		[Token(Token = "0x400F627")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("branch_id")]
		private string _enemyBranchIdLeftHandRoom;

		// Token: 0x0400F628 RID: 63016
		[Token(Token = "0x400F628")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("branch_id")]
		private string _enemyBranchIdRightHandRoom;

		// Token: 0x0400F629 RID: 63017
		[Token(Token = "0x400F629")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("branch_id")]
		private string _enemyBranchTriggeredByHPRatio1;

		// Token: 0x0400F62A RID: 63018
		[Token(Token = "0x400F62A")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("branch_id")]
		private string _enemyBranchTriggeredByHPRatio2;

		// Token: 0x0400F62B RID: 63019
		[Token(Token = "0x400F62B")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("branch_id")]
		private string _enemyBranchTailKillUnit;

		// Token: 0x0400F62C RID: 63020
		[Token(Token = "0x400F62C")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("branch_id")]
		private string _enemyBranchTailHitDefault;

		// Token: 0x0400F62D RID: 63021
		[Token(Token = "0x400F62D")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("audio")]
		private string _bossTailHitAudioSignal;

		// Token: 0x0400F62E RID: 63022
		[Token(Token = "0x400F62E")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("audio")]
		private string _bossSkillEffectWarningAudioSignal;

		// Token: 0x0400F62F RID: 63023
		[Token(Token = "0x400F62F")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("audio")]
		private string _bossHeadDeathAudioSignal;

		// Token: 0x0400F630 RID: 63024
		[Token(Token = "0x400F630")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("audio")]
		private string _bossLeftHandDeath1AudioSignal;

		// Token: 0x0400F631 RID: 63025
		[Token(Token = "0x400F631")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("audio")]
		private string _bossLeftHandDeath2AudioSignal;

		// Token: 0x0400F632 RID: 63026
		[Token(Token = "0x400F632")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("audio")]
		private string _bossRightHandDeath1AudioSignal;

		// Token: 0x0400F633 RID: 63027
		[Token(Token = "0x400F633")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Group("audio")]
		private string _bossRightHandDeath2AudioSignal;

		// Token: 0x0400F634 RID: 63028
		[Token(Token = "0x400F634")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Group("audio")]
		private float _bossHeadDeathDelay;

		// Token: 0x0400F635 RID: 63029
		[Token(Token = "0x400F635")]
		[FieldOffset(Offset = "0x124")]
		[SerializeField]
		[Group("audio")]
		private float _bossLeftHandDeath1Delay;

		// Token: 0x0400F636 RID: 63030
		[Token(Token = "0x400F636")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		[Group("audio")]
		private float _bossLeftHandDeath2Delay;

		// Token: 0x0400F637 RID: 63031
		[Token(Token = "0x400F637")]
		[FieldOffset(Offset = "0x12C")]
		[SerializeField]
		[Group("audio")]
		private float _bossRightHandDeath1Delay;

		// Token: 0x0400F638 RID: 63032
		[Token(Token = "0x400F638")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Group("audio")]
		private float _bossRightHandDeath2Delay;

		// Token: 0x0400F639 RID: 63033
		[Token(Token = "0x400F639")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private string _enableTailHitDefaultSummon;

		// Token: 0x0400F63A RID: 63034
		[Token(Token = "0x400F63A")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private string _bossAwakeCountDownKey;

		// Token: 0x0400F63B RID: 63035
		[Token(Token = "0x400F63B")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private TargetOptions _bossSkillTargetOptions;

		// Token: 0x0400F63C RID: 63036
		[Token(Token = "0x400F63C")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private FilterUtil.FilterType _bossSkillTargetFilterType;

		// Token: 0x0400F63D RID: 63037
		[Token(Token = "0x400F63D")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private string _bossSkillOffsetKey;

		// Token: 0x0400F63E RID: 63038
		[Token(Token = "0x400F63E")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private string _leftHandSkillBuffKey;

		// Token: 0x0400F63F RID: 63039
		[Token(Token = "0x400F63F")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private string _rightHandSkillBuffKey;

		// Token: 0x0400F640 RID: 63040
		[Token(Token = "0x400F640")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private string _tailSkillBuffKey;

		// Token: 0x0400F641 RID: 63041
		[Token(Token = "0x400F641")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private string _suiBossMarkBuffKey;

		// Token: 0x0400F642 RID: 63042
		[Token(Token = "0x400F642")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		private GridPosition _leftHandSpineMoveOffset;

		// Token: 0x0400F643 RID: 63043
		[Token(Token = "0x400F643")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		private GridPosition _rightHandSpineMoveOffset;

		// Token: 0x0400F644 RID: 63044
		[Token(Token = "0x400F644")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		private ActionArray _headSkillExtraActions;

		// Token: 0x0400F645 RID: 63045
		[Token(Token = "0x400F645")]
		[FieldOffset(Offset = "0x1F0")]
		[SerializeField]
		private string _triggerSyncSkillRatioKey1;

		// Token: 0x0400F646 RID: 63046
		[Token(Token = "0x400F646")]
		[FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		private string _triggerSyncSkillRatioKey2;

		// Token: 0x0400F647 RID: 63047
		[Token(Token = "0x400F647")]
		[FieldOffset(Offset = "0x200")]
		[SerializeField]
		private string _breakRatioKey;

		// Token: 0x0400F648 RID: 63048
		[Token(Token = "0x400F648")]
		[FieldOffset(Offset = "0x208")]
		[SerializeField]
		private BuffData _buffTriggerHeadBossSkill;

		// Token: 0x0400F649 RID: 63049
		[Token(Token = "0x400F649")]
		[FieldOffset(Offset = "0x210")]
		[SerializeField]
		private BuffData _buffTriggerTailBossSkill;

		// Token: 0x0400F64A RID: 63050
		[Token(Token = "0x400F64A")]
		[FieldOffset(Offset = "0x218")]
		[SerializeField]
		private BuffData _buffTriggerLeftHandBossSkill;

		// Token: 0x0400F64B RID: 63051
		[Token(Token = "0x400F64B")]
		[FieldOffset(Offset = "0x220")]
		[SerializeField]
		private BuffData _buffTriggerRigthHandBossSkill;

		// Token: 0x0400F64C RID: 63052
		[Token(Token = "0x400F64C")]
		[FieldOffset(Offset = "0x228")]
		[SerializeField]
		private BuffData _buffTriggerBossBreak;

		// Token: 0x0400F64D RID: 63053
		[Token(Token = "0x400F64D")]
		[FieldOffset(Offset = "0x230")]
		[SerializeField]
		private BuffData _buffFullyUnsealed;

		// Token: 0x0400F64E RID: 63054
		[Token(Token = "0x400F64E")]
		[FieldOffset(Offset = "0x238")]
		[SerializeField]
		[Group("left hand boss effects")]
		private string _leftHandWarningEffectKey;

		// Token: 0x0400F64F RID: 63055
		[Token(Token = "0x400F64F")]
		[FieldOffset(Offset = "0x240")]
		[SerializeField]
		[Group("left hand boss effects")]
		private string _leftHandSkillStartEffectKey;

		// Token: 0x0400F650 RID: 63056
		[Token(Token = "0x400F650")]
		[FieldOffset(Offset = "0x248")]
		[SerializeField]
		[Group("left hand boss effects")]
		private string _leftHandSkillHitEffectKey;

		// Token: 0x0400F651 RID: 63057
		[Token(Token = "0x400F651")]
		[FieldOffset(Offset = "0x250")]
		[SerializeField]
		[Group("right hand boss effects")]
		private string _rightHandWarningEffectKey;

		// Token: 0x0400F652 RID: 63058
		[Token(Token = "0x400F652")]
		[FieldOffset(Offset = "0x258")]
		[SerializeField]
		[Group("right hand boss effects")]
		private string _rightHandSkillStartEffectKey;

		// Token: 0x0400F653 RID: 63059
		[Token(Token = "0x400F653")]
		[FieldOffset(Offset = "0x260")]
		[SerializeField]
		[Group("right hand boss effects")]
		private string _rightHandSkillHitEffectKey;

		// Token: 0x0400F654 RID: 63060
		[Token(Token = "0x400F654")]
		[FieldOffset(Offset = "0x268")]
		[SerializeField]
		[Group("tail boss effects")]
		private string _tailSkillHitEffectKey;

		// Token: 0x0400F655 RID: 63061
		[Token(Token = "0x400F655")]
		[FieldOffset(Offset = "0x270")]
		[SerializeField]
		[Group("tail boss effects")]
		private string _tailSealedWarningEffectKey;

		// Token: 0x0400F656 RID: 63062
		[Token(Token = "0x400F656")]
		[FieldOffset(Offset = "0x278")]
		[SerializeField]
		[Group("tail boss effects")]
		private string _tailUnsealedWarningEffectKey;

		// Token: 0x0400F657 RID: 63063
		[Token(Token = "0x400F657")]
		[FieldOffset(Offset = "0x280")]
		[SerializeField]
		[Group("head boss effects")]
		private string _headSealedWarningEffectKey;

		// Token: 0x0400F658 RID: 63064
		[Token(Token = "0x400F658")]
		[FieldOffset(Offset = "0x288")]
		[SerializeField]
		[Group("head boss effects")]
		private string _headUnsealedWarningEffectKey;

		// Token: 0x0400F659 RID: 63065
		[Token(Token = "0x400F659")]
		[FieldOffset(Offset = "0x290")]
		[SerializeField]
		[Group("head boss effects")]
		private string _headSkillProjectileHitEffectKey;

		// Token: 0x0400F65A RID: 63066
		[Token(Token = "0x400F65A")]
		[FieldOffset(Offset = "0x298")]
		[SerializeField]
		[Group("head boss effects")]
		private string _headSealedSkillDotRangeEffectKey;

		// Token: 0x0400F65B RID: 63067
		[Token(Token = "0x400F65B")]
		[FieldOffset(Offset = "0x2A0")]
		[SerializeField]
		[Group("head boss effects")]
		private string _headUnsealedSkillDotRangeEffectKey;

		// Token: 0x0400F65C RID: 63068
		[Token(Token = "0x400F65C")]
		[FieldOffset(Offset = "0x2A8")]
		[SerializeField]
		[Group("common boss effects")]
		private string _bossStressScreenEffectKey;

		// Token: 0x0400F65D RID: 63069
		[Token(Token = "0x400F65D")]
		[FieldOffset(Offset = "0x2B0")]
		[SerializeField]
		[Group("common boss effects")]
		private string _suiLockTargetEffectKey;

		// Token: 0x0400F65E RID: 63070
		[Token(Token = "0x400F65E")]
		[FieldOffset(Offset = "0x2B8")]
		[SerializeField]
		private string _bossRigthHandAbleToShowWarningEffectBuffKey;

		// Token: 0x0400F65F RID: 63071
		[Token(Token = "0x400F65F")]
		[FieldOffset(Offset = "0x2C0")]
		[SerializeField]
		private string _bossLeftHandAbleToShowWarningEffectBuffKey;

		// Token: 0x0400F660 RID: 63072
		[Token(Token = "0x400F660")]
		[FieldOffset(Offset = "0x2C8")]
		[SerializeField]
		private string _bossHeadAbleToShowWarningEffectBuffKey;

		// Token: 0x0400F661 RID: 63073
		[Token(Token = "0x400F661")]
		[FieldOffset(Offset = "0x2D0")]
		[SerializeField]
		private string _bossTailAbleToShowWarningEffectBuffKey;

		// Token: 0x0400F662 RID: 63074
		[Token(Token = "0x400F662")]
		[FieldOffset(Offset = "0x2D8")]
		private Vector3 m_headRoomOffset;

		// Token: 0x0400F663 RID: 63075
		[Token(Token = "0x400F663")]
		[FieldOffset(Offset = "0x2E4")]
		private Vector3 m_tailRoomOffset;

		// Token: 0x0400F664 RID: 63076
		[Token(Token = "0x400F664")]
		[FieldOffset(Offset = "0x2F0")]
		private Vector3 m_rightHandRoomOffset;

		// Token: 0x0400F665 RID: 63077
		[Token(Token = "0x400F665")]
		[FieldOffset(Offset = "0x2FC")]
		private Vector3 m_leftHandRoomOffset;

		// Token: 0x0400F666 RID: 63078
		[Token(Token = "0x400F666")]
		[FieldOffset(Offset = "0x308")]
		private string m_printRoom;

		// Token: 0x0400F667 RID: 63079
		[Token(Token = "0x400F667")]
		[FieldOffset(Offset = "0x310")]
		private Act49SideLevelBossManager.SubRoomType m_printRoomType;

		// Token: 0x0400F668 RID: 63080
		[Token(Token = "0x400F668")]
		[FieldOffset(Offset = "0x314")]
		private bool m_forceHidePrintingSlider;

		// Token: 0x0400F669 RID: 63081
		[Token(Token = "0x400F669")]
		[FieldOffset(Offset = "0x318")]
		private float m_bossAwakeCountDown;

		// Token: 0x0400F66A RID: 63082
		[Token(Token = "0x400F66A")]
		[FieldOffset(Offset = "0x320")]
		private PeriodicTimer m_bossAweakTimer;

		// Token: 0x0400F66B RID: 63083
		[Token(Token = "0x400F66B")]
		[FieldOffset(Offset = "0x328")]
		private Act49SidePrintingManager m_printManager;

		// Token: 0x0400F66C RID: 63084
		[Token(Token = "0x400F66C")]
		[FieldOffset(Offset = "0x330")]
		private Act49SideLevelBossManager.Act49sideBossLevelState m_state;

		// Token: 0x0400F66D RID: 63085
		[Token(Token = "0x400F66D")]
		[FieldOffset(Offset = "0x338")]
		private Act49SideLevelBossManager.Act49sideBossState m_bossState;

		// Token: 0x0400F66E RID: 63086
		[Token(Token = "0x400F66E")]
		[FieldOffset(Offset = "0x340")]
		private Dictionary<GridPosition, Tile> m_headRoomPosDict;

		// Token: 0x0400F66F RID: 63087
		[Token(Token = "0x400F66F")]
		[FieldOffset(Offset = "0x348")]
		private Dictionary<GridPosition, Tile> m_tailRoomPosDict;

		// Token: 0x0400F670 RID: 63088
		[Token(Token = "0x400F670")]
		[FieldOffset(Offset = "0x350")]
		private Dictionary<GridPosition, Tile> m_leftHandRoomPosDict;

		// Token: 0x0400F671 RID: 63089
		[Token(Token = "0x400F671")]
		[FieldOffset(Offset = "0x358")]
		private Dictionary<GridPosition, Tile> m_rightHandRoomPosDict;

		// Token: 0x0400F672 RID: 63090
		[Token(Token = "0x400F672")]
		[FieldOffset(Offset = "0x360")]
		private Dictionary<GridPosition, Tile> m_mainFieldPosDict;

		// Token: 0x0400F673 RID: 63091
		[Token(Token = "0x400F673")]
		[FieldOffset(Offset = "0x368")]
		private Dictionary<GridPosition, BuildableType> m_headRoomOriginBuildableTypeDict;

		// Token: 0x0400F674 RID: 63092
		[Token(Token = "0x400F674")]
		[FieldOffset(Offset = "0x370")]
		private Dictionary<GridPosition, BuildableType> m_tailRoomOriginBuildableTypeDict;

		// Token: 0x0400F675 RID: 63093
		[Token(Token = "0x400F675")]
		[FieldOffset(Offset = "0x378")]
		private Dictionary<GridPosition, BuildableType> m_leftHandRoomOriginBuildableTypeDict;

		// Token: 0x0400F676 RID: 63094
		[Token(Token = "0x400F676")]
		[FieldOffset(Offset = "0x380")]
		private Dictionary<GridPosition, BuildableType> m_rightHandRoomOriginBuildableTypeDict;

		// Token: 0x0400F677 RID: 63095
		[Token(Token = "0x400F677")]
		[FieldOffset(Offset = "0x388")]
		private Dictionary<GridPosition, BuildableType> m_mainFieldOriginBuildableTypeDict;

		// Token: 0x0400F678 RID: 63096
		[Token(Token = "0x400F678")]
		[FieldOffset(Offset = "0x390")]
		private bool m_enableTailHitDefaultSummon;

		// Token: 0x0400F679 RID: 63097
		[Token(Token = "0x400F679")]
		[FieldOffset(Offset = "0x391")]
		private bool m_isDuringCameraMove;

		// Token: 0x0400F67A RID: 63098
		[Token(Token = "0x400F67A")]
		[FieldOffset(Offset = "0x398")]
		private Effect m_headBossWarningEffect;

		// Token: 0x0400F67B RID: 63099
		[Token(Token = "0x400F67B")]
		[FieldOffset(Offset = "0x3A0")]
		private Effect m_tailBossWarningEffect;

		// Token: 0x0400F67C RID: 63100
		[Token(Token = "0x400F67C")]
		[FieldOffset(Offset = "0x3A8")]
		private Effect m_rightHandBossWarningEffect;

		// Token: 0x0400F67D RID: 63101
		[Token(Token = "0x400F67D")]
		[FieldOffset(Offset = "0x3B0")]
		private Effect m_leftHandBossWarningEffect;

		// Token: 0x0400F67E RID: 63102
		[Token(Token = "0x400F67E")]
		[FieldOffset(Offset = "0x3B8")]
		private Effect m_headBossSkillRangeEffect;

		// Token: 0x0400F67F RID: 63103
		[Token(Token = "0x400F67F")]
		[FieldOffset(Offset = "0x3C0")]
		private bool m_shouldHideTjgsd;

		// Token: 0x0400F680 RID: 63104
		[Token(Token = "0x400F680")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isHeadRoomFinished;

		// Token: 0x0400F681 RID: 63105
		[Token(Token = "0x400F681")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isTailRoomFinished;

		// Token: 0x0400F682 RID: 63106
		[Token(Token = "0x400F682")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isLeftHandRoomFinished;

		// Token: 0x0400F683 RID: 63107
		[Token(Token = "0x400F683")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isRightHandRoomFinished;

		// Token: 0x0400F684 RID: 63108
		[Token(Token = "0x400F684")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_printManager;

		// Token: 0x0400F685 RID: 63109
		[Token(Token = "0x400F685")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_fullyUnsealed;

		// Token: 0x0400F686 RID: 63110
		[Token(Token = "0x400F686")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x0400F687 RID: 63111
		[Token(Token = "0x400F687")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400F688 RID: 63112
		[Token(Token = "0x400F688")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F689 RID: 63113
		[Token(Token = "0x400F689")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnPostInit;

		// Token: 0x0400F68A RID: 63114
		[Token(Token = "0x400F68A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F68B RID: 63115
		[Token(Token = "0x400F68B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnEnvDestroy;

		// Token: 0x0400F68C RID: 63116
		[Token(Token = "0x400F68C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_DoMoveCamera;

		// Token: 0x0400F68D RID: 63117
		[Token(Token = "0x400F68D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_RegisterEnemy;

		// Token: 0x0400F68E RID: 63118
		[Token(Token = "0x400F68E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_DeregisterEnemy;

		// Token: 0x0400F68F RID: 63119
		[Token(Token = "0x400F68F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_InterruptSubRoom;

		// Token: 0x0400F690 RID: 63120
		[Token(Token = "0x400F690")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_CheckBossPartSealed;

		// Token: 0x0400F691 RID: 63121
		[Token(Token = "0x400F691")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_QueryBossLevelUIState;

		// Token: 0x0400F692 RID: 63122
		[Token(Token = "0x400F692")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_SummonHolderTraps;

		// Token: 0x0400F693 RID: 63123
		[Token(Token = "0x400F693")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_ClearHolderTraps;

		// Token: 0x0400F694 RID: 63124
		[Token(Token = "0x400F694")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_CanTriggerSunmaoTrapSkill;

		// Token: 0x0400F695 RID: 63125
		[Token(Token = "0x400F695")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnTrapSunmaoSkillTriggered;

		// Token: 0x0400F696 RID: 63126
		[Token(Token = "0x400F696")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_FindTargetHead;

		// Token: 0x0400F697 RID: 63127
		[Token(Token = "0x400F697")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_FindTargetLeftHand;

		// Token: 0x0400F698 RID: 63128
		[Token(Token = "0x400F698")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_FindTargetRightHand;

		// Token: 0x0400F699 RID: 63129
		[Token(Token = "0x400F699")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_FindTargetTail;

		// Token: 0x0400F69A RID: 63130
		[Token(Token = "0x400F69A")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_UpdateRectSkillTileList;

		// Token: 0x0400F69B RID: 63131
		[Token(Token = "0x400F69B")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_UpdateTailSkillTileList;

		// Token: 0x0400F69C RID: 63132
		[Token(Token = "0x400F69C")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_ApplyDamageToTargetTiles;

		// Token: 0x0400F69D RID: 63133
		[Token(Token = "0x400F69D")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_FindSkillFocusGrid;

		// Token: 0x0400F69E RID: 63134
		[Token(Token = "0x400F69E")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_SetDefaultSkillFocusGrid;

		// Token: 0x0400F69F RID: 63135
		[Token(Token = "0x400F69F")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_ApplySkillDamage;

		// Token: 0x0400F6A0 RID: 63136
		[Token(Token = "0x400F6A0")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_BossTailChargeEnemySummonCnt;

		// Token: 0x0400F6A1 RID: 63137
		[Token(Token = "0x400F6A1")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_BossTailSetSummonEnemyInterval;

		// Token: 0x0400F6A2 RID: 63138
		[Token(Token = "0x400F6A2")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_GetBossHeadSkillTargetTile;

		// Token: 0x0400F6A3 RID: 63139
		[Token(Token = "0x400F6A3")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_GetBossHeadSkillActionWhenReachedTarget;

		// Token: 0x0400F6A4 RID: 63140
		[Token(Token = "0x400F6A4")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_ResetHeadSkillDotTimerAndClearHeadSkillRangeEffect;

		// Token: 0x0400F6A5 RID: 63141
		[Token(Token = "0x400F6A5")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_OnBossHeadSkillReached;

		// Token: 0x0400F6A6 RID: 63142
		[Token(Token = "0x400F6A6")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_HeadBossSetParams;

		// Token: 0x0400F6A7 RID: 63143
		[Token(Token = "0x400F6A7")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_RegistBossPart;

		// Token: 0x0400F6A8 RID: 63144
		[Token(Token = "0x400F6A8")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_ApplyDamageToLevelBoss;

		// Token: 0x0400F6A9 RID: 63145
		[Token(Token = "0x400F6A9")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_UpdateBossSkillWarningEffect;

		// Token: 0x0400F6AA RID: 63146
		[Token(Token = "0x400F6AA")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_FinishBossSkillWarningEffect;

		// Token: 0x0400F6AB RID: 63147
		[Token(Token = "0x400F6AB")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_EnemySheartTriggerSkill;

		// Token: 0x0400F6AC RID: 63148
		[Token(Token = "0x400F6AC")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_TriggerLevelFinish;

		// Token: 0x0400F6AD RID: 63149
		[Token(Token = "0x400F6AD")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__KillAllBeforeFinishLevel;

		// Token: 0x0400F6AE RID: 63150
		[Token(Token = "0x400F6AE")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__FinishLevel;

		// Token: 0x0400F6AF RID: 63151
		[Token(Token = "0x400F6AF")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__PlayAudioAtPos;

		// Token: 0x0400F6B0 RID: 63152
		[Token(Token = "0x400F6B0")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__OnHeadSealed;

		// Token: 0x0400F6B1 RID: 63153
		[Token(Token = "0x400F6B1")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__OnTailSealed;

		// Token: 0x0400F6B2 RID: 63154
		[Token(Token = "0x400F6B2")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__OnLeftHandSealed;

		// Token: 0x0400F6B3 RID: 63155
		[Token(Token = "0x400F6B3")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__OnRightHandSealed;

		// Token: 0x0400F6B4 RID: 63156
		[Token(Token = "0x400F6B4")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0__AwakeBoss;

		// Token: 0x0400F6B5 RID: 63157
		[Token(Token = "0x400F6B5")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__UpdateSubRoomState;

		// Token: 0x0400F6B6 RID: 63158
		[Token(Token = "0x400F6B6")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0__HideTrapTjgsdAndTrapCharacterTile;

		// Token: 0x0400F6B7 RID: 63159
		[Token(Token = "0x400F6B7")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__OnFinishCameraMove;

		// Token: 0x0400F6B8 RID: 63160
		[Token(Token = "0x400F6B8")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0__CheckHasAliveEnemyInSubRoom;

		// Token: 0x0400F6B9 RID: 63161
		[Token(Token = "0x400F6B9")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0__FindAndSortTargets;

		// Token: 0x0400F6BA RID: 63162
		[Token(Token = "0x400F6BA")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0__BossTailSummonEnemyWhenHitDefaultPos;

		// Token: 0x0400F6BB RID: 63163
		[Token(Token = "0x400F6BB")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0__ApplyHeadBossSkillDotDmg;

		// Token: 0x0400F6BC RID: 63164
		[Token(Token = "0x400F6BC")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0__SwitchSubRoomTileBuidableType;

		// Token: 0x0400F6BD RID: 63165
		[Token(Token = "0x400F6BD")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0__FinishBossLockBuff;

		// Token: 0x0400F6BE RID: 63166
		[Token(Token = "0x400F6BE")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020022E2 RID: 8930
		[Token(Token = "0x20022E2")]
		public enum SubRoomType
		{
			// Token: 0x0400F6C0 RID: 63168
			[Token(Token = "0x400F6C0")]
			None,
			// Token: 0x0400F6C1 RID: 63169
			[Token(Token = "0x400F6C1")]
			Main,
			// Token: 0x0400F6C2 RID: 63170
			[Token(Token = "0x400F6C2")]
			Head,
			// Token: 0x0400F6C3 RID: 63171
			[Token(Token = "0x400F6C3")]
			Tail,
			// Token: 0x0400F6C4 RID: 63172
			[Token(Token = "0x400F6C4")]
			LeftHand,
			// Token: 0x0400F6C5 RID: 63173
			[Token(Token = "0x400F6C5")]
			RightHand
		}

		// Token: 0x020022E3 RID: 8931
		[Token(Token = "0x20022E3")]
		private enum Act49sideBossLevelStage
		{
			// Token: 0x0400F6C7 RID: 63175
			[Token(Token = "0x400F6C7")]
			Unsealing,
			// Token: 0x0400F6C8 RID: 63176
			[Token(Token = "0x400F6C8")]
			MainBattle
		}

		// Token: 0x020022E4 RID: 8932
		[Token(Token = "0x20022E4")]
		private class Act49sideBossLevelState
		{
			// Token: 0x0600E182 RID: 57730 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E182")]
			[Address(RVA = "0x558700", Offset = "0x557300", VA = "0x180558700")]
			public void Init()
			{
			}

			// Token: 0x0600E183 RID: 57731 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E183")]
			[Address(RVA = "0x558770", Offset = "0x557370", VA = "0x180558770")]
			public void OnDestroy()
			{
			}

			// Token: 0x0600E184 RID: 57732 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E184")]
			[Address(RVA = "0x5587D0", Offset = "0x5573D0", VA = "0x1805587D0")]
			public Act49sideBossLevelState()
			{
			}

			// Token: 0x0400F6C9 RID: 63177
			[Token(Token = "0x400F6C9")]
			[FieldOffset(Offset = "0x10")]
			public bool hasKilledHeadRoomMarkEnemy;

			// Token: 0x0400F6CA RID: 63178
			[Token(Token = "0x400F6CA")]
			[FieldOffset(Offset = "0x11")]
			public bool hasKilledTailRoomMarkEnemy;

			// Token: 0x0400F6CB RID: 63179
			[Token(Token = "0x400F6CB")]
			[FieldOffset(Offset = "0x12")]
			public bool hasKilledLeftHandRoomMarkEnemy;

			// Token: 0x0400F6CC RID: 63180
			[Token(Token = "0x400F6CC")]
			[FieldOffset(Offset = "0x13")]
			public bool hasKilledRightHandRoomMarkEnemy;

			// Token: 0x0400F6CD RID: 63181
			[Token(Token = "0x400F6CD")]
			[FieldOffset(Offset = "0x14")]
			public bool shouldSummonHeadRoomEnemy;

			// Token: 0x0400F6CE RID: 63182
			[Token(Token = "0x400F6CE")]
			[FieldOffset(Offset = "0x15")]
			public bool shouldSummonTailRoomEnemy;

			// Token: 0x0400F6CF RID: 63183
			[Token(Token = "0x400F6CF")]
			[FieldOffset(Offset = "0x16")]
			public bool shouldSummonLeftHandRoomEnemy;

			// Token: 0x0400F6D0 RID: 63184
			[Token(Token = "0x400F6D0")]
			[FieldOffset(Offset = "0x17")]
			public bool shouldSummonRightHandRoomEnemy;

			// Token: 0x0400F6D1 RID: 63185
			[Token(Token = "0x400F6D1")]
			[FieldOffset(Offset = "0x18")]
			public Trap headRoomSunmao;

			// Token: 0x0400F6D2 RID: 63186
			[Token(Token = "0x400F6D2")]
			[FieldOffset(Offset = "0x20")]
			public Trap tailRoomSunmao;

			// Token: 0x0400F6D3 RID: 63187
			[Token(Token = "0x400F6D3")]
			[FieldOffset(Offset = "0x28")]
			public Trap lefthandRoomSunmao;

			// Token: 0x0400F6D4 RID: 63188
			[Token(Token = "0x400F6D4")]
			[FieldOffset(Offset = "0x30")]
			public Trap righthandRoomSunmao;

			// Token: 0x0400F6D5 RID: 63189
			[Token(Token = "0x400F6D5")]
			[FieldOffset(Offset = "0x38")]
			public Act49SideLevelBossManager.Act49sideBossLevelStage levelStage;

			// Token: 0x0400F6D6 RID: 63190
			[Token(Token = "0x400F6D6")]
			[FieldOffset(Offset = "0x3C")]
			public Act49SideLevelBossManager.SubRoomType currentSubRoomType;

			// Token: 0x0400F6D7 RID: 63191
			[Token(Token = "0x400F6D7")]
			[FieldOffset(Offset = "0x40")]
			public bool isHeadRoomInterrupted;

			// Token: 0x0400F6D8 RID: 63192
			[Token(Token = "0x400F6D8")]
			[FieldOffset(Offset = "0x41")]
			public bool isTailRoomInterrupted;

			// Token: 0x0400F6D9 RID: 63193
			[Token(Token = "0x400F6D9")]
			[FieldOffset(Offset = "0x42")]
			public bool isLeftHandRoomInterrupted;

			// Token: 0x0400F6DA RID: 63194
			[Token(Token = "0x400F6DA")]
			[FieldOffset(Offset = "0x43")]
			public bool isRightHandRoomInterrupted;

			// Token: 0x0400F6DB RID: 63195
			[Token(Token = "0x400F6DB")]
			[FieldOffset(Offset = "0x44")]
			public bool hasExitFromHeadRoom;

			// Token: 0x0400F6DC RID: 63196
			[Token(Token = "0x400F6DC")]
			[FieldOffset(Offset = "0x45")]
			public bool hasExitFromTailRoom;

			// Token: 0x0400F6DD RID: 63197
			[Token(Token = "0x400F6DD")]
			[FieldOffset(Offset = "0x46")]
			public bool hasExitFromLeftHandRoom;

			// Token: 0x0400F6DE RID: 63198
			[Token(Token = "0x400F6DE")]
			[FieldOffset(Offset = "0x47")]
			public bool hasExitFromRightHandRoom;
		}

		// Token: 0x020022E5 RID: 8933
		[Token(Token = "0x20022E5")]
		private class Act49sideBossState
		{
			// Token: 0x17001C44 RID: 7236
			// (get) Token: 0x0600E185 RID: 57733 RVA: 0x00051CF0 File Offset: 0x0004FEF0
			[Token(Token = "0x17001C44")]
			public float hpRatio
			{
				[Token(Token = "0x600E185")]
				[Address(RVA = "0x55AF70", Offset = "0x559B70", VA = "0x18055AF70")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17001C45 RID: 7237
			// (get) Token: 0x0600E186 RID: 57734 RVA: 0x00051D08 File Offset: 0x0004FF08
			[Token(Token = "0x17001C45")]
			public bool fullyUnsealed
			{
				[Token(Token = "0x600E186")]
				[Address(RVA = "0x55AF40", Offset = "0x559B40", VA = "0x18055AF40")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600E187 RID: 57735 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E187")]
			[Address(RVA = "0x5587E0", Offset = "0x5573E0", VA = "0x1805587E0")]
			public void Init(Act49SideLevelBossManager bossManager)
			{
			}

			// Token: 0x0600E188 RID: 57736 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E188")]
			[Address(RVA = "0x558D10", Offset = "0x557910", VA = "0x180558D10")]
			public void OnDestroy()
			{
			}

			// Token: 0x0600E189 RID: 57737 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E189")]
			[Address(RVA = "0x55A470", Offset = "0x559070", VA = "0x18055A470")]
			public void Update(FP deltaTime)
			{
			}

			// Token: 0x0600E18A RID: 57738 RVA: 0x00051D20 File Offset: 0x0004FF20
			[Token(Token = "0x600E18A")]
			[Address(RVA = "0x5590C0", Offset = "0x557CC0", VA = "0x1805590C0")]
			public bool UpdateEnemyHP(Enemy source, ref Modifier modifer)
			{
				return default(bool);
			}

			// Token: 0x0600E18B RID: 57739 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E18B")]
			[Address(RVA = "0x55AC80", Offset = "0x559880", VA = "0x18055AC80")]
			public Act49sideBossState()
			{
			}

			// Token: 0x0400F6DF RID: 63199
			[Token(Token = "0x400F6DF")]
			private const float BOSS_DEATH_KILL_ALL_COUNT_DOWN_TIME = 3f;

			// Token: 0x0400F6E0 RID: 63200
			[Token(Token = "0x400F6E0")]
			[FieldOffset(Offset = "0x10")]
			public Act49SideLevelBossManager manager;

			// Token: 0x0400F6E1 RID: 63201
			[Token(Token = "0x400F6E1")]
			[FieldOffset(Offset = "0x18")]
			public Enemy headEnemy;

			// Token: 0x0400F6E2 RID: 63202
			[Token(Token = "0x400F6E2")]
			[FieldOffset(Offset = "0x20")]
			public Enemy tailEnemy;

			// Token: 0x0400F6E3 RID: 63203
			[Token(Token = "0x400F6E3")]
			[FieldOffset(Offset = "0x28")]
			public Enemy leftHandEnemy;

			// Token: 0x0400F6E4 RID: 63204
			[Token(Token = "0x400F6E4")]
			[FieldOffset(Offset = "0x30")]
			public Enemy rightHandEnemy;

			// Token: 0x0400F6E5 RID: 63205
			[Token(Token = "0x400F6E5")]
			[FieldOffset(Offset = "0x38")]
			public Effect headLockEffect;

			// Token: 0x0400F6E6 RID: 63206
			[Token(Token = "0x400F6E6")]
			[FieldOffset(Offset = "0x40")]
			public Effect tailLockEffect;

			// Token: 0x0400F6E7 RID: 63207
			[Token(Token = "0x400F6E7")]
			[FieldOffset(Offset = "0x48")]
			public Effect leftHandLockEffect;

			// Token: 0x0400F6E8 RID: 63208
			[Token(Token = "0x400F6E8")]
			[FieldOffset(Offset = "0x50")]
			public Effect rightHandLockEffect;

			// Token: 0x0400F6E9 RID: 63209
			[Token(Token = "0x400F6E9")]
			[FieldOffset(Offset = "0x58")]
			public FP enemyHp;

			// Token: 0x0400F6EA RID: 63210
			[Token(Token = "0x400F6EA")]
			[FieldOffset(Offset = "0x60")]
			public FP enemyMaxHp;

			// Token: 0x0400F6EB RID: 63211
			[Token(Token = "0x400F6EB")]
			[FieldOffset(Offset = "0x68")]
			public FP headDmg;

			// Token: 0x0400F6EC RID: 63212
			[Token(Token = "0x400F6EC")]
			[FieldOffset(Offset = "0x70")]
			public FP tailDmg;

			// Token: 0x0400F6ED RID: 63213
			[Token(Token = "0x400F6ED")]
			[FieldOffset(Offset = "0x78")]
			public FP leftHandDmg;

			// Token: 0x0400F6EE RID: 63214
			[Token(Token = "0x400F6EE")]
			[FieldOffset(Offset = "0x80")]
			public FP rightHandDmg;

			// Token: 0x0400F6EF RID: 63215
			[Token(Token = "0x400F6EF")]
			[FieldOffset(Offset = "0x88")]
			public List<Tile> headSkillTargetTiles;

			// Token: 0x0400F6F0 RID: 63216
			[Token(Token = "0x400F6F0")]
			[FieldOffset(Offset = "0x90")]
			public List<Tile> tailSkillTargetTiles;

			// Token: 0x0400F6F1 RID: 63217
			[Token(Token = "0x400F6F1")]
			[FieldOffset(Offset = "0x98")]
			public List<Tile> leftHandSkillTargetTile;

			// Token: 0x0400F6F2 RID: 63218
			[Token(Token = "0x400F6F2")]
			[FieldOffset(Offset = "0xA0")]
			public List<Tile> rightHandSkillTargetTile;

			// Token: 0x0400F6F3 RID: 63219
			[Token(Token = "0x400F6F3")]
			[FieldOffset(Offset = "0xA8")]
			public List<Tile> headHolderTiles;

			// Token: 0x0400F6F4 RID: 63220
			[Token(Token = "0x400F6F4")]
			[FieldOffset(Offset = "0xB0")]
			public List<Tile> tailHolderTiles;

			// Token: 0x0400F6F5 RID: 63221
			[Token(Token = "0x400F6F5")]
			[FieldOffset(Offset = "0xB8")]
			public List<Tile> leftHandHolderTiles;

			// Token: 0x0400F6F6 RID: 63222
			[Token(Token = "0x400F6F6")]
			[FieldOffset(Offset = "0xC0")]
			public List<Tile> rightHandHolderTiles;

			// Token: 0x0400F6F7 RID: 63223
			[Token(Token = "0x400F6F7")]
			[FieldOffset(Offset = "0xC8")]
			public bool isHeadSealed;

			// Token: 0x0400F6F8 RID: 63224
			[Token(Token = "0x400F6F8")]
			[FieldOffset(Offset = "0xC9")]
			public bool isTailSealed;

			// Token: 0x0400F6F9 RID: 63225
			[Token(Token = "0x400F6F9")]
			[FieldOffset(Offset = "0xCA")]
			public bool isRightHandSealed;

			// Token: 0x0400F6FA RID: 63226
			[Token(Token = "0x400F6FA")]
			[FieldOffset(Offset = "0xCB")]
			public bool isLeftHandSealed;

			// Token: 0x0400F6FB RID: 63227
			[Token(Token = "0x400F6FB")]
			[FieldOffset(Offset = "0xCC")]
			public bool isBossRegistered;

			// Token: 0x0400F6FC RID: 63228
			[Token(Token = "0x400F6FC")]
			[FieldOffset(Offset = "0xD0")]
			public GridPosition leftHandSkillFocusPos;

			// Token: 0x0400F6FD RID: 63229
			[Token(Token = "0x400F6FD")]
			[FieldOffset(Offset = "0xD8")]
			public GridPosition rightHandSkillFocusPos;

			// Token: 0x0400F6FE RID: 63230
			[Token(Token = "0x400F6FE")]
			[FieldOffset(Offset = "0xE0")]
			public GridPosition headSkillFocusPos;

			// Token: 0x0400F6FF RID: 63231
			[Token(Token = "0x400F6FF")]
			[FieldOffset(Offset = "0xE8")]
			public GridPosition tailSkillFocusPos;

			// Token: 0x0400F700 RID: 63232
			[Token(Token = "0x400F700")]
			[FieldOffset(Offset = "0xF0")]
			public GridPosition defaultLeftHandSkillFocusPos;

			// Token: 0x0400F701 RID: 63233
			[Token(Token = "0x400F701")]
			[FieldOffset(Offset = "0xF8")]
			public GridPosition defaultRightHandSkillFocusPos;

			// Token: 0x0400F702 RID: 63234
			[Token(Token = "0x400F702")]
			[FieldOffset(Offset = "0x100")]
			public GridPosition defaultHeadSkillFocusPos;

			// Token: 0x0400F703 RID: 63235
			[Token(Token = "0x400F703")]
			[FieldOffset(Offset = "0x108")]
			public GridPosition defaultTailSkillFocusPos;

			// Token: 0x0400F704 RID: 63236
			[Token(Token = "0x400F704")]
			[FieldOffset(Offset = "0x110")]
			public PeriodicTimer enemySummonTimer;

			// Token: 0x0400F705 RID: 63237
			[Token(Token = "0x400F705")]
			[FieldOffset(Offset = "0x118")]
			public float summonInterval;

			// Token: 0x0400F706 RID: 63238
			[Token(Token = "0x400F706")]
			[FieldOffset(Offset = "0x11C")]
			public int summonCnt;

			// Token: 0x0400F707 RID: 63239
			[Token(Token = "0x400F707")]
			[FieldOffset(Offset = "0x120")]
			public PeriodicTimer headBossDotTimer;

			// Token: 0x0400F708 RID: 63240
			[Token(Token = "0x400F708")]
			[FieldOffset(Offset = "0x128")]
			public PeriodicTimer headBossDotTriggerTimer;

			// Token: 0x0400F709 RID: 63241
			[Token(Token = "0x400F709")]
			[FieldOffset(Offset = "0x130")]
			public PeriodicTimer bossDeathCountDownTimer;

			// Token: 0x0400F70A RID: 63242
			[Token(Token = "0x400F70A")]
			[FieldOffset(Offset = "0x138")]
			public PeriodicTimer bossDoomCountDownTimer;

			// Token: 0x0400F70B RID: 63243
			[Token(Token = "0x400F70B")]
			[FieldOffset(Offset = "0x140")]
			public float headBossDotTime;

			// Token: 0x0400F70C RID: 63244
			[Token(Token = "0x400F70C")]
			[FieldOffset(Offset = "0x144")]
			public float headBossDotTriggerInterval;

			// Token: 0x0400F70D RID: 63245
			[Token(Token = "0x400F70D")]
			[FieldOffset(Offset = "0x148")]
			public float headBossMainAttackAtkScale;

			// Token: 0x0400F70E RID: 63246
			[Token(Token = "0x400F70E")]
			[FieldOffset(Offset = "0x14C")]
			public float headBossMainElementalAttackAtkScale;

			// Token: 0x0400F70F RID: 63247
			[Token(Token = "0x400F70F")]
			[FieldOffset(Offset = "0x150")]
			public float headBossDotAttackAtkScale;

			// Token: 0x0400F710 RID: 63248
			[Token(Token = "0x400F710")]
			[FieldOffset(Offset = "0x154")]
			public float headBossDotElementalAttackAtkScale;

			// Token: 0x0400F711 RID: 63249
			[Token(Token = "0x400F711")]
			[FieldOffset(Offset = "0x158")]
			public float doomCountDown;

			// Token: 0x0400F712 RID: 63250
			[Token(Token = "0x400F712")]
			[FieldOffset(Offset = "0x15C")]
			public float triggerSyncAttackRatio_1;

			// Token: 0x0400F713 RID: 63251
			[Token(Token = "0x400F713")]
			[FieldOffset(Offset = "0x160")]
			public float triggerSyncAttackRatio_2;

			// Token: 0x0400F714 RID: 63252
			[Token(Token = "0x400F714")]
			[FieldOffset(Offset = "0x164")]
			public float triggerBreakRatio;

			// Token: 0x0400F715 RID: 63253
			[Token(Token = "0x400F715")]
			[FieldOffset(Offset = "0x168")]
			public int syncAttackCnt;

			// Token: 0x0400F716 RID: 63254
			[Token(Token = "0x400F716")]
			[FieldOffset(Offset = "0x16C")]
			public int breakTime;
		}
	}
}
