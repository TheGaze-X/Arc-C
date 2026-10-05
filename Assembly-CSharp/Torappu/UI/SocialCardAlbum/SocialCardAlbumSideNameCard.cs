using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SocialCardAlbum
{
	// Token: 0x02003EBB RID: 16059
	[Token(Token = "0x2003EBB")]
	public class SocialCardAlbumSideNameCard : SocialCardAlbumSideSubBase
	{
		// Token: 0x17003B78 RID: 15224
		// (get) Token: 0x06018ED8 RID: 102104 RVA: 0x0009C6A8 File Offset: 0x0009A8A8
		[Token(Token = "0x17003B78")]
		public override CardType cardType
		{
			[Token(Token = "0x6018ED8")]
			[Address(RVA = "0x11A83D0", Offset = "0x11A6FD0", VA = "0x1811A83D0", Slot = "4")]
			get
			{
				return CardType.NAME_CARD;
			}
		}

		// Token: 0x06018ED9 RID: 102105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018ED9")]
		[Address(RVA = "0x11A82D0", Offset = "0x11A6ED0", VA = "0x1811A82D0", Slot = "5")]
		public override void Render(CardViewModel card)
		{
		}

		// Token: 0x06018EDA RID: 102106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EDA")]
		[Address(RVA = "0x11A8330", Offset = "0x11A6F30", VA = "0x1811A8330")]
		public SocialCardAlbumSideNameCard()
		{
		}

		// Token: 0x0401EC2D RID: 125997
		[Token(Token = "0x401EC2D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cardType;

		// Token: 0x0401EC2E RID: 125998
		[Token(Token = "0x401EC2E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401EC2F RID: 125999
		[Token(Token = "0x401EC2F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
