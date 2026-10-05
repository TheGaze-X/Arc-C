using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SocialCardAlbum
{
	// Token: 0x02003EC4 RID: 16068
	[Token(Token = "0x2003EC4")]
	public class ArtMagazineLeafCardViewModel : CardViewModel
	{
		// Token: 0x17003B7C RID: 15228
		// (get) Token: 0x06018EF2 RID: 102130 RVA: 0x0009C708 File Offset: 0x0009A908
		[Token(Token = "0x17003B7C")]
		public override CardType cardType
		{
			[Token(Token = "0x6018EF2")]
			[Address(RVA = "0x1195C10", Offset = "0x1194810", VA = "0x181195C10", Slot = "4")]
			get
			{
				return CardType.NAME_CARD;
			}
		}

		// Token: 0x06018EF3 RID: 102131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EF3")]
		[Address(RVA = "0x1195B70", Offset = "0x1194770", VA = "0x181195B70")]
		public ArtMagazineLeafCardViewModel()
		{
		}

		// Token: 0x0401EC54 RID: 126036
		[Token(Token = "0x401EC54")]
		[FieldOffset(Offset = "0x10")]
		public int leafIndex;

		// Token: 0x0401EC55 RID: 126037
		[Token(Token = "0x401EC55")]
		[FieldOffset(Offset = "0x14")]
		public int leafCount;

		// Token: 0x0401EC56 RID: 126038
		[Token(Token = "0x401EC56")]
		[FieldOffset(Offset = "0x18")]
		public string leafName;

		// Token: 0x0401EC57 RID: 126039
		[Token(Token = "0x401EC57")]
		[FieldOffset(Offset = "0x20")]
		public SocialCardArtMagazineLeafViewModel leaf;

		// Token: 0x0401EC58 RID: 126040
		[Token(Token = "0x401EC58")]
		[FieldOffset(Offset = "0x28")]
		public bool isFriend;

		// Token: 0x0401EC59 RID: 126041
		[Token(Token = "0x401EC59")]
		[FieldOffset(Offset = "0x30")]
		public string friendUid;

		// Token: 0x0401EC5A RID: 126042
		[Token(Token = "0x401EC5A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cardType;

		// Token: 0x0401EC5B RID: 126043
		[Token(Token = "0x401EC5B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
