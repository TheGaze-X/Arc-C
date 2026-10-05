using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006645 RID: 26181
	[Token(Token = "0x2006645")]
	public class ArtGalleryListModeHomeBackgroundGroupSetViewModel : ArtGalleryListModeGroupSetViewModelBase<ArtGalleryListModeHomeBackgroundGroupViewModel>
	{
		// Token: 0x170058F6 RID: 22774
		// (get) Token: 0x06025996 RID: 154006 RVA: 0x000C8748 File Offset: 0x000C6948
		[Token(Token = "0x170058F6")]
		public override ArtGalleryTabType groupSetType
		{
			[Token(Token = "0x6025996")]
			[Address(RVA = "0x208D230", Offset = "0x208BE30", VA = "0x18208D230", Slot = "11")]
			get
			{
				return ArtGalleryTabType.HOME_THEME;
			}
		}

		// Token: 0x06025997 RID: 154007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025997")]
		[Address(RVA = "0x208D130", Offset = "0x208BD30", VA = "0x18208D130", Slot = "12")]
		protected override List<ArtGalleryGroupData> GetGroupList()
		{
			return null;
		}

		// Token: 0x06025998 RID: 154008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025998")]
		[Address(RVA = "0x208D1C0", Offset = "0x208BDC0", VA = "0x18208D1C0")]
		public ArtGalleryListModeHomeBackgroundGroupSetViewModel()
		{
		}

		// Token: 0x04034D35 RID: 216373
		[Token(Token = "0x4034D35")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_groupSetType;

		// Token: 0x04034D36 RID: 216374
		[Token(Token = "0x4034D36")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetGroupList;

		// Token: 0x04034D37 RID: 216375
		[Token(Token = "0x4034D37")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
