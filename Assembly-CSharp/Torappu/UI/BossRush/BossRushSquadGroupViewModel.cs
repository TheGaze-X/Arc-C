using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x0200619C RID: 24988
	[Token(Token = "0x200619C")]
	public class BossRushSquadGroupViewModel : SquadGroupViewModel
	{
		// Token: 0x17005511 RID: 21777
		// (get) Token: 0x060240A5 RID: 147621 RVA: 0x000C2D48 File Offset: 0x000C0F48
		[Token(Token = "0x17005511")]
		public ActivityBossRushData.BossRushStageType stageType
		{
			[Token(Token = "0x60240A5")]
			[Address(RVA = "0x1EB6920", Offset = "0x1EB5520", VA = "0x181EB6920")]
			get
			{
				return ActivityBossRushData.BossRushStageType.NONE;
			}
		}

		// Token: 0x17005512 RID: 21778
		// (get) Token: 0x060240A6 RID: 147622 RVA: 0x000C2D60 File Offset: 0x000C0F60
		[Token(Token = "0x17005512")]
		public bool isNormalStage
		{
			[Token(Token = "0x60240A6")]
			[Address(RVA = "0x1EB68C0", Offset = "0x1EB54C0", VA = "0x181EB68C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060240A7 RID: 147623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240A7")]
		[Address(RVA = "0x1EB4B10", Offset = "0x1EB3710", VA = "0x181EB4B10")]
		public void LoadDataFromTeams(string actId, string stageId, List<CharacterCardViewModel> predefinedSquad)
		{
		}

		// Token: 0x060240A8 RID: 147624 RVA: 0x000C2D78 File Offset: 0x000C0F78
		[Token(Token = "0x60240A8")]
		[Address(RVA = "0x1EB4840", Offset = "0x1EB3440", VA = "0x181EB4840")]
		public bool IsTeamMember(string teamId, string charId)
		{
			return default(bool);
		}

		// Token: 0x060240A9 RID: 147625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240A9")]
		[Address(RVA = "0x1EB5550", Offset = "0x1EB4150", VA = "0x181EB5550")]
		public void UpdateCustomMemberStatus()
		{
		}

		// Token: 0x060240AA RID: 147626 RVA: 0x000C2D90 File Offset: 0x000C0F90
		[Token(Token = "0x60240AA")]
		[Address(RVA = "0x1EB46E0", Offset = "0x1EB32E0", VA = "0x181EB46E0")]
		public bool IsFreeTeam(string teamId)
		{
			return default(bool);
		}

		// Token: 0x060240AB RID: 147627 RVA: 0x000C2DA8 File Offset: 0x000C0FA8
		[Token(Token = "0x60240AB")]
		[Address(RVA = "0x1EB49C0", Offset = "0x1EB35C0", VA = "0x181EB49C0")]
		public bool IsTeamSquadHasTeamBuff(string teamId)
		{
			return default(bool);
		}

		// Token: 0x060240AC RID: 147628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240AC")]
		[Address(RVA = "0x1EB5370", Offset = "0x1EB3F70", VA = "0x181EB5370")]
		public void SetSquadIndexByTeamId(string selectedTeamId)
		{
		}

		// Token: 0x060240AD RID: 147629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60240AD")]
		[Address(RVA = "0x1EB5A70", Offset = "0x1EB4670", VA = "0x181EB5A70")]
		private List<CharacterCardViewModel> _GetTeamFixedMemberList(Dictionary<string, CharacterCardViewModel> predefinedCharDict, ActivityBossRushData.BossRushTeamData teamData)
		{
			return null;
		}

		// Token: 0x060240AE RID: 147630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240AE")]
		[Address(RVA = "0x1EB5CF0", Offset = "0x1EB48F0", VA = "0x181EB5CF0")]
		private void _LoadNormalSquad(string actId, SquadItemStruct[] squadItemList)
		{
		}

		// Token: 0x060240AF RID: 147631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240AF")]
		[Address(RVA = "0x1EB5DA0", Offset = "0x1EB49A0", VA = "0x181EB5DA0")]
		private void _LoadTeamSquad(string actId, string teamId, List<CharacterCardViewModel> fixTeamMember, SquadItemStruct[] squadItemList)
		{
		}

		// Token: 0x060240B0 RID: 147632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240B0")]
		[Address(RVA = "0x1EB65E0", Offset = "0x1EB51E0", VA = "0x181EB65E0")]
		private void _TryLoadFixPartFromCache(string actId, string teamId, List<CharacterCardViewModel> fixTeamMember, SquadItemStruct[] squadItemList)
		{
		}

		// Token: 0x060240B1 RID: 147633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240B1")]
		[Address(RVA = "0x1EB62B0", Offset = "0x1EB4EB0", VA = "0x181EB62B0")]
		private void _TryLoadCustomSquadFromCache(string actId, string squadId, int fixTeamCount, SquadItemStruct[] squadItemList)
		{
		}

		// Token: 0x060240B2 RID: 147634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60240B2")]
		[Address(RVA = "0x1EB60B0", Offset = "0x1EB4CB0", VA = "0x181EB60B0")]
		private static string _MigrateSkillIfTmplChanged(CharacterCardViewModel curCard, SquadSlotCache savedSlot)
		{
			return null;
		}

		// Token: 0x060240B3 RID: 147635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60240B3")]
		[Address(RVA = "0x1EB5EB0", Offset = "0x1EB4AB0", VA = "0x181EB5EB0")]
		private static string _MigrateEquipIfTmplChanged(CharacterCardViewModel curCard, SquadSlotCache savedSlot)
		{
			return null;
		}

		// Token: 0x060240B4 RID: 147636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60240B4")]
		[Address(RVA = "0x1EB6860", Offset = "0x1EB5460", VA = "0x181EB6860")]
		public BossRushSquadGroupViewModel()
		{
		}

		// Token: 0x04032155 RID: 205141
		[Token(Token = "0x4032155")]
		[FieldOffset(Offset = "0x40")]
		private ActivityBossRushData m_cachedActData;

		// Token: 0x04032156 RID: 205142
		[Token(Token = "0x4032156")]
		private const int NORMAL_SQUAD_COUNT = 1;

		// Token: 0x04032157 RID: 205143
		[Token(Token = "0x4032157")]
		public const string NORMAL_SQUAD_ID = "normal";

		// Token: 0x04032158 RID: 205144
		[Token(Token = "0x4032158")]
		[FieldOffset(Offset = "0x48")]
		public string selectingRelicId;

		// Token: 0x04032159 RID: 205145
		[Token(Token = "0x4032159")]
		[FieldOffset(Offset = "0x50")]
		public string curSquadTeamId;

		// Token: 0x0403215A RID: 205146
		[Token(Token = "0x403215A")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, ActivityBossRushData.BossRushTeamData> teamDataDic;

		// Token: 0x0403215B RID: 205147
		[Token(Token = "0x403215B")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<int, string> teamIndexDic;

		// Token: 0x0403215C RID: 205148
		[Token(Token = "0x403215C")]
		[FieldOffset(Offset = "0x68")]
		public Dictionary<string, List<CharacterCardViewModel>> teamCardViewDic;

		// Token: 0x0403215D RID: 205149
		[Token(Token = "0x403215D")]
		[FieldOffset(Offset = "0x70")]
		private ActivityBossRushData.BossRushStageType m_stageType;

		// Token: 0x0403215E RID: 205150
		[Token(Token = "0x403215E")]
		[FieldOffset(Offset = "0x74")]
		private bool m_isNormalStage;

		// Token: 0x0403215F RID: 205151
		[Token(Token = "0x403215F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stageType;

		// Token: 0x04032160 RID: 205152
		[Token(Token = "0x4032160")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isNormalStage;

		// Token: 0x04032161 RID: 205153
		[Token(Token = "0x4032161")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadDataFromTeams;

		// Token: 0x04032162 RID: 205154
		[Token(Token = "0x4032162")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsTeamMember;

		// Token: 0x04032163 RID: 205155
		[Token(Token = "0x4032163")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateCustomMemberStatus;

		// Token: 0x04032164 RID: 205156
		[Token(Token = "0x4032164")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsFreeTeam;

		// Token: 0x04032165 RID: 205157
		[Token(Token = "0x4032165")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_IsTeamSquadHasTeamBuff;

		// Token: 0x04032166 RID: 205158
		[Token(Token = "0x4032166")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetSquadIndexByTeamId;

		// Token: 0x04032167 RID: 205159
		[Token(Token = "0x4032167")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetTeamFixedMemberList;

		// Token: 0x04032168 RID: 205160
		[Token(Token = "0x4032168")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadNormalSquad;

		// Token: 0x04032169 RID: 205161
		[Token(Token = "0x4032169")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__LoadTeamSquad;

		// Token: 0x0403216A RID: 205162
		[Token(Token = "0x403216A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TryLoadFixPartFromCache;

		// Token: 0x0403216B RID: 205163
		[Token(Token = "0x403216B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TryLoadCustomSquadFromCache;

		// Token: 0x0403216C RID: 205164
		[Token(Token = "0x403216C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__MigrateSkillIfTmplChanged;

		// Token: 0x0403216D RID: 205165
		[Token(Token = "0x403216D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__MigrateEquipIfTmplChanged;

		// Token: 0x0403216E RID: 205166
		[Token(Token = "0x403216E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
