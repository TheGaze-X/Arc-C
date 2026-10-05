using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Stage.MixStory;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067B7 RID: 26551
	[Token(Token = "0x20067B7")]
	public class ZoneHomeMainlineEntryItemModel : ZoneHomeEntryItemModel
	{
		// Token: 0x17005A09 RID: 23049
		// (get) Token: 0x06026126 RID: 155942 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026127 RID: 155943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A09")]
		public string chapterId
		{
			[Token(Token = "0x6026126")]
			[Address(RVA = "0x212E980", Offset = "0x212D580", VA = "0x18212E980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026127")]
			[Address(RVA = "0x212EBC0", Offset = "0x212D7C0", VA = "0x18212EBC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005A0A RID: 23050
		// (get) Token: 0x06026128 RID: 155944 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026129 RID: 155945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A0A")]
		public ZoneData zoneData
		{
			[Token(Token = "0x6026128")]
			[Address(RVA = "0x212EB60", Offset = "0x212D760", VA = "0x18212EB60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026129")]
			[Address(RVA = "0x212EE10", Offset = "0x212DA10", VA = "0x18212EE10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005A0B RID: 23051
		// (get) Token: 0x0602612A RID: 155946 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602612B RID: 155947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A0B")]
		public StageData stageData
		{
			[Token(Token = "0x602612A")]
			[Address(RVA = "0x212EB00", Offset = "0x212D700", VA = "0x18212EB00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602612B")]
			[Address(RVA = "0x212ED90", Offset = "0x212D990", VA = "0x18212ED90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005A0C RID: 23052
		// (get) Token: 0x0602612C RID: 155948 RVA: 0x000C9DC8 File Offset: 0x000C7FC8
		// (set) Token: 0x0602612D RID: 155949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A0C")]
		public bool isAllChapterPass
		{
			[Token(Token = "0x602612C")]
			[Address(RVA = "0x212EA40", Offset = "0x212D640", VA = "0x18212EA40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602612D")]
			[Address(RVA = "0x212ECB0", Offset = "0x212D8B0", VA = "0x18212ECB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005A0D RID: 23053
		// (get) Token: 0x0602612E RID: 155950 RVA: 0x000C9DE0 File Offset: 0x000C7FE0
		// (set) Token: 0x0602612F RID: 155951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A0D")]
		public bool isChapterPass
		{
			[Token(Token = "0x602612E")]
			[Address(RVA = "0x212EAA0", Offset = "0x212D6A0", VA = "0x18212EAA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602612F")]
			[Address(RVA = "0x212ED20", Offset = "0x212D920", VA = "0x18212ED20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005A0E RID: 23054
		// (get) Token: 0x06026130 RID: 155952 RVA: 0x000C9DF8 File Offset: 0x000C7FF8
		// (set) Token: 0x06026131 RID: 155953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A0E")]
		private int chapterIndex
		{
			[Token(Token = "0x6026130")]
			[Address(RVA = "0x212E9E0", Offset = "0x212D5E0", VA = "0x18212E9E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6026131")]
			[Address(RVA = "0x212EC40", Offset = "0x212D840", VA = "0x18212EC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06026132 RID: 155954 RVA: 0x000C9E10 File Offset: 0x000C8010
		[Token(Token = "0x6026132")]
		[Address(RVA = "0x212D460", Offset = "0x212C060", VA = "0x18212D460", Slot = "5")]
		public override ZoneHomeEntryLockInfo GetLockInfo()
		{
			return default(ZoneHomeEntryLockInfo);
		}

		// Token: 0x06026133 RID: 155955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026133")]
		[Address(RVA = "0x212E1D0", Offset = "0x212CDD0", VA = "0x18212E1D0")]
		private static StageStorylineMainlineChapterViewModel _GetMainlineZoneGroupViewModel(StageStateBean stateBean)
		{
			return null;
		}

		// Token: 0x06026134 RID: 155956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026134")]
		[Address(RVA = "0x212D4E0", Offset = "0x212C0E0", VA = "0x18212D4E0")]
		public static IList<ZoneHomeMainlineEntryItemModel> LoadData(StageStateBean stateBean)
		{
			return null;
		}

		// Token: 0x06026135 RID: 155957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026135")]
		[Address(RVA = "0x212E610", Offset = "0x212D210", VA = "0x18212E610")]
		private static void _UpdateSortIndex(List<ZoneHomeMainlineEntryItemModel> mainlineList)
		{
		}

		// Token: 0x06026136 RID: 155958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026136")]
		[Address(RVA = "0x212D230", Offset = "0x212BE30", VA = "0x18212D230")]
		public static ZoneHomeMainlineEntryItemModel CreateMainlineDisplayThemeEntry(string zoneId, StageStateBean stateBean)
		{
			return null;
		}

		// Token: 0x06026137 RID: 155959 RVA: 0x000C9E28 File Offset: 0x000C8028
		[Token(Token = "0x6026137")]
		[Address(RVA = "0x212D740", Offset = "0x212C340", VA = "0x18212D740")]
		private static ZoneHomeEntryLockInfo _CreateMainlineDisplayLockInfo(string curZoneId, string curChapterId, StageStorylineMainlineChapterViewModel mainlineModel)
		{
			return default(ZoneHomeEntryLockInfo);
		}

		// Token: 0x06026138 RID: 155960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026138")]
		[Address(RVA = "0x212E480", Offset = "0x212D080", VA = "0x18212E480")]
		private static void _LoadFinishZoneData(List<ZoneHomeMainlineEntryItemModel> mainlineList, string chapterId, int chapterIndex, List<ChapterViewModel> chapterInfos, bool hasOtherChapterUnfinish)
		{
		}

		// Token: 0x06026139 RID: 155961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026139")]
		[Address(RVA = "0x212E550", Offset = "0x212D150", VA = "0x18212E550")]
		private static void _LoadProcessingZoneData(List<ZoneHomeMainlineEntryItemModel> mainlineList, string chapterId, int chapterIndex, List<ChapterViewModel> chapterInfos)
		{
		}

		// Token: 0x0602613A RID: 155962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602613A")]
		[Address(RVA = "0x212E000", Offset = "0x212CC00", VA = "0x18212E000")]
		private static StageData _GetChapterCurGoingStageData(string chapterId, List<ChapterViewModel> chapterInfoList)
		{
			return null;
		}

		// Token: 0x0602613B RID: 155963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602613B")]
		[Address(RVA = "0x212E2F0", Offset = "0x212CEF0", VA = "0x18212E2F0")]
		private static void _LoadData(List<ZoneHomeMainlineEntryItemModel> mainlineList, StageData stageData, string chapterId, int chapterIndex, bool isAllChapterPass, bool isChapterPass)
		{
		}

		// Token: 0x0602613C RID: 155964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602613C")]
		[Address(RVA = "0x212DB80", Offset = "0x212C780", VA = "0x18212DB80")]
		private static ZoneHomeMainlineEntryItemModel _CreateViewModel(StageData stageData, string chapterId, int chapterIndex, bool isAllChapterPass, bool isChapterPass, ZoneHomeEntryLockInfo lockInfo)
		{
			return null;
		}

		// Token: 0x0602613D RID: 155965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602613D")]
		[Address(RVA = "0x212E880", Offset = "0x212D480", VA = "0x18212E880")]
		public ZoneHomeMainlineEntryItemModel()
		{
		}

		// Token: 0x0602613E RID: 155966 RVA: 0x000C9E40 File Offset: 0x000C8040
		[Token(Token = "0x602613E")]
		[Address(RVA = "0x2128CE0", Offset = "0x21278E0", VA = "0x182128CE0")]
		private ZoneHomeEntryLockInfo <>xLuaBaseProxy_GetLockInfo()
		{
			return default(ZoneHomeEntryLockInfo);
		}

		// Token: 0x0403595F RID: 219487
		[Token(Token = "0x403595F")]
		[FieldOffset(Offset = "0x40")]
		private ZoneHomeEntryLockInfo lockInfo;

		// Token: 0x04035966 RID: 219494
		[Token(Token = "0x4035966")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_chapterId;

		// Token: 0x04035967 RID: 219495
		[Token(Token = "0x4035967")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_chapterId;

		// Token: 0x04035968 RID: 219496
		[Token(Token = "0x4035968")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_zoneData;

		// Token: 0x04035969 RID: 219497
		[Token(Token = "0x4035969")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_zoneData;

		// Token: 0x0403596A RID: 219498
		[Token(Token = "0x403596A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_stageData;

		// Token: 0x0403596B RID: 219499
		[Token(Token = "0x403596B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_stageData;

		// Token: 0x0403596C RID: 219500
		[Token(Token = "0x403596C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isAllChapterPass;

		// Token: 0x0403596D RID: 219501
		[Token(Token = "0x403596D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_isAllChapterPass;

		// Token: 0x0403596E RID: 219502
		[Token(Token = "0x403596E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isChapterPass;

		// Token: 0x0403596F RID: 219503
		[Token(Token = "0x403596F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_isChapterPass;

		// Token: 0x04035970 RID: 219504
		[Token(Token = "0x4035970")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_chapterIndex;

		// Token: 0x04035971 RID: 219505
		[Token(Token = "0x4035971")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_chapterIndex;

		// Token: 0x04035972 RID: 219506
		[Token(Token = "0x4035972")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetLockInfo;

		// Token: 0x04035973 RID: 219507
		[Token(Token = "0x4035973")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GetMainlineZoneGroupViewModel;

		// Token: 0x04035974 RID: 219508
		[Token(Token = "0x4035974")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04035975 RID: 219509
		[Token(Token = "0x4035975")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__UpdateSortIndex;

		// Token: 0x04035976 RID: 219510
		[Token(Token = "0x4035976")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_CreateMainlineDisplayThemeEntry;

		// Token: 0x04035977 RID: 219511
		[Token(Token = "0x4035977")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CreateMainlineDisplayLockInfo;

		// Token: 0x04035978 RID: 219512
		[Token(Token = "0x4035978")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__LoadFinishZoneData;

		// Token: 0x04035979 RID: 219513
		[Token(Token = "0x4035979")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__LoadProcessingZoneData;

		// Token: 0x0403597A RID: 219514
		[Token(Token = "0x403597A")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__GetChapterCurGoingStageData;

		// Token: 0x0403597B RID: 219515
		[Token(Token = "0x403597B")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x0403597C RID: 219516
		[Token(Token = "0x403597C")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__CreateViewModel;

		// Token: 0x0403597D RID: 219517
		[Token(Token = "0x403597D")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
