using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.CharWord;
using Torappu.UI.CharSelect;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005522 RID: 21794
	[Token(Token = "0x2005522")]
	public class RoguelikeCharCardViewModel : ISquadMemberCompInfo, IHotfixable
	{
		// Token: 0x17004B24 RID: 19236
		// (get) Token: 0x060200C6 RID: 131270 RVA: 0x000B4588 File Offset: 0x000B2788
		[Token(Token = "0x17004B24")]
		public int instId
		{
			[Token(Token = "0x60200C6")]
			[Address(RVA = "0x1A1A1C0", Offset = "0x1A18DC0", VA = "0x181A1A1C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004B25 RID: 19237
		// (get) Token: 0x060200C7 RID: 131271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B25")]
		public string charId
		{
			[Token(Token = "0x60200C7")]
			[Address(RVA = "0x1A1A000", Offset = "0x1A18C00", VA = "0x181A1A000")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004B26 RID: 19238
		// (get) Token: 0x060200C8 RID: 131272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B26")]
		public string tmplId
		{
			[Token(Token = "0x60200C8")]
			[Address(RVA = "0x1A1A650", Offset = "0x1A19250", VA = "0x181A1A650")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004B27 RID: 19239
		// (get) Token: 0x060200C9 RID: 131273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B27")]
		public string skinId
		{
			[Token(Token = "0x60200C9")]
			[Address(RVA = "0x1A1A5E0", Offset = "0x1A191E0", VA = "0x181A1A5E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004B28 RID: 19240
		// (get) Token: 0x060200CA RID: 131274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B28")]
		public string name
		{
			[Token(Token = "0x60200CA")]
			[Address(RVA = "0x1A1A3B0", Offset = "0x1A18FB0", VA = "0x181A1A3B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004B29 RID: 19241
		// (get) Token: 0x060200CB RID: 131275 RVA: 0x000B45A0 File Offset: 0x000B27A0
		[Token(Token = "0x17004B29")]
		public RarityRank rarity
		{
			[Token(Token = "0x60200CB")]
			[Address(RVA = "0x1A1A500", Offset = "0x1A19100", VA = "0x181A1A500")]
			get
			{
				return RarityRank.TIER_1;
			}
		}

		// Token: 0x17004B2A RID: 19242
		// (get) Token: 0x060200CC RID: 131276 RVA: 0x000B45B8 File Offset: 0x000B27B8
		[Token(Token = "0x17004B2A")]
		public ProfessionCategory profession
		{
			[Token(Token = "0x60200CC")]
			[Address(RVA = "0x1A1A490", Offset = "0x1A19090", VA = "0x181A1A490")]
			get
			{
				return ProfessionCategory.NONE;
			}
		}

		// Token: 0x17004B2B RID: 19243
		// (get) Token: 0x060200CD RID: 131277 RVA: 0x000B45D0 File Offset: 0x000B27D0
		[Token(Token = "0x17004B2B")]
		public EvolvePhase evolvePhase
		{
			[Token(Token = "0x60200CD")]
			[Address(RVA = "0x1A1A0E0", Offset = "0x1A18CE0", VA = "0x181A1A0E0")]
			get
			{
				return EvolvePhase.PHASE_0;
			}
		}

		// Token: 0x17004B2C RID: 19244
		// (get) Token: 0x060200CE RID: 131278 RVA: 0x000B45E8 File Offset: 0x000B27E8
		[Token(Token = "0x17004B2C")]
		public int potentialRank
		{
			[Token(Token = "0x60200CE")]
			[Address(RVA = "0x1A1A420", Offset = "0x1A19020", VA = "0x181A1A420")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004B2D RID: 19245
		// (get) Token: 0x060200CF RID: 131279 RVA: 0x000B4600 File Offset: 0x000B2800
		[Token(Token = "0x17004B2D")]
		public int level
		{
			[Token(Token = "0x60200CF")]
			[Address(RVA = "0x1A1A2D0", Offset = "0x1A18ED0", VA = "0x181A1A2D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004B2E RID: 19246
		// (get) Token: 0x060200D0 RID: 131280 RVA: 0x000B4618 File Offset: 0x000B2818
		[Token(Token = "0x17004B2E")]
		public int favorPoint
		{
			[Token(Token = "0x60200D0")]
			[Address(RVA = "0x1A1A150", Offset = "0x1A18D50", VA = "0x181A1A150")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004B2F RID: 19247
		// (get) Token: 0x060200D1 RID: 131281 RVA: 0x000B4630 File Offset: 0x000B2830
		[Token(Token = "0x17004B2F")]
		public int mainSkillLvl
		{
			[Token(Token = "0x60200D1")]
			[Address(RVA = "0x1A1A340", Offset = "0x1A18F40", VA = "0x181A1A340")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004B30 RID: 19248
		// (get) Token: 0x060200D2 RID: 131282 RVA: 0x000B4648 File Offset: 0x000B2848
		[Token(Token = "0x17004B30")]
		public int defaultSkillIndex
		{
			[Token(Token = "0x60200D2")]
			[Address(RVA = "0x1A1A070", Offset = "0x1A18C70", VA = "0x181A1A070")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004B31 RID: 19249
		// (get) Token: 0x060200D3 RID: 131283 RVA: 0x000B4660 File Offset: 0x000B2860
		[Token(Token = "0x17004B31")]
		public bool isShowSpSkin
		{
			[Token(Token = "0x60200D3")]
			[Address(RVA = "0x1A1A230", Offset = "0x1A18E30", VA = "0x181A1A230")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004B32 RID: 19250
		// (get) Token: 0x060200D4 RID: 131284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B32")]
		public PlayerCharSkill[] skills
		{
			[Token(Token = "0x60200D4")]
			[Address(RVA = "0x1A1A570", Offset = "0x1A19170", VA = "0x181A1A570")]
			get
			{
				return null;
			}
		}

		// Token: 0x060200D5 RID: 131285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60200D5")]
		[Address(RVA = "0x1A16D80", Offset = "0x1A15980", VA = "0x181A16D80", Slot = "6")]
		public string GetDefaultEquipId()
		{
			return null;
		}

		// Token: 0x060200D6 RID: 131286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200D6")]
		[Address(RVA = "0x1A169B0", Offset = "0x1A155B0", VA = "0x181A169B0")]
		public void EnsureSkill()
		{
		}

		// Token: 0x060200D7 RID: 131287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60200D7")]
		[Address(RVA = "0x1A187C0", Offset = "0x1A173C0", VA = "0x181A187C0")]
		private RoguelikeTalentViewModel[] _GenTalentGroup(CharacterData charData, int playerCharLevel, EvolvePhase playerEvolvePhase, int playerPotentialRank)
		{
			return null;
		}

		// Token: 0x060200D8 RID: 131288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200D8")]
		[Address(RVA = "0x1A193E0", Offset = "0x1A17FE0", VA = "0x181A193E0")]
		private void _LoadUniqEquip(CharacterData charData, CharQuery charQuery, EvolvePhase evolvePhase, int level, int favorPoint, int potentialRank, string playerCharEquipId, ListDict<string, PlayerCharEquipInfo> playerCharEquipInfos)
		{
		}

		// Token: 0x060200D9 RID: 131289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200D9")]
		[Address(RVA = "0x1A18F50", Offset = "0x1A17B50", VA = "0x181A18F50")]
		private void _LoadUniequipAttr(CharacterData charData, CharQuery charQuery, EvolvePhase evolvePhase, int level, int favorPoint, int potentialRank, string equipId, int equiplevel)
		{
		}

		// Token: 0x060200DA RID: 131290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200DA")]
		[Address(RVA = "0x1A19B60", Offset = "0x1A18760", VA = "0x181A19B60")]
		private void _ReloadUniequip()
		{
		}

		// Token: 0x060200DB RID: 131291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200DB")]
		[Address(RVA = "0x1A17AE0", Offset = "0x1A166E0", VA = "0x181A17AE0")]
		public void LoadData(PlayerRoguelikeV2.CurrentData.Char playerChar, RoguelikeCharCardViewModel.ShowType showType)
		{
		}

		// Token: 0x060200DC RID: 131292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200DC")]
		[Address(RVA = "0x1A17380", Offset = "0x1A15F80", VA = "0x181A17380")]
		public void LoadData(PlayerRoguelikeV2.CurrentData.RecruitChar playerChar, RoguelikeCharCardViewModel.ShowType showType)
		{
		}

		// Token: 0x060200DD RID: 131293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200DD")]
		[Address(RVA = "0x1A18480", Offset = "0x1A17080", VA = "0x181A18480")]
		public void SetSkill(string skillId)
		{
		}

		// Token: 0x060200DE RID: 131294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200DE")]
		[Address(RVA = "0x1A18260", Offset = "0x1A16E60", VA = "0x181A18260")]
		public void SetBranch(string equipId, string defaultEquipId)
		{
		}

		// Token: 0x060200DF RID: 131295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60200DF")]
		[Address(RVA = "0x1A171B0", Offset = "0x1A15DB0", VA = "0x181A171B0")]
		public string GetSkillId(int index)
		{
			return null;
		}

		// Token: 0x060200E0 RID: 131296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200E0")]
		[Address(RVA = "0x1A18680", Offset = "0x1A17280", VA = "0x181A18680")]
		public void UpdateLastSkillCount()
		{
		}

		// Token: 0x060200E1 RID: 131297 RVA: 0x000B4678 File Offset: 0x000B2878
		[Token(Token = "0x60200E1")]
		[Address(RVA = "0x1A16C20", Offset = "0x1A15820", VA = "0x181A16C20")]
		public CharQuery GetCharQuery()
		{
			return default(CharQuery);
		}

		// Token: 0x060200E2 RID: 131298 RVA: 0x000B4690 File Offset: 0x000B2890
		[Token(Token = "0x60200E2")]
		[Address(RVA = "0x1A16DF0", Offset = "0x1A159F0", VA = "0x181A16DF0")]
		public CharacterData.UniqueEquipPair GetEquipQuery()
		{
			return default(CharacterData.UniqueEquipPair);
		}

		// Token: 0x060200E3 RID: 131299 RVA: 0x000B46A8 File Offset: 0x000B28A8
		[Token(Token = "0x60200E3")]
		[Address(RVA = "0x1A17280", Offset = "0x1A15E80", VA = "0x181A17280")]
		public VoiceQuery GetVoiceQuery()
		{
			return default(VoiceQuery);
		}

		// Token: 0x060200E4 RID: 131300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60200E4")]
		[Address(RVA = "0x1A16F40", Offset = "0x1A15B40", VA = "0x181A16F40")]
		public RoguelikeTopicMonthSquad GetMonthSquadData()
		{
			return null;
		}

		// Token: 0x060200E5 RID: 131301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60200E5")]
		[Address(RVA = "0x1A16ED0", Offset = "0x1A15AD0", VA = "0x181A16ED0")]
		public string GetMonthCharCardTagName()
		{
			return null;
		}

		// Token: 0x060200E6 RID: 131302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60200E6")]
		[Address(RVA = "0x1A16B70", Offset = "0x1A15770", VA = "0x181A16B70", Slot = "4")]
		public IEnumerator<KeyValuePair<string, PlayerSquadTmpl>> ExtraTmplInfo()
		{
			return null;
		}

		// Token: 0x060200E7 RID: 131303 RVA: 0x000B46C0 File Offset: 0x000B28C0
		[Token(Token = "0x60200E7")]
		[Address(RVA = "0x1A16AB0", Offset = "0x1A156B0", VA = "0x181A16AB0", Slot = "5")]
		public int ExtraTmplCount()
		{
			return 0;
		}

		// Token: 0x060200E8 RID: 131304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60200E8")]
		[Address(RVA = "0x1A19F90", Offset = "0x1A18B90", VA = "0x181A19F90")]
		public RoguelikeCharCardViewModel()
		{
		}

		// Token: 0x0402B465 RID: 177253
		[Token(Token = "0x402B465")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeCharCardViewModel.ShowType showType;

		// Token: 0x0402B466 RID: 177254
		[Token(Token = "0x402B466")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeBasicCharInfoModel basicInfo;

		// Token: 0x0402B467 RID: 177255
		[Token(Token = "0x402B467")]
		[FieldOffset(Offset = "0x20")]
		public int populationCost;

		// Token: 0x0402B468 RID: 177256
		[Token(Token = "0x402B468")]
		[FieldOffset(Offset = "0x24")]
		public int upgradePhase;

		// Token: 0x0402B469 RID: 177257
		[Token(Token = "0x402B469")]
		[FieldOffset(Offset = "0x28")]
		public bool upgradeLimited;

		// Token: 0x0402B46A RID: 177258
		[Token(Token = "0x402B46A")]
		[FieldOffset(Offset = "0x29")]
		public bool isUpgrade;

		// Token: 0x0402B46B RID: 177259
		[Token(Token = "0x402B46B")]
		[FieldOffset(Offset = "0x30")]
		public string conflictSpCharId;

		// Token: 0x0402B46C RID: 177260
		[Token(Token = "0x402B46C")]
		[FieldOffset(Offset = "0x38")]
		public int troopInstId;

		// Token: 0x0402B46D RID: 177261
		[Token(Token = "0x402B46D")]
		[FieldOffset(Offset = "0x3C")]
		public bool availToSelect;

		// Token: 0x0402B46E RID: 177262
		[Token(Token = "0x402B46E")]
		[FieldOffset(Offset = "0x40")]
		public int isThird;

		// Token: 0x0402B46F RID: 177263
		[Token(Token = "0x402B46F")]
		[FieldOffset(Offset = "0x44")]
		public int isThirdElite;

		// Token: 0x0402B470 RID: 177264
		[Token(Token = "0x402B470")]
		[FieldOffset(Offset = "0x48")]
		public int isElite;

		// Token: 0x0402B471 RID: 177265
		[Token(Token = "0x402B471")]
		[FieldOffset(Offset = "0x4C")]
		public int isAddition;

		// Token: 0x0402B472 RID: 177266
		[Token(Token = "0x402B472")]
		[FieldOffset(Offset = "0x50")]
		public int isFriendAssist;

		// Token: 0x0402B473 RID: 177267
		[Token(Token = "0x402B473")]
		[FieldOffset(Offset = "0x54")]
		public int isMonthlyTeam;

		// Token: 0x0402B474 RID: 177268
		[Token(Token = "0x402B474")]
		[FieldOffset(Offset = "0x58")]
		public bool isPlayerChar;

		// Token: 0x0402B475 RID: 177269
		[Token(Token = "0x402B475")]
		[FieldOffset(Offset = "0x60")]
		public List<string> charBuffIdList;

		// Token: 0x0402B476 RID: 177270
		[Token(Token = "0x402B476")]
		[FieldOffset(Offset = "0x68")]
		public RoguelikeCharState state;

		// Token: 0x0402B477 RID: 177271
		[Token(Token = "0x402B477")]
		[FieldOffset(Offset = "0x70")]
		public string attackSpeedDesc;

		// Token: 0x0402B478 RID: 177272
		[Token(Token = "0x402B478")]
		[FieldOffset(Offset = "0x78")]
		public string respawnDesc;

		// Token: 0x0402B479 RID: 177273
		[Token(Token = "0x402B479")]
		[FieldOffset(Offset = "0x80")]
		public AttackRangeDescModel attackRange;

		// Token: 0x0402B47A RID: 177274
		[Token(Token = "0x402B47A")]
		[FieldOffset(Offset = "0x90")]
		public EvolvePhase maxStateEvolve;

		// Token: 0x0402B47B RID: 177275
		[Token(Token = "0x402B47B")]
		[FieldOffset(Offset = "0x94")]
		public int maxStateLevel;

		// Token: 0x0402B47C RID: 177276
		[Token(Token = "0x402B47C")]
		[FieldOffset(Offset = "0x98")]
		public RoguelikeCharSelectSkillGroupViewModel skillGroup;

		// Token: 0x0402B47D RID: 177277
		[Token(Token = "0x402B47D")]
		[FieldOffset(Offset = "0xA0")]
		public RoguelikeCharSelectBranchGroupViewModel branchGroup;

		// Token: 0x0402B47E RID: 177278
		[Token(Token = "0x402B47E")]
		[FieldOffset(Offset = "0xA8")]
		public CharAttrTabType attryTabType;

		// Token: 0x0402B47F RID: 177279
		[Token(Token = "0x402B47F")]
		[FieldOffset(Offset = "0xAC")]
		public int skillIndex;

		// Token: 0x0402B480 RID: 177280
		[Token(Token = "0x402B480")]
		[FieldOffset(Offset = "0xB0")]
		public int lastSkillCount;

		// Token: 0x0402B481 RID: 177281
		[Token(Token = "0x402B481")]
		[FieldOffset(Offset = "0xB8")]
		private string m_cachedTopicId;

		// Token: 0x0402B482 RID: 177282
		[Token(Token = "0x402B482")]
		[FieldOffset(Offset = "0xC0")]
		private string m_cachedMonthSquadId;

		// Token: 0x0402B483 RID: 177283
		[Token(Token = "0x402B483")]
		[FieldOffset(Offset = "0xC8")]
		private RoguelikeTopicMonthSquad m_cachedMonthSquadData;

		// Token: 0x0402B484 RID: 177284
		[Token(Token = "0x402B484")]
		[FieldOffset(Offset = "0xD0")]
		private string m_cachedMonthCharCardTag;

		// Token: 0x0402B485 RID: 177285
		[Token(Token = "0x402B485")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_instId;

		// Token: 0x0402B486 RID: 177286
		[Token(Token = "0x402B486")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_charId;

		// Token: 0x0402B487 RID: 177287
		[Token(Token = "0x402B487")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_tmplId;

		// Token: 0x0402B488 RID: 177288
		[Token(Token = "0x402B488")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_skinId;

		// Token: 0x0402B489 RID: 177289
		[Token(Token = "0x402B489")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x0402B48A RID: 177290
		[Token(Token = "0x402B48A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_rarity;

		// Token: 0x0402B48B RID: 177291
		[Token(Token = "0x402B48B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_profession;

		// Token: 0x0402B48C RID: 177292
		[Token(Token = "0x402B48C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_evolvePhase;

		// Token: 0x0402B48D RID: 177293
		[Token(Token = "0x402B48D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_potentialRank;

		// Token: 0x0402B48E RID: 177294
		[Token(Token = "0x402B48E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_level;

		// Token: 0x0402B48F RID: 177295
		[Token(Token = "0x402B48F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_favorPoint;

		// Token: 0x0402B490 RID: 177296
		[Token(Token = "0x402B490")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_mainSkillLvl;

		// Token: 0x0402B491 RID: 177297
		[Token(Token = "0x402B491")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_defaultSkillIndex;

		// Token: 0x0402B492 RID: 177298
		[Token(Token = "0x402B492")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_isShowSpSkin;

		// Token: 0x0402B493 RID: 177299
		[Token(Token = "0x402B493")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_skills;

		// Token: 0x0402B494 RID: 177300
		[Token(Token = "0x402B494")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetDefaultEquipId;

		// Token: 0x0402B495 RID: 177301
		[Token(Token = "0x402B495")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_EnsureSkill;

		// Token: 0x0402B496 RID: 177302
		[Token(Token = "0x402B496")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__GenTalentGroup;

		// Token: 0x0402B497 RID: 177303
		[Token(Token = "0x402B497")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__LoadUniqEquip;

		// Token: 0x0402B498 RID: 177304
		[Token(Token = "0x402B498")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__LoadUniequipAttr;

		// Token: 0x0402B499 RID: 177305
		[Token(Token = "0x402B499")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__ReloadUniequip;

		// Token: 0x0402B49A RID: 177306
		[Token(Token = "0x402B49A")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402B49B RID: 177307
		[Token(Token = "0x402B49B")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix1_LoadData;

		// Token: 0x0402B49C RID: 177308
		[Token(Token = "0x402B49C")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_SetSkill;

		// Token: 0x0402B49D RID: 177309
		[Token(Token = "0x402B49D")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_SetBranch;

		// Token: 0x0402B49E RID: 177310
		[Token(Token = "0x402B49E")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GetSkillId;

		// Token: 0x0402B49F RID: 177311
		[Token(Token = "0x402B49F")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_UpdateLastSkillCount;

		// Token: 0x0402B4A0 RID: 177312
		[Token(Token = "0x402B4A0")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_GetCharQuery;

		// Token: 0x0402B4A1 RID: 177313
		[Token(Token = "0x402B4A1")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_GetEquipQuery;

		// Token: 0x0402B4A2 RID: 177314
		[Token(Token = "0x402B4A2")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_GetVoiceQuery;

		// Token: 0x0402B4A3 RID: 177315
		[Token(Token = "0x402B4A3")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_GetMonthSquadData;

		// Token: 0x0402B4A4 RID: 177316
		[Token(Token = "0x402B4A4")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_GetMonthCharCardTagName;

		// Token: 0x0402B4A5 RID: 177317
		[Token(Token = "0x402B4A5")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_ExtraTmplInfo;

		// Token: 0x0402B4A6 RID: 177318
		[Token(Token = "0x402B4A6")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_ExtraTmplCount;

		// Token: 0x0402B4A7 RID: 177319
		[Token(Token = "0x402B4A7")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005523 RID: 21795
		[Token(Token = "0x2005523")]
		public enum ShowType
		{
			// Token: 0x0402B4A9 RID: 177321
			[Token(Token = "0x402B4A9")]
			CHAR_SKILL,
			// Token: 0x0402B4AA RID: 177322
			[Token(Token = "0x402B4AA")]
			RECRUIT,
			// Token: 0x0402B4AB RID: 177323
			[Token(Token = "0x402B4AB")]
			RECRUIT_TEMP,
			// Token: 0x0402B4AC RID: 177324
			[Token(Token = "0x402B4AC")]
			UPGRADE,
			// Token: 0x0402B4AD RID: 177325
			[Token(Token = "0x402B4AD")]
			ONLY_FOR_SHOW,
			// Token: 0x0402B4AE RID: 177326
			[Token(Token = "0x402B4AE")]
			SQUAD
		}
	}
}
