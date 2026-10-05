using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FA2 RID: 28578
	[Token(Token = "0x2006FA2")]
	public class ActMultiV3QuickMatchModel : IHotfixable
	{
		// Token: 0x17005F9F RID: 24479
		// (get) Token: 0x060288FC RID: 166140 RVA: 0x000D21B0 File Offset: 0x000D03B0
		// (set) Token: 0x060288FD RID: 166141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F9F")]
		public bool isMatchUnlock
		{
			[Token(Token = "0x60288FC")]
			[Address(RVA = "0x23E4750", Offset = "0x23E3350", VA = "0x1823E4750")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60288FD")]
			[Address(RVA = "0x23E5160", Offset = "0x23E3D60", VA = "0x1823E5160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FA0 RID: 24480
		// (get) Token: 0x060288FE RID: 166142 RVA: 0x000D21C8 File Offset: 0x000D03C8
		// (set) Token: 0x060288FF RID: 166143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FA0")]
		public int matchStatusSeqNum
		{
			[Token(Token = "0x60288FE")]
			[Address(RVA = "0x23E4980", Offset = "0x23E3580", VA = "0x1823E4980")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60288FF")]
			[Address(RVA = "0x23E5330", Offset = "0x23E3F30", VA = "0x1823E5330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FA1 RID: 24481
		// (get) Token: 0x06028900 RID: 166144 RVA: 0x000D21E0 File Offset: 0x000D03E0
		// (set) Token: 0x06028901 RID: 166145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FA1")]
		public int enterSeqNum
		{
			[Token(Token = "0x6028900")]
			[Address(RVA = "0x23E44E0", Offset = "0x23E30E0", VA = "0x1823E44E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028901")]
			[Address(RVA = "0x23E4FF0", Offset = "0x23E3BF0", VA = "0x1823E4FF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FA2 RID: 24482
		// (get) Token: 0x06028902 RID: 166146 RVA: 0x000D21F8 File Offset: 0x000D03F8
		// (set) Token: 0x06028903 RID: 166147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FA2")]
		public ActMultiV3MatchStatus matchStatus
		{
			[Token(Token = "0x6028902")]
			[Address(RVA = "0x23E49E0", Offset = "0x23E35E0", VA = "0x1823E49E0")]
			[CompilerGenerated]
			get
			{
				return ActMultiV3MatchStatus.NONE;
			}
			[Token(Token = "0x6028903")]
			[Address(RVA = "0x23E53A0", Offset = "0x23E3FA0", VA = "0x1823E53A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FA3 RID: 24483
		// (get) Token: 0x06028904 RID: 166148 RVA: 0x000D2210 File Offset: 0x000D0410
		// (set) Token: 0x06028905 RID: 166149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FA3")]
		public ActMultiV3MatchResult matchResult
		{
			[Token(Token = "0x6028904")]
			[Address(RVA = "0x23E4920", Offset = "0x23E3520", VA = "0x1823E4920")]
			[CompilerGenerated]
			get
			{
				return ActMultiV3MatchResult.NONE;
			}
			[Token(Token = "0x6028905")]
			[Address(RVA = "0x23E52C0", Offset = "0x23E3EC0", VA = "0x1823E52C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FA4 RID: 24484
		// (get) Token: 0x06028906 RID: 166150 RVA: 0x000D2228 File Offset: 0x000D0428
		// (set) Token: 0x06028907 RID: 166151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FA4")]
		public ActMultiV3MatchPosType partnerPosType
		{
			[Token(Token = "0x6028906")]
			[Address(RVA = "0x23E4B00", Offset = "0x23E3700", VA = "0x1823E4B00")]
			[CompilerGenerated]
			get
			{
				return ActMultiV3MatchPosType.NORMAL;
			}
			[Token(Token = "0x6028907")]
			[Address(RVA = "0x23E5490", Offset = "0x23E4090", VA = "0x1823E5490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FA5 RID: 24485
		// (get) Token: 0x06028908 RID: 166152 RVA: 0x000D2240 File Offset: 0x000D0440
		// (set) Token: 0x06028909 RID: 166153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FA5")]
		public bool isPosListShow
		{
			[Token(Token = "0x6028908")]
			[Address(RVA = "0x23E4860", Offset = "0x23E3460", VA = "0x1823E4860")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028909")]
			[Address(RVA = "0x23E51D0", Offset = "0x23E3DD0", VA = "0x1823E51D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005FA6 RID: 24486
		// (get) Token: 0x0602890A RID: 166154 RVA: 0x000D2258 File Offset: 0x000D0458
		// (set) Token: 0x0602890B RID: 166155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FA6")]
		public ActMultiV3MatchPosType currPosType
		{
			[Token(Token = "0x602890A")]
			[Address(RVA = "0x23E4480", Offset = "0x23E3080", VA = "0x1823E4480")]
			[CompilerGenerated]
			get
			{
				return ActMultiV3MatchPosType.NORMAL;
			}
			[Token(Token = "0x602890B")]
			[Address(RVA = "0x23E4F80", Offset = "0x23E3B80", VA = "0x1823E4F80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FA7 RID: 24487
		// (get) Token: 0x0602890C RID: 166156 RVA: 0x000D2270 File Offset: 0x000D0470
		// (set) Token: 0x0602890D RID: 166157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FA7")]
		public int tipSwitchTime
		{
			[Token(Token = "0x602890C")]
			[Address(RVA = "0x23E4C20", Offset = "0x23E3820", VA = "0x1823E4C20")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x602890D")]
			[Address(RVA = "0x23E5580", Offset = "0x23E4180", VA = "0x1823E5580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FA8 RID: 24488
		// (get) Token: 0x0602890E RID: 166158 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602890F RID: 166159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FA8")]
		public string trainingStageConfirmDesc
		{
			[Token(Token = "0x602890E")]
			[Address(RVA = "0x23E4CE0", Offset = "0x23E38E0", VA = "0x1823E4CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602890F")]
			[Address(RVA = "0x23E5670", Offset = "0x23E4270", VA = "0x1823E5670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FA9 RID: 24489
		// (get) Token: 0x06028910 RID: 166160 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028911 RID: 166161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FA9")]
		public string trainingLockToastStr
		{
			[Token(Token = "0x6028910")]
			[Address(RVA = "0x23E4C80", Offset = "0x23E3880", VA = "0x1823E4C80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028911")]
			[Address(RVA = "0x23E55F0", Offset = "0x23E41F0", VA = "0x1823E55F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FAA RID: 24490
		// (get) Token: 0x06028912 RID: 166162 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028913 RID: 166163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FAA")]
		public string nothingSelectToastStr
		{
			[Token(Token = "0x6028912")]
			[Address(RVA = "0x23E4AA0", Offset = "0x23E36A0", VA = "0x1823E4AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028913")]
			[Address(RVA = "0x23E5410", Offset = "0x23E4010", VA = "0x1823E5410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FAB RID: 24491
		// (get) Token: 0x06028914 RID: 166164 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028915 RID: 166165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FAB")]
		public string continuousClickToastStr
		{
			[Token(Token = "0x6028914")]
			[Address(RVA = "0x23E4420", Offset = "0x23E3020", VA = "0x1823E4420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028915")]
			[Address(RVA = "0x23E4F00", Offset = "0x23E3B00", VA = "0x1823E4F00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FAC RID: 24492
		// (get) Token: 0x06028916 RID: 166166 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028917 RID: 166167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FAC")]
		public string bannedToastStr
		{
			[Token(Token = "0x6028916")]
			[Address(RVA = "0x23E43C0", Offset = "0x23E2FC0", VA = "0x1823E43C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028917")]
			[Address(RVA = "0x23E4E80", Offset = "0x23E3A80", VA = "0x1823E4E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FAD RID: 24493
		// (get) Token: 0x06028918 RID: 166168 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028919 RID: 166169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FAD")]
		public string serverOverloadToastStr
		{
			[Token(Token = "0x6028918")]
			[Address(RVA = "0x23E4BC0", Offset = "0x23E37C0", VA = "0x1823E4BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028919")]
			[Address(RVA = "0x23E5500", Offset = "0x23E4100", VA = "0x1823E5500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FAE RID: 24494
		// (get) Token: 0x0602891A RID: 166170 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602891B RID: 166171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FAE")]
		public string inverseDescStr
		{
			[Token(Token = "0x602891A")]
			[Address(RVA = "0x23E4540", Offset = "0x23E3140", VA = "0x1823E4540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602891B")]
			[Address(RVA = "0x23E5060", Offset = "0x23E3C60", VA = "0x1823E5060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FAF RID: 24495
		// (get) Token: 0x0602891C RID: 166172 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602891D RID: 166173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FAF")]
		public string inverseUnlockHintToastStr
		{
			[Token(Token = "0x602891C")]
			[Address(RVA = "0x23E45A0", Offset = "0x23E31A0", VA = "0x1823E45A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602891D")]
			[Address(RVA = "0x23E50E0", Offset = "0x23E3CE0", VA = "0x1823E50E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FB0 RID: 24496
		// (get) Token: 0x0602891E RID: 166174 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602891F RID: 166175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FB0")]
		public string matchConnectFailedToastStr
		{
			[Token(Token = "0x602891E")]
			[Address(RVA = "0x23E48C0", Offset = "0x23E34C0", VA = "0x1823E48C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602891F")]
			[Address(RVA = "0x23E5240", Offset = "0x23E3E40", VA = "0x1823E5240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FB1 RID: 24497
		// (get) Token: 0x06028920 RID: 166176 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028921 RID: 166177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FB1")]
		public string actId
		{
			[Token(Token = "0x6028920")]
			[Address(RVA = "0x23E4360", Offset = "0x23E2F60", VA = "0x1823E4360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028921")]
			[Address(RVA = "0x23E4E00", Offset = "0x23E3A00", VA = "0x1823E4E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FB2 RID: 24498
		// (get) Token: 0x06028922 RID: 166178 RVA: 0x000D2288 File Offset: 0x000D0488
		[Token(Token = "0x17005FB2")]
		public bool isInverseActive
		{
			[Token(Token = "0x6028922")]
			[Address(RVA = "0x23E4600", Offset = "0x23E3200", VA = "0x1823E4600")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005FB3 RID: 24499
		// (get) Token: 0x06028923 RID: 166179 RVA: 0x000D22A0 File Offset: 0x000D04A0
		[Token(Token = "0x17005FB3")]
		public bool isInverseUnlock
		{
			[Token(Token = "0x6028923")]
			[Address(RVA = "0x23E4660", Offset = "0x23E3260", VA = "0x1823E4660")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005FB4 RID: 24500
		// (get) Token: 0x06028924 RID: 166180 RVA: 0x000D22B8 File Offset: 0x000D04B8
		[Token(Token = "0x17005FB4")]
		public bool isMatching
		{
			[Token(Token = "0x6028924")]
			[Address(RVA = "0x23E47B0", Offset = "0x23E33B0", VA = "0x1823E47B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005FB5 RID: 24501
		// (get) Token: 0x06028925 RID: 166181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005FB5")]
		public List<ActMultiV3MatchModeGroupModel> modeGroupList
		{
			[Token(Token = "0x6028925")]
			[Address(RVA = "0x23E4A40", Offset = "0x23E3640", VA = "0x1823E4A40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005FB6 RID: 24502
		// (get) Token: 0x06028926 RID: 166182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005FB6")]
		public List<ActMultiV3MatchPosModel> posList
		{
			[Token(Token = "0x6028926")]
			[Address(RVA = "0x23E4B60", Offset = "0x23E3760", VA = "0x1823E4B60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005FB7 RID: 24503
		// (get) Token: 0x06028927 RID: 166183 RVA: 0x000D22D0 File Offset: 0x000D04D0
		[Token(Token = "0x17005FB7")]
		public bool isMatchBanned
		{
			[Token(Token = "0x6028927")]
			[Address(RVA = "0x23E46C0", Offset = "0x23E32C0", VA = "0x1823E46C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005FB8 RID: 24504
		// (get) Token: 0x06028928 RID: 166184 RVA: 0x000D22E8 File Offset: 0x000D04E8
		[Token(Token = "0x17005FB8")]
		public int waitSeconds
		{
			[Token(Token = "0x6028928")]
			[Address(RVA = "0x23E4D40", Offset = "0x23E3940", VA = "0x1823E4D40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06028929 RID: 166185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028929")]
		[Address(RVA = "0x23E0E10", Offset = "0x23DFA10", VA = "0x1823E0E10")]
		public ActMultiV3StartMatchRequest.Option CreateStartMatchOption()
		{
			return null;
		}

		// Token: 0x0602892A RID: 166186 RVA: 0x000D2300 File Offset: 0x000D0500
		[Token(Token = "0x602892A")]
		[Address(RVA = "0x23E0AC0", Offset = "0x23DF6C0", VA = "0x1823E0AC0")]
		public bool CheckModeGroupSelect(ActMultiV3MapModeType modeType)
		{
			return default(bool);
		}

		// Token: 0x0602892B RID: 166187 RVA: 0x000D2318 File Offset: 0x000D0518
		[Token(Token = "0x602892B")]
		[Address(RVA = "0x23E0C20", Offset = "0x23DF820", VA = "0x1823E0C20")]
		public bool CheckModeSelect(string modeId)
		{
			return default(bool);
		}

		// Token: 0x0602892C RID: 166188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602892C")]
		[Address(RVA = "0x23E2450", Offset = "0x23E1050", VA = "0x1823E2450")]
		public void ToggleModeSelect(string modeId)
		{
		}

		// Token: 0x0602892D RID: 166189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602892D")]
		[Address(RVA = "0x23E23F0", Offset = "0x23E0FF0", VA = "0x1823E23F0")]
		public void ToggleInverse()
		{
		}

		// Token: 0x0602892E RID: 166190 RVA: 0x000D2330 File Offset: 0x000D0530
		[Token(Token = "0x602892E")]
		[Address(RVA = "0x23E15A0", Offset = "0x23E01A0", VA = "0x1823E15A0")]
		public int GetSelectCount()
		{
			return 0;
		}

		// Token: 0x0602892F RID: 166191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602892F")]
		[Address(RVA = "0x23E1180", Offset = "0x23DFD80", VA = "0x1823E1180")]
		public ActMultiV3MatchPosModel FindCurrMatchPosModel()
		{
			return null;
		}

		// Token: 0x06028930 RID: 166192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028930")]
		[Address(RVA = "0x23E1240", Offset = "0x23DFE40", VA = "0x1823E1240")]
		public ActMultiV3MatchPosModel FindMatchPosModel(ActMultiV3MatchPosType posType)
		{
			return null;
		}

		// Token: 0x06028931 RID: 166193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028931")]
		[Address(RVA = "0x23E2370", Offset = "0x23E0F70", VA = "0x1823E2370")]
		public void SetPosType(ActMultiV3MatchPosType posType)
		{
		}

		// Token: 0x06028932 RID: 166194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028932")]
		[Address(RVA = "0x23E2850", Offset = "0x23E1450", VA = "0x1823E2850")]
		private ActMultiV3MatchPosModel _FindMatchPosModel(ActMultiV3MatchPosType posType)
		{
			return null;
		}

		// Token: 0x06028933 RID: 166195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028933")]
		[Address(RVA = "0x23E1610", Offset = "0x23E0210", VA = "0x1823E1610")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x06028934 RID: 166196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028934")]
		[Address(RVA = "0x23E38C0", Offset = "0x23E24C0", VA = "0x1823E38C0")]
		private void _InitTipList(string actId, ActMultiV3Data actData)
		{
		}

		// Token: 0x06028935 RID: 166197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028935")]
		[Address(RVA = "0x23E1020", Offset = "0x23DFC20", VA = "0x1823E1020")]
		public string FetchRandomTip()
		{
			return null;
		}

		// Token: 0x06028936 RID: 166198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028936")]
		[Address(RVA = "0x23E32A0", Offset = "0x23E1EA0", VA = "0x1823E32A0")]
		private void _InitMatchPosList(string actId, ActMultiV3Data actData)
		{
		}

		// Token: 0x06028937 RID: 166199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028937")]
		[Address(RVA = "0x23E35C0", Offset = "0x23E21C0", VA = "0x1823E35C0")]
		private void _InitModeGroupList(string actId, ActMultiV3Data actData)
		{
		}

		// Token: 0x06028938 RID: 166200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028938")]
		[Address(RVA = "0x23E26B0", Offset = "0x23E12B0", VA = "0x1823E26B0")]
		public void UpdateBanTime()
		{
		}

		// Token: 0x06028939 RID: 166201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028939")]
		[Address(RVA = "0x23E2180", Offset = "0x23E0D80", VA = "0x1823E2180")]
		public void MarkStartMatch()
		{
		}

		// Token: 0x0602893A RID: 166202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602893A")]
		[Address(RVA = "0x23E2110", Offset = "0x23E0D10", VA = "0x1823E2110")]
		public void MarkMatchTick(float waitSec)
		{
		}

		// Token: 0x0602893B RID: 166203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602893B")]
		[Address(RVA = "0x23E1EE0", Offset = "0x23E0AE0", VA = "0x1823E1EE0")]
		public void MarkEndMatch(ActMultiV3MatchResult result)
		{
		}

		// Token: 0x0602893C RID: 166204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602893C")]
		[Address(RVA = "0x23E22D0", Offset = "0x23E0ED0", VA = "0x1823E22D0")]
		public void SetPartnerPos(ActMultiV3MatchPosType posType)
		{
		}

		// Token: 0x0602893D RID: 166205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602893D")]
		[Address(RVA = "0x23E2010", Offset = "0x23E0C10", VA = "0x1823E2010")]
		public void MarkEnter()
		{
		}

		// Token: 0x0602893E RID: 166206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602893E")]
		[Address(RVA = "0x23E3B40", Offset = "0x23E2740", VA = "0x1823E3B40")]
		private void _UpdateBanTime()
		{
		}

		// Token: 0x0602893F RID: 166207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602893F")]
		[Address(RVA = "0x23E12C0", Offset = "0x23DFEC0", VA = "0x1823E12C0")]
		public ActMultiV3MatchModeDiffModel FindModeDiffModel(string modeId)
		{
			return null;
		}

		// Token: 0x06028940 RID: 166208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028940")]
		[Address(RVA = "0x23E1520", Offset = "0x23E0120", VA = "0x1823E1520")]
		public ActMultiV3MatchModeGroupModel FindModeGroupModel(ActMultiV3MapModeType modeType)
		{
			return null;
		}

		// Token: 0x06028941 RID: 166209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028941")]
		[Address(RVA = "0x23E1460", Offset = "0x23E0060", VA = "0x1823E1460")]
		public ActMultiV3MatchModeDiffModel FindModeDiffModel(ActMultiV3MapModeType modeType, ActMultiV3MapDiffType diffType)
		{
			return null;
		}

		// Token: 0x06028942 RID: 166210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028942")]
		[Address(RVA = "0x23E0D40", Offset = "0x23DF940", VA = "0x1823E0D40")]
		public void ConsumeSelectModeTrack()
		{
		}

		// Token: 0x06028943 RID: 166211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028943")]
		[Address(RVA = "0x23E0CC0", Offset = "0x23DF8C0", VA = "0x1823E0CC0")]
		public void ConsumeModeTrack(string modeId)
		{
		}

		// Token: 0x06028944 RID: 166212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028944")]
		[Address(RVA = "0x23E2710", Offset = "0x23E1310", VA = "0x1823E2710")]
		private void _ConsumeModeTrack(string modeId)
		{
		}

		// Token: 0x06028945 RID: 166213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028945")]
		[Address(RVA = "0x23E29B0", Offset = "0x23E15B0", VA = "0x1823E29B0")]
		private ActMultiV3MatchModeGroupModel _FindModeGroupModel(ActMultiV3MapModeType modeType)
		{
			return null;
		}

		// Token: 0x06028946 RID: 166214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028946")]
		[Address(RVA = "0x23E3FC0", Offset = "0x23E2BC0", VA = "0x1823E3FC0")]
		private void _UpdateModeDiffUnlockStatus()
		{
		}

		// Token: 0x06028947 RID: 166215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028947")]
		[Address(RVA = "0x23E3C10", Offset = "0x23E2810", VA = "0x1823E3C10")]
		private void _UpdateInverseUnlockStatus()
		{
		}

		// Token: 0x06028948 RID: 166216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028948")]
		[Address(RVA = "0x23E40A0", Offset = "0x23E2CA0", VA = "0x1823E40A0")]
		private void _UpdatePosUnlockStatus()
		{
		}

		// Token: 0x06028949 RID: 166217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028949")]
		[Address(RVA = "0x23E3DC0", Offset = "0x23E29C0", VA = "0x1823E3DC0")]
		private void _UpdateMapScore()
		{
		}

		// Token: 0x0602894A RID: 166218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602894A")]
		[Address(RVA = "0x23E3120", Offset = "0x23E1D20", VA = "0x1823E3120")]
		private void _InitMatchConfig(ActMultiV3Data actData)
		{
		}

		// Token: 0x0602894B RID: 166219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602894B")]
		[Address(RVA = "0x23E2ED0", Offset = "0x23E1AD0", VA = "0x1823E2ED0")]
		private void _InitMatchConfigUsingPlayerData(PlayerActivity.PlayerMultiV3Activity.MatchInfo playerMatchInfo)
		{
		}

		// Token: 0x0602894C RID: 166220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602894C")]
		[Address(RVA = "0x23E2B10", Offset = "0x23E1710", VA = "0x1823E2B10")]
		private void _InitMatchConfigUsingGameData(ActMultiV3Data actData)
		{
		}

		// Token: 0x0602894D RID: 166221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602894D")]
		[Address(RVA = "0x23E4180", Offset = "0x23E2D80", VA = "0x1823E4180")]
		public ActMultiV3QuickMatchModel()
		{
		}

		// Token: 0x04039C53 RID: 236627
		[Token(Token = "0x4039C53")]
		[FieldOffset(Offset = "0x10")]
		private List<ActMultiV3MatchPosModel> m_posList;

		// Token: 0x04039C54 RID: 236628
		[Token(Token = "0x4039C54")]
		[FieldOffset(Offset = "0x18")]
		private List<ActMultiV3MatchModeGroupModel> m_modeGroupList;

		// Token: 0x04039C55 RID: 236629
		[Token(Token = "0x4039C55")]
		[FieldOffset(Offset = "0x20")]
		private ActMultiV3InverseUnlockCond m_inverseUnlockCond;

		// Token: 0x04039C56 RID: 236630
		[Token(Token = "0x4039C56")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInverseUnlock;

		// Token: 0x04039C57 RID: 236631
		[Token(Token = "0x4039C57")]
		[FieldOffset(Offset = "0x29")]
		private bool m_isInverseActive;

		// Token: 0x04039C58 RID: 236632
		[Token(Token = "0x4039C58")]
		[FieldOffset(Offset = "0x30")]
		private long m_banFinishTs;

		// Token: 0x04039C59 RID: 236633
		[Token(Token = "0x4039C59")]
		[FieldOffset(Offset = "0x38")]
		private float m_matchingSecs;

		// Token: 0x04039C5A RID: 236634
		[Token(Token = "0x4039C5A")]
		[FieldOffset(Offset = "0x40")]
		private List<string> m_selectList;

		// Token: 0x04039C5B RID: 236635
		[Token(Token = "0x4039C5B")]
		[FieldOffset(Offset = "0x48")]
		private List<ActMultiV3MatchTipModel> m_allTipList;

		// Token: 0x04039C5C RID: 236636
		[Token(Token = "0x4039C5C")]
		[FieldOffset(Offset = "0x50")]
		private List<ActMultiV3MatchTipModel> m_drawTipList;

		// Token: 0x04039C70 RID: 236656
		[Token(Token = "0x4039C70")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isMatchUnlock;

		// Token: 0x04039C71 RID: 236657
		[Token(Token = "0x4039C71")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isMatchUnlock;

		// Token: 0x04039C72 RID: 236658
		[Token(Token = "0x4039C72")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_matchStatusSeqNum;

		// Token: 0x04039C73 RID: 236659
		[Token(Token = "0x4039C73")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_matchStatusSeqNum;

		// Token: 0x04039C74 RID: 236660
		[Token(Token = "0x4039C74")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_enterSeqNum;

		// Token: 0x04039C75 RID: 236661
		[Token(Token = "0x4039C75")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_enterSeqNum;

		// Token: 0x04039C76 RID: 236662
		[Token(Token = "0x4039C76")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_matchStatus;

		// Token: 0x04039C77 RID: 236663
		[Token(Token = "0x4039C77")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_matchStatus;

		// Token: 0x04039C78 RID: 236664
		[Token(Token = "0x4039C78")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_matchResult;

		// Token: 0x04039C79 RID: 236665
		[Token(Token = "0x4039C79")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_matchResult;

		// Token: 0x04039C7A RID: 236666
		[Token(Token = "0x4039C7A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_partnerPosType;

		// Token: 0x04039C7B RID: 236667
		[Token(Token = "0x4039C7B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_partnerPosType;

		// Token: 0x04039C7C RID: 236668
		[Token(Token = "0x4039C7C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_isPosListShow;

		// Token: 0x04039C7D RID: 236669
		[Token(Token = "0x4039C7D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_isPosListShow;

		// Token: 0x04039C7E RID: 236670
		[Token(Token = "0x4039C7E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_currPosType;

		// Token: 0x04039C7F RID: 236671
		[Token(Token = "0x4039C7F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_currPosType;

		// Token: 0x04039C80 RID: 236672
		[Token(Token = "0x4039C80")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_tipSwitchTime;

		// Token: 0x04039C81 RID: 236673
		[Token(Token = "0x4039C81")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_tipSwitchTime;

		// Token: 0x04039C82 RID: 236674
		[Token(Token = "0x4039C82")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_trainingStageConfirmDesc;

		// Token: 0x04039C83 RID: 236675
		[Token(Token = "0x4039C83")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_set_trainingStageConfirmDesc;

		// Token: 0x04039C84 RID: 236676
		[Token(Token = "0x4039C84")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_trainingLockToastStr;

		// Token: 0x04039C85 RID: 236677
		[Token(Token = "0x4039C85")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_set_trainingLockToastStr;

		// Token: 0x04039C86 RID: 236678
		[Token(Token = "0x4039C86")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_nothingSelectToastStr;

		// Token: 0x04039C87 RID: 236679
		[Token(Token = "0x4039C87")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_set_nothingSelectToastStr;

		// Token: 0x04039C88 RID: 236680
		[Token(Token = "0x4039C88")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_continuousClickToastStr;

		// Token: 0x04039C89 RID: 236681
		[Token(Token = "0x4039C89")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_set_continuousClickToastStr;

		// Token: 0x04039C8A RID: 236682
		[Token(Token = "0x4039C8A")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_bannedToastStr;

		// Token: 0x04039C8B RID: 236683
		[Token(Token = "0x4039C8B")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_set_bannedToastStr;

		// Token: 0x04039C8C RID: 236684
		[Token(Token = "0x4039C8C")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_serverOverloadToastStr;

		// Token: 0x04039C8D RID: 236685
		[Token(Token = "0x4039C8D")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_set_serverOverloadToastStr;

		// Token: 0x04039C8E RID: 236686
		[Token(Token = "0x4039C8E")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_inverseDescStr;

		// Token: 0x04039C8F RID: 236687
		[Token(Token = "0x4039C8F")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_set_inverseDescStr;

		// Token: 0x04039C90 RID: 236688
		[Token(Token = "0x4039C90")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_inverseUnlockHintToastStr;

		// Token: 0x04039C91 RID: 236689
		[Token(Token = "0x4039C91")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_set_inverseUnlockHintToastStr;

		// Token: 0x04039C92 RID: 236690
		[Token(Token = "0x4039C92")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_get_matchConnectFailedToastStr;

		// Token: 0x04039C93 RID: 236691
		[Token(Token = "0x4039C93")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_set_matchConnectFailedToastStr;

		// Token: 0x04039C94 RID: 236692
		[Token(Token = "0x4039C94")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x04039C95 RID: 236693
		[Token(Token = "0x4039C95")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x04039C96 RID: 236694
		[Token(Token = "0x4039C96")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_get_isInverseActive;

		// Token: 0x04039C97 RID: 236695
		[Token(Token = "0x4039C97")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_get_isInverseUnlock;

		// Token: 0x04039C98 RID: 236696
		[Token(Token = "0x4039C98")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_get_isMatching;

		// Token: 0x04039C99 RID: 236697
		[Token(Token = "0x4039C99")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_get_modeGroupList;

		// Token: 0x04039C9A RID: 236698
		[Token(Token = "0x4039C9A")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_get_posList;

		// Token: 0x04039C9B RID: 236699
		[Token(Token = "0x4039C9B")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_get_isMatchBanned;

		// Token: 0x04039C9C RID: 236700
		[Token(Token = "0x4039C9C")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_get_waitSeconds;

		// Token: 0x04039C9D RID: 236701
		[Token(Token = "0x4039C9D")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_CreateStartMatchOption;

		// Token: 0x04039C9E RID: 236702
		[Token(Token = "0x4039C9E")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_CheckModeGroupSelect;

		// Token: 0x04039C9F RID: 236703
		[Token(Token = "0x4039C9F")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_CheckModeSelect;

		// Token: 0x04039CA0 RID: 236704
		[Token(Token = "0x4039CA0")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_ToggleModeSelect;

		// Token: 0x04039CA1 RID: 236705
		[Token(Token = "0x4039CA1")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_ToggleInverse;

		// Token: 0x04039CA2 RID: 236706
		[Token(Token = "0x4039CA2")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_GetSelectCount;

		// Token: 0x04039CA3 RID: 236707
		[Token(Token = "0x4039CA3")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_FindCurrMatchPosModel;

		// Token: 0x04039CA4 RID: 236708
		[Token(Token = "0x4039CA4")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_FindMatchPosModel;

		// Token: 0x04039CA5 RID: 236709
		[Token(Token = "0x4039CA5")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_SetPosType;

		// Token: 0x04039CA6 RID: 236710
		[Token(Token = "0x4039CA6")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__FindMatchPosModel;

		// Token: 0x04039CA7 RID: 236711
		[Token(Token = "0x4039CA7")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04039CA8 RID: 236712
		[Token(Token = "0x4039CA8")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__InitTipList;

		// Token: 0x04039CA9 RID: 236713
		[Token(Token = "0x4039CA9")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_FetchRandomTip;

		// Token: 0x04039CAA RID: 236714
		[Token(Token = "0x4039CAA")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0__InitMatchPosList;

		// Token: 0x04039CAB RID: 236715
		[Token(Token = "0x4039CAB")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0__InitModeGroupList;

		// Token: 0x04039CAC RID: 236716
		[Token(Token = "0x4039CAC")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_UpdateBanTime;

		// Token: 0x04039CAD RID: 236717
		[Token(Token = "0x4039CAD")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_MarkStartMatch;

		// Token: 0x04039CAE RID: 236718
		[Token(Token = "0x4039CAE")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_MarkMatchTick;

		// Token: 0x04039CAF RID: 236719
		[Token(Token = "0x4039CAF")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_MarkEndMatch;

		// Token: 0x04039CB0 RID: 236720
		[Token(Token = "0x4039CB0")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_SetPartnerPos;

		// Token: 0x04039CB1 RID: 236721
		[Token(Token = "0x4039CB1")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_MarkEnter;

		// Token: 0x04039CB2 RID: 236722
		[Token(Token = "0x4039CB2")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0__UpdateBanTime;

		// Token: 0x04039CB3 RID: 236723
		[Token(Token = "0x4039CB3")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_FindModeDiffModel;

		// Token: 0x04039CB4 RID: 236724
		[Token(Token = "0x4039CB4")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_FindModeGroupModel;

		// Token: 0x04039CB5 RID: 236725
		[Token(Token = "0x4039CB5")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix1_FindModeDiffModel;

		// Token: 0x04039CB6 RID: 236726
		[Token(Token = "0x4039CB6")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_ConsumeSelectModeTrack;

		// Token: 0x04039CB7 RID: 236727
		[Token(Token = "0x4039CB7")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_ConsumeModeTrack;

		// Token: 0x04039CB8 RID: 236728
		[Token(Token = "0x4039CB8")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0__ConsumeModeTrack;

		// Token: 0x04039CB9 RID: 236729
		[Token(Token = "0x4039CB9")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0__FindModeGroupModel;

		// Token: 0x04039CBA RID: 236730
		[Token(Token = "0x4039CBA")]
		[FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0__UpdateModeDiffUnlockStatus;

		// Token: 0x04039CBB RID: 236731
		[Token(Token = "0x4039CBB")]
		[FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0__UpdateInverseUnlockStatus;

		// Token: 0x04039CBC RID: 236732
		[Token(Token = "0x4039CBC")]
		[FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0__UpdatePosUnlockStatus;

		// Token: 0x04039CBD RID: 236733
		[Token(Token = "0x4039CBD")]
		[FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0__UpdateMapScore;

		// Token: 0x04039CBE RID: 236734
		[Token(Token = "0x4039CBE")]
		[FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0__InitMatchConfig;

		// Token: 0x04039CBF RID: 236735
		[Token(Token = "0x4039CBF")]
		[FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0__InitMatchConfigUsingPlayerData;

		// Token: 0x04039CC0 RID: 236736
		[Token(Token = "0x4039CC0")]
		[FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0__InitMatchConfigUsingGameData;

		// Token: 0x04039CC1 RID: 236737
		[Token(Token = "0x4039CC1")]
		[FieldOffset(Offset = "0x288")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
