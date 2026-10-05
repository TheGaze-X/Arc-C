using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.UI.Stage
{
	// Token: 0x020069F3 RID: 27123
	[Token(Token = "0x20069F3")]
	public class ZoneViewModel : IComparable<ZoneViewModel>, IStageSelectHandler
	{
		// Token: 0x17005B84 RID: 23428
		// (get) Token: 0x06026C93 RID: 158867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B84")]
		public string wrappedDefaultFocusStage
		{
			[Token(Token = "0x6026C93")]
			[Address(RVA = "0x21E8030", Offset = "0x21E6C30", VA = "0x1821E8030")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B85 RID: 23429
		// (get) Token: 0x06026C94 RID: 158868 RVA: 0x000CC570 File Offset: 0x000CA770
		// (set) Token: 0x06026C95 RID: 158869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B85")]
		public StageDiffGroup currentZoneDiffGroup
		{
			[Token(Token = "0x6026C94")]
			[Address(RVA = "0x6DF220", Offset = "0x6DDE20", VA = "0x1806DF220")]
			get
			{
				return StageDiffGroup.NONE;
			}
			[Token(Token = "0x6026C95")]
			[Address(RVA = "0x21E8120", Offset = "0x21E6D20", VA = "0x1821E8120")]
			set
			{
			}
		}

		// Token: 0x06026C96 RID: 158870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026C96")]
		[Address(RVA = "0x21E7B30", Offset = "0x21E6730", VA = "0x1821E7B30")]
		public ListDict<string, StageViewModel> LoadDiffGroupShuffleStages()
		{
			return null;
		}

		// Token: 0x06026C97 RID: 158871 RVA: 0x000CC588 File Offset: 0x000CA788
		[Token(Token = "0x6026C97")]
		[Address(RVA = "0x21E75E0", Offset = "0x21E61E0", VA = "0x1821E75E0")]
		public bool ApplySelectedViewModel(string normalStageId)
		{
			return default(bool);
		}

		// Token: 0x17005B86 RID: 23430
		// (get) Token: 0x06026C98 RID: 158872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B86")]
		public StageViewModel selectedStageNormal
		{
			[Token(Token = "0x6026C98")]
			[Address(RVA = "0x21E7F90", Offset = "0x21E6B90", VA = "0x1821E7F90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B87 RID: 23431
		// (get) Token: 0x06026C99 RID: 158873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B87")]
		public StageViewModel selectedStageHard
		{
			[Token(Token = "0x6026C99")]
			[Address(RVA = "0x21E7F70", Offset = "0x21E6B70", VA = "0x1821E7F70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B88 RID: 23432
		// (get) Token: 0x06026C9A RID: 158874 RVA: 0x000CC5A0 File Offset: 0x000CA7A0
		// (set) Token: 0x06026C9B RID: 158875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B88")]
		public SpecialStageType stageSelectedType
		{
			[Token(Token = "0x6026C9A")]
			[Address(RVA = "0x21E8020", Offset = "0x21E6C20", VA = "0x1821E8020", Slot = "5")]
			get
			{
				return SpecialStageType.NORMAL;
			}
			[Token(Token = "0x6026C9B")]
			[Address(RVA = "0x21E8290", Offset = "0x21E6E90", VA = "0x1821E8290")]
			set
			{
			}
		}

		// Token: 0x06026C9C RID: 158876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026C9C")]
		[Address(RVA = "0x21E78A0", Offset = "0x21E64A0", VA = "0x1821E78A0", Slot = "6")]
		public StageViewModel FindNormalStageFromSpecialStage(string notNormalStageId, SpecialStageType sourceStageType)
		{
			return null;
		}

		// Token: 0x06026C9D RID: 158877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026C9D")]
		[Address(RVA = "0x21E79C0", Offset = "0x21E65C0", VA = "0x1821E79C0", Slot = "7")]
		public StageViewModel FindSpecialStageFromNormal(string normalStageId, SpecialStageType targetStageType)
		{
			return null;
		}

		// Token: 0x06026C9E RID: 158878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026C9E")]
		[Address(RVA = "0x21E7AE0", Offset = "0x21E66E0", VA = "0x1821E7AE0", Slot = "8")]
		public StageViewModel GetStageByType(SpecialStageType stageType)
		{
			return null;
		}

		// Token: 0x17005B89 RID: 23433
		// (get) Token: 0x06026C9F RID: 158879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B89")]
		public StageViewModel selectedStageSixStar
		{
			[Token(Token = "0x6026C9F")]
			[Address(RVA = "0x21E7FB0", Offset = "0x21E6BB0", VA = "0x1821E7FB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B8A RID: 23434
		// (get) Token: 0x06026CA0 RID: 158880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B8A")]
		public StageViewModel selectedStage
		{
			[Token(Token = "0x6026CA0")]
			[Address(RVA = "0x21E7FD0", Offset = "0x21E6BD0", VA = "0x1821E7FD0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B8B RID: 23435
		// (get) Token: 0x06026CA1 RID: 158881 RVA: 0x000CC5B8 File Offset: 0x000CA7B8
		// (set) Token: 0x06026CA2 RID: 158882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005B8B")]
		public int sortIndex
		{
			[Token(Token = "0x6026CA1")]
			[Address(RVA = "0x21E8010", Offset = "0x21E6C10", VA = "0x1821E8010")]
			[CompilerGenerated]
			protected get
			{
				return 0;
			}
			[Token(Token = "0x6026CA2")]
			[Address(RVA = "0x21E8280", Offset = "0x21E6E80", VA = "0x1821E8280")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005B8C RID: 23436
		// (get) Token: 0x06026CA3 RID: 158883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B8C")]
		public string focusStageIdNormal
		{
			[Token(Token = "0x6026CA3")]
			[Address(RVA = "0x21E7F10", Offset = "0x21E6B10", VA = "0x1821E7F10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06026CA4 RID: 158884 RVA: 0x000CC5D0 File Offset: 0x000CA7D0
		[Token(Token = "0x6026CA4")]
		[Address(RVA = "0x21E77D0", Offset = "0x21E63D0", VA = "0x1821E77D0", Slot = "10")]
		public virtual int CompareTo(ZoneViewModel otherModel)
		{
			return 0;
		}

		// Token: 0x06026CA5 RID: 158885 RVA: 0x000CC5E8 File Offset: 0x000CA7E8
		[Token(Token = "0x6026CA5")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		public bool IsCompleteCountExceeded()
		{
			return default(bool);
		}

		// Token: 0x06026CA6 RID: 158886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CA6")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "11")]
		public virtual void LoadExtraData(string zoneId)
		{
		}

		// Token: 0x06026CA7 RID: 158887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CA7")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "12")]
		public virtual void LateInitAfterStageLoaded()
		{
		}

		// Token: 0x06026CA8 RID: 158888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CA8")]
		[Address(RVA = "0x21E7D80", Offset = "0x21E6980", VA = "0x1821E7D80")]
		public ZoneViewModel()
		{
		}

		// Token: 0x04036CC9 RID: 224457
		[Token(Token = "0x4036CC9")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04036CCA RID: 224458
		[Token(Token = "0x4036CCA")]
		[FieldOffset(Offset = "0x18")]
		public bool isUnlock;

		// Token: 0x04036CCB RID: 224459
		[Token(Token = "0x4036CCB")]
		[FieldOffset(Offset = "0x20")]
		public string defaultFocusStage;

		// Token: 0x04036CCC RID: 224460
		[Token(Token = "0x4036CCC")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<StageDiffGroup, string> defaultFocusStageDiffGroup;

		// Token: 0x04036CCD RID: 224461
		[Token(Token = "0x4036CCD")]
		[FieldOffset(Offset = "0x30")]
		public string zoneMapAssetPath;

		// Token: 0x04036CCE RID: 224462
		[Token(Token = "0x4036CCE")]
		[FieldOffset(Offset = "0x38")]
		public string timelyDropId;

		// Token: 0x04036CCF RID: 224463
		[Token(Token = "0x4036CCF")]
		[FieldOffset(Offset = "0x40")]
		private StageDiffGroup m_currentDiffGroup;

		// Token: 0x04036CD0 RID: 224464
		[Token(Token = "0x4036CD0")]
		[FieldOffset(Offset = "0x48")]
		public ZoneData zoneData;

		// Token: 0x04036CD1 RID: 224465
		[Token(Token = "0x4036CD1")]
		[FieldOffset(Offset = "0x50")]
		public ListDict<string, StageViewModel> stages;

		// Token: 0x04036CD2 RID: 224466
		[Token(Token = "0x4036CD2")]
		[FieldOffset(Offset = "0x58")]
		public List<ZoneViewModel.DiffInfo> diffGroup;

		// Token: 0x04036CD3 RID: 224467
		[Token(Token = "0x4036CD3")]
		[FieldOffset(Offset = "0x60")]
		public StageData mainlinePreposedStageData;

		// Token: 0x04036CD4 RID: 224468
		[Token(Token = "0x4036CD4")]
		[FieldOffset(Offset = "0x68")]
		public ZoneRewardBuffViewModel rewardBuffViewModel;

		// Token: 0x04036CD5 RID: 224469
		[Token(Token = "0x4036CD5")]
		[FieldOffset(Offset = "0x70")]
		public ListDict<string, StageViewModel> stageEntries;

		// Token: 0x04036CD6 RID: 224470
		[Token(Token = "0x4036CD6")]
		[FieldOffset(Offset = "0x78")]
		public ZoneViewModel.SelectedStageViewModel selectedViewModel;

		// Token: 0x04036CD8 RID: 224472
		[Token(Token = "0x4036CD8")]
		[FieldOffset(Offset = "0x88")]
		public string focusStageId;

		// Token: 0x020069F4 RID: 27124
		[Token(Token = "0x20069F4")]
		[Serializable]
		public struct LocalCache
		{
			// Token: 0x04036CD9 RID: 224473
			[Token(Token = "0x4036CD9")]
			[FieldOffset(Offset = "0x0")]
			public string lastPlayedStage;

			// Token: 0x04036CDA RID: 224474
			[Token(Token = "0x4036CDA")]
			[FieldOffset(Offset = "0x8")]
			public Dictionary<StageDiffGroup, string> lastPlayedStageByDiffGroup;
		}

		// Token: 0x020069F5 RID: 27125
		[Token(Token = "0x20069F5")]
		public class DiffInfo
		{
			// Token: 0x06026CA9 RID: 158889 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026CA9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DiffInfo()
			{
			}

			// Token: 0x04036CDB RID: 224475
			[Token(Token = "0x4036CDB")]
			[FieldOffset(Offset = "0x10")]
			public StageDiffGroup diffGroup;

			// Token: 0x04036CDC RID: 224476
			[Token(Token = "0x4036CDC")]
			[FieldOffset(Offset = "0x14")]
			public bool isUnlock;
		}

		// Token: 0x020069F6 RID: 27126
		[Token(Token = "0x20069F6")]
		public class SelectedStageViewModel
		{
			// Token: 0x17005B8D RID: 23437
			// (get) Token: 0x06026CAA RID: 158890 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005B8D")]
			public StageViewModel selectedStageNormal
			{
				[Token(Token = "0x6026CAA")]
				[Address(RVA = "0x21D7290", Offset = "0x21D5E90", VA = "0x1821D7290")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005B8E RID: 23438
			// (get) Token: 0x06026CAB RID: 158891 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005B8E")]
			public StageViewModel selectedStageHard
			{
				[Token(Token = "0x6026CAB")]
				[Address(RVA = "0x21D7220", Offset = "0x21D5E20", VA = "0x1821D7220")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005B8F RID: 23439
			// (get) Token: 0x06026CAC RID: 158892 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005B8F")]
			public StageViewModel selectedStageViewModel
			{
				[Token(Token = "0x6026CAC")]
				[Address(RVA = "0x21D7300", Offset = "0x21D5F00", VA = "0x1821D7300")]
				get
				{
					return null;
				}
			}

			// Token: 0x06026CAD RID: 158893 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026CAD")]
			[Address(RVA = "0x21D7080", Offset = "0x21D5C80", VA = "0x1821D7080")]
			public void RegisterStageViewModel(SpecialStageType stageType, StageViewModel stageViewModel)
			{
			}

			// Token: 0x06026CAE RID: 158894 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6026CAE")]
			[Address(RVA = "0x21D7000", Offset = "0x21D5C00", VA = "0x1821D7000")]
			public StageViewModel GetStageViewModel(SpecialStageType stageType)
			{
				return null;
			}

			// Token: 0x06026CAF RID: 158895 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026CAF")]
			[Address(RVA = "0x21D7190", Offset = "0x21D5D90", VA = "0x1821D7190")]
			public SelectedStageViewModel()
			{
			}

			// Token: 0x04036CDD RID: 224477
			[Token(Token = "0x4036CDD")]
			[FieldOffset(Offset = "0x10")]
			private EnumIntDictionary<SpecialStageType, StageViewModel> m_stageDict;

			// Token: 0x04036CDE RID: 224478
			[Token(Token = "0x4036CDE")]
			[FieldOffset(Offset = "0x18")]
			public SpecialStageType stageSelectType;
		}
	}
}
