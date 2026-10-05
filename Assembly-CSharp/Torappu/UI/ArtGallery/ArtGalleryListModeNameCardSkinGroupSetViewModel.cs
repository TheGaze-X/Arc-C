using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x0200664B RID: 26187
	[Token(Token = "0x200664B")]
	public class ArtGalleryListModeNameCardSkinGroupSetViewModel : ArtGalleryListModeGroupSetViewModelBase<ArtGalleryListModeNameCardSkinGroupViewModel>
	{
		// Token: 0x170058FA RID: 22778
		// (get) Token: 0x060259AA RID: 154026 RVA: 0x000C87A8 File Offset: 0x000C69A8
		[Token(Token = "0x170058FA")]
		public override ArtGalleryTabType groupSetType
		{
			[Token(Token = "0x60259AA")]
			[Address(RVA = "0x208D5D0", Offset = "0x208C1D0", VA = "0x18208D5D0", Slot = "11")]
			get
			{
				return ArtGalleryTabType.HOME_THEME;
			}
		}

		// Token: 0x060259AB RID: 154027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60259AB")]
		[Address(RVA = "0x208D4D0", Offset = "0x208C0D0", VA = "0x18208D4D0", Slot = "12")]
		protected override List<ArtGalleryGroupData> GetGroupList()
		{
			return null;
		}

		// Token: 0x060259AC RID: 154028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60259AC")]
		[Address(RVA = "0x208D560", Offset = "0x208C160", VA = "0x18208D560")]
		public ArtGalleryListModeNameCardSkinGroupSetViewModel()
		{
		}

		// Token: 0x04034D49 RID: 216393
		[Token(Token = "0x4034D49")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_groupSetType;

		// Token: 0x04034D4A RID: 216394
		[Token(Token = "0x4034D4A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetGroupList;

		// Token: 0x04034D4B RID: 216395
		[Token(Token = "0x4034D4B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
