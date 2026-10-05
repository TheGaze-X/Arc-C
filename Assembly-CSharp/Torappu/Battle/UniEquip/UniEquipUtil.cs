using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UniEquip
{
	// Token: 0x02002A32 RID: 10802
	[Token(Token = "0x2002A32")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class UniEquipUtil
	{
		// Token: 0x06011EC1 RID: 73409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EC1")]
		[Address(RVA = "0x9D52E0", Offset = "0x9D3EE0", VA = "0x1809D52E0")]
		public static void ClearStatic()
		{
		}

		// Token: 0x06011EC2 RID: 73410 RVA: 0x0006D938 File Offset: 0x0006BB38
		[Token(Token = "0x6011EC2")]
		[Address(RVA = "0x9D4BD0", Offset = "0x9D37D0", VA = "0x1809D4BD0")]
		public static bool CheckEquipValid(BattleEquipPerLevelPack data, int level, EvolvePhase phase)
		{
			return default(bool);
		}

		// Token: 0x06011EC3 RID: 73411 RVA: 0x0006D950 File Offset: 0x0006BB50
		[Token(Token = "0x6011EC3")]
		[Address(RVA = "0x9D7260", Offset = "0x9D5E60", VA = "0x1809D7260")]
		public static bool TryGetOverrideTraitData(BattleUniEquipData data, int level, EvolvePhase phase, int potential, out CharacterData.EquipTraitData overrideTraitData)
		{
			return default(bool);
		}

		// Token: 0x06011EC4 RID: 73412 RVA: 0x0006D968 File Offset: 0x0006BB68
		[Token(Token = "0x6011EC4")]
		[Address(RVA = "0x9D6DA0", Offset = "0x9D59A0", VA = "0x1809D6DA0")]
		public static bool TryGetOverrideTalentData(BattleUniEquipData data, int level, EvolvePhase phase, int potential, out EquipTalentData addOrOverrideTalentData)
		{
			return default(bool);
		}

		// Token: 0x06011EC5 RID: 73413 RVA: 0x0006D980 File Offset: 0x0006BB80
		[Token(Token = "0x6011EC5")]
		[Address(RVA = "0x9D7750", Offset = "0x9D6350", VA = "0x1809D7750")]
		public static bool TryGetUniEquipPackData(CharacterData.UniqueEquipPair query, out BattleEquipPerLevelPack result)
		{
			return default(bool);
		}

		// Token: 0x06011EC6 RID: 73414 RVA: 0x0006D998 File Offset: 0x0006BB98
		[Token(Token = "0x6011EC6")]
		[Address(RVA = "0x9D6ED0", Offset = "0x9D5AD0", VA = "0x1809D6ED0")]
		public static bool TryGetOverrideTalentData(CharacterData.UniqueEquipPair query, int level, EvolvePhase phase, int potential, bool isToken, out List<TalentData> talents)
		{
			return default(bool);
		}

		// Token: 0x06011EC7 RID: 73415 RVA: 0x0006D9B0 File Offset: 0x0006BBB0
		[Token(Token = "0x6011EC7")]
		[Address(RVA = "0x9D4F00", Offset = "0x9D3B00", VA = "0x1809D4F00")]
		private static bool CheckFilter(BattleUniEquipData part, bool isToken)
		{
			return default(bool);
		}

		// Token: 0x06011EC8 RID: 73416 RVA: 0x0006D9C8 File Offset: 0x0006BBC8
		[Token(Token = "0x6011EC8")]
		[Address(RVA = "0x9D7390", Offset = "0x9D5F90", VA = "0x1809D7390")]
		public static bool TryGetOverrideTraitData(CharacterData.UniqueEquipPair query, int level, EvolvePhase phase, int potential, bool isToken, out List<CharacterData.TraitData> trait)
		{
			return default(bool);
		}

		// Token: 0x06011EC9 RID: 73417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011EC9")]
		[Address(RVA = "0x9D55D0", Offset = "0x9D41D0", VA = "0x1809D55D0")]
		public static string GetTraitDescription(CharacterData data, List<CharacterData.UniqueEquipPair> queries, bool isToken, int level, EvolvePhase evolvePhase, int potentialRank)
		{
			return null;
		}

		// Token: 0x06011ECA RID: 73418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011ECA")]
		[Address(RVA = "0x9D53A0", Offset = "0x9D3FA0", VA = "0x1809D53A0")]
		public static string GetTraitDescriptionInRichText(CharacterData data, List<CharacterData.UniqueEquipPair> queries, bool isToken, int level, EvolvePhase evolvePhase, int potentialRank)
		{
			return null;
		}

		// Token: 0x06011ECB RID: 73419 RVA: 0x0006D9E0 File Offset: 0x0006BBE0
		[Token(Token = "0x6011ECB")]
		[Address(RVA = "0x9D8590", Offset = "0x9D7190", VA = "0x1809D8590")]
		private static bool _TryGetFirstEquipOverrideTraitData(CharacterData data, int level, EvolvePhase phase, int potential, List<CharacterData.UniqueEquipPair> queries, bool isToken, out string description)
		{
			return default(bool);
		}

		// Token: 0x06011ECC RID: 73420 RVA: 0x0006D9F8 File Offset: 0x0006BBF8
		[Token(Token = "0x6011ECC")]
		[Address(RVA = "0x9D68E0", Offset = "0x9D54E0", VA = "0x1809D68E0")]
		public static bool TryGetEquipTalentWithOrigin(CharacterData data, int level, EvolvePhase phase, int potential, List<CharacterData.UniqueEquipPair> currentQueries, List<CharacterData.UniqueEquipPair> targetQueries, out string equipTalentName, out string equipTalentDesc, out string originTalentDesc)
		{
			return default(bool);
		}

		// Token: 0x06011ECD RID: 73421 RVA: 0x0006DA10 File Offset: 0x0006BC10
		[Token(Token = "0x6011ECD")]
		[Address(RVA = "0x9D7A10", Offset = "0x9D6610", VA = "0x1809D7A10")]
		public static bool TryGetValidEquipTalent(int level, EvolvePhase phase, int potential, List<CharacterData.UniqueEquipPair> queries, bool isToken, out EquipTalentData equipTalentData)
		{
			return default(bool);
		}

		// Token: 0x06011ECE RID: 73422 RVA: 0x0006DA28 File Offset: 0x0006BC28
		[Token(Token = "0x6011ECE")]
		[Address(RVA = "0x9D8320", Offset = "0x9D6F20", VA = "0x1809D8320")]
		private static bool _TryGetEquipTalentHasDescription(int level, EvolvePhase phase, int potential, List<CharacterData.UniqueEquipPair> queries, bool isToken, out EquipTalentData equipTalentData)
		{
			return default(bool);
		}

		// Token: 0x06011ECF RID: 73423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011ECF")]
		[Address(RVA = "0x9D8140", Offset = "0x9D6D40", VA = "0x1809D8140")]
		private static string _GetOriginTalentDesc(CharacterData data, int level, EvolvePhase phase, int potential, int talentIndex)
		{
			return null;
		}

		// Token: 0x06011ED0 RID: 73424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011ED0")]
		[Address(RVA = "0x9D4620", Offset = "0x9D3220", VA = "0x1809D4620")]
		public static void AddEquipTraitData(BattleCharacterData battleChar, UniEquip equip, int level, EvolvePhase phase, int potential, ref CharacterData.TraitData traitData)
		{
		}

		// Token: 0x06011ED1 RID: 73425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011ED1")]
		[Address(RVA = "0x9D48A0", Offset = "0x9D34A0", VA = "0x1809D48A0")]
		public static Ability AddTraitPrefab(IList<UniEquip> equips, int level, EvolvePhase phase, int potential, Transform parent, Action<string, GameObject> onEquipProcessed)
		{
			return null;
		}

		// Token: 0x06011ED2 RID: 73426 RVA: 0x0006DA40 File Offset: 0x0006BC40
		[Token(Token = "0x6011ED2")]
		[Address(RVA = "0x9D7E70", Offset = "0x9D6A70", VA = "0x1809D7E70")]
		private static bool _DoAddTrait(string resKey, Transform parent, out Ability newTrait, out string equipOriginName)
		{
			return default(bool);
		}

		// Token: 0x06011ED3 RID: 73427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011ED3")]
		[Address(RVA = "0x9D4130", Offset = "0x9D2D30", VA = "0x1809D4130")]
		public static void AddEquipTalentData(BattleCharacterData battleChar, UniEquip equip, int level, EvolvePhase phase, int potential, IList<UniEquipTarget> equipTargetTypes, IList<TalentData> talentsData)
		{
		}

		// Token: 0x06011ED4 RID: 73428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011ED4")]
		[Address(RVA = "0x9D5730", Offset = "0x9D4330", VA = "0x1809D5730")]
		public static void ReplaceTalentPrefab(Unit unit, UnitMode[] unitModes, IList<UniEquip> equips, int level, EvolvePhase phase, int potential, Transform charDirection, Action<string, GameObject> onEquipProcessed)
		{
		}

		// Token: 0x06011ED5 RID: 73429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011ED5")]
		[Address(RVA = "0x9D88A0", Offset = "0x9D74A0", VA = "0x1809D88A0")]
		private static string _TryGetUniequipTalentKey(string rawTalentKey, out bool isRootTalent)
		{
			return null;
		}

		// Token: 0x06011ED6 RID: 73430 RVA: 0x0006DA58 File Offset: 0x0006BC58
		[Token(Token = "0x6011ED6")]
		[Address(RVA = "0x9D8010", Offset = "0x9D6C10", VA = "0x1809D8010")]
		private static bool _DoReplaceSingleTalent(BasicTalent originTalent, UniEquip uniEquip, string renamedTalentKey, Action<string, GameObject> onEquipProcessed, out string equipOriginName, out GameObject equipObject)
		{
			return default(bool);
		}

		// Token: 0x06011ED7 RID: 73431 RVA: 0x0006DA70 File Offset: 0x0006BC70
		[Token(Token = "0x6011ED7")]
		[Address(RVA = "0x9D7B00", Offset = "0x9D6700", VA = "0x1809D7B00")]
		private static bool _DoAddSingleTalent(Transform parentNode, UniEquip uniEquip, string renamedTalentKey, Action<string, GameObject> onEquipProcessed, out string equipOriginName, out GameObject equipObject)
		{
			return default(bool);
		}

		// Token: 0x06011ED8 RID: 73432 RVA: 0x0006DA88 File Offset: 0x0006BC88
		[Token(Token = "0x6011ED8")]
		[Address(RVA = "0x9D63D0", Offset = "0x9D4FD0", VA = "0x1809D63D0")]
		public static bool TryGetCurrentTalentData(CharacterData data, List<CharacterData.UniqueEquipPair> queries, bool isToken, int level, EvolvePhase phase, int potential, ref List<TalentData> talentDatas)
		{
			return default(bool);
		}

		// Token: 0x06011ED9 RID: 73433 RVA: 0x0006DAA0 File Offset: 0x0006BCA0
		[Token(Token = "0x6011ED9")]
		[Address(RVA = "0x9D5260", Offset = "0x9D3E60", VA = "0x1809D5260")]
		public static bool CheckIfEquipGainNewTalent(EquipTalentData equipTalentData)
		{
			return default(bool);
		}

		// Token: 0x04014346 RID: 82758
		[Token(Token = "0x4014346")]
		[FieldOffset(Offset = "0x0")]
		private static List<ITalentOwner> s_talentOwner;

		// Token: 0x04014347 RID: 82759
		[Token(Token = "0x4014347")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ClearStatic;

		// Token: 0x04014348 RID: 82760
		[Token(Token = "0x4014348")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckEquipValid;

		// Token: 0x04014349 RID: 82761
		[Token(Token = "0x4014349")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TryGetOverrideTraitData;

		// Token: 0x0401434A RID: 82762
		[Token(Token = "0x401434A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TryGetOverrideTalentData;

		// Token: 0x0401434B RID: 82763
		[Token(Token = "0x401434B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TryGetUniEquipPackData;

		// Token: 0x0401434C RID: 82764
		[Token(Token = "0x401434C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix1_TryGetOverrideTalentData;

		// Token: 0x0401434D RID: 82765
		[Token(Token = "0x401434D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckFilter;

		// Token: 0x0401434E RID: 82766
		[Token(Token = "0x401434E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix1_TryGetOverrideTraitData;

		// Token: 0x0401434F RID: 82767
		[Token(Token = "0x401434F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetTraitDescription;

		// Token: 0x04014350 RID: 82768
		[Token(Token = "0x4014350")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetTraitDescriptionInRichText;

		// Token: 0x04014351 RID: 82769
		[Token(Token = "0x4014351")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TryGetFirstEquipOverrideTraitData;

		// Token: 0x04014352 RID: 82770
		[Token(Token = "0x4014352")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_TryGetEquipTalentWithOrigin;

		// Token: 0x04014353 RID: 82771
		[Token(Token = "0x4014353")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_TryGetValidEquipTalent;

		// Token: 0x04014354 RID: 82772
		[Token(Token = "0x4014354")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__TryGetEquipTalentHasDescription;

		// Token: 0x04014355 RID: 82773
		[Token(Token = "0x4014355")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GetOriginTalentDesc;

		// Token: 0x04014356 RID: 82774
		[Token(Token = "0x4014356")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_AddEquipTraitData;

		// Token: 0x04014357 RID: 82775
		[Token(Token = "0x4014357")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_AddTraitPrefab;

		// Token: 0x04014358 RID: 82776
		[Token(Token = "0x4014358")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__DoAddTrait;

		// Token: 0x04014359 RID: 82777
		[Token(Token = "0x4014359")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_AddEquipTalentData;

		// Token: 0x0401435A RID: 82778
		[Token(Token = "0x401435A")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_ReplaceTalentPrefab;

		// Token: 0x0401435B RID: 82779
		[Token(Token = "0x401435B")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__TryGetUniequipTalentKey;

		// Token: 0x0401435C RID: 82780
		[Token(Token = "0x401435C")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__DoReplaceSingleTalent;

		// Token: 0x0401435D RID: 82781
		[Token(Token = "0x401435D")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__DoAddSingleTalent;

		// Token: 0x0401435E RID: 82782
		[Token(Token = "0x401435E")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_TryGetCurrentTalentData;

		// Token: 0x0401435F RID: 82783
		[Token(Token = "0x401435F")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_CheckIfEquipGainNewTalent;
	}
}
