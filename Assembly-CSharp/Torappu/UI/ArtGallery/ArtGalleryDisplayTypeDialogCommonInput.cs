using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x0200663E RID: 26174
	[Token(Token = "0x200663E")]
	public class ArtGalleryDisplayTypeDialogCommonInput : IHotfixable
	{
		// Token: 0x06025983 RID: 153987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025983")]
		[Address(RVA = "0x208C410", Offset = "0x208B010", VA = "0x18208C410")]
		public ArtGalleryDisplayTypeDialogCommonInput()
		{
		}

		// Token: 0x04034D1A RID: 216346
		[Token(Token = "0x4034D1A")]
		[FieldOffset(Offset = "0x10")]
		public ArtGalleryTabType currTab;

		// Token: 0x04034D1B RID: 216347
		[Token(Token = "0x4034D1B")]
		[FieldOffset(Offset = "0x14")]
		public ArtGalleryDisplayViewModel.ArtGalleryShuffleRule curShuffleRule;

		// Token: 0x04034D1C RID: 216348
		[Token(Token = "0x4034D1C")]
		[FieldOffset(Offset = "0x18")]
		public ArtGalleryDisplayViewModel.ArtGalleryItemSelectParam curSelectParam;

		// Token: 0x04034D1D RID: 216349
		[Token(Token = "0x4034D1D")]
		[FieldOffset(Offset = "0x28")]
		public ArtGalleryDisplayViewModel.ArtGalleryFocusParam curFocusParam;

		// Token: 0x04034D1E RID: 216350
		[Token(Token = "0x4034D1E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
