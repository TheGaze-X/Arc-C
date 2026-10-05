using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.Battle.Runes;
using Torappu.Battle.Runes.Internal;
using Torappu.Battle.UI.Sandbox;
using Torappu.UI;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A5E RID: 10846
	[Token(Token = "0x2002A5E")]
	public class SandboxBattleManager : IHotfixable
	{
		// Token: 0x06012046 RID: 73798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012046")]
		[Address(RVA = "0xA12EF0", Offset = "0xA11AF0", VA = "0x180A12EF0")]
		public SandboxBattleManager(GameModeFactory.SandboxGameMode gameMode)
		{
		}

		// Token: 0x17002793 RID: 10131
		// (get) Token: 0x06012047 RID: 73799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002793")]
		private SandboxUIPlugin uiPlugin
		{
			[Token(Token = "0x6012047")]
			[Address(RVA = "0xA13A70", Offset = "0xA12670", VA = "0x180A13A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002794 RID: 10132
		// (get) Token: 0x06012048 RID: 73800 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06012049 RID: 73801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002794")]
		public UIBattleSandboxItemNotification notification
		{
			[Token(Token = "0x6012048")]
			[Address(RVA = "0xA139B0", Offset = "0xA125B0", VA = "0x180A139B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6012049")]
			[Address(RVA = "0xA13E00", Offset = "0xA12A00", VA = "0x180A13E00")]
			set
			{
			}
		}

		// Token: 0x17002795 RID: 10133
		// (get) Token: 0x0601204A RID: 73802 RVA: 0x0006E268 File Offset: 0x0006C468
		// (set) Token: 0x0601204B RID: 73803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002795")]
		private int maxVisibleCnt
		{
			[Token(Token = "0x601204A")]
			[Address(RVA = "0xA13950", Offset = "0xA12550", VA = "0x180A13950")]
			get
			{
				return 0;
			}
			[Token(Token = "0x601204B")]
			[Address(RVA = "0xA13D90", Offset = "0xA12990", VA = "0x180A13D90")]
			set
			{
			}
		}

		// Token: 0x17002796 RID: 10134
		// (get) Token: 0x0601204C RID: 73804 RVA: 0x0006E280 File Offset: 0x0006C480
		// (set) Token: 0x0601204D RID: 73805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002796")]
		public int maxVisibleCntLimit
		{
			[Token(Token = "0x601204C")]
			[Address(RVA = "0xA138B0", Offset = "0xA124B0", VA = "0x180A138B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x601204D")]
			[Address(RVA = "0xA13D20", Offset = "0xA12920", VA = "0x180A13D20")]
			set
			{
			}
		}

		// Token: 0x17002797 RID: 10135
		// (get) Token: 0x0601204E RID: 73806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002797")]
		public List<Deck.Card> originHiddenList
		{
			[Token(Token = "0x601204E")]
			[Address(RVA = "0xA13A10", Offset = "0xA12610", VA = "0x180A13A10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002798 RID: 10136
		// (get) Token: 0x0601204F RID: 73807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002798")]
		public List<List<Deck.Card>> cardPageList
		{
			[Token(Token = "0x601204F")]
			[Address(RVA = "0xA135D0", Offset = "0xA121D0", VA = "0x180A135D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002799 RID: 10137
		// (get) Token: 0x06012050 RID: 73808 RVA: 0x0006E298 File Offset: 0x0006C498
		// (set) Token: 0x06012051 RID: 73809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002799")]
		public int activePage
		{
			[Token(Token = "0x6012050")]
			[Address(RVA = "0xA133C0", Offset = "0xA11FC0", VA = "0x180A133C0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6012051")]
			[Address(RVA = "0xA13C20", Offset = "0xA12820", VA = "0x180A13C20")]
			set
			{
			}
		}

		// Token: 0x1700279A RID: 10138
		// (get) Token: 0x06012052 RID: 73810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700279A")]
		public List<string> charactersWithFoodBuff
		{
			[Token(Token = "0x6012052")]
			[Address(RVA = "0xA13630", Offset = "0xA12230", VA = "0x180A13630")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700279B RID: 10139
		// (get) Token: 0x06012053 RID: 73811 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06012054 RID: 73812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700279B")]
		public string exploredMap
		{
			[Token(Token = "0x6012053")]
			[Address(RVA = "0xA137B0", Offset = "0xA123B0", VA = "0x180A137B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6012054")]
			[Address(RVA = "0xA13C90", Offset = "0xA12890", VA = "0x180A13C90")]
			set
			{
			}
		}

		// Token: 0x1700279C RID: 10140
		// (get) Token: 0x06012055 RID: 73813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700279C")]
		public SandboxV2Data configData
		{
			[Token(Token = "0x6012055")]
			[Address(RVA = "0xA136A0", Offset = "0xA122A0", VA = "0x180A136A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700279D RID: 10141
		// (get) Token: 0x06012056 RID: 73814 RVA: 0x0006E2B0 File Offset: 0x0006C4B0
		[Token(Token = "0x1700279D")]
		public SandboxLevelConfig levelConfig
		{
			[Token(Token = "0x6012056")]
			[Address(RVA = "0xA13820", Offset = "0xA12420", VA = "0x180A13820")]
			get
			{
				return default(SandboxLevelConfig);
			}
		}

		// Token: 0x1700279E RID: 10142
		// (get) Token: 0x06012057 RID: 73815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700279E")]
		public Dictionary<SandboxEntityStatusKey, SandboxEntityStatusValue> entityStatus
		{
			[Token(Token = "0x6012057")]
			[Address(RVA = "0xA13710", Offset = "0xA12310", VA = "0x180A13710")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700279F RID: 10143
		// (get) Token: 0x06012058 RID: 73816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700279F")]
		public SandboxCameraPlugin cameraPlugin
		{
			[Token(Token = "0x6012058")]
			[Address(RVA = "0xA13420", Offset = "0xA12020", VA = "0x180A13420")]
			get
			{
				return null;
			}
		}

		// Token: 0x06012059 RID: 73817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012059")]
		[Address(RVA = "0xA0B150", Offset = "0xA09D50", VA = "0x180A0B150")]
		public void Init(LevelData levelData, BattlePlayerData playerData)
		{
		}

		// Token: 0x0601205A RID: 73818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601205A")]
		[Address(RVA = "0xA0CC00", Offset = "0xA0B800", VA = "0x180A0CC00")]
		public void OnGameOver(BattleController.GameResult result)
		{
		}

		// Token: 0x0601205B RID: 73819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601205B")]
		[Address(RVA = "0xA0CB90", Offset = "0xA0B790", VA = "0x180A0CB90")]
		public void OnFetchGameOverOutput()
		{
		}

		// Token: 0x0601205C RID: 73820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601205C")]
		[Address(RVA = "0xA11E80", Offset = "0xA10A80", VA = "0x180A11E80")]
		private void _ParseConfigBlackboard(LevelData levelData)
		{
		}

		// Token: 0x0601205D RID: 73821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601205D")]
		[Address(RVA = "0xA119F0", Offset = "0xA105F0", VA = "0x180A119F0")]
		private void _InitInputStatus()
		{
		}

		// Token: 0x0601205E RID: 73822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601205E")]
		[Address(RVA = "0xA11DC0", Offset = "0xA109C0", VA = "0x180A11DC0")]
		private void _ParseCameraPlugin(Blackboard blackboard)
		{
		}

		// Token: 0x0601205F RID: 73823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601205F")]
		[Address(RVA = "0xA123D0", Offset = "0xA10FD0", VA = "0x180A123D0")]
		private void _ParseNpc(Blackboard blackboard)
		{
		}

		// Token: 0x06012060 RID: 73824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012060")]
		[Address(RVA = "0xA12020", Offset = "0xA10C20", VA = "0x180A12020")]
		private void _ParseHiddenArea(Blackboard blackboard)
		{
		}

		// Token: 0x06012061 RID: 73825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012061")]
		[Address(RVA = "0xA0D2C0", Offset = "0xA0BEC0", VA = "0x180A0D2C0")]
		public void PostprocessMap(Map map)
		{
		}

		// Token: 0x06012062 RID: 73826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012062")]
		[Address(RVA = "0xA11450", Offset = "0xA10050", VA = "0x180A11450")]
		private void _DoHideTile()
		{
		}

		// Token: 0x06012063 RID: 73827 RVA: 0x0006E2C8 File Offset: 0x0006C4C8
		[Token(Token = "0x6012063")]
		[Address(RVA = "0xA09600", Offset = "0xA08200", VA = "0x180A09600")]
		public bool CheckTileValid(int row, int col)
		{
			return default(bool);
		}

		// Token: 0x06012064 RID: 73828 RVA: 0x0006E2E0 File Offset: 0x0006C4E0
		[Token(Token = "0x6012064")]
		[Address(RVA = "0xA10A30", Offset = "0xA0F630", VA = "0x180A10A30")]
		public bool ShowHiddenAreas(string rectStrs, Trap trap)
		{
			return default(bool);
		}

		// Token: 0x06012065 RID: 73829 RVA: 0x0006E2F8 File Offset: 0x0006C4F8
		[Token(Token = "0x6012065")]
		[Address(RVA = "0xA128A0", Offset = "0xA114A0", VA = "0x180A128A0")]
		private bool _ShowHiddenArea(string rectStr, Trap trap)
		{
			return default(bool);
		}

		// Token: 0x06012066 RID: 73830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012066")]
		[Address(RVA = "0xA0D340", Offset = "0xA0BF40", VA = "0x180A0D340")]
		public void PreprocessCharacterCard(BattleCharacterData data, Character character)
		{
		}

		// Token: 0x06012067 RID: 73831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012067")]
		[Address(RVA = "0xA0D4F0", Offset = "0xA0C0F0", VA = "0x180A0D4F0")]
		public void PreprocessEnemy(LevelData.EnemyData data)
		{
		}

		// Token: 0x06012068 RID: 73832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012068")]
		[Address(RVA = "0xA0C8F0", Offset = "0xA0B4F0", VA = "0x180A0C8F0")]
		public void OnEnemyBorn(Enemy enemy)
		{
		}

		// Token: 0x06012069 RID: 73833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012069")]
		[Address(RVA = "0xA0DD50", Offset = "0xA0C950", VA = "0x180A0DD50")]
		public void PreprocessRuneInput(RuneManager manager)
		{
		}

		// Token: 0x0601206A RID: 73834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601206A")]
		[Address(RVA = "0xA0CC80", Offset = "0xA0B880", VA = "0x180A0CC80")]
		public void OnStartGame()
		{
		}

		// Token: 0x0601206B RID: 73835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601206B")]
		[Address(RVA = "0xA0A200", Offset = "0xA08E00", VA = "0x180A0A200")]
		public IEnumerator FinalSchedule()
		{
			return null;
		}

		// Token: 0x0601206C RID: 73836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601206C")]
		[Address(RVA = "0xA112A0", Offset = "0xA0FEA0", VA = "0x180A112A0")]
		public void TrySummonInsects()
		{
		}

		// Token: 0x0601206D RID: 73837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601206D")]
		[Address(RVA = "0xA0D230", Offset = "0xA0BE30", VA = "0x180A0D230")]
		public void PostPreprocessLevel(LevelData levelData)
		{
		}

		// Token: 0x0601206E RID: 73838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601206E")]
		[Address(RVA = "0xA0E440", Offset = "0xA0D040", VA = "0x180A0E440")]
		public void RebuildPageList()
		{
		}

		// Token: 0x0601206F RID: 73839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601206F")]
		[Address(RVA = "0xA0ECE0", Offset = "0xA0D8E0", VA = "0x180A0ECE0")]
		public void RefreshCardListByActivePage()
		{
		}

		// Token: 0x06012070 RID: 73840 RVA: 0x0006E310 File Offset: 0x0006C510
		[Token(Token = "0x6012070")]
		[Address(RVA = "0xA11310", Offset = "0xA0FF10", VA = "0x180A11310")]
		private static bool _CheckIfTeamTacticalCard(Deck.Card card)
		{
			return default(bool);
		}

		// Token: 0x06012071 RID: 73841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012071")]
		[Address(RVA = "0xA12690", Offset = "0xA11290", VA = "0x180A12690")]
		private static void _RemoveTeamTacticalCard(List<Deck.Card> cards)
		{
		}

		// Token: 0x06012072 RID: 73842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012072")]
		[Address(RVA = "0xA0DB60", Offset = "0xA0C760", VA = "0x180A0DB60")]
		public void PreprocessPlayerDeckList(ListDict<PlayerSide, Deck> deckList)
		{
		}

		// Token: 0x06012073 RID: 73843 RVA: 0x0006E328 File Offset: 0x0006C528
		[Token(Token = "0x6012073")]
		[Address(RVA = "0xA08F70", Offset = "0xA07B70", VA = "0x180A08F70")]
		public bool CheckCardDeployCountNotOverflow(Deck.Card card)
		{
			return default(bool);
		}

		// Token: 0x06012074 RID: 73844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012074")]
		[Address(RVA = "0xA110D0", Offset = "0xA0FCD0", VA = "0x180A110D0")]
		public void SwitchPage(int curPage)
		{
		}

		// Token: 0x06012075 RID: 73845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012075")]
		[Address(RVA = "0xA0C7C0", Offset = "0xA0B3C0", VA = "0x180A0C7C0")]
		public void OnCharacterFinished(Character character, Entity.FinishReason reason)
		{
		}

		// Token: 0x06012076 RID: 73846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012076")]
		[Address(RVA = "0xA0C9B0", Offset = "0xA0B5B0", VA = "0x180A0C9B0")]
		public void OnEnemyFinished(Enemy enemy, Entity.FinishReason reason)
		{
		}

		// Token: 0x06012077 RID: 73847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012077")]
		[Address(RVA = "0xA0CD70", Offset = "0xA0B970", VA = "0x180A0CD70")]
		public void OnUnitRegistered(Unit unit)
		{
		}

		// Token: 0x06012078 RID: 73848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012078")]
		[Address(RVA = "0xA0B050", Offset = "0xA09C50", VA = "0x180A0B050")]
		public Scheduler.SchedulerPreprocessor GetSchedulerPreprocessor()
		{
			return null;
		}

		// Token: 0x06012079 RID: 73849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012079")]
		[Address(RVA = "0xA0D650", Offset = "0xA0C250", VA = "0x180A0D650")]
		public List<LevelData.GlobalBuffData> PreprocessGlobalBuff()
		{
			return null;
		}

		// Token: 0x0601207A RID: 73850 RVA: 0x0006E340 File Offset: 0x0006C540
		[Token(Token = "0x601207A")]
		[Address(RVA = "0xA0B830", Offset = "0xA0A430", VA = "0x180A0B830")]
		public bool IsConstructItem(Character character)
		{
			return default(bool);
		}

		// Token: 0x0601207B RID: 73851 RVA: 0x0006E358 File Offset: 0x0006C558
		[Token(Token = "0x601207B")]
		[Address(RVA = "0xA0B960", Offset = "0xA0A560", VA = "0x180A0B960")]
		public bool IsFactoryTrap(Character character)
		{
			return default(bool);
		}

		// Token: 0x0601207C RID: 73852 RVA: 0x0006E370 File Offset: 0x0006C570
		[Token(Token = "0x601207C")]
		[Address(RVA = "0xA0BA10", Offset = "0xA0A610", VA = "0x180A0BA10")]
		public bool IsFactoryTrap(Deck.Card card)
		{
			return default(bool);
		}

		// Token: 0x0601207D RID: 73853 RVA: 0x0006E388 File Offset: 0x0006C588
		[Token(Token = "0x601207D")]
		[Address(RVA = "0xA0BBC0", Offset = "0xA0A7C0", VA = "0x180A0BBC0")]
		public bool IsPlacedItem(Entity entity)
		{
			return default(bool);
		}

		// Token: 0x0601207E RID: 73854 RVA: 0x0006E3A0 File Offset: 0x0006C5A0
		[Token(Token = "0x601207E")]
		[Address(RVA = "0xA0AFA0", Offset = "0xA09BA0", VA = "0x180A0AFA0")]
		public int GetResCountByID(string resId, bool thisLevel)
		{
			return 0;
		}

		// Token: 0x0601207F RID: 73855 RVA: 0x0006E3B8 File Offset: 0x0006C5B8
		[Token(Token = "0x601207F")]
		[Address(RVA = "0xA0A9E0", Offset = "0xA095E0", VA = "0x180A0A9E0")]
		public int GetGoldCount(bool thisLevel)
		{
			return 0;
		}

		// Token: 0x06012080 RID: 73856 RVA: 0x0006E3D0 File Offset: 0x0006C5D0
		[Token(Token = "0x6012080")]
		[Address(RVA = "0xA0A2B0", Offset = "0xA08EB0", VA = "0x180A0A2B0")]
		public int GetAllRepairCost()
		{
			return 0;
		}

		// Token: 0x06012081 RID: 73857 RVA: 0x0006E3E8 File Offset: 0x0006C5E8
		[Token(Token = "0x6012081")]
		[Address(RVA = "0xA0A690", Offset = "0xA09290", VA = "0x180A0A690")]
		public int GetDimensionCoinItemIdCount(bool thisLevel)
		{
			return 0;
		}

		// Token: 0x06012082 RID: 73858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012082")]
		[Address(RVA = "0xA10010", Offset = "0xA0EC10", VA = "0x180A10010")]
		public int[] SandboxEntityPackedItems(Entity entity)
		{
			return null;
		}

		// Token: 0x06012083 RID: 73859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012083")]
		[Address(RVA = "0xA0FEC0", Offset = "0xA0EAC0", VA = "0x180A0FEC0")]
		public void SandboxEntityDropItem(Entity entity, ResDropSourceType type)
		{
		}

		// Token: 0x06012084 RID: 73860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012084")]
		[Address(RVA = "0xA0FE10", Offset = "0xA0EA10", VA = "0x180A0FE10")]
		public void SandboxEntityDropItem(Entity entity, string itemId, int count)
		{
		}

		// Token: 0x06012085 RID: 73861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012085")]
		[Address(RVA = "0xA0F930", Offset = "0xA0E530", VA = "0x180A0F930")]
		public void SandboxCollectItem(string itemId, int count)
		{
		}

		// Token: 0x06012086 RID: 73862 RVA: 0x0006E400 File Offset: 0x0006C600
		[Token(Token = "0x6012086")]
		[Address(RVA = "0xA0F9E0", Offset = "0xA0E5E0", VA = "0x180A0F9E0")]
		public bool SandboxCollectRacer(Enemy enemy)
		{
			return default(bool);
		}

		// Token: 0x06012087 RID: 73863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012087")]
		[Address(RVA = "0xA0F710", Offset = "0xA0E310", VA = "0x180A0F710")]
		public void SandboxBindCollectItemListener(Action<string, int> onItemCollect)
		{
		}

		// Token: 0x06012088 RID: 73864 RVA: 0x0006E418 File Offset: 0x0006C618
		[Token(Token = "0x6012088")]
		[Address(RVA = "0xA0BB30", Offset = "0xA0A730", VA = "0x180A0BB30")]
		public bool IsPackedResFull(Entity entity)
		{
			return default(bool);
		}

		// Token: 0x06012089 RID: 73865 RVA: 0x0006E430 File Offset: 0x0006C630
		[Token(Token = "0x6012089")]
		[Address(RVA = "0xA0AD70", Offset = "0xA09970", VA = "0x180A0AD70")]
		public int GetPackedResMaxCount(Entity entity)
		{
			return 0;
		}

		// Token: 0x0601208A RID: 73866 RVA: 0x0006E448 File Offset: 0x0006C648
		[Token(Token = "0x601208A")]
		[Address(RVA = "0xA0AE00", Offset = "0xA09A00", VA = "0x180A0AE00")]
		public int GetPackedResMaxCount(Deck.Card card)
		{
			return 0;
		}

		// Token: 0x0601208B RID: 73867 RVA: 0x0006E460 File Offset: 0x0006C660
		[Token(Token = "0x601208B")]
		[Address(RVA = "0xA097E0", Offset = "0xA083E0", VA = "0x180A097E0")]
		public bool CollectPackedRes(Entity entity)
		{
			return default(bool);
		}

		// Token: 0x0601208C RID: 73868 RVA: 0x0006E478 File Offset: 0x0006C678
		[Token(Token = "0x601208C")]
		[Address(RVA = "0xA111F0", Offset = "0xA0FDF0", VA = "0x180A111F0")]
		public bool TransferAllPackedRes(Entity fromTarget, Entity toTarget)
		{
			return default(bool);
		}

		// Token: 0x0601208D RID: 73869 RVA: 0x0006E490 File Offset: 0x0006C690
		[Token(Token = "0x601208D")]
		[Address(RVA = "0xA0B0C0", Offset = "0xA09CC0", VA = "0x180A0B0C0")]
		public int GetTotalPackedResCount(Entity entity)
		{
			return 0;
		}

		// Token: 0x0601208E RID: 73870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601208E")]
		[Address(RVA = "0xA0F290", Offset = "0xA0DE90", VA = "0x180A0F290")]
		public void SandboxAvgCollectItem(string itemId, int count)
		{
		}

		// Token: 0x0601208F RID: 73871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601208F")]
		[Address(RVA = "0xA0F100", Offset = "0xA0DD00", VA = "0x180A0F100")]
		public void SandboxAvgCollectItemList(List<UIItemViewModel> models)
		{
		}

		// Token: 0x06012090 RID: 73872 RVA: 0x0006E4A8 File Offset: 0x0006C6A8
		[Token(Token = "0x6012090")]
		[Address(RVA = "0xA09390", Offset = "0xA07F90", VA = "0x180A09390")]
		public bool CheckItemCount(string itemId, int count, bool containsEq)
		{
			return default(bool);
		}

		// Token: 0x06012091 RID: 73873 RVA: 0x0006E4C0 File Offset: 0x0006C6C0
		[Token(Token = "0x6012091")]
		[Address(RVA = "0xA09AA0", Offset = "0xA086A0", VA = "0x180A09AA0")]
		public bool FetchBossRecordedStatus(string rushEnemyUid, string targetKey, out SandboxRushBossStatus status)
		{
			return default(bool);
		}

		// Token: 0x06012092 RID: 73874 RVA: 0x0006E4D8 File Offset: 0x0006C6D8
		[Token(Token = "0x6012092")]
		[Address(RVA = "0xA09F20", Offset = "0xA08B20", VA = "0x180A09F20")]
		public bool FetchUniEnemyRecordedStatus(string targetKey, out SandboxV2UniEnemyStatus status)
		{
			return default(bool);
		}

		// Token: 0x06012093 RID: 73875 RVA: 0x0006E4F0 File Offset: 0x0006C6F0
		[Token(Token = "0x6012093")]
		[Address(RVA = "0xA0A0F0", Offset = "0xA08CF0", VA = "0x180A0A0F0")]
		public bool FetchUnitRecordedStatus(SandboxEntityStatusKey targetKey, out SandboxEntityStatusValue status)
		{
			return default(bool);
		}

		// Token: 0x06012094 RID: 73876 RVA: 0x0006E508 File Offset: 0x0006C708
		[Token(Token = "0x6012094")]
		[Address(RVA = "0xA09C80", Offset = "0xA08880", VA = "0x180A09C80")]
		public bool FetchPlacedItemRecordedStatus(SandboxPlacedItemStatusKey targetKey, out SandboxPlacedItemStatusValue status)
		{
			return default(bool);
		}

		// Token: 0x06012095 RID: 73877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012095")]
		[Address(RVA = "0xA0EB90", Offset = "0xA0D790", VA = "0x180A0EB90")]
		public void RecordUnitState(SandboxEntityStatusKey targetKey, SandboxEntityStatusValue newStatus)
		{
		}

		// Token: 0x06012096 RID: 73878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012096")]
		[Address(RVA = "0xA0E970", Offset = "0xA0D570", VA = "0x180A0E970")]
		public void RecordPlacedItemState(SandboxPlacedItemStatusKey targetKey, SandboxPlacedItemStatusValue newStatus)
		{
		}

		// Token: 0x06012097 RID: 73879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012097")]
		[Address(RVA = "0xA0EA80", Offset = "0xA0D680", VA = "0x180A0EA80")]
		public void RecordUniEnemyState(string targetKey, SandboxV2UniEnemyStatus newStatus)
		{
		}

		// Token: 0x06012098 RID: 73880 RVA: 0x0006E520 File Offset: 0x0006C720
		[Token(Token = "0x6012098")]
		[Address(RVA = "0xA09E70", Offset = "0xA08A70", VA = "0x180A09E70")]
		public bool FetchUniEnemyExtraInfo(string targetKey, out RareAnimalExtraInfo extraInfo)
		{
			return default(bool);
		}

		// Token: 0x06012099 RID: 73881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012099")]
		[Address(RVA = "0xA0E8C0", Offset = "0xA0D4C0", VA = "0x180A0E8C0")]
		public void RecordBossState(string enemyUid, string targetKey, SandboxRushBossStatus newStatus)
		{
		}

		// Token: 0x0601209A RID: 73882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601209A")]
		[Address(RVA = "0xA0EC50", Offset = "0xA0D850", VA = "0x180A0EC50")]
		public void RecordUsingConstructItem(Character character)
		{
		}

		// Token: 0x0601209B RID: 73883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601209B")]
		[Address(RVA = "0xA0C2C0", Offset = "0xA0AEC0", VA = "0x180A0C2C0")]
		public void MarkRushEnemyDead(RushEnemy rushEnemy)
		{
		}

		// Token: 0x0601209C RID: 73884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601209C")]
		[Address(RVA = "0xA0C3C0", Offset = "0xA0AFC0", VA = "0x180A0C3C0")]
		public void MarkRushEnemyReachExit(Enemy target)
		{
		}

		// Token: 0x0601209D RID: 73885 RVA: 0x0006E538 File Offset: 0x0006C738
		[Token(Token = "0x601209D")]
		[Address(RVA = "0xA0E3B0", Offset = "0xA0CFB0", VA = "0x180A0E3B0")]
		public bool ProcessSpecialEnemy(Enemy enemy)
		{
			return default(bool);
		}

		// Token: 0x0601209E RID: 73886 RVA: 0x0006E550 File Offset: 0x0006C750
		[Token(Token = "0x601209E")]
		[Address(RVA = "0xA094F0", Offset = "0xA080F0", VA = "0x180A094F0")]
		public bool CheckSpecialUniEnemy(string enemyId)
		{
			return default(bool);
		}

		// Token: 0x0601209F RID: 73887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601209F")]
		[Address(RVA = "0xA099E0", Offset = "0xA085E0", VA = "0x180A099E0")]
		public void ConstructSaveLevelRes()
		{
		}

		// Token: 0x060120A0 RID: 73888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60120A0")]
		[Address(RVA = "0xA10440", Offset = "0xA0F040", VA = "0x180A10440")]
		public void SandboxMarkDeathDetail(string entityId, int count, SandboxOutput.EnemyDeathDetailType detailType)
		{
		}

		// Token: 0x060120A1 RID: 73889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60120A1")]
		[Address(RVA = "0xA10750", Offset = "0xA0F350", VA = "0x180A10750")]
		public void SandboxMarkUniDeathDetail(string rareAnimalInstId, SandboxOutput.UniEnemyDeathDetailType uniDetailType)
		{
		}

		// Token: 0x060120A2 RID: 73890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60120A2")]
		[Address(RVA = "0xA101A0", Offset = "0xA0EDA0", VA = "0x180A101A0")]
		public void SandboxLogEnemyEvent(string entityId, string eventId, int count)
		{
		}

		// Token: 0x060120A3 RID: 73891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60120A3")]
		[Address(RVA = "0xA105A0", Offset = "0xA0F1A0", VA = "0x180A105A0")]
		public void SandboxMarkRemoveDeathDetail(string entityId, int count, SandboxOutput.EnemyDeathDetailType detailType)
		{
		}

		// Token: 0x060120A4 RID: 73892 RVA: 0x0006E568 File Offset: 0x0006C768
		[Token(Token = "0x60120A4")]
		[Address(RVA = "0xA0A610", Offset = "0xA09210", VA = "0x180A0A610")]
		public float GetCompleteProgress()
		{
			return 0f;
		}

		// Token: 0x060120A5 RID: 73893 RVA: 0x0006E580 File Offset: 0x0006C780
		[Token(Token = "0x60120A5")]
		[Address(RVA = "0xA0BAC0", Offset = "0xA0A6C0", VA = "0x180A0BAC0")]
		public bool IsLevelUnlockConditionComplete()
		{
			return default(bool);
		}

		// Token: 0x060120A6 RID: 73894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60120A6")]
		[Address(RVA = "0xA11760", Offset = "0xA10360", VA = "0x180A11760")]
		private List<Deck.Card> _GetAvailableCardList()
		{
			return null;
		}

		// Token: 0x060120A7 RID: 73895 RVA: 0x0006E598 File Offset: 0x0006C798
		[Token(Token = "0x60120A7")]
		[Address(RVA = "0xA09120", Offset = "0xA07D20", VA = "0x180A09120")]
		public bool CheckConditionKey(string condition, int count, bool containsEq)
		{
			return default(bool);
		}

		// Token: 0x060120A8 RID: 73896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60120A8")]
		[Address(RVA = "0xA0C650", Offset = "0xA0B250", VA = "0x180A0C650")]
		public void ModifyCondition(string condition, int val)
		{
		}

		// Token: 0x060120A9 RID: 73897 RVA: 0x0006E5B0 File Offset: 0x0006C7B0
		[Token(Token = "0x60120A9")]
		[Address(RVA = "0xA09240", Offset = "0xA07E40", VA = "0x180A09240")]
		public bool CheckFavour(string trapId, int val, bool containsEq)
		{
			return default(bool);
		}

		// Token: 0x060120AA RID: 73898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60120AA")]
		[Address(RVA = "0xA08A10", Offset = "0xA07610", VA = "0x180A08A10")]
		public void AddFavour(string trapId, int val)
		{
		}

		// Token: 0x060120AB RID: 73899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60120AB")]
		[Address(RVA = "0xA08E10", Offset = "0xA07A10", VA = "0x180A08E10")]
		public void AddOutput(string npcId, BattleDialogType type)
		{
		}

		// Token: 0x060120AC RID: 73900 RVA: 0x0006E5C8 File Offset: 0x0006C7C8
		[Token(Token = "0x60120AC")]
		[Address(RVA = "0xA0BE00", Offset = "0xA0AA00", VA = "0x180A0BE00")]
		public bool MakeReactGacha(string npcId, bool isAll, int gachaCnt, ref List<UIItemViewModel> gachaedItem)
		{
			return default(bool);
		}

		// Token: 0x060120AD RID: 73901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60120AD")]
		[Address(RVA = "0xA08C10", Offset = "0xA07810", VA = "0x180A08C10")]
		public void AddOutputChoice(string npcId, string content, BattleDialogType type)
		{
		}

		// Token: 0x060120AE RID: 73902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60120AE")]
		[Address(RVA = "0xA0A780", Offset = "0xA09380", VA = "0x180A0A780")]
		public string GetFirstSignal(BattleDialogType type)
		{
			return null;
		}

		// Token: 0x060120AF RID: 73903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60120AF")]
		[Address(RVA = "0xA0AAD0", Offset = "0xA096D0", VA = "0x180A0AAD0")]
		public NpcBattleInput GetNpcInputData(string signalId, BattleDialogType dialogType)
		{
			return null;
		}

		// Token: 0x060120B0 RID: 73904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60120B0")]
		[Address(RVA = "0xA10890", Offset = "0xA0F490", VA = "0x180A10890")]
		public void SetNpcFinish(string npcId, BattleDialogType type)
		{
		}

		// Token: 0x060120B1 RID: 73905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60120B1")]
		[Address(RVA = "0xA0CF50", Offset = "0xA0BB50", VA = "0x180A0CF50")]
		public void OverrideRiftId(string riftId)
		{
		}

		// Token: 0x060120B2 RID: 73906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60120B2")]
		[Address(RVA = "0xA10B60", Offset = "0xA0F760", VA = "0x180A10B60")]
		public void SpawnReactNpcIfNot()
		{
		}

		// Token: 0x040145A0 RID: 83360
		[Token(Token = "0x40145A0")]
		[FieldOffset(Offset = "0x10")]
		private SandboxInput m_input;

		// Token: 0x040145A1 RID: 83361
		[Token(Token = "0x40145A1")]
		[FieldOffset(Offset = "0x18")]
		private SandboxOutput m_output;

		// Token: 0x040145A2 RID: 83362
		[Token(Token = "0x40145A2")]
		[FieldOffset(Offset = "0x20")]
		private GameModeFactory.SandboxGameMode m_gameMode;

		// Token: 0x040145A3 RID: 83363
		[Token(Token = "0x40145A3")]
		[FieldOffset(Offset = "0x28")]
		private SandboxLevelDataProcessor m_levelDataProcessor;

		// Token: 0x040145A4 RID: 83364
		[Token(Token = "0x40145A4")]
		[FieldOffset(Offset = "0x30")]
		private SandboxBattleDataController m_battleStatusController;

		// Token: 0x040145A5 RID: 83365
		[Token(Token = "0x40145A5")]
		[FieldOffset(Offset = "0x38")]
		private SandboxLevelConfig m_levelConfig;

		// Token: 0x040145A6 RID: 83366
		[Token(Token = "0x40145A6")]
		[FieldOffset(Offset = "0x40")]
		private readonly List<LevelData.GlobalBuffData> m_globalBuffs;

		// Token: 0x040145A7 RID: 83367
		[Token(Token = "0x40145A7")]
		[FieldOffset(Offset = "0x48")]
		private SandboxCameraPlugin m_cameraPlugin;

		// Token: 0x040145A8 RID: 83368
		[Token(Token = "0x40145A8")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<string, string> m_hiddenAreaGraphicKeys;

		// Token: 0x040145A9 RID: 83369
		[Token(Token = "0x40145A9")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<string, HiddenArea> m_hiddenAreas;

		// Token: 0x040145AA RID: 83370
		[Token(Token = "0x40145AA")]
		[FieldOffset(Offset = "0x60")]
		private HiddenAreaTileListener m_hiddenTileListener;

		// Token: 0x040145AB RID: 83371
		[Token(Token = "0x40145AB")]
		[FieldOffset(Offset = "0x68")]
		private SandboxBattleManager.SandboxLevelProgressHelper m_progressHelper;

		// Token: 0x040145AC RID: 83372
		[Token(Token = "0x40145AC")]
		[FieldOffset(Offset = "0x70")]
		private List<uint> m_sandboxFactoryTrapUidList;

		// Token: 0x040145AD RID: 83373
		[Token(Token = "0x40145AD")]
		[FieldOffset(Offset = "0x78")]
		private HashSet<string> m_sandboxFactoryTrapIds;

		// Token: 0x040145AE RID: 83374
		[Token(Token = "0x40145AE")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<string, int> m_itemMaxDeployCnt;

		// Token: 0x040145AF RID: 83375
		[Token(Token = "0x40145AF")]
		[FieldOffset(Offset = "0x88")]
		private Dictionary<string, int> m_itemCurrentDeployCnt;

		// Token: 0x040145B0 RID: 83376
		[Token(Token = "0x40145B0")]
		[FieldOffset(Offset = "0x90")]
		private readonly List<List<Deck.Card>> m_cardPageList;

		// Token: 0x040145B1 RID: 83377
		[Token(Token = "0x40145B1")]
		[FieldOffset(Offset = "0x98")]
		private int m_activePage;

		// Token: 0x040145B2 RID: 83378
		[Token(Token = "0x40145B2")]
		[FieldOffset(Offset = "0xA0")]
		private readonly List<Deck.Card> m_originHiddenList;

		// Token: 0x040145B3 RID: 83379
		[Token(Token = "0x40145B3")]
		[FieldOffset(Offset = "0xA8")]
		private int m_maxVisibleCnt;

		// Token: 0x040145B4 RID: 83380
		[Token(Token = "0x40145B4")]
		[FieldOffset(Offset = "0xAC")]
		private int m_maxVisibleCntLimit;

		// Token: 0x040145B5 RID: 83381
		[Token(Token = "0x40145B5")]
		[FieldOffset(Offset = "0xB0")]
		private UIBattleSandboxItemNotification m_notification;

		// Token: 0x040145B6 RID: 83382
		[Token(Token = "0x40145B6")]
		[FieldOffset(Offset = "0xB8")]
		private SandboxUIPlugin m_uiPlugin;

		// Token: 0x040145B7 RID: 83383
		[Token(Token = "0x40145B7")]
		[FieldOffset(Offset = "0xC0")]
		private bool hasSpwanedNpc;

		// Token: 0x040145B8 RID: 83384
		[Token(Token = "0x40145B8")]
		[FieldOffset(Offset = "0xC4")]
		private int m_remainingRacerItemSpace;

		// Token: 0x040145B9 RID: 83385
		[Token(Token = "0x40145B9")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_teamTacticalEffectEnabled;

		// Token: 0x040145BA RID: 83386
		[Token(Token = "0x40145BA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040145BB RID: 83387
		[Token(Token = "0x40145BB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_uiPlugin;

		// Token: 0x040145BC RID: 83388
		[Token(Token = "0x40145BC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_notification;

		// Token: 0x040145BD RID: 83389
		[Token(Token = "0x40145BD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_notification;

		// Token: 0x040145BE RID: 83390
		[Token(Token = "0x40145BE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_maxVisibleCnt;

		// Token: 0x040145BF RID: 83391
		[Token(Token = "0x40145BF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_maxVisibleCnt;

		// Token: 0x040145C0 RID: 83392
		[Token(Token = "0x40145C0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_maxVisibleCntLimit;

		// Token: 0x040145C1 RID: 83393
		[Token(Token = "0x40145C1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_maxVisibleCntLimit;

		// Token: 0x040145C2 RID: 83394
		[Token(Token = "0x40145C2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_originHiddenList;

		// Token: 0x040145C3 RID: 83395
		[Token(Token = "0x40145C3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_cardPageList;

		// Token: 0x040145C4 RID: 83396
		[Token(Token = "0x40145C4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_activePage;

		// Token: 0x040145C5 RID: 83397
		[Token(Token = "0x40145C5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_activePage;

		// Token: 0x040145C6 RID: 83398
		[Token(Token = "0x40145C6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_charactersWithFoodBuff;

		// Token: 0x040145C7 RID: 83399
		[Token(Token = "0x40145C7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_exploredMap;

		// Token: 0x040145C8 RID: 83400
		[Token(Token = "0x40145C8")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_exploredMap;

		// Token: 0x040145C9 RID: 83401
		[Token(Token = "0x40145C9")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_configData;

		// Token: 0x040145CA RID: 83402
		[Token(Token = "0x40145CA")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_levelConfig;

		// Token: 0x040145CB RID: 83403
		[Token(Token = "0x40145CB")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_entityStatus;

		// Token: 0x040145CC RID: 83404
		[Token(Token = "0x40145CC")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_cameraPlugin;

		// Token: 0x040145CD RID: 83405
		[Token(Token = "0x40145CD")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040145CE RID: 83406
		[Token(Token = "0x40145CE")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnGameOver;

		// Token: 0x040145CF RID: 83407
		[Token(Token = "0x40145CF")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnFetchGameOverOutput;

		// Token: 0x040145D0 RID: 83408
		[Token(Token = "0x40145D0")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__ParseConfigBlackboard;

		// Token: 0x040145D1 RID: 83409
		[Token(Token = "0x40145D1")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__InitInputStatus;

		// Token: 0x040145D2 RID: 83410
		[Token(Token = "0x40145D2")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__ParseCameraPlugin;

		// Token: 0x040145D3 RID: 83411
		[Token(Token = "0x40145D3")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__ParseNpc;

		// Token: 0x040145D4 RID: 83412
		[Token(Token = "0x40145D4")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__ParseHiddenArea;

		// Token: 0x040145D5 RID: 83413
		[Token(Token = "0x40145D5")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_PostprocessMap;

		// Token: 0x040145D6 RID: 83414
		[Token(Token = "0x40145D6")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__DoHideTile;

		// Token: 0x040145D7 RID: 83415
		[Token(Token = "0x40145D7")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_CheckTileValid;

		// Token: 0x040145D8 RID: 83416
		[Token(Token = "0x40145D8")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_ShowHiddenAreas;

		// Token: 0x040145D9 RID: 83417
		[Token(Token = "0x40145D9")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__ShowHiddenArea;

		// Token: 0x040145DA RID: 83418
		[Token(Token = "0x40145DA")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_PreprocessCharacterCard;

		// Token: 0x040145DB RID: 83419
		[Token(Token = "0x40145DB")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_PreprocessEnemy;

		// Token: 0x040145DC RID: 83420
		[Token(Token = "0x40145DC")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_OnEnemyBorn;

		// Token: 0x040145DD RID: 83421
		[Token(Token = "0x40145DD")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_PreprocessRuneInput;

		// Token: 0x040145DE RID: 83422
		[Token(Token = "0x40145DE")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_OnStartGame;

		// Token: 0x040145DF RID: 83423
		[Token(Token = "0x40145DF")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_FinalSchedule;

		// Token: 0x040145E0 RID: 83424
		[Token(Token = "0x40145E0")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_TrySummonInsects;

		// Token: 0x040145E1 RID: 83425
		[Token(Token = "0x40145E1")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_PostPreprocessLevel;

		// Token: 0x040145E2 RID: 83426
		[Token(Token = "0x40145E2")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_RebuildPageList;

		// Token: 0x040145E3 RID: 83427
		[Token(Token = "0x40145E3")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_RefreshCardListByActivePage;

		// Token: 0x040145E4 RID: 83428
		[Token(Token = "0x40145E4")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__CheckIfTeamTacticalCard;

		// Token: 0x040145E5 RID: 83429
		[Token(Token = "0x40145E5")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__RemoveTeamTacticalCard;

		// Token: 0x040145E6 RID: 83430
		[Token(Token = "0x40145E6")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_PreprocessPlayerDeckList;

		// Token: 0x040145E7 RID: 83431
		[Token(Token = "0x40145E7")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_CheckCardDeployCountNotOverflow;

		// Token: 0x040145E8 RID: 83432
		[Token(Token = "0x40145E8")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_SwitchPage;

		// Token: 0x040145E9 RID: 83433
		[Token(Token = "0x40145E9")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_OnCharacterFinished;

		// Token: 0x040145EA RID: 83434
		[Token(Token = "0x40145EA")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_OnEnemyFinished;

		// Token: 0x040145EB RID: 83435
		[Token(Token = "0x40145EB")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_OnUnitRegistered;

		// Token: 0x040145EC RID: 83436
		[Token(Token = "0x40145EC")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_GetSchedulerPreprocessor;

		// Token: 0x040145ED RID: 83437
		[Token(Token = "0x40145ED")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_PreprocessGlobalBuff;

		// Token: 0x040145EE RID: 83438
		[Token(Token = "0x40145EE")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_IsConstructItem;

		// Token: 0x040145EF RID: 83439
		[Token(Token = "0x40145EF")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_IsFactoryTrap;

		// Token: 0x040145F0 RID: 83440
		[Token(Token = "0x40145F0")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix1_IsFactoryTrap;

		// Token: 0x040145F1 RID: 83441
		[Token(Token = "0x40145F1")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_IsPlacedItem;

		// Token: 0x040145F2 RID: 83442
		[Token(Token = "0x40145F2")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_GetResCountByID;

		// Token: 0x040145F3 RID: 83443
		[Token(Token = "0x40145F3")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_GetGoldCount;

		// Token: 0x040145F4 RID: 83444
		[Token(Token = "0x40145F4")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_GetAllRepairCost;

		// Token: 0x040145F5 RID: 83445
		[Token(Token = "0x40145F5")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_GetDimensionCoinItemIdCount;

		// Token: 0x040145F6 RID: 83446
		[Token(Token = "0x40145F6")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_SandboxEntityPackedItems;

		// Token: 0x040145F7 RID: 83447
		[Token(Token = "0x40145F7")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_SandboxEntityDropItem;

		// Token: 0x040145F8 RID: 83448
		[Token(Token = "0x40145F8")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix1_SandboxEntityDropItem;

		// Token: 0x040145F9 RID: 83449
		[Token(Token = "0x40145F9")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_SandboxCollectItem;

		// Token: 0x040145FA RID: 83450
		[Token(Token = "0x40145FA")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_SandboxCollectRacer;

		// Token: 0x040145FB RID: 83451
		[Token(Token = "0x40145FB")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_SandboxBindCollectItemListener;

		// Token: 0x040145FC RID: 83452
		[Token(Token = "0x40145FC")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_IsPackedResFull;

		// Token: 0x040145FD RID: 83453
		[Token(Token = "0x40145FD")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_GetPackedResMaxCount;

		// Token: 0x040145FE RID: 83454
		[Token(Token = "0x40145FE")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix1_GetPackedResMaxCount;

		// Token: 0x040145FF RID: 83455
		[Token(Token = "0x40145FF")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_CollectPackedRes;

		// Token: 0x04014600 RID: 83456
		[Token(Token = "0x4014600")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_TransferAllPackedRes;

		// Token: 0x04014601 RID: 83457
		[Token(Token = "0x4014601")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_GetTotalPackedResCount;

		// Token: 0x04014602 RID: 83458
		[Token(Token = "0x4014602")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_SandboxAvgCollectItem;

		// Token: 0x04014603 RID: 83459
		[Token(Token = "0x4014603")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_SandboxAvgCollectItemList;

		// Token: 0x04014604 RID: 83460
		[Token(Token = "0x4014604")]
		[FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_CheckItemCount;

		// Token: 0x04014605 RID: 83461
		[Token(Token = "0x4014605")]
		[FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_FetchBossRecordedStatus;

		// Token: 0x04014606 RID: 83462
		[Token(Token = "0x4014606")]
		[FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0_FetchUniEnemyRecordedStatus;

		// Token: 0x04014607 RID: 83463
		[Token(Token = "0x4014607")]
		[FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0_FetchUnitRecordedStatus;

		// Token: 0x04014608 RID: 83464
		[Token(Token = "0x4014608")]
		[FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0_FetchPlacedItemRecordedStatus;

		// Token: 0x04014609 RID: 83465
		[Token(Token = "0x4014609")]
		[FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0_RecordUnitState;

		// Token: 0x0401460A RID: 83466
		[Token(Token = "0x401460A")]
		[FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0_RecordPlacedItemState;

		// Token: 0x0401460B RID: 83467
		[Token(Token = "0x401460B")]
		[FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0_RecordUniEnemyState;

		// Token: 0x0401460C RID: 83468
		[Token(Token = "0x401460C")]
		[FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0_FetchUniEnemyExtraInfo;

		// Token: 0x0401460D RID: 83469
		[Token(Token = "0x401460D")]
		[FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0_RecordBossState;

		// Token: 0x0401460E RID: 83470
		[Token(Token = "0x401460E")]
		[FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0_RecordUsingConstructItem;

		// Token: 0x0401460F RID: 83471
		[Token(Token = "0x401460F")]
		[FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0_MarkRushEnemyDead;

		// Token: 0x04014610 RID: 83472
		[Token(Token = "0x4014610")]
		[FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0_MarkRushEnemyReachExit;

		// Token: 0x04014611 RID: 83473
		[Token(Token = "0x4014611")]
		[FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0_ProcessSpecialEnemy;

		// Token: 0x04014612 RID: 83474
		[Token(Token = "0x4014612")]
		[FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0_CheckSpecialUniEnemy;

		// Token: 0x04014613 RID: 83475
		[Token(Token = "0x4014613")]
		[FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0_ConstructSaveLevelRes;

		// Token: 0x04014614 RID: 83476
		[Token(Token = "0x4014614")]
		[FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0_SandboxMarkDeathDetail;

		// Token: 0x04014615 RID: 83477
		[Token(Token = "0x4014615")]
		[FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0_SandboxMarkUniDeathDetail;

		// Token: 0x04014616 RID: 83478
		[Token(Token = "0x4014616")]
		[FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0_SandboxLogEnemyEvent;

		// Token: 0x04014617 RID: 83479
		[Token(Token = "0x4014617")]
		[FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0_SandboxMarkRemoveDeathDetail;

		// Token: 0x04014618 RID: 83480
		[Token(Token = "0x4014618")]
		[FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0_GetCompleteProgress;

		// Token: 0x04014619 RID: 83481
		[Token(Token = "0x4014619")]
		[FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0_IsLevelUnlockConditionComplete;

		// Token: 0x0401461A RID: 83482
		[Token(Token = "0x401461A")]
		[FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0__GetAvailableCardList;

		// Token: 0x0401461B RID: 83483
		[Token(Token = "0x401461B")]
		[FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0_CheckConditionKey;

		// Token: 0x0401461C RID: 83484
		[Token(Token = "0x401461C")]
		[FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0_ModifyCondition;

		// Token: 0x0401461D RID: 83485
		[Token(Token = "0x401461D")]
		[FieldOffset(Offset = "0x318")]
		private static DelegateBridge __Hotfix0_CheckFavour;

		// Token: 0x0401461E RID: 83486
		[Token(Token = "0x401461E")]
		[FieldOffset(Offset = "0x320")]
		private static DelegateBridge __Hotfix0_AddFavour;

		// Token: 0x0401461F RID: 83487
		[Token(Token = "0x401461F")]
		[FieldOffset(Offset = "0x328")]
		private static DelegateBridge __Hotfix0_AddOutput;

		// Token: 0x04014620 RID: 83488
		[Token(Token = "0x4014620")]
		[FieldOffset(Offset = "0x330")]
		private static DelegateBridge __Hotfix0_MakeReactGacha;

		// Token: 0x04014621 RID: 83489
		[Token(Token = "0x4014621")]
		[FieldOffset(Offset = "0x338")]
		private static DelegateBridge __Hotfix0_AddOutputChoice;

		// Token: 0x04014622 RID: 83490
		[Token(Token = "0x4014622")]
		[FieldOffset(Offset = "0x340")]
		private static DelegateBridge __Hotfix0_GetFirstSignal;

		// Token: 0x04014623 RID: 83491
		[Token(Token = "0x4014623")]
		[FieldOffset(Offset = "0x348")]
		private static DelegateBridge __Hotfix0_GetNpcInputData;

		// Token: 0x04014624 RID: 83492
		[Token(Token = "0x4014624")]
		[FieldOffset(Offset = "0x350")]
		private static DelegateBridge __Hotfix0_SetNpcFinish;

		// Token: 0x04014625 RID: 83493
		[Token(Token = "0x4014625")]
		[FieldOffset(Offset = "0x358")]
		private static DelegateBridge __Hotfix0_OverrideRiftId;

		// Token: 0x04014626 RID: 83494
		[Token(Token = "0x4014626")]
		[FieldOffset(Offset = "0x360")]
		private static DelegateBridge __Hotfix0_SpawnReactNpcIfNot;

		// Token: 0x02002A5F RID: 10847
		[Token(Token = "0x2002A5F")]
		public class SandboxLevelProgressHelper : IHotfixable
		{
			// Token: 0x060120B3 RID: 73907 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60120B3")]
			[Address(RVA = "0xA33660", Offset = "0xA32260", VA = "0x180A33660")]
			public SandboxLevelProgressHelper()
			{
			}

			// Token: 0x060120B4 RID: 73908 RVA: 0x0006E5E0 File Offset: 0x0006C7E0
			[Token(Token = "0x60120B4")]
			[Address(RVA = "0xA32530", Offset = "0xA31130", VA = "0x180A32530")]
			public float GetCompleteProgress()
			{
				return 0f;
			}

			// Token: 0x060120B5 RID: 73909 RVA: 0x0006E5F8 File Offset: 0x0006C7F8
			[Token(Token = "0x60120B5")]
			[Address(RVA = "0xA32B30", Offset = "0xA31730", VA = "0x180A32B30")]
			private bool _CheckIdInCount(string id)
			{
				return default(bool);
			}

			// Token: 0x060120B6 RID: 73910 RVA: 0x0006E610 File Offset: 0x0006C810
			[Token(Token = "0x60120B6")]
			[Address(RVA = "0xA32C10", Offset = "0xA31810", VA = "0x180A32C10")]
			private FP _GetProgressByUnitId(Func<string, bool> isMatched)
			{
				return default(FP);
			}

			// Token: 0x060120B7 RID: 73911 RVA: 0x0006E628 File Offset: 0x0006C828
			[Token(Token = "0x60120B7")]
			[Address(RVA = "0xA327F0", Offset = "0xA313F0", VA = "0x180A327F0")]
			public bool IsLevelUnlockConditionComplete()
			{
				return default(bool);
			}

			// Token: 0x060120B8 RID: 73912 RVA: 0x0006E640 File Offset: 0x0006C840
			[Token(Token = "0x60120B8")]
			[Address(RVA = "0xA33460", Offset = "0xA32060", VA = "0x180A33460")]
			private bool _IsUnitIdAllDead(Func<string, bool> isMatched)
			{
				return default(bool);
			}

			// Token: 0x04014627 RID: 83495
			[Token(Token = "0x4014627")]
			[FieldOffset(Offset = "0x10")]
			private ListDict<SandboxEntityStatusKey, float> m_entityStatusCache;

			// Token: 0x04014628 RID: 83496
			[Token(Token = "0x4014628")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04014629 RID: 83497
			[Token(Token = "0x4014629")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetCompleteProgress;

			// Token: 0x0401462A RID: 83498
			[Token(Token = "0x401462A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__CheckIdInCount;

			// Token: 0x0401462B RID: 83499
			[Token(Token = "0x401462B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__GetProgressByUnitId;

			// Token: 0x0401462C RID: 83500
			[Token(Token = "0x401462C")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_IsLevelUnlockConditionComplete;

			// Token: 0x0401462D RID: 83501
			[Token(Token = "0x401462D")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__IsUnitIdAllDead;
		}

		// Token: 0x02002A61 RID: 10849
		[Token(Token = "0x2002A61")]
		public class LMultiEnemyKeyReplace : BasicLevelRune
		{
			// Token: 0x060120BE RID: 73918 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60120BE")]
			[Address(RVA = "0xA24890", Offset = "0xA23490", VA = "0x180A24890")]
			protected LMultiEnemyKeyReplace()
			{
			}

			// Token: 0x170027A0 RID: 10144
			// (get) Token: 0x060120BF RID: 73919 RVA: 0x0006E6B8 File Offset: 0x0006C8B8
			[Token(Token = "0x170027A0")]
			public override Rune.RuneTarget targetMask
			{
				[Token(Token = "0x60120BF")]
				[Address(RVA = "0xA24940", Offset = "0xA23540", VA = "0x180A24940", Slot = "5")]
				get
				{
					return Rune.RuneTarget.NONE;
				}
			}

			// Token: 0x060120C0 RID: 73920 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60120C0")]
			[Address(RVA = "0xA23F80", Offset = "0xA22B80", VA = "0x180A23F80", Slot = "8")]
			public override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
			{
			}

			// Token: 0x060120C1 RID: 73921 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60120C1")]
			[Address(RVA = "0xA244C0", Offset = "0xA230C0", VA = "0x180A244C0")]
			private void _ProcessEnemyReplace(LevelData levelData, SandboxV2Data configData, Dictionary<string, string> replaceKeys)
			{
			}

			// Token: 0x060120C2 RID: 73922 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60120C2")]
			[Address(RVA = "0xA241B0", Offset = "0xA22DB0", VA = "0x180A241B0")]
			private LevelData.EnemyDataDbReference _GetEnemyDataDbReference(SandboxV2Data configData, string enemyId)
			{
				return null;
			}

			// Token: 0x060120C3 RID: 73923 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60120C3")]
			[Address(RVA = "0xA24150", Offset = "0xA22D50", VA = "0x180A24150", Slot = "7")]
			public override void PreprocessLevelOptions(LevelData.Options options)
			{
			}

			// Token: 0x0401462F RID: 83503
			[Token(Token = "0x401462F")]
			private const float MIN_VIEW_RADIUS = 1.5f;

			// Token: 0x04014630 RID: 83504
			[Token(Token = "0x4014630")]
			[FieldOffset(Offset = "0x20")]
			private HashSet<string> m_replacedEnemyKeys;

			// Token: 0x04014631 RID: 83505
			[Token(Token = "0x4014631")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04014632 RID: 83506
			[Token(Token = "0x4014632")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_targetMask;

			// Token: 0x04014633 RID: 83507
			[Token(Token = "0x4014633")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_PreprocessLevelData;

			// Token: 0x04014634 RID: 83508
			[Token(Token = "0x4014634")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__ProcessEnemyReplace;

			// Token: 0x04014635 RID: 83509
			[Token(Token = "0x4014635")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__GetEnemyDataDbReference;

			// Token: 0x04014636 RID: 83510
			[Token(Token = "0x4014636")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_PreprocessLevelOptions;
		}
	}
}
