using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CEF RID: 27887
	[Token(Token = "0x2006CEF")]
	public class TemplateActivityMileStoneItemModel
	{
		// Token: 0x17005DE0 RID: 24032
		// (get) Token: 0x06027C1E RID: 162846 RVA: 0x000CF408 File Offset: 0x000CD608
		[Token(Token = "0x17005DE0")]
		public TemplateActivityMileStoneItemModel.Status status
		{
			[Token(Token = "0x6027C1E")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return TemplateActivityMileStoneItemModel.Status.NONE;
			}
		}

		// Token: 0x17005DE1 RID: 24033
		// (get) Token: 0x06027C1F RID: 162847 RVA: 0x000CF420 File Offset: 0x000CD620
		[Token(Token = "0x17005DE1")]
		public int sortId
		{
			[Token(Token = "0x6027C1F")]
			[Address(RVA = "0x22FB140", Offset = "0x22F9D40", VA = "0x1822FB140")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005DE2 RID: 24034
		// (get) Token: 0x06027C20 RID: 162848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005DE2")]
		public string milestoneGroupName
		{
			[Token(Token = "0x6027C20")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005DE3 RID: 24035
		// (get) Token: 0x06027C21 RID: 162849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005DE3")]
		public string milestoneId
		{
			[Token(Token = "0x6027C21")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005DE4 RID: 24036
		// (get) Token: 0x06027C22 RID: 162850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005DE4")]
		public string costItemId
		{
			[Token(Token = "0x6027C22")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005DE5 RID: 24037
		// (get) Token: 0x06027C23 RID: 162851 RVA: 0x000CF438 File Offset: 0x000CD638
		[Token(Token = "0x17005DE5")]
		public int costItemCount
		{
			[Token(Token = "0x6027C23")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005DE6 RID: 24038
		// (get) Token: 0x06027C24 RID: 162852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005DE6")]
		public List<BasicActivityItemViewModel> rewardList
		{
			[Token(Token = "0x6027C24")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005DE7 RID: 24039
		// (get) Token: 0x06027C25 RID: 162853 RVA: 0x000CF450 File Offset: 0x000CD650
		[Token(Token = "0x17005DE7")]
		public long unlockTs
		{
			[Token(Token = "0x6027C25")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06027C26 RID: 162854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C26")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private TemplateActivityMileStoneItemModel()
		{
		}

		// Token: 0x06027C27 RID: 162855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027C27")]
		[Address(RVA = "0x22FA970", Offset = "0x22F9570", VA = "0x1822FA970")]
		public static TemplateActivityMileStoneItemModel Create(TemplateActivityMileStoneItemModel.Param param)
		{
			return null;
		}

		// Token: 0x06027C28 RID: 162856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C28")]
		[Address(RVA = "0x22FB090", Offset = "0x22F9C90", VA = "0x1822FB090")]
		public void UpdateStatus(int currentCnt, bool hasGot)
		{
		}

		// Token: 0x06027C29 RID: 162857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027C29")]
		[Address(RVA = "0x22FAFD0", Offset = "0x22F9BD0", VA = "0x1822FAFD0")]
		public ItemBundle GetSkinRewardOrNull()
		{
			return null;
		}

		// Token: 0x06027C2A RID: 162858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027C2A")]
		[Address(RVA = "0x22FAF10", Offset = "0x22F9B10", VA = "0x1822FAF10")]
		public ItemBundle GetNameCardSkinRewardOrNull()
		{
			return null;
		}

		// Token: 0x06027C2B RID: 162859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027C2B")]
		[Address(RVA = "0x22FACD0", Offset = "0x22F98D0", VA = "0x1822FACD0")]
		public ItemBundle GetAvatarRewardOrNull()
		{
			return null;
		}

		// Token: 0x06027C2C RID: 162860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027C2C")]
		[Address(RVA = "0x22FAE50", Offset = "0x22F9A50", VA = "0x1822FAE50")]
		public ItemBundle GetHomeThemeRewardOrNull()
		{
			return null;
		}

		// Token: 0x06027C2D RID: 162861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027C2D")]
		[Address(RVA = "0x22FAD90", Offset = "0x22F9990", VA = "0x1822FAD90")]
		public ItemBundle GetFurnRewardOrNull()
		{
			return null;
		}

		// Token: 0x04038620 RID: 230944
		[Token(Token = "0x4038620")]
		[FieldOffset(Offset = "0x10")]
		private TemplateActivityMileStoneItemModel.Status m_status;

		// Token: 0x04038621 RID: 230945
		[Token(Token = "0x4038621")]
		[FieldOffset(Offset = "0x18")]
		private string m_milestoneId;

		// Token: 0x04038622 RID: 230946
		[Token(Token = "0x4038622")]
		[FieldOffset(Offset = "0x20")]
		private string m_costItemId;

		// Token: 0x04038623 RID: 230947
		[Token(Token = "0x4038623")]
		[FieldOffset(Offset = "0x28")]
		private string m_milestoneGroupName;

		// Token: 0x04038624 RID: 230948
		[Token(Token = "0x4038624")]
		[FieldOffset(Offset = "0x30")]
		private int m_costItemCount;

		// Token: 0x04038625 RID: 230949
		[Token(Token = "0x4038625")]
		[FieldOffset(Offset = "0x34")]
		private int m_sortId;

		// Token: 0x04038626 RID: 230950
		[Token(Token = "0x4038626")]
		[FieldOffset(Offset = "0x38")]
		private long m_unlockTs;

		// Token: 0x04038627 RID: 230951
		[Token(Token = "0x4038627")]
		[FieldOffset(Offset = "0x40")]
		private List<BasicActivityItemViewModel> m_rewardList;

		// Token: 0x02006CF0 RID: 27888
		[Token(Token = "0x2006CF0")]
		public enum Status
		{
			// Token: 0x04038629 RID: 230953
			[Token(Token = "0x4038629")]
			NONE,
			// Token: 0x0403862A RID: 230954
			[Token(Token = "0x403862A")]
			AVAIL,
			// Token: 0x0403862B RID: 230955
			[Token(Token = "0x403862B")]
			NOTAVAIL,
			// Token: 0x0403862C RID: 230956
			[Token(Token = "0x403862C")]
			FINISH,
			// Token: 0x0403862D RID: 230957
			[Token(Token = "0x403862D")]
			LOCKED
		}

		// Token: 0x02006CF1 RID: 27889
		[Token(Token = "0x2006CF1")]
		public struct Param
		{
			// Token: 0x0403862E RID: 230958
			[Token(Token = "0x403862E")]
			[FieldOffset(Offset = "0x0")]
			public List<ItemBundle> rewardItems;

			// Token: 0x0403862F RID: 230959
			[Token(Token = "0x403862F")]
			[FieldOffset(Offset = "0x8")]
			public string actId;

			// Token: 0x04038630 RID: 230960
			[Token(Token = "0x4038630")]
			[FieldOffset(Offset = "0x10")]
			public string milestoneGroupName;

			// Token: 0x04038631 RID: 230961
			[Token(Token = "0x4038631")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x04038632 RID: 230962
			[Token(Token = "0x4038632")]
			[FieldOffset(Offset = "0x20")]
			public string costItem;

			// Token: 0x04038633 RID: 230963
			[Token(Token = "0x4038633")]
			[FieldOffset(Offset = "0x28")]
			public int costCount;

			// Token: 0x04038634 RID: 230964
			[Token(Token = "0x4038634")]
			[FieldOffset(Offset = "0x30")]
			public string milestoneId;

			// Token: 0x04038635 RID: 230965
			[Token(Token = "0x4038635")]
			[FieldOffset(Offset = "0x38")]
			public long unlockTs;
		}
	}
}
