using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Building.UI;
using Torappu.UI.CharacterCommon;
using Torappu.UI.CharacterInfo;
using XLua;

namespace Torappu.UI.CharacterShow
{
	// Token: 0x02005DE1 RID: 24033
	[Token(Token = "0x2005DE1")]
	public class CharacterShowV2Model : IHotfixable
	{
		// Token: 0x17005242 RID: 21058
		// (get) Token: 0x06022CFD RID: 142589 RVA: 0x000BEF68 File Offset: 0x000BD168
		[Token(Token = "0x17005242")]
		public bool isAllSlotVisible
		{
			[Token(Token = "0x6022CFD")]
			[Address(RVA = "0x1D4E190", Offset = "0x1D4CD90", VA = "0x181D4E190")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005243 RID: 21059
		// (get) Token: 0x06022CFE RID: 142590 RVA: 0x000BEF80 File Offset: 0x000BD180
		[Token(Token = "0x17005243")]
		public bool isUnlockHintVisible
		{
			[Token(Token = "0x6022CFE")]
			[Address(RVA = "0x1D4E370", Offset = "0x1D4CF70", VA = "0x181D4E370")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005244 RID: 21060
		// (get) Token: 0x06022CFF RID: 142591 RVA: 0x000BEF98 File Offset: 0x000BD198
		[Token(Token = "0x17005244")]
		public bool isEquipCntOverLimit
		{
			[Token(Token = "0x6022CFF")]
			[Address(RVA = "0x1D4E250", Offset = "0x1D4CE50", VA = "0x181D4E250")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005245 RID: 21061
		// (get) Token: 0x06022D00 RID: 142592 RVA: 0x000BEFB0 File Offset: 0x000BD1B0
		[Token(Token = "0x17005245")]
		public bool isMasterHide
		{
			[Token(Token = "0x6022D00")]
			[Address(RVA = "0x1D4E310", Offset = "0x1D4CF10", VA = "0x181D4E310")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005246 RID: 21062
		// (get) Token: 0x06022D01 RID: 142593 RVA: 0x000BEFC8 File Offset: 0x000BD1C8
		[Token(Token = "0x17005246")]
		public int favorPercent
		{
			[Token(Token = "0x6022D01")]
			[Address(RVA = "0x1D4DFA0", Offset = "0x1D4CBA0", VA = "0x181D4DFA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005247 RID: 21063
		// (get) Token: 0x06022D02 RID: 142594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005247")]
		public List<BuildingBuffDescStruct> buildingBuffList
		{
			[Token(Token = "0x6022D02")]
			[Address(RVA = "0x1D4DA30", Offset = "0x1D4C630", VA = "0x181D4DA30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005248 RID: 21064
		// (get) Token: 0x06022D03 RID: 142595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005248")]
		public List<CharacterShowTalentModel> talentModelList
		{
			[Token(Token = "0x6022D03")]
			[Address(RVA = "0x1D4EBD0", Offset = "0x1D4D7D0", VA = "0x181D4EBD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005249 RID: 21065
		// (get) Token: 0x06022D04 RID: 142596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005249")]
		public List<CharacterShowMasterModel> masterModelList
		{
			[Token(Token = "0x6022D04")]
			[Address(RVA = "0x1D4E490", Offset = "0x1D4D090", VA = "0x181D4E490")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700524A RID: 21066
		// (get) Token: 0x06022D05 RID: 142597 RVA: 0x000BEFE0 File Offset: 0x000BD1E0
		[Token(Token = "0x1700524A")]
		public bool hasEquip
		{
			[Token(Token = "0x6022D05")]
			[Address(RVA = "0x1D4E010", Offset = "0x1D4CC10", VA = "0x181D4E010")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700524B RID: 21067
		// (get) Token: 0x06022D06 RID: 142598 RVA: 0x000BEFF8 File Offset: 0x000BD1F8
		[Token(Token = "0x1700524B")]
		public bool hasTalent
		{
			[Token(Token = "0x6022D06")]
			[Address(RVA = "0x1D4E110", Offset = "0x1D4CD10", VA = "0x181D4E110")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700524C RID: 21068
		// (get) Token: 0x06022D07 RID: 142599 RVA: 0x000BF010 File Offset: 0x000BD210
		[Token(Token = "0x1700524C")]
		public bool hasMaster
		{
			[Token(Token = "0x6022D07")]
			[Address(RVA = "0x1D4E090", Offset = "0x1D4CC90", VA = "0x181D4E090")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700524D RID: 21069
		// (get) Token: 0x06022D08 RID: 142600 RVA: 0x000BF028 File Offset: 0x000BD228
		[Token(Token = "0x1700524D")]
		public bool isBuildingBuffVisible
		{
			[Token(Token = "0x6022D08")]
			[Address(RVA = "0x1D4E1F0", Offset = "0x1D4CDF0", VA = "0x181D4E1F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700524E RID: 21070
		// (get) Token: 0x06022D09 RID: 142601 RVA: 0x000BF040 File Offset: 0x000BD240
		[Token(Token = "0x1700524E")]
		public int level
		{
			[Token(Token = "0x6022D09")]
			[Address(RVA = "0x1D4E430", Offset = "0x1D4D030", VA = "0x181D4E430")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700524F RID: 21071
		// (get) Token: 0x06022D0A RID: 142602 RVA: 0x000BF058 File Offset: 0x000BD258
		[Token(Token = "0x1700524F")]
		public int maxLevel
		{
			[Token(Token = "0x6022D0A")]
			[Address(RVA = "0x1D4E620", Offset = "0x1D4D220", VA = "0x181D4E620")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005250 RID: 21072
		// (get) Token: 0x06022D0B RID: 142603 RVA: 0x000BF070 File Offset: 0x000BD270
		[Token(Token = "0x17005250")]
		public EvolvePhase evolvePhase
		{
			[Token(Token = "0x6022D0B")]
			[Address(RVA = "0x1D4DD30", Offset = "0x1D4C930", VA = "0x181D4DD30")]
			get
			{
				return EvolvePhase.PHASE_0;
			}
		}

		// Token: 0x17005251 RID: 21073
		// (get) Token: 0x06022D0C RID: 142604 RVA: 0x000BF088 File Offset: 0x000BD288
		[Token(Token = "0x17005251")]
		public int potentialRank
		{
			[Token(Token = "0x6022D0C")]
			[Address(RVA = "0x1D4E6E0", Offset = "0x1D4D2E0", VA = "0x181D4E6E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005252 RID: 21074
		// (get) Token: 0x06022D0D RID: 142605 RVA: 0x000BF0A0 File Offset: 0x000BD2A0
		[Token(Token = "0x17005252")]
		public bool isLevelMax
		{
			[Token(Token = "0x6022D0D")]
			[Address(RVA = "0x1D4E2B0", Offset = "0x1D4CEB0", VA = "0x181D4E2B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005253 RID: 21075
		// (get) Token: 0x06022D0E RID: 142606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005253")]
		public string expDesc
		{
			[Token(Token = "0x6022D0E")]
			[Address(RVA = "0x1D4DD90", Offset = "0x1D4C990", VA = "0x181D4DD90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005254 RID: 21076
		// (get) Token: 0x06022D0F RID: 142607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005254")]
		public string maxExpDesc
		{
			[Token(Token = "0x6022D0F")]
			[Address(RVA = "0x1D4E4F0", Offset = "0x1D4D0F0", VA = "0x181D4E4F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005255 RID: 21077
		// (get) Token: 0x06022D10 RID: 142608 RVA: 0x000BF0B8 File Offset: 0x000BD2B8
		[Token(Token = "0x17005255")]
		public float expProgress
		{
			[Token(Token = "0x6022D10")]
			[Address(RVA = "0x1D4DE60", Offset = "0x1D4CA60", VA = "0x181D4DE60")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17005256 RID: 21078
		// (get) Token: 0x06022D11 RID: 142609 RVA: 0x000BF0D0 File Offset: 0x000BD2D0
		[Token(Token = "0x17005256")]
		public int maxHp
		{
			[Token(Token = "0x6022D11")]
			[Address(RVA = "0x1D4E5C0", Offset = "0x1D4D1C0", VA = "0x181D4E5C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005257 RID: 21079
		// (get) Token: 0x06022D12 RID: 142610 RVA: 0x000BF0E8 File Offset: 0x000BD2E8
		[Token(Token = "0x17005257")]
		public int atk
		{
			[Token(Token = "0x6022D12")]
			[Address(RVA = "0x1D4D910", Offset = "0x1D4C510", VA = "0x181D4D910")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005258 RID: 21080
		// (get) Token: 0x06022D13 RID: 142611 RVA: 0x000BF100 File Offset: 0x000BD300
		[Token(Token = "0x17005258")]
		public int def
		{
			[Token(Token = "0x6022D13")]
			[Address(RVA = "0x1D4DC10", Offset = "0x1D4C810", VA = "0x181D4DC10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005259 RID: 21081
		// (get) Token: 0x06022D14 RID: 142612 RVA: 0x000BF118 File Offset: 0x000BD318
		[Token(Token = "0x17005259")]
		public float res
		{
			[Token(Token = "0x6022D14")]
			[Address(RVA = "0x1D4E810", Offset = "0x1D4D410", VA = "0x181D4E810")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700525A RID: 21082
		// (get) Token: 0x06022D15 RID: 142613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700525A")]
		public string respawnTime
		{
			[Token(Token = "0x6022D15")]
			[Address(RVA = "0x1D4E870", Offset = "0x1D4D470", VA = "0x181D4E870")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700525B RID: 21083
		// (get) Token: 0x06022D16 RID: 142614 RVA: 0x000BF130 File Offset: 0x000BD330
		[Token(Token = "0x1700525B")]
		public int cost
		{
			[Token(Token = "0x6022D16")]
			[Address(RVA = "0x1D4DBB0", Offset = "0x1D4C7B0", VA = "0x181D4DBB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700525C RID: 21084
		// (get) Token: 0x06022D17 RID: 142615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700525C")]
		public string atkSpeed
		{
			[Token(Token = "0x6022D17")]
			[Address(RVA = "0x1D4D8B0", Offset = "0x1D4C4B0", VA = "0x181D4D8B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700525D RID: 21085
		// (get) Token: 0x06022D18 RID: 142616 RVA: 0x000BF148 File Offset: 0x000BD348
		[Token(Token = "0x1700525D")]
		public int blockNum
		{
			[Token(Token = "0x6022D18")]
			[Address(RVA = "0x1D4D9D0", Offset = "0x1D4C5D0", VA = "0x181D4D9D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700525E RID: 21086
		// (get) Token: 0x06022D19 RID: 142617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700525E")]
		public BattleInfoViewModel battleInfoModel
		{
			[Token(Token = "0x6022D19")]
			[Address(RVA = "0x1D4D970", Offset = "0x1D4C570", VA = "0x181D4D970")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700525F RID: 21087
		// (get) Token: 0x06022D1A RID: 142618 RVA: 0x000BF160 File Offset: 0x000BD360
		[Token(Token = "0x1700525F")]
		public bool isValid
		{
			[Token(Token = "0x6022D1A")]
			[Address(RVA = "0x1D4E3D0", Offset = "0x1D4CFD0", VA = "0x181D4E3D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005260 RID: 21088
		// (get) Token: 0x06022D1B RID: 142619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005260")]
		public string charId
		{
			[Token(Token = "0x6022D1B")]
			[Address(RVA = "0x1D4DAF0", Offset = "0x1D4C6F0", VA = "0x181D4DAF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005261 RID: 21089
		// (get) Token: 0x06022D1C RID: 142620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005261")]
		public string skinId
		{
			[Token(Token = "0x6022D1C")]
			[Address(RVA = "0x1D4E9F0", Offset = "0x1D4D5F0", VA = "0x181D4E9F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005262 RID: 21090
		// (get) Token: 0x06022D1D RID: 142621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005262")]
		public CharacterData charData
		{
			[Token(Token = "0x6022D1D")]
			[Address(RVA = "0x1D4DA90", Offset = "0x1D4C690", VA = "0x181D4DA90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005263 RID: 21091
		// (get) Token: 0x06022D1E RID: 142622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005263")]
		public string subProfId
		{
			[Token(Token = "0x6022D1E")]
			[Address(RVA = "0x1D4EA50", Offset = "0x1D4D650", VA = "0x181D4EA50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005264 RID: 21092
		// (get) Token: 0x06022D1F RID: 142623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005264")]
		public string subProfName
		{
			[Token(Token = "0x6022D1F")]
			[Address(RVA = "0x1D4EAE0", Offset = "0x1D4D6E0", VA = "0x181D4EAE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005265 RID: 21093
		// (get) Token: 0x06022D20 RID: 142624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005265")]
		public string traitDesc
		{
			[Token(Token = "0x6022D20")]
			[Address(RVA = "0x1D4EC30", Offset = "0x1D4D830", VA = "0x181D4EC30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005266 RID: 21094
		// (get) Token: 0x06022D21 RID: 142625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005266")]
		public AttributesData favorDelta
		{
			[Token(Token = "0x6022D21")]
			[Address(RVA = "0x1D4DF40", Offset = "0x1D4CB40", VA = "0x181D4DF40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005267 RID: 21095
		// (get) Token: 0x06022D22 RID: 142626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005267")]
		public string position
		{
			[Token(Token = "0x6022D22")]
			[Address(RVA = "0x1D4E680", Offset = "0x1D4D280", VA = "0x181D4E680")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005268 RID: 21096
		// (get) Token: 0x06022D23 RID: 142627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005268")]
		public string tagsContent
		{
			[Token(Token = "0x6022D23")]
			[Address(RVA = "0x1D4EB70", Offset = "0x1D4D770", VA = "0x181D4EB70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005269 RID: 21097
		// (get) Token: 0x06022D24 RID: 142628 RVA: 0x000BF178 File Offset: 0x000BD378
		[Token(Token = "0x17005269")]
		public ProfessionCategory profession
		{
			[Token(Token = "0x6022D24")]
			[Address(RVA = "0x1D4E740", Offset = "0x1D4D340", VA = "0x181D4E740")]
			get
			{
				return ProfessionCategory.NONE;
			}
		}

		// Token: 0x1700526A RID: 21098
		// (get) Token: 0x06022D25 RID: 142629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700526A")]
		public List<CharacterShowEquipModel> equipList
		{
			[Token(Token = "0x6022D25")]
			[Address(RVA = "0x1D4DC70", Offset = "0x1D4C870", VA = "0x181D4DC70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700526B RID: 21099
		// (get) Token: 0x06022D26 RID: 142630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700526B")]
		public List<CharacterShowSkillModel> skillList
		{
			[Token(Token = "0x6022D26")]
			[Address(RVA = "0x1D4E990", Offset = "0x1D4D590", VA = "0x181D4E990")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700526C RID: 21100
		// (get) Token: 0x06022D27 RID: 142631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700526C")]
		public string selectedSkillId
		{
			[Token(Token = "0x6022D27")]
			[Address(RVA = "0x1D4E930", Offset = "0x1D4D530", VA = "0x181D4E930")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700526D RID: 21101
		// (get) Token: 0x06022D28 RID: 142632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700526D")]
		public string selectedEquipId
		{
			[Token(Token = "0x6022D28")]
			[Address(RVA = "0x1D4E8D0", Offset = "0x1D4D4D0", VA = "0x181D4E8D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700526E RID: 21102
		// (get) Token: 0x06022D29 RID: 142633 RVA: 0x000BF190 File Offset: 0x000BD390
		[Token(Token = "0x1700526E")]
		public float equipScrollNormalizedPos
		{
			[Token(Token = "0x6022D29")]
			[Address(RVA = "0x1D4DCD0", Offset = "0x1D4C8D0", VA = "0x181D4DCD0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700526F RID: 21103
		// (get) Token: 0x06022D2A RID: 142634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700526F")]
		public CharTokenViewModel charTokenViewModel
		{
			[Token(Token = "0x6022D2A")]
			[Address(RVA = "0x1D4DB50", Offset = "0x1D4C750", VA = "0x181D4DB50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005270 RID: 21104
		// (get) Token: 0x06022D2B RID: 142635 RVA: 0x000BF1A8 File Offset: 0x000BD3A8
		[Token(Token = "0x17005270")]
		public int refreshEquipSeqNum
		{
			[Token(Token = "0x6022D2B")]
			[Address(RVA = "0x1D4E7B0", Offset = "0x1D4D3B0", VA = "0x181D4E7B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06022D2C RID: 142636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D2C")]
		[Address(RVA = "0x1D4A4C0", Offset = "0x1D490C0", VA = "0x181D4A4C0")]
		public void LoadData(CharacterShowViewModel input)
		{
		}

		// Token: 0x06022D2D RID: 142637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022D2D")]
		[Address(RVA = "0x1D4A3F0", Offset = "0x1D48FF0", VA = "0x181D4A3F0")]
		public CharacterShowEquipModel GetSelectedEquipModel()
		{
			return null;
		}

		// Token: 0x06022D2E RID: 142638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022D2E")]
		[Address(RVA = "0x1D4A460", Offset = "0x1D49060", VA = "0x181D4A460")]
		public CharacterShowSkillModel GetSelectedSkillModel()
		{
			return null;
		}

		// Token: 0x06022D2F RID: 142639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022D2F")]
		[Address(RVA = "0x1D4B520", Offset = "0x1D4A120", VA = "0x181D4B520")]
		private string _GenerateTagContent(CharacterData charData)
		{
			return null;
		}

		// Token: 0x06022D30 RID: 142640 RVA: 0x000BF1C0 File Offset: 0x000BD3C0
		[Token(Token = "0x6022D30")]
		[Address(RVA = "0x1D4ACA0", Offset = "0x1D498A0", VA = "0x181D4ACA0")]
		public bool TryUpdateDataWithSKillId(string skillId)
		{
			return default(bool);
		}

		// Token: 0x06022D31 RID: 142641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D31")]
		[Address(RVA = "0x1D4D150", Offset = "0x1D4BD50", VA = "0x181D4D150")]
		private void _UpdateDataWithSKill(CharacterShowSkillModel skillModel)
		{
		}

		// Token: 0x06022D32 RID: 142642 RVA: 0x000BF1D8 File Offset: 0x000BD3D8
		[Token(Token = "0x6022D32")]
		[Address(RVA = "0x1D4ABC0", Offset = "0x1D497C0", VA = "0x181D4ABC0")]
		public bool TryUpdateDataWithEquipId(string equipId)
		{
			return default(bool);
		}

		// Token: 0x06022D33 RID: 142643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D33")]
		[Address(RVA = "0x1D4CF40", Offset = "0x1D4BB40", VA = "0x181D4CF40")]
		private void _UpdateDataWithEquip(CharacterShowEquipModel equipModel)
		{
		}

		// Token: 0x06022D34 RID: 142644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D34")]
		[Address(RVA = "0x1D4CAD0", Offset = "0x1D4B6D0", VA = "0x181D4CAD0")]
		private void _SetEquipListFocus(int defaultEquipIndex)
		{
		}

		// Token: 0x06022D35 RID: 142645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D35")]
		[Address(RVA = "0x1D4D1F0", Offset = "0x1D4BDF0", VA = "0x181D4D1F0")]
		private void _UpdateTalentList(CharacterShowEquipModel equipModel)
		{
		}

		// Token: 0x06022D36 RID: 142646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D36")]
		[Address(RVA = "0x1D4CBB0", Offset = "0x1D4B7B0", VA = "0x181D4CBB0")]
		private void _UpdateAttributes(CharacterShowEquipModel equipModel)
		{
		}

		// Token: 0x06022D37 RID: 142647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D37")]
		[Address(RVA = "0x1D4CE30", Offset = "0x1D4BA30", VA = "0x181D4CE30")]
		private void _UpdateBattleInfoModel(CharacterShowEquipModel equipModel)
		{
		}

		// Token: 0x06022D38 RID: 142648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D38")]
		[Address(RVA = "0x1D4D590", Offset = "0x1D4C190", VA = "0x181D4D590")]
		private void _UpdateTraitDesc(CharacterShowEquipModel equipModel)
		{
		}

		// Token: 0x06022D39 RID: 142649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022D39")]
		[Address(RVA = "0x1D4B0F0", Offset = "0x1D49CF0", VA = "0x181D4B0F0")]
		private string _CalcTraitDesc(CharacterShowEquipModel equipModel)
		{
			return null;
		}

		// Token: 0x06022D3A RID: 142650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022D3A")]
		[Address(RVA = "0x1D4BAA0", Offset = "0x1D4A6A0", VA = "0x181D4BAA0")]
		private CharacterShowSkillModel _GetSkillModel(string skillId)
		{
			return null;
		}

		// Token: 0x06022D3B RID: 142651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022D3B")]
		[Address(RVA = "0x1D4B990", Offset = "0x1D4A590", VA = "0x181D4B990")]
		private CharacterShowEquipModel _GetEquipModel(string equipId)
		{
			return null;
		}

		// Token: 0x06022D3C RID: 142652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022D3C")]
		[Address(RVA = "0x1D49A10", Offset = "0x1D48610", VA = "0x181D49A10")]
		public List<string> FetchTraitVariantList()
		{
			return null;
		}

		// Token: 0x06022D3D RID: 142653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D3D")]
		[Address(RVA = "0x1D4B310", Offset = "0x1D49F10", VA = "0x181D4B310")]
		private void _CalcTraitVariantList()
		{
		}

		// Token: 0x06022D3E RID: 142654 RVA: 0x000BF1F0 File Offset: 0x000BD3F0
		[Token(Token = "0x6022D3E")]
		[Address(RVA = "0x1D49C50", Offset = "0x1D48850", VA = "0x181D49C50")]
		public CharQuery GetCharQuery()
		{
			return default(CharQuery);
		}

		// Token: 0x06022D3F RID: 142655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D3F")]
		[Address(RVA = "0x1D4C0F0", Offset = "0x1D4ACF0", VA = "0x181D4C0F0")]
		private void _InitUniEquipList(List<CharacterShowViewModel.EquipDataStruct> equipList)
		{
		}

		// Token: 0x06022D40 RID: 142656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D40")]
		[Address(RVA = "0x1D4BDD0", Offset = "0x1D4A9D0", VA = "0x181D4BDD0")]
		private void _InitSkillModelList(List<CharacterShowViewModel.SkillDataStruct> skillList, int mainSkillLv, CharacterData charData)
		{
		}

		// Token: 0x06022D41 RID: 142657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D41")]
		[Address(RVA = "0x1D4C850", Offset = "0x1D4B450", VA = "0x181D4C850")]
		private void _LoadTokenModel()
		{
		}

		// Token: 0x06022D42 RID: 142658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D42")]
		[Address(RVA = "0x1D4C4B0", Offset = "0x1D4B0B0", VA = "0x181D4C4B0")]
		private void _LoadMasterData()
		{
		}

		// Token: 0x06022D43 RID: 142659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022D43")]
		[Address(RVA = "0x1D49ED0", Offset = "0x1D48AD0", VA = "0x181D49ED0")]
		public string GetMaxHpDisplayStr()
		{
			return null;
		}

		// Token: 0x06022D44 RID: 142660 RVA: 0x000BF208 File Offset: 0x000BD408
		[Token(Token = "0x6022D44")]
		[Address(RVA = "0x1D49FB0", Offset = "0x1D48BB0", VA = "0x181D49FB0")]
		public float GetMaxHpRatio()
		{
			return 0f;
		}

		// Token: 0x06022D45 RID: 142661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022D45")]
		[Address(RVA = "0x1D49A80", Offset = "0x1D48680", VA = "0x181D49A80")]
		public string GetAtkDisplayStr()
		{
			return null;
		}

		// Token: 0x06022D46 RID: 142662 RVA: 0x000BF220 File Offset: 0x000BD420
		[Token(Token = "0x6022D46")]
		[Address(RVA = "0x1D49B60", Offset = "0x1D48760", VA = "0x181D49B60")]
		public float GetAtkRatio()
		{
			return 0f;
		}

		// Token: 0x06022D47 RID: 142663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022D47")]
		[Address(RVA = "0x1D49D00", Offset = "0x1D48900", VA = "0x181D49D00")]
		public string GetDefDisplayStr()
		{
			return null;
		}

		// Token: 0x06022D48 RID: 142664 RVA: 0x000BF238 File Offset: 0x000BD438
		[Token(Token = "0x6022D48")]
		[Address(RVA = "0x1D49DE0", Offset = "0x1D489E0", VA = "0x181D49DE0")]
		public float GetDefRatio()
		{
			return 0f;
		}

		// Token: 0x06022D49 RID: 142665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022D49")]
		[Address(RVA = "0x1D4A0B0", Offset = "0x1D48CB0", VA = "0x181D4A0B0")]
		public string GetResDisplayStr()
		{
			return null;
		}

		// Token: 0x06022D4A RID: 142666 RVA: 0x000BF250 File Offset: 0x000BD450
		[Token(Token = "0x6022D4A")]
		[Address(RVA = "0x1D4A2E0", Offset = "0x1D48EE0", VA = "0x181D4A2E0")]
		public float GetResRatio()
		{
			return 0f;
		}

		// Token: 0x06022D4B RID: 142667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022D4B")]
		[Address(RVA = "0x1D4B840", Offset = "0x1D4A440", VA = "0x181D4B840")]
		private string _GetAttrValWithFavor(int totalVal, int favorVal)
		{
			return null;
		}

		// Token: 0x06022D4C RID: 142668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022D4C")]
		[Address(RVA = "0x1D4B6E0", Offset = "0x1D4A2E0", VA = "0x181D4B6E0")]
		private string _GetAttrValWithFavor(float totalVal, float favorVal)
		{
			return null;
		}

		// Token: 0x06022D4D RID: 142669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022D4D")]
		[Address(RVA = "0x1D4ADF0", Offset = "0x1D499F0", VA = "0x181D4ADF0")]
		private string _CalcTokenId()
		{
			return null;
		}

		// Token: 0x06022D4E RID: 142670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022D4E")]
		[Address(RVA = "0x1D4BBB0", Offset = "0x1D4A7B0", VA = "0x181D4BBB0")]
		private string _GetSkillTokenId()
		{
			return null;
		}

		// Token: 0x06022D4F RID: 142671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022D4F")]
		[Address(RVA = "0x1D4BCD0", Offset = "0x1D4A8D0", VA = "0x181D4BCD0")]
		private string _GetTalentTokenId()
		{
			return null;
		}

		// Token: 0x06022D50 RID: 142672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D50")]
		[Address(RVA = "0x1D4D620", Offset = "0x1D4C220", VA = "0x181D4D620")]
		public CharacterShowV2Model()
		{
		}

		// Token: 0x0402FE90 RID: 196240
		[Token(Token = "0x402FE90")]
		private const int TAG_LINE_WIDTH = 5;

		// Token: 0x0402FE91 RID: 196241
		[Token(Token = "0x402FE91")]
		private const int EQUIP_MIN_SHOW_CNT = 3;

		// Token: 0x0402FE92 RID: 196242
		[Token(Token = "0x402FE92")]
		private const string EXP_MAX_STR = "-";

		// Token: 0x0402FE93 RID: 196243
		[Token(Token = "0x402FE93")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isAllSlotVisible;

		// Token: 0x0402FE94 RID: 196244
		[Token(Token = "0x402FE94")]
		[FieldOffset(Offset = "0x11")]
		private bool m_isUnlockHintVisible;

		// Token: 0x0402FE95 RID: 196245
		[Token(Token = "0x402FE95")]
		[FieldOffset(Offset = "0x12")]
		private bool m_isBuildingBuffVisible;

		// Token: 0x0402FE96 RID: 196246
		[Token(Token = "0x402FE96")]
		[FieldOffset(Offset = "0x13")]
		private bool m_isMasterHide;

		// Token: 0x0402FE97 RID: 196247
		[Token(Token = "0x402FE97")]
		[FieldOffset(Offset = "0x14")]
		private bool m_isValid;

		// Token: 0x0402FE98 RID: 196248
		[Token(Token = "0x402FE98")]
		[FieldOffset(Offset = "0x15")]
		private bool m_isEquipCntOverLimit;

		// Token: 0x0402FE99 RID: 196249
		[Token(Token = "0x402FE99")]
		[FieldOffset(Offset = "0x18")]
		private string m_charId;

		// Token: 0x0402FE9A RID: 196250
		[Token(Token = "0x402FE9A")]
		[FieldOffset(Offset = "0x20")]
		private string m_tmplId;

		// Token: 0x0402FE9B RID: 196251
		[Token(Token = "0x402FE9B")]
		[FieldOffset(Offset = "0x28")]
		private EvolvePhase m_evolvePhase;

		// Token: 0x0402FE9C RID: 196252
		[Token(Token = "0x402FE9C")]
		[FieldOffset(Offset = "0x30")]
		private string m_skinId;

		// Token: 0x0402FE9D RID: 196253
		[Token(Token = "0x402FE9D")]
		[FieldOffset(Offset = "0x38")]
		private int m_level;

		// Token: 0x0402FE9E RID: 196254
		[Token(Token = "0x402FE9E")]
		[FieldOffset(Offset = "0x3C")]
		private int m_maxLevel;

		// Token: 0x0402FE9F RID: 196255
		[Token(Token = "0x402FE9F")]
		[FieldOffset(Offset = "0x40")]
		private int m_favorPoint;

		// Token: 0x0402FEA0 RID: 196256
		[Token(Token = "0x402FEA0")]
		[FieldOffset(Offset = "0x44")]
		private int m_potentialRank;

		// Token: 0x0402FEA1 RID: 196257
		[Token(Token = "0x402FEA1")]
		[FieldOffset(Offset = "0x48")]
		private int m_exp;

		// Token: 0x0402FEA2 RID: 196258
		[Token(Token = "0x402FEA2")]
		[FieldOffset(Offset = "0x4C")]
		private int m_maxExp;

		// Token: 0x0402FEA3 RID: 196259
		[Token(Token = "0x402FEA3")]
		[FieldOffset(Offset = "0x50")]
		private string m_tagsContent;

		// Token: 0x0402FEA4 RID: 196260
		[Token(Token = "0x402FEA4")]
		[FieldOffset(Offset = "0x58")]
		private string m_position;

		// Token: 0x0402FEA5 RID: 196261
		[Token(Token = "0x402FEA5")]
		[FieldOffset(Offset = "0x60")]
		private List<CharacterShowTalentModel> m_talentModelList;

		// Token: 0x0402FEA6 RID: 196262
		[Token(Token = "0x402FEA6")]
		[FieldOffset(Offset = "0x68")]
		private List<CharacterShowSkillModel> m_skillModelList;

		// Token: 0x0402FEA7 RID: 196263
		[Token(Token = "0x402FEA7")]
		[FieldOffset(Offset = "0x70")]
		private string m_selectedSkillId;

		// Token: 0x0402FEA8 RID: 196264
		[Token(Token = "0x402FEA8")]
		[FieldOffset(Offset = "0x78")]
		private List<CharacterShowEquipModel> m_equipModelList;

		// Token: 0x0402FEA9 RID: 196265
		[Token(Token = "0x402FEA9")]
		[FieldOffset(Offset = "0x80")]
		private string m_selectedEquipId;

		// Token: 0x0402FEAA RID: 196266
		[Token(Token = "0x402FEAA")]
		[FieldOffset(Offset = "0x88")]
		private float m_equipScrollNormalizedPos;

		// Token: 0x0402FEAB RID: 196267
		[Token(Token = "0x402FEAB")]
		[FieldOffset(Offset = "0x90")]
		private CharacterData m_charData;

		// Token: 0x0402FEAC RID: 196268
		[Token(Token = "0x402FEAC")]
		[FieldOffset(Offset = "0x98")]
		private SubProfessionData m_subProfData;

		// Token: 0x0402FEAD RID: 196269
		[Token(Token = "0x402FEAD")]
		[FieldOffset(Offset = "0xA0")]
		private FavorData m_favorData;

		// Token: 0x0402FEAE RID: 196270
		[Token(Token = "0x402FEAE")]
		[FieldOffset(Offset = "0xA8")]
		private string m_traitDesc;

		// Token: 0x0402FEAF RID: 196271
		[Token(Token = "0x402FEAF")]
		[FieldOffset(Offset = "0xB0")]
		private BattleInfoViewModel m_battleInfoModel;

		// Token: 0x0402FEB0 RID: 196272
		[Token(Token = "0x402FEB0")]
		[FieldOffset(Offset = "0xB8")]
		private List<string> m_traitVariantList;

		// Token: 0x0402FEB1 RID: 196273
		[Token(Token = "0x402FEB1")]
		[FieldOffset(Offset = "0xC0")]
		private List<BuildingBuffDescStruct> m_buildingBuffList;

		// Token: 0x0402FEB2 RID: 196274
		[Token(Token = "0x402FEB2")]
		[FieldOffset(Offset = "0xC8")]
		private List<CharacterShowMasterModel> m_masterShow;

		// Token: 0x0402FEB3 RID: 196275
		[Token(Token = "0x402FEB3")]
		[FieldOffset(Offset = "0xD0")]
		private int m_maxHp;

		// Token: 0x0402FEB4 RID: 196276
		[Token(Token = "0x402FEB4")]
		[FieldOffset(Offset = "0xD4")]
		private int m_atk;

		// Token: 0x0402FEB5 RID: 196277
		[Token(Token = "0x402FEB5")]
		[FieldOffset(Offset = "0xD8")]
		private int m_def;

		// Token: 0x0402FEB6 RID: 196278
		[Token(Token = "0x402FEB6")]
		[FieldOffset(Offset = "0xDC")]
		private float m_res;

		// Token: 0x0402FEB7 RID: 196279
		[Token(Token = "0x402FEB7")]
		[FieldOffset(Offset = "0xE0")]
		private string m_respawnTime;

		// Token: 0x0402FEB8 RID: 196280
		[Token(Token = "0x402FEB8")]
		[FieldOffset(Offset = "0xE8")]
		private int m_cost;

		// Token: 0x0402FEB9 RID: 196281
		[Token(Token = "0x402FEB9")]
		[FieldOffset(Offset = "0xF0")]
		private string m_atkSpeed;

		// Token: 0x0402FEBA RID: 196282
		[Token(Token = "0x402FEBA")]
		[FieldOffset(Offset = "0xF8")]
		private int m_blockNum;

		// Token: 0x0402FEBB RID: 196283
		[Token(Token = "0x402FEBB")]
		[FieldOffset(Offset = "0x100")]
		private AttributesData m_favorDelta;

		// Token: 0x0402FEBC RID: 196284
		[Token(Token = "0x402FEBC")]
		[FieldOffset(Offset = "0x108")]
		private bool m_showMergeAttrVal;

		// Token: 0x0402FEBD RID: 196285
		[Token(Token = "0x402FEBD")]
		[FieldOffset(Offset = "0x110")]
		private CharTokenViewModel m_charTokenViewModel;

		// Token: 0x0402FEBE RID: 196286
		[Token(Token = "0x402FEBE")]
		[FieldOffset(Offset = "0x118")]
		private int m_refreshEquipSeqNum;

		// Token: 0x0402FEBF RID: 196287
		[Token(Token = "0x402FEBF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isAllSlotVisible;

		// Token: 0x0402FEC0 RID: 196288
		[Token(Token = "0x402FEC0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isUnlockHintVisible;

		// Token: 0x0402FEC1 RID: 196289
		[Token(Token = "0x402FEC1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isEquipCntOverLimit;

		// Token: 0x0402FEC2 RID: 196290
		[Token(Token = "0x402FEC2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isMasterHide;

		// Token: 0x0402FEC3 RID: 196291
		[Token(Token = "0x402FEC3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_favorPercent;

		// Token: 0x0402FEC4 RID: 196292
		[Token(Token = "0x402FEC4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_buildingBuffList;

		// Token: 0x0402FEC5 RID: 196293
		[Token(Token = "0x402FEC5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_talentModelList;

		// Token: 0x0402FEC6 RID: 196294
		[Token(Token = "0x402FEC6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_masterModelList;

		// Token: 0x0402FEC7 RID: 196295
		[Token(Token = "0x402FEC7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_hasEquip;

		// Token: 0x0402FEC8 RID: 196296
		[Token(Token = "0x402FEC8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_hasTalent;

		// Token: 0x0402FEC9 RID: 196297
		[Token(Token = "0x402FEC9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_hasMaster;

		// Token: 0x0402FECA RID: 196298
		[Token(Token = "0x402FECA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_isBuildingBuffVisible;

		// Token: 0x0402FECB RID: 196299
		[Token(Token = "0x402FECB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_level;

		// Token: 0x0402FECC RID: 196300
		[Token(Token = "0x402FECC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_maxLevel;

		// Token: 0x0402FECD RID: 196301
		[Token(Token = "0x402FECD")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_evolvePhase;

		// Token: 0x0402FECE RID: 196302
		[Token(Token = "0x402FECE")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_potentialRank;

		// Token: 0x0402FECF RID: 196303
		[Token(Token = "0x402FECF")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_isLevelMax;

		// Token: 0x0402FED0 RID: 196304
		[Token(Token = "0x402FED0")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_expDesc;

		// Token: 0x0402FED1 RID: 196305
		[Token(Token = "0x402FED1")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_maxExpDesc;

		// Token: 0x0402FED2 RID: 196306
		[Token(Token = "0x402FED2")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_expProgress;

		// Token: 0x0402FED3 RID: 196307
		[Token(Token = "0x402FED3")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_maxHp;

		// Token: 0x0402FED4 RID: 196308
		[Token(Token = "0x402FED4")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_atk;

		// Token: 0x0402FED5 RID: 196309
		[Token(Token = "0x402FED5")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_def;

		// Token: 0x0402FED6 RID: 196310
		[Token(Token = "0x402FED6")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_res;

		// Token: 0x0402FED7 RID: 196311
		[Token(Token = "0x402FED7")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_respawnTime;

		// Token: 0x0402FED8 RID: 196312
		[Token(Token = "0x402FED8")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_cost;

		// Token: 0x0402FED9 RID: 196313
		[Token(Token = "0x402FED9")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_atkSpeed;

		// Token: 0x0402FEDA RID: 196314
		[Token(Token = "0x402FEDA")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_blockNum;

		// Token: 0x0402FEDB RID: 196315
		[Token(Token = "0x402FEDB")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_battleInfoModel;

		// Token: 0x0402FEDC RID: 196316
		[Token(Token = "0x402FEDC")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_isValid;

		// Token: 0x0402FEDD RID: 196317
		[Token(Token = "0x402FEDD")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_charId;

		// Token: 0x0402FEDE RID: 196318
		[Token(Token = "0x402FEDE")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_skinId;

		// Token: 0x0402FEDF RID: 196319
		[Token(Token = "0x402FEDF")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_charData;

		// Token: 0x0402FEE0 RID: 196320
		[Token(Token = "0x402FEE0")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_subProfId;

		// Token: 0x0402FEE1 RID: 196321
		[Token(Token = "0x402FEE1")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_get_subProfName;

		// Token: 0x0402FEE2 RID: 196322
		[Token(Token = "0x402FEE2")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_get_traitDesc;

		// Token: 0x0402FEE3 RID: 196323
		[Token(Token = "0x402FEE3")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_get_favorDelta;

		// Token: 0x0402FEE4 RID: 196324
		[Token(Token = "0x402FEE4")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_get_position;

		// Token: 0x0402FEE5 RID: 196325
		[Token(Token = "0x402FEE5")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_get_tagsContent;

		// Token: 0x0402FEE6 RID: 196326
		[Token(Token = "0x402FEE6")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_get_profession;

		// Token: 0x0402FEE7 RID: 196327
		[Token(Token = "0x402FEE7")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_get_equipList;

		// Token: 0x0402FEE8 RID: 196328
		[Token(Token = "0x402FEE8")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_get_skillList;

		// Token: 0x0402FEE9 RID: 196329
		[Token(Token = "0x402FEE9")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_get_selectedSkillId;

		// Token: 0x0402FEEA RID: 196330
		[Token(Token = "0x402FEEA")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_get_selectedEquipId;

		// Token: 0x0402FEEB RID: 196331
		[Token(Token = "0x402FEEB")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_get_equipScrollNormalizedPos;

		// Token: 0x0402FEEC RID: 196332
		[Token(Token = "0x402FEEC")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_get_charTokenViewModel;

		// Token: 0x0402FEED RID: 196333
		[Token(Token = "0x402FEED")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_get_refreshEquipSeqNum;

		// Token: 0x0402FEEE RID: 196334
		[Token(Token = "0x402FEEE")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402FEEF RID: 196335
		[Token(Token = "0x402FEEF")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_GetSelectedEquipModel;

		// Token: 0x0402FEF0 RID: 196336
		[Token(Token = "0x402FEF0")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_GetSelectedSkillModel;

		// Token: 0x0402FEF1 RID: 196337
		[Token(Token = "0x402FEF1")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__GenerateTagContent;

		// Token: 0x0402FEF2 RID: 196338
		[Token(Token = "0x402FEF2")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_TryUpdateDataWithSKillId;

		// Token: 0x0402FEF3 RID: 196339
		[Token(Token = "0x402FEF3")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__UpdateDataWithSKill;

		// Token: 0x0402FEF4 RID: 196340
		[Token(Token = "0x402FEF4")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_TryUpdateDataWithEquipId;

		// Token: 0x0402FEF5 RID: 196341
		[Token(Token = "0x402FEF5")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__UpdateDataWithEquip;

		// Token: 0x0402FEF6 RID: 196342
		[Token(Token = "0x402FEF6")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0__SetEquipListFocus;

		// Token: 0x0402FEF7 RID: 196343
		[Token(Token = "0x402FEF7")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__UpdateTalentList;

		// Token: 0x0402FEF8 RID: 196344
		[Token(Token = "0x402FEF8")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0__UpdateAttributes;

		// Token: 0x0402FEF9 RID: 196345
		[Token(Token = "0x402FEF9")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0__UpdateBattleInfoModel;

		// Token: 0x0402FEFA RID: 196346
		[Token(Token = "0x402FEFA")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0__UpdateTraitDesc;

		// Token: 0x0402FEFB RID: 196347
		[Token(Token = "0x402FEFB")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0__CalcTraitDesc;

		// Token: 0x0402FEFC RID: 196348
		[Token(Token = "0x402FEFC")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0__GetSkillModel;

		// Token: 0x0402FEFD RID: 196349
		[Token(Token = "0x402FEFD")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0__GetEquipModel;

		// Token: 0x0402FEFE RID: 196350
		[Token(Token = "0x402FEFE")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_FetchTraitVariantList;

		// Token: 0x0402FEFF RID: 196351
		[Token(Token = "0x402FEFF")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0__CalcTraitVariantList;

		// Token: 0x0402FF00 RID: 196352
		[Token(Token = "0x402FF00")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_GetCharQuery;

		// Token: 0x0402FF01 RID: 196353
		[Token(Token = "0x402FF01")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0__InitUniEquipList;

		// Token: 0x0402FF02 RID: 196354
		[Token(Token = "0x402FF02")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0__InitSkillModelList;

		// Token: 0x0402FF03 RID: 196355
		[Token(Token = "0x402FF03")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0__LoadTokenModel;

		// Token: 0x0402FF04 RID: 196356
		[Token(Token = "0x402FF04")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0__LoadMasterData;

		// Token: 0x0402FF05 RID: 196357
		[Token(Token = "0x402FF05")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_GetMaxHpDisplayStr;

		// Token: 0x0402FF06 RID: 196358
		[Token(Token = "0x402FF06")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_GetMaxHpRatio;

		// Token: 0x0402FF07 RID: 196359
		[Token(Token = "0x402FF07")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_GetAtkDisplayStr;

		// Token: 0x0402FF08 RID: 196360
		[Token(Token = "0x402FF08")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_GetAtkRatio;

		// Token: 0x0402FF09 RID: 196361
		[Token(Token = "0x402FF09")]
		[FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_GetDefDisplayStr;

		// Token: 0x0402FF0A RID: 196362
		[Token(Token = "0x402FF0A")]
		[FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_GetDefRatio;

		// Token: 0x0402FF0B RID: 196363
		[Token(Token = "0x402FF0B")]
		[FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0_GetResDisplayStr;

		// Token: 0x0402FF0C RID: 196364
		[Token(Token = "0x402FF0C")]
		[FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0_GetResRatio;

		// Token: 0x0402FF0D RID: 196365
		[Token(Token = "0x402FF0D")]
		[FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0__GetAttrValWithFavor;

		// Token: 0x0402FF0E RID: 196366
		[Token(Token = "0x402FF0E")]
		[FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix1__GetAttrValWithFavor;

		// Token: 0x0402FF0F RID: 196367
		[Token(Token = "0x402FF0F")]
		[FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0__CalcTokenId;

		// Token: 0x0402FF10 RID: 196368
		[Token(Token = "0x402FF10")]
		[FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0__GetSkillTokenId;

		// Token: 0x0402FF11 RID: 196369
		[Token(Token = "0x402FF11")]
		[FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0__GetTalentTokenId;

		// Token: 0x0402FF12 RID: 196370
		[Token(Token = "0x402FF12")]
		[FieldOffset(Offset = "0x298")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
