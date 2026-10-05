using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.Battle.Effects;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002333 RID: 9011
	[Token(Token = "0x2002333")]
	public class Mainline15PrtsManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x0600E3C1 RID: 58305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3C1")]
		[Address(RVA = "0x587780", Offset = "0x586380", VA = "0x180587780")]
		public void CreateBuffToPrts(BuffData buffData, Blackboard blackboard)
		{
		}

		// Token: 0x0600E3C2 RID: 58306 RVA: 0x00052638 File Offset: 0x00050838
		[Token(Token = "0x600E3C2")]
		[Address(RVA = "0x5887A0", Offset = "0x5873A0", VA = "0x1805887A0")]
		public bool SkipPrtsAction(Mainline15PrtsManager.PrtsActionType actionType)
		{
			return default(bool);
		}

		// Token: 0x0600E3C3 RID: 58307 RVA: 0x00052650 File Offset: 0x00050850
		[Token(Token = "0x600E3C3")]
		[Address(RVA = "0x587860", Offset = "0x586460", VA = "0x180587860")]
		public bool FilterCurrenSubAction(Mainline15PrtsManager.PrtsSubActionType actionType)
		{
			return default(bool);
		}

		// Token: 0x0600E3C4 RID: 58308 RVA: 0x00052668 File Offset: 0x00050868
		[Token(Token = "0x600E3C4")]
		[Address(RVA = "0x587950", Offset = "0x586550", VA = "0x180587950")]
		public bool FilterCurrentAction(Mainline15PrtsManager.PrtsActionType actionType)
		{
			return default(bool);
		}

		// Token: 0x0600E3C5 RID: 58309 RVA: 0x00052680 File Offset: 0x00050880
		[Token(Token = "0x600E3C5")]
		[Address(RVA = "0x588E00", Offset = "0x587A00", VA = "0x180588E00")]
		public bool TryNextSubAction(bool doNextWhenSuccess, bool forceNext)
		{
			return default(bool);
		}

		// Token: 0x0600E3C6 RID: 58310 RVA: 0x00052698 File Offset: 0x00050898
		[Token(Token = "0x600E3C6")]
		[Address(RVA = "0x5891E0", Offset = "0x587DE0", VA = "0x1805891E0")]
		public bool TryPickNextAction()
		{
			return default(bool);
		}

		// Token: 0x0600E3C7 RID: 58311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3C7")]
		[Address(RVA = "0x58B6C0", Offset = "0x58A2C0", VA = "0x18058B6C0")]
		private void _ParseMoveCreateBuffAction(Mainline15PrtsManager.PrtsAction action)
		{
		}

		// Token: 0x0600E3C8 RID: 58312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3C8")]
		[Address(RVA = "0x58B120", Offset = "0x589D20", VA = "0x18058B120")]
		private void _ParseMoveAndSpawnEnemyAction(Mainline15PrtsManager.PrtsAction action)
		{
		}

		// Token: 0x0600E3C9 RID: 58313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3C9")]
		[Address(RVA = "0x58AD50", Offset = "0x589950", VA = "0x18058AD50")]
		private void _ParseMoveAndDragSourceAction(Mainline15PrtsManager.PrtsAction action)
		{
		}

		// Token: 0x0600E3CA RID: 58314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3CA")]
		[Address(RVA = "0x58A360", Offset = "0x588F60", VA = "0x18058A360")]
		private void _OnActionStart(Mainline15PrtsManager.PrtsAction action)
		{
		}

		// Token: 0x0600E3CB RID: 58315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3CB")]
		[Address(RVA = "0x58A2F0", Offset = "0x588EF0", VA = "0x18058A2F0")]
		private void _OnActionFinish()
		{
		}

		// Token: 0x0600E3CC RID: 58316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3CC")]
		[Address(RVA = "0x58A9F0", Offset = "0x5895F0", VA = "0x18058A9F0")]
		private void _OnSubActionStartFailed()
		{
		}

		// Token: 0x0600E3CD RID: 58317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3CD")]
		[Address(RVA = "0x58A8A0", Offset = "0x5894A0", VA = "0x18058A8A0")]
		private void _OnPrtsFree()
		{
		}

		// Token: 0x0600E3CE RID: 58318 RVA: 0x000526B0 File Offset: 0x000508B0
		[Token(Token = "0x600E3CE")]
		[Address(RVA = "0x5894F0", Offset = "0x5880F0", VA = "0x1805894F0")]
		public bool TrySpawnEnemyOnMostSurround(Tile targetTile, int priority, string enemyKeyFly, string enemyKeyHL, string enemyKeyLL)
		{
			return default(bool);
		}

		// Token: 0x0600E3CF RID: 58319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3CF")]
		[Address(RVA = "0x588AA0", Offset = "0x5876A0", VA = "0x180588AA0")]
		public void TryMoveAndCreateBuff(int priority, Vector2 targetPos, BuffData buffData, Blackboard blackboard)
		{
		}

		// Token: 0x0600E3D0 RID: 58320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3D0")]
		[Address(RVA = "0x588C50", Offset = "0x587850", VA = "0x180588C50")]
		public void TryMoveAndDragSource(int priority, Entity source, Vector2 targetPos, BuffData buffData, Blackboard blackboard)
		{
		}

		// Token: 0x0600E3D1 RID: 58321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E3D1")]
		[Address(RVA = "0x587A40", Offset = "0x586640", VA = "0x180587A40")]
		public Tile FindMostCharacterSurroundTile()
		{
			return null;
		}

		// Token: 0x0600E3D2 RID: 58322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E3D2")]
		[Address(RVA = "0x587E40", Offset = "0x586A40", VA = "0x180587E40")]
		public Tile FindMostEnemySurroundTile()
		{
			return null;
		}

		// Token: 0x0600E3D3 RID: 58323 RVA: 0x000526C8 File Offset: 0x000508C8
		[Token(Token = "0x600E3D3")]
		[Address(RVA = "0x589A00", Offset = "0x588600", VA = "0x180589A00")]
		private bool _GetTileViaMaxDataMapFilter(Tile tile, bool excludeTileHasChar)
		{
			return default(bool);
		}

		// Token: 0x0600E3D4 RID: 58324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E3D4")]
		[Address(RVA = "0x589B60", Offset = "0x588760", VA = "0x180589B60")]
		private Tile _GetTileViaMaxDataMap(int[,] dataMap, bool excludeTileHasChar, bool excludeStartEnd = true)
		{
			return null;
		}

		// Token: 0x0600E3D5 RID: 58325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3D5")]
		[Address(RVA = "0x588250", Offset = "0x586E50", VA = "0x180588250", Slot = "7")]
		public override void Init(GlobalEnvSystem owner)
		{
		}

		// Token: 0x0600E3D6 RID: 58326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3D6")]
		[Address(RVA = "0x589FE0", Offset = "0x588BE0", VA = "0x180589FE0")]
		private void _InitPrtsHookedAction()
		{
		}

		// Token: 0x0600E3D7 RID: 58327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3D7")]
		[Address(RVA = "0x5884B0", Offset = "0x5870B0", VA = "0x1805884B0", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E3D8 RID: 58328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3D8")]
		[Address(RVA = "0x589870", Offset = "0x588470", VA = "0x180589870")]
		private void Update()
		{
		}

		// Token: 0x0600E3D9 RID: 58329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3D9")]
		[Address(RVA = "0x588710", Offset = "0x587310", VA = "0x180588710")]
		public void SetForceBattleSpeed(bool enable)
		{
		}

		// Token: 0x17001C8A RID: 7306
		// (get) Token: 0x0600E3DA RID: 58330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C8A")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E3DA")]
			[Address(RVA = "0x58BD80", Offset = "0x58A980", VA = "0x18058BD80", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E3DB RID: 58331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3DB")]
		[Address(RVA = "0x58AAA0", Offset = "0x5896A0", VA = "0x18058AAA0")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600E3DC RID: 58332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3DC")]
		[Address(RVA = "0x58A7B0", Offset = "0x5893B0", VA = "0x18058A7B0")]
		private void _OnGameOver(object arg)
		{
		}

		// Token: 0x0600E3DD RID: 58333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3DD")]
		[Address(RVA = "0x58A400", Offset = "0x589000", VA = "0x18058A400")]
		private void _OnBeforeLevelActionExecute(object arg)
		{
		}

		// Token: 0x0600E3DE RID: 58334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3DE")]
		[Address(RVA = "0x58BAF0", Offset = "0x58A6F0", VA = "0x18058BAF0")]
		public Mainline15PrtsManager()
		{
		}

		// Token: 0x0600E3E0 RID: 58336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3E0")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E3E1 RID: 58337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3E1")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600E3E2 RID: 58338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E3E2")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0400FA88 RID: 64136
		[Token(Token = "0x400FA88")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _prtsEnemyKey;

		// Token: 0x0400FA89 RID: 64137
		[Token(Token = "0x400FA89")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _prtsEnemyDragTileKey;

		// Token: 0x0400FA8A RID: 64138
		[Token(Token = "0x400FA8A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _prtsSpawnCheckDistance;

		// Token: 0x0400FA8B RID: 64139
		[Token(Token = "0x400FA8B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Mainline15PrtsManager.HighlandEnemyTrapPair[] _enemyTrapKeyPairs;

		// Token: 0x0400FA8C RID: 64140
		[Token(Token = "0x400FA8C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private BuffData _buffToPrtsWhenActionFinish;

		// Token: 0x0400FA8D RID: 64141
		[Token(Token = "0x400FA8D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BuffData _buffToPrtsWhenStartSubActionFailed;

		// Token: 0x0400FA8E RID: 64142
		[Token(Token = "0x400FA8E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string _effectOnDragTile;

		// Token: 0x0400FA8F RID: 64143
		[Token(Token = "0x400FA8F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _effectMarkDragTargetPos;

		// Token: 0x0400FA90 RID: 64144
		[Token(Token = "0x400FA90")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string _prtsErrorBattleEvent;

		// Token: 0x0400FA91 RID: 64145
		[Token(Token = "0x400FA91")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string _prtsErrorUIPlugin;

		// Token: 0x0400FA92 RID: 64146
		[Token(Token = "0x400FA92")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _prtsWriterInterval;

		// Token: 0x0400FA93 RID: 64147
		[Token(Token = "0x400FA93")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private int _prtsWriterMaxLine;

		// Token: 0x0400FA94 RID: 64148
		[Token(Token = "0x400FA94")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string EVENT_SYSTEM_KEY;

		// Token: 0x0400FA95 RID: 64149
		[Token(Token = "0x400FA95")]
		[FieldOffset(Offset = "0x80")]
		private Mainline15PrtsManager.EnemyPrts m_prts;

		// Token: 0x0400FA96 RID: 64150
		[Token(Token = "0x400FA96")]
		[FieldOffset(Offset = "0x88")]
		private bool m_forceBattleSpeed;

		// Token: 0x0400FA97 RID: 64151
		[Token(Token = "0x400FA97")]
		[FieldOffset(Offset = "0x8C")]
		private Vector2 m_prtsDragPos;

		// Token: 0x0400FA98 RID: 64152
		[Token(Token = "0x400FA98")]
		[FieldOffset(Offset = "0x98")]
		private HashSet<LevelData.ActionID> m_actionPrtsHooked;

		// Token: 0x0400FA99 RID: 64153
		[Token(Token = "0x400FA99")]
		[FieldOffset(Offset = "0xA0")]
		private Queue<Mainline15PrtsManager.PrtsSubAction> m_subActionsInDoing;

		// Token: 0x0400FA9A RID: 64154
		[Token(Token = "0x400FA9A")]
		[FieldOffset(Offset = "0xA8")]
		private PriorityQueue<Mainline15PrtsManager.PrtsAction> m_pendingPrtsActions;

		// Token: 0x0400FA9B RID: 64155
		[Token(Token = "0x400FA9B")]
		[FieldOffset(Offset = "0xB0")]
		private int[,] m_charCountMap;

		// Token: 0x0400FA9C RID: 64156
		[Token(Token = "0x400FA9C")]
		[FieldOffset(Offset = "0xB8")]
		private int[,] m_enemyCountMap;

		// Token: 0x0400FA9D RID: 64157
		[Token(Token = "0x400FA9D")]
		[FieldOffset(Offset = "0xC0")]
		private int m_mapHeight;

		// Token: 0x0400FA9E RID: 64158
		[Token(Token = "0x400FA9E")]
		[FieldOffset(Offset = "0xC4")]
		private int m_mapWidth;

		// Token: 0x0400FA9F RID: 64159
		[Token(Token = "0x400FA9F")]
		[FieldOffset(Offset = "0xC8")]
		private List<Tile> m_sharedTileResults;

		// Token: 0x0400FAA0 RID: 64160
		[Token(Token = "0x400FAA0")]
		[FieldOffset(Offset = "0xD0")]
		private Mainline15PrtsManager.PrtsErrorMetaController m_prtsErrorMetaController;

		// Token: 0x0400FAA1 RID: 64161
		[Token(Token = "0x400FAA1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateBuffToPrts;

		// Token: 0x0400FAA2 RID: 64162
		[Token(Token = "0x400FAA2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SkipPrtsAction;

		// Token: 0x0400FAA3 RID: 64163
		[Token(Token = "0x400FAA3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_FilterCurrenSubAction;

		// Token: 0x0400FAA4 RID: 64164
		[Token(Token = "0x400FAA4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_FilterCurrentAction;

		// Token: 0x0400FAA5 RID: 64165
		[Token(Token = "0x400FAA5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TryNextSubAction;

		// Token: 0x0400FAA6 RID: 64166
		[Token(Token = "0x400FAA6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TryPickNextAction;

		// Token: 0x0400FAA7 RID: 64167
		[Token(Token = "0x400FAA7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ParseMoveCreateBuffAction;

		// Token: 0x0400FAA8 RID: 64168
		[Token(Token = "0x400FAA8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ParseMoveAndSpawnEnemyAction;

		// Token: 0x0400FAA9 RID: 64169
		[Token(Token = "0x400FAA9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ParseMoveAndDragSourceAction;

		// Token: 0x0400FAAA RID: 64170
		[Token(Token = "0x400FAAA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnActionStart;

		// Token: 0x0400FAAB RID: 64171
		[Token(Token = "0x400FAAB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnActionFinish;

		// Token: 0x0400FAAC RID: 64172
		[Token(Token = "0x400FAAC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnSubActionStartFailed;

		// Token: 0x0400FAAD RID: 64173
		[Token(Token = "0x400FAAD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnPrtsFree;

		// Token: 0x0400FAAE RID: 64174
		[Token(Token = "0x400FAAE")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_TrySpawnEnemyOnMostSurround;

		// Token: 0x0400FAAF RID: 64175
		[Token(Token = "0x400FAAF")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_TryMoveAndCreateBuff;

		// Token: 0x0400FAB0 RID: 64176
		[Token(Token = "0x400FAB0")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_TryMoveAndDragSource;

		// Token: 0x0400FAB1 RID: 64177
		[Token(Token = "0x400FAB1")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_FindMostCharacterSurroundTile;

		// Token: 0x0400FAB2 RID: 64178
		[Token(Token = "0x400FAB2")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_FindMostEnemySurroundTile;

		// Token: 0x0400FAB3 RID: 64179
		[Token(Token = "0x400FAB3")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__GetTileViaMaxDataMapFilter;

		// Token: 0x0400FAB4 RID: 64180
		[Token(Token = "0x400FAB4")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__GetTileViaMaxDataMap;

		// Token: 0x0400FAB5 RID: 64181
		[Token(Token = "0x400FAB5")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400FAB6 RID: 64182
		[Token(Token = "0x400FAB6")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__InitPrtsHookedAction;

		// Token: 0x0400FAB7 RID: 64183
		[Token(Token = "0x400FAB7")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400FAB8 RID: 64184
		[Token(Token = "0x400FAB8")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400FAB9 RID: 64185
		[Token(Token = "0x400FAB9")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_SetForceBattleSpeed;

		// Token: 0x0400FABA RID: 64186
		[Token(Token = "0x400FABA")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400FABB RID: 64187
		[Token(Token = "0x400FABB")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0400FABC RID: 64188
		[Token(Token = "0x400FABC")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__OnGameOver;

		// Token: 0x0400FABD RID: 64189
		[Token(Token = "0x400FABD")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__OnBeforeLevelActionExecute;

		// Token: 0x0400FABE RID: 64190
		[Token(Token = "0x400FABE")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002334 RID: 9012
		[Token(Token = "0x2002334")]
		[Serializable]
		public class HighlandEnemyTrapPair
		{
			// Token: 0x0600E3E3 RID: 58339 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E3E3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public HighlandEnemyTrapPair()
			{
			}

			// Token: 0x0400FABF RID: 64191
			[Token(Token = "0x400FABF")]
			[FieldOffset(Offset = "0x10")]
			public TileData.HeightType tileHeightType;

			// Token: 0x0400FAC0 RID: 64192
			[Token(Token = "0x400FAC0")]
			[FieldOffset(Offset = "0x18")]
			public string enemyKey;

			// Token: 0x0400FAC1 RID: 64193
			[Token(Token = "0x400FAC1")]
			[FieldOffset(Offset = "0x20")]
			public SideType trapSide;

			// Token: 0x0400FAC2 RID: 64194
			[Token(Token = "0x400FAC2")]
			[FieldOffset(Offset = "0x28")]
			public AdvancedCharacterInst trapInst;
		}

		// Token: 0x02002335 RID: 9013
		[Token(Token = "0x2002335")]
		public class EnemyPrts : IHotfixable
		{
			// Token: 0x0600E3E4 RID: 58340 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E3E4")]
			[Address(RVA = "0x57F4F0", Offset = "0x57E0F0", VA = "0x18057F4F0")]
			public EnemyPrts(Enemy enemy, Mainline15PrtsManager.HighlandEnemyTrapPair[] enemyTrapKeyPairs)
			{
			}

			// Token: 0x0600E3E5 RID: 58341 RVA: 0x000526E0 File Offset: 0x000508E0
			[Token(Token = "0x600E3E5")]
			[Address(RVA = "0x57F340", Offset = "0x57DF40", VA = "0x18057F340")]
			public bool TracePosition(GridPosition targetPos, Vector2 offset)
			{
				return default(bool);
			}

			// Token: 0x0600E3E6 RID: 58342 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E3E6")]
			[Address(RVA = "0x57ECC0", Offset = "0x57D8C0", VA = "0x18057ECC0")]
			public void EnableDraggingEnemy(string enemyKey)
			{
			}

			// Token: 0x0600E3E7 RID: 58343 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600E3E7")]
			[Address(RVA = "0x57F260", Offset = "0x57DE60", VA = "0x18057F260")]
			public Mainline15PrtsManager.HighlandEnemyTrapPair GetHighlandEnemyTrapInfo(string enemyKey, TileData.HeightType heightType)
			{
				return null;
			}

			// Token: 0x0400FAC3 RID: 64195
			[Token(Token = "0x400FAC3")]
			[FieldOffset(Offset = "0x10")]
			public Enemy enemy;

			// Token: 0x0400FAC4 RID: 64196
			[Token(Token = "0x400FAC4")]
			[FieldOffset(Offset = "0x18")]
			private Dictionary<string, Enemy> m_draggingedEnemy;

			// Token: 0x0400FAC5 RID: 64197
			[Token(Token = "0x400FAC5")]
			[FieldOffset(Offset = "0x20")]
			private Enemy m_prtsDragging;

			// Token: 0x0400FAC6 RID: 64198
			[Token(Token = "0x400FAC6")]
			[FieldOffset(Offset = "0x28")]
			private GridPosition m_tracePosition;

			// Token: 0x0400FAC7 RID: 64199
			[Token(Token = "0x400FAC7")]
			[FieldOffset(Offset = "0x30")]
			private Mainline15PrtsManager.HighlandEnemyTrapPair[] m_enemyTrapKeyPairs;

			// Token: 0x0400FAC8 RID: 64200
			[Token(Token = "0x400FAC8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400FAC9 RID: 64201
			[Token(Token = "0x400FAC9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_TracePosition;

			// Token: 0x0400FACA RID: 64202
			[Token(Token = "0x400FACA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_EnableDraggingEnemy;

			// Token: 0x0400FACB RID: 64203
			[Token(Token = "0x400FACB")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetHighlandEnemyTrapInfo;
		}

		// Token: 0x02002336 RID: 9014
		[Token(Token = "0x2002336")]
		public enum PrtsActionType
		{
			// Token: 0x0400FACD RID: 64205
			[Token(Token = "0x400FACD")]
			MOVE_AND_SPAWNENEMY,
			// Token: 0x0400FACE RID: 64206
			[Token(Token = "0x400FACE")]
			MOVE_AND_CREATEBUFF,
			// Token: 0x0400FACF RID: 64207
			[Token(Token = "0x400FACF")]
			MOVE_AND_DRAG_SOURCE
		}

		// Token: 0x02002337 RID: 9015
		[Token(Token = "0x2002337")]
		public enum PrtsSubActionType
		{
			// Token: 0x0400FAD1 RID: 64209
			[Token(Token = "0x400FAD1")]
			MOVE_TO_ORIGIN,
			// Token: 0x0400FAD2 RID: 64210
			[Token(Token = "0x400FAD2")]
			MOVE_TO_DRAG,
			// Token: 0x0400FAD3 RID: 64211
			[Token(Token = "0x400FAD3")]
			DRAG,
			// Token: 0x0400FAD4 RID: 64212
			[Token(Token = "0x400FAD4")]
			SPAWN,
			// Token: 0x0400FAD5 RID: 64213
			[Token(Token = "0x400FAD5")]
			MOVE_TO_CREATE_BUFF,
			// Token: 0x0400FAD6 RID: 64214
			[Token(Token = "0x400FAD6")]
			CREATE_BUFF,
			// Token: 0x0400FAD7 RID: 64215
			[Token(Token = "0x400FAD7")]
			FOLLOW_BOSS
		}

		// Token: 0x02002338 RID: 9016
		[Token(Token = "0x2002338")]
		[Serializable]
		public struct PrtsAction : IComparable<Mainline15PrtsManager.PrtsAction>, IHotfixable
		{
			// Token: 0x0600E3E8 RID: 58344 RVA: 0x000526F8 File Offset: 0x000508F8
			[Token(Token = "0x600E3E8")]
			[Address(RVA = "0x594630", Offset = "0x593230", VA = "0x180594630", Slot = "4")]
			public int CompareTo(Mainline15PrtsManager.PrtsAction other)
			{
				return 0;
			}

			// Token: 0x0400FAD8 RID: 64216
			[Token(Token = "0x400FAD8")]
			[FieldOffset(Offset = "0x0")]
			public int priority;

			// Token: 0x0400FAD9 RID: 64217
			[Token(Token = "0x400FAD9")]
			[FieldOffset(Offset = "0x8")]
			public string key;

			// Token: 0x0400FADA RID: 64218
			[Token(Token = "0x400FADA")]
			[FieldOffset(Offset = "0x10")]
			public Route route;

			// Token: 0x0400FADB RID: 64219
			[Token(Token = "0x400FADB")]
			[FieldOffset(Offset = "0x18")]
			public Mainline15PrtsManager.PrtsActionType actionType;

			// Token: 0x0400FADC RID: 64220
			[Token(Token = "0x400FADC")]
			[FieldOffset(Offset = "0x1C")]
			public Vector2 targetPos;

			// Token: 0x0400FADD RID: 64221
			[Token(Token = "0x400FADD")]
			[FieldOffset(Offset = "0x28")]
			public BuffData buffData;

			// Token: 0x0400FADE RID: 64222
			[Token(Token = "0x400FADE")]
			[FieldOffset(Offset = "0x30")]
			public Entity source;

			// Token: 0x0400FADF RID: 64223
			[Token(Token = "0x400FADF")]
			[FieldOffset(Offset = "0x38")]
			public Blackboard blackboard;

			// Token: 0x0400FAE0 RID: 64224
			[Token(Token = "0x400FAE0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CompareTo;
		}

		// Token: 0x02002339 RID: 9017
		[Token(Token = "0x2002339")]
		public interface PrtsSubAction : IHotfixable
		{
			// Token: 0x17001C8B RID: 7307
			// (get) Token: 0x0600E3E9 RID: 58345
			[Token(Token = "0x17001C8B")]
			Mainline15PrtsManager.PrtsActionType actionType { [Token(Token = "0x600E3E9")] get; }

			// Token: 0x17001C8C RID: 7308
			// (get) Token: 0x0600E3EA RID: 58346
			[Token(Token = "0x17001C8C")]
			Mainline15PrtsManager.PrtsSubActionType subActionType { [Token(Token = "0x600E3EA")] get; }

			// Token: 0x0600E3EB RID: 58347
			[Token(Token = "0x600E3EB")]
			bool CheckSuccess(Mainline15PrtsManager.EnemyPrts prts);

			// Token: 0x0600E3EC RID: 58348
			[Token(Token = "0x600E3EC")]
			bool StartAction(Mainline15PrtsManager.EnemyPrts prts);

			// Token: 0x0600E3ED RID: 58349
			[Token(Token = "0x600E3ED")]
			bool FinishAction(Mainline15PrtsManager.EnemyPrts prts);
		}

		// Token: 0x0200233A RID: 9018
		[Token(Token = "0x200233A")]
		public struct PrtsSpawnEnemyAction : Mainline15PrtsManager.PrtsSubAction, IHotfixable
		{
			// Token: 0x17001C8D RID: 7309
			// (get) Token: 0x0600E3EE RID: 58350 RVA: 0x00052710 File Offset: 0x00050910
			// (set) Token: 0x0600E3EF RID: 58351 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001C8D")]
			public Mainline15PrtsManager.PrtsActionType actionType
			{
				[Token(Token = "0x600E3EE")]
				[Address(RVA = "0x5965A0", Offset = "0x5951A0", VA = "0x1805965A0", Slot = "4")]
				[CompilerGenerated]
				readonly get
				{
					return Mainline15PrtsManager.PrtsActionType.MOVE_AND_SPAWNENEMY;
				}
				[Token(Token = "0x600E3EF")]
				[Address(RVA = "0x596680", Offset = "0x595280", VA = "0x180596680")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17001C8E RID: 7310
			// (get) Token: 0x0600E3F0 RID: 58352 RVA: 0x00052728 File Offset: 0x00050928
			// (set) Token: 0x0600E3F1 RID: 58353 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001C8E")]
			public Mainline15PrtsManager.PrtsSubActionType subActionType
			{
				[Token(Token = "0x600E3F0")]
				[Address(RVA = "0x596610", Offset = "0x595210", VA = "0x180596610", Slot = "5")]
				[CompilerGenerated]
				readonly get
				{
					return Mainline15PrtsManager.PrtsSubActionType.MOVE_TO_ORIGIN;
				}
				[Token(Token = "0x600E3F1")]
				[Address(RVA = "0x596700", Offset = "0x595300", VA = "0x180596700")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0600E3F2 RID: 58354 RVA: 0x00052740 File Offset: 0x00050940
			[Token(Token = "0x600E3F2")]
			[Address(RVA = "0x595E10", Offset = "0x594A10", VA = "0x180595E10", Slot = "6")]
			public bool CheckSuccess(Mainline15PrtsManager.EnemyPrts prts)
			{
				return default(bool);
			}

			// Token: 0x0600E3F3 RID: 58355 RVA: 0x00052758 File Offset: 0x00050958
			[Token(Token = "0x600E3F3")]
			[Address(RVA = "0x596460", Offset = "0x595060", VA = "0x180596460")]
			private bool _CheckSpawnEnemyTileValid(Tile tile)
			{
				return default(bool);
			}

			// Token: 0x0600E3F4 RID: 58356 RVA: 0x00052770 File Offset: 0x00050970
			[Token(Token = "0x600E3F4")]
			[Address(RVA = "0x595F10", Offset = "0x594B10", VA = "0x180595F10", Slot = "7")]
			public bool StartAction(Mainline15PrtsManager.EnemyPrts prts)
			{
				return default(bool);
			}

			// Token: 0x0600E3F5 RID: 58357 RVA: 0x00052788 File Offset: 0x00050988
			[Token(Token = "0x600E3F5")]
			[Address(RVA = "0x595E90", Offset = "0x594A90", VA = "0x180595E90", Slot = "8")]
			public bool FinishAction(Mainline15PrtsManager.EnemyPrts prts)
			{
				return default(bool);
			}

			// Token: 0x0400FAE3 RID: 64227
			[Token(Token = "0x400FAE3")]
			[FieldOffset(Offset = "0x8")]
			public string enemyKey;

			// Token: 0x0400FAE4 RID: 64228
			[Token(Token = "0x400FAE4")]
			[FieldOffset(Offset = "0x10")]
			public GridPosition targetPos;

			// Token: 0x0400FAE5 RID: 64229
			[Token(Token = "0x400FAE5")]
			[FieldOffset(Offset = "0x18")]
			public Route route;

			// Token: 0x0400FAE6 RID: 64230
			[Token(Token = "0x400FAE6")]
			private const string SPAWN_AUDIO_ENEMY = "prts_spawn_enemy";

			// Token: 0x0400FAE7 RID: 64231
			[Token(Token = "0x400FAE7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_actionType;

			// Token: 0x0400FAE8 RID: 64232
			[Token(Token = "0x400FAE8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_actionType;

			// Token: 0x0400FAE9 RID: 64233
			[Token(Token = "0x400FAE9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_subActionType;

			// Token: 0x0400FAEA RID: 64234
			[Token(Token = "0x400FAEA")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_subActionType;

			// Token: 0x0400FAEB RID: 64235
			[Token(Token = "0x400FAEB")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_CheckSuccess;

			// Token: 0x0400FAEC RID: 64236
			[Token(Token = "0x400FAEC")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__CheckSpawnEnemyTileValid;

			// Token: 0x0400FAED RID: 64237
			[Token(Token = "0x400FAED")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_StartAction;

			// Token: 0x0400FAEE RID: 64238
			[Token(Token = "0x400FAEE")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_FinishAction;
		}

		// Token: 0x0200233B RID: 9019
		[Token(Token = "0x200233B")]
		public struct PrtsCreateBuffAction : Mainline15PrtsManager.PrtsSubAction, IHotfixable
		{
			// Token: 0x17001C8F RID: 7311
			// (get) Token: 0x0600E3F6 RID: 58358 RVA: 0x000527A0 File Offset: 0x000509A0
			// (set) Token: 0x0600E3F7 RID: 58359 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001C8F")]
			public Mainline15PrtsManager.PrtsActionType actionType
			{
				[Token(Token = "0x600E3F6")]
				[Address(RVA = "0x5948E0", Offset = "0x5934E0", VA = "0x1805948E0", Slot = "4")]
				[CompilerGenerated]
				readonly get
				{
					return Mainline15PrtsManager.PrtsActionType.MOVE_AND_SPAWNENEMY;
				}
				[Token(Token = "0x600E3F7")]
				[Address(RVA = "0x5949C0", Offset = "0x5935C0", VA = "0x1805949C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17001C90 RID: 7312
			// (get) Token: 0x0600E3F8 RID: 58360 RVA: 0x000527B8 File Offset: 0x000509B8
			// (set) Token: 0x0600E3F9 RID: 58361 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001C90")]
			public Mainline15PrtsManager.PrtsSubActionType subActionType
			{
				[Token(Token = "0x600E3F8")]
				[Address(RVA = "0x594950", Offset = "0x593550", VA = "0x180594950", Slot = "5")]
				[CompilerGenerated]
				readonly get
				{
					return Mainline15PrtsManager.PrtsSubActionType.MOVE_TO_ORIGIN;
				}
				[Token(Token = "0x600E3F9")]
				[Address(RVA = "0x594A40", Offset = "0x593640", VA = "0x180594A40")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0600E3FA RID: 58362 RVA: 0x000527D0 File Offset: 0x000509D0
			[Token(Token = "0x600E3FA")]
			[Address(RVA = "0x594710", Offset = "0x593310", VA = "0x180594710", Slot = "6")]
			public bool CheckSuccess(Mainline15PrtsManager.EnemyPrts prts)
			{
				return default(bool);
			}

			// Token: 0x0600E3FB RID: 58363 RVA: 0x000527E8 File Offset: 0x000509E8
			[Token(Token = "0x600E3FB")]
			[Address(RVA = "0x594810", Offset = "0x593410", VA = "0x180594810", Slot = "7")]
			public bool StartAction(Mainline15PrtsManager.EnemyPrts prts)
			{
				return default(bool);
			}

			// Token: 0x0600E3FC RID: 58364 RVA: 0x00052800 File Offset: 0x00050A00
			[Token(Token = "0x600E3FC")]
			[Address(RVA = "0x594790", Offset = "0x593390", VA = "0x180594790", Slot = "8")]
			public bool FinishAction(Mainline15PrtsManager.EnemyPrts prts)
			{
				return default(bool);
			}

			// Token: 0x0400FAF1 RID: 64241
			[Token(Token = "0x400FAF1")]
			[FieldOffset(Offset = "0x8")]
			public BuffData buffData;

			// Token: 0x0400FAF2 RID: 64242
			[Token(Token = "0x400FAF2")]
			[FieldOffset(Offset = "0x10")]
			public Blackboard blackboard;

			// Token: 0x0400FAF3 RID: 64243
			[Token(Token = "0x400FAF3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_actionType;

			// Token: 0x0400FAF4 RID: 64244
			[Token(Token = "0x400FAF4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_actionType;

			// Token: 0x0400FAF5 RID: 64245
			[Token(Token = "0x400FAF5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_subActionType;

			// Token: 0x0400FAF6 RID: 64246
			[Token(Token = "0x400FAF6")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_subActionType;

			// Token: 0x0400FAF7 RID: 64247
			[Token(Token = "0x400FAF7")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_CheckSuccess;

			// Token: 0x0400FAF8 RID: 64248
			[Token(Token = "0x400FAF8")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_StartAction;

			// Token: 0x0400FAF9 RID: 64249
			[Token(Token = "0x400FAF9")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_FinishAction;
		}

		// Token: 0x0200233C RID: 9020
		[Token(Token = "0x200233C")]
		public struct PrtsMoveSubAction : Mainline15PrtsManager.PrtsSubAction, IHotfixable
		{
			// Token: 0x17001C91 RID: 7313
			// (get) Token: 0x0600E3FD RID: 58365 RVA: 0x00052818 File Offset: 0x00050A18
			// (set) Token: 0x0600E3FE RID: 58366 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001C91")]
			public Mainline15PrtsManager.PrtsActionType actionType
			{
				[Token(Token = "0x600E3FD")]
				[Address(RVA = "0x595C00", Offset = "0x594800", VA = "0x180595C00", Slot = "4")]
				[CompilerGenerated]
				readonly get
				{
					return Mainline15PrtsManager.PrtsActionType.MOVE_AND_SPAWNENEMY;
				}
				[Token(Token = "0x600E3FE")]
				[Address(RVA = "0x595CF0", Offset = "0x5948F0", VA = "0x180595CF0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17001C92 RID: 7314
			// (get) Token: 0x0600E3FF RID: 58367 RVA: 0x00052830 File Offset: 0x00050A30
			// (set) Token: 0x0600E400 RID: 58368 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001C92")]
			public Mainline15PrtsManager.PrtsSubActionType subActionType
			{
				[Token(Token = "0x600E3FF")]
				[Address(RVA = "0x595C70", Offset = "0x594870", VA = "0x180595C70", Slot = "5")]
				[CompilerGenerated]
				readonly get
				{
					return Mainline15PrtsManager.PrtsSubActionType.MOVE_TO_ORIGIN;
				}
				[Token(Token = "0x600E400")]
				[Address(RVA = "0x595D80", Offset = "0x594980", VA = "0x180595D80")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0600E401 RID: 58369 RVA: 0x00052848 File Offset: 0x00050A48
			[Token(Token = "0x600E401")]
			[Address(RVA = "0x595820", Offset = "0x594420", VA = "0x180595820", Slot = "6")]
			public bool CheckSuccess(Mainline15PrtsManager.EnemyPrts prts)
			{
				return default(bool);
			}

			// Token: 0x0600E402 RID: 58370 RVA: 0x00052860 File Offset: 0x00050A60
			[Token(Token = "0x600E402")]
			[Address(RVA = "0x5959F0", Offset = "0x5945F0", VA = "0x1805959F0", Slot = "7")]
			public bool StartAction(Mainline15PrtsManager.EnemyPrts prts)
			{
				return default(bool);
			}

			// Token: 0x0600E403 RID: 58371 RVA: 0x00052878 File Offset: 0x00050A78
			[Token(Token = "0x600E403")]
			[Address(RVA = "0x5958E0", Offset = "0x5944E0", VA = "0x1805958E0", Slot = "8")]
			public bool FinishAction(Mainline15PrtsManager.EnemyPrts prts)
			{
				return default(bool);
			}

			// Token: 0x0400FAFC RID: 64252
			[Token(Token = "0x400FAFC")]
			[FieldOffset(Offset = "0x8")]
			public Vector2 targetPos;

			// Token: 0x0400FAFD RID: 64253
			[Token(Token = "0x400FAFD")]
			[FieldOffset(Offset = "0x10")]
			public string targetPosEffect;

			// Token: 0x0400FAFE RID: 64254
			[Token(Token = "0x400FAFE")]
			[FieldOffset(Offset = "0x18")]
			public float checkDist;

			// Token: 0x0400FAFF RID: 64255
			[Token(Token = "0x400FAFF")]
			[FieldOffset(Offset = "0x20")]
			public string draggingKey;

			// Token: 0x0400FB00 RID: 64256
			[Token(Token = "0x400FB00")]
			[FieldOffset(Offset = "0x28")]
			private Effect m_targetPosEffect;

			// Token: 0x0400FB01 RID: 64257
			[Token(Token = "0x400FB01")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_actionType;

			// Token: 0x0400FB02 RID: 64258
			[Token(Token = "0x400FB02")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_actionType;

			// Token: 0x0400FB03 RID: 64259
			[Token(Token = "0x400FB03")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_subActionType;

			// Token: 0x0400FB04 RID: 64260
			[Token(Token = "0x400FB04")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_subActionType;

			// Token: 0x0400FB05 RID: 64261
			[Token(Token = "0x400FB05")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_CheckSuccess;

			// Token: 0x0400FB06 RID: 64262
			[Token(Token = "0x400FB06")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_StartAction;

			// Token: 0x0400FB07 RID: 64263
			[Token(Token = "0x400FB07")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_FinishAction;
		}

		// Token: 0x0200233D RID: 9021
		[Token(Token = "0x200233D")]
		public struct PrtsDragSourceSubAction : Mainline15PrtsManager.PrtsSubAction, IHotfixable
		{
			// Token: 0x17001C93 RID: 7315
			// (get) Token: 0x0600E404 RID: 58372 RVA: 0x00052890 File Offset: 0x00050A90
			// (set) Token: 0x0600E405 RID: 58373 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001C93")]
			public Mainline15PrtsManager.PrtsActionType actionType
			{
				[Token(Token = "0x600E404")]
				[Address(RVA = "0x594DB0", Offset = "0x5939B0", VA = "0x180594DB0", Slot = "4")]
				[CompilerGenerated]
				readonly get
				{
					return Mainline15PrtsManager.PrtsActionType.MOVE_AND_SPAWNENEMY;
				}
				[Token(Token = "0x600E405")]
				[Address(RVA = "0x594E90", Offset = "0x593A90", VA = "0x180594E90")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17001C94 RID: 7316
			// (get) Token: 0x0600E406 RID: 58374 RVA: 0x000528A8 File Offset: 0x00050AA8
			// (set) Token: 0x0600E407 RID: 58375 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001C94")]
			public Mainline15PrtsManager.PrtsSubActionType subActionType
			{
				[Token(Token = "0x600E406")]
				[Address(RVA = "0x594E20", Offset = "0x593A20", VA = "0x180594E20", Slot = "5")]
				[CompilerGenerated]
				readonly get
				{
					return Mainline15PrtsManager.PrtsSubActionType.MOVE_TO_ORIGIN;
				}
				[Token(Token = "0x600E407")]
				[Address(RVA = "0x594F10", Offset = "0x593B10", VA = "0x180594F10")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0600E408 RID: 58376 RVA: 0x000528C0 File Offset: 0x00050AC0
			[Token(Token = "0x600E408")]
			[Address(RVA = "0x594AC0", Offset = "0x5936C0", VA = "0x180594AC0", Slot = "6")]
			public bool CheckSuccess(Mainline15PrtsManager.EnemyPrts prts)
			{
				return default(bool);
			}

			// Token: 0x0600E409 RID: 58377 RVA: 0x000528D8 File Offset: 0x00050AD8
			[Token(Token = "0x600E409")]
			[Address(RVA = "0x594C70", Offset = "0x593870", VA = "0x180594C70", Slot = "7")]
			public bool StartAction(Mainline15PrtsManager.EnemyPrts prts)
			{
				return default(bool);
			}

			// Token: 0x0600E40A RID: 58378 RVA: 0x000528F0 File Offset: 0x00050AF0
			[Token(Token = "0x600E40A")]
			[Address(RVA = "0x594BF0", Offset = "0x5937F0", VA = "0x180594BF0", Slot = "8")]
			public bool FinishAction(Mainline15PrtsManager.EnemyPrts prts)
			{
				return default(bool);
			}

			// Token: 0x0400FB0A RID: 64266
			[Token(Token = "0x400FB0A")]
			[FieldOffset(Offset = "0x8")]
			public Entity source;

			// Token: 0x0400FB0B RID: 64267
			[Token(Token = "0x400FB0B")]
			[FieldOffset(Offset = "0x10")]
			public BuffData buffData;

			// Token: 0x0400FB0C RID: 64268
			[Token(Token = "0x400FB0C")]
			[FieldOffset(Offset = "0x18")]
			public Blackboard blackboard;

			// Token: 0x0400FB0D RID: 64269
			[Token(Token = "0x400FB0D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_actionType;

			// Token: 0x0400FB0E RID: 64270
			[Token(Token = "0x400FB0E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_actionType;

			// Token: 0x0400FB0F RID: 64271
			[Token(Token = "0x400FB0F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_subActionType;

			// Token: 0x0400FB10 RID: 64272
			[Token(Token = "0x400FB10")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_subActionType;

			// Token: 0x0400FB11 RID: 64273
			[Token(Token = "0x400FB11")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_CheckSuccess;

			// Token: 0x0400FB12 RID: 64274
			[Token(Token = "0x400FB12")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_StartAction;

			// Token: 0x0400FB13 RID: 64275
			[Token(Token = "0x400FB13")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_FinishAction;
		}

		// Token: 0x0200233E RID: 9022
		[Token(Token = "0x200233E")]
		private class PrtsErrorMetaController
		{
			// Token: 0x0600E40B RID: 58379 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E40B")]
			[Address(RVA = "0x594F90", Offset = "0x593B90", VA = "0x180594F90")]
			public void Init(string prtsErrorUIPlugin, float prtsWriterInterval, int _prtsWriterMaxLine)
			{
			}

			// Token: 0x0600E40C RID: 58380 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E40C")]
			[Address(RVA = "0x5954D0", Offset = "0x5940D0", VA = "0x1805954D0")]
			public void OnTick(FP deltaTime)
			{
			}

			// Token: 0x0600E40D RID: 58381 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E40D")]
			[Address(RVA = "0x5955F0", Offset = "0x5941F0", VA = "0x1805955F0")]
			private void _DoPrtsMetaErrorMsg()
			{
			}

			// Token: 0x0600E40E RID: 58382 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E40E")]
			[Address(RVA = "0x595790", Offset = "0x594390", VA = "0x180595790")]
			private void _OnPrtsMetaErrorMsgShowedLine()
			{
			}

			// Token: 0x0600E40F RID: 58383 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E40F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PrtsErrorMetaController()
			{
			}

			// Token: 0x0400FB14 RID: 64276
			[Token(Token = "0x400FB14")]
			[FieldOffset(Offset = "0x10")]
			private AVGTypeWriterText m_prtsErrorWriter;

			// Token: 0x0400FB15 RID: 64277
			[Token(Token = "0x400FB15")]
			[FieldOffset(Offset = "0x18")]
			private List<string> m_prtsErrorMsg;

			// Token: 0x0400FB16 RID: 64278
			[Token(Token = "0x400FB16")]
			[FieldOffset(Offset = "0x20")]
			private Queue<string> m_prtsErrorMsgShowed;

			// Token: 0x0400FB17 RID: 64279
			[Token(Token = "0x400FB17")]
			[FieldOffset(Offset = "0x28")]
			private int m_prtsErrorMsgIndex;

			// Token: 0x0400FB18 RID: 64280
			[Token(Token = "0x400FB18")]
			[FieldOffset(Offset = "0x2C")]
			private float m_interval;

			// Token: 0x0400FB19 RID: 64281
			[Token(Token = "0x400FB19")]
			[FieldOffset(Offset = "0x30")]
			private PeriodicTimer m_timer;

			// Token: 0x0400FB1A RID: 64282
			[Token(Token = "0x400FB1A")]
			[FieldOffset(Offset = "0x38")]
			private int m_line;

			// Token: 0x0400FB1B RID: 64283
			[Token(Token = "0x400FB1B")]
			[FieldOffset(Offset = "0x3C")]
			private int m_Maxline;

			// Token: 0x0400FB1C RID: 64284
			[Token(Token = "0x400FB1C")]
			[FieldOffset(Offset = "0x40")]
			public UILifePoint m_lifePoint;
		}
	}
}
