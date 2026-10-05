using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x020022B3 RID: 8883
	[Token(Token = "0x20022B3")]
	[Obsolete]
	public class Act27SideBattleManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x0600DF4E RID: 57166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF4E")]
		[Address(RVA = "0x3644520", Offset = "0x3643120", VA = "0x183644520", Slot = "9")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x17001C04 RID: 7172
		// (get) Token: 0x0600DF4F RID: 57167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C04")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600DF4F")]
			[Address(RVA = "0x3646670", Offset = "0x3645270", VA = "0x183646670", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600DF50 RID: 57168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF50")]
		[Address(RVA = "0x3644630", Offset = "0x3643230", VA = "0x183644630", Slot = "7")]
		public override void Init(GlobalEnvSystem system)
		{
		}

		// Token: 0x0600DF51 RID: 57169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF51")]
		[Address(RVA = "0x3646000", Offset = "0x3644C00", VA = "0x183646000")]
		private void _InitTileData()
		{
		}

		// Token: 0x0600DF52 RID: 57170 RVA: 0x000511E0 File Offset: 0x0004F3E0
		[Token(Token = "0x600DF52")]
		[Address(RVA = "0x3646240", Offset = "0x3644E40", VA = "0x183646240")]
		private bool _IsEntityValid(Entity entity)
		{
			return default(bool);
		}

		// Token: 0x0600DF53 RID: 57171 RVA: 0x000511F8 File Offset: 0x0004F3F8
		[Token(Token = "0x600DF53")]
		[Address(RVA = "0x3646340", Offset = "0x3644F40", VA = "0x183646340")]
		private bool _IsSwitchable(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600DF54 RID: 57172 RVA: 0x00051210 File Offset: 0x0004F410
		[Token(Token = "0x600DF54")]
		[Address(RVA = "0x3645DE0", Offset = "0x36449E0", VA = "0x183645DE0")]
		private bool _CheckTileInBlackList(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600DF55 RID: 57173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF55")]
		[Address(RVA = "0x3645EF0", Offset = "0x3644AF0", VA = "0x183645EF0")]
		private void _DoRemoveEntities()
		{
		}

		// Token: 0x0600DF56 RID: 57174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF56")]
		[Address(RVA = "0x3644890", Offset = "0x3643490", VA = "0x183644890", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600DF57 RID: 57175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF57")]
		[Address(RVA = "0x3644A40", Offset = "0x3643640", VA = "0x183644A40", Slot = "15")]
		public override void OnTrigger(object param)
		{
		}

		// Token: 0x0600DF58 RID: 57176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF58")]
		[Address(RVA = "0x3644710", Offset = "0x3643310", VA = "0x183644710")]
		public void OnGameStart(object args)
		{
		}

		// Token: 0x0600DF59 RID: 57177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF59")]
		[Address(RVA = "0x3644C20", Offset = "0x3643820", VA = "0x183644C20")]
		public void OnUnitBorn(object args)
		{
		}

		// Token: 0x0600DF5A RID: 57178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF5A")]
		[Address(RVA = "0x3645000", Offset = "0x3643C00", VA = "0x183645000")]
		public void OnUnitFinish(object args)
		{
		}

		// Token: 0x0600DF5B RID: 57179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF5B")]
		[Address(RVA = "0x3645260", Offset = "0x3643E60", VA = "0x183645260")]
		public void OnUnitSwitchSide(object args)
		{
		}

		// Token: 0x0600DF5C RID: 57180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF5C")]
		[Address(RVA = "0x3645530", Offset = "0x3644130", VA = "0x183645530")]
		public void RefreshEntityBuffs(Entity entity, Act27SideBattleManager.MechanismSideType mechanismSideType, bool onToggle = false)
		{
		}

		// Token: 0x0600DF5D RID: 57181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF5D")]
		[Address(RVA = "0x3645C10", Offset = "0x3644810", VA = "0x183645C10")]
		public void ToggleTileSideType(Tile tile, Act27SideBattleManager.MechanismSideType mechanismSideType)
		{
		}

		// Token: 0x0600DF5E RID: 57182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF5E")]
		[Address(RVA = "0x3643F50", Offset = "0x3642B50", VA = "0x183643F50")]
		public void DoToggleTileSideType(Tile tile, Act27SideBattleManager.MechanismSideType mechanismSideType)
		{
		}

		// Token: 0x0600DF5F RID: 57183 RVA: 0x00051228 File Offset: 0x0004F428
		[Token(Token = "0x600DF5F")]
		[Address(RVA = "0x3643E40", Offset = "0x3642A40", VA = "0x183643E40")]
		public bool CheckEntityRootTileSideType(Entity entity, Act27SideBattleManager.MechanismSideType sideType)
		{
			return default(bool);
		}

		// Token: 0x0600DF60 RID: 57184 RVA: 0x00051240 File Offset: 0x0004F440
		[Token(Token = "0x600DF60")]
		[Address(RVA = "0x3645D30", Offset = "0x3644930", VA = "0x183645D30")]
		public bool TryGetTileSideType(Tile tile, out Act27SideBattleManager.MechanismSideType sideType)
		{
			return default(bool);
		}

		// Token: 0x0600DF61 RID: 57185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF61")]
		[Address(RVA = "0x3643A60", Offset = "0x3642660", VA = "0x183643A60")]
		public void AddTileBlackList(Tile tile)
		{
		}

		// Token: 0x0600DF62 RID: 57186 RVA: 0x00051258 File Offset: 0x0004F458
		[Token(Token = "0x600DF62")]
		[Address(RVA = "0x3643B50", Offset = "0x3642750", VA = "0x183643B50")]
		public int CalculateScore(int basic, int add, Color color)
		{
			return 0;
		}

		// Token: 0x0600DF63 RID: 57187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF63")]
		[Address(RVA = "0x36464B0", Offset = "0x36450B0", VA = "0x1836464B0")]
		public Act27SideBattleManager()
		{
		}

		// Token: 0x0400F28A RID: 62090
		[Token(Token = "0x400F28A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act27SideBattleManager.Act27SideMechanismConfig[] _configs;

		// Token: 0x0400F28B RID: 62091
		[Token(Token = "0x400F28B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int tickPeriodic;

		// Token: 0x0400F28C RID: 62092
		[Token(Token = "0x400F28C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string[] _tileBlackList;

		// Token: 0x0400F28D RID: 62093
		[Token(Token = "0x400F28D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _tileEffectKey;

		// Token: 0x0400F28E RID: 62094
		[Token(Token = "0x400F28E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _tileEffectNightKey;

		// Token: 0x0400F28F RID: 62095
		[Token(Token = "0x400F28F")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<Tile, Act27SideBattleManager.Act27SideTileData> m_tileStatesMap;

		// Token: 0x0400F290 RID: 62096
		[Token(Token = "0x400F290")]
		[FieldOffset(Offset = "0x58")]
		private List<Act27SideBattleManager.Act27SideTileData> m_tileStatesList;

		// Token: 0x0400F291 RID: 62097
		[Token(Token = "0x400F291")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<ObjectPtr<Entity>, Act27SideBattleManager.Act27SideEntityData> m_entities;

		// Token: 0x0400F292 RID: 62098
		[Token(Token = "0x400F292")]
		[FieldOffset(Offset = "0x68")]
		private List<ObjectPtr<Entity>> m_removedEntities;

		// Token: 0x0400F293 RID: 62099
		[Token(Token = "0x400F293")]
		[FieldOffset(Offset = "0x70")]
		private Deck.Card m_stmbotCard;

		// Token: 0x0400F294 RID: 62100
		[Token(Token = "0x400F294")]
		[FieldOffset(Offset = "0x78")]
		private HashSet<GridPosition> m_additionalTileBlackList;

		// Token: 0x0400F295 RID: 62101
		[Token(Token = "0x400F295")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isNightMap;

		// Token: 0x0400F296 RID: 62102
		[Token(Token = "0x400F296")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string EVENT_SYSTEM_KEY;

		// Token: 0x0400F297 RID: 62103
		[Token(Token = "0x400F297")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string STMBOT_KEY;

		// Token: 0x0400F298 RID: 62104
		[Token(Token = "0x400F298")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string NIGHT_MAP_KEY;

		// Token: 0x020022B4 RID: 8884
		[Token(Token = "0x20022B4")]
		[Serializable]
		public struct Act27SideMechanismConfig
		{
			// Token: 0x0400F299 RID: 62105
			[Token(Token = "0x400F299")]
			[FieldOffset(Offset = "0x0")]
			public string effectOnSwitchBegin;

			// Token: 0x0400F29A RID: 62106
			[Token(Token = "0x400F29A")]
			[FieldOffset(Offset = "0x8")]
			public BuffData[] buffToAllyOnToggle;

			// Token: 0x0400F29B RID: 62107
			[Token(Token = "0x400F29B")]
			[FieldOffset(Offset = "0x10")]
			public BuffData[] buffToEnemyOnToggle;

			// Token: 0x0400F29C RID: 62108
			[Token(Token = "0x400F29C")]
			[FieldOffset(Offset = "0x18")]
			public BuffData[] buffsToAlly;

			// Token: 0x0400F29D RID: 62109
			[Token(Token = "0x400F29D")]
			[FieldOffset(Offset = "0x20")]
			public BuffData[] buffsToEnemy;

			// Token: 0x0400F29E RID: 62110
			[Token(Token = "0x400F29E")]
			[FieldOffset(Offset = "0x28")]
			public BuffData[] buffsToEnemyGameCity;

			// Token: 0x0400F29F RID: 62111
			[Token(Token = "0x400F29F")]
			[FieldOffset(Offset = "0x30")]
			public BuffData[] buffsToAllyGameCity;
		}

		// Token: 0x020022B5 RID: 8885
		[Token(Token = "0x20022B5")]
		public class Act27SideTileData
		{
			// Token: 0x0600DF65 RID: 57189 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF65")]
			[Address(RVA = "0x3646BF0", Offset = "0x36457F0", VA = "0x183646BF0")]
			public Act27SideTileData(int tickPeriodic, int maxDuration, Tile tile)
			{
			}

			// Token: 0x0600DF66 RID: 57190 RVA: 0x00051270 File Offset: 0x0004F470
			[Token(Token = "0x600DF66")]
			[Address(RVA = "0x3646BA0", Offset = "0x36457A0", VA = "0x183646BA0")]
			public bool OnTick()
			{
				return default(bool);
			}

			// Token: 0x0400F2A0 RID: 62112
			[Token(Token = "0x400F2A0")]
			[FieldOffset(Offset = "0x10")]
			public PeriodicTicker refreshTicker;

			// Token: 0x0400F2A1 RID: 62113
			[Token(Token = "0x400F2A1")]
			[FieldOffset(Offset = "0x18")]
			public PeriodicTicker durationTicker;

			// Token: 0x0400F2A2 RID: 62114
			[Token(Token = "0x400F2A2")]
			[FieldOffset(Offset = "0x20")]
			public Act27SideBattleManager.MechanismSideType tileSideType;

			// Token: 0x0400F2A3 RID: 62115
			[Token(Token = "0x400F2A3")]
			[FieldOffset(Offset = "0x24")]
			public Act27SideBattleManager.MechanismSideType cachedType;

			// Token: 0x0400F2A4 RID: 62116
			[Token(Token = "0x400F2A4")]
			[FieldOffset(Offset = "0x28")]
			public Tile tile;

			// Token: 0x0400F2A5 RID: 62117
			[Token(Token = "0x400F2A5")]
			[FieldOffset(Offset = "0x30")]
			public Effect tileEffect;
		}

		// Token: 0x020022B6 RID: 8886
		[Token(Token = "0x20022B6")]
		public class Act27SideEntityData
		{
			// Token: 0x0600DF67 RID: 57191 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF67")]
			[Address(RVA = "0x3646B10", Offset = "0x3645710", VA = "0x183646B10")]
			public Act27SideEntityData()
			{
			}

			// Token: 0x0400F2A6 RID: 62118
			[Token(Token = "0x400F2A6")]
			[FieldOffset(Offset = "0x10")]
			public Act27SideBattleManager.MechanismSideType mechanismSideType;

			// Token: 0x0400F2A7 RID: 62119
			[Token(Token = "0x400F2A7")]
			[FieldOffset(Offset = "0x18")]
			public List<uint> buffUids;

			// Token: 0x0400F2A8 RID: 62120
			[Token(Token = "0x400F2A8")]
			[FieldOffset(Offset = "0x20")]
			public bool isRemoved;
		}

		// Token: 0x020022B7 RID: 8887
		[Token(Token = "0x20022B7")]
		public enum MechanismSideType
		{
			// Token: 0x0400F2AA RID: 62122
			[Token(Token = "0x400F2AA")]
			ALLY,
			// Token: 0x0400F2AB RID: 62123
			[Token(Token = "0x400F2AB")]
			ENEMY,
			// Token: 0x0400F2AC RID: 62124
			[Token(Token = "0x400F2AC")]
			NONE
		}
	}
}
