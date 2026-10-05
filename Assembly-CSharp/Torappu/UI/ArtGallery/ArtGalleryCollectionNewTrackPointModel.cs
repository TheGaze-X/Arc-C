using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x0200661E RID: 26142
	[Token(Token = "0x200661E")]
	public class ArtGalleryCollectionNewTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x170058AB RID: 22699
		// (get) Token: 0x060258B3 RID: 153779 RVA: 0x000C8298 File Offset: 0x000C6498
		[Token(Token = "0x170058AB")]
		public bool isShow
		{
			[Token(Token = "0x60258B3")]
			[Address(RVA = "0x207F450", Offset = "0x207E050", VA = "0x18207F450", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060258B4 RID: 153780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60258B4")]
		[Address(RVA = "0x207F360", Offset = "0x207DF60", VA = "0x18207F360", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x060258B5 RID: 153781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60258B5")]
		[Address(RVA = "0x207F3F0", Offset = "0x207DFF0", VA = "0x18207F3F0")]
		public ArtGalleryCollectionNewTrackPointModel()
		{
		}

		// Token: 0x04034BEF RID: 216047
		[Token(Token = "0x4034BEF")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x04034BF0 RID: 216048
		[Token(Token = "0x4034BF0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04034BF1 RID: 216049
		[Token(Token = "0x4034BF1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04034BF2 RID: 216050
		[Token(Token = "0x4034BF2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
