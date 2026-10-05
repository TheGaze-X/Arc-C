using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006651 RID: 26193
	[Token(Token = "0x2006651")]
	public abstract class ArtGalleryListModeGroupViewModelBase<TItemViewModel> : IArtGalleryListModeGroupViewModel, IHotfixable where TItemViewModel : IArtGalleryDisplayItemViewModel, new()
	{
		// Token: 0x17005910 RID: 22800
		// (get) Token: 0x060259E0 RID: 154080 RVA: 0x000C8910 File Offset: 0x000C6B10
		// (set) Token: 0x060259E1 RID: 154081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005910")]
		public int refreshSeq
		{
			[Token(Token = "0x60259E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60259E1")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17005911 RID: 22801
		// (get) Token: 0x060259E2 RID: 154082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005911")]
		public List<IArtGalleryDisplayItemViewModel> shuffledItemModels
		{
			[Token(Token = "0x60259E2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005912 RID: 22802
		// (get) Token: 0x060259E3 RID: 154083 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060259E4 RID: 154084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005912")]
		public string groupType
		{
			[Token(Token = "0x60259E3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60259E4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17005913 RID: 22803
		// (get) Token: 0x060259E5 RID: 154085 RVA: 0x000C8928 File Offset: 0x000C6B28
		[Token(Token = "0x17005913")]
		public virtual bool isEmpty
		{
			[Token(Token = "0x60259E5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005914 RID: 22804
		// (get) Token: 0x060259E6 RID: 154086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005914")]
		public virtual string title
		{
			[Token(Token = "0x60259E6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005915 RID: 22805
		// (get) Token: 0x060259E7 RID: 154087 RVA: 0x000C8940 File Offset: 0x000C6B40
		[Token(Token = "0x17005915")]
		public virtual int sortId
		{
			[Token(Token = "0x60259E7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060259E8 RID: 154088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60259E8")]
		protected virtual void ShuffleAndRefreshItem(IArtGalleryListModeGroupSetViewModel.GroupViewModelInput groupViewModelInput)
		{
		}

		// Token: 0x060259E9 RID: 154089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60259E9")]
		public virtual void LoadData(ArtGalleryGroupData groupData, IArtGalleryListModeGroupSetViewModel.GroupViewModelInput groupViewModelInput)
		{
		}

		// Token: 0x060259EA RID: 154090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60259EA")]
		public void RefreshData(IArtGalleryListModeGroupSetViewModel.GroupViewModelInput groupViewModelInput)
		{
		}

		// Token: 0x060259EB RID: 154091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60259EB")]
		protected ArtGalleryListModeGroupViewModelBase()
		{
		}

		// Token: 0x04034D93 RID: 216467
		[Token(Token = "0x4034D93")]
		[FieldOffset(Offset = "0x0")]
		private string m_title;

		// Token: 0x04034D94 RID: 216468
		[Token(Token = "0x4034D94")]
		[FieldOffset(Offset = "0x0")]
		private int m_sortId;

		// Token: 0x04034D95 RID: 216469
		[Token(Token = "0x4034D95")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<string, int> m_itemIndexDict;

		// Token: 0x04034D96 RID: 216470
		[Token(Token = "0x4034D96")]
		[FieldOffset(Offset = "0x0")]
		private List<IArtGalleryDisplayItemViewModel> m_originItemModels;

		// Token: 0x04034D97 RID: 216471
		[Token(Token = "0x4034D97")]
		[FieldOffset(Offset = "0x0")]
		private List<IArtGalleryDisplayItemViewModel> m_shuffledItemModels;

		// Token: 0x04034D98 RID: 216472
		[Token(Token = "0x4034D98")]
		[FieldOffset(Offset = "0x0")]
		private ArtGalleryDisplayViewModel.ArtGalleryShuffleRule m_cachedShuffleRule;

		// Token: 0x04034D9B RID: 216475
		[Token(Token = "0x4034D9B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_refreshSeq;

		// Token: 0x04034D9C RID: 216476
		[Token(Token = "0x4034D9C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_refreshSeq;

		// Token: 0x04034D9D RID: 216477
		[Token(Token = "0x4034D9D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_shuffledItemModels;

		// Token: 0x04034D9E RID: 216478
		[Token(Token = "0x4034D9E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_groupType;

		// Token: 0x04034D9F RID: 216479
		[Token(Token = "0x4034D9F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_groupType;

		// Token: 0x04034DA0 RID: 216480
		[Token(Token = "0x4034DA0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x04034DA1 RID: 216481
		[Token(Token = "0x4034DA1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_title;

		// Token: 0x04034DA2 RID: 216482
		[Token(Token = "0x4034DA2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x04034DA3 RID: 216483
		[Token(Token = "0x4034DA3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShuffleAndRefreshItem;

		// Token: 0x04034DA4 RID: 216484
		[Token(Token = "0x4034DA4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04034DA5 RID: 216485
		[Token(Token = "0x4034DA5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04034DA6 RID: 216486
		[Token(Token = "0x4034DA6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
