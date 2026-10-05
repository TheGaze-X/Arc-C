using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Scripts.UI.Squad;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x020061A5 RID: 24997
	[Token(Token = "0x20061A5")]
	public class BossRushSquadStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17005518 RID: 21784
		// (get) Token: 0x06024111 RID: 147729 RVA: 0x000C2F40 File Offset: 0x000C1140
		[Token(Token = "0x17005518")]
		public ActivityBossRushData.BossRushStageType bossRushStageType
		{
			[Token(Token = "0x6024111")]
			[Address(RVA = "0x1EC1260", Offset = "0x1EBFE60", VA = "0x181EC1260")]
			get
			{
				return ActivityBossRushData.BossRushStageType.NONE;
			}
		}

		// Token: 0x17005519 RID: 21785
		// (get) Token: 0x06024112 RID: 147730 RVA: 0x000C2F58 File Offset: 0x000C1158
		[Token(Token = "0x17005519")]
		public bool isNormalStage
		{
			[Token(Token = "0x6024112")]
			[Address(RVA = "0x1EC1820", Offset = "0x1EC0420", VA = "0x181EC1820")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700551A RID: 21786
		// (get) Token: 0x06024113 RID: 147731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700551A")]
		public Dictionary<string, ActivityBossRushData.BossRushTeamData> teamDataDic
		{
			[Token(Token = "0x6024113")]
			[Address(RVA = "0x1EC19C0", Offset = "0x1EC05C0", VA = "0x181EC19C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700551B RID: 21787
		// (get) Token: 0x06024114 RID: 147732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700551B")]
		public Dictionary<int, string> teamIndexDic
		{
			[Token(Token = "0x6024114")]
			[Address(RVA = "0x1EC1BB0", Offset = "0x1EC07B0", VA = "0x181EC1BB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700551C RID: 21788
		// (get) Token: 0x06024115 RID: 147733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700551C")]
		public string curSquadTeamId
		{
			[Token(Token = "0x6024115")]
			[Address(RVA = "0x1EC13A0", Offset = "0x1EBFFA0", VA = "0x181EC13A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700551D RID: 21789
		// (get) Token: 0x06024116 RID: 147734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700551D")]
		public string teamIdForRequest
		{
			[Token(Token = "0x6024116")]
			[Address(RVA = "0x1EC1AA0", Offset = "0x1EC06A0", VA = "0x181EC1AA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700551E RID: 21790
		// (get) Token: 0x06024117 RID: 147735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700551E")]
		public SquadGroupViewProperty squadGroupProp
		{
			[Token(Token = "0x6024117")]
			[Address(RVA = "0x1EC1960", Offset = "0x1EC0560", VA = "0x181EC1960")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700551F RID: 21791
		// (get) Token: 0x06024118 RID: 147736 RVA: 0x000C2F70 File Offset: 0x000C1170
		// (set) Token: 0x06024119 RID: 147737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700551F")]
		public ProfessionCategory assistProfession
		{
			[Token(Token = "0x6024118")]
			[Address(RVA = "0x1EC1200", Offset = "0x1EBFE00", VA = "0x181EC1200")]
			get
			{
				return ProfessionCategory.NONE;
			}
			[Token(Token = "0x6024119")]
			[Address(RVA = "0x1EC1C90", Offset = "0x1EC0890", VA = "0x181EC1C90")]
			set
			{
			}
		}

		// Token: 0x17005520 RID: 21792
		// (get) Token: 0x0602411A RID: 147738 RVA: 0x000C2F88 File Offset: 0x000C1188
		// (set) Token: 0x0602411B RID: 147739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005520")]
		public BossRushSquadStateBean.FriendAssistDataStruct friendDataCache
		{
			[Token(Token = "0x602411A")]
			[Address(RVA = "0x1EC1480", Offset = "0x1EC0080", VA = "0x181EC1480")]
			get
			{
				return default(BossRushSquadStateBean.FriendAssistDataStruct);
			}
			[Token(Token = "0x602411B")]
			[Address(RVA = "0x1EC1D00", Offset = "0x1EC0900", VA = "0x181EC1D00")]
			set
			{
			}
		}

		// Token: 0x17005521 RID: 21793
		// (get) Token: 0x0602411C RID: 147740 RVA: 0x000C2FA0 File Offset: 0x000C11A0
		[Token(Token = "0x17005521")]
		public bool isFriendLegal
		{
			[Token(Token = "0x602411C")]
			[Address(RVA = "0x1EC1500", Offset = "0x1EC0100", VA = "0x181EC1500")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602411D RID: 147741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602411D")]
		[Address(RVA = "0x1EBED50", Offset = "0x1EBD950", VA = "0x181EBED50")]
		public CharacterCardViewModel PickRandomCharacter()
		{
			return null;
		}

		// Token: 0x0602411E RID: 147742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602411E")]
		[Address(RVA = "0x1EBE7E0", Offset = "0x1EBD3E0", VA = "0x181EBE7E0")]
		public SquadItemStruct[] ParseBattleSquadLocal()
		{
			return null;
		}

		// Token: 0x0602411F RID: 147743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602411F")]
		[Address(RVA = "0x1EBE950", Offset = "0x1EBD550", VA = "0x181EBE950")]
		public List<RequestSquadSlot> ParseBattleStartRequestSquad()
		{
			return null;
		}

		// Token: 0x06024120 RID: 147744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024120")]
		[Address(RVA = "0x1EBDC60", Offset = "0x1EBC860", VA = "0x181EBDC60")]
		public List<RuneTable.PackedRuneData> GetRuneListByBossRushRelic()
		{
			return null;
		}

		// Token: 0x06024121 RID: 147745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024121")]
		[Address(RVA = "0x1EBFC60", Offset = "0x1EBE860", VA = "0x181EBFC60")]
		private void _AddRelicRuneData(List<RuneTable.PackedRuneData> runeList, ActivityBossRushData bossRushData, PlayerActivity.PlayerBossRushActivity playerData)
		{
		}

		// Token: 0x06024122 RID: 147746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024122")]
		[Address(RVA = "0x1EBFF10", Offset = "0x1EBEB10", VA = "0x181EBFF10")]
		private void _AddWaveRuneData(List<RuneTable.PackedRuneData> runeList, ActivityBossRushData bossRushData, PlayerActivity.PlayerBossRushActivity playerData)
		{
		}

		// Token: 0x06024123 RID: 147747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024123")]
		[Address(RVA = "0x1EBFE10", Offset = "0x1EBEA10", VA = "0x181EBFE10")]
		private void _AddTeamRuneData(List<RuneTable.PackedRuneData> runeList, ActivityBossRushData bossRushData)
		{
		}

		// Token: 0x06024124 RID: 147748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024124")]
		[Address(RVA = "0x1EBDB70", Offset = "0x1EBC770", VA = "0x181EBDB70")]
		public DataBundle GenDataBundleToJump()
		{
			return null;
		}

		// Token: 0x06024125 RID: 147749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024125")]
		[Address(RVA = "0x1EBE5E0", Offset = "0x1EBD1E0", VA = "0x181EBE5E0")]
		public void LoadData(BossRushSquadTeamPage.Params pageParams)
		{
		}

		// Token: 0x06024126 RID: 147750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024126")]
		[Address(RVA = "0x1EBEFA0", Offset = "0x1EBDBA0", VA = "0x181EBEFA0")]
		public void RefreshData()
		{
		}

		// Token: 0x06024127 RID: 147751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024127")]
		[Address(RVA = "0x1EBCE90", Offset = "0x1EBBA90", VA = "0x181EBCE90")]
		public void ApplyToFriendAssistBean(SquadFriendAssistStateBean assistBean)
		{
		}

		// Token: 0x06024128 RID: 147752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024128")]
		[Address(RVA = "0x1EBEE10", Offset = "0x1EBDA10", VA = "0x181EBEE10")]
		public void ReceiveFromFriendAssistBean(SquadFriendAssistStateBean assistBean)
		{
		}

		// Token: 0x06024129 RID: 147753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024129")]
		[Address(RVA = "0x1EBE290", Offset = "0x1EBCE90", VA = "0x181EBE290")]
		public string GetTeamIdByIndex(int index)
		{
			return null;
		}

		// Token: 0x0602412A RID: 147754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602412A")]
		[Address(RVA = "0x1EBF5C0", Offset = "0x1EBE1C0", VA = "0x181EBF5C0")]
		public void SaveAllSquadDataToLocalCache()
		{
		}

		// Token: 0x0602412B RID: 147755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602412B")]
		[Address(RVA = "0x1EBFB20", Offset = "0x1EBE720", VA = "0x181EBFB20")]
		public void SaveSquadTeamToLocalCache(string teamId)
		{
		}

		// Token: 0x0602412C RID: 147756 RVA: 0x000C2FB8 File Offset: 0x000C11B8
		[Token(Token = "0x602412C")]
		[Address(RVA = "0x1EBF110", Offset = "0x1EBDD10", VA = "0x181EBF110")]
		public bool RestrictSquadMembers()
		{
			return default(bool);
		}

		// Token: 0x0602412D RID: 147757 RVA: 0x000C2FD0 File Offset: 0x000C11D0
		[Token(Token = "0x602412D")]
		[Address(RVA = "0x1EBD200", Offset = "0x1EBBE00", VA = "0x181EBD200")]
		public bool CheckIfCharSelectable(CharQuery charQuery, string teamId)
		{
			return default(bool);
		}

		// Token: 0x0602412E RID: 147758 RVA: 0x000C2FE8 File Offset: 0x000C11E8
		[Token(Token = "0x602412E")]
		[Address(RVA = "0x1EBD070", Offset = "0x1EBBC70", VA = "0x181EBD070")]
		public bool CheckIfCharSelectable(int instId, string teamId)
		{
			return default(bool);
		}

		// Token: 0x0602412F RID: 147759 RVA: 0x000C3000 File Offset: 0x000C1200
		[Token(Token = "0x602412F")]
		[Address(RVA = "0x1EBE6F0", Offset = "0x1EBD2F0", VA = "0x181EBE6F0")]
		public int MaxNum4CharSelect(string teamId)
		{
			return 0;
		}

		// Token: 0x06024130 RID: 147760 RVA: 0x000C3018 File Offset: 0x000C1218
		[Token(Token = "0x6024130")]
		[Address(RVA = "0x1EBE3A0", Offset = "0x1EBCFA0", VA = "0x181EBE3A0")]
		public bool IsCurrentSquadEmpty()
		{
			return default(bool);
		}

		// Token: 0x06024131 RID: 147761 RVA: 0x000C3030 File Offset: 0x000C1230
		[Token(Token = "0x6024131")]
		[Address(RVA = "0x1EBCFC0", Offset = "0x1EBBBC0", VA = "0x181EBCFC0")]
		public bool CheckIfCharRuneValid(CharQuery charQuery)
		{
			return default(bool);
		}

		// Token: 0x06024132 RID: 147762 RVA: 0x000C3048 File Offset: 0x000C1248
		[Token(Token = "0x6024132")]
		[Address(RVA = "0x1EBD2B0", Offset = "0x1EBBEB0", VA = "0x181EBD2B0")]
		public bool CheckIfCharValid(CharQuery charQuery, string teamId)
		{
			return default(bool);
		}

		// Token: 0x06024133 RID: 147763 RVA: 0x000C3060 File Offset: 0x000C1260
		[Token(Token = "0x6024133")]
		[Address(RVA = "0x1EBD8A0", Offset = "0x1EBC4A0", VA = "0x181EBD8A0")]
		public bool CheckIfSelectTeamMember(string teamId, string charId)
		{
			return default(bool);
		}

		// Token: 0x06024134 RID: 147764 RVA: 0x000C3078 File Offset: 0x000C1278
		[Token(Token = "0x6024134")]
		[Address(RVA = "0x1EBE170", Offset = "0x1EBCD70", VA = "0x181EBE170")]
		public int GetTeamFixMemCount(string teamId)
		{
			return 0;
		}

		// Token: 0x06024135 RID: 147765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024135")]
		[Address(RVA = "0x1EBDAA0", Offset = "0x1EBC6A0", VA = "0x181EBDAA0")]
		public void CleanAssistChar()
		{
		}

		// Token: 0x06024136 RID: 147766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024136")]
		[Address(RVA = "0x1EBFBD0", Offset = "0x1EBE7D0", VA = "0x181EBFBD0")]
		public void UpdateTeamInfoByIndex(int selectedIndex)
		{
		}

		// Token: 0x06024137 RID: 147767 RVA: 0x000C3090 File Offset: 0x000C1290
		[Token(Token = "0x6024137")]
		[Address(RVA = "0x1EBD520", Offset = "0x1EBC120", VA = "0x181EBD520")]
		public bool CheckIfPredefinedTeamSkillChanged()
		{
			return default(bool);
		}

		// Token: 0x06024138 RID: 147768 RVA: 0x000C30A8 File Offset: 0x000C12A8
		[Token(Token = "0x6024138")]
		[Address(RVA = "0x1EBDA10", Offset = "0x1EBC610", VA = "0x181EBDA10")]
		public bool CheckIfShowPredefineSkillCanChange()
		{
			return default(bool);
		}

		// Token: 0x06024139 RID: 147769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024139")]
		[Address(RVA = "0x1EBFA90", Offset = "0x1EBE690", VA = "0x181EBFA90")]
		public void SavePredefineSkillCanChangeFlag()
		{
		}

		// Token: 0x0602413A RID: 147770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602413A")]
		[Address(RVA = "0x1EC0520", Offset = "0x1EBF120", VA = "0x181EC0520")]
		private void _LoadDataInternal(string actId, string stageGroupId, string stageId, string selectedTeamId)
		{
		}

		// Token: 0x0602413B RID: 147771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602413B")]
		[Address(RVA = "0x1EC0D80", Offset = "0x1EBF980", VA = "0x181EC0D80")]
		private void _UpdateStartButtonType()
		{
		}

		// Token: 0x0602413C RID: 147772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602413C")]
		[Address(RVA = "0x1EC0C50", Offset = "0x1EBF850", VA = "0x181EC0C50")]
		private void _TryRefreshData()
		{
		}

		// Token: 0x0602413D RID: 147773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602413D")]
		[Address(RVA = "0x1EC0950", Offset = "0x1EBF550", VA = "0x181EC0950")]
		private void _RefreshRelic()
		{
		}

		// Token: 0x0602413E RID: 147774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602413E")]
		[Address(RVA = "0x1EC0B10", Offset = "0x1EBF710", VA = "0x181EC0B10")]
		private ActivityBossRushData.BossRushTeamData _TryGetSquadTeamData(string teamId)
		{
			return null;
		}

		// Token: 0x0602413F RID: 147775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602413F")]
		[Address(RVA = "0x1EC0480", Offset = "0x1EBF080", VA = "0x181EC0480")]
		private void _InitTeamSelectedIndex(BossRushSquadGroupViewModel squadGroupViewModel, string selectedTeamId)
		{
		}

		// Token: 0x06024140 RID: 147776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024140")]
		[Address(RVA = "0x1EC0F20", Offset = "0x1EBFB20", VA = "0x181EC0F20")]
		private void _UpdateTeamInfo(string teamId)
		{
		}

		// Token: 0x06024141 RID: 147777 RVA: 0x000C30C0 File Offset: 0x000C12C0
		[Token(Token = "0x6024141")]
		[Address(RVA = "0x1EC0330", Offset = "0x1EBEF30", VA = "0x181EC0330")]
		private SquadMaxNumInfo _GetSquadMaxRawNumInfo(string squadTeamId, bool excludePredefined)
		{
			return default(SquadMaxNumInfo);
		}

		// Token: 0x06024142 RID: 147778 RVA: 0x000C30D8 File Offset: 0x000C12D8
		[Token(Token = "0x6024142")]
		[Address(RVA = "0x1EC02B0", Offset = "0x1EBEEB0", VA = "0x181EC02B0")]
		private SquadMaxNumInfo _GetSquadMaxLimitNumInfo()
		{
			return default(SquadMaxNumInfo);
		}

		// Token: 0x06024143 RID: 147779 RVA: 0x000C30F0 File Offset: 0x000C12F0
		[Token(Token = "0x6024143")]
		[Address(RVA = "0x1EC0220", Offset = "0x1EBEE20", VA = "0x181EC0220")]
		private int _GetSquadMaxCharCount(string squadTeamId)
		{
			return 0;
		}

		// Token: 0x06024144 RID: 147780 RVA: 0x000C3108 File Offset: 0x000C1308
		[Token(Token = "0x6024144")]
		[Address(RVA = "0x1EC0080", Offset = "0x1EBEC80", VA = "0x181EC0080")]
		private int _GetCurSquadValidMemberNum()
		{
			return 0;
		}

		// Token: 0x06024145 RID: 147781 RVA: 0x000C3120 File Offset: 0x000C1320
		[Token(Token = "0x6024145")]
		[Address(RVA = "0x1EC0150", Offset = "0x1EBED50", VA = "0x181EC0150")]
		private int _GetSquadAssistNum()
		{
			return 0;
		}

		// Token: 0x06024146 RID: 147782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024146")]
		[Address(RVA = "0x1EC1110", Offset = "0x1EBFD10", VA = "0x181EC1110")]
		public BossRushSquadStateBean()
		{
		}

		// Token: 0x040321DE RID: 205278
		[Token(Token = "0x40321DE")]
		[FieldOffset(Offset = "0x10")]
		private LevelData m_levelData;

		// Token: 0x040321DF RID: 205279
		[Token(Token = "0x40321DF")]
		[FieldOffset(Offset = "0x18")]
		public string activityId;

		// Token: 0x040321E0 RID: 205280
		[Token(Token = "0x40321E0")]
		[FieldOffset(Offset = "0x20")]
		public string stageGroupId;

		// Token: 0x040321E1 RID: 205281
		[Token(Token = "0x40321E1")]
		[FieldOffset(Offset = "0x28")]
		public string stageId;

		// Token: 0x040321E2 RID: 205282
		[Token(Token = "0x40321E2")]
		[FieldOffset(Offset = "0x30")]
		public SquadStartButtonTypeEnum startButtonMode;

		// Token: 0x040321E3 RID: 205283
		[Token(Token = "0x40321E3")]
		[FieldOffset(Offset = "0x38")]
		public List<CharacterCardViewModel> curSquadTeamPredefinedList;

		// Token: 0x040321E4 RID: 205284
		[Token(Token = "0x40321E4")]
		[FieldOffset(Offset = "0x40")]
		public bool curSquadHasTeamBuff;

		// Token: 0x040321E5 RID: 205285
		[Token(Token = "0x40321E5")]
		[FieldOffset(Offset = "0x48")]
		private SquadGroupViewProperty m_squadProperty;

		// Token: 0x040321E6 RID: 205286
		[Token(Token = "0x40321E6")]
		[FieldOffset(Offset = "0x50")]
		private ProfessionCategory m_assistProfession;

		// Token: 0x040321E7 RID: 205287
		[Token(Token = "0x40321E7")]
		[FieldOffset(Offset = "0x58")]
		private BossRushSquadStateBean.FriendAssistDataStruct m_friendDataCache;

		// Token: 0x040321E8 RID: 205288
		[Token(Token = "0x40321E8")]
		[FieldOffset(Offset = "0x68")]
		private ExternalRuneChecker m_externalRuneChecker;

		// Token: 0x040321E9 RID: 205289
		[Token(Token = "0x40321E9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bossRushStageType;

		// Token: 0x040321EA RID: 205290
		[Token(Token = "0x40321EA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isNormalStage;

		// Token: 0x040321EB RID: 205291
		[Token(Token = "0x40321EB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_teamDataDic;

		// Token: 0x040321EC RID: 205292
		[Token(Token = "0x40321EC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_teamIndexDic;

		// Token: 0x040321ED RID: 205293
		[Token(Token = "0x40321ED")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_curSquadTeamId;

		// Token: 0x040321EE RID: 205294
		[Token(Token = "0x40321EE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_teamIdForRequest;

		// Token: 0x040321EF RID: 205295
		[Token(Token = "0x40321EF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_squadGroupProp;

		// Token: 0x040321F0 RID: 205296
		[Token(Token = "0x40321F0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_assistProfession;

		// Token: 0x040321F1 RID: 205297
		[Token(Token = "0x40321F1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_assistProfession;

		// Token: 0x040321F2 RID: 205298
		[Token(Token = "0x40321F2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_friendDataCache;

		// Token: 0x040321F3 RID: 205299
		[Token(Token = "0x40321F3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_friendDataCache;

		// Token: 0x040321F4 RID: 205300
		[Token(Token = "0x40321F4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_isFriendLegal;

		// Token: 0x040321F5 RID: 205301
		[Token(Token = "0x40321F5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_PickRandomCharacter;

		// Token: 0x040321F6 RID: 205302
		[Token(Token = "0x40321F6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ParseBattleSquadLocal;

		// Token: 0x040321F7 RID: 205303
		[Token(Token = "0x40321F7")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ParseBattleStartRequestSquad;

		// Token: 0x040321F8 RID: 205304
		[Token(Token = "0x40321F8")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetRuneListByBossRushRelic;

		// Token: 0x040321F9 RID: 205305
		[Token(Token = "0x40321F9")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__AddRelicRuneData;

		// Token: 0x040321FA RID: 205306
		[Token(Token = "0x40321FA")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__AddWaveRuneData;

		// Token: 0x040321FB RID: 205307
		[Token(Token = "0x40321FB")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__AddTeamRuneData;

		// Token: 0x040321FC RID: 205308
		[Token(Token = "0x40321FC")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GenDataBundleToJump;

		// Token: 0x040321FD RID: 205309
		[Token(Token = "0x40321FD")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040321FE RID: 205310
		[Token(Token = "0x40321FE")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x040321FF RID: 205311
		[Token(Token = "0x40321FF")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_ApplyToFriendAssistBean;

		// Token: 0x04032200 RID: 205312
		[Token(Token = "0x4032200")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_ReceiveFromFriendAssistBean;

		// Token: 0x04032201 RID: 205313
		[Token(Token = "0x4032201")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_GetTeamIdByIndex;

		// Token: 0x04032202 RID: 205314
		[Token(Token = "0x4032202")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_SaveAllSquadDataToLocalCache;

		// Token: 0x04032203 RID: 205315
		[Token(Token = "0x4032203")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_SaveSquadTeamToLocalCache;

		// Token: 0x04032204 RID: 205316
		[Token(Token = "0x4032204")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_RestrictSquadMembers;

		// Token: 0x04032205 RID: 205317
		[Token(Token = "0x4032205")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_CheckIfCharSelectable;

		// Token: 0x04032206 RID: 205318
		[Token(Token = "0x4032206")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix1_CheckIfCharSelectable;

		// Token: 0x04032207 RID: 205319
		[Token(Token = "0x4032207")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_MaxNum4CharSelect;

		// Token: 0x04032208 RID: 205320
		[Token(Token = "0x4032208")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_IsCurrentSquadEmpty;

		// Token: 0x04032209 RID: 205321
		[Token(Token = "0x4032209")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_CheckIfCharRuneValid;

		// Token: 0x0403220A RID: 205322
		[Token(Token = "0x403220A")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_CheckIfCharValid;

		// Token: 0x0403220B RID: 205323
		[Token(Token = "0x403220B")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_CheckIfSelectTeamMember;

		// Token: 0x0403220C RID: 205324
		[Token(Token = "0x403220C")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_GetTeamFixMemCount;

		// Token: 0x0403220D RID: 205325
		[Token(Token = "0x403220D")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_CleanAssistChar;

		// Token: 0x0403220E RID: 205326
		[Token(Token = "0x403220E")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_UpdateTeamInfoByIndex;

		// Token: 0x0403220F RID: 205327
		[Token(Token = "0x403220F")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_CheckIfPredefinedTeamSkillChanged;

		// Token: 0x04032210 RID: 205328
		[Token(Token = "0x4032210")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_CheckIfShowPredefineSkillCanChange;

		// Token: 0x04032211 RID: 205329
		[Token(Token = "0x4032211")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_SavePredefineSkillCanChangeFlag;

		// Token: 0x04032212 RID: 205330
		[Token(Token = "0x4032212")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__LoadDataInternal;

		// Token: 0x04032213 RID: 205331
		[Token(Token = "0x4032213")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__UpdateStartButtonType;

		// Token: 0x04032214 RID: 205332
		[Token(Token = "0x4032214")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__TryRefreshData;

		// Token: 0x04032215 RID: 205333
		[Token(Token = "0x4032215")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__RefreshRelic;

		// Token: 0x04032216 RID: 205334
		[Token(Token = "0x4032216")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__TryGetSquadTeamData;

		// Token: 0x04032217 RID: 205335
		[Token(Token = "0x4032217")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__InitTeamSelectedIndex;

		// Token: 0x04032218 RID: 205336
		[Token(Token = "0x4032218")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__UpdateTeamInfo;

		// Token: 0x04032219 RID: 205337
		[Token(Token = "0x4032219")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__GetSquadMaxRawNumInfo;

		// Token: 0x0403221A RID: 205338
		[Token(Token = "0x403221A")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__GetSquadMaxLimitNumInfo;

		// Token: 0x0403221B RID: 205339
		[Token(Token = "0x403221B")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__GetSquadMaxCharCount;

		// Token: 0x0403221C RID: 205340
		[Token(Token = "0x403221C")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__GetCurSquadValidMemberNum;

		// Token: 0x0403221D RID: 205341
		[Token(Token = "0x403221D")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__GetSquadAssistNum;

		// Token: 0x0403221E RID: 205342
		[Token(Token = "0x403221E")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020061A6 RID: 24998
		[Token(Token = "0x20061A6")]
		private class SquadConstrainPolicy : SquadGroupConstrainPolicy
		{
			// Token: 0x06024147 RID: 147783 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024147")]
			[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
			public SquadConstrainPolicy(BossRushSquadStateBean clousre)
			{
			}

			// Token: 0x06024148 RID: 147784 RVA: 0x000C3138 File Offset: 0x000C1338
			[Token(Token = "0x6024148")]
			[Address(RVA = "0x1ECBB50", Offset = "0x1ECA750", VA = "0x181ECBB50", Slot = "4")]
			public override bool CheckIfAssistLocked()
			{
				return default(bool);
			}

			// Token: 0x06024149 RID: 147785 RVA: 0x000C3150 File Offset: 0x000C1350
			[Token(Token = "0x6024149")]
			[Address(RVA = "0x1ECBC80", Offset = "0x1ECA880", VA = "0x181ECBC80", Slot = "5")]
			public override bool CheckIfSquadSlotLocked(SquadViewModel squad, int index)
			{
				return default(bool);
			}

			// Token: 0x0403221F RID: 205343
			[Token(Token = "0x403221F")]
			[FieldOffset(Offset = "0x10")]
			private BossRushSquadStateBean m_closure;
		}

		// Token: 0x020061A7 RID: 24999
		[Token(Token = "0x20061A7")]
		public struct FriendAssistDataStruct
		{
			// Token: 0x04032220 RID: 205344
			[Token(Token = "0x4032220")]
			[FieldOffset(Offset = "0x0")]
			public GetFriendAssistCharListResponse friendAssistResp;

			// Token: 0x04032221 RID: 205345
			[Token(Token = "0x4032221")]
			[FieldOffset(Offset = "0x8")]
			public bool isFromRemote;
		}
	}
}
