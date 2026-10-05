using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052EB RID: 21227
	[Token(Token = "0x20052EB")]
	public class RoguelikeFriendAssistSearchModel : IHotfixable
	{
		// Token: 0x17004975 RID: 18805
		// (get) Token: 0x0601F4F2 RID: 128242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004975")]
		public string recruitIndex
		{
			[Token(Token = "0x601F4F2")]
			[Address(RVA = "0x1906ED0", Offset = "0x1905AD0", VA = "0x181906ED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004976 RID: 18806
		// (get) Token: 0x0601F4F3 RID: 128243 RVA: 0x000B1708 File Offset: 0x000AF908
		[Token(Token = "0x17004976")]
		public int population
		{
			[Token(Token = "0x601F4F3")]
			[Address(RVA = "0x1906D60", Offset = "0x1905960", VA = "0x181906D60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004977 RID: 18807
		// (get) Token: 0x0601F4F4 RID: 128244 RVA: 0x000B1720 File Offset: 0x000AF920
		[Token(Token = "0x17004977")]
		public ProfessionCategory profession
		{
			[Token(Token = "0x601F4F4")]
			[Address(RVA = "0x1906E60", Offset = "0x1905A60", VA = "0x181906E60")]
			get
			{
				return ProfessionCategory.NONE;
			}
		}

		// Token: 0x17004978 RID: 18808
		// (get) Token: 0x0601F4F5 RID: 128245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004978")]
		public List<ProfessionCategory> professionList
		{
			[Token(Token = "0x601F4F5")]
			[Address(RVA = "0x1906DD0", Offset = "0x19059D0", VA = "0x181906DD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004979 RID: 18809
		// (get) Token: 0x0601F4F6 RID: 128246 RVA: 0x000B1738 File Offset: 0x000AF938
		[Token(Token = "0x17004979")]
		public ProfessionCategory activeProfession
		{
			[Token(Token = "0x601F4F6")]
			[Address(RVA = "0x1906960", Offset = "0x1905560", VA = "0x181906960")]
			get
			{
				return ProfessionCategory.NONE;
			}
		}

		// Token: 0x1700497A RID: 18810
		// (get) Token: 0x0601F4F7 RID: 128247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700497A")]
		public List<PlayerRoguelikeV2.CurrentData.Recruit.FriendAssistData> assistList
		{
			[Token(Token = "0x601F4F7")]
			[Address(RVA = "0x19069D0", Offset = "0x19055D0", VA = "0x1819069D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601F4F8 RID: 128248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4F8")]
		[Address(RVA = "0x1905C30", Offset = "0x1904830", VA = "0x181905C30")]
		public void LoadData(string topicId)
		{
		}

		// Token: 0x0601F4F9 RID: 128249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4F9")]
		[Address(RVA = "0x1905FF0", Offset = "0x1904BF0", VA = "0x181905FF0")]
		public void SetStarFriendTabSelected(bool isSelected)
		{
		}

		// Token: 0x0601F4FA RID: 128250 RVA: 0x000B1750 File Offset: 0x000AF950
		[Token(Token = "0x601F4FA")]
		[Address(RVA = "0x1906330", Offset = "0x1904F30", VA = "0x181906330")]
		private bool _TryGetCurrentPopulation(out int population)
		{
			return default(bool);
		}

		// Token: 0x0601F4FB RID: 128251 RVA: 0x000B1768 File Offset: 0x000AF968
		[Token(Token = "0x601F4FB")]
		[Address(RVA = "0x1906430", Offset = "0x1905030", VA = "0x181906430")]
		private bool _TryGetPendingRecruitIndex(out string recruitIndex)
		{
			return default(bool);
		}

		// Token: 0x0601F4FC RID: 128252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4FC")]
		[Address(RVA = "0x19060B0", Offset = "0x1904CB0", VA = "0x1819060B0")]
		private void _AddSquadSlotWithoutDup(List<PlayerRoguelikeV2.CurrentData.Recruit.FriendAssistData> retList, List<PlayerRoguelikeV2.CurrentData.Recruit.FriendAssistData> dataSource, int maxLength)
		{
		}

		// Token: 0x0601F4FD RID: 128253 RVA: 0x000B1780 File Offset: 0x000AF980
		[Token(Token = "0x601F4FD")]
		[Address(RVA = "0x1906250", Offset = "0x1904E50", VA = "0x181906250")]
		private bool _IsSameAssistData(PlayerRoguelikeV2.CurrentData.Recruit.FriendAssistData a, PlayerRoguelikeV2.CurrentData.Recruit.FriendAssistData b)
		{
			return default(bool);
		}

		// Token: 0x0601F4FE RID: 128254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F4FE")]
		[Address(RVA = "0x19068E0", Offset = "0x19054E0", VA = "0x1819068E0")]
		public RoguelikeFriendAssistSearchModel()
		{
		}

		// Token: 0x0402A105 RID: 172293
		[Token(Token = "0x402A105")]
		[FieldOffset(Offset = "0x0")]
		public static List<ProfessionCategory> PROFESSION_LIST;

		// Token: 0x0402A106 RID: 172294
		[Token(Token = "0x402A106")]
		[FieldOffset(Offset = "0x10")]
		private string m_recruitIndex;

		// Token: 0x0402A107 RID: 172295
		[Token(Token = "0x402A107")]
		[FieldOffset(Offset = "0x18")]
		private PlayerRoguelikeV2.CurrentData.Recruit m_recruitData;

		// Token: 0x0402A108 RID: 172296
		[Token(Token = "0x402A108")]
		[FieldOffset(Offset = "0x20")]
		private ProfessionCategory m_profession;

		// Token: 0x0402A109 RID: 172297
		[Token(Token = "0x402A109")]
		[FieldOffset(Offset = "0x24")]
		private int m_population;

		// Token: 0x0402A10A RID: 172298
		[Token(Token = "0x402A10A")]
		[FieldOffset(Offset = "0x28")]
		private string m_topicId;

		// Token: 0x0402A10B RID: 172299
		[Token(Token = "0x402A10B")]
		[FieldOffset(Offset = "0x30")]
		private int m_assistSlotMaxCount;

		// Token: 0x0402A10C RID: 172300
		[Token(Token = "0x402A10C")]
		[FieldOffset(Offset = "0x34")]
		public bool starFriendTabSelected;

		// Token: 0x0402A10D RID: 172301
		[Token(Token = "0x402A10D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_recruitIndex;

		// Token: 0x0402A10E RID: 172302
		[Token(Token = "0x402A10E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_population;

		// Token: 0x0402A10F RID: 172303
		[Token(Token = "0x402A10F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_profession;

		// Token: 0x0402A110 RID: 172304
		[Token(Token = "0x402A110")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_professionList;

		// Token: 0x0402A111 RID: 172305
		[Token(Token = "0x402A111")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_activeProfession;

		// Token: 0x0402A112 RID: 172306
		[Token(Token = "0x402A112")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_assistList;

		// Token: 0x0402A113 RID: 172307
		[Token(Token = "0x402A113")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402A114 RID: 172308
		[Token(Token = "0x402A114")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetStarFriendTabSelected;

		// Token: 0x0402A115 RID: 172309
		[Token(Token = "0x402A115")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TryGetCurrentPopulation;

		// Token: 0x0402A116 RID: 172310
		[Token(Token = "0x402A116")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TryGetPendingRecruitIndex;

		// Token: 0x0402A117 RID: 172311
		[Token(Token = "0x402A117")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__AddSquadSlotWithoutDup;

		// Token: 0x0402A118 RID: 172312
		[Token(Token = "0x402A118")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__IsSameAssistData;

		// Token: 0x0402A119 RID: 172313
		[Token(Token = "0x402A119")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
