using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006625 RID: 26149
	[Token(Token = "0x2006625")]
	public class ArtGalleryCollectDetailMissionViewModel : IHotfixable
	{
		// Token: 0x170058B5 RID: 22709
		// (get) Token: 0x060258D0 RID: 153808 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060258D1 RID: 153809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058B5")]
		public string setId
		{
			[Token(Token = "0x60258D0")]
			[Address(RVA = "0x2073270", Offset = "0x2071E70", VA = "0x182073270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60258D1")]
			[Address(RVA = "0x20733A0", Offset = "0x2071FA0", VA = "0x1820733A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170058B6 RID: 22710
		// (get) Token: 0x060258D2 RID: 153810 RVA: 0x000C8358 File Offset: 0x000C6558
		// (set) Token: 0x060258D3 RID: 153811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058B6")]
		public int gotCnt
		{
			[Token(Token = "0x60258D2")]
			[Address(RVA = "0x20731B0", Offset = "0x2071DB0", VA = "0x1820731B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60258D3")]
			[Address(RVA = "0x2073330", Offset = "0x2071F30", VA = "0x182073330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170058B7 RID: 22711
		// (get) Token: 0x060258D4 RID: 153812 RVA: 0x000C8370 File Offset: 0x000C6570
		// (set) Token: 0x060258D5 RID: 153813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058B7")]
		public int totalCnt
		{
			[Token(Token = "0x60258D4")]
			[Address(RVA = "0x20732D0", Offset = "0x2071ED0", VA = "0x1820732D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60258D5")]
			[Address(RVA = "0x2073420", Offset = "0x2072020", VA = "0x182073420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170058B8 RID: 22712
		// (get) Token: 0x060258D6 RID: 153814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170058B8")]
		public List<ArtGalleryCollectDetailMissionItemViewModel> items
		{
			[Token(Token = "0x60258D6")]
			[Address(RVA = "0x2073210", Offset = "0x2071E10", VA = "0x182073210")]
			get
			{
				return null;
			}
		}

		// Token: 0x060258D7 RID: 153815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60258D7")]
		[Address(RVA = "0x2072C20", Offset = "0x2071820", VA = "0x182072C20")]
		public void LoadData(string selectedSetId)
		{
		}

		// Token: 0x060258D8 RID: 153816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60258D8")]
		[Address(RVA = "0x2072F90", Offset = "0x2071B90", VA = "0x182072F90")]
		public void RefreshData()
		{
		}

		// Token: 0x060258D9 RID: 153817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60258D9")]
		[Address(RVA = "0x2073100", Offset = "0x2071D00", VA = "0x182073100")]
		public ArtGalleryCollectDetailMissionViewModel()
		{
		}

		// Token: 0x04034C1D RID: 216093
		[Token(Token = "0x4034C1D")]
		[FieldOffset(Offset = "0x20")]
		private ArtGalleryCollectSetData m_setData;

		// Token: 0x04034C1E RID: 216094
		[Token(Token = "0x4034C1E")]
		[FieldOffset(Offset = "0x28")]
		private List<ArtGalleryCollectDetailMissionItemViewModel> m_items;

		// Token: 0x04034C1F RID: 216095
		[Token(Token = "0x4034C1F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_setId;

		// Token: 0x04034C20 RID: 216096
		[Token(Token = "0x4034C20")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_setId;

		// Token: 0x04034C21 RID: 216097
		[Token(Token = "0x4034C21")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_gotCnt;

		// Token: 0x04034C22 RID: 216098
		[Token(Token = "0x4034C22")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_gotCnt;

		// Token: 0x04034C23 RID: 216099
		[Token(Token = "0x4034C23")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_totalCnt;

		// Token: 0x04034C24 RID: 216100
		[Token(Token = "0x4034C24")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_totalCnt;

		// Token: 0x04034C25 RID: 216101
		[Token(Token = "0x4034C25")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_items;

		// Token: 0x04034C26 RID: 216102
		[Token(Token = "0x4034C26")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04034C27 RID: 216103
		[Token(Token = "0x4034C27")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04034C28 RID: 216104
		[Token(Token = "0x4034C28")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
