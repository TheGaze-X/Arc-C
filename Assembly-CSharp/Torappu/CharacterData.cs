using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using XLua;

namespace Torappu
{
	// Token: 0x02000F52 RID: 3922
	[Token(Token = "0x2000F52")]
	[Serializable]
	public class CharacterData
	{
		// Token: 0x06006C60 RID: 27744 RVA: 0x00031740 File Offset: 0x0002F940
		[Token(Token = "0x6006C60")]
		[Address(RVA = "0x20077F0", Offset = "0x20063F0", VA = "0x1820077F0")]
		public bool ShouldSerializeclassicPotentialItemId()
		{
			return default(bool);
		}

		// Token: 0x06006C61 RID: 27745 RVA: 0x00031758 File Offset: 0x0002F958
		[Token(Token = "0x6006C61")]
		[Address(RVA = "0x20083F0", Offset = "0x2006FF0", VA = "0x1820083F0")]
		public bool ShouldSerializedisplayTokenDict()
		{
			return default(bool);
		}

		// Token: 0x06006C62 RID: 27746 RVA: 0x00031770 File Offset: 0x0002F970
		[Token(Token = "0x6006C62")]
		[Address(RVA = "0x2008440", Offset = "0x2007040", VA = "0x182008440")]
		public bool ShouldSerializesubPower()
		{
			return default(bool);
		}

		// Token: 0x06006C63 RID: 27747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C63")]
		[Address(RVA = "0x2008310", Offset = "0x2006F10", VA = "0x182008310")]
		public string GetRawDescriptionFormatByTraitBlackboard(int level, EvolvePhase phase, int potential)
		{
			return null;
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x06006C64 RID: 27748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D07")]
		public string minPowerId
		{
			[Token(Token = "0x6006C64")]
			[Address(RVA = "0x2008510", Offset = "0x2007110", VA = "0x182008510")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x06006C65 RID: 27749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D08")]
		public string maxPowerId
		{
			[Token(Token = "0x6006C65")]
			[Address(RVA = "0x2008490", Offset = "0x2007090", VA = "0x182008490")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006C66 RID: 27750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C66")]
		[Address(RVA = "0x20082F0", Offset = "0x2006EF0", VA = "0x1820082F0")]
		public string GetPowerIdByLevel(HandbookTeamDB.PowerLevel level)
		{
			return null;
		}

		// Token: 0x06006C67 RID: 27751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C67")]
		[Address(RVA = "0x2008240", Offset = "0x2006E40", VA = "0x182008240")]
		public static string GetMinPowerId(CharacterData.PowerData power)
		{
			return null;
		}

		// Token: 0x06006C68 RID: 27752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C68")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CharacterData()
		{
		}

		// Token: 0x04005365 RID: 21349
		[Token(Token = "0x4005365")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04005366 RID: 21350
		[Token(Token = "0x4005366")]
		[FieldOffset(Offset = "0x18")]
		public string description;

		// Token: 0x04005367 RID: 21351
		[Token(Token = "0x4005367")]
		[FieldOffset(Offset = "0x20")]
		public int sortIndex;

		// Token: 0x04005368 RID: 21352
		[Token(Token = "0x4005368")]
		[FieldOffset(Offset = "0x24")]
		public SpecialOperatorTargetType spTargetType;

		// Token: 0x04005369 RID: 21353
		[Token(Token = "0x4005369")]
		[FieldOffset(Offset = "0x28")]
		public string spTargetId;

		// Token: 0x0400536A RID: 21354
		[Token(Token = "0x400536A")]
		[FieldOffset(Offset = "0x30")]
		public bool canUseGeneralPotentialItem;

		// Token: 0x0400536B RID: 21355
		[Token(Token = "0x400536B")]
		[FieldOffset(Offset = "0x31")]
		public bool canUseActivityPotentialItem;

		// Token: 0x0400536C RID: 21356
		[Token(Token = "0x400536C")]
		[FieldOffset(Offset = "0x38")]
		public string potentialItemId;

		// Token: 0x0400536D RID: 21357
		[Token(Token = "0x400536D")]
		[FieldOffset(Offset = "0x40")]
		public string activityPotentialItemId;

		// Token: 0x0400536E RID: 21358
		[Token(Token = "0x400536E")]
		[FieldOffset(Offset = "0x48")]
		public string classicPotentialItemId;

		// Token: 0x0400536F RID: 21359
		[Token(Token = "0x400536F")]
		[FieldOffset(Offset = "0x50")]
		public string nationId;

		// Token: 0x04005370 RID: 21360
		[Token(Token = "0x4005370")]
		[FieldOffset(Offset = "0x58")]
		public string groupId;

		// Token: 0x04005371 RID: 21361
		[Token(Token = "0x4005371")]
		[FieldOffset(Offset = "0x60")]
		public string teamId;

		// Token: 0x04005372 RID: 21362
		[Token(Token = "0x4005372")]
		[FieldOffset(Offset = "0x68")]
		public CharacterData.PowerData mainPower;

		// Token: 0x04005373 RID: 21363
		[Token(Token = "0x4005373")]
		[FieldOffset(Offset = "0x80")]
		public CharacterData.PowerData[] subPower;

		// Token: 0x04005374 RID: 21364
		[Token(Token = "0x4005374")]
		[FieldOffset(Offset = "0x88")]
		public string displayNumber;

		// Token: 0x04005375 RID: 21365
		[Token(Token = "0x4005375")]
		[FieldOffset(Offset = "0x90")]
		public string appellation;

		// Token: 0x04005376 RID: 21366
		[Token(Token = "0x4005376")]
		[FieldOffset(Offset = "0x98")]
		[JsonConverter(typeof(StringEnumConverter))]
		public BuildableType position;

		// Token: 0x04005377 RID: 21367
		[Token(Token = "0x4005377")]
		[FieldOffset(Offset = "0xA0")]
		public string[] tagList;

		// Token: 0x04005378 RID: 21368
		[Token(Token = "0x4005378")]
		[FieldOffset(Offset = "0xA8")]
		public string itemUsage;

		// Token: 0x04005379 RID: 21369
		[Token(Token = "0x4005379")]
		[FieldOffset(Offset = "0xB0")]
		public string itemDesc;

		// Token: 0x0400537A RID: 21370
		[Token(Token = "0x400537A")]
		[FieldOffset(Offset = "0xB8")]
		public string itemObtainApproach;

		// Token: 0x0400537B RID: 21371
		[Token(Token = "0x400537B")]
		[FieldOffset(Offset = "0xC0")]
		public bool isNotObtainable;

		// Token: 0x0400537C RID: 21372
		[Token(Token = "0x400537C")]
		[FieldOffset(Offset = "0xC1")]
		public bool isSpChar;

		// Token: 0x0400537D RID: 21373
		[Token(Token = "0x400537D")]
		[FieldOffset(Offset = "0xC4")]
		public int maxPotentialLevel;

		// Token: 0x0400537E RID: 21374
		[Token(Token = "0x400537E")]
		[FieldOffset(Offset = "0xC8")]
		public RarityRank rarity;

		// Token: 0x0400537F RID: 21375
		[Token(Token = "0x400537F")]
		[FieldOffset(Offset = "0xCC")]
		[JsonConverter(typeof(StringEnumConverter))]
		public ProfessionCategory profession;

		// Token: 0x04005380 RID: 21376
		[Token(Token = "0x4005380")]
		[FieldOffset(Offset = "0xD0")]
		public string subProfessionId;

		// Token: 0x04005381 RID: 21377
		[Token(Token = "0x4005381")]
		[FieldOffset(Offset = "0xD8")]
		public CharacterData.TraitDataBundle trait;

		// Token: 0x04005382 RID: 21378
		[Token(Token = "0x4005382")]
		[FieldOffset(Offset = "0xE0")]
		public CharacterData.PhaseData[] phases;

		// Token: 0x04005383 RID: 21379
		[Token(Token = "0x4005383")]
		[FieldOffset(Offset = "0xE8")]
		public CharacterData.MainSkill[] skills;

		// Token: 0x04005384 RID: 21380
		[Token(Token = "0x4005384")]
		[FieldOffset(Offset = "0xF0")]
		public Dictionary<string, bool> displayTokenDict;

		// Token: 0x04005385 RID: 21381
		[Token(Token = "0x4005385")]
		[FieldOffset(Offset = "0xF8")]
		public CharacterData.TalentDataBundle[] talents;

		// Token: 0x04005386 RID: 21382
		[Token(Token = "0x4005386")]
		[FieldOffset(Offset = "0x100")]
		public CharacterData.PotentialRank[] potentialRanks;

		// Token: 0x04005387 RID: 21383
		[Token(Token = "0x4005387")]
		[FieldOffset(Offset = "0x108")]
		public CharacterData.AttributesDeltaKeyFrame favorKeyFrames;

		// Token: 0x04005388 RID: 21384
		[Token(Token = "0x4005388")]
		[FieldOffset(Offset = "0x110")]
		public CharacterData.SkillLevelCost[] allSkillLvlup;

		// Token: 0x02000F53 RID: 3923
		[Token(Token = "0x2000F53")]
		[Serializable]
		public class AttributesKeyFrame : KeyFrames<AttributesData>
		{
			// Token: 0x06006C69 RID: 27753 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006C69")]
			[Address(RVA = "0x2001070", Offset = "0x1FFFC70", VA = "0x182001070", Slot = "35")]
			protected override AttributesData LerpData(KeyFrames<AttributesData, AttributesData>.KeyFrame from, KeyFrames<AttributesData, AttributesData>.KeyFrame to, int level)
			{
				return null;
			}

			// Token: 0x06006C6A RID: 27754 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C6A")]
			[Address(RVA = "0x2001140", Offset = "0x1FFFD40", VA = "0x182001140")]
			public AttributesKeyFrame()
			{
			}
		}

		// Token: 0x02000F54 RID: 3924
		[Token(Token = "0x2000F54")]
		[Serializable]
		public class AttributesDeltaKeyFrame : KeyFrames<AttributesDeltaData, AttributesData>
		{
			// Token: 0x06006C6B RID: 27755 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006C6B")]
			[Address(RVA = "0x2000F60", Offset = "0x1FFFB60", VA = "0x182000F60", Slot = "35")]
			protected override AttributesData LerpData(KeyFrames<AttributesDeltaData, AttributesData>.KeyFrame from, KeyFrames<AttributesDeltaData, AttributesData>.KeyFrame to, int level)
			{
				return null;
			}

			// Token: 0x06006C6C RID: 27756 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C6C")]
			[Address(RVA = "0x2001030", Offset = "0x1FFFC30", VA = "0x182001030")]
			public AttributesDeltaKeyFrame()
			{
			}
		}

		// Token: 0x02000F55 RID: 3925
		[Token(Token = "0x2000F55")]
		[Serializable]
		public struct UnlockCondition : IComparable<CharacterData.UnlockCondition>
		{
			// Token: 0x06006C6D RID: 27757 RVA: 0x00031788 File Offset: 0x0002F988
			[Token(Token = "0x6006C6D")]
			[Address(RVA = "0x200E550", Offset = "0x200D150", VA = "0x18200E550")]
			public bool Validate(int level, EvolvePhase phase)
			{
				return default(bool);
			}

			// Token: 0x06006C6E RID: 27758 RVA: 0x000317A0 File Offset: 0x0002F9A0
			[Token(Token = "0x6006C6E")]
			[Address(RVA = "0x200E4B0", Offset = "0x200D0B0", VA = "0x18200E4B0", Slot = "4")]
			public int CompareTo(CharacterData.UnlockCondition other)
			{
				return 0;
			}

			// Token: 0x04005389 RID: 21385
			[Token(Token = "0x4005389")]
			[FieldOffset(Offset = "0x0")]
			public EvolvePhase phase;

			// Token: 0x0400538A RID: 21386
			[Token(Token = "0x400538A")]
			[FieldOffset(Offset = "0x4")]
			public int level;
		}

		// Token: 0x02000F56 RID: 3926
		[Token(Token = "0x2000F56")]
		[Serializable]
		public class TalentDataBundle
		{
			// Token: 0x06006C6F RID: 27759 RVA: 0x000317B8 File Offset: 0x0002F9B8
			[Token(Token = "0x6006C6F")]
			[Address(RVA = "0x2116D90", Offset = "0x2115990", VA = "0x182116D90")]
			public bool TryGetTalent(int level, EvolvePhase phase, int potential, out TalentData talent)
			{
				return default(bool);
			}

			// Token: 0x06006C70 RID: 27760 RVA: 0x000317D0 File Offset: 0x0002F9D0
			[Token(Token = "0x6006C70")]
			[Address(RVA = "0x21166F0", Offset = "0x21152F0", VA = "0x1821166F0")]
			protected static bool DoGetTalent(TalentData[] candidates, int level, EvolvePhase phase, int potential, out TalentData talent)
			{
				return default(bool);
			}

			// Token: 0x06006C71 RID: 27761 RVA: 0x000317E8 File Offset: 0x0002F9E8
			[Token(Token = "0x6006C71")]
			[Address(RVA = "0x2116940", Offset = "0x2115540", VA = "0x182116940")]
			public bool TryGetInitTalent(out TalentData talentData)
			{
				return default(bool);
			}

			// Token: 0x06006C72 RID: 27762 RVA: 0x00031800 File Offset: 0x0002FA00
			[Token(Token = "0x6006C72")]
			[Address(RVA = "0x2116B30", Offset = "0x2115730", VA = "0x182116B30")]
			public bool TryGetNextTalent(int level, EvolvePhase phase, int potential, out TalentData talent)
			{
				return default(bool);
			}

			// Token: 0x06006C73 RID: 27763 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C73")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TalentDataBundle()
			{
			}

			// Token: 0x0400538B RID: 21387
			[Token(Token = "0x400538B")]
			[FieldOffset(Offset = "0x10")]
			public TalentData[] candidates;
		}

		// Token: 0x02000F58 RID: 3928
		[Token(Token = "0x2000F58")]
		[Serializable]
		public class MasterData
		{
			// Token: 0x06006C79 RID: 27769 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C79")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MasterData()
			{
			}

			// Token: 0x04005390 RID: 21392
			[Token(Token = "0x4005390")]
			[FieldOffset(Offset = "0x10")]
			public int level;

			// Token: 0x04005391 RID: 21393
			[Token(Token = "0x4005391")]
			[FieldOffset(Offset = "0x18")]
			public string masterId;

			// Token: 0x04005392 RID: 21394
			[Token(Token = "0x4005392")]
			[FieldOffset(Offset = "0x20")]
			public TalentData talentData;
		}

		// Token: 0x02000F59 RID: 3929
		[Token(Token = "0x2000F59")]
		[Serializable]
		public class MasterDataBundle
		{
			// Token: 0x06006C7A RID: 27770 RVA: 0x00031860 File Offset: 0x0002FA60
			[Token(Token = "0x6006C7A")]
			[Address(RVA = "0x2107870", Offset = "0x2106470", VA = "0x182107870")]
			public bool TryGetMaster(CharacterData.MasterInfo masterInfo, out TalentData data)
			{
				return default(bool);
			}

			// Token: 0x06006C7B RID: 27771 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C7B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MasterDataBundle()
			{
			}

			// Token: 0x04005393 RID: 21395
			[Token(Token = "0x4005393")]
			[FieldOffset(Offset = "0x10")]
			public CharacterData.MasterData[] candidates;
		}

		// Token: 0x02000F5A RID: 3930
		[Token(Token = "0x2000F5A")]
		[Serializable]
		public class EquipTalentDataBundle : CharacterData.TalentDataBundle
		{
			// Token: 0x06006C7C RID: 27772 RVA: 0x00031878 File Offset: 0x0002FA78
			[Token(Token = "0x6006C7C")]
			[Address(RVA = "0x2103F70", Offset = "0x2102B70", VA = "0x182103F70")]
			public bool TryGetTalent(int level, EvolvePhase phase, int potential, out EquipTalentData equipTalent)
			{
				return default(bool);
			}

			// Token: 0x06006C7D RID: 27773 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C7D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EquipTalentDataBundle()
			{
			}

			// Token: 0x04005394 RID: 21396
			[Token(Token = "0x4005394")]
			[FieldOffset(Offset = "0x18")]
			public new EquipTalentData[] candidates;
		}

		// Token: 0x02000F5B RID: 3931
		[Token(Token = "0x2000F5B")]
		[Serializable]
		public class TraitData : IHotfixable
		{
			// Token: 0x17000D09 RID: 3337
			// (get) Token: 0x06006C7E RID: 27774 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000D09")]
			public virtual string additionalDesc
			{
				[Token(Token = "0x6006C7E")]
				[Address(RVA = "0x2117610", Offset = "0x2116210", VA = "0x182117610", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x06006C7F RID: 27775 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006C7F")]
			[Address(RVA = "0x2117350", Offset = "0x2115F50", VA = "0x182117350")]
			public string ConcatTraitDescription(string defaultDescription)
			{
				return null;
			}

			// Token: 0x06006C80 RID: 27776 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006C80")]
			[Address(RVA = "0x2117450", Offset = "0x2116050", VA = "0x182117450")]
			public CharacterData.TraitData Duplicate()
			{
				return null;
			}

			// Token: 0x06006C81 RID: 27777 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C81")]
			[Address(RVA = "0x21175B0", Offset = "0x21161B0", VA = "0x1821175B0")]
			public TraitData()
			{
			}

			// Token: 0x04005395 RID: 21397
			[Token(Token = "0x4005395")]
			[FieldOffset(Offset = "0x10")]
			public CharacterData.UnlockCondition unlockCondition;

			// Token: 0x04005396 RID: 21398
			[Token(Token = "0x4005396")]
			[FieldOffset(Offset = "0x18")]
			public int requiredPotentialRank;

			// Token: 0x04005397 RID: 21399
			[Token(Token = "0x4005397")]
			[FieldOffset(Offset = "0x20")]
			public Blackboard blackboard;

			// Token: 0x04005398 RID: 21400
			[Token(Token = "0x4005398")]
			[FieldOffset(Offset = "0x28")]
			public string overrideDescripton;

			// Token: 0x04005399 RID: 21401
			[Token(Token = "0x4005399")]
			[FieldOffset(Offset = "0x30")]
			public string prefabKey;

			// Token: 0x0400539A RID: 21402
			[Token(Token = "0x400539A")]
			[FieldOffset(Offset = "0x38")]
			public string rangeId;

			// Token: 0x0400539B RID: 21403
			[Token(Token = "0x400539B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_additionalDesc;

			// Token: 0x0400539C RID: 21404
			[Token(Token = "0x400539C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ConcatTraitDescription;

			// Token: 0x0400539D RID: 21405
			[Token(Token = "0x400539D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Duplicate;

			// Token: 0x0400539E RID: 21406
			[Token(Token = "0x400539E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02000F5C RID: 3932
		[Token(Token = "0x2000F5C")]
		[Serializable]
		public class EquipTraitData : CharacterData.TraitData
		{
			// Token: 0x17000D0A RID: 3338
			// (get) Token: 0x06006C82 RID: 27778 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000D0A")]
			[JsonIgnore]
			public override string additionalDesc
			{
				[Token(Token = "0x6006C82")]
				[Address(RVA = "0x2104350", Offset = "0x2102F50", VA = "0x182104350", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x06006C83 RID: 27779 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C83")]
			[Address(RVA = "0x21042B0", Offset = "0x2102EB0", VA = "0x1821042B0")]
			public EquipTraitData()
			{
			}

			// Token: 0x06006C84 RID: 27780 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006C84")]
			[Address(RVA = "0x2104240", Offset = "0x2102E40", VA = "0x182104240")]
			private string <>xLuaBaseProxy_get_additionalDesc()
			{
				return null;
			}

			// Token: 0x0400539F RID: 21407
			[Token(Token = "0x400539F")]
			[FieldOffset(Offset = "0x40")]
			public string additionalDescription;

			// Token: 0x040053A0 RID: 21408
			[Token(Token = "0x40053A0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_additionalDesc;

			// Token: 0x040053A1 RID: 21409
			[Token(Token = "0x40053A1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02000F5D RID: 3933
		[Token(Token = "0x2000F5D")]
		[Serializable]
		public class TraitDataBundle
		{
			// Token: 0x06006C85 RID: 27781 RVA: 0x00031890 File Offset: 0x0002FA90
			[Token(Token = "0x6006C85")]
			[Address(RVA = "0x21172C0", Offset = "0x2115EC0", VA = "0x1821172C0")]
			public bool TryGetTrait(int level, EvolvePhase phase, int potential, out CharacterData.TraitData trait)
			{
				return default(bool);
			}

			// Token: 0x06006C86 RID: 27782 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C86")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TraitDataBundle()
			{
			}

			// Token: 0x040053A2 RID: 21410
			[Token(Token = "0x40053A2")]
			[FieldOffset(Offset = "0x10")]
			public CharacterData.TraitData[] candidates;
		}

		// Token: 0x02000F5E RID: 3934
		[Token(Token = "0x2000F5E")]
		public class EquipTraitDataBundle
		{
			// Token: 0x06006C87 RID: 27783 RVA: 0x000318A8 File Offset: 0x0002FAA8
			[Token(Token = "0x6006C87")]
			[Address(RVA = "0x21040C0", Offset = "0x2102CC0", VA = "0x1821040C0")]
			public bool TryGetTrait(int level, EvolvePhase phase, int potential, out CharacterData.EquipTraitData equipTalent)
			{
				return default(bool);
			}

			// Token: 0x06006C88 RID: 27784 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C88")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EquipTraitDataBundle()
			{
			}

			// Token: 0x040053A3 RID: 21411
			[Token(Token = "0x40053A3")]
			[FieldOffset(Offset = "0x10")]
			public CharacterData.EquipTraitData[] candidates;
		}

		// Token: 0x02000F5F RID: 3935
		[Token(Token = "0x2000F5F")]
		[Serializable]
		public class PhaseData
		{
			// Token: 0x06006C89 RID: 27785 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C89")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PhaseData()
			{
			}

			// Token: 0x040053A4 RID: 21412
			[Token(Token = "0x40053A4")]
			[FieldOffset(Offset = "0x10")]
			public string characterPrefabKey;

			// Token: 0x040053A5 RID: 21413
			[Token(Token = "0x40053A5")]
			[FieldOffset(Offset = "0x18")]
			public string rangeId;

			// Token: 0x040053A6 RID: 21414
			[Token(Token = "0x40053A6")]
			[FieldOffset(Offset = "0x20")]
			public int maxLevel;

			// Token: 0x040053A7 RID: 21415
			[Token(Token = "0x40053A7")]
			[FieldOffset(Offset = "0x28")]
			public CharacterData.AttributesKeyFrame attributesKeyFrames;

			// Token: 0x040053A8 RID: 21416
			[Token(Token = "0x40053A8")]
			[FieldOffset(Offset = "0x30")]
			public ItemBundle[] evolveCost;
		}

		// Token: 0x02000F60 RID: 3936
		[Token(Token = "0x2000F60")]
		[Serializable]
		public class MainSkill
		{
			// Token: 0x06006C8A RID: 27786 RVA: 0x000318C0 File Offset: 0x0002FAC0
			[Token(Token = "0x6006C8A")]
			[Address(RVA = "0x21072F0", Offset = "0x2105EF0", VA = "0x1821072F0")]
			public bool TryGetUnlockCondition(int totalLvl, out CharacterData.UnlockCondition condition)
			{
				return default(bool);
			}

			// Token: 0x06006C8B RID: 27787 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C8B")]
			[Address(RVA = "0x21073C0", Offset = "0x2105FC0", VA = "0x1821073C0")]
			public MainSkill()
			{
			}

			// Token: 0x040053A9 RID: 21417
			[Token(Token = "0x40053A9")]
			[FieldOffset(Offset = "0x10")]
			public string skillId;

			// Token: 0x040053AA RID: 21418
			[Token(Token = "0x40053AA")]
			[FieldOffset(Offset = "0x18")]
			public string overridePrefabKey;

			// Token: 0x040053AB RID: 21419
			[Token(Token = "0x40053AB")]
			[FieldOffset(Offset = "0x20")]
			public string overrideTokenKey;

			// Token: 0x040053AC RID: 21420
			[Token(Token = "0x40053AC")]
			[FieldOffset(Offset = "0x28")]
			[JsonProperty("levelUpCostCond")]
			public CharacterData.MainSkill.SpecializeLevelData[] specializeLevelUpData;

			// Token: 0x040053AD RID: 21421
			[Token(Token = "0x40053AD")]
			[FieldOffset(Offset = "0x30")]
			[JsonProperty("unlockCond")]
			public CharacterData.UnlockCondition initialUnlockCond;

			// Token: 0x02000F61 RID: 3937
			[Token(Token = "0x2000F61")]
			[Serializable]
			public class SpecializeLevelData
			{
				// Token: 0x06006C8C RID: 27788 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006C8C")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public SpecializeLevelData()
				{
				}

				// Token: 0x040053AE RID: 21422
				[Token(Token = "0x40053AE")]
				[FieldOffset(Offset = "0x10")]
				public CharacterData.UnlockCondition unlockCond;

				// Token: 0x040053AF RID: 21423
				[Token(Token = "0x40053AF")]
				[FieldOffset(Offset = "0x18")]
				public int lvlUpTime;

				// Token: 0x040053B0 RID: 21424
				[Token(Token = "0x40053B0")]
				[FieldOffset(Offset = "0x20")]
				public ItemBundle[] levelUpCost;
			}
		}

		// Token: 0x02000F62 RID: 3938
		[Token(Token = "0x2000F62")]
		[Serializable]
		public class PotentialRank
		{
			// Token: 0x06006C8D RID: 27789 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C8D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PotentialRank()
			{
			}

			// Token: 0x040053B1 RID: 21425
			[Token(Token = "0x40053B1")]
			[FieldOffset(Offset = "0x10")]
			public CharacterData.PotentialRank.TypeEnum type;

			// Token: 0x040053B2 RID: 21426
			[Token(Token = "0x40053B2")]
			[FieldOffset(Offset = "0x18")]
			public string description;

			// Token: 0x040053B3 RID: 21427
			[Token(Token = "0x40053B3")]
			[FieldOffset(Offset = "0x20")]
			public ExternalBuff buff;

			// Token: 0x040053B4 RID: 21428
			[Token(Token = "0x40053B4")]
			[FieldOffset(Offset = "0x28")]
			public ItemBundle[] equivalentCost;

			// Token: 0x02000F63 RID: 3939
			[Token(Token = "0x2000F63")]
			public enum TypeEnum
			{
				// Token: 0x040053B6 RID: 21430
				[Token(Token = "0x40053B6")]
				BUFF,
				// Token: 0x040053B7 RID: 21431
				[Token(Token = "0x40053B7")]
				CUSTOM
			}
		}

		// Token: 0x02000F64 RID: 3940
		[Token(Token = "0x2000F64")]
		[Serializable]
		public class PotentialCost
		{
			// Token: 0x06006C8E RID: 27790 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C8E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PotentialCost()
			{
			}

			// Token: 0x040053B8 RID: 21432
			[Token(Token = "0x40053B8")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x040053B9 RID: 21433
			[Token(Token = "0x40053B9")]
			[FieldOffset(Offset = "0x18")]
			public float percent;
		}

		// Token: 0x02000F65 RID: 3941
		[Token(Token = "0x2000F65")]
		[Serializable]
		public class SkillLevelCost
		{
			// Token: 0x06006C8F RID: 27791 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C8F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SkillLevelCost()
			{
			}

			// Token: 0x040053BA RID: 21434
			[Token(Token = "0x40053BA")]
			[FieldOffset(Offset = "0x10")]
			public CharacterData.UnlockCondition unlockCond;

			// Token: 0x040053BB RID: 21435
			[Token(Token = "0x40053BB")]
			[FieldOffset(Offset = "0x18")]
			public ItemBundle[] lvlUpCost;
		}

		// Token: 0x02000F66 RID: 3942
		[Token(Token = "0x2000F66")]
		[Serializable]
		public struct UniqueEquipPair
		{
			// Token: 0x06006C90 RID: 27792 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C90")]
			[Address(RVA = "0x21178B0", Offset = "0x21164B0", VA = "0x1821178B0")]
			public UniqueEquipPair(string key, int level)
			{
			}

			// Token: 0x06006C91 RID: 27793 RVA: 0x000318D8 File Offset: 0x0002FAD8
			[Token(Token = "0x6006C91")]
			[Address(RVA = "0xF5CEF0", Offset = "0xF5BAF0", VA = "0x180F5CEF0")]
			public static bool operator ==(CharacterData.UniqueEquipPair lhs, CharacterData.UniqueEquipPair rhs)
			{
				return default(bool);
			}

			// Token: 0x06006C92 RID: 27794 RVA: 0x000318F0 File Offset: 0x0002FAF0
			[Token(Token = "0x6006C92")]
			[Address(RVA = "0x21178E0", Offset = "0x21164E0", VA = "0x1821178E0")]
			public static bool operator !=(CharacterData.UniqueEquipPair lhs, CharacterData.UniqueEquipPair rhs)
			{
				return default(bool);
			}

			// Token: 0x040053BC RID: 21436
			[Token(Token = "0x40053BC")]
			[FieldOffset(Offset = "0x0")]
			public string key;

			// Token: 0x040053BD RID: 21437
			[Token(Token = "0x40053BD")]
			[FieldOffset(Offset = "0x8")]
			public int level;
		}

		// Token: 0x02000F67 RID: 3943
		[Token(Token = "0x2000F67")]
		[Serializable]
		public class MasterInfo
		{
			// Token: 0x06006C93 RID: 27795 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C93")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MasterInfo()
			{
			}

			// Token: 0x040053BE RID: 21438
			[Token(Token = "0x40053BE")]
			[FieldOffset(Offset = "0x10")]
			public string masterId;

			// Token: 0x040053BF RID: 21439
			[Token(Token = "0x40053BF")]
			[FieldOffset(Offset = "0x18")]
			public int level;
		}

		// Token: 0x02000F68 RID: 3944
		[Token(Token = "0x2000F68")]
		[Serializable]
		public struct PowerData
		{
			// Token: 0x040053C0 RID: 21440
			[Token(Token = "0x40053C0")]
			[FieldOffset(Offset = "0x0")]
			public string nationId;

			// Token: 0x040053C1 RID: 21441
			[Token(Token = "0x40053C1")]
			[FieldOffset(Offset = "0x8")]
			public string groupId;

			// Token: 0x040053C2 RID: 21442
			[Token(Token = "0x40053C2")]
			[FieldOffset(Offset = "0x10")]
			public string teamId;
		}
	}
}
