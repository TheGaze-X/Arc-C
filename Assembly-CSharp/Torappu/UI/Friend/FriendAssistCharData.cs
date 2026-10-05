using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D71 RID: 19825
	[Token(Token = "0x2004D71")]
	public class FriendAssistCharData
	{
		// Token: 0x17004595 RID: 17813
		// (get) Token: 0x0601DAD1 RID: 121553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004595")]
		public List<FriendAssistCharData.CharEquipInfo> charEquipInfos
		{
			[Token(Token = "0x601DAD1")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004596 RID: 17814
		// (get) Token: 0x0601DAD2 RID: 121554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004596")]
		public CharacterCardViewModel charCard
		{
			[Token(Token = "0x601DAD2")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004597 RID: 17815
		// (get) Token: 0x0601DAD3 RID: 121555 RVA: 0x000AC380 File Offset: 0x000AA580
		[Token(Token = "0x17004597")]
		public int skillIndex
		{
			[Token(Token = "0x601DAD3")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004598 RID: 17816
		// (get) Token: 0x0601DAD4 RID: 121556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004598")]
		public string equipId
		{
			[Token(Token = "0x601DAD4")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004599 RID: 17817
		// (get) Token: 0x0601DAD5 RID: 121557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004599")]
		public PlayerCharSkill[] charSkills
		{
			[Token(Token = "0x601DAD5")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700459A RID: 17818
		// (get) Token: 0x0601DAD6 RID: 121558 RVA: 0x000AC398 File Offset: 0x000AA598
		[Token(Token = "0x1700459A")]
		public int mainSkillLvl
		{
			[Token(Token = "0x601DAD6")]
			[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700459B RID: 17819
		// (get) Token: 0x0601DAD7 RID: 121559 RVA: 0x000AC3B0 File Offset: 0x000AA5B0
		[Token(Token = "0x1700459B")]
		public bool isAllSpecMax
		{
			[Token(Token = "0x601DAD7")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601DAD8 RID: 121560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAD8")]
		[Address(RVA = "0x173B820", Offset = "0x173A420", VA = "0x18173B820")]
		public void LoadData(CharacterCardViewModel characterCard, int skillIndex, string equipId)
		{
		}

		// Token: 0x0601DAD9 RID: 121561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAD9")]
		[Address(RVA = "0xB14320", Offset = "0xB12F20", VA = "0x180B14320")]
		public FriendAssistCharData()
		{
		}

		// Token: 0x04027346 RID: 160582
		[Token(Token = "0x4027346")]
		[FieldOffset(Offset = "0x10")]
		private CharacterCardViewModel m_charCard;

		// Token: 0x04027347 RID: 160583
		[Token(Token = "0x4027347")]
		[FieldOffset(Offset = "0x18")]
		private List<FriendAssistCharData.CharEquipInfo> m_charEquipInfos;

		// Token: 0x04027348 RID: 160584
		[Token(Token = "0x4027348")]
		[FieldOffset(Offset = "0x20")]
		private PlayerCharSkill[] m_charSkills;

		// Token: 0x04027349 RID: 160585
		[Token(Token = "0x4027349")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isAllSpecMax;

		// Token: 0x0402734A RID: 160586
		[Token(Token = "0x402734A")]
		[FieldOffset(Offset = "0x2C")]
		private int m_mainSkillLvl;

		// Token: 0x0402734B RID: 160587
		[Token(Token = "0x402734B")]
		[FieldOffset(Offset = "0x30")]
		private int m_skillIndex;

		// Token: 0x0402734C RID: 160588
		[Token(Token = "0x402734C")]
		[FieldOffset(Offset = "0x38")]
		private string m_equipId;

		// Token: 0x02004D72 RID: 19826
		[Token(Token = "0x2004D72")]
		public class CharEquipInfo : IComparable<FriendAssistCharData.CharEquipInfo>
		{
			// Token: 0x0601DADA RID: 121562 RVA: 0x000AC3C8 File Offset: 0x000AA5C8
			[Token(Token = "0x601DADA")]
			[Address(RVA = "0x173B1B0", Offset = "0x1739DB0", VA = "0x18173B1B0", Slot = "4")]
			public int CompareTo(FriendAssistCharData.CharEquipInfo other)
			{
				return 0;
			}

			// Token: 0x0601DADB RID: 121563 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DADB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CharEquipInfo()
			{
			}

			// Token: 0x0402734D RID: 160589
			[Token(Token = "0x402734D")]
			[FieldOffset(Offset = "0x10")]
			public string equipId;

			// Token: 0x0402734E RID: 160590
			[Token(Token = "0x402734E")]
			[FieldOffset(Offset = "0x18")]
			public bool locked;

			// Token: 0x0402734F RID: 160591
			[Token(Token = "0x402734F")]
			[FieldOffset(Offset = "0x1C")]
			public int level;

			// Token: 0x04027350 RID: 160592
			[Token(Token = "0x4027350")]
			[FieldOffset(Offset = "0x20")]
			public int sortOrder;
		}
	}
}
