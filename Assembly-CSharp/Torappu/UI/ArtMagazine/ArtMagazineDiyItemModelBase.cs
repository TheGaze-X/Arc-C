using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200657D RID: 25981
	[Token(Token = "0x200657D")]
	public abstract class ArtMagazineDiyItemModelBase : IArtMagazineDiyItemViewModel, IHotfixable
	{
		// Token: 0x17005851 RID: 22609
		// (get) Token: 0x060255D8 RID: 153048
		[Token(Token = "0x17005851")]
		public abstract string id { [Token(Token = "0x60255D8")] get; }

		// Token: 0x17005852 RID: 22610
		// (get) Token: 0x060255D9 RID: 153049
		[Token(Token = "0x17005852")]
		public abstract string itemId { [Token(Token = "0x60255D9")] get; }

		// Token: 0x17005853 RID: 22611
		// (get) Token: 0x060255DA RID: 153050
		[Token(Token = "0x17005853")]
		public abstract ItemType itemType { [Token(Token = "0x60255DA")] get; }

		// Token: 0x17005854 RID: 22612
		// (get) Token: 0x060255DB RID: 153051
		[Token(Token = "0x17005854")]
		public abstract int templateId { [Token(Token = "0x60255DB")] get; }

		// Token: 0x17005855 RID: 22613
		// (get) Token: 0x060255DC RID: 153052
		[Token(Token = "0x17005855")]
		public abstract int sortId { [Token(Token = "0x60255DC")] get; }

		// Token: 0x060255DD RID: 153053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60255DD")]
		[Address(RVA = "0x204ACB0", Offset = "0x20498B0", VA = "0x18204ACB0")]
		protected ArtMagazineDiyItemModelBase()
		{
		}

		// Token: 0x040346F5 RID: 214773
		[Token(Token = "0x40346F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
