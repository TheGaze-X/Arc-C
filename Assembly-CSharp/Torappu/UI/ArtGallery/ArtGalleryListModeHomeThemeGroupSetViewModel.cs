using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006648 RID: 26184
	[Token(Token = "0x2006648")]
	public class ArtGalleryListModeHomeThemeGroupSetViewModel : ArtGalleryListModeGroupSetViewModelBase<ArtGalleryListModeHomeThemeGroupViewModel>
	{
		// Token: 0x170058F8 RID: 22776
		// (get) Token: 0x060259A0 RID: 154016 RVA: 0x000C8778 File Offset: 0x000C6978
		[Token(Token = "0x170058F8")]
		public override ArtGalleryTabType groupSetType
		{
			[Token(Token = "0x60259A0")]
			[Address(RVA = "0x208D400", Offset = "0x208C000", VA = "0x18208D400", Slot = "11")]
			get
			{
				return ArtGalleryTabType.HOME_THEME;
			}
		}

		// Token: 0x060259A1 RID: 154017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60259A1")]
		[Address(RVA = "0x208D300", Offset = "0x208BF00", VA = "0x18208D300", Slot = "12")]
		protected override List<ArtGalleryGroupData> GetGroupList()
		{
			return null;
		}

		// Token: 0x060259A2 RID: 154018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60259A2")]
		[Address(RVA = "0x208D390", Offset = "0x208BF90", VA = "0x18208D390")]
		public ArtGalleryListModeHomeThemeGroupSetViewModel()
		{
		}

		// Token: 0x04034D40 RID: 216384
		[Token(Token = "0x4034D40")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_groupSetType;

		// Token: 0x04034D41 RID: 216385
		[Token(Token = "0x4034D41")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetGroupList;

		// Token: 0x04034D42 RID: 216386
		[Token(Token = "0x4034D42")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
