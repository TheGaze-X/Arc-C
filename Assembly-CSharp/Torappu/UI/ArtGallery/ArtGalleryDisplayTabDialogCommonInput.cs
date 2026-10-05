using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x0200663F RID: 26175
	[Token(Token = "0x200663F")]
	public class ArtGalleryDisplayTabDialogCommonInput : IHotfixable
	{
		// Token: 0x06025984 RID: 153988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025984")]
		[Address(RVA = "0x208C3B0", Offset = "0x208AFB0", VA = "0x18208C3B0")]
		public ArtGalleryDisplayTabDialogCommonInput()
		{
		}

		// Token: 0x04034D1F RID: 216351
		[Token(Token = "0x4034D1F")]
		[FieldOffset(Offset = "0x10")]
		public ArtGalleryDisplayViewModel.ArtGalleryShuffleRule curShuffleRule;

		// Token: 0x04034D20 RID: 216352
		[Token(Token = "0x4034D20")]
		[FieldOffset(Offset = "0x18")]
		public ArtGalleryDisplayViewModel.ArtGalleryItemSelectParam curSelectParam;

		// Token: 0x04034D21 RID: 216353
		[Token(Token = "0x4034D21")]
		[FieldOffset(Offset = "0x28")]
		public ArtGalleryDisplayViewModel.ArtGalleryFocusParam curFocusParam;

		// Token: 0x04034D22 RID: 216354
		[Token(Token = "0x4034D22")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
