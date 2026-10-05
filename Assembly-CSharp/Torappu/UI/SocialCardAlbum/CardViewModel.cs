using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SocialCardAlbum
{
	// Token: 0x02003EC1 RID: 16065
	[Token(Token = "0x2003EC1")]
	public abstract class CardViewModel : IHotfixable
	{
		// Token: 0x17003B7A RID: 15226
		// (get) Token: 0x06018EED RID: 102125
		[Token(Token = "0x17003B7A")]
		public abstract CardType cardType { [Token(Token = "0x6018EED")] get; }

		// Token: 0x06018EEE RID: 102126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EEE")]
		[Address(RVA = "0x1195C70", Offset = "0x1194870", VA = "0x181195C70")]
		protected CardViewModel()
		{
		}

		// Token: 0x0401EC4F RID: 126031
		[Token(Token = "0x401EC4F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
