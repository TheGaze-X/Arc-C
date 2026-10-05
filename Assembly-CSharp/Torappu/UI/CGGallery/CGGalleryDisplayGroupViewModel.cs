using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CGGallery
{
	// Token: 0x02005FEF RID: 24559
	[Token(Token = "0x2005FEF")]
	public class CGGalleryDisplayGroupViewModel : IHotfixable, IComparable<CGGalleryDisplayGroupViewModel>
	{
		// Token: 0x170053D2 RID: 21458
		// (get) Token: 0x060237F4 RID: 145396 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060237F5 RID: 145397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170053D2")]
		public string storylineId
		{
			[Token(Token = "0x60237F4")]
			[Address(RVA = "0x1E17280", Offset = "0x1E15E80", VA = "0x181E17280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60237F5")]
			[Address(RVA = "0x1E17510", Offset = "0x1E16110", VA = "0x181E17510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170053D3 RID: 21459
		// (get) Token: 0x060237F6 RID: 145398 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060237F7 RID: 145399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170053D3")]
		public string storySetId
		{
			[Token(Token = "0x60237F6")]
			[Address(RVA = "0x1E17220", Offset = "0x1E15E20", VA = "0x181E17220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60237F7")]
			[Address(RVA = "0x1E17490", Offset = "0x1E16090", VA = "0x181E17490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170053D4 RID: 21460
		// (get) Token: 0x060237F8 RID: 145400 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060237F9 RID: 145401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170053D4")]
		public string titleImageId
		{
			[Token(Token = "0x60237F8")]
			[Address(RVA = "0x1E172E0", Offset = "0x1E15EE0", VA = "0x181E172E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60237F9")]
			[Address(RVA = "0x1E17590", Offset = "0x1E16190", VA = "0x181E17590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170053D5 RID: 21461
		// (get) Token: 0x060237FA RID: 145402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170053D5")]
		public IReadOnlyList<CGGalleryDisplayViewModel> displays
		{
			[Token(Token = "0x60237FA")]
			[Address(RVA = "0x1E170A0", Offset = "0x1E15CA0", VA = "0x181E170A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170053D6 RID: 21462
		// (get) Token: 0x060237FB RID: 145403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170053D6")]
		public IReadOnlyList<CGGalleryDisplayViewModel> favouriteDisplays
		{
			[Token(Token = "0x60237FB")]
			[Address(RVA = "0x1E17160", Offset = "0x1E15D60", VA = "0x181E17160")]
			get
			{
				return null;
			}
		}

		// Token: 0x170053D7 RID: 21463
		// (get) Token: 0x060237FC RID: 145404 RVA: 0x000C1140 File Offset: 0x000BF340
		// (set) Token: 0x060237FD RID: 145405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170053D7")]
		public bool favourite
		{
			[Token(Token = "0x60237FC")]
			[Address(RVA = "0x1E171C0", Offset = "0x1E15DC0", VA = "0x181E171C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60237FD")]
			[Address(RVA = "0x1E17420", Offset = "0x1E16020", VA = "0x181E17420")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170053D8 RID: 21464
		// (get) Token: 0x060237FE RID: 145406 RVA: 0x000C1158 File Offset: 0x000BF358
		// (set) Token: 0x060237FF RID: 145407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170053D8")]
		public int cgCount
		{
			[Token(Token = "0x60237FE")]
			[Address(RVA = "0x1E17040", Offset = "0x1E15C40", VA = "0x181E17040")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60237FF")]
			[Address(RVA = "0x1E17340", Offset = "0x1E15F40", VA = "0x181E17340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170053D9 RID: 21465
		// (get) Token: 0x06023800 RID: 145408 RVA: 0x000C1170 File Offset: 0x000BF370
		// (set) Token: 0x06023801 RID: 145409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170053D9")]
		public int favouriteCgCount
		{
			[Token(Token = "0x6023800")]
			[Address(RVA = "0x1E17100", Offset = "0x1E15D00", VA = "0x181E17100")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6023801")]
			[Address(RVA = "0x1E173B0", Offset = "0x1E15FB0", VA = "0x181E173B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06023802 RID: 145410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023802")]
		[Address(RVA = "0x1E167E0", Offset = "0x1E153E0", VA = "0x181E167E0")]
		public void LoadData(StorylineData storylineData, StorylineLocationData locationData, StorylineStorySetData storySetData, List<CGGalleryDisplayViewModel> displayList)
		{
		}

		// Token: 0x06023803 RID: 145411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023803")]
		[Address(RVA = "0x1E16C80", Offset = "0x1E15880", VA = "0x181E16C80")]
		public void RefreshData(ICollection<string> favouriteCgIds)
		{
		}

		// Token: 0x06023804 RID: 145412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023804")]
		[Address(RVA = "0x1E164D0", Offset = "0x1E150D0", VA = "0x181E164D0")]
		public void ApplyFavouriteCollection()
		{
		}

		// Token: 0x06023805 RID: 145413 RVA: 0x000C1188 File Offset: 0x000BF388
		[Token(Token = "0x6023805")]
		[Address(RVA = "0x1E16720", Offset = "0x1E15320", VA = "0x181E16720", Slot = "4")]
		public int CompareTo(CGGalleryDisplayGroupViewModel other)
		{
			return 0;
		}

		// Token: 0x06023806 RID: 145414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023806")]
		[Address(RVA = "0x1E16F80", Offset = "0x1E15B80", VA = "0x181E16F80")]
		public CGGalleryDisplayGroupViewModel()
		{
		}

		// Token: 0x040311AC RID: 201132
		[Token(Token = "0x40311AC")]
		[FieldOffset(Offset = "0x10")]
		private int m_storylineSortId;

		// Token: 0x040311AD RID: 201133
		[Token(Token = "0x40311AD")]
		[FieldOffset(Offset = "0x14")]
		private int m_inlineSortId;

		// Token: 0x040311AE RID: 201134
		[Token(Token = "0x40311AE")]
		[FieldOffset(Offset = "0x18")]
		private List<CGGalleryDisplayViewModel> m_displays;

		// Token: 0x040311AF RID: 201135
		[Token(Token = "0x40311AF")]
		[FieldOffset(Offset = "0x20")]
		private List<CGGalleryDisplayViewModel> m_favouriteDisplays;

		// Token: 0x040311B6 RID: 201142
		[Token(Token = "0x40311B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_storylineId;

		// Token: 0x040311B7 RID: 201143
		[Token(Token = "0x40311B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_storylineId;

		// Token: 0x040311B8 RID: 201144
		[Token(Token = "0x40311B8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_storySetId;

		// Token: 0x040311B9 RID: 201145
		[Token(Token = "0x40311B9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_storySetId;

		// Token: 0x040311BA RID: 201146
		[Token(Token = "0x40311BA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_titleImageId;

		// Token: 0x040311BB RID: 201147
		[Token(Token = "0x40311BB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_titleImageId;

		// Token: 0x040311BC RID: 201148
		[Token(Token = "0x40311BC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_displays;

		// Token: 0x040311BD RID: 201149
		[Token(Token = "0x40311BD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_favouriteDisplays;

		// Token: 0x040311BE RID: 201150
		[Token(Token = "0x40311BE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_favourite;

		// Token: 0x040311BF RID: 201151
		[Token(Token = "0x40311BF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_favourite;

		// Token: 0x040311C0 RID: 201152
		[Token(Token = "0x40311C0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_cgCount;

		// Token: 0x040311C1 RID: 201153
		[Token(Token = "0x40311C1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_cgCount;

		// Token: 0x040311C2 RID: 201154
		[Token(Token = "0x40311C2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_favouriteCgCount;

		// Token: 0x040311C3 RID: 201155
		[Token(Token = "0x40311C3")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_favouriteCgCount;

		// Token: 0x040311C4 RID: 201156
		[Token(Token = "0x40311C4")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040311C5 RID: 201157
		[Token(Token = "0x40311C5")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x040311C6 RID: 201158
		[Token(Token = "0x40311C6")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_ApplyFavouriteCollection;

		// Token: 0x040311C7 RID: 201159
		[Token(Token = "0x40311C7")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x040311C8 RID: 201160
		[Token(Token = "0x40311C8")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
