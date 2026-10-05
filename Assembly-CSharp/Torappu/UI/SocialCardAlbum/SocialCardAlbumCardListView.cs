using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SocialCardAlbum
{
	// Token: 0x02003EAF RID: 16047
	[Token(Token = "0x2003EAF")]
	public class SocialCardAlbumCardListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018E89 RID: 102025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E89")]
		[Address(RVA = "0x1183C60", Offset = "0x1182860", VA = "0x181183C60")]
		public void Render(SocialCardAlbumViewModel model)
		{
		}

		// Token: 0x06018E8A RID: 102026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E8A")]
		[Address(RVA = "0x11841F0", Offset = "0x1182DF0", VA = "0x1811841F0")]
		private void _EnsurePrefabDict()
		{
		}

		// Token: 0x06018E8B RID: 102027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E8B")]
		[Address(RVA = "0x1184670", Offset = "0x1183270", VA = "0x181184670")]
		private void _RenderCardView(int index, CardViewModel cardModel, out SocialCardAlbumCardItemBase cardInstance)
		{
		}

		// Token: 0x06018E8C RID: 102028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018E8C")]
		[Address(RVA = "0x11843F0", Offset = "0x1182FF0", VA = "0x1811843F0")]
		private SocialCardAlbumCardItemBase _PickAndInstanceForCard(CardViewModel cardModel)
		{
			return null;
		}

		// Token: 0x06018E8D RID: 102029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E8D")]
		[Address(RVA = "0x1183B10", Offset = "0x1182710", VA = "0x181183B10")]
		private void OnEnable()
		{
		}

		// Token: 0x06018E8E RID: 102030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E8E")]
		[Address(RVA = "0x1183A30", Offset = "0x1182630", VA = "0x181183A30")]
		private void OnDisable()
		{
		}

		// Token: 0x06018E8F RID: 102031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E8F")]
		[Address(RVA = "0x1184350", Offset = "0x1182F50", VA = "0x181184350")]
		private void _NotifyExposureTracker(Vector2 pos)
		{
		}

		// Token: 0x06018E90 RID: 102032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E90")]
		[Address(RVA = "0x11848F0", Offset = "0x11834F0", VA = "0x1811848F0")]
		public SocialCardAlbumCardListView()
		{
		}

		// Token: 0x0401EBBD RID: 125885
		[Token(Token = "0x401EBBD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _cardContainer;

		// Token: 0x0401EBBE RID: 125886
		[Token(Token = "0x401EBBE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private HorizontalLayoutGroup _cardLayoutGroup;

		// Token: 0x0401EBBF RID: 125887
		[Token(Token = "0x401EBBF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ScrollRect _cardScrollRect;

		// Token: 0x0401EBC0 RID: 125888
		[Token(Token = "0x401EBC0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ScrollViewMoveToughPager _cardScrollPager;

		// Token: 0x0401EBC1 RID: 125889
		[Token(Token = "0x401EBC1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SocialCardAlbumCardItemBase[] _cardPrefabs;

		// Token: 0x0401EBC2 RID: 125890
		[Token(Token = "0x401EBC2")]
		[FieldOffset(Offset = "0x40")]
		private EnumIntDictionary<CardType, SocialCardAlbumCardItemBase> m_cardPrefabDict;

		// Token: 0x0401EBC3 RID: 125891
		[Token(Token = "0x401EBC3")]
		[FieldOffset(Offset = "0x48")]
		private List<SocialCardAlbumCardItemBase> m_cardList;

		// Token: 0x0401EBC4 RID: 125892
		[Token(Token = "0x401EBC4")]
		[FieldOffset(Offset = "0x50")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401EBC5 RID: 125893
		[Token(Token = "0x401EBC5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401EBC6 RID: 125894
		[Token(Token = "0x401EBC6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsurePrefabDict;

		// Token: 0x0401EBC7 RID: 125895
		[Token(Token = "0x401EBC7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderCardView;

		// Token: 0x0401EBC8 RID: 125896
		[Token(Token = "0x401EBC8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PickAndInstanceForCard;

		// Token: 0x0401EBC9 RID: 125897
		[Token(Token = "0x401EBC9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401EBCA RID: 125898
		[Token(Token = "0x401EBCA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0401EBCB RID: 125899
		[Token(Token = "0x401EBCB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__NotifyExposureTracker;

		// Token: 0x0401EBCC RID: 125900
		[Token(Token = "0x401EBCC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
