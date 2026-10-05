using System;
using Il2CppDummyDll;
using Torappu.CharWord;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035AD RID: 13741
	[Token(Token = "0x20035AD")]
	public abstract class CommonCharCardViewModel : ICharacterCardViewModel, IHotfixable, IComparableChar
	{
		// Token: 0x06015DBB RID: 89531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015DBB")]
		[Address(RVA = "0xE5D3A0", Offset = "0xE5BFA0", VA = "0x180E5D3A0", Slot = "6")]
		public void ClearChar()
		{
		}

		// Token: 0x17003458 RID: 13400
		// (get) Token: 0x06015DBC RID: 89532 RVA: 0x0008E650 File Offset: 0x0008C850
		[Token(Token = "0x17003458")]
		public bool isEmpty
		{
			[Token(Token = "0x6015DBC")]
			[Address(RVA = "0xE5ED40", Offset = "0xE5D940", VA = "0x180E5ED40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06015DBD RID: 89533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015DBD")]
		public TInfo SetCharInfo<TInfo>(CommonCharCardInfoType infoType, TInfo characterInfo) where TInfo : class, ICharacterInfo
		{
			return null;
		}

		// Token: 0x06015DBE RID: 89534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015DBE")]
		public TInfo GetCharInfo<TInfo>(CommonCharCardInfoType infoType) where TInfo : class, ICharacterInfo
		{
			return null;
		}

		// Token: 0x17003459 RID: 13401
		// (get) Token: 0x06015DBF RID: 89535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003459")]
		public string charId
		{
			[Token(Token = "0x6015DBF")]
			[Address(RVA = "0xE5DD60", Offset = "0xE5C960", VA = "0x180E5DD60", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700345A RID: 13402
		// (get) Token: 0x06015DC0 RID: 89536 RVA: 0x0008E668 File Offset: 0x0008C868
		[Token(Token = "0x1700345A")]
		public int charInstId
		{
			[Token(Token = "0x6015DC0")]
			[Address(RVA = "0xE5DE00", Offset = "0xE5CA00", VA = "0x180E5DE00", Slot = "9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700345B RID: 13403
		// (get) Token: 0x06015DC1 RID: 89537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700345B")]
		public string tmplId
		{
			[Token(Token = "0x6015DC1")]
			[Address(RVA = "0xE5FCD0", Offset = "0xE5E8D0", VA = "0x180E5FCD0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700345C RID: 13404
		// (get) Token: 0x06015DC2 RID: 89538 RVA: 0x0008E680 File Offset: 0x0008C880
		[Token(Token = "0x1700345C")]
		public CharQuery charQuery
		{
			[Token(Token = "0x6015DC2")]
			[Address(RVA = "0xE5DEA0", Offset = "0xE5CAA0", VA = "0x180E5DEA0", Slot = "11")]
			get
			{
				return default(CharQuery);
			}
		}

		// Token: 0x1700345D RID: 13405
		// (get) Token: 0x06015DC3 RID: 89539 RVA: 0x0008E698 File Offset: 0x0008C898
		[Token(Token = "0x1700345D")]
		public VoiceQuery charVoiceQuery
		{
			[Token(Token = "0x6015DC3")]
			[Address(RVA = "0xE5E080", Offset = "0xE5CC80", VA = "0x180E5E080", Slot = "12")]
			get
			{
				return default(VoiceQuery);
			}
		}

		// Token: 0x1700345E RID: 13406
		// (get) Token: 0x06015DC4 RID: 89540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700345E")]
		public string skillId
		{
			[Token(Token = "0x6015DC4")]
			[Address(RVA = "0xE5F800", Offset = "0xE5E400", VA = "0x180E5F800", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700345F RID: 13407
		// (get) Token: 0x06015DC5 RID: 89541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700345F")]
		public string defaultSkillId
		{
			[Token(Token = "0x6015DC5")]
			[Address(RVA = "0xE5E6A0", Offset = "0xE5D2A0", VA = "0x180E5E6A0", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003460 RID: 13408
		// (get) Token: 0x06015DC6 RID: 89542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003460")]
		public PlayerCharSkill curSkill
		{
			[Token(Token = "0x6015DC6")]
			[Address(RVA = "0xE5E400", Offset = "0xE5D000", VA = "0x180E5E400")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003461 RID: 13409
		// (get) Token: 0x06015DC7 RID: 89543 RVA: 0x0008E6B0 File Offset: 0x0008C8B0
		[Token(Token = "0x17003461")]
		public int mainSkillLvl
		{
			[Token(Token = "0x6015DC7")]
			[Address(RVA = "0xE5F030", Offset = "0xE5DC30", VA = "0x180E5F030", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003462 RID: 13410
		// (get) Token: 0x06015DC8 RID: 89544 RVA: 0x0008E6C8 File Offset: 0x0008C8C8
		// (set) Token: 0x06015DC9 RID: 89545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003462")]
		public virtual int skillSpecLvl
		{
			[Token(Token = "0x6015DC8")]
			[Address(RVA = "0xE5F8C0", Offset = "0xE5E4C0", VA = "0x180E5F8C0", Slot = "52")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6015DC9")]
			[Address(RVA = "0xE5FF10", Offset = "0xE5EB10", VA = "0x180E5FF10", Slot = "53")]
			set
			{
			}
		}

		// Token: 0x17003463 RID: 13411
		// (get) Token: 0x06015DCA RID: 89546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003463")]
		public ListDict<string, PlayerCharSkill> skills
		{
			[Token(Token = "0x6015DCA")]
			[Address(RVA = "0xE5F950", Offset = "0xE5E550", VA = "0x180E5F950", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003464 RID: 13412
		// (get) Token: 0x06015DCB RID: 89547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003464")]
		public string equipId
		{
			[Token(Token = "0x6015DCB")]
			[Address(RVA = "0xE5E760", Offset = "0xE5D360", VA = "0x180E5E760", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003465 RID: 13413
		// (get) Token: 0x06015DCC RID: 89548 RVA: 0x0008E6E0 File Offset: 0x0008C8E0
		// (set) Token: 0x06015DCD RID: 89549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003465")]
		public int equipLvl
		{
			[Token(Token = "0x6015DCC")]
			[Address(RVA = "0xE5E820", Offset = "0xE5D420", VA = "0x180E5E820", Slot = "21")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6015DCD")]
			[Address(RVA = "0xE5FD90", Offset = "0xE5E990", VA = "0x180E5FD90")]
			set
			{
			}
		}

		// Token: 0x17003466 RID: 13414
		// (get) Token: 0x06015DCE RID: 89550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003466")]
		public virtual ListDict<string, PlayerCharEquipInfo> equips
		{
			[Token(Token = "0x6015DCE")]
			[Address(RVA = "0xE5E950", Offset = "0xE5D550", VA = "0x180E5E950", Slot = "54")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003467 RID: 13415
		// (get) Token: 0x06015DCF RID: 89551 RVA: 0x0008E6F8 File Offset: 0x0008C8F8
		[Token(Token = "0x17003467")]
		public CharUISkinStruct skinStruct
		{
			[Token(Token = "0x6015DCF")]
			[Address(RVA = "0xE5F9F0", Offset = "0xE5E5F0", VA = "0x180E5F9F0", Slot = "24")]
			get
			{
				return default(CharUISkinStruct);
			}
		}

		// Token: 0x17003468 RID: 13416
		// (get) Token: 0x06015DD0 RID: 89552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003468")]
		public string name
		{
			[Token(Token = "0x6015DD0")]
			[Address(RVA = "0xE5F330", Offset = "0xE5DF30", VA = "0x180E5F330", Slot = "34")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003469 RID: 13417
		// (get) Token: 0x06015DD1 RID: 89553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003469")]
		public string nickName
		{
			[Token(Token = "0x6015DD1")]
			[Address(RVA = "0xE5F3D0", Offset = "0xE5DFD0", VA = "0x180E5F3D0", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700346A RID: 13418
		// (get) Token: 0x06015DD2 RID: 89554 RVA: 0x0008E710 File Offset: 0x0008C910
		[Token(Token = "0x1700346A")]
		public RarityRank rarity
		{
			[Token(Token = "0x6015DD2")]
			[Address(RVA = "0xE5F5B0", Offset = "0xE5E1B0", VA = "0x180E5F5B0", Slot = "35")]
			get
			{
				return RarityRank.TIER_1;
			}
		}

		// Token: 0x1700346B RID: 13419
		// (get) Token: 0x06015DD3 RID: 89555 RVA: 0x0008E728 File Offset: 0x0008C928
		[Token(Token = "0x1700346B")]
		public int level
		{
			[Token(Token = "0x6015DD3")]
			[Address(RVA = "0xE5EDC0", Offset = "0xE5D9C0", VA = "0x180E5EDC0", Slot = "38")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700346C RID: 13420
		// (get) Token: 0x06015DD4 RID: 89556 RVA: 0x0008E740 File Offset: 0x0008C940
		[Token(Token = "0x1700346C")]
		public int maxLevel
		{
			[Token(Token = "0x6015DD4")]
			[Address(RVA = "0xE5F290", Offset = "0xE5DE90", VA = "0x180E5F290", Slot = "26")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700346D RID: 13421
		// (get) Token: 0x06015DD5 RID: 89557 RVA: 0x0008E758 File Offset: 0x0008C958
		[Token(Token = "0x1700346D")]
		public DateTime gainTime
		{
			[Token(Token = "0x6015DD5")]
			[Address(RVA = "0xE5EBD0", Offset = "0xE5D7D0", VA = "0x180E5EBD0", Slot = "39")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x1700346E RID: 13422
		// (get) Token: 0x06015DD6 RID: 89558 RVA: 0x0008E770 File Offset: 0x0008C970
		[Token(Token = "0x1700346E")]
		public float expPercent
		{
			[Token(Token = "0x6015DD6")]
			[Address(RVA = "0xE5EA90", Offset = "0xE5D690", VA = "0x180E5EA90", Slot = "27")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700346F RID: 13423
		// (get) Token: 0x06015DD7 RID: 89559 RVA: 0x0008E788 File Offset: 0x0008C988
		[Token(Token = "0x1700346F")]
		public ProfessionCategory profession
		{
			[Token(Token = "0x6015DD7")]
			[Address(RVA = "0xE5F510", Offset = "0xE5E110", VA = "0x180E5F510", Slot = "36")]
			get
			{
				return ProfessionCategory.NONE;
			}
		}

		// Token: 0x17003470 RID: 13424
		// (get) Token: 0x06015DD8 RID: 89560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003470")]
		public string subProfessionId
		{
			[Token(Token = "0x6015DD8")]
			[Address(RVA = "0xE5FC30", Offset = "0xE5E830", VA = "0x180E5FC30", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003471 RID: 13425
		// (get) Token: 0x06015DD9 RID: 89561 RVA: 0x0008E7A0 File Offset: 0x0008C9A0
		[Token(Token = "0x17003471")]
		public EvolvePhase evolvePhase
		{
			[Token(Token = "0x6015DD9")]
			[Address(RVA = "0xE5E9F0", Offset = "0xE5D5F0", VA = "0x180E5E9F0", Slot = "37")]
			get
			{
				return EvolvePhase.PHASE_0;
			}
		}

		// Token: 0x17003472 RID: 13426
		// (get) Token: 0x06015DDA RID: 89562 RVA: 0x0008E7B8 File Offset: 0x0008C9B8
		[Token(Token = "0x17003472")]
		public int potentialRank
		{
			[Token(Token = "0x6015DDA")]
			[Address(RVA = "0xE5F470", Offset = "0xE5E070", VA = "0x180E5F470", Slot = "29")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003473 RID: 13427
		// (get) Token: 0x06015DDB RID: 89563 RVA: 0x0008E7D0 File Offset: 0x0008C9D0
		[Token(Token = "0x17003473")]
		public int cost
		{
			[Token(Token = "0x6015DDB")]
			[Address(RVA = "0xE5E250", Offset = "0xE5CE50", VA = "0x180E5E250", Slot = "44")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003474 RID: 13428
		// (get) Token: 0x06015DDC RID: 89564 RVA: 0x0008E7E8 File Offset: 0x0008C9E8
		[Token(Token = "0x17003474")]
		public int maxHp
		{
			[Token(Token = "0x6015DDC")]
			[Address(RVA = "0xE5F0E0", Offset = "0xE5DCE0", VA = "0x180E5F0E0", Slot = "45")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003475 RID: 13429
		// (get) Token: 0x06015DDD RID: 89565 RVA: 0x0008E800 File Offset: 0x0008CA00
		[Token(Token = "0x17003475")]
		public int atk
		{
			[Token(Token = "0x6015DDD")]
			[Address(RVA = "0xE5D960", Offset = "0xE5C560", VA = "0x180E5D960", Slot = "41")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003476 RID: 13430
		// (get) Token: 0x06015DDE RID: 89566 RVA: 0x0008E818 File Offset: 0x0008CA18
		[Token(Token = "0x17003476")]
		public float atkSpeed
		{
			[Token(Token = "0x6015DDE")]
			[Address(RVA = "0xE5D780", Offset = "0xE5C380", VA = "0x180E5D780", Slot = "48")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003477 RID: 13431
		// (get) Token: 0x06015DDF RID: 89567 RVA: 0x0008E830 File Offset: 0x0008CA30
		[Token(Token = "0x17003477")]
		public int def
		{
			[Token(Token = "0x6015DDF")]
			[Address(RVA = "0xE5E4F0", Offset = "0xE5D0F0", VA = "0x180E5E4F0", Slot = "42")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003478 RID: 13432
		// (get) Token: 0x06015DE0 RID: 89568 RVA: 0x0008E848 File Offset: 0x0008CA48
		[Token(Token = "0x17003478")]
		public float magicRes
		{
			[Token(Token = "0x6015DE0")]
			[Address(RVA = "0xE5EE60", Offset = "0xE5DA60", VA = "0x180E5EE60", Slot = "43")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003479 RID: 13433
		// (get) Token: 0x06015DE1 RID: 89569 RVA: 0x0008E860 File Offset: 0x0008CA60
		[Token(Token = "0x17003479")]
		public int favorPoint
		{
			[Token(Token = "0x6015DE1")]
			[Address(RVA = "0xE5EB30", Offset = "0xE5D730", VA = "0x180E5EB30", Slot = "40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700347A RID: 13434
		// (get) Token: 0x06015DE2 RID: 89570 RVA: 0x0008E878 File Offset: 0x0008CA78
		[Token(Token = "0x1700347A")]
		public int respawnTime
		{
			[Token(Token = "0x6015DE2")]
			[Address(RVA = "0xE5F650", Offset = "0xE5E250", VA = "0x180E5F650", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700347B RID: 13435
		// (get) Token: 0x06015DE3 RID: 89571 RVA: 0x0008E890 File Offset: 0x0008CA90
		[Token(Token = "0x1700347B")]
		public int blockCnt
		{
			[Token(Token = "0x6015DE3")]
			[Address(RVA = "0xE5DBB0", Offset = "0xE5C7B0", VA = "0x180E5DBB0", Slot = "46")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700347C RID: 13436
		// (get) Token: 0x06015DE4 RID: 89572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700347C")]
		public AttributesData attrData
		{
			[Token(Token = "0x6015DE4")]
			[Address(RVA = "0xE5DB10", Offset = "0xE5C710", VA = "0x180E5DB10", Slot = "30")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700347D RID: 13437
		// (get) Token: 0x06015DE5 RID: 89573 RVA: 0x0008E8A8 File Offset: 0x0008CAA8
		[Token(Token = "0x1700347D")]
		public CharStarMarkState starMark
		{
			[Token(Token = "0x6015DE5")]
			[Address(RVA = "0xE5FB90", Offset = "0xE5E790", VA = "0x180E5FB90", Slot = "31")]
			get
			{
				return CharStarMarkState.NONE;
			}
		}

		// Token: 0x1700347E RID: 13438
		// (get) Token: 0x06015DE6 RID: 89574 RVA: 0x0008E8C0 File Offset: 0x0008CAC0
		[Token(Token = "0x1700347E")]
		public int sortIndex
		{
			[Token(Token = "0x6015DE6")]
			[Address(RVA = "0xE5FAF0", Offset = "0xE5E6F0", VA = "0x180E5FAF0", Slot = "49")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06015DE7 RID: 89575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015DE7")]
		[Address(RVA = "0xE5D610", Offset = "0xE5C210", VA = "0x180E5D610", Slot = "19")]
		public void SetSkillId(string newSkillId)
		{
		}

		// Token: 0x06015DE8 RID: 89576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015DE8")]
		[Address(RVA = "0xE5D560", Offset = "0xE5C160", VA = "0x180E5D560", Slot = "23")]
		public void SetEquipId(string newEquipId)
		{
		}

		// Token: 0x06015DE9 RID: 89577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015DE9")]
		[Address(RVA = "0xE5D420", Offset = "0xE5C020", VA = "0x180E5D420", Slot = "32")]
		public void SetAttrData(AttributesData newAttrData)
		{
		}

		// Token: 0x06015DEA RID: 89578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015DEA")]
		[Address(RVA = "0xE5D6C0", Offset = "0xE5C2C0", VA = "0x180E5D6C0")]
		protected CommonCharCardViewModel()
		{
		}

		// Token: 0x0401A498 RID: 107672
		[Token(Token = "0x401A498")]
		[FieldOffset(Offset = "0x10")]
		private EnumIntDictionary<CommonCharCardInfoType, ICharacterInfo> m_charInfos;

		// Token: 0x0401A499 RID: 107673
		[Token(Token = "0x401A499")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ClearChar;

		// Token: 0x0401A49A RID: 107674
		[Token(Token = "0x401A49A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x0401A49B RID: 107675
		[Token(Token = "0x401A49B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetCharInfo;

		// Token: 0x0401A49C RID: 107676
		[Token(Token = "0x401A49C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCharInfo;

		// Token: 0x0401A49D RID: 107677
		[Token(Token = "0x401A49D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_charId;

		// Token: 0x0401A49E RID: 107678
		[Token(Token = "0x401A49E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_charInstId;

		// Token: 0x0401A49F RID: 107679
		[Token(Token = "0x401A49F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_tmplId;

		// Token: 0x0401A4A0 RID: 107680
		[Token(Token = "0x401A4A0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_charQuery;

		// Token: 0x0401A4A1 RID: 107681
		[Token(Token = "0x401A4A1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_charVoiceQuery;

		// Token: 0x0401A4A2 RID: 107682
		[Token(Token = "0x401A4A2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_skillId;

		// Token: 0x0401A4A3 RID: 107683
		[Token(Token = "0x401A4A3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_defaultSkillId;

		// Token: 0x0401A4A4 RID: 107684
		[Token(Token = "0x401A4A4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_curSkill;

		// Token: 0x0401A4A5 RID: 107685
		[Token(Token = "0x401A4A5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_mainSkillLvl;

		// Token: 0x0401A4A6 RID: 107686
		[Token(Token = "0x401A4A6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_skillSpecLvl;

		// Token: 0x0401A4A7 RID: 107687
		[Token(Token = "0x401A4A7")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_skillSpecLvl;

		// Token: 0x0401A4A8 RID: 107688
		[Token(Token = "0x401A4A8")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_skills;

		// Token: 0x0401A4A9 RID: 107689
		[Token(Token = "0x401A4A9")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_equipId;

		// Token: 0x0401A4AA RID: 107690
		[Token(Token = "0x401A4AA")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_equipLvl;

		// Token: 0x0401A4AB RID: 107691
		[Token(Token = "0x401A4AB")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_set_equipLvl;

		// Token: 0x0401A4AC RID: 107692
		[Token(Token = "0x401A4AC")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_equips;

		// Token: 0x0401A4AD RID: 107693
		[Token(Token = "0x401A4AD")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_skinStruct;

		// Token: 0x0401A4AE RID: 107694
		[Token(Token = "0x401A4AE")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x0401A4AF RID: 107695
		[Token(Token = "0x401A4AF")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_nickName;

		// Token: 0x0401A4B0 RID: 107696
		[Token(Token = "0x401A4B0")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_rarity;

		// Token: 0x0401A4B1 RID: 107697
		[Token(Token = "0x401A4B1")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_level;

		// Token: 0x0401A4B2 RID: 107698
		[Token(Token = "0x401A4B2")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_maxLevel;

		// Token: 0x0401A4B3 RID: 107699
		[Token(Token = "0x401A4B3")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_gainTime;

		// Token: 0x0401A4B4 RID: 107700
		[Token(Token = "0x401A4B4")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_expPercent;

		// Token: 0x0401A4B5 RID: 107701
		[Token(Token = "0x401A4B5")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_profession;

		// Token: 0x0401A4B6 RID: 107702
		[Token(Token = "0x401A4B6")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_subProfessionId;

		// Token: 0x0401A4B7 RID: 107703
		[Token(Token = "0x401A4B7")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_evolvePhase;

		// Token: 0x0401A4B8 RID: 107704
		[Token(Token = "0x401A4B8")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_potentialRank;

		// Token: 0x0401A4B9 RID: 107705
		[Token(Token = "0x401A4B9")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_cost;

		// Token: 0x0401A4BA RID: 107706
		[Token(Token = "0x401A4BA")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_maxHp;

		// Token: 0x0401A4BB RID: 107707
		[Token(Token = "0x401A4BB")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_get_atk;

		// Token: 0x0401A4BC RID: 107708
		[Token(Token = "0x401A4BC")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_get_atkSpeed;

		// Token: 0x0401A4BD RID: 107709
		[Token(Token = "0x401A4BD")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_get_def;

		// Token: 0x0401A4BE RID: 107710
		[Token(Token = "0x401A4BE")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_get_magicRes;

		// Token: 0x0401A4BF RID: 107711
		[Token(Token = "0x401A4BF")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_get_favorPoint;

		// Token: 0x0401A4C0 RID: 107712
		[Token(Token = "0x401A4C0")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_get_respawnTime;

		// Token: 0x0401A4C1 RID: 107713
		[Token(Token = "0x401A4C1")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_get_blockCnt;

		// Token: 0x0401A4C2 RID: 107714
		[Token(Token = "0x401A4C2")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_get_attrData;

		// Token: 0x0401A4C3 RID: 107715
		[Token(Token = "0x401A4C3")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_get_starMark;

		// Token: 0x0401A4C4 RID: 107716
		[Token(Token = "0x401A4C4")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_get_sortIndex;

		// Token: 0x0401A4C5 RID: 107717
		[Token(Token = "0x401A4C5")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_SetSkillId;

		// Token: 0x0401A4C6 RID: 107718
		[Token(Token = "0x401A4C6")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_SetEquipId;

		// Token: 0x0401A4C7 RID: 107719
		[Token(Token = "0x401A4C7")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_SetAttrData;

		// Token: 0x0401A4C8 RID: 107720
		[Token(Token = "0x401A4C8")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
