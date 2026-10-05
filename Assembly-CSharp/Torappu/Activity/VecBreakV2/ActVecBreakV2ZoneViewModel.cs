using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DFC RID: 28156
	[Token(Token = "0x2006DFC")]
	public class ActVecBreakV2ZoneViewModel : IHotfixable
	{
		// Token: 0x17005EC8 RID: 24264
		// (get) Token: 0x0602814D RID: 164173 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602814E RID: 164174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005EC8")]
		public string zoneName
		{
			[Token(Token = "0x602814D")]
			[Address(RVA = "0x235A6B0", Offset = "0x23592B0", VA = "0x18235A6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602814E")]
			[Address(RVA = "0x235A800", Offset = "0x2359400", VA = "0x18235A800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005EC9 RID: 24265
		// (get) Token: 0x0602814F RID: 164175 RVA: 0x000D0A10 File Offset: 0x000CEC10
		// (set) Token: 0x06028150 RID: 164176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005EC9")]
		public ActVecBreakV2ZoneViewModel.ZoneStatus status
		{
			[Token(Token = "0x602814F")]
			[Address(RVA = "0x235A650", Offset = "0x2359250", VA = "0x18235A650")]
			[CompilerGenerated]
			get
			{
				return ActVecBreakV2ZoneViewModel.ZoneStatus.NONE;
			}
			[Token(Token = "0x6028150")]
			[Address(RVA = "0x235A790", Offset = "0x2359390", VA = "0x18235A790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005ECA RID: 24266
		// (get) Token: 0x06028151 RID: 164177 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028152 RID: 164178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005ECA")]
		public string stageLockHint
		{
			[Token(Token = "0x6028151")]
			[Address(RVA = "0x235A580", Offset = "0x2359180", VA = "0x18235A580")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028152")]
			[Address(RVA = "0x235A710", Offset = "0x2359310", VA = "0x18235A710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005ECB RID: 24267
		// (get) Token: 0x06028153 RID: 164179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005ECB")]
		public List<ActVecBreakV2ZoneStageViewModel> stageList
		{
			[Token(Token = "0x6028153")]
			[Address(RVA = "0x235A520", Offset = "0x2359120", VA = "0x18235A520")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005ECC RID: 24268
		// (get) Token: 0x06028154 RID: 164180 RVA: 0x000D0A28 File Offset: 0x000CEC28
		[Token(Token = "0x17005ECC")]
		public long startTs
		{
			[Token(Token = "0x6028154")]
			[Address(RVA = "0x235A5E0", Offset = "0x23591E0", VA = "0x18235A5E0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06028155 RID: 164181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028155")]
		[Address(RVA = "0x235A470", Offset = "0x2359070", VA = "0x18235A470")]
		private ActVecBreakV2ZoneViewModel()
		{
		}

		// Token: 0x06028156 RID: 164182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028156")]
		[Address(RVA = "0x2359480", Offset = "0x2358080", VA = "0x182359480")]
		public static ActVecBreakV2ZoneViewModel Create(ActVecBreakV2Data actData, ActVecBreakV2ZoneType zoneType, long currTs)
		{
			return null;
		}

		// Token: 0x06028157 RID: 164183 RVA: 0x000D0A40 File Offset: 0x000CEC40
		[Token(Token = "0x6028157")]
		[Address(RVA = "0x2359330", Offset = "0x2357F30", VA = "0x182359330")]
		public int CalcCompleteStageCount()
		{
			return 0;
		}

		// Token: 0x06028158 RID: 164184 RVA: 0x000D0A58 File Offset: 0x000CEC58
		[Token(Token = "0x6028158")]
		[Address(RVA = "0x2359410", Offset = "0x2358010", VA = "0x182359410")]
		public int CalcTotalStageCount()
		{
			return 0;
		}

		// Token: 0x06028159 RID: 164185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028159")]
		[Address(RVA = "0x2359B90", Offset = "0x2358790", VA = "0x182359B90")]
		private static string _GetZoneIdByType(ActVecBreakV2Data actData, ActVecBreakV2ZoneType zoneType)
		{
			return null;
		}

		// Token: 0x0602815A RID: 164186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602815A")]
		[Address(RVA = "0x235A170", Offset = "0x2358D70", VA = "0x18235A170")]
		private void _LoadData(ActVecBreakV2Data actData, ActVecBreakV2ZoneData zoneData, ActVecBreakV2ZoneType zoneType, ZoneData basicData, ZoneValidInfo zoneValidInfo, long currTs)
		{
		}

		// Token: 0x0602815B RID: 164187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602815B")]
		[Address(RVA = "0x2359C40", Offset = "0x2358840", VA = "0x182359C40")]
		private void _InitStageList(ActVecBreakV2ZoneType zoneType, List<ActVecBreakV2ZoneStageViewModel> stageList)
		{
		}

		// Token: 0x0602815C RID: 164188 RVA: 0x000D0A70 File Offset: 0x000CEC70
		[Token(Token = "0x602815C")]
		[Address(RVA = "0x2359A30", Offset = "0x2358630", VA = "0x182359A30")]
		private ActVecBreakV2ZoneViewModel.ZoneStatus _CalcZoneStatus(long currTs)
		{
			return ActVecBreakV2ZoneViewModel.ZoneStatus.NONE;
		}

		// Token: 0x04038DE6 RID: 232934
		[Token(Token = "0x4038DE6")]
		[FieldOffset(Offset = "0x10")]
		private ZoneValidInfo m_validInfo;

		// Token: 0x04038DE7 RID: 232935
		[Token(Token = "0x4038DE7")]
		[FieldOffset(Offset = "0x18")]
		private ActVecBreakV2Data m_actData;

		// Token: 0x04038DE8 RID: 232936
		[Token(Token = "0x4038DE8")]
		[FieldOffset(Offset = "0x20")]
		private List<ActVecBreakV2ZoneStageViewModel> m_stageList;

		// Token: 0x04038DEC RID: 232940
		[Token(Token = "0x4038DEC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_zoneName;

		// Token: 0x04038DED RID: 232941
		[Token(Token = "0x4038DED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_zoneName;

		// Token: 0x04038DEE RID: 232942
		[Token(Token = "0x4038DEE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_status;

		// Token: 0x04038DEF RID: 232943
		[Token(Token = "0x4038DEF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_status;

		// Token: 0x04038DF0 RID: 232944
		[Token(Token = "0x4038DF0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_stageLockHint;

		// Token: 0x04038DF1 RID: 232945
		[Token(Token = "0x4038DF1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_stageLockHint;

		// Token: 0x04038DF2 RID: 232946
		[Token(Token = "0x4038DF2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_stageList;

		// Token: 0x04038DF3 RID: 232947
		[Token(Token = "0x4038DF3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_startTs;

		// Token: 0x04038DF4 RID: 232948
		[Token(Token = "0x4038DF4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04038DF5 RID: 232949
		[Token(Token = "0x4038DF5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x04038DF6 RID: 232950
		[Token(Token = "0x4038DF6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CalcCompleteStageCount;

		// Token: 0x04038DF7 RID: 232951
		[Token(Token = "0x4038DF7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CalcTotalStageCount;

		// Token: 0x04038DF8 RID: 232952
		[Token(Token = "0x4038DF8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetZoneIdByType;

		// Token: 0x04038DF9 RID: 232953
		[Token(Token = "0x4038DF9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x04038DFA RID: 232954
		[Token(Token = "0x4038DFA")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__InitStageList;

		// Token: 0x04038DFB RID: 232955
		[Token(Token = "0x4038DFB")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CalcZoneStatus;

		// Token: 0x02006DFD RID: 28157
		[Token(Token = "0x2006DFD")]
		public enum ZoneStatus
		{
			// Token: 0x04038DFD RID: 232957
			[Token(Token = "0x4038DFD")]
			NONE,
			// Token: 0x04038DFE RID: 232958
			[Token(Token = "0x4038DFE")]
			TIME_LOCK,
			// Token: 0x04038DFF RID: 232959
			[Token(Token = "0x4038DFF")]
			STAGE_EMPTY,
			// Token: 0x04038E00 RID: 232960
			[Token(Token = "0x4038E00")]
			STAGE_LOCK,
			// Token: 0x04038E01 RID: 232961
			[Token(Token = "0x4038E01")]
			ACTIVE,
			// Token: 0x04038E02 RID: 232962
			[Token(Token = "0x4038E02")]
			TIME_OUT
		}
	}
}
