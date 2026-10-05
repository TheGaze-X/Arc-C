using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.CharWord;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003504 RID: 13572
	[Token(Token = "0x2003504")]
	public class CharacterCardViewModel : IBasicCharInfo, IHotfixable
	{
		// Token: 0x17003356 RID: 13142
		// (get) Token: 0x06015A5C RID: 88668 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015A5D RID: 88669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003356")]
		public BasicCharInfoModel basicCharInfo
		{
			[Token(Token = "0x6015A5C")]
			[Address(RVA = "0xE342F0", Offset = "0xE32EF0", VA = "0x180E342F0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6015A5D")]
			[Address(RVA = "0xE35980", Offset = "0xE34580", VA = "0x180E35980")]
			set
			{
			}
		}

		// Token: 0x17003357 RID: 13143
		// (get) Token: 0x06015A5E RID: 88670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003357")]
		public CharacterCardSkillInfo skillInfo
		{
			[Token(Token = "0x6015A5E")]
			[Address(RVA = "0xE35520", Offset = "0xE34120", VA = "0x180E35520")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003358 RID: 13144
		// (get) Token: 0x06015A5F RID: 88671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003358")]
		public CharacterCardEquipInfo equipInfo
		{
			[Token(Token = "0x6015A5F")]
			[Address(RVA = "0xE34990", Offset = "0xE33590", VA = "0x180E34990")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003359 RID: 13145
		// (get) Token: 0x06015A60 RID: 88672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003359")]
		public ICharSkinInfo skinInfo
		{
			[Token(Token = "0x6015A60")]
			[Address(RVA = "0xE35730", Offset = "0xE34330", VA = "0x180E35730")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700335A RID: 13146
		// (get) Token: 0x06015A61 RID: 88673 RVA: 0x0008D2B8 File Offset: 0x0008B4B8
		[Token(Token = "0x1700335A")]
		public int chrInstId
		{
			[Token(Token = "0x6015A61")]
			[Address(RVA = "0xE343C0", Offset = "0xE32FC0", VA = "0x180E343C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700335B RID: 13147
		// (get) Token: 0x06015A62 RID: 88674 RVA: 0x0008D2D0 File Offset: 0x0008B4D0
		[Token(Token = "0x1700335B")]
		public RarityRank rarity
		{
			[Token(Token = "0x6015A62")]
			[Address(RVA = "0xE35220", Offset = "0xE33E20", VA = "0x180E35220")]
			get
			{
				return RarityRank.TIER_1;
			}
		}

		// Token: 0x1700335C RID: 13148
		// (get) Token: 0x06015A63 RID: 88675 RVA: 0x0008D2E8 File Offset: 0x0008B4E8
		[Token(Token = "0x1700335C")]
		public ProfessionCategory profession
		{
			[Token(Token = "0x6015A63")]
			[Address(RVA = "0xE35160", Offset = "0xE33D60", VA = "0x180E35160")]
			get
			{
				return ProfessionCategory.NONE;
			}
		}

		// Token: 0x1700335D RID: 13149
		// (get) Token: 0x06015A64 RID: 88676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700335D")]
		public string subProfessionId
		{
			[Token(Token = "0x6015A64")]
			[Address(RVA = "0xE35850", Offset = "0xE34450", VA = "0x180E35850")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700335E RID: 13150
		// (get) Token: 0x06015A65 RID: 88677 RVA: 0x0008D300 File Offset: 0x0008B500
		[Token(Token = "0x1700335E")]
		public EvolvePhase evolvePhase
		{
			[Token(Token = "0x6015A65")]
			[Address(RVA = "0xE34A60", Offset = "0xE33660", VA = "0x180E34A60")]
			get
			{
				return EvolvePhase.PHASE_0;
			}
		}

		// Token: 0x1700335F RID: 13151
		// (get) Token: 0x06015A66 RID: 88678 RVA: 0x0008D318 File Offset: 0x0008B518
		[Token(Token = "0x1700335F")]
		public int potentialRank
		{
			[Token(Token = "0x6015A66")]
			[Address(RVA = "0xE350F0", Offset = "0xE33CF0", VA = "0x180E350F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003360 RID: 13152
		// (get) Token: 0x06015A67 RID: 88679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003360")]
		public string description
		{
			[Token(Token = "0x6015A67")]
			[Address(RVA = "0xE34830", Offset = "0xE33430", VA = "0x180E34830")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003361 RID: 13153
		// (get) Token: 0x06015A68 RID: 88680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003361")]
		public string name
		{
			[Token(Token = "0x6015A68")]
			[Address(RVA = "0xE34F20", Offset = "0xE33B20", VA = "0x180E34F20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003362 RID: 13154
		// (get) Token: 0x06015A69 RID: 88681 RVA: 0x0008D330 File Offset: 0x0008B530
		[Token(Token = "0x17003362")]
		public int level
		{
			[Token(Token = "0x6015A69")]
			[Address(RVA = "0xE34D20", Offset = "0xE33920", VA = "0x180E34D20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003363 RID: 13155
		// (get) Token: 0x06015A6A RID: 88682 RVA: 0x0008D348 File Offset: 0x0008B548
		[Token(Token = "0x17003363")]
		public float expPercent
		{
			[Token(Token = "0x6015A6A")]
			[Address(RVA = "0xE34AD0", Offset = "0xE336D0", VA = "0x180E34AD0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003364 RID: 13156
		// (get) Token: 0x06015A6B RID: 88683 RVA: 0x0008D360 File Offset: 0x0008B560
		[Token(Token = "0x17003364")]
		public DateTime gainTime
		{
			[Token(Token = "0x6015A6B")]
			[Address(RVA = "0xE34B90", Offset = "0xE33790", VA = "0x180E34B90")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x17003365 RID: 13157
		// (get) Token: 0x06015A6C RID: 88684 RVA: 0x0008D378 File Offset: 0x0008B578
		[Token(Token = "0x17003365")]
		public int cost
		{
			[Token(Token = "0x6015A6C")]
			[Address(RVA = "0xE34490", Offset = "0xE33090", VA = "0x180E34490")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003366 RID: 13158
		// (get) Token: 0x06015A6D RID: 88685 RVA: 0x0008D390 File Offset: 0x0008B590
		[Token(Token = "0x17003366")]
		public int maxHp
		{
			[Token(Token = "0x6015A6D")]
			[Address(RVA = "0xE34E00", Offset = "0xE33A00", VA = "0x180E34E00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003367 RID: 13159
		// (get) Token: 0x06015A6E RID: 88686 RVA: 0x0008D3A8 File Offset: 0x0008B5A8
		[Token(Token = "0x17003367")]
		public int atk
		{
			[Token(Token = "0x6015A6E")]
			[Address(RVA = "0xE341D0", Offset = "0xE32DD0", VA = "0x180E341D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003368 RID: 13160
		// (get) Token: 0x06015A6F RID: 88687 RVA: 0x0008D3C0 File Offset: 0x0008B5C0
		[Token(Token = "0x17003368")]
		public int def
		{
			[Token(Token = "0x6015A6F")]
			[Address(RVA = "0xE345B0", Offset = "0xE331B0", VA = "0x180E345B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003369 RID: 13161
		// (get) Token: 0x06015A70 RID: 88688 RVA: 0x0008D3D8 File Offset: 0x0008B5D8
		[Token(Token = "0x17003369")]
		public float res
		{
			[Token(Token = "0x6015A70")]
			[Address(RVA = "0xE352E0", Offset = "0xE33EE0", VA = "0x180E352E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700336A RID: 13162
		// (get) Token: 0x06015A71 RID: 88689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700336A")]
		public string charId
		{
			[Token(Token = "0x6015A71")]
			[Address(RVA = "0xE34350", Offset = "0xE32F50", VA = "0x180E34350")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700336B RID: 13163
		// (get) Token: 0x06015A72 RID: 88690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700336B")]
		public string tmplId
		{
			[Token(Token = "0x6015A72")]
			[Address(RVA = "0xE35910", Offset = "0xE34510", VA = "0x180E35910")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700336C RID: 13164
		// (get) Token: 0x06015A73 RID: 88691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700336C")]
		public string skinId
		{
			[Token(Token = "0x6015A73")]
			[Address(RVA = "0xE356C0", Offset = "0xE342C0", VA = "0x180E356C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700336D RID: 13165
		// (get) Token: 0x06015A74 RID: 88692 RVA: 0x0008D3F0 File Offset: 0x0008B5F0
		[Token(Token = "0x1700336D")]
		public CharStarMarkState starMark
		{
			[Token(Token = "0x6015A74")]
			[Address(RVA = "0xE35790", Offset = "0xE34390", VA = "0x180E35790")]
			get
			{
				return CharStarMarkState.NONE;
			}
		}

		// Token: 0x1700336E RID: 13166
		// (get) Token: 0x06015A75 RID: 88693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700336E")]
		public string portraitId
		{
			[Token(Token = "0x6015A75")]
			[Address(RVA = "0xE35010", Offset = "0xE33C10", VA = "0x180E35010")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700336F RID: 13167
		// (get) Token: 0x06015A76 RID: 88694 RVA: 0x0008D408 File Offset: 0x0008B608
		[Token(Token = "0x1700336F")]
		public int defaultSkillIndex
		{
			[Token(Token = "0x6015A76")]
			[Address(RVA = "0xE346D0", Offset = "0xE332D0", VA = "0x180E346D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003370 RID: 13168
		// (get) Token: 0x06015A77 RID: 88695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003370")]
		public string skillId
		{
			[Token(Token = "0x6015A77")]
			[Address(RVA = "0xE354B0", Offset = "0xE340B0", VA = "0x180E354B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003371 RID: 13169
		// (get) Token: 0x06015A78 RID: 88696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003371")]
		public string skillName
		{
			[Token(Token = "0x6015A78")]
			[Address(RVA = "0xE35580", Offset = "0xE34180", VA = "0x180E35580")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003372 RID: 13170
		// (get) Token: 0x06015A79 RID: 88697 RVA: 0x0008D420 File Offset: 0x0008B620
		[Token(Token = "0x17003372")]
		public int mainSkillLvl
		{
			[Token(Token = "0x6015A79")]
			[Address(RVA = "0xE34D90", Offset = "0xE33990", VA = "0x180E34D90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003373 RID: 13171
		// (get) Token: 0x06015A7A RID: 88698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003373")]
		public string skillIconId
		{
			[Token(Token = "0x6015A7A")]
			[Address(RVA = "0xE35410", Offset = "0xE34010", VA = "0x180E35410")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003374 RID: 13172
		// (get) Token: 0x06015A7B RID: 88699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003374")]
		public PlayerCharSkill[] skills
		{
			[Token(Token = "0x6015A7B")]
			[Address(RVA = "0xE35620", Offset = "0xE34220", VA = "0x180E35620")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003375 RID: 13173
		// (get) Token: 0x06015A7C RID: 88700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003375")]
		public string equipId
		{
			[Token(Token = "0x6015A7C")]
			[Address(RVA = "0xE34920", Offset = "0xE33520", VA = "0x180E34920")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015A7D RID: 88701 RVA: 0x0008D438 File Offset: 0x0008B638
		[Token(Token = "0x6015A7D")]
		[Address(RVA = "0xE338E0", Offset = "0xE324E0", VA = "0x180E338E0")]
		public CharQuery GetCharQuery()
		{
			return default(CharQuery);
		}

		// Token: 0x06015A7E RID: 88702 RVA: 0x0008D450 File Offset: 0x0008B650
		[Token(Token = "0x6015A7E")]
		[Address(RVA = "0xE33A00", Offset = "0xE32600", VA = "0x180E33A00")]
		public VoiceQuery GetVoiceQuery()
		{
			return default(VoiceQuery);
		}

		// Token: 0x17003376 RID: 13174
		// (get) Token: 0x06015A7F RID: 88703 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015A80 RID: 88704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003376")]
		public Sprite chrProfessionIconSprite
		{
			[Token(Token = "0x6015A7F")]
			[Address(RVA = "0xE34430", Offset = "0xE33030", VA = "0x180E34430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6015A80")]
			[Address(RVA = "0xE35A00", Offset = "0xE34600", VA = "0x180E35A00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003377 RID: 13175
		// (get) Token: 0x06015A81 RID: 88705 RVA: 0x0008D468 File Offset: 0x0008B668
		[Token(Token = "0x17003377")]
		public bool isAllSpecMax
		{
			[Token(Token = "0x6015A81")]
			[Address(RVA = "0xE34C80", Offset = "0xE33880", VA = "0x180E34C80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003378 RID: 13176
		// (get) Token: 0x06015A82 RID: 88706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003378")]
		public ListDict<string, PlayerCharEquipInfo> equips
		{
			[Token(Token = "0x6015A82")]
			[Address(RVA = "0xE349F0", Offset = "0xE335F0", VA = "0x180E349F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015A83 RID: 88707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A83")]
		[Address(RVA = "0xE33B10", Offset = "0xE32710", VA = "0x180E33B10")]
		public void LoadNecessarySprites(SpriteHub professionHub)
		{
		}

		// Token: 0x06015A84 RID: 88708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A84")]
		[Address(RVA = "0xE33020", Offset = "0xE31C20", VA = "0x180E33020")]
		public void ClearSprites()
		{
		}

		// Token: 0x06015A85 RID: 88709 RVA: 0x0008D480 File Offset: 0x0008B680
		[Token(Token = "0x6015A85")]
		[Address(RVA = "0xE33080", Offset = "0xE31C80", VA = "0x180E33080")]
		public bool FillViewModel(PlayerCharacter playerChar, bool instAble = true)
		{
			return default(bool);
		}

		// Token: 0x06015A86 RID: 88710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015A86")]
		[Address(RVA = "0xE33F50", Offset = "0xE32B50", VA = "0x180E33F50")]
		public CharacterCardViewModel ShallowCopy()
		{
			return null;
		}

		// Token: 0x06015A87 RID: 88711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A87")]
		[Address(RVA = "0xE33E40", Offset = "0xE32A40", VA = "0x180E33E40")]
		public void SetSkillInfo(string newSkillId)
		{
		}

		// Token: 0x06015A88 RID: 88712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A88")]
		[Address(RVA = "0xE33D30", Offset = "0xE32930", VA = "0x180E33D30")]
		public void SetEquipInfo(string newEquipId)
		{
		}

		// Token: 0x06015A89 RID: 88713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A89")]
		[Address(RVA = "0xE34030", Offset = "0xE32C30", VA = "0x180E34030")]
		public CharacterCardViewModel()
		{
		}

		// Token: 0x04019F4D RID: 106317
		[Token(Token = "0x4019F4D")]
		[FieldOffset(Offset = "0x10")]
		private readonly CharacterCardSkillInfo m_skillInfo;

		// Token: 0x04019F4E RID: 106318
		[Token(Token = "0x4019F4E")]
		[FieldOffset(Offset = "0x18")]
		private readonly CharacterCardEquipInfo m_equipInfo;

		// Token: 0x04019F4F RID: 106319
		[Token(Token = "0x4019F4F")]
		[FieldOffset(Offset = "0x20")]
		private BasicCharInfoModel m_basicInfo;

		// Token: 0x04019F50 RID: 106320
		[Token(Token = "0x4019F50")]
		[FieldOffset(Offset = "0x28")]
		public string professionIconId;

		// Token: 0x04019F51 RID: 106321
		[Token(Token = "0x4019F51")]
		[FieldOffset(Offset = "0x30")]
		public bool isInSquad;

		// Token: 0x04019F53 RID: 106323
		[Token(Token = "0x4019F53")]
		[FieldOffset(Offset = "0x40")]
		private string m_profIdCache;

		// Token: 0x04019F54 RID: 106324
		[Token(Token = "0x4019F54")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_basicCharInfo;

		// Token: 0x04019F55 RID: 106325
		[Token(Token = "0x4019F55")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_basicCharInfo;

		// Token: 0x04019F56 RID: 106326
		[Token(Token = "0x4019F56")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_skillInfo;

		// Token: 0x04019F57 RID: 106327
		[Token(Token = "0x4019F57")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_equipInfo;

		// Token: 0x04019F58 RID: 106328
		[Token(Token = "0x4019F58")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_skinInfo;

		// Token: 0x04019F59 RID: 106329
		[Token(Token = "0x4019F59")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_chrInstId;

		// Token: 0x04019F5A RID: 106330
		[Token(Token = "0x4019F5A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_rarity;

		// Token: 0x04019F5B RID: 106331
		[Token(Token = "0x4019F5B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_profession;

		// Token: 0x04019F5C RID: 106332
		[Token(Token = "0x4019F5C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_subProfessionId;

		// Token: 0x04019F5D RID: 106333
		[Token(Token = "0x4019F5D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_evolvePhase;

		// Token: 0x04019F5E RID: 106334
		[Token(Token = "0x4019F5E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_potentialRank;

		// Token: 0x04019F5F RID: 106335
		[Token(Token = "0x4019F5F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_description;

		// Token: 0x04019F60 RID: 106336
		[Token(Token = "0x4019F60")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x04019F61 RID: 106337
		[Token(Token = "0x4019F61")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_level;

		// Token: 0x04019F62 RID: 106338
		[Token(Token = "0x4019F62")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_expPercent;

		// Token: 0x04019F63 RID: 106339
		[Token(Token = "0x4019F63")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_gainTime;

		// Token: 0x04019F64 RID: 106340
		[Token(Token = "0x4019F64")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_cost;

		// Token: 0x04019F65 RID: 106341
		[Token(Token = "0x4019F65")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_maxHp;

		// Token: 0x04019F66 RID: 106342
		[Token(Token = "0x4019F66")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_atk;

		// Token: 0x04019F67 RID: 106343
		[Token(Token = "0x4019F67")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_def;

		// Token: 0x04019F68 RID: 106344
		[Token(Token = "0x4019F68")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_res;

		// Token: 0x04019F69 RID: 106345
		[Token(Token = "0x4019F69")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_charId;

		// Token: 0x04019F6A RID: 106346
		[Token(Token = "0x4019F6A")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_tmplId;

		// Token: 0x04019F6B RID: 106347
		[Token(Token = "0x4019F6B")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_skinId;

		// Token: 0x04019F6C RID: 106348
		[Token(Token = "0x4019F6C")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_starMark;

		// Token: 0x04019F6D RID: 106349
		[Token(Token = "0x4019F6D")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_portraitId;

		// Token: 0x04019F6E RID: 106350
		[Token(Token = "0x4019F6E")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_defaultSkillIndex;

		// Token: 0x04019F6F RID: 106351
		[Token(Token = "0x4019F6F")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_skillId;

		// Token: 0x04019F70 RID: 106352
		[Token(Token = "0x4019F70")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_skillName;

		// Token: 0x04019F71 RID: 106353
		[Token(Token = "0x4019F71")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_mainSkillLvl;

		// Token: 0x04019F72 RID: 106354
		[Token(Token = "0x4019F72")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_skillIconId;

		// Token: 0x04019F73 RID: 106355
		[Token(Token = "0x4019F73")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_skills;

		// Token: 0x04019F74 RID: 106356
		[Token(Token = "0x4019F74")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_equipId;

		// Token: 0x04019F75 RID: 106357
		[Token(Token = "0x4019F75")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_GetCharQuery;

		// Token: 0x04019F76 RID: 106358
		[Token(Token = "0x4019F76")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_GetVoiceQuery;

		// Token: 0x04019F77 RID: 106359
		[Token(Token = "0x4019F77")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_get_chrProfessionIconSprite;

		// Token: 0x04019F78 RID: 106360
		[Token(Token = "0x4019F78")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_set_chrProfessionIconSprite;

		// Token: 0x04019F79 RID: 106361
		[Token(Token = "0x4019F79")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_get_isAllSpecMax;

		// Token: 0x04019F7A RID: 106362
		[Token(Token = "0x4019F7A")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_get_equips;

		// Token: 0x04019F7B RID: 106363
		[Token(Token = "0x4019F7B")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_LoadNecessarySprites;

		// Token: 0x04019F7C RID: 106364
		[Token(Token = "0x4019F7C")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_ClearSprites;

		// Token: 0x04019F7D RID: 106365
		[Token(Token = "0x4019F7D")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_FillViewModel;

		// Token: 0x04019F7E RID: 106366
		[Token(Token = "0x4019F7E")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_ShallowCopy;

		// Token: 0x04019F7F RID: 106367
		[Token(Token = "0x4019F7F")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_SetSkillInfo;

		// Token: 0x04019F80 RID: 106368
		[Token(Token = "0x4019F80")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_SetEquipInfo;

		// Token: 0x04019F81 RID: 106369
		[Token(Token = "0x4019F81")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
