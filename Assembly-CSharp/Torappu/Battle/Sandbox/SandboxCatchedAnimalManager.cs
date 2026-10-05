using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A56 RID: 10838
	[Token(Token = "0x2002A56")]
	public class SandboxCatchedAnimalManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x17002788 RID: 10120
		// (get) Token: 0x06011FD1 RID: 73681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002788")]
		public SandboxInput input
		{
			[Token(Token = "0x6011FD1")]
			[Address(RVA = "0xA1C4A0", Offset = "0xA1B0A0", VA = "0x180A1C4A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002789 RID: 10121
		// (get) Token: 0x06011FD2 RID: 73682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002789")]
		public SandboxOutput output
		{
			[Token(Token = "0x6011FD2")]
			[Address(RVA = "0xA1C510", Offset = "0xA1B110", VA = "0x180A1C510")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700278A RID: 10122
		// (get) Token: 0x06011FD3 RID: 73683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700278A")]
		public SandboxV2Data configData
		{
			[Token(Token = "0x6011FD3")]
			[Address(RVA = "0xA1C030", Offset = "0xA1AC30", VA = "0x180A1C030")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700278B RID: 10123
		// (get) Token: 0x06011FD4 RID: 73684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700278B")]
		public string trapAnimalCageKey
		{
			[Token(Token = "0x6011FD4")]
			[Address(RVA = "0xA1C5E0", Offset = "0xA1B1E0", VA = "0x180A1C5E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700278C RID: 10124
		// (get) Token: 0x06011FD5 RID: 73685 RVA: 0x0006DF38 File Offset: 0x0006C138
		[Token(Token = "0x1700278C")]
		public bool inBuildMode
		{
			[Token(Token = "0x6011FD5")]
			[Address(RVA = "0xA1C430", Offset = "0xA1B030", VA = "0x180A1C430")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700278D RID: 10125
		// (get) Token: 0x06011FD6 RID: 73686 RVA: 0x0006DF50 File Offset: 0x0006C150
		[Token(Token = "0x1700278D")]
		private PlayerSide playerSide
		{
			[Token(Token = "0x6011FD6")]
			[Address(RVA = "0xA1C580", Offset = "0xA1B180", VA = "0x180A1C580")]
			get
			{
				return PlayerSide.DEFAULT;
			}
		}

		// Token: 0x1700278E RID: 10126
		// (get) Token: 0x06011FD7 RID: 73687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700278E")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x6011FD7")]
			[Address(RVA = "0xA1C0A0", Offset = "0xA1ACA0", VA = "0x180A1C0A0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011FD8 RID: 73688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FD8")]
		[Address(RVA = "0xA14B50", Offset = "0xA13750", VA = "0x180A14B50", Slot = "7")]
		public override void Init(GlobalEnvSystem system)
		{
		}

		// Token: 0x06011FD9 RID: 73689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FD9")]
		[Address(RVA = "0xA189F0", Offset = "0xA175F0", VA = "0x180A189F0")]
		private void _OnGameStart(object arg)
		{
		}

		// Token: 0x06011FDA RID: 73690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FDA")]
		[Address(RVA = "0xA150D0", Offset = "0xA13CD0", VA = "0x180A150D0", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011FDB RID: 73691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FDB")]
		[Address(RVA = "0xA18E10", Offset = "0xA17A10", VA = "0x180A18E10")]
		public void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x06011FDC RID: 73692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FDC")]
		[Address(RVA = "0xA16B80", Offset = "0xA15780", VA = "0x180A16B80")]
		private void _OnEnemyBorn(Enemy enemy)
		{
		}

		// Token: 0x06011FDD RID: 73693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FDD")]
		[Address(RVA = "0xA167E0", Offset = "0xA153E0", VA = "0x180A167E0")]
		private void _OnCharacterBorn(Character character)
		{
		}

		// Token: 0x06011FDE RID: 73694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FDE")]
		[Address(RVA = "0xA18FC0", Offset = "0xA17BC0", VA = "0x180A18FC0")]
		public void _OnUnitFinish(object arg)
		{
		}

		// Token: 0x06011FDF RID: 73695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FDF")]
		[Address(RVA = "0xA17580", Offset = "0xA16180", VA = "0x180A17580")]
		public void _OnFenceFinishInBuild(Character character)
		{
		}

		// Token: 0x06011FE0 RID: 73696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FE0")]
		[Address(RVA = "0xA17AD0", Offset = "0xA166D0", VA = "0x180A17AD0")]
		public void _OnFenceFinishInNormal(Character character)
		{
		}

		// Token: 0x06011FE1 RID: 73697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FE1")]
		[Address(RVA = "0xA187E0", Offset = "0xA173E0", VA = "0x180A187E0")]
		private void _OnGameReady(object arg)
		{
		}

		// Token: 0x06011FE2 RID: 73698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FE2")]
		[Address(RVA = "0xA16740", Offset = "0xA15340", VA = "0x180A16740")]
		private void _OnBeforeSaveMapRequest(object arg)
		{
		}

		// Token: 0x06011FE3 RID: 73699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FE3")]
		[Address(RVA = "0xA146F0", Offset = "0xA132F0", VA = "0x180A146F0")]
		public void GetCatchedAnimalInfo(Dictionary<int, Dictionary<string, int>> data)
		{
		}

		// Token: 0x06011FE4 RID: 73700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FE4")]
		[Address(RVA = "0xA156C0", Offset = "0xA142C0", VA = "0x180A156C0")]
		private void _DoSaveCache(object arg)
		{
		}

		// Token: 0x06011FE5 RID: 73701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FE5")]
		[Address(RVA = "0xA15740", Offset = "0xA14340", VA = "0x180A15740")]
		private void _DoSaveCache()
		{
		}

		// Token: 0x06011FE6 RID: 73702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FE6")]
		[Address(RVA = "0xA141B0", Offset = "0xA12DB0", VA = "0x180A141B0")]
		public void DoResetFromCache()
		{
		}

		// Token: 0x06011FE7 RID: 73703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011FE7")]
		[Address(RVA = "0xA15B40", Offset = "0xA14740", VA = "0x180A15B40")]
		private string _GetEnemyIdByItem(string itemId, out bool isShiny)
		{
			return null;
		}

		// Token: 0x06011FE8 RID: 73704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011FE8")]
		[Address(RVA = "0xA15DF0", Offset = "0xA149F0", VA = "0x180A15DF0")]
		private string _GetItemIdByEnemy(string enemyId, bool isShiny)
		{
			return null;
		}

		// Token: 0x06011FE9 RID: 73705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011FE9")]
		[Address(RVA = "0xA16260", Offset = "0xA14E60", VA = "0x180A16260")]
		private string _GetTargetFenceIdByEnemyId(string enemyId)
		{
			return null;
		}

		// Token: 0x06011FEA RID: 73706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011FEA")]
		[Address(RVA = "0xA16060", Offset = "0xA14C60", VA = "0x180A16060")]
		private string _GetItemIdByEnemy(Enemy enemy)
		{
			return null;
		}

		// Token: 0x06011FEB RID: 73707 RVA: 0x0006DF68 File Offset: 0x0006C168
		[Token(Token = "0x6011FEB")]
		[Address(RVA = "0xA15290", Offset = "0xA13E90", VA = "0x180A15290")]
		private int _CatchedAnimalRoomId(int row, int col)
		{
			return 0;
		}

		// Token: 0x06011FEC RID: 73708 RVA: 0x0006DF80 File Offset: 0x0006C180
		[Token(Token = "0x6011FEC")]
		[Address(RVA = "0xA15A70", Offset = "0xA14670", VA = "0x180A15A70")]
		private int _GetCatchedAnimalRoomId(Tile tile)
		{
			return 0;
		}

		// Token: 0x06011FED RID: 73709 RVA: 0x0006DF98 File Offset: 0x0006C198
		[Token(Token = "0x6011FED")]
		[Address(RVA = "0xA14AD0", Offset = "0xA136D0", VA = "0x180A14AD0")]
		public int GetCatchedAnimalRoomId(Tile tile)
		{
			return 0;
		}

		// Token: 0x06011FEE RID: 73710 RVA: 0x0006DFB0 File Offset: 0x0006C1B0
		[Token(Token = "0x6011FEE")]
		[Address(RVA = "0xA13FB0", Offset = "0xA12BB0", VA = "0x180A13FB0")]
		public bool CheckAnimalRelatedTileReachable(Tile tileA, Tile tileB)
		{
			return default(bool);
		}

		// Token: 0x06011FEF RID: 73711 RVA: 0x0006DFC8 File Offset: 0x0006C1C8
		[Token(Token = "0x6011FEF")]
		[Address(RVA = "0xA13E80", Offset = "0xA12A80", VA = "0x180A13E80")]
		public static bool CheckAnimalRelatedTileReachableForRareFence(Tile tileA, Tile tileB)
		{
			return default(bool);
		}

		// Token: 0x06011FF0 RID: 73712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FF0")]
		[Address(RVA = "0xA191C0", Offset = "0xA17DC0", VA = "0x180A191C0")]
		private void _ParseCatchedAnimalCards()
		{
		}

		// Token: 0x06011FF1 RID: 73713 RVA: 0x0006DFE0 File Offset: 0x0006C1E0
		[Token(Token = "0x6011FF1")]
		[Address(RVA = "0xA1A230", Offset = "0xA18E30", VA = "0x180A1A230")]
		private bool _PreloadAnimalCards(string itemId, Dictionary<int, int> animalCardCount, List<BattleCharacterData> tokenPreloads)
		{
			return default(bool);
		}

		// Token: 0x06011FF2 RID: 73714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FF2")]
		[Address(RVA = "0xA1A140", Offset = "0xA18D40", VA = "0x180A1A140")]
		private void _ParseCatchedAnimals(Dictionary<int, Dictionary<string, int>> animals)
		{
		}

		// Token: 0x06011FF3 RID: 73715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FF3")]
		[Address(RVA = "0xA19760", Offset = "0xA18360", VA = "0x180A19760")]
		private void _ParseCatchedAnimalsInBuildMode(Dictionary<int, Dictionary<string, int>> animals)
		{
		}

		// Token: 0x06011FF4 RID: 73716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FF4")]
		[Address(RVA = "0xA1AE30", Offset = "0xA19A30", VA = "0x180A1AE30")]
		private void _RefreshCatchAnimalMapStatus()
		{
		}

		// Token: 0x06011FF5 RID: 73717 RVA: 0x0006DFF8 File Offset: 0x0006C1F8
		[Token(Token = "0x6011FF5")]
		[Address(RVA = "0xA15030", Offset = "0xA13C30", VA = "0x180A15030")]
		public bool IsCageValidTile(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x06011FF6 RID: 73718 RVA: 0x0006E010 File Offset: 0x0006C210
		[Token(Token = "0x6011FF6")]
		[Address(RVA = "0xA16440", Offset = "0xA15040", VA = "0x180A16440")]
		private bool _IsFenceTile(int row, int col)
		{
			return default(bool);
		}

		// Token: 0x06011FF7 RID: 73719 RVA: 0x0006E028 File Offset: 0x0006C228
		[Token(Token = "0x6011FF7")]
		[Address(RVA = "0xA16530", Offset = "0xA15130", VA = "0x180A16530")]
		private bool _IsRareFenceTile(int row, int col)
		{
			return default(bool);
		}

		// Token: 0x06011FF8 RID: 73720 RVA: 0x0006E040 File Offset: 0x0006C240
		[Token(Token = "0x6011FF8")]
		[Address(RVA = "0xA163A0", Offset = "0xA14FA0", VA = "0x180A163A0")]
		private bool _IsFenceTileId(string id)
		{
			return default(bool);
		}

		// Token: 0x06011FF9 RID: 73721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FF9")]
		[Address(RVA = "0xA1AF00", Offset = "0xA19B00", VA = "0x180A1AF00")]
		private void _RefreshCatchAnimalMap()
		{
		}

		// Token: 0x06011FFA RID: 73722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FFA")]
		[Address(RVA = "0xA1B9A0", Offset = "0xA1A5A0", VA = "0x180A1B9A0")]
		private void _SolveCatchedAnimalFlagViaDFS(int[,] map, int row, int col, int i, int j, int new_flag, int old_flag)
		{
		}

		// Token: 0x06011FFB RID: 73723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FFB")]
		[Address(RVA = "0xA1ABB0", Offset = "0xA197B0", VA = "0x180A1ABB0")]
		private void _RefreshAnimalRoomCapacity()
		{
		}

		// Token: 0x06011FFC RID: 73724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011FFC")]
		[Address(RVA = "0xA1A960", Offset = "0xA19560", VA = "0x180A1A960")]
		private void _RefreshAnimalCountInRoom()
		{
		}

		// Token: 0x06011FFD RID: 73725 RVA: 0x0006E058 File Offset: 0x0006C258
		[Token(Token = "0x6011FFD")]
		[Address(RVA = "0xA1B560", Offset = "0xA1A160", VA = "0x180A1B560")]
		private int _RegisterAnimalInRoom(int roomId, int count = 1)
		{
			return 0;
		}

		// Token: 0x06011FFE RID: 73726 RVA: 0x0006E070 File Offset: 0x0006C270
		[Token(Token = "0x6011FFE")]
		[Address(RVA = "0xA166C0", Offset = "0xA152C0", VA = "0x180A166C0")]
		private bool _IsRoomOverflow(int roomId)
		{
			return default(bool);
		}

		// Token: 0x06011FFF RID: 73727 RVA: 0x0006E088 File Offset: 0x0006C288
		[Token(Token = "0x6011FFF")]
		[Address(RVA = "0xA16160", Offset = "0xA14D60", VA = "0x180A16160")]
		private int _GetRoomRestCap(int roomId)
		{
			return 0;
		}

		// Token: 0x06012000 RID: 73728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012000")]
		[Address(RVA = "0xA1A760", Offset = "0xA19360", VA = "0x180A1A760")]
		private void _RecycleCatchedAnimal(Enemy enemy)
		{
		}

		// Token: 0x06012001 RID: 73729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012001")]
		[Address(RVA = "0xA1B730", Offset = "0xA1A330", VA = "0x180A1B730")]
		private void _SaveAnimalCardCount()
		{
		}

		// Token: 0x06012002 RID: 73730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012002")]
		[Address(RVA = "0xA1A5B0", Offset = "0xA191B0", VA = "0x180A1A5B0")]
		private void _RecycleCatchedAnimalCard(string itemId)
		{
		}

		// Token: 0x06012003 RID: 73731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012003")]
		[Address(RVA = "0xA15940", Offset = "0xA14540", VA = "0x180A15940")]
		private void _ForceChargeCatchedAnimalCard(uint uid, int count)
		{
		}

		// Token: 0x06012004 RID: 73732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012004")]
		[Address(RVA = "0xA15320", Offset = "0xA13F20", VA = "0x180A15320")]
		private void _DoEnemyMove(Enemy enemy)
		{
		}

		// Token: 0x06012005 RID: 73733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012005")]
		[Address(RVA = "0xA18D30", Offset = "0xA17930", VA = "0x180A18D30")]
		private void _OnPlaceAniamlFull()
		{
		}

		// Token: 0x06012006 RID: 73734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012006")]
		[Address(RVA = "0xA1B0C0", Offset = "0xA19CC0", VA = "0x180A1B0C0")]
		private void _RefreshTrapFenceAnimatorSurround(int row, int col)
		{
		}

		// Token: 0x06012007 RID: 73735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012007")]
		[Address(RVA = "0xA1B1E0", Offset = "0xA19DE0", VA = "0x180A1B1E0")]
		private void _RefreshTrapFenceAnimator(int row, int col)
		{
		}

		// Token: 0x06012008 RID: 73736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012008")]
		[Address(RVA = "0xA1BB90", Offset = "0xA1A790", VA = "0x180A1BB90")]
		public SandboxCatchedAnimalManager()
		{
		}

		// Token: 0x06012009 RID: 73737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012009")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0601200A RID: 73738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601200A")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0601200B RID: 73739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601200B")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x040144F2 RID: 83186
		[Token(Token = "0x40144F2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _animalAppearRandomOffset;

		// Token: 0x040144F3 RID: 83187
		[Token(Token = "0x40144F3")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _animalCapPerTile;

		// Token: 0x040144F4 RID: 83188
		[Token(Token = "0x40144F4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _trapAnimalCageKey;

		// Token: 0x040144F5 RID: 83189
		[Token(Token = "0x40144F5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BuffData _shinyAnimalBuff;

		// Token: 0x040144F6 RID: 83190
		[Token(Token = "0x40144F6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<string> _newShinyAnimalId;

		// Token: 0x040144F7 RID: 83191
		[Token(Token = "0x40144F7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private BuffData _newShinyAnimalBuff;

		// Token: 0x040144F8 RID: 83192
		[Token(Token = "0x40144F8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector2 _animalMoveInterval;

		// Token: 0x040144F9 RID: 83193
		[Token(Token = "0x40144F9")]
		[FieldOffset(Offset = "0x58")]
		private GameModeFactory.SandboxGameMode m_gameMode;

		// Token: 0x040144FA RID: 83194
		[Token(Token = "0x40144FA")]
		private const int CATCHED_ANIMAL_ROOM_ID_PARAM = 10000;

		// Token: 0x040144FB RID: 83195
		[Token(Token = "0x40144FB")]
		private const float CATCHED_ANIMAL_APPEAR_MOVE_DELAY = 0.3f;

		// Token: 0x040144FC RID: 83196
		[Token(Token = "0x40144FC")]
		private const int FENCE_AREA_FLAG = -1;

		// Token: 0x040144FD RID: 83197
		[Token(Token = "0x40144FD")]
		[FieldOffset(Offset = "0x60")]
		private List<LevelData.WaveData.FragmentData.ActionData> m_catchedAnimalActions;

		// Token: 0x040144FE RID: 83198
		[Token(Token = "0x40144FE")]
		[FieldOffset(Offset = "0x68")]
		private LevelData.BranchData.PhaseData m_catchedAnimalPhase;

		// Token: 0x040144FF RID: 83199
		[Token(Token = "0x40144FF")]
		[FieldOffset(Offset = "0x70")]
		private int[,] m_catchedAnimalFlagMap;

		// Token: 0x04014500 RID: 83200
		[Token(Token = "0x4014500")]
		[FieldOffset(Offset = "0x78")]
		private ListDict<Enemy, float> m_catchedAnimals;

		// Token: 0x04014501 RID: 83201
		[Token(Token = "0x4014501")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<Enemy, string> m_catchedAnimalFenceId;

		// Token: 0x04014502 RID: 83202
		[Token(Token = "0x4014502")]
		[FieldOffset(Offset = "0x88")]
		private Dictionary<int, int> m_animalRoomCapacity;

		// Token: 0x04014503 RID: 83203
		[Token(Token = "0x4014503")]
		[FieldOffset(Offset = "0x90")]
		private Dictionary<int, int> m_animalCountInRoom;

		// Token: 0x04014504 RID: 83204
		[Token(Token = "0x4014504")]
		[FieldOffset(Offset = "0x98")]
		private ListDict<int, SandboxCatchedAnimalManager.CatchedAnimalInfo> m_animalCardInfos;

		// Token: 0x04014505 RID: 83205
		[Token(Token = "0x4014505")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_cachedLastSpawnCage;

		// Token: 0x04014506 RID: 83206
		[Token(Token = "0x4014506")]
		[FieldOffset(Offset = "0xA1")]
		private bool m_cachedLastEnemy;

		// Token: 0x04014507 RID: 83207
		[Token(Token = "0x4014507")]
		[FieldOffset(Offset = "0xA2")]
		private bool m_cachedLastEnemyIsShiny;

		// Token: 0x04014508 RID: 83208
		[Token(Token = "0x4014508")]
		[FieldOffset(Offset = "0xA8")]
		private ListDict<string, uint> m_animalCardUids;

		// Token: 0x04014509 RID: 83209
		[Token(Token = "0x4014509")]
		[FieldOffset(Offset = "0xB0")]
		private ListDict<uint, int> m_catchedAnimalCardCount;

		// Token: 0x0401450A RID: 83210
		[Token(Token = "0x401450A")]
		[FieldOffset(Offset = "0xB8")]
		private Dictionary<int, Dictionary<string, int>> m_catchedAnimalCache;

		// Token: 0x0401450B RID: 83211
		[Token(Token = "0x401450B")]
		[FieldOffset(Offset = "0xC0")]
		private ListDict<string, int> m_roomAnimalCountTmp;

		// Token: 0x0401450C RID: 83212
		[Token(Token = "0x401450C")]
		[FieldOffset(Offset = "0xC8")]
		private ListDict<int, int> m_roomTilesCache;

		// Token: 0x0401450D RID: 83213
		[Token(Token = "0x401450D")]
		[FieldOffset(Offset = "0xD0")]
		private ListDict<int, HashSet<int>> m_roomDiff;

		// Token: 0x0401450E RID: 83214
		[Token(Token = "0x401450E")]
		[FieldOffset(Offset = "0xD8")]
		private SandboxCatchedAnimalManager.SandboxCatchedAnimalTileBuildableChecker m_tileBuildableChecker;

		// Token: 0x0401450F RID: 83215
		[Token(Token = "0x401450F")]
		[FieldOffset(Offset = "0xE0")]
		private int m_mapWidth;

		// Token: 0x04014510 RID: 83216
		[Token(Token = "0x4014510")]
		[FieldOffset(Offset = "0xE4")]
		private int m_mapHeight;

		// Token: 0x04014511 RID: 83217
		[Token(Token = "0x4014511")]
		[FieldOffset(Offset = "0xE8")]
		private string m_defaultFenceId;

		// Token: 0x04014512 RID: 83218
		[Token(Token = "0x4014512")]
		[FieldOffset(Offset = "0xF0")]
		private string m_rareFenceId;

		// Token: 0x04014513 RID: 83219
		[Token(Token = "0x4014513")]
		[FieldOffset(Offset = "0xF8")]
		private int m_unitFenceLimit;

		// Token: 0x04014514 RID: 83220
		[Token(Token = "0x4014514")]
		[FieldOffset(Offset = "0xFC")]
		private int m_unitRareFenceLimit;

		// Token: 0x04014515 RID: 83221
		[Token(Token = "0x4014515")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_input;

		// Token: 0x04014516 RID: 83222
		[Token(Token = "0x4014516")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_output;

		// Token: 0x04014517 RID: 83223
		[Token(Token = "0x4014517")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_configData;

		// Token: 0x04014518 RID: 83224
		[Token(Token = "0x4014518")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_trapAnimalCageKey;

		// Token: 0x04014519 RID: 83225
		[Token(Token = "0x4014519")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_inBuildMode;

		// Token: 0x0401451A RID: 83226
		[Token(Token = "0x401451A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_playerSide;

		// Token: 0x0401451B RID: 83227
		[Token(Token = "0x401451B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0401451C RID: 83228
		[Token(Token = "0x401451C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401451D RID: 83229
		[Token(Token = "0x401451D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnGameStart;

		// Token: 0x0401451E RID: 83230
		[Token(Token = "0x401451E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0401451F RID: 83231
		[Token(Token = "0x401451F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x04014520 RID: 83232
		[Token(Token = "0x4014520")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnEnemyBorn;

		// Token: 0x04014521 RID: 83233
		[Token(Token = "0x4014521")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnCharacterBorn;

		// Token: 0x04014522 RID: 83234
		[Token(Token = "0x4014522")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnUnitFinish;

		// Token: 0x04014523 RID: 83235
		[Token(Token = "0x4014523")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnFenceFinishInBuild;

		// Token: 0x04014524 RID: 83236
		[Token(Token = "0x4014524")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnFenceFinishInNormal;

		// Token: 0x04014525 RID: 83237
		[Token(Token = "0x4014525")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnGameReady;

		// Token: 0x04014526 RID: 83238
		[Token(Token = "0x4014526")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnBeforeSaveMapRequest;

		// Token: 0x04014527 RID: 83239
		[Token(Token = "0x4014527")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GetCatchedAnimalInfo;

		// Token: 0x04014528 RID: 83240
		[Token(Token = "0x4014528")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__DoSaveCache;

		// Token: 0x04014529 RID: 83241
		[Token(Token = "0x4014529")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix1__DoSaveCache;

		// Token: 0x0401452A RID: 83242
		[Token(Token = "0x401452A")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_DoResetFromCache;

		// Token: 0x0401452B RID: 83243
		[Token(Token = "0x401452B")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__GetEnemyIdByItem;

		// Token: 0x0401452C RID: 83244
		[Token(Token = "0x401452C")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__GetItemIdByEnemy;

		// Token: 0x0401452D RID: 83245
		[Token(Token = "0x401452D")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__GetTargetFenceIdByEnemyId;

		// Token: 0x0401452E RID: 83246
		[Token(Token = "0x401452E")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix1__GetItemIdByEnemy;

		// Token: 0x0401452F RID: 83247
		[Token(Token = "0x401452F")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__CatchedAnimalRoomId;

		// Token: 0x04014530 RID: 83248
		[Token(Token = "0x4014530")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__GetCatchedAnimalRoomId;

		// Token: 0x04014531 RID: 83249
		[Token(Token = "0x4014531")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_GetCatchedAnimalRoomId;

		// Token: 0x04014532 RID: 83250
		[Token(Token = "0x4014532")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_CheckAnimalRelatedTileReachable;

		// Token: 0x04014533 RID: 83251
		[Token(Token = "0x4014533")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_CheckAnimalRelatedTileReachableForRareFence;

		// Token: 0x04014534 RID: 83252
		[Token(Token = "0x4014534")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__ParseCatchedAnimalCards;

		// Token: 0x04014535 RID: 83253
		[Token(Token = "0x4014535")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__PreloadAnimalCards;

		// Token: 0x04014536 RID: 83254
		[Token(Token = "0x4014536")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__ParseCatchedAnimals;

		// Token: 0x04014537 RID: 83255
		[Token(Token = "0x4014537")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__ParseCatchedAnimalsInBuildMode;

		// Token: 0x04014538 RID: 83256
		[Token(Token = "0x4014538")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__RefreshCatchAnimalMapStatus;

		// Token: 0x04014539 RID: 83257
		[Token(Token = "0x4014539")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_IsCageValidTile;

		// Token: 0x0401453A RID: 83258
		[Token(Token = "0x401453A")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__IsFenceTile;

		// Token: 0x0401453B RID: 83259
		[Token(Token = "0x401453B")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__IsRareFenceTile;

		// Token: 0x0401453C RID: 83260
		[Token(Token = "0x401453C")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__IsFenceTileId;

		// Token: 0x0401453D RID: 83261
		[Token(Token = "0x401453D")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__RefreshCatchAnimalMap;

		// Token: 0x0401453E RID: 83262
		[Token(Token = "0x401453E")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__SolveCatchedAnimalFlagViaDFS;

		// Token: 0x0401453F RID: 83263
		[Token(Token = "0x401453F")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__RefreshAnimalRoomCapacity;

		// Token: 0x04014540 RID: 83264
		[Token(Token = "0x4014540")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__RefreshAnimalCountInRoom;

		// Token: 0x04014541 RID: 83265
		[Token(Token = "0x4014541")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__RegisterAnimalInRoom;

		// Token: 0x04014542 RID: 83266
		[Token(Token = "0x4014542")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__IsRoomOverflow;

		// Token: 0x04014543 RID: 83267
		[Token(Token = "0x4014543")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__GetRoomRestCap;

		// Token: 0x04014544 RID: 83268
		[Token(Token = "0x4014544")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__RecycleCatchedAnimal;

		// Token: 0x04014545 RID: 83269
		[Token(Token = "0x4014545")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__SaveAnimalCardCount;

		// Token: 0x04014546 RID: 83270
		[Token(Token = "0x4014546")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__RecycleCatchedAnimalCard;

		// Token: 0x04014547 RID: 83271
		[Token(Token = "0x4014547")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__ForceChargeCatchedAnimalCard;

		// Token: 0x04014548 RID: 83272
		[Token(Token = "0x4014548")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__DoEnemyMove;

		// Token: 0x04014549 RID: 83273
		[Token(Token = "0x4014549")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__OnPlaceAniamlFull;

		// Token: 0x0401454A RID: 83274
		[Token(Token = "0x401454A")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0__RefreshTrapFenceAnimatorSurround;

		// Token: 0x0401454B RID: 83275
		[Token(Token = "0x401454B")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__RefreshTrapFenceAnimator;

		// Token: 0x0401454C RID: 83276
		[Token(Token = "0x401454C")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002A57 RID: 10839
		[Token(Token = "0x2002A57")]
		private class CatchedAnimalBornInfo
		{
			// Token: 0x0601200C RID: 73740 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601200C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CatchedAnimalBornInfo()
			{
			}

			// Token: 0x0401454D RID: 83277
			[Token(Token = "0x401454D")]
			[FieldOffset(Offset = "0x10")]
			public bool isShiny;

			// Token: 0x0401454E RID: 83278
			[Token(Token = "0x401454E")]
			[FieldOffset(Offset = "0x14")]
			public int roomId;

			// Token: 0x0401454F RID: 83279
			[Token(Token = "0x401454F")]
			[FieldOffset(Offset = "0x18")]
			public List<Vector2> areaPositions;
		}

		// Token: 0x02002A58 RID: 10840
		[Token(Token = "0x2002A58")]
		private class CatchedAnimalBornBaseInfo
		{
			// Token: 0x0601200D RID: 73741 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601200D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CatchedAnimalBornBaseInfo()
			{
			}

			// Token: 0x04014550 RID: 83280
			[Token(Token = "0x4014550")]
			[FieldOffset(Offset = "0x10")]
			public SandboxCatchedAnimalManager.CatchedAnimalBornInfo normalInfo;

			// Token: 0x04014551 RID: 83281
			[Token(Token = "0x4014551")]
			[FieldOffset(Offset = "0x18")]
			public SandboxCatchedAnimalManager.CatchedAnimalBornInfo shinyInfo;
		}

		// Token: 0x02002A59 RID: 10841
		[Token(Token = "0x2002A59")]
		private struct CatchedAnimalInfo
		{
			// Token: 0x04014552 RID: 83282
			[Token(Token = "0x4014552")]
			[FieldOffset(Offset = "0x0")]
			public bool isShiny;

			// Token: 0x04014553 RID: 83283
			[Token(Token = "0x4014553")]
			[FieldOffset(Offset = "0x8")]
			public string enemyId;

			// Token: 0x04014554 RID: 83284
			[Token(Token = "0x4014554")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x04014555 RID: 83285
			[Token(Token = "0x4014555")]
			[FieldOffset(Offset = "0x18")]
			public string targetFenceId;
		}

		// Token: 0x02002A5A RID: 10842
		[Token(Token = "0x2002A5A")]
		public class SandboxCatchedAnimalTileBuildableChecker : ITileBuildableChecker, IHotfixable
		{
			// Token: 0x0601200E RID: 73742 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601200E")]
			[Address(RVA = "0xA1CB80", Offset = "0xA1B780", VA = "0x180A1CB80")]
			public SandboxCatchedAnimalTileBuildableChecker(SandboxCatchedAnimalManager manager)
			{
			}

			// Token: 0x0601200F RID: 73743 RVA: 0x0006E0A0 File Offset: 0x0006C2A0
			[Token(Token = "0x601200F")]
			[Address(RVA = "0xA1C640", Offset = "0xA1B240", VA = "0x180A1C640", Slot = "4")]
			public bool IsCharacterBuildableOnTile(Tile tile, BattleCharacterData sourceData)
			{
				return default(bool);
			}

			// Token: 0x06012010 RID: 73744 RVA: 0x0006E0B8 File Offset: 0x0006C2B8
			[Token(Token = "0x6012010")]
			[Address(RVA = "0xA1C8F0", Offset = "0xA1B4F0", VA = "0x180A1C8F0")]
			private bool _IsValidSourceData(BattleCharacterData sourceData)
			{
				return default(bool);
			}

			// Token: 0x06012011 RID: 73745 RVA: 0x0006E0D0 File Offset: 0x0006C2D0
			[Token(Token = "0x6012011")]
			[Address(RVA = "0xA1C980", Offset = "0xA1B580", VA = "0x180A1C980")]
			private bool _IsValidTile(Tile tile)
			{
				return default(bool);
			}

			// Token: 0x04014556 RID: 83286
			[Token(Token = "0x4014556")]
			[FieldOffset(Offset = "0x10")]
			private SandboxCatchedAnimalManager m_manager;

			// Token: 0x04014557 RID: 83287
			[Token(Token = "0x4014557")]
			[FieldOffset(Offset = "0x18")]
			private ListDict<int, SandboxCatchedAnimalManager.CatchedAnimalInfo> m_animalCardInfos;

			// Token: 0x04014558 RID: 83288
			[Token(Token = "0x4014558")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04014559 RID: 83289
			[Token(Token = "0x4014559")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_IsCharacterBuildableOnTile;

			// Token: 0x0401455A RID: 83290
			[Token(Token = "0x401455A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__IsValidSourceData;

			// Token: 0x0401455B RID: 83291
			[Token(Token = "0x401455B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__IsValidTile;
		}
	}
}
