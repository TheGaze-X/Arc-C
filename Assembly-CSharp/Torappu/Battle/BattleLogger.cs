using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Torappu.Battle.AntiCheat;
using Torappu.Battle.Roguelike;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002240 RID: 8768
	[Token(Token = "0x2002240")]
	public class BattleLogger : IHotfixable
	{
		// Token: 0x0600DC5B RID: 56411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC5B")]
		[Address(RVA = "0x3615650", Offset = "0x3614250", VA = "0x183615650")]
		public BattleLogger(BattleController controller, GameModeMeta.GameModeType gameModeType)
		{
		}

		// Token: 0x0600DC5C RID: 56412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC5C")]
		[Address(RVA = "0x3615480", Offset = "0x3614080", VA = "0x183615480")]
		private void _CreateVerboseRecorder(GameModeMeta.GameModeType gameModeType)
		{
		}

		// Token: 0x0600DC5D RID: 56413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC5D")]
		[Address(RVA = "0x36147B0", Offset = "0x36133B0", VA = "0x1836147B0")]
		public void LogSquadAndRandomSeed(BattlePlayerData playerData, int randomSeed, PlayerSide playerSide)
		{
		}

		// Token: 0x0600DC5E RID: 56414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC5E")]
		[Address(RVA = "0x36137F0", Offset = "0x36123F0", VA = "0x1836137F0")]
		public void LogManualSpawn(BattleCharacterData data, SharedConsts.Direction direction, GridPosition pos, bool ignoreCharStats = false)
		{
		}

		// Token: 0x0600DC5F RID: 56415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC5F")]
		[Address(RVA = "0x3613970", Offset = "0x3612570", VA = "0x183613970")]
		public void LogManualWithdraw(BattleCharacterData data, GridPosition pos)
		{
		}

		// Token: 0x0600DC60 RID: 56416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC60")]
		[Address(RVA = "0x3611C70", Offset = "0x3610870", VA = "0x183611C70")]
		public void LogCharacterAutoWithdraw(BattleCharacterData data)
		{
		}

		// Token: 0x0600DC61 RID: 56417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC61")]
		[Address(RVA = "0x36136A0", Offset = "0x36122A0", VA = "0x1836136A0")]
		public void LogManualSkill(BattleCharacterData data, GridPosition pos, bool isHidden, [Optional] string extraInfo)
		{
		}

		// Token: 0x0600DC62 RID: 56418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC62")]
		[Address(RVA = "0x3613AE0", Offset = "0x36126E0", VA = "0x183613AE0")]
		public void LogModifier(ref Modifier modifier)
		{
		}

		// Token: 0x0600DC63 RID: 56419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC63")]
		[Address(RVA = "0x3612870", Offset = "0x3611470", VA = "0x183612870")]
		public void LogEpModifier(ref Modifier modifier)
		{
		}

		// Token: 0x0600DC64 RID: 56420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC64")]
		[Address(RVA = "0x3612670", Offset = "0x3611270", VA = "0x183612670")]
		public void LogEpBreakModifier(Character character, ElementType elementType)
		{
		}

		// Token: 0x0600DC65 RID: 56421 RVA: 0x00050760 File Offset: 0x0004E960
		[Token(Token = "0x600DC65")]
		[Address(RVA = "0x3611D40", Offset = "0x3610940", VA = "0x183611D40")]
		public bool LogCharacterSnapshot(Character character)
		{
			return default(bool);
		}

		// Token: 0x0600DC66 RID: 56422 RVA: 0x00050778 File Offset: 0x0004E978
		[Token(Token = "0x600DC66")]
		[Address(RVA = "0x3612170", Offset = "0x3610D70", VA = "0x183612170")]
		public bool LogEnemySnapshot(LevelData.EnemyData data)
		{
			return default(bool);
		}

		// Token: 0x0600DC67 RID: 56423 RVA: 0x00050790 File Offset: 0x0004E990
		[Token(Token = "0x600DC67")]
		[Address(RVA = "0x36143B0", Offset = "0x3612FB0", VA = "0x1836143B0")]
		public bool LogRuneSnapshot()
		{
			return default(bool);
		}

		// Token: 0x0600DC68 RID: 56424 RVA: 0x000507A8 File Offset: 0x0004E9A8
		[Token(Token = "0x600DC68")]
		[Address(RVA = "0x3613330", Offset = "0x3611F30", VA = "0x183613330")]
		public bool LogExtraBattleInfo(string key, int value, bool overwrite = false)
		{
			return default(bool);
		}

		// Token: 0x0600DC69 RID: 56425 RVA: 0x000507C0 File Offset: 0x0004E9C0
		[Token(Token = "0x600DC69")]
		[Address(RVA = "0x36134F0", Offset = "0x36120F0", VA = "0x1836134F0")]
		public bool LogExtraBattleInfo(string key, int value = 1)
		{
			return default(bool);
		}

		// Token: 0x0600DC6A RID: 56426 RVA: 0x000507D8 File Offset: 0x0004E9D8
		[Token(Token = "0x600DC6A")]
		[Address(RVA = "0x3612EE0", Offset = "0x3611AE0", VA = "0x183612EE0")]
		public bool LogExtraBattleInfoCharacterNotMannuallySpawn(string key)
		{
			return default(bool);
		}

		// Token: 0x0600DC6B RID: 56427 RVA: 0x000507F0 File Offset: 0x0004E9F0
		[Token(Token = "0x600DC6B")]
		[Address(RVA = "0x3612E20", Offset = "0x3611A20", VA = "0x183612E20")]
		public bool LogExtraBattleInfoCharacterKillCount(string key)
		{
			return default(bool);
		}

		// Token: 0x0600DC6C RID: 56428 RVA: 0x00050808 File Offset: 0x0004EA08
		[Token(Token = "0x600DC6C")]
		[Address(RVA = "0x3612F90", Offset = "0x3611B90", VA = "0x183612F90")]
		public bool LogExtraBattleInfoEnemyDieBecauseOfFallDown(string key)
		{
			return default(bool);
		}

		// Token: 0x0600DC6D RID: 56429 RVA: 0x00050820 File Offset: 0x0004EA20
		[Token(Token = "0x600DC6D")]
		[Address(RVA = "0x36140C0", Offset = "0x3612CC0", VA = "0x1836140C0")]
		public bool LogRoguelikeRelicSnapshot(IEnumerable<BasicRelic> relics)
		{
			return default(bool);
		}

		// Token: 0x0600DC6E RID: 56430 RVA: 0x00050838 File Offset: 0x0004EA38
		[Token(Token = "0x600DC6E")]
		[Address(RVA = "0x3612B90", Offset = "0x3611790", VA = "0x183612B90")]
		public bool LogExtraBattleInfoAddCount(ExtraLogType logType, List<int> indexs)
		{
			return default(bool);
		}

		// Token: 0x0600DC6F RID: 56431 RVA: 0x00050850 File Offset: 0x0004EA50
		[Token(Token = "0x600DC6F")]
		[Address(RVA = "0x3613050", Offset = "0x3611C50", VA = "0x183613050")]
		public bool LogExtraBattleInfoMaxCount(ExtraLogType logType, List<int> indexs, int new_count)
		{
			return default(bool);
		}

		// Token: 0x0600DC70 RID: 56432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC70")]
		[Address(RVA = "0x3614BE0", Offset = "0x36137E0", VA = "0x183614BE0")]
		public void OnCharacterFinish(BattleCharacterData data, Entity.FinishReason reason)
		{
		}

		// Token: 0x0600DC71 RID: 56433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC71")]
		[Address(RVA = "0x3614D90", Offset = "0x3613990", VA = "0x183614D90")]
		public void OnEnemyBorn(LevelData.EnemyData data)
		{
		}

		// Token: 0x0600DC72 RID: 56434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC72")]
		[Address(RVA = "0x3614E70", Offset = "0x3613A70", VA = "0x183614E70")]
		public void OnEnemyFinish(LevelData.EnemyData data, Enemy.Options options, Entity.FinishReason reason)
		{
		}

		// Token: 0x0600DC73 RID: 56435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC73")]
		[Address(RVA = "0x3615050", Offset = "0x3613C50", VA = "0x183615050")]
		public void OnSkillTrig(BattleCharacterData data)
		{
		}

		// Token: 0x0600DC74 RID: 56436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC74")]
		[Address(RVA = "0x3614D10", Offset = "0x3613910", VA = "0x183614D10")]
		public void OnCostUnnaturalRecovered(int cost)
		{
		}

		// Token: 0x0600DC75 RID: 56437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC75")]
		[Address(RVA = "0x3614B70", Offset = "0x3613770", VA = "0x183614B70")]
		public void OnAutoReplayCancelled()
		{
		}

		// Token: 0x0600DC76 RID: 56438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC76")]
		[Address(RVA = "0x3611BD0", Offset = "0x36107D0", VA = "0x183611BD0")]
		public void ClearAll()
		{
		}

		// Token: 0x0600DC77 RID: 56439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DC77")]
		[Address(RVA = "0x3611B40", Offset = "0x3610740", VA = "0x183611B40")]
		public BattleLogger.BattleStats AchieveStats(BattleController controller)
		{
			return null;
		}

		// Token: 0x0600DC78 RID: 56440 RVA: 0x00050868 File Offset: 0x0004EA68
		[Token(Token = "0x600DC78")]
		[Address(RVA = "0x3611160", Offset = "0x360FD60", VA = "0x183611160")]
		public BattleLogger.Journal AchieveJournal(BattleController controller)
		{
			return default(BattleLogger.Journal);
		}

		// Token: 0x0600DC79 RID: 56441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DC79")]
		[Address(RVA = "0x36115D0", Offset = "0x36101D0", VA = "0x1836115D0")]
		public List<string> AchievePackedRuneDataList()
		{
			return null;
		}

		// Token: 0x0600DC7A RID: 56442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DC7A")]
		[Address(RVA = "0x3611870", Offset = "0x3610470", VA = "0x183611870")]
		public List<string> AchieveSixStarRuneDataList()
		{
			return null;
		}

		// Token: 0x0600DC7B RID: 56443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC7B")]
		[Address(RVA = "0x3615220", Offset = "0x3613E20", VA = "0x183615220")]
		private void _AppendLog(BattleLogger.LogItem log)
		{
		}

		// Token: 0x0600DC7C RID: 56444 RVA: 0x00050880 File Offset: 0x0004EA80
		[Token(Token = "0x600DC7C")]
		[Address(RVA = "0x36153D0", Offset = "0x3613FD0", VA = "0x1836153D0")]
		private bool _CheckPlayerSide(PlayerSide sourceSide)
		{
			return default(bool);
		}

		// Token: 0x0400EE43 RID: 60995
		[Token(Token = "0x400EE43")]
		private const int MAX_SNAPSHOTS_FOR_SINGLE_CHARACTER = 1;

		// Token: 0x0400EE44 RID: 60996
		[Token(Token = "0x400EE44")]
		private const int MAX_SNAPSHOTS_FOR_SAME_ENEMY = 1;

		// Token: 0x0400EE45 RID: 60997
		[Token(Token = "0x400EE45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int m_randomSeed;

		// Token: 0x0400EE46 RID: 60998
		[Token(Token = "0x400EE46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private BattleController m_controller;

		// Token: 0x0400EE47 RID: 60999
		[Token(Token = "0x400EE47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<BattleLogger.LogItem> m_logs;

		// Token: 0x0400EE48 RID: 61000
		[Token(Token = "0x400EE48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<BattleLogger.CharInfo> m_squad;

		// Token: 0x0400EE49 RID: 61001
		[Token(Token = "0x400EE49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private BattleLogger.BattleStats m_stats;

		// Token: 0x0400EE4A RID: 61002
		[Token(Token = "0x400EE4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BattleVerboseRecorder m_verboseRecorder;

		// Token: 0x0400EE4B RID: 61003
		[Token(Token = "0x400EE4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400EE4C RID: 61004
		[Token(Token = "0x400EE4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CreateVerboseRecorder;

		// Token: 0x0400EE4D RID: 61005
		[Token(Token = "0x400EE4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LogSquadAndRandomSeed;

		// Token: 0x0400EE4E RID: 61006
		[Token(Token = "0x400EE4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LogManualSpawn;

		// Token: 0x0400EE4F RID: 61007
		[Token(Token = "0x400EE4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LogManualWithdraw;

		// Token: 0x0400EE50 RID: 61008
		[Token(Token = "0x400EE50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LogCharacterAutoWithdraw;

		// Token: 0x0400EE51 RID: 61009
		[Token(Token = "0x400EE51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LogManualSkill;

		// Token: 0x0400EE52 RID: 61010
		[Token(Token = "0x400EE52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LogModifier;

		// Token: 0x0400EE53 RID: 61011
		[Token(Token = "0x400EE53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LogEpModifier;

		// Token: 0x0400EE54 RID: 61012
		[Token(Token = "0x400EE54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LogEpBreakModifier;

		// Token: 0x0400EE55 RID: 61013
		[Token(Token = "0x400EE55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LogCharacterSnapshot;

		// Token: 0x0400EE56 RID: 61014
		[Token(Token = "0x400EE56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LogEnemySnapshot;

		// Token: 0x0400EE57 RID: 61015
		[Token(Token = "0x400EE57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LogRuneSnapshot;

		// Token: 0x0400EE58 RID: 61016
		[Token(Token = "0x400EE58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_LogExtraBattleInfo;

		// Token: 0x0400EE59 RID: 61017
		[Token(Token = "0x400EE59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix1_LogExtraBattleInfo;

		// Token: 0x0400EE5A RID: 61018
		[Token(Token = "0x400EE5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_LogExtraBattleInfoCharacterNotMannuallySpawn;

		// Token: 0x0400EE5B RID: 61019
		[Token(Token = "0x400EE5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_LogExtraBattleInfoCharacterKillCount;

		// Token: 0x0400EE5C RID: 61020
		[Token(Token = "0x400EE5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_LogExtraBattleInfoEnemyDieBecauseOfFallDown;

		// Token: 0x0400EE5D RID: 61021
		[Token(Token = "0x400EE5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_LogRoguelikeRelicSnapshot;

		// Token: 0x0400EE5E RID: 61022
		[Token(Token = "0x400EE5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_LogExtraBattleInfoAddCount;

		// Token: 0x0400EE5F RID: 61023
		[Token(Token = "0x400EE5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_LogExtraBattleInfoMaxCount;

		// Token: 0x0400EE60 RID: 61024
		[Token(Token = "0x400EE60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnCharacterFinish;

		// Token: 0x0400EE61 RID: 61025
		[Token(Token = "0x400EE61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnEnemyBorn;

		// Token: 0x0400EE62 RID: 61026
		[Token(Token = "0x400EE62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnEnemyFinish;

		// Token: 0x0400EE63 RID: 61027
		[Token(Token = "0x400EE63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnSkillTrig;

		// Token: 0x0400EE64 RID: 61028
		[Token(Token = "0x400EE64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnCostUnnaturalRecovered;

		// Token: 0x0400EE65 RID: 61029
		[Token(Token = "0x400EE65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnAutoReplayCancelled;

		// Token: 0x0400EE66 RID: 61030
		[Token(Token = "0x400EE66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_ClearAll;

		// Token: 0x0400EE67 RID: 61031
		[Token(Token = "0x400EE67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_AchieveStats;

		// Token: 0x0400EE68 RID: 61032
		[Token(Token = "0x400EE68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_AchieveJournal;

		// Token: 0x0400EE69 RID: 61033
		[Token(Token = "0x400EE69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_AchievePackedRuneDataList;

		// Token: 0x0400EE6A RID: 61034
		[Token(Token = "0x400EE6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_AchieveSixStarRuneDataList;

		// Token: 0x0400EE6B RID: 61035
		[Token(Token = "0x400EE6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__AppendLog;

		// Token: 0x0400EE6C RID: 61036
		[Token(Token = "0x400EE6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__CheckPlayerSide;

		// Token: 0x02002241 RID: 8769
		[Token(Token = "0x2002241")]
		public struct CharInfo
		{
			// Token: 0x0600DC7D RID: 56445 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600DC7D")]
			[Address(RVA = "0x361DF20", Offset = "0x361CB20", VA = "0x18361DF20")]
			public List<object> ToListCharInfo()
			{
				return null;
			}

			// Token: 0x0400EE6D RID: 61037
			[Token(Token = "0x400EE6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int charInstId;

			// Token: 0x0400EE6E RID: 61038
			[Token(Token = "0x400EE6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string skinId;

			// Token: 0x0400EE6F RID: 61039
			[Token(Token = "0x400EE6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string tmplId;

			// Token: 0x0400EE70 RID: 61040
			[Token(Token = "0x400EE70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string skillId;

			// Token: 0x0400EE71 RID: 61041
			[Token(Token = "0x400EE71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int skillIndex;

			// Token: 0x0400EE72 RID: 61042
			[Token(Token = "0x400EE72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int skillLvl;

			// Token: 0x0400EE73 RID: 61043
			[Token(Token = "0x400EE73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int level;

			// Token: 0x0400EE74 RID: 61044
			[Token(Token = "0x400EE74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public EvolvePhase phase;

			// Token: 0x0400EE75 RID: 61045
			[Token(Token = "0x400EE75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int potentialRank;

			// Token: 0x0400EE76 RID: 61046
			[Token(Token = "0x400EE76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int favorBattlePhase;

			// Token: 0x0400EE77 RID: 61047
			[Token(Token = "0x400EE77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isAssistChar;

			// Token: 0x0400EE78 RID: 61048
			[Token(Token = "0x400EE78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string uniequipId;

			// Token: 0x0400EE79 RID: 61049
			[Token(Token = "0x400EE79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public int uniequipLevel;
		}

		// Token: 0x02002242 RID: 8770
		[Token(Token = "0x2002242")]
		public struct LogItem : IComparable<BattleLogger.LogItem>
		{
			// Token: 0x0600DC7E RID: 56446 RVA: 0x00050898 File Offset: 0x0004EA98
			[Token(Token = "0x600DC7E")]
			[Address(RVA = "0x3624AA0", Offset = "0x36236A0", VA = "0x183624AA0", Slot = "4")]
			public int CompareTo(BattleLogger.LogItem other)
			{
				return 0;
			}

			// Token: 0x0600DC7F RID: 56447 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600DC7F")]
			[Address(RVA = "0x3624AB0", Offset = "0x36236B0", VA = "0x183624AB0")]
			public StringBuilder ToStringBuilder()
			{
				return null;
			}

			// Token: 0x0600DC80 RID: 56448 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600DC80")]
			[Address(RVA = "0x3624D30", Offset = "0x3623930", VA = "0x183624D30", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0400EE7A RID: 61050
			[Token(Token = "0x400EE7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float timestamp;

			// Token: 0x0400EE7B RID: 61051
			[Token(Token = "0x400EE7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public BattleCharacterData.Signiture signiture;

			// Token: 0x0400EE7C RID: 61052
			[Token(Token = "0x400EE7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PlayerOperationType op;

			// Token: 0x0400EE7D RID: 61053
			[Token(Token = "0x400EE7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public SharedConsts.Direction direction;

			// Token: 0x0400EE7E RID: 61054
			[Token(Token = "0x400EE7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GridPosition pos;

			// Token: 0x0400EE7F RID: 61055
			[Token(Token = "0x400EE7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string extraInfo;
		}

		// Token: 0x02002243 RID: 8771
		[Token(Token = "0x2002243")]
		public struct Journal
		{
			// Token: 0x0600DC81 RID: 56449 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600DC81")]
			[Address(RVA = "0x3620260", Offset = "0x361EE60", VA = "0x183620260")]
			public StringBuilder ToStringBuilder()
			{
				return null;
			}

			// Token: 0x0600DC82 RID: 56450 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600DC82")]
			[Address(RVA = "0x36204F0", Offset = "0x361F0F0", VA = "0x1836204F0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0400EE80 RID: 61056
			[Token(Token = "0x400EE80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public BattleLogger.Journal.Metadata metadata;

			// Token: 0x0400EE81 RID: 61057
			[Token(Token = "0x400EE81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public List<BattleLogger.CharInfo> squad;

			// Token: 0x0400EE82 RID: 61058
			[Token(Token = "0x400EE82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public List<BattleLogger.LogItem> logs;

			// Token: 0x0400EE83 RID: 61059
			[Token(Token = "0x400EE83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public int randomSeed;

			// Token: 0x0400EE84 RID: 61060
			[Token(Token = "0x400EE84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public List<string> runeList;

			// Token: 0x02002244 RID: 8772
			[Token(Token = "0x2002244")]
			public struct Metadata
			{
				// Token: 0x0600DC83 RID: 56451 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600DC83")]
				[Address(RVA = "0x3629430", Offset = "0x3628030", VA = "0x183629430")]
				public StringBuilder ToStringBuilder()
				{
					return null;
				}

				// Token: 0x0600DC84 RID: 56452 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600DC84")]
				[Address(RVA = "0x3629700", Offset = "0x3628300", VA = "0x183629700", Slot = "3")]
				public override string ToString()
				{
					return null;
				}

				// Token: 0x0400EE85 RID: 61061
				[Token(Token = "0x400EE85")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public float standardPlayTime;

				// Token: 0x0400EE86 RID: 61062
				[Token(Token = "0x400EE86")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public BattleController.GameResult gameResult;

				// Token: 0x0400EE87 RID: 61063
				[Token(Token = "0x400EE87")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public DateTime saveTime;

				// Token: 0x0400EE88 RID: 61064
				[Token(Token = "0x400EE88")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public int remainingCost;

				// Token: 0x0400EE89 RID: 61065
				[Token(Token = "0x400EE89")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public int remainingLifePoint;

				// Token: 0x0400EE8A RID: 61066
				[Token(Token = "0x400EE8A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public int killedEnemiesCnt;

				// Token: 0x0400EE8B RID: 61067
				[Token(Token = "0x400EE8B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				public int missedEnemiesCnt;

				// Token: 0x0400EE8C RID: 61068
				[Token(Token = "0x400EE8C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public string levelId;

				// Token: 0x0400EE8D RID: 61069
				[Token(Token = "0x400EE8D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public string stageId;

				// Token: 0x0400EE8E RID: 61070
				[Token(Token = "0x400EE8E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public int validKilledEnemiesCnt;
			}
		}

		// Token: 0x02002245 RID: 8773
		[Token(Token = "0x2002245")]
		public class BattleStats : IHotfixable
		{
			// Token: 0x0600DC85 RID: 56453 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DC85")]
			[Address(RVA = "0x3615D00", Offset = "0x3614900", VA = "0x183615D00")]
			public void ClearAll()
			{
			}

			// Token: 0x0600DC86 RID: 56454 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600DC86")]
			[Address(RVA = "0x36169E0", Offset = "0x36155E0", VA = "0x1836169E0")]
			public BattleLogger.BattleStats.CharAdvancedStats TouchCharAdvancedStats(string charId)
			{
				return null;
			}

			// Token: 0x0600DC87 RID: 56455 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600DC87")]
			[Address(RVA = "0x3616AF0", Offset = "0x36156F0", VA = "0x183616AF0")]
			public BattleLogger.BattleStats.EnemyAdvancedStats TouchEnemyAdvancedStats(string enemyId)
			{
				return null;
			}

			// Token: 0x0600DC88 RID: 56456 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600DC88")]
			[Address(RVA = "0x3616190", Offset = "0x3614D90", VA = "0x183616190")]
			public BattleLogger.BattleStats TakeSnapShot(BattleController controller, BattleLogger logger)
			{
				return null;
			}

			// Token: 0x0600DC89 RID: 56457 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DC89")]
			[Address(RVA = "0x3616CB0", Offset = "0x36158B0", VA = "0x183616CB0")]
			private void _FilterBattleInfoStats(ListDict<string, BattleLogger.BattleStats.CharAdvancedStats> advChars)
			{
			}

			// Token: 0x0600DC8A RID: 56458 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DC8A")]
			[Address(RVA = "0x3616040", Offset = "0x3614C40", VA = "0x183616040")]
			public void LogExtraBattleInfo(ExtraLogType type, string extraKey, int value, bool useMax = false)
			{
			}

			// Token: 0x0600DC8B RID: 56459 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DC8B")]
			[Address(RVA = "0x36170E0", Offset = "0x3615CE0", VA = "0x1836170E0")]
			private void _GenerateCharList(BattleLogger.BattleStats snapShot, BattleLogger logger, ListDict<string, BattleLogger.BattleStats.CharAdvancedStats> advChars, List<BattleLogger.CharInfo> squad)
			{
			}

			// Token: 0x0600DC8C RID: 56460 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600DC8C")]
			[Address(RVA = "0x3618270", Offset = "0x3616E70", VA = "0x183618270")]
			private static List<object> _GetCharCommonLogList(BattleLogger.BattleStats.CharAdvancedStats advancedStats, BattleLogger.CharInfo squadCharInfo)
			{
				return null;
			}

			// Token: 0x0600DC8D RID: 56461 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DC8D")]
			[Address(RVA = "0x3617D70", Offset = "0x3616970", VA = "0x183617D70")]
			private void _GenerateLegionCharList(BattleLogger.BattleStats snapShot, List<BattleLogger.CharInfo> squad, KeyValuePair<string, BattleLogger.BattleStats.CharAdvancedStats> advChar)
			{
			}

			// Token: 0x0600DC8E RID: 56462 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DC8E")]
			[Address(RVA = "0x3618780", Offset = "0x3617380", VA = "0x183618780")]
			public BattleStats()
			{
			}

			// Token: 0x0400EE8F RID: 61071
			[Token(Token = "0x400EE8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int killedEnemiesCnt;

			// Token: 0x0400EE90 RID: 61072
			[Token(Token = "0x400EE90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int unnatrualRecoveredCost;

			// Token: 0x0400EE91 RID: 61073
			[Token(Token = "0x400EE91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ListCounterPool<BattleLogger.BattleStats.CharStatKey> charStats;

			// Token: 0x0400EE92 RID: 61074
			[Token(Token = "0x400EE92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ListCounterPool<BattleLogger.BattleStats.EnemyStatKey> enemyStats;

			// Token: 0x0400EE93 RID: 61075
			[Token(Token = "0x400EE93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ListCounterPool<BattleLogger.BattleStats.SkillTrigStatsKey> skillTrigStats;

			// Token: 0x0400EE94 RID: 61076
			[Token(Token = "0x400EE94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ListDict<string, BattleLogger.BattleStats.CharAdvancedStats> charAdvancedStats;

			// Token: 0x0400EE95 RID: 61077
			[Token(Token = "0x400EE95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public ListDict<string, BattleLogger.BattleStats.EnemyAdvancedStats> enemyAdvancedStats;

			// Token: 0x0400EE96 RID: 61078
			[Token(Token = "0x400EE96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public List<List<object>> runeAdvancedStats;

			// Token: 0x0400EE97 RID: 61079
			[Token(Token = "0x400EE97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public List<List<object>> rlBuffAdvancedStats;

			// Token: 0x0400EE98 RID: 61080
			[Token(Token = "0x400EE98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public ListDict<string, int> extraBattleInfoStats;

			// Token: 0x0400EE99 RID: 61081
			[Token(Token = "0x400EE99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public List<List<int>> extraBattleInfoSubStats;

			// Token: 0x0400EE9A RID: 61082
			[Token(Token = "0x400EE9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private List<int> m_extraBattleLogTmpIds;

			// Token: 0x0400EE9B RID: 61083
			[Token(Token = "0x400EE9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public ListDict<string, List<object>> charList;

			// Token: 0x0400EE9C RID: 61084
			[Token(Token = "0x400EE9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public ListDict<string, List<object>> enemyList;

			// Token: 0x0400EE9D RID: 61085
			[Token(Token = "0x400EE9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public List<List<object>> runeList;

			// Token: 0x0400EE9E RID: 61086
			[Token(Token = "0x400EE9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public List<List<object>> rlBuffList;

			// Token: 0x0400EE9F RID: 61087
			[Token(Token = "0x400EE9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public long beginTs;

			// Token: 0x0400EEA0 RID: 61088
			[Token(Token = "0x400EEA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public long endTs;

			// Token: 0x0400EEA1 RID: 61089
			[Token(Token = "0x400EEA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public string access;

			// Token: 0x0400EEA2 RID: 61090
			[Token(Token = "0x400EEA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public string hash;

			// Token: 0x0400EEA3 RID: 61091
			[Token(Token = "0x400EEA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public string packageName;

			// Token: 0x0400EEA4 RID: 61092
			[Token(Token = "0x400EEA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public bool checkKilledCnt;

			// Token: 0x0400EEA5 RID: 61093
			[Token(Token = "0x400EEA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			public int leftHp;

			// Token: 0x0400EEA6 RID: 61094
			[Token(Token = "0x400EEA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public float totalHeal;

			// Token: 0x0400EEA7 RID: 61095
			[Token(Token = "0x400EEA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			public float totalDamage;

			// Token: 0x0400EEA8 RID: 61096
			[Token(Token = "0x400EEA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			public long fixedPlayTime;

			// Token: 0x0400EEA9 RID: 61097
			[Token(Token = "0x400EEA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			public List<int> restartCompleteTimeList;

			// Token: 0x0400EEAA RID: 61098
			[Token(Token = "0x400EEAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			public Dictionary<int, string> extraInfo;

			// Token: 0x0400EEAB RID: 61099
			[Token(Token = "0x400EEAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			public ListDict<string, int> extraBattleInfo;

			// Token: 0x0400EEAC RID: 61100
			[Token(Token = "0x400EEAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			public ListDict<int, List<object>> clientAntiCheatLog;

			// Token: 0x0400EEAD RID: 61101
			[Token(Token = "0x400EEAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			public List<string> idList;

			// Token: 0x0400EEAE RID: 61102
			[Token(Token = "0x400EEAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			public List<string> packedRuneDataList;

			// Token: 0x0400EEAF RID: 61103
			[Token(Token = "0x400EEAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			public List<string> sixStarRuneList;

			// Token: 0x0400EEB0 RID: 61104
			[Token(Token = "0x400EEB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			public bool autoReplayCancelled;

			// Token: 0x0400EEB1 RID: 61105
			[Token(Token = "0x400EEB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_ClearAll;

			// Token: 0x0400EEB2 RID: 61106
			[Token(Token = "0x400EEB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_TouchCharAdvancedStats;

			// Token: 0x0400EEB3 RID: 61107
			[Token(Token = "0x400EEB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_TouchEnemyAdvancedStats;

			// Token: 0x0400EEB4 RID: 61108
			[Token(Token = "0x400EEB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_TakeSnapShot;

			// Token: 0x0400EEB5 RID: 61109
			[Token(Token = "0x400EEB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__FilterBattleInfoStats;

			// Token: 0x0400EEB6 RID: 61110
			[Token(Token = "0x400EEB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_LogExtraBattleInfo;

			// Token: 0x0400EEB7 RID: 61111
			[Token(Token = "0x400EEB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__GenerateCharList;

			// Token: 0x0400EEB8 RID: 61112
			[Token(Token = "0x400EEB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__GetCharCommonLogList;

			// Token: 0x0400EEB9 RID: 61113
			[Token(Token = "0x400EEB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__GenerateLegionCharList;

			// Token: 0x0400EEBA RID: 61114
			[Token(Token = "0x400EEBA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02002246 RID: 8774
			[Token(Token = "0x2002246")]
			public struct EnemyStatKey : IEquatable<BattleLogger.BattleStats.EnemyStatKey>
			{
				// Token: 0x0600DC8F RID: 56463 RVA: 0x000508B0 File Offset: 0x0004EAB0
				[Token(Token = "0x600DC8F")]
				[Address(RVA = "0x361EFA0", Offset = "0x361DBA0", VA = "0x18361EFA0", Slot = "4")]
				public bool Equals(BattleLogger.BattleStats.EnemyStatKey other)
				{
					return default(bool);
				}

				// Token: 0x0400EEBB RID: 61115
				[Token(Token = "0x400EEBB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string enemyId;

				// Token: 0x0400EEBC RID: 61116
				[Token(Token = "0x400EEBC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[JsonConverter(typeof(StringEnumConverter))]
				public BattleLogger.BattleStats.EnemyStatKey.CounterType counterType;

				// Token: 0x0400EEBD RID: 61117
				[Token(Token = "0x400EEBD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public bool isInvalidKilled;

				// Token: 0x02002247 RID: 8775
				[Token(Token = "0x2002247")]
				public enum CounterType
				{
					// Token: 0x0400EEBF RID: 61119
					[Token(Token = "0x400EEBF")]
					HP_ZERO,
					// Token: 0x0400EEC0 RID: 61120
					[Token(Token = "0x400EEC0")]
					FALLDOWN,
					// Token: 0x0400EEC1 RID: 61121
					[Token(Token = "0x400EEC1")]
					REACH_EXIT,
					// Token: 0x0400EEC2 RID: 61122
					[Token(Token = "0x400EEC2")]
					ENCOUNTER,
					// Token: 0x0400EEC3 RID: 61123
					[Token(Token = "0x400EEC3")]
					DEADLIKE_REACH_EXIT
				}
			}

			// Token: 0x02002248 RID: 8776
			[Token(Token = "0x2002248")]
			public struct CharStatKey : IEquatable<BattleLogger.BattleStats.CharStatKey>
			{
				// Token: 0x0600DC90 RID: 56464 RVA: 0x000508C8 File Offset: 0x0004EAC8
				[Token(Token = "0x600DC90")]
				[Address(RVA = "0xF5CEF0", Offset = "0xF5BAF0", VA = "0x180F5CEF0", Slot = "4")]
				public bool Equals(BattleLogger.BattleStats.CharStatKey other)
				{
					return default(bool);
				}

				// Token: 0x0400EEC4 RID: 61124
				[Token(Token = "0x400EEC4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string charId;

				// Token: 0x0400EEC5 RID: 61125
				[Token(Token = "0x400EEC5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[JsonConverter(typeof(StringEnumConverter))]
				public BattleLogger.BattleStats.CharStatKey.CounterType counterType;

				// Token: 0x02002249 RID: 8777
				[Token(Token = "0x2002249")]
				public enum CounterType
				{
					// Token: 0x0400EEC7 RID: 61127
					[Token(Token = "0x400EEC7")]
					SPAWN,
					// Token: 0x0400EEC8 RID: 61128
					[Token(Token = "0x400EEC8")]
					DEAD,
					// Token: 0x0400EEC9 RID: 61129
					[Token(Token = "0x400EEC9")]
					WITHDRAW
				}
			}

			// Token: 0x0200224A RID: 8778
			[Token(Token = "0x200224A")]
			public class CharAdvancedStats : IHotfixable
			{
				// Token: 0x0600DC91 RID: 56465 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600DC91")]
				[Address(RVA = "0x361DB50", Offset = "0x361C750", VA = "0x18361DB50")]
				public CharAdvancedStats()
				{
				}

				// Token: 0x0600DC92 RID: 56466 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600DC92")]
				[Address(RVA = "0x361D850", Offset = "0x361C450", VA = "0x18361D850")]
				public List<object> ToListOutputDamageRange()
				{
					return null;
				}

				// Token: 0x0600DC93 RID: 56467 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600DC93")]
				[Address(RVA = "0x361D580", Offset = "0x361C180", VA = "0x18361D580")]
				public List<object> ToListElementDamage()
				{
					return null;
				}

				// Token: 0x0600DC94 RID: 56468 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600DC94")]
				[Address(RVA = "0x361D700", Offset = "0x361C300", VA = "0x18361D700")]
				public List<object> ToListEpBreakCnt()
				{
					return null;
				}

				// Token: 0x0600DC95 RID: 56469 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600DC95")]
				[Address(RVA = "0x361D430", Offset = "0x361C030", VA = "0x18361D430")]
				public List<object> ToListDamageByTypeTotal()
				{
					return null;
				}

				// Token: 0x0400EECA RID: 61130
				[Token(Token = "0x400EECA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public Vector2 outputDamageRange;

				// Token: 0x0400EECB RID: 61131
				[Token(Token = "0x400EECB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public Vector2 inputDamageRange;

				// Token: 0x0400EECC RID: 61132
				[Token(Token = "0x400EECC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public float outputDamageTotal;

				// Token: 0x0400EECD RID: 61133
				[Token(Token = "0x400EECD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public List<float> outputElementDamageTotal;

				// Token: 0x0400EECE RID: 61134
				[Token(Token = "0x400EECE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public List<int> outputEpBreakCnt;

				// Token: 0x0400EECF RID: 61135
				[Token(Token = "0x400EECF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				public List<float> outputDamageByTypeTotal;

				// Token: 0x0400EED0 RID: 61136
				[Token(Token = "0x400EED0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				public List<CharacterSnapshot> snapshots;

				// Token: 0x0400EED1 RID: 61137
				[Token(Token = "0x400EED1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge _c__Hotfix0_ctor;

				// Token: 0x0400EED2 RID: 61138
				[Token(Token = "0x400EED2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_ToListOutputDamageRange;

				// Token: 0x0400EED3 RID: 61139
				[Token(Token = "0x400EED3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_ToListElementDamage;

				// Token: 0x0400EED4 RID: 61140
				[Token(Token = "0x400EED4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_ToListEpBreakCnt;

				// Token: 0x0400EED5 RID: 61141
				[Token(Token = "0x400EED5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_ToListDamageByTypeTotal;
			}

			// Token: 0x0200224B RID: 8779
			[Token(Token = "0x200224B")]
			public class EnemyAdvancedStats : IHotfixable
			{
				// Token: 0x0600DC96 RID: 56470 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600DC96")]
				[Address(RVA = "0x361ECF0", Offset = "0x361D8F0", VA = "0x18361ECF0")]
				public List<object> ToList()
				{
					return null;
				}

				// Token: 0x0600DC97 RID: 56471 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600DC97")]
				[Address(RVA = "0x361EEE0", Offset = "0x361DAE0", VA = "0x18361EEE0")]
				public EnemyAdvancedStats()
				{
				}

				// Token: 0x0400EED6 RID: 61142
				[Token(Token = "0x400EED6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public List<EnemySnapshot> snapshots;

				// Token: 0x0400EED7 RID: 61143
				[Token(Token = "0x400EED7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_ToList;

				// Token: 0x0400EED8 RID: 61144
				[Token(Token = "0x400EED8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x0200224C RID: 8780
			[Token(Token = "0x200224C")]
			public class SkillTrigStatsKey : IHotfixable, IEquatable<BattleLogger.BattleStats.SkillTrigStatsKey>
			{
				// Token: 0x0600DC98 RID: 56472 RVA: 0x000508E0 File Offset: 0x0004EAE0
				[Token(Token = "0x600DC98")]
				[Address(RVA = "0x3629D40", Offset = "0x3628940", VA = "0x183629D40", Slot = "4")]
				public bool Equals(BattleLogger.BattleStats.SkillTrigStatsKey other)
				{
					return default(bool);
				}

				// Token: 0x0600DC99 RID: 56473 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600DC99")]
				[Address(RVA = "0x3629DE0", Offset = "0x36289E0", VA = "0x183629DE0")]
				public SkillTrigStatsKey()
				{
				}

				// Token: 0x0400EED9 RID: 61145
				[Token(Token = "0x400EED9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string charId;

				// Token: 0x0400EEDA RID: 61146
				[Token(Token = "0x400EEDA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public string skillId;

				// Token: 0x0400EEDB RID: 61147
				[Token(Token = "0x400EEDB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_Equals;

				// Token: 0x0400EEDC RID: 61148
				[Token(Token = "0x400EEDC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}
		}
	}
}
