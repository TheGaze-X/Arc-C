using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B55 RID: 27477
	[Token(Token = "0x2006B55")]
	public class ArchiveCopperInfoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027443 RID: 160835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027443")]
		[Address(RVA = "0x22706B0", Offset = "0x226F2B0", VA = "0x1822706B0")]
		public void Render(CopperItemModel model)
		{
		}

		// Token: 0x06027444 RID: 160836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027444")]
		[Address(RVA = "0x2270FD0", Offset = "0x226FBD0", VA = "0x182270FD0")]
		public ArchiveCopperInfoView()
		{
		}

		// Token: 0x0403794C RID: 227660
		[Token(Token = "0x403794C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color UNATTAIN_COLOR;

		// Token: 0x0403794D RID: 227661
		[Token(Token = "0x403794D")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color DEFAULT_COLOR;

		// Token: 0x0403794E RID: 227662
		[Token(Token = "0x403794E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Bg")]
		private UIAtlasImage _bgLocked;

		// Token: 0x0403794F RID: 227663
		[Token(Token = "0x403794F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Bg")]
		private UIAtlasImage _bgLow;

		// Token: 0x04037950 RID: 227664
		[Token(Token = "0x4037950")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Bg")]
		private UIAtlasImage _bgMid;

		// Token: 0x04037951 RID: 227665
		[Token(Token = "0x4037951")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Bg")]
		private UIAtlasImage _bgHigh;

		// Token: 0x04037952 RID: 227666
		[Token(Token = "0x4037952")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Icon")]
		private GameObject _imgLock;

		// Token: 0x04037953 RID: 227667
		[Token(Token = "0x4037953")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Icon")]
		private ThreeStateToggle _iconToggle;

		// Token: 0x04037954 RID: 227668
		[Token(Token = "0x4037954")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Icon")]
		private Image _iconLucky;

		// Token: 0x04037955 RID: 227669
		[Token(Token = "0x4037955")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Icon")]
		private Image _iconCopper;

		// Token: 0x04037956 RID: 227670
		[Token(Token = "0x4037956")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Icon")]
		private Image _iconGild;

		// Token: 0x04037957 RID: 227671
		[Token(Token = "0x4037957")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Icon")]
		private UIAtlasImage _iconGildBg;

		// Token: 0x04037958 RID: 227672
		[Token(Token = "0x4037958")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Info")]
		private RectTransform _nameLayout;

		// Token: 0x04037959 RID: 227673
		[Token(Token = "0x4037959")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Info")]
		private GameObject _luckyIconTitleHolder;

		// Token: 0x0403795A RID: 227674
		[Token(Token = "0x403795A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Info")]
		private Image _luckyIconTitle;

		// Token: 0x0403795B RID: 227675
		[Token(Token = "0x403795B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Info")]
		private Text _textName;

		// Token: 0x0403795C RID: 227676
		[Token(Token = "0x403795C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Info")]
		private Text _textType;

		// Token: 0x0403795D RID: 227677
		[Token(Token = "0x403795D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Info")]
		private Text _textDescFirst;

		// Token: 0x0403795E RID: 227678
		[Token(Token = "0x403795E")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Info")]
		private Text _textDescSec;

		// Token: 0x0403795F RID: 227679
		[Token(Token = "0x403795F")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Poem")]
		private GameObject _panelPoem;

		// Token: 0x04037960 RID: 227680
		[Token(Token = "0x4037960")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Poem")]
		private Text[] _poems;

		// Token: 0x04037961 RID: 227681
		[Token(Token = "0x4037961")]
		[FieldOffset(Offset = "0xB0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04037962 RID: 227682
		[Token(Token = "0x4037962")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037963 RID: 227683
		[Token(Token = "0x4037963")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
