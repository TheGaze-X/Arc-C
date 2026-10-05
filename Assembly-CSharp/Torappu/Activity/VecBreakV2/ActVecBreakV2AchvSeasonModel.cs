using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Medal;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DC3 RID: 28099
	[Token(Token = "0x2006DC3")]
	public class ActVecBreakV2AchvSeasonModel : IHotfixable
	{
		// Token: 0x17005E8C RID: 24204
		// (get) Token: 0x06028016 RID: 163862 RVA: 0x000D0530 File Offset: 0x000CE730
		// (set) Token: 0x06028017 RID: 163863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005E8C")]
		public bool hasRecrod
		{
			[Token(Token = "0x6028016")]
			[Address(RVA = "0x23489C0", Offset = "0x23475C0", VA = "0x1823489C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028017")]
			[Address(RVA = "0x2348F50", Offset = "0x2347B50", VA = "0x182348F50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005E8D RID: 24205
		// (get) Token: 0x06028018 RID: 163864 RVA: 0x000D0548 File Offset: 0x000CE748
		// (set) Token: 0x06028019 RID: 163865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005E8D")]
		public int bestLv
		{
			[Token(Token = "0x6028018")]
			[Address(RVA = "0x2348780", Offset = "0x2347380", VA = "0x182348780")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028019")]
			[Address(RVA = "0x2348DE0", Offset = "0x23479E0", VA = "0x182348DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005E8E RID: 24206
		// (get) Token: 0x0602801A RID: 163866 RVA: 0x000D0560 File Offset: 0x000CE760
		// (set) Token: 0x0602801B RID: 163867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005E8E")]
		public long recordTs
		{
			[Token(Token = "0x602801A")]
			[Address(RVA = "0x2348B70", Offset = "0x2347770", VA = "0x182348B70")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x602801B")]
			[Address(RVA = "0x2349040", Offset = "0x2347C40", VA = "0x182349040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005E8F RID: 24207
		// (get) Token: 0x0602801C RID: 163868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E8F")]
		public string actId
		{
			[Token(Token = "0x602801C")]
			[Address(RVA = "0x2348720", Offset = "0x2347320", VA = "0x182348720")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005E90 RID: 24208
		// (get) Token: 0x0602801D RID: 163869 RVA: 0x000D0578 File Offset: 0x000CE778
		// (set) Token: 0x0602801E RID: 163870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005E90")]
		public long startTs
		{
			[Token(Token = "0x602801D")]
			[Address(RVA = "0x2348CF0", Offset = "0x23478F0", VA = "0x182348CF0")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x602801E")]
			[Address(RVA = "0x2349120", Offset = "0x2347D20", VA = "0x182349120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005E91 RID: 24209
		// (get) Token: 0x0602801F RID: 163871 RVA: 0x000D0590 File Offset: 0x000CE790
		// (set) Token: 0x06028020 RID: 163872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005E91")]
		public int squadBuffMaxCnt
		{
			[Token(Token = "0x602801F")]
			[Address(RVA = "0x2348C30", Offset = "0x2347830", VA = "0x182348C30")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028020")]
			[Address(RVA = "0x23490B0", Offset = "0x2347CB0", VA = "0x1823490B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005E92 RID: 24210
		// (get) Token: 0x06028021 RID: 163873 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028022 RID: 163874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005E92")]
		public string offenseZoneName
		{
			[Token(Token = "0x6028021")]
			[Address(RVA = "0x2348B10", Offset = "0x2347710", VA = "0x182348B10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028022")]
			[Address(RVA = "0x2348FC0", Offset = "0x2347BC0", VA = "0x182348FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005E93 RID: 24211
		// (get) Token: 0x06028023 RID: 163875 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028024 RID: 163876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005E93")]
		public string hardZoneName
		{
			[Token(Token = "0x6028023")]
			[Address(RVA = "0x2348960", Offset = "0x2347560", VA = "0x182348960")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028024")]
			[Address(RVA = "0x2348ED0", Offset = "0x2347AD0", VA = "0x182348ED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005E94 RID: 24212
		// (get) Token: 0x06028025 RID: 163877 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028026 RID: 163878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005E94")]
		public string defenseZoneName
		{
			[Token(Token = "0x6028025")]
			[Address(RVA = "0x2348840", Offset = "0x2347440", VA = "0x182348840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028026")]
			[Address(RVA = "0x2348E50", Offset = "0x2347A50", VA = "0x182348E50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005E95 RID: 24213
		// (get) Token: 0x06028027 RID: 163879 RVA: 0x000D05A8 File Offset: 0x000CE7A8
		// (set) Token: 0x06028028 RID: 163880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005E95")]
		public Color themeColor
		{
			[Token(Token = "0x6028027")]
			[Address(RVA = "0x2348D50", Offset = "0x2347950", VA = "0x182348D50")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6028028")]
			[Address(RVA = "0x2349190", Offset = "0x2347D90", VA = "0x182349190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005E96 RID: 24214
		// (get) Token: 0x06028029 RID: 163881 RVA: 0x000D05C0 File Offset: 0x000CE7C0
		[Token(Token = "0x17005E96")]
		public bool isHardZoneOpen
		{
			[Token(Token = "0x6028029")]
			[Address(RVA = "0x2348A20", Offset = "0x2347620", VA = "0x182348A20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005E97 RID: 24215
		// (get) Token: 0x0602802A RID: 163882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E97")]
		public List<ActVecBreakV2AchvDefenseBuffModel> defenseBuffList
		{
			[Token(Token = "0x602802A")]
			[Address(RVA = "0x23487E0", Offset = "0x23473E0", VA = "0x1823487E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005E98 RID: 24216
		// (get) Token: 0x0602802B RID: 163883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E98")]
		public List<ActVecBreakV2AchvHardStageModel> hardStageList
		{
			[Token(Token = "0x602802B")]
			[Address(RVA = "0x2348900", Offset = "0x2347500", VA = "0x182348900")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005E99 RID: 24217
		// (get) Token: 0x0602802C RID: 163884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E99")]
		public List<ActVecBreakV2AchvSquadBuffModel> squadBuffList
		{
			[Token(Token = "0x602802C")]
			[Address(RVA = "0x2348BD0", Offset = "0x23477D0", VA = "0x182348BD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005E9A RID: 24218
		// (get) Token: 0x0602802D RID: 163885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E9A")]
		public List<ActVecBreakV2AchvSquadCharModel> squadCharList
		{
			[Token(Token = "0x602802D")]
			[Address(RVA = "0x2348C90", Offset = "0x2347890", VA = "0x182348C90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005E9B RID: 24219
		// (get) Token: 0x0602802E RID: 163886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E9B")]
		public MedalGroupViewModel medalGroupModel
		{
			[Token(Token = "0x602802E")]
			[Address(RVA = "0x2348AB0", Offset = "0x23476B0", VA = "0x182348AB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005E9C RID: 24220
		// (get) Token: 0x0602802F RID: 163887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E9C")]
		public List<ActVecBreakV2AchvSquadItemModel> displayCharList
		{
			[Token(Token = "0x602802F")]
			[Address(RVA = "0x23488A0", Offset = "0x23474A0", VA = "0x1823488A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06028030 RID: 163888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028030")]
		[Address(RVA = "0x2346AE0", Offset = "0x23456E0", VA = "0x182346AE0")]
		public void LoadData(ActivityTable.BasicData basicInfo, VecBreakV2SeasonAchvInfo playerSeasonInfo, long currTs)
		{
		}

		// Token: 0x06028031 RID: 163889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028031")]
		[Address(RVA = "0x23474B0", Offset = "0x23460B0", VA = "0x1823474B0")]
		private string _GetZoneName(string zoneId)
		{
			return null;
		}

		// Token: 0x06028032 RID: 163890 RVA: 0x000D05D8 File Offset: 0x000CE7D8
		[Token(Token = "0x6028032")]
		[Address(RVA = "0x23471C0", Offset = "0x2345DC0", VA = "0x1823471C0")]
		public bool _CheckIsHardZoneTimeUnlock(string actId, long currTs)
		{
			return default(bool);
		}

		// Token: 0x06028033 RID: 163891 RVA: 0x000D05F0 File Offset: 0x000CE7F0
		[Token(Token = "0x6028033")]
		[Address(RVA = "0x23472F0", Offset = "0x2345EF0", VA = "0x1823472F0")]
		private int _FetchBestStageLv(ActVecBreakV2Data actData, VecBreakV2SeasonAchvInfo playerSeasonInfo)
		{
			return 0;
		}

		// Token: 0x06028034 RID: 163892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028034")]
		[Address(RVA = "0x2347C10", Offset = "0x2346810", VA = "0x182347C10")]
		private void _LoadHardStageList(ActVecBreakV2Data actData, VecBreakV2SeasonAchvInfo playerSeasonInfo)
		{
		}

		// Token: 0x06028035 RID: 163893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028035")]
		[Address(RVA = "0x23473E0", Offset = "0x2345FE0", VA = "0x1823473E0")]
		private VecBreakV2StageInfo _FindStageInfo(VecBreakV2SeasonAchvInfo playerSeasonInfo, string stageId)
		{
			return null;
		}

		// Token: 0x06028036 RID: 163894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028036")]
		[Address(RVA = "0x23479B0", Offset = "0x23465B0", VA = "0x1823479B0")]
		private void _LoadDisplayCharList()
		{
		}

		// Token: 0x06028037 RID: 163895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028037")]
		[Address(RVA = "0x2348260", Offset = "0x2346E60", VA = "0x182348260")]
		private void _LoadSquadCharList(ActVecBreakV2Data actData, VecBreakV2SeasonAchvInfo playerSeasonInfo)
		{
		}

		// Token: 0x06028038 RID: 163896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028038")]
		[Address(RVA = "0x2347FD0", Offset = "0x2346BD0", VA = "0x182347FD0")]
		private void _LoadSquadBuffList(ActVecBreakV2Data actData, VecBreakV2SeasonAchvInfo playerSeasonInfo)
		{
		}

		// Token: 0x06028039 RID: 163897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028039")]
		[Address(RVA = "0x23475A0", Offset = "0x23461A0", VA = "0x1823475A0")]
		private void _LoadDefenseBuffList(ActVecBreakV2Data actData, VecBreakV2SeasonAchvInfo playerSeasonInfo, long currTs)
		{
		}

		// Token: 0x0602803A RID: 163898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602803A")]
		[Address(RVA = "0x2348530", Offset = "0x2347130", VA = "0x182348530")]
		public ActVecBreakV2AchvSeasonModel()
		{
		}

		// Token: 0x04038B8B RID: 232331
		[Token(Token = "0x4038B8B")]
		[FieldOffset(Offset = "0x10")]
		private string m_actId;

		// Token: 0x04038B8C RID: 232332
		[Token(Token = "0x4038B8C")]
		[FieldOffset(Offset = "0x18")]
		private List<ActVecBreakV2AchvDefenseBuffModel> m_defenseBuffList;

		// Token: 0x04038B8D RID: 232333
		[Token(Token = "0x4038B8D")]
		[FieldOffset(Offset = "0x20")]
		private List<ActVecBreakV2AchvHardStageModel> m_hardStageList;

		// Token: 0x04038B8E RID: 232334
		[Token(Token = "0x4038B8E")]
		[FieldOffset(Offset = "0x28")]
		private List<ActVecBreakV2AchvSquadBuffModel> m_squadBuffList;

		// Token: 0x04038B8F RID: 232335
		[Token(Token = "0x4038B8F")]
		[FieldOffset(Offset = "0x30")]
		private List<ActVecBreakV2AchvSquadCharModel> m_squadCharList;

		// Token: 0x04038B90 RID: 232336
		[Token(Token = "0x4038B90")]
		[FieldOffset(Offset = "0x38")]
		private ActVecBreakV2AchvSquadCharModel m_assistCharModel;

		// Token: 0x04038B91 RID: 232337
		[Token(Token = "0x4038B91")]
		[FieldOffset(Offset = "0x40")]
		private List<ActVecBreakV2AchvSquadItemModel> m_displayCharList;

		// Token: 0x04038B92 RID: 232338
		[Token(Token = "0x4038B92")]
		[FieldOffset(Offset = "0x48")]
		private MedalGroupViewModel m_medalGroupModel;

		// Token: 0x04038B96 RID: 232342
		[Token(Token = "0x4038B96")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isHardZoneOpen;

		// Token: 0x04038B9D RID: 232349
		[Token(Token = "0x4038B9D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasRecrod;

		// Token: 0x04038B9E RID: 232350
		[Token(Token = "0x4038B9E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_hasRecrod;

		// Token: 0x04038B9F RID: 232351
		[Token(Token = "0x4038B9F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_bestLv;

		// Token: 0x04038BA0 RID: 232352
		[Token(Token = "0x4038BA0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_bestLv;

		// Token: 0x04038BA1 RID: 232353
		[Token(Token = "0x4038BA1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_recordTs;

		// Token: 0x04038BA2 RID: 232354
		[Token(Token = "0x4038BA2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_recordTs;

		// Token: 0x04038BA3 RID: 232355
		[Token(Token = "0x4038BA3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x04038BA4 RID: 232356
		[Token(Token = "0x4038BA4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_startTs;

		// Token: 0x04038BA5 RID: 232357
		[Token(Token = "0x4038BA5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_startTs;

		// Token: 0x04038BA6 RID: 232358
		[Token(Token = "0x4038BA6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_squadBuffMaxCnt;

		// Token: 0x04038BA7 RID: 232359
		[Token(Token = "0x4038BA7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_squadBuffMaxCnt;

		// Token: 0x04038BA8 RID: 232360
		[Token(Token = "0x4038BA8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_offenseZoneName;

		// Token: 0x04038BA9 RID: 232361
		[Token(Token = "0x4038BA9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_set_offenseZoneName;

		// Token: 0x04038BAA RID: 232362
		[Token(Token = "0x4038BAA")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_hardZoneName;

		// Token: 0x04038BAB RID: 232363
		[Token(Token = "0x4038BAB")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_hardZoneName;

		// Token: 0x04038BAC RID: 232364
		[Token(Token = "0x4038BAC")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_defenseZoneName;

		// Token: 0x04038BAD RID: 232365
		[Token(Token = "0x4038BAD")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_set_defenseZoneName;

		// Token: 0x04038BAE RID: 232366
		[Token(Token = "0x4038BAE")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_themeColor;

		// Token: 0x04038BAF RID: 232367
		[Token(Token = "0x4038BAF")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_set_themeColor;

		// Token: 0x04038BB0 RID: 232368
		[Token(Token = "0x4038BB0")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_isHardZoneOpen;

		// Token: 0x04038BB1 RID: 232369
		[Token(Token = "0x4038BB1")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_defenseBuffList;

		// Token: 0x04038BB2 RID: 232370
		[Token(Token = "0x4038BB2")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_hardStageList;

		// Token: 0x04038BB3 RID: 232371
		[Token(Token = "0x4038BB3")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_squadBuffList;

		// Token: 0x04038BB4 RID: 232372
		[Token(Token = "0x4038BB4")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_squadCharList;

		// Token: 0x04038BB5 RID: 232373
		[Token(Token = "0x4038BB5")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_medalGroupModel;

		// Token: 0x04038BB6 RID: 232374
		[Token(Token = "0x4038BB6")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_displayCharList;

		// Token: 0x04038BB7 RID: 232375
		[Token(Token = "0x4038BB7")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04038BB8 RID: 232376
		[Token(Token = "0x4038BB8")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__GetZoneName;

		// Token: 0x04038BB9 RID: 232377
		[Token(Token = "0x4038BB9")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__CheckIsHardZoneTimeUnlock;

		// Token: 0x04038BBA RID: 232378
		[Token(Token = "0x4038BBA")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__FetchBestStageLv;

		// Token: 0x04038BBB RID: 232379
		[Token(Token = "0x4038BBB")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__LoadHardStageList;

		// Token: 0x04038BBC RID: 232380
		[Token(Token = "0x4038BBC")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__FindStageInfo;

		// Token: 0x04038BBD RID: 232381
		[Token(Token = "0x4038BBD")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__LoadDisplayCharList;

		// Token: 0x04038BBE RID: 232382
		[Token(Token = "0x4038BBE")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__LoadSquadCharList;

		// Token: 0x04038BBF RID: 232383
		[Token(Token = "0x4038BBF")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__LoadSquadBuffList;

		// Token: 0x04038BC0 RID: 232384
		[Token(Token = "0x4038BC0")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__LoadDefenseBuffList;

		// Token: 0x04038BC1 RID: 232385
		[Token(Token = "0x4038BC1")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
