using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004F22 RID: 20258
	[Token(Token = "0x2004F22")]
	public class FifthAnnivExploreTopMenuViewModel : IHotfixable
	{
		// Token: 0x0601E2F9 RID: 123641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2F9")]
		[Address(RVA = "0x17F3A40", Offset = "0x17F2640", VA = "0x1817F3A40")]
		public void LoadData(bool isInit)
		{
		}

		// Token: 0x0601E2FA RID: 123642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2FA")]
		[Address(RVA = "0x17F3C10", Offset = "0x17F2810", VA = "0x1817F3C10")]
		public FifthAnnivExploreTopMenuViewModel()
		{
		}

		// Token: 0x04028351 RID: 164689
		[Token(Token = "0x4028351")]
		[FieldOffset(Offset = "0x10")]
		public FifthAnnivExploreTopMenuViewModel.DynViewType dynViewType;

		// Token: 0x04028352 RID: 164690
		[Token(Token = "0x4028352")]
		[FieldOffset(Offset = "0x18")]
		public FifthAnnivExploreGroupHeritageViewModel heritageViewModel;

		// Token: 0x04028353 RID: 164691
		[Token(Token = "0x4028353")]
		[FieldOffset(Offset = "0x20")]
		public FifthAnnivExploreProgressViewModel progressViewModel;

		// Token: 0x04028354 RID: 164692
		[Token(Token = "0x4028354")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04028355 RID: 164693
		[Token(Token = "0x4028355")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004F23 RID: 20259
		[Token(Token = "0x2004F23")]
		public enum DynViewType
		{
			// Token: 0x04028357 RID: 164695
			[Token(Token = "0x4028357")]
			HERITAGE,
			// Token: 0x04028358 RID: 164696
			[Token(Token = "0x4028358")]
			PROGRESS
		}
	}
}
