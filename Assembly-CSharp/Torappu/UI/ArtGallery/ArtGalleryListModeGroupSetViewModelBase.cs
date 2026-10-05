using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006650 RID: 26192
	[Token(Token = "0x2006650")]
	public abstract class ArtGalleryListModeGroupSetViewModelBase<T> : IArtGalleryListModeGroupSetViewModel, IHotfixable where T : IArtGalleryListModeGroupViewModel, new()
	{
		// Token: 0x1700590C RID: 22796
		// (get) Token: 0x060259D4 RID: 154068
		[Token(Token = "0x1700590C")]
		public abstract ArtGalleryTabType groupSetType { [Token(Token = "0x60259D4")] get; }

		// Token: 0x1700590D RID: 22797
		// (get) Token: 0x060259D5 RID: 154069 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060259D6 RID: 154070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700590D")]
		public List<IArtGalleryListModeGroupViewModel> groupViewModels
		{
			[Token(Token = "0x60259D5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60259D6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700590E RID: 22798
		// (get) Token: 0x060259D7 RID: 154071 RVA: 0x000C88E0 File Offset: 0x000C6AE0
		// (set) Token: 0x060259D8 RID: 154072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700590E")]
		public int refreshSeq
		{
			[Token(Token = "0x60259D7")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60259D8")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700590F RID: 22799
		// (get) Token: 0x060259D9 RID: 154073 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060259DA RID: 154074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700590F")]
		public string currentSelectItemId
		{
			[Token(Token = "0x60259D9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60259DA")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060259DB RID: 154075
		[Token(Token = "0x60259DB")]
		protected abstract List<ArtGalleryGroupData> GetGroupList();

		// Token: 0x060259DC RID: 154076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60259DC")]
		public virtual void LoadData(IArtGalleryListModeGroupSetViewModel.GroupViewModelInput input)
		{
		}

		// Token: 0x060259DD RID: 154077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60259DD")]
		public virtual void RefreshData(IArtGalleryListModeGroupSetViewModel.GroupViewModelInput input)
		{
		}

		// Token: 0x060259DE RID: 154078 RVA: 0x000C88F8 File Offset: 0x000C6AF8
		[Token(Token = "0x60259DE")]
		public bool CheckIfEmpty()
		{
			return default(bool);
		}

		// Token: 0x060259DF RID: 154079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60259DF")]
		protected ArtGalleryListModeGroupSetViewModelBase()
		{
		}

		// Token: 0x04034D85 RID: 216453
		[Token(Token = "0x4034D85")]
		[FieldOffset(Offset = "0x0")]
		private ArtGalleryFilterType m_cachedFilter;

		// Token: 0x04034D89 RID: 216457
		[Token(Token = "0x4034D89")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_groupViewModels;

		// Token: 0x04034D8A RID: 216458
		[Token(Token = "0x4034D8A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_groupViewModels;

		// Token: 0x04034D8B RID: 216459
		[Token(Token = "0x4034D8B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_refreshSeq;

		// Token: 0x04034D8C RID: 216460
		[Token(Token = "0x4034D8C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_refreshSeq;

		// Token: 0x04034D8D RID: 216461
		[Token(Token = "0x4034D8D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currentSelectItemId;

		// Token: 0x04034D8E RID: 216462
		[Token(Token = "0x4034D8E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_currentSelectItemId;

		// Token: 0x04034D8F RID: 216463
		[Token(Token = "0x4034D8F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04034D90 RID: 216464
		[Token(Token = "0x4034D90")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04034D91 RID: 216465
		[Token(Token = "0x4034D91")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckIfEmpty;

		// Token: 0x04034D92 RID: 216466
		[Token(Token = "0x4034D92")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
