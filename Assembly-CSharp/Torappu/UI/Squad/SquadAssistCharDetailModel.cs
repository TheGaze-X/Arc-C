using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003DF1 RID: 15857
	[Token(Token = "0x2003DF1")]
	public class SquadAssistCharDetailModel : IHotfixable
	{
		// Token: 0x06018AA9 RID: 101033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018AA9")]
		[Address(RVA = "0x1121210", Offset = "0x111FE10", VA = "0x181121210")]
		public void LoadData(SquadAssistCharDetailModel.Input input)
		{
		}

		// Token: 0x06018AAA RID: 101034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018AAA")]
		[Address(RVA = "0x1121CC0", Offset = "0x11208C0", VA = "0x181121CC0")]
		private void _LoadSkill(ref ModifiedSharedCharData modifiedData)
		{
		}

		// Token: 0x06018AAB RID: 101035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018AAB")]
		[Address(RVA = "0x1121A10", Offset = "0x1120610", VA = "0x181121A10")]
		private void _LoadEquip(ListDict<string, SharedCharData.CharEquipInfo> equips)
		{
		}

		// Token: 0x06018AAC RID: 101036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018AAC")]
		[Address(RVA = "0x11218F0", Offset = "0x11204F0", VA = "0x1811218F0")]
		public void SelectSkill(int index)
		{
		}

		// Token: 0x06018AAD RID: 101037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018AAD")]
		[Address(RVA = "0x1121860", Offset = "0x1120460", VA = "0x181121860")]
		public void SelectEquip(string equipId)
		{
		}

		// Token: 0x06018AAE RID: 101038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018AAE")]
		[Address(RVA = "0x11219A0", Offset = "0x11205A0", VA = "0x1811219A0")]
		public void SetDetailViewShow(bool show)
		{
		}

		// Token: 0x06018AAF RID: 101039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018AAF")]
		[Address(RVA = "0x1120FC0", Offset = "0x111FBC0", VA = "0x181120FC0")]
		public SquadFriendData ConvertToSquadFriendData()
		{
			return null;
		}

		// Token: 0x06018AB0 RID: 101040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018AB0")]
		[Address(RVA = "0x1121160", Offset = "0x111FD60", VA = "0x181121160")]
		public CharacterShowViewModel GetCharShowViewModel()
		{
			return null;
		}

		// Token: 0x06018AB1 RID: 101041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018AB1")]
		[Address(RVA = "0x1121F90", Offset = "0x1120B90", VA = "0x181121F90")]
		public SquadAssistCharDetailModel()
		{
		}

		// Token: 0x0401E3AB RID: 123819
		[Token(Token = "0x401E3AB")]
		private const int SKILL_SLOT_MIN = 3;

		// Token: 0x0401E3AC RID: 123820
		[Token(Token = "0x401E3AC")]
		private const int EQUIP_SLOT_MIN = 3;

		// Token: 0x0401E3AD RID: 123821
		[Token(Token = "0x401E3AD")]
		[FieldOffset(Offset = "0x10")]
		public int friendLevel;

		// Token: 0x0401E3AE RID: 123822
		[Token(Token = "0x401E3AE")]
		[FieldOffset(Offset = "0x18")]
		public AvatarInfo avatar;

		// Token: 0x0401E3AF RID: 123823
		[Token(Token = "0x401E3AF")]
		[FieldOffset(Offset = "0x20")]
		public PlayerAvatarQuery avatarQuery;

		// Token: 0x0401E3B0 RID: 123824
		[Token(Token = "0x401E3B0")]
		[FieldOffset(Offset = "0x38")]
		public string friendName;

		// Token: 0x0401E3B1 RID: 123825
		[Token(Token = "0x401E3B1")]
		[FieldOffset(Offset = "0x40")]
		public string friendNumber;

		// Token: 0x0401E3B2 RID: 123826
		[Token(Token = "0x401E3B2")]
		[FieldOffset(Offset = "0x48")]
		public string friendAliasName;

		// Token: 0x0401E3B3 RID: 123827
		[Token(Token = "0x401E3B3")]
		[FieldOffset(Offset = "0x50")]
		public bool isFriendOnline;

		// Token: 0x0401E3B4 RID: 123828
		[Token(Token = "0x401E3B4")]
		[FieldOffset(Offset = "0x58")]
		public string friendLastOnlineTimeStr;

		// Token: 0x0401E3B5 RID: 123829
		[Token(Token = "0x401E3B5")]
		[FieldOffset(Offset = "0x60")]
		public List<SharedCharData> friendAssistChars;

		// Token: 0x0401E3B6 RID: 123830
		[Token(Token = "0x401E3B6")]
		[FieldOffset(Offset = "0x68")]
		public bool canAddFriend;

		// Token: 0x0401E3B7 RID: 123831
		[Token(Token = "0x401E3B7")]
		[FieldOffset(Offset = "0x69")]
		public bool isFriend;

		// Token: 0x0401E3B8 RID: 123832
		[Token(Token = "0x401E3B8")]
		[FieldOffset(Offset = "0x70")]
		public string nameCardSkinId;

		// Token: 0x0401E3B9 RID: 123833
		[Token(Token = "0x401E3B9")]
		[FieldOffset(Offset = "0x78")]
		public int nameCardSkinTmpl;

		// Token: 0x0401E3BA RID: 123834
		[Token(Token = "0x401E3BA")]
		[FieldOffset(Offset = "0x7C")]
		public bool isStarFriend;

		// Token: 0x0401E3BB RID: 123835
		[Token(Token = "0x401E3BB")]
		[FieldOffset(Offset = "0x80")]
		public CharUISkinStruct charIllust;

		// Token: 0x0401E3BC RID: 123836
		[Token(Token = "0x401E3BC")]
		[FieldOffset(Offset = "0x98")]
		public EvolvePhase charEvolvePhase;

		// Token: 0x0401E3BD RID: 123837
		[Token(Token = "0x401E3BD")]
		[FieldOffset(Offset = "0x9C")]
		public int charLevel;

		// Token: 0x0401E3BE RID: 123838
		[Token(Token = "0x401E3BE")]
		[FieldOffset(Offset = "0xA0")]
		public int charPotential;

		// Token: 0x0401E3BF RID: 123839
		[Token(Token = "0x401E3BF")]
		[FieldOffset(Offset = "0xA4")]
		public RarityRank charRarity;

		// Token: 0x0401E3C0 RID: 123840
		[Token(Token = "0x401E3C0")]
		[FieldOffset(Offset = "0xA8")]
		public ProfessionCategory charProfession;

		// Token: 0x0401E3C1 RID: 123841
		[Token(Token = "0x401E3C1")]
		[FieldOffset(Offset = "0xB0")]
		public string charName;

		// Token: 0x0401E3C2 RID: 123842
		[Token(Token = "0x401E3C2")]
		[FieldOffset(Offset = "0xB8")]
		public bool isSkillLimited;

		// Token: 0x0401E3C3 RID: 123843
		[Token(Token = "0x401E3C3")]
		[FieldOffset(Offset = "0xC0")]
		public List<bool> singleSkillLimitList;

		// Token: 0x0401E3C4 RID: 123844
		[Token(Token = "0x401E3C4")]
		[FieldOffset(Offset = "0xC8")]
		public List<SkillItemViewModel> charSkills;

		// Token: 0x0401E3C5 RID: 123845
		[Token(Token = "0x401E3C5")]
		[FieldOffset(Offset = "0xD0")]
		public ListDict<string, UIClickableEquipItemModel> charEquips;

		// Token: 0x0401E3C6 RID: 123846
		[Token(Token = "0x401E3C6")]
		[FieldOffset(Offset = "0xD8")]
		public int selectedSkillIndex;

		// Token: 0x0401E3C7 RID: 123847
		[Token(Token = "0x401E3C7")]
		[FieldOffset(Offset = "0xE0")]
		public string selectedEquipId;

		// Token: 0x0401E3C8 RID: 123848
		[Token(Token = "0x401E3C8")]
		[FieldOffset(Offset = "0xE8")]
		public string friendUid;

		// Token: 0x0401E3C9 RID: 123849
		[Token(Token = "0x401E3C9")]
		[FieldOffset(Offset = "0xF0")]
		public bool detailViewShow;

		// Token: 0x0401E3CA RID: 123850
		[Token(Token = "0x401E3CA")]
		[FieldOffset(Offset = "0xF4")]
		public int enterSeqNum;

		// Token: 0x0401E3CB RID: 123851
		[Token(Token = "0x401E3CB")]
		[FieldOffset(Offset = "0xF8")]
		public float equipScrollNormalizedPos;

		// Token: 0x0401E3CC RID: 123852
		[Token(Token = "0x401E3CC")]
		[FieldOffset(Offset = "0xFC")]
		private bool m_usePlayerSelection;

		// Token: 0x0401E3CD RID: 123853
		[Token(Token = "0x401E3CD")]
		[FieldOffset(Offset = "0x100")]
		private SharedCharData m_cachedSelectChar;

		// Token: 0x0401E3CE RID: 123854
		[Token(Token = "0x401E3CE")]
		[FieldOffset(Offset = "0x108")]
		private SharedCharData m_cachedOriginChar;

		// Token: 0x0401E3CF RID: 123855
		[Token(Token = "0x401E3CF")]
		[FieldOffset(Offset = "0x110")]
		private string m_friendServerName;

		// Token: 0x0401E3D0 RID: 123856
		[Token(Token = "0x401E3D0")]
		[FieldOffset(Offset = "0x118")]
		private DateTime m_lastOnlineTime;

		// Token: 0x0401E3D1 RID: 123857
		[Token(Token = "0x401E3D1")]
		[FieldOffset(Offset = "0x120")]
		private ModifiedSharedCharData m_cachedModifiedSharedCharData;

		// Token: 0x0401E3D2 RID: 123858
		[Token(Token = "0x401E3D2")]
		[FieldOffset(Offset = "0x140")]
		private bool m_isCharShowMultiSlot;

		// Token: 0x0401E3D3 RID: 123859
		[Token(Token = "0x401E3D3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401E3D4 RID: 123860
		[Token(Token = "0x401E3D4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadSkill;

		// Token: 0x0401E3D5 RID: 123861
		[Token(Token = "0x401E3D5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadEquip;

		// Token: 0x0401E3D6 RID: 123862
		[Token(Token = "0x401E3D6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SelectSkill;

		// Token: 0x0401E3D7 RID: 123863
		[Token(Token = "0x401E3D7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SelectEquip;

		// Token: 0x0401E3D8 RID: 123864
		[Token(Token = "0x401E3D8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetDetailViewShow;

		// Token: 0x0401E3D9 RID: 123865
		[Token(Token = "0x401E3D9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ConvertToSquadFriendData;

		// Token: 0x0401E3DA RID: 123866
		[Token(Token = "0x401E3DA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetCharShowViewModel;

		// Token: 0x0401E3DB RID: 123867
		[Token(Token = "0x401E3DB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003DF2 RID: 15858
		[Token(Token = "0x2003DF2")]
		public class Input : IHotfixable
		{
			// Token: 0x06018AB2 RID: 101042 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018AB2")]
			[Address(RVA = "0x111E130", Offset = "0x111CD30", VA = "0x18111E130")]
			public Input()
			{
			}

			// Token: 0x0401E3DC RID: 123868
			[Token(Token = "0x401E3DC")]
			[FieldOffset(Offset = "0x10")]
			public SquadAssistData assistData;

			// Token: 0x0401E3DD RID: 123869
			[Token(Token = "0x401E3DD")]
			[FieldOffset(Offset = "0x18")]
			public EvolvePhaseAndLevel maxEvolvePhaseAndLevel;

			// Token: 0x0401E3DE RID: 123870
			[Token(Token = "0x401E3DE")]
			[FieldOffset(Offset = "0x20")]
			public SquadFriendAssistStateBean.Options option;

			// Token: 0x0401E3DF RID: 123871
			[Token(Token = "0x401E3DF")]
			[FieldOffset(Offset = "0x22")]
			public bool isCharShowMultipleSlot;

			// Token: 0x0401E3E0 RID: 123872
			[Token(Token = "0x401E3E0")]
			[FieldOffset(Offset = "0x23")]
			public bool isFriend;

			// Token: 0x0401E3E1 RID: 123873
			[Token(Token = "0x401E3E1")]
			[FieldOffset(Offset = "0x28")]
			public string nameCardSkinId;

			// Token: 0x0401E3E2 RID: 123874
			[Token(Token = "0x401E3E2")]
			[FieldOffset(Offset = "0x30")]
			public int nameCardSkinTmpl;

			// Token: 0x0401E3E3 RID: 123875
			[Token(Token = "0x401E3E3")]
			[FieldOffset(Offset = "0x34")]
			public bool isUsePlayerSelection;

			// Token: 0x0401E3E4 RID: 123876
			[Token(Token = "0x401E3E4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
