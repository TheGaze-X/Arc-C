using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.CETest
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	public class CETestPersistent : MonoBehaviour
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x54DA520", Offset = "0x54D9120", VA = "0x1854DA520")]
		public static void TryInit(GameObject prefMe)
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x54D9560", Offset = "0x54D8160", VA = "0x1854D9560")]
		public static bool CEUpdateInBattleCharExcludeInfoWhenCharacterBuilt(string charId)
		{
			return default(bool);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x54D9B00", Offset = "0x54D8700", VA = "0x1854D9B00")]
		public static bool CEUpdateInBattleCharExcludeInfoWhenCharacterOut(string charId, List<string> charactersOnGround)
		{
			return default(bool);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x54DA7D0", Offset = "0x54D93D0", VA = "0x1854DA7D0")]
		public void UpdateLastTestedLevel(string levelId)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x54DA730", Offset = "0x54D9330", VA = "0x1854DA730")]
		public void UpdateLastTestedLevelSquadCombination(string levelId, string squadId)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x54D9500", Offset = "0x54D8100", VA = "0x1854D9500")]
		public void AddTestedLevels(string levelId)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x54D93E0", Offset = "0x54D7FE0", VA = "0x1854D93E0")]
		public void AddTestedLevelAndSquadCombination(Tuple<string, string> data)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x54D9440", Offset = "0x54D8040", VA = "0x1854D9440")]
		public void AddTestedLevelAndSquadCombination(string levelId, string squadId)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x4FCBC30", Offset = "0x4FCA830", VA = "0x184FCBC30")]
		public string GetLastTestedLevel()
		{
			return null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x4FCBB50", Offset = "0x4FCA750", VA = "0x184FCBB50")]
		public Tuple<string, string> GetLastTestedLevelSquadCombination()
		{
			return null;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x54DA480", Offset = "0x54D9080", VA = "0x1854DA480")]
		public bool IsLevelTested(string levelId)
		{
			return default(bool);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x54DA3C0", Offset = "0x54D8FC0", VA = "0x1854DA3C0")]
		public bool IsLevelSquadCombinationTested(string levelId, string squadId)
		{
			return default(bool);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x54DA4E0", Offset = "0x54D90E0", VA = "0x1854DA4E0")]
		public void SetGroupExcludeRules(bool isGroupExcluded, List<CETestConfigs.CharacterGroup> groups)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x54D9370", Offset = "0x54D7F70", VA = "0x1854D9370")]
		public void AddInGameSquadMember(string charID)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x54D9F40", Offset = "0x54D8B40", VA = "0x1854D9F40")]
		public void InitWhiteList()
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x54DA800", Offset = "0x54D9400", VA = "0x1854DA800")]
		public CETestPersistent()
		{
		}

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x18")]
		public GameObject _buttonBack2CETestScenePrefab;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x0")]
		public static CETestPersistent inst;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x20")]
		public CETestPersistent.CEPersistantData cePersistantData;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x28")]
		public bool CE_TEST;

		// Token: 0x02000013 RID: 19
		[Token(Token = "0x2000013")]
		public class CEPersistantData
		{
			// Token: 0x06000052 RID: 82 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x54D46F0", Offset = "0x54D32F0", VA = "0x1854D46F0")]
			public void Init()
			{
			}

			// Token: 0x06000053 RID: 83 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x54D47F0", Offset = "0x54D33F0", VA = "0x1854D47F0")]
			public CEPersistantData()
			{
			}

			// Token: 0x0400004A RID: 74
			[Token(Token = "0x400004A")]
			[FieldOffset(Offset = "0x10")]
			public string lastTestedLevelId;

			// Token: 0x0400004B RID: 75
			[Token(Token = "0x400004B")]
			[FieldOffset(Offset = "0x18")]
			public Tuple<string, string> lastTestedLevelSquadCombination;

			// Token: 0x0400004C RID: 76
			[Token(Token = "0x400004C")]
			[FieldOffset(Offset = "0x20")]
			public HashSet<string> testedLevels;

			// Token: 0x0400004D RID: 77
			[Token(Token = "0x400004D")]
			[FieldOffset(Offset = "0x28")]
			public HashSet<Tuple<string, string>> testedLevelSquadCombinations;

			// Token: 0x0400004E RID: 78
			[Token(Token = "0x400004E")]
			[FieldOffset(Offset = "0x30")]
			public List<string> excludeIds;

			// Token: 0x0400004F RID: 79
			[Token(Token = "0x400004F")]
			[FieldOffset(Offset = "0x38")]
			public bool isGroupedExclude;

			// Token: 0x04000050 RID: 80
			[Token(Token = "0x4000050")]
			[FieldOffset(Offset = "0x40")]
			public List<CETestConfigs.CharacterGroup> groups;

			// Token: 0x04000051 RID: 81
			[Token(Token = "0x4000051")]
			[FieldOffset(Offset = "0x48")]
			public List<string> inGameSquad;

			// Token: 0x04000052 RID: 82
			[Token(Token = "0x4000052")]
			[FieldOffset(Offset = "0x50")]
			public List<string> whiteList;
		}
	}
}
