using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using Torappu.Battle.UniEquip;
using Torappu.UI;

namespace Torappu.Battle
{
	// Token: 0x02002636 RID: 9782
	[Token(Token = "0x2002636")]
	[Serializable]
	public class BattleCharacterData : BattleEntityData
	{
		// Token: 0x06010017 RID: 65559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010017")]
		[Address(RVA = "0x774090", Offset = "0x772C90", VA = "0x180774090")]
		public string GetPrefabKey()
		{
			return null;
		}

		// Token: 0x06010018 RID: 65560 RVA: 0x000615D8 File Offset: 0x0005F7D8
		[Token(Token = "0x6010018")]
		[Address(RVA = "0x774040", Offset = "0x772C40", VA = "0x180774040")]
		public CharQuery GetCharQuery()
		{
			return default(CharQuery);
		}

		// Token: 0x06010019 RID: 65561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010019")]
		[Address(RVA = "0x773FD0", Offset = "0x772BD0", VA = "0x180773FD0")]
		public string GetAvatarId()
		{
			return null;
		}

		// Token: 0x0601001A RID: 65562 RVA: 0x000615F0 File Offset: 0x0005F7F0
		[Token(Token = "0x601001A")]
		[Address(RVA = "0x774100", Offset = "0x772D00", VA = "0x180774100")]
		public bool TryGetAttackRangeDescModel(Character characterOrNull, bool notLoadFromResource, out AttackRangeDescModel result)
		{
			return default(bool);
		}

		// Token: 0x0601001B RID: 65563 RVA: 0x00061608 File Offset: 0x0005F808
		[Token(Token = "0x601001B")]
		[Address(RVA = "0x773790", Offset = "0x772390", VA = "0x180773790")]
		public bool CheckGroupTag(IList<string> groupTags)
		{
			return default(bool);
		}

		// Token: 0x0601001C RID: 65564 RVA: 0x00061620 File Offset: 0x0005F820
		[Token(Token = "0x601001C")]
		[Address(RVA = "0x773960", Offset = "0x772560", VA = "0x180773960")]
		public bool CheckGroupTag(string groupTag)
		{
			return default(bool);
		}

		// Token: 0x0601001D RID: 65565 RVA: 0x00061638 File Offset: 0x0005F838
		[Token(Token = "0x601001D")]
		[Address(RVA = "0x773530", Offset = "0x772130", VA = "0x180773530")]
		public bool CheckGroupTagExceptExtraTag(string groupTag)
		{
			return default(bool);
		}

		// Token: 0x0601001E RID: 65566 RVA: 0x00061650 File Offset: 0x0005F850
		[Token(Token = "0x601001E")]
		[Address(RVA = "0x7740C0", Offset = "0x772CC0", VA = "0x1807740C0")]
		public BattleCharacterData.Signiture TakeSigniture()
		{
			return default(BattleCharacterData.Signiture);
		}

		// Token: 0x0601001F RID: 65567 RVA: 0x00061668 File Offset: 0x0005F868
		[Token(Token = "0x601001F")]
		[Address(RVA = "0x773A20", Offset = "0x772620", VA = "0x180773A20")]
		public bool CheckSubprofessionTag(string subprofessionTag)
		{
			return default(bool);
		}

		// Token: 0x06010020 RID: 65568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010020")]
		[Address(RVA = "0x773A50", Offset = "0x772650", VA = "0x180773A50")]
		public BattleCharacterData Duplicate()
		{
			return null;
		}

		// Token: 0x06010021 RID: 65569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010021")]
		[Address(RVA = "0x774370", Offset = "0x772F70", VA = "0x180774370")]
		public BattleCharacterData()
		{
		}

		// Token: 0x04011C7B RID: 72827
		[Token(Token = "0x4011C7B")]
		[FieldOffset(Offset = "0x40")]
		public int level;

		// Token: 0x04011C7C RID: 72828
		[Token(Token = "0x4011C7C")]
		[FieldOffset(Offset = "0x44")]
		public EvolvePhase evolvePhase;

		// Token: 0x04011C7D RID: 72829
		[Token(Token = "0x4011C7D")]
		[FieldOffset(Offset = "0x48")]
		public int potentialRank;

		// Token: 0x04011C7E RID: 72830
		[Token(Token = "0x4011C7E")]
		[FieldOffset(Offset = "0x4C")]
		public int favorBattlePhase;

		// Token: 0x04011C7F RID: 72831
		[Token(Token = "0x4011C7F")]
		[FieldOffset(Offset = "0x50")]
		public string prefabKey;

		// Token: 0x04011C80 RID: 72832
		[Token(Token = "0x4011C80")]
		[FieldOffset(Offset = "0x58")]
		public string rangeId;

		// Token: 0x04011C81 RID: 72833
		[Token(Token = "0x4011C81")]
		[FieldOffset(Offset = "0x60")]
		public CharSkinData skinData;

		// Token: 0x04011C82 RID: 72834
		[Token(Token = "0x4011C82")]
		[FieldOffset(Offset = "0x68")]
		public bool showSpIllust;

		// Token: 0x04011C83 RID: 72835
		[Token(Token = "0x4011C83")]
		[FieldOffset(Offset = "0x6C")]
		public uint uniqueId;

		// Token: 0x04011C84 RID: 72836
		[Token(Token = "0x4011C84")]
		[FieldOffset(Offset = "0x70")]
		public ProfessionCategory profession;

		// Token: 0x04011C85 RID: 72837
		[Token(Token = "0x4011C85")]
		[FieldOffset(Offset = "0x78")]
		public SubProfessionData subProfessionData;

		// Token: 0x04011C86 RID: 72838
		[Token(Token = "0x4011C86")]
		[FieldOffset(Offset = "0x80")]
		public RarityRank rarity;

		// Token: 0x04011C87 RID: 72839
		[Token(Token = "0x4011C87")]
		[FieldOffset(Offset = "0x84")]
		public BuildableType deployPositionFromData;

		// Token: 0x04011C88 RID: 72840
		[Token(Token = "0x4011C88")]
		[FieldOffset(Offset = "0x88")]
		public string teamKey;

		// Token: 0x04011C89 RID: 72841
		[Token(Token = "0x4011C89")]
		[FieldOffset(Offset = "0x90")]
		public bool isToken;

		// Token: 0x04011C8A RID: 72842
		[Token(Token = "0x4011C8A")]
		[FieldOffset(Offset = "0x91")]
		public bool isPredefined;

		// Token: 0x04011C8B RID: 72843
		[Token(Token = "0x4011C8B")]
		[FieldOffset(Offset = "0x92")]
		public bool isHidden;

		// Token: 0x04011C8C RID: 72844
		[Token(Token = "0x4011C8C")]
		[FieldOffset(Offset = "0x93")]
		public bool isAssistChar;

		// Token: 0x04011C8D RID: 72845
		[Token(Token = "0x4011C8D")]
		[FieldOffset(Offset = "0x98")]
		public string tokenOrHostKey;

		// Token: 0x04011C8E RID: 72846
		[Token(Token = "0x4011C8E")]
		[FieldOffset(Offset = "0xA0")]
		public uint tokenOrHostUniqueId;

		// Token: 0x04011C8F RID: 72847
		[Token(Token = "0x4011C8F")]
		[FieldOffset(Offset = "0xA4")]
		public int tokenInitialCnt;

		// Token: 0x04011C90 RID: 72848
		[Token(Token = "0x4011C90")]
		[FieldOffset(Offset = "0xA8")]
		public BuildCondition buildCondition;

		// Token: 0x04011C91 RID: 72849
		[Token(Token = "0x4011C91")]
		[FieldOffset(Offset = "0xF8")]
		public int mainSkillIndex;

		// Token: 0x04011C92 RID: 72850
		[Token(Token = "0x4011C92")]
		[FieldOffset(Offset = "0x100")]
		public SkillData mainSkill;

		// Token: 0x04011C93 RID: 72851
		[Token(Token = "0x4011C93")]
		[FieldOffset(Offset = "0x108")]
		public List<TalentData> talents;

		// Token: 0x04011C94 RID: 72852
		[Token(Token = "0x4011C94")]
		[FieldOffset(Offset = "0x110")]
		public CharacterData.TraitData trait;

		// Token: 0x04011C95 RID: 72853
		[Token(Token = "0x4011C95")]
		[FieldOffset(Offset = "0x118")]
		public List<CharacterData.UniqueEquipPair> uniEquipQueries;

		// Token: 0x04011C96 RID: 72854
		[Token(Token = "0x4011C96")]
		[FieldOffset(Offset = "0x120")]
		public List<UniEquip> uniEquips;

		// Token: 0x04011C97 RID: 72855
		[Token(Token = "0x4011C97")]
		[FieldOffset(Offset = "0x128")]
		public List<BattleUniEquipSetting> uniEquipSettings;

		// Token: 0x04011C98 RID: 72856
		[Token(Token = "0x4011C98")]
		[FieldOffset(Offset = "0x130")]
		public string nationId;

		// Token: 0x04011C99 RID: 72857
		[Token(Token = "0x4011C99")]
		[FieldOffset(Offset = "0x138")]
		public string groupId;

		// Token: 0x04011C9A RID: 72858
		[Token(Token = "0x4011C9A")]
		[FieldOffset(Offset = "0x140")]
		public string teamId;

		// Token: 0x04011C9B RID: 72859
		[Token(Token = "0x4011C9B")]
		[FieldOffset(Offset = "0x148")]
		public CharacterData.PowerData[] subPower;

		// Token: 0x04011C9C RID: 72860
		[Token(Token = "0x4011C9C")]
		[FieldOffset(Offset = "0x150")]
		[NonSerialized]
		public BattleCharacterData.SharedData shared;

		// Token: 0x04011C9D RID: 72861
		[Token(Token = "0x4011C9D")]
		[FieldOffset(Offset = "0x158")]
		[NonSerialized]
		public AttackRangeDescModel? attackRangeDesc;

		// Token: 0x04011C9E RID: 72862
		[Token(Token = "0x4011C9E")]
		[FieldOffset(Offset = "0x170")]
		[NonSerialized]
		public BattleCharacterData.RuntimeData runtimeData;

		// Token: 0x02002637 RID: 9783
		[Token(Token = "0x2002637")]
		public struct Signiture : IEquatable<BattleCharacterData.Signiture>
		{
			// Token: 0x06010022 RID: 65570 RVA: 0x00061680 File Offset: 0x0005F880
			[Token(Token = "0x6010022")]
			[Address(RVA = "0x7846C0", Offset = "0x7832C0", VA = "0x1807846C0", Slot = "4")]
			public bool Equals(BattleCharacterData.Signiture other)
			{
				return default(bool);
			}

			// Token: 0x06010023 RID: 65571 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010023")]
			[Address(RVA = "0x7846E0", Offset = "0x7832E0", VA = "0x1807846E0")]
			public StringBuilder ToStringBuilder()
			{
				return null;
			}

			// Token: 0x04011C9F RID: 72863
			[Token(Token = "0x4011C9F")]
			[FieldOffset(Offset = "0x0")]
			public uint uniqueId;

			// Token: 0x04011CA0 RID: 72864
			[Token(Token = "0x4011CA0")]
			[FieldOffset(Offset = "0x8")]
			public string charId;
		}

		// Token: 0x02002638 RID: 9784
		[Token(Token = "0x2002638")]
		public class SharedData
		{
			// Token: 0x06010024 RID: 65572 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010024")]
			[Address(RVA = "0x784600", Offset = "0x783200", VA = "0x180784600")]
			public SharedData()
			{
			}

			// Token: 0x04011CA1 RID: 72865
			[Token(Token = "0x4011CA1")]
			[FieldOffset(Offset = "0x10")]
			public int skillTriggerCnt;

			// Token: 0x04011CA2 RID: 72866
			[Token(Token = "0x4011CA2")]
			[FieldOffset(Offset = "0x14")]
			public int spScaleCnt;

			// Token: 0x04011CA3 RID: 72867
			[Token(Token = "0x4011CA3")]
			[FieldOffset(Offset = "0x18")]
			public int? originCost;

			// Token: 0x04011CA4 RID: 72868
			[Token(Token = "0x4011CA4")]
			[FieldOffset(Offset = "0x20")]
			public int buildCnt;

			// Token: 0x04011CA5 RID: 72869
			[Token(Token = "0x4011CA5")]
			[FieldOffset(Offset = "0x24")]
			public int deathCnt;

			// Token: 0x04011CA6 RID: 72870
			[Token(Token = "0x4011CA6")]
			[FieldOffset(Offset = "0x28")]
			public List<ObjectPtr<Projectile>> managedProjectiles;

			// Token: 0x04011CA7 RID: 72871
			[Token(Token = "0x4011CA7")]
			[FieldOffset(Offset = "0x30")]
			public Entity.FinishReason lastFinishReason;

			// Token: 0x04011CA8 RID: 72872
			[Token(Token = "0x4011CA8")]
			[FieldOffset(Offset = "0x34")]
			public ProfessionCategory extraProfession;

			// Token: 0x04011CA9 RID: 72873
			[Token(Token = "0x4011CA9")]
			[FieldOffset(Offset = "0x38")]
			public Blackboard blackboard;

			// Token: 0x04011CAA RID: 72874
			[Token(Token = "0x4011CAA")]
			[FieldOffset(Offset = "0x40")]
			public object extraDatas;

			// Token: 0x04011CAB RID: 72875
			[Token(Token = "0x4011CAB")]
			[FieldOffset(Offset = "0x48")]
			public Dictionary<string, Blackboard> externalBlackboardDict;
		}

		// Token: 0x02002639 RID: 9785
		[Token(Token = "0x2002639")]
		public class RuntimeData
		{
			// Token: 0x06010025 RID: 65573 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010025")]
			[Address(RVA = "0x784530", Offset = "0x783130", VA = "0x180784530")]
			public RuntimeData()
			{
			}

			// Token: 0x04011CAC RID: 72876
			[Token(Token = "0x4011CAC")]
			[FieldOffset(Offset = "0x10")]
			public List<DynamicAbilityData> dynamicAbilities;

			// Token: 0x04011CAD RID: 72877
			[Token(Token = "0x4011CAD")]
			[FieldOffset(Offset = "0x18")]
			public string overrideAvatarID;

			// Token: 0x04011CAE RID: 72878
			[Token(Token = "0x4011CAE")]
			[FieldOffset(Offset = "0x20")]
			public List<string> extraGroupTags;
		}
	}
}
