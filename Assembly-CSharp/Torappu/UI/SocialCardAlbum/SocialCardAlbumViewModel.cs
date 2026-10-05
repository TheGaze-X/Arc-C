using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Friend;
using XLua;

namespace Torappu.UI.SocialCardAlbum
{
	// Token: 0x02003EC5 RID: 16069
	[Token(Token = "0x2003EC5")]
	public class SocialCardAlbumViewModel : IHotfixable
	{
		// Token: 0x17003B7D RID: 15229
		// (get) Token: 0x06018EF4 RID: 102132 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018EF5 RID: 102133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B7D")]
		public NameCardV2ViewModel nameCard
		{
			[Token(Token = "0x6018EF4")]
			[Address(RVA = "0x11AA5D0", Offset = "0x11A91D0", VA = "0x1811AA5D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6018EF5")]
			[Address(RVA = "0x11AA630", Offset = "0x11A9230", VA = "0x1811AA630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003B7E RID: 15230
		// (get) Token: 0x06018EF6 RID: 102134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003B7E")]
		public List<CardViewModel> cards
		{
			[Token(Token = "0x6018EF6")]
			[Address(RVA = "0x11AA570", Offset = "0x11A9170", VA = "0x1811AA570")]
			get
			{
				return null;
			}
		}

		// Token: 0x06018EF7 RID: 102135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EF7")]
		[Address(RVA = "0x11A9960", Offset = "0x11A8560", VA = "0x1811A9960")]
		public void LoadData(bool isSelf, FriendDataWithNameCard friendData)
		{
		}

		// Token: 0x06018EF8 RID: 102136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EF8")]
		[Address(RVA = "0x11A97B0", Offset = "0x11A83B0", VA = "0x1811A97B0")]
		private void LoadAsSelf()
		{
		}

		// Token: 0x06018EF9 RID: 102137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EF9")]
		[Address(RVA = "0x11AA140", Offset = "0x11A8D40", VA = "0x1811AA140")]
		private void _LoadAsFriend(FriendDataWithNameCard friendData)
		{
		}

		// Token: 0x06018EFA RID: 102138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EFA")]
		[Address(RVA = "0x11AA310", Offset = "0x11A8F10", VA = "0x1811AA310")]
		private void _LoadNameCard(NameCardV2ViewModel nameCard)
		{
		}

		// Token: 0x06018EFB RID: 102139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EFB")]
		[Address(RVA = "0x11A9D80", Offset = "0x11A8980", VA = "0x1811A9D80")]
		private void _LoadArtMagazineLeavesAsSelf()
		{
		}

		// Token: 0x06018EFC RID: 102140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EFC")]
		[Address(RVA = "0x11A9440", Offset = "0x11A8040", VA = "0x1811A9440")]
		private void LoadArtMagazineLeavesAsFriend(FriendDataWithNameCard friendData)
		{
		}

		// Token: 0x06018EFD RID: 102141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EFD")]
		[Address(RVA = "0x11AA470", Offset = "0x11A9070", VA = "0x1811AA470")]
		public SocialCardAlbumViewModel()
		{
		}

		// Token: 0x0401EC5C RID: 126044
		[Token(Token = "0x401EC5C")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<CardViewModel> m_cards;

		// Token: 0x0401EC5D RID: 126045
		[Token(Token = "0x401EC5D")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<ArtMagazineLeafCardViewModel> m_tempLeafList;

		// Token: 0x0401EC5F RID: 126047
		[Token(Token = "0x401EC5F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_nameCard;

		// Token: 0x0401EC60 RID: 126048
		[Token(Token = "0x401EC60")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_nameCard;

		// Token: 0x0401EC61 RID: 126049
		[Token(Token = "0x401EC61")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_cards;

		// Token: 0x0401EC62 RID: 126050
		[Token(Token = "0x401EC62")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401EC63 RID: 126051
		[Token(Token = "0x401EC63")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadAsSelf;

		// Token: 0x0401EC64 RID: 126052
		[Token(Token = "0x401EC64")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadAsFriend;

		// Token: 0x0401EC65 RID: 126053
		[Token(Token = "0x401EC65")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadNameCard;

		// Token: 0x0401EC66 RID: 126054
		[Token(Token = "0x401EC66")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LoadArtMagazineLeavesAsSelf;

		// Token: 0x0401EC67 RID: 126055
		[Token(Token = "0x401EC67")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadArtMagazineLeavesAsFriend;

		// Token: 0x0401EC68 RID: 126056
		[Token(Token = "0x401EC68")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
