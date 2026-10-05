using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x0200661F RID: 26143
	[Token(Token = "0x200661F")]
	public class ArtGalleryCollectSetRewardsTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x170058AC RID: 22700
		// (get) Token: 0x060258B6 RID: 153782 RVA: 0x000C82B0 File Offset: 0x000C64B0
		[Token(Token = "0x170058AC")]
		public bool isShow
		{
			[Token(Token = "0x60258B6")]
			[Address(RVA = "0x207D8A0", Offset = "0x207C4A0", VA = "0x18207D8A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060258B7 RID: 153783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60258B7")]
		[Address(RVA = "0x207D7D0", Offset = "0x207C3D0", VA = "0x18207D7D0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x060258B8 RID: 153784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60258B8")]
		[Address(RVA = "0x207D840", Offset = "0x207C440", VA = "0x18207D840")]
		public ArtGalleryCollectSetRewardsTrackPointModel()
		{
		}

		// Token: 0x04034BF3 RID: 216051
		[Token(Token = "0x4034BF3")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x04034BF4 RID: 216052
		[Token(Token = "0x4034BF4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04034BF5 RID: 216053
		[Token(Token = "0x4034BF5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04034BF6 RID: 216054
		[Token(Token = "0x4034BF6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
