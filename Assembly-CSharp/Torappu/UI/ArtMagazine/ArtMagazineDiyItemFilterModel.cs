using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200659A RID: 26010
	[Token(Token = "0x200659A")]
	public abstract class ArtMagazineDiyItemFilterModel : IHotfixable
	{
		// Token: 0x17005876 RID: 22646
		// (get) Token: 0x0602565F RID: 153183
		[Token(Token = "0x17005876")]
		public abstract ItemType relateItemType { [Token(Token = "0x602565F")] get; }

		// Token: 0x17005877 RID: 22647
		// (get) Token: 0x06025660 RID: 153184
		[Token(Token = "0x17005877")]
		public abstract string filterDialogResPath { [Token(Token = "0x6025660")] get; }

		// Token: 0x17005878 RID: 22648
		// (get) Token: 0x06025661 RID: 153185
		[Token(Token = "0x17005878")]
		public abstract string title { [Token(Token = "0x6025661")] get; }

		// Token: 0x17005879 RID: 22649
		// (get) Token: 0x06025662 RID: 153186
		[Token(Token = "0x17005879")]
		public abstract object activeFilterParam { [Token(Token = "0x6025662")] get; }

		// Token: 0x06025663 RID: 153187
		[Token(Token = "0x6025663")]
		public abstract bool IsValid(ArtMagazineDiyItemModelBase itemModel);

		// Token: 0x06025664 RID: 153188
		[Token(Token = "0x6025664")]
		public abstract void UpdateParam(object param);

		// Token: 0x06025665 RID: 153189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025665")]
		[Address(RVA = "0x2063A80", Offset = "0x2062680", VA = "0x182063A80")]
		protected ArtMagazineDiyItemFilterModel()
		{
		}

		// Token: 0x0403479C RID: 214940
		[Token(Token = "0x403479C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
