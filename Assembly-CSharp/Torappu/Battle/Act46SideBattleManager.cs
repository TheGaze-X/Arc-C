using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020022D5 RID: 8917
	[Token(Token = "0x20022D5")]
	public class Act46SideBattleManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x17001C36 RID: 7222
		// (get) Token: 0x0600E0C6 RID: 57542 RVA: 0x000518D0 File Offset: 0x0004FAD0
		[Token(Token = "0x17001C36")]
		private Vector3 worldZero
		{
			[Token(Token = "0x600E0C6")]
			[Address(RVA = "0x3684050", Offset = "0x3682C50", VA = "0x183684050")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17001C37 RID: 7223
		// (get) Token: 0x0600E0C7 RID: 57543 RVA: 0x000518E8 File Offset: 0x0004FAE8
		[Token(Token = "0x17001C37")]
		public int checkPointsCount
		{
			[Token(Token = "0x600E0C7")]
			[Address(RVA = "0x3683AD0", Offset = "0x36826D0", VA = "0x183683AD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001C38 RID: 7224
		// (get) Token: 0x0600E0C8 RID: 57544 RVA: 0x00051900 File Offset: 0x0004FB00
		// (set) Token: 0x0600E0C9 RID: 57545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001C38")]
		public bool isEffectEnabled
		{
			[Token(Token = "0x600E0C8")]
			[Address(RVA = "0x3683F90", Offset = "0x3682B90", VA = "0x183683F90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E0C9")]
			[Address(RVA = "0x3684210", Offset = "0x3682E10", VA = "0x183684210")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001C39 RID: 7225
		// (get) Token: 0x0600E0CA RID: 57546 RVA: 0x00051918 File Offset: 0x0004FB18
		// (set) Token: 0x0600E0CB RID: 57547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001C39")]
		public bool mapInitialized
		{
			[Token(Token = "0x600E0CA")]
			[Address(RVA = "0x3683FF0", Offset = "0x3682BF0", VA = "0x183683FF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600E0CB")]
			[Address(RVA = "0x3684280", Offset = "0x3682E80", VA = "0x183684280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001C3A RID: 7226
		// (get) Token: 0x0600E0CC RID: 57548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C3A")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E0CC")]
			[Address(RVA = "0x3683B50", Offset = "0x3682750", VA = "0x183683B50", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E0CD RID: 57549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0CD")]
		[Address(RVA = "0x367B830", Offset = "0x367A430", VA = "0x18367B830", Slot = "9")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600E0CE RID: 57550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0CE")]
		[Address(RVA = "0x367BB60", Offset = "0x367A760", VA = "0x18367BB60", Slot = "7")]
		public override void Init(GlobalEnvSystem envSystem)
		{
		}

		// Token: 0x0600E0CF RID: 57551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0CF")]
		[Address(RVA = "0x367CA00", Offset = "0x367B600", VA = "0x18367CA00", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E0D0 RID: 57552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0D0")]
		[Address(RVA = "0x3681740", Offset = "0x3680340", VA = "0x183681740")]
		private void _OnGameStart(object arg)
		{
		}

		// Token: 0x0600E0D1 RID: 57553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0D1")]
		[Address(RVA = "0x36821D0", Offset = "0x3680DD0", VA = "0x1836821D0")]
		private void _OnWaveWillStart(object arg)
		{
		}

		// Token: 0x0600E0D2 RID: 57554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0D2")]
		[Address(RVA = "0x3681380", Offset = "0x367FF80", VA = "0x183681380")]
		private void _OnGameOver(object obj)
		{
		}

		// Token: 0x0600E0D3 RID: 57555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0D3")]
		[Address(RVA = "0x36817C0", Offset = "0x36803C0", VA = "0x1836817C0")]
		private void _OnUnitBorn(object obj)
		{
		}

		// Token: 0x0600E0D4 RID: 57556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0D4")]
		[Address(RVA = "0x3680710", Offset = "0x367F310", VA = "0x183680710")]
		private void _OnAvalancheTrapBorn(Character character)
		{
		}

		// Token: 0x0600E0D5 RID: 57557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0D5")]
		[Address(RVA = "0x36810F0", Offset = "0x367FCF0", VA = "0x1836810F0")]
		private void _OnEnemyBorn(Enemy enemy)
		{
		}

		// Token: 0x0600E0D6 RID: 57558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0D6")]
		[Address(RVA = "0x3680CE0", Offset = "0x367F8E0", VA = "0x183680CE0")]
		private void _OnCharacterBorn(Character character)
		{
		}

		// Token: 0x0600E0D7 RID: 57559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0D7")]
		[Address(RVA = "0x3681DE0", Offset = "0x36809E0", VA = "0x183681DE0")]
		private void _OnUnitFinish(object obj)
		{
		}

		// Token: 0x0600E0D8 RID: 57560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0D8")]
		[Address(RVA = "0x3680FA0", Offset = "0x367FBA0", VA = "0x183680FA0")]
		private void _OnCharacterFinish(Character character)
		{
		}

		// Token: 0x0600E0D9 RID: 57561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0D9")]
		[Address(RVA = "0x3681230", Offset = "0x367FE30", VA = "0x183681230")]
		private void _OnEnemyFinish(Enemy enemy)
		{
		}

		// Token: 0x0600E0DA RID: 57562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0DA")]
		[Address(RVA = "0x3680490", Offset = "0x367F090", VA = "0x183680490")]
		private void _OnAvalancheEnemy(Enemy enemy, int index)
		{
		}

		// Token: 0x0600E0DB RID: 57563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0DB")]
		[Address(RVA = "0x3680140", Offset = "0x367ED40", VA = "0x183680140")]
		private void _OnAvalancheCharacter(Character character)
		{
		}

		// Token: 0x0600E0DC RID: 57564 RVA: 0x00051930 File Offset: 0x0004FB30
		[Token(Token = "0x600E0DC")]
		[Address(RVA = "0x367BD20", Offset = "0x367A920", VA = "0x18367BD20")]
		public bool IsAvalancheArea(GridPosition gridPosition)
		{
			return default(bool);
		}

		// Token: 0x0600E0DD RID: 57565 RVA: 0x00051948 File Offset: 0x0004FB48
		[Token(Token = "0x600E0DD")]
		[Address(RVA = "0x367BA60", Offset = "0x367A660", VA = "0x18367BA60")]
		public int GetAvalancheAreaIndex(GridPosition gridPosition)
		{
			return 0;
		}

		// Token: 0x0600E0DE RID: 57566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0DE")]
		[Address(RVA = "0x367C540", Offset = "0x367B140", VA = "0x18367C540")]
		public void OnEnemyInteractWithAvalancheArea(Enemy enemy, bool isEnter, int index)
		{
		}

		// Token: 0x0600E0DF RID: 57567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0DF")]
		[Address(RVA = "0x367CDD0", Offset = "0x367B9D0", VA = "0x18367CDD0")]
		public void TriggerAvalanche(GridPosition gridPosition)
		{
		}

		// Token: 0x0600E0E0 RID: 57568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0E0")]
		[Address(RVA = "0x367BE00", Offset = "0x367AA00", VA = "0x18367BE00")]
		public void OnAreaExpand(GridPosition gridPosition)
		{
		}

		// Token: 0x0600E0E1 RID: 57569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0E1")]
		[Address(RVA = "0x367C080", Offset = "0x367AC80", VA = "0x18367C080")]
		public void OnAreaReset(GridPosition gridPosition)
		{
		}

		// Token: 0x0600E0E2 RID: 57570 RVA: 0x00051960 File Offset: 0x0004FB60
		[Token(Token = "0x600E0E2")]
		[Address(RVA = "0x367ADC0", Offset = "0x36799C0", VA = "0x18367ADC0")]
		public bool AvalancheForCharacterFromOutside(Character character, int direction)
		{
			return default(bool);
		}

		// Token: 0x0600E0E3 RID: 57571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0E3")]
		[Address(RVA = "0x367C300", Offset = "0x367AF00", VA = "0x18367C300")]
		public void OnBlockChanged(Entity entity, bool isActivate)
		{
		}

		// Token: 0x0600E0E4 RID: 57572 RVA: 0x00051978 File Offset: 0x0004FB78
		[Token(Token = "0x600E0E4")]
		[Address(RVA = "0x367D5E0", Offset = "0x367C1E0", VA = "0x18367D5E0")]
		public bool TryGetRebuiltNpcRoute(out Route route)
		{
			return default(bool);
		}

		// Token: 0x0600E0E5 RID: 57573 RVA: 0x00051990 File Offset: 0x0004FB90
		[Token(Token = "0x600E0E5")]
		[Address(RVA = "0x367AAA0", Offset = "0x36796A0", VA = "0x18367AAA0")]
		public bool AddAreaSp(GridPosition gridPosition, int sp)
		{
			return default(bool);
		}

		// Token: 0x0600E0E6 RID: 57574 RVA: 0x000519A8 File Offset: 0x0004FBA8
		[Token(Token = "0x600E0E6")]
		[Address(RVA = "0x367AFE0", Offset = "0x3679BE0", VA = "0x18367AFE0")]
		public bool BanAreaSkill(GridPosition gridPosition, bool isBan)
		{
			return default(bool);
		}

		// Token: 0x0600E0E7 RID: 57575 RVA: 0x000519C0 File Offset: 0x0004FBC0
		[Token(Token = "0x600E0E7")]
		[Address(RVA = "0x367B360", Offset = "0x3679F60", VA = "0x18367B360")]
		public bool CreateAreaGridFx(GridPosition gridPosition, bool active)
		{
			return default(bool);
		}

		// Token: 0x0600E0E8 RID: 57576 RVA: 0x000519D8 File Offset: 0x0004FBD8
		[Token(Token = "0x600E0E8")]
		[Address(RVA = "0x367CCC0", Offset = "0x367B8C0", VA = "0x18367CCC0")]
		public bool SwitchAreaAnimatorState(GridPosition gridPosition, bool state)
		{
			return default(bool);
		}

		// Token: 0x0600E0E9 RID: 57577 RVA: 0x000519F0 File Offset: 0x0004FBF0
		[Token(Token = "0x600E0E9")]
		[Address(RVA = "0x367B910", Offset = "0x367A510", VA = "0x18367B910")]
		public int GetAreaDirectionByGridPosition(GridPosition gridPosition)
		{
			return 0;
		}

		// Token: 0x0600E0EA RID: 57578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0EA")]
		[Address(RVA = "0x367CB90", Offset = "0x367B790", VA = "0x18367CB90")]
		public void RegisterMapEffect(Effect effect)
		{
		}

		// Token: 0x0600E0EB RID: 57579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0EB")]
		[Address(RVA = "0x367B170", Offset = "0x3679D70", VA = "0x18367B170")]
		public void ClearMapEffects()
		{
		}

		// Token: 0x0600E0EC RID: 57580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0EC")]
		[Address(RVA = "0x367FBD0", Offset = "0x367E7D0", VA = "0x18367FBD0")]
		private void _InitMapIfNot()
		{
		}

		// Token: 0x0600E0ED RID: 57581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0ED")]
		[Address(RVA = "0x367D840", Offset = "0x367C440", VA = "0x18367D840")]
		private void _AssignGridToAvalancheArea()
		{
		}

		// Token: 0x0600E0EE RID: 57582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0EE")]
		[Address(RVA = "0x3682E80", Offset = "0x3681A80", VA = "0x183682E80")]
		private void _UpdateAreaLine()
		{
		}

		// Token: 0x0600E0EF RID: 57583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0EF")]
		[Address(RVA = "0x3682BA0", Offset = "0x36817A0", VA = "0x183682BA0")]
		private void _SearchAddition(int index, Act46SideBattleManager.AvalancheArea area, HashSet<GridPosition> targetSet, HashSet<GridPosition> additionalGrids)
		{
		}

		// Token: 0x0600E0F0 RID: 57584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0F0")]
		[Address(RVA = "0x367E040", Offset = "0x367CC40", VA = "0x18367E040")]
		private static void _DealAreaExpandEntity(HashSet<GridPosition> additionalGrids, Act46SideBattleManager.AvalancheArea area)
		{
		}

		// Token: 0x0600E0F1 RID: 57585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0F1")]
		[Address(RVA = "0x367E450", Offset = "0x367D050", VA = "0x18367E450")]
		private static void _DealAreaResetEntity(Act46SideBattleManager.AvalancheArea area)
		{
		}

		// Token: 0x0600E0F2 RID: 57586 RVA: 0x00051A08 File Offset: 0x0004FC08
		[Token(Token = "0x600E0F2")]
		[Address(RVA = "0x367DA60", Offset = "0x367C660", VA = "0x18367DA60")]
		private bool _CheckBuildable(Character character, int direction, bool recursive = true)
		{
			return default(bool);
		}

		// Token: 0x0600E0F3 RID: 57587 RVA: 0x00051A20 File Offset: 0x0004FC20
		[Token(Token = "0x600E0F3")]
		[Address(RVA = "0x367FF70", Offset = "0x367EB70", VA = "0x18367FF70")]
		private bool _IsAvalancheArea(GridPosition gridPosition)
		{
			return default(bool);
		}

		// Token: 0x0600E0F4 RID: 57588 RVA: 0x00051A38 File Offset: 0x0004FC38
		[Token(Token = "0x600E0F4")]
		[Address(RVA = "0x367DE90", Offset = "0x367CA90", VA = "0x18367DE90")]
		private bool _CheckGridValid(int row, int col)
		{
			return default(bool);
		}

		// Token: 0x0600E0F5 RID: 57589 RVA: 0x00051A50 File Offset: 0x0004FC50
		[Token(Token = "0x600E0F5")]
		[Address(RVA = "0x367DF40", Offset = "0x367CB40", VA = "0x18367DF40")]
		private bool _CheckGridValid(GridPosition gridPosition)
		{
			return default(bool);
		}

		// Token: 0x0600E0F6 RID: 57590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0F6")]
		[Address(RVA = "0x367F100", Offset = "0x367DD00", VA = "0x18367F100")]
		private void _DealRebuildList()
		{
		}

		// Token: 0x0600E0F7 RID: 57591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0F7")]
		[Address(RVA = "0x3683180", Offset = "0x3681D80", VA = "0x183683180")]
		private void _UpdateProtectedGrids(GridPosition sourceGrid)
		{
		}

		// Token: 0x0600E0F8 RID: 57592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0F8")]
		[Address(RVA = "0x367E930", Offset = "0x367D530", VA = "0x18367E930")]
		private void _DealAvalancheStartFx(Act46SideBattleManager.AvalancheArea area)
		{
		}

		// Token: 0x0600E0F9 RID: 57593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0F9")]
		[Address(RVA = "0x36822C0", Offset = "0x3680EC0", VA = "0x1836822C0")]
		private void _PlayAvalancheFx(GridPosition start, int length, int dir)
		{
		}

		// Token: 0x0600E0FA RID: 57594 RVA: 0x00051A68 File Offset: 0x0004FC68
		[Token(Token = "0x600E0FA")]
		[Address(RVA = "0x367F990", Offset = "0x367E590", VA = "0x18367F990")]
		private Vector3 _GetWorldPosition(int row, int col)
		{
			return default(Vector3);
		}

		// Token: 0x0600E0FB RID: 57595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0FB")]
		[Address(RVA = "0x3682630", Offset = "0x3681230", VA = "0x183682630")]
		private void _PrintDirectionMap()
		{
		}

		// Token: 0x0600E0FC RID: 57596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0FC")]
		[Address(RVA = "0x36828A0", Offset = "0x36814A0", VA = "0x1836828A0")]
		private void _PrintIndexMap()
		{
		}

		// Token: 0x0600E0FD RID: 57597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0FD")]
		[Address(RVA = "0x3682A20", Offset = "0x3681620", VA = "0x183682A20")]
		private void _PrintStateMap()
		{
		}

		// Token: 0x0600E0FE RID: 57598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0FE")]
		[Address(RVA = "0x36835C0", Offset = "0x36821C0", VA = "0x1836835C0")]
		public Act46SideBattleManager()
		{
		}

		// Token: 0x0600E0FF RID: 57599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E0FF")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0600E100 RID: 57600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E100")]
		[Address(RVA = "0x550BD0", Offset = "0x54F7D0", VA = "0x180550BD0")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x0600E101 RID: 57601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E101")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E102 RID: 57602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E102")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0400F52D RID: 62765
		[Token(Token = "0x400F52D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<string> _avalancheTrapKeys;

		// Token: 0x0400F52E RID: 62766
		[Token(Token = "0x400F52E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _enemyBornStatus;

		// Token: 0x0400F52F RID: 62767
		[Token(Token = "0x400F52F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _characterBornStatus;

		// Token: 0x0400F530 RID: 62768
		[Token(Token = "0x400F530")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _enemyAvalancheStatus;

		// Token: 0x0400F531 RID: 62769
		[Token(Token = "0x400F531")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _characterAvalancheFailStatus;

		// Token: 0x0400F532 RID: 62770
		[Token(Token = "0x400F532")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _characterAvalancheSuccessStatus;

		// Token: 0x0400F533 RID: 62771
		[Token(Token = "0x400F533")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string _trapBannedStatus;

		// Token: 0x0400F534 RID: 62772
		[Token(Token = "0x400F534")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _trapUnbannedStatus;

		// Token: 0x0400F535 RID: 62773
		[Token(Token = "0x400F535")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string _blockerAvalancheStartStatus;

		// Token: 0x0400F536 RID: 62774
		[Token(Token = "0x400F536")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string _waveWillStartStatus;

		// Token: 0x0400F537 RID: 62775
		[Token(Token = "0x400F537")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private string _tileOnStatus;

		// Token: 0x0400F538 RID: 62776
		[Token(Token = "0x400F538")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private string _tileOffStatus;

		// Token: 0x0400F539 RID: 62777
		[Token(Token = "0x400F539")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private string _edgeLineRendererEffectKey;

		// Token: 0x0400F53A RID: 62778
		[Token(Token = "0x400F53A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string _disableBlackboardKey;

		// Token: 0x0400F53B RID: 62779
		[Token(Token = "0x400F53B")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _heightOffset;

		// Token: 0x0400F53C RID: 62780
		[Token(Token = "0x400F53C")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private Vector3 _lineOffsetToMapCenter;

		// Token: 0x0400F53D RID: 62781
		[Token(Token = "0x400F53D")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private int _forceLevel;

		// Token: 0x0400F53E RID: 62782
		[Token(Token = "0x400F53E")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private string _npcId;

		// Token: 0x0400F53F RID: 62783
		[Token(Token = "0x400F53F")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private string _npcBornStatus;

		// Token: 0x0400F540 RID: 62784
		[Token(Token = "0x400F540")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private string _charSpKey;

		// Token: 0x0400F541 RID: 62785
		[Token(Token = "0x400F541")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private List<string> _avalancheFxKeys;

		// Token: 0x0400F542 RID: 62786
		[Token(Token = "0x400F542")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private string _addSpEffectKey;

		// Token: 0x0400F543 RID: 62787
		[Token(Token = "0x400F543")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private List<string> _artificialHighLandTrapIds;

		// Token: 0x0400F544 RID: 62788
		[Token(Token = "0x400F544")]
		[FieldOffset(Offset = "0xE0")]
		private int m_mapWidth;

		// Token: 0x0400F545 RID: 62789
		[Token(Token = "0x400F545")]
		[FieldOffset(Offset = "0xE4")]
		private int m_mapHeight;

		// Token: 0x0400F546 RID: 62790
		[Token(Token = "0x400F546")]
		[FieldOffset(Offset = "0xE8")]
		private ObjectPtr<Enemy> m_npc;

		// Token: 0x0400F547 RID: 62791
		[Token(Token = "0x400F547")]
		[FieldOffset(Offset = "0xF8")]
		private readonly Dictionary<int, GridPosition> m_checkPoints;

		// Token: 0x0400F548 RID: 62792
		[Token(Token = "0x400F548")]
		[FieldOffset(Offset = "0x100")]
		private int m_checkPointIndex;

		// Token: 0x0400F549 RID: 62793
		[Token(Token = "0x400F549")]
		[FieldOffset(Offset = "0x104")]
		private int m_charSp;

		// Token: 0x0400F54A RID: 62794
		[Token(Token = "0x400F54A")]
		[FieldOffset(Offset = "0x108")]
		private bool m_isGameStarted;

		// Token: 0x0400F54B RID: 62795
		[Token(Token = "0x400F54B")]
		[FieldOffset(Offset = "0x109")]
		private bool m_worldZeroValid;

		// Token: 0x0400F54C RID: 62796
		[Token(Token = "0x400F54C")]
		[FieldOffset(Offset = "0x10A")]
		private bool m_isNpcFirstRouteDone;

		// Token: 0x0400F54D RID: 62797
		[Token(Token = "0x400F54D")]
		[FieldOffset(Offset = "0x10C")]
		private Vector3 m_worldZero;

		// Token: 0x0400F54E RID: 62798
		[Token(Token = "0x400F54E")]
		[FieldOffset(Offset = "0x118")]
		private readonly Dictionary<ValueTuple<int, int>, Vector3> m_gridToWorldPos;

		// Token: 0x0400F54F RID: 62799
		[Token(Token = "0x400F54F")]
		[FieldOffset(Offset = "0x120")]
		private Act46SideBattleManager.AvalancheGrid[,] m_avalancheAreaMap;

		// Token: 0x0400F550 RID: 62800
		[Token(Token = "0x400F550")]
		[FieldOffset(Offset = "0x128")]
		private readonly Dictionary<int, Act46SideBattleManager.AvalancheArea> m_avalanches;

		// Token: 0x0400F551 RID: 62801
		[Token(Token = "0x400F551")]
		[FieldOffset(Offset = "0x130")]
		private readonly Dictionary<ObjectPtr<Character>, Act46SideBattleManager.CharacterRebuildState> m_waitToRebuild;

		// Token: 0x0400F552 RID: 62802
		[Token(Token = "0x400F552")]
		[FieldOffset(Offset = "0x138")]
		private readonly List<ObjectPtr<Character>> m_checkedList;

		// Token: 0x0400F553 RID: 62803
		[Token(Token = "0x400F553")]
		[FieldOffset(Offset = "0x140")]
		private readonly List<ObjectPtr<Effect>> m_mapEffects;

		// Token: 0x0400F554 RID: 62804
		[Token(Token = "0x400F554")]
		public const string ENV_SYSTEM_KEY = "env_037_act46side";

		// Token: 0x0400F555 RID: 62805
		[Token(Token = "0x400F555")]
		private const string AVALANCHE_INDEX_KEY = "avalanche_index";

		// Token: 0x0400F556 RID: 62806
		[Token(Token = "0x400F556")]
		private const string AVALANCHE_STATE_KEY = "avalanche_state";

		// Token: 0x0400F557 RID: 62807
		[Token(Token = "0x400F557")]
		private const int SAFE_AREA_FLAG = -1;

		// Token: 0x0400F558 RID: 62808
		[Token(Token = "0x400F558")]
		private const string CHECK_POINT_INDEX_KEY = "check_point_index";

		// Token: 0x0400F55B RID: 62811
		[Token(Token = "0x400F55B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_worldZero;

		// Token: 0x0400F55C RID: 62812
		[Token(Token = "0x400F55C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_checkPointsCount;

		// Token: 0x0400F55D RID: 62813
		[Token(Token = "0x400F55D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isEffectEnabled;

		// Token: 0x0400F55E RID: 62814
		[Token(Token = "0x400F55E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isEffectEnabled;

		// Token: 0x0400F55F RID: 62815
		[Token(Token = "0x400F55F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_mapInitialized;

		// Token: 0x0400F560 RID: 62816
		[Token(Token = "0x400F560")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_mapInitialized;

		// Token: 0x0400F561 RID: 62817
		[Token(Token = "0x400F561")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400F562 RID: 62818
		[Token(Token = "0x400F562")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400F563 RID: 62819
		[Token(Token = "0x400F563")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F564 RID: 62820
		[Token(Token = "0x400F564")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F565 RID: 62821
		[Token(Token = "0x400F565")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnGameStart;

		// Token: 0x0400F566 RID: 62822
		[Token(Token = "0x400F566")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnWaveWillStart;

		// Token: 0x0400F567 RID: 62823
		[Token(Token = "0x400F567")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnGameOver;

		// Token: 0x0400F568 RID: 62824
		[Token(Token = "0x400F568")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0400F569 RID: 62825
		[Token(Token = "0x400F569")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnAvalancheTrapBorn;

		// Token: 0x0400F56A RID: 62826
		[Token(Token = "0x400F56A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnEnemyBorn;

		// Token: 0x0400F56B RID: 62827
		[Token(Token = "0x400F56B")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnCharacterBorn;

		// Token: 0x0400F56C RID: 62828
		[Token(Token = "0x400F56C")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnUnitFinish;

		// Token: 0x0400F56D RID: 62829
		[Token(Token = "0x400F56D")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnCharacterFinish;

		// Token: 0x0400F56E RID: 62830
		[Token(Token = "0x400F56E")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnEnemyFinish;

		// Token: 0x0400F56F RID: 62831
		[Token(Token = "0x400F56F")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnAvalancheEnemy;

		// Token: 0x0400F570 RID: 62832
		[Token(Token = "0x400F570")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnAvalancheCharacter;

		// Token: 0x0400F571 RID: 62833
		[Token(Token = "0x400F571")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_IsAvalancheArea;

		// Token: 0x0400F572 RID: 62834
		[Token(Token = "0x400F572")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_GetAvalancheAreaIndex;

		// Token: 0x0400F573 RID: 62835
		[Token(Token = "0x400F573")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnEnemyInteractWithAvalancheArea;

		// Token: 0x0400F574 RID: 62836
		[Token(Token = "0x400F574")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_TriggerAvalanche;

		// Token: 0x0400F575 RID: 62837
		[Token(Token = "0x400F575")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnAreaExpand;

		// Token: 0x0400F576 RID: 62838
		[Token(Token = "0x400F576")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_OnAreaReset;

		// Token: 0x0400F577 RID: 62839
		[Token(Token = "0x400F577")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_AvalancheForCharacterFromOutside;

		// Token: 0x0400F578 RID: 62840
		[Token(Token = "0x400F578")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnBlockChanged;

		// Token: 0x0400F579 RID: 62841
		[Token(Token = "0x400F579")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_TryGetRebuiltNpcRoute;

		// Token: 0x0400F57A RID: 62842
		[Token(Token = "0x400F57A")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_AddAreaSp;

		// Token: 0x0400F57B RID: 62843
		[Token(Token = "0x400F57B")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_BanAreaSkill;

		// Token: 0x0400F57C RID: 62844
		[Token(Token = "0x400F57C")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_CreateAreaGridFx;

		// Token: 0x0400F57D RID: 62845
		[Token(Token = "0x400F57D")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_SwitchAreaAnimatorState;

		// Token: 0x0400F57E RID: 62846
		[Token(Token = "0x400F57E")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_GetAreaDirectionByGridPosition;

		// Token: 0x0400F57F RID: 62847
		[Token(Token = "0x400F57F")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_RegisterMapEffect;

		// Token: 0x0400F580 RID: 62848
		[Token(Token = "0x400F580")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_ClearMapEffects;

		// Token: 0x0400F581 RID: 62849
		[Token(Token = "0x400F581")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__InitMapIfNot;

		// Token: 0x0400F582 RID: 62850
		[Token(Token = "0x400F582")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__AssignGridToAvalancheArea;

		// Token: 0x0400F583 RID: 62851
		[Token(Token = "0x400F583")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__UpdateAreaLine;

		// Token: 0x0400F584 RID: 62852
		[Token(Token = "0x400F584")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__SearchAddition;

		// Token: 0x0400F585 RID: 62853
		[Token(Token = "0x400F585")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__DealAreaExpandEntity;

		// Token: 0x0400F586 RID: 62854
		[Token(Token = "0x400F586")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__DealAreaResetEntity;

		// Token: 0x0400F587 RID: 62855
		[Token(Token = "0x400F587")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__CheckBuildable;

		// Token: 0x0400F588 RID: 62856
		[Token(Token = "0x400F588")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__IsAvalancheArea;

		// Token: 0x0400F589 RID: 62857
		[Token(Token = "0x400F589")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__CheckGridValid;

		// Token: 0x0400F58A RID: 62858
		[Token(Token = "0x400F58A")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix1__CheckGridValid;

		// Token: 0x0400F58B RID: 62859
		[Token(Token = "0x400F58B")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__DealRebuildList;

		// Token: 0x0400F58C RID: 62860
		[Token(Token = "0x400F58C")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__UpdateProtectedGrids;

		// Token: 0x0400F58D RID: 62861
		[Token(Token = "0x400F58D")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__DealAvalancheStartFx;

		// Token: 0x0400F58E RID: 62862
		[Token(Token = "0x400F58E")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__PlayAvalancheFx;

		// Token: 0x0400F58F RID: 62863
		[Token(Token = "0x400F58F")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__GetWorldPosition;

		// Token: 0x0400F590 RID: 62864
		[Token(Token = "0x400F590")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0__PrintDirectionMap;

		// Token: 0x0400F591 RID: 62865
		[Token(Token = "0x400F591")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__PrintIndexMap;

		// Token: 0x0400F592 RID: 62866
		[Token(Token = "0x400F592")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0__PrintStateMap;

		// Token: 0x0400F593 RID: 62867
		[Token(Token = "0x400F593")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020022D6 RID: 8918
		[Token(Token = "0x20022D6")]
		[Serializable]
		private struct AvalancheGrid
		{
			// Token: 0x0400F594 RID: 62868
			[Token(Token = "0x400F594")]
			[FieldOffset(Offset = "0x0")]
			public int index;

			// Token: 0x0400F595 RID: 62869
			[Token(Token = "0x400F595")]
			[FieldOffset(Offset = "0x4")]
			public int state;

			// Token: 0x0400F596 RID: 62870
			[Token(Token = "0x400F596")]
			[FieldOffset(Offset = "0x8")]
			public bool isBlocked;
		}

		// Token: 0x020022D7 RID: 8919
		[Token(Token = "0x20022D7")]
		[Serializable]
		private struct CharacterRebuildState
		{
			// Token: 0x0400F597 RID: 62871
			[Token(Token = "0x400F597")]
			[FieldOffset(Offset = "0x0")]
			public GridPosition gridPosition;

			// Token: 0x0400F598 RID: 62872
			[Token(Token = "0x400F598")]
			[FieldOffset(Offset = "0x8")]
			public FP hpRatio;

			// Token: 0x0400F599 RID: 62873
			[Token(Token = "0x400F599")]
			[FieldOffset(Offset = "0x10")]
			public FP spRatio;
		}

		// Token: 0x020022D8 RID: 8920
		[Token(Token = "0x20022D8")]
		[Serializable]
		private class AvalancheArea
		{
			// Token: 0x0600E103 RID: 57603 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E103")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AvalancheArea()
			{
			}

			// Token: 0x0400F59A RID: 62874
			[Token(Token = "0x400F59A")]
			[FieldOffset(Offset = "0x10")]
			public int index;

			// Token: 0x0400F59B RID: 62875
			[Token(Token = "0x400F59B")]
			[FieldOffset(Offset = "0x14")]
			public int direction;

			// Token: 0x0400F59C RID: 62876
			[Token(Token = "0x400F59C")]
			[FieldOffset(Offset = "0x18")]
			public ObjectPtr<Entity> host;

			// Token: 0x0400F59D RID: 62877
			[Token(Token = "0x400F59D")]
			[FieldOffset(Offset = "0x28")]
			public RangeLineEffectHandler handler;

			// Token: 0x0400F59E RID: 62878
			[Token(Token = "0x400F59E")]
			[FieldOffset(Offset = "0x30")]
			public HashSet<ObjectPtr<Character>> characters;

			// Token: 0x0400F59F RID: 62879
			[Token(Token = "0x400F59F")]
			[FieldOffset(Offset = "0x38")]
			public HashSet<ObjectPtr<Enemy>> enemies;

			// Token: 0x0400F5A0 RID: 62880
			[Token(Token = "0x400F5A0")]
			[FieldOffset(Offset = "0x40")]
			public int nextExpandingDirection;

			// Token: 0x0400F5A1 RID: 62881
			[Token(Token = "0x400F5A1")]
			[FieldOffset(Offset = "0x48")]
			public HashSet<GridPosition> grids;

			// Token: 0x0400F5A2 RID: 62882
			[Token(Token = "0x400F5A2")]
			[FieldOffset(Offset = "0x50")]
			public HashSet<GridPosition> additionalGrids;

			// Token: 0x0400F5A3 RID: 62883
			[Token(Token = "0x400F5A3")]
			[FieldOffset(Offset = "0x58")]
			public Dictionary<GridPosition, int> protectedGrids;

			// Token: 0x0400F5A4 RID: 62884
			[Token(Token = "0x400F5A4")]
			[FieldOffset(Offset = "0x60")]
			public HashSet<ObjectPtr<Entity>> blockers;
		}
	}
}
