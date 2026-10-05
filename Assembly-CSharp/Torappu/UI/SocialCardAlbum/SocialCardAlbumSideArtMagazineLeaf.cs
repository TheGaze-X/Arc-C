using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SocialCardAlbum
{
	// Token: 0x02003EBA RID: 16058
	[Token(Token = "0x2003EBA")]
	public class SocialCardAlbumSideArtMagazineLeaf : SocialCardAlbumSideSubBase
	{
		// Token: 0x17003B77 RID: 15223
		// (get) Token: 0x06018ED5 RID: 102101 RVA: 0x0009C690 File Offset: 0x0009A890
		[Token(Token = "0x17003B77")]
		public override CardType cardType
		{
			[Token(Token = "0x6018ED5")]
			[Address(RVA = "0x11A8270", Offset = "0x11A6E70", VA = "0x1811A8270", Slot = "4")]
			get
			{
				return CardType.NAME_CARD;
			}
		}

		// Token: 0x06018ED6 RID: 102102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018ED6")]
		[Address(RVA = "0x11A8000", Offset = "0x11A6C00", VA = "0x1811A8000", Slot = "5")]
		public override void Render(CardViewModel card)
		{
		}

		// Token: 0x06018ED7 RID: 102103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018ED7")]
		[Address(RVA = "0x11A81D0", Offset = "0x11A6DD0", VA = "0x1811A81D0")]
		public SocialCardAlbumSideArtMagazineLeaf()
		{
		}

		// Token: 0x0401EC26 RID: 125990
		[Token(Token = "0x401EC26")]
		private const string NAME_FORMAT = "//{0}";

		// Token: 0x0401EC27 RID: 125991
		[Token(Token = "0x401EC27")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _indexText;

		// Token: 0x0401EC28 RID: 125992
		[Token(Token = "0x401EC28")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _countText;

		// Token: 0x0401EC29 RID: 125993
		[Token(Token = "0x401EC29")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x0401EC2A RID: 125994
		[Token(Token = "0x401EC2A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cardType;

		// Token: 0x0401EC2B RID: 125995
		[Token(Token = "0x401EC2B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401EC2C RID: 125996
		[Token(Token = "0x401EC2C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
