using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.AVG;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002217 RID: 8727
	[Token(Token = "0x2002217")]
	public class BattlePluginExternalHost : IBattleModule, IHotfixable
	{
		// Token: 0x0600DBB8 RID: 56248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBB8")]
		[Address(RVA = "0x3615920", Offset = "0x3614520", VA = "0x183615920", Slot = "5")]
		public void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x0600DBB9 RID: 56249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBB9")]
		[Address(RVA = "0x3615AD0", Offset = "0x36146D0", VA = "0x183615AD0", Slot = "8")]
		public void OnGameOver(BattleController.GameResult result)
		{
		}

		// Token: 0x0600DBBA RID: 56250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBBA")]
		[Address(RVA = "0x3615BE0", Offset = "0x36147E0", VA = "0x183615BE0", Slot = "4")]
		public void OnGameReset(BattleController controller)
		{
		}

		// Token: 0x0600DBBB RID: 56251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBBB")]
		[Address(RVA = "0x3615B80", Offset = "0x3614780", VA = "0x183615B80", Slot = "6")]
		public void OnGameReady()
		{
		}

		// Token: 0x0600DBBC RID: 56252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBBC")]
		[Address(RVA = "0x3615C40", Offset = "0x3614840", VA = "0x183615C40", Slot = "7")]
		public void OnGameStart()
		{
		}

		// Token: 0x0600DBBD RID: 56253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBBD")]
		[Address(RVA = "0x3615CA0", Offset = "0x36148A0", VA = "0x183615CA0")]
		public BattlePluginExternalHost()
		{
		}

		// Token: 0x0400EDD6 RID: 60886
		[Token(Token = "0x400EDD6")]
		[FieldOffset(Offset = "0x10")]
		private BattlePluginExternalHost.BattleTutorialCommandPostChecker m_checker;

		// Token: 0x0400EDD7 RID: 60887
		[Token(Token = "0x400EDD7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x0400EDD8 RID: 60888
		[Token(Token = "0x400EDD8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnGameOver;

		// Token: 0x0400EDD9 RID: 60889
		[Token(Token = "0x400EDD9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnGameReset;

		// Token: 0x0400EDDA RID: 60890
		[Token(Token = "0x400EDDA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnGameReady;

		// Token: 0x0400EDDB RID: 60891
		[Token(Token = "0x400EDDB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnGameStart;

		// Token: 0x0400EDDC RID: 60892
		[Token(Token = "0x400EDDC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002218 RID: 8728
		[Token(Token = "0x2002218")]
		private class BattleTutorialCommandPostChecker : ICommandPostChecker, IHotfixable
		{
			// Token: 0x0600DBBE RID: 56254 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600DBBE")]
			[Address(RVA = "0x3618DF0", Offset = "0x36179F0", VA = "0x183618DF0")]
			private Dictionary<string, Action<Command>> GenPostCheckers()
			{
				return null;
			}

			// Token: 0x17001BA7 RID: 7079
			// (get) Token: 0x0600DBBF RID: 56255 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600DBC0 RID: 56256 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001BA7")]
			public AVGTutorialPanel panel
			{
				[Token(Token = "0x600DBBF")]
				[Address(RVA = "0x361A400", Offset = "0x3619000", VA = "0x18361A400")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600DBC0")]
				[Address(RVA = "0x361A460", Offset = "0x3619060", VA = "0x18361A460")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0600DBC1 RID: 56257 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBC1")]
			[Address(RVA = "0x36195A0", Offset = "0x36181A0", VA = "0x1836195A0")]
			private void _PostCharacterInfo(Command command)
			{
			}

			// Token: 0x0600DBC2 RID: 56258 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBC2")]
			[Address(RVA = "0x3619F70", Offset = "0x3618B70", VA = "0x183619F70")]
			private void _PostPutDown(Command command)
			{
			}

			// Token: 0x0600DBC3 RID: 56259 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBC3")]
			[Address(RVA = "0x3619D90", Offset = "0x3618990", VA = "0x183619D90")]
			private void _PostPutDownPosCheck(Command command)
			{
			}

			// Token: 0x0600DBC4 RID: 56260 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBC4")]
			[Address(RVA = "0x3619B60", Offset = "0x3618760", VA = "0x183619B60")]
			private void _PostPutDownCharIdCheck(Command command)
			{
			}

			// Token: 0x0600DBC5 RID: 56261 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBC5")]
			[Address(RVA = "0x3618CF0", Offset = "0x36178F0", VA = "0x183618CF0")]
			private void AppendTileBuildableChecker(ITileBuildableChecker buildableChecker)
			{
			}

			// Token: 0x0600DBC6 RID: 56262 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBC6")]
			[Address(RVA = "0x3619460", Offset = "0x3618060", VA = "0x183619460")]
			private void RemoveTileBuildableChecker()
			{
			}

			// Token: 0x0600DBC7 RID: 56263 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBC7")]
			[Address(RVA = "0x361A080", Offset = "0x3618C80", VA = "0x18361A080")]
			private void _PostUseSkill(Command command)
			{
			}

			// Token: 0x0600DBC8 RID: 56264 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBC8")]
			[Address(RVA = "0x3619890", Offset = "0x3618490", VA = "0x183619890")]
			private void _PostExitCharacterMenu(Command command)
			{
			}

			// Token: 0x0600DBC9 RID: 56265 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBC9")]
			[Address(RVA = "0x3619120", Offset = "0x3617D20", VA = "0x183619120")]
			private void OnPostCheckDelayFallback()
			{
			}

			// Token: 0x17001BA8 RID: 7080
			// (get) Token: 0x0600DBCA RID: 56266 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001BA8")]
			public string cmdName
			{
				[Token(Token = "0x600DBCA")]
				[Address(RVA = "0x361A390", Offset = "0x3618F90", VA = "0x18361A390", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600DBCB RID: 56267 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBCB")]
			[Address(RVA = "0x3619320", Offset = "0x3617F20", VA = "0x183619320", Slot = "5")]
			public void PostCheck(bool isTutorial, Command command)
			{
			}

			// Token: 0x0600DBCC RID: 56268 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBCC")]
			[Address(RVA = "0x3619090", Offset = "0x3617C90", VA = "0x183619090", Slot = "6")]
			public void OnCommandFinished(bool isTutorial, Command command)
			{
			}

			// Token: 0x0600DBCD RID: 56269 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBCD")]
			[Address(RVA = "0x36192A0", Offset = "0x3617EA0", VA = "0x1836192A0", Slot = "7")]
			public void OnStorySkipped(bool isTutorial)
			{
			}

			// Token: 0x0600DBCE RID: 56270 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBCE")]
			[Address(RVA = "0x361A330", Offset = "0x3618F30", VA = "0x18361A330")]
			public BattleTutorialCommandPostChecker()
			{
			}

			// Token: 0x0400EDDD RID: 60893
			[Token(Token = "0x400EDDD")]
			[FieldOffset(Offset = "0x10")]
			private Dictionary<string, Action<Command>> m_postSignalCheckers;

			// Token: 0x0400EDDF RID: 60895
			[Token(Token = "0x400EDDF")]
			[FieldOffset(Offset = "0x20")]
			private ITileBuildableChecker m_tileBuildableCheckerForPutDown;

			// Token: 0x0400EDE0 RID: 60896
			[Token(Token = "0x400EDE0")]
			private const float DEFAULT_DELAY = 3f;

			// Token: 0x0400EDE1 RID: 60897
			[Token(Token = "0x400EDE1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GenPostCheckers;

			// Token: 0x0400EDE2 RID: 60898
			[Token(Token = "0x400EDE2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_panel;

			// Token: 0x0400EDE3 RID: 60899
			[Token(Token = "0x400EDE3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_panel;

			// Token: 0x0400EDE4 RID: 60900
			[Token(Token = "0x400EDE4")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__PostCharacterInfo;

			// Token: 0x0400EDE5 RID: 60901
			[Token(Token = "0x400EDE5")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__PostPutDown;

			// Token: 0x0400EDE6 RID: 60902
			[Token(Token = "0x400EDE6")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__PostPutDownPosCheck;

			// Token: 0x0400EDE7 RID: 60903
			[Token(Token = "0x400EDE7")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__PostPutDownCharIdCheck;

			// Token: 0x0400EDE8 RID: 60904
			[Token(Token = "0x400EDE8")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_AppendTileBuildableChecker;

			// Token: 0x0400EDE9 RID: 60905
			[Token(Token = "0x400EDE9")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_RemoveTileBuildableChecker;

			// Token: 0x0400EDEA RID: 60906
			[Token(Token = "0x400EDEA")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0__PostUseSkill;

			// Token: 0x0400EDEB RID: 60907
			[Token(Token = "0x400EDEB")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0__PostExitCharacterMenu;

			// Token: 0x0400EDEC RID: 60908
			[Token(Token = "0x400EDEC")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_OnPostCheckDelayFallback;

			// Token: 0x0400EDED RID: 60909
			[Token(Token = "0x400EDED")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_get_cmdName;

			// Token: 0x0400EDEE RID: 60910
			[Token(Token = "0x400EDEE")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_PostCheck;

			// Token: 0x0400EDEF RID: 60911
			[Token(Token = "0x400EDEF")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_OnCommandFinished;

			// Token: 0x0400EDF0 RID: 60912
			[Token(Token = "0x400EDF0")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_OnStorySkipped;

			// Token: 0x0400EDF1 RID: 60913
			[Token(Token = "0x400EDF1")]
			[FieldOffset(Offset = "0x80")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
