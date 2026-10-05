using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200443E RID: 17470
	[Token(Token = "0x200443E")]
	public class SandboxV2SquadCharModel : ISquadMemberCompInfo, IHotfixable
	{
		// Token: 0x0601AB19 RID: 109337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB19")]
		[Address(RVA = "0x13C5DB0", Offset = "0x13C49B0", VA = "0x1813C5DB0")]
		private SandboxV2SquadCharModel()
		{
		}

		// Token: 0x17003F56 RID: 16214
		// (get) Token: 0x0601AB1A RID: 109338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003F56")]
		public SandboxV2CharInfoHolder infoHolder
		{
			[Token(Token = "0x601AB1A")]
			[Address(RVA = "0x13C5FA0", Offset = "0x13C4BA0", VA = "0x1813C5FA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003F57 RID: 16215
		// (get) Token: 0x0601AB1B RID: 109339 RVA: 0x000A2F48 File Offset: 0x000A1148
		[Token(Token = "0x17003F57")]
		public int instId
		{
			[Token(Token = "0x601AB1B")]
			[Address(RVA = "0x13C6000", Offset = "0x13C4C00", VA = "0x1813C6000")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003F58 RID: 16216
		// (get) Token: 0x0601AB1C RID: 109340 RVA: 0x000A2F60 File Offset: 0x000A1160
		[Token(Token = "0x17003F58")]
		public SandboxV2CharStatus charStatus
		{
			[Token(Token = "0x601AB1C")]
			[Address(RVA = "0x13C5F40", Offset = "0x13C4B40", VA = "0x1813C5F40")]
			get
			{
				return SandboxV2CharStatus.NONE;
			}
		}

		// Token: 0x17003F59 RID: 16217
		// (get) Token: 0x0601AB1D RID: 109341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003F59")]
		public List<SandboxV2CharSkillModel> skillList
		{
			[Token(Token = "0x601AB1D")]
			[Address(RVA = "0x13C6290", Offset = "0x13C4E90", VA = "0x1813C6290")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003F5A RID: 16218
		// (get) Token: 0x0601AB1E RID: 109342 RVA: 0x000A2F78 File Offset: 0x000A1178
		[Token(Token = "0x17003F5A")]
		public CharQuery charQuery
		{
			[Token(Token = "0x601AB1E")]
			[Address(RVA = "0x13C5E10", Offset = "0x13C4A10", VA = "0x1813C5E10")]
			get
			{
				return default(CharQuery);
			}
		}

		// Token: 0x17003F5B RID: 16219
		// (get) Token: 0x0601AB1F RID: 109343 RVA: 0x000A2F90 File Offset: 0x000A1190
		[Token(Token = "0x17003F5B")]
		public int selectSkillIdx
		{
			[Token(Token = "0x601AB1F")]
			[Address(RVA = "0x13C6230", Offset = "0x13C4E30", VA = "0x1813C6230")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003F5C RID: 16220
		// (get) Token: 0x0601AB20 RID: 109344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003F5C")]
		public string selectEquipId
		{
			[Token(Token = "0x601AB20")]
			[Address(RVA = "0x13C60E0", Offset = "0x13C4CE0", VA = "0x1813C60E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003F5D RID: 16221
		// (get) Token: 0x0601AB21 RID: 109345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003F5D")]
		public string selectSkillId
		{
			[Token(Token = "0x601AB21")]
			[Address(RVA = "0x13C6140", Offset = "0x13C4D40", VA = "0x1813C6140")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003F5E RID: 16222
		// (get) Token: 0x0601AB22 RID: 109346 RVA: 0x000A2FA8 File Offset: 0x000A11A8
		[Token(Token = "0x17003F5E")]
		public Color rarityColor
		{
			[Token(Token = "0x601AB22")]
			[Address(RVA = "0x13C6060", Offset = "0x13C4C60", VA = "0x1813C6060")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x0601AB23 RID: 109347 RVA: 0x000A2FC0 File Offset: 0x000A11C0
		[Token(Token = "0x601AB23")]
		[Address(RVA = "0x13C45F0", Offset = "0x13C31F0", VA = "0x1813C45F0")]
		public CharUISkinStruct CreateCharSkinStruct()
		{
			return default(CharUISkinStruct);
		}

		// Token: 0x0601AB24 RID: 109348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AB24")]
		[Address(RVA = "0x13C53A0", Offset = "0x13C3FA0", VA = "0x1813C53A0")]
		public SandboxV2CharEquipModel GetSelectEquipModel()
		{
			return null;
		}

		// Token: 0x0601AB25 RID: 109349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AB25")]
		[Address(RVA = "0x13C4C20", Offset = "0x13C3820", VA = "0x1813C4C20", Slot = "4")]
		public IEnumerator<KeyValuePair<string, PlayerSquadTmpl>> ExtraTmplInfo()
		{
			return null;
		}

		// Token: 0x0601AB26 RID: 109350 RVA: 0x000A2FD8 File Offset: 0x000A11D8
		[Token(Token = "0x601AB26")]
		[Address(RVA = "0x13C4BB0", Offset = "0x13C37B0", VA = "0x1813C4BB0", Slot = "5")]
		public int ExtraTmplCount()
		{
			return 0;
		}

		// Token: 0x0601AB27 RID: 109351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AB27")]
		[Address(RVA = "0x13C52E0", Offset = "0x13C3EE0", VA = "0x1813C52E0", Slot = "6")]
		public string GetDefaultEquipId()
		{
			return null;
		}

		// Token: 0x0601AB28 RID: 109352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AB28")]
		[Address(RVA = "0x13C5340", Offset = "0x13C3F40", VA = "0x1813C5340")]
		public string GetSelectEquipId()
		{
			return null;
		}

		// Token: 0x0601AB29 RID: 109353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AB29")]
		[Address(RVA = "0x13C4A20", Offset = "0x13C3620", VA = "0x1813C4A20")]
		public static SandboxV2SquadCharModel Create(string topicId, PlayerSquadItem playerSquadItem, bool isTutorial)
		{
			return null;
		}

		// Token: 0x0601AB2A RID: 109354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AB2A")]
		[Address(RVA = "0x13C47F0", Offset = "0x13C33F0", VA = "0x1813C47F0")]
		public static SandboxV2SquadCharModel CreateFromInstId(string topicId, SandboxV2CharSquad charConfig, bool isTutorial)
		{
			return null;
		}

		// Token: 0x0601AB2B RID: 109355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB2B")]
		[Address(RVA = "0x13C5B10", Offset = "0x13C4710", VA = "0x1813C5B10")]
		private void _LoadData(string topicId, int charInstId, SandboxV2CharInfoHolder charInfoHolder, int skillIndex, string equipId, bool isTutorial)
		{
		}

		// Token: 0x0601AB2C RID: 109356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB2C")]
		[Address(RVA = "0x13C5720", Offset = "0x13C4320", VA = "0x1813C5720")]
		public void UpdatePlayerData()
		{
		}

		// Token: 0x0601AB2D RID: 109357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB2D")]
		[Address(RVA = "0x13C5D00", Offset = "0x13C4900", VA = "0x1813C5D00")]
		private void _UpdateCharStatus()
		{
		}

		// Token: 0x0601AB2E RID: 109358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB2E")]
		[Address(RVA = "0x13C5A00", Offset = "0x13C4600", VA = "0x1813C5A00")]
		private void _LoadAdditionData()
		{
		}

		// Token: 0x0601AB2F RID: 109359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB2F")]
		[Address(RVA = "0x13C5560", Offset = "0x13C4160", VA = "0x1813C5560")]
		public void SelectSkill(string skillId)
		{
		}

		// Token: 0x0601AB30 RID: 109360 RVA: 0x000A2FF0 File Offset: 0x000A11F0
		[Token(Token = "0x601AB30")]
		[Address(RVA = "0x13C44D0", Offset = "0x13C30D0", VA = "0x1813C44D0")]
		public bool CheckIfMemberChanged(PlayerSquadItem playerItem)
		{
			return default(bool);
		}

		// Token: 0x0601AB31 RID: 109361 RVA: 0x000A3008 File Offset: 0x000A1208
		[Token(Token = "0x601AB31")]
		[Address(RVA = "0x13C4470", Offset = "0x13C3070", VA = "0x1813C4470")]
		public bool CanBattle()
		{
			return default(bool);
		}

		// Token: 0x0601AB32 RID: 109362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AB32")]
		[Address(RVA = "0x13C4CD0", Offset = "0x13C38D0", VA = "0x1813C4CD0")]
		public AdvancedCharacterInst GenAdvancedCharInst()
		{
			return null;
		}

		// Token: 0x04022138 RID: 139576
		[Token(Token = "0x4022138")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isTutorial;

		// Token: 0x04022139 RID: 139577
		[Token(Token = "0x4022139")]
		[FieldOffset(Offset = "0x14")]
		private int m_instId;

		// Token: 0x0402213A RID: 139578
		[Token(Token = "0x402213A")]
		[FieldOffset(Offset = "0x18")]
		private string m_topicId;

		// Token: 0x0402213B RID: 139579
		[Token(Token = "0x402213B")]
		[FieldOffset(Offset = "0x20")]
		private SandboxV2CharInfoHolder m_charInfoHolder;

		// Token: 0x0402213C RID: 139580
		[Token(Token = "0x402213C")]
		[FieldOffset(Offset = "0x28")]
		private string m_currentTmpl;

		// Token: 0x0402213D RID: 139581
		[Token(Token = "0x402213D")]
		[FieldOffset(Offset = "0x30")]
		private int m_selectSkillIndex;

		// Token: 0x0402213E RID: 139582
		[Token(Token = "0x402213E")]
		[FieldOffset(Offset = "0x38")]
		private string m_selectEquipId;

		// Token: 0x0402213F RID: 139583
		[Token(Token = "0x402213F")]
		[FieldOffset(Offset = "0x40")]
		private string m_defaultEquipId;

		// Token: 0x04022140 RID: 139584
		[Token(Token = "0x4022140")]
		[FieldOffset(Offset = "0x48")]
		private Color m_rarityColor;

		// Token: 0x04022141 RID: 139585
		[Token(Token = "0x4022141")]
		[FieldOffset(Offset = "0x58")]
		private SandboxV2CharStatus m_charStatus;

		// Token: 0x04022142 RID: 139586
		[Token(Token = "0x4022142")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04022143 RID: 139587
		[Token(Token = "0x4022143")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_infoHolder;

		// Token: 0x04022144 RID: 139588
		[Token(Token = "0x4022144")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_instId;

		// Token: 0x04022145 RID: 139589
		[Token(Token = "0x4022145")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_charStatus;

		// Token: 0x04022146 RID: 139590
		[Token(Token = "0x4022146")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_skillList;

		// Token: 0x04022147 RID: 139591
		[Token(Token = "0x4022147")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_charQuery;

		// Token: 0x04022148 RID: 139592
		[Token(Token = "0x4022148")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_selectSkillIdx;

		// Token: 0x04022149 RID: 139593
		[Token(Token = "0x4022149")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_selectEquipId;

		// Token: 0x0402214A RID: 139594
		[Token(Token = "0x402214A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_selectSkillId;

		// Token: 0x0402214B RID: 139595
		[Token(Token = "0x402214B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_rarityColor;

		// Token: 0x0402214C RID: 139596
		[Token(Token = "0x402214C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CreateCharSkinStruct;

		// Token: 0x0402214D RID: 139597
		[Token(Token = "0x402214D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetSelectEquipModel;

		// Token: 0x0402214E RID: 139598
		[Token(Token = "0x402214E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ExtraTmplInfo;

		// Token: 0x0402214F RID: 139599
		[Token(Token = "0x402214F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ExtraTmplCount;

		// Token: 0x04022150 RID: 139600
		[Token(Token = "0x4022150")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetDefaultEquipId;

		// Token: 0x04022151 RID: 139601
		[Token(Token = "0x4022151")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetSelectEquipId;

		// Token: 0x04022152 RID: 139602
		[Token(Token = "0x4022152")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x04022153 RID: 139603
		[Token(Token = "0x4022153")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_CreateFromInstId;

		// Token: 0x04022154 RID: 139604
		[Token(Token = "0x4022154")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x04022155 RID: 139605
		[Token(Token = "0x4022155")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_UpdatePlayerData;

		// Token: 0x04022156 RID: 139606
		[Token(Token = "0x4022156")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__UpdateCharStatus;

		// Token: 0x04022157 RID: 139607
		[Token(Token = "0x4022157")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__LoadAdditionData;

		// Token: 0x04022158 RID: 139608
		[Token(Token = "0x4022158")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_SelectSkill;

		// Token: 0x04022159 RID: 139609
		[Token(Token = "0x4022159")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_CheckIfMemberChanged;

		// Token: 0x0402215A RID: 139610
		[Token(Token = "0x402215A")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_CanBattle;

		// Token: 0x0402215B RID: 139611
		[Token(Token = "0x402215B")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GenAdvancedCharInst;
	}
}
