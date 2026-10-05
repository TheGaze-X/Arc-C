using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x0200664D RID: 26189
	[Token(Token = "0x200664D")]
	public struct ArtGalleryDisplayGridVirtualParam : IHotfixable
	{
		// Token: 0x170058FB RID: 22779
		// (get) Token: 0x060259AE RID: 154030 RVA: 0x000C87C0 File Offset: 0x000C69C0
		// (set) Token: 0x060259AF RID: 154031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058FB")]
		public ArtGalleryDisplayGridVirtualParam.ViewType viewType
		{
			[Token(Token = "0x60259AE")]
			[Address(RVA = "0x2089E90", Offset = "0x2088A90", VA = "0x182089E90")]
			[CompilerGenerated]
			readonly get
			{
				return ArtGalleryDisplayGridVirtualParam.ViewType.NONE;
			}
			[Token(Token = "0x60259AF")]
			[Address(RVA = "0x208A0A0", Offset = "0x2088CA0", VA = "0x18208A0A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170058FC RID: 22780
		// (get) Token: 0x060259B0 RID: 154032 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060259B1 RID: 154033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058FC")]
		public string title
		{
			[Token(Token = "0x60259B0")]
			[Address(RVA = "0x2089E20", Offset = "0x2088A20", VA = "0x182089E20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60259B1")]
			[Address(RVA = "0x208A010", Offset = "0x2088C10", VA = "0x18208A010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170058FD RID: 22781
		// (get) Token: 0x060259B2 RID: 154034 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060259B3 RID: 154035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058FD")]
		public IArtGalleryDisplayItemViewModel itemViewModel
		{
			[Token(Token = "0x60259B2")]
			[Address(RVA = "0x2089DB0", Offset = "0x20889B0", VA = "0x182089DB0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60259B3")]
			[Address(RVA = "0x2089F80", Offset = "0x2088B80", VA = "0x182089F80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170058FE RID: 22782
		// (get) Token: 0x060259B4 RID: 154036 RVA: 0x000C87D8 File Offset: 0x000C69D8
		// (set) Token: 0x060259B5 RID: 154037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058FE")]
		public bool isFirstItem
		{
			[Token(Token = "0x60259B4")]
			[Address(RVA = "0x2089D40", Offset = "0x2088940", VA = "0x182089D40")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x60259B5")]
			[Address(RVA = "0x2089F00", Offset = "0x2088B00", VA = "0x182089F00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060259B6 RID: 154038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60259B6")]
		[Address(RVA = "0x2089B50", Offset = "0x2088750", VA = "0x182089B50")]
		public ArtGalleryDisplayGridVirtualParam(string title)
		{
		}

		// Token: 0x060259B7 RID: 154039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60259B7")]
		[Address(RVA = "0x2089C00", Offset = "0x2088800", VA = "0x182089C00")]
		public ArtGalleryDisplayGridVirtualParam(IArtGalleryDisplayItemViewModel itemViewModel, bool isFirstItem = false)
		{
		}

		// Token: 0x04034D51 RID: 216401
		[Token(Token = "0x4034D51")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewType;

		// Token: 0x04034D52 RID: 216402
		[Token(Token = "0x4034D52")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_viewType;

		// Token: 0x04034D53 RID: 216403
		[Token(Token = "0x4034D53")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_title;

		// Token: 0x04034D54 RID: 216404
		[Token(Token = "0x4034D54")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_title;

		// Token: 0x04034D55 RID: 216405
		[Token(Token = "0x4034D55")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_itemViewModel;

		// Token: 0x04034D56 RID: 216406
		[Token(Token = "0x4034D56")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_itemViewModel;

		// Token: 0x04034D57 RID: 216407
		[Token(Token = "0x4034D57")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isFirstItem;

		// Token: 0x04034D58 RID: 216408
		[Token(Token = "0x4034D58")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_isFirstItem;

		// Token: 0x04034D59 RID: 216409
		[Token(Token = "0x4034D59")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04034D5A RID: 216410
		[Token(Token = "0x4034D5A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix1_ctor;

		// Token: 0x0200664E RID: 26190
		[Token(Token = "0x200664E")]
		public enum ViewType
		{
			// Token: 0x04034D5C RID: 216412
			[Token(Token = "0x4034D5C")]
			NONE,
			// Token: 0x04034D5D RID: 216413
			[Token(Token = "0x4034D5D")]
			TITLE,
			// Token: 0x04034D5E RID: 216414
			[Token(Token = "0x4034D5E")]
			ITEM
		}
	}
}
