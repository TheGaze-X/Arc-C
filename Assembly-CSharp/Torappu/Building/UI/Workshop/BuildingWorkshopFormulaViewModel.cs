using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.UI.Workshop
{
	// Token: 0x02001BC4 RID: 7108
	[Token(Token = "0x2001BC4")]
	public class BuildingWorkshopFormulaViewModel : IHotfixable
	{
		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x0600B140 RID: 45376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700150B")]
		public List<BuildingData.WorkshopRarityInfo> workshopRarityInfos
		{
			[Token(Token = "0x600B140")]
			[Address(RVA = "0x32BE960", Offset = "0x32BD560", VA = "0x1832BE960")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B141 RID: 45377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B141")]
		[Address(RVA = "0x32BE320", Offset = "0x32BCF20", VA = "0x1832BE320")]
		public void LoadData(IWorkshopSession currentSession)
		{
		}

		// Token: 0x0600B142 RID: 45378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B142")]
		[Address(RVA = "0x32BE7D0", Offset = "0x32BD3D0", VA = "0x1832BE7D0")]
		public void ResetCurSelectRarityInfo()
		{
		}

		// Token: 0x0600B143 RID: 45379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B143")]
		[Address(RVA = "0x32BE3D0", Offset = "0x32BCFD0", VA = "0x1832BE3D0")]
		public List<IWorkshopFormula> LoadFormulasWithFilter()
		{
			return null;
		}

		// Token: 0x0600B144 RID: 45380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B144")]
		[Address(RVA = "0x32BE830", Offset = "0x32BD430", VA = "0x1832BE830")]
		private BuildingData.WorkshopRarityInfo _LoadCurrentRarityInfo()
		{
			return null;
		}

		// Token: 0x0600B145 RID: 45381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B145")]
		[Address(RVA = "0x32BE8F0", Offset = "0x32BD4F0", VA = "0x1832BE8F0")]
		public BuildingWorkshopFormulaViewModel()
		{
		}

		// Token: 0x0400AB9D RID: 43933
		[Token(Token = "0x400AB9D")]
		public const BuildingWorkshopFilterIndex INDEX_NOT_NEED_FILTER = BuildingWorkshopFilterIndex.INDEX_FURNITURE;

		// Token: 0x0400AB9E RID: 43934
		[Token(Token = "0x400AB9E")]
		[FieldOffset(Offset = "0x10")]
		public BuildingWorkshopFilterIndex currentFilterIndex;

		// Token: 0x0400AB9F RID: 43935
		[Token(Token = "0x400AB9F")]
		[FieldOffset(Offset = "0x14")]
		public WorkshopFormulaSorter.WorkshopSortingOption currentSortingOption;

		// Token: 0x0400ABA0 RID: 43936
		[Token(Token = "0x400ABA0")]
		[FieldOffset(Offset = "0x18")]
		public WorkshopFormulaSorter.SortingMethod currentSortingMethod;

		// Token: 0x0400ABA1 RID: 43937
		[Token(Token = "0x400ABA1")]
		[FieldOffset(Offset = "0x1C")]
		public bool showRarityFilterPanel;

		// Token: 0x0400ABA2 RID: 43938
		[Token(Token = "0x400ABA2")]
		[FieldOffset(Offset = "0x20")]
		public int rarityFilterIndex;

		// Token: 0x0400ABA3 RID: 43939
		[Token(Token = "0x400ABA3")]
		[FieldOffset(Offset = "0x28")]
		private IWorkshopSession m_currentSession;

		// Token: 0x0400ABA4 RID: 43940
		[Token(Token = "0x400ABA4")]
		[FieldOffset(Offset = "0x30")]
		private List<BuildingData.WorkshopRarityInfo> m_workshopRarityInfos;

		// Token: 0x0400ABA5 RID: 43941
		[Token(Token = "0x400ABA5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_workshopRarityInfos;

		// Token: 0x0400ABA6 RID: 43942
		[Token(Token = "0x400ABA6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0400ABA7 RID: 43943
		[Token(Token = "0x400ABA7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ResetCurSelectRarityInfo;

		// Token: 0x0400ABA8 RID: 43944
		[Token(Token = "0x400ABA8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadFormulasWithFilter;

		// Token: 0x0400ABA9 RID: 43945
		[Token(Token = "0x400ABA9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadCurrentRarityInfo;

		// Token: 0x0400ABAA RID: 43946
		[Token(Token = "0x400ABAA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
