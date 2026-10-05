using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CGGallery
{
	// Token: 0x02005FF0 RID: 24560
	[Token(Token = "0x2005FF0")]
	public class CGGalleryDisplayViewModel : IHotfixable, IComparable<CGGalleryDisplayViewModel>
	{
		// Token: 0x170053DA RID: 21466
		// (get) Token: 0x06023807 RID: 145415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170053DA")]
		public string displayId
		{
			[Token(Token = "0x6023807")]
			[Address(RVA = "0x1E18250", Offset = "0x1E16E50", VA = "0x181E18250")]
			get
			{
				return null;
			}
		}

		// Token: 0x170053DB RID: 21467
		// (get) Token: 0x06023808 RID: 145416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170053DB")]
		public string displayName
		{
			[Token(Token = "0x6023808")]
			[Address(RVA = "0x1E182C0", Offset = "0x1E16EC0", VA = "0x181E182C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170053DC RID: 21468
		// (get) Token: 0x06023809 RID: 145417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170053DC")]
		public string displayDesc
		{
			[Token(Token = "0x6023809")]
			[Address(RVA = "0x1E181E0", Offset = "0x1E16DE0", VA = "0x181E181E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170053DD RID: 21469
		// (get) Token: 0x0602380A RID: 145418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170053DD")]
		public string relatedStoryId
		{
			[Token(Token = "0x602380A")]
			[Address(RVA = "0x1E184B0", Offset = "0x1E170B0", VA = "0x181E184B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170053DE RID: 21470
		// (get) Token: 0x0602380B RID: 145419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170053DE")]
		public CGGalleryDisplayGroupViewModel parent
		{
			[Token(Token = "0x602380B")]
			[Address(RVA = "0x1E18450", Offset = "0x1E17050", VA = "0x181E18450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170053DF RID: 21471
		// (get) Token: 0x0602380C RID: 145420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170053DF")]
		public IReadOnlyList<CGGalleryCGViewModel> cgs
		{
			[Token(Token = "0x602380C")]
			[Address(RVA = "0x1E18180", Offset = "0x1E16D80", VA = "0x181E18180")]
			get
			{
				return null;
			}
		}

		// Token: 0x170053E0 RID: 21472
		// (get) Token: 0x0602380D RID: 145421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170053E0")]
		public IReadOnlyList<CGGalleryCGViewModel> favouriteCgs
		{
			[Token(Token = "0x602380D")]
			[Address(RVA = "0x1E18390", Offset = "0x1E16F90", VA = "0x181E18390")]
			get
			{
				return null;
			}
		}

		// Token: 0x170053E1 RID: 21473
		// (get) Token: 0x0602380E RID: 145422 RVA: 0x000C11A0 File Offset: 0x000BF3A0
		// (set) Token: 0x0602380F RID: 145423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170053E1")]
		public bool favourite
		{
			[Token(Token = "0x602380E")]
			[Address(RVA = "0x1E183F0", Offset = "0x1E16FF0", VA = "0x181E183F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602380F")]
			[Address(RVA = "0x1E18590", Offset = "0x1E17190", VA = "0x181E18590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170053E2 RID: 21474
		// (get) Token: 0x06023810 RID: 145424 RVA: 0x000C11B8 File Offset: 0x000BF3B8
		// (set) Token: 0x06023811 RID: 145425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170053E2")]
		public int favouriteCgCount
		{
			[Token(Token = "0x6023810")]
			[Address(RVA = "0x1E18330", Offset = "0x1E16F30", VA = "0x181E18330")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6023811")]
			[Address(RVA = "0x1E18520", Offset = "0x1E17120", VA = "0x181E18520")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06023812 RID: 145426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023812")]
		[Address(RVA = "0x1E18070", Offset = "0x1E16C70", VA = "0x181E18070")]
		public CGGalleryDisplayViewModel(CGGalleryDisplayGroupViewModel parent)
		{
		}

		// Token: 0x06023813 RID: 145427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023813")]
		[Address(RVA = "0x1E177D0", Offset = "0x1E163D0", VA = "0x181E177D0")]
		public void LoadData(CGGalleryDisplayData displayData)
		{
		}

		// Token: 0x06023814 RID: 145428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023814")]
		[Address(RVA = "0x1E17AA0", Offset = "0x1E166A0", VA = "0x181E17AA0")]
		public void RefreshData(ICollection<string> favouriteCgIds)
		{
		}

		// Token: 0x06023815 RID: 145429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023815")]
		[Address(RVA = "0x1E17610", Offset = "0x1E16210", VA = "0x181E17610")]
		public void ApplyFavouriteCollection()
		{
		}

		// Token: 0x06023816 RID: 145430 RVA: 0x000C11D0 File Offset: 0x000BF3D0
		[Token(Token = "0x6023816")]
		[Address(RVA = "0x1E17700", Offset = "0x1E16300", VA = "0x181E17700", Slot = "4")]
		public int CompareTo(CGGalleryDisplayViewModel other)
		{
			return 0;
		}

		// Token: 0x06023817 RID: 145431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023817")]
		[Address(RVA = "0x1E17E10", Offset = "0x1E16A10", VA = "0x181E17E10")]
		private List<CGGalleryCGCompositeViewModel> _LoadCGCompositeList(List<CGGalleryCGCompositeData> dataList)
		{
			return null;
		}

		// Token: 0x040311C9 RID: 201161
		[Token(Token = "0x40311C9")]
		[FieldOffset(Offset = "0x10")]
		private CGGalleryDisplayData m_data;

		// Token: 0x040311CA RID: 201162
		[Token(Token = "0x40311CA")]
		[FieldOffset(Offset = "0x18")]
		private List<CGGalleryCGViewModel> m_cgs;

		// Token: 0x040311CB RID: 201163
		[Token(Token = "0x40311CB")]
		[FieldOffset(Offset = "0x20")]
		private List<CGGalleryCGViewModel> m_favouriteCgs;

		// Token: 0x040311CF RID: 201167
		[Token(Token = "0x40311CF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_displayId;

		// Token: 0x040311D0 RID: 201168
		[Token(Token = "0x40311D0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_displayName;

		// Token: 0x040311D1 RID: 201169
		[Token(Token = "0x40311D1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_displayDesc;

		// Token: 0x040311D2 RID: 201170
		[Token(Token = "0x40311D2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_relatedStoryId;

		// Token: 0x040311D3 RID: 201171
		[Token(Token = "0x40311D3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_parent;

		// Token: 0x040311D4 RID: 201172
		[Token(Token = "0x40311D4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_cgs;

		// Token: 0x040311D5 RID: 201173
		[Token(Token = "0x40311D5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_favouriteCgs;

		// Token: 0x040311D6 RID: 201174
		[Token(Token = "0x40311D6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_favourite;

		// Token: 0x040311D7 RID: 201175
		[Token(Token = "0x40311D7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_favourite;

		// Token: 0x040311D8 RID: 201176
		[Token(Token = "0x40311D8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_favouriteCgCount;

		// Token: 0x040311D9 RID: 201177
		[Token(Token = "0x40311D9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_favouriteCgCount;

		// Token: 0x040311DA RID: 201178
		[Token(Token = "0x40311DA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040311DB RID: 201179
		[Token(Token = "0x40311DB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040311DC RID: 201180
		[Token(Token = "0x40311DC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x040311DD RID: 201181
		[Token(Token = "0x40311DD")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ApplyFavouriteCollection;

		// Token: 0x040311DE RID: 201182
		[Token(Token = "0x40311DE")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x040311DF RID: 201183
		[Token(Token = "0x40311DF")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__LoadCGCompositeList;
	}
}
