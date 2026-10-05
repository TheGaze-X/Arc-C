using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006621 RID: 26145
	[Token(Token = "0x2006621")]
	public class ArtGalleryMagazineRewardsTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x170058AE RID: 22702
		// (get) Token: 0x060258BC RID: 153788 RVA: 0x000C82E0 File Offset: 0x000C64E0
		[Token(Token = "0x170058AE")]
		public bool isShow
		{
			[Token(Token = "0x60258BC")]
			[Address(RVA = "0x2086F40", Offset = "0x2085B40", VA = "0x182086F40", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060258BD RID: 153789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60258BD")]
		[Address(RVA = "0x2086E70", Offset = "0x2085A70", VA = "0x182086E70", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x060258BE RID: 153790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60258BE")]
		[Address(RVA = "0x2086EE0", Offset = "0x2085AE0", VA = "0x182086EE0")]
		public ArtGalleryMagazineRewardsTrackPointModel()
		{
		}

		// Token: 0x04034BFB RID: 216059
		[Token(Token = "0x4034BFB")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x04034BFC RID: 216060
		[Token(Token = "0x4034BFC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04034BFD RID: 216061
		[Token(Token = "0x4034BFD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04034BFE RID: 216062
		[Token(Token = "0x4034BFE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
