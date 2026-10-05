using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C09 RID: 3081
	[Token(Token = "0x2000C09")]
	public class PlayerGallery
	{
		// Token: 0x0600689F RID: 26783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600689F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerGallery()
		{
		}

		// Token: 0x04003ED5 RID: 16085
		[Token(Token = "0x4003ED5")]
		[FieldOffset(Offset = "0x10")]
		public bool firstRewards;

		// Token: 0x04003ED6 RID: 16086
		[Token(Token = "0x4003ED6")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, PlayerArtMagazineLeafData> leafMap;

		// Token: 0x04003ED7 RID: 16087
		[Token(Token = "0x4003ED7")]
		[FieldOffset(Offset = "0x20")]
		public List<string> magazineSquad;

		// Token: 0x04003ED8 RID: 16088
		[Token(Token = "0x4003ED8")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, bool> collectionRewards;

		// Token: 0x04003ED9 RID: 16089
		[Token(Token = "0x4003ED9")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, long> stickerMap;
	}
}
