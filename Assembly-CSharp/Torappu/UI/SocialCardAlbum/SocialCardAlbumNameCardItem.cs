using System;
using Il2CppDummyDll;
using Torappu.UI.Friend;
using UnityEngine;
using XLua;

namespace Torappu.UI.SocialCardAlbum
{
	// Token: 0x02003EB2 RID: 16050
	[Token(Token = "0x2003EB2")]
	public class SocialCardAlbumNameCardItem : SocialCardAlbumCardItemBase
	{
		// Token: 0x17003B6F RID: 15215
		// (get) Token: 0x06018E9D RID: 102045 RVA: 0x0009C630 File Offset: 0x0009A830
		[Token(Token = "0x17003B6F")]
		public override CardType cardType
		{
			[Token(Token = "0x6018E9D")]
			[Address(RVA = "0x11A5A90", Offset = "0x11A4690", VA = "0x1811A5A90", Slot = "4")]
			get
			{
				return CardType.NAME_CARD;
			}
		}

		// Token: 0x06018E9E RID: 102046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E9E")]
		[Address(RVA = "0x11A5690", Offset = "0x11A4290", VA = "0x1811A5690", Slot = "5")]
		public override void Render(CardViewModel card)
		{
		}

		// Token: 0x06018E9F RID: 102047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E9F")]
		[Address(RVA = "0x11A57C0", Offset = "0x11A43C0", VA = "0x1811A57C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018EA0 RID: 102048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EA0")]
		[Address(RVA = "0x11A5A30", Offset = "0x11A4630", VA = "0x1811A5A30")]
		public SocialCardAlbumNameCardItem()
		{
		}

		// Token: 0x0401EBDC RID: 125916
		[Token(Token = "0x401EBDC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0401EBDD RID: 125917
		[Token(Token = "0x401EBDD")]
		[FieldOffset(Offset = "0x28")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401EBDE RID: 125918
		[Token(Token = "0x401EBDE")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x0401EBDF RID: 125919
		[Token(Token = "0x401EBDF")]
		[FieldOffset(Offset = "0x40")]
		private NameCardV2Property m_property;

		// Token: 0x0401EBE0 RID: 125920
		[Token(Token = "0x401EBE0")]
		[FieldOffset(Offset = "0x48")]
		private NameCardV2View m_nameCardView;

		// Token: 0x0401EBE1 RID: 125921
		[Token(Token = "0x401EBE1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cardType;

		// Token: 0x0401EBE2 RID: 125922
		[Token(Token = "0x401EBE2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401EBE3 RID: 125923
		[Token(Token = "0x401EBE3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401EBE4 RID: 125924
		[Token(Token = "0x401EBE4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
