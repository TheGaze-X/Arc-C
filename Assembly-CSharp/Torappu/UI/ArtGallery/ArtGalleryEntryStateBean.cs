using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x0200661D RID: 26141
	[Token(Token = "0x200661D")]
	public class ArtGalleryEntryStateBean : IStateBean, IHotfixable
	{
		// Token: 0x060258B2 RID: 153778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60258B2")]
		[Address(RVA = "0x2081B10", Offset = "0x2080710", VA = "0x182081B10")]
		public ArtGalleryEntryStateBean()
		{
		}

		// Token: 0x04034BE9 RID: 216041
		[Token(Token = "0x4034BE9")]
		[FieldOffset(Offset = "0x10")]
		public ArtGalleryEntryProperty property;

		// Token: 0x04034BEA RID: 216042
		[Token(Token = "0x4034BEA")]
		[FieldOffset(Offset = "0x18")]
		public TrackPointViewProperty collectionRewardTrackPointProperty;

		// Token: 0x04034BEB RID: 216043
		[Token(Token = "0x4034BEB")]
		[FieldOffset(Offset = "0x20")]
		public TrackPointViewProperty collectionNewTrackPointProperty;

		// Token: 0x04034BEC RID: 216044
		[Token(Token = "0x4034BEC")]
		[FieldOffset(Offset = "0x28")]
		public TrackPointViewProperty magazineRewardTrackPointProperty;

		// Token: 0x04034BED RID: 216045
		[Token(Token = "0x4034BED")]
		[FieldOffset(Offset = "0x30")]
		public TrackPointViewProperty magazineNewTrackPointProperty;

		// Token: 0x04034BEE RID: 216046
		[Token(Token = "0x4034BEE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
