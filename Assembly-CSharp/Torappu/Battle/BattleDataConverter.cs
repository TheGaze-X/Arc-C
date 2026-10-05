using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200262A RID: 9770
	[Token(Token = "0x200262A")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class BattleDataConverter
	{
		// Token: 0x0600FFC7 RID: 65479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FFC7")]
		[Address(RVA = "0x7760B0", Offset = "0x774CB0", VA = "0x1807760B0")]
		public static BattleCharacterData TouchCharacterData(AdvancedCharacterInst slot, bool isToken = false, bool isAssistChar = false, PlayerSide playerSide = PlayerSide.DEFAULT)
		{
			return null;
		}

		// Token: 0x0600FFC8 RID: 65480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FFC8")]
		[Address(RVA = "0x7750B0", Offset = "0x773CB0", VA = "0x1807750B0")]
		public static BattleCharacterData ConvertToCharacterData(AdvancedCharacterInst slot, bool isToken = false, bool isAssistChar = false, PlayerSide playerSide = PlayerSide.DEFAULT, [Optional] LevelData levelData)
		{
			return null;
		}

		// Token: 0x0600FFC9 RID: 65481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FFC9")]
		[Address(RVA = "0x775CA0", Offset = "0x7748A0", VA = "0x180775CA0")]
		public static void OverrideMainSkillBlackboardIfExist(AdvancedCharacterInst slot, bool isToken, ref BattleCharacterData battleCharacterData)
		{
		}

		// Token: 0x0600FFCA RID: 65482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FFCA")]
		[Address(RVA = "0x775D70", Offset = "0x774970", VA = "0x180775D70")]
		public static void OverrideTalentBlackboardIfExist(AdvancedCharacterInst slot, ref BattleCharacterData battleCharacterData)
		{
		}

		// Token: 0x0600FFCB RID: 65483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FFCB")]
		[Address(RVA = "0x775260", Offset = "0x773E60", VA = "0x180775260")]
		public static List<BattleCharacterData> ConvertToRuntimeCharacterData(List<AdvancedCharacterInst> slots, bool isToken, bool isAssistChar = false, PlayerSide playerSide = PlayerSide.DEFAULT)
		{
			return null;
		}

		// Token: 0x0600FFCC RID: 65484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FFCC")]
		[Address(RVA = "0x775190", Offset = "0x773D90", VA = "0x180775190")]
		public static BattleCharacterData ConvertToRuntimeCharacterData(AdvancedCharacterInst slot, bool isToken, bool isAssistChar = false, PlayerSide playerSide = PlayerSide.DEFAULT)
		{
			return null;
		}

		// Token: 0x0600FFCD RID: 65485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FFCD")]
		[Address(RVA = "0x775B60", Offset = "0x774760", VA = "0x180775B60")]
		public static List<string> LoadEnemyList(string stageId)
		{
			return null;
		}

		// Token: 0x0600FFCE RID: 65486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FFCE")]
		[Address(RVA = "0x7759D0", Offset = "0x7745D0", VA = "0x1807759D0")]
		public static List<string> LoadEnemyListByLevelId(string levelId)
		{
			return null;
		}

		// Token: 0x0600FFCF RID: 65487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FFCF")]
		[Address(RVA = "0x7758B0", Offset = "0x7744B0", VA = "0x1807758B0")]
		public static List<LevelData.EnemyDataDbReference> LoadEnemyDataList(string stageId)
		{
			return null;
		}

		// Token: 0x0600FFD0 RID: 65488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FFD0")]
		[Address(RVA = "0x775730", Offset = "0x774330", VA = "0x180775730")]
		public static List<LevelData.EnemyDataDbReference> LoadEnemyDataListByLevelId(string levelId)
		{
			return null;
		}

		// Token: 0x0600FFD1 RID: 65489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FFD1")]
		[Address(RVA = "0x774750", Offset = "0x773350", VA = "0x180774750")]
		public static BattlePlayerData ConvertToBattlePlayerData(IList<AdvancedCharacterInst> slots, LevelData levelData, LevelData.Difficulty difficulty, [Optional] AdvancedCharacterInst assistChar, bool isMemory = false, PlayerSide playerSide = PlayerSide.DEFAULT, bool resetIdCounterFlag = true, bool isSkillSelectablePredefined = false)
		{
			return null;
		}

		// Token: 0x0600FFD2 RID: 65490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FFD2")]
		[Address(RVA = "0x775550", Offset = "0x774150", VA = "0x180775550")]
		public static BattleCharacterData CreateTokenData(Blackboard blackboard)
		{
			return null;
		}

		// Token: 0x0600FFD3 RID: 65491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FFD3")]
		[Address(RVA = "0x775480", Offset = "0x774080", VA = "0x180775480")]
		public static BattleCharacterData ConvertToTokenDataOrNull(BattleCharacterData host, AdvancedCharacterInst slot, PlayerSide playerSide)
		{
			return null;
		}

		// Token: 0x0600FFD4 RID: 65492 RVA: 0x00061428 File Offset: 0x0005F628
		[Token(Token = "0x600FFD4")]
		[Address(RVA = "0x776180", Offset = "0x774D80", VA = "0x180776180")]
		public static bool TryGetPlayerIdByUniqueId(uint uniqueId, bool excludeTokenAndTrap, PlayerSide playerSide, out int playerInstId)
		{
			return default(bool);
		}

		// Token: 0x0600FFD5 RID: 65493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FFD5")]
		[Address(RVA = "0x775F70", Offset = "0x774B70", VA = "0x180775F70")]
		public static void Reset(uint uniqueId = 0U)
		{
		}

		// Token: 0x0600FFD6 RID: 65494 RVA: 0x00061440 File Offset: 0x0005F640
		[Token(Token = "0x600FFD6")]
		[Address(RVA = "0x775640", Offset = "0x774240", VA = "0x180775640")]
		public static uint GetCurUniqueId()
		{
			return 0U;
		}

		// Token: 0x0600FFD7 RID: 65495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FFD7")]
		[Address(RVA = "0x778100", Offset = "0x776D00", VA = "0x180778100")]
		private static BattleCharacterData _ConvertToTokenData(BattleCharacterData host, AdvancedCharacterInst slot, PlayerSide playerSide)
		{
			return null;
		}

		// Token: 0x0600FFD8 RID: 65496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FFD8")]
		[Address(RVA = "0x777E90", Offset = "0x776A90", VA = "0x180777E90")]
		private static BattleCharacterData _ConvertToTokenData(LevelData.PredefinedData.PredefinedCharacter pChar, PlayerSide playerSide)
		{
			return null;
		}

		// Token: 0x0600FFD9 RID: 65497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FFD9")]
		[Address(RVA = "0x777DC0", Offset = "0x7769C0", VA = "0x180777DC0")]
		private static BattleCharacterData _ConvertToTokenData(AdvancedCharacterInst slot, int initialCnt, PlayerSide playerSide)
		{
			return null;
		}

		// Token: 0x0600FFDA RID: 65498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FFDA")]
		[Address(RVA = "0x776250", Offset = "0x774E50", VA = "0x180776250")]
		private static BattleCharacterData _ConvertInternal(string characterKey, AdvancedCharacterInst slot, bool isToken, bool isAssistChar, string skinId, bool generateUniqueId, PlayerSide playerSide, [Optional] LevelData levelData)
		{
			return null;
		}

		// Token: 0x0600FFDB RID: 65499 RVA: 0x00061458 File Offset: 0x0005F658
		[Token(Token = "0x600FFDB")]
		[Address(RVA = "0x775690", Offset = "0x774290", VA = "0x180775690")]
		public static uint GetUniqueIdByPlayerId(int playerInstId, bool isCharacter, bool isAssistChar, PlayerSide playerSide)
		{
			return 0U;
		}

		// Token: 0x0600FFDC RID: 65500 RVA: 0x00061470 File Offset: 0x0005F670
		[Token(Token = "0x600FFDC")]
		[Address(RVA = "0x7782F0", Offset = "0x776EF0", VA = "0x1807782F0")]
		private static uint _GetUniqueIdByPlayerId(int playerInstId, bool isCharacter, bool isAssistChar, PlayerSide playerSide)
		{
			return 0U;
		}

		// Token: 0x0600FFDD RID: 65501 RVA: 0x00061488 File Offset: 0x0005F688
		[Token(Token = "0x600FFDD")]
		[Address(RVA = "0x776040", Offset = "0x774C40", VA = "0x180776040")]
		public static uint ShiftByPlayerSide(uint playerInstId, PlayerSide playerSide)
		{
			return 0U;
		}

		// Token: 0x0600FFDE RID: 65502 RVA: 0x000614A0 File Offset: 0x0005F6A0
		[Token(Token = "0x600FFDE")]
		[Address(RVA = "0x775FD0", Offset = "0x774BD0", VA = "0x180775FD0")]
		public static uint ShiftBackPlayerSide(uint playerInstId, PlayerSide playerSide)
		{
			return 0U;
		}

		// Token: 0x04011C11 RID: 72721
		[Token(Token = "0x4011C11")]
		private const uint MASK_PLAYER_CHARACTER = 2147483648U;

		// Token: 0x04011C12 RID: 72722
		[Token(Token = "0x4011C12")]
		private const uint MASK_PLAYER_TRAP_OR_TOKEN = 1073741824U;

		// Token: 0x04011C13 RID: 72723
		[Token(Token = "0x4011C13")]
		private const uint MASK_PLAYER_ASSIST_CHAR = 536870912U;

		// Token: 0x04011C14 RID: 72724
		[Token(Token = "0x4011C14")]
		private const uint PLAYER_SIDE_SHIFT = 1048576U;

		// Token: 0x04011C15 RID: 72725
		[Token(Token = "0x4011C15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static uint s_uniqueId;

		// Token: 0x04011C16 RID: 72726
		[Token(Token = "0x4011C16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TouchCharacterData;

		// Token: 0x04011C17 RID: 72727
		[Token(Token = "0x4011C17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ConvertToCharacterData;

		// Token: 0x04011C18 RID: 72728
		[Token(Token = "0x4011C18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OverrideMainSkillBlackboardIfExist;

		// Token: 0x04011C19 RID: 72729
		[Token(Token = "0x4011C19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OverrideTalentBlackboardIfExist;

		// Token: 0x04011C1A RID: 72730
		[Token(Token = "0x4011C1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ConvertToRuntimeCharacterData;

		// Token: 0x04011C1B RID: 72731
		[Token(Token = "0x4011C1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix1_ConvertToRuntimeCharacterData;

		// Token: 0x04011C1C RID: 72732
		[Token(Token = "0x4011C1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadEnemyList;

		// Token: 0x04011C1D RID: 72733
		[Token(Token = "0x4011C1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadEnemyListByLevelId;

		// Token: 0x04011C1E RID: 72734
		[Token(Token = "0x4011C1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadEnemyDataList;

		// Token: 0x04011C1F RID: 72735
		[Token(Token = "0x4011C1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadEnemyDataListByLevelId;

		// Token: 0x04011C20 RID: 72736
		[Token(Token = "0x4011C20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ConvertToBattlePlayerData;

		// Token: 0x04011C21 RID: 72737
		[Token(Token = "0x4011C21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CreateTokenData;

		// Token: 0x04011C22 RID: 72738
		[Token(Token = "0x4011C22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ConvertToTokenDataOrNull;

		// Token: 0x04011C23 RID: 72739
		[Token(Token = "0x4011C23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_TryGetPlayerIdByUniqueId;

		// Token: 0x04011C24 RID: 72740
		[Token(Token = "0x4011C24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04011C25 RID: 72741
		[Token(Token = "0x4011C25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetCurUniqueId;

		// Token: 0x04011C26 RID: 72742
		[Token(Token = "0x4011C26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ConvertToTokenData;

		// Token: 0x04011C27 RID: 72743
		[Token(Token = "0x4011C27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix1__ConvertToTokenData;

		// Token: 0x04011C28 RID: 72744
		[Token(Token = "0x4011C28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix2__ConvertToTokenData;

		// Token: 0x04011C29 RID: 72745
		[Token(Token = "0x4011C29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__ConvertInternal;

		// Token: 0x04011C2A RID: 72746
		[Token(Token = "0x4011C2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_GetUniqueIdByPlayerId;

		// Token: 0x04011C2B RID: 72747
		[Token(Token = "0x4011C2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__GetUniqueIdByPlayerId;

		// Token: 0x04011C2C RID: 72748
		[Token(Token = "0x4011C2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_ShiftByPlayerSide;

		// Token: 0x04011C2D RID: 72749
		[Token(Token = "0x4011C2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_ShiftBackPlayerSide;
	}
}
