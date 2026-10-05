using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x0200224F RID: 8783
	[Token(Token = "0x200224F")]
	public class BattleVerboseRecorder : IBattleModule
	{
		// Token: 0x0600DC9E RID: 56478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DC9E")]
		[Address(RVA = "0x361A6C0", Offset = "0x36192C0", VA = "0x18361A6C0")]
		public static string GetLogDirPath()
		{
			return null;
		}

		// Token: 0x0600DC9F RID: 56479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC9F")]
		[Address(RVA = "0x361B030", Offset = "0x3619C30", VA = "0x18361B030")]
		private void _OnAppliedModifier(object arg)
		{
		}

		// Token: 0x0600DCA0 RID: 56480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCA0")]
		[Address(RVA = "0x361C3C0", Offset = "0x361AFC0", VA = "0x18361C3C0")]
		private void _OnSkillCast(object arg)
		{
		}

		// Token: 0x0600DCA1 RID: 56481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCA1")]
		[Address(RVA = "0x361C690", Offset = "0x361B290", VA = "0x18361C690")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600DCA2 RID: 56482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCA2")]
		[Address(RVA = "0x361BF70", Offset = "0x361AB70", VA = "0x18361BF70")]
		private void _OnRallyPointReborn(object arg)
		{
		}

		// Token: 0x0600DCA3 RID: 56483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCA3")]
		[Address(RVA = "0x361CBD0", Offset = "0x361B7D0", VA = "0x18361CBD0")]
		private void _OnUnitFinish(object arg)
		{
		}

		// Token: 0x0600DCA4 RID: 56484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCA4")]
		[Address(RVA = "0x361BC10", Offset = "0x361A810", VA = "0x18361BC10")]
		private void _OnBuffStart(object arg)
		{
		}

		// Token: 0x0600DCA5 RID: 56485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCA5")]
		[Address(RVA = "0x361B9F0", Offset = "0x361A5F0", VA = "0x18361B9F0")]
		private void _OnBuffFinish(object arg)
		{
		}

		// Token: 0x0600DCA6 RID: 56486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCA6")]
		[Address(RVA = "0x361C5F0", Offset = "0x361B1F0", VA = "0x18361C5F0")]
		private void _OnSnapShot(object arg)
		{
		}

		// Token: 0x0600DCA7 RID: 56487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCA7")]
		[Address(RVA = "0x361BED0", Offset = "0x361AAD0", VA = "0x18361BED0")]
		private void _OnPlayerOperation(object arg)
		{
		}

		// Token: 0x0600DCA8 RID: 56488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCA8")]
		[Address(RVA = "0x361BE30", Offset = "0x361AA30", VA = "0x18361BE30")]
		private void _OnGiveUpGame(object arg)
		{
		}

		// Token: 0x0600DCA9 RID: 56489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCA9")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public void OnGameReady()
		{
		}

		// Token: 0x0600DCAA RID: 56490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCAA")]
		[Address(RVA = "0x361A860", Offset = "0x3619460", VA = "0x18361A860", Slot = "4")]
		public void OnGameReset(BattleController controller)
		{
		}

		// Token: 0x0600DCAB RID: 56491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCAB")]
		[Address(RVA = "0x361A700", Offset = "0x3619300", VA = "0x18361A700", Slot = "5")]
		public void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x0600DCAC RID: 56492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCAC")]
		[Address(RVA = "0x361AB60", Offset = "0x3619760", VA = "0x18361AB60", Slot = "7")]
		public void OnGameStart()
		{
		}

		// Token: 0x0600DCAD RID: 56493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCAD")]
		[Address(RVA = "0x361A760", Offset = "0x3619360", VA = "0x18361A760", Slot = "8")]
		public void OnGameOver(BattleController.GameResult result)
		{
		}

		// Token: 0x0600DCAE RID: 56494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCAE")]
		[Address(RVA = "0x361A650", Offset = "0x3619250", VA = "0x18361A650")]
		public void ClearAll()
		{
		}

		// Token: 0x0600DCAF RID: 56495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCAF")]
		[Address(RVA = "0x361AE70", Offset = "0x3619A70", VA = "0x18361AE70")]
		private void _AppendLog(BattleVerboseRecorder.LogItem log)
		{
		}

		// Token: 0x0600DCB0 RID: 56496 RVA: 0x000508F8 File Offset: 0x0004EAF8
		[Token(Token = "0x600DCB0")]
		[Address(RVA = "0x361ABA0", Offset = "0x36197A0", VA = "0x18361ABA0")]
		private BattleVerboseRecorder.SourceOrTargetRef _AnalyzeComplexSource(ref Modifier modifier, ref Context.Snapshot snapshot)
		{
			return default(BattleVerboseRecorder.SourceOrTargetRef);
		}

		// Token: 0x0600DCB1 RID: 56497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCB1")]
		[Address(RVA = "0x361D0A0", Offset = "0x361BCA0", VA = "0x18361D0A0")]
		private void _ResetLogger()
		{
		}

		// Token: 0x0600DCB2 RID: 56498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCB2")]
		[Address(RVA = "0x361D060", Offset = "0x361BC60", VA = "0x18361D060")]
		private void _ReleaseLogger()
		{
		}

		// Token: 0x0600DCB3 RID: 56499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DCB3")]
		[Address(RVA = "0x361B000", Offset = "0x3619C00", VA = "0x18361B000")]
		private string _GetFileFormat()
		{
			return null;
		}

		// Token: 0x0600DCB4 RID: 56500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DCB4")]
		[Address(RVA = "0x361D210", Offset = "0x361BE10", VA = "0x18361D210")]
		public BattleVerboseRecorder()
		{
		}

		// Token: 0x0400EEDF RID: 61151
		[Token(Token = "0x400EEDF")]
		private const string SAVE_DIR = "BattleLog";

		// Token: 0x0400EEE0 RID: 61152
		[Token(Token = "0x400EEE0")]
		private const string FILENAME_FORMAT = "{0}/BattleLog_{1}/B-{2}.log";

		// Token: 0x0400EEE1 RID: 61153
		[Token(Token = "0x400EEE1")]
		private const string MULTIPLAYER_SIDE_A_FILENAME_FORMAT = "{0}/MultiBattleLog_Player_A{1}/B-{2}.log";

		// Token: 0x0400EEE2 RID: 61154
		[Token(Token = "0x400EEE2")]
		private const string MULTIPLAYER_SIDE_B_FILENAME_FORMAT = "{0}/MultiBattleLog_Player_B{1}/B-{2}.log";

		// Token: 0x0400EEE3 RID: 61155
		[Token(Token = "0x400EEE3")]
		[FieldOffset(Offset = "0x10")]
		private List<BattleVerboseRecorder.LogItem> m_detailLogs;

		// Token: 0x0400EEE4 RID: 61156
		[Token(Token = "0x400EEE4")]
		[FieldOffset(Offset = "0x18")]
		private BattleVerboseRecorder.DebugPrinter m_debugPrinter;

		// Token: 0x0400EEE5 RID: 61157
		[Token(Token = "0x400EEE5")]
		[FieldOffset(Offset = "0x20")]
		private FileLogger m_logger;

		// Token: 0x02002250 RID: 8784
		[Token(Token = "0x2002250")]
		public struct SourceOrTargetRef
		{
			// Token: 0x17001BC7 RID: 7111
			// (get) Token: 0x0600DCB5 RID: 56501 RVA: 0x00050910 File Offset: 0x0004EB10
			[Token(Token = "0x17001BC7")]
			public bool isNull
			{
				[Token(Token = "0x600DCB5")]
				[Address(RVA = "0x1A15A50", Offset = "0x1A14650", VA = "0x181A15A50")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600DCB6 RID: 56502 RVA: 0x00050928 File Offset: 0x0004EB28
			[Token(Token = "0x600DCB6")]
			[Address(RVA = "0x3629E40", Offset = "0x3628A40", VA = "0x183629E40")]
			public static BattleVerboseRecorder.SourceOrTargetRef Of(Entity entity)
			{
				return default(BattleVerboseRecorder.SourceOrTargetRef);
			}

			// Token: 0x0600DCB7 RID: 56503 RVA: 0x00050940 File Offset: 0x0004EB40
			[Token(Token = "0x600DCB7")]
			[Address(RVA = "0x362A0E0", Offset = "0x3628CE0", VA = "0x18362A0E0")]
			public static BattleVerboseRecorder.SourceOrTargetRef Of(Tile tile)
			{
				return default(BattleVerboseRecorder.SourceOrTargetRef);
			}

			// Token: 0x0600DCB8 RID: 56504 RVA: 0x00050958 File Offset: 0x0004EB58
			[Token(Token = "0x600DCB8")]
			[Address(RVA = "0x362A1A0", Offset = "0x3628DA0", VA = "0x18362A1A0")]
			public static BattleVerboseRecorder.SourceOrTargetRef Of(Buff buff)
			{
				return default(BattleVerboseRecorder.SourceOrTargetRef);
			}

			// Token: 0x0600DCB9 RID: 56505 RVA: 0x00050970 File Offset: 0x0004EB70
			[Token(Token = "0x600DCB9")]
			[Address(RVA = "0x362A230", Offset = "0x3628E30", VA = "0x18362A230")]
			private static uint _MergeGridPos(GridPosition gridPos)
			{
				return 0U;
			}

			// Token: 0x0600DCBA RID: 56506 RVA: 0x00050988 File Offset: 0x0004EB88
			[Token(Token = "0x600DCBA")]
			[Address(RVA = "0x362A1F0", Offset = "0x3628DF0", VA = "0x18362A1F0")]
			public static GridPosition SplitGridPos(uint value)
			{
				return default(GridPosition);
			}

			// Token: 0x0400EEE6 RID: 61158
			[Token(Token = "0x400EEE6")]
			[FieldOffset(Offset = "0x0")]
			public static readonly BattleVerboseRecorder.SourceOrTargetRef NULL;

			// Token: 0x0400EEE7 RID: 61159
			[Token(Token = "0x400EEE7")]
			private const int MAX_MAP_COLUMNS = 100;

			// Token: 0x0400EEE8 RID: 61160
			[Token(Token = "0x400EEE8")]
			[FieldOffset(Offset = "0x0")]
			public BattleVerboseRecorder.SourceOrTargetRef.Type type;

			// Token: 0x0400EEE9 RID: 61161
			[Token(Token = "0x400EEE9")]
			[FieldOffset(Offset = "0x8")]
			public string key;

			// Token: 0x0400EEEA RID: 61162
			[Token(Token = "0x400EEEA")]
			[FieldOffset(Offset = "0x10")]
			public uint uniqueId;

			// Token: 0x02002251 RID: 8785
			[Token(Token = "0x2002251")]
			public enum Type : byte
			{
				// Token: 0x0400EEEC RID: 61164
				[Token(Token = "0x400EEEC")]
				NONE,
				// Token: 0x0400EEED RID: 61165
				[Token(Token = "0x400EEED")]
				CHARACTER,
				// Token: 0x0400EEEE RID: 61166
				[Token(Token = "0x400EEEE")]
				ENEMY,
				// Token: 0x0400EEEF RID: 61167
				[Token(Token = "0x400EEEF")]
				TILE,
				// Token: 0x0400EEF0 RID: 61168
				[Token(Token = "0x400EEF0")]
				BUFF
			}
		}

		// Token: 0x02002252 RID: 8786
		[Token(Token = "0x2002252")]
		public struct LogItem
		{
			// Token: 0x0400EEF1 RID: 61169
			[Token(Token = "0x400EEF1")]
			[FieldOffset(Offset = "0x0")]
			public BattleVerboseRecorder.LogItem.Type type;

			// Token: 0x0400EEF2 RID: 61170
			[Token(Token = "0x400EEF2")]
			[FieldOffset(Offset = "0x4")]
			public uint frameCnt;

			// Token: 0x0400EEF3 RID: 61171
			[Token(Token = "0x400EEF3")]
			[FieldOffset(Offset = "0x8")]
			public BattleVerboseRecorder.SourceOrTargetRef source;

			// Token: 0x0400EEF4 RID: 61172
			[Token(Token = "0x400EEF4")]
			[FieldOffset(Offset = "0x20")]
			public BattleVerboseRecorder.SourceOrTargetRef target;

			// Token: 0x0400EEF5 RID: 61173
			[Token(Token = "0x400EEF5")]
			[FieldOffset(Offset = "0x38")]
			public BattleVerboseRecorder.LogItem.ModifierDelta modifier;

			// Token: 0x0400EEF6 RID: 61174
			[Token(Token = "0x400EEF6")]
			[FieldOffset(Offset = "0x40")]
			public object extraData;

			// Token: 0x0400EEF7 RID: 61175
			[Token(Token = "0x400EEF7")]
			[FieldOffset(Offset = "0x48")]
			public object extraData2;

			// Token: 0x02002253 RID: 8787
			[Token(Token = "0x2002253")]
			public enum Type : byte
			{
				// Token: 0x0400EEF9 RID: 61177
				[Token(Token = "0x400EEF9")]
				BATTLE_START,
				// Token: 0x0400EEFA RID: 61178
				[Token(Token = "0x400EEFA")]
				BATTLE_FINISH,
				// Token: 0x0400EEFB RID: 61179
				[Token(Token = "0x400EEFB")]
				UNIT_BORN,
				// Token: 0x0400EEFC RID: 61180
				[Token(Token = "0x400EEFC")]
				UNIT_FINISH,
				// Token: 0x0400EEFD RID: 61181
				[Token(Token = "0x400EEFD")]
				BUFF_START,
				// Token: 0x0400EEFE RID: 61182
				[Token(Token = "0x400EEFE")]
				BUFF_FINISH,
				// Token: 0x0400EEFF RID: 61183
				[Token(Token = "0x400EEFF")]
				SKILL_CAST,
				// Token: 0x0400EF00 RID: 61184
				[Token(Token = "0x400EF00")]
				MODIFY_HP,
				// Token: 0x0400EF01 RID: 61185
				[Token(Token = "0x400EF01")]
				MODIFY_SP,
				// Token: 0x0400EF02 RID: 61186
				[Token(Token = "0x400EF02")]
				MODIFY_COST,
				// Token: 0x0400EF03 RID: 61187
				[Token(Token = "0x400EF03")]
				MODIFY_LIFE_POINT,
				// Token: 0x0400EF04 RID: 61188
				[Token(Token = "0x400EF04")]
				MODIFY_LIFE_POINT_A,
				// Token: 0x0400EF05 RID: 61189
				[Token(Token = "0x400EF05")]
				MODIFY_LIFE_POINT_B,
				// Token: 0x0400EF06 RID: 61190
				[Token(Token = "0x400EF06")]
				MODIFY_CHAR_LIMIT,
				// Token: 0x0400EF07 RID: 61191
				[Token(Token = "0x400EF07")]
				RALLYPOINT_REBORN,
				// Token: 0x0400EF08 RID: 61192
				[Token(Token = "0x400EF08")]
				SNAP_SHOT,
				// Token: 0x0400EF09 RID: 61193
				[Token(Token = "0x400EF09")]
				PLAYER_OPERATION,
				// Token: 0x0400EF0A RID: 61194
				[Token(Token = "0x400EF0A")]
				MODIFY_COST_SIDE_A,
				// Token: 0x0400EF0B RID: 61195
				[Token(Token = "0x400EF0B")]
				MODIFY_COST_SIDE_B,
				// Token: 0x0400EF0C RID: 61196
				[Token(Token = "0x400EF0C")]
				MODIFY_EP,
				// Token: 0x0400EF0D RID: 61197
				[Token(Token = "0x400EF0D")]
				MODIFY_CHAR_LIMIT_A,
				// Token: 0x0400EF0E RID: 61198
				[Token(Token = "0x400EF0E")]
				MODIFY_CHAR_LIMIT_B
			}

			// Token: 0x02002254 RID: 8788
			[Token(Token = "0x2002254")]
			public struct ModifierDelta
			{
				// Token: 0x0400EF0F RID: 61199
				[Token(Token = "0x400EF0F")]
				[FieldOffset(Offset = "0x0")]
				public float realDelta;

				// Token: 0x0400EF10 RID: 61200
				[Token(Token = "0x400EF10")]
				[FieldOffset(Offset = "0x4")]
				public float afterValue;
			}
		}

		// Token: 0x02002255 RID: 8789
		[Token(Token = "0x2002255")]
		private interface IPrinter
		{
			// Token: 0x0600DCBC RID: 56508
			[Token(Token = "0x600DCBC")]
			string PrintLog(ref BattleVerboseRecorder.LogItem log);
		}

		// Token: 0x02002256 RID: 8790
		[Token(Token = "0x2002256")]
		public class DebugPrinter : BattleVerboseRecorder.IPrinter
		{
			// Token: 0x0600DCBD RID: 56509 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600DCBD")]
			[Address(RVA = "0x361E0F0", Offset = "0x361CCF0", VA = "0x18361E0F0", Slot = "4")]
			public string PrintLog(ref BattleVerboseRecorder.LogItem log)
			{
				return null;
			}

			// Token: 0x0600DCBE RID: 56510 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DCBE")]
			[Address(RVA = "0x361EA50", Offset = "0x361D650", VA = "0x18361EA50")]
			private void _PrintRef(ref BattleVerboseRecorder.SourceOrTargetRef refItem)
			{
			}

			// Token: 0x0600DCBF RID: 56511 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DCBF")]
			[Address(RVA = "0x361E890", Offset = "0x361D490", VA = "0x18361E890")]
			private void _PrintExtraData(object extraData)
			{
			}

			// Token: 0x0600DCC0 RID: 56512 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DCC0")]
			[Address(RVA = "0x361E8F0", Offset = "0x361D4F0", VA = "0x18361E8F0")]
			private void _PrintModifierDelta(ref BattleVerboseRecorder.LogItem.ModifierDelta delta, bool showAbsDelta = false)
			{
			}

			// Token: 0x0600DCC1 RID: 56513 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DCC1")]
			[Address(RVA = "0x361E6F0", Offset = "0x361D2F0", VA = "0x18361E6F0")]
			private void _PrintCommonModifier(ref BattleVerboseRecorder.LogItem log, string token)
			{
			}

			// Token: 0x0600DCC2 RID: 56514 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DCC2")]
			[Address(RVA = "0x361EC80", Offset = "0x361D880", VA = "0x18361EC80")]
			public DebugPrinter()
			{
			}

			// Token: 0x0400EF11 RID: 61201
			[Token(Token = "0x400EF11")]
			[FieldOffset(Offset = "0x10")]
			private StringBuilder m_builder;
		}
	}
}
