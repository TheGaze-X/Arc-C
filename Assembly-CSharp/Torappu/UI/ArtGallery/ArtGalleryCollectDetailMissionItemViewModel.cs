using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006623 RID: 26147
	[Token(Token = "0x2006623")]
	public class ArtGalleryCollectDetailMissionItemViewModel : IHotfixable
	{
		// Token: 0x170058B0 RID: 22704
		// (get) Token: 0x060258C3 RID: 153795 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060258C4 RID: 153796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058B0")]
		public string setId
		{
			[Token(Token = "0x60258C3")]
			[Address(RVA = "0x20721C0", Offset = "0x2070DC0", VA = "0x1820721C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60258C4")]
			[Address(RVA = "0x2072400", Offset = "0x2071000", VA = "0x182072400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170058B1 RID: 22705
		// (get) Token: 0x060258C5 RID: 153797 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060258C6 RID: 153798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058B1")]
		public string missionId
		{
			[Token(Token = "0x60258C5")]
			[Address(RVA = "0x20720A0", Offset = "0x2070CA0", VA = "0x1820720A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60258C6")]
			[Address(RVA = "0x2072290", Offset = "0x2070E90", VA = "0x182072290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170058B2 RID: 22706
		// (get) Token: 0x060258C7 RID: 153799 RVA: 0x000C8328 File Offset: 0x000C6528
		// (set) Token: 0x060258C8 RID: 153800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058B2")]
		public int requireCount
		{
			[Token(Token = "0x60258C7")]
			[Address(RVA = "0x2072100", Offset = "0x2070D00", VA = "0x182072100")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60258C8")]
			[Address(RVA = "0x2072310", Offset = "0x2070F10", VA = "0x182072310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170058B3 RID: 22707
		// (get) Token: 0x060258C9 RID: 153801 RVA: 0x000C8340 File Offset: 0x000C6540
		// (set) Token: 0x060258CA RID: 153802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058B3")]
		public ArtGalleryCollectDetailMissionItemViewModel.ClaimState claimState
		{
			[Token(Token = "0x60258C9")]
			[Address(RVA = "0x2072040", Offset = "0x2070C40", VA = "0x182072040")]
			[CompilerGenerated]
			get
			{
				return ArtGalleryCollectDetailMissionItemViewModel.ClaimState.NOT_AVAILABLE;
			}
			[Token(Token = "0x60258CA")]
			[Address(RVA = "0x2072220", Offset = "0x2070E20", VA = "0x182072220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170058B4 RID: 22708
		// (get) Token: 0x060258CB RID: 153803 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060258CC RID: 153804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058B4")]
		public List<ItemBundle> rewardItems
		{
			[Token(Token = "0x60258CB")]
			[Address(RVA = "0x2072160", Offset = "0x2070D60", VA = "0x182072160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60258CC")]
			[Address(RVA = "0x2072380", Offset = "0x2070F80", VA = "0x182072380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060258CD RID: 153805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60258CD")]
		[Address(RVA = "0x2071CE0", Offset = "0x20708E0", VA = "0x182071CE0")]
		public void LoadData(string collectSetId, ArtGalleryCollectSetMissionData missionData)
		{
		}

		// Token: 0x060258CE RID: 153806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60258CE")]
		[Address(RVA = "0x2071ED0", Offset = "0x2070AD0", VA = "0x182071ED0")]
		public void RefreshData(bool isClaimed, int itemsGotCnt)
		{
		}

		// Token: 0x060258CF RID: 153807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60258CF")]
		[Address(RVA = "0x2071FE0", Offset = "0x2070BE0", VA = "0x182071FE0")]
		public ArtGalleryCollectDetailMissionItemViewModel()
		{
		}

		// Token: 0x04034C09 RID: 216073
		[Token(Token = "0x4034C09")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_setId;

		// Token: 0x04034C0A RID: 216074
		[Token(Token = "0x4034C0A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_setId;

		// Token: 0x04034C0B RID: 216075
		[Token(Token = "0x4034C0B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_missionId;

		// Token: 0x04034C0C RID: 216076
		[Token(Token = "0x4034C0C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_missionId;

		// Token: 0x04034C0D RID: 216077
		[Token(Token = "0x4034C0D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_requireCount;

		// Token: 0x04034C0E RID: 216078
		[Token(Token = "0x4034C0E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_requireCount;

		// Token: 0x04034C0F RID: 216079
		[Token(Token = "0x4034C0F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_claimState;

		// Token: 0x04034C10 RID: 216080
		[Token(Token = "0x4034C10")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_claimState;

		// Token: 0x04034C11 RID: 216081
		[Token(Token = "0x4034C11")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_rewardItems;

		// Token: 0x04034C12 RID: 216082
		[Token(Token = "0x4034C12")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_rewardItems;

		// Token: 0x04034C13 RID: 216083
		[Token(Token = "0x4034C13")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04034C14 RID: 216084
		[Token(Token = "0x4034C14")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04034C15 RID: 216085
		[Token(Token = "0x4034C15")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006624 RID: 26148
		[Token(Token = "0x2006624")]
		public enum ClaimState
		{
			// Token: 0x04034C17 RID: 216087
			[Token(Token = "0x4034C17")]
			NOT_AVAILABLE,
			// Token: 0x04034C18 RID: 216088
			[Token(Token = "0x4034C18")]
			AVAILABLE,
			// Token: 0x04034C19 RID: 216089
			[Token(Token = "0x4034C19")]
			CLAIMED
		}
	}
}
