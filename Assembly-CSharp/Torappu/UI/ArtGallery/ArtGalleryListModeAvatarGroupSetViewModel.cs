using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006642 RID: 26178
	[Token(Token = "0x2006642")]
	public class ArtGalleryListModeAvatarGroupSetViewModel : ArtGalleryListModeGroupSetViewModelBase<ArtGalleryListModeAvatarGroupViewModel>
	{
		// Token: 0x170058F4 RID: 22772
		// (get) Token: 0x0602598B RID: 153995 RVA: 0x000C8700 File Offset: 0x000C6900
		[Token(Token = "0x170058F4")]
		public override ArtGalleryTabType groupSetType
		{
			[Token(Token = "0x602598B")]
			[Address(RVA = "0x208D060", Offset = "0x208BC60", VA = "0x18208D060", Slot = "11")]
			get
			{
				return ArtGalleryTabType.HOME_THEME;
			}
		}

		// Token: 0x0602598C RID: 153996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602598C")]
		[Address(RVA = "0x208C990", Offset = "0x208B590", VA = "0x18208C990", Slot = "12")]
		protected override List<ArtGalleryGroupData> GetGroupList()
		{
			return null;
		}

		// Token: 0x0602598D RID: 153997 RVA: 0x000C8718 File Offset: 0x000C6918
		[Token(Token = "0x602598D")]
		[Address(RVA = "0x208CF80", Offset = "0x208BB80", VA = "0x18208CF80")]
		private bool _CheckAvatarTypeNeedShow(PlayerAvatarGroupType type)
		{
			return default(bool);
		}

		// Token: 0x0602598E RID: 153998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602598E")]
		[Address(RVA = "0x208CFF0", Offset = "0x208BBF0", VA = "0x18208CFF0")]
		public ArtGalleryListModeAvatarGroupSetViewModel()
		{
		}

		// Token: 0x04034D28 RID: 216360
		[Token(Token = "0x4034D28")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_groupSetType;

		// Token: 0x04034D29 RID: 216361
		[Token(Token = "0x4034D29")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetGroupList;

		// Token: 0x04034D2A RID: 216362
		[Token(Token = "0x4034D2A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckAvatarTypeNeedShow;

		// Token: 0x04034D2B RID: 216363
		[Token(Token = "0x4034D2B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
