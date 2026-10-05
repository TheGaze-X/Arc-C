using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006620 RID: 26144
	[Token(Token = "0x2006620")]
	public class ArtGalleryMagazineNewTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x170058AD RID: 22701
		// (get) Token: 0x060258B9 RID: 153785 RVA: 0x000C82C8 File Offset: 0x000C64C8
		[Token(Token = "0x170058AD")]
		public bool isShow
		{
			[Token(Token = "0x60258B9")]
			[Address(RVA = "0x2086E10", Offset = "0x2085A10", VA = "0x182086E10", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060258BA RID: 153786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60258BA")]
		[Address(RVA = "0x2086D20", Offset = "0x2085920", VA = "0x182086D20", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x060258BB RID: 153787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60258BB")]
		[Address(RVA = "0x2086DB0", Offset = "0x20859B0", VA = "0x182086DB0")]
		public ArtGalleryMagazineNewTrackPointModel()
		{
		}

		// Token: 0x04034BF7 RID: 216055
		[Token(Token = "0x4034BF7")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x04034BF8 RID: 216056
		[Token(Token = "0x4034BF8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04034BF9 RID: 216057
		[Token(Token = "0x4034BF9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04034BFA RID: 216058
		[Token(Token = "0x4034BFA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
