using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D82 RID: 23938
	[Token(Token = "0x2005D82")]
	public class ClimbTowerSquadMultiEditCharModel
	{
		// Token: 0x170051DA RID: 20954
		// (get) Token: 0x06022B1D RID: 142109 RVA: 0x000BE788 File Offset: 0x000BC988
		[Token(Token = "0x170051DA")]
		public int cardId
		{
			[Token(Token = "0x6022B1D")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170051DB RID: 20955
		// (get) Token: 0x06022B1E RID: 142110 RVA: 0x000BE7A0 File Offset: 0x000BC9A0
		[Token(Token = "0x170051DB")]
		public TowerCurrent.TowerCardType cardType
		{
			[Token(Token = "0x6022B1E")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			get
			{
				return TowerCurrent.TowerCardType.CHAR;
			}
		}

		// Token: 0x170051DC RID: 20956
		// (get) Token: 0x06022B1F RID: 142111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170051DC")]
		public Sprite charMarkSprite
		{
			[Token(Token = "0x6022B1F")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x170051DD RID: 20957
		// (get) Token: 0x06022B20 RID: 142112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170051DD")]
		public string charId
		{
			[Token(Token = "0x6022B20")]
			[Address(RVA = "0x1D3D5D0", Offset = "0x1D3C1D0", VA = "0x181D3D5D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170051DE RID: 20958
		// (get) Token: 0x06022B21 RID: 142113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170051DE")]
		public CharacterCardViewModel cardModel
		{
			[Token(Token = "0x6022B21")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170051DF RID: 20959
		// (get) Token: 0x06022B22 RID: 142114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170051DF")]
		public string curSkillId
		{
			[Token(Token = "0x6022B22")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170051E0 RID: 20960
		// (get) Token: 0x06022B23 RID: 142115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170051E0")]
		public string curEquipId
		{
			[Token(Token = "0x6022B23")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x170051E1 RID: 20961
		// (get) Token: 0x06022B24 RID: 142116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170051E1")]
		public List<SkillItemViewModel> skillList
		{
			[Token(Token = "0x6022B24")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170051E2 RID: 20962
		// (get) Token: 0x06022B25 RID: 142117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170051E2")]
		public List<ClimbTowerEquipItemModel> equipList
		{
			[Token(Token = "0x6022B25")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x170051E3 RID: 20963
		// (get) Token: 0x06022B26 RID: 142118 RVA: 0x000BE7B8 File Offset: 0x000BC9B8
		[Token(Token = "0x170051E3")]
		public bool isEquipCntOverLimit
		{
			[Token(Token = "0x6022B26")]
			[Address(RVA = "0x16647A0", Offset = "0x16633A0", VA = "0x1816647A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170051E4 RID: 20964
		// (get) Token: 0x06022B27 RID: 142119 RVA: 0x000BE7D0 File Offset: 0x000BC9D0
		[Token(Token = "0x170051E4")]
		public bool isEquipScrollNeedPresetPosition
		{
			[Token(Token = "0x6022B27")]
			[Address(RVA = "0x1D3D5F0", Offset = "0x1D3C1F0", VA = "0x181D3D5F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06022B28 RID: 142120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B28")]
		[Address(RVA = "0x1D3C760", Offset = "0x1D3B360", VA = "0x181D3C760")]
		public void LoadData(UIPage page, TowerCurrent.GameCard gameCard, ClimbTowerCharEditCacheModel editModel)
		{
		}

		// Token: 0x06022B29 RID: 142121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B29")]
		[Address(RVA = "0x1D3CC50", Offset = "0x1D3B850", VA = "0x181D3CC50")]
		private void _LoadCharMarkSprite(UIPage page)
		{
		}

		// Token: 0x06022B2A RID: 142122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B2A")]
		[Address(RVA = "0x1D3CDB0", Offset = "0x1D3B9B0", VA = "0x181D3CDB0")]
		private void _LoadEquipList()
		{
		}

		// Token: 0x06022B2B RID: 142123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B2B")]
		[Address(RVA = "0x1D3D1C0", Offset = "0x1D3BDC0", VA = "0x181D3D1C0")]
		private void _LoadSkillList()
		{
		}

		// Token: 0x06022B2C RID: 142124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022B2C")]
		[Address(RVA = "0x1D3CAD0", Offset = "0x1D3B6D0", VA = "0x181D3CAD0")]
		private PlayerCharSkill _GetPlayerSkillData(PlayerCharSkill[] playerSkills, string skillId)
		{
			return null;
		}

		// Token: 0x06022B2D RID: 142125 RVA: 0x000BE7E8 File Offset: 0x000BC9E8
		[Token(Token = "0x6022B2D")]
		[Address(RVA = "0x1D3CB90", Offset = "0x1D3B790", VA = "0x181D3CB90")]
		private int _GetSelectEquipPosition()
		{
			return 0;
		}

		// Token: 0x06022B2E RID: 142126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B2E")]
		[Address(RVA = "0x1D3CA80", Offset = "0x1D3B680", VA = "0x181D3CA80")]
		public void UpdateSelectSkill(string skillId)
		{
		}

		// Token: 0x06022B2F RID: 142127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B2F")]
		[Address(RVA = "0x1D3CA30", Offset = "0x1D3B630", VA = "0x181D3CA30")]
		public void UpdateSelectEquip(string equipId)
		{
		}

		// Token: 0x06022B30 RID: 142128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B30")]
		[Address(RVA = "0x1D3D500", Offset = "0x1D3C100", VA = "0x181D3D500")]
		public ClimbTowerSquadMultiEditCharModel()
		{
		}

		// Token: 0x0402FB25 RID: 195365
		[Token(Token = "0x402FB25")]
		private const int EQUIP_MIN_SHOW_CNT = 3;

		// Token: 0x0402FB26 RID: 195366
		[Token(Token = "0x402FB26")]
		private const int SELECT_EQUIP_POSITION_NO_NEED_PRESET_POSITION = 0;

		// Token: 0x0402FB27 RID: 195367
		[Token(Token = "0x402FB27")]
		[FieldOffset(Offset = "0x10")]
		private int m_cardId;

		// Token: 0x0402FB28 RID: 195368
		[Token(Token = "0x402FB28")]
		[FieldOffset(Offset = "0x14")]
		private TowerCurrent.TowerCardType m_cardType;

		// Token: 0x0402FB29 RID: 195369
		[Token(Token = "0x402FB29")]
		[FieldOffset(Offset = "0x18")]
		private CharacterCardViewModel m_cardModel;

		// Token: 0x0402FB2A RID: 195370
		[Token(Token = "0x402FB2A")]
		[FieldOffset(Offset = "0x20")]
		private string m_selectSkillId;

		// Token: 0x0402FB2B RID: 195371
		[Token(Token = "0x402FB2B")]
		[FieldOffset(Offset = "0x28")]
		private string m_selectEquipId;

		// Token: 0x0402FB2C RID: 195372
		[Token(Token = "0x402FB2C")]
		[FieldOffset(Offset = "0x30")]
		private List<SkillItemViewModel> m_skills;

		// Token: 0x0402FB2D RID: 195373
		[Token(Token = "0x402FB2D")]
		[FieldOffset(Offset = "0x38")]
		private List<ClimbTowerEquipItemModel> m_equips;

		// Token: 0x0402FB2E RID: 195374
		[Token(Token = "0x402FB2E")]
		[FieldOffset(Offset = "0x40")]
		private Sprite m_charMarkSprite;

		// Token: 0x0402FB2F RID: 195375
		[Token(Token = "0x402FB2F")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isEquipCntOverLimit;

		// Token: 0x0402FB30 RID: 195376
		[Token(Token = "0x402FB30")]
		[FieldOffset(Offset = "0x49")]
		private bool m_isEquipScrollPositionNeedAnchor;
	}
}
