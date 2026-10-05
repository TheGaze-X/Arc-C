using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage.Extern;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006D00 RID: 27904
	[Token(Token = "0x2006D00")]
	public class TemplateActivityZoneGroupViewModel : TemplateActivityViewModel
	{
		// Token: 0x06027C80 RID: 162944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C80")]
		[Address(RVA = "0x22FFBF0", Offset = "0x22FE7F0", VA = "0x1822FFBF0")]
		public TemplateActivityZoneGroupViewModel(object param)
		{
		}

		// Token: 0x17005E02 RID: 24066
		// (get) Token: 0x06027C81 RID: 162945 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027C82 RID: 162946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005E02")]
		public string selectedZoneId
		{
			[Token(Token = "0x6027C81")]
			[Address(RVA = "0x22FFEB0", Offset = "0x22FEAB0", VA = "0x1822FFEB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6027C82")]
			[Address(RVA = "0x22FFF80", Offset = "0x22FEB80", VA = "0x1822FFF80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005E03 RID: 24067
		// (get) Token: 0x06027C83 RID: 162947 RVA: 0x000CF678 File Offset: 0x000CD878
		// (set) Token: 0x06027C84 RID: 162948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005E03")]
		public bool isAllTimeout
		{
			[Token(Token = "0x6027C83")]
			[Address(RVA = "0x22FFE50", Offset = "0x22FEA50", VA = "0x1822FFE50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6027C84")]
			[Address(RVA = "0x22FFF10", Offset = "0x22FEB10", VA = "0x1822FFF10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06027C85 RID: 162949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C85")]
		[Address(RVA = "0x22FF210", Offset = "0x22FDE10", VA = "0x1822FF210")]
		public void LoadData(ActivityBasicInfo actBasicInfo, List<ActivityZoneViewModel> actZoneModels, Dictionary<string, string> unlockParamDict, Dictionary<string, DataBundle> zoneMetaList)
		{
		}

		// Token: 0x06027C86 RID: 162950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C86")]
		[Address(RVA = "0x22FF990", Offset = "0x22FE590", VA = "0x1822FF990")]
		public void SetSelectedZone(string zoneId)
		{
		}

		// Token: 0x040386B1 RID: 231089
		[Token(Token = "0x40386B1")]
		[FieldOffset(Offset = "0x20")]
		public List<TemplateActivityZoneGroupViewModel.ZoneViewModel> zoneDescModelList;

		// Token: 0x040386B2 RID: 231090
		[Token(Token = "0x40386B2")]
		[FieldOffset(Offset = "0x28")]
		public DataBundle meta;

		// Token: 0x040386B5 RID: 231093
		[Token(Token = "0x40386B5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040386B6 RID: 231094
		[Token(Token = "0x40386B6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectedZoneId;

		// Token: 0x040386B7 RID: 231095
		[Token(Token = "0x40386B7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_selectedZoneId;

		// Token: 0x040386B8 RID: 231096
		[Token(Token = "0x40386B8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isAllTimeout;

		// Token: 0x040386B9 RID: 231097
		[Token(Token = "0x40386B9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_isAllTimeout;

		// Token: 0x040386BA RID: 231098
		[Token(Token = "0x40386BA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040386BB RID: 231099
		[Token(Token = "0x40386BB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetSelectedZone;

		// Token: 0x02006D01 RID: 27905
		[Token(Token = "0x2006D01")]
		public class Input
		{
			// Token: 0x06027C87 RID: 162951 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027C87")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x040386BC RID: 231100
			[Token(Token = "0x40386BC")]
			[FieldOffset(Offset = "0x10")]
			public ActivityBasicInfo actBasicInfo;

			// Token: 0x040386BD RID: 231101
			[Token(Token = "0x40386BD")]
			[FieldOffset(Offset = "0x88")]
			public List<ActivityZoneViewModel> actZoneModels;

			// Token: 0x040386BE RID: 231102
			[Token(Token = "0x40386BE")]
			[FieldOffset(Offset = "0x90")]
			public Dictionary<string, DataBundle> zoneMeta;

			// Token: 0x040386BF RID: 231103
			[Token(Token = "0x40386BF")]
			[FieldOffset(Offset = "0x98")]
			public DataBundle meta;

			// Token: 0x040386C0 RID: 231104
			[Token(Token = "0x40386C0")]
			[FieldOffset(Offset = "0xA0")]
			public Dictionary<string, string> unlockParamDict;
		}

		// Token: 0x02006D02 RID: 27906
		[Token(Token = "0x2006D02")]
		public class ZoneViewModel
		{
			// Token: 0x17005E04 RID: 24068
			// (get) Token: 0x06027C88 RID: 162952 RVA: 0x000CF690 File Offset: 0x000CD890
			[Token(Token = "0x17005E04")]
			public bool isLocked
			{
				[Token(Token = "0x6027C88")]
				[Address(RVA = "0x2302660", Offset = "0x2301260", VA = "0x182302660")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17005E05 RID: 24069
			// (get) Token: 0x06027C89 RID: 162953 RVA: 0x000CF6A8 File Offset: 0x000CD8A8
			[Token(Token = "0x17005E05")]
			public bool isAccessible
			{
				[Token(Token = "0x6027C89")]
				[Address(RVA = "0x2302640", Offset = "0x2301240", VA = "0x182302640")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17005E06 RID: 24070
			// (get) Token: 0x06027C8A RID: 162954 RVA: 0x000CF6C0 File Offset: 0x000CD8C0
			[Token(Token = "0x17005E06")]
			public bool hasNewSign
			{
				[Token(Token = "0x6027C8A")]
				[Address(RVA = "0x2302630", Offset = "0x2301230", VA = "0x182302630")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17005E07 RID: 24071
			// (get) Token: 0x06027C8B RID: 162955 RVA: 0x000CF6D8 File Offset: 0x000CD8D8
			[Token(Token = "0x17005E07")]
			public bool IsFogUnlockable
			{
				[Token(Token = "0x6027C8B")]
				[Address(RVA = "0x2302520", Offset = "0x2301120", VA = "0x182302520")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06027C8C RID: 162956 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027C8C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private ZoneViewModel()
			{
			}

			// Token: 0x06027C8D RID: 162957 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027C8D")]
			[Address(RVA = "0x2302130", Offset = "0x2300D30", VA = "0x182302130")]
			public static TemplateActivityZoneGroupViewModel.ZoneViewModel Create(ActivityZoneViewModel zoneModel, string activityId, ZoneValidInfo validInfo, long timeStampNow, long activityStartTime, string lockedText, DataBundle metaInfo)
			{
				return null;
			}

			// Token: 0x06027C8E RID: 162958 RVA: 0x000CF6F0 File Offset: 0x000CD8F0
			[Token(Token = "0x6027C8E")]
			[Address(RVA = "0x23024A0", Offset = "0x23010A0", VA = "0x1823024A0")]
			private bool _StageFogUnlockItemEnough(StageFogInfo fogInfo)
			{
				return default(bool);
			}

			// Token: 0x040386C1 RID: 231105
			[Token(Token = "0x40386C1")]
			[FieldOffset(Offset = "0x10")]
			public string zoneId;

			// Token: 0x040386C2 RID: 231106
			[Token(Token = "0x40386C2")]
			[FieldOffset(Offset = "0x18")]
			public string zoneName;

			// Token: 0x040386C3 RID: 231107
			[Token(Token = "0x40386C3")]
			[FieldOffset(Offset = "0x20")]
			public string iconId;

			// Token: 0x040386C4 RID: 231108
			[Token(Token = "0x40386C4")]
			[FieldOffset(Offset = "0x28")]
			public string unlockText;

			// Token: 0x040386C5 RID: 231109
			[Token(Token = "0x40386C5")]
			[FieldOffset(Offset = "0x30")]
			public long startTime;

			// Token: 0x040386C6 RID: 231110
			[Token(Token = "0x40386C6")]
			[FieldOffset(Offset = "0x38")]
			public bool isStageLocked;

			// Token: 0x040386C7 RID: 231111
			[Token(Token = "0x40386C7")]
			[FieldOffset(Offset = "0x39")]
			public bool isTimeLocked;

			// Token: 0x040386C8 RID: 231112
			[Token(Token = "0x40386C8")]
			[FieldOffset(Offset = "0x3A")]
			public bool isTimeout;

			// Token: 0x040386C9 RID: 231113
			[Token(Token = "0x40386C9")]
			[FieldOffset(Offset = "0x3B")]
			public bool isNew;

			// Token: 0x040386CA RID: 231114
			[Token(Token = "0x40386CA")]
			[FieldOffset(Offset = "0x3C")]
			public bool hasNewStage;

			// Token: 0x040386CB RID: 231115
			[Token(Token = "0x40386CB")]
			[FieldOffset(Offset = "0x40")]
			public List<StageFogInfo> stageFogList;

			// Token: 0x040386CC RID: 231116
			[Token(Token = "0x40386CC")]
			[FieldOffset(Offset = "0x48")]
			public ListDict<string, StageViewModel> stages;
		}
	}
}
