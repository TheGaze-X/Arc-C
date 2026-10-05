using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x0200661B RID: 26139
	[Token(Token = "0x200661B")]
	public class ArtGalleryEntryViewModel : IHotfixable
	{
		// Token: 0x060258AE RID: 153774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60258AE")]
		[Address(RVA = "0x2081F40", Offset = "0x2080B40", VA = "0x182081F40")]
		public void LoadData()
		{
		}

		// Token: 0x060258AF RID: 153775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60258AF")]
		[Address(RVA = "0x2082060", Offset = "0x2080C60", VA = "0x182082060")]
		public void RefreshData()
		{
		}

		// Token: 0x060258B0 RID: 153776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60258B0")]
		[Address(RVA = "0x2082150", Offset = "0x2080D50", VA = "0x182082150")]
		public ArtGalleryEntryViewModel()
		{
		}

		// Token: 0x04034BE5 RID: 216037
		[Token(Token = "0x4034BE5")]
		[FieldOffset(Offset = "0x10")]
		public int skinCount;

		// Token: 0x04034BE6 RID: 216038
		[Token(Token = "0x4034BE6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04034BE7 RID: 216039
		[Token(Token = "0x4034BE7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04034BE8 RID: 216040
		[Token(Token = "0x4034BE8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
