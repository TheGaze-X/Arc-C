using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003EF7 RID: 16119
	[Token(Token = "0x2003EF7")]
	public class SiracusaMapStageDetailInfoViewModel : IHotfixable
	{
		// Token: 0x17003BBD RID: 15293
		// (get) Token: 0x06019062 RID: 102498 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019063 RID: 102499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BBD")]
		public string key
		{
			[Token(Token = "0x6019062")]
			[Address(RVA = "0x11BE0E0", Offset = "0x11BCCE0", VA = "0x1811BE0E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019063")]
			[Address(RVA = "0x11BE4C0", Offset = "0x11BD0C0", VA = "0x1811BE4C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003BBE RID: 15294
		// (get) Token: 0x06019064 RID: 102500 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019065 RID: 102501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BBE")]
		public string stageId
		{
			[Token(Token = "0x6019064")]
			[Address(RVA = "0x11BE1A0", Offset = "0x11BCDA0", VA = "0x1811BE1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019065")]
			[Address(RVA = "0x11BE5C0", Offset = "0x11BD1C0", VA = "0x1811BE5C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003BBF RID: 15295
		// (get) Token: 0x06019066 RID: 102502 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019067 RID: 102503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BBF")]
		public StageViewModel stageViewModel
		{
			[Token(Token = "0x6019066")]
			[Address(RVA = "0x11BE260", Offset = "0x11BCE60", VA = "0x1811BE260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019067")]
			[Address(RVA = "0x11BE6B0", Offset = "0x11BD2B0", VA = "0x1811BE6B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003BC0 RID: 15296
		// (get) Token: 0x06019068 RID: 102504 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019069 RID: 102505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BC0")]
		public string pointId
		{
			[Token(Token = "0x6019068")]
			[Address(RVA = "0x11BE140", Offset = "0x11BCD40", VA = "0x1811BE140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019069")]
			[Address(RVA = "0x11BE540", Offset = "0x11BD140", VA = "0x1811BE540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003BC1 RID: 15297
		// (get) Token: 0x0601906A RID: 102506 RVA: 0x0009CC30 File Offset: 0x0009AE30
		// (set) Token: 0x0601906B RID: 102507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BC1")]
		public int stageRank
		{
			[Token(Token = "0x601906A")]
			[Address(RVA = "0x11BE200", Offset = "0x11BCE00", VA = "0x1811BE200")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601906B")]
			[Address(RVA = "0x11BE640", Offset = "0x11BD240", VA = "0x1811BE640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003BC2 RID: 15298
		// (get) Token: 0x0601906C RID: 102508 RVA: 0x0009CC48 File Offset: 0x0009AE48
		// (set) Token: 0x0601906D RID: 102509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BC2")]
		public bool isSelecting
		{
			[Token(Token = "0x601906C")]
			[Address(RVA = "0x11BE080", Offset = "0x11BCC80", VA = "0x1811BE080")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601906D")]
			[Address(RVA = "0x11BE450", Offset = "0x11BD050", VA = "0x1811BE450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003BC3 RID: 15299
		// (get) Token: 0x0601906E RID: 102510 RVA: 0x0009CC60 File Offset: 0x0009AE60
		// (set) Token: 0x0601906F RID: 102511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BC3")]
		public SIRACUSA_MAP_AVG_TYPE avgType
		{
			[Token(Token = "0x601906E")]
			[Address(RVA = "0x11BE020", Offset = "0x11BCC20", VA = "0x1811BE020")]
			[CompilerGenerated]
			get
			{
				return SIRACUSA_MAP_AVG_TYPE.NONE;
			}
			[Token(Token = "0x601906F")]
			[Address(RVA = "0x11BE3E0", Offset = "0x11BCFE0", VA = "0x1811BE3E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003BC4 RID: 15300
		// (get) Token: 0x06019070 RID: 102512 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019071 RID: 102513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BC4")]
		public string storyId
		{
			[Token(Token = "0x6019070")]
			[Address(RVA = "0x11BE380", Offset = "0x11BCF80", VA = "0x1811BE380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019071")]
			[Address(RVA = "0x11BE830", Offset = "0x11BD430", VA = "0x1811BE830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003BC5 RID: 15301
		// (get) Token: 0x06019072 RID: 102514 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019073 RID: 102515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BC5")]
		public StoryData storyData
		{
			[Token(Token = "0x6019072")]
			[Address(RVA = "0x11BE320", Offset = "0x11BCF20", VA = "0x1811BE320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019073")]
			[Address(RVA = "0x11BE7B0", Offset = "0x11BD3B0", VA = "0x1811BE7B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003BC6 RID: 15302
		// (get) Token: 0x06019074 RID: 102516 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019075 RID: 102517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BC6")]
		public string storyBriefInfo
		{
			[Token(Token = "0x6019074")]
			[Address(RVA = "0x11BE2C0", Offset = "0x11BCEC0", VA = "0x1811BE2C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019075")]
			[Address(RVA = "0x11BE730", Offset = "0x11BD330", VA = "0x1811BE730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06019076 RID: 102518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019076")]
		[Address(RVA = "0x11BDA80", Offset = "0x11BC680", VA = "0x1811BDA80")]
		public void LoadBasicData(ISiracusaMapStageInfoModel stageInfo)
		{
		}

		// Token: 0x06019077 RID: 102519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019077")]
		[Address(RVA = "0x11BD610", Offset = "0x11BC210", VA = "0x1811BD610")]
		public void LoadAvgData(ISiracusaMapStageInfoModel stageInfo, SIRACUSA_MAP_AVG_TYPE mapAvgType, StoryData storyInfo, Dictionary<string, SiracusaData.StoryBriefInfoData> briefInfoMap)
		{
		}

		// Token: 0x06019078 RID: 102520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019078")]
		[Address(RVA = "0x11BDE10", Offset = "0x11BCA10", VA = "0x1811BDE10")]
		public void UpdateInfoSelectState(bool select)
		{
		}

		// Token: 0x06019079 RID: 102521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019079")]
		[Address(RVA = "0x11BD330", Offset = "0x11BBF30", VA = "0x1811BD330")]
		public static SiracusaMapStageDetailInfoViewModel CreateExploreViewModel()
		{
			return null;
		}

		// Token: 0x0601907A RID: 102522 RVA: 0x0009CC78 File Offset: 0x0009AE78
		[Token(Token = "0x601907A")]
		[Address(RVA = "0x11BD410", Offset = "0x11BC010", VA = "0x1811BD410")]
		public static bool CreateStoryOnlyStageDetailInfo(SiracusaMapMapNodeViewModel stageNodeViewModel, ref SiracusaMapStageDetailInfoViewModel detailViewModel)
		{
			return default(bool);
		}

		// Token: 0x0601907B RID: 102523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601907B")]
		[Address(RVA = "0x11BDEB0", Offset = "0x11BCAB0", VA = "0x1811BDEB0")]
		private string _TryGetBriefInfo(Dictionary<string, SiracusaData.StoryBriefInfoData> briefInfoMap, string storyId)
		{
			return null;
		}

		// Token: 0x0601907C RID: 102524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601907C")]
		[Address(RVA = "0x11BDFC0", Offset = "0x11BCBC0", VA = "0x1811BDFC0")]
		public SiracusaMapStageDetailInfoViewModel()
		{
		}

		// Token: 0x0401EEF8 RID: 126712
		[Token(Token = "0x401EEF8")]
		public const string EXPLORE_MORE_KEY = "stage_explore_more";

		// Token: 0x0401EEF9 RID: 126713
		[Token(Token = "0x401EEF9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_key;

		// Token: 0x0401EEFA RID: 126714
		[Token(Token = "0x401EEFA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_key;

		// Token: 0x0401EEFB RID: 126715
		[Token(Token = "0x401EEFB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_stageId;

		// Token: 0x0401EEFC RID: 126716
		[Token(Token = "0x401EEFC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_stageId;

		// Token: 0x0401EEFD RID: 126717
		[Token(Token = "0x401EEFD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_stageViewModel;

		// Token: 0x0401EEFE RID: 126718
		[Token(Token = "0x401EEFE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_stageViewModel;

		// Token: 0x0401EEFF RID: 126719
		[Token(Token = "0x401EEFF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_pointId;

		// Token: 0x0401EF00 RID: 126720
		[Token(Token = "0x401EF00")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_pointId;

		// Token: 0x0401EF01 RID: 126721
		[Token(Token = "0x401EF01")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_stageRank;

		// Token: 0x0401EF02 RID: 126722
		[Token(Token = "0x401EF02")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_stageRank;

		// Token: 0x0401EF03 RID: 126723
		[Token(Token = "0x401EF03")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_isSelecting;

		// Token: 0x0401EF04 RID: 126724
		[Token(Token = "0x401EF04")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_isSelecting;

		// Token: 0x0401EF05 RID: 126725
		[Token(Token = "0x401EF05")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_avgType;

		// Token: 0x0401EF06 RID: 126726
		[Token(Token = "0x401EF06")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_avgType;

		// Token: 0x0401EF07 RID: 126727
		[Token(Token = "0x401EF07")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_storyId;

		// Token: 0x0401EF08 RID: 126728
		[Token(Token = "0x401EF08")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_storyId;

		// Token: 0x0401EF09 RID: 126729
		[Token(Token = "0x401EF09")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_storyData;

		// Token: 0x0401EF0A RID: 126730
		[Token(Token = "0x401EF0A")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_storyData;

		// Token: 0x0401EF0B RID: 126731
		[Token(Token = "0x401EF0B")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_storyBriefInfo;

		// Token: 0x0401EF0C RID: 126732
		[Token(Token = "0x401EF0C")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_set_storyBriefInfo;

		// Token: 0x0401EF0D RID: 126733
		[Token(Token = "0x401EF0D")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_LoadBasicData;

		// Token: 0x0401EF0E RID: 126734
		[Token(Token = "0x401EF0E")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_LoadAvgData;

		// Token: 0x0401EF0F RID: 126735
		[Token(Token = "0x401EF0F")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_UpdateInfoSelectState;

		// Token: 0x0401EF10 RID: 126736
		[Token(Token = "0x401EF10")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_CreateExploreViewModel;

		// Token: 0x0401EF11 RID: 126737
		[Token(Token = "0x401EF11")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_CreateStoryOnlyStageDetailInfo;

		// Token: 0x0401EF12 RID: 126738
		[Token(Token = "0x401EF12")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__TryGetBriefInfo;

		// Token: 0x0401EF13 RID: 126739
		[Token(Token = "0x401EF13")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
